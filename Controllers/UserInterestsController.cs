using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GameInterestApi.Data;
using GameInterestApi.Models;

namespace GameInterestApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserInterestsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public UserInterestsController(AppDbContext context)
        {
            _context = context;
        }

        //Get: api/UserInterests
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserInterest>>> GetUsers(string? favoriteClass){
            var query = _context.UserInterests.AsQueryable();

            if(!string.IsNullOrEmpty(favoriteClass))
            {
                query = query.Where(u=> u.FavoriteClass == favoriteClass);
            }

            return await query.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<UserInterest>> GetUser(int id)
        {
            var user = await _context.UserInterests.FindAsync(id);

            if (user==null)
                return NotFound();

            return user;
        }

        [HttpPost]
        public async Task<ActionResult<UserInterest>> CreateUser(UserInterest user)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            _context.UserInterests.Add(user);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetUser), new {id=user.Id}, user);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateUser(int id, UserInterest user)
        {
            var exists = await _context.UserInterests.AnyAsync(u=> u.Id == id);
            if(!exists){
                return NotFound();
            }
            if(id!= user.Id){
                return BadRequest();
            }

            _context.Entry(user).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            var user = await _context.UserInterests.FindAsync(id);

            if(user==null){
                return NotFound();
            }

            _context.UserInterests.Remove(user);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
    
}
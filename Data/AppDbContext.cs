using Microsoft.EntityFrameworkCore;
using GameInterestApi.Models;

namespace GameInterestApi.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<UserInterest> UserInterests{get; set;}
    }
}   
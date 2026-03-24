using System.ComponentModel.DataAnnotations;


namespace GameInterestApi.Models
{
    public class UserInterest
    {
        public int Id{get; set;}

        [Required]
        public string Username {get; set;}= string.Empty;
        
        [Required]
        [EmailAddress]
        public string Email { get;set;} = string.Empty;
        
        [Required]
        public string FavoriteClass{get;set;} =  string.Empty;
        
        public DateTime CreatedAt{get;set;} = DateTime.Now;
    }
}
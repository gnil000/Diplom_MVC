using Microsoft.AspNetCore.Identity;

namespace Diplom_MVC.Models
{
    public class User : IdentityUser
    {
        //public string FirstName {  get; set; }  
        //public string LastName { get; set; }
        public int Year { get; set; }
        public List<Comment> Comments { get; set; } = new();
        public List<AnswerOnComment> AnswersOnComments { get; set; } = new();
    }
}

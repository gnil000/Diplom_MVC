using Microsoft.AspNetCore.Identity;

namespace Diplom_MVC.Models
{
    public class User : IdentityUser
    {
        public int Year { get; set; }
    }
}

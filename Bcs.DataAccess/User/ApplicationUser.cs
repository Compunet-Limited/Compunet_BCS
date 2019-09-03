using Microsoft.AspNetCore.Identity;

namespace Bcs.DataAccess.User
{
    public class ApplicationUser : IdentityUser
    {
        public int SchoolId { get; set; }
        public bool DisableLogin { get; set; }
    }
}

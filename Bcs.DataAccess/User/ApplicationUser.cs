using Microsoft.AspNetCore.Identity;

namespace Bcs.DataAccess.User
{
    public class ApplicationUser : IdentityUser
    {
        public int StudentId { get; set; }
        public int StaffId { get; set; }
        public bool DisableLogin { get; set; }
    }
}

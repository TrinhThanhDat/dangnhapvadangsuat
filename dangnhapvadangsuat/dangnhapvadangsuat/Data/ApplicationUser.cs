using Microsoft.AspNetCore.Identity;

namespace dangnhapvadangsuat.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public DateOnly? DateOfbirth { get; set; }
    }

}

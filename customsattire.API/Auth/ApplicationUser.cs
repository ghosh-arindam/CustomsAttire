using Microsoft.AspNetCore.Identity;

namespace CustomsAttire.API.Auth
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; } = default!;
        public string LastName { get; set; } = default!;
    }
}

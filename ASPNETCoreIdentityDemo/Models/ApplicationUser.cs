using Microsoft.AspNetCore.Identity;

namespace ASPNETCoreIdentityDemo.Models
{
    public class ApplicationUser : IdentityUser
    {
        //FirstName and LastName added to IdentityCoreDB AspNetUsers Table
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
    }
}

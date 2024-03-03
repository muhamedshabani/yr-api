using Microsoft.AspNetCore.Identity;

namespace yr_api.Models.Entities;

public class ApplicationUser : IdentityUser
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public bool IsActive { get; set; } = false;
    public DateTime? FirstLogin { get; set; }
    public DateTime? LastLogin { get; set; }
    public string? OneTimePassword { get; set; }
    public string? ProfilePicture { get; set; }

    public List<Cabinet> Cabinets { get; set; }
}

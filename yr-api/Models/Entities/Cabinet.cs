using System.ComponentModel.DataAnnotations.Schema;

namespace yr_api.Models.Entities;

public class Cabinet : Base
{
    public string? Title { get; set; }
    public string? Emoji { get; set; }

    // Files
    public ICollection<File> Files { get; set; }

    // User
    [ForeignKey(nameof(User))]
    public string UserId { get; set; }
    public virtual ApplicationUser User { get; set; }

    // Styles
    [ForeignKey(nameof(Styles))]
    public Guid StylesId { get; set; }
    public virtual Style Styles { get; set; }
}
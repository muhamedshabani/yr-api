using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using yr_api.Models.Enums;

namespace yr_api.Models.Entities;

public class Style
{
    [Key]
    public Guid Id { get; set; }
    public EFontType? FontFamily { get; set; }
    public EColorScheme? ColorScheme { get; set; }
    public int? FontSize { get; set; }

    public virtual Cabinet Cabinet { get; set; }
}
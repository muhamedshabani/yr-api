using System.Text.Json.Serialization;

namespace yr_api.Models.Enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum EFontType
{
    None = 0,
    Arial,
    TimesNewRoman,
    Courier,
    Helvetica,
    Garamond,
    Candara,
    Geneva,
    Calibri
}

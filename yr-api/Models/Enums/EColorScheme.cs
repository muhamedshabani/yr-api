using System.Text.Json.Serialization;

namespace yr_api.Models.Enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum EColorScheme
{
    BlackOnWhitesmoke = 0,
    WhitesmokeOnBlack,
    WhitesmokeOnDarkGray,
    WhitesmokeOnDarkGreen,
    WhitesmokeOnDarkBlue,
    DarkBlueOnWhitesmoke,
    DarkGreenOnPeach,
    // TODO: Add more schemes
}

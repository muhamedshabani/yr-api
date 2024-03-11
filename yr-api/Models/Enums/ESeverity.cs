using System.Text.Json.Serialization;

namespace yr_api.Models.Enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum ESeverity
{
    None,
    Low,
    Medium,
    Major,
    Critical
}


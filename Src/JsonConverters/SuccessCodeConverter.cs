using System.Text.Json;
using System.Text.Json.Serialization;

namespace JsonConverters;

public class SuccessCodeConverter : JsonConverter<bool>
{
    public override bool Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        return reader.TokenType == JsonTokenType.String ? bool.Parse(reader.GetString() ?? "false") : reader.GetBoolean();
    }

    public override void Write(Utf8JsonWriter writer, bool value, JsonSerializerOptions options)
    {
    }
}
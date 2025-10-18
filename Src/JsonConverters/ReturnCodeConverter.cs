using System.Text.Json;
using System.Text.Json.Serialization;

namespace JsonConverters
{
    public class ReturnCodeConverter : JsonConverter<int>
    {
        public override int Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return reader.TokenType == JsonTokenType.String ? int.Parse(reader.GetString() ?? "0") : reader.GetInt32();
        }

        public override void Write(Utf8JsonWriter writer, int value, JsonSerializerOptions options)
        {
            writer.WriteNumberValue(value);
        }
    }
}
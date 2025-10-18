using System.Text.Json;
using JsonConverters;

namespace JsonSerialization.Tests;

public abstract class JsonConverterTestBase
{
    protected readonly JsonSerializerOptions Options = new JsonSerializerOptions
    {
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        Converters =
        {
            new ReturnCodeConverter(),
            new SuccessCodeConverter()
        }
    };
}

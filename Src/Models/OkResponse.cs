using System.Text.Json.Serialization;
using JsonConverters;

namespace Models;

public abstract class OkResponse<TData>
{
    public TData? Data { get; set; }
    public string? Message { get; set; }

    [JsonConverter(typeof(ReturnCodeConverter))]
    public int ReturnCode { get; set; }

    [JsonConverter(typeof(SuccessCodeConverter))]
    public bool Success { get; set; }
}

using System.Text.Json.Serialization;

namespace Fina.Core.Responses;

public class Response<T>
{
    private int _code = Configuration.DefaultStatusCode;

    [JsonIgnore]
    public bool IsSuccess => _code >= 200 && _code <= 299;

    public string? Message { get; set; }
    public T? Data { get; set; }

    [JsonConstructor]
    public Response() => _code = Configuration.DefaultStatusCode;

    public Response(T? data, 
        int code = Configuration.DefaultStatusCode,
        string? message = null)
    {
        Data = data;
        _code = code;
        Message = message;
    }
}
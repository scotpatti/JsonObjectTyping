namespace JsonObjectTyping.JsonSchema;
using Newtonsoft.Json;

public class ChatMessage : JsonBase
{
    /// <summary>
    /// Message content
    /// </summary>
    [JsonProperty("Message", NullValueHandling = NullValueHandling.Ignore)]
    public string Message { get; set; } = string.Empty;

    /// <summary>
    /// Sender of the message
    /// </summary>
    [JsonProperty("Sender", NullValueHandling = NullValueHandling.Ignore)]
    public string Sender { get; set; } = string.Empty;

    public override string ToString()
    {
        return $"Type: {Type}, Sender: {Sender}, Message: {Message}";
    }
}

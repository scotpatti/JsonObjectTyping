namespace JsonObjectTyping.JsonSchema;

using Newtonsoft.Json;

public class ChatCommand : JsonBase
{
    /// <summary>
    /// Command without parameters
    /// </summary>
    [JsonProperty("Command")]
    public string Command { get; set; } = string.Empty;

    /// <summary>
    /// Command parameters
    /// </summary>
    [JsonProperty("Parameters")]
    public string[] Parameters { get; set; } = Array.Empty<string>();

    /// <summary>
    /// Sender of the message
    /// </summary>
    [JsonProperty("Sender")]
    public string Sender { get; set; } = string.Empty;

    public override string ToString()
    {
        return $"Type: {Type}, Sender: {Sender}, Command: {Command}, Parameters: {string.Join(", ", Parameters)}";
    }
}
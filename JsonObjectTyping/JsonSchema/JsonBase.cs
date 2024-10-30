using Newtonsoft.Json;

namespace JsonObjectTyping.JsonSchema
{
    public class JsonBase
    {
        [JsonProperty("Type")]
        public string Type { get; set; } = string.Empty;
    }
}

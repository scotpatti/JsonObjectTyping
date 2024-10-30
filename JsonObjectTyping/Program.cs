using JsonObjectTyping;
using Newtonsoft.Json;
using JsonObjectTyping.JsonSchema;
using Newtonsoft.Json.Schema;

// Uncomment one of the following lines only!
string sampleMessage = File.ReadAllText("JsonSchema/MessageSample.json");
//string sampleMessage = File.ReadAllText("JsonSchema/CommandSample.json");

JSchema MessageSchema = JSchema.Parse(File.ReadAllText("JsonSchema/Message.json"));
JSchema CommandSchema = JSchema.Parse(File.ReadAllText("JsonSchema/Command.json"));

JsonBase? json = JsonConvert.DeserializeObject<JsonBase>(sampleMessage);

if (json == null) return;
switch (json.Type)
{
    case "MSG": Handle<ChatMessage>(sampleMessage, MessageSchema); break;
    case "CMD": Handle<ChatCommand>(sampleMessage, CommandSchema); break;
}

void Handle<T>(string json, JSchema schema)
{
    (bool flag, T? msg, string errs) = JsonSchemaValidator.ValidateParseJson<T>(json, schema);
    if (flag)
    {
        Console.WriteLine(msg?.ToString());
    }
}
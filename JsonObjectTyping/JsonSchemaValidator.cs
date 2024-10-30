using Newtonsoft.Json.Schema;
using Newtonsoft.Json.Linq;
using System.Text;
using JsonObjectTyping.JsonSchema;
using Newtonsoft.Json;

namespace JsonObjectTyping
{
    internal class JsonSchemaValidator
    {
        public static (bool, T?, string) ValidateParseJson<T>(string json, JSchema schema)
        {
            bool success = true;
            StringBuilder errs = new StringBuilder();
            try
            {
                JObject jobj = JObject.Parse(json);

                if (!jobj.IsValid(schema, out IList<ValidationError> errorMessages))
                {
                    success = false;
                    foreach (var error in errorMessages)
                    {
                        errs.AppendLine($"Error: {error.Message} at: {error.Path}");
                    }
                    return (success, default, errs.ToString());
                }
                T? obj = JsonConvert.DeserializeObject<T>(json);
                return (success, obj, errs.ToString());
            }
            catch (Exception)
            {
                return (false, default, "Invalid JSON - Validate in JsonSchemaValidator did not find valid JSON could not verify schema.");
            }

        }
    }
}

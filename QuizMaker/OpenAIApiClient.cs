using System;
using System.IO;
using System.Net;
using System.Xml.Linq;
using Newtonsoft.Json.Linq;
using System.IO;
using YamlDotNet.Serialization;
using System.Collections.Generic;

public class OpenAIGptClient
{ 

    private const string GptEndpointUrl = "https://api.openai.com/v1/chat/completions";

    public string SendApiRequest(string message)
    {
        // Load the YAML configuration
        var deserializer = new DeserializerBuilder().Build();
        var filePath = Path.Combine(Directory.GetCurrentDirectory(), "..", "..", "config.yaml");
        var yamlConfig = deserializer.Deserialize<Dictionary<string, string>>(File.ReadAllText(filePath));


        // Access the value
        string GptApiKey = yamlConfig["key"];

        string result = string.Empty;

        try
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(GptEndpointUrl);
            request.Method = "POST";
            request.Headers.Add("Authorization", $"Bearer {GptApiKey}");
            request.ContentType = "application/json";

            string requestBody = $"{{ \"model\": \"gpt-3.5-turbo\", \"messages\": [{{ \"role\": \"user\", \"content\": \"{message}\" }}], \"temperature\": 0.7 }}";

            using (StreamWriter writer = new StreamWriter(request.GetRequestStream()))
            {
                writer.Write(requestBody);
                writer.Flush();
                writer.Close();
            }

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            {
                using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                {
                    result = reader.ReadToEnd();
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }

        return result;
    }
    public string ExtractContentFromResponse(string response)
    {
        string content = string.Empty;

        try
        {
            JObject responseObject = JObject.Parse(response);
            JArray choices = responseObject["choices"] as JArray;
            if (choices != null && choices.Count > 0)
            {
                content = choices[0]["message"]["content"].ToString();
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }

        return content;
    }
}

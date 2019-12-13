using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Json
{
    class Program
    {
        static void Main(string[] args)
        {
            String json = "";

            try
            {
                json = File.ReadAllText(@"colors.json", Encoding.Default);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                
            }
            Console.WriteLine(json);

            JsonTextReader reader = new JsonTextReader(new StringReader(json));

            while (reader.Read())
            {
                Console.WriteLine($"{reader.TokenType},{reader.ValueType},{reader.Value}");
            }

            JObject colors = JObject.Parse(json);

            var jsColors = colors.SelectToken("colors");

            Console.WriteLine(jsColors[0]["code"]["rgba"]);

            var codes = colors.SelectTokens("$..code");

            var reds = colors.SelectTokens("$.colors[?(@.color=='red')]");

            Console.WriteLine(codes.Count());
            Console.WriteLine(reds.Count());

            Console.ReadKey();
        }
    }
}

using BankReconciliation.Infrastructure.Corsscuting.Parser.Contracts;
using Microsoft.AspNetCore.Http;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace BankReconciliation.Infrastructure.Corsscuting.Parser
{
    public class OFXParser
    {
        public static async Task<ExtractOFX> Parse(IFormFile file)
        {
            return await new OFXParser().GenerateExtract(file);
        }

        private async Task<ExtractOFX> GenerateExtract(IFormFile file)
        {
            string result = await GetOFXXmlString(file);
            ExtractOFX extractOFX = ConvertToExtract(result);
            extractOFX.Name = file.FileName;

            return extractOFX;
        }

        /// <summary>
        /// Converts OFX File into string xml formatted
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        private static async Task<string> GetOFXXmlString(IFormFile file)
        {
            var result = new StringBuilder();
            using (var reader = new StreamReader(file.OpenReadStream()))
            {
                while (!reader.EndOfStream)
                {
                    var line = await reader.ReadLineAsync();

                    if (line.StartsWith("<"))
                    {
                        if (!line.EndsWith(">"))
                        {
                            // identifies end of tag name in the opened tag
                            var indexOf = line.IndexOf(">");

                            // gets tag name (with '<' and '>')
                            var tag = line.Substring(0, ++indexOf);

                            // add close tag
                            line = line + tag.Insert(1, "/");
                        }

                        result.AppendLine(line);
                    }
                }
            }

            return result.ToString();
        }

        /// <summary>
        /// Converts string to xml and then convert to Extract
        /// </summary>
        /// <param name="result"></param>
        /// <returns></returns>
        private static ExtractOFX ConvertToExtract(string result)
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(result);

            XmlReader docReader = new XmlNodeReader(doc);
            XmlSerializer t = new XmlSerializer(typeof(ExtractOFX));
            ExtractOFX extractOFX = (ExtractOFX)t.Deserialize(docReader);
            return extractOFX;
        }
    }
}

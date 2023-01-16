using System.IO;
using System.Text;
using System.Xml;

namespace SoapServicesCore.Logging
{
    public static class FormatSoapBody
    {
        public static string FormatXml(this string xmlString)
        {
            var memoryStream = new MemoryStream();
            var writer = new XmlTextWriter(memoryStream, Encoding.Unicode);
            var document = new XmlDocument();

            string result;
            try
            {
                // Load the XmlDocument with the XML.
                document.LoadXml(xmlString);

                writer.Formatting = Formatting.Indented;

                // Write the XML into a formatting XmlTextWriter
                document.WriteContentTo(writer);
                writer.Flush();
                memoryStream.Flush();

                // Have to rewind the MemoryStream in order to read
                // its contents.
                memoryStream.Position = 0;

                // Read MemoryStream contents into a StreamReader.
                StreamReader sReader = new StreamReader(memoryStream);

                // Extract the text from the StreamReader.
                result = sReader.ReadToEnd();
            }
            catch (XmlException)
            {
                return xmlString;
            }

            memoryStream.Close();
            writer.Close();

            return result;
        }
    }
}

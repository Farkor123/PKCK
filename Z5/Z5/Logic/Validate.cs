using System;
using System.Xml;
using System.Xml.Schema;

namespace Logic
{
    public class Validate
    {
        public static void ValidateXml(string xmlPath, string[] schemaPaths, Action<string> XMLValidateCallback)
        {


            XmlReaderSettings settings = new XmlReaderSettings();

            try
            {
                foreach (string schemaPath in schemaPaths)
                {

                    settings.Schemas.Add(null, schemaPath);
                }

                settings.ValidationEventHandler += new ValidationEventHandler(
                    (sender, args) => XMLValidateCallback(args.Message)
                );
            }
            catch (Exception e)
            {
                XMLValidateCallback("Invalid schema " + e.Message);
            }


            XmlReader reader = XmlReader.Create(xmlPath, settings);
            while (reader.Read()) { }
            reader.Close();
            XMLValidateCallback("Valid schema and XML");

        }
    }
}

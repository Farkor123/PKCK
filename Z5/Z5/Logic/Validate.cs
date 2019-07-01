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
                settings = new XmlReaderSettings();
                settings.ValidationType = ValidationType.Schema;
                settings.ValidationFlags |= XmlSchemaValidationFlags.ProcessSchemaLocation;
                settings.ValidationFlags |= XmlSchemaValidationFlags.ReportValidationWarnings;
                foreach (string schemaPath in schemaPaths)
                {

                    settings.Schemas.Add(null, schemaPath);
                }
                /*
                settings.ValidationEventHandler += new ValidationEventHandler(
                    (sender, args) => XMLValidateCallback(args.Message)
                );*/

                settings.Schemas.Compile();
            }
            catch (Exception e)
            {
                XMLValidateCallback("Invalid schema " + e.Message);
                return;
            }


            XmlReader reader = XmlReader.Create(xmlPath, settings);
            try
            {
                while (reader.Read()) { }
            }
            catch (Exception e)
            {
                XMLValidateCallback("Invalid xml:  " + e.Message);
                return;
            }

            reader.Close();
            XMLValidateCallback("Valid schema and XML");

        }
    }
}

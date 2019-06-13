using Model;
using System.IO;
using System.Xml.Serialization;

namespace Logic
{
    public class Serialization
    {
        public static books DeserializeFile(string filename)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(books));

            using (Stream reader = new FileStream(filename, FileMode.Open))
            {
                return (books)serializer.Deserialize(reader);
            }
        }

        public static void SerializeToFile(string filename, books root)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(books));
            TextWriter writer = new StreamWriter(filename);

            serializer.Serialize(writer, root);
            writer.Close();
        }
    }
}

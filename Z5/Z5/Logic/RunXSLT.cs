using System.Xml;
using System.Xml.XPath;
using System.Xml.Xsl;

namespace Logic
{
    public class RunXSLT
    {
        public static void Transform(string inXML, string outFile, string transformFile)
        {
            XPathDocument myXPathDoc = new XPathDocument(inXML);
            XslCompiledTransform myXslTrans = new XslCompiledTransform();
            myXslTrans.Load(transformFile);
            XmlTextWriter myWriter = new XmlTextWriter(outFile, null);
            myXslTrans.Transform(myXPathDoc, null, myWriter);
        }
    }
}

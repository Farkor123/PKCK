using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://publisher.example.com")]
    public partial class publishersListPublisher
    {

        private string publisherNameField;

        private string publisherIDField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "")]
        public string publisherName
        {
            get
            {
                return this.publisherNameField;
            }
            set
            {
                this.publisherNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string publisherID
        {
            get
            {
                return this.publisherIDField;
            }
            set
            {
                this.publisherIDField = value;
            }
        }
    }
}

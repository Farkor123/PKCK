using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://publisher.example.com")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://publisher.example.com", IsNullable = false)]
    public partial class publishersList
    {

        private publishersListPublisher[] publisherField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("publisher")]
        public publishersListPublisher[] publisher
        {
            get
            {
                return this.publisherField;
            }
            set
            {
                this.publisherField = value;
            }
        }
    }
}

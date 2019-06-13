using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class books
    {

        private technicalData technicalDataField;

        private writersListWriter[] writersListField;

        private publishersListPublisher[] publishersListField;

        private booksBook[] booksListField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://data.example.com")]
        public technicalData technicalData
        {
            get
            {
                return this.technicalDataField;
            }
            set
            {
                this.technicalDataField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Namespace = "http://writer.example.com")]
        [System.Xml.Serialization.XmlArrayItemAttribute("writer", IsNullable = false)]
        public writersListWriter[] writersList
        {
            get
            {
                return this.writersListField;
            }
            set
            {
                this.writersListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Namespace = "http://publisher.example.com")]
        [System.Xml.Serialization.XmlArrayItemAttribute("publisher", IsNullable = false)]
        public publishersListPublisher[] publishersList
        {
            get
            {
                return this.publishersListField;
            }
            set
            {
                this.publishersListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("book", IsNullable = false)]
        public booksBook[] booksList
        {
            get
            {
                return this.booksListField;
            }
            set
            {
                this.booksListField = value;
            }
        }
    }
}

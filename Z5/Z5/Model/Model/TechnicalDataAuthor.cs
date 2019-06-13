using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://data.example.com")]
    public partial class technicalDataAuthor
    {

        private string nameField;

        private string surnameField;

        private uint authorIndexNumberField;

        private string authorIDField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "")]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "")]
        public string surname
        {
            get
            {
                return this.surnameField;
            }
            set
            {
                this.surnameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "")]
        public uint authorIndexNumber
        {
            get
            {
                return this.authorIndexNumberField;
            }
            set
            {
                this.authorIndexNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string authorID
        {
            get
            {
                return this.authorIDField;
            }
            set
            {
                this.authorIDField = value;
            }
        }
    }
}

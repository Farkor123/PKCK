using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://writer.example.com")]
    public partial class writersListWriter
    {

        private string nameField;

        private string surnameField;

        private ushort writerBirthYearField;

        private string writerIDField;

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
        public ushort writerBirthYear
        {
            get
            {
                return this.writerBirthYearField;
            }
            set
            {
                this.writerBirthYearField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string writerID
        {
            get
            {
                return this.writerIDField;
            }
            set
            {
                this.writerIDField = value;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://data.example.com")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://data.example.com", IsNullable = false)]
    public partial class technicalData
    {

        private technicalDataAuthor[] authorField;

        private technicalDataLastModificationDate lastModificationDateField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("author")]
        public technicalDataAuthor[] author
        {
            get
            {
                return this.authorField;
            }
            set
            {
                this.authorField = value;
            }
        }

        /// <remarks/>
        public technicalDataLastModificationDate lastModificationDate
        {
            get
            {
                return this.lastModificationDateField;
            }
            set
            {
                this.lastModificationDateField = value;
            }
        }
    }
}

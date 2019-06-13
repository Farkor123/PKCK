using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://data.example.com")]
    public partial class technicalDataLastModificationDate
    {

        private string lastModificationDayField;

        private string lastModificationMonthField;

        private ushort lastModificationYearField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "")]
        public string lastModificationDay
        {
            get
            {
                return this.lastModificationDayField;
            }
            set
            {
                this.lastModificationDayField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "")]
        public string lastModificationMonth
        {
            get
            {
                return this.lastModificationMonthField;
            }
            set
            {
                this.lastModificationMonthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "")]
        public ushort lastModificationYear
        {
            get
            {
                return this.lastModificationYearField;
            }
            set
            {
                this.lastModificationYearField = value;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://writer.example.com")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://writer.example.com", IsNullable = false)]
    public partial class writersList
    {

        private writersListWriter[] writerField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("writer")]
        public writersListWriter[] writer
        {
            get
            {
                return this.writerField;
            }
            set
            {
                this.writerField = value;
            }
        }
    }
}

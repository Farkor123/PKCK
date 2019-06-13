using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class booksBookBookWriter
    {

        private string writerIDField;

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

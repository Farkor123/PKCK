using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class booksBookBookPublisher
    {

        private string publisherIDField;

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

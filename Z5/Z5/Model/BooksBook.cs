using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class booksBook
    {

        private booksBookBookWriter bookWriterField;

        private booksBookBookPublisher bookPublisherField;

        private string bookTitleField;

        private ulong bookIsbnField;

        private ushort bookDateOfPublishField;

        private decimal bookPriceField;

        private string bookIDField;

        /// <remarks/>
        public booksBookBookWriter bookWriter
        {
            get
            {
                return this.bookWriterField;
            }
            set
            {
                this.bookWriterField = value;
            }
        }

        /// <remarks/>
        public booksBookBookPublisher bookPublisher
        {
            get
            {
                return this.bookPublisherField;
            }
            set
            {
                this.bookPublisherField = value;
            }
        }

        /// <remarks/>
        public string bookTitle
        {
            get
            {
                return this.bookTitleField;
            }
            set
            {
                this.bookTitleField = value;
            }
        }

        /// <remarks/>
        public ulong bookIsbn
        {
            get
            {
                return this.bookIsbnField;
            }
            set
            {
                this.bookIsbnField = value;
            }
        }

        /// <remarks/>
        public ushort bookDateOfPublish
        {
            get
            {
                return this.bookDateOfPublishField;
            }
            set
            {
                this.bookDateOfPublishField = value;
            }
        }

        /// <remarks/>
        public decimal bookPrice
        {
            get
            {
                return this.bookPriceField;
            }
            set
            {
                this.bookPriceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string bookID
        {
            get
            {
                return this.bookIDField;
            }
            set
            {
                this.bookIDField = value;
            }
        }
    }
}

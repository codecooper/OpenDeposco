//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// This code was generated by XmlSchemaClassGenerator version 2.1.954.0
namespace BillingInvoice
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.954.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("BillingInvoiceCollection", Namespace="http://integration.deposco.com/billinginvoice")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("billingInvoices", Namespace="http://integration.deposco.com/billinginvoice")]
    public partial class BillingInvoiceCollection
    {
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<BillingInvoiceType> _billingInvoice;
        
        [System.Xml.Serialization.XmlElementAttribute("billingInvoice", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public System.Collections.ObjectModel.Collection<BillingInvoiceType> BillingInvoice
        {
            get
            {
                return _billingInvoice;
            }
            private set
            {
                _billingInvoice = value;
            }
        }
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BillingInvoiceSpecified
        {
            get
            {
                return (this.BillingInvoice.Count != 0);
            }
        }
        
        /// <summary>
        /// </summary>
        public BillingInvoiceCollection()
        {
            this._billingInvoice = new System.Collections.ObjectModel.Collection<BillingInvoiceType>();
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.954.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("BillingInvoiceType", Namespace="http://integration.deposco.com/billinginvoice")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class BillingInvoiceType
    {
        
        [System.Xml.Serialization.XmlElementAttribute("businessUnit", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string BusinessUnit { get; set; }
        
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("number", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Number { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private string _status = "New";
        
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("status", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Status
        {
            get
            {
                return _status;
            }
            set
            {
                _status = value;
            }
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("billingStartDateTime", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="dateTime")]
        public System.DateTime BillingStartDateTimeValue { get; set; }
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool BillingStartDateTimeValueSpecified { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<System.DateTime> BillingStartDateTime
        {
            get
            {
                if (this.BillingStartDateTimeValueSpecified)
                {
                    return this.BillingStartDateTimeValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.BillingStartDateTimeValue = value.GetValueOrDefault();
                this.BillingStartDateTimeValueSpecified = value.HasValue;
            }
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("billingEndDateTime", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="dateTime")]
        public System.DateTime BillingEndDateTimeValue { get; set; }
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool BillingEndDateTimeValueSpecified { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<System.DateTime> BillingEndDateTime
        {
            get
            {
                if (this.BillingEndDateTimeValueSpecified)
                {
                    return this.BillingEndDateTimeValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.BillingEndDateTimeValue = value.GetValueOrDefault();
                this.BillingEndDateTimeValueSpecified = value.HasValue;
            }
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("createdDateTime", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="dateTime")]
        public System.DateTime CreatedDateTimeValue { get; set; }
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool CreatedDateTimeValueSpecified { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<System.DateTime> CreatedDateTime
        {
            get
            {
                if (this.CreatedDateTimeValueSpecified)
                {
                    return this.CreatedDateTimeValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.CreatedDateTimeValue = value.GetValueOrDefault();
                this.CreatedDateTimeValueSpecified = value.HasValue;
            }
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("updatedDateTime", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="dateTime")]
        public System.DateTime UpdatedDateTimeValue { get; set; }
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool UpdatedDateTimeValueSpecified { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<System.DateTime> UpdatedDateTime
        {
            get
            {
                if (this.UpdatedDateTimeValueSpecified)
                {
                    return this.UpdatedDateTimeValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.UpdatedDateTimeValue = value.GetValueOrDefault();
                this.UpdatedDateTimeValueSpecified = value.HasValue;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("createdBy", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string CreatedBy { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("updatedBy", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string UpdatedBy { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<BillingInvoiceLine.BillingInvoiceLineType> _billingInvoiceLines;
        
        [System.Xml.Serialization.XmlArrayAttribute("billingInvoiceLines", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("billingInvoiceLine", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public System.Collections.ObjectModel.Collection<BillingInvoiceLine.BillingInvoiceLineType> BillingInvoiceLines
        {
            get
            {
                return _billingInvoiceLines;
            }
            private set
            {
                _billingInvoiceLines = value;
            }
        }
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BillingInvoiceLinesSpecified
        {
            get
            {
                return (this.BillingInvoiceLines.Count != 0);
            }
        }
        
        /// <summary>
        /// </summary>
        public BillingInvoiceType()
        {
            this._billingInvoiceLines = new System.Collections.ObjectModel.Collection<BillingInvoiceLine.BillingInvoiceLineType>();
        }
    }
}

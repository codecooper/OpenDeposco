//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// This code was generated by XmlSchemaClassGenerator version 2.1.954.0
namespace Invoice
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.954.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("invoiceCollection", Namespace="http://integration.deposco.com/invoice")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("invoices", Namespace="http://integration.deposco.com/invoice")]
    public partial class InvoiceCollection
    {
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<InvoiceType> _invoice;
        
        [System.Xml.Serialization.XmlElementAttribute("invoice", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public System.Collections.ObjectModel.Collection<InvoiceType> Invoice
        {
            get
            {
                return _invoice;
            }
            private set
            {
                _invoice = value;
            }
        }
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool InvoiceSpecified
        {
            get
            {
                return (this.Invoice.Count != 0);
            }
        }
        
        /// <summary>
        /// </summary>
        public InvoiceCollection()
        {
            this._invoice = new System.Collections.ObjectModel.Collection<InvoiceType>();
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.954.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("invoiceType", Namespace="http://integration.deposco.com/invoice")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class InvoiceType
    {
        
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("businessUnit", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string BusinessUnit { get; set; }
        
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("number", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Number { get; set; }
        
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("status", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Status { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("transactionType", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string TransactionType { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("termsType", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string TermsType { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("termsBasis", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string TermsBasis { get; set; }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("termsDiscount", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public double TermsDiscountValue { get; set; }
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool TermsDiscountValueSpecified { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<double> TermsDiscount
        {
            get
            {
                if (this.TermsDiscountValueSpecified)
                {
                    return this.TermsDiscountValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.TermsDiscountValue = value.GetValueOrDefault();
                this.TermsDiscountValueSpecified = value.HasValue;
            }
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("termsDiscountDue", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int TermsDiscountDueValue { get; set; }
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool TermsDiscountDueValueSpecified { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<int> TermsDiscountDue
        {
            get
            {
                if (this.TermsDiscountDueValueSpecified)
                {
                    return this.TermsDiscountDueValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.TermsDiscountDueValue = value.GetValueOrDefault();
                this.TermsDiscountDueValueSpecified = value.HasValue;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("remitAttention", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string RemitAttention { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("remitAddress", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Types.AddressType RemitAddress { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("note", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Note { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("currency", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Currency { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("identificationCode", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string IdentificationCode { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("billToAddress", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Types.AddressType BillToAddress { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("shipToAddress", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Types.AddressType ShipToAddress { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("tradingPartner", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string TradingPartner { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("importReference", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ImportReference { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("exportReference", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ExportReference { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("notificationCode1", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string NotificationCode1 { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("notificationCode2", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string NotificationCode2 { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("notificationCode3", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string NotificationCode3 { get; set; }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("createdDate", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="dateTime")]
        public System.DateTime CreatedDateValue { get; set; }
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool CreatedDateValueSpecified { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<System.DateTime> CreatedDate
        {
            get
            {
                if (this.CreatedDateValueSpecified)
                {
                    return this.CreatedDateValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.CreatedDateValue = value.GetValueOrDefault();
                this.CreatedDateValueSpecified = value.HasValue;
            }
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("updatedDate", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="dateTime")]
        public System.DateTime UpdatedDateValue { get; set; }
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool UpdatedDateValueSpecified { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<System.DateTime> UpdatedDate
        {
            get
            {
                if (this.UpdatedDateValueSpecified)
                {
                    return this.UpdatedDateValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.UpdatedDateValue = value.GetValueOrDefault();
                this.UpdatedDateValueSpecified = value.HasValue;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("shipToReference", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ShipToReference { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("billToAccountNumber", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string BillToAccountNumber { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("orderNumber", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string OrderNumber { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<InvoiceLine.InvoiceLineType> _invoiceLines;
        
        [System.Xml.Serialization.XmlArrayAttribute("invoiceLines", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("invoiceLine", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public System.Collections.ObjectModel.Collection<InvoiceLine.InvoiceLineType> InvoiceLines
        {
            get
            {
                return _invoiceLines;
            }
            private set
            {
                _invoiceLines = value;
            }
        }
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool InvoiceLinesSpecified
        {
            get
            {
                return (this.InvoiceLines.Count != 0);
            }
        }
        
        /// <summary>
        /// </summary>
        public InvoiceType()
        {
            this._invoiceLines = new System.Collections.ObjectModel.Collection<InvoiceLine.InvoiceLineType>();
            this._channels = new System.Collections.ObjectModel.Collection<Types.ChannelFieldType>();
        }
        
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("invoiceConfig", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string InvoiceConfig { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<Types.ChannelFieldType> _channels;
        
        [System.Xml.Serialization.XmlArrayAttribute("channels", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("channel", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public System.Collections.ObjectModel.Collection<Types.ChannelFieldType> Channels
        {
            get
            {
                return _channels;
            }
            private set
            {
                _channels = value;
            }
        }
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ChannelsSpecified
        {
            get
            {
                return (this.Channels.Count != 0);
            }
        }
    }
}

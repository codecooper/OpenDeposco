//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// This code was generated by XmlSchemaClassGenerator version 2.1.954.0
namespace Payment
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.954.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("PaymentCollection", Namespace="http://integration.deposco.com/payment")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("payments", Namespace="http://integration.deposco.com/payment")]
    public partial class PaymentCollection
    {
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<PaymentType> _payment;
        
        [System.Xml.Serialization.XmlElementAttribute("payment", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public System.Collections.ObjectModel.Collection<PaymentType> Payment
        {
            get
            {
                return _payment;
            }
            private set
            {
                _payment = value;
            }
        }
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PaymentSpecified
        {
            get
            {
                return (this.Payment.Count != 0);
            }
        }
        
        /// <summary>
        /// </summary>
        public PaymentCollection()
        {
            this._payment = new System.Collections.ObjectModel.Collection<PaymentType>();
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.954.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("PaymentType", Namespace="http://integration.deposco.com/payment")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("PaymentType", Namespace="http://integration.deposco.com/payment")]
    public partial class PaymentType
    {
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("id", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public long IdValue { get; set; }
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool IdValueSpecified { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<long> Id
        {
            get
            {
                if (this.IdValueSpecified)
                {
                    return this.IdValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.IdValue = value.GetValueOrDefault();
                this.IdValueSpecified = value.HasValue;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("number", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Number { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("gateway", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Gateway { get; set; }
        
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("order", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Order { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("store", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Store { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("transType", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string TransType { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("type", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Type { get; set; }
        
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("amount", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public float Amount { get; set; }
        
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("changes", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public float Changes { get; set; }
        
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("shipping", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public float Shipping { get; set; }
        
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("tax", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public float Tax { get; set; }
        
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("cityTax", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public float CityTax { get; set; }
        
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("discount", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public float Discount { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("cardType", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string CardType { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("txType", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string TxType { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("txNumber", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string TxNumber { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("createdBy", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string CreatedBy { get; set; }
        
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
        
        [System.Xml.Serialization.XmlElementAttribute("businessUnit", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string BusinessUnit { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("detail", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PaymentDetailType Detail { get; set; }
        
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
        
        /// <summary>
        /// </summary>
        public PaymentType()
        {
            this._channels = new System.Collections.ObjectModel.Collection<Types.ChannelFieldType>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("channelSource", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ChannelSource { get; set; }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.954.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("PaymentDetailType", Namespace="http://integration.deposco.com/payment")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class PaymentDetailType
    {
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("credit", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool CreditValue { get; set; }
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool CreditValueSpecified { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<bool> Credit
        {
            get
            {
                if (this.CreditValueSpecified)
                {
                    return this.CreditValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.CreditValue = value.GetValueOrDefault();
                this.CreditValueSpecified = value.HasValue;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("lastFour", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string LastFour { get; set; }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("authorized", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool AuthorizedValue { get; set; }
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool AuthorizedValueSpecified { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<bool> Authorized
        {
            get
            {
                if (this.AuthorizedValueSpecified)
                {
                    return this.AuthorizedValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.AuthorizedValue = value.GetValueOrDefault();
                this.AuthorizedValueSpecified = value.HasValue;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("historyId", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string HistoryId { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("orderId", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string OrderId { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("authCode", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string AuthCode { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("additionalData", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string AdditionalData { get; set; }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("salePosted", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool SalePostedValue { get; set; }
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool SalePostedValueSpecified { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<bool> SalePosted
        {
            get
            {
                if (this.SalePostedValueSpecified)
                {
                    return this.SalePostedValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.SalePostedValue = value.GetValueOrDefault();
                this.SalePostedValueSpecified = value.HasValue;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("emvData", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string EmvData { get; set; }
    }
}

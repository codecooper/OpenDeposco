//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// This code was generated by XmlSchemaClassGenerator version 2.1.954.0
namespace RoutingResponse
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.954.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("ResponseCollection", Namespace="http://integration.deposco.com/RoutingResponse")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("routingResponse", Namespace="http://integration.deposco.com/RoutingResponse")]
    public partial class ResponseCollection
    {
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<RoutingResponseType> _response;
        
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("response", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public System.Collections.ObjectModel.Collection<RoutingResponseType> Response
        {
            get
            {
                return _response;
            }
            private set
            {
                _response = value;
            }
        }
        
        /// <summary>
        /// </summary>
        public ResponseCollection()
        {
            this._response = new System.Collections.ObjectModel.Collection<RoutingResponseType>();
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.954.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("RoutingResponseType", Namespace="http://integration.deposco.com/RoutingResponse")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class RoutingResponseType
    {
        
        [System.Xml.Serialization.XmlElementAttribute("businessUnit", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string BusinessUnit { get; set; }
        
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("routingRequest", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public long RoutingRequest { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("description", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Description { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("requestReference", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string RequestReference { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("routingNumber", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string RoutingNumber { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("scacCode", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ScacCode { get; set; }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("estimatedCost", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public double EstimatedCostValue { get; set; }
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool EstimatedCostValueSpecified { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<double> EstimatedCost
        {
            get
            {
                if (this.EstimatedCostValueSpecified)
                {
                    return this.EstimatedCostValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.EstimatedCostValue = value.GetValueOrDefault();
                this.EstimatedCostValueSpecified = value.HasValue;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<ResponseDetailType> _details;
        
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlArrayAttribute("details", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("detail", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public System.Collections.ObjectModel.Collection<ResponseDetailType> Details
        {
            get
            {
                return _details;
            }
            private set
            {
                _details = value;
            }
        }
        
        /// <summary>
        /// </summary>
        public RoutingResponseType()
        {
            this._details = new System.Collections.ObjectModel.Collection<ResponseDetailType>();
            this._contacts = new System.Collections.ObjectModel.Collection<TransContactType>();
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<TransContactType> _contacts;
        
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlArrayAttribute("contacts", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("contact", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public System.Collections.ObjectModel.Collection<TransContactType> Contacts
        {
            get
            {
                return _contacts;
            }
            private set
            {
                _contacts = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.954.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("ResponseDetailCollection", Namespace="http://integration.deposco.com/RoutingResponse")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ResponseDetailCollection
    {
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<ResponseDetailType> _detail;
        
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("detail", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public System.Collections.ObjectModel.Collection<ResponseDetailType> Detail
        {
            get
            {
                return _detail;
            }
            private set
            {
                _detail = value;
            }
        }
        
        /// <summary>
        /// </summary>
        public ResponseDetailCollection()
        {
            this._detail = new System.Collections.ObjectModel.Collection<ResponseDetailType>();
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.954.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("ResponseDetailType", Namespace="http://integration.deposco.com/RoutingResponse")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ResponseDetailType
    {
        
        [System.Xml.Serialization.XmlElementAttribute("businessUnit", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string BusinessUnit { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("poNumber", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string PoNumber { get; set; }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("requestedShipDate", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="dateTime")]
        public System.DateTime RequestedShipDateValue { get; set; }
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool RequestedShipDateValueSpecified { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<System.DateTime> RequestedShipDate
        {
            get
            {
                if (this.RequestedShipDateValueSpecified)
                {
                    return this.RequestedShipDateValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.RequestedShipDateValue = value.GetValueOrDefault();
                this.RequestedShipDateValueSpecified = value.HasValue;
            }
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("scheduledPickUpDate", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="dateTime")]
        public System.DateTime ScheduledPickUpDateValue { get; set; }
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool ScheduledPickUpDateValueSpecified { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<System.DateTime> ScheduledPickUpDate
        {
            get
            {
                if (this.ScheduledPickUpDateValueSpecified)
                {
                    return this.ScheduledPickUpDateValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.ScheduledPickUpDateValue = value.GetValueOrDefault();
                this.ScheduledPickUpDateValueSpecified = value.HasValue;
            }
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("scheduledQuantity", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public double ScheduledQuantityValue { get; set; }
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool ScheduledQuantityValueSpecified { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<double> ScheduledQuantity
        {
            get
            {
                if (this.ScheduledQuantityValueSpecified)
                {
                    return this.ScheduledQuantityValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.ScheduledQuantityValue = value.GetValueOrDefault();
                this.ScheduledQuantityValueSpecified = value.HasValue;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("scheduledQuantityDescription", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ScheduledQuantityDescription { get; set; }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("shipmentWeight", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public double ShipmentWeightValue { get; set; }
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool ShipmentWeightValueSpecified { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<double> ShipmentWeight
        {
            get
            {
                if (this.ShipmentWeightValueSpecified)
                {
                    return this.ShipmentWeightValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.ShipmentWeightValue = value.GetValueOrDefault();
                this.ShipmentWeightValueSpecified = value.HasValue;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("weightUOM", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string WeightUom { get; set; }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("shipmentVolume", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public double ShipmentVolumeValue { get; set; }
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool ShipmentVolumeValueSpecified { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<double> ShipmentVolume
        {
            get
            {
                if (this.ShipmentVolumeValueSpecified)
                {
                    return this.ShipmentVolumeValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.ShipmentVolumeValue = value.GetValueOrDefault();
                this.ShipmentVolumeValueSpecified = value.HasValue;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("volumeUOM", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string VolumeUom { get; set; }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.954.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("ContactCollection", Namespace="http://integration.deposco.com/RoutingResponse")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ContactCollection
    {
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<TransContactType> _contact;
        
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("contact", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public System.Collections.ObjectModel.Collection<TransContactType> Contact
        {
            get
            {
                return _contact;
            }
            private set
            {
                _contact = value;
            }
        }
        
        /// <summary>
        /// </summary>
        public ContactCollection()
        {
            this._contact = new System.Collections.ObjectModel.Collection<TransContactType>();
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.954.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("TransContactType", Namespace="http://integration.deposco.com/RoutingResponse")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class TransContactType
    {
        
        [System.Xml.Serialization.XmlElementAttribute("code", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Code { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("type", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Type { get; set; }
        
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("name", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Name { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("line1", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Line1 { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("line2", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Line2 { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("line3", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Line3 { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("city", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string City { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("stateProvince", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string StateProvince { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("postalCode", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string PostalCode { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("country", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Country { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("location", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Location { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("email", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Email { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("phone", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Phone { get; set; }
    }
}

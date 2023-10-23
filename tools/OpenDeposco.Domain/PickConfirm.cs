//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// This code was generated by XmlSchemaClassGenerator version 2.1.954.0
namespace PickConfirm
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.954.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("PickConfirmsCollection", Namespace="http://integration.deposco.com/pickconfirm")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("pickConfirms", Namespace="http://integration.deposco.com/pickconfirm")]
    public partial class PickConfirmsCollection
    {
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<PickConfirmType> _pickConfirm;
        
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("pickConfirm", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public System.Collections.ObjectModel.Collection<PickConfirmType> PickConfirm
        {
            get
            {
                return _pickConfirm;
            }
            private set
            {
                _pickConfirm = value;
            }
        }
        
        /// <summary>
        /// </summary>
        public PickConfirmsCollection()
        {
            this._pickConfirm = new System.Collections.ObjectModel.Collection<PickConfirmType>();
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.954.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("PickConfirmType", Namespace="http://integration.deposco.com/pickconfirm")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class PickConfirmType
    {
        
        [System.Xml.Serialization.XmlElementAttribute("orderNumber", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string OrderNumber { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("pickTask", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string PickTask { get; set; }
        
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("location", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Location { get; set; }
        
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("qtyToPick", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int QtyToPick { get; set; }
        
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("qtyPicked", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int QtyPicked { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("item", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Item { get; set; }
        
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("container", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Container { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("exceptionCode", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ExceptionCode { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("exceptionReason", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ExceptionReason { get; set; }
        
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("user", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string User { get; set; }
        
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("facility", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Facility { get; set; }
        
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("businessUnit", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string BusinessUnit { get; set; }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("startTaskTime", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="dateTime")]
        public System.DateTime StartTaskTimeValue { get; set; }
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool StartTaskTimeValueSpecified { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<System.DateTime> StartTaskTime
        {
            get
            {
                if (this.StartTaskTimeValueSpecified)
                {
                    return this.StartTaskTimeValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.StartTaskTimeValue = value.GetValueOrDefault();
                this.StartTaskTimeValueSpecified = value.HasValue;
            }
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("endTaskTime", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="dateTime")]
        public System.DateTime EndTaskTimeValue { get; set; }
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool EndTaskTimeValueSpecified { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<System.DateTime> EndTaskTime
        {
            get
            {
                if (this.EndTaskTimeValueSpecified)
                {
                    return this.EndTaskTimeValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.EndTaskTimeValue = value.GetValueOrDefault();
                this.EndTaskTimeValueSpecified = value.HasValue;
            }
        }
        
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("pickSystem", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string PickSystem { get; set; }
        
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("channel", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Types.ChannelFieldType Channel { get; set; }
    }
}

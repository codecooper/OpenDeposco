//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// This code was generated by XmlSchemaClassGenerator version 2.1.954.0
namespace ReturnLabel
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.954.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("ReturnLabelCollection", Namespace="http://integration.deposco.com/returnLabel")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("returnLabels", Namespace="http://integration.deposco.com/returnLabel")]
    public partial class ReturnLabelCollection
    {
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<ReturnLabelType> _returnLabel;
        
        [System.Xml.Serialization.XmlElementAttribute("returnLabel", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public System.Collections.ObjectModel.Collection<ReturnLabelType> ReturnLabel
        {
            get
            {
                return _returnLabel;
            }
            private set
            {
                _returnLabel = value;
            }
        }
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ReturnLabelSpecified
        {
            get
            {
                return (this.ReturnLabel.Count != 0);
            }
        }
        
        /// <summary>
        /// </summary>
        public ReturnLabelCollection()
        {
            this._returnLabel = new System.Collections.ObjectModel.Collection<ReturnLabelType>();
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.954.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("ReturnLabelType", Namespace="http://integration.deposco.com/returnLabel")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ReturnLabelType
    {
        
        [System.Xml.Serialization.XmlElementAttribute("businessUnit", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string BusinessUnit { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("createdBy", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string CreatedBy { get; set; }
        
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("customerReturnNumber", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string CustomerReturnNumber { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("returnShipVia", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ReturnShipVia { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("returnShipOption", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ReturnShipOption { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<Container.ContainerType> _containers;
        
        [System.Xml.Serialization.XmlArrayAttribute("containers", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("container", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public System.Collections.ObjectModel.Collection<Container.ContainerType> Containers
        {
            get
            {
                return _containers;
            }
            private set
            {
                _containers = value;
            }
        }
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ContainersSpecified
        {
            get
            {
                return (this.Containers.Count != 0);
            }
        }
        
        /// <summary>
        /// </summary>
        public ReturnLabelType()
        {
            this._containers = new System.Collections.ObjectModel.Collection<Container.ContainerType>();
        }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// This code was generated by XmlSchemaClassGenerator version 2.1.954.0
namespace InvSegmentationPlan
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.954.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("InvSegmentationPlanCollection", Namespace="http://integration.deposco.com/invsegmentationplan")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("invSegmentationPlans", Namespace="http://integration.deposco.com/invsegmentationplan")]
    public partial class InvSegmentationPlanCollection
    {
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<InvSegmentationPlanType> _invSegmentationPlan;
        
        [System.Xml.Serialization.XmlElementAttribute("invSegmentationPlan", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public System.Collections.ObjectModel.Collection<InvSegmentationPlanType> InvSegmentationPlan
        {
            get
            {
                return _invSegmentationPlan;
            }
            private set
            {
                _invSegmentationPlan = value;
            }
        }
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool InvSegmentationPlanSpecified
        {
            get
            {
                return (this.InvSegmentationPlan.Count != 0);
            }
        }
        
        /// <summary>
        /// </summary>
        public InvSegmentationPlanCollection()
        {
            this._invSegmentationPlan = new System.Collections.ObjectModel.Collection<InvSegmentationPlanType>();
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.954.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("InvSegmentationPlanType", Namespace="http://integration.deposco.com/invsegmentationplan")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class InvSegmentationPlanType
    {
        
        [System.Xml.Serialization.XmlElementAttribute("code", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Code { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// This code was generated by XmlSchemaClassGenerator version 2.1.954.0
namespace CoChargeAllowance
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.954.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("ChargeAllowanceCollection", Namespace="http://integration.deposco.com/cochargeallowance")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("chargesAllowances", Namespace="http://integration.deposco.com/cochargeallowance")]
    public partial class ChargeAllowanceCollection
    {
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<ChargeAllowanceType> _chargeAllowance;
        
        [System.Xml.Serialization.XmlElementAttribute("chargeAllowance", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public System.Collections.ObjectModel.Collection<ChargeAllowanceType> ChargeAllowance
        {
            get
            {
                return _chargeAllowance;
            }
            private set
            {
                _chargeAllowance = value;
            }
        }
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ChargeAllowanceSpecified
        {
            get
            {
                return (this.ChargeAllowance.Count != 0);
            }
        }
        
        /// <summary>
        /// </summary>
        public ChargeAllowanceCollection()
        {
            this._chargeAllowance = new System.Collections.ObjectModel.Collection<ChargeAllowanceType>();
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.954.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("ChargeAllowanceType", Namespace="http://integration.deposco.com/cochargeallowance")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ChargeAllowanceType
    {
        
        [System.Xml.Serialization.XmlElementAttribute("indicator", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Indicator { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("code", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Code { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("agency", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Agency { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("agencyCode", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string AgencyCode { get; set; }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("allowChargeAmount", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public double AllowChargeAmountValue { get; set; }
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool AllowChargeAmountValueSpecified { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<double> AllowChargeAmount
        {
            get
            {
                if (this.AllowChargeAmountValueSpecified)
                {
                    return this.AllowChargeAmountValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.AllowChargeAmountValue = value.GetValueOrDefault();
                this.AllowChargeAmountValueSpecified = value.HasValue;
            }
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("allowChargePercentBasis", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public double AllowChargePercentBasisValue { get; set; }
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool AllowChargePercentBasisValueSpecified { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<double> AllowChargePercentBasis
        {
            get
            {
                if (this.AllowChargePercentBasisValueSpecified)
                {
                    return this.AllowChargePercentBasisValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.AllowChargePercentBasisValue = value.GetValueOrDefault();
                this.AllowChargePercentBasisValueSpecified = value.HasValue;
            }
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("allowChargePercent", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public double AllowChargePercentValue { get; set; }
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool AllowChargePercentValueSpecified { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<double> AllowChargePercent
        {
            get
            {
                if (this.AllowChargePercentValueSpecified)
                {
                    return this.AllowChargePercentValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.AllowChargePercentValue = value.GetValueOrDefault();
                this.AllowChargePercentValueSpecified = value.HasValue;
            }
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("allowChargeRate", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public double AllowChargeRateValue { get; set; }
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool AllowChargeRateValueSpecified { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<double> AllowChargeRate
        {
            get
            {
                if (this.AllowChargeRateValueSpecified)
                {
                    return this.AllowChargeRateValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.AllowChargeRateValue = value.GetValueOrDefault();
                this.AllowChargeRateValueSpecified = value.HasValue;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("allowChargeQtyUOM", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string AllowChargeQtyUom { get; set; }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("allowChargeQty", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public double AllowChargeQtyValue { get; set; }
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool AllowChargeQtyValueSpecified { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<double> AllowChargeQty
        {
            get
            {
                if (this.AllowChargeQtyValueSpecified)
                {
                    return this.AllowChargeQtyValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.AllowChargeQtyValue = value.GetValueOrDefault();
                this.AllowChargeQtyValueSpecified = value.HasValue;
            }
        }
    }
}

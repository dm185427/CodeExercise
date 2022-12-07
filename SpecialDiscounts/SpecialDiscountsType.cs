namespace Retalix.Contracts.Generated.SpecialDiscounts
{
    using Retalix.Contracts.Generated.Common;
    using Retalix.Contracts.Generated.Arts.PosLogV6.Source;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("BatchContractGenerator.Console", "30.100.999")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://retalix.com/R10/services")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://retalix.com/R10/services", IsNullable=true)]
    [Retalix.Commons.Contracts.ContractDocumentationAttributes.ContractSourceAttribute("Schemas\\SpecialDiscounts\\SpecialDiscounts.xsd")]
    public partial class SpecialDiscountsType
    {
        
        private int idField;
        
        private string discountCodeField;
        
        private int valueField;
        
        private string expiryDateField;
        
        private ActionTypeCodes actionField;
        
        private bool actionFieldSpecified;
        
        private bool IdFieldSpecified;
        
        private bool ValueFieldSpecified;
        
        [Retalix.Commons.Contracts.ContractValidationAttributes.ContractRequiredAttribute()]
        public int Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
                this.IdSpecified = true;
            }
        }
        
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        public string DiscountCode
        {
            get
            {
                return this.discountCodeField;
            }
            set
            {
                this.discountCodeField = value;
            }
        }
        
        [Retalix.Commons.Contracts.ContractValidationAttributes.ContractRequiredAttribute()]
        public int Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
                this.ValueSpecified = true;
            }
        }
        
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        public string ExpiryDate
        {
            get
            {
                return this.expiryDateField;
            }
            set
            {
                this.expiryDateField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ActionTypeCodes Action
        {
            get
            {
                return this.actionField;
            }
            set
            {
                this.actionField = value;
                this.ActionSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ActionSpecified
        {
            get
            {
                return this.actionFieldSpecified;
            }
            set
            {
                this.actionFieldSpecified = value;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual bool IdSpecified
        {
            get
            {
                return this.IdFieldSpecified;
            }
            set
            {
                this.IdFieldSpecified = value;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual bool ValueSpecified
        {
            get
            {
                return this.ValueFieldSpecified;
            }
            set
            {
                this.ValueFieldSpecified = value;
            }
        }
    }
}

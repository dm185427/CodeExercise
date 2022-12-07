namespace Retalix.Contracts.Generated.SpecialDiscounts
{
    using Retalix.Contracts.Generated.Common;
    using Retalix.Contracts.Generated.Arts.PosLogV6.Source;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("BatchContractGenerator.Console", "30.100.999")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://retalix.com/R10/services")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://retalix.com/R10/services", IsNullable=false)]
    [Retalix.Commons.Contracts.ContractDocumentationAttributes.ContractSourceAttribute("Schemas\\SpecialDiscounts\\SpecialDiscounts.xsd")]
    public partial class SpecialDiscountsLookupResponse : Retalix.Contracts.Interfaces.IHeaderResponse
    {
        
        private RetalixCommonHeaderType headerField;
        
        private SpecialDiscountsType[] specialDiscountsTypeField;
        
        public RetalixCommonHeaderType Header
        {
            get
            {
                return this.headerField;
            }
            set
            {
                this.headerField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("SpecialDiscountsType")]
        public SpecialDiscountsType[] SpecialDiscountsType
        {
            get
            {
                return this.specialDiscountsTypeField;
            }
            set
            {
                this.specialDiscountsTypeField = value;
            }
        }
    }
}

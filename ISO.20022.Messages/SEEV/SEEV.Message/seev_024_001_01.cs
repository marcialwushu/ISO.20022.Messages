﻿//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;

// 
// This source code was auto-generated by xsd, Version=4.8.3928.0.
// 


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.024.001.01")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.024.001.01", IsNullable=false)]
public partial class Document {
    
    private AgentCAInformationStatusAdviceV01 agtCAInfStsAdvcField;
    
    /// <remarks/>
    public AgentCAInformationStatusAdviceV01 AgtCAInfStsAdvc {
        get {
            return this.agtCAInfStsAdvcField;
        }
        set {
            this.agtCAInfStsAdvcField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.024.001.01")]
public partial class AgentCAInformationStatusAdviceV01 {
    
    private DocumentIdentification8 idField;
    
    private DocumentIdentification8 agtCAInfAdvcIdField;
    
    private CorporateActionAdditionalInformation1 corpActnAddtlInfField;
    
    private CorporateActionInformationStatus1Choice infStsDtlsField;
    
    /// <remarks/>
    public DocumentIdentification8 Id {
        get {
            return this.idField;
        }
        set {
            this.idField = value;
        }
    }
    
    /// <remarks/>
    public DocumentIdentification8 AgtCAInfAdvcId {
        get {
            return this.agtCAInfAdvcIdField;
        }
        set {
            this.agtCAInfAdvcIdField = value;
        }
    }
    
    /// <remarks/>
    public CorporateActionAdditionalInformation1 CorpActnAddtlInf {
        get {
            return this.corpActnAddtlInfField;
        }
        set {
            this.corpActnAddtlInfField = value;
        }
    }
    
    /// <remarks/>
    public CorporateActionInformationStatus1Choice InfStsDtls {
        get {
            return this.infStsDtlsField;
        }
        set {
            this.infStsDtlsField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.024.001.01")]
public partial class DocumentIdentification8 {
    
    private string idField;
    
    private System.DateTime creDtTmField;
    
    private bool creDtTmFieldSpecified;
    
    /// <remarks/>
    public string Id {
        get {
            return this.idField;
        }
        set {
            this.idField = value;
        }
    }
    
    /// <remarks/>
    public System.DateTime CreDtTm {
        get {
            return this.creDtTmField;
        }
        set {
            this.creDtTmField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool CreDtTmSpecified {
        get {
            return this.creDtTmFieldSpecified;
        }
        set {
            this.creDtTmFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.024.001.01")]
public partial class RejectionReason15FormatChoice {
    
    private object itemField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Cd", typeof(RejectionReason15Code))]
    [System.Xml.Serialization.XmlElementAttribute("Prtry", typeof(GenericIdentification13))]
    public object Item {
        get {
            return this.itemField;
        }
        set {
            this.itemField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.024.001.01")]
public enum RejectionReason15Code {
    
    /// <remarks/>
    FAIL,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.024.001.01")]
public partial class GenericIdentification13 {
    
    private string idField;
    
    private string schmeNmField;
    
    private string issrField;
    
    /// <remarks/>
    public string Id {
        get {
            return this.idField;
        }
        set {
            this.idField = value;
        }
    }
    
    /// <remarks/>
    public string SchmeNm {
        get {
            return this.schmeNmField;
        }
        set {
            this.schmeNmField = value;
        }
    }
    
    /// <remarks/>
    public string Issr {
        get {
            return this.issrField;
        }
        set {
            this.issrField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.024.001.01")]
public partial class CorporateActionInformationRejectedStatus1 {
    
    private RejectionReason15FormatChoice[] rsnField;
    
    private string addtlInfField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Rsn")]
    public RejectionReason15FormatChoice[] Rsn {
        get {
            return this.rsnField;
        }
        set {
            this.rsnField = value;
        }
    }
    
    /// <remarks/>
    public string AddtlInf {
        get {
            return this.addtlInfField;
        }
        set {
            this.addtlInfField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.024.001.01")]
public partial class ProcessedStatus5FormatChoice {
    
    private object itemField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Cd", typeof(ProcessedStatus5Code))]
    [System.Xml.Serialization.XmlElementAttribute("Prtry", typeof(GenericIdentification13))]
    public object Item {
        get {
            return this.itemField;
        }
        set {
            this.itemField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.024.001.01")]
public enum ProcessedStatus5Code {
    
    /// <remarks/>
    RECE,
    
    /// <remarks/>
    PACK,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.024.001.01")]
public partial class CorporateActionInformationProcessingStatus1 {
    
    private ProcessedStatus5FormatChoice stsField;
    
    private string addtlInfField;
    
    /// <remarks/>
    public ProcessedStatus5FormatChoice Sts {
        get {
            return this.stsField;
        }
        set {
            this.stsField = value;
        }
    }
    
    /// <remarks/>
    public string AddtlInf {
        get {
            return this.addtlInfField;
        }
        set {
            this.addtlInfField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.024.001.01")]
public partial class CorporateActionInformationStatus1Choice {
    
    private object itemField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("PrcdSts", typeof(CorporateActionInformationProcessingStatus1))]
    [System.Xml.Serialization.XmlElementAttribute("RjctdSts", typeof(CorporateActionInformationRejectedStatus1))]
    public object Item {
        get {
            return this.itemField;
        }
        set {
            this.itemField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.024.001.01")]
public partial class SimpleIdentificationInformation {
    
    private string idField;
    
    /// <remarks/>
    public string Id {
        get {
            return this.idField;
        }
        set {
            this.idField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.024.001.01")]
public partial class CashAccountIdentification1Choice {
    
    private object itemField;
    
    private ItemChoiceType1 itemElementNameField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("BBAN", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("DmstAcct", typeof(SimpleIdentificationInformation))]
    [System.Xml.Serialization.XmlElementAttribute("IBAN", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("UPIC", typeof(string))]
    [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
    public object Item {
        get {
            return this.itemField;
        }
        set {
            this.itemField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public ItemChoiceType1 ItemElementName {
        get {
            return this.itemElementNameField;
        }
        set {
            this.itemElementNameField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.024.001.01", IncludeInSchema=false)]
public enum ItemChoiceType1 {
    
    /// <remarks/>
    BBAN,
    
    /// <remarks/>
    DmstAcct,
    
    /// <remarks/>
    IBAN,
    
    /// <remarks/>
    UPIC,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.024.001.01")]
public partial class ProceedsDelivery1 {
    
    private object itemField;
    
    private PartyIdentification2Choice acctOwnrIdField;
    
    private PartyIdentification2Choice acctSvcrIdField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("CshAcctId", typeof(CashAccountIdentification1Choice))]
    [System.Xml.Serialization.XmlElementAttribute("SctiesAcctId", typeof(string))]
    public object Item {
        get {
            return this.itemField;
        }
        set {
            this.itemField = value;
        }
    }
    
    /// <remarks/>
    public PartyIdentification2Choice AcctOwnrId {
        get {
            return this.acctOwnrIdField;
        }
        set {
            this.acctOwnrIdField = value;
        }
    }
    
    /// <remarks/>
    public PartyIdentification2Choice AcctSvcrId {
        get {
            return this.acctSvcrIdField;
        }
        set {
            this.acctSvcrIdField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.024.001.01")]
public partial class PartyIdentification2Choice {
    
    private object itemField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("BICOrBEI", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("NmAndAdr", typeof(NameAndAddress5))]
    [System.Xml.Serialization.XmlElementAttribute("PrtryId", typeof(GenericIdentification1))]
    public object Item {
        get {
            return this.itemField;
        }
        set {
            this.itemField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.024.001.01")]
public partial class NameAndAddress5 {
    
    private string nmField;
    
    private PostalAddress1 adrField;
    
    /// <remarks/>
    public string Nm {
        get {
            return this.nmField;
        }
        set {
            this.nmField = value;
        }
    }
    
    /// <remarks/>
    public PostalAddress1 Adr {
        get {
            return this.adrField;
        }
        set {
            this.adrField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.024.001.01")]
public partial class PostalAddress1 {
    
    private AddressType2Code adrTpField;
    
    private bool adrTpFieldSpecified;
    
    private string[] adrLineField;
    
    private string strtNmField;
    
    private string bldgNbField;
    
    private string pstCdField;
    
    private string twnNmField;
    
    private string ctrySubDvsnField;
    
    private string ctryField;
    
    /// <remarks/>
    public AddressType2Code AdrTp {
        get {
            return this.adrTpField;
        }
        set {
            this.adrTpField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool AdrTpSpecified {
        get {
            return this.adrTpFieldSpecified;
        }
        set {
            this.adrTpFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("AdrLine")]
    public string[] AdrLine {
        get {
            return this.adrLineField;
        }
        set {
            this.adrLineField = value;
        }
    }
    
    /// <remarks/>
    public string StrtNm {
        get {
            return this.strtNmField;
        }
        set {
            this.strtNmField = value;
        }
    }
    
    /// <remarks/>
    public string BldgNb {
        get {
            return this.bldgNbField;
        }
        set {
            this.bldgNbField = value;
        }
    }
    
    /// <remarks/>
    public string PstCd {
        get {
            return this.pstCdField;
        }
        set {
            this.pstCdField = value;
        }
    }
    
    /// <remarks/>
    public string TwnNm {
        get {
            return this.twnNmField;
        }
        set {
            this.twnNmField = value;
        }
    }
    
    /// <remarks/>
    public string CtrySubDvsn {
        get {
            return this.ctrySubDvsnField;
        }
        set {
            this.ctrySubDvsnField = value;
        }
    }
    
    /// <remarks/>
    public string Ctry {
        get {
            return this.ctryField;
        }
        set {
            this.ctryField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.024.001.01")]
public enum AddressType2Code {
    
    /// <remarks/>
    ADDR,
    
    /// <remarks/>
    PBOX,
    
    /// <remarks/>
    HOME,
    
    /// <remarks/>
    BIZZ,
    
    /// <remarks/>
    MLTO,
    
    /// <remarks/>
    DLVY,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.024.001.01")]
public partial class GenericIdentification1 {
    
    private string idField;
    
    private string schmeNmField;
    
    private string issrField;
    
    /// <remarks/>
    public string Id {
        get {
            return this.idField;
        }
        set {
            this.idField = value;
        }
    }
    
    /// <remarks/>
    public string SchmeNm {
        get {
            return this.schmeNmField;
        }
        set {
            this.schmeNmField = value;
        }
    }
    
    /// <remarks/>
    public string Issr {
        get {
            return this.issrField;
        }
        set {
            this.issrField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.024.001.01")]
public partial class ActiveCurrencyAndAmount {
    
    private string ccyField;
    
    private decimal valueField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Ccy {
        get {
            return this.ccyField;
        }
        set {
            this.ccyField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public decimal Value {
        get {
            return this.valueField;
        }
        set {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.024.001.01")]
public partial class UnitOrFaceAmount1Choice {
    
    private object itemField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("FaceAmt", typeof(ActiveCurrencyAndAmount))]
    [System.Xml.Serialization.XmlElementAttribute("Unit", typeof(decimal))]
    public object Item {
        get {
            return this.itemField;
        }
        set {
            this.itemField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.024.001.01")]
public partial class AlternateSecurityIdentification3 {
    
    private string idField;
    
    private string itemField;
    
    private ItemChoiceType itemElementNameField;
    
    /// <remarks/>
    public string Id {
        get {
            return this.idField;
        }
        set {
            this.idField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("DmstIdSrc", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("PrtryIdSrc", typeof(string))]
    [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
    public string Item {
        get {
            return this.itemField;
        }
        set {
            this.itemField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public ItemChoiceType ItemElementName {
        get {
            return this.itemElementNameField;
        }
        set {
            this.itemElementNameField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.024.001.01", IncludeInSchema=false)]
public enum ItemChoiceType {
    
    /// <remarks/>
    DmstIdSrc,
    
    /// <remarks/>
    PrtryIdSrc,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.024.001.01")]
public partial class SecurityIdentification7 {
    
    private object itemField;
    
    private string descField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ISIN", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("OthrId", typeof(AlternateSecurityIdentification3))]
    public object Item {
        get {
            return this.itemField;
        }
        set {
            this.itemField = value;
        }
    }
    
    /// <remarks/>
    public string Desc {
        get {
            return this.descField;
        }
        set {
            this.descField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.024.001.01")]
public partial class BeneficiaryCertificationType1FormatChoice {
    
    private object itemField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Cd", typeof(BeneficiaryCertificationType1Code))]
    [System.Xml.Serialization.XmlElementAttribute("Prtry", typeof(GenericIdentification13))]
    public object Item {
        get {
            return this.itemField;
        }
        set {
            this.itemField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.024.001.01")]
public enum BeneficiaryCertificationType1Code {
    
    /// <remarks/>
    ACCI,
    
    /// <remarks/>
    DOMI,
    
    /// <remarks/>
    FULL,
    
    /// <remarks/>
    QIBB,
    
    /// <remarks/>
    TRBD,
    
    /// <remarks/>
    NCOM,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.024.001.01")]
public partial class PersonIdentificationType3Choice {
    
    private object itemField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Cd", typeof(PersonIdentificationType3Code))]
    [System.Xml.Serialization.XmlElementAttribute("Prtry", typeof(GenericIdentification13))]
    public object Item {
        get {
            return this.itemField;
        }
        set {
            this.itemField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.024.001.01")]
public enum PersonIdentificationType3Code {
    
    /// <remarks/>
    ARNU,
    
    /// <remarks/>
    CCPT,
    
    /// <remarks/>
    EMID,
    
    /// <remarks/>
    DRLC,
    
    /// <remarks/>
    FINN,
    
    /// <remarks/>
    TXID,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.024.001.01")]
public partial class GenericIdentification16 {
    
    private string idField;
    
    private PersonIdentificationType3Choice idTpField;
    
    private string issrField;
    
    /// <remarks/>
    public string Id {
        get {
            return this.idField;
        }
        set {
            this.idField = value;
        }
    }
    
    /// <remarks/>
    public PersonIdentificationType3Choice IdTp {
        get {
            return this.idTpField;
        }
        set {
            this.idTpField = value;
        }
    }
    
    /// <remarks/>
    public string Issr {
        get {
            return this.issrField;
        }
        set {
            this.issrField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.024.001.01")]
public partial class BeneficialOwner1 {
    
    private PartyIdentification2Choice bnfclOwnrIdField;
    
    private GenericIdentification16 addtlIdField;
    
    private string ntltyField;
    
    private string dmclCtryField;
    
    private string nonDmclCtryField;
    
    private bool certfctnIndField;
    
    private bool certfctnIndFieldSpecified;
    
    private BeneficiaryCertificationType1FormatChoice certfctnTpField;
    
    private string dclrtnDtlsField;
    
    private SecurityIdentification7 sctyIdField;
    
    private UnitOrFaceAmount1Choice elctdSctiesQtyField;
    
    /// <remarks/>
    public PartyIdentification2Choice BnfclOwnrId {
        get {
            return this.bnfclOwnrIdField;
        }
        set {
            this.bnfclOwnrIdField = value;
        }
    }
    
    /// <remarks/>
    public GenericIdentification16 AddtlId {
        get {
            return this.addtlIdField;
        }
        set {
            this.addtlIdField = value;
        }
    }
    
    /// <remarks/>
    public string Ntlty {
        get {
            return this.ntltyField;
        }
        set {
            this.ntltyField = value;
        }
    }
    
    /// <remarks/>
    public string DmclCtry {
        get {
            return this.dmclCtryField;
        }
        set {
            this.dmclCtryField = value;
        }
    }
    
    /// <remarks/>
    public string NonDmclCtry {
        get {
            return this.nonDmclCtryField;
        }
        set {
            this.nonDmclCtryField = value;
        }
    }
    
    /// <remarks/>
    public bool CertfctnInd {
        get {
            return this.certfctnIndField;
        }
        set {
            this.certfctnIndField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool CertfctnIndSpecified {
        get {
            return this.certfctnIndFieldSpecified;
        }
        set {
            this.certfctnIndFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public BeneficiaryCertificationType1FormatChoice CertfctnTp {
        get {
            return this.certfctnTpField;
        }
        set {
            this.certfctnTpField = value;
        }
    }
    
    /// <remarks/>
    public string DclrtnDtls {
        get {
            return this.dclrtnDtlsField;
        }
        set {
            this.dclrtnDtlsField = value;
        }
    }
    
    /// <remarks/>
    public SecurityIdentification7 SctyId {
        get {
            return this.sctyIdField;
        }
        set {
            this.sctyIdField = value;
        }
    }
    
    /// <remarks/>
    public UnitOrFaceAmount1Choice ElctdSctiesQty {
        get {
            return this.elctdSctiesQtyField;
        }
        set {
            this.elctdSctiesQtyField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.024.001.01")]
public partial class CorporateActionAdditionalInformation1 {
    
    private BeneficialOwner1[] bnfclOwnrDtlsField;
    
    private string regnDtlsField;
    
    private PartyIdentification2Choice rcvrIdField;
    
    private bool certfctnIndField;
    
    private bool certfctnIndFieldSpecified;
    
    private BeneficiaryCertificationType1FormatChoice certfctnTpField;
    
    private ProceedsDelivery1[] dlvryDtlsField;
    
    private string addtlInstrField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("BnfclOwnrDtls")]
    public BeneficialOwner1[] BnfclOwnrDtls {
        get {
            return this.bnfclOwnrDtlsField;
        }
        set {
            this.bnfclOwnrDtlsField = value;
        }
    }
    
    /// <remarks/>
    public string RegnDtls {
        get {
            return this.regnDtlsField;
        }
        set {
            this.regnDtlsField = value;
        }
    }
    
    /// <remarks/>
    public PartyIdentification2Choice RcvrId {
        get {
            return this.rcvrIdField;
        }
        set {
            this.rcvrIdField = value;
        }
    }
    
    /// <remarks/>
    public bool CertfctnInd {
        get {
            return this.certfctnIndField;
        }
        set {
            this.certfctnIndField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool CertfctnIndSpecified {
        get {
            return this.certfctnIndFieldSpecified;
        }
        set {
            this.certfctnIndFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public BeneficiaryCertificationType1FormatChoice CertfctnTp {
        get {
            return this.certfctnTpField;
        }
        set {
            this.certfctnTpField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("DlvryDtls")]
    public ProceedsDelivery1[] DlvryDtls {
        get {
            return this.dlvryDtlsField;
        }
        set {
            this.dlvryDtlsField = value;
        }
    }
    
    /// <remarks/>
    public string AddtlInstr {
        get {
            return this.addtlInstrField;
        }
        set {
            this.addtlInstrField = value;
        }
    }
}

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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.019.001.02")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.019.001.02", IsNullable=false)]
public partial class Document {
    
    private AccountHoldingInformationRequestV02 acctHldgInfReqField;
    
    /// <remarks/>
    public AccountHoldingInformationRequestV02 AcctHldgInfReq {
        get {
            return this.acctHldgInfReqField;
        }
        set {
            this.acctHldgInfReqField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.019.001.02")]
public partial class AccountHoldingInformationRequestV02 {
    
    private MessageIdentification1 msgRefField;
    
    private AdditionalReference3 poolRefField;
    
    private AdditionalReference3 prvsRefField;
    
    private AdditionalReference3 rltdRefField;
    
    private BusinessFlowDirectionType1Code bizFlowDrctnTpField;
    
    private bool bizFlowDrctnTpFieldSpecified;
    
    private IndividualPerson8 pmryIndvInvstrField;
    
    private IndividualPerson8 scndryIndvInvstrField;
    
    private IndividualPerson8[] othrIndvInvstrField;
    
    private Organisation4 pmryCorpInvstrField;
    
    private Organisation4 scndryCorpInvstrField;
    
    private Organisation4[] othrCorpInvstrField;
    
    private Account5 trfrAcctField;
    
    private Account6 nmneeAcctField;
    
    private PartyIdentification2Choice trfeeField;
    
    private ISATransfer5[] pdctTrfField;
    
    private Extension1[] xtnsnField;
    
    /// <remarks/>
    public MessageIdentification1 MsgRef {
        get {
            return this.msgRefField;
        }
        set {
            this.msgRefField = value;
        }
    }
    
    /// <remarks/>
    public AdditionalReference3 PoolRef {
        get {
            return this.poolRefField;
        }
        set {
            this.poolRefField = value;
        }
    }
    
    /// <remarks/>
    public AdditionalReference3 PrvsRef {
        get {
            return this.prvsRefField;
        }
        set {
            this.prvsRefField = value;
        }
    }
    
    /// <remarks/>
    public AdditionalReference3 RltdRef {
        get {
            return this.rltdRefField;
        }
        set {
            this.rltdRefField = value;
        }
    }
    
    /// <remarks/>
    public BusinessFlowDirectionType1Code BizFlowDrctnTp {
        get {
            return this.bizFlowDrctnTpField;
        }
        set {
            this.bizFlowDrctnTpField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool BizFlowDrctnTpSpecified {
        get {
            return this.bizFlowDrctnTpFieldSpecified;
        }
        set {
            this.bizFlowDrctnTpFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public IndividualPerson8 PmryIndvInvstr {
        get {
            return this.pmryIndvInvstrField;
        }
        set {
            this.pmryIndvInvstrField = value;
        }
    }
    
    /// <remarks/>
    public IndividualPerson8 ScndryIndvInvstr {
        get {
            return this.scndryIndvInvstrField;
        }
        set {
            this.scndryIndvInvstrField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("OthrIndvInvstr")]
    public IndividualPerson8[] OthrIndvInvstr {
        get {
            return this.othrIndvInvstrField;
        }
        set {
            this.othrIndvInvstrField = value;
        }
    }
    
    /// <remarks/>
    public Organisation4 PmryCorpInvstr {
        get {
            return this.pmryCorpInvstrField;
        }
        set {
            this.pmryCorpInvstrField = value;
        }
    }
    
    /// <remarks/>
    public Organisation4 ScndryCorpInvstr {
        get {
            return this.scndryCorpInvstrField;
        }
        set {
            this.scndryCorpInvstrField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("OthrCorpInvstr")]
    public Organisation4[] OthrCorpInvstr {
        get {
            return this.othrCorpInvstrField;
        }
        set {
            this.othrCorpInvstrField = value;
        }
    }
    
    /// <remarks/>
    public Account5 TrfrAcct {
        get {
            return this.trfrAcctField;
        }
        set {
            this.trfrAcctField = value;
        }
    }
    
    /// <remarks/>
    public Account6 NmneeAcct {
        get {
            return this.nmneeAcctField;
        }
        set {
            this.nmneeAcctField = value;
        }
    }
    
    /// <remarks/>
    public PartyIdentification2Choice Trfee {
        get {
            return this.trfeeField;
        }
        set {
            this.trfeeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("PdctTrf")]
    public ISATransfer5[] PdctTrf {
        get {
            return this.pdctTrfField;
        }
        set {
            this.pdctTrfField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Xtnsn")]
    public Extension1[] Xtnsn {
        get {
            return this.xtnsnField;
        }
        set {
            this.xtnsnField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.019.001.02")]
public partial class MessageIdentification1 {
    
    private string idField;
    
    private System.DateTime creDtTmField;
    
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
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.019.001.02")]
public partial class Extension1 {
    
    private string plcAndNmField;
    
    private string txtField;
    
    /// <remarks/>
    public string PlcAndNm {
        get {
            return this.plcAndNmField;
        }
        set {
            this.plcAndNmField = value;
        }
    }
    
    /// <remarks/>
    public string Txt {
        get {
            return this.txtField;
        }
        set {
            this.txtField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.019.001.02")]
public partial class AlternateSecurityIdentification1 {
    
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.019.001.02", IncludeInSchema=false)]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.019.001.02")]
public partial class SecurityIdentification3Choice {
    
    private object itemField;
    
    private ItemChoiceType1 itemElementNameField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Belgn", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("Blmbrg", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("CTA", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("CUSIP", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("Cmon", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("Dtch", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("ISIN", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("OthrPrtryId", typeof(AlternateSecurityIdentification1))]
    [System.Xml.Serialization.XmlElementAttribute("QUICK", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("RIC", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("SCVM", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("SEDOL", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("TckrSymb", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("Vlrn", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("Wrtppr", typeof(string))]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.019.001.02", IncludeInSchema=false)]
public enum ItemChoiceType1 {
    
    /// <remarks/>
    Belgn,
    
    /// <remarks/>
    Blmbrg,
    
    /// <remarks/>
    CTA,
    
    /// <remarks/>
    CUSIP,
    
    /// <remarks/>
    Cmon,
    
    /// <remarks/>
    Dtch,
    
    /// <remarks/>
    ISIN,
    
    /// <remarks/>
    OthrPrtryId,
    
    /// <remarks/>
    QUICK,
    
    /// <remarks/>
    RIC,
    
    /// <remarks/>
    SCVM,
    
    /// <remarks/>
    SEDOL,
    
    /// <remarks/>
    TckrSymb,
    
    /// <remarks/>
    Vlrn,
    
    /// <remarks/>
    Wrtppr,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.019.001.02")]
public partial class FinancialInstrument27 {
    
    private SecurityIdentification3Choice idField;
    
    private string nmField;
    
    private Account6 trfeeAcctField;
    
    /// <remarks/>
    public SecurityIdentification3Choice Id {
        get {
            return this.idField;
        }
        set {
            this.idField = value;
        }
    }
    
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
    public Account6 TrfeeAcct {
        get {
            return this.trfeeAcctField;
        }
        set {
            this.trfeeAcctField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.019.001.02")]
public partial class Account6 {
    
    private string idField;
    
    private string dsgntField;
    
    private PartyIdentification2Choice svcrField;
    
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
    public string Dsgnt {
        get {
            return this.dsgntField;
        }
        set {
            this.dsgntField = value;
        }
    }
    
    /// <remarks/>
    public PartyIdentification2Choice Svcr {
        get {
            return this.svcrField;
        }
        set {
            this.svcrField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.019.001.02")]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.019.001.02")]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.019.001.02")]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.019.001.02")]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.019.001.02")]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.019.001.02")]
public partial class Portfolio1 {
    
    private string[] prtflInfField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("PrtflInf")]
    public string[] PrtflInf {
        get {
            return this.prtflInfField;
        }
        set {
            this.prtflInfField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.019.001.02")]
public partial class PreviousYearChoice {
    
    private string[] itemsField;
    
    private ItemsChoiceType[] itemsElementNameField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("AllPrvsYrs", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("SpcfcPrvsYrs", typeof(string), DataType="gYear")]
    [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
    public string[] Items {
        get {
            return this.itemsField;
        }
        set {
            this.itemsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public ItemsChoiceType[] ItemsElementName {
        get {
            return this.itemsElementNameField;
        }
        set {
            this.itemsElementNameField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.019.001.02", IncludeInSchema=false)]
public enum ItemsChoiceType {
    
    /// <remarks/>
    AllPrvsYrs,
    
    /// <remarks/>
    SpcfcPrvsYrs,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.019.001.02")]
public partial class CurrentYearType2Choice {
    
    private object itemField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("CurYrTp", typeof(ISAType2Code))]
    [System.Xml.Serialization.XmlElementAttribute("XtndedCurYrTp", typeof(string))]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.019.001.02")]
public enum ISAType2Code {
    
    /// <remarks/>
    MINE,
    
    /// <remarks/>
    MAXI,
    
    /// <remarks/>
    MINC,
    
    /// <remarks/>
    ANYI,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.019.001.02")]
public partial class ISAYearsOfIssue6 {
    
    private CurrentYearType2Choice curYrField;
    
    private PreviousYearChoice prvsYrsField;
    
    /// <remarks/>
    public CurrentYearType2Choice CurYr {
        get {
            return this.curYrField;
        }
        set {
            this.curYrField = value;
        }
    }
    
    /// <remarks/>
    public PreviousYearChoice PrvsYrs {
        get {
            return this.prvsYrsField;
        }
        set {
            this.prvsYrsField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.019.001.02")]
public partial class ISAPortfolio3Choice {
    
    private object itemField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ISA", typeof(ISAYearsOfIssue6))]
    [System.Xml.Serialization.XmlElementAttribute("Prtfl", typeof(Portfolio1))]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.019.001.02")]
public partial class ISATransfer5 {
    
    private string mstrRefField;
    
    private string trfIdField;
    
    private ISAPortfolio3Choice prtflField;
    
    private bool allOthrCshField;
    
    private FinancialInstrument27[] finInstrmAsstForTrfField;
    
    /// <remarks/>
    public string MstrRef {
        get {
            return this.mstrRefField;
        }
        set {
            this.mstrRefField = value;
        }
    }
    
    /// <remarks/>
    public string TrfId {
        get {
            return this.trfIdField;
        }
        set {
            this.trfIdField = value;
        }
    }
    
    /// <remarks/>
    public ISAPortfolio3Choice Prtfl {
        get {
            return this.prtflField;
        }
        set {
            this.prtflField = value;
        }
    }
    
    /// <remarks/>
    public bool AllOthrCsh {
        get {
            return this.allOthrCshField;
        }
        set {
            this.allOthrCshField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("FinInstrmAsstForTrf")]
    public FinancialInstrument27[] FinInstrmAsstForTrf {
        get {
            return this.finInstrmAsstForTrfField;
        }
        set {
            this.finInstrmAsstForTrfField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.019.001.02")]
public partial class Account5 {
    
    private string idField;
    
    private string dsgntField;
    
    private PartyIdentification2Choice svcrField;
    
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
    public string Dsgnt {
        get {
            return this.dsgntField;
        }
        set {
            this.dsgntField = value;
        }
    }
    
    /// <remarks/>
    public PartyIdentification2Choice Svcr {
        get {
            return this.svcrField;
        }
        set {
            this.svcrField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.019.001.02")]
public partial class PartyIdentification4Choice {
    
    private object itemField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("BICOrBEI", typeof(string))]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.019.001.02")]
public partial class Organisation4 {
    
    private string nmField;
    
    private PartyIdentification4Choice idField;
    
    private string purpField;
    
    private string taxtnCtryField;
    
    private string regnCtryField;
    
    private System.DateTime regnDtField;
    
    private bool regnDtFieldSpecified;
    
    private string taxIdNbField;
    
    private string ntlRegnNbField;
    
    private PostalAddress1 corpInvstrAdrField;
    
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
    public PartyIdentification4Choice Id {
        get {
            return this.idField;
        }
        set {
            this.idField = value;
        }
    }
    
    /// <remarks/>
    public string Purp {
        get {
            return this.purpField;
        }
        set {
            this.purpField = value;
        }
    }
    
    /// <remarks/>
    public string TaxtnCtry {
        get {
            return this.taxtnCtryField;
        }
        set {
            this.taxtnCtryField = value;
        }
    }
    
    /// <remarks/>
    public string RegnCtry {
        get {
            return this.regnCtryField;
        }
        set {
            this.regnCtryField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
    public System.DateTime RegnDt {
        get {
            return this.regnDtField;
        }
        set {
            this.regnDtField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool RegnDtSpecified {
        get {
            return this.regnDtFieldSpecified;
        }
        set {
            this.regnDtFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public string TaxIdNb {
        get {
            return this.taxIdNbField;
        }
        set {
            this.taxIdNbField = value;
        }
    }
    
    /// <remarks/>
    public string NtlRegnNb {
        get {
            return this.ntlRegnNbField;
        }
        set {
            this.ntlRegnNbField = value;
        }
    }
    
    /// <remarks/>
    public PostalAddress1 CorpInvstrAdr {
        get {
            return this.corpInvstrAdrField;
        }
        set {
            this.corpInvstrAdrField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.019.001.02")]
public partial class IndividualPerson8 {
    
    private string nmField;
    
    private string gvnNmField;
    
    private NamePrefix1Code nmPrfxField;
    
    private bool nmPrfxFieldSpecified;
    
    private string nmSfxField;
    
    private GenderCode gndrField;
    
    private bool gndrFieldSpecified;
    
    private System.DateTime birthDtField;
    
    private bool birthDtFieldSpecified;
    
    private string sclSctyNbField;
    
    private PostalAddress1 indvInvstrAdrField;
    
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
    public string GvnNm {
        get {
            return this.gvnNmField;
        }
        set {
            this.gvnNmField = value;
        }
    }
    
    /// <remarks/>
    public NamePrefix1Code NmPrfx {
        get {
            return this.nmPrfxField;
        }
        set {
            this.nmPrfxField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool NmPrfxSpecified {
        get {
            return this.nmPrfxFieldSpecified;
        }
        set {
            this.nmPrfxFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public string NmSfx {
        get {
            return this.nmSfxField;
        }
        set {
            this.nmSfxField = value;
        }
    }
    
    /// <remarks/>
    public GenderCode Gndr {
        get {
            return this.gndrField;
        }
        set {
            this.gndrField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool GndrSpecified {
        get {
            return this.gndrFieldSpecified;
        }
        set {
            this.gndrFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
    public System.DateTime BirthDt {
        get {
            return this.birthDtField;
        }
        set {
            this.birthDtField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool BirthDtSpecified {
        get {
            return this.birthDtFieldSpecified;
        }
        set {
            this.birthDtFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public string SclSctyNb {
        get {
            return this.sclSctyNbField;
        }
        set {
            this.sclSctyNbField = value;
        }
    }
    
    /// <remarks/>
    public PostalAddress1 IndvInvstrAdr {
        get {
            return this.indvInvstrAdrField;
        }
        set {
            this.indvInvstrAdrField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.019.001.02")]
public enum NamePrefix1Code {
    
    /// <remarks/>
    DOCT,
    
    /// <remarks/>
    MIST,
    
    /// <remarks/>
    MISS,
    
    /// <remarks/>
    MADM,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.019.001.02")]
public enum GenderCode {
    
    /// <remarks/>
    MALE,
    
    /// <remarks/>
    FEMA,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.019.001.02")]
public partial class AdditionalReference3 {
    
    private string refField;
    
    private PartyIdentification2Choice refIssrField;
    
    private string msgNmField;
    
    /// <remarks/>
    public string Ref {
        get {
            return this.refField;
        }
        set {
            this.refField = value;
        }
    }
    
    /// <remarks/>
    public PartyIdentification2Choice RefIssr {
        get {
            return this.refIssrField;
        }
        set {
            this.refIssrField = value;
        }
    }
    
    /// <remarks/>
    public string MsgNm {
        get {
            return this.msgNmField;
        }
        set {
            this.msgNmField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.019.001.02")]
public enum BusinessFlowDirectionType1Code {
    
    /// <remarks/>
    ADLV,
    
    /// <remarks/>
    ARCV,
}

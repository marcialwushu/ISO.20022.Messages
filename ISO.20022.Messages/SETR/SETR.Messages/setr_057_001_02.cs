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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.057.001.02")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.057.001.02", IsNullable=false)]
public partial class Document {
    
    private OrderConfirmationStatusReportV02 ordrConfStsRptField;
    
    /// <remarks/>
    public OrderConfirmationStatusReportV02 OrdrConfStsRpt {
        get {
            return this.ordrConfStsRptField;
        }
        set {
            this.ordrConfStsRptField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.057.001.02")]
public partial class OrderConfirmationStatusReportV02 {
    
    private MessageIdentification1 msgIdField;
    
    private References61Choice refField;
    
    private IndividualOrderConfirmationStatusAndReason2[] indvOrdrConfDtlsRptField;
    
    private Extension1[] xtnsnField;
    
    /// <remarks/>
    public MessageIdentification1 MsgId {
        get {
            return this.msgIdField;
        }
        set {
            this.msgIdField = value;
        }
    }
    
    /// <remarks/>
    public References61Choice Ref {
        get {
            return this.refField;
        }
        set {
            this.refField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("IndvOrdrConfDtlsRpt")]
    public IndividualOrderConfirmationStatusAndReason2[] IndvOrdrConfDtlsRpt {
        get {
            return this.indvOrdrConfDtlsRptField;
        }
        set {
            this.indvOrdrConfDtlsRptField = value;
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.057.001.02")]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.057.001.02")]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.057.001.02")]
public partial class DateFormat42Choice {
    
    private object itemField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("YrMnth", typeof(string), DataType="gYearMonth")]
    [System.Xml.Serialization.XmlElementAttribute("YrMnthDay", typeof(System.DateTime), DataType="date")]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.057.001.02")]
public partial class Series1 {
    
    private DateFormat42Choice srsDtField;
    
    private string srsNmField;
    
    /// <remarks/>
    public DateFormat42Choice SrsDt {
        get {
            return this.srsDtField;
        }
        set {
            this.srsDtField = value;
        }
    }
    
    /// <remarks/>
    public string SrsNm {
        get {
            return this.srsNmField;
        }
        set {
            this.srsNmField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.057.001.02")]
public partial class IdentificationSource1Choice {
    
    private string itemField;
    
    private ItemChoiceType itemElementNameField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Dmst", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("Prtry", typeof(string))]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.057.001.02", IncludeInSchema=false)]
public enum ItemChoiceType {
    
    /// <remarks/>
    Dmst,
    
    /// <remarks/>
    Prtry,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.057.001.02")]
public partial class AlternateSecurityIdentification7 {
    
    private string idField;
    
    private IdentificationSource1Choice idSrcField;
    
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
    public IdentificationSource1Choice IdSrc {
        get {
            return this.idSrcField;
        }
        set {
            this.idSrcField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.057.001.02")]
public partial class SecurityIdentification25Choice {
    
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
    [System.Xml.Serialization.XmlElementAttribute("OthrPrtryId", typeof(AlternateSecurityIdentification7))]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.057.001.02", IncludeInSchema=false)]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.057.001.02")]
public partial class FinancialInstrument57 {
    
    private SecurityIdentification25Choice idField;
    
    private string nmField;
    
    private string shrtNmField;
    
    private string splmtryIdField;
    
    private string clssTpField;
    
    private FormOfSecurity1Code sctiesFormField;
    
    private bool sctiesFormFieldSpecified;
    
    private DistributionPolicy1Code dstrbtnPlcyField;
    
    private bool dstrbtnPlcyFieldSpecified;
    
    private string pdctGrpField;
    
    private Series1 srsIdField;
    
    /// <remarks/>
    public SecurityIdentification25Choice Id {
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
    public string ShrtNm {
        get {
            return this.shrtNmField;
        }
        set {
            this.shrtNmField = value;
        }
    }
    
    /// <remarks/>
    public string SplmtryId {
        get {
            return this.splmtryIdField;
        }
        set {
            this.splmtryIdField = value;
        }
    }
    
    /// <remarks/>
    public string ClssTp {
        get {
            return this.clssTpField;
        }
        set {
            this.clssTpField = value;
        }
    }
    
    /// <remarks/>
    public FormOfSecurity1Code SctiesForm {
        get {
            return this.sctiesFormField;
        }
        set {
            this.sctiesFormField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool SctiesFormSpecified {
        get {
            return this.sctiesFormFieldSpecified;
        }
        set {
            this.sctiesFormFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public DistributionPolicy1Code DstrbtnPlcy {
        get {
            return this.dstrbtnPlcyField;
        }
        set {
            this.dstrbtnPlcyField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool DstrbtnPlcySpecified {
        get {
            return this.dstrbtnPlcyFieldSpecified;
        }
        set {
            this.dstrbtnPlcyFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public string PdctGrp {
        get {
            return this.pdctGrpField;
        }
        set {
            this.pdctGrpField = value;
        }
    }
    
    /// <remarks/>
    public Series1 SrsId {
        get {
            return this.srsIdField;
        }
        set {
            this.srsIdField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.057.001.02")]
public enum FormOfSecurity1Code {
    
    /// <remarks/>
    BEAR,
    
    /// <remarks/>
    REGD,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.057.001.02")]
public enum DistributionPolicy1Code {
    
    /// <remarks/>
    DIST,
    
    /// <remarks/>
    ACCU,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.057.001.02")]
public partial class SubAccount6 {
    
    private string idField;
    
    private string nmField;
    
    private string chrtcField;
    
    private string acctDsgntField;
    
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
    public string Nm {
        get {
            return this.nmField;
        }
        set {
            this.nmField = value;
        }
    }
    
    /// <remarks/>
    public string Chrtc {
        get {
            return this.chrtcField;
        }
        set {
            this.chrtcField = value;
        }
    }
    
    /// <remarks/>
    public string AcctDsgnt {
        get {
            return this.acctDsgntField;
        }
        set {
            this.acctDsgntField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.057.001.02")]
public partial class InvestmentAccount58 {
    
    private string acctIdField;
    
    private string acctNmField;
    
    private string acctDsgntField;
    
    private PartyIdentification113[] ownrIdField;
    
    private PartyIdentification113 acctSvcrField;
    
    private OrderOriginatorEligibility1Code ordrOrgtrElgbltyField;
    
    private bool ordrOrgtrElgbltyFieldSpecified;
    
    private SubAccount6 subAcctDtlsField;
    
    /// <remarks/>
    public string AcctId {
        get {
            return this.acctIdField;
        }
        set {
            this.acctIdField = value;
        }
    }
    
    /// <remarks/>
    public string AcctNm {
        get {
            return this.acctNmField;
        }
        set {
            this.acctNmField = value;
        }
    }
    
    /// <remarks/>
    public string AcctDsgnt {
        get {
            return this.acctDsgntField;
        }
        set {
            this.acctDsgntField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("OwnrId")]
    public PartyIdentification113[] OwnrId {
        get {
            return this.ownrIdField;
        }
        set {
            this.ownrIdField = value;
        }
    }
    
    /// <remarks/>
    public PartyIdentification113 AcctSvcr {
        get {
            return this.acctSvcrField;
        }
        set {
            this.acctSvcrField = value;
        }
    }
    
    /// <remarks/>
    public OrderOriginatorEligibility1Code OrdrOrgtrElgblty {
        get {
            return this.ordrOrgtrElgbltyField;
        }
        set {
            this.ordrOrgtrElgbltyField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool OrdrOrgtrElgbltySpecified {
        get {
            return this.ordrOrgtrElgbltyFieldSpecified;
        }
        set {
            this.ordrOrgtrElgbltyFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public SubAccount6 SubAcctDtls {
        get {
            return this.subAcctDtlsField;
        }
        set {
            this.subAcctDtlsField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.057.001.02")]
public partial class PartyIdentification113 {
    
    private PartyIdentification90Choice ptyField;
    
    private string lEIField;
    
    /// <remarks/>
    public PartyIdentification90Choice Pty {
        get {
            return this.ptyField;
        }
        set {
            this.ptyField = value;
        }
    }
    
    /// <remarks/>
    public string LEI {
        get {
            return this.lEIField;
        }
        set {
            this.lEIField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.057.001.02")]
public partial class PartyIdentification90Choice {
    
    private object itemField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("AnyBIC", typeof(string))]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.057.001.02")]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.057.001.02")]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.057.001.02")]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.057.001.02")]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.057.001.02")]
public enum OrderOriginatorEligibility1Code {
    
    /// <remarks/>
    ELIG,
    
    /// <remarks/>
    RETL,
    
    /// <remarks/>
    PROF,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.057.001.02")]
public partial class ConfirmationRejectedReason1Choice {
    
    private object itemField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Cd", typeof(RejectedConfirmationStatusReason1Code))]
    [System.Xml.Serialization.XmlElementAttribute("Prtry", typeof(GenericIdentification1))]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.057.001.02")]
public enum RejectedConfirmationStatusReason1Code {
    
    /// <remarks/>
    DSAF,
    
    /// <remarks/>
    DFIN,
    
    /// <remarks/>
    DBEN,
    
    /// <remarks/>
    DPTD,
    
    /// <remarks/>
    DORD,
    
    /// <remarks/>
    DCXR,
    
    /// <remarks/>
    DUNB,
    
    /// <remarks/>
    DORT,
    
    /// <remarks/>
    DROU,
    
    /// <remarks/>
    DNAM,
    
    /// <remarks/>
    DGAM,
    
    /// <remarks/>
    DHRR,
    
    /// <remarks/>
    DGRP,
    
    /// <remarks/>
    DINP,
    
    /// <remarks/>
    DLIR,
    
    /// <remarks/>
    DARR,
    
    /// <remarks/>
    DPDI,
    
    /// <remarks/>
    DRSC,
    
    /// <remarks/>
    DNAV,
    
    /// <remarks/>
    DFXD,
    
    /// <remarks/>
    DCHD,
    
    /// <remarks/>
    DXOD,
    
    /// <remarks/>
    DTAD,
    
    /// <remarks/>
    DPDD,
    
    /// <remarks/>
    DSCA,
    
    /// <remarks/>
    DPID,
    
    /// <remarks/>
    DSAM,
    
    /// <remarks/>
    DSDT,
    
    /// <remarks/>
    DEXD,
    
    /// <remarks/>
    DIMD,
    
    /// <remarks/>
    DTRA,
    
    /// <remarks/>
    DTSA,
    
    /// <remarks/>
    DACI,
    
    /// <remarks/>
    DACO,
    
    /// <remarks/>
    DPSA,
    
    /// <remarks/>
    DPRA,
    
    /// <remarks/>
    DLID,
    
    /// <remarks/>
    DORF,
    
    /// <remarks/>
    ULNK,
    
    /// <remarks/>
    DREF,
    
    /// <remarks/>
    IVAG,
    
    /// <remarks/>
    IRCU,
    
    /// <remarks/>
    IRIN,
    
    /// <remarks/>
    ICAG,
    
    /// <remarks/>
    IDCU,
    
    /// <remarks/>
    IDIN,
    
    /// <remarks/>
    ICTR,
    
    /// <remarks/>
    DMON,
    
    /// <remarks/>
    DDAT,
    
    /// <remarks/>
    NSLA,
    
    /// <remarks/>
    MEUT,
    
    /// <remarks/>
    MCOM,
    
    /// <remarks/>
    MCHA,
    
    /// <remarks/>
    MTAX,
    
    /// <remarks/>
    NATA,
    
    /// <remarks/>
    ALAT,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.057.001.02")]
public partial class ConfirmationRejectedStatus2 {
    
    private ConfirmationRejectedReason1Choice rsnField;
    
    private string addtlInfField;
    
    /// <remarks/>
    public ConfirmationRejectedReason1Choice Rsn {
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.057.001.02")]
public partial class ConfirmationStatus1Choice {
    
    private object[] itemsField;
    
    private ItemsChoiceType1[] itemsElementNameField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("AmdmntRjctd", typeof(ConfirmationRejectedStatus2))]
    [System.Xml.Serialization.XmlElementAttribute("ConfRjctd", typeof(ConfirmationRejectedStatus2))]
    [System.Xml.Serialization.XmlElementAttribute("Sts", typeof(OrderConfirmationStatus1Code))]
    [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
    public object[] Items {
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
    public ItemsChoiceType1[] ItemsElementName {
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.057.001.02")]
public enum OrderConfirmationStatus1Code {
    
    /// <remarks/>
    STNP,
    
    /// <remarks/>
    CPNP,
    
    /// <remarks/>
    COAC,
    
    /// <remarks/>
    CREC,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.057.001.02", IncludeInSchema=false)]
public enum ItemsChoiceType1 {
    
    /// <remarks/>
    AmdmntRjctd,
    
    /// <remarks/>
    ConfRjctd,
    
    /// <remarks/>
    Sts,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.057.001.02")]
public partial class IndividualOrderConfirmationStatusAndReason2 {
    
    private string mstrRefField;
    
    private string ordrRefField;
    
    private ConfirmationStatus1Choice confField;
    
    private string clntRefField;
    
    private string dealRefField;
    
    private PartyIdentification113 stsInitrField;
    
    private InvestmentAccount58 invstmtAcctDtlsField;
    
    private FinancialInstrument57 finInstrmDtlsField;
    
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
    public string OrdrRef {
        get {
            return this.ordrRefField;
        }
        set {
            this.ordrRefField = value;
        }
    }
    
    /// <remarks/>
    public ConfirmationStatus1Choice Conf {
        get {
            return this.confField;
        }
        set {
            this.confField = value;
        }
    }
    
    /// <remarks/>
    public string ClntRef {
        get {
            return this.clntRefField;
        }
        set {
            this.clntRefField = value;
        }
    }
    
    /// <remarks/>
    public string DealRef {
        get {
            return this.dealRefField;
        }
        set {
            this.dealRefField = value;
        }
    }
    
    /// <remarks/>
    public PartyIdentification113 StsInitr {
        get {
            return this.stsInitrField;
        }
        set {
            this.stsInitrField = value;
        }
    }
    
    /// <remarks/>
    public InvestmentAccount58 InvstmtAcctDtls {
        get {
            return this.invstmtAcctDtlsField;
        }
        set {
            this.invstmtAcctDtlsField = value;
        }
    }
    
    /// <remarks/>
    public FinancialInstrument57 FinInstrmDtls {
        get {
            return this.finInstrmDtlsField;
        }
        set {
            this.finInstrmDtlsField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.057.001.02")]
public partial class AdditionalReference8 {
    
    private string refField;
    
    private PartyIdentification113 refIssrField;
    
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
    public PartyIdentification113 RefIssr {
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
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.057.001.02")]
public partial class References61Choice {
    
    private AdditionalReference8[] itemsField;
    
    private ItemsChoiceType[] itemsElementNameField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("OthrRef", typeof(AdditionalReference8))]
    [System.Xml.Serialization.XmlElementAttribute("RltdRef", typeof(AdditionalReference8))]
    [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
    public AdditionalReference8[] Items {
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.057.001.02", IncludeInSchema=false)]
public enum ItemsChoiceType {
    
    /// <remarks/>
    OthrRef,
    
    /// <remarks/>
    RltdRef,
}

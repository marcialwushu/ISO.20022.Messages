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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:reda.061.001.01")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:reda.061.001.01", IsNullable=false)]
public partial class Document {
    
    private NettingCutOffReferenceDataReportV01 netgCutOffRefDataRptField;
    
    /// <remarks/>
    public NettingCutOffReferenceDataReportV01 NetgCutOffRefDataRpt {
        get {
            return this.netgCutOffRefDataRptField;
        }
        set {
            this.netgCutOffRefDataRptField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:reda.061.001.01")]
public partial class NettingCutOffReferenceDataReportV01 {
    
    private NettingCutOffReportData1 rptDataField;
    
    private CutOffData1[] ptcptNetgCutOffDataField;
    
    private SupplementaryData1[] splmtryDataField;
    
    /// <remarks/>
    public NettingCutOffReportData1 RptData {
        get {
            return this.rptDataField;
        }
        set {
            this.rptDataField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("PtcptNetgCutOffData")]
    public CutOffData1[] PtcptNetgCutOffData {
        get {
            return this.ptcptNetgCutOffDataField;
        }
        set {
            this.ptcptNetgCutOffDataField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("SplmtryData")]
    public SupplementaryData1[] SplmtryData {
        get {
            return this.splmtryDataField;
        }
        set {
            this.splmtryDataField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:reda.061.001.01")]
public partial class NettingCutOffReportData1 {
    
    private string msgIdField;
    
    private System.DateTime creDtTmField;
    
    private string rptTpField;
    
    private System.DateTime actvtnDtField;
    
    private PartyIdentification73Choice netSvcPtcptIdField;
    
    private PartyIdentification73Choice rptSvcrField;
    
    private string netSvcTpField;
    
    private Pagination msgPgntnField;
    
    /// <remarks/>
    public string MsgId {
        get {
            return this.msgIdField;
        }
        set {
            this.msgIdField = value;
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
    public string RptTp {
        get {
            return this.rptTpField;
        }
        set {
            this.rptTpField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
    public System.DateTime ActvtnDt {
        get {
            return this.actvtnDtField;
        }
        set {
            this.actvtnDtField = value;
        }
    }
    
    /// <remarks/>
    public PartyIdentification73Choice NetSvcPtcptId {
        get {
            return this.netSvcPtcptIdField;
        }
        set {
            this.netSvcPtcptIdField = value;
        }
    }
    
    /// <remarks/>
    public PartyIdentification73Choice RptSvcr {
        get {
            return this.rptSvcrField;
        }
        set {
            this.rptSvcrField = value;
        }
    }
    
    /// <remarks/>
    public string NetSvcTp {
        get {
            return this.netSvcTpField;
        }
        set {
            this.netSvcTpField = value;
        }
    }
    
    /// <remarks/>
    public Pagination MsgPgntn {
        get {
            return this.msgPgntnField;
        }
        set {
            this.msgPgntnField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:reda.061.001.01")]
public partial class PartyIdentification73Choice {
    
    private object itemField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("AnyBIC", typeof(PartyIdentification44))]
    [System.Xml.Serialization.XmlElementAttribute("NmAndAdr", typeof(NameAndAddress8))]
    [System.Xml.Serialization.XmlElementAttribute("PtyId", typeof(PartyIdentification59))]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:reda.061.001.01")]
public partial class PartyIdentification44 {
    
    private string anyBICField;
    
    private string[] altrntvIdrField;
    
    /// <remarks/>
    public string AnyBIC {
        get {
            return this.anyBICField;
        }
        set {
            this.anyBICField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("AltrntvIdr")]
    public string[] AltrntvIdr {
        get {
            return this.altrntvIdrField;
        }
        set {
            this.altrntvIdrField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:reda.061.001.01")]
public partial class SupplementaryData1 {
    
    private string plcAndNmField;
    
    private System.Xml.XmlElement envlpField;
    
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
    public System.Xml.XmlElement Envlp {
        get {
            return this.envlpField;
        }
        set {
            this.envlpField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:reda.061.001.01")]
public partial class CutOff1 {
    
    private string cutOffUpdIdField;
    
    private string ccyField;
    
    private System.DateTime cutOffTmField;
    
    private string valDtOffsetField;
    
    /// <remarks/>
    public string CutOffUpdId {
        get {
            return this.cutOffUpdIdField;
        }
        set {
            this.cutOffUpdIdField = value;
        }
    }
    
    /// <remarks/>
    public string Ccy {
        get {
            return this.ccyField;
        }
        set {
            this.ccyField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="time")]
    public System.DateTime CutOffTm {
        get {
            return this.cutOffTmField;
        }
        set {
            this.cutOffTmField = value;
        }
    }
    
    /// <remarks/>
    public string ValDtOffset {
        get {
            return this.valDtOffsetField;
        }
        set {
            this.valDtOffsetField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:reda.061.001.01")]
public partial class NettingIdentification1Choice {
    
    private object itemField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("NetgGrpId", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("TradPty", typeof(PartyIdentification73Choice))]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:reda.061.001.01")]
public partial class NettingCutOff1 {
    
    private NettingIdentification1Choice netgIdField;
    
    private CutOff1[] newCutOffField;
    
    /// <remarks/>
    public NettingIdentification1Choice NetgId {
        get {
            return this.netgIdField;
        }
        set {
            this.netgIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("NewCutOff")]
    public CutOff1[] NewCutOff {
        get {
            return this.newCutOffField;
        }
        set {
            this.newCutOffField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:reda.061.001.01")]
public partial class CutOffData1 {
    
    private PartyIdentification73Choice ptcptIdField;
    
    private NettingCutOff1[] netgCutOffDtlsField;
    
    /// <remarks/>
    public PartyIdentification73Choice PtcptId {
        get {
            return this.ptcptIdField;
        }
        set {
            this.ptcptIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("NetgCutOffDtls")]
    public NettingCutOff1[] NetgCutOffDtls {
        get {
            return this.netgCutOffDtlsField;
        }
        set {
            this.netgCutOffDtlsField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:reda.061.001.01")]
public partial class Pagination {
    
    private string pgNbField;
    
    private bool lastPgIndField;
    
    /// <remarks/>
    public string PgNb {
        get {
            return this.pgNbField;
        }
        set {
            this.pgNbField = value;
        }
    }
    
    /// <remarks/>
    public bool LastPgInd {
        get {
            return this.lastPgIndField;
        }
        set {
            this.lastPgIndField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:reda.061.001.01")]
public partial class ClearingSystemIdentification2Choice {
    
    private string itemField;
    
    private ItemChoiceType itemElementNameField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Cd", typeof(string))]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:reda.061.001.01", IncludeInSchema=false)]
public enum ItemChoiceType {
    
    /// <remarks/>
    Cd,
    
    /// <remarks/>
    Prtry,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:reda.061.001.01")]
public partial class PartyIdentification59 {
    
    private string ptyNmField;
    
    private PartyIdentification44 anyBICField;
    
    private string acctNbField;
    
    private string adrField;
    
    private ClearingSystemIdentification2Choice clrSysIdField;
    
    private string lglNttyIdrField;
    
    /// <remarks/>
    public string PtyNm {
        get {
            return this.ptyNmField;
        }
        set {
            this.ptyNmField = value;
        }
    }
    
    /// <remarks/>
    public PartyIdentification44 AnyBIC {
        get {
            return this.anyBICField;
        }
        set {
            this.anyBICField = value;
        }
    }
    
    /// <remarks/>
    public string AcctNb {
        get {
            return this.acctNbField;
        }
        set {
            this.acctNbField = value;
        }
    }
    
    /// <remarks/>
    public string Adr {
        get {
            return this.adrField;
        }
        set {
            this.adrField = value;
        }
    }
    
    /// <remarks/>
    public ClearingSystemIdentification2Choice ClrSysId {
        get {
            return this.clrSysIdField;
        }
        set {
            this.clrSysIdField = value;
        }
    }
    
    /// <remarks/>
    public string LglNttyIdr {
        get {
            return this.lglNttyIdrField;
        }
        set {
            this.lglNttyIdrField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:reda.061.001.01")]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:reda.061.001.01")]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:reda.061.001.01")]
public partial class NameAndAddress8 {
    
    private string nmField;
    
    private PostalAddress1 adrField;
    
    private string[] altrntvIdrField;
    
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
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("AltrntvIdr")]
    public string[] AltrntvIdr {
        get {
            return this.altrntvIdrField;
        }
        set {
            this.altrntvIdrField = value;
        }
    }
}

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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:fxtr.036.001.01")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:fxtr.036.001.01", IsNullable=false)]
public partial class Document {
    
    private ForeignExchangeTradeConfirmationRequestCancellationRequestV01 fXTradConfReqCxlReqField;
    
    /// <remarks/>
    public ForeignExchangeTradeConfirmationRequestCancellationRequestV01 FXTradConfReqCxlReq {
        get {
            return this.fXTradConfReqCxlReqField;
        }
        set {
            this.fXTradConfReqCxlReqField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:fxtr.036.001.01")]
public partial class ForeignExchangeTradeConfirmationRequestCancellationRequestV01 {
    
    private Header23 hdrField;
    
    private MessageIdentification1 cxlReqIdField;
    
    private TradePartyIdentification7 tradgSdIdField;
    
    private TradePartyIdentification7 ctrPtyRoleIdField;
    
    private string tradIdField;
    
    private UnderlyingProductIdentifier1Code undrlygPdctTpField;
    
    private SupplementaryData1[] splmtryDataField;
    
    /// <remarks/>
    public Header23 Hdr {
        get {
            return this.hdrField;
        }
        set {
            this.hdrField = value;
        }
    }
    
    /// <remarks/>
    public MessageIdentification1 CxlReqId {
        get {
            return this.cxlReqIdField;
        }
        set {
            this.cxlReqIdField = value;
        }
    }
    
    /// <remarks/>
    public TradePartyIdentification7 TradgSdId {
        get {
            return this.tradgSdIdField;
        }
        set {
            this.tradgSdIdField = value;
        }
    }
    
    /// <remarks/>
    public TradePartyIdentification7 CtrPtyRoleId {
        get {
            return this.ctrPtyRoleIdField;
        }
        set {
            this.ctrPtyRoleIdField = value;
        }
    }
    
    /// <remarks/>
    public string TradId {
        get {
            return this.tradIdField;
        }
        set {
            this.tradIdField = value;
        }
    }
    
    /// <remarks/>
    public UnderlyingProductIdentifier1Code UndrlygPdctTp {
        get {
            return this.undrlygPdctTpField;
        }
        set {
            this.undrlygPdctTpField = value;
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:fxtr.036.001.01")]
public partial class Header23 {
    
    private string frmtVrsnField;
    
    private string xchgIdField;
    
    private GenericIdentification32 initgPtyField;
    
    private GenericIdentification32 rcptPtyField;
    
    private decimal msgSeqNbField;
    
    private System.DateTime creDtTmField;
    
    /// <remarks/>
    public string FrmtVrsn {
        get {
            return this.frmtVrsnField;
        }
        set {
            this.frmtVrsnField = value;
        }
    }
    
    /// <remarks/>
    public string XchgId {
        get {
            return this.xchgIdField;
        }
        set {
            this.xchgIdField = value;
        }
    }
    
    /// <remarks/>
    public GenericIdentification32 InitgPty {
        get {
            return this.initgPtyField;
        }
        set {
            this.initgPtyField = value;
        }
    }
    
    /// <remarks/>
    public GenericIdentification32 RcptPty {
        get {
            return this.rcptPtyField;
        }
        set {
            this.rcptPtyField = value;
        }
    }
    
    /// <remarks/>
    public decimal MsgSeqNb {
        get {
            return this.msgSeqNbField;
        }
        set {
            this.msgSeqNbField = value;
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:fxtr.036.001.01")]
public partial class GenericIdentification32 {
    
    private string idField;
    
    private PartyType3Code tpField;
    
    private bool tpFieldSpecified;
    
    private PartyType4Code issrField;
    
    private bool issrFieldSpecified;
    
    private string shrtNmField;
    
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
    public PartyType3Code Tp {
        get {
            return this.tpField;
        }
        set {
            this.tpField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool TpSpecified {
        get {
            return this.tpFieldSpecified;
        }
        set {
            this.tpFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public PartyType4Code Issr {
        get {
            return this.issrField;
        }
        set {
            this.issrField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool IssrSpecified {
        get {
            return this.issrFieldSpecified;
        }
        set {
            this.issrFieldSpecified = value;
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
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:fxtr.036.001.01")]
public enum PartyType3Code {
    
    /// <remarks/>
    OPOI,
    
    /// <remarks/>
    MERC,
    
    /// <remarks/>
    ACCP,
    
    /// <remarks/>
    ITAG,
    
    /// <remarks/>
    ACQR,
    
    /// <remarks/>
    CISS,
    
    /// <remarks/>
    DLIS,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:fxtr.036.001.01")]
public enum PartyType4Code {
    
    /// <remarks/>
    MERC,
    
    /// <remarks/>
    ACCP,
    
    /// <remarks/>
    ITAG,
    
    /// <remarks/>
    ACQR,
    
    /// <remarks/>
    CISS,
    
    /// <remarks/>
    TAXH,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:fxtr.036.001.01")]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:fxtr.036.001.01")]
public partial class SimpleIdentificationInformation4 {
    
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:fxtr.036.001.01")]
public partial class AccountIdentification26 {
    
    private SimpleIdentificationInformation4 prtryField;
    
    /// <remarks/>
    public SimpleIdentificationInformation4 Prtry {
        get {
            return this.prtryField;
        }
        set {
            this.prtryField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:fxtr.036.001.01")]
public partial class AccountIdentification30 {
    
    private AccountInformationType1Code acctTpField;
    
    private AccountIdentification26 idField;
    
    /// <remarks/>
    public AccountInformationType1Code AcctTp {
        get {
            return this.acctTpField;
        }
        set {
            this.acctTpField = value;
        }
    }
    
    /// <remarks/>
    public AccountIdentification26 Id {
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:fxtr.036.001.01")]
public enum AccountInformationType1Code {
    
    /// <remarks/>
    IBND,
    
    /// <remarks/>
    IBCC,
    
    /// <remarks/>
    IBDC,
    
    /// <remarks/>
    BIBC,
    
    /// <remarks/>
    BIBD,
    
    /// <remarks/>
    BINC,
    
    /// <remarks/>
    BIND,
    
    /// <remarks/>
    BICC,
    
    /// <remarks/>
    BIDC,
    
    /// <remarks/>
    CMSA,
    
    /// <remarks/>
    CBBC,
    
    /// <remarks/>
    CBBD,
    
    /// <remarks/>
    CBNC,
    
    /// <remarks/>
    CBND,
    
    /// <remarks/>
    CBCC,
    
    /// <remarks/>
    CBDC,
    
    /// <remarks/>
    CUAC,
    
    /// <remarks/>
    DEAC,
    
    /// <remarks/>
    FCAA,
    
    /// <remarks/>
    FCAN,
    
    /// <remarks/>
    FCBN,
    
    /// <remarks/>
    IBBC,
    
    /// <remarks/>
    IBBD,
    
    /// <remarks/>
    IBNC,
    
    /// <remarks/>
    MCAA,
    
    /// <remarks/>
    MCAN,
    
    /// <remarks/>
    MCIC,
    
    /// <remarks/>
    MCIN,
    
    /// <remarks/>
    MSAA,
    
    /// <remarks/>
    MSBN,
    
    /// <remarks/>
    MCAD,
    
    /// <remarks/>
    NODC,
    
    /// <remarks/>
    SCAC,
    
    /// <remarks/>
    SCAA,
    
    /// <remarks/>
    OMSA,
    
    /// <remarks/>
    NOCC,
    
    /// <remarks/>
    MSBS,
    
    /// <remarks/>
    MSAN,
    
    /// <remarks/>
    SCAN,
    
    /// <remarks/>
    SCIC,
    
    /// <remarks/>
    SCIN,
    
    /// <remarks/>
    SOCA,
    
    /// <remarks/>
    SSCA,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:fxtr.036.001.01")]
public partial class PartyIdentification90 {
    
    private PartyIdentificationType1Code idTpField;
    
    private string idField;
    
    /// <remarks/>
    public PartyIdentificationType1Code IdTp {
        get {
            return this.idTpField;
        }
        set {
            this.idTpField = value;
        }
    }
    
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:fxtr.036.001.01")]
public enum PartyIdentificationType1Code {
    
    /// <remarks/>
    FXID,
    
    /// <remarks/>
    FXSN,
    
    /// <remarks/>
    INGN,
    
    /// <remarks/>
    IICS,
    
    /// <remarks/>
    IGBT,
    
    /// <remarks/>
    MAMA,
    
    /// <remarks/>
    MEOC,
    
    /// <remarks/>
    METY,
    
    /// <remarks/>
    NOMM,
    
    /// <remarks/>
    OSCO,
    
    /// <remarks/>
    PASS,
    
    /// <remarks/>
    PONU,
    
    /// <remarks/>
    POAD,
    
    /// <remarks/>
    RMID,
    
    /// <remarks/>
    SLCN,
    
    /// <remarks/>
    SLNF,
    
    /// <remarks/>
    TACN,
    
    /// <remarks/>
    TRCO,
    
    /// <remarks/>
    TANA,
    
    /// <remarks/>
    USIT,
    
    /// <remarks/>
    USNA,
    
    /// <remarks/>
    AUIT,
    
    /// <remarks/>
    BRID,
    
    /// <remarks/>
    CLIN,
    
    /// <remarks/>
    CMID,
    
    /// <remarks/>
    COIN,
    
    /// <remarks/>
    CMOT,
    
    /// <remarks/>
    CONU,
    
    /// <remarks/>
    CMIN,
    
    /// <remarks/>
    DECN,
    
    /// <remarks/>
    DEPA,
    
    /// <remarks/>
    ELCO,
    
    /// <remarks/>
    EXVE,
    
    /// <remarks/>
    FICO,
    
    /// <remarks/>
    FIID,
    
    /// <remarks/>
    FLCN,
    
    /// <remarks/>
    FLNF,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:fxtr.036.001.01")]
public partial class PartyIdentificationAndAccount119 {
    
    private PartyIdentification90[] ptyIdField;
    
    private AccountIdentification30[] acctIdField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("PtyId")]
    public PartyIdentification90[] PtyId {
        get {
            return this.ptyIdField;
        }
        set {
            this.ptyIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("AcctId")]
    public AccountIdentification30[] AcctId {
        get {
            return this.acctIdField;
        }
        set {
            this.acctIdField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:fxtr.036.001.01")]
public partial class PartyIdentification78 {
    
    private IdentificationType1Code ptySrcField;
    
    private bool ptySrcFieldSpecified;
    
    private string tradPtyIdField;
    
    /// <remarks/>
    public IdentificationType1Code PtySrc {
        get {
            return this.ptySrcField;
        }
        set {
            this.ptySrcField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool PtySrcSpecified {
        get {
            return this.ptySrcFieldSpecified;
        }
        set {
            this.ptySrcFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public string TradPtyId {
        get {
            return this.tradPtyIdField;
        }
        set {
            this.tradPtyIdField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:fxtr.036.001.01")]
public enum IdentificationType1Code {
    
    /// <remarks/>
    BASC,
    
    /// <remarks/>
    BICO,
    
    /// <remarks/>
    CFET,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:fxtr.036.001.01")]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:fxtr.036.001.01")]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:fxtr.036.001.01")]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:fxtr.036.001.01")]
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

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:fxtr.036.001.01")]
public partial class PartyIdentification19Choice {
    
    private object itemField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("AnyBIC", typeof(PartyIdentification44))]
    [System.Xml.Serialization.XmlElementAttribute("NmAndAdr", typeof(NameAndAddress8))]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:fxtr.036.001.01")]
public partial class FundIdentification3 {
    
    private string fndIdField;
    
    private string acctIdWthCtdnField;
    
    private PartyIdentification19Choice ctdnIdField;
    
    /// <remarks/>
    public string FndId {
        get {
            return this.fndIdField;
        }
        set {
            this.fndIdField = value;
        }
    }
    
    /// <remarks/>
    public string AcctIdWthCtdn {
        get {
            return this.acctIdWthCtdnField;
        }
        set {
            this.acctIdWthCtdnField = value;
        }
    }
    
    /// <remarks/>
    public PartyIdentification19Choice CtdnId {
        get {
            return this.ctdnIdField;
        }
        set {
            this.ctdnIdField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:fxtr.036.001.01")]
public partial class TradePartyIdentification7 {
    
    private FundIdentification3 fndInfField;
    
    private OptionParty1Code buyrOrSellrIndField;
    
    private OptionParty3Code initrIndField;
    
    private PartyIdentification78 tradPtyIdField;
    
    private PartyIdentificationAndAccount119 submitgPtyField;
    
    /// <remarks/>
    public FundIdentification3 FndInf {
        get {
            return this.fndInfField;
        }
        set {
            this.fndInfField = value;
        }
    }
    
    /// <remarks/>
    public OptionParty1Code BuyrOrSellrInd {
        get {
            return this.buyrOrSellrIndField;
        }
        set {
            this.buyrOrSellrIndField = value;
        }
    }
    
    /// <remarks/>
    public OptionParty3Code InitrInd {
        get {
            return this.initrIndField;
        }
        set {
            this.initrIndField = value;
        }
    }
    
    /// <remarks/>
    public PartyIdentification78 TradPtyId {
        get {
            return this.tradPtyIdField;
        }
        set {
            this.tradPtyIdField = value;
        }
    }
    
    /// <remarks/>
    public PartyIdentificationAndAccount119 SubmitgPty {
        get {
            return this.submitgPtyField;
        }
        set {
            this.submitgPtyField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:fxtr.036.001.01")]
public enum OptionParty1Code {
    
    /// <remarks/>
    SLLR,
    
    /// <remarks/>
    BYER,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:fxtr.036.001.01")]
public enum OptionParty3Code {
    
    /// <remarks/>
    MAKE,
    
    /// <remarks/>
    TAKE,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:fxtr.036.001.01")]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:fxtr.036.001.01")]
public enum UnderlyingProductIdentifier1Code {
    
    /// <remarks/>
    FORW,
    
    /// <remarks/>
    NDFO,
    
    /// <remarks/>
    SPOT,
    
    /// <remarks/>
    SWAP,
}
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:colr.006.001.04")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:colr.006.001.04", IsNullable=false)]
public partial class Document {
    
    private CollateralManagementCancellationStatusV04 collMgmtCxlStsField;
    
    /// <remarks/>
    public CollateralManagementCancellationStatusV04 CollMgmtCxlSts {
        get {
            return this.collMgmtCxlStsField;
        }
        set {
            this.collMgmtCxlStsField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:colr.006.001.04")]
public partial class CollateralManagementCancellationStatusV04 {
    
    private string txIdField;
    
    private Reference16 refField;
    
    private Obligation4 oblgtnField;
    
    private CollateralCancellationStatus1 cxlStsField;
    
    private SupplementaryData1[] splmtryDataField;
    
    /// <remarks/>
    public string TxId {
        get {
            return this.txIdField;
        }
        set {
            this.txIdField = value;
        }
    }
    
    /// <remarks/>
    public Reference16 Ref {
        get {
            return this.refField;
        }
        set {
            this.refField = value;
        }
    }
    
    /// <remarks/>
    public Obligation4 Oblgtn {
        get {
            return this.oblgtnField;
        }
        set {
            this.oblgtnField = value;
        }
    }
    
    /// <remarks/>
    public CollateralCancellationStatus1 CxlSts {
        get {
            return this.cxlStsField;
        }
        set {
            this.cxlStsField = value;
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:colr.006.001.04")]
public partial class Reference16 {
    
    private string collMsgCxlReqIdField;
    
    /// <remarks/>
    public string CollMsgCxlReqId {
        get {
            return this.collMsgCxlReqIdField;
        }
        set {
            this.collMsgCxlReqIdField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:colr.006.001.04")]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:colr.006.001.04")]
public partial class RejectionStatus2 {
    
    private RejectionReasonV021Code rjctdRsnField;
    
    private string addtlInfField;
    
    /// <remarks/>
    public RejectionReasonV021Code RjctdRsn {
        get {
            return this.rjctdRsnField;
        }
        set {
            this.rjctdRsnField = value;
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:colr.006.001.04")]
public enum RejectionReasonV021Code {
    
    /// <remarks/>
    DSEC,
    
    /// <remarks/>
    EVNM,
    
    /// <remarks/>
    UKWN,
    
    /// <remarks/>
    ICOL,
    
    /// <remarks/>
    CONL,
    
    /// <remarks/>
    ELIG,
    
    /// <remarks/>
    INID,
    
    /// <remarks/>
    OTHR,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:colr.006.001.04")]
public partial class CollateralCancellationStatus1 {
    
    private Status4Code collStsCdField;
    
    private string addtlInfField;
    
    private RejectionStatus2 rjctnDtlsField;
    
    /// <remarks/>
    public Status4Code CollStsCd {
        get {
            return this.collStsCdField;
        }
        set {
            this.collStsCdField = value;
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
    
    /// <remarks/>
    public RejectionStatus2 RjctnDtls {
        get {
            return this.rjctnDtlsField;
        }
        set {
            this.rjctnDtlsField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:colr.006.001.04")]
public enum Status4Code {
    
    /// <remarks/>
    REJT,
    
    /// <remarks/>
    PACK,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:colr.006.001.04")]
public partial class DateAndDateTimeChoice {
    
    private System.DateTime itemField;
    
    private ItemChoiceType itemElementNameField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Dt", typeof(System.DateTime), DataType="date")]
    [System.Xml.Serialization.XmlElementAttribute("DtTm", typeof(System.DateTime))]
    [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
    public System.DateTime Item {
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:colr.006.001.04", IncludeInSchema=false)]
public enum ItemChoiceType {
    
    /// <remarks/>
    Dt,
    
    /// <remarks/>
    DtTm,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:colr.006.001.04")]
public partial class CollateralAccountIdentificationType2Choice {
    
    private object itemField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Prtry", typeof(GenericIdentification36))]
    [System.Xml.Serialization.XmlElementAttribute("Tp", typeof(CollateralAccountType1Code))]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:colr.006.001.04")]
public partial class GenericIdentification36 {
    
    private string idField;
    
    private string issrField;
    
    private string schmeNmField;
    
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
    public string Issr {
        get {
            return this.issrField;
        }
        set {
            this.issrField = value;
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
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:colr.006.001.04")]
public enum CollateralAccountType1Code {
    
    /// <remarks/>
    HOUS,
    
    /// <remarks/>
    CLIE,
    
    /// <remarks/>
    LIPR,
    
    /// <remarks/>
    MGIN,
    
    /// <remarks/>
    DFLT,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:colr.006.001.04")]
public partial class CollateralAccount2 {
    
    private string idField;
    
    private CollateralAccountIdentificationType2Choice tpField;
    
    private string nmField;
    
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
    public CollateralAccountIdentificationType2Choice Tp {
        get {
            return this.tpField;
        }
        set {
            this.tpField = value;
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
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:colr.006.001.04")]
public partial class PostalAddress2 {
    
    private string strtNmField;
    
    private string pstCdIdField;
    
    private string twnNmField;
    
    private string ctrySubDvsnField;
    
    private string ctryField;
    
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
    public string PstCdId {
        get {
            return this.pstCdIdField;
        }
        set {
            this.pstCdIdField = value;
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
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:colr.006.001.04")]
public partial class NameAndAddress6 {
    
    private string nmField;
    
    private PostalAddress2 adrField;
    
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
    public PostalAddress2 Adr {
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:colr.006.001.04")]
public partial class PartyIdentification100Choice {
    
    private object itemField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("AnyBIC", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("NmAndAdr", typeof(NameAndAddress6))]
    [System.Xml.Serialization.XmlElementAttribute("PrtryId", typeof(GenericIdentification36))]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:colr.006.001.04")]
public partial class Obligation4 {
    
    private PartyIdentification100Choice ptyAField;
    
    private PartyIdentification100Choice svcgPtyAField;
    
    private PartyIdentification100Choice ptyBField;
    
    private PartyIdentification100Choice svcgPtyBField;
    
    private CollateralAccount2 collAcctIdField;
    
    private ExposureType5Code xpsrTpField;
    
    private bool xpsrTpFieldSpecified;
    
    private DateAndDateTimeChoice valtnDtField;
    
    /// <remarks/>
    public PartyIdentification100Choice PtyA {
        get {
            return this.ptyAField;
        }
        set {
            this.ptyAField = value;
        }
    }
    
    /// <remarks/>
    public PartyIdentification100Choice SvcgPtyA {
        get {
            return this.svcgPtyAField;
        }
        set {
            this.svcgPtyAField = value;
        }
    }
    
    /// <remarks/>
    public PartyIdentification100Choice PtyB {
        get {
            return this.ptyBField;
        }
        set {
            this.ptyBField = value;
        }
    }
    
    /// <remarks/>
    public PartyIdentification100Choice SvcgPtyB {
        get {
            return this.svcgPtyBField;
        }
        set {
            this.svcgPtyBField = value;
        }
    }
    
    /// <remarks/>
    public CollateralAccount2 CollAcctId {
        get {
            return this.collAcctIdField;
        }
        set {
            this.collAcctIdField = value;
        }
    }
    
    /// <remarks/>
    public ExposureType5Code XpsrTp {
        get {
            return this.xpsrTpField;
        }
        set {
            this.xpsrTpField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool XpsrTpSpecified {
        get {
            return this.xpsrTpFieldSpecified;
        }
        set {
            this.xpsrTpFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public DateAndDateTimeChoice ValtnDt {
        get {
            return this.valtnDtField;
        }
        set {
            this.valtnDtField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:colr.006.001.04")]
public enum ExposureType5Code {
    
    /// <remarks/>
    BFWD,
    
    /// <remarks/>
    PAYM,
    
    /// <remarks/>
    CCPC,
    
    /// <remarks/>
    COMM,
    
    /// <remarks/>
    CRDS,
    
    /// <remarks/>
    CRTL,
    
    /// <remarks/>
    CRSP,
    
    /// <remarks/>
    CCIR,
    
    /// <remarks/>
    CRPR,
    
    /// <remarks/>
    EQUI,
    
    /// <remarks/>
    EQPT,
    
    /// <remarks/>
    EQUS,
    
    /// <remarks/>
    EXTD,
    
    /// <remarks/>
    EXPT,
    
    /// <remarks/>
    FIXI,
    
    /// <remarks/>
    FORX,
    
    /// <remarks/>
    FORW,
    
    /// <remarks/>
    FUTR,
    
    /// <remarks/>
    OPTN,
    
    /// <remarks/>
    LIQU,
    
    /// <remarks/>
    OTCD,
    
    /// <remarks/>
    REPO,
    
    /// <remarks/>
    RVPO,
    
    /// <remarks/>
    SLOA,
    
    /// <remarks/>
    SBSC,
    
    /// <remarks/>
    SCRP,
    
    /// <remarks/>
    SLEB,
    
    /// <remarks/>
    SHSL,
    
    /// <remarks/>
    SCIR,
    
    /// <remarks/>
    SCIE,
    
    /// <remarks/>
    SWPT,
    
    /// <remarks/>
    TBAS,
    
    /// <remarks/>
    TRBD,
    
    /// <remarks/>
    TRCP,
}

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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:colr.012.001.03")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:colr.012.001.03", IsNullable=false)]
public partial class Document {
    
    private CollateralSubstitutionConfirmationV03 collSbstitnConfField;
    
    /// <remarks/>
    public CollateralSubstitutionConfirmationV03 CollSbstitnConf {
        get {
            return this.collSbstitnConfField;
        }
        set {
            this.collSbstitnConfField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:colr.012.001.03")]
public partial class CollateralSubstitutionConfirmationV03 {
    
    private string txIdField;
    
    private Obligation3 oblgtnField;
    
    private Agreement2 agrmtField;
    
    private CollateralConfirmation1 sbstitnConfField;
    
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
    public Obligation3 Oblgtn {
        get {
            return this.oblgtnField;
        }
        set {
            this.oblgtnField = value;
        }
    }
    
    /// <remarks/>
    public Agreement2 Agrmt {
        get {
            return this.agrmtField;
        }
        set {
            this.agrmtField = value;
        }
    }
    
    /// <remarks/>
    public CollateralConfirmation1 SbstitnConf {
        get {
            return this.sbstitnConfField;
        }
        set {
            this.sbstitnConfField = value;
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:colr.012.001.03")]
public partial class Obligation3 {
    
    private PartyIdentification33Choice ptyAField;
    
    private PartyIdentification33Choice svcgPtyAField;
    
    private PartyIdentification33Choice ptyBField;
    
    private PartyIdentification33Choice svcgPtyBField;
    
    private CollateralAccount1 collAcctIdField;
    
    private ExposureType5Code xpsrTpField;
    
    private bool xpsrTpFieldSpecified;
    
    private DateAndDateTimeChoice valtnDtField;
    
    /// <remarks/>
    public PartyIdentification33Choice PtyA {
        get {
            return this.ptyAField;
        }
        set {
            this.ptyAField = value;
        }
    }
    
    /// <remarks/>
    public PartyIdentification33Choice SvcgPtyA {
        get {
            return this.svcgPtyAField;
        }
        set {
            this.svcgPtyAField = value;
        }
    }
    
    /// <remarks/>
    public PartyIdentification33Choice PtyB {
        get {
            return this.ptyBField;
        }
        set {
            this.ptyBField = value;
        }
    }
    
    /// <remarks/>
    public PartyIdentification33Choice SvcgPtyB {
        get {
            return this.svcgPtyBField;
        }
        set {
            this.svcgPtyBField = value;
        }
    }
    
    /// <remarks/>
    public CollateralAccount1 CollAcctId {
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
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:colr.012.001.03")]
public partial class PartyIdentification33Choice {
    
    private object itemField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("AnyBIC", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("NmAndAdr", typeof(NameAndAddress6))]
    [System.Xml.Serialization.XmlElementAttribute("PrtryId", typeof(GenericIdentification29))]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:colr.012.001.03")]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:colr.012.001.03")]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:colr.012.001.03")]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:colr.012.001.03")]
public partial class CollateralConfirmation1 {
    
    private string collSbstitnReqIdField;
    
    private string collSbstitnRspnIdField;
    
    private CollateralSubstitutionConfirmation1Code confTpField;
    
    private string cmntField;
    
    /// <remarks/>
    public string CollSbstitnReqId {
        get {
            return this.collSbstitnReqIdField;
        }
        set {
            this.collSbstitnReqIdField = value;
        }
    }
    
    /// <remarks/>
    public string CollSbstitnRspnId {
        get {
            return this.collSbstitnRspnIdField;
        }
        set {
            this.collSbstitnRspnIdField = value;
        }
    }
    
    /// <remarks/>
    public CollateralSubstitutionConfirmation1Code ConfTp {
        get {
            return this.confTpField;
        }
        set {
            this.confTpField = value;
        }
    }
    
    /// <remarks/>
    public string Cmnt {
        get {
            return this.cmntField;
        }
        set {
            this.cmntField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:colr.012.001.03")]
public enum CollateralSubstitutionConfirmation1Code {
    
    /// <remarks/>
    CREL,
    
    /// <remarks/>
    CRET,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:colr.012.001.03")]
public partial class GenericIdentification30 {
    
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
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:colr.012.001.03")]
public partial class AgreementFramework1Choice {
    
    private object itemField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("AgrmtFrmwk", typeof(AgreementFramework1Code))]
    [System.Xml.Serialization.XmlElementAttribute("PrtryId", typeof(GenericIdentification30))]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:colr.012.001.03")]
public enum AgreementFramework1Code {
    
    /// <remarks/>
    FBAA,
    
    /// <remarks/>
    BBAA,
    
    /// <remarks/>
    DERV,
    
    /// <remarks/>
    ISDA,
    
    /// <remarks/>
    NONR,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:colr.012.001.03")]
public partial class Agreement2 {
    
    private string agrmtDtlsField;
    
    private string agrmtIdField;
    
    private System.DateTime agrmtDtField;
    
    private string baseCcyField;
    
    private AgreementFramework1Choice agrmtFrmwkField;
    
    /// <remarks/>
    public string AgrmtDtls {
        get {
            return this.agrmtDtlsField;
        }
        set {
            this.agrmtDtlsField = value;
        }
    }
    
    /// <remarks/>
    public string AgrmtId {
        get {
            return this.agrmtIdField;
        }
        set {
            this.agrmtIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
    public System.DateTime AgrmtDt {
        get {
            return this.agrmtDtField;
        }
        set {
            this.agrmtDtField = value;
        }
    }
    
    /// <remarks/>
    public string BaseCcy {
        get {
            return this.baseCcyField;
        }
        set {
            this.baseCcyField = value;
        }
    }
    
    /// <remarks/>
    public AgreementFramework1Choice AgrmtFrmwk {
        get {
            return this.agrmtFrmwkField;
        }
        set {
            this.agrmtFrmwkField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:colr.012.001.03")]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:colr.012.001.03", IncludeInSchema=false)]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:colr.012.001.03")]
public partial class CollateralAccountIdentificationType1Choice {
    
    private object itemField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Prtry", typeof(GenericIdentification29))]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:colr.012.001.03")]
public partial class GenericIdentification29 {
    
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:colr.012.001.03")]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:colr.012.001.03")]
public partial class CollateralAccount1 {
    
    private string idField;
    
    private CollateralAccountIdentificationType1Choice tpField;
    
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
    public CollateralAccountIdentificationType1Choice Tp {
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:colr.012.001.03")]
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
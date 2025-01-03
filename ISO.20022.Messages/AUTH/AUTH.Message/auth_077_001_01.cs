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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.077.001.01")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.077.001.01", IsNullable=false)]
public partial class Document {
    
    private FinancialBenchmarkReportV01 finBchmkRptField;
    
    /// <remarks/>
    public FinancialBenchmarkReportV01 FinBchmkRpt {
        get {
            return this.finBchmkRptField;
        }
        set {
            this.finBchmkRptField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.077.001.01")]
public partial class FinancialBenchmarkReportV01 {
    
    private BenchmarkReport1Choice[] bchmkDataField;
    
    private SupplementaryData1[] splmtryDataField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("BchmkData")]
    public BenchmarkReport1Choice[] BchmkData {
        get {
            return this.bchmkDataField;
        }
        set {
            this.bchmkDataField = value;
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.077.001.01")]
public partial class BenchmarkReport1Choice {
    
    private object itemField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Cret", typeof(BenchmarkCreate1))]
    [System.Xml.Serialization.XmlElementAttribute("Cxl", typeof(BenchmarkCancellation1))]
    [System.Xml.Serialization.XmlElementAttribute("Upd", typeof(BenchmarkUpdate1))]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.077.001.01")]
public partial class BenchmarkCreate1 {
    
    private string techRcrdIdField;
    
    private SecurityIdentification19 idField;
    
    private BenchmarkDetail1 othrField;
    
    private PartyIdentification136 admstrField;
    
    private PartyIdentification136 ndrsngPtyField;
    
    private StatusDetail1 stsField;
    
    private Period4Choice techVldtyPrdField;
    
    private SupplementaryData1[] splmtryDataField;
    
    /// <remarks/>
    public string TechRcrdId {
        get {
            return this.techRcrdIdField;
        }
        set {
            this.techRcrdIdField = value;
        }
    }
    
    /// <remarks/>
    public SecurityIdentification19 Id {
        get {
            return this.idField;
        }
        set {
            this.idField = value;
        }
    }
    
    /// <remarks/>
    public BenchmarkDetail1 Othr {
        get {
            return this.othrField;
        }
        set {
            this.othrField = value;
        }
    }
    
    /// <remarks/>
    public PartyIdentification136 Admstr {
        get {
            return this.admstrField;
        }
        set {
            this.admstrField = value;
        }
    }
    
    /// <remarks/>
    public PartyIdentification136 NdrsngPty {
        get {
            return this.ndrsngPtyField;
        }
        set {
            this.ndrsngPtyField = value;
        }
    }
    
    /// <remarks/>
    public StatusDetail1 Sts {
        get {
            return this.stsField;
        }
        set {
            this.stsField = value;
        }
    }
    
    /// <remarks/>
    public Period4Choice TechVldtyPrd {
        get {
            return this.techVldtyPrdField;
        }
        set {
            this.techVldtyPrdField = value;
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.077.001.01")]
public partial class SecurityIdentification19 {
    
    private string iSINField;
    
    private OtherIdentification1[] othrIdField;
    
    private string descField;
    
    /// <remarks/>
    public string ISIN {
        get {
            return this.iSINField;
        }
        set {
            this.iSINField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("OthrId")]
    public OtherIdentification1[] OthrId {
        get {
            return this.othrIdField;
        }
        set {
            this.othrIdField = value;
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.077.001.01")]
public partial class OtherIdentification1 {
    
    private string idField;
    
    private string sfxField;
    
    private IdentificationSource3Choice tpField;
    
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
    public string Sfx {
        get {
            return this.sfxField;
        }
        set {
            this.sfxField = value;
        }
    }
    
    /// <remarks/>
    public IdentificationSource3Choice Tp {
        get {
            return this.tpField;
        }
        set {
            this.tpField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.077.001.01")]
public partial class IdentificationSource3Choice {
    
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.077.001.01", IncludeInSchema=false)]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.077.001.01")]
public partial class BenchmarkCancellation1 {
    
    private string techRcrdIdField;
    
    private SecurityIdentification19 idField;
    
    private SupplementaryData1[] splmtryDataField;
    
    /// <remarks/>
    public string TechRcrdId {
        get {
            return this.techRcrdIdField;
        }
        set {
            this.techRcrdIdField = value;
        }
    }
    
    /// <remarks/>
    public SecurityIdentification19 Id {
        get {
            return this.idField;
        }
        set {
            this.idField = value;
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.077.001.01")]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.077.001.01")]
public partial class BenchmarkUpdate1 {
    
    private string techRcrdIdField;
    
    private SecurityIdentification19 idField;
    
    private SecurityIdentification19 prvsIdField;
    
    private BenchmarkDetail1 othrField;
    
    private PartyIdentification136 admstrField;
    
    private PartyIdentification136 ndrsngPtyField;
    
    private StatusDetail1 stsField;
    
    private Period4Choice techVldtyPrdField;
    
    private SupplementaryData1[] splmtryDataField;
    
    /// <remarks/>
    public string TechRcrdId {
        get {
            return this.techRcrdIdField;
        }
        set {
            this.techRcrdIdField = value;
        }
    }
    
    /// <remarks/>
    public SecurityIdentification19 Id {
        get {
            return this.idField;
        }
        set {
            this.idField = value;
        }
    }
    
    /// <remarks/>
    public SecurityIdentification19 PrvsId {
        get {
            return this.prvsIdField;
        }
        set {
            this.prvsIdField = value;
        }
    }
    
    /// <remarks/>
    public BenchmarkDetail1 Othr {
        get {
            return this.othrField;
        }
        set {
            this.othrField = value;
        }
    }
    
    /// <remarks/>
    public PartyIdentification136 Admstr {
        get {
            return this.admstrField;
        }
        set {
            this.admstrField = value;
        }
    }
    
    /// <remarks/>
    public PartyIdentification136 NdrsngPty {
        get {
            return this.ndrsngPtyField;
        }
        set {
            this.ndrsngPtyField = value;
        }
    }
    
    /// <remarks/>
    public StatusDetail1 Sts {
        get {
            return this.stsField;
        }
        set {
            this.stsField = value;
        }
    }
    
    /// <remarks/>
    public Period4Choice TechVldtyPrd {
        get {
            return this.techVldtyPrdField;
        }
        set {
            this.techVldtyPrdField = value;
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.077.001.01")]
public partial class BenchmarkDetail1 {
    
    private string fullNmField;
    
    private BenchmarkCurveName2Code indxField;
    
    private bool indxFieldSpecified;
    
    private string cmntField;
    
    /// <remarks/>
    public string FullNm {
        get {
            return this.fullNmField;
        }
        set {
            this.fullNmField = value;
        }
    }
    
    /// <remarks/>
    public BenchmarkCurveName2Code Indx {
        get {
            return this.indxField;
        }
        set {
            this.indxField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool IndxSpecified {
        get {
            return this.indxFieldSpecified;
        }
        set {
            this.indxFieldSpecified = value;
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.077.001.01")]
public enum BenchmarkCurveName2Code {
    
    /// <remarks/>
    WIBO,
    
    /// <remarks/>
    TREA,
    
    /// <remarks/>
    TIBO,
    
    /// <remarks/>
    TLBO,
    
    /// <remarks/>
    SWAP,
    
    /// <remarks/>
    STBO,
    
    /// <remarks/>
    PRBO,
    
    /// <remarks/>
    PFAN,
    
    /// <remarks/>
    NIBO,
    
    /// <remarks/>
    MAAA,
    
    /// <remarks/>
    MOSP,
    
    /// <remarks/>
    LIBO,
    
    /// <remarks/>
    LIBI,
    
    /// <remarks/>
    JIBA,
    
    /// <remarks/>
    ISDA,
    
    /// <remarks/>
    GCFR,
    
    /// <remarks/>
    FUSW,
    
    /// <remarks/>
    EUCH,
    
    /// <remarks/>
    EUUS,
    
    /// <remarks/>
    EURI,
    
    /// <remarks/>
    EONS,
    
    /// <remarks/>
    EONA,
    
    /// <remarks/>
    CIBO,
    
    /// <remarks/>
    CDOR,
    
    /// <remarks/>
    BUBO,
    
    /// <remarks/>
    BBSW,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.077.001.01")]
public partial class PartyIdentification136 {
    
    private PartyIdentification120Choice idField;
    
    private string lEIField;
    
    /// <remarks/>
    public PartyIdentification120Choice Id {
        get {
            return this.idField;
        }
        set {
            this.idField = value;
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.077.001.01")]
public partial class PartyIdentification120Choice {
    
    private object itemField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("AnyBIC", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("NmAndAdr", typeof(NameAndAddress5))]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.077.001.01")]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.077.001.01")]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.077.001.01")]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.077.001.01")]
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
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.077.001.01")]
public partial class StatusDetail1 {
    
    private string ctryField;
    
    private SupervisingAuthorityIdentification1 cmptntAuthrtyField;
    
    private string stsField;
    
    private string stsRsnField;
    
    private Period4Choice actvtyPrdField;
    
    private string cmntField;
    
    /// <remarks/>
    public string Ctry {
        get {
            return this.ctryField;
        }
        set {
            this.ctryField = value;
        }
    }
    
    /// <remarks/>
    public SupervisingAuthorityIdentification1 CmptntAuthrty {
        get {
            return this.cmptntAuthrtyField;
        }
        set {
            this.cmptntAuthrtyField = value;
        }
    }
    
    /// <remarks/>
    public string Sts {
        get {
            return this.stsField;
        }
        set {
            this.stsField = value;
        }
    }
    
    /// <remarks/>
    public string StsRsn {
        get {
            return this.stsRsnField;
        }
        set {
            this.stsRsnField = value;
        }
    }
    
    /// <remarks/>
    public Period4Choice ActvtyPrd {
        get {
            return this.actvtyPrdField;
        }
        set {
            this.actvtyPrdField = value;
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
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.077.001.01")]
public partial class SupervisingAuthorityIdentification1 {
    
    private SupervisingAuthorityIdentification1Choice idField;
    
    private string lEIField;
    
    /// <remarks/>
    public SupervisingAuthorityIdentification1Choice Id {
        get {
            return this.idField;
        }
        set {
            this.idField = value;
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.077.001.01")]
public partial class SupervisingAuthorityIdentification1Choice {
    
    private string itemField;
    
    private ItemChoiceType1 itemElementNameField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("FullNm", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("PrtryId", typeof(string))]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.077.001.01", IncludeInSchema=false)]
public enum ItemChoiceType1 {
    
    /// <remarks/>
    FullNm,
    
    /// <remarks/>
    PrtryId,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.077.001.01")]
public partial class Period4Choice {
    
    private object itemField;
    
    private ItemChoiceType2 itemElementNameField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Dt", typeof(System.DateTime), DataType="date")]
    [System.Xml.Serialization.XmlElementAttribute("FrDt", typeof(System.DateTime), DataType="date")]
    [System.Xml.Serialization.XmlElementAttribute("FrDtToDt", typeof(Period2))]
    [System.Xml.Serialization.XmlElementAttribute("ToDt", typeof(System.DateTime), DataType="date")]
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
    public ItemChoiceType2 ItemElementName {
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
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.077.001.01")]
public partial class Period2 {
    
    private System.DateTime frDtField;
    
    private System.DateTime toDtField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
    public System.DateTime FrDt {
        get {
            return this.frDtField;
        }
        set {
            this.frDtField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
    public System.DateTime ToDt {
        get {
            return this.toDtField;
        }
        set {
            this.toDtField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.077.001.01", IncludeInSchema=false)]
public enum ItemChoiceType2 {
    
    /// <remarks/>
    Dt,
    
    /// <remarks/>
    FrDt,
    
    /// <remarks/>
    FrDtToDt,
    
    /// <remarks/>
    ToDt,
}

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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.044.001.02")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.044.001.02", IsNullable=false)]
public partial class Document {
    
    private CorporateActionMovementPreliminaryAdviceCancellationAdviceV02 corpActnMvmntPrlimryAdvcCxlAdvcField;
    
    /// <remarks/>
    public CorporateActionMovementPreliminaryAdviceCancellationAdviceV02 CorpActnMvmntPrlimryAdvcCxlAdvc {
        get {
            return this.corpActnMvmntPrlimryAdvcCxlAdvcField;
        }
        set {
            this.corpActnMvmntPrlimryAdvcCxlAdvcField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.044.001.02")]
public partial class CorporateActionMovementPreliminaryAdviceCancellationAdviceV02 {
    
    private CorporateActionProcessingStatus1Choice cxlAdvcGnlInfField;
    
    private DocumentIdentification15 mvmntPrlimryAdvcIdField;
    
    private CorporateActionGeneralInformation25 corpActnGnlInfField;
    
    private AccountIdentification13Choice acctDtlsField;
    
    private PartyIdentification46Choice[] issrAgtField;
    
    private PartyIdentification46Choice[] pngAgtField;
    
    private PartyIdentification46Choice[] subPngAgtField;
    
    private PartyIdentification46Choice regarField;
    
    private PartyIdentification46Choice[] rsellngAgtField;
    
    private PartyIdentification46Choice physSctiesAgtField;
    
    private PartyIdentification46Choice drpAgtField;
    
    private PartyIdentification46Choice[] slctnAgtField;
    
    private PartyIdentification46Choice infAgtField;
    
    private SupplementaryData1[] splmtryDataField;
    
    /// <remarks/>
    public CorporateActionProcessingStatus1Choice CxlAdvcGnlInf {
        get {
            return this.cxlAdvcGnlInfField;
        }
        set {
            this.cxlAdvcGnlInfField = value;
        }
    }
    
    /// <remarks/>
    public DocumentIdentification15 MvmntPrlimryAdvcId {
        get {
            return this.mvmntPrlimryAdvcIdField;
        }
        set {
            this.mvmntPrlimryAdvcIdField = value;
        }
    }
    
    /// <remarks/>
    public CorporateActionGeneralInformation25 CorpActnGnlInf {
        get {
            return this.corpActnGnlInfField;
        }
        set {
            this.corpActnGnlInfField = value;
        }
    }
    
    /// <remarks/>
    public AccountIdentification13Choice AcctDtls {
        get {
            return this.acctDtlsField;
        }
        set {
            this.acctDtlsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("IssrAgt")]
    public PartyIdentification46Choice[] IssrAgt {
        get {
            return this.issrAgtField;
        }
        set {
            this.issrAgtField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("PngAgt")]
    public PartyIdentification46Choice[] PngAgt {
        get {
            return this.pngAgtField;
        }
        set {
            this.pngAgtField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("SubPngAgt")]
    public PartyIdentification46Choice[] SubPngAgt {
        get {
            return this.subPngAgtField;
        }
        set {
            this.subPngAgtField = value;
        }
    }
    
    /// <remarks/>
    public PartyIdentification46Choice Regar {
        get {
            return this.regarField;
        }
        set {
            this.regarField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("RsellngAgt")]
    public PartyIdentification46Choice[] RsellngAgt {
        get {
            return this.rsellngAgtField;
        }
        set {
            this.rsellngAgtField = value;
        }
    }
    
    /// <remarks/>
    public PartyIdentification46Choice PhysSctiesAgt {
        get {
            return this.physSctiesAgtField;
        }
        set {
            this.physSctiesAgtField = value;
        }
    }
    
    /// <remarks/>
    public PartyIdentification46Choice DrpAgt {
        get {
            return this.drpAgtField;
        }
        set {
            this.drpAgtField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("SlctnAgt")]
    public PartyIdentification46Choice[] SlctnAgt {
        get {
            return this.slctnAgtField;
        }
        set {
            this.slctnAgtField = value;
        }
    }
    
    /// <remarks/>
    public PartyIdentification46Choice InfAgt {
        get {
            return this.infAgtField;
        }
        set {
            this.infAgtField = value;
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.044.001.02")]
public partial class CorporateActionProcessingStatus1Choice {
    
    private object itemField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("EvtSts", typeof(CorporateActionEventStatus1))]
    [System.Xml.Serialization.XmlElementAttribute("ForInfOnlyInd", typeof(bool))]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.044.001.02")]
public partial class CorporateActionEventStatus1 {
    
    private EventCompletenessStatus1Code evtCmpltnsStsField;
    
    private EventConfirmationStatus1Code evtConfStsField;
    
    /// <remarks/>
    public EventCompletenessStatus1Code EvtCmpltnsSts {
        get {
            return this.evtCmpltnsStsField;
        }
        set {
            this.evtCmpltnsStsField = value;
        }
    }
    
    /// <remarks/>
    public EventConfirmationStatus1Code EvtConfSts {
        get {
            return this.evtConfStsField;
        }
        set {
            this.evtConfStsField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.044.001.02")]
public enum EventCompletenessStatus1Code {
    
    /// <remarks/>
    COMP,
    
    /// <remarks/>
    INCO,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.044.001.02")]
public enum EventConfirmationStatus1Code {
    
    /// <remarks/>
    CONF,
    
    /// <remarks/>
    UCON,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.044.001.02")]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.044.001.02")]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.044.001.02")]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.044.001.02")]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.044.001.02")]
public partial class PartyIdentification46Choice {
    
    private object itemField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("AnyBIC", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("NmAndAdr", typeof(NameAndAddress5))]
    [System.Xml.Serialization.XmlElementAttribute("PrtryId", typeof(GenericIdentification19))]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.044.001.02")]
public partial class GenericIdentification19 {
    
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.044.001.02")]
public partial class GenericIdentification21 {
    
    private GenericIdentification20 tpField;
    
    private string idField;
    
    /// <remarks/>
    public GenericIdentification20 Tp {
        get {
            return this.tpField;
        }
        set {
            this.tpField = value;
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
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.044.001.02")]
public partial class GenericIdentification20 {
    
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.044.001.02")]
public partial class SafekeepingPlaceTypeAndAnyBICIdentifier1 {
    
    private SafekeepingPlace1Code sfkpgPlcTpField;
    
    private string idField;
    
    /// <remarks/>
    public SafekeepingPlace1Code SfkpgPlcTp {
        get {
            return this.sfkpgPlcTpField;
        }
        set {
            this.sfkpgPlcTpField = value;
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.044.001.02")]
public enum SafekeepingPlace1Code {
    
    /// <remarks/>
    CUST,
    
    /// <remarks/>
    ICSD,
    
    /// <remarks/>
    NCSD,
    
    /// <remarks/>
    SHHE,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.044.001.02")]
public partial class SafekeepingPlaceTypeAndText2 {
    
    private SafekeepingPlace2Code sfkpgPlcTpField;
    
    private string idField;
    
    /// <remarks/>
    public SafekeepingPlace2Code SfkpgPlcTp {
        get {
            return this.sfkpgPlcTpField;
        }
        set {
            this.sfkpgPlcTpField = value;
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.044.001.02")]
public enum SafekeepingPlace2Code {
    
    /// <remarks/>
    SHHE,
    
    /// <remarks/>
    ALLP,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.044.001.02")]
public partial class SafekeepingPlaceFormat2Choice {
    
    private object itemField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Ctry", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("Id", typeof(SafekeepingPlaceTypeAndText2))]
    [System.Xml.Serialization.XmlElementAttribute("Prtry", typeof(GenericIdentification21))]
    [System.Xml.Serialization.XmlElementAttribute("TpAndId", typeof(SafekeepingPlaceTypeAndAnyBICIdentifier1))]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.044.001.02")]
public partial class PartyIdentification36Choice {
    
    private object itemField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("AnyBIC", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("PrtryId", typeof(GenericIdentification19))]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.044.001.02")]
public partial class AccountIdentification15 {
    
    private string sfkpgAcctField;
    
    private PartyIdentification36Choice acctOwnrField;
    
    private SafekeepingPlaceFormat2Choice sfkpgPlcField;
    
    /// <remarks/>
    public string SfkpgAcct {
        get {
            return this.sfkpgAcctField;
        }
        set {
            this.sfkpgAcctField = value;
        }
    }
    
    /// <remarks/>
    public PartyIdentification36Choice AcctOwnr {
        get {
            return this.acctOwnrField;
        }
        set {
            this.acctOwnrField = value;
        }
    }
    
    /// <remarks/>
    public SafekeepingPlaceFormat2Choice SfkpgPlc {
        get {
            return this.sfkpgPlcField;
        }
        set {
            this.sfkpgPlcField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.044.001.02")]
public partial class AccountIdentification10 {
    
    private SafekeepingAccountIdentification1Code idCdField;
    
    /// <remarks/>
    public SafekeepingAccountIdentification1Code IdCd {
        get {
            return this.idCdField;
        }
        set {
            this.idCdField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.044.001.02")]
public enum SafekeepingAccountIdentification1Code {
    
    /// <remarks/>
    GENR,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.044.001.02")]
public partial class AccountIdentification13Choice {
    
    private object[] itemsField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("AcctsList", typeof(AccountIdentification15))]
    [System.Xml.Serialization.XmlElementAttribute("ForAllAccts", typeof(AccountIdentification10))]
    public object[] Items {
        get {
            return this.itemsField;
        }
        set {
            this.itemsField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.044.001.02")]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.044.001.02", IncludeInSchema=false)]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.044.001.02")]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.044.001.02")]
public partial class SecurityIdentification14 {
    
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.044.001.02")]
public partial class CorporateActionMandatoryVoluntary1Choice {
    
    private object itemField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Cd", typeof(CorporateActionMandatoryVoluntary1Code))]
    [System.Xml.Serialization.XmlElementAttribute("Prtry", typeof(GenericIdentification20))]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.044.001.02")]
public enum CorporateActionMandatoryVoluntary1Code {
    
    /// <remarks/>
    MAND,
    
    /// <remarks/>
    CHOS,
    
    /// <remarks/>
    VOLU,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.044.001.02")]
public partial class CorporateActionEventType3Choice {
    
    private object itemField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Cd", typeof(CorporateActionEventType6Code))]
    [System.Xml.Serialization.XmlElementAttribute("Prtry", typeof(GenericIdentification20))]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.044.001.02")]
public enum CorporateActionEventType6Code {
    
    /// <remarks/>
    ACTV,
    
    /// <remarks/>
    ATTI,
    
    /// <remarks/>
    BIDS,
    
    /// <remarks/>
    BONU,
    
    /// <remarks/>
    BPUT,
    
    /// <remarks/>
    BRUP,
    
    /// <remarks/>
    CAPG,
    
    /// <remarks/>
    CAPI,
    
    /// <remarks/>
    CERT,
    
    /// <remarks/>
    CHAN,
    
    /// <remarks/>
    CLSA,
    
    /// <remarks/>
    CONS,
    
    /// <remarks/>
    CONV,
    
    /// <remarks/>
    COOP,
    
    /// <remarks/>
    DECR,
    
    /// <remarks/>
    DETI,
    
    /// <remarks/>
    DFLT,
    
    /// <remarks/>
    DLST,
    
    /// <remarks/>
    DRAW,
    
    /// <remarks/>
    DRIP,
    
    /// <remarks/>
    DSCL,
    
    /// <remarks/>
    DTCH,
    
    /// <remarks/>
    DVCA,
    
    /// <remarks/>
    DVOP,
    
    /// <remarks/>
    DVSC,
    
    /// <remarks/>
    DVSE,
    
    /// <remarks/>
    EXOF,
    
    /// <remarks/>
    EXRI,
    
    /// <remarks/>
    EXTM,
    
    /// <remarks/>
    EXWA,
    
    /// <remarks/>
    CAPD,
    
    /// <remarks/>
    INCR,
    
    /// <remarks/>
    INTR,
    
    /// <remarks/>
    LIQU,
    
    /// <remarks/>
    MCAL,
    
    /// <remarks/>
    MRGR,
    
    /// <remarks/>
    ODLT,
    
    /// <remarks/>
    OTHR,
    
    /// <remarks/>
    PARI,
    
    /// <remarks/>
    PCAL,
    
    /// <remarks/>
    PDEF,
    
    /// <remarks/>
    PINK,
    
    /// <remarks/>
    PLAC,
    
    /// <remarks/>
    PPMT,
    
    /// <remarks/>
    PRED,
    
    /// <remarks/>
    PRII,
    
    /// <remarks/>
    PRIO,
    
    /// <remarks/>
    REDM,
    
    /// <remarks/>
    REDO,
    
    /// <remarks/>
    REMK,
    
    /// <remarks/>
    RHDI,
    
    /// <remarks/>
    RHTS,
    
    /// <remarks/>
    SHPR,
    
    /// <remarks/>
    SMAL,
    
    /// <remarks/>
    SOFF,
    
    /// <remarks/>
    SPLF,
    
    /// <remarks/>
    SPLR,
    
    /// <remarks/>
    SUSP,
    
    /// <remarks/>
    TEND,
    
    /// <remarks/>
    TREC,
    
    /// <remarks/>
    WRTH,
    
    /// <remarks/>
    WTRC,
    
    /// <remarks/>
    CREV,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.044.001.02")]
public partial class CorporateActionGeneralInformation25 {
    
    private string corpActnEvtIdField;
    
    private string offclCorpActnEvtIdField;
    
    private string clssActnNbField;
    
    private CorporateActionEventType3Choice evtTpField;
    
    private CorporateActionMandatoryVoluntary1Choice mndtryVlntryEvtTpField;
    
    private SecurityIdentification14 undrlygSctyIdField;
    
    /// <remarks/>
    public string CorpActnEvtId {
        get {
            return this.corpActnEvtIdField;
        }
        set {
            this.corpActnEvtIdField = value;
        }
    }
    
    /// <remarks/>
    public string OffclCorpActnEvtId {
        get {
            return this.offclCorpActnEvtIdField;
        }
        set {
            this.offclCorpActnEvtIdField = value;
        }
    }
    
    /// <remarks/>
    public string ClssActnNb {
        get {
            return this.clssActnNbField;
        }
        set {
            this.clssActnNbField = value;
        }
    }
    
    /// <remarks/>
    public CorporateActionEventType3Choice EvtTp {
        get {
            return this.evtTpField;
        }
        set {
            this.evtTpField = value;
        }
    }
    
    /// <remarks/>
    public CorporateActionMandatoryVoluntary1Choice MndtryVlntryEvtTp {
        get {
            return this.mndtryVlntryEvtTpField;
        }
        set {
            this.mndtryVlntryEvtTpField = value;
        }
    }
    
    /// <remarks/>
    public SecurityIdentification14 UndrlygSctyId {
        get {
            return this.undrlygSctyIdField;
        }
        set {
            this.undrlygSctyIdField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.044.001.02")]
public partial class ProcessingPosition1Choice {
    
    private object itemField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Cd", typeof(ProcessingPosition3Code))]
    [System.Xml.Serialization.XmlElementAttribute("Prtry", typeof(GenericIdentification20))]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.044.001.02")]
public enum ProcessingPosition3Code {
    
    /// <remarks/>
    AFTE,
    
    /// <remarks/>
    WITH,
    
    /// <remarks/>
    BEFO,
    
    /// <remarks/>
    INFO,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.044.001.02")]
public partial class DocumentIdentification15 {
    
    private string idField;
    
    private ProcessingPosition1Choice lkgTpField;
    
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
    public ProcessingPosition1Choice LkgTp {
        get {
            return this.lkgTpField;
        }
        set {
            this.lkgTpField = value;
        }
    }
}

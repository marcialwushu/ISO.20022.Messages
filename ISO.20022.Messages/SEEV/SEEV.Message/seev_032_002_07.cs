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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.032.002.07")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.032.002.07", IsNullable=false)]
public partial class Document {
    
    private CorporateActionEventProcessingStatusAdvice002V07 corpActnEvtPrcgStsAdvcField;
    
    /// <remarks/>
    public CorporateActionEventProcessingStatusAdvice002V07 CorpActnEvtPrcgStsAdvc {
        get {
            return this.corpActnEvtPrcgStsAdvcField;
        }
        set {
            this.corpActnEvtPrcgStsAdvcField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.032.002.07")]
public partial class CorporateActionEventProcessingStatusAdvice002V07 {
    
    private DocumentIdentification17 ntfctnIdField;
    
    private DocumentIdentification34[] othrDocIdField;
    
    private CorporateActionGeneralInformation144 corpActnGnlInfField;
    
    private EventProcessingStatus6Choice[] evtPrcgStsField;
    
    private CorporateActionNarrative19 addtlInfField;
    
    private SupplementaryData1[] splmtryDataField;
    
    /// <remarks/>
    public DocumentIdentification17 NtfctnId {
        get {
            return this.ntfctnIdField;
        }
        set {
            this.ntfctnIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("OthrDocId")]
    public DocumentIdentification34[] OthrDocId {
        get {
            return this.othrDocIdField;
        }
        set {
            this.othrDocIdField = value;
        }
    }
    
    /// <remarks/>
    public CorporateActionGeneralInformation144 CorpActnGnlInf {
        get {
            return this.corpActnGnlInfField;
        }
        set {
            this.corpActnGnlInfField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("EvtPrcgSts")]
    public EventProcessingStatus6Choice[] EvtPrcgSts {
        get {
            return this.evtPrcgStsField;
        }
        set {
            this.evtPrcgStsField = value;
        }
    }
    
    /// <remarks/>
    public CorporateActionNarrative19 AddtlInf {
        get {
            return this.addtlInfField;
        }
        set {
            this.addtlInfField = value;
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.032.002.07")]
public partial class DocumentIdentification17 {
    
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.032.002.07")]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.032.002.07")]
public partial class CorporateActionNarrative19 {
    
    private string[] addtlTxtField;
    
    private string[] ptyCtctNrrtvField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("AddtlTxt")]
    public string[] AddtlTxt {
        get {
            return this.addtlTxtField;
        }
        set {
            this.addtlTxtField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("PtyCtctNrrtv")]
    public string[] PtyCtctNrrtv {
        get {
            return this.ptyCtctNrrtvField;
        }
        set {
            this.ptyCtctNrrtvField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.032.002.07")]
public partial class ProprietaryReason5 {
    
    private GenericIdentification47 rsnField;
    
    private string addtlRsnInfField;
    
    /// <remarks/>
    public GenericIdentification47 Rsn {
        get {
            return this.rsnField;
        }
        set {
            this.rsnField = value;
        }
    }
    
    /// <remarks/>
    public string AddtlRsnInf {
        get {
            return this.addtlRsnInfField;
        }
        set {
            this.addtlRsnInfField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.032.002.07")]
public partial class GenericIdentification47 {
    
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.032.002.07")]
public partial class ProprietaryStatusAndReason7 {
    
    private GenericIdentification47 prtryStsField;
    
    private ProprietaryReason5[] prtryRsnField;
    
    /// <remarks/>
    public GenericIdentification47 PrtrySts {
        get {
            return this.prtryStsField;
        }
        set {
            this.prtryStsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("PrtryRsn")]
    public ProprietaryReason5[] PrtryRsn {
        get {
            return this.prtryRsnField;
        }
        set {
            this.prtryRsnField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.032.002.07")]
public partial class PendingReason55Choice {
    
    private object itemField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Cd", typeof(PendingReason19Code))]
    [System.Xml.Serialization.XmlElementAttribute("Prtry", typeof(GenericIdentification47))]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.032.002.07")]
public enum PendingReason19Code {
    
    /// <remarks/>
    NSEC,
    
    /// <remarks/>
    NPAY,
    
    /// <remarks/>
    OTHR,
    
    /// <remarks/>
    AUTH,
    
    /// <remarks/>
    VLDA,
    
    /// <remarks/>
    MCER,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.032.002.07")]
public partial class PendingStatusReason19 {
    
    private PendingReason55Choice rsnCdField;
    
    private string addtlRsnInfField;
    
    /// <remarks/>
    public PendingReason55Choice RsnCd {
        get {
            return this.rsnCdField;
        }
        set {
            this.rsnCdField = value;
        }
    }
    
    /// <remarks/>
    public string AddtlRsnInf {
        get {
            return this.addtlRsnInfField;
        }
        set {
            this.addtlRsnInfField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.032.002.07")]
public partial class PendingStatus59Choice {
    
    private object[] itemsField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("NoSpcfdRsn", typeof(NoReasonCode))]
    [System.Xml.Serialization.XmlElementAttribute("Rsn", typeof(PendingStatusReason19))]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.032.002.07")]
public enum NoReasonCode {
    
    /// <remarks/>
    NORE,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.032.002.07")]
public partial class NoSpecifiedReason1 {
    
    private NoReasonCode noSpcfdRsnField;
    
    /// <remarks/>
    public NoReasonCode NoSpcfdRsn {
        get {
            return this.noSpcfdRsnField;
        }
        set {
            this.noSpcfdRsnField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.032.002.07")]
public partial class EventProcessingStatus6Choice {
    
    private object itemField;
    
    private ItemChoiceType2 itemElementNameField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Cmplt", typeof(NoSpecifiedReason1))]
    [System.Xml.Serialization.XmlElementAttribute("Pdg", typeof(PendingStatus59Choice))]
    [System.Xml.Serialization.XmlElementAttribute("PrtrySts", typeof(ProprietaryStatusAndReason7))]
    [System.Xml.Serialization.XmlElementAttribute("Rcncld", typeof(NoSpecifiedReason1))]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.032.002.07", IncludeInSchema=false)]
public enum ItemChoiceType2 {
    
    /// <remarks/>
    Cmplt,
    
    /// <remarks/>
    Pdg,
    
    /// <remarks/>
    PrtrySts,
    
    /// <remarks/>
    Rcncld,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.032.002.07")]
public partial class CorporateActionEventType90Choice {
    
    private object itemField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Cd", typeof(CorporateActionEventType29Code))]
    [System.Xml.Serialization.XmlElementAttribute("Prtry", typeof(GenericIdentification47))]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.032.002.07")]
public enum CorporateActionEventType29Code {
    
    /// <remarks/>
    ACTV,
    
    /// <remarks/>
    ATTI,
    
    /// <remarks/>
    BRUP,
    
    /// <remarks/>
    DFLT,
    
    /// <remarks/>
    BONU,
    
    /// <remarks/>
    EXRI,
    
    /// <remarks/>
    CAPD,
    
    /// <remarks/>
    CAPG,
    
    /// <remarks/>
    CAPI,
    
    /// <remarks/>
    DRCA,
    
    /// <remarks/>
    DVCA,
    
    /// <remarks/>
    CHAN,
    
    /// <remarks/>
    COOP,
    
    /// <remarks/>
    CLSA,
    
    /// <remarks/>
    CONS,
    
    /// <remarks/>
    CONV,
    
    /// <remarks/>
    CREV,
    
    /// <remarks/>
    DECR,
    
    /// <remarks/>
    DETI,
    
    /// <remarks/>
    DSCL,
    
    /// <remarks/>
    DVOP,
    
    /// <remarks/>
    DRIP,
    
    /// <remarks/>
    DRAW,
    
    /// <remarks/>
    DTCH,
    
    /// <remarks/>
    EXOF,
    
    /// <remarks/>
    REDM,
    
    /// <remarks/>
    MCAL,
    
    /// <remarks/>
    INCR,
    
    /// <remarks/>
    PPMT,
    
    /// <remarks/>
    INTR,
    
    /// <remarks/>
    RHDI,
    
    /// <remarks/>
    LIQU,
    
    /// <remarks/>
    EXTM,
    
    /// <remarks/>
    MRGR,
    
    /// <remarks/>
    NOOF,
    
    /// <remarks/>
    CERT,
    
    /// <remarks/>
    ODLT,
    
    /// <remarks/>
    OTHR,
    
    /// <remarks/>
    PARI,
    
    /// <remarks/>
    PCAL,
    
    /// <remarks/>
    PRED,
    
    /// <remarks/>
    PINK,
    
    /// <remarks/>
    PLAC,
    
    /// <remarks/>
    PDEF,
    
    /// <remarks/>
    PRIO,
    
    /// <remarks/>
    BPUT,
    
    /// <remarks/>
    REDO,
    
    /// <remarks/>
    REMK,
    
    /// <remarks/>
    BIDS,
    
    /// <remarks/>
    SPLR,
    
    /// <remarks/>
    RHTS,
    
    /// <remarks/>
    DVSC,
    
    /// <remarks/>
    SHPR,
    
    /// <remarks/>
    SMAL,
    
    /// <remarks/>
    SOFF,
    
    /// <remarks/>
    DVSE,
    
    /// <remarks/>
    SPLF,
    
    /// <remarks/>
    TREC,
    
    /// <remarks/>
    TEND,
    
    /// <remarks/>
    DLST,
    
    /// <remarks/>
    SUSP,
    
    /// <remarks/>
    EXWA,
    
    /// <remarks/>
    WTRC,
    
    /// <remarks/>
    WRTH,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.032.002.07")]
public partial class CorporateActionGeneralInformation144 {
    
    private string corpActnEvtIdField;
    
    private string offclCorpActnEvtIdField;
    
    private string clssActnNbField;
    
    private CorporateActionEventType90Choice evtTpField;
    
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
    public CorporateActionEventType90Choice EvtTp {
        get {
            return this.evtTpField;
        }
        set {
            this.evtTpField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.032.002.07")]
public partial class GenericIdentification86 {
    
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.032.002.07")]
public partial class DocumentNumber6Choice {
    
    private object itemField;
    
    private ItemChoiceType1 itemElementNameField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("LngNb", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("PrtryNb", typeof(GenericIdentification86))]
    [System.Xml.Serialization.XmlElementAttribute("ShrtNb", typeof(string))]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.032.002.07", IncludeInSchema=false)]
public enum ItemChoiceType1 {
    
    /// <remarks/>
    LngNb,
    
    /// <remarks/>
    PrtryNb,
    
    /// <remarks/>
    ShrtNb,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.032.002.07")]
public partial class DocumentIdentification4Choice {
    
    private string itemField;
    
    private ItemChoiceType itemElementNameField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("AcctOwnrDocId", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("AcctSvcrDocId", typeof(string))]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.032.002.07", IncludeInSchema=false)]
public enum ItemChoiceType {
    
    /// <remarks/>
    AcctOwnrDocId,
    
    /// <remarks/>
    AcctSvcrDocId,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.032.002.07")]
public partial class DocumentIdentification34 {
    
    private DocumentIdentification4Choice idField;
    
    private DocumentNumber6Choice docNbField;
    
    /// <remarks/>
    public DocumentIdentification4Choice Id {
        get {
            return this.idField;
        }
        set {
            this.idField = value;
        }
    }
    
    /// <remarks/>
    public DocumentNumber6Choice DocNb {
        get {
            return this.docNbField;
        }
        set {
            this.docNbField = value;
        }
    }
}

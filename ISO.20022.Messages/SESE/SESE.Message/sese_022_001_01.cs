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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.022.001.01")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.022.001.01", IsNullable=false)]
public partial class Document {
    
    private SecuritiesStatusOrStatementQueryStatusAdviceV01 sctiesStsOrStmtQryStsAdvcField;
    
    /// <remarks/>
    public SecuritiesStatusOrStatementQueryStatusAdviceV01 SctiesStsOrStmtQryStsAdvc {
        get {
            return this.sctiesStsOrStmtQryStsAdvcField;
        }
        set {
            this.sctiesStsOrStmtQryStsAdvcField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.022.001.01")]
public partial class SecuritiesStatusOrStatementQueryStatusAdviceV01 {
    
    private DocumentIdentification11 idField;
    
    private Identification1 qryRefField;
    
    private PartyIdentification13Choice acctOwnrField;
    
    private SecuritiesAccount13 sfkpgAcctField;
    
    private StatusOrStatement1Choice stsOrStmtReqdField;
    
    private ProcessingStatus4Choice prcgStsField;
    
    private PartyIdentification10Choice msgOrgtrField;
    
    private PartyIdentification10Choice msgRcptField;
    
    private Extension2[] xtnsnField;
    
    /// <remarks/>
    public DocumentIdentification11 Id {
        get {
            return this.idField;
        }
        set {
            this.idField = value;
        }
    }
    
    /// <remarks/>
    public Identification1 QryRef {
        get {
            return this.qryRefField;
        }
        set {
            this.qryRefField = value;
        }
    }
    
    /// <remarks/>
    public PartyIdentification13Choice AcctOwnr {
        get {
            return this.acctOwnrField;
        }
        set {
            this.acctOwnrField = value;
        }
    }
    
    /// <remarks/>
    public SecuritiesAccount13 SfkpgAcct {
        get {
            return this.sfkpgAcctField;
        }
        set {
            this.sfkpgAcctField = value;
        }
    }
    
    /// <remarks/>
    public StatusOrStatement1Choice StsOrStmtReqd {
        get {
            return this.stsOrStmtReqdField;
        }
        set {
            this.stsOrStmtReqdField = value;
        }
    }
    
    /// <remarks/>
    public ProcessingStatus4Choice PrcgSts {
        get {
            return this.prcgStsField;
        }
        set {
            this.prcgStsField = value;
        }
    }
    
    /// <remarks/>
    public PartyIdentification10Choice MsgOrgtr {
        get {
            return this.msgOrgtrField;
        }
        set {
            this.msgOrgtrField = value;
        }
    }
    
    /// <remarks/>
    public PartyIdentification10Choice MsgRcpt {
        get {
            return this.msgRcptField;
        }
        set {
            this.msgRcptField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Xtnsn")]
    public Extension2[] Xtnsn {
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.022.001.01")]
public partial class DocumentIdentification11 {
    
    private string idField;
    
    private DateAndDateTimeChoice creDtTmField;
    
    private CopyDuplicate1Code cpyDplctField;
    
    private bool cpyDplctFieldSpecified;
    
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
    public DateAndDateTimeChoice CreDtTm {
        get {
            return this.creDtTmField;
        }
        set {
            this.creDtTmField = value;
        }
    }
    
    /// <remarks/>
    public CopyDuplicate1Code CpyDplct {
        get {
            return this.cpyDplctField;
        }
        set {
            this.cpyDplctField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool CpyDplctSpecified {
        get {
            return this.cpyDplctFieldSpecified;
        }
        set {
            this.cpyDplctFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.022.001.01")]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.022.001.01", IncludeInSchema=false)]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.022.001.01")]
public partial class Extension2 {
    
    private string plcAndNmField;
    
    private System.Xml.XmlElement xtnsnEnvlpField;
    
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
    public System.Xml.XmlElement XtnsnEnvlp {
        get {
            return this.xtnsnEnvlpField;
        }
        set {
            this.xtnsnEnvlpField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.022.001.01")]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.022.001.01")]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.022.001.01")]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.022.001.01")]
public partial class PartyIdentification10Choice {
    
    private object itemField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("BICOrBEI", typeof(string))]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.022.001.01")]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.022.001.01")]
public partial class ProprietaryReason1 {
    
    private GenericIdentification20 rsnField;
    
    private string addtlRsnInfField;
    
    /// <remarks/>
    public GenericIdentification20 Rsn {
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.022.001.01")]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.022.001.01")]
public partial class ProprietaryStatusAndReason1 {
    
    private GenericIdentification20 prtryStsField;
    
    private ProprietaryReason1[] prtryRsnField;
    
    /// <remarks/>
    public GenericIdentification20 PrtrySts {
        get {
            return this.prtryStsField;
        }
        set {
            this.prtryStsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("PrtryRsn")]
    public ProprietaryReason1[] PrtryRsn {
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.022.001.01")]
public partial class RejectionAndRepairReason2Choice {
    
    private object itemField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Cd", typeof(RejectionReason24Code))]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.022.001.01")]
public enum RejectionReason24Code {
    
    /// <remarks/>
    SAFE,
    
    /// <remarks/>
    DSEC,
    
    /// <remarks/>
    LATE,
    
    /// <remarks/>
    REFE,
    
    /// <remarks/>
    ADEA,
    
    /// <remarks/>
    OTHR,
    
    /// <remarks/>
    MISM,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.022.001.01")]
public partial class RejectionOrRepairReason2 {
    
    private RejectionAndRepairReason2Choice cdField;
    
    private string addtlRsnInfField;
    
    /// <remarks/>
    public RejectionAndRepairReason2Choice Cd {
        get {
            return this.cdField;
        }
        set {
            this.cdField = value;
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.022.001.01")]
public partial class RejectionOrRepairStatus5Choice {
    
    private object[] itemsField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("NoSpcfdRsn", typeof(NoReasonCode))]
    [System.Xml.Serialization.XmlElementAttribute("Rsn", typeof(RejectionOrRepairReason2))]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.022.001.01")]
public enum NoReasonCode {
    
    /// <remarks/>
    NORE,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.022.001.01")]
public partial class AcknowledgementReason1Choice {
    
    private object itemField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Cd", typeof(AcknowledgementReason3Code))]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.022.001.01")]
public enum AcknowledgementReason3Code {
    
    /// <remarks/>
    ADEA,
    
    /// <remarks/>
    SMPG,
    
    /// <remarks/>
    OTHR,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.022.001.01")]
public partial class AcknowledgementReason1 {
    
    private AcknowledgementReason1Choice cdField;
    
    private string addtlRsnInfField;
    
    /// <remarks/>
    public AcknowledgementReason1Choice Cd {
        get {
            return this.cdField;
        }
        set {
            this.cdField = value;
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.022.001.01")]
public partial class AcknowledgedAcceptedStatus1Choice {
    
    private object[] itemsField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("NoSpcfdRsn", typeof(NoReasonCode))]
    [System.Xml.Serialization.XmlElementAttribute("Rsn", typeof(AcknowledgementReason1))]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.022.001.01")]
public partial class ProcessingStatus4Choice {
    
    private object itemField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("AckdAccptd", typeof(AcknowledgedAcceptedStatus1Choice))]
    [System.Xml.Serialization.XmlElementAttribute("Prtry", typeof(ProprietaryStatusAndReason1))]
    [System.Xml.Serialization.XmlElementAttribute("Rjctd", typeof(RejectionOrRepairStatus5Choice))]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.022.001.01")]
public partial class DocumentNumber1 {
    
    private DocumentNumber1Choice nbField;
    
    /// <remarks/>
    public DocumentNumber1Choice Nb {
        get {
            return this.nbField;
        }
        set {
            this.nbField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.022.001.01")]
public partial class DocumentNumber1Choice {
    
    private object itemField;
    
    private ItemChoiceType1 itemElementNameField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("LngNb", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("PrtryNb", typeof(GenericIdentification19))]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.022.001.01", IncludeInSchema=false)]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.022.001.01")]
public partial class Identification2 {
    
    private string acctOwnrTxIdField;
    
    private string acctSvcrTxIdField;
    
    private string mktInfrstrctrTxIdField;
    
    private string cmonIdField;
    
    private string[] tradIdField;
    
    private string mstrIdField;
    
    private string bsktIdField;
    
    private string indxIdField;
    
    private string listIdField;
    
    private string prgmIdField;
    
    private string poolIdField;
    
    private string corpActnEvtIdField;
    
    /// <remarks/>
    public string AcctOwnrTxId {
        get {
            return this.acctOwnrTxIdField;
        }
        set {
            this.acctOwnrTxIdField = value;
        }
    }
    
    /// <remarks/>
    public string AcctSvcrTxId {
        get {
            return this.acctSvcrTxIdField;
        }
        set {
            this.acctSvcrTxIdField = value;
        }
    }
    
    /// <remarks/>
    public string MktInfrstrctrTxId {
        get {
            return this.mktInfrstrctrTxIdField;
        }
        set {
            this.mktInfrstrctrTxIdField = value;
        }
    }
    
    /// <remarks/>
    public string CmonId {
        get {
            return this.cmonIdField;
        }
        set {
            this.cmonIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("TradId")]
    public string[] TradId {
        get {
            return this.tradIdField;
        }
        set {
            this.tradIdField = value;
        }
    }
    
    /// <remarks/>
    public string MstrId {
        get {
            return this.mstrIdField;
        }
        set {
            this.mstrIdField = value;
        }
    }
    
    /// <remarks/>
    public string BsktId {
        get {
            return this.bsktIdField;
        }
        set {
            this.bsktIdField = value;
        }
    }
    
    /// <remarks/>
    public string IndxId {
        get {
            return this.indxIdField;
        }
        set {
            this.indxIdField = value;
        }
    }
    
    /// <remarks/>
    public string ListId {
        get {
            return this.listIdField;
        }
        set {
            this.listIdField = value;
        }
    }
    
    /// <remarks/>
    public string PrgmId {
        get {
            return this.prgmIdField;
        }
        set {
            this.prgmIdField = value;
        }
    }
    
    /// <remarks/>
    public string PoolId {
        get {
            return this.poolIdField;
        }
        set {
            this.poolIdField = value;
        }
    }
    
    /// <remarks/>
    public string CorpActnEvtId {
        get {
            return this.corpActnEvtIdField;
        }
        set {
            this.corpActnEvtIdField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.022.001.01")]
public partial class DocumentNumber2 {
    
    private DocumentNumber1Choice nbField;
    
    private Identification2[] refsField;
    
    /// <remarks/>
    public DocumentNumber1Choice Nb {
        get {
            return this.nbField;
        }
        set {
            this.nbField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Refs")]
    public Identification2[] Refs {
        get {
            return this.refsField;
        }
        set {
            this.refsField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.022.001.01")]
public partial class StatusOrStatement1Choice {
    
    private object itemField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Stmt", typeof(DocumentNumber1))]
    [System.Xml.Serialization.XmlElementAttribute("StsAdvc", typeof(DocumentNumber2))]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.022.001.01")]
public partial class SecuritiesAccount13 {
    
    private string idField;
    
    private GenericIdentification20 tpField;
    
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
    public GenericIdentification20 Tp {
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.022.001.01")]
public partial class PartyIdentification13Choice {
    
    private object itemField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("BICOrBEI", typeof(string))]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.022.001.01")]
public partial class Identification1 {
    
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.022.001.01")]
public enum CopyDuplicate1Code {
    
    /// <remarks/>
    CODU,
    
    /// <remarks/>
    COPY,
    
    /// <remarks/>
    DUPL,
}

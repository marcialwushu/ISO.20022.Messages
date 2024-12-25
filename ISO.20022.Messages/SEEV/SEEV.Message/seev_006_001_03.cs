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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.006.001.03")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.006.001.03", IsNullable=false)]
public partial class Document {
    
    private MeetingInstructionStatusV03 mtgInstrStsField;
    
    /// <remarks/>
    public MeetingInstructionStatusV03 MtgInstrSts {
        get {
            return this.mtgInstrStsField;
        }
        set {
            this.mtgInstrStsField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.006.001.03")]
public partial class MeetingInstructionStatusV03 {
    
    private MessageIdentification1 idField;
    
    private InstructionType1Choice instrTpField;
    
    private MeetingReference4 mtgRefField;
    
    private PartyIdentification9Choice rptgPtyField;
    
    private SecurityIdentification11 sctyIdField;
    
    private InstructionTypeStatus1Choice instrTpStsField;
    
    /// <remarks/>
    public MessageIdentification1 Id {
        get {
            return this.idField;
        }
        set {
            this.idField = value;
        }
    }
    
    /// <remarks/>
    public InstructionType1Choice InstrTp {
        get {
            return this.instrTpField;
        }
        set {
            this.instrTpField = value;
        }
    }
    
    /// <remarks/>
    public MeetingReference4 MtgRef {
        get {
            return this.mtgRefField;
        }
        set {
            this.mtgRefField = value;
        }
    }
    
    /// <remarks/>
    public PartyIdentification9Choice RptgPty {
        get {
            return this.rptgPtyField;
        }
        set {
            this.rptgPtyField = value;
        }
    }
    
    /// <remarks/>
    public SecurityIdentification11 SctyId {
        get {
            return this.sctyIdField;
        }
        set {
            this.sctyIdField = value;
        }
    }
    
    /// <remarks/>
    public InstructionTypeStatus1Choice InstrTpSts {
        get {
            return this.instrTpStsField;
        }
        set {
            this.instrTpStsField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.006.001.03")]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.006.001.03")]
public partial class CancellationRejectionStatus1Choice {
    
    private object itemField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Cd", typeof(RejectionReason2Code))]
    [System.Xml.Serialization.XmlElementAttribute("Prtry", typeof(GenericIdentification13))]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.006.001.03")]
public enum RejectionReason2Code {
    
    /// <remarks/>
    ULNK,
    
    /// <remarks/>
    RBIS,
    
    /// <remarks/>
    INIR,
    
    /// <remarks/>
    ADEA,
    
    /// <remarks/>
    LATE,
    
    /// <remarks/>
    DCAN,
    
    /// <remarks/>
    DPRG,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.006.001.03")]
public partial class GenericIdentification13 {
    
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.006.001.03")]
public partial class AdditionalStatus2 {
    
    private CancellationRejectionStatus1Choice rsnField;
    
    private string addtlInfField;
    
    /// <remarks/>
    public CancellationRejectionStatus1Choice Rsn {
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.006.001.03")]
public partial class CancellationProcessingStatus1 {
    
    private CancellationStatus3Code stsField;
    
    private string addtlInfField;
    
    /// <remarks/>
    public CancellationStatus3Code Sts {
        get {
            return this.stsField;
        }
        set {
            this.stsField = value;
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.006.001.03")]
public enum CancellationStatus3Code {
    
    /// <remarks/>
    PACK,
    
    /// <remarks/>
    CANP,
    
    /// <remarks/>
    CAND,
    
    /// <remarks/>
    RCIS,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.006.001.03")]
public partial class CancellationStatus2Choice {
    
    private object itemField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("PrcgSts", typeof(CancellationProcessingStatus1))]
    [System.Xml.Serialization.XmlElementAttribute("RjctnSts", typeof(AdditionalStatus2))]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.006.001.03")]
public partial class DetailedInstructionStatus8 {
    
    private string instrIdField;
    
    private string acctIdField;
    
    private string subAcctIdField;
    
    private InstructionStatus4Choice instrStsField;
    
    /// <remarks/>
    public string InstrId {
        get {
            return this.instrIdField;
        }
        set {
            this.instrIdField = value;
        }
    }
    
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
    public string SubAcctId {
        get {
            return this.subAcctIdField;
        }
        set {
            this.subAcctIdField = value;
        }
    }
    
    /// <remarks/>
    public InstructionStatus4Choice InstrSts {
        get {
            return this.instrStsField;
        }
        set {
            this.instrStsField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.006.001.03")]
public partial class InstructionStatus4Choice {
    
    private object itemField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("PrcgSts", typeof(InstructionProcessingStatus1))]
    [System.Xml.Serialization.XmlElementAttribute("RjctnSts", typeof(AdditionalStatus1))]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.006.001.03")]
public partial class InstructionProcessingStatus1 {
    
    private Status3Code stsField;
    
    private string addtlInfField;
    
    /// <remarks/>
    public Status3Code Sts {
        get {
            return this.stsField;
        }
        set {
            this.stsField = value;
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.006.001.03")]
public enum Status3Code {
    
    /// <remarks/>
    CAND,
    
    /// <remarks/>
    PACK,
    
    /// <remarks/>
    NOIN,
    
    /// <remarks/>
    COMP,
    
    /// <remarks/>
    RCIS,
    
    /// <remarks/>
    STIN,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.006.001.03")]
public partial class AdditionalStatus1 {
    
    private InstructionRejectionStatus1Choice rsnField;
    
    private string addtlInfField;
    
    /// <remarks/>
    public InstructionRejectionStatus1Choice Rsn {
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.006.001.03")]
public partial class InstructionRejectionStatus1Choice {
    
    private object itemField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Cd", typeof(RejectionReason1Code))]
    [System.Xml.Serialization.XmlElementAttribute("Prtry", typeof(GenericIdentification13))]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.006.001.03")]
public enum RejectionReason1Code {
    
    /// <remarks/>
    ADEA,
    
    /// <remarks/>
    LATE,
    
    /// <remarks/>
    DQUA,
    
    /// <remarks/>
    IPOS,
    
    /// <remarks/>
    LACK,
    
    /// <remarks/>
    SAFE,
    
    /// <remarks/>
    RBIS,
    
    /// <remarks/>
    EVNM,
    
    /// <remarks/>
    ULNK,
    
    /// <remarks/>
    PRXY,
    
    /// <remarks/>
    PART,
    
    /// <remarks/>
    SPLT,
    
    /// <remarks/>
    IPOA,
    
    /// <remarks/>
    IREG,
    
    /// <remarks/>
    DSEC,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.006.001.03")]
public partial class InstructionStatus3Choice {
    
    private object[] itemsField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("DtldInstrSts", typeof(DetailedInstructionStatus8))]
    [System.Xml.Serialization.XmlElementAttribute("GblInstrSts", typeof(InstructionStatus4Choice))]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.006.001.03")]
public partial class InstructionTypeStatus1Choice {
    
    private object itemField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("CxlSts", typeof(CancellationStatus2Choice))]
    [System.Xml.Serialization.XmlElementAttribute("InstrSts", typeof(InstructionStatus3Choice))]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.006.001.03")]
public partial class IdentificationSource1Choice {
    
    private string itemField;
    
    private ItemChoiceType1 itemElementNameField;
    
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.006.001.03", IncludeInSchema=false)]
public enum ItemChoiceType1 {
    
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.006.001.03")]
public partial class AlternateIdentification1 {
    
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.006.001.03")]
public partial class SecurityIdentification11Choice {
    
    private object itemField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ISIN", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("OthrId", typeof(AlternateIdentification1))]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.006.001.03")]
public partial class SecurityIdentification11 {
    
    private SecurityIdentification11Choice idField;
    
    private string descField;
    
    /// <remarks/>
    public SecurityIdentification11Choice Id {
        get {
            return this.idField;
        }
        set {
            this.idField = value;
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.006.001.03")]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.006.001.03")]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.006.001.03")]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.006.001.03")]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.006.001.03")]
public partial class PartyIdentification9Choice {
    
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.006.001.03")]
public partial class MeetingTypeClassification1Choice {
    
    private object itemField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Cd", typeof(MeetingTypeClassification1Code))]
    [System.Xml.Serialization.XmlElementAttribute("Prtry", typeof(GenericIdentification13))]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.006.001.03")]
public enum MeetingTypeClassification1Code {
    
    /// <remarks/>
    AMET,
    
    /// <remarks/>
    OMET,
    
    /// <remarks/>
    CLAS,
    
    /// <remarks/>
    ISSU,
    
    /// <remarks/>
    VRHI,
    
    /// <remarks/>
    CORT,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.006.001.03")]
public partial class MeetingReference4 {
    
    private string mtgIdField;
    
    private string issrMtgIdField;
    
    private System.DateTime mtgDtAndTmField;
    
    private MeetingType2Code tpField;
    
    private MeetingTypeClassification1Choice clssfctnField;
    
    private PostalAddress1[] lctnField;
    
    /// <remarks/>
    public string MtgId {
        get {
            return this.mtgIdField;
        }
        set {
            this.mtgIdField = value;
        }
    }
    
    /// <remarks/>
    public string IssrMtgId {
        get {
            return this.issrMtgIdField;
        }
        set {
            this.issrMtgIdField = value;
        }
    }
    
    /// <remarks/>
    public System.DateTime MtgDtAndTm {
        get {
            return this.mtgDtAndTmField;
        }
        set {
            this.mtgDtAndTmField = value;
        }
    }
    
    /// <remarks/>
    public MeetingType2Code Tp {
        get {
            return this.tpField;
        }
        set {
            this.tpField = value;
        }
    }
    
    /// <remarks/>
    public MeetingTypeClassification1Choice Clssfctn {
        get {
            return this.clssfctnField;
        }
        set {
            this.clssfctnField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Lctn")]
    public PostalAddress1[] Lctn {
        get {
            return this.lctnField;
        }
        set {
            this.lctnField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.006.001.03")]
public enum MeetingType2Code {
    
    /// <remarks/>
    XMET,
    
    /// <remarks/>
    GMET,
    
    /// <remarks/>
    MIXD,
    
    /// <remarks/>
    SPCL,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.006.001.03")]
public partial class MessageIdentification {
    
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.006.001.03")]
public partial class InstructionType1Choice {
    
    private MessageIdentification itemField;
    
    private ItemChoiceType itemElementNameField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("InstrCxlId", typeof(MessageIdentification))]
    [System.Xml.Serialization.XmlElementAttribute("InstrId", typeof(MessageIdentification))]
    [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
    public MessageIdentification Item {
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.006.001.03", IncludeInSchema=false)]
public enum ItemChoiceType {
    
    /// <remarks/>
    InstrCxlId,
    
    /// <remarks/>
    InstrId,
}

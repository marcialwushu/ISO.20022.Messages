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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.022.001.01")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.022.001.01", IsNullable=false)]
public partial class Document {
    
    private AgentCAMovementStatusAdviceV01 agtCAMvmntStsAdvcField;
    
    /// <remarks/>
    public AgentCAMovementStatusAdviceV01 AgtCAMvmntStsAdvc {
        get {
            return this.agtCAMvmntStsAdvcField;
        }
        set {
            this.agtCAMvmntStsAdvcField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.022.001.01")]
public partial class AgentCAMovementStatusAdviceV01 {
    
    private DocumentIdentification8 idField;
    
    private DocumentIdentification8 itemField;
    
    private ItemChoiceType itemElementNameField;
    
    private CorporateActionInformation1 corpActnGnlInfField;
    
    private object item1Field;
    
    /// <remarks/>
    public DocumentIdentification8 Id {
        get {
            return this.idField;
        }
        set {
            this.idField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("AgtCAElctnStsAdvcId", typeof(DocumentIdentification8))]
    [System.Xml.Serialization.XmlElementAttribute("AgtCAGblDstrbtnStsAdvcId", typeof(DocumentIdentification8))]
    [System.Xml.Serialization.XmlElementAttribute("AgtCAMvmntCxlReqId", typeof(DocumentIdentification8))]
    [System.Xml.Serialization.XmlElementAttribute("AgtCAMvmntInstrId", typeof(DocumentIdentification8))]
    [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
    public DocumentIdentification8 Item {
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
    
    /// <remarks/>
    public CorporateActionInformation1 CorpActnGnlInf {
        get {
            return this.corpActnGnlInfField;
        }
        set {
            this.corpActnGnlInfField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("MvmntCxlStsDtls", typeof(CorporateMovementStatus2))]
    [System.Xml.Serialization.XmlElementAttribute("MvmntStsDtls", typeof(CorporateActionMovementStatus1Choice))]
    public object Item1 {
        get {
            return this.item1Field;
        }
        set {
            this.item1Field = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.022.001.01")]
public partial class DocumentIdentification8 {
    
    private string idField;
    
    private System.DateTime creDtTmField;
    
    private bool creDtTmFieldSpecified;
    
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
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool CreDtTmSpecified {
        get {
            return this.creDtTmFieldSpecified;
        }
        set {
            this.creDtTmFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.022.001.01")]
public partial class RejectionReason14FormatChoice {
    
    private object itemField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Cd", typeof(RejectionReason14Code))]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.022.001.01")]
public enum RejectionReason14Code {
    
    /// <remarks/>
    FAIL,
    
    /// <remarks/>
    LATT,
    
    /// <remarks/>
    INET,
    
    /// <remarks/>
    INUS,
    
    /// <remarks/>
    INPT,
    
    /// <remarks/>
    INMV,
    
    /// <remarks/>
    INDE,
    
    /// <remarks/>
    AGIN,
    
    /// <remarks/>
    INMO,
    
    /// <remarks/>
    SAID,
    
    /// <remarks/>
    INID,
    
    /// <remarks/>
    MOSE,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.022.001.01")]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.022.001.01")]
public partial class CorporateActionMovementRejectionStatus2 {
    
    private RejectionReason14FormatChoice[] rsnField;
    
    private string addtlInfField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Rsn")]
    public RejectionReason14FormatChoice[] Rsn {
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.022.001.01")]
public partial class ProcessedStatus2FormatChoice {
    
    private object itemField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Cd", typeof(ProcessedStatus2Code))]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.022.001.01")]
public enum ProcessedStatus2Code {
    
    /// <remarks/>
    RECE,
    
    /// <remarks/>
    COMP,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.022.001.01")]
public partial class CorporationActionMovementProcessingStatus2 {
    
    private ProcessedStatus2FormatChoice stsField;
    
    private string addtlInfField;
    
    /// <remarks/>
    public ProcessedStatus2FormatChoice Sts {
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
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.022.001.01")]
public partial class CorporateMovementStatus2 {
    
    private CorporationActionMovementProcessingStatus2 prcdStsField;
    
    private CorporateActionMovementRejectionStatus2 rjctdStsField;
    
    /// <remarks/>
    public CorporationActionMovementProcessingStatus2 PrcdSts {
        get {
            return this.prcdStsField;
        }
        set {
            this.prcdStsField = value;
        }
    }
    
    /// <remarks/>
    public CorporateActionMovementRejectionStatus2 RjctdSts {
        get {
            return this.rjctdStsField;
        }
        set {
            this.rjctdStsField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.022.001.01")]
public partial class RejectionReason13FormatChoice {
    
    private object itemField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Cd", typeof(RejectionReason13Code))]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.022.001.01")]
public enum RejectionReason13Code {
    
    /// <remarks/>
    FAIL,
    
    /// <remarks/>
    SAID,
    
    /// <remarks/>
    INID,
    
    /// <remarks/>
    REFI,
    
    /// <remarks/>
    MICA,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.022.001.01")]
public partial class CorporateActionMovementRejectionStatus1 {
    
    private RejectionReason13FormatChoice[] rsnField;
    
    private string addtlInfField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Rsn")]
    public RejectionReason13FormatChoice[] Rsn {
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.022.001.01")]
public partial class FailedSettlementReason1FormatChoice {
    
    private object itemField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Cd", typeof(FailedSettlementReason1Code))]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.022.001.01")]
public enum FailedSettlementReason1Code {
    
    /// <remarks/>
    CANE,
    
    /// <remarks/>
    CADI,
    
    /// <remarks/>
    DANE,
    
    /// <remarks/>
    AADI,
    
    /// <remarks/>
    INSE,
    
    /// <remarks/>
    INDI,
    
    /// <remarks/>
    INCA,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.022.001.01")]
public partial class UnitOrFaceAmount1Choice {
    
    private object itemField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("FaceAmt", typeof(ActiveCurrencyAndAmount))]
    [System.Xml.Serialization.XmlElementAttribute("Unit", typeof(decimal))]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.022.001.01")]
public partial class ActiveCurrencyAndAmount {
    
    private string ccyField;
    
    private decimal valueField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Ccy {
        get {
            return this.ccyField;
        }
        set {
            this.ccyField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public decimal Value {
        get {
            return this.valueField;
        }
        set {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.022.001.01")]
public partial class FailedMovement1 {
    
    private object itemField;
    
    private SecurityIdentification7 sctyIdField;
    
    private FailedSettlementReason1FormatChoice rsnField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("CshAmt", typeof(ActiveCurrencyAndAmount))]
    [System.Xml.Serialization.XmlElementAttribute("SctiesQty", typeof(UnitOrFaceAmount1Choice))]
    public object Item {
        get {
            return this.itemField;
        }
        set {
            this.itemField = value;
        }
    }
    
    /// <remarks/>
    public SecurityIdentification7 SctyId {
        get {
            return this.sctyIdField;
        }
        set {
            this.sctyIdField = value;
        }
    }
    
    /// <remarks/>
    public FailedSettlementReason1FormatChoice Rsn {
        get {
            return this.rsnField;
        }
        set {
            this.rsnField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.022.001.01")]
public partial class SecurityIdentification7 {
    
    private object itemField;
    
    private string descField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ISIN", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("OthrId", typeof(AlternateSecurityIdentification3))]
    public object Item {
        get {
            return this.itemField;
        }
        set {
            this.itemField = value;
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.022.001.01")]
public partial class AlternateSecurityIdentification3 {
    
    private string idField;
    
    private string itemField;
    
    private ItemChoiceType1 itemElementNameField;
    
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
    [System.Xml.Serialization.XmlElementAttribute("DmstIdSrc", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("PrtryIdSrc", typeof(string))]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.022.001.01", IncludeInSchema=false)]
public enum ItemChoiceType1 {
    
    /// <remarks/>
    DmstIdSrc,
    
    /// <remarks/>
    PrtryIdSrc,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.022.001.01")]
public partial class CorporateActionMovementFailedStatus1 {
    
    private string agtAcctIdField;
    
    private string clntAcctIdField;
    
    private PartyIdentification2Choice acctOwnrIdField;
    
    private FailedMovement1[] rsrcDtlsField;
    
    /// <remarks/>
    public string AgtAcctId {
        get {
            return this.agtAcctIdField;
        }
        set {
            this.agtAcctIdField = value;
        }
    }
    
    /// <remarks/>
    public string ClntAcctId {
        get {
            return this.clntAcctIdField;
        }
        set {
            this.clntAcctIdField = value;
        }
    }
    
    /// <remarks/>
    public PartyIdentification2Choice AcctOwnrId {
        get {
            return this.acctOwnrIdField;
        }
        set {
            this.acctOwnrIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("RsrcDtls")]
    public FailedMovement1[] RsrcDtls {
        get {
            return this.rsrcDtlsField;
        }
        set {
            this.rsrcDtlsField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.022.001.01")]
public partial class PartyIdentification2Choice {
    
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.022.001.01")]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.022.001.01")]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.022.001.01")]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.022.001.01")]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.022.001.01")]
public partial class ProcessedStatus3FormatChoice {
    
    private object itemField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Cd", typeof(ProcessedStatus3Code))]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.022.001.01")]
public enum ProcessedStatus3Code {
    
    /// <remarks/>
    RECE,
    
    /// <remarks/>
    PEND,
    
    /// <remarks/>
    PACK,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.022.001.01")]
public partial class CorporateActionMovementProcessingStatus1 {
    
    private ProcessedStatus3FormatChoice stsField;
    
    private string addtlInfField;
    
    /// <remarks/>
    public ProcessedStatus3FormatChoice Sts {
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
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.022.001.01")]
public partial class CorporateActionMovementStatus1Choice {
    
    private object itemField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("FaildSts", typeof(CorporateActionMovementFailedStatus1))]
    [System.Xml.Serialization.XmlElementAttribute("PrcdSts", typeof(CorporateActionMovementProcessingStatus1))]
    [System.Xml.Serialization.XmlElementAttribute("RjctdSts", typeof(CorporateActionMovementRejectionStatus1))]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.022.001.01")]
public partial class FinancialInstrumentDescription3 {
    
    private SecurityIdentification7 sctyIdField;
    
    private string plcOfListgField;
    
    private PartyIdentification2Choice sfkpgPlcField;
    
    /// <remarks/>
    public SecurityIdentification7 SctyId {
        get {
            return this.sctyIdField;
        }
        set {
            this.sctyIdField = value;
        }
    }
    
    /// <remarks/>
    public string PlcOfListg {
        get {
            return this.plcOfListgField;
        }
        set {
            this.plcOfListgField = value;
        }
    }
    
    /// <remarks/>
    public PartyIdentification2Choice SfkpgPlc {
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.022.001.01")]
public partial class CorporateActionEventProcessingType1FormatChoice {
    
    private object itemField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Cd", typeof(CorporateActionEventProcessingType1Code))]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.022.001.01")]
public enum CorporateActionEventProcessingType1Code {
    
    /// <remarks/>
    GENL,
    
    /// <remarks/>
    DISN,
    
    /// <remarks/>
    REOR,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.022.001.01")]
public partial class CorporateActionMandatoryVoluntary1FormatChoice {
    
    private object itemField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Cd", typeof(CorporateActionMandatoryVoluntary1Code))]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.022.001.01")]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.022.001.01")]
public partial class CorporateActionEventType2FormatChoice {
    
    private object itemField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Cd", typeof(CorporateActionEventType2Code))]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.022.001.01")]
public enum CorporateActionEventType2Code {
    
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
    OTHR,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.022.001.01")]
public partial class CorporateActionInformation1 {
    
    private PartyIdentification2Choice agtIdField;
    
    private string issrCorpActnIdField;
    
    private string corpActnPrcgIdField;
    
    private CorporateActionEventType2FormatChoice evtTpField;
    
    private CorporateActionMandatoryVoluntary1FormatChoice mndtryVlntryEvtTpField;
    
    private CorporateActionEventProcessingType1FormatChoice evtPrcgTpField;
    
    private FinancialInstrumentDescription3 undrlygSctyField;
    
    /// <remarks/>
    public PartyIdentification2Choice AgtId {
        get {
            return this.agtIdField;
        }
        set {
            this.agtIdField = value;
        }
    }
    
    /// <remarks/>
    public string IssrCorpActnId {
        get {
            return this.issrCorpActnIdField;
        }
        set {
            this.issrCorpActnIdField = value;
        }
    }
    
    /// <remarks/>
    public string CorpActnPrcgId {
        get {
            return this.corpActnPrcgIdField;
        }
        set {
            this.corpActnPrcgIdField = value;
        }
    }
    
    /// <remarks/>
    public CorporateActionEventType2FormatChoice EvtTp {
        get {
            return this.evtTpField;
        }
        set {
            this.evtTpField = value;
        }
    }
    
    /// <remarks/>
    public CorporateActionMandatoryVoluntary1FormatChoice MndtryVlntryEvtTp {
        get {
            return this.mndtryVlntryEvtTpField;
        }
        set {
            this.mndtryVlntryEvtTpField = value;
        }
    }
    
    /// <remarks/>
    public CorporateActionEventProcessingType1FormatChoice EvtPrcgTp {
        get {
            return this.evtPrcgTpField;
        }
        set {
            this.evtPrcgTpField = value;
        }
    }
    
    /// <remarks/>
    public FinancialInstrumentDescription3 UndrlygScty {
        get {
            return this.undrlygSctyField;
        }
        set {
            this.undrlygSctyField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.022.001.01", IncludeInSchema=false)]
public enum ItemChoiceType {
    
    /// <remarks/>
    AgtCAElctnStsAdvcId,
    
    /// <remarks/>
    AgtCAGblDstrbtnStsAdvcId,
    
    /// <remarks/>
    AgtCAMvmntCxlReqId,
    
    /// <remarks/>
    AgtCAMvmntInstrId,
}

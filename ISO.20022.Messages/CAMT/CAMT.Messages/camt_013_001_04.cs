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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.013.001.04")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.013.001.04", IsNullable=false)]
public partial class Document {
    
    private GetMemberV04 getMmbField;
    
    /// <remarks/>
    public GetMemberV04 GetMmb {
        get {
            return this.getMmbField;
        }
        set {
            this.getMmbField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.013.001.04")]
public partial class GetMemberV04 {
    
    private MessageHeader9 msgHdrField;
    
    private MemberQueryDefinition4 mmbQryDefField;
    
    private SupplementaryData1[] splmtryDataField;
    
    /// <remarks/>
    public MessageHeader9 MsgHdr {
        get {
            return this.msgHdrField;
        }
        set {
            this.msgHdrField = value;
        }
    }
    
    /// <remarks/>
    public MemberQueryDefinition4 MmbQryDef {
        get {
            return this.mmbQryDefField;
        }
        set {
            this.mmbQryDefField = value;
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.013.001.04")]
public partial class MessageHeader9 {
    
    private string msgIdField;
    
    private System.DateTime creDtTmField;
    
    private bool creDtTmFieldSpecified;
    
    private RequestType4Choice reqTpField;
    
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
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool CreDtTmSpecified {
        get {
            return this.creDtTmFieldSpecified;
        }
        set {
            this.creDtTmFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public RequestType4Choice ReqTp {
        get {
            return this.reqTpField;
        }
        set {
            this.reqTpField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.013.001.04")]
public partial class RequestType4Choice {
    
    private object itemField;
    
    private ItemChoiceType itemElementNameField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Enqry", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("PmtCtrl", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("Prtry", typeof(GenericIdentification1))]
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
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.013.001.04")]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.013.001.04")]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.013.001.04")]
public partial class MemberReturnCriteria1 {
    
    private bool nmIndField;
    
    private bool nmIndFieldSpecified;
    
    private bool mmbRtrAdrIndField;
    
    private bool mmbRtrAdrIndFieldSpecified;
    
    private bool acctIndField;
    
    private bool acctIndFieldSpecified;
    
    private bool tpIndField;
    
    private bool tpIndFieldSpecified;
    
    private bool stsIndField;
    
    private bool stsIndFieldSpecified;
    
    private bool ctctRefIndField;
    
    private bool ctctRefIndFieldSpecified;
    
    private bool comAdrIndField;
    
    private bool comAdrIndFieldSpecified;
    
    /// <remarks/>
    public bool NmInd {
        get {
            return this.nmIndField;
        }
        set {
            this.nmIndField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool NmIndSpecified {
        get {
            return this.nmIndFieldSpecified;
        }
        set {
            this.nmIndFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public bool MmbRtrAdrInd {
        get {
            return this.mmbRtrAdrIndField;
        }
        set {
            this.mmbRtrAdrIndField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool MmbRtrAdrIndSpecified {
        get {
            return this.mmbRtrAdrIndFieldSpecified;
        }
        set {
            this.mmbRtrAdrIndFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public bool AcctInd {
        get {
            return this.acctIndField;
        }
        set {
            this.acctIndField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool AcctIndSpecified {
        get {
            return this.acctIndFieldSpecified;
        }
        set {
            this.acctIndFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public bool TpInd {
        get {
            return this.tpIndField;
        }
        set {
            this.tpIndField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool TpIndSpecified {
        get {
            return this.tpIndFieldSpecified;
        }
        set {
            this.tpIndFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public bool StsInd {
        get {
            return this.stsIndField;
        }
        set {
            this.stsIndField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool StsIndSpecified {
        get {
            return this.stsIndFieldSpecified;
        }
        set {
            this.stsIndFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public bool CtctRefInd {
        get {
            return this.ctctRefIndField;
        }
        set {
            this.ctctRefIndField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool CtctRefIndSpecified {
        get {
            return this.ctctRefIndFieldSpecified;
        }
        set {
            this.ctctRefIndFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public bool ComAdrInd {
        get {
            return this.comAdrIndField;
        }
        set {
            this.comAdrIndField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool ComAdrIndSpecified {
        get {
            return this.comAdrIndFieldSpecified;
        }
        set {
            this.comAdrIndFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.013.001.04")]
public partial class SystemMemberStatus1Choice {
    
    private object itemField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Cd", typeof(MemberStatus1Code))]
    [System.Xml.Serialization.XmlElementAttribute("Prtry", typeof(string))]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.013.001.04")]
public enum MemberStatus1Code {
    
    /// <remarks/>
    ENBL,
    
    /// <remarks/>
    DSBL,
    
    /// <remarks/>
    DLTD,
    
    /// <remarks/>
    JOIN,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.013.001.04")]
public partial class SystemMemberType1Choice {
    
    private string itemField;
    
    private ItemChoiceType3 itemElementNameField;
    
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
    public ItemChoiceType3 ItemElementName {
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.013.001.04", IncludeInSchema=false)]
public enum ItemChoiceType3 {
    
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.013.001.04")]
public partial class FinancialIdentificationSchemeName1Choice {
    
    private string itemField;
    
    private ItemChoiceType2 itemElementNameField;
    
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.013.001.04", IncludeInSchema=false)]
public enum ItemChoiceType2 {
    
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.013.001.04")]
public partial class GenericFinancialIdentification1 {
    
    private string idField;
    
    private FinancialIdentificationSchemeName1Choice schmeNmField;
    
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
    public FinancialIdentificationSchemeName1Choice SchmeNm {
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.013.001.04")]
public partial class ClearingSystemIdentification2Choice {
    
    private string itemField;
    
    private ItemChoiceType1 itemElementNameField;
    
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.013.001.04", IncludeInSchema=false)]
public enum ItemChoiceType1 {
    
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.013.001.04")]
public partial class ClearingSystemMemberIdentification2 {
    
    private ClearingSystemIdentification2Choice clrSysIdField;
    
    private string mmbIdField;
    
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
    public string MmbId {
        get {
            return this.mmbIdField;
        }
        set {
            this.mmbIdField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.013.001.04")]
public partial class MemberIdentification3Choice {
    
    private object itemField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("BICFI", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("ClrSysMmbId", typeof(ClearingSystemMemberIdentification2))]
    [System.Xml.Serialization.XmlElementAttribute("Othr", typeof(GenericFinancialIdentification1))]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.013.001.04")]
public partial class MemberSearchCriteria4 {
    
    private MemberIdentification3Choice[] idField;
    
    private SystemMemberType1Choice[] tpField;
    
    private SystemMemberStatus1Choice[] stsField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Id")]
    public MemberIdentification3Choice[] Id {
        get {
            return this.idField;
        }
        set {
            this.idField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Tp")]
    public SystemMemberType1Choice[] Tp {
        get {
            return this.tpField;
        }
        set {
            this.tpField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Sts")]
    public SystemMemberStatus1Choice[] Sts {
        get {
            return this.stsField;
        }
        set {
            this.stsField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.013.001.04")]
public partial class MemberCriteria4 {
    
    private string newQryNmField;
    
    private MemberSearchCriteria4[] schCritField;
    
    private MemberReturnCriteria1 rtrCritField;
    
    /// <remarks/>
    public string NewQryNm {
        get {
            return this.newQryNmField;
        }
        set {
            this.newQryNmField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("SchCrit")]
    public MemberSearchCriteria4[] SchCrit {
        get {
            return this.schCritField;
        }
        set {
            this.schCritField = value;
        }
    }
    
    /// <remarks/>
    public MemberReturnCriteria1 RtrCrit {
        get {
            return this.rtrCritField;
        }
        set {
            this.rtrCritField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.013.001.04")]
public partial class MemberCriteriaDefinition2Choice {
    
    private object itemField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("NewCrit", typeof(MemberCriteria4))]
    [System.Xml.Serialization.XmlElementAttribute("QryNm", typeof(string))]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.013.001.04")]
public partial class MemberQueryDefinition4 {
    
    private QueryType2Code qryTpField;
    
    private bool qryTpFieldSpecified;
    
    private MemberCriteriaDefinition2Choice mmbCritField;
    
    /// <remarks/>
    public QueryType2Code QryTp {
        get {
            return this.qryTpField;
        }
        set {
            this.qryTpField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool QryTpSpecified {
        get {
            return this.qryTpFieldSpecified;
        }
        set {
            this.qryTpFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public MemberCriteriaDefinition2Choice MmbCrit {
        get {
            return this.mmbCritField;
        }
        set {
            this.mmbCritField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.013.001.04")]
public enum QueryType2Code {
    
    /// <remarks/>
    ALLL,
    
    /// <remarks/>
    CHNG,
    
    /// <remarks/>
    MODF,
    
    /// <remarks/>
    DELD,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.013.001.04", IncludeInSchema=false)]
public enum ItemChoiceType {
    
    /// <remarks/>
    Enqry,
    
    /// <remarks/>
    PmtCtrl,
    
    /// <remarks/>
    Prtry,
}

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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.016.001.04")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.016.001.04", IsNullable=false)]
public partial class Document {
    
    private GetCurrencyExchangeRateV04 getCcyXchgRateField;
    
    /// <remarks/>
    public GetCurrencyExchangeRateV04 GetCcyXchgRate {
        get {
            return this.getCcyXchgRateField;
        }
        set {
            this.getCcyXchgRateField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.016.001.04")]
public partial class GetCurrencyExchangeRateV04 {
    
    private MessageHeader1 msgHdrField;
    
    private CurrencyQueryDefinition3 ccyQryDefField;
    
    private SupplementaryData1[] splmtryDataField;
    
    /// <remarks/>
    public MessageHeader1 MsgHdr {
        get {
            return this.msgHdrField;
        }
        set {
            this.msgHdrField = value;
        }
    }
    
    /// <remarks/>
    public CurrencyQueryDefinition3 CcyQryDef {
        get {
            return this.ccyQryDefField;
        }
        set {
            this.ccyQryDefField = value;
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.016.001.04")]
public partial class MessageHeader1 {
    
    private string msgIdField;
    
    private System.DateTime creDtTmField;
    
    private bool creDtTmFieldSpecified;
    
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
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.016.001.04")]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.016.001.04")]
public partial class CurrencyExchangeSearchCriteria1 {
    
    private string srcCcyField;
    
    private string trgtCcyField;
    
    /// <remarks/>
    public string SrcCcy {
        get {
            return this.srcCcyField;
        }
        set {
            this.srcCcyField = value;
        }
    }
    
    /// <remarks/>
    public string TrgtCcy {
        get {
            return this.trgtCcyField;
        }
        set {
            this.trgtCcyField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.016.001.04")]
public partial class CurrencyExchangeCriteria2 {
    
    private string newQryNmField;
    
    private CurrencyExchangeSearchCriteria1[] schCritField;
    
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
    public CurrencyExchangeSearchCriteria1[] SchCrit {
        get {
            return this.schCritField;
        }
        set {
            this.schCritField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.016.001.04")]
public partial class CurrencyCriteriaDefinition1Choice {
    
    private object itemField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("NewCrit", typeof(CurrencyExchangeCriteria2))]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.016.001.04")]
public partial class CurrencyQueryDefinition3 {
    
    private QueryType2Code qryTpField;
    
    private bool qryTpFieldSpecified;
    
    private CurrencyCriteriaDefinition1Choice ccyCritField;
    
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
    public CurrencyCriteriaDefinition1Choice CcyCrit {
        get {
            return this.ccyCritField;
        }
        set {
            this.ccyCritField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.016.001.04")]
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

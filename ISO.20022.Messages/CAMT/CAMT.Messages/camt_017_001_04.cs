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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.017.001.04")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.017.001.04", IsNullable=false)]
public partial class Document {
    
    private ReturnCurrencyExchangeRateV04 rtrCcyXchgRateField;
    
    /// <remarks/>
    public ReturnCurrencyExchangeRateV04 RtrCcyXchgRate {
        get {
            return this.rtrCcyXchgRateField;
        }
        set {
            this.rtrCcyXchgRateField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.017.001.04")]
public partial class ReturnCurrencyExchangeRateV04 {
    
    private MessageHeader7 msgHdrField;
    
    private ExchangeRateReportOrError1Choice rptOrErrField;
    
    private SupplementaryData1[] splmtryDataField;
    
    /// <remarks/>
    public MessageHeader7 MsgHdr {
        get {
            return this.msgHdrField;
        }
        set {
            this.msgHdrField = value;
        }
    }
    
    /// <remarks/>
    public ExchangeRateReportOrError1Choice RptOrErr {
        get {
            return this.rptOrErrField;
        }
        set {
            this.rptOrErrField = value;
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.017.001.04")]
public partial class MessageHeader7 {
    
    private string msgIdField;
    
    private System.DateTime creDtTmField;
    
    private bool creDtTmFieldSpecified;
    
    private RequestType4Choice reqTpField;
    
    private OriginalBusinessQuery1 orgnlBizQryField;
    
    private string qryNmField;
    
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
    
    /// <remarks/>
    public OriginalBusinessQuery1 OrgnlBizQry {
        get {
            return this.orgnlBizQryField;
        }
        set {
            this.orgnlBizQryField = value;
        }
    }
    
    /// <remarks/>
    public string QryNm {
        get {
            return this.qryNmField;
        }
        set {
            this.qryNmField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.017.001.04")]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.017.001.04")]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.017.001.04")]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.017.001.04")]
public partial class CurrencyExchange7 {
    
    private decimal xchgRateField;
    
    private string qtdCcyField;
    
    private System.DateTime qtnDtField;
    
    /// <remarks/>
    public decimal XchgRate {
        get {
            return this.xchgRateField;
        }
        set {
            this.xchgRateField = value;
        }
    }
    
    /// <remarks/>
    public string QtdCcy {
        get {
            return this.qtdCcyField;
        }
        set {
            this.qtdCcyField = value;
        }
    }
    
    /// <remarks/>
    public System.DateTime QtnDt {
        get {
            return this.qtnDtField;
        }
        set {
            this.qtnDtField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.017.001.04")]
public partial class ErrorHandling1Choice {
    
    private object itemField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Cd", typeof(ErrorHandling1Code))]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.017.001.04")]
public enum ErrorHandling1Code {
    
    /// <remarks/>
    X020,
    
    /// <remarks/>
    X030,
    
    /// <remarks/>
    X050,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.017.001.04")]
public partial class ErrorHandling3 {
    
    private ErrorHandling1Choice errField;
    
    private string descField;
    
    /// <remarks/>
    public ErrorHandling1Choice Err {
        get {
            return this.errField;
        }
        set {
            this.errField = value;
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.017.001.04")]
public partial class ExchangeRateReportOrError2Choice {
    
    private object[] itemsField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("BizErr", typeof(ErrorHandling3))]
    [System.Xml.Serialization.XmlElementAttribute("CcyXchg", typeof(CurrencyExchange7))]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.017.001.04")]
public partial class CurrencySourceTarget1 {
    
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.017.001.04")]
public partial class CurrencyExchangeReport3 {
    
    private CurrencySourceTarget1 ccyRefField;
    
    private ExchangeRateReportOrError2Choice ccyXchgOrErrField;
    
    /// <remarks/>
    public CurrencySourceTarget1 CcyRef {
        get {
            return this.ccyRefField;
        }
        set {
            this.ccyRefField = value;
        }
    }
    
    /// <remarks/>
    public ExchangeRateReportOrError2Choice CcyXchgOrErr {
        get {
            return this.ccyXchgOrErrField;
        }
        set {
            this.ccyXchgOrErrField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.017.001.04")]
public partial class ExchangeRateReportOrError1Choice {
    
    private object[] itemsField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("CcyXchgRpt", typeof(CurrencyExchangeReport3))]
    [System.Xml.Serialization.XmlElementAttribute("OprlErr", typeof(ErrorHandling3))]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.017.001.04")]
public partial class OriginalBusinessQuery1 {
    
    private string msgIdField;
    
    private string msgNmIdField;
    
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
    public string MsgNmId {
        get {
            return this.msgNmIdField;
        }
        set {
            this.msgNmIdField = value;
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.017.001.04", IncludeInSchema=false)]
public enum ItemChoiceType {
    
    /// <remarks/>
    Enqry,
    
    /// <remarks/>
    PmtCtrl,
    
    /// <remarks/>
    Prtry,
}

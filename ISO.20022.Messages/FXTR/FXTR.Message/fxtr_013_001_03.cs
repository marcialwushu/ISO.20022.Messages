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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:fxtr.013.001.03")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:fxtr.013.001.03", IsNullable=false)]
public partial class Document {
    
    private ForeignExchangeTradeWithdrawalNotificationV03 fXTradWdrwlNtfctnField;
    
    /// <remarks/>
    public ForeignExchangeTradeWithdrawalNotificationV03 FXTradWdrwlNtfctn {
        get {
            return this.fXTradWdrwlNtfctnField;
        }
        set {
            this.fXTradWdrwlNtfctnField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:fxtr.013.001.03")]
public partial class ForeignExchangeTradeWithdrawalNotificationV03 {
    
    private string msgIdField;
    
    private string mtchgSysUnqRefField;
    
    private WithdrawalReason1 wdrwlRsnField;
    
    private string sttlmSsnIdrField;
    
    private SupplementaryData1[] splmtryDataField;
    
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
    public string MtchgSysUnqRef {
        get {
            return this.mtchgSysUnqRefField;
        }
        set {
            this.mtchgSysUnqRefField = value;
        }
    }
    
    /// <remarks/>
    public WithdrawalReason1 WdrwlRsn {
        get {
            return this.wdrwlRsnField;
        }
        set {
            this.wdrwlRsnField = value;
        }
    }
    
    /// <remarks/>
    public string SttlmSsnIdr {
        get {
            return this.sttlmSsnIdrField;
        }
        set {
            this.sttlmSsnIdrField = value;
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:fxtr.013.001.03")]
public partial class WithdrawalReason1 {
    
    private WithdrawalReason1Code wdrwlRsnCdField;
    
    private string wdrwlRsnSubCdField;
    
    /// <remarks/>
    public WithdrawalReason1Code WdrwlRsnCd {
        get {
            return this.wdrwlRsnCdField;
        }
        set {
            this.wdrwlRsnCdField = value;
        }
    }
    
    /// <remarks/>
    public string WdrwlRsnSubCd {
        get {
            return this.wdrwlRsnSubCdField;
        }
        set {
            this.wdrwlRsnSubCdField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:fxtr.013.001.03")]
public enum WithdrawalReason1Code {
    
    /// <remarks/>
    RJCT,
    
    /// <remarks/>
    RSCD,
    
    /// <remarks/>
    WTDN,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:fxtr.013.001.03")]
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

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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.043.001.01")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.043.001.01", IsNullable=false)]
public partial class Document {
    
    private FinancialInstrumentReportingReferenceDataIndexReportV01 finInstrmRptgRefDataIndxRptField;
    
    /// <remarks/>
    public FinancialInstrumentReportingReferenceDataIndexReportV01 FinInstrmRptgRefDataIndxRpt {
        get {
            return this.finInstrmRptgRefDataIndxRptField;
        }
        set {
            this.finInstrmRptgRefDataIndxRptField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.043.001.01")]
public partial class FinancialInstrumentReportingReferenceDataIndexReportV01 {
    
    private SecuritiesMarketReportHeader1 rptHdrField;
    
    private SecuritiesIndexReport1[] indxDataField;
    
    private SupplementaryData1[] splmtryDataField;
    
    /// <remarks/>
    public SecuritiesMarketReportHeader1 RptHdr {
        get {
            return this.rptHdrField;
        }
        set {
            this.rptHdrField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("IndxData")]
    public SecuritiesIndexReport1[] IndxData {
        get {
            return this.indxDataField;
        }
        set {
            this.indxDataField = value;
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.043.001.01")]
public partial class SecuritiesMarketReportHeader1 {
    
    private TradingVenueIdentification1Choice rptgNttyField;
    
    private Period4Choice rptgPrdField;
    
    private System.DateTime submissnDtTmField;
    
    private bool submissnDtTmFieldSpecified;
    
    /// <remarks/>
    public TradingVenueIdentification1Choice RptgNtty {
        get {
            return this.rptgNttyField;
        }
        set {
            this.rptgNttyField = value;
        }
    }
    
    /// <remarks/>
    public Period4Choice RptgPrd {
        get {
            return this.rptgPrdField;
        }
        set {
            this.rptgPrdField = value;
        }
    }
    
    /// <remarks/>
    public System.DateTime SubmissnDtTm {
        get {
            return this.submissnDtTmField;
        }
        set {
            this.submissnDtTmField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool SubmissnDtTmSpecified {
        get {
            return this.submissnDtTmFieldSpecified;
        }
        set {
            this.submissnDtTmFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.043.001.01")]
public partial class TradingVenueIdentification1Choice {
    
    private object itemField;
    
    private ItemChoiceType itemElementNameField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("MktIdCd", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("NtlCmptntAuthrty", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("Othr", typeof(TradingVenueIdentification2))]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.043.001.01")]
public partial class TradingVenueIdentification2 {
    
    private string idField;
    
    private TradingVenue2Code tpField;
    
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
    public TradingVenue2Code Tp {
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.043.001.01")]
public enum TradingVenue2Code {
    
    /// <remarks/>
    APPA,
    
    /// <remarks/>
    CTPS,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.043.001.01")]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.043.001.01")]
public partial class FinancialInstrument46Choice {
    
    private object itemField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ISIN", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("Indx", typeof(BenchmarkCurveName2Code))]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.043.001.01")]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.043.001.01")]
public partial class SecuritiesIndexReport1 {
    
    private string techRcrdIdField;
    
    private string rqstngNttyField;
    
    private FinancialInstrument46Choice indxField;
    
    private Period4Choice vldtyPrdField;
    
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
    public string RqstngNtty {
        get {
            return this.rqstngNttyField;
        }
        set {
            this.rqstngNttyField = value;
        }
    }
    
    /// <remarks/>
    public FinancialInstrument46Choice Indx {
        get {
            return this.indxField;
        }
        set {
            this.indxField = value;
        }
    }
    
    /// <remarks/>
    public Period4Choice VldtyPrd {
        get {
            return this.vldtyPrdField;
        }
        set {
            this.vldtyPrdField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.043.001.01")]
public partial class Period4Choice {
    
    private object itemField;
    
    private ItemChoiceType1 itemElementNameField;
    
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
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.043.001.01")]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.043.001.01", IncludeInSchema=false)]
public enum ItemChoiceType1 {
    
    /// <remarks/>
    Dt,
    
    /// <remarks/>
    FrDt,
    
    /// <remarks/>
    FrDtToDt,
    
    /// <remarks/>
    ToDt,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.043.001.01", IncludeInSchema=false)]
public enum ItemChoiceType {
    
    /// <remarks/>
    MktIdCd,
    
    /// <remarks/>
    NtlCmptntAuthrty,
    
    /// <remarks/>
    Othr,
}
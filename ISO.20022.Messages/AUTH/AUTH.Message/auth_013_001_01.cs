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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.013.001.01")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.013.001.01", IsNullable=false)]
public partial class Document {
    
    private MoneyMarketUnsecuredMarketStatisticalReportV01 mnyMktUscrdMktSttstclRptField;
    
    /// <remarks/>
    public MoneyMarketUnsecuredMarketStatisticalReportV01 MnyMktUscrdMktSttstclRpt {
        get {
            return this.mnyMktUscrdMktSttstclRptField;
        }
        set {
            this.mnyMktUscrdMktSttstclRptField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.013.001.01")]
public partial class MoneyMarketUnsecuredMarketStatisticalReportV01 {
    
    private MoneyMarketReportHeader1 rptHdrField;
    
    private UnsecuredMarketReport3Choice uscrdMktRptField;
    
    private SupplementaryData1[] splmtryDataField;
    
    /// <remarks/>
    public MoneyMarketReportHeader1 RptHdr {
        get {
            return this.rptHdrField;
        }
        set {
            this.rptHdrField = value;
        }
    }
    
    /// <remarks/>
    public UnsecuredMarketReport3Choice UscrdMktRpt {
        get {
            return this.uscrdMktRptField;
        }
        set {
            this.uscrdMktRptField = value;
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.013.001.01")]
public partial class MoneyMarketReportHeader1 {
    
    private string rptgAgtField;
    
    private DateTimePeriod1 refPrdField;
    
    /// <remarks/>
    public string RptgAgt {
        get {
            return this.rptgAgtField;
        }
        set {
            this.rptgAgtField = value;
        }
    }
    
    /// <remarks/>
    public DateTimePeriod1 RefPrd {
        get {
            return this.refPrdField;
        }
        set {
            this.refPrdField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.013.001.01")]
public partial class DateTimePeriod1 {
    
    private System.DateTime frDtTmField;
    
    private System.DateTime toDtTmField;
    
    /// <remarks/>
    public System.DateTime FrDtTm {
        get {
            return this.frDtTmField;
        }
        set {
            this.frDtTmField = value;
        }
    }
    
    /// <remarks/>
    public System.DateTime ToDtTm {
        get {
            return this.toDtTmField;
        }
        set {
            this.toDtTmField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.013.001.01")]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.013.001.01")]
public partial class OptionDateOrPeriod1Choice {
    
    private object itemField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("EarlstExrcDt", typeof(System.DateTime), DataType="date")]
    [System.Xml.Serialization.XmlElementAttribute("NtcePrd", typeof(decimal))]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.013.001.01")]
public partial class Option12 {
    
    private OptionType1Code tpField;
    
    private OptionDateOrPeriod1Choice dtOrPrdField;
    
    /// <remarks/>
    public OptionType1Code Tp {
        get {
            return this.tpField;
        }
        set {
            this.tpField = value;
        }
    }
    
    /// <remarks/>
    public OptionDateOrPeriod1Choice DtOrPrd {
        get {
            return this.dtOrPrdField;
        }
        set {
            this.dtOrPrdField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.013.001.01")]
public enum OptionType1Code {
    
    /// <remarks/>
    CALL,
    
    /// <remarks/>
    PUTO,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.013.001.01")]
public partial class FloatingRateNote2 {
    
    private string refRateIndxField;
    
    private decimal bsisPtSprdField;
    
    /// <remarks/>
    public string RefRateIndx {
        get {
            return this.refRateIndxField;
        }
        set {
            this.refRateIndxField = value;
        }
    }
    
    /// <remarks/>
    public decimal BsisPtSprd {
        get {
            return this.bsisPtSprdField;
        }
        set {
            this.bsisPtSprdField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.013.001.01")]
public partial class Rate2 {
    
    private bool sgnField;
    
    private bool sgnFieldSpecified;
    
    private decimal rateField;
    
    /// <remarks/>
    public bool Sgn {
        get {
            return this.sgnField;
        }
        set {
            this.sgnField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool SgnSpecified {
        get {
            return this.sgnFieldSpecified;
        }
        set {
            this.sgnFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public decimal Rate {
        get {
            return this.rateField;
        }
        set {
            this.rateField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.013.001.01")]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.013.001.01")]
public partial class DateAndDateTimeChoice {
    
    private System.DateTime itemField;
    
    private ItemChoiceType1 itemElementNameField;
    
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.013.001.01", IncludeInSchema=false)]
public enum ItemChoiceType1 {
    
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.013.001.01")]
public partial class NameOrSector1Choice {
    
    private string itemField;
    
    private ItemChoiceType itemElementNameField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Nm", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("Sctr", typeof(string))]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.013.001.01", IncludeInSchema=false)]
public enum ItemChoiceType {
    
    /// <remarks/>
    Nm,
    
    /// <remarks/>
    Sctr,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.013.001.01")]
public partial class ReportedPartyIdentification1 {
    
    private NameOrSector1Choice nmOrSctrField;
    
    private string lctnField;
    
    /// <remarks/>
    public NameOrSector1Choice NmOrSctr {
        get {
            return this.nmOrSctrField;
        }
        set {
            this.nmOrSctrField = value;
        }
    }
    
    /// <remarks/>
    public string Lctn {
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
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.013.001.01")]
public partial class CounterpartyIdentification2Choice {
    
    private object itemField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("LEI", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("Othr", typeof(ReportedPartyIdentification1))]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.013.001.01")]
public partial class UnsecuredMarketTransaction3 {
    
    private TransactionOperationType1Code rptdTxStsField;
    
    private string brnchIdField;
    
    private string unqTxIdrField;
    
    private string prtryTxIdField;
    
    private string ctrPtyPrtryTxIdField;
    
    private CounterpartyIdentification2Choice ctrPtyIdField;
    
    private DateAndDateTimeChoice tradDtField;
    
    private System.DateTime sttlmDtField;
    
    private System.DateTime mtrtyDtField;
    
    private MoneyMarketTransactionType1Code txTpField;
    
    private FinancialInstrumentProductType1Code instrmTpField;
    
    private ActiveCurrencyAndAmount txNmnlAmtField;
    
    private decimal dealPricField;
    
    private InterestRateType1Code rateTpField;
    
    private Rate2 dealRateField;
    
    private FloatingRateNote2 fltgRateNoteField;
    
    private BrokeredDeal1Code brkrdDealField;
    
    private bool brkrdDealFieldSpecified;
    
    private Option12[] callPutOptnField;
    
    private SupplementaryData1[] splmtryDataField;
    
    /// <remarks/>
    public TransactionOperationType1Code RptdTxSts {
        get {
            return this.rptdTxStsField;
        }
        set {
            this.rptdTxStsField = value;
        }
    }
    
    /// <remarks/>
    public string BrnchId {
        get {
            return this.brnchIdField;
        }
        set {
            this.brnchIdField = value;
        }
    }
    
    /// <remarks/>
    public string UnqTxIdr {
        get {
            return this.unqTxIdrField;
        }
        set {
            this.unqTxIdrField = value;
        }
    }
    
    /// <remarks/>
    public string PrtryTxId {
        get {
            return this.prtryTxIdField;
        }
        set {
            this.prtryTxIdField = value;
        }
    }
    
    /// <remarks/>
    public string CtrPtyPrtryTxId {
        get {
            return this.ctrPtyPrtryTxIdField;
        }
        set {
            this.ctrPtyPrtryTxIdField = value;
        }
    }
    
    /// <remarks/>
    public CounterpartyIdentification2Choice CtrPtyId {
        get {
            return this.ctrPtyIdField;
        }
        set {
            this.ctrPtyIdField = value;
        }
    }
    
    /// <remarks/>
    public DateAndDateTimeChoice TradDt {
        get {
            return this.tradDtField;
        }
        set {
            this.tradDtField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
    public System.DateTime SttlmDt {
        get {
            return this.sttlmDtField;
        }
        set {
            this.sttlmDtField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
    public System.DateTime MtrtyDt {
        get {
            return this.mtrtyDtField;
        }
        set {
            this.mtrtyDtField = value;
        }
    }
    
    /// <remarks/>
    public MoneyMarketTransactionType1Code TxTp {
        get {
            return this.txTpField;
        }
        set {
            this.txTpField = value;
        }
    }
    
    /// <remarks/>
    public FinancialInstrumentProductType1Code InstrmTp {
        get {
            return this.instrmTpField;
        }
        set {
            this.instrmTpField = value;
        }
    }
    
    /// <remarks/>
    public ActiveCurrencyAndAmount TxNmnlAmt {
        get {
            return this.txNmnlAmtField;
        }
        set {
            this.txNmnlAmtField = value;
        }
    }
    
    /// <remarks/>
    public decimal DealPric {
        get {
            return this.dealPricField;
        }
        set {
            this.dealPricField = value;
        }
    }
    
    /// <remarks/>
    public InterestRateType1Code RateTp {
        get {
            return this.rateTpField;
        }
        set {
            this.rateTpField = value;
        }
    }
    
    /// <remarks/>
    public Rate2 DealRate {
        get {
            return this.dealRateField;
        }
        set {
            this.dealRateField = value;
        }
    }
    
    /// <remarks/>
    public FloatingRateNote2 FltgRateNote {
        get {
            return this.fltgRateNoteField;
        }
        set {
            this.fltgRateNoteField = value;
        }
    }
    
    /// <remarks/>
    public BrokeredDeal1Code BrkrdDeal {
        get {
            return this.brkrdDealField;
        }
        set {
            this.brkrdDealField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool BrkrdDealSpecified {
        get {
            return this.brkrdDealFieldSpecified;
        }
        set {
            this.brkrdDealFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("CallPutOptn")]
    public Option12[] CallPutOptn {
        get {
            return this.callPutOptnField;
        }
        set {
            this.callPutOptnField = value;
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.013.001.01")]
public enum TransactionOperationType1Code {
    
    /// <remarks/>
    AMND,
    
    /// <remarks/>
    CANC,
    
    /// <remarks/>
    CORR,
    
    /// <remarks/>
    NEWT,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.013.001.01")]
public enum MoneyMarketTransactionType1Code {
    
    /// <remarks/>
    BORR,
    
    /// <remarks/>
    LEND,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.013.001.01")]
public enum FinancialInstrumentProductType1Code {
    
    /// <remarks/>
    CEOD,
    
    /// <remarks/>
    COPR,
    
    /// <remarks/>
    OTHR,
    
    /// <remarks/>
    ABCP,
    
    /// <remarks/>
    FRNT,
    
    /// <remarks/>
    CACM,
    
    /// <remarks/>
    DPST,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.013.001.01")]
public enum InterestRateType1Code {
    
    /// <remarks/>
    FIXE,
    
    /// <remarks/>
    VARI,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.013.001.01")]
public enum BrokeredDeal1Code {
    
    /// <remarks/>
    BILA,
    
    /// <remarks/>
    BROK,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.013.001.01")]
public partial class UnsecuredMarketReport3Choice {
    
    private object[] itemsField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("DataSetActn", typeof(ReportPeriodActivity1Code))]
    [System.Xml.Serialization.XmlElementAttribute("Tx", typeof(UnsecuredMarketTransaction3))]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.013.001.01")]
public enum ReportPeriodActivity1Code {
    
    /// <remarks/>
    NOTX,
}

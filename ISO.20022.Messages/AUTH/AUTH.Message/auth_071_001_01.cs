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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.071.001.01")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.071.001.01", IsNullable=false)]
public partial class Document {
    
    private SecuritiesFinancingReportingTransactionReusedCollateralDataReportV01 sctiesFincgRptgTxReusdCollDataRptField;
    
    /// <remarks/>
    public SecuritiesFinancingReportingTransactionReusedCollateralDataReportV01 SctiesFincgRptgTxReusdCollDataRpt {
        get {
            return this.sctiesFincgRptgTxReusdCollDataRptField;
        }
        set {
            this.sctiesFincgRptgTxReusdCollDataRptField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.071.001.01")]
public partial class SecuritiesFinancingReportingTransactionReusedCollateralDataReportV01 {
    
    private TradeData9Choice tradDataField;
    
    private SupplementaryData1[] splmtryDataField;
    
    /// <remarks/>
    public TradeData9Choice TradData {
        get {
            return this.tradDataField;
        }
        set {
            this.tradDataField = value;
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.071.001.01")]
public partial class TradeData9Choice {
    
    private object[] itemsField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("DataSetActn", typeof(ReportPeriodActivity1Code))]
    [System.Xml.Serialization.XmlElementAttribute("Rpt", typeof(ReuseDataReport3Choice))]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.071.001.01")]
public enum ReportPeriodActivity1Code {
    
    /// <remarks/>
    NOTX,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.071.001.01")]
public partial class ReuseDataReport3Choice {
    
    private object itemField;
    
    private ItemChoiceType2 itemElementNameField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("CollReuseUpd", typeof(ReuseDataReportCorrection7))]
    [System.Xml.Serialization.XmlElementAttribute("Crrctn", typeof(ReuseDataReportCorrection7))]
    [System.Xml.Serialization.XmlElementAttribute("Err", typeof(ReuseDataReportError3))]
    [System.Xml.Serialization.XmlElementAttribute("New", typeof(ReuseDataReportNew3))]
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
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.071.001.01")]
public partial class ReuseDataReportCorrection7 {
    
    private string techRcrdIdField;
    
    private System.DateTime rptgDtTmField;
    
    private CounterpartyData46 ctrPtyDataField;
    
    private CollateralType12[] collCmpntField;
    
    private System.DateTime evtDayField;
    
    private FundingSource1[] fndgSrcField;
    
    private SupplementaryData1[] splmtryDataField;
    
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
    public System.DateTime RptgDtTm {
        get {
            return this.rptgDtTmField;
        }
        set {
            this.rptgDtTmField = value;
        }
    }
    
    /// <remarks/>
    public CounterpartyData46 CtrPtyData {
        get {
            return this.ctrPtyDataField;
        }
        set {
            this.ctrPtyDataField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("CollCmpnt")]
    public CollateralType12[] CollCmpnt {
        get {
            return this.collCmpntField;
        }
        set {
            this.collCmpntField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
    public System.DateTime EvtDay {
        get {
            return this.evtDayField;
        }
        set {
            this.evtDayField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("FndgSrc")]
    public FundingSource1[] FndgSrc {
        get {
            return this.fndgSrcField;
        }
        set {
            this.fndgSrcField = value;
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.071.001.01")]
public partial class CounterpartyData46 {
    
    private OrganisationIdentification9Choice rptSubmitgNttyField;
    
    private OrganisationIdentification9Choice rptgCtrPtyField;
    
    private OrganisationIdentification9Choice nttyRspnsblForRptField;
    
    /// <remarks/>
    public OrganisationIdentification9Choice RptSubmitgNtty {
        get {
            return this.rptSubmitgNttyField;
        }
        set {
            this.rptSubmitgNttyField = value;
        }
    }
    
    /// <remarks/>
    public OrganisationIdentification9Choice RptgCtrPty {
        get {
            return this.rptgCtrPtyField;
        }
        set {
            this.rptgCtrPtyField = value;
        }
    }
    
    /// <remarks/>
    public OrganisationIdentification9Choice NttyRspnsblForRpt {
        get {
            return this.nttyRspnsblForRptField;
        }
        set {
            this.nttyRspnsblForRptField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.071.001.01")]
public partial class OrganisationIdentification9Choice {
    
    private string itemField;
    
    private ItemChoiceType itemElementNameField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("AnyBIC", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("ClntId", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("LEI", typeof(string))]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.071.001.01", IncludeInSchema=false)]
public enum ItemChoiceType {
    
    /// <remarks/>
    AnyBIC,
    
    /// <remarks/>
    ClntId,
    
    /// <remarks/>
    LEI,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.071.001.01")]
public partial class ReuseDataReportError3 {
    
    private string techRcrdIdField;
    
    private System.DateTime rptgDtTmField;
    
    private CounterpartyData46 ctrPtyDataField;
    
    private SupplementaryData1[] splmtryDataField;
    
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
    public System.DateTime RptgDtTm {
        get {
            return this.rptgDtTmField;
        }
        set {
            this.rptgDtTmField = value;
        }
    }
    
    /// <remarks/>
    public CounterpartyData46 CtrPtyData {
        get {
            return this.ctrPtyDataField;
        }
        set {
            this.ctrPtyDataField = value;
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.071.001.01")]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.071.001.01")]
public partial class FundingSource1 {
    
    private FundingSourceType1Code tpField;
    
    private ActiveOrHistoricCurrencyAndAmount mktValField;
    
    /// <remarks/>
    public FundingSourceType1Code Tp {
        get {
            return this.tpField;
        }
        set {
            this.tpField = value;
        }
    }
    
    /// <remarks/>
    public ActiveOrHistoricCurrencyAndAmount MktVal {
        get {
            return this.mktValField;
        }
        set {
            this.mktValField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.071.001.01")]
public enum FundingSourceType1Code {
    
    /// <remarks/>
    SECL,
    
    /// <remarks/>
    FREE,
    
    /// <remarks/>
    OTHR,
    
    /// <remarks/>
    BSHS,
    
    /// <remarks/>
    CSHS,
    
    /// <remarks/>
    REPO,
    
    /// <remarks/>
    UBOR,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.071.001.01")]
public partial class ActiveOrHistoricCurrencyAndAmount {
    
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.071.001.01")]
public partial class ReinvestedCashTypeAndAmount1 {
    
    private ReinvestmentType1Code tpField;
    
    private ActiveOrHistoricCurrencyAndAmount rinvstdCshAmtField;
    
    /// <remarks/>
    public ReinvestmentType1Code Tp {
        get {
            return this.tpField;
        }
        set {
            this.tpField = value;
        }
    }
    
    /// <remarks/>
    public ActiveOrHistoricCurrencyAndAmount RinvstdCshAmt {
        get {
            return this.rinvstdCshAmtField;
        }
        set {
            this.rinvstdCshAmtField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.071.001.01")]
public enum ReinvestmentType1Code {
    
    /// <remarks/>
    OTHR,
    
    /// <remarks/>
    OCMP,
    
    /// <remarks/>
    MMFT,
    
    /// <remarks/>
    REPM,
    
    /// <remarks/>
    SDPU,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.071.001.01")]
public partial class CashReuseData1 {
    
    private ReinvestedCashTypeAndAmount1[] rinvstdCshField;
    
    private decimal cshRinvstmtRateField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("RinvstdCsh")]
    public ReinvestedCashTypeAndAmount1[] RinvstdCsh {
        get {
            return this.rinvstdCshField;
        }
        set {
            this.rinvstdCshField = value;
        }
    }
    
    /// <remarks/>
    public decimal CshRinvstmtRate {
        get {
            return this.cshRinvstmtRateField;
        }
        set {
            this.cshRinvstmtRateField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.071.001.01")]
public partial class ReuseValue1Choice {
    
    private ActiveOrHistoricCurrencyAndAmount itemField;
    
    private ItemChoiceType1 itemElementNameField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Actl", typeof(ActiveOrHistoricCurrencyAndAmount))]
    [System.Xml.Serialization.XmlElementAttribute("Estmtd", typeof(ActiveOrHistoricCurrencyAndAmount))]
    [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
    public ActiveOrHistoricCurrencyAndAmount Item {
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.071.001.01", IncludeInSchema=false)]
public enum ItemChoiceType1 {
    
    /// <remarks/>
    Actl,
    
    /// <remarks/>
    Estmtd,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.071.001.01")]
public partial class SecurityReuseData1 {
    
    private string iSINField;
    
    private ReuseValue1Choice reuseValField;
    
    /// <remarks/>
    public string ISIN {
        get {
            return this.iSINField;
        }
        set {
            this.iSINField = value;
        }
    }
    
    /// <remarks/>
    public ReuseValue1Choice ReuseVal {
        get {
            return this.reuseValField;
        }
        set {
            this.reuseValField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.071.001.01")]
public partial class CollateralType12 {
    
    private SecurityReuseData1[] sctyField;
    
    private CashReuseData1[] cshField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Scty")]
    public SecurityReuseData1[] Scty {
        get {
            return this.sctyField;
        }
        set {
            this.sctyField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Csh")]
    public CashReuseData1[] Csh {
        get {
            return this.cshField;
        }
        set {
            this.cshField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.071.001.01")]
public partial class ReuseDataReportNew3 {
    
    private string techRcrdIdField;
    
    private System.DateTime rptgDtTmField;
    
    private CounterpartyData46 ctrPtyDataField;
    
    private CollateralType12[] collCmpntField;
    
    private System.DateTime evtDayField;
    
    private FundingSource1[] fndgSrcField;
    
    private SupplementaryData1[] splmtryDataField;
    
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
    public System.DateTime RptgDtTm {
        get {
            return this.rptgDtTmField;
        }
        set {
            this.rptgDtTmField = value;
        }
    }
    
    /// <remarks/>
    public CounterpartyData46 CtrPtyData {
        get {
            return this.ctrPtyDataField;
        }
        set {
            this.ctrPtyDataField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("CollCmpnt")]
    public CollateralType12[] CollCmpnt {
        get {
            return this.collCmpntField;
        }
        set {
            this.collCmpntField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
    public System.DateTime EvtDay {
        get {
            return this.evtDayField;
        }
        set {
            this.evtDayField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("FndgSrc")]
    public FundingSource1[] FndgSrc {
        get {
            return this.fndgSrcField;
        }
        set {
            this.fndgSrcField = value;
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.071.001.01", IncludeInSchema=false)]
public enum ItemChoiceType2 {
    
    /// <remarks/>
    CollReuseUpd,
    
    /// <remarks/>
    Crrctn,
    
    /// <remarks/>
    Err,
    
    /// <remarks/>
    New,
}

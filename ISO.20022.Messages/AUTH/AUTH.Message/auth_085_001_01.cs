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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.085.001.01")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.085.001.01", IsNullable=false)]
public partial class Document {
    
    private SecuritiesFinancingReportingMarginDataTransactionStateReportV01 sctiesFincgRptgMrgnDataTxStatRptField;
    
    /// <remarks/>
    public SecuritiesFinancingReportingMarginDataTransactionStateReportV01 SctiesFincgRptgMrgnDataTxStatRpt {
        get {
            return this.sctiesFincgRptgMrgnDataTxStatRptField;
        }
        set {
            this.sctiesFincgRptgMrgnDataTxStatRptField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.085.001.01")]
public partial class SecuritiesFinancingReportingMarginDataTransactionStateReportV01 {
    
    private TradeData13Choice tradDataField;
    
    private SupplementaryData1[] splmtryDataField;
    
    /// <remarks/>
    public TradeData13Choice TradData {
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.085.001.01")]
public partial class TradeData13Choice {
    
    private object[] itemsField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("DataSetActn", typeof(ReportPeriodActivity1Code))]
    [System.Xml.Serialization.XmlElementAttribute("Stat", typeof(CollateralMarginNew7))]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.085.001.01")]
public enum ReportPeriodActivity1Code {
    
    /// <remarks/>
    NOTX,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.085.001.01")]
public partial class CollateralMarginNew7 {
    
    private string techRcrdIdField;
    
    private System.DateTime rptgDtTmField;
    
    private System.DateTime evtDtField;
    
    private Counterparty30 ctrPtyField;
    
    private string collPrtflIdField;
    
    private PostedMarginOrCollateral3 pstdMrgnOrCollField;
    
    private ReceivedMarginOrCollateral3 rcvdMrgnOrCollField;
    
    private ReconciliationFlag1 rcncltnFlgField;
    
    private ContractModification3 ctrctModField;
    
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
    [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
    public System.DateTime EvtDt {
        get {
            return this.evtDtField;
        }
        set {
            this.evtDtField = value;
        }
    }
    
    /// <remarks/>
    public Counterparty30 CtrPty {
        get {
            return this.ctrPtyField;
        }
        set {
            this.ctrPtyField = value;
        }
    }
    
    /// <remarks/>
    public string CollPrtflId {
        get {
            return this.collPrtflIdField;
        }
        set {
            this.collPrtflIdField = value;
        }
    }
    
    /// <remarks/>
    public PostedMarginOrCollateral3 PstdMrgnOrColl {
        get {
            return this.pstdMrgnOrCollField;
        }
        set {
            this.pstdMrgnOrCollField = value;
        }
    }
    
    /// <remarks/>
    public ReceivedMarginOrCollateral3 RcvdMrgnOrColl {
        get {
            return this.rcvdMrgnOrCollField;
        }
        set {
            this.rcvdMrgnOrCollField = value;
        }
    }
    
    /// <remarks/>
    public ReconciliationFlag1 RcncltnFlg {
        get {
            return this.rcncltnFlgField;
        }
        set {
            this.rcncltnFlgField = value;
        }
    }
    
    /// <remarks/>
    public ContractModification3 CtrctMod {
        get {
            return this.ctrctModField;
        }
        set {
            this.ctrctModField = value;
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.085.001.01")]
public partial class Counterparty30 {
    
    private OrganisationIdentification9Choice rptgCtrPtyField;
    
    private OrganisationIdentification9Choice othrCtrPtyField;
    
    private OrganisationIdentification9Choice nttyRspnsblForRptField;
    
    private OrganisationIdentification9Choice rptSubmitgNttyField;
    
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
    public OrganisationIdentification9Choice OthrCtrPty {
        get {
            return this.othrCtrPtyField;
        }
        set {
            this.othrCtrPtyField = value;
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
    
    /// <remarks/>
    public OrganisationIdentification9Choice RptSubmitgNtty {
        get {
            return this.rptSubmitgNttyField;
        }
        set {
            this.rptSubmitgNttyField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.085.001.01")]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.085.001.01", IncludeInSchema=false)]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.085.001.01")]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.085.001.01")]
public partial class ContractModification3 {
    
    private TransactionOperationType6Code actnTpField;
    
    private ModificationLevel1Code lvlField;
    
    private bool lvlFieldSpecified;
    
    /// <remarks/>
    public TransactionOperationType6Code ActnTp {
        get {
            return this.actnTpField;
        }
        set {
            this.actnTpField = value;
        }
    }
    
    /// <remarks/>
    public ModificationLevel1Code Lvl {
        get {
            return this.lvlField;
        }
        set {
            this.lvlField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool LvlSpecified {
        get {
            return this.lvlFieldSpecified;
        }
        set {
            this.lvlFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.085.001.01")]
public enum TransactionOperationType6Code {
    
    /// <remarks/>
    REUU,
    
    /// <remarks/>
    COLU,
    
    /// <remarks/>
    CORR,
    
    /// <remarks/>
    ETRM,
    
    /// <remarks/>
    VALU,
    
    /// <remarks/>
    POSC,
    
    /// <remarks/>
    NEWT,
    
    /// <remarks/>
    MODI,
    
    /// <remarks/>
    MARU,
    
    /// <remarks/>
    EROR,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.085.001.01")]
public enum ModificationLevel1Code {
    
    /// <remarks/>
    PSTN,
    
    /// <remarks/>
    TCTN,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.085.001.01")]
public partial class ReconciliationFlag1 {
    
    private TradeRepositoryReportingType1Code rptTpField;
    
    private bool rptTpFieldSpecified;
    
    private bool bothCtrPtiesRptgField;
    
    private bool bothCtrPtiesRptgFieldSpecified;
    
    private bool pairdStsField;
    
    private bool pairdStsFieldSpecified;
    
    private bool lnRcncltnStsField;
    
    private bool lnRcncltnStsFieldSpecified;
    
    private bool collRcncltnStsField;
    
    private bool collRcncltnStsFieldSpecified;
    
    private bool modStsField;
    
    private bool modStsFieldSpecified;
    
    /// <remarks/>
    public TradeRepositoryReportingType1Code RptTp {
        get {
            return this.rptTpField;
        }
        set {
            this.rptTpField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool RptTpSpecified {
        get {
            return this.rptTpFieldSpecified;
        }
        set {
            this.rptTpFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public bool BothCtrPtiesRptg {
        get {
            return this.bothCtrPtiesRptgField;
        }
        set {
            this.bothCtrPtiesRptgField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool BothCtrPtiesRptgSpecified {
        get {
            return this.bothCtrPtiesRptgFieldSpecified;
        }
        set {
            this.bothCtrPtiesRptgFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public bool PairdSts {
        get {
            return this.pairdStsField;
        }
        set {
            this.pairdStsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool PairdStsSpecified {
        get {
            return this.pairdStsFieldSpecified;
        }
        set {
            this.pairdStsFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public bool LnRcncltnSts {
        get {
            return this.lnRcncltnStsField;
        }
        set {
            this.lnRcncltnStsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool LnRcncltnStsSpecified {
        get {
            return this.lnRcncltnStsFieldSpecified;
        }
        set {
            this.lnRcncltnStsFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public bool CollRcncltnSts {
        get {
            return this.collRcncltnStsField;
        }
        set {
            this.collRcncltnStsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool CollRcncltnStsSpecified {
        get {
            return this.collRcncltnStsFieldSpecified;
        }
        set {
            this.collRcncltnStsFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public bool ModSts {
        get {
            return this.modStsField;
        }
        set {
            this.modStsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool ModStsSpecified {
        get {
            return this.modStsFieldSpecified;
        }
        set {
            this.modStsFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.085.001.01")]
public enum TradeRepositoryReportingType1Code {
    
    /// <remarks/>
    SWOS,
    
    /// <remarks/>
    TWOS,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.085.001.01")]
public partial class ReceivedMarginOrCollateral3 {
    
    private ActiveOrHistoricCurrencyAndAmount initlMrgnRcvdField;
    
    private ActiveOrHistoricCurrencyAndAmount vartnMrgnRcvdField;
    
    private ActiveOrHistoricCurrencyAndAmount xcssCollRcvdField;
    
    /// <remarks/>
    public ActiveOrHistoricCurrencyAndAmount InitlMrgnRcvd {
        get {
            return this.initlMrgnRcvdField;
        }
        set {
            this.initlMrgnRcvdField = value;
        }
    }
    
    /// <remarks/>
    public ActiveOrHistoricCurrencyAndAmount VartnMrgnRcvd {
        get {
            return this.vartnMrgnRcvdField;
        }
        set {
            this.vartnMrgnRcvdField = value;
        }
    }
    
    /// <remarks/>
    public ActiveOrHistoricCurrencyAndAmount XcssCollRcvd {
        get {
            return this.xcssCollRcvdField;
        }
        set {
            this.xcssCollRcvdField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.085.001.01")]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.085.001.01")]
public partial class PostedMarginOrCollateral3 {
    
    private ActiveOrHistoricCurrencyAndAmount initlMrgnPstdField;
    
    private ActiveOrHistoricCurrencyAndAmount vartnMrgnPstdField;
    
    private ActiveOrHistoricCurrencyAndAmount xcssCollPstdField;
    
    /// <remarks/>
    public ActiveOrHistoricCurrencyAndAmount InitlMrgnPstd {
        get {
            return this.initlMrgnPstdField;
        }
        set {
            this.initlMrgnPstdField = value;
        }
    }
    
    /// <remarks/>
    public ActiveOrHistoricCurrencyAndAmount VartnMrgnPstd {
        get {
            return this.vartnMrgnPstdField;
        }
        set {
            this.vartnMrgnPstdField = value;
        }
    }
    
    /// <remarks/>
    public ActiveOrHistoricCurrencyAndAmount XcssCollPstd {
        get {
            return this.xcssCollPstdField;
        }
        set {
            this.xcssCollPstdField = value;
        }
    }
}

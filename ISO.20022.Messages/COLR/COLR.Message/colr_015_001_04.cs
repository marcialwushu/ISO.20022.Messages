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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:colr.015.001.04")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:colr.015.001.04", IsNullable=false)]
public partial class Document {
    
    private InterestPaymentStatementV04 intrstPmtStmtField;
    
    /// <remarks/>
    public InterestPaymentStatementV04 IntrstPmtStmt {
        get {
            return this.intrstPmtStmtField;
        }
        set {
            this.intrstPmtStmtField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:colr.015.001.04")]
public partial class InterestPaymentStatementV04 {
    
    private string txIdField;
    
    private Agreement4 agrmtField;
    
    private Obligation4 oblgtnField;
    
    private Statement32 stmtParamsField;
    
    private Pagination pgntnField;
    
    private InterestStatement4 intrstStmtField;
    
    private SupplementaryData1[] splmtryDataField;
    
    /// <remarks/>
    public string TxId {
        get {
            return this.txIdField;
        }
        set {
            this.txIdField = value;
        }
    }
    
    /// <remarks/>
    public Agreement4 Agrmt {
        get {
            return this.agrmtField;
        }
        set {
            this.agrmtField = value;
        }
    }
    
    /// <remarks/>
    public Obligation4 Oblgtn {
        get {
            return this.oblgtnField;
        }
        set {
            this.oblgtnField = value;
        }
    }
    
    /// <remarks/>
    public Statement32 StmtParams {
        get {
            return this.stmtParamsField;
        }
        set {
            this.stmtParamsField = value;
        }
    }
    
    /// <remarks/>
    public Pagination Pgntn {
        get {
            return this.pgntnField;
        }
        set {
            this.pgntnField = value;
        }
    }
    
    /// <remarks/>
    public InterestStatement4 IntrstStmt {
        get {
            return this.intrstStmtField;
        }
        set {
            this.intrstStmtField = value;
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:colr.015.001.04")]
public partial class Agreement4 {
    
    private string agrmtDtlsField;
    
    private string agrmtIdField;
    
    private System.DateTime agrmtDtField;
    
    private string baseCcyField;
    
    private AgreementFramework1Choice agrmtFrmwkField;
    
    /// <remarks/>
    public string AgrmtDtls {
        get {
            return this.agrmtDtlsField;
        }
        set {
            this.agrmtDtlsField = value;
        }
    }
    
    /// <remarks/>
    public string AgrmtId {
        get {
            return this.agrmtIdField;
        }
        set {
            this.agrmtIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
    public System.DateTime AgrmtDt {
        get {
            return this.agrmtDtField;
        }
        set {
            this.agrmtDtField = value;
        }
    }
    
    /// <remarks/>
    public string BaseCcy {
        get {
            return this.baseCcyField;
        }
        set {
            this.baseCcyField = value;
        }
    }
    
    /// <remarks/>
    public AgreementFramework1Choice AgrmtFrmwk {
        get {
            return this.agrmtFrmwkField;
        }
        set {
            this.agrmtFrmwkField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:colr.015.001.04")]
public partial class AgreementFramework1Choice {
    
    private object itemField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("AgrmtFrmwk", typeof(AgreementFramework1Code))]
    [System.Xml.Serialization.XmlElementAttribute("PrtryId", typeof(GenericIdentification30))]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:colr.015.001.04")]
public enum AgreementFramework1Code {
    
    /// <remarks/>
    FBAA,
    
    /// <remarks/>
    BBAA,
    
    /// <remarks/>
    DERV,
    
    /// <remarks/>
    ISDA,
    
    /// <remarks/>
    NONR,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:colr.015.001.04")]
public partial class GenericIdentification30 {
    
    private string idField;
    
    private string issrField;
    
    private string schmeNmField;
    
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
    public string Issr {
        get {
            return this.issrField;
        }
        set {
            this.issrField = value;
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
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:colr.015.001.04")]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:colr.015.001.04")]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:colr.015.001.04")]
public partial class AmountAndDirection20 {
    
    private ActiveOrHistoricCurrencyAndAmount amtField;
    
    private CreditDebitCode cdtDbtIndField;
    
    private bool cdtDbtIndFieldSpecified;
    
    /// <remarks/>
    public ActiveOrHistoricCurrencyAndAmount Amt {
        get {
            return this.amtField;
        }
        set {
            this.amtField = value;
        }
    }
    
    /// <remarks/>
    public CreditDebitCode CdtDbtInd {
        get {
            return this.cdtDbtIndField;
        }
        set {
            this.cdtDbtIndField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool CdtDbtIndSpecified {
        get {
            return this.cdtDbtIndFieldSpecified;
        }
        set {
            this.cdtDbtIndFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:colr.015.001.04")]
public enum CreditDebitCode {
    
    /// <remarks/>
    CRDT,
    
    /// <remarks/>
    DBIT,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:colr.015.001.04")]
public partial class InterestCalculation4 {
    
    private System.DateTime clctnDtField;
    
    private CollateralAccount2 collAcctIdField;
    
    private AmountAndDirection20 fctvPrncplAmtField;
    
    private AmountAndDirection20 prncplAmtField;
    
    private AmountAndDirection20 mvmntAmtField;
    
    private decimal nbOfDaysField;
    
    private bool nbOfDaysFieldSpecified;
    
    private decimal fctvRateField;
    
    private decimal intrstRateField;
    
    private bool intrstRateFieldSpecified;
    
    private decimal sprdField;
    
    private bool sprdFieldSpecified;
    
    private AmountAndDirection20 acrdIntrstAmtField;
    
    private ActiveCurrencyAndAmount aggtdIntrstAmtField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
    public System.DateTime ClctnDt {
        get {
            return this.clctnDtField;
        }
        set {
            this.clctnDtField = value;
        }
    }
    
    /// <remarks/>
    public CollateralAccount2 CollAcctId {
        get {
            return this.collAcctIdField;
        }
        set {
            this.collAcctIdField = value;
        }
    }
    
    /// <remarks/>
    public AmountAndDirection20 FctvPrncplAmt {
        get {
            return this.fctvPrncplAmtField;
        }
        set {
            this.fctvPrncplAmtField = value;
        }
    }
    
    /// <remarks/>
    public AmountAndDirection20 PrncplAmt {
        get {
            return this.prncplAmtField;
        }
        set {
            this.prncplAmtField = value;
        }
    }
    
    /// <remarks/>
    public AmountAndDirection20 MvmntAmt {
        get {
            return this.mvmntAmtField;
        }
        set {
            this.mvmntAmtField = value;
        }
    }
    
    /// <remarks/>
    public decimal NbOfDays {
        get {
            return this.nbOfDaysField;
        }
        set {
            this.nbOfDaysField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool NbOfDaysSpecified {
        get {
            return this.nbOfDaysFieldSpecified;
        }
        set {
            this.nbOfDaysFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public decimal FctvRate {
        get {
            return this.fctvRateField;
        }
        set {
            this.fctvRateField = value;
        }
    }
    
    /// <remarks/>
    public decimal IntrstRate {
        get {
            return this.intrstRateField;
        }
        set {
            this.intrstRateField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool IntrstRateSpecified {
        get {
            return this.intrstRateFieldSpecified;
        }
        set {
            this.intrstRateFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public decimal Sprd {
        get {
            return this.sprdField;
        }
        set {
            this.sprdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool SprdSpecified {
        get {
            return this.sprdFieldSpecified;
        }
        set {
            this.sprdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public AmountAndDirection20 AcrdIntrstAmt {
        get {
            return this.acrdIntrstAmtField;
        }
        set {
            this.acrdIntrstAmtField = value;
        }
    }
    
    /// <remarks/>
    public ActiveCurrencyAndAmount AggtdIntrstAmt {
        get {
            return this.aggtdIntrstAmtField;
        }
        set {
            this.aggtdIntrstAmtField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:colr.015.001.04")]
public partial class CollateralAccount2 {
    
    private string idField;
    
    private CollateralAccountIdentificationType2Choice tpField;
    
    private string nmField;
    
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
    public CollateralAccountIdentificationType2Choice Tp {
        get {
            return this.tpField;
        }
        set {
            this.tpField = value;
        }
    }
    
    /// <remarks/>
    public string Nm {
        get {
            return this.nmField;
        }
        set {
            this.nmField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:colr.015.001.04")]
public partial class CollateralAccountIdentificationType2Choice {
    
    private object itemField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Prtry", typeof(GenericIdentification36))]
    [System.Xml.Serialization.XmlElementAttribute("Tp", typeof(CollateralAccountType1Code))]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:colr.015.001.04")]
public partial class GenericIdentification36 {
    
    private string idField;
    
    private string issrField;
    
    private string schmeNmField;
    
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
    public string Issr {
        get {
            return this.issrField;
        }
        set {
            this.issrField = value;
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
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:colr.015.001.04")]
public enum CollateralAccountType1Code {
    
    /// <remarks/>
    HOUS,
    
    /// <remarks/>
    CLIE,
    
    /// <remarks/>
    LIPR,
    
    /// <remarks/>
    MGIN,
    
    /// <remarks/>
    DFLT,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:colr.015.001.04")]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:colr.015.001.04")]
public partial class DatePeriodDetails {
    
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
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:colr.015.001.04")]
public partial class InterestStatement4 {
    
    private DatePeriodDetails intrstPrdField;
    
    private ActiveCurrencyAndAmount ttlIntrstAmtDueToAField;
    
    private ActiveCurrencyAndAmount ttlIntrstAmtDueToBField;
    
    private System.DateTime valDtField;
    
    private string intrstPmtReqIdField;
    
    private InterestCalculation4[] intrstClctnField;
    
    /// <remarks/>
    public DatePeriodDetails IntrstPrd {
        get {
            return this.intrstPrdField;
        }
        set {
            this.intrstPrdField = value;
        }
    }
    
    /// <remarks/>
    public ActiveCurrencyAndAmount TtlIntrstAmtDueToA {
        get {
            return this.ttlIntrstAmtDueToAField;
        }
        set {
            this.ttlIntrstAmtDueToAField = value;
        }
    }
    
    /// <remarks/>
    public ActiveCurrencyAndAmount TtlIntrstAmtDueToB {
        get {
            return this.ttlIntrstAmtDueToBField;
        }
        set {
            this.ttlIntrstAmtDueToBField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
    public System.DateTime ValDt {
        get {
            return this.valDtField;
        }
        set {
            this.valDtField = value;
        }
    }
    
    /// <remarks/>
    public string IntrstPmtReqId {
        get {
            return this.intrstPmtReqIdField;
        }
        set {
            this.intrstPmtReqIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("IntrstClctn")]
    public InterestCalculation4[] IntrstClctn {
        get {
            return this.intrstClctnField;
        }
        set {
            this.intrstClctnField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:colr.015.001.04")]
public partial class Pagination {
    
    private string pgNbField;
    
    private bool lastPgIndField;
    
    /// <remarks/>
    public string PgNb {
        get {
            return this.pgNbField;
        }
        set {
            this.pgNbField = value;
        }
    }
    
    /// <remarks/>
    public bool LastPgInd {
        get {
            return this.lastPgIndField;
        }
        set {
            this.lastPgIndField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:colr.015.001.04")]
public partial class Statement32 {
    
    private string stmtIdField;
    
    private bool actvtyIndField;
    
    private Frequency1Code frqcyField;
    
    private DateAndDateTimeChoice stmtDtTmField;
    
    /// <remarks/>
    public string StmtId {
        get {
            return this.stmtIdField;
        }
        set {
            this.stmtIdField = value;
        }
    }
    
    /// <remarks/>
    public bool ActvtyInd {
        get {
            return this.actvtyIndField;
        }
        set {
            this.actvtyIndField = value;
        }
    }
    
    /// <remarks/>
    public Frequency1Code Frqcy {
        get {
            return this.frqcyField;
        }
        set {
            this.frqcyField = value;
        }
    }
    
    /// <remarks/>
    public DateAndDateTimeChoice StmtDtTm {
        get {
            return this.stmtDtTmField;
        }
        set {
            this.stmtDtTmField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:colr.015.001.04")]
public enum Frequency1Code {
    
    /// <remarks/>
    YEAR,
    
    /// <remarks/>
    MNTH,
    
    /// <remarks/>
    QURT,
    
    /// <remarks/>
    MIAN,
    
    /// <remarks/>
    WEEK,
    
    /// <remarks/>
    DAIL,
    
    /// <remarks/>
    ADHO,
    
    /// <remarks/>
    INDA,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:colr.015.001.04")]
public partial class DateAndDateTimeChoice {
    
    private System.DateTime itemField;
    
    private ItemChoiceType itemElementNameField;
    
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:colr.015.001.04", IncludeInSchema=false)]
public enum ItemChoiceType {
    
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:colr.015.001.04")]
public partial class PostalAddress2 {
    
    private string strtNmField;
    
    private string pstCdIdField;
    
    private string twnNmField;
    
    private string ctrySubDvsnField;
    
    private string ctryField;
    
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
    public string PstCdId {
        get {
            return this.pstCdIdField;
        }
        set {
            this.pstCdIdField = value;
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
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:colr.015.001.04")]
public partial class NameAndAddress6 {
    
    private string nmField;
    
    private PostalAddress2 adrField;
    
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
    public PostalAddress2 Adr {
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:colr.015.001.04")]
public partial class PartyIdentification100Choice {
    
    private object itemField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("AnyBIC", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("NmAndAdr", typeof(NameAndAddress6))]
    [System.Xml.Serialization.XmlElementAttribute("PrtryId", typeof(GenericIdentification36))]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:colr.015.001.04")]
public partial class Obligation4 {
    
    private PartyIdentification100Choice ptyAField;
    
    private PartyIdentification100Choice svcgPtyAField;
    
    private PartyIdentification100Choice ptyBField;
    
    private PartyIdentification100Choice svcgPtyBField;
    
    private CollateralAccount2 collAcctIdField;
    
    private ExposureType5Code xpsrTpField;
    
    private bool xpsrTpFieldSpecified;
    
    private DateAndDateTimeChoice valtnDtField;
    
    /// <remarks/>
    public PartyIdentification100Choice PtyA {
        get {
            return this.ptyAField;
        }
        set {
            this.ptyAField = value;
        }
    }
    
    /// <remarks/>
    public PartyIdentification100Choice SvcgPtyA {
        get {
            return this.svcgPtyAField;
        }
        set {
            this.svcgPtyAField = value;
        }
    }
    
    /// <remarks/>
    public PartyIdentification100Choice PtyB {
        get {
            return this.ptyBField;
        }
        set {
            this.ptyBField = value;
        }
    }
    
    /// <remarks/>
    public PartyIdentification100Choice SvcgPtyB {
        get {
            return this.svcgPtyBField;
        }
        set {
            this.svcgPtyBField = value;
        }
    }
    
    /// <remarks/>
    public CollateralAccount2 CollAcctId {
        get {
            return this.collAcctIdField;
        }
        set {
            this.collAcctIdField = value;
        }
    }
    
    /// <remarks/>
    public ExposureType5Code XpsrTp {
        get {
            return this.xpsrTpField;
        }
        set {
            this.xpsrTpField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool XpsrTpSpecified {
        get {
            return this.xpsrTpFieldSpecified;
        }
        set {
            this.xpsrTpFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public DateAndDateTimeChoice ValtnDt {
        get {
            return this.valtnDtField;
        }
        set {
            this.valtnDtField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:colr.015.001.04")]
public enum ExposureType5Code {
    
    /// <remarks/>
    BFWD,
    
    /// <remarks/>
    PAYM,
    
    /// <remarks/>
    CCPC,
    
    /// <remarks/>
    COMM,
    
    /// <remarks/>
    CRDS,
    
    /// <remarks/>
    CRTL,
    
    /// <remarks/>
    CRSP,
    
    /// <remarks/>
    CCIR,
    
    /// <remarks/>
    CRPR,
    
    /// <remarks/>
    EQUI,
    
    /// <remarks/>
    EQPT,
    
    /// <remarks/>
    EQUS,
    
    /// <remarks/>
    EXTD,
    
    /// <remarks/>
    EXPT,
    
    /// <remarks/>
    FIXI,
    
    /// <remarks/>
    FORX,
    
    /// <remarks/>
    FORW,
    
    /// <remarks/>
    FUTR,
    
    /// <remarks/>
    OPTN,
    
    /// <remarks/>
    LIQU,
    
    /// <remarks/>
    OTCD,
    
    /// <remarks/>
    REPO,
    
    /// <remarks/>
    RVPO,
    
    /// <remarks/>
    SLOA,
    
    /// <remarks/>
    SBSC,
    
    /// <remarks/>
    SCRP,
    
    /// <remarks/>
    SLEB,
    
    /// <remarks/>
    SHSL,
    
    /// <remarks/>
    SCIR,
    
    /// <remarks/>
    SCIE,
    
    /// <remarks/>
    SWPT,
    
    /// <remarks/>
    TBAS,
    
    /// <remarks/>
    TRBD,
    
    /// <remarks/>
    TRCP,
}

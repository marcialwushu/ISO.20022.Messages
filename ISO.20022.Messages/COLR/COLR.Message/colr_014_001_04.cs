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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:colr.014.001.04")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:colr.014.001.04", IsNullable=false)]
public partial class Document {
    
    private InterestPaymentResponseV04 intrstPmtRspnField;
    
    /// <remarks/>
    public InterestPaymentResponseV04 IntrstPmtRspn {
        get {
            return this.intrstPmtRspnField;
        }
        set {
            this.intrstPmtRspnField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:colr.014.001.04")]
public partial class InterestPaymentResponseV04 {
    
    private string txIdField;
    
    private Obligation4 oblgtnField;
    
    private Agreement4 agrmtField;
    
    private InterestAmount2 intrstDueToAField;
    
    private InterestAmount2 intrstDueToBField;
    
    private InterestResponse1 intrstRspnField;
    
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
    public Obligation4 Oblgtn {
        get {
            return this.oblgtnField;
        }
        set {
            this.oblgtnField = value;
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
    public InterestAmount2 IntrstDueToA {
        get {
            return this.intrstDueToAField;
        }
        set {
            this.intrstDueToAField = value;
        }
    }
    
    /// <remarks/>
    public InterestAmount2 IntrstDueToB {
        get {
            return this.intrstDueToBField;
        }
        set {
            this.intrstDueToBField = value;
        }
    }
    
    /// <remarks/>
    public InterestResponse1 IntrstRspn {
        get {
            return this.intrstRspnField;
        }
        set {
            this.intrstRspnField = value;
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:colr.014.001.04")]
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
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:colr.014.001.04")]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:colr.014.001.04")]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:colr.014.001.04")]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:colr.014.001.04")]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:colr.014.001.04")]
public partial class RejectionReason21FormatChoice {
    
    private object itemField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Cd", typeof(InterestRejectionReason1Code))]
    [System.Xml.Serialization.XmlElementAttribute("Prtry", typeof(GenericIdentification30))]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:colr.014.001.04")]
public enum InterestRejectionReason1Code {
    
    /// <remarks/>
    VADA,
    
    /// <remarks/>
    DIAM,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:colr.014.001.04")]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:colr.014.001.04")]
public partial class InterestResponse1 {
    
    private Status4Code rspnTpField;
    
    private RejectionReason21FormatChoice rjctnRsnField;
    
    private string rjctnRsnInfField;
    
    private string intrstPmtReqIdField;
    
    /// <remarks/>
    public Status4Code RspnTp {
        get {
            return this.rspnTpField;
        }
        set {
            this.rspnTpField = value;
        }
    }
    
    /// <remarks/>
    public RejectionReason21FormatChoice RjctnRsn {
        get {
            return this.rjctnRsnField;
        }
        set {
            this.rjctnRsnField = value;
        }
    }
    
    /// <remarks/>
    public string RjctnRsnInf {
        get {
            return this.rjctnRsnInfField;
        }
        set {
            this.rjctnRsnInfField = value;
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
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:colr.014.001.04")]
public enum Status4Code {
    
    /// <remarks/>
    REJT,
    
    /// <remarks/>
    PACK,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:colr.014.001.04")]
public partial class CollateralBalance1 {
    
    private ActiveCurrencyAndAmount heldByPtyAField;
    
    private ActiveCurrencyAndAmount heldByPtyBField;
    
    /// <remarks/>
    public ActiveCurrencyAndAmount HeldByPtyA {
        get {
            return this.heldByPtyAField;
        }
        set {
            this.heldByPtyAField = value;
        }
    }
    
    /// <remarks/>
    public ActiveCurrencyAndAmount HeldByPtyB {
        get {
            return this.heldByPtyBField;
        }
        set {
            this.heldByPtyBField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:colr.014.001.04")]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:colr.014.001.04")]
public partial class CollateralPurpose1Choice {
    
    private object itemField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Cd", typeof(CollateralPurpose1Code))]
    [System.Xml.Serialization.XmlElementAttribute("Prtry", typeof(GenericIdentification30))]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:colr.014.001.04")]
public enum CollateralPurpose1Code {
    
    /// <remarks/>
    VAMA,
    
    /// <remarks/>
    SINA,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:colr.014.001.04")]
public partial class VariableInterest1Rate {
    
    private string indxField;
    
    private decimal bsisPtSprdField;
    
    private bool bsisPtSprdFieldSpecified;
    
    /// <remarks/>
    public string Indx {
        get {
            return this.indxField;
        }
        set {
            this.indxField = value;
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
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool BsisPtSprdSpecified {
        get {
            return this.bsisPtSprdFieldSpecified;
        }
        set {
            this.bsisPtSprdFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:colr.014.001.04")]
public partial class InterestRate1Choice {
    
    private object itemField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("FxdIntrstRate", typeof(decimal))]
    [System.Xml.Serialization.XmlElementAttribute("VarblIntrstRate", typeof(VariableInterest1Rate))]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:colr.014.001.04")]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:colr.014.001.04")]
public partial class InterestAmount2 {
    
    private ActiveCurrencyAndAmount acrdIntrstAmtField;
    
    private DateAndDateTimeChoice valDtField;
    
    private InterestMethod1Code intrstMtdField;
    
    private DatePeriodDetails intrstPrdField;
    
    private InterestRate1Choice intrstRateField;
    
    private InterestComputationMethod2Code dayCntBsisField;
    
    private bool dayCntBsisFieldSpecified;
    
    private bool apldWhldgTaxField;
    
    private bool apldWhldgTaxFieldSpecified;
    
    private CalculationMethod1Code clctnMtdField;
    
    private bool clctnMtdFieldSpecified;
    
    private Frequency1Code clctnFrqcyField;
    
    private bool clctnFrqcyFieldSpecified;
    
    private CollateralPurpose1Choice collPurpField;
    
    private CollateralBalance1 opngCollBalField;
    
    private CollateralBalance1 clsgCollBalField;
    
    private string stdSttlmInstrsField;
    
    private string addtlInfField;
    
    /// <remarks/>
    public ActiveCurrencyAndAmount AcrdIntrstAmt {
        get {
            return this.acrdIntrstAmtField;
        }
        set {
            this.acrdIntrstAmtField = value;
        }
    }
    
    /// <remarks/>
    public DateAndDateTimeChoice ValDt {
        get {
            return this.valDtField;
        }
        set {
            this.valDtField = value;
        }
    }
    
    /// <remarks/>
    public InterestMethod1Code IntrstMtd {
        get {
            return this.intrstMtdField;
        }
        set {
            this.intrstMtdField = value;
        }
    }
    
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
    public InterestRate1Choice IntrstRate {
        get {
            return this.intrstRateField;
        }
        set {
            this.intrstRateField = value;
        }
    }
    
    /// <remarks/>
    public InterestComputationMethod2Code DayCntBsis {
        get {
            return this.dayCntBsisField;
        }
        set {
            this.dayCntBsisField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool DayCntBsisSpecified {
        get {
            return this.dayCntBsisFieldSpecified;
        }
        set {
            this.dayCntBsisFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public bool ApldWhldgTax {
        get {
            return this.apldWhldgTaxField;
        }
        set {
            this.apldWhldgTaxField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool ApldWhldgTaxSpecified {
        get {
            return this.apldWhldgTaxFieldSpecified;
        }
        set {
            this.apldWhldgTaxFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public CalculationMethod1Code ClctnMtd {
        get {
            return this.clctnMtdField;
        }
        set {
            this.clctnMtdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool ClctnMtdSpecified {
        get {
            return this.clctnMtdFieldSpecified;
        }
        set {
            this.clctnMtdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public Frequency1Code ClctnFrqcy {
        get {
            return this.clctnFrqcyField;
        }
        set {
            this.clctnFrqcyField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool ClctnFrqcySpecified {
        get {
            return this.clctnFrqcyFieldSpecified;
        }
        set {
            this.clctnFrqcyFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public CollateralPurpose1Choice CollPurp {
        get {
            return this.collPurpField;
        }
        set {
            this.collPurpField = value;
        }
    }
    
    /// <remarks/>
    public CollateralBalance1 OpngCollBal {
        get {
            return this.opngCollBalField;
        }
        set {
            this.opngCollBalField = value;
        }
    }
    
    /// <remarks/>
    public CollateralBalance1 ClsgCollBal {
        get {
            return this.clsgCollBalField;
        }
        set {
            this.clsgCollBalField = value;
        }
    }
    
    /// <remarks/>
    public string StdSttlmInstrs {
        get {
            return this.stdSttlmInstrsField;
        }
        set {
            this.stdSttlmInstrsField = value;
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:colr.014.001.04")]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:colr.014.001.04", IncludeInSchema=false)]
public enum ItemChoiceType {
    
    /// <remarks/>
    Dt,
    
    /// <remarks/>
    DtTm,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:colr.014.001.04")]
public enum InterestMethod1Code {
    
    /// <remarks/>
    PHYS,
    
    /// <remarks/>
    ROLL,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:colr.014.001.04")]
public enum InterestComputationMethod2Code {
    
    /// <remarks/>
    A001,
    
    /// <remarks/>
    A002,
    
    /// <remarks/>
    A003,
    
    /// <remarks/>
    A004,
    
    /// <remarks/>
    A005,
    
    /// <remarks/>
    A006,
    
    /// <remarks/>
    A007,
    
    /// <remarks/>
    A008,
    
    /// <remarks/>
    A009,
    
    /// <remarks/>
    A010,
    
    /// <remarks/>
    A011,
    
    /// <remarks/>
    A012,
    
    /// <remarks/>
    A013,
    
    /// <remarks/>
    A014,
    
    /// <remarks/>
    NARR,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:colr.014.001.04")]
public enum CalculationMethod1Code {
    
    /// <remarks/>
    SIMP,
    
    /// <remarks/>
    COMP,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:colr.014.001.04")]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:colr.014.001.04")]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:colr.014.001.04")]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:colr.014.001.04")]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:colr.014.001.04")]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:colr.014.001.04")]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:colr.014.001.04")]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:colr.014.001.04")]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:colr.014.001.04")]
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

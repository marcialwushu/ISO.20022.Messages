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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.044.001.02")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.044.001.02", IsNullable=false)]
public partial class Document {
    
    private FundConfirmedCashForecastReportCancellationV02 fndConfdCshFcstRptCxlV02Field;
    
    /// <remarks/>
    public FundConfirmedCashForecastReportCancellationV02 FndConfdCshFcstRptCxlV02 {
        get {
            return this.fndConfdCshFcstRptCxlV02Field;
        }
        set {
            this.fndConfdCshFcstRptCxlV02Field = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.044.001.02")]
public partial class FundConfirmedCashForecastReportCancellationV02 {
    
    private MessageIdentification1 msgIdField;
    
    private AdditionalReference3 poolRefField;
    
    private AdditionalReference3 prvsRefField;
    
    private AdditionalReference3[] rltdRefField;
    
    private Pagination msgPgntnField;
    
    private FundConfirmedCashForecastReport2 cshFcstRptToBeCancField;
    
    /// <remarks/>
    public MessageIdentification1 MsgId {
        get {
            return this.msgIdField;
        }
        set {
            this.msgIdField = value;
        }
    }
    
    /// <remarks/>
    public AdditionalReference3 PoolRef {
        get {
            return this.poolRefField;
        }
        set {
            this.poolRefField = value;
        }
    }
    
    /// <remarks/>
    public AdditionalReference3 PrvsRef {
        get {
            return this.prvsRefField;
        }
        set {
            this.prvsRefField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("RltdRef")]
    public AdditionalReference3[] RltdRef {
        get {
            return this.rltdRefField;
        }
        set {
            this.rltdRefField = value;
        }
    }
    
    /// <remarks/>
    public Pagination MsgPgntn {
        get {
            return this.msgPgntnField;
        }
        set {
            this.msgPgntnField = value;
        }
    }
    
    /// <remarks/>
    public FundConfirmedCashForecastReport2 CshFcstRptToBeCanc {
        get {
            return this.cshFcstRptToBeCancField;
        }
        set {
            this.cshFcstRptToBeCancField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.044.001.02")]
public partial class MessageIdentification1 {
    
    private string idField;
    
    private System.DateTime creDtTmField;
    
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
    public System.DateTime CreDtTm {
        get {
            return this.creDtTmField;
        }
        set {
            this.creDtTmField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.044.001.02")]
public partial class Extension1 {
    
    private string plcAndNmField;
    
    private string txtField;
    
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
    public string Txt {
        get {
            return this.txtField;
        }
        set {
            this.txtField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.044.001.02")]
public partial class NetCashForecast3 {
    
    private ActiveOrHistoricCurrencyAndAmount netAmtField;
    
    private FinancialInstrumentQuantity1 netUnitsNbField;
    
    private FlowDirectionType1Code flowDrctnField;
    
    /// <remarks/>
    public ActiveOrHistoricCurrencyAndAmount NetAmt {
        get {
            return this.netAmtField;
        }
        set {
            this.netAmtField = value;
        }
    }
    
    /// <remarks/>
    public FinancialInstrumentQuantity1 NetUnitsNb {
        get {
            return this.netUnitsNbField;
        }
        set {
            this.netUnitsNbField = value;
        }
    }
    
    /// <remarks/>
    public FlowDirectionType1Code FlowDrctn {
        get {
            return this.flowDrctnField;
        }
        set {
            this.flowDrctnField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.044.001.02")]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.044.001.02")]
public partial class FinancialInstrumentQuantity1 {
    
    private decimal unitField;
    
    /// <remarks/>
    public decimal Unit {
        get {
            return this.unitField;
        }
        set {
            this.unitField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.044.001.02")]
public enum FlowDirectionType1Code {
    
    /// <remarks/>
    INCG,
    
    /// <remarks/>
    OUTG,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.044.001.02")]
public partial class NetCashForecast2 {
    
    private System.DateTime cshSttlmDtField;
    
    private ActiveOrHistoricCurrencyAndAmount netAmtField;
    
    private FinancialInstrumentQuantity1 netUnitsNbField;
    
    private FlowDirectionType1Code flowDrctnField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
    public System.DateTime CshSttlmDt {
        get {
            return this.cshSttlmDtField;
        }
        set {
            this.cshSttlmDtField = value;
        }
    }
    
    /// <remarks/>
    public ActiveOrHistoricCurrencyAndAmount NetAmt {
        get {
            return this.netAmtField;
        }
        set {
            this.netAmtField = value;
        }
    }
    
    /// <remarks/>
    public FinancialInstrumentQuantity1 NetUnitsNb {
        get {
            return this.netUnitsNbField;
        }
        set {
            this.netUnitsNbField = value;
        }
    }
    
    /// <remarks/>
    public FlowDirectionType1Code FlowDrctn {
        get {
            return this.flowDrctnField;
        }
        set {
            this.flowDrctnField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.044.001.02")]
public partial class CashOutForecast4 {
    
    private System.DateTime cshSttlmDtField;
    
    private ActiveOrHistoricCurrencyAndAmount subTtlAmtField;
    
    private FinancialInstrumentQuantity1 subTtlUnitsNbField;
    
    private bool xcptnlCshFlowIndField;
    
    private bool xcptnlCshFlowIndFieldSpecified;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
    public System.DateTime CshSttlmDt {
        get {
            return this.cshSttlmDtField;
        }
        set {
            this.cshSttlmDtField = value;
        }
    }
    
    /// <remarks/>
    public ActiveOrHistoricCurrencyAndAmount SubTtlAmt {
        get {
            return this.subTtlAmtField;
        }
        set {
            this.subTtlAmtField = value;
        }
    }
    
    /// <remarks/>
    public FinancialInstrumentQuantity1 SubTtlUnitsNb {
        get {
            return this.subTtlUnitsNbField;
        }
        set {
            this.subTtlUnitsNbField = value;
        }
    }
    
    /// <remarks/>
    public bool XcptnlCshFlowInd {
        get {
            return this.xcptnlCshFlowIndField;
        }
        set {
            this.xcptnlCshFlowIndField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool XcptnlCshFlowIndSpecified {
        get {
            return this.xcptnlCshFlowIndFieldSpecified;
        }
        set {
            this.xcptnlCshFlowIndFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.044.001.02")]
public partial class CashInForecast4 {
    
    private System.DateTime cshSttlmDtField;
    
    private ActiveOrHistoricCurrencyAndAmount subTtlAmtField;
    
    private FinancialInstrumentQuantity1 subTtlUnitsNbField;
    
    private bool xcptnlCshFlowIndField;
    
    private bool xcptnlCshFlowIndFieldSpecified;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
    public System.DateTime CshSttlmDt {
        get {
            return this.cshSttlmDtField;
        }
        set {
            this.cshSttlmDtField = value;
        }
    }
    
    /// <remarks/>
    public ActiveOrHistoricCurrencyAndAmount SubTtlAmt {
        get {
            return this.subTtlAmtField;
        }
        set {
            this.subTtlAmtField = value;
        }
    }
    
    /// <remarks/>
    public FinancialInstrumentQuantity1 SubTtlUnitsNb {
        get {
            return this.subTtlUnitsNbField;
        }
        set {
            this.subTtlUnitsNbField = value;
        }
    }
    
    /// <remarks/>
    public bool XcptnlCshFlowInd {
        get {
            return this.xcptnlCshFlowIndField;
        }
        set {
            this.xcptnlCshFlowIndField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool XcptnlCshFlowIndSpecified {
        get {
            return this.xcptnlCshFlowIndFieldSpecified;
        }
        set {
            this.xcptnlCshFlowIndFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.044.001.02")]
public partial class AlternateSecurityIdentification1 {
    
    private string idField;
    
    private string itemField;
    
    private ItemChoiceType1 itemElementNameField;
    
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
    [System.Xml.Serialization.XmlElementAttribute("DmstIdSrc", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("PrtryIdSrc", typeof(string))]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.044.001.02", IncludeInSchema=false)]
public enum ItemChoiceType1 {
    
    /// <remarks/>
    DmstIdSrc,
    
    /// <remarks/>
    PrtryIdSrc,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.044.001.02")]
public partial class SecurityIdentification3Choice {
    
    private object itemField;
    
    private ItemChoiceType2 itemElementNameField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Belgn", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("Blmbrg", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("CTA", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("CUSIP", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("Cmon", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("Dtch", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("ISIN", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("OthrPrtryId", typeof(AlternateSecurityIdentification1))]
    [System.Xml.Serialization.XmlElementAttribute("QUICK", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("RIC", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("SCVM", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("SEDOL", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("TckrSymb", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("Vlrn", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("Wrtppr", typeof(string))]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.044.001.02", IncludeInSchema=false)]
public enum ItemChoiceType2 {
    
    /// <remarks/>
    Belgn,
    
    /// <remarks/>
    Blmbrg,
    
    /// <remarks/>
    CTA,
    
    /// <remarks/>
    CUSIP,
    
    /// <remarks/>
    Cmon,
    
    /// <remarks/>
    Dtch,
    
    /// <remarks/>
    ISIN,
    
    /// <remarks/>
    OthrPrtryId,
    
    /// <remarks/>
    QUICK,
    
    /// <remarks/>
    RIC,
    
    /// <remarks/>
    SCVM,
    
    /// <remarks/>
    SEDOL,
    
    /// <remarks/>
    TckrSymb,
    
    /// <remarks/>
    Vlrn,
    
    /// <remarks/>
    Wrtppr,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.044.001.02")]
public partial class FinancialInstrument9 {
    
    private SecurityIdentification3Choice idField;
    
    private string nmField;
    
    private string splmtryIdField;
    
    private string reqdNAVCcyField;
    
    private string clssTpField;
    
    private FormOfSecurity1Code sctiesFormField;
    
    private bool sctiesFormFieldSpecified;
    
    private DistributionPolicy1Code dstrbtnPlcyField;
    
    private bool dstrbtnPlcyFieldSpecified;
    
    private bool dualFndIndField;
    
    /// <remarks/>
    public SecurityIdentification3Choice Id {
        get {
            return this.idField;
        }
        set {
            this.idField = value;
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
    
    /// <remarks/>
    public string SplmtryId {
        get {
            return this.splmtryIdField;
        }
        set {
            this.splmtryIdField = value;
        }
    }
    
    /// <remarks/>
    public string ReqdNAVCcy {
        get {
            return this.reqdNAVCcyField;
        }
        set {
            this.reqdNAVCcyField = value;
        }
    }
    
    /// <remarks/>
    public string ClssTp {
        get {
            return this.clssTpField;
        }
        set {
            this.clssTpField = value;
        }
    }
    
    /// <remarks/>
    public FormOfSecurity1Code SctiesForm {
        get {
            return this.sctiesFormField;
        }
        set {
            this.sctiesFormField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool SctiesFormSpecified {
        get {
            return this.sctiesFormFieldSpecified;
        }
        set {
            this.sctiesFormFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public DistributionPolicy1Code DstrbtnPlcy {
        get {
            return this.dstrbtnPlcyField;
        }
        set {
            this.dstrbtnPlcyField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool DstrbtnPlcySpecified {
        get {
            return this.dstrbtnPlcyFieldSpecified;
        }
        set {
            this.dstrbtnPlcyFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public bool DualFndInd {
        get {
            return this.dualFndIndField;
        }
        set {
            this.dualFndIndField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.044.001.02")]
public enum FormOfSecurity1Code {
    
    /// <remarks/>
    BEAR,
    
    /// <remarks/>
    REGD,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.044.001.02")]
public enum DistributionPolicy1Code {
    
    /// <remarks/>
    DIST,
    
    /// <remarks/>
    ACCU,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.044.001.02")]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.044.001.02", IncludeInSchema=false)]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.044.001.02")]
public partial class FundCashForecast3 {
    
    private string idField;
    
    private DateAndDateTimeChoice tradDtTmField;
    
    private DateAndDateTimeChoice prvsTradDtTmField;
    
    private FinancialInstrument9 finInstrmDtlsField;
    
    private ActiveOrHistoricCurrencyAndAmount ttlNAVField;
    
    private ActiveOrHistoricCurrencyAndAmount prvsTtlNAVField;
    
    private FinancialInstrumentQuantity1 ttlUnitsNbField;
    
    private FinancialInstrumentQuantity1 prvsTtlUnitsNbField;
    
    private decimal ttlNAVChngRateField;
    
    private bool ttlNAVChngRateFieldSpecified;
    
    private string[] invstmtCcyField;
    
    private bool xcptnlNetCshFlowIndField;
    
    private CashInForecast4[] cshInFcstDtlsField;
    
    private CashOutForecast4[] cshOutFcstDtlsField;
    
    private NetCashForecast2[] netCshFcstDtlsField;
    
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
    public DateAndDateTimeChoice TradDtTm {
        get {
            return this.tradDtTmField;
        }
        set {
            this.tradDtTmField = value;
        }
    }
    
    /// <remarks/>
    public DateAndDateTimeChoice PrvsTradDtTm {
        get {
            return this.prvsTradDtTmField;
        }
        set {
            this.prvsTradDtTmField = value;
        }
    }
    
    /// <remarks/>
    public FinancialInstrument9 FinInstrmDtls {
        get {
            return this.finInstrmDtlsField;
        }
        set {
            this.finInstrmDtlsField = value;
        }
    }
    
    /// <remarks/>
    public ActiveOrHistoricCurrencyAndAmount TtlNAV {
        get {
            return this.ttlNAVField;
        }
        set {
            this.ttlNAVField = value;
        }
    }
    
    /// <remarks/>
    public ActiveOrHistoricCurrencyAndAmount PrvsTtlNAV {
        get {
            return this.prvsTtlNAVField;
        }
        set {
            this.prvsTtlNAVField = value;
        }
    }
    
    /// <remarks/>
    public FinancialInstrumentQuantity1 TtlUnitsNb {
        get {
            return this.ttlUnitsNbField;
        }
        set {
            this.ttlUnitsNbField = value;
        }
    }
    
    /// <remarks/>
    public FinancialInstrumentQuantity1 PrvsTtlUnitsNb {
        get {
            return this.prvsTtlUnitsNbField;
        }
        set {
            this.prvsTtlUnitsNbField = value;
        }
    }
    
    /// <remarks/>
    public decimal TtlNAVChngRate {
        get {
            return this.ttlNAVChngRateField;
        }
        set {
            this.ttlNAVChngRateField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool TtlNAVChngRateSpecified {
        get {
            return this.ttlNAVChngRateFieldSpecified;
        }
        set {
            this.ttlNAVChngRateFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("InvstmtCcy")]
    public string[] InvstmtCcy {
        get {
            return this.invstmtCcyField;
        }
        set {
            this.invstmtCcyField = value;
        }
    }
    
    /// <remarks/>
    public bool XcptnlNetCshFlowInd {
        get {
            return this.xcptnlNetCshFlowIndField;
        }
        set {
            this.xcptnlNetCshFlowIndField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("CshInFcstDtls")]
    public CashInForecast4[] CshInFcstDtls {
        get {
            return this.cshInFcstDtlsField;
        }
        set {
            this.cshInFcstDtlsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("CshOutFcstDtls")]
    public CashOutForecast4[] CshOutFcstDtls {
        get {
            return this.cshOutFcstDtlsField;
        }
        set {
            this.cshOutFcstDtlsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("NetCshFcstDtls")]
    public NetCashForecast2[] NetCshFcstDtls {
        get {
            return this.netCshFcstDtlsField;
        }
        set {
            this.netCshFcstDtlsField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.044.001.02")]
public partial class FundConfirmedCashForecastReport2 {
    
    private FundCashForecast3[] fndCshFcstDtlsField;
    
    private NetCashForecast3 cnsltdNetCshFcstField;
    
    private Extension1[] xtnsnField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("FndCshFcstDtls")]
    public FundCashForecast3[] FndCshFcstDtls {
        get {
            return this.fndCshFcstDtlsField;
        }
        set {
            this.fndCshFcstDtlsField = value;
        }
    }
    
    /// <remarks/>
    public NetCashForecast3 CnsltdNetCshFcst {
        get {
            return this.cnsltdNetCshFcstField;
        }
        set {
            this.cnsltdNetCshFcstField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Xtnsn")]
    public Extension1[] Xtnsn {
        get {
            return this.xtnsnField;
        }
        set {
            this.xtnsnField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.044.001.02")]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.044.001.02")]
public partial class PostalAddress1 {
    
    private AddressType2Code adrTpField;
    
    private bool adrTpFieldSpecified;
    
    private string[] adrLineField;
    
    private string strtNmField;
    
    private string bldgNbField;
    
    private string pstCdField;
    
    private string twnNmField;
    
    private string ctrySubDvsnField;
    
    private string ctryField;
    
    /// <remarks/>
    public AddressType2Code AdrTp {
        get {
            return this.adrTpField;
        }
        set {
            this.adrTpField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool AdrTpSpecified {
        get {
            return this.adrTpFieldSpecified;
        }
        set {
            this.adrTpFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("AdrLine")]
    public string[] AdrLine {
        get {
            return this.adrLineField;
        }
        set {
            this.adrLineField = value;
        }
    }
    
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
    public string BldgNb {
        get {
            return this.bldgNbField;
        }
        set {
            this.bldgNbField = value;
        }
    }
    
    /// <remarks/>
    public string PstCd {
        get {
            return this.pstCdField;
        }
        set {
            this.pstCdField = value;
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.044.001.02")]
public enum AddressType2Code {
    
    /// <remarks/>
    ADDR,
    
    /// <remarks/>
    PBOX,
    
    /// <remarks/>
    HOME,
    
    /// <remarks/>
    BIZZ,
    
    /// <remarks/>
    MLTO,
    
    /// <remarks/>
    DLVY,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.044.001.02")]
public partial class NameAndAddress5 {
    
    private string nmField;
    
    private PostalAddress1 adrField;
    
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
    public PostalAddress1 Adr {
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.044.001.02")]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.044.001.02")]
public partial class PartyIdentification2Choice {
    
    private object itemField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("BICOrBEI", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("NmAndAdr", typeof(NameAndAddress5))]
    [System.Xml.Serialization.XmlElementAttribute("PrtryId", typeof(GenericIdentification1))]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.044.001.02")]
public partial class AdditionalReference3 {
    
    private string refField;
    
    private PartyIdentification2Choice refIssrField;
    
    private string msgNmField;
    
    /// <remarks/>
    public string Ref {
        get {
            return this.refField;
        }
        set {
            this.refField = value;
        }
    }
    
    /// <remarks/>
    public PartyIdentification2Choice RefIssr {
        get {
            return this.refIssrField;
        }
        set {
            this.refIssrField = value;
        }
    }
    
    /// <remarks/>
    public string MsgNm {
        get {
            return this.msgNmField;
        }
        set {
            this.msgNmField = value;
        }
    }
}

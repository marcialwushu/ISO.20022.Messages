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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.092.001.02")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.092.001.02", IsNullable=false)]
public partial class Document {
    
    private DerivativesTradeRejectionStatisticalReportV02 derivsTradRjctnSttstclRptField;
    
    /// <remarks/>
    public DerivativesTradeRejectionStatisticalReportV02 DerivsTradRjctnSttstclRpt {
        get {
            return this.derivsTradRjctnSttstclRptField;
        }
        set {
            this.derivsTradRjctnSttstclRptField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.092.001.02")]
public partial class DerivativesTradeRejectionStatisticalReportV02 {
    
    private StatisticsPerCounterparty3Choice sttstcsPerCtrPtyField;
    
    private SupplementaryData1[] splmtryDataField;
    
    /// <remarks/>
    public StatisticsPerCounterparty3Choice SttstcsPerCtrPty {
        get {
            return this.sttstcsPerCtrPtyField;
        }
        set {
            this.sttstcsPerCtrPtyField = value;
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.092.001.02")]
public partial class StatisticsPerCounterparty3Choice {
    
    private object[] itemsField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("DataSetActn", typeof(ReportPeriodActivity1Code))]
    [System.Xml.Serialization.XmlElementAttribute("Rpt", typeof(DetailedStatisticsPerCounterparty7))]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.092.001.02")]
public enum ReportPeriodActivity1Code {
    
    /// <remarks/>
    NOTX,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.092.001.02")]
public partial class DetailedStatisticsPerCounterparty7 {
    
    private Period2 rptgPrdField;
    
    private CounterpartyData78 ctrPtyIdField;
    
    private RejectionStatistics3 rjctnSttstcsField;
    
    private CompetentAuthority1[] cmptntAuthrtyField;
    
    /// <remarks/>
    public Period2 RptgPrd {
        get {
            return this.rptgPrdField;
        }
        set {
            this.rptgPrdField = value;
        }
    }
    
    /// <remarks/>
    public CounterpartyData78 CtrPtyId {
        get {
            return this.ctrPtyIdField;
        }
        set {
            this.ctrPtyIdField = value;
        }
    }
    
    /// <remarks/>
    public RejectionStatistics3 RjctnSttstcs {
        get {
            return this.rjctnSttstcsField;
        }
        set {
            this.rjctnSttstcsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("CmptntAuthrty")]
    public CompetentAuthority1[] CmptntAuthrty {
        get {
            return this.cmptntAuthrtyField;
        }
        set {
            this.cmptntAuthrtyField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.092.001.02")]
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
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.092.001.02")]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.092.001.02")]
public partial class CompetentAuthority1 {
    
    private string idField;
    
    private bool onbrdgStsField;
    
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
    public bool OnbrdgSts {
        get {
            return this.onbrdgStsField;
        }
        set {
            this.onbrdgStsField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.092.001.02")]
public partial class TopReasonsForRejections2 {
    
    private string[] allField;
    
    private string[] newField;
    
    private string[] modField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("All")]
    public string[] All {
        get {
            return this.allField;
        }
        set {
            this.allField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("New")]
    public string[] New {
        get {
            return this.newField;
        }
        set {
            this.newField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Mod")]
    public string[] Mod {
        get {
            return this.modField;
        }
        set {
            this.modField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.092.001.02")]
public partial class StatisticsPerActionType1 {
    
    private decimal allField;
    
    private decimal newField;
    
    private decimal modField;
    
    /// <remarks/>
    public decimal All {
        get {
            return this.allField;
        }
        set {
            this.allField = value;
        }
    }
    
    /// <remarks/>
    public decimal New {
        get {
            return this.newField;
        }
        set {
            this.newField = value;
        }
    }
    
    /// <remarks/>
    public decimal Mod {
        get {
            return this.modField;
        }
        set {
            this.modField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.092.001.02")]
public partial class DerivativesStatistics3 {
    
    private StatisticsPerActionType1 ttlSubmittdField;
    
    private StatisticsPerActionType1 ttlRjctdField;
    
    private StatisticsPerActionType1 ttlCrrctdRjctnsField;
    
    private TopReasonsForRejections2 topRjctnRsnsField;
    
    /// <remarks/>
    public StatisticsPerActionType1 TtlSubmittd {
        get {
            return this.ttlSubmittdField;
        }
        set {
            this.ttlSubmittdField = value;
        }
    }
    
    /// <remarks/>
    public StatisticsPerActionType1 TtlRjctd {
        get {
            return this.ttlRjctdField;
        }
        set {
            this.ttlRjctdField = value;
        }
    }
    
    /// <remarks/>
    public StatisticsPerActionType1 TtlCrrctdRjctns {
        get {
            return this.ttlCrrctdRjctnsField;
        }
        set {
            this.ttlCrrctdRjctnsField = value;
        }
    }
    
    /// <remarks/>
    public TopReasonsForRejections2 TopRjctnRsns {
        get {
            return this.topRjctnRsnsField;
        }
        set {
            this.topRjctnRsnsField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.092.001.02")]
public partial class RejectionStatistics3 {
    
    private decimal ttlNbOfTechRjctnsField;
    
    private DerivativesStatistics3 derivsSttstcsField;
    
    /// <remarks/>
    public decimal TtlNbOfTechRjctns {
        get {
            return this.ttlNbOfTechRjctnsField;
        }
        set {
            this.ttlNbOfTechRjctnsField = value;
        }
    }
    
    /// <remarks/>
    public DerivativesStatistics3 DerivsSttstcs {
        get {
            return this.derivsSttstcsField;
        }
        set {
            this.derivsSttstcsField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.092.001.02")]
public partial class GenericIdentification175 {
    
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.092.001.02")]
public partial class OrganisationIdentification36 {
    
    private GenericIdentification175 idField;
    
    private string nmField;
    
    private string dmclField;
    
    /// <remarks/>
    public GenericIdentification175 Id {
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
    public string Dmcl {
        get {
            return this.dmclField;
        }
        set {
            this.dmclField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.092.001.02")]
public partial class OrganisationIdentification10Choice {
    
    private object itemField;
    
    private ItemChoiceType itemElementNameField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("AnyBIC", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("LEI", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("Othr", typeof(OrganisationIdentification36))]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.092.001.02", IncludeInSchema=false)]
public enum ItemChoiceType {
    
    /// <remarks/>
    AnyBIC,
    
    /// <remarks/>
    LEI,
    
    /// <remarks/>
    Othr,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.092.001.02")]
public partial class CounterpartyData78 {
    
    private OrganisationIdentification10Choice rptSubmitgNttyField;
    
    private OrganisationIdentification10Choice rptgCtrPtyField;
    
    /// <remarks/>
    public OrganisationIdentification10Choice RptSubmitgNtty {
        get {
            return this.rptSubmitgNttyField;
        }
        set {
            this.rptSubmitgNttyField = value;
        }
    }
    
    /// <remarks/>
    public OrganisationIdentification10Choice RptgCtrPty {
        get {
            return this.rptgCtrPtyField;
        }
        set {
            this.rptgCtrPtyField = value;
        }
    }
}

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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.058.001.01")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.058.001.01", IsNullable=false)]
public partial class Document {
    
    private CCPPortfolioStressTestingResultReportV01 cCPPrtflStrssTstgRsltRptField;
    
    /// <remarks/>
    public CCPPortfolioStressTestingResultReportV01 CCPPrtflStrssTstgRsltRpt {
        get {
            return this.cCPPrtflStrssTstgRsltRptField;
        }
        set {
            this.cCPPrtflStrssTstgRsltRptField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.058.001.01")]
public partial class CCPPortfolioStressTestingResultReportV01 {
    
    private ScenarioStressTestResult1[] scnroStrssTstRsltField;
    
    private SupplementaryData1[] splmtryDataField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ScnroStrssTstRslt")]
    public ScenarioStressTestResult1[] ScnroStrssTstRslt {
        get {
            return this.scnroStrssTstRsltField;
        }
        set {
            this.scnroStrssTstRsltField = value;
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.058.001.01")]
public partial class ScenarioStressTestResult1 {
    
    private GenericIdentification168 idField;
    
    private PortfolioStressTestResult1[] prtflStrssTstRsltField;
    
    /// <remarks/>
    public GenericIdentification168 Id {
        get {
            return this.idField;
        }
        set {
            this.idField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("PrtflStrssTstRslt")]
    public PortfolioStressTestResult1[] PrtflStrssTstRslt {
        get {
            return this.prtflStrssTstRsltField;
        }
        set {
            this.prtflStrssTstRsltField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.058.001.01")]
public partial class GenericIdentification168 {
    
    private string idField;
    
    private string descField;
    
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
    public string Desc {
        get {
            return this.descField;
        }
        set {
            this.descField = value;
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.058.001.01")]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.058.001.01")]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.058.001.01")]
public partial class AmountAndDirection102 {
    
    private ActiveCurrencyAndAmount amtField;
    
    private bool sgnField;
    
    /// <remarks/>
    public ActiveCurrencyAndAmount Amt {
        get {
            return this.amtField;
        }
        set {
            this.amtField = value;
        }
    }
    
    /// <remarks/>
    public bool Sgn {
        get {
            return this.sgnField;
        }
        set {
            this.sgnField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.058.001.01")]
public partial class GenericIdentification165 {
    
    private string idField;
    
    private string descField;
    
    private string issrField;
    
    private SchemeIdentificationType1Code schmeNmField;
    
    private bool schmeNmFieldSpecified;
    
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
    public string Desc {
        get {
            return this.descField;
        }
        set {
            this.descField = value;
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
    public SchemeIdentificationType1Code SchmeNm {
        get {
            return this.schmeNmField;
        }
        set {
            this.schmeNmField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool SchmeNmSpecified {
        get {
            return this.schmeNmFieldSpecified;
        }
        set {
            this.schmeNmFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.058.001.01")]
public enum SchemeIdentificationType1Code {
    
    /// <remarks/>
    MARG,
    
    /// <remarks/>
    COLL,
    
    /// <remarks/>
    POSI,
    
    /// <remarks/>
    CLIM,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.058.001.01")]
public partial class PortfolioStressTestResult1 {
    
    private GenericIdentification165 prtflIdField;
    
    private AmountAndDirection102 strssLossField;
    
    private AmountAndDirection102 rawStrssLossField;
    
    private bool cover1FlgField;
    
    private bool cover2FlgField;
    
    /// <remarks/>
    public GenericIdentification165 PrtflId {
        get {
            return this.prtflIdField;
        }
        set {
            this.prtflIdField = value;
        }
    }
    
    /// <remarks/>
    public AmountAndDirection102 StrssLoss {
        get {
            return this.strssLossField;
        }
        set {
            this.strssLossField = value;
        }
    }
    
    /// <remarks/>
    public AmountAndDirection102 RawStrssLoss {
        get {
            return this.rawStrssLossField;
        }
        set {
            this.rawStrssLossField = value;
        }
    }
    
    /// <remarks/>
    public bool Cover1Flg {
        get {
            return this.cover1FlgField;
        }
        set {
            this.cover1FlgField = value;
        }
    }
    
    /// <remarks/>
    public bool Cover2Flg {
        get {
            return this.cover2FlgField;
        }
        set {
            this.cover2FlgField = value;
        }
    }
}

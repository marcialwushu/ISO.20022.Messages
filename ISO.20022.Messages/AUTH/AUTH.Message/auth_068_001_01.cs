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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.068.001.01")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.068.001.01", IsNullable=false)]
public partial class Document {
    
    private CCPAccountPositionReportV01 cCPAcctPosRptField;
    
    /// <remarks/>
    public CCPAccountPositionReportV01 CCPAcctPosRpt {
        get {
            return this.cCPAcctPosRptField;
        }
        set {
            this.cCPAcctPosRptField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.068.001.01")]
public partial class CCPAccountPositionReportV01 {
    
    private PositionAccount2[] prtflField;
    
    private SupplementaryData1[] splmtryDataField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Prtfl")]
    public PositionAccount2[] Prtfl {
        get {
            return this.prtflField;
        }
        set {
            this.prtflField = value;
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.068.001.01")]
public partial class PositionAccount2 {
    
    private GenericIdentification165 idField;
    
    private Position1[] posField;
    
    /// <remarks/>
    public GenericIdentification165 Id {
        get {
            return this.idField;
        }
        set {
            this.idField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Pos")]
    public Position1[] Pos {
        get {
            return this.posField;
        }
        set {
            this.posField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.068.001.01")]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.068.001.01")]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.068.001.01")]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.068.001.01")]
public partial class ActiveCurrencyAnd24Amount {
    
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.068.001.01")]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.068.001.01")]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.068.001.01")]
public partial class EndOfDayRequirement1 {
    
    private ActiveCurrencyAndAmount initlMrgnRqrmntField;
    
    private AmountAndDirection102 vartnMrgnRqrmntField;
    
    /// <remarks/>
    public ActiveCurrencyAndAmount InitlMrgnRqrmnt {
        get {
            return this.initlMrgnRqrmntField;
        }
        set {
            this.initlMrgnRqrmntField = value;
        }
    }
    
    /// <remarks/>
    public AmountAndDirection102 VartnMrgnRqrmnt {
        get {
            return this.vartnMrgnRqrmntField;
        }
        set {
            this.vartnMrgnRqrmntField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.068.001.01")]
public partial class Position1 {
    
    private string pdctIdField;
    
    private EndOfDayRequirement1 rskRqrmntField;
    
    private ActiveCurrencyAnd24Amount grssNtnlField;
    
    private AmountAndDirection102 netNtnlField;
    
    private ActiveCurrencyAndAmount grssDltaEqvtValField;
    
    private AmountAndDirection102 netDltaEqvtValField;
    
    private decimal grssDltaEqvtQtyField;
    
    private bool grssDltaEqvtQtyFieldSpecified;
    
    private decimal netDltaEqvtQtyField;
    
    private bool netDltaEqvtQtyFieldSpecified;
    
    private ActiveCurrencyAndAmount grssMktValField;
    
    /// <remarks/>
    public string PdctId {
        get {
            return this.pdctIdField;
        }
        set {
            this.pdctIdField = value;
        }
    }
    
    /// <remarks/>
    public EndOfDayRequirement1 RskRqrmnt {
        get {
            return this.rskRqrmntField;
        }
        set {
            this.rskRqrmntField = value;
        }
    }
    
    /// <remarks/>
    public ActiveCurrencyAnd24Amount GrssNtnl {
        get {
            return this.grssNtnlField;
        }
        set {
            this.grssNtnlField = value;
        }
    }
    
    /// <remarks/>
    public AmountAndDirection102 NetNtnl {
        get {
            return this.netNtnlField;
        }
        set {
            this.netNtnlField = value;
        }
    }
    
    /// <remarks/>
    public ActiveCurrencyAndAmount GrssDltaEqvtVal {
        get {
            return this.grssDltaEqvtValField;
        }
        set {
            this.grssDltaEqvtValField = value;
        }
    }
    
    /// <remarks/>
    public AmountAndDirection102 NetDltaEqvtVal {
        get {
            return this.netDltaEqvtValField;
        }
        set {
            this.netDltaEqvtValField = value;
        }
    }
    
    /// <remarks/>
    public decimal GrssDltaEqvtQty {
        get {
            return this.grssDltaEqvtQtyField;
        }
        set {
            this.grssDltaEqvtQtyField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool GrssDltaEqvtQtySpecified {
        get {
            return this.grssDltaEqvtQtyFieldSpecified;
        }
        set {
            this.grssDltaEqvtQtyFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public decimal NetDltaEqvtQty {
        get {
            return this.netDltaEqvtQtyField;
        }
        set {
            this.netDltaEqvtQtyField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool NetDltaEqvtQtySpecified {
        get {
            return this.netDltaEqvtQtyFieldSpecified;
        }
        set {
            this.netDltaEqvtQtyFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public ActiveCurrencyAndAmount GrssMktVal {
        get {
            return this.grssMktValField;
        }
        set {
            this.grssMktValField = value;
        }
    }
}

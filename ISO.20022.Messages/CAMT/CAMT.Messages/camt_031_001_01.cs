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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.031.001.01")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.031.001.01", IsNullable=false)]
public partial class Document {
    
    private camt03100101 camt03100101Field;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("camt.031.001.01")]
    public camt03100101 camt03100101 {
        get {
            return this.camt03100101Field;
        }
        set {
            this.camt03100101Field = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(TypeName="camt.031.001.01", Namespace="urn:iso:std:iso:20022:tech:xsd:camt.031.001.01")]
public partial class camt03100101 {
    
    private CaseAssignment assgnmtField;
    
    private Case caseField;
    
    private CaseAssignmentRejectionJustification justfnField;
    
    /// <remarks/>
    public CaseAssignment Assgnmt {
        get {
            return this.assgnmtField;
        }
        set {
            this.assgnmtField = value;
        }
    }
    
    /// <remarks/>
    public Case Case {
        get {
            return this.caseField;
        }
        set {
            this.caseField = value;
        }
    }
    
    /// <remarks/>
    public CaseAssignmentRejectionJustification Justfn {
        get {
            return this.justfnField;
        }
        set {
            this.justfnField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.031.001.01")]
public partial class CaseAssignment {
    
    private string idField;
    
    private string assgnrField;
    
    private string assgneField;
    
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
    public string Assgnr {
        get {
            return this.assgnrField;
        }
        set {
            this.assgnrField = value;
        }
    }
    
    /// <remarks/>
    public string Assgne {
        get {
            return this.assgneField;
        }
        set {
            this.assgneField = value;
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.031.001.01")]
public partial class CaseAssignmentRejectionJustification {
    
    private CaseAssignmentRejection1Code rjctnRsnField;
    
    /// <remarks/>
    public CaseAssignmentRejection1Code RjctnRsn {
        get {
            return this.rjctnRsnField;
        }
        set {
            this.rjctnRsnField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.031.001.01")]
public enum CaseAssignmentRejection1Code {
    
    /// <remarks/>
    NFND,
    
    /// <remarks/>
    NAUT,
    
    /// <remarks/>
    UKNW,
    
    /// <remarks/>
    RJCT,
    
    /// <remarks/>
    CNCL,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.031.001.01")]
public partial class Case {
    
    private string idField;
    
    private string cretrField;
    
    private bool reopCaseIndctnField;
    
    private bool reopCaseIndctnFieldSpecified;
    
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
    public string Cretr {
        get {
            return this.cretrField;
        }
        set {
            this.cretrField = value;
        }
    }
    
    /// <remarks/>
    public bool ReopCaseIndctn {
        get {
            return this.reopCaseIndctnField;
        }
        set {
            this.reopCaseIndctnField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool ReopCaseIndctnSpecified {
        get {
            return this.reopCaseIndctnFieldSpecified;
        }
        set {
            this.reopCaseIndctnFieldSpecified = value;
        }
    }
}

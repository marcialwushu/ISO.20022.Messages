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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.011.001.01")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.011.001.01", IsNullable=false)]
public partial class Document {
    
    private RegulatoryTransactionReportCancellationStatusV01 rgltryTxRptCxlStsV01Field;
    
    /// <remarks/>
    public RegulatoryTransactionReportCancellationStatusV01 RgltryTxRptCxlStsV01 {
        get {
            return this.rgltryTxRptCxlStsV01Field;
        }
        set {
            this.rgltryTxRptCxlStsV01Field = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.011.001.01")]
public partial class RegulatoryTransactionReportCancellationStatusV01 {
    
    private DocumentIdentification8 idField;
    
    private PartyIdentification23Choice rptgInstnField;
    
    private object[] itemsField;
    
    /// <remarks/>
    public DocumentIdentification8 Id {
        get {
            return this.idField;
        }
        set {
            this.idField = value;
        }
    }
    
    /// <remarks/>
    public PartyIdentification23Choice RptgInstn {
        get {
            return this.rptgInstnField;
        }
        set {
            this.rptgInstnField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("IndvTxCxlSts", typeof(TradeTransactionStatusAndReason2))]
    [System.Xml.Serialization.XmlElementAttribute("RptCxlSts", typeof(ReportStatusAndReason2))]
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
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.011.001.01")]
public partial class DocumentIdentification8 {
    
    private string idField;
    
    private System.DateTime creDtTmField;
    
    private bool creDtTmFieldSpecified;
    
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
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool CreDtTmSpecified {
        get {
            return this.creDtTmFieldSpecified;
        }
        set {
            this.creDtTmFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.011.001.01")]
public partial class TradeTransactionStatusAndReason2 {
    
    private string rltdRefField;
    
    private string tradRefField;
    
    private object[] itemsField;
    
    /// <remarks/>
    public string RltdRef {
        get {
            return this.rltdRefField;
        }
        set {
            this.rltdRefField = value;
        }
    }
    
    /// <remarks/>
    public string TradRef {
        get {
            return this.tradRefField;
        }
        set {
            this.tradRefField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Rjctd", typeof(RejectedCancellationStatusReason1Choice))]
    [System.Xml.Serialization.XmlElementAttribute("Sts", typeof(Status2Code))]
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
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.011.001.01")]
public partial class RejectedCancellationStatusReason1Choice {
    
    private object itemField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("DataSrcSchme", typeof(GenericIdentification1))]
    [System.Xml.Serialization.XmlElementAttribute("Rsn", typeof(RejectedCancellationStatusReason1Code))]
    [System.Xml.Serialization.XmlElementAttribute("XtndedRsn", typeof(string))]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.011.001.01")]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.011.001.01")]
public enum RejectedCancellationStatusReason1Code {
    
    /// <remarks/>
    REFE,
    
    /// <remarks/>
    NRGM,
    
    /// <remarks/>
    NSLA,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.011.001.01")]
public enum Status2Code {
    
    /// <remarks/>
    COMP,
    
    /// <remarks/>
    PDNG,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.011.001.01")]
public partial class ReportStatusAndReason2 {
    
    private string rltdRefField;
    
    private object[] itemsField;
    
    /// <remarks/>
    public string RltdRef {
        get {
            return this.rltdRefField;
        }
        set {
            this.rltdRefField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Rjctd", typeof(RejectedCancellationStatusReason1Choice))]
    [System.Xml.Serialization.XmlElementAttribute("Sts", typeof(Status2Code))]
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
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.011.001.01")]
public partial class PartyIdentification23Choice {
    
    private object itemField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("BICOrBEI", typeof(string))]
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

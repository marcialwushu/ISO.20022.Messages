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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.007.001.02")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.007.001.02", IsNullable=false)]
public partial class Document {
    
    private AmendmentRejectionV02 amdmntRjctnField;
    
    /// <remarks/>
    public AmendmentRejectionV02 AmdmntRjctn {
        get {
            return this.amdmntRjctnField;
        }
        set {
            this.amdmntRjctnField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.007.001.02")]
public partial class AmendmentRejectionV02 {
    
    private MessageIdentification1 rjctnIdField;
    
    private SimpleIdentificationInformation txIdField;
    
    private SimpleIdentificationInformation submitrTxRefField;
    
    private MessageIdentification1 dltaRptRefField;
    
    private Count1 rjctdAmdmntNbField;
    
    private RejectionReason1Choice rjctnRsnField;
    
    /// <remarks/>
    public MessageIdentification1 RjctnId {
        get {
            return this.rjctnIdField;
        }
        set {
            this.rjctnIdField = value;
        }
    }
    
    /// <remarks/>
    public SimpleIdentificationInformation TxId {
        get {
            return this.txIdField;
        }
        set {
            this.txIdField = value;
        }
    }
    
    /// <remarks/>
    public SimpleIdentificationInformation SubmitrTxRef {
        get {
            return this.submitrTxRefField;
        }
        set {
            this.submitrTxRefField = value;
        }
    }
    
    /// <remarks/>
    public MessageIdentification1 DltaRptRef {
        get {
            return this.dltaRptRefField;
        }
        set {
            this.dltaRptRefField = value;
        }
    }
    
    /// <remarks/>
    public Count1 RjctdAmdmntNb {
        get {
            return this.rjctdAmdmntNbField;
        }
        set {
            this.rjctdAmdmntNbField = value;
        }
    }
    
    /// <remarks/>
    public RejectionReason1Choice RjctnRsn {
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
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.007.001.02")]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.007.001.02")]
public partial class RejectedElement1 {
    
    private decimal elmtSeqNbField;
    
    private string indvRjctnRsnField;
    
    /// <remarks/>
    public decimal ElmtSeqNb {
        get {
            return this.elmtSeqNbField;
        }
        set {
            this.elmtSeqNbField = value;
        }
    }
    
    /// <remarks/>
    public string IndvRjctnRsn {
        get {
            return this.indvRjctnRsnField;
        }
        set {
            this.indvRjctnRsnField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.007.001.02")]
public partial class Reason2 {
    
    private string descField;
    
    /// <remarks/>
    public string Desc {
        get {
            return this.descField;
        }
        set {
            this.descField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.007.001.02")]
public partial class RejectionReason1Choice {
    
    private object[] itemsField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("GblRjctnRsn", typeof(Reason2))]
    [System.Xml.Serialization.XmlElementAttribute("RjctdElmt", typeof(RejectedElement1))]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.007.001.02")]
public partial class Count1 {
    
    private decimal nbField;
    
    /// <remarks/>
    public decimal Nb {
        get {
            return this.nbField;
        }
        set {
            this.nbField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.007.001.02")]
public partial class SimpleIdentificationInformation {
    
    private string idField;
    
    /// <remarks/>
    public string Id {
        get {
            return this.idField;
        }
        set {
            this.idField = value;
        }
    }
}

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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.049.001.01")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.049.001.01", IsNullable=false)]
public partial class Document {
    
    private RoleAndBaselineAcceptanceV01 roleAndBaselnAccptncField;
    
    /// <remarks/>
    public RoleAndBaselineAcceptanceV01 RoleAndBaselnAccptnc {
        get {
            return this.roleAndBaselnAccptncField;
        }
        set {
            this.roleAndBaselnAccptncField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.049.001.01")]
public partial class RoleAndBaselineAcceptanceV01 {
    
    private MessageIdentification1 accptncIdField;
    
    private MessageIdentification1 rltdMsgRefField;
    
    private SimpleIdentificationInformation txIdField;
    
    /// <remarks/>
    public MessageIdentification1 AccptncId {
        get {
            return this.accptncIdField;
        }
        set {
            this.accptncIdField = value;
        }
    }
    
    /// <remarks/>
    public MessageIdentification1 RltdMsgRef {
        get {
            return this.rltdMsgRefField;
        }
        set {
            this.rltdMsgRefField = value;
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
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.049.001.01")]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.049.001.01")]
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

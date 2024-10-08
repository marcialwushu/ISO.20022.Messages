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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.002.001.03")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.002.001.03", IsNullable=false)]
public partial class Document {
    
    private ActivityReportV03 actvtyRptField;
    
    /// <remarks/>
    public ActivityReportV03 ActvtyRpt {
        get {
            return this.actvtyRptField;
        }
        set {
            this.actvtyRptField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.002.001.03")]
public partial class ActivityReportV03 {
    
    private MessageIdentification1 rptIdField;
    
    private MessageIdentification1 rltdMsgRefField;
    
    private ActivityReportItems2[] rptField;
    
    /// <remarks/>
    public MessageIdentification1 RptId {
        get {
            return this.rptIdField;
        }
        set {
            this.rptIdField = value;
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
    [System.Xml.Serialization.XmlElementAttribute("Rpt")]
    public ActivityReportItems2[] Rpt {
        get {
            return this.rptField;
        }
        set {
            this.rptField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.002.001.03")]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.002.001.03")]
public partial class PendingActivity2 {
    
    private Action2Code tpField;
    
    private string descField;
    
    /// <remarks/>
    public Action2Code Tp {
        get {
            return this.tpField;
        }
        set {
            this.tpField = value;
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
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.002.001.03")]
public enum Action2Code {
    
    /// <remarks/>
    SBTW,
    
    /// <remarks/>
    RSTW,
    
    /// <remarks/>
    RSBS,
    
    /// <remarks/>
    ARDM,
    
    /// <remarks/>
    ARCS,
    
    /// <remarks/>
    ARES,
    
    /// <remarks/>
    WAIT,
    
    /// <remarks/>
    UPDT,
    
    /// <remarks/>
    SBDS,
    
    /// <remarks/>
    ARBA,
    
    /// <remarks/>
    ARRO,
    
    /// <remarks/>
    CINR,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.002.001.03")]
public partial class Activity1 {
    
    private string msgNmField;
    
    private string descField;
    
    /// <remarks/>
    public string MsgNm {
        get {
            return this.msgNmField;
        }
        set {
            this.msgNmField = value;
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
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.002.001.03")]
public partial class ActivityDetails1 {
    
    private System.DateTime dtTmField;
    
    private Activity1 actvtyField;
    
    private BICIdentification1 initrField;
    
    /// <remarks/>
    public System.DateTime DtTm {
        get {
            return this.dtTmField;
        }
        set {
            this.dtTmField = value;
        }
    }
    
    /// <remarks/>
    public Activity1 Actvty {
        get {
            return this.actvtyField;
        }
        set {
            this.actvtyField = value;
        }
    }
    
    /// <remarks/>
    public BICIdentification1 Initr {
        get {
            return this.initrField;
        }
        set {
            this.initrField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.002.001.03")]
public partial class BICIdentification1 {
    
    private string bICField;
    
    /// <remarks/>
    public string BIC {
        get {
            return this.bICField;
        }
        set {
            this.bICField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.002.001.03")]
public partial class DocumentIdentification5 {
    
    private string idField;
    
    private BICIdentification1 idIssrField;
    
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
    public BICIdentification1 IdIssr {
        get {
            return this.idIssrField;
        }
        set {
            this.idIssrField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.002.001.03")]
public partial class ActivityReportItems2 {
    
    private string txIdField;
    
    private DocumentIdentification5[] usrTxRefField;
    
    private BICIdentification1 rptdNttyField;
    
    private ActivityDetails1[] rptdItmField;
    
    private PendingActivity2[] pdgReqForActnField;
    
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
    [System.Xml.Serialization.XmlElementAttribute("UsrTxRef")]
    public DocumentIdentification5[] UsrTxRef {
        get {
            return this.usrTxRefField;
        }
        set {
            this.usrTxRefField = value;
        }
    }
    
    /// <remarks/>
    public BICIdentification1 RptdNtty {
        get {
            return this.rptdNttyField;
        }
        set {
            this.rptdNttyField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("RptdItm")]
    public ActivityDetails1[] RptdItm {
        get {
            return this.rptdItmField;
        }
        set {
            this.rptdItmField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("PdgReqForActn")]
    public PendingActivity2[] PdgReqForActn {
        get {
            return this.pdgReqForActnField;
        }
        set {
            this.pdgReqForActnField = value;
        }
    }
}

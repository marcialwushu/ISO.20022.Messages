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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.008.001.03")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.008.001.03", IsNullable=false)]
public partial class Document {
    
    private AmendmentRejectionNotificationV03 amdmntRjctnNtfctnField;
    
    /// <remarks/>
    public AmendmentRejectionNotificationV03 AmdmntRjctnNtfctn {
        get {
            return this.amdmntRjctnNtfctnField;
        }
        set {
            this.amdmntRjctnNtfctnField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.008.001.03")]
public partial class AmendmentRejectionNotificationV03 {
    
    private MessageIdentification1 ntfctnIdField;
    
    private SimpleIdentificationInformation txIdField;
    
    private DocumentIdentification3 estblishdBaselnIdField;
    
    private TransactionStatus4 txStsField;
    
    private DocumentIdentification5[] usrTxRefField;
    
    private MessageIdentification1 dltaRptRefField;
    
    private Count1 rjctdAmdmntNbField;
    
    private BICIdentification1 initrField;
    
    private RejectionReason1Choice rjctnRsnField;
    
    private PendingActivity2 reqForActnField;
    
    /// <remarks/>
    public MessageIdentification1 NtfctnId {
        get {
            return this.ntfctnIdField;
        }
        set {
            this.ntfctnIdField = value;
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
    public DocumentIdentification3 EstblishdBaselnId {
        get {
            return this.estblishdBaselnIdField;
        }
        set {
            this.estblishdBaselnIdField = value;
        }
    }
    
    /// <remarks/>
    public TransactionStatus4 TxSts {
        get {
            return this.txStsField;
        }
        set {
            this.txStsField = value;
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
    public BICIdentification1 Initr {
        get {
            return this.initrField;
        }
        set {
            this.initrField = value;
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
    
    /// <remarks/>
    public PendingActivity2 ReqForActn {
        get {
            return this.reqForActnField;
        }
        set {
            this.reqForActnField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.008.001.03")]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.008.001.03")]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.008.001.03")]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.008.001.03")]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.008.001.03")]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.008.001.03")]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.008.001.03")]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.008.001.03")]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.008.001.03")]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.008.001.03")]
public partial class TransactionStatus4 {
    
    private BaselineStatus3Code stsField;
    
    /// <remarks/>
    public BaselineStatus3Code Sts {
        get {
            return this.stsField;
        }
        set {
            this.stsField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.008.001.03")]
public enum BaselineStatus3Code {
    
    /// <remarks/>
    PROP,
    
    /// <remarks/>
    CLSD,
    
    /// <remarks/>
    PMTC,
    
    /// <remarks/>
    ESTD,
    
    /// <remarks/>
    ACTV,
    
    /// <remarks/>
    COMP,
    
    /// <remarks/>
    AMRQ,
    
    /// <remarks/>
    RARQ,
    
    /// <remarks/>
    CLRQ,
    
    /// <remarks/>
    SCRQ,
    
    /// <remarks/>
    SERQ,
    
    /// <remarks/>
    DARQ,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.008.001.03")]
public partial class DocumentIdentification3 {
    
    private string idField;
    
    private decimal vrsnField;
    
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
    public decimal Vrsn {
        get {
            return this.vrsnField;
        }
        set {
            this.vrsnField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.008.001.03")]
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

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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:caaa.015.001.02")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:caaa.015.001.02", IsNullable=false)]
public partial class Document {
    
    private AcceptorRejectionV02 accptrRjctnField;
    
    /// <remarks/>
    public AcceptorRejectionV02 AccptrRjctn {
        get {
            return this.accptrRjctnField;
        }
        set {
            this.accptrRjctnField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:caaa.015.001.02")]
public partial class AcceptorRejectionV02 {
    
    private Header5 hdrField;
    
    private AcceptorRejection1 rjctField;
    
    /// <remarks/>
    public Header5 Hdr {
        get {
            return this.hdrField;
        }
        set {
            this.hdrField = value;
        }
    }
    
    /// <remarks/>
    public AcceptorRejection1 Rjct {
        get {
            return this.rjctField;
        }
        set {
            this.rjctField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:caaa.015.001.02")]
public partial class Header5 {
    
    private MessageFunction1Code msgFctnField;
    
    private string prtcolVrsnField;
    
    private string xchgIdField;
    
    private System.DateTime creDtTmField;
    
    private GenericIdentification32 initgPtyField;
    
    private GenericIdentification32 rcptPtyField;
    
    private Traceability1[] tracbltField;
    
    /// <remarks/>
    public MessageFunction1Code MsgFctn {
        get {
            return this.msgFctnField;
        }
        set {
            this.msgFctnField = value;
        }
    }
    
    /// <remarks/>
    public string PrtcolVrsn {
        get {
            return this.prtcolVrsnField;
        }
        set {
            this.prtcolVrsnField = value;
        }
    }
    
    /// <remarks/>
    public string XchgId {
        get {
            return this.xchgIdField;
        }
        set {
            this.xchgIdField = value;
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
    public GenericIdentification32 InitgPty {
        get {
            return this.initgPtyField;
        }
        set {
            this.initgPtyField = value;
        }
    }
    
    /// <remarks/>
    public GenericIdentification32 RcptPty {
        get {
            return this.rcptPtyField;
        }
        set {
            this.rcptPtyField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Tracblt")]
    public Traceability1[] Tracblt {
        get {
            return this.tracbltField;
        }
        set {
            this.tracbltField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:caaa.015.001.02")]
public enum MessageFunction1Code {
    
    /// <remarks/>
    AUTQ,
    
    /// <remarks/>
    AUTP,
    
    /// <remarks/>
    FAUQ,
    
    /// <remarks/>
    FAUP,
    
    /// <remarks/>
    CMPV,
    
    /// <remarks/>
    CMPK,
    
    /// <remarks/>
    FCMV,
    
    /// <remarks/>
    FCMK,
    
    /// <remarks/>
    RVRA,
    
    /// <remarks/>
    RVRR,
    
    /// <remarks/>
    FRVA,
    
    /// <remarks/>
    FRVR,
    
    /// <remarks/>
    CCAQ,
    
    /// <remarks/>
    CCAP,
    
    /// <remarks/>
    CCAV,
    
    /// <remarks/>
    CCAK,
    
    /// <remarks/>
    DGNP,
    
    /// <remarks/>
    DGNQ,
    
    /// <remarks/>
    RCLQ,
    
    /// <remarks/>
    RCLP,
    
    /// <remarks/>
    RJCT,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:caaa.015.001.02")]
public partial class GenericIdentification32 {
    
    private string idField;
    
    private PartyType3Code tpField;
    
    private bool tpFieldSpecified;
    
    private PartyType4Code issrField;
    
    private bool issrFieldSpecified;
    
    private string shrtNmField;
    
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
    public PartyType3Code Tp {
        get {
            return this.tpField;
        }
        set {
            this.tpField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool TpSpecified {
        get {
            return this.tpFieldSpecified;
        }
        set {
            this.tpFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public PartyType4Code Issr {
        get {
            return this.issrField;
        }
        set {
            this.issrField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool IssrSpecified {
        get {
            return this.issrFieldSpecified;
        }
        set {
            this.issrFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public string ShrtNm {
        get {
            return this.shrtNmField;
        }
        set {
            this.shrtNmField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:caaa.015.001.02")]
public enum PartyType3Code {
    
    /// <remarks/>
    OPOI,
    
    /// <remarks/>
    MERC,
    
    /// <remarks/>
    ACCP,
    
    /// <remarks/>
    ITAG,
    
    /// <remarks/>
    ACQR,
    
    /// <remarks/>
    CISS,
    
    /// <remarks/>
    DLIS,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:caaa.015.001.02")]
public enum PartyType4Code {
    
    /// <remarks/>
    MERC,
    
    /// <remarks/>
    ACCP,
    
    /// <remarks/>
    ITAG,
    
    /// <remarks/>
    ACQR,
    
    /// <remarks/>
    CISS,
    
    /// <remarks/>
    TAXH,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:caaa.015.001.02")]
public partial class AcceptorRejection1 {
    
    private RejectReason1Code rjctRsnField;
    
    private string addtlInfField;
    
    private byte[] msgInErrField;
    
    /// <remarks/>
    public RejectReason1Code RjctRsn {
        get {
            return this.rjctRsnField;
        }
        set {
            this.rjctRsnField = value;
        }
    }
    
    /// <remarks/>
    public string AddtlInf {
        get {
            return this.addtlInfField;
        }
        set {
            this.addtlInfField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
    public byte[] MsgInErr {
        get {
            return this.msgInErrField;
        }
        set {
            this.msgInErrField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:caaa.015.001.02")]
public enum RejectReason1Code {
    
    /// <remarks/>
    UNPR,
    
    /// <remarks/>
    IMSG,
    
    /// <remarks/>
    PARS,
    
    /// <remarks/>
    SECU,
    
    /// <remarks/>
    INTP,
    
    /// <remarks/>
    RCPP,
    
    /// <remarks/>
    DPMG,
    
    /// <remarks/>
    VERS,
    
    /// <remarks/>
    MSGT,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:caaa.015.001.02")]
public partial class GenericIdentification31 {
    
    private string idField;
    
    private PartyType3Code tpField;
    
    private PartyType4Code issrField;
    
    private bool issrFieldSpecified;
    
    private string shrtNmField;
    
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
    public PartyType3Code Tp {
        get {
            return this.tpField;
        }
        set {
            this.tpField = value;
        }
    }
    
    /// <remarks/>
    public PartyType4Code Issr {
        get {
            return this.issrField;
        }
        set {
            this.issrField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool IssrSpecified {
        get {
            return this.issrFieldSpecified;
        }
        set {
            this.issrFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public string ShrtNm {
        get {
            return this.shrtNmField;
        }
        set {
            this.shrtNmField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:caaa.015.001.02")]
public partial class Traceability1 {
    
    private GenericIdentification31 rlayIdField;
    
    private System.DateTime tracDtTmInField;
    
    private System.DateTime tracDtTmOutField;
    
    /// <remarks/>
    public GenericIdentification31 RlayId {
        get {
            return this.rlayIdField;
        }
        set {
            this.rlayIdField = value;
        }
    }
    
    /// <remarks/>
    public System.DateTime TracDtTmIn {
        get {
            return this.tracDtTmInField;
        }
        set {
            this.tracDtTmInField = value;
        }
    }
    
    /// <remarks/>
    public System.DateTime TracDtTmOut {
        get {
            return this.tracDtTmOutField;
        }
        set {
            this.tracDtTmOutField = value;
        }
    }
}

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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:caaa.010.001.03")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:caaa.010.001.03", IsNullable=false)]
public partial class Document {
    
    private AcceptorReconciliationResponseV03 accptrRcncltnRspnField;
    
    /// <remarks/>
    public AcceptorReconciliationResponseV03 AccptrRcncltnRspn {
        get {
            return this.accptrRcncltnRspnField;
        }
        set {
            this.accptrRcncltnRspnField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:caaa.010.001.03")]
public partial class AcceptorReconciliationResponseV03 {
    
    private Header7 hdrField;
    
    private AcceptorReconciliationResponse2 rcncltnRspnField;
    
    private ContentInformationType8 sctyTrlrField;
    
    /// <remarks/>
    public Header7 Hdr {
        get {
            return this.hdrField;
        }
        set {
            this.hdrField = value;
        }
    }
    
    /// <remarks/>
    public AcceptorReconciliationResponse2 RcncltnRspn {
        get {
            return this.rcncltnRspnField;
        }
        set {
            this.rcncltnRspnField = value;
        }
    }
    
    /// <remarks/>
    public ContentInformationType8 SctyTrlr {
        get {
            return this.sctyTrlrField;
        }
        set {
            this.sctyTrlrField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:caaa.010.001.03")]
public partial class Header7 {
    
    private MessageFunction4Code msgFctnField;
    
    private string prtcolVrsnField;
    
    private string xchgIdField;
    
    private System.DateTime creDtTmField;
    
    private GenericIdentification32 initgPtyField;
    
    private GenericIdentification32 rcptPtyField;
    
    private Traceability1[] tracbltField;
    
    /// <remarks/>
    public MessageFunction4Code MsgFctn {
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:caaa.010.001.03")]
public enum MessageFunction4Code {
    
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
    
    /// <remarks/>
    DCCQ,
    
    /// <remarks/>
    DCCP,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:caaa.010.001.03")]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:caaa.010.001.03")]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:caaa.010.001.03")]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:caaa.010.001.03")]
public partial class EncapsulatedContent2 {
    
    private ContentType1Code cnttTpField;
    
    private byte[] cnttField;
    
    /// <remarks/>
    public ContentType1Code CnttTp {
        get {
            return this.cnttTpField;
        }
        set {
            this.cnttTpField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
    public byte[] Cntt {
        get {
            return this.cnttField;
        }
        set {
            this.cnttField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:caaa.010.001.03")]
public enum ContentType1Code {
    
    /// <remarks/>
    DATA,
    
    /// <remarks/>
    SIGN,
    
    /// <remarks/>
    EVLP,
    
    /// <remarks/>
    DGST,
    
    /// <remarks/>
    ECRP,
    
    /// <remarks/>
    AUTH,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:caaa.010.001.03")]
public partial class AlgorithmIdentification10 {
    
    private Algorithm10Code algoField;
    
    private Parameter1 paramField;
    
    /// <remarks/>
    public Algorithm10Code Algo {
        get {
            return this.algoField;
        }
        set {
            this.algoField = value;
        }
    }
    
    /// <remarks/>
    public Parameter1 Param {
        get {
            return this.paramField;
        }
        set {
            this.paramField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:caaa.010.001.03")]
public enum Algorithm10Code {
    
    /// <remarks/>
    MACC,
    
    /// <remarks/>
    MCCS,
    
    /// <remarks/>
    CMA1,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:caaa.010.001.03")]
public partial class Parameter1 {
    
    private byte[] initlstnVctrField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
    public byte[] InitlstnVctr {
        get {
            return this.initlstnVctrField;
        }
        set {
            this.initlstnVctrField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:caaa.010.001.03")]
public partial class AlgorithmIdentification9 {
    
    private Algorithm9Code algoField;
    
    private Parameter1 paramField;
    
    /// <remarks/>
    public Algorithm9Code Algo {
        get {
            return this.algoField;
        }
        set {
            this.algoField = value;
        }
    }
    
    /// <remarks/>
    public Parameter1 Param {
        get {
            return this.paramField;
        }
        set {
            this.paramField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:caaa.010.001.03")]
public enum Algorithm9Code {
    
    /// <remarks/>
    EA2C,
    
    /// <remarks/>
    E3DC,
    
    /// <remarks/>
    DKP9,
    
    /// <remarks/>
    UKPT,
    
    /// <remarks/>
    UKA1,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:caaa.010.001.03")]
public partial class KEKIdentifier1 {
    
    private string keyIdField;
    
    private string keyVrsnField;
    
    private byte[] derivtnIdField;
    
    /// <remarks/>
    public string KeyId {
        get {
            return this.keyIdField;
        }
        set {
            this.keyIdField = value;
        }
    }
    
    /// <remarks/>
    public string KeyVrsn {
        get {
            return this.keyVrsnField;
        }
        set {
            this.keyVrsnField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
    public byte[] DerivtnId {
        get {
            return this.derivtnIdField;
        }
        set {
            this.derivtnIdField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:caaa.010.001.03")]
public partial class KEK3 {
    
    private decimal vrsnField;
    
    private bool vrsnFieldSpecified;
    
    private KEKIdentifier1 kEKIdField;
    
    private AlgorithmIdentification9 keyNcrptnAlgoField;
    
    private byte[] ncrptdKeyField;
    
    /// <remarks/>
    public decimal Vrsn {
        get {
            return this.vrsnField;
        }
        set {
            this.vrsnField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool VrsnSpecified {
        get {
            return this.vrsnFieldSpecified;
        }
        set {
            this.vrsnFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public KEKIdentifier1 KEKId {
        get {
            return this.kEKIdField;
        }
        set {
            this.kEKIdField = value;
        }
    }
    
    /// <remarks/>
    public AlgorithmIdentification9 KeyNcrptnAlgo {
        get {
            return this.keyNcrptnAlgoField;
        }
        set {
            this.keyNcrptnAlgoField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
    public byte[] NcrptdKey {
        get {
            return this.ncrptdKeyField;
        }
        set {
            this.ncrptdKeyField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:caaa.010.001.03")]
public partial class Parameter3 {
    
    private Algorithm5Code dgstAlgoField;
    
    private bool dgstAlgoFieldSpecified;
    
    /// <remarks/>
    public Algorithm5Code DgstAlgo {
        get {
            return this.dgstAlgoField;
        }
        set {
            this.dgstAlgoField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool DgstAlgoSpecified {
        get {
            return this.dgstAlgoFieldSpecified;
        }
        set {
            this.dgstAlgoFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:caaa.010.001.03")]
public enum Algorithm5Code {
    
    /// <remarks/>
    HS25,
    
    /// <remarks/>
    HS38,
    
    /// <remarks/>
    HS51,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:caaa.010.001.03")]
public partial class AlgorithmIdentification8 {
    
    private Algorithm8Code algoField;
    
    private Parameter3 paramField;
    
    /// <remarks/>
    public Algorithm8Code Algo {
        get {
            return this.algoField;
        }
        set {
            this.algoField = value;
        }
    }
    
    /// <remarks/>
    public Parameter3 Param {
        get {
            return this.paramField;
        }
        set {
            this.paramField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:caaa.010.001.03")]
public enum Algorithm8Code {
    
    /// <remarks/>
    MGF1,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:caaa.010.001.03")]
public partial class Parameter2 {
    
    private Algorithm5Code dgstAlgoField;
    
    private bool dgstAlgoFieldSpecified;
    
    private AlgorithmIdentification8 mskGnrtrAlgoField;
    
    /// <remarks/>
    public Algorithm5Code DgstAlgo {
        get {
            return this.dgstAlgoField;
        }
        set {
            this.dgstAlgoField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool DgstAlgoSpecified {
        get {
            return this.dgstAlgoFieldSpecified;
        }
        set {
            this.dgstAlgoFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public AlgorithmIdentification8 MskGnrtrAlgo {
        get {
            return this.mskGnrtrAlgoField;
        }
        set {
            this.mskGnrtrAlgoField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:caaa.010.001.03")]
public partial class AlgorithmIdentification7 {
    
    private Algorithm7Code algoField;
    
    private Parameter2 paramField;
    
    /// <remarks/>
    public Algorithm7Code Algo {
        get {
            return this.algoField;
        }
        set {
            this.algoField = value;
        }
    }
    
    /// <remarks/>
    public Parameter2 Param {
        get {
            return this.paramField;
        }
        set {
            this.paramField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:caaa.010.001.03")]
public enum Algorithm7Code {
    
    /// <remarks/>
    ERSA,
    
    /// <remarks/>
    RSAO,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:caaa.010.001.03")]
public partial class RelativeDistinguishedName1 {
    
    private AttributeType1Code attrTpField;
    
    private string attrValField;
    
    /// <remarks/>
    public AttributeType1Code AttrTp {
        get {
            return this.attrTpField;
        }
        set {
            this.attrTpField = value;
        }
    }
    
    /// <remarks/>
    public string AttrVal {
        get {
            return this.attrValField;
        }
        set {
            this.attrValField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:caaa.010.001.03")]
public enum AttributeType1Code {
    
    /// <remarks/>
    CNAT,
    
    /// <remarks/>
    LATT,
    
    /// <remarks/>
    OATT,
    
    /// <remarks/>
    OUAT,
    
    /// <remarks/>
    CATT,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:caaa.010.001.03")]
public partial class IssuerAndSerialNumber1 {
    
    private RelativeDistinguishedName1[] issrField;
    
    private byte[] srlNbField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("RltvDstngshdNm", IsNullable=false)]
    public RelativeDistinguishedName1[] Issr {
        get {
            return this.issrField;
        }
        set {
            this.issrField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
    public byte[] SrlNb {
        get {
            return this.srlNbField;
        }
        set {
            this.srlNbField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:caaa.010.001.03")]
public partial class CertificateIdentifier1 {
    
    private IssuerAndSerialNumber1 issrAndSrlNbField;
    
    /// <remarks/>
    public IssuerAndSerialNumber1 IssrAndSrlNb {
        get {
            return this.issrAndSrlNbField;
        }
        set {
            this.issrAndSrlNbField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:caaa.010.001.03")]
public partial class KeyTransport3 {
    
    private decimal vrsnField;
    
    private bool vrsnFieldSpecified;
    
    private CertificateIdentifier1 rcptIdField;
    
    private AlgorithmIdentification7 keyNcrptnAlgoField;
    
    private byte[] ncrptdKeyField;
    
    /// <remarks/>
    public decimal Vrsn {
        get {
            return this.vrsnField;
        }
        set {
            this.vrsnField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool VrsnSpecified {
        get {
            return this.vrsnFieldSpecified;
        }
        set {
            this.vrsnFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public CertificateIdentifier1 RcptId {
        get {
            return this.rcptIdField;
        }
        set {
            this.rcptIdField = value;
        }
    }
    
    /// <remarks/>
    public AlgorithmIdentification7 KeyNcrptnAlgo {
        get {
            return this.keyNcrptnAlgoField;
        }
        set {
            this.keyNcrptnAlgoField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
    public byte[] NcrptdKey {
        get {
            return this.ncrptdKeyField;
        }
        set {
            this.ncrptdKeyField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:caaa.010.001.03")]
public partial class Recipient3Choice {
    
    private object itemField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("KEK", typeof(KEK3))]
    [System.Xml.Serialization.XmlElementAttribute("KeyIdr", typeof(KEKIdentifier1))]
    [System.Xml.Serialization.XmlElementAttribute("KeyTrnsprt", typeof(KeyTransport3))]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:caaa.010.001.03")]
public partial class AuthenticatedData3 {
    
    private decimal vrsnField;
    
    private bool vrsnFieldSpecified;
    
    private Recipient3Choice[] rcptField;
    
    private AlgorithmIdentification10 mACAlgoField;
    
    private EncapsulatedContent2 ncpsltdCnttField;
    
    private byte[] mACField;
    
    /// <remarks/>
    public decimal Vrsn {
        get {
            return this.vrsnField;
        }
        set {
            this.vrsnField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool VrsnSpecified {
        get {
            return this.vrsnFieldSpecified;
        }
        set {
            this.vrsnFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Rcpt")]
    public Recipient3Choice[] Rcpt {
        get {
            return this.rcptField;
        }
        set {
            this.rcptField = value;
        }
    }
    
    /// <remarks/>
    public AlgorithmIdentification10 MACAlgo {
        get {
            return this.mACAlgoField;
        }
        set {
            this.mACAlgoField = value;
        }
    }
    
    /// <remarks/>
    public EncapsulatedContent2 NcpsltdCntt {
        get {
            return this.ncpsltdCnttField;
        }
        set {
            this.ncpsltdCnttField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
    public byte[] MAC {
        get {
            return this.mACField;
        }
        set {
            this.mACField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:caaa.010.001.03")]
public partial class ContentInformationType8 {
    
    private ContentType1Code cnttTpField;
    
    private AuthenticatedData3[] authntcdDataField;
    
    /// <remarks/>
    public ContentType1Code CnttTp {
        get {
            return this.cnttTpField;
        }
        set {
            this.cnttTpField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("AuthntcdData")]
    public AuthenticatedData3[] AuthntcdData {
        get {
            return this.authntcdDataField;
        }
        set {
            this.authntcdDataField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:caaa.010.001.03")]
public partial class TransactionTotals2 {
    
    private string pOIGrpIdField;
    
    private string cardPdctPrflField;
    
    private string ccyField;
    
    private TypeTransactionTotals2Code tpField;
    
    private string ttlNbField;
    
    private decimal cmltvAmtField;
    
    /// <remarks/>
    public string POIGrpId {
        get {
            return this.pOIGrpIdField;
        }
        set {
            this.pOIGrpIdField = value;
        }
    }
    
    /// <remarks/>
    public string CardPdctPrfl {
        get {
            return this.cardPdctPrflField;
        }
        set {
            this.cardPdctPrflField = value;
        }
    }
    
    /// <remarks/>
    public string Ccy {
        get {
            return this.ccyField;
        }
        set {
            this.ccyField = value;
        }
    }
    
    /// <remarks/>
    public TypeTransactionTotals2Code Tp {
        get {
            return this.tpField;
        }
        set {
            this.tpField = value;
        }
    }
    
    /// <remarks/>
    public string TtlNb {
        get {
            return this.ttlNbField;
        }
        set {
            this.ttlNbField = value;
        }
    }
    
    /// <remarks/>
    public decimal CmltvAmt {
        get {
            return this.cmltvAmtField;
        }
        set {
            this.cmltvAmtField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:caaa.010.001.03")]
public enum TypeTransactionTotals2Code {
    
    /// <remarks/>
    CRDT,
    
    /// <remarks/>
    CRDR,
    
    /// <remarks/>
    DEBT,
    
    /// <remarks/>
    DBTR,
    
    /// <remarks/>
    DECL,
    
    /// <remarks/>
    FAIL,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:caaa.010.001.03")]
public partial class TransactionIdentifier1 {
    
    private System.DateTime txDtTmField;
    
    private string txRefField;
    
    /// <remarks/>
    public System.DateTime TxDtTm {
        get {
            return this.txDtTmField;
        }
        set {
            this.txDtTmField = value;
        }
    }
    
    /// <remarks/>
    public string TxRef {
        get {
            return this.txRefField;
        }
        set {
            this.txRefField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:caaa.010.001.03")]
public partial class TransactionReconciliation2 {
    
    private bool clsPrdField;
    
    private bool clsPrdFieldSpecified;
    
    private TransactionIdentifier1 rcncltnTxIdField;
    
    private string rcncltnIdField;
    
    private TransactionTotals2[] txTtlsField;
    
    private string addtlTxDataField;
    
    /// <remarks/>
    public bool ClsPrd {
        get {
            return this.clsPrdField;
        }
        set {
            this.clsPrdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool ClsPrdSpecified {
        get {
            return this.clsPrdFieldSpecified;
        }
        set {
            this.clsPrdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public TransactionIdentifier1 RcncltnTxId {
        get {
            return this.rcncltnTxIdField;
        }
        set {
            this.rcncltnTxIdField = value;
        }
    }
    
    /// <remarks/>
    public string RcncltnId {
        get {
            return this.rcncltnIdField;
        }
        set {
            this.rcncltnIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("TxTtls")]
    public TransactionTotals2[] TxTtls {
        get {
            return this.txTtlsField;
        }
        set {
            this.txTtlsField = value;
        }
    }
    
    /// <remarks/>
    public string AddtlTxData {
        get {
            return this.addtlTxDataField;
        }
        set {
            this.addtlTxDataField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:caaa.010.001.03")]
public partial class ResponseType1 {
    
    private Response1Code rspnField;
    
    private string rspnRsnField;
    
    /// <remarks/>
    public Response1Code Rspn {
        get {
            return this.rspnField;
        }
        set {
            this.rspnField = value;
        }
    }
    
    /// <remarks/>
    public string RspnRsn {
        get {
            return this.rspnRsnField;
        }
        set {
            this.rspnRsnField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:caaa.010.001.03")]
public enum Response1Code {
    
    /// <remarks/>
    DECL,
    
    /// <remarks/>
    APPR,
    
    /// <remarks/>
    PART,
    
    /// <remarks/>
    TECH,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:caaa.010.001.03")]
public partial class CardPaymentEnvironment19 {
    
    private GenericIdentification32 acqrrIdField;
    
    private GenericIdentification32 mrchntIdField;
    
    private GenericIdentification32 pOIIdField;
    
    /// <remarks/>
    public GenericIdentification32 AcqrrId {
        get {
            return this.acqrrIdField;
        }
        set {
            this.acqrrIdField = value;
        }
    }
    
    /// <remarks/>
    public GenericIdentification32 MrchntId {
        get {
            return this.mrchntIdField;
        }
        set {
            this.mrchntIdField = value;
        }
    }
    
    /// <remarks/>
    public GenericIdentification32 POIId {
        get {
            return this.pOIIdField;
        }
        set {
            this.pOIIdField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:caaa.010.001.03")]
public partial class AcceptorReconciliationResponse2 {
    
    private CardPaymentEnvironment19 envtField;
    
    private ResponseType1 txRspnField;
    
    private TransactionReconciliation2 txField;
    
    /// <remarks/>
    public CardPaymentEnvironment19 Envt {
        get {
            return this.envtField;
        }
        set {
            this.envtField = value;
        }
    }
    
    /// <remarks/>
    public ResponseType1 TxRspn {
        get {
            return this.txRspnField;
        }
        set {
            this.txRspnField = value;
        }
    }
    
    /// <remarks/>
    public TransactionReconciliation2 Tx {
        get {
            return this.txField;
        }
        set {
            this.txField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:caaa.010.001.03")]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:caaa.010.001.03")]
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

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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.021.001.06")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.021.001.06", IsNullable=false)]
public partial class Document {
    
    private ReturnGeneralBusinessInformationV06 rtrGnlBizInfField;
    
    /// <remarks/>
    public ReturnGeneralBusinessInformationV06 RtrGnlBizInf {
        get {
            return this.rtrGnlBizInfField;
        }
        set {
            this.rtrGnlBizInfField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.021.001.06")]
public partial class ReturnGeneralBusinessInformationV06 {
    
    private MessageHeader7 msgHdrField;
    
    private GeneralBusinessOrError7Choice rptOrErrField;
    
    private SupplementaryData1[] splmtryDataField;
    
    /// <remarks/>
    public MessageHeader7 MsgHdr {
        get {
            return this.msgHdrField;
        }
        set {
            this.msgHdrField = value;
        }
    }
    
    /// <remarks/>
    public GeneralBusinessOrError7Choice RptOrErr {
        get {
            return this.rptOrErrField;
        }
        set {
            this.rptOrErrField = value;
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.021.001.06")]
public partial class MessageHeader7 {
    
    private string msgIdField;
    
    private System.DateTime creDtTmField;
    
    private bool creDtTmFieldSpecified;
    
    private RequestType4Choice reqTpField;
    
    private OriginalBusinessQuery1 orgnlBizQryField;
    
    private string qryNmField;
    
    /// <remarks/>
    public string MsgId {
        get {
            return this.msgIdField;
        }
        set {
            this.msgIdField = value;
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
    
    /// <remarks/>
    public RequestType4Choice ReqTp {
        get {
            return this.reqTpField;
        }
        set {
            this.reqTpField = value;
        }
    }
    
    /// <remarks/>
    public OriginalBusinessQuery1 OrgnlBizQry {
        get {
            return this.orgnlBizQryField;
        }
        set {
            this.orgnlBizQryField = value;
        }
    }
    
    /// <remarks/>
    public string QryNm {
        get {
            return this.qryNmField;
        }
        set {
            this.qryNmField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.021.001.06")]
public partial class RequestType4Choice {
    
    private object itemField;
    
    private ItemChoiceType itemElementNameField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Enqry", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("PmtCtrl", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("Prtry", typeof(GenericIdentification1))]
    [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
    public object Item {
        get {
            return this.itemField;
        }
        set {
            this.itemField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public ItemChoiceType ItemElementName {
        get {
            return this.itemElementNameField;
        }
        set {
            this.itemElementNameField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.021.001.06")]
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
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.021.001.06")]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.021.001.06")]
public partial class InformationQualifierType1 {
    
    private bool isFrmtdField;
    
    private bool isFrmtdFieldSpecified;
    
    private Priority1Code prtyField;
    
    private bool prtyFieldSpecified;
    
    /// <remarks/>
    public bool IsFrmtd {
        get {
            return this.isFrmtdField;
        }
        set {
            this.isFrmtdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool IsFrmtdSpecified {
        get {
            return this.isFrmtdFieldSpecified;
        }
        set {
            this.isFrmtdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public Priority1Code Prty {
        get {
            return this.prtyField;
        }
        set {
            this.prtyField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool PrtySpecified {
        get {
            return this.prtyFieldSpecified;
        }
        set {
            this.prtyFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.021.001.06")]
public enum Priority1Code {
    
    /// <remarks/>
    HIGH,
    
    /// <remarks/>
    NORM,
    
    /// <remarks/>
    LOWW,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.021.001.06")]
public partial class GeneralBusinessInformation1 {
    
    private InformationQualifierType1 qlfrField;
    
    private string sbjtField;
    
    private string sbjtDtlsField;
    
    /// <remarks/>
    public InformationQualifierType1 Qlfr {
        get {
            return this.qlfrField;
        }
        set {
            this.qlfrField = value;
        }
    }
    
    /// <remarks/>
    public string Sbjt {
        get {
            return this.sbjtField;
        }
        set {
            this.sbjtField = value;
        }
    }
    
    /// <remarks/>
    public string SbjtDtls {
        get {
            return this.sbjtDtlsField;
        }
        set {
            this.sbjtDtlsField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.021.001.06")]
public partial class GeneralBusinessOrError8Choice {
    
    private object[] itemsField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("BizErr", typeof(ErrorHandling5))]
    [System.Xml.Serialization.XmlElementAttribute("GnlBiz", typeof(GeneralBusinessInformation1))]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.021.001.06")]
public partial class ErrorHandling5 {
    
    private ErrorHandling3Choice errField;
    
    private string descField;
    
    /// <remarks/>
    public ErrorHandling3Choice Err {
        get {
            return this.errField;
        }
        set {
            this.errField = value;
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.021.001.06")]
public partial class ErrorHandling3Choice {
    
    private string itemField;
    
    private ItemChoiceType1 itemElementNameField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Cd", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("Prtry", typeof(string))]
    [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
    public string Item {
        get {
            return this.itemField;
        }
        set {
            this.itemField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public ItemChoiceType1 ItemElementName {
        get {
            return this.itemElementNameField;
        }
        set {
            this.itemElementNameField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.021.001.06", IncludeInSchema=false)]
public enum ItemChoiceType1 {
    
    /// <remarks/>
    Cd,
    
    /// <remarks/>
    Prtry,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.021.001.06")]
public partial class GeneralBusinessReport6 {
    
    private string bizInfRefField;
    
    private GeneralBusinessOrError8Choice gnlBizOrErrField;
    
    /// <remarks/>
    public string BizInfRef {
        get {
            return this.bizInfRefField;
        }
        set {
            this.bizInfRefField = value;
        }
    }
    
    /// <remarks/>
    public GeneralBusinessOrError8Choice GnlBizOrErr {
        get {
            return this.gnlBizOrErrField;
        }
        set {
            this.gnlBizOrErrField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.021.001.06")]
public partial class GeneralBusinessOrError7Choice {
    
    private object[] itemsField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("BizRpt", typeof(GeneralBusinessReport6))]
    [System.Xml.Serialization.XmlElementAttribute("OprlErr", typeof(ErrorHandling5))]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.021.001.06")]
public partial class OriginalBusinessQuery1 {
    
    private string msgIdField;
    
    private string msgNmIdField;
    
    private System.DateTime creDtTmField;
    
    private bool creDtTmFieldSpecified;
    
    /// <remarks/>
    public string MsgId {
        get {
            return this.msgIdField;
        }
        set {
            this.msgIdField = value;
        }
    }
    
    /// <remarks/>
    public string MsgNmId {
        get {
            return this.msgNmIdField;
        }
        set {
            this.msgNmIdField = value;
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.021.001.06", IncludeInSchema=false)]
public enum ItemChoiceType {
    
    /// <remarks/>
    Enqry,
    
    /// <remarks/>
    PmtCtrl,
    
    /// <remarks/>
    Prtry,
}

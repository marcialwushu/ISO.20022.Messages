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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.008.001.08")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.008.001.08", IsNullable=false)]
public partial class Document {
    
    private ReversalOfTransferInConfirmationV08 rvslOfTrfInConfField;
    
    /// <remarks/>
    public ReversalOfTransferInConfirmationV08 RvslOfTrfInConf {
        get {
            return this.rvslOfTrfInConfField;
        }
        set {
            this.rvslOfTrfInConfField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.008.001.08")]
public partial class ReversalOfTransferInConfirmationV08 {
    
    private MessageIdentification1 msgIdField;
    
    private AdditionalReference9 poolRefField;
    
    private AdditionalReference8 prvsRefField;
    
    private AdditionalReference8 rltdRefField;
    
    private string mstrRefField;
    
    private TransferInFunction2Code fctnField;
    
    private bool fctnFieldSpecified;
    
    private TransferReference12 refField;
    
    private MarketPracticeVersion1 mktPrctcVrsnField;
    
    private CopyInformation4 cpyDtlsField;
    
    /// <remarks/>
    public MessageIdentification1 MsgId {
        get {
            return this.msgIdField;
        }
        set {
            this.msgIdField = value;
        }
    }
    
    /// <remarks/>
    public AdditionalReference9 PoolRef {
        get {
            return this.poolRefField;
        }
        set {
            this.poolRefField = value;
        }
    }
    
    /// <remarks/>
    public AdditionalReference8 PrvsRef {
        get {
            return this.prvsRefField;
        }
        set {
            this.prvsRefField = value;
        }
    }
    
    /// <remarks/>
    public AdditionalReference8 RltdRef {
        get {
            return this.rltdRefField;
        }
        set {
            this.rltdRefField = value;
        }
    }
    
    /// <remarks/>
    public string MstrRef {
        get {
            return this.mstrRefField;
        }
        set {
            this.mstrRefField = value;
        }
    }
    
    /// <remarks/>
    public TransferInFunction2Code Fctn {
        get {
            return this.fctnField;
        }
        set {
            this.fctnField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool FctnSpecified {
        get {
            return this.fctnFieldSpecified;
        }
        set {
            this.fctnFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public TransferReference12 Ref {
        get {
            return this.refField;
        }
        set {
            this.refField = value;
        }
    }
    
    /// <remarks/>
    public MarketPracticeVersion1 MktPrctcVrsn {
        get {
            return this.mktPrctcVrsnField;
        }
        set {
            this.mktPrctcVrsnField = value;
        }
    }
    
    /// <remarks/>
    public CopyInformation4 CpyDtls {
        get {
            return this.cpyDtlsField;
        }
        set {
            this.cpyDtlsField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.008.001.08")]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.008.001.08")]
public partial class CopyInformation4 {
    
    private bool cpyIndField;
    
    private string orgnlRcvrField;
    
    /// <remarks/>
    public bool CpyInd {
        get {
            return this.cpyIndField;
        }
        set {
            this.cpyIndField = value;
        }
    }
    
    /// <remarks/>
    public string OrgnlRcvr {
        get {
            return this.orgnlRcvrField;
        }
        set {
            this.orgnlRcvrField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.008.001.08")]
public partial class MarketPracticeVersion1 {
    
    private string nmField;
    
    private string dtField;
    
    private string nbField;
    
    /// <remarks/>
    public string Nm {
        get {
            return this.nmField;
        }
        set {
            this.nmField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="gYearMonth")]
    public string Dt {
        get {
            return this.dtField;
        }
        set {
            this.dtField = value;
        }
    }
    
    /// <remarks/>
    public string Nb {
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.008.001.08")]
public partial class TransferReference12 {
    
    private string trfRefField;
    
    private AdditionalReference8 clntRefField;
    
    private string trfConfRefField;
    
    private AdditionalReference8 ctrPtyRefField;
    
    private string cxlRefField;
    
    private string rvslRsnField;
    
    /// <remarks/>
    public string TrfRef {
        get {
            return this.trfRefField;
        }
        set {
            this.trfRefField = value;
        }
    }
    
    /// <remarks/>
    public AdditionalReference8 ClntRef {
        get {
            return this.clntRefField;
        }
        set {
            this.clntRefField = value;
        }
    }
    
    /// <remarks/>
    public string TrfConfRef {
        get {
            return this.trfConfRefField;
        }
        set {
            this.trfConfRefField = value;
        }
    }
    
    /// <remarks/>
    public AdditionalReference8 CtrPtyRef {
        get {
            return this.ctrPtyRefField;
        }
        set {
            this.ctrPtyRefField = value;
        }
    }
    
    /// <remarks/>
    public string CxlRef {
        get {
            return this.cxlRefField;
        }
        set {
            this.cxlRefField = value;
        }
    }
    
    /// <remarks/>
    public string RvslRsn {
        get {
            return this.rvslRsnField;
        }
        set {
            this.rvslRsnField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.008.001.08")]
public partial class AdditionalReference8 {
    
    private string refField;
    
    private PartyIdentification113 refIssrField;
    
    private string msgNmField;
    
    /// <remarks/>
    public string Ref {
        get {
            return this.refField;
        }
        set {
            this.refField = value;
        }
    }
    
    /// <remarks/>
    public PartyIdentification113 RefIssr {
        get {
            return this.refIssrField;
        }
        set {
            this.refIssrField = value;
        }
    }
    
    /// <remarks/>
    public string MsgNm {
        get {
            return this.msgNmField;
        }
        set {
            this.msgNmField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.008.001.08")]
public partial class PartyIdentification113 {
    
    private PartyIdentification90Choice ptyField;
    
    private string lEIField;
    
    /// <remarks/>
    public PartyIdentification90Choice Pty {
        get {
            return this.ptyField;
        }
        set {
            this.ptyField = value;
        }
    }
    
    /// <remarks/>
    public string LEI {
        get {
            return this.lEIField;
        }
        set {
            this.lEIField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.008.001.08")]
public partial class PartyIdentification90Choice {
    
    private object itemField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("AnyBIC", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("NmAndAdr", typeof(NameAndAddress5))]
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

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.008.001.08")]
public partial class NameAndAddress5 {
    
    private string nmField;
    
    private PostalAddress1 adrField;
    
    /// <remarks/>
    public string Nm {
        get {
            return this.nmField;
        }
        set {
            this.nmField = value;
        }
    }
    
    /// <remarks/>
    public PostalAddress1 Adr {
        get {
            return this.adrField;
        }
        set {
            this.adrField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.008.001.08")]
public partial class PostalAddress1 {
    
    private AddressType2Code adrTpField;
    
    private bool adrTpFieldSpecified;
    
    private string[] adrLineField;
    
    private string strtNmField;
    
    private string bldgNbField;
    
    private string pstCdField;
    
    private string twnNmField;
    
    private string ctrySubDvsnField;
    
    private string ctryField;
    
    /// <remarks/>
    public AddressType2Code AdrTp {
        get {
            return this.adrTpField;
        }
        set {
            this.adrTpField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool AdrTpSpecified {
        get {
            return this.adrTpFieldSpecified;
        }
        set {
            this.adrTpFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("AdrLine")]
    public string[] AdrLine {
        get {
            return this.adrLineField;
        }
        set {
            this.adrLineField = value;
        }
    }
    
    /// <remarks/>
    public string StrtNm {
        get {
            return this.strtNmField;
        }
        set {
            this.strtNmField = value;
        }
    }
    
    /// <remarks/>
    public string BldgNb {
        get {
            return this.bldgNbField;
        }
        set {
            this.bldgNbField = value;
        }
    }
    
    /// <remarks/>
    public string PstCd {
        get {
            return this.pstCdField;
        }
        set {
            this.pstCdField = value;
        }
    }
    
    /// <remarks/>
    public string TwnNm {
        get {
            return this.twnNmField;
        }
        set {
            this.twnNmField = value;
        }
    }
    
    /// <remarks/>
    public string CtrySubDvsn {
        get {
            return this.ctrySubDvsnField;
        }
        set {
            this.ctrySubDvsnField = value;
        }
    }
    
    /// <remarks/>
    public string Ctry {
        get {
            return this.ctryField;
        }
        set {
            this.ctryField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.008.001.08")]
public enum AddressType2Code {
    
    /// <remarks/>
    ADDR,
    
    /// <remarks/>
    PBOX,
    
    /// <remarks/>
    HOME,
    
    /// <remarks/>
    BIZZ,
    
    /// <remarks/>
    MLTO,
    
    /// <remarks/>
    DLVY,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.008.001.08")]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.008.001.08")]
public partial class AdditionalReference9 {
    
    private string refField;
    
    private PartyIdentification113 refIssrField;
    
    private string msgNmField;
    
    /// <remarks/>
    public string Ref {
        get {
            return this.refField;
        }
        set {
            this.refField = value;
        }
    }
    
    /// <remarks/>
    public PartyIdentification113 RefIssr {
        get {
            return this.refIssrField;
        }
        set {
            this.refIssrField = value;
        }
    }
    
    /// <remarks/>
    public string MsgNm {
        get {
            return this.msgNmField;
        }
        set {
            this.msgNmField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.008.001.08")]
public enum TransferInFunction2Code {
    
    /// <remarks/>
    CONF,
    
    /// <remarks/>
    ADVI,
}

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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.013.001.03")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.013.001.03", IsNullable=false)]
public partial class Document {
    
    private DataSetMatchReportV03 dataSetMtchRptField;
    
    /// <remarks/>
    public DataSetMatchReportV03 DataSetMtchRpt {
        get {
            return this.dataSetMtchRptField;
        }
        set {
            this.dataSetMtchRptField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.013.001.03")]
public partial class DataSetMatchReportV03 {
    
    private MessageIdentification1 rptIdField;
    
    private SimpleIdentificationInformation txIdField;
    
    private DocumentIdentification3 estblishdBaselnIdField;
    
    private TransactionStatus4 txStsField;
    
    private DocumentIdentification5[] usrTxRefField;
    
    private PartyIdentification26 buyrField;
    
    private PartyIdentification26 sellrField;
    
    private BICIdentification1 buyrBkField;
    
    private BICIdentification1 sellrBkField;
    
    private DocumentIdentification10[] cmpardDocRefField;
    
    private ReportType3 submissnTpField;
    
    private MisMatchReport3 rptField;
    
    private PendingActivity2 reqForActnField;
    
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
    public PartyIdentification26 Buyr {
        get {
            return this.buyrField;
        }
        set {
            this.buyrField = value;
        }
    }
    
    /// <remarks/>
    public PartyIdentification26 Sellr {
        get {
            return this.sellrField;
        }
        set {
            this.sellrField = value;
        }
    }
    
    /// <remarks/>
    public BICIdentification1 BuyrBk {
        get {
            return this.buyrBkField;
        }
        set {
            this.buyrBkField = value;
        }
    }
    
    /// <remarks/>
    public BICIdentification1 SellrBk {
        get {
            return this.sellrBkField;
        }
        set {
            this.sellrBkField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("CmpardDocRef")]
    public DocumentIdentification10[] CmpardDocRef {
        get {
            return this.cmpardDocRefField;
        }
        set {
            this.cmpardDocRefField = value;
        }
    }
    
    /// <remarks/>
    public ReportType3 SubmissnTp {
        get {
            return this.submissnTpField;
        }
        set {
            this.submissnTpField = value;
        }
    }
    
    /// <remarks/>
    public MisMatchReport3 Rpt {
        get {
            return this.rptField;
        }
        set {
            this.rptField = value;
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.013.001.03")]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.013.001.03")]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.013.001.03")]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.013.001.03")]
public partial class ElementIdentification1 {
    
    private string docIndxField;
    
    private string elmtPthField;
    
    private string elmtNmField;
    
    private string elmtValField;
    
    /// <remarks/>
    public string DocIndx {
        get {
            return this.docIndxField;
        }
        set {
            this.docIndxField = value;
        }
    }
    
    /// <remarks/>
    public string ElmtPth {
        get {
            return this.elmtPthField;
        }
        set {
            this.elmtPthField = value;
        }
    }
    
    /// <remarks/>
    public string ElmtNm {
        get {
            return this.elmtNmField;
        }
        set {
            this.elmtNmField = value;
        }
    }
    
    /// <remarks/>
    public string ElmtVal {
        get {
            return this.elmtValField;
        }
        set {
            this.elmtValField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.013.001.03")]
public partial class ValidationResult5 {
    
    private decimal seqNbField;
    
    private string ruleIdField;
    
    private string ruleDescField;
    
    private ElementIdentification1[] misMtchdElmtField;
    
    /// <remarks/>
    public decimal SeqNb {
        get {
            return this.seqNbField;
        }
        set {
            this.seqNbField = value;
        }
    }
    
    /// <remarks/>
    public string RuleId {
        get {
            return this.ruleIdField;
        }
        set {
            this.ruleIdField = value;
        }
    }
    
    /// <remarks/>
    public string RuleDesc {
        get {
            return this.ruleDescField;
        }
        set {
            this.ruleDescField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("MisMtchdElmt")]
    public ElementIdentification1[] MisMtchdElmt {
        get {
            return this.misMtchdElmtField;
        }
        set {
            this.misMtchdElmtField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.013.001.03")]
public partial class MisMatchReport3 {
    
    private decimal nbOfMisMtchsField;
    
    private ValidationResult5[] misMtchInfField;
    
    /// <remarks/>
    public decimal NbOfMisMtchs {
        get {
            return this.nbOfMisMtchsField;
        }
        set {
            this.nbOfMisMtchsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("MisMtchInf")]
    public ValidationResult5[] MisMtchInf {
        get {
            return this.misMtchInfField;
        }
        set {
            this.misMtchInfField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.013.001.03")]
public partial class ReportType3 {
    
    private InstructionType3Code tpField;
    
    /// <remarks/>
    public InstructionType3Code Tp {
        get {
            return this.tpField;
        }
        set {
            this.tpField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.013.001.03")]
public enum InstructionType3Code {
    
    /// <remarks/>
    MTCH,
    
    /// <remarks/>
    PMTC,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.013.001.03")]
public partial class DocumentIdentification10 {
    
    private string idField;
    
    private decimal vrsnField;
    
    private DataSetType2Code tpField;
    
    private BICIdentification1 submitrField;
    
    private string docIndxField;
    
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
    
    /// <remarks/>
    public DataSetType2Code Tp {
        get {
            return this.tpField;
        }
        set {
            this.tpField = value;
        }
    }
    
    /// <remarks/>
    public BICIdentification1 Submitr {
        get {
            return this.submitrField;
        }
        set {
            this.submitrField = value;
        }
    }
    
    /// <remarks/>
    public string DocIndx {
        get {
            return this.docIndxField;
        }
        set {
            this.docIndxField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.013.001.03")]
public enum DataSetType2Code {
    
    /// <remarks/>
    BASE,
    
    /// <remarks/>
    TRDS,
    
    /// <remarks/>
    CODS,
    
    /// <remarks/>
    INDS,
    
    /// <remarks/>
    CEDS,
    
    /// <remarks/>
    OCDS,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.013.001.03")]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.013.001.03")]
public partial class PostalAddress5 {
    
    private string strtNmField;
    
    private string pstCdIdField;
    
    private string twnNmField;
    
    private string ctrySubDvsnField;
    
    private string ctryField;
    
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
    public string PstCdId {
        get {
            return this.pstCdIdField;
        }
        set {
            this.pstCdIdField = value;
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
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.013.001.03")]
public partial class GenericIdentification4 {
    
    private string idField;
    
    private string idTpField;
    
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
    public string IdTp {
        get {
            return this.idTpField;
        }
        set {
            this.idTpField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.013.001.03")]
public partial class PartyIdentification26 {
    
    private string nmField;
    
    private GenericIdentification4 prtryIdField;
    
    private PostalAddress5 pstlAdrField;
    
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
    public GenericIdentification4 PrtryId {
        get {
            return this.prtryIdField;
        }
        set {
            this.prtryIdField = value;
        }
    }
    
    /// <remarks/>
    public PostalAddress5 PstlAdr {
        get {
            return this.pstlAdrField;
        }
        set {
            this.pstlAdrField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.013.001.03")]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.013.001.03")]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.013.001.03")]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.013.001.03")]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.013.001.03")]
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

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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.025.001.05")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.025.001.05", IsNullable=false)]
public partial class Document {
    
    private ReceiptV05 rctField;
    
    /// <remarks/>
    public ReceiptV05 Rct {
        get {
            return this.rctField;
        }
        set {
            this.rctField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.025.001.05")]
public partial class ReceiptV05 {
    
    private MessageHeader9 msgHdrField;
    
    private Receipt3[] rctDtlsField;
    
    private SupplementaryData1[] splmtryDataField;
    
    /// <remarks/>
    public MessageHeader9 MsgHdr {
        get {
            return this.msgHdrField;
        }
        set {
            this.msgHdrField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("RctDtls")]
    public Receipt3[] RctDtls {
        get {
            return this.rctDtlsField;
        }
        set {
            this.rctDtlsField = value;
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.025.001.05")]
public partial class MessageHeader9 {
    
    private string msgIdField;
    
    private System.DateTime creDtTmField;
    
    private bool creDtTmFieldSpecified;
    
    private RequestType4Choice reqTpField;
    
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
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.025.001.05")]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.025.001.05")]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.025.001.05")]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.025.001.05")]
public partial class RequestHandling1 {
    
    private string stsCdField;
    
    private string descField;
    
    /// <remarks/>
    public string StsCd {
        get {
            return this.stsCdField;
        }
        set {
            this.stsCdField = value;
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.025.001.05")]
public partial class ShortPaymentIdentification2 {
    
    private string txIdField;
    
    private System.DateTime intrBkSttlmDtField;
    
    private BranchAndFinancialInstitutionIdentification6 instgAgtField;
    
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
    [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
    public System.DateTime IntrBkSttlmDt {
        get {
            return this.intrBkSttlmDtField;
        }
        set {
            this.intrBkSttlmDtField = value;
        }
    }
    
    /// <remarks/>
    public BranchAndFinancialInstitutionIdentification6 InstgAgt {
        get {
            return this.instgAgtField;
        }
        set {
            this.instgAgtField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.025.001.05")]
public partial class BranchAndFinancialInstitutionIdentification6 {
    
    private FinancialInstitutionIdentification18 finInstnIdField;
    
    private BranchData3 brnchIdField;
    
    /// <remarks/>
    public FinancialInstitutionIdentification18 FinInstnId {
        get {
            return this.finInstnIdField;
        }
        set {
            this.finInstnIdField = value;
        }
    }
    
    /// <remarks/>
    public BranchData3 BrnchId {
        get {
            return this.brnchIdField;
        }
        set {
            this.brnchIdField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.025.001.05")]
public partial class FinancialInstitutionIdentification18 {
    
    private string bICFIField;
    
    private ClearingSystemMemberIdentification2 clrSysMmbIdField;
    
    private string lEIField;
    
    private string nmField;
    
    private PostalAddress24 pstlAdrField;
    
    private GenericFinancialIdentification1 othrField;
    
    /// <remarks/>
    public string BICFI {
        get {
            return this.bICFIField;
        }
        set {
            this.bICFIField = value;
        }
    }
    
    /// <remarks/>
    public ClearingSystemMemberIdentification2 ClrSysMmbId {
        get {
            return this.clrSysMmbIdField;
        }
        set {
            this.clrSysMmbIdField = value;
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
    public PostalAddress24 PstlAdr {
        get {
            return this.pstlAdrField;
        }
        set {
            this.pstlAdrField = value;
        }
    }
    
    /// <remarks/>
    public GenericFinancialIdentification1 Othr {
        get {
            return this.othrField;
        }
        set {
            this.othrField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.025.001.05")]
public partial class ClearingSystemMemberIdentification2 {
    
    private ClearingSystemIdentification2Choice clrSysIdField;
    
    private string mmbIdField;
    
    /// <remarks/>
    public ClearingSystemIdentification2Choice ClrSysId {
        get {
            return this.clrSysIdField;
        }
        set {
            this.clrSysIdField = value;
        }
    }
    
    /// <remarks/>
    public string MmbId {
        get {
            return this.mmbIdField;
        }
        set {
            this.mmbIdField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.025.001.05")]
public partial class ClearingSystemIdentification2Choice {
    
    private string itemField;
    
    private ItemChoiceType2 itemElementNameField;
    
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
    public ItemChoiceType2 ItemElementName {
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.025.001.05", IncludeInSchema=false)]
public enum ItemChoiceType2 {
    
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.025.001.05")]
public partial class PostalAddress24 {
    
    private AddressType3Choice adrTpField;
    
    private string deptField;
    
    private string subDeptField;
    
    private string strtNmField;
    
    private string bldgNbField;
    
    private string bldgNmField;
    
    private string flrField;
    
    private string pstBxField;
    
    private string roomField;
    
    private string pstCdField;
    
    private string twnNmField;
    
    private string twnLctnNmField;
    
    private string dstrctNmField;
    
    private string ctrySubDvsnField;
    
    private string ctryField;
    
    private string[] adrLineField;
    
    /// <remarks/>
    public AddressType3Choice AdrTp {
        get {
            return this.adrTpField;
        }
        set {
            this.adrTpField = value;
        }
    }
    
    /// <remarks/>
    public string Dept {
        get {
            return this.deptField;
        }
        set {
            this.deptField = value;
        }
    }
    
    /// <remarks/>
    public string SubDept {
        get {
            return this.subDeptField;
        }
        set {
            this.subDeptField = value;
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
    public string BldgNm {
        get {
            return this.bldgNmField;
        }
        set {
            this.bldgNmField = value;
        }
    }
    
    /// <remarks/>
    public string Flr {
        get {
            return this.flrField;
        }
        set {
            this.flrField = value;
        }
    }
    
    /// <remarks/>
    public string PstBx {
        get {
            return this.pstBxField;
        }
        set {
            this.pstBxField = value;
        }
    }
    
    /// <remarks/>
    public string Room {
        get {
            return this.roomField;
        }
        set {
            this.roomField = value;
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
    public string TwnLctnNm {
        get {
            return this.twnLctnNmField;
        }
        set {
            this.twnLctnNmField = value;
        }
    }
    
    /// <remarks/>
    public string DstrctNm {
        get {
            return this.dstrctNmField;
        }
        set {
            this.dstrctNmField = value;
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
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.025.001.05")]
public partial class AddressType3Choice {
    
    private object itemField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Cd", typeof(AddressType2Code))]
    [System.Xml.Serialization.XmlElementAttribute("Prtry", typeof(GenericIdentification30))]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.025.001.05")]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.025.001.05")]
public partial class GenericIdentification30 {
    
    private string idField;
    
    private string issrField;
    
    private string schmeNmField;
    
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
    public string Issr {
        get {
            return this.issrField;
        }
        set {
            this.issrField = value;
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
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.025.001.05")]
public partial class GenericFinancialIdentification1 {
    
    private string idField;
    
    private FinancialIdentificationSchemeName1Choice schmeNmField;
    
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
    public FinancialIdentificationSchemeName1Choice SchmeNm {
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.025.001.05")]
public partial class FinancialIdentificationSchemeName1Choice {
    
    private string itemField;
    
    private ItemChoiceType3 itemElementNameField;
    
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
    public ItemChoiceType3 ItemElementName {
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.025.001.05", IncludeInSchema=false)]
public enum ItemChoiceType3 {
    
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.025.001.05")]
public partial class BranchData3 {
    
    private string idField;
    
    private string lEIField;
    
    private string nmField;
    
    private PostalAddress24 pstlAdrField;
    
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
    public string LEI {
        get {
            return this.lEIField;
        }
        set {
            this.lEIField = value;
        }
    }
    
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
    public PostalAddress24 PstlAdr {
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.025.001.05")]
public partial class PaymentOrigin1Choice {
    
    private object itemField;
    
    private ItemChoiceType1 itemElementNameField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("FINMT", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("Instrm", typeof(PaymentInstrument1Code))]
    [System.Xml.Serialization.XmlElementAttribute("Prtry", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("XMLMsgNm", typeof(string))]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.025.001.05")]
public enum PaymentInstrument1Code {
    
    /// <remarks/>
    BDT,
    
    /// <remarks/>
    BCT,
    
    /// <remarks/>
    CDT,
    
    /// <remarks/>
    CCT,
    
    /// <remarks/>
    CHK,
    
    /// <remarks/>
    BKT,
    
    /// <remarks/>
    DCP,
    
    /// <remarks/>
    CCP,
    
    /// <remarks/>
    RTI,
    
    /// <remarks/>
    CAN,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.025.001.05", IncludeInSchema=false)]
public enum ItemChoiceType1 {
    
    /// <remarks/>
    FINMT,
    
    /// <remarks/>
    Instrm,
    
    /// <remarks/>
    Prtry,
    
    /// <remarks/>
    XMLMsgNm,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.025.001.05")]
public partial class LongPaymentIdentification2 {
    
    private string txIdField;
    
    private string uETRField;
    
    private decimal intrBkSttlmAmtField;
    
    private System.DateTime intrBkSttlmDtField;
    
    private PaymentOrigin1Choice pmtMtdField;
    
    private BranchAndFinancialInstitutionIdentification6 instgAgtField;
    
    private BranchAndFinancialInstitutionIdentification6 instdAgtField;
    
    private string ntryTpField;
    
    private string endToEndIdField;
    
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
    public string UETR {
        get {
            return this.uETRField;
        }
        set {
            this.uETRField = value;
        }
    }
    
    /// <remarks/>
    public decimal IntrBkSttlmAmt {
        get {
            return this.intrBkSttlmAmtField;
        }
        set {
            this.intrBkSttlmAmtField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
    public System.DateTime IntrBkSttlmDt {
        get {
            return this.intrBkSttlmDtField;
        }
        set {
            this.intrBkSttlmDtField = value;
        }
    }
    
    /// <remarks/>
    public PaymentOrigin1Choice PmtMtd {
        get {
            return this.pmtMtdField;
        }
        set {
            this.pmtMtdField = value;
        }
    }
    
    /// <remarks/>
    public BranchAndFinancialInstitutionIdentification6 InstgAgt {
        get {
            return this.instgAgtField;
        }
        set {
            this.instgAgtField = value;
        }
    }
    
    /// <remarks/>
    public BranchAndFinancialInstitutionIdentification6 InstdAgt {
        get {
            return this.instdAgtField;
        }
        set {
            this.instdAgtField = value;
        }
    }
    
    /// <remarks/>
    public string NtryTp {
        get {
            return this.ntryTpField;
        }
        set {
            this.ntryTpField = value;
        }
    }
    
    /// <remarks/>
    public string EndToEndId {
        get {
            return this.endToEndIdField;
        }
        set {
            this.endToEndIdField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.025.001.05")]
public partial class QueueTransactionIdentification1 {
    
    private string qIdField;
    
    private string posInQField;
    
    /// <remarks/>
    public string QId {
        get {
            return this.qIdField;
        }
        set {
            this.qIdField = value;
        }
    }
    
    /// <remarks/>
    public string PosInQ {
        get {
            return this.posInQField;
        }
        set {
            this.posInQField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.025.001.05")]
public partial class PaymentIdentification6Choice {
    
    private object itemField;
    
    private ItemChoiceType4 itemElementNameField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("LngBizId", typeof(LongPaymentIdentification2))]
    [System.Xml.Serialization.XmlElementAttribute("PrtryId", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("QId", typeof(QueueTransactionIdentification1))]
    [System.Xml.Serialization.XmlElementAttribute("ShrtBizId", typeof(ShortPaymentIdentification2))]
    [System.Xml.Serialization.XmlElementAttribute("TxId", typeof(string))]
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
    public ItemChoiceType4 ItemElementName {
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.025.001.05", IncludeInSchema=false)]
public enum ItemChoiceType4 {
    
    /// <remarks/>
    LngBizId,
    
    /// <remarks/>
    PrtryId,
    
    /// <remarks/>
    QId,
    
    /// <remarks/>
    ShrtBizId,
    
    /// <remarks/>
    TxId,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.025.001.05")]
public partial class OriginalMessageAndIssuer1 {
    
    private string msgIdField;
    
    private string msgNmIdField;
    
    private string orgtrNmField;
    
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
    public string OrgtrNm {
        get {
            return this.orgtrNmField;
        }
        set {
            this.orgtrNmField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.025.001.05")]
public partial class Receipt3 {
    
    private OriginalMessageAndIssuer1 orgnlMsgIdField;
    
    private PaymentIdentification6Choice orgnlPmtIdField;
    
    private RequestHandling1[] reqHdlgField;
    
    /// <remarks/>
    public OriginalMessageAndIssuer1 OrgnlMsgId {
        get {
            return this.orgnlMsgIdField;
        }
        set {
            this.orgnlMsgIdField = value;
        }
    }
    
    /// <remarks/>
    public PaymentIdentification6Choice OrgnlPmtId {
        get {
            return this.orgnlPmtIdField;
        }
        set {
            this.orgnlPmtIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ReqHdlg")]
    public RequestHandling1[] ReqHdlg {
        get {
            return this.reqHdlgField;
        }
        set {
            this.reqHdlgField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.025.001.05", IncludeInSchema=false)]
public enum ItemChoiceType {
    
    /// <remarks/>
    Enqry,
    
    /// <remarks/>
    PmtCtrl,
    
    /// <remarks/>
    Prtry,
}

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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.040.001.05")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.040.001.05", IsNullable=false)]
public partial class Document {
    
    private CorporateActionInstructionCancellationRequestV05 corpActnInstrCxlReqField;
    
    /// <remarks/>
    public CorporateActionInstructionCancellationRequestV05 CorpActnInstrCxlReq {
        get {
            return this.corpActnInstrCxlReqField;
        }
        set {
            this.corpActnInstrCxlReqField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.040.001.05")]
public partial class CorporateActionInstructionCancellationRequestV05 {
    
    private bool chngInstrIndField;
    
    private bool chngInstrIndFieldSpecified;
    
    private DocumentIdentification15 instrIdField;
    
    private CorporateActionGeneralInformation49 corpActnGnlInfField;
    
    private AccountIdentification15 acctDtlsField;
    
    private CorporateActionOption42 corpActnInstrField;
    
    private SupplementaryData1[] splmtryDataField;
    
    /// <remarks/>
    public bool ChngInstrInd {
        get {
            return this.chngInstrIndField;
        }
        set {
            this.chngInstrIndField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool ChngInstrIndSpecified {
        get {
            return this.chngInstrIndFieldSpecified;
        }
        set {
            this.chngInstrIndFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public DocumentIdentification15 InstrId {
        get {
            return this.instrIdField;
        }
        set {
            this.instrIdField = value;
        }
    }
    
    /// <remarks/>
    public CorporateActionGeneralInformation49 CorpActnGnlInf {
        get {
            return this.corpActnGnlInfField;
        }
        set {
            this.corpActnGnlInfField = value;
        }
    }
    
    /// <remarks/>
    public AccountIdentification15 AcctDtls {
        get {
            return this.acctDtlsField;
        }
        set {
            this.acctDtlsField = value;
        }
    }
    
    /// <remarks/>
    public CorporateActionOption42 CorpActnInstr {
        get {
            return this.corpActnInstrField;
        }
        set {
            this.corpActnInstrField = value;
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.040.001.05")]
public partial class DocumentIdentification15 {
    
    private string idField;
    
    private ProcessingPosition1Choice lkgTpField;
    
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
    public ProcessingPosition1Choice LkgTp {
        get {
            return this.lkgTpField;
        }
        set {
            this.lkgTpField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.040.001.05")]
public partial class ProcessingPosition1Choice {
    
    private object itemField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Cd", typeof(ProcessingPosition3Code))]
    [System.Xml.Serialization.XmlElementAttribute("Prtry", typeof(GenericIdentification20))]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.040.001.05")]
public enum ProcessingPosition3Code {
    
    /// <remarks/>
    AFTE,
    
    /// <remarks/>
    WITH,
    
    /// <remarks/>
    BEFO,
    
    /// <remarks/>
    INFO,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.040.001.05")]
public partial class GenericIdentification20 {
    
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.040.001.05")]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.040.001.05")]
public partial class FinancialInstrumentQuantity1Choice {
    
    private decimal itemField;
    
    private ItemChoiceType1 itemElementNameField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("AmtsdVal", typeof(decimal))]
    [System.Xml.Serialization.XmlElementAttribute("FaceAmt", typeof(decimal))]
    [System.Xml.Serialization.XmlElementAttribute("Unit", typeof(decimal))]
    [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
    public decimal Item {
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.040.001.05", IncludeInSchema=false)]
public enum ItemChoiceType1 {
    
    /// <remarks/>
    AmtsdVal,
    
    /// <remarks/>
    FaceAmt,
    
    /// <remarks/>
    Unit,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.040.001.05")]
public partial class OriginalAndCurrentQuantities1 {
    
    private decimal faceAmtField;
    
    private decimal amtsdValField;
    
    /// <remarks/>
    public decimal FaceAmt {
        get {
            return this.faceAmtField;
        }
        set {
            this.faceAmtField = value;
        }
    }
    
    /// <remarks/>
    public decimal AmtsdVal {
        get {
            return this.amtsdValField;
        }
        set {
            this.amtsdValField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.040.001.05")]
public partial class Quantity5Choice {
    
    private object itemField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Cd", typeof(Quantity1Code))]
    [System.Xml.Serialization.XmlElementAttribute("OrgnlAndCurFaceAmt", typeof(OriginalAndCurrentQuantities1))]
    [System.Xml.Serialization.XmlElementAttribute("Qty", typeof(FinancialInstrumentQuantity1Choice))]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.040.001.05")]
public enum Quantity1Code {
    
    /// <remarks/>
    QALL,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.040.001.05")]
public partial class InstructedOrQuantityToReceive1Choice {
    
    private Quantity5Choice itemField;
    
    private ItemChoiceType2 itemElementNameField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("InstdQty", typeof(Quantity5Choice))]
    [System.Xml.Serialization.XmlElementAttribute("QtyToRcv", typeof(Quantity5Choice))]
    [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
    public Quantity5Choice Item {
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.040.001.05", IncludeInSchema=false)]
public enum ItemChoiceType2 {
    
    /// <remarks/>
    InstdQty,
    
    /// <remarks/>
    QtyToRcv,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.040.001.05")]
public partial class CorporateActionOption12Choice {
    
    private object itemField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Cd", typeof(CorporateActionOption9Code))]
    [System.Xml.Serialization.XmlElementAttribute("Prtry", typeof(GenericIdentification20))]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.040.001.05")]
public enum CorporateActionOption9Code {
    
    /// <remarks/>
    ABST,
    
    /// <remarks/>
    AMGT,
    
    /// <remarks/>
    BSPL,
    
    /// <remarks/>
    BUYA,
    
    /// <remarks/>
    CASE,
    
    /// <remarks/>
    CASH,
    
    /// <remarks/>
    CERT,
    
    /// <remarks/>
    CEXC,
    
    /// <remarks/>
    CONN,
    
    /// <remarks/>
    CONY,
    
    /// <remarks/>
    CTEN,
    
    /// <remarks/>
    EXER,
    
    /// <remarks/>
    LAPS,
    
    /// <remarks/>
    MKDW,
    
    /// <remarks/>
    MKUP,
    
    /// <remarks/>
    MNGT,
    
    /// <remarks/>
    MPUT,
    
    /// <remarks/>
    NOAC,
    
    /// <remarks/>
    NOQU,
    
    /// <remarks/>
    OFFR,
    
    /// <remarks/>
    OTHR,
    
    /// <remarks/>
    OVER,
    
    /// <remarks/>
    PROX,
    
    /// <remarks/>
    QINV,
    
    /// <remarks/>
    SECU,
    
    /// <remarks/>
    SLLE,
    
    /// <remarks/>
    SPLI,
    
    /// <remarks/>
    TAXI,
    
    /// <remarks/>
    PRUN,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.040.001.05")]
public partial class OptionNumber1Choice {
    
    private object itemField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Cd", typeof(OptionNumber1Code))]
    [System.Xml.Serialization.XmlElementAttribute("Nb", typeof(string))]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.040.001.05")]
public enum OptionNumber1Code {
    
    /// <remarks/>
    UNSO,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.040.001.05")]
public partial class CorporateActionOption42 {
    
    private OptionNumber1Choice optnNbField;
    
    private CorporateActionOption12Choice optnTpField;
    
    private InstructedOrQuantityToReceive1Choice instdOrQtyToRcvField;
    
    /// <remarks/>
    public OptionNumber1Choice OptnNb {
        get {
            return this.optnNbField;
        }
        set {
            this.optnNbField = value;
        }
    }
    
    /// <remarks/>
    public CorporateActionOption12Choice OptnTp {
        get {
            return this.optnTpField;
        }
        set {
            this.optnTpField = value;
        }
    }
    
    /// <remarks/>
    public InstructedOrQuantityToReceive1Choice InstdOrQtyToRcv {
        get {
            return this.instdOrQtyToRcvField;
        }
        set {
            this.instdOrQtyToRcvField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.040.001.05")]
public partial class GenericIdentification21 {
    
    private GenericIdentification20 tpField;
    
    private string idField;
    
    /// <remarks/>
    public GenericIdentification20 Tp {
        get {
            return this.tpField;
        }
        set {
            this.tpField = value;
        }
    }
    
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

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.040.001.05")]
public partial class SafekeepingPlaceTypeAndAnyBICIdentifier1 {
    
    private SafekeepingPlace1Code sfkpgPlcTpField;
    
    private string idField;
    
    /// <remarks/>
    public SafekeepingPlace1Code SfkpgPlcTp {
        get {
            return this.sfkpgPlcTpField;
        }
        set {
            this.sfkpgPlcTpField = value;
        }
    }
    
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

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.040.001.05")]
public enum SafekeepingPlace1Code {
    
    /// <remarks/>
    CUST,
    
    /// <remarks/>
    ICSD,
    
    /// <remarks/>
    NCSD,
    
    /// <remarks/>
    SHHE,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.040.001.05")]
public partial class SafekeepingPlaceTypeAndText2 {
    
    private SafekeepingPlace2Code sfkpgPlcTpField;
    
    private string idField;
    
    /// <remarks/>
    public SafekeepingPlace2Code SfkpgPlcTp {
        get {
            return this.sfkpgPlcTpField;
        }
        set {
            this.sfkpgPlcTpField = value;
        }
    }
    
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

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.040.001.05")]
public enum SafekeepingPlace2Code {
    
    /// <remarks/>
    SHHE,
    
    /// <remarks/>
    ALLP,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.040.001.05")]
public partial class SafekeepingPlaceFormat2Choice {
    
    private object itemField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Ctry", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("Id", typeof(SafekeepingPlaceTypeAndText2))]
    [System.Xml.Serialization.XmlElementAttribute("Prtry", typeof(GenericIdentification21))]
    [System.Xml.Serialization.XmlElementAttribute("TpAndId", typeof(SafekeepingPlaceTypeAndAnyBICIdentifier1))]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.040.001.05")]
public partial class GenericIdentification19 {
    
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.040.001.05")]
public partial class PartyIdentification36Choice {
    
    private object itemField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("AnyBIC", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("PrtryId", typeof(GenericIdentification19))]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.040.001.05")]
public partial class AccountIdentification15 {
    
    private string sfkpgAcctField;
    
    private PartyIdentification36Choice acctOwnrField;
    
    private SafekeepingPlaceFormat2Choice sfkpgPlcField;
    
    /// <remarks/>
    public string SfkpgAcct {
        get {
            return this.sfkpgAcctField;
        }
        set {
            this.sfkpgAcctField = value;
        }
    }
    
    /// <remarks/>
    public PartyIdentification36Choice AcctOwnr {
        get {
            return this.acctOwnrField;
        }
        set {
            this.acctOwnrField = value;
        }
    }
    
    /// <remarks/>
    public SafekeepingPlaceFormat2Choice SfkpgPlc {
        get {
            return this.sfkpgPlcField;
        }
        set {
            this.sfkpgPlcField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.040.001.05")]
public partial class IdentificationSource3Choice {
    
    private string itemField;
    
    private ItemChoiceType itemElementNameField;
    
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.040.001.05", IncludeInSchema=false)]
public enum ItemChoiceType {
    
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.040.001.05")]
public partial class OtherIdentification1 {
    
    private string idField;
    
    private string sfxField;
    
    private IdentificationSource3Choice tpField;
    
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
    public string Sfx {
        get {
            return this.sfxField;
        }
        set {
            this.sfxField = value;
        }
    }
    
    /// <remarks/>
    public IdentificationSource3Choice Tp {
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
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.040.001.05")]
public partial class SecurityIdentification14 {
    
    private string iSINField;
    
    private OtherIdentification1[] othrIdField;
    
    private string descField;
    
    /// <remarks/>
    public string ISIN {
        get {
            return this.iSINField;
        }
        set {
            this.iSINField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("OthrId")]
    public OtherIdentification1[] OthrId {
        get {
            return this.othrIdField;
        }
        set {
            this.othrIdField = value;
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.040.001.05")]
public partial class CorporateActionEventType11Choice {
    
    private object itemField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Cd", typeof(CorporateActionEventType10Code))]
    [System.Xml.Serialization.XmlElementAttribute("Prtry", typeof(GenericIdentification20))]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.040.001.05")]
public enum CorporateActionEventType10Code {
    
    /// <remarks/>
    ACTV,
    
    /// <remarks/>
    ATTI,
    
    /// <remarks/>
    BRUP,
    
    /// <remarks/>
    DFLT,
    
    /// <remarks/>
    BONU,
    
    /// <remarks/>
    EXRI,
    
    /// <remarks/>
    CAPD,
    
    /// <remarks/>
    CAPG,
    
    /// <remarks/>
    CAPI,
    
    /// <remarks/>
    DRCA,
    
    /// <remarks/>
    DVCA,
    
    /// <remarks/>
    CHAN,
    
    /// <remarks/>
    CLSA,
    
    /// <remarks/>
    COOP,
    
    /// <remarks/>
    CONS,
    
    /// <remarks/>
    CONV,
    
    /// <remarks/>
    CREV,
    
    /// <remarks/>
    DECR,
    
    /// <remarks/>
    DETI,
    
    /// <remarks/>
    DSCL,
    
    /// <remarks/>
    DVOP,
    
    /// <remarks/>
    DRIP,
    
    /// <remarks/>
    DRAW,
    
    /// <remarks/>
    DTCH,
    
    /// <remarks/>
    EXOF,
    
    /// <remarks/>
    REDM,
    
    /// <remarks/>
    MCAL,
    
    /// <remarks/>
    INCR,
    
    /// <remarks/>
    PPMT,
    
    /// <remarks/>
    INTR,
    
    /// <remarks/>
    RHDI,
    
    /// <remarks/>
    PRII,
    
    /// <remarks/>
    LIQU,
    
    /// <remarks/>
    EXTM,
    
    /// <remarks/>
    MRGR,
    
    /// <remarks/>
    CERT,
    
    /// <remarks/>
    ODLT,
    
    /// <remarks/>
    OTHR,
    
    /// <remarks/>
    PARI,
    
    /// <remarks/>
    PCAL,
    
    /// <remarks/>
    PRED,
    
    /// <remarks/>
    PINK,
    
    /// <remarks/>
    PLAC,
    
    /// <remarks/>
    PDEF,
    
    /// <remarks/>
    PRIO,
    
    /// <remarks/>
    BPUT,
    
    /// <remarks/>
    REDO,
    
    /// <remarks/>
    REMK,
    
    /// <remarks/>
    BIDS,
    
    /// <remarks/>
    SPLR,
    
    /// <remarks/>
    RHTS,
    
    /// <remarks/>
    DVSC,
    
    /// <remarks/>
    SHPR,
    
    /// <remarks/>
    SMAL,
    
    /// <remarks/>
    SOFF,
    
    /// <remarks/>
    DVSE,
    
    /// <remarks/>
    SPLF,
    
    /// <remarks/>
    TREC,
    
    /// <remarks/>
    TEND,
    
    /// <remarks/>
    DLST,
    
    /// <remarks/>
    SUSP,
    
    /// <remarks/>
    EXWA,
    
    /// <remarks/>
    WTRC,
    
    /// <remarks/>
    WRTH,
    
    /// <remarks/>
    NOOF,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.040.001.05")]
public partial class CorporateActionGeneralInformation49 {
    
    private string corpActnEvtIdField;
    
    private string offclCorpActnEvtIdField;
    
    private CorporateActionEventType11Choice evtTpField;
    
    private SecurityIdentification14 finInstrmIdField;
    
    /// <remarks/>
    public string CorpActnEvtId {
        get {
            return this.corpActnEvtIdField;
        }
        set {
            this.corpActnEvtIdField = value;
        }
    }
    
    /// <remarks/>
    public string OffclCorpActnEvtId {
        get {
            return this.offclCorpActnEvtIdField;
        }
        set {
            this.offclCorpActnEvtIdField = value;
        }
    }
    
    /// <remarks/>
    public CorporateActionEventType11Choice EvtTp {
        get {
            return this.evtTpField;
        }
        set {
            this.evtTpField = value;
        }
    }
    
    /// <remarks/>
    public SecurityIdentification14 FinInstrmId {
        get {
            return this.finInstrmIdField;
        }
        set {
            this.finInstrmIdField = value;
        }
    }
}

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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.021.001.03")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.021.001.03", IsNullable=false)]
public partial class Document {
    
    private SecuritiesTransactionStatusQueryV03 sctiesTxStsQryField;
    
    /// <remarks/>
    public SecuritiesTransactionStatusQueryV03 SctiesTxStsQry {
        get {
            return this.sctiesTxStsQryField;
        }
        set {
            this.sctiesTxStsQryField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.021.001.03")]
public partial class SecuritiesTransactionStatusQueryV03 {
    
    private DocumentNumber9 stsAdvcReqdField;
    
    private PartyIdentification36Choice acctOwnrField;
    
    private SecuritiesAccount13 sfkpgAcctField;
    
    private SupplementaryData1[] splmtryDataField;
    
    /// <remarks/>
    public DocumentNumber9 StsAdvcReqd {
        get {
            return this.stsAdvcReqdField;
        }
        set {
            this.stsAdvcReqdField = value;
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
    public SecuritiesAccount13 SfkpgAcct {
        get {
            return this.sfkpgAcctField;
        }
        set {
            this.sfkpgAcctField = value;
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.021.001.03")]
public partial class DocumentNumber9 {
    
    private DocumentNumber1Choice nbField;
    
    private Identification11[] refsField;
    
    /// <remarks/>
    public DocumentNumber1Choice Nb {
        get {
            return this.nbField;
        }
        set {
            this.nbField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Refs")]
    public Identification11[] Refs {
        get {
            return this.refsField;
        }
        set {
            this.refsField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.021.001.03")]
public partial class DocumentNumber1Choice {
    
    private object itemField;
    
    private ItemChoiceType itemElementNameField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("LngNb", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("PrtryNb", typeof(GenericIdentification19))]
    [System.Xml.Serialization.XmlElementAttribute("ShrtNb", typeof(string))]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.021.001.03")]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.021.001.03")]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.021.001.03")]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.021.001.03")]
public partial class SecuritiesAccount13 {
    
    private string idField;
    
    private GenericIdentification20 tpField;
    
    private string nmField;
    
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
    public GenericIdentification20 Tp {
        get {
            return this.tpField;
        }
        set {
            this.tpField = value;
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
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.021.001.03")]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.021.001.03")]
public partial class Identification11 {
    
    private string acctOwnrTxIdField;
    
    private string acctSvcrTxIdField;
    
    private string mktInfrstrctrTxIdField;
    
    private string prcrTxIdField;
    
    private string cmonIdField;
    
    private string[] tradIdField;
    
    private string mstrIdField;
    
    private string bsktIdField;
    
    private string indxIdField;
    
    private string listIdField;
    
    private string prgmIdField;
    
    private string poolIdField;
    
    private string corpActnEvtIdField;
    
    /// <remarks/>
    public string AcctOwnrTxId {
        get {
            return this.acctOwnrTxIdField;
        }
        set {
            this.acctOwnrTxIdField = value;
        }
    }
    
    /// <remarks/>
    public string AcctSvcrTxId {
        get {
            return this.acctSvcrTxIdField;
        }
        set {
            this.acctSvcrTxIdField = value;
        }
    }
    
    /// <remarks/>
    public string MktInfrstrctrTxId {
        get {
            return this.mktInfrstrctrTxIdField;
        }
        set {
            this.mktInfrstrctrTxIdField = value;
        }
    }
    
    /// <remarks/>
    public string PrcrTxId {
        get {
            return this.prcrTxIdField;
        }
        set {
            this.prcrTxIdField = value;
        }
    }
    
    /// <remarks/>
    public string CmonId {
        get {
            return this.cmonIdField;
        }
        set {
            this.cmonIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("TradId")]
    public string[] TradId {
        get {
            return this.tradIdField;
        }
        set {
            this.tradIdField = value;
        }
    }
    
    /// <remarks/>
    public string MstrId {
        get {
            return this.mstrIdField;
        }
        set {
            this.mstrIdField = value;
        }
    }
    
    /// <remarks/>
    public string BsktId {
        get {
            return this.bsktIdField;
        }
        set {
            this.bsktIdField = value;
        }
    }
    
    /// <remarks/>
    public string IndxId {
        get {
            return this.indxIdField;
        }
        set {
            this.indxIdField = value;
        }
    }
    
    /// <remarks/>
    public string ListId {
        get {
            return this.listIdField;
        }
        set {
            this.listIdField = value;
        }
    }
    
    /// <remarks/>
    public string PrgmId {
        get {
            return this.prgmIdField;
        }
        set {
            this.prgmIdField = value;
        }
    }
    
    /// <remarks/>
    public string PoolId {
        get {
            return this.poolIdField;
        }
        set {
            this.poolIdField = value;
        }
    }
    
    /// <remarks/>
    public string CorpActnEvtId {
        get {
            return this.corpActnEvtIdField;
        }
        set {
            this.corpActnEvtIdField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.021.001.03", IncludeInSchema=false)]
public enum ItemChoiceType {
    
    /// <remarks/>
    LngNb,
    
    /// <remarks/>
    PrtryNb,
    
    /// <remarks/>
    ShrtNb,
}
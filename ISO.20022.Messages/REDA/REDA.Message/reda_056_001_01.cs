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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:reda.056.001.01")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:reda.056.001.01", IsNullable=false)]
public partial class Document {
    
    private StandingSettlementInstructionV01 stgSttlmInstrField;
    
    /// <remarks/>
    public StandingSettlementInstructionV01 StgSttlmInstr {
        get {
            return this.stgSttlmInstrField;
        }
        set {
            this.stgSttlmInstrField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:reda.056.001.01")]
public partial class StandingSettlementInstructionV01 {
    
    private string msgRefIdField;
    
    private EffectiveDate1 fctvDtDtlsField;
    
    private AccountIdentification26[] acctIdField;
    
    private MarketIdentificationOrCashPurpose1Choice mktIdField;
    
    private string sttlmCcyField;
    
    private SecuritiesOrCash1Choice sttlmDtlsField;
    
    private SupplementaryData1[] splmtryDataField;
    
    /// <remarks/>
    public string MsgRefId {
        get {
            return this.msgRefIdField;
        }
        set {
            this.msgRefIdField = value;
        }
    }
    
    /// <remarks/>
    public EffectiveDate1 FctvDtDtls {
        get {
            return this.fctvDtDtlsField;
        }
        set {
            this.fctvDtDtlsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("AcctId")]
    public AccountIdentification26[] AcctId {
        get {
            return this.acctIdField;
        }
        set {
            this.acctIdField = value;
        }
    }
    
    /// <remarks/>
    public MarketIdentificationOrCashPurpose1Choice MktId {
        get {
            return this.mktIdField;
        }
        set {
            this.mktIdField = value;
        }
    }
    
    /// <remarks/>
    public string SttlmCcy {
        get {
            return this.sttlmCcyField;
        }
        set {
            this.sttlmCcyField = value;
        }
    }
    
    /// <remarks/>
    public SecuritiesOrCash1Choice SttlmDtls {
        get {
            return this.sttlmDtlsField;
        }
        set {
            this.sttlmDtlsField = value;
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:reda.056.001.01")]
public partial class EffectiveDate1 {
    
    private System.DateTime fctvDtField;
    
    private string fctvDtParamField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
    public System.DateTime FctvDt {
        get {
            return this.fctvDtField;
        }
        set {
            this.fctvDtField = value;
        }
    }
    
    /// <remarks/>
    public string FctvDtParam {
        get {
            return this.fctvDtParamField;
        }
        set {
            this.fctvDtParamField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:reda.056.001.01")]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:reda.056.001.01")]
public partial class PartyIdentification62 {
    
    private string bICFIField;
    
    private GenericIdentification1 prtryIdField;
    
    private NameAndAddress5 nmAndAdrField;
    
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
    public GenericIdentification1 PrtryId {
        get {
            return this.prtryIdField;
        }
        set {
            this.prtryIdField = value;
        }
    }
    
    /// <remarks/>
    public NameAndAddress5 NmAndAdr {
        get {
            return this.nmAndAdrField;
        }
        set {
            this.nmAndAdrField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:reda.056.001.01")]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:reda.056.001.01")]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:reda.056.001.01")]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:reda.056.001.01")]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:reda.056.001.01")]
public partial class PartyIdentificationAndAccount97 {
    
    private PartyIdentification62 ptyIdField;
    
    private AccountIdentification26 acctIdField;
    
    /// <remarks/>
    public PartyIdentification62 PtyId {
        get {
            return this.ptyIdField;
        }
        set {
            this.ptyIdField = value;
        }
    }
    
    /// <remarks/>
    public AccountIdentification26 AcctId {
        get {
            return this.acctIdField;
        }
        set {
            this.acctIdField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:reda.056.001.01")]
public partial class AccountIdentification26 {
    
    private SimpleIdentificationInformation4 prtryField;
    
    /// <remarks/>
    public SimpleIdentificationInformation4 Prtry {
        get {
            return this.prtryField;
        }
        set {
            this.prtryField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:reda.056.001.01")]
public partial class SimpleIdentificationInformation4 {
    
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

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:reda.056.001.01")]
public partial class PartyIdentification64 {
    
    private string anyBICField;
    
    private GenericIdentification1 prtryIdField;
    
    private NameAndAddress5 nmAndAdrField;
    
    /// <remarks/>
    public string AnyBIC {
        get {
            return this.anyBICField;
        }
        set {
            this.anyBICField = value;
        }
    }
    
    /// <remarks/>
    public GenericIdentification1 PrtryId {
        get {
            return this.prtryIdField;
        }
        set {
            this.prtryIdField = value;
        }
    }
    
    /// <remarks/>
    public NameAndAddress5 NmAndAdr {
        get {
            return this.nmAndAdrField;
        }
        set {
            this.nmAndAdrField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:reda.056.001.01")]
public partial class PartyIdentificationAndAccount96 {
    
    private PartyIdentification64 ptyIdField;
    
    private AccountIdentification26 acctIdField;
    
    /// <remarks/>
    public PartyIdentification64 PtyId {
        get {
            return this.ptyIdField;
        }
        set {
            this.ptyIdField = value;
        }
    }
    
    /// <remarks/>
    public AccountIdentification26 AcctId {
        get {
            return this.acctIdField;
        }
        set {
            this.acctIdField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:reda.056.001.01")]
public partial class CashParties24 {
    
    private PartyIdentificationAndAccount96 cdtrField;
    
    private PartyIdentificationAndAccount97 cdtrAgtField;
    
    private PartyIdentificationAndAccount97 intrmyField;
    
    private PartyIdentificationAndAccount97 intrmy2Field;
    
    /// <remarks/>
    public PartyIdentificationAndAccount96 Cdtr {
        get {
            return this.cdtrField;
        }
        set {
            this.cdtrField = value;
        }
    }
    
    /// <remarks/>
    public PartyIdentificationAndAccount97 CdtrAgt {
        get {
            return this.cdtrAgtField;
        }
        set {
            this.cdtrAgtField = value;
        }
    }
    
    /// <remarks/>
    public PartyIdentificationAndAccount97 Intrmy {
        get {
            return this.intrmyField;
        }
        set {
            this.intrmyField = value;
        }
    }
    
    /// <remarks/>
    public PartyIdentificationAndAccount97 Intrmy2 {
        get {
            return this.intrmy2Field;
        }
        set {
            this.intrmy2Field = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:reda.056.001.01")]
public partial class PartyIdentification44 {
    
    private string anyBICField;
    
    private string[] altrntvIdrField;
    
    /// <remarks/>
    public string AnyBIC {
        get {
            return this.anyBICField;
        }
        set {
            this.anyBICField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("AltrntvIdr")]
    public string[] AltrntvIdr {
        get {
            return this.altrntvIdrField;
        }
        set {
            this.altrntvIdrField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:reda.056.001.01")]
public partial class NameAndAddress8 {
    
    private string nmField;
    
    private PostalAddress1 adrField;
    
    private string[] altrntvIdrField;
    
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
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("AltrntvIdr")]
    public string[] AltrntvIdr {
        get {
            return this.altrntvIdrField;
        }
        set {
            this.altrntvIdrField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:reda.056.001.01")]
public partial class PartyIdentification99Choice {
    
    private object itemField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("AnyBIC", typeof(PartyIdentification44))]
    [System.Xml.Serialization.XmlElementAttribute("NmAndAdr", typeof(NameAndAddress8))]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:reda.056.001.01")]
public partial class GenericIdentification49 {
    
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:reda.056.001.01")]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:reda.056.001.01")]
public partial class SecuritiesAccount22 {
    
    private string idField;
    
    private GenericIdentification30 tpField;
    
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
    public GenericIdentification30 Tp {
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:reda.056.001.01")]
public partial class GenericIdentification36 {
    
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:reda.056.001.01")]
public partial class PartyIdentification71Choice {
    
    private object itemField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("AnyBIC", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("NmAndAdr", typeof(NameAndAddress5))]
    [System.Xml.Serialization.XmlElementAttribute("PrtryId", typeof(GenericIdentification36))]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:reda.056.001.01")]
public partial class PartyIdentificationAndAccount95 {
    
    private PartyIdentification71Choice ptyIdField;
    
    private SecuritiesAccount22 acctIdField;
    
    private string prcgIdField;
    
    /// <remarks/>
    public PartyIdentification71Choice PtyId {
        get {
            return this.ptyIdField;
        }
        set {
            this.ptyIdField = value;
        }
    }
    
    /// <remarks/>
    public SecuritiesAccount22 AcctId {
        get {
            return this.acctIdField;
        }
        set {
            this.acctIdField = value;
        }
    }
    
    /// <remarks/>
    public string PrcgId {
        get {
            return this.prcgIdField;
        }
        set {
            this.prcgIdField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:reda.056.001.01")]
public partial class PartyIdentification75Choice {
    
    private object itemField;
    
    private ItemChoiceType itemElementNameField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("AnyBIC", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("Ctry", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("NmAndAdr", typeof(NameAndAddress5))]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:reda.056.001.01", IncludeInSchema=false)]
public enum ItemChoiceType {
    
    /// <remarks/>
    AnyBIC,
    
    /// <remarks/>
    Ctry,
    
    /// <remarks/>
    NmAndAdr,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:reda.056.001.01")]
public partial class PartyIdentification63 {
    
    private PartyIdentification75Choice ptyIdField;
    
    private string prcgIdField;
    
    /// <remarks/>
    public PartyIdentification75Choice PtyId {
        get {
            return this.ptyIdField;
        }
        set {
            this.ptyIdField = value;
        }
    }
    
    /// <remarks/>
    public string PrcgId {
        get {
            return this.prcgIdField;
        }
        set {
            this.prcgIdField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:reda.056.001.01")]
public partial class SettlementParties32 {
    
    private PartyIdentification63 dpstryField;
    
    private PartyIdentificationAndAccount95 pty1Field;
    
    private PartyIdentificationAndAccount95 pty2Field;
    
    private PartyIdentificationAndAccount95 pty3Field;
    
    private PartyIdentificationAndAccount95 pty4Field;
    
    private PartyIdentificationAndAccount95 pty5Field;
    
    /// <remarks/>
    public PartyIdentification63 Dpstry {
        get {
            return this.dpstryField;
        }
        set {
            this.dpstryField = value;
        }
    }
    
    /// <remarks/>
    public PartyIdentificationAndAccount95 Pty1 {
        get {
            return this.pty1Field;
        }
        set {
            this.pty1Field = value;
        }
    }
    
    /// <remarks/>
    public PartyIdentificationAndAccount95 Pty2 {
        get {
            return this.pty2Field;
        }
        set {
            this.pty2Field = value;
        }
    }
    
    /// <remarks/>
    public PartyIdentificationAndAccount95 Pty3 {
        get {
            return this.pty3Field;
        }
        set {
            this.pty3Field = value;
        }
    }
    
    /// <remarks/>
    public PartyIdentificationAndAccount95 Pty4 {
        get {
            return this.pty4Field;
        }
        set {
            this.pty4Field = value;
        }
    }
    
    /// <remarks/>
    public PartyIdentificationAndAccount95 Pty5 {
        get {
            return this.pty5Field;
        }
        set {
            this.pty5Field = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:reda.056.001.01")]
public partial class SettlementParties35 {
    
    private SettlementParties32 stgSttlmPtiesField;
    
    private GenericIdentification49[] lclMktIdField;
    
    private PartyIdentification99Choice regnDtlsField;
    
    /// <remarks/>
    public SettlementParties32 StgSttlmPties {
        get {
            return this.stgSttlmPtiesField;
        }
        set {
            this.stgSttlmPtiesField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("LclMktId")]
    public GenericIdentification49[] LclMktId {
        get {
            return this.lclMktIdField;
        }
        set {
            this.lclMktIdField = value;
        }
    }
    
    /// <remarks/>
    public PartyIdentification99Choice RegnDtls {
        get {
            return this.regnDtlsField;
        }
        set {
            this.regnDtlsField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:reda.056.001.01")]
public partial class SecuritiesOrCash1Choice {
    
    private object itemField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("CshPtiesDtls", typeof(CashParties24))]
    [System.Xml.Serialization.XmlElementAttribute("SctiesDtls", typeof(SettlementParties35))]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:reda.056.001.01")]
public partial class Purpose3Choice {
    
    private object itemField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Prtry", typeof(GenericIdentification1))]
    [System.Xml.Serialization.XmlElementAttribute("SctiesPurpCd", typeof(string))]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:reda.056.001.01")]
public partial class ClassificationType1Choice {
    
    private object itemField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("AltrnClssfctn", typeof(GenericIdentification1))]
    [System.Xml.Serialization.XmlElementAttribute("ClssfctnFinInstrm", typeof(string))]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:reda.056.001.01")]
public partial class MarketIdentification87 {
    
    private string ctryField;
    
    private ClassificationType1Choice clssfctnTpField;
    
    private Purpose3Choice sttlmPurpField;
    
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
    public ClassificationType1Choice ClssfctnTp {
        get {
            return this.clssfctnTpField;
        }
        set {
            this.clssfctnTpField = value;
        }
    }
    
    /// <remarks/>
    public Purpose3Choice SttlmPurp {
        get {
            return this.sttlmPurpField;
        }
        set {
            this.sttlmPurpField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:reda.056.001.01")]
public partial class MarketIdentificationOrCashPurpose1Choice {
    
    private object[] itemsField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("CshSSIPurp", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("SttlmInstrMktId", typeof(MarketIdentification87))]
    public object[] Items {
        get {
            return this.itemsField;
        }
        set {
            this.itemsField = value;
        }
    }
}

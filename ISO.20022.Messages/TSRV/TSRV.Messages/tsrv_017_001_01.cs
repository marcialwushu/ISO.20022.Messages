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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsrv.017.001.01")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsrv.017.001.01", IsNullable=false)]
public partial class Document {
    
    private DemandWithdrawalNotificationV01 dmndWdrwlNtfctnField;
    
    /// <remarks/>
    public DemandWithdrawalNotificationV01 DmndWdrwlNtfctn {
        get {
            return this.dmndWdrwlNtfctnField;
        }
        set {
            this.dmndWdrwlNtfctnField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsrv.017.001.01")]
public partial class DemandWithdrawalNotificationV01 {
    
    private UndertakingDemandWithdrawal1 dmndWdrwlNtfctnDtlsField;
    
    private PartyAndSignature2 dgtlSgntrField;
    
    /// <remarks/>
    public UndertakingDemandWithdrawal1 DmndWdrwlNtfctnDtls {
        get {
            return this.dmndWdrwlNtfctnDtlsField;
        }
        set {
            this.dmndWdrwlNtfctnDtlsField = value;
        }
    }
    
    /// <remarks/>
    public PartyAndSignature2 DgtlSgntr {
        get {
            return this.dgtlSgntrField;
        }
        set {
            this.dgtlSgntrField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsrv.017.001.01")]
public partial class UndertakingDemandWithdrawal1 {
    
    private Undertaking6 udrtkgIdField;
    
    private string advsgPtyRefNbField;
    
    private Demand3 dmndDtlsField;
    
    private string cnfrmrRefNbField;
    
    /// <remarks/>
    public Undertaking6 UdrtkgId {
        get {
            return this.udrtkgIdField;
        }
        set {
            this.udrtkgIdField = value;
        }
    }
    
    /// <remarks/>
    public string AdvsgPtyRefNb {
        get {
            return this.advsgPtyRefNbField;
        }
        set {
            this.advsgPtyRefNbField = value;
        }
    }
    
    /// <remarks/>
    public Demand3 DmndDtls {
        get {
            return this.dmndDtlsField;
        }
        set {
            this.dmndDtlsField = value;
        }
    }
    
    /// <remarks/>
    public string CnfrmrRefNb {
        get {
            return this.cnfrmrRefNbField;
        }
        set {
            this.cnfrmrRefNbField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsrv.017.001.01")]
public partial class Undertaking6 {
    
    private string idField;
    
    private PartyIdentification43 issrField;
    
    private string bnfcryRefNbField;
    
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
    public PartyIdentification43 Issr {
        get {
            return this.issrField;
        }
        set {
            this.issrField = value;
        }
    }
    
    /// <remarks/>
    public string BnfcryRefNb {
        get {
            return this.bnfcryRefNbField;
        }
        set {
            this.bnfcryRefNbField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsrv.017.001.01")]
public partial class PartyIdentification43 {
    
    private string nmField;
    
    private PostalAddress6 pstlAdrField;
    
    private Party11Choice idField;
    
    private string ctryOfResField;
    
    private ContactDetails2 ctctDtlsField;
    
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
    public PostalAddress6 PstlAdr {
        get {
            return this.pstlAdrField;
        }
        set {
            this.pstlAdrField = value;
        }
    }
    
    /// <remarks/>
    public Party11Choice Id {
        get {
            return this.idField;
        }
        set {
            this.idField = value;
        }
    }
    
    /// <remarks/>
    public string CtryOfRes {
        get {
            return this.ctryOfResField;
        }
        set {
            this.ctryOfResField = value;
        }
    }
    
    /// <remarks/>
    public ContactDetails2 CtctDtls {
        get {
            return this.ctctDtlsField;
        }
        set {
            this.ctctDtlsField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsrv.017.001.01")]
public partial class PostalAddress6 {
    
    private AddressType2Code adrTpField;
    
    private bool adrTpFieldSpecified;
    
    private string deptField;
    
    private string subDeptField;
    
    private string strtNmField;
    
    private string bldgNbField;
    
    private string pstCdField;
    
    private string twnNmField;
    
    private string ctrySubDvsnField;
    
    private string ctryField;
    
    private string[] adrLineField;
    
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsrv.017.001.01")]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsrv.017.001.01")]
public partial class PartyAndSignature2 {
    
    private PartyIdentification43 ptyField;
    
    private System.Xml.XmlElement sgntrField;
    
    /// <remarks/>
    public PartyIdentification43 Pty {
        get {
            return this.ptyField;
        }
        set {
            this.ptyField = value;
        }
    }
    
    /// <remarks/>
    public System.Xml.XmlElement Sgntr {
        get {
            return this.sgntrField;
        }
        set {
            this.sgntrField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsrv.017.001.01")]
public partial class ActiveCurrencyAndAmount {
    
    private string ccyField;
    
    private decimal valueField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Ccy {
        get {
            return this.ccyField;
        }
        set {
            this.ccyField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public decimal Value {
        get {
            return this.valueField;
        }
        set {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsrv.017.001.01")]
public partial class Demand3 {
    
    private string idField;
    
    private System.DateTime submissnDtTmField;
    
    private ActiveCurrencyAndAmount amtField;
    
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
    public System.DateTime SubmissnDtTm {
        get {
            return this.submissnDtTmField;
        }
        set {
            this.submissnDtTmField = value;
        }
    }
    
    /// <remarks/>
    public ActiveCurrencyAndAmount Amt {
        get {
            return this.amtField;
        }
        set {
            this.amtField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsrv.017.001.01")]
public partial class ContactDetails2 {
    
    private NamePrefix1Code nmPrfxField;
    
    private bool nmPrfxFieldSpecified;
    
    private string nmField;
    
    private string phneNbField;
    
    private string mobNbField;
    
    private string faxNbField;
    
    private string emailAdrField;
    
    private string othrField;
    
    /// <remarks/>
    public NamePrefix1Code NmPrfx {
        get {
            return this.nmPrfxField;
        }
        set {
            this.nmPrfxField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool NmPrfxSpecified {
        get {
            return this.nmPrfxFieldSpecified;
        }
        set {
            this.nmPrfxFieldSpecified = value;
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
    public string PhneNb {
        get {
            return this.phneNbField;
        }
        set {
            this.phneNbField = value;
        }
    }
    
    /// <remarks/>
    public string MobNb {
        get {
            return this.mobNbField;
        }
        set {
            this.mobNbField = value;
        }
    }
    
    /// <remarks/>
    public string FaxNb {
        get {
            return this.faxNbField;
        }
        set {
            this.faxNbField = value;
        }
    }
    
    /// <remarks/>
    public string EmailAdr {
        get {
            return this.emailAdrField;
        }
        set {
            this.emailAdrField = value;
        }
    }
    
    /// <remarks/>
    public string Othr {
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsrv.017.001.01")]
public enum NamePrefix1Code {
    
    /// <remarks/>
    DOCT,
    
    /// <remarks/>
    MIST,
    
    /// <remarks/>
    MISS,
    
    /// <remarks/>
    MADM,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsrv.017.001.01")]
public partial class PersonIdentificationSchemeName1Choice {
    
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsrv.017.001.01", IncludeInSchema=false)]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsrv.017.001.01")]
public partial class GenericPersonIdentification1 {
    
    private string idField;
    
    private PersonIdentificationSchemeName1Choice schmeNmField;
    
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
    public PersonIdentificationSchemeName1Choice SchmeNm {
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsrv.017.001.01")]
public partial class DateAndPlaceOfBirth {
    
    private System.DateTime birthDtField;
    
    private string prvcOfBirthField;
    
    private string cityOfBirthField;
    
    private string ctryOfBirthField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
    public System.DateTime BirthDt {
        get {
            return this.birthDtField;
        }
        set {
            this.birthDtField = value;
        }
    }
    
    /// <remarks/>
    public string PrvcOfBirth {
        get {
            return this.prvcOfBirthField;
        }
        set {
            this.prvcOfBirthField = value;
        }
    }
    
    /// <remarks/>
    public string CityOfBirth {
        get {
            return this.cityOfBirthField;
        }
        set {
            this.cityOfBirthField = value;
        }
    }
    
    /// <remarks/>
    public string CtryOfBirth {
        get {
            return this.ctryOfBirthField;
        }
        set {
            this.ctryOfBirthField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsrv.017.001.01")]
public partial class PersonIdentification5 {
    
    private DateAndPlaceOfBirth dtAndPlcOfBirthField;
    
    private GenericPersonIdentification1[] othrField;
    
    /// <remarks/>
    public DateAndPlaceOfBirth DtAndPlcOfBirth {
        get {
            return this.dtAndPlcOfBirthField;
        }
        set {
            this.dtAndPlcOfBirthField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Othr")]
    public GenericPersonIdentification1[] Othr {
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsrv.017.001.01")]
public partial class OrganisationIdentificationSchemeName1Choice {
    
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsrv.017.001.01", IncludeInSchema=false)]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsrv.017.001.01")]
public partial class GenericOrganisationIdentification1 {
    
    private string idField;
    
    private OrganisationIdentificationSchemeName1Choice schmeNmField;
    
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
    public OrganisationIdentificationSchemeName1Choice SchmeNm {
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsrv.017.001.01")]
public partial class OrganisationIdentification8 {
    
    private string anyBICField;
    
    private GenericOrganisationIdentification1[] othrField;
    
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
    [System.Xml.Serialization.XmlElementAttribute("Othr")]
    public GenericOrganisationIdentification1[] Othr {
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsrv.017.001.01")]
public partial class Party11Choice {
    
    private object itemField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("OrgId", typeof(OrganisationIdentification8))]
    [System.Xml.Serialization.XmlElementAttribute("PrvtId", typeof(PersonIdentification5))]
    public object Item {
        get {
            return this.itemField;
        }
        set {
            this.itemField = value;
        }
    }
}

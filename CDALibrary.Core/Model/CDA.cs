using System.Collections.Generic;
using System.Xml.Serialization;

using CDALibrary.Core.Logic;

namespace CDALibrary.Core.Model
{

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName = ".ClinicalDocument", Namespace = "urn:hl7-org:v3")]
    [XmlRootAttribute("ClinicalDocument", Namespace = "urn:hl7-org:v3", IsNullable = false)]
    public partial class ClinicalDocument
    {

        private List<CS> realmCodeField;

        private InfrastructureRootTypeId typeIdField;

        private List<II> templateIdField;

        private II idField;

        private CE codeField;

        private ST titleField;

        private TS effectiveTimeField;

        private CE confidentialityCodeField;

        private CS languageCodeField;

        private II setIdField;

        private INT versionNumberField;

        private TS copyTimeField;

        private List<RecordTarget> recordTargetField;

        private List<Author> authorField;

        private DataEnterer dataEntererField;

        private List<Informant12> informantField;

        private Custodian custodianField;

        private List<InformationRecipient> informationRecipientField;

        private LegalAuthenticator legalAuthenticatorField;

        private List<Authenticator> authenticatorField;

        private List<Participant1> participantField;

        private List<InFulfillmentOf> inFulfillmentOfField;

        private List<DocumentationOf> documentationOfField;

        private List<RelatedDocument> relatedDocumentField;

        private List<Authorization> authorizationField;

        private Component1 componentOfField;

        private BodyComponent componentField;

        private string nullFlavorField;

        private ParentDocumentClassCodes classCodeField;

        private bool classCodeFieldSpecified;

        private string moodCodeField;

        public ClinicalDocument()
        {
            this.classCodeField = ParentDocumentClassCodes.DOCCLIN;
            this.moodCodeField = "EVN";
        }

        [XmlElement("realmCode")]
        public List<CS> RealmCodes
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.realmCodeField == null)
                    this.realmCodeField = new List<CS>();

                return this.realmCodeField;
            }
            set
            {
                this.realmCodeField = value;
            }
        }

        [XmlElement("typeId")]
        public InfrastructureRootTypeId TypeId
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.typeIdField == null)
                    this.typeIdField = new InfrastructureRootTypeId();

                return this.typeIdField;
            }
            set
            {
                this.typeIdField = value;
            }
        }

        [XmlElement("templateId")]
        public List<II> TemplateIds
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.templateIdField == null)
                    this.templateIdField = new List<II>();

                return this.templateIdField;
            }
            set
            {
                this.templateIdField = value;
            }
        }

        [XmlElement("id")]
        public II Id
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.idField == null)
                    this.idField = new II();

                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        [XmlElement("code")]
        public CE Code
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.codeField == null)
                    this.codeField = new CE();

                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }

        [XmlElement("title")]
        public ST Title
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.titleField == null)
                    this.titleField = new ST();

                return this.titleField;
            }
            set
            {
                this.titleField = value;
            }
        }

        [XmlElement("effectiveTime")]
        public TS EffectiveTime
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.effectiveTimeField == null)
                    this.effectiveTimeField = new TS();

                return this.effectiveTimeField;
            }
            set
            {
                this.effectiveTimeField = value;
            }
        }

        [XmlElement("confidentialityCode")]
        public CE ConfidentialityCode
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.confidentialityCodeField == null)
                    this.confidentialityCodeField = new CE();

                return this.confidentialityCodeField;
            }
            set
            {
                this.confidentialityCodeField = value;
            }
        }

        [XmlElement("languageCode")]
        public CS LanguageCode
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.languageCodeField == null)
                    this.languageCodeField = new CS();

                return this.languageCodeField;
            }
            set
            {
                this.languageCodeField = value;
            }
        }

        [XmlElement("setId")]
        public II SetId
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.setIdField == null)
                    this.setIdField = new II();

                return this.setIdField;
            }
            set
            {
                this.setIdField = value;
            }
        }

        [XmlElement("versionNumber")]
        public INT VersionNumber
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.versionNumberField == null)
                    this.versionNumberField = new INT();

                return this.versionNumberField;
            }
            set
            {
                this.versionNumberField = value;
            }
        }

        [XmlElement("copyTime")]
        public TS CopyTime
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.copyTimeField == null)
                    this.copyTimeField = new TS();

                return this.copyTimeField;
            }
            set
            {
                this.copyTimeField = value;
            }
        }

        [XmlElement("recordTarget")]
        public List<RecordTarget> RecordTargets
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.recordTargetField == null)
                    this.recordTargetField = new List<RecordTarget>();

                return this.recordTargetField;
            }
            set
            {
                this.recordTargetField = value;
            }
        }

        [XmlElement("author")]
        public List<Author> Authors
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.authorField == null)
                    this.authorField = new List<Author>();

                return this.authorField;
            }
            set
            {
                this.authorField = value;
            }
        }

        [XmlElement("dataEnterer")]
        public DataEnterer DataEnterer
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.dataEntererField == null)
                    this.dataEntererField = new DataEnterer();

                return this.dataEntererField;
            }
            set
            {
                this.dataEntererField = value;
            }
        }

        [XmlElement("informant")]
        public List<Informant12> Informants
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.informantField == null)
                    this.informantField = new List<Informant12>();

                return this.informantField;
            }
            set
            {
                this.informantField = value;
            }
        }

        [XmlElement("custodian")]
        public Custodian Custodian
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.custodianField == null)
                    this.custodianField = new Custodian();

                return this.custodianField;
            }
            set
            {
                this.custodianField = value;
            }
        }

        [XmlElement("informationRecipient")]
        public List<InformationRecipient> InformationRecipients
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.informationRecipientField == null)
                    this.informationRecipientField = new List<InformationRecipient>();

                return this.informationRecipientField;
            }
            set
            {
                this.informationRecipientField = value;
            }
        }

        [XmlElement("legalAuthenticator")]
        public LegalAuthenticator LegalAuthenticator
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.legalAuthenticatorField == null)
                    this.legalAuthenticatorField = new LegalAuthenticator();

                return this.legalAuthenticatorField;
            }
            set
            {
                this.legalAuthenticatorField = value;
            }
        }

        [XmlElement("authenticator")]
        public List<Authenticator> Authenticators
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.authenticatorField == null)
                    this.authenticatorField = new List<Authenticator>();

                return this.authenticatorField;
            }
            set
            {
                this.authenticatorField = value;
            }
        }

        [XmlElement("participant")]
        public List<Participant1> Participants
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.participantField == null)
                    this.participantField = new List<Participant1>();

                return this.participantField;
            }
            set
            {
                this.participantField = value;
            }
        }

        [XmlElement("inFulfillmentOf")]
        public List<InFulfillmentOf> InFulfillmentOfs
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.inFulfillmentOfField == null)
                    this.inFulfillmentOfField = new List<InFulfillmentOf>();

                return this.inFulfillmentOfField;
            }
            set
            {
                this.inFulfillmentOfField = value;
            }
        }

        [XmlElement("documentationOf")]
        public List<DocumentationOf> DocumentationOfs
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.documentationOfField == null)
                    this.documentationOfField = new List<DocumentationOf>();

                return this.documentationOfField;
            }
            set
            {
                this.documentationOfField = value;
            }
        }

        [XmlElement("relatedDocument")]
        public List<RelatedDocument> RelatedDocuments
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.relatedDocumentField == null)
                    this.relatedDocumentField = new List<RelatedDocument>();

                return this.relatedDocumentField;
            }
            set
            {
                this.relatedDocumentField = value;
            }
        }

        [XmlElement("authorization")]
        public List<Authorization> Authorizations
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.authorizationField == null)
                    this.authorizationField = new List<Authorization>();

                return this.authorizationField;
            }
            set
            {
                this.authorizationField = value;
            }
        }

        [XmlElement("componentOf")]
        public Component1 ComponentOf
        {
            get
            {
                return this.componentOfField;
            }
            set
            {
                this.componentOfField = value;
            }
        }

        [XmlElement("component")]
        public BodyComponent BodyComponent
        {
            get
            {
                return this.componentField;
            }
            set
            {
                this.componentField = value;
            }
        }

        [XmlAttribute("nullFlavor")]
        public string NullFlavor
        {
            get
            {
                return this.nullFlavorField;
            }
            set
            {
                this.nullFlavorField = value;
            }
        }

        [XmlAttribute("classCode")]
        public ParentDocumentClassCodes ClassCode
        {
            get
            {
                return this.classCodeField;
            }
            set
            {
                this.classCodeField = value;
            }
        }

        [XmlIgnore()]
        public bool ClassCodeSpecified
        {
            get
            {
                return this.classCodeFieldSpecified;
            }
            set
            {
                this.classCodeFieldSpecified = value;
            }
        }

        [XmlAttribute("moodCode")]
        public string MoodCode
        {
            get
            {
                return this.moodCodeField;
            }
            set
            {
                this.moodCodeField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn:hl7-org:v3")]
    public partial class CS : CV
    {
    }

    [XmlIncludeAttribute(typeof(PQR))]
    [XmlIncludeAttribute(typeof(CO))]
    [XmlIncludeAttribute(typeof(CS))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn:hl7-org:v3")]
    public partial class CV : CE
    {
    }

    [XmlIncludeAttribute(typeof(HXIT_CE))]
    [XmlIncludeAttribute(typeof(EIVLevent))]
    [XmlIncludeAttribute(typeof(CV))]
    [XmlIncludeAttribute(typeof(PQR))]
    [XmlIncludeAttribute(typeof(CO))]
    [XmlIncludeAttribute(typeof(CS))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn:hl7-org:v3")]
    public partial class CE : CD
    {
    }

    [XmlIncludeAttribute(typeof(BXIT_CD))]
    [XmlIncludeAttribute(typeof(SXCM_CD))]
    [XmlIncludeAttribute(typeof(CE))]
    [XmlIncludeAttribute(typeof(HXIT_CE))]
    [XmlIncludeAttribute(typeof(EIVLevent))]
    [XmlIncludeAttribute(typeof(CV))]
    [XmlIncludeAttribute(typeof(PQR))]
    [XmlIncludeAttribute(typeof(CO))]
    [XmlIncludeAttribute(typeof(CS))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn:hl7-org:v3")]
    public partial class CD : ANY
    {

        private ED originalTextField;

        private List<CR> qualifierField;

        private List<CD> translationField;

        private string codeField;

        private string codeSystemField;

        private string codeSystemNameField;

        private string codeSystemVersionField;

        private string displayNameField;

        [XmlElement("originalText")]
        public ED OriginalText
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.originalTextField == null)
                    this.originalTextField = new ED();

                return this.originalTextField;
            }
            set
            {
                this.originalTextField = value;
            }
        }

        [XmlElement("qualifier")]
        public List<CR> Qualifiers
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.qualifierField == null)
                    this.qualifierField = new List<CR>();

                return this.qualifierField;
            }
            set
            {
                this.qualifierField = value;
            }
        }

        [XmlElement("translation")]
        public List<CD> Translations
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.translationField == null)
                    this.translationField = new List<CD>();

                return this.translationField;
            }
            set
            {
                this.translationField = value;
            }
        }

        [XmlAttribute(AttributeName = "code", DataType = "token")]
        public string Code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }

        [XmlAttribute("codeSystem")]
        public string CodeSystem
        {
            get
            {
                return this.codeSystemField;
            }
            set
            {
                this.codeSystemField = value;
            }
        }

        [XmlAttribute("codeSystemName")]
        public string CodeSystemName
        {
            get
            {
                return this.codeSystemNameField;
            }
            set
            {
                this.codeSystemNameField = value;
            }
        }

        [XmlAttribute("codeSystemVersion")]
        public string CodeSystemVersion
        {
            get
            {
                return this.codeSystemVersionField;
            }
            set
            {
                this.codeSystemVersionField = value;
            }
        }

        [XmlAttribute("displayName")]
        public string DisplayName
        {
            get
            {
                return this.displayNameField;
            }
            set
            {
                this.displayNameField = value;
            }
        }
    }

    [XmlIncludeAttribute(typeof(ST))]
    [XmlIncludeAttribute(typeof(ENXP))]
    [XmlIncludeAttribute(typeof(ensuffix))]
    [XmlIncludeAttribute(typeof(enprefix))]
    [XmlIncludeAttribute(typeof(engiven))]
    [XmlIncludeAttribute(typeof(enfamily))]
    [XmlIncludeAttribute(typeof(endelimiter))]
    [XmlIncludeAttribute(typeof(ADXP))]
    [XmlIncludeAttribute(typeof(adxpprecinct))]
    [XmlIncludeAttribute(typeof(adxppostBox))]
    [XmlIncludeAttribute(typeof(adxpbuildingNumberSuffix))]
    [XmlIncludeAttribute(typeof(adxpdeliveryModeIdentifier))]
    [XmlIncludeAttribute(typeof(adxpdeliveryMode))]
    [XmlIncludeAttribute(typeof(adxpdeliveryInstallationQualifier))]
    [XmlIncludeAttribute(typeof(adxpdeliveryInstallationArea))]
    [XmlIncludeAttribute(typeof(adxpdeliveryInstallationType))]
    [XmlIncludeAttribute(typeof(adxpdeliveryAddressLine))]
    [XmlIncludeAttribute(typeof(adxpcensusTract))]
    [XmlIncludeAttribute(typeof(adxpcareOf))]
    [XmlIncludeAttribute(typeof(adxpunitType))]
    [XmlIncludeAttribute(typeof(adxpunitID))]
    [XmlIncludeAttribute(typeof(adxpadditionalLocator))]
    [XmlIncludeAttribute(typeof(adxpstreetNameType))]
    [XmlIncludeAttribute(typeof(adxpstreetNameBase))]
    [XmlIncludeAttribute(typeof(adxpstreetName))]
    [XmlIncludeAttribute(typeof(adxpdirection))]
    [XmlIncludeAttribute(typeof(adxphouseNumberNumeric))]
    [XmlIncludeAttribute(typeof(adxphouseNumber))]
    [XmlIncludeAttribute(typeof(adxpstreetAddressLine))]
    [XmlIncludeAttribute(typeof(adxppostalCode))]
    [XmlIncludeAttribute(typeof(adxpcity))]
    [XmlIncludeAttribute(typeof(adxpcounty))]
    [XmlIncludeAttribute(typeof(adxpstate))]
    [XmlIncludeAttribute(typeof(adxpcountry))]
    [XmlIncludeAttribute(typeof(adxpdelimiter))]
    [XmlIncludeAttribute(typeof(SC))]
    [XmlIncludeAttribute(typeof(thumbnail))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn:hl7-org:v3")]
    public partial class ED : BIN
    {

        private TEL referenceField;

        private thumbnail thumbnailField;

        private string mediaTypeField;

        private string languageField;

        private CompressionAlgorithms compressionField;

        private bool compressionFieldSpecified;

        private byte[] integrityCheckField;

        private IntegrityCheckAlgorithms integrityCheckAlgorithmField;

        public ED()
        {
            this.mediaTypeField = "text/plain";
            this.integrityCheckAlgorithmField = IntegrityCheckAlgorithms.SHA1;
        }

        [XmlElement("reference")]
        public TEL Reference
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.referenceField == null)
                    this.referenceField = new TEL();

                return this.referenceField;
            }
            set
            {
                this.referenceField = value;
            }
        }

        [XmlElement("thumbnail")]
        public thumbnail Thumbnail
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.thumbnailField == null)
                    this.thumbnailField = new thumbnail();

                return this.thumbnailField;
            }
            set
            {
                this.thumbnailField = value;
            }
        }

        [XmlAttribute(AttributeName = "mediaType", DataType = "token")]
        [System.ComponentModel.DefaultValueAttribute("text/plain")]
        public string MediaType
        {
            get
            {
                return this.mediaTypeField;
            }
            set
            {
                this.mediaTypeField = value;
            }
        }

        [XmlAttribute(AttributeName = "language", DataType = "token")]
        public string Language
        {
            get
            {
                return this.languageField;
            }
            set
            {
                this.languageField = value;
            }
        }

        [XmlAttribute("compression")]
        public CompressionAlgorithms Compression
        {
            get
            {
                return this.compressionField;
            }
            set
            {
                this.compressionField = value;
            }
        }

        [XmlIgnore()]
        public bool CompressionSpecified
        {
            get
            {
                return this.compressionFieldSpecified;
            }
            set
            {
                this.compressionFieldSpecified = value;
            }
        }

        [XmlAttribute(AttributeName = "integrityCheck", DataType = "base64Binary")]
        public byte[] IntegrityCheck
        {
            get
            {
                return this.integrityCheckField;
            }
            set
            {
                this.integrityCheckField = value;
            }
        }

        [XmlAttribute(AttributeName = "integrityCheckAlgorithm")]
        [System.ComponentModel.DefaultValueAttribute(IntegrityCheckAlgorithms.SHA1)]
        public IntegrityCheckAlgorithms IntegrityCheckAlgorithm
        {
            get
            {
                return this.integrityCheckAlgorithmField;
            }
            set
            {
                this.integrityCheckAlgorithmField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn:hl7-org:v3")]
    public partial class TEL : URL
    {

        private SXCM_TS[] useablePeriodField;

        private string[] useField;

        [XmlElement("useablePeriod")]
        public SXCM_TS[] UseablePeriods
        {
            get
            {
                return this.useablePeriodField;
            }
            set
            {
                this.useablePeriodField = value;
            }
        }

        [XmlAttribute("use")]
        public string[] Use
        {
            get
            {
                return this.useField;
            }
            set
            {
                this.useField = value;
            }
        }
    }

    [XmlIncludeAttribute(typeof(SXPR_TS))]
    [XmlIncludeAttribute(typeof(EIVL_TS))]
    [XmlIncludeAttribute(typeof(PIVL_TS))]
    [XmlIncludeAttribute(typeof(IVL_TS))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn:hl7-org:v3")]
    public partial class SXCM_TS : TS
    {

        private Operators operatorField;

        public SXCM_TS()
        {
            this.operatorField = Operators.I;
        }

        [XmlAttribute("operator")]
        [System.ComponentModel.DefaultValueAttribute(Operators.I)]
        public Operators Operator
        {
            get
            {
                return this.operatorField;
            }
            set
            {
                this.operatorField = value;
            }
        }
    }

    [XmlIncludeAttribute(typeof(UVP_TS))]
    [XmlIncludeAttribute(typeof(PPD_TS))]
    [XmlIncludeAttribute(typeof(IVXB_PPD_TS))]
    [XmlIncludeAttribute(typeof(SXCM_PPD_TS))]
    [XmlIncludeAttribute(typeof(EIVL_PPD_TS))]
    [XmlIncludeAttribute(typeof(IVL_PPD_TS))]
    [XmlIncludeAttribute(typeof(PIVL_PPD_TS))]
    [XmlIncludeAttribute(typeof(IVXB_TS))]
    [XmlIncludeAttribute(typeof(SXCM_TS))]
    [XmlIncludeAttribute(typeof(SXPR_TS))]
    [XmlIncludeAttribute(typeof(EIVL_TS))]
    [XmlIncludeAttribute(typeof(PIVL_TS))]
    [XmlIncludeAttribute(typeof(IVL_TS))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn:hl7-org:v3")]
    public partial class TS : QTY
    {

        private string valueField;

        [XmlAttribute("value")]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    [XmlIncludeAttribute(typeof(RTO_MO_PQ))]
    [XmlIncludeAttribute(typeof(RTO_PQ_PQ))]
    [XmlIncludeAttribute(typeof(RTO_QTY_QTY))]
    [XmlIncludeAttribute(typeof(RTO))]
    [XmlIncludeAttribute(typeof(MO))]
    [XmlIncludeAttribute(typeof(IVXB_MO))]
    [XmlIncludeAttribute(typeof(SXCM_MO))]
    [XmlIncludeAttribute(typeof(IVL_MO))]
    [XmlIncludeAttribute(typeof(REAL))]
    [XmlIncludeAttribute(typeof(IVXB_REAL))]
    [XmlIncludeAttribute(typeof(SXCM_REAL))]
    [XmlIncludeAttribute(typeof(IVL_REAL))]
    [XmlIncludeAttribute(typeof(INT))]
    [XmlIncludeAttribute(typeof(RegionOfInterestvalue))]
    [XmlIncludeAttribute(typeof(IVXB_INT))]
    [XmlIncludeAttribute(typeof(SXCM_INT))]
    [XmlIncludeAttribute(typeof(IVL_INT))]
    [XmlIncludeAttribute(typeof(PQ))]
    [XmlIncludeAttribute(typeof(HXIT_PQ))]
    [XmlIncludeAttribute(typeof(PPD_PQ))]
    [XmlIncludeAttribute(typeof(IVXB_PPD_PQ))]
    [XmlIncludeAttribute(typeof(SXCM_PPD_PQ))]
    [XmlIncludeAttribute(typeof(IVL_PPD_PQ))]
    [XmlIncludeAttribute(typeof(IVXB_PQ))]
    [XmlIncludeAttribute(typeof(SXCM_PQ))]
    [XmlIncludeAttribute(typeof(IVL_PQ))]
    [XmlIncludeAttribute(typeof(BXIT_IVL_PQ))]
    [XmlIncludeAttribute(typeof(TS))]
    [XmlIncludeAttribute(typeof(UVP_TS))]
    [XmlIncludeAttribute(typeof(PPD_TS))]
    [XmlIncludeAttribute(typeof(IVXB_PPD_TS))]
    [XmlIncludeAttribute(typeof(SXCM_PPD_TS))]
    [XmlIncludeAttribute(typeof(EIVL_PPD_TS))]
    [XmlIncludeAttribute(typeof(IVL_PPD_TS))]
    [XmlIncludeAttribute(typeof(PIVL_PPD_TS))]
    [XmlIncludeAttribute(typeof(IVXB_TS))]
    [XmlIncludeAttribute(typeof(SXCM_TS))]
    [XmlIncludeAttribute(typeof(SXPR_TS))]
    [XmlIncludeAttribute(typeof(EIVL_TS))]
    [XmlIncludeAttribute(typeof(PIVL_TS))]
    [XmlIncludeAttribute(typeof(IVL_TS))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn:hl7-org:v3")]
    public abstract partial class QTY : ANY
    {
    }

    [XmlIncludeAttribute(typeof(GLIST_PQ))]
    [XmlIncludeAttribute(typeof(GLIST_TS))]
    [XmlIncludeAttribute(typeof(SLIST_TS))]
    [XmlIncludeAttribute(typeof(SLIST_PQ))]
    [XmlIncludeAttribute(typeof(EN))]
    [XmlIncludeAttribute(typeof(TN))]
    [XmlIncludeAttribute(typeof(ON))]
    [XmlIncludeAttribute(typeof(PN))]
    [XmlIncludeAttribute(typeof(AD))]
    [XmlIncludeAttribute(typeof(II))]
    [XmlIncludeAttribute(typeof(InfrastructureRootTypeId))]
    [XmlIncludeAttribute(typeof(CR))]
    [XmlIncludeAttribute(typeof(CD))]
    [XmlIncludeAttribute(typeof(BXIT_CD))]
    [XmlIncludeAttribute(typeof(SXCM_CD))]
    [XmlIncludeAttribute(typeof(CE))]
    [XmlIncludeAttribute(typeof(HXIT_CE))]
    [XmlIncludeAttribute(typeof(EIVLevent))]
    [XmlIncludeAttribute(typeof(CV))]
    [XmlIncludeAttribute(typeof(PQR))]
    [XmlIncludeAttribute(typeof(CO))]
    [XmlIncludeAttribute(typeof(CS))]
    [XmlIncludeAttribute(typeof(QTY))]
    [XmlIncludeAttribute(typeof(RTO_MO_PQ))]
    [XmlIncludeAttribute(typeof(RTO_PQ_PQ))]
    [XmlIncludeAttribute(typeof(RTO_QTY_QTY))]
    [XmlIncludeAttribute(typeof(RTO))]
    [XmlIncludeAttribute(typeof(MO))]
    [XmlIncludeAttribute(typeof(IVXB_MO))]
    [XmlIncludeAttribute(typeof(SXCM_MO))]
    [XmlIncludeAttribute(typeof(IVL_MO))]
    [XmlIncludeAttribute(typeof(REAL))]
    [XmlIncludeAttribute(typeof(IVXB_REAL))]
    [XmlIncludeAttribute(typeof(SXCM_REAL))]
    [XmlIncludeAttribute(typeof(IVL_REAL))]
    [XmlIncludeAttribute(typeof(INT))]
    [XmlIncludeAttribute(typeof(RegionOfInterestvalue))]
    [XmlIncludeAttribute(typeof(IVXB_INT))]
    [XmlIncludeAttribute(typeof(SXCM_INT))]
    [XmlIncludeAttribute(typeof(IVL_INT))]
    [XmlIncludeAttribute(typeof(PQ))]
    [XmlIncludeAttribute(typeof(HXIT_PQ))]
    [XmlIncludeAttribute(typeof(PPD_PQ))]
    [XmlIncludeAttribute(typeof(IVXB_PPD_PQ))]
    [XmlIncludeAttribute(typeof(SXCM_PPD_PQ))]
    [XmlIncludeAttribute(typeof(IVL_PPD_PQ))]
    [XmlIncludeAttribute(typeof(IVXB_PQ))]
    [XmlIncludeAttribute(typeof(SXCM_PQ))]
    [XmlIncludeAttribute(typeof(IVL_PQ))]
    [XmlIncludeAttribute(typeof(BXIT_IVL_PQ))]
    [XmlIncludeAttribute(typeof(TS))]
    [XmlIncludeAttribute(typeof(UVP_TS))]
    [XmlIncludeAttribute(typeof(PPD_TS))]
    [XmlIncludeAttribute(typeof(IVXB_PPD_TS))]
    [XmlIncludeAttribute(typeof(SXCM_PPD_TS))]
    [XmlIncludeAttribute(typeof(EIVL_PPD_TS))]
    [XmlIncludeAttribute(typeof(IVL_PPD_TS))]
    [XmlIncludeAttribute(typeof(PIVL_PPD_TS))]
    [XmlIncludeAttribute(typeof(IVXB_TS))]
    [XmlIncludeAttribute(typeof(SXCM_TS))]
    [XmlIncludeAttribute(typeof(SXPR_TS))]
    [XmlIncludeAttribute(typeof(EIVL_TS))]
    [XmlIncludeAttribute(typeof(PIVL_TS))]
    [XmlIncludeAttribute(typeof(IVL_TS))]
    [XmlIncludeAttribute(typeof(URL))]
    [XmlIncludeAttribute(typeof(TEL))]
    [XmlIncludeAttribute(typeof(BIN))]
    [XmlIncludeAttribute(typeof(ED))]
    [XmlIncludeAttribute(typeof(ST))]
    [XmlIncludeAttribute(typeof(ENXP))]
    [XmlIncludeAttribute(typeof(ensuffix))]
    [XmlIncludeAttribute(typeof(enprefix))]
    [XmlIncludeAttribute(typeof(engiven))]
    [XmlIncludeAttribute(typeof(enfamily))]
    [XmlIncludeAttribute(typeof(endelimiter))]
    [XmlIncludeAttribute(typeof(ADXP))]
    [XmlIncludeAttribute(typeof(adxpprecinct))]
    [XmlIncludeAttribute(typeof(adxppostBox))]
    [XmlIncludeAttribute(typeof(adxpbuildingNumberSuffix))]
    [XmlIncludeAttribute(typeof(adxpdeliveryModeIdentifier))]
    [XmlIncludeAttribute(typeof(adxpdeliveryMode))]
    [XmlIncludeAttribute(typeof(adxpdeliveryInstallationQualifier))]
    [XmlIncludeAttribute(typeof(adxpdeliveryInstallationArea))]
    [XmlIncludeAttribute(typeof(adxpdeliveryInstallationType))]
    [XmlIncludeAttribute(typeof(adxpdeliveryAddressLine))]
    [XmlIncludeAttribute(typeof(adxpcensusTract))]
    [XmlIncludeAttribute(typeof(adxpcareOf))]
    [XmlIncludeAttribute(typeof(adxpunitType))]
    [XmlIncludeAttribute(typeof(adxpunitID))]
    [XmlIncludeAttribute(typeof(adxpadditionalLocator))]
    [XmlIncludeAttribute(typeof(adxpstreetNameType))]
    [XmlIncludeAttribute(typeof(adxpstreetNameBase))]
    [XmlIncludeAttribute(typeof(adxpstreetName))]
    [XmlIncludeAttribute(typeof(adxpdirection))]
    [XmlIncludeAttribute(typeof(adxphouseNumberNumeric))]
    [XmlIncludeAttribute(typeof(adxphouseNumber))]
    [XmlIncludeAttribute(typeof(adxpstreetAddressLine))]
    [XmlIncludeAttribute(typeof(adxppostalCode))]
    [XmlIncludeAttribute(typeof(adxpcity))]
    [XmlIncludeAttribute(typeof(adxpcounty))]
    [XmlIncludeAttribute(typeof(adxpstate))]
    [XmlIncludeAttribute(typeof(adxpcountry))]
    [XmlIncludeAttribute(typeof(adxpdelimiter))]
    [XmlIncludeAttribute(typeof(SC))]
    [XmlIncludeAttribute(typeof(thumbnail))]
    [XmlIncludeAttribute(typeof(ANYNonNull))]
    [XmlIncludeAttribute(typeof(BN))]
    [XmlIncludeAttribute(typeof(BL))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn:hl7-org:v3")]
    public abstract partial class ANY
    {

        private string nullFlavorField;

        [XmlAttribute("nullFlavor")]
        public string NullFlavor
        {
            get
            {
                return this.nullFlavorField;
            }
            set
            {
                this.nullFlavorField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName = ".Component5", Namespace = "urn:hl7-org:v3")]
    public partial class Component5
    {

        private List<CS> realmCodeField;

        private InfrastructureRootTypeId typeIdField;

        private List<II> templateIdField;

        private Section sectionField;

        private string nullFlavorField;

        private ComponentTypeCodes typeCodeField;

        private bool typeCodeFieldSpecified;

        private bool contextConductionIndField;

        private bool contextConductionIndFieldSpecified;

        public Component5()
        {
            this.typeCodeField = ComponentTypeCodes.COMP;
            this.contextConductionIndField = true;
        }

        [XmlElement("realmCode")]
        public List<CS> RealmCodes
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.realmCodeField == null)
                    this.realmCodeField = new List<CS>();

                return this.realmCodeField;
            }
            set
            {
                this.realmCodeField = value;
            }
        }

        [XmlElement("typeId")]
        public InfrastructureRootTypeId TypeId
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.typeIdField == null)
                    this.typeIdField = new InfrastructureRootTypeId();

                return this.typeIdField;
            }
            set
            {
                this.typeIdField = value;
            }
        }

        [XmlElement("templateId")]
        public List<II> TemplateIds
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.templateIdField == null)
                    this.templateIdField = new List<II>();

                return this.templateIdField;
            }
            set
            {
                this.templateIdField = value;
            }
        }

        [XmlElement("section")]
        public Section Section
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.sectionField == null)
                    this.sectionField = new Section();

                return this.sectionField;
            }
            set
            {
                this.sectionField = value;
            }
        }

        [XmlAttribute("nullFlavor")]
        public string NullFlavor
        {
            get
            {
                return this.nullFlavorField;
            }
            set
            {
                this.nullFlavorField = value;
            }
        }

        [XmlAttribute("typeCode")]
        public ComponentTypeCodes TypeCode
        {
            get
            {
                return this.typeCodeField;
            }
            set
            {
                this.typeCodeField = value;
            }
        }

        [XmlIgnore()]
        public bool TypeCodeSpecified
        {
            get
            {
                return this.typeCodeFieldSpecified;
            }
            set
            {
                this.typeCodeFieldSpecified = value;
            }
        }

        [XmlAttribute("contextConductionInd")]
        public bool ContextConductionInd
        {
            get
            {
                return this.contextConductionIndField;
            }
            set
            {
                this.contextConductionIndField = value;
            }
        }

        [XmlIgnore()]
        public bool ContextConductionIndSpecified
        {
            get
            {
                return this.contextConductionIndFieldSpecified;
            }
            set
            {
                this.contextConductionIndFieldSpecified = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName = ".InfrastructureRoot.typeId", Namespace = "urn:hl7-org:v3")]
    public partial class InfrastructureRootTypeId : II
    {
    }

    [XmlIncludeAttribute(typeof(InfrastructureRootTypeId))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn:hl7-org:v3")]
    public partial class II : ANY
    {

        private string rootField;

        private string extensionField;

        private string assigningAuthorityNameField;

        private bool displayableField;

        private bool displayableFieldSpecified;

        [XmlAttribute("root")]
        public string Root
        {
            get
            {
                return this.rootField;
            }
            set
            {
                this.rootField = value;
            }
        }

        [XmlAttribute("extension")]
        public string Extension
        {
            get
            {
                return this.extensionField;
            }
            set
            {
                this.extensionField = value;
            }
        }

        [XmlAttribute("assigningAuthorityName")]
        public string AssigningAuthorityName
        {
            get
            {
                return this.assigningAuthorityNameField;
            }
            set
            {
                this.assigningAuthorityNameField = value;
            }
        }

        [XmlAttribute("displayable")]
        public bool Displayable
        {
            get
            {
                return this.displayableField;
            }
            set
            {
                this.displayableField = value;
            }
        }

        [XmlIgnore()]
        public bool DisplayableSpecified
        {
            get
            {
                return this.displayableFieldSpecified;
            }
            set
            {
                this.displayableFieldSpecified = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName = ".Section", Namespace = "urn:hl7-org:v3")]
    public partial class Section
    {

        private List<CS> realmCodeField;

        private InfrastructureRootTypeId typeIdField;

        private List<II> templateIdField;

        private II idField;

        private CE codeField;

        private ST titleField;

        private StrucDocText textField;

        private CE confidentialityCodeField;

        private CS languageCodeField;

        private Subject subjectField;

        private List<Author> authorField;

        private List<Informant12> informantField;

        private List<Entry> entryField;

        private List<Component5> componentField;

        private string idField1;

        private string nullFlavorField;

        private string classCodeField;

        private string moodCodeField;

        public Section()
        {
            this.classCodeField = "DOCSECT";
            this.moodCodeField = "EVN";
        }

        [XmlElement("realmCode")]
        public List<CS> RealmCodes
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.realmCodeField == null)
                    this.realmCodeField = new List<CS>();

                return this.realmCodeField;
            }
            set
            {
                this.realmCodeField = value;
            }
        }

        [XmlElement("typeId")]
        public InfrastructureRootTypeId TypeId
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.typeIdField == null)
                    this.typeIdField = new InfrastructureRootTypeId();

                return this.typeIdField;
            }
            set
            {
                this.typeIdField = value;
            }
        }

        [XmlElement("templateId")]
        public List<II> TemplateIds
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.templateIdField == null)
                    this.templateIdField = new List<II>();

                return this.templateIdField;
            }
            set
            {
                this.templateIdField = value;
            }
        }

        [XmlElement("id")]
        public II Id
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.idField == null)
                    this.idField = new II();

                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        [XmlElement("code")]
        public CE Code
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.codeField == null)
                    this.codeField = new CE();

                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }

        [XmlElement("title")]
        public ST Title
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.titleField == null)
                    this.titleField = new ST();

                return this.titleField;
            }
            set
            {
                this.titleField = value;
            }
        }

        [XmlElement("text")]
        public StrucDocText Text
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.textField == null)
                    this.textField = new StrucDocText();

                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }

        [XmlElement("confidentialityCode")]
        public CE ConfidentialityCode
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.confidentialityCodeField == null)
                    this.confidentialityCodeField = new CE();

                return this.confidentialityCodeField;
            }
            set
            {
                this.confidentialityCodeField = value;
            }
        }

        [XmlElement("languageCode")]
        public CS LanguageCode
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.languageCodeField == null)
                    this.languageCodeField = new CS();

                return this.languageCodeField;
            }
            set
            {
                this.languageCodeField = value;
            }
        }

        [XmlElement("subject")]
        public Subject Subject
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.subjectField == null)
                    this.subjectField = new Subject();

                return this.subjectField;
            }
            set
            {
                this.subjectField = value;
            }
        }

        [XmlElement("author")]
        public List<Author> Authors
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.authorField == null)
                    this.authorField = new List<Author>();

                return this.authorField;
            }
            set
            {
                this.authorField = value;
            }
        }

        [XmlElement("informant")]
        public List<Informant12> Informants
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.informantField == null)
                    this.informantField = new List<Informant12>();

                return this.informantField;
            }
            set
            {
                this.informantField = value;
            }
        }

        [XmlElement("entry")]
        public List<Entry> Entries
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.entryField == null)
                    this.entryField = new List<Entry>();

                return this.entryField;
            }
            set
            {
                this.entryField = value;
            }
        }

        [XmlElement("component")]
        public List<Component5> Components
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.componentField == null)
                    this.componentField = new List<Component5>();

                return this.componentField;
            }
            set
            {
                this.componentField = value;
            }
        }

        [XmlAttribute(AttributeName = "ID", DataType = "ID")]
        public string ReferenceId
        {
            get
            {
                return this.idField1;
            }
            set
            {
                this.idField1 = value;
            }
        }

        [XmlAttribute("nullFlavor")]
        public string NullFlavor
        {
            get
            {
                return this.nullFlavorField;
            }
            set
            {
                this.nullFlavorField = value;
            }
        }

        [XmlAttribute("classCode")]
        public string ClassCode
        {
            get
            {
                return this.classCodeField;
            }
            set
            {
                this.classCodeField = value;
            }
        }

        [XmlAttribute("moodCode")]
        public string MoodCode
        {
            get
            {
                return this.moodCodeField;
            }
            set
            {
                this.moodCodeField = value;
            }
        }
    }

    [XmlIncludeAttribute(typeof(ENXP))]
    [XmlIncludeAttribute(typeof(ensuffix))]
    [XmlIncludeAttribute(typeof(enprefix))]
    [XmlIncludeAttribute(typeof(engiven))]
    [XmlIncludeAttribute(typeof(enfamily))]
    [XmlIncludeAttribute(typeof(endelimiter))]
    [XmlIncludeAttribute(typeof(ADXP))]
    [XmlIncludeAttribute(typeof(adxpprecinct))]
    [XmlIncludeAttribute(typeof(adxppostBox))]
    [XmlIncludeAttribute(typeof(adxpbuildingNumberSuffix))]
    [XmlIncludeAttribute(typeof(adxpdeliveryModeIdentifier))]
    [XmlIncludeAttribute(typeof(adxpdeliveryMode))]
    [XmlIncludeAttribute(typeof(adxpdeliveryInstallationQualifier))]
    [XmlIncludeAttribute(typeof(adxpdeliveryInstallationArea))]
    [XmlIncludeAttribute(typeof(adxpdeliveryInstallationType))]
    [XmlIncludeAttribute(typeof(adxpdeliveryAddressLine))]
    [XmlIncludeAttribute(typeof(adxpcensusTract))]
    [XmlIncludeAttribute(typeof(adxpcareOf))]
    [XmlIncludeAttribute(typeof(adxpunitType))]
    [XmlIncludeAttribute(typeof(adxpunitID))]
    [XmlIncludeAttribute(typeof(adxpadditionalLocator))]
    [XmlIncludeAttribute(typeof(adxpstreetNameType))]
    [XmlIncludeAttribute(typeof(adxpstreetNameBase))]
    [XmlIncludeAttribute(typeof(adxpstreetName))]
    [XmlIncludeAttribute(typeof(adxpdirection))]
    [XmlIncludeAttribute(typeof(adxphouseNumberNumeric))]
    [XmlIncludeAttribute(typeof(adxphouseNumber))]
    [XmlIncludeAttribute(typeof(adxpstreetAddressLine))]
    [XmlIncludeAttribute(typeof(adxppostalCode))]
    [XmlIncludeAttribute(typeof(adxpcity))]
    [XmlIncludeAttribute(typeof(adxpcounty))]
    [XmlIncludeAttribute(typeof(adxpstate))]
    [XmlIncludeAttribute(typeof(adxpcountry))]
    [XmlIncludeAttribute(typeof(adxpdelimiter))]
    [XmlIncludeAttribute(typeof(SC))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn:hl7-org:v3")]
    public partial class ST : ED
    {
    }

    [XmlIncludeAttribute(typeof(ensuffix))]
    [XmlIncludeAttribute(typeof(enprefix))]
    [XmlIncludeAttribute(typeof(engiven))]
    [XmlIncludeAttribute(typeof(enfamily))]
    [XmlIncludeAttribute(typeof(endelimiter))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn:hl7-org:v3")]
    public partial class ENXP : ST
    {

        private string partTypeField;

        private string[] qualifierField;

        [XmlAttribute("partType")]
        public string PartType
        {
            get
            {
                return this.partTypeField;
            }
            set
            {
                this.partTypeField = value;
            }
        }

        [XmlAttribute("qualifier")]
        public string[] Qualifiers
        {
            get
            {
                return this.qualifierField;
            }
            set
            {
                this.qualifierField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName = "en.suffix", Namespace = "urn:hl7-org:v3")]
    public partial class ensuffix : ENXP
    {
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName = "en.prefix", Namespace = "urn:hl7-org:v3")]
    public partial class enprefix : ENXP
    {
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName = "en.given", Namespace = "urn:hl7-org:v3")]
    public partial class engiven : ENXP
    {
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName = "en.family", Namespace = "urn:hl7-org:v3")]
    public partial class enfamily : ENXP
    {
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName = "en.delimiter", Namespace = "urn:hl7-org:v3")]
    public partial class endelimiter : ENXP
    {
    }

    [XmlIncludeAttribute(typeof(adxpprecinct))]
    [XmlIncludeAttribute(typeof(adxppostBox))]
    [XmlIncludeAttribute(typeof(adxpbuildingNumberSuffix))]
    [XmlIncludeAttribute(typeof(adxpdeliveryModeIdentifier))]
    [XmlIncludeAttribute(typeof(adxpdeliveryMode))]
    [XmlIncludeAttribute(typeof(adxpdeliveryInstallationQualifier))]
    [XmlIncludeAttribute(typeof(adxpdeliveryInstallationArea))]
    [XmlIncludeAttribute(typeof(adxpdeliveryInstallationType))]
    [XmlIncludeAttribute(typeof(adxpdeliveryAddressLine))]
    [XmlIncludeAttribute(typeof(adxpcensusTract))]
    [XmlIncludeAttribute(typeof(adxpcareOf))]
    [XmlIncludeAttribute(typeof(adxpunitType))]
    [XmlIncludeAttribute(typeof(adxpunitID))]
    [XmlIncludeAttribute(typeof(adxpadditionalLocator))]
    [XmlIncludeAttribute(typeof(adxpstreetNameType))]
    [XmlIncludeAttribute(typeof(adxpstreetNameBase))]
    [XmlIncludeAttribute(typeof(adxpstreetName))]
    [XmlIncludeAttribute(typeof(adxpdirection))]
    [XmlIncludeAttribute(typeof(adxphouseNumberNumeric))]
    [XmlIncludeAttribute(typeof(adxphouseNumber))]
    [XmlIncludeAttribute(typeof(adxpstreetAddressLine))]
    [XmlIncludeAttribute(typeof(adxppostalCode))]
    [XmlIncludeAttribute(typeof(adxpcity))]
    [XmlIncludeAttribute(typeof(adxpcounty))]
    [XmlIncludeAttribute(typeof(adxpstate))]
    [XmlIncludeAttribute(typeof(adxpcountry))]
    [XmlIncludeAttribute(typeof(adxpdelimiter))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn:hl7-org:v3")]
    public partial class ADXP : ST
    {

        private string partTypeField;

        [XmlAttribute("partType")]
        public string PartType
        {
            get
            {
                return this.partTypeField;
            }
            set
            {
                this.partTypeField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName = "adxp.precinct", Namespace = "urn:hl7-org:v3")]
    public partial class adxpprecinct : ADXP
    {
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName = "adxp.postBox", Namespace = "urn:hl7-org:v3")]
    public partial class adxppostBox : ADXP
    {
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName = "adxp.buildingNumberSuffix", Namespace = "urn:hl7-org:v3")]
    public partial class adxpbuildingNumberSuffix : ADXP
    {
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName = "adxp.deliveryModeIdentifier", Namespace = "urn:hl7-org:v3")]
    public partial class adxpdeliveryModeIdentifier : ADXP
    {
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName = "adxp.deliveryMode", Namespace = "urn:hl7-org:v3")]
    public partial class adxpdeliveryMode : ADXP
    {
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName = "adxp.deliveryInstallationQualifier", Namespace = "urn:hl7-org:v3")]
    public partial class adxpdeliveryInstallationQualifier : ADXP
    {
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName = "adxp.deliveryInstallationArea", Namespace = "urn:hl7-org:v3")]
    public partial class adxpdeliveryInstallationArea : ADXP
    {
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName = "adxp.deliveryInstallationType", Namespace = "urn:hl7-org:v3")]
    public partial class adxpdeliveryInstallationType : ADXP
    {
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName = "adxp.deliveryAddressLine", Namespace = "urn:hl7-org:v3")]
    public partial class adxpdeliveryAddressLine : ADXP
    {
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName = "adxp.censusTract", Namespace = "urn:hl7-org:v3")]
    public partial class adxpcensusTract : ADXP
    {
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName = "adxp.careOf", Namespace = "urn:hl7-org:v3")]
    public partial class adxpcareOf : ADXP
    {
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName = "adxp.unitType", Namespace = "urn:hl7-org:v3")]
    public partial class adxpunitType : ADXP
    {
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName = "adxp.unitID", Namespace = "urn:hl7-org:v3")]
    public partial class adxpunitID : ADXP
    {
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName = "adxp.additionalLocator", Namespace = "urn:hl7-org:v3")]
    public partial class adxpadditionalLocator : ADXP
    {
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName = "adxp.streetNameType", Namespace = "urn:hl7-org:v3")]
    public partial class adxpstreetNameType : ADXP
    {
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName = "adxp.streetNameBase", Namespace = "urn:hl7-org:v3")]
    public partial class adxpstreetNameBase : ADXP
    {
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName = "adxp.streetName", Namespace = "urn:hl7-org:v3")]
    public partial class adxpstreetName : ADXP
    {
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName = "adxp.direction", Namespace = "urn:hl7-org:v3")]
    public partial class adxpdirection : ADXP
    {
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName = "adxp.houseNumberNumeric", Namespace = "urn:hl7-org:v3")]
    public partial class adxphouseNumberNumeric : ADXP
    {
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName = "adxp.houseNumber", Namespace = "urn:hl7-org:v3")]
    public partial class adxphouseNumber : ADXP
    {
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName = "adxp.streetAddressLine", Namespace = "urn:hl7-org:v3")]
    public partial class adxpstreetAddressLine : ADXP
    {
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName = "adxp.postalCode", Namespace = "urn:hl7-org:v3")]
    public partial class adxppostalCode : ADXP
    {
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName = "adxp.city", Namespace = "urn:hl7-org:v3")]
    public partial class adxpcity : ADXP
    {
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName = "adxp.county", Namespace = "urn:hl7-org:v3")]
    public partial class adxpcounty : ADXP
    {
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName = "adxp.state", Namespace = "urn:hl7-org:v3")]
    public partial class adxpstate : ADXP
    {
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName = "adxp.country", Namespace = "urn:hl7-org:v3")]
    public partial class adxpcountry : ADXP
    {
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName = "adxp.delimiter", Namespace = "urn:hl7-org:v3")]
    public partial class adxpdelimiter : ADXP
    {
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn:hl7-org:v3")]
    public partial class SC : ST
    {

        private string codeField;

        private string codeSystemField;

        private string codeSystemNameField;

        private string codeSystemVersionField;

        private string displayNameField;

        [XmlAttribute(AttributeName = "code", DataType = "token")]
        public string Code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }

        [XmlAttribute("codeSystem")]
        public string CodeSystem
        {
            get
            {
                return this.codeSystemField;
            }
            set
            {
                this.codeSystemField = value;
            }
        }

        [XmlAttribute("codeSystemName")]
        public string CodeSystemName
        {
            get
            {
                return this.codeSystemNameField;
            }
            set
            {
                this.codeSystemNameField = value;
            }
        }

        [XmlAttribute("codeSystemVersion")]
        public string CodeSystemVersion
        {
            get
            {
                return this.codeSystemVersionField;
            }
            set
            {
                this.codeSystemVersionField = value;
            }
        }

        [XmlAttribute("displayName")]
        public string DisplayName
        {
            get
            {
                return this.displayNameField;
            }
            set
            {
                this.displayNameField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName = ".Subject", Namespace = "urn:hl7-org:v3")]
    public partial class Subject
    {

        private List<CS> realmCodeField;

        private InfrastructureRootTypeId typeIdField;

        private List<II> templateIdField;

        private CE awarenessCodeField;

        private RelatedSubject relatedSubjectField;

        private string nullFlavorField;

        private SubjectTypeCodes typeCodeField;

        private bool typeCodeFieldSpecified;

        private string contextControlCodeField;

        public Subject()
        {
            this.typeCodeField = SubjectTypeCodes.SBJ;
            this.contextControlCodeField = "OP";
        }

        [XmlElement("realmCode")]
        public List<CS> RealmCodes
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.realmCodeField == null)
                    this.realmCodeField = new List<CS>();

                return this.realmCodeField;
            }
            set
            {
                this.realmCodeField = value;
            }
        }

        [XmlElement("typeId")]
        public InfrastructureRootTypeId TypeId
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.typeIdField == null)
                    this.typeIdField = new InfrastructureRootTypeId();

                return this.typeIdField;
            }
            set
            {
                this.typeIdField = value;
            }
        }

        [XmlElement("templateId")]
        public List<II> TemplateIds
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.templateIdField == null)
                    this.templateIdField = new List<II>();

                return this.templateIdField;
            }
            set
            {
                this.templateIdField = value;
            }
        }

        [XmlElement("awarenessCode")]
        public CE AwarenessCode
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.awarenessCodeField == null)
                    this.awarenessCodeField = new CE();

                return this.awarenessCodeField;
            }
            set
            {
                this.awarenessCodeField = value;
            }
        }

        [XmlElement("relatedSubject")]
        public RelatedSubject RelatedSubject
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.relatedSubjectField == null)
                    this.relatedSubjectField = new RelatedSubject();

                return this.relatedSubjectField;
            }
            set
            {
                this.relatedSubjectField = value;
            }
        }

        [XmlAttribute("nullFlavor")]
        public string NullFlavor
        {
            get
            {
                return this.nullFlavorField;
            }
            set
            {
                this.nullFlavorField = value;
            }
        }

        [XmlAttribute("typeCode")]
        public SubjectTypeCodes TypeCode
        {
            get
            {
                return this.typeCodeField;
            }
            set
            {
                this.typeCodeField = value;
            }
        }

        [XmlIgnore()]
        public bool TypeCodeSpecified
        {
            get
            {
                return this.typeCodeFieldSpecified;
            }
            set
            {
                this.typeCodeFieldSpecified = value;
            }
        }

        [XmlAttribute("contextControlCode")]
        public string ContextControlCode
        {
            get
            {
                return this.contextControlCodeField;
            }
            set
            {
                this.contextControlCodeField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName = ".RelatedSubject", Namespace = "urn:hl7-org:v3")]
    public partial class RelatedSubject
    {

        private List<CS> realmCodeField;

        private InfrastructureRootTypeId typeIdField;

        private List<II> templateIdField;

        private CE codeField;

        private List<AD> addrField;

        private List<TEL> telecomField;

        private SubjectPerson subjectField;

        private string nullFlavorField;

        private RelatedSubjectClassCodes classCodeField;

        public RelatedSubject()
        {
            this.classCodeField = RelatedSubjectClassCodes.PRS;
        }

        [XmlElement("realmCode")]
        public List<CS> RealmCodes
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.realmCodeField == null)
                    this.realmCodeField = new List<CS>();

                return this.realmCodeField;
            }
            set
            {
                this.realmCodeField = value;
            }
        }

        [XmlElement("typeId")]
        public InfrastructureRootTypeId TypeId
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.typeIdField == null)
                    this.typeIdField = new InfrastructureRootTypeId();

                return this.typeIdField;
            }
            set
            {
                this.typeIdField = value;
            }
        }

        [XmlElement("templateId")]
        public List<II> TemplateIds
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.templateIdField == null)
                    this.templateIdField = new List<II>();

                return this.templateIdField;
            }
            set
            {
                this.templateIdField = value;
            }
        }

        [XmlElement("code")]
        public CE Code
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.codeField == null)
                    this.codeField = new CE();

                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }

        [XmlElement("addr")]
        public List<AD> Address
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.addrField == null)
                    this.addrField = new List<AD>();

                return this.addrField;
            }
            set
            {
                this.addrField = value;
            }
        }

        [XmlElement("telecom")]
        public List<TEL> Telephone
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.telecomField == null)
                    this.telecomField = new List<TEL>();

                return this.telecomField;
            }
            set
            {
                this.telecomField = value;
            }
        }

        [XmlElement("subject")]
        public SubjectPerson Subject
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.subjectField == null)
                    this.subjectField = new SubjectPerson();

                return this.subjectField;
            }
            set
            {
                this.subjectField = value;
            }
        }

        [XmlAttribute("nullFlavor")]
        public string NullFlavor
        {
            get
            {
                return this.nullFlavorField;
            }
            set
            {
                this.nullFlavorField = value;
            }
        }

        [XmlAttribute("classCode")]
        [System.ComponentModel.DefaultValueAttribute(RelatedSubjectClassCodes.PRS)]
        public RelatedSubjectClassCodes ClassCode
        {
            get
            {
                return this.classCodeField;
            }
            set
            {
                this.classCodeField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn:hl7-org:v3")]
    public partial class AD : ANY
    {

        private ADXP[] itemsField;

        private SXCM_TS[] useablePeriodField;

        private string[] textField;

        private string[] useField;

        private bool isNotOrderedField;

        private bool isNotOrderedFieldSpecified;

        [XmlElement("additionalLocator", typeof(adxpadditionalLocator))]
        [XmlElement("buildingNumberSuffix", typeof(adxpbuildingNumberSuffix))]
        [XmlElement("careOf", typeof(adxpcareOf))]
        [XmlElement("censusTract", typeof(adxpcensusTract))]
        [XmlElement("city", typeof(adxpcity))]
        [XmlElement("country", typeof(adxpcountry))]
        [XmlElement("county", typeof(adxpcounty))]
        [XmlElement("delimiter", typeof(adxpdelimiter))]
        [XmlElement("deliveryAddressLine", typeof(adxpdeliveryAddressLine))]
        [XmlElement("deliveryInstallationArea", typeof(adxpdeliveryInstallationArea))]
        [XmlElement("deliveryInstallationQualifier", typeof(adxpdeliveryInstallationQualifier))]
        [XmlElement("deliveryInstallationType", typeof(adxpdeliveryInstallationType))]
        [XmlElement("deliveryMode", typeof(adxpdeliveryMode))]
        [XmlElement("deliveryModeIdentifier", typeof(adxpdeliveryModeIdentifier))]
        [XmlElement("direction", typeof(adxpdirection))]
        [XmlElement("houseNumber", typeof(adxphouseNumber))]
        [XmlElement("houseNumberNumeric", typeof(adxphouseNumberNumeric))]
        [XmlElement("postBox", typeof(adxppostBox))]
        [XmlElement("postalCode", typeof(adxppostalCode))]
        [XmlElement("precinct", typeof(adxpprecinct))]
        [XmlElement("state", typeof(adxpstate))]
        [XmlElement("streetAddressLine", typeof(adxpstreetAddressLine))]
        [XmlElement("streetName", typeof(adxpstreetName))]
        [XmlElement("streetNameBase", typeof(adxpstreetNameBase))]
        [XmlElement("streetNameType", typeof(adxpstreetNameType))]
        [XmlElement("unitID", typeof(adxpunitID))]
        [XmlElement("unitType", typeof(adxpunitType))]
        public ADXP[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        [XmlElement("useablePeriod")]
        public SXCM_TS[] UseablePeriod
        {
            get
            {
                return this.useablePeriodField;
            }
            set
            {
                this.useablePeriodField = value;
            }
        }

        [XmlTextAttribute()]
        public string[] Text
        {
            get
            {
                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }

        [XmlAttribute("use")]
        public string[] Use
        {
            get
            {
                return this.useField;
            }
            set
            {
                this.useField = value;
            }
        }

        [XmlAttribute("isNotOrdered")]
        public bool IsNotOrdered
        {
            get
            {
                return this.isNotOrderedField;
            }
            set
            {
                this.isNotOrderedField = value;
            }
        }

        [XmlIgnore()]
        public bool IsNotOrderedSpecified
        {
            get
            {
                return this.isNotOrderedFieldSpecified;
            }
            set
            {
                this.isNotOrderedFieldSpecified = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName = ".SubjectPerson", Namespace = "urn:hl7-org:v3")]
    public partial class SubjectPerson
    {

        private List<CS> realmCodeField;

        private InfrastructureRootTypeId typeIdField;

        private List<II> templateIdField;

        private List<PN> nameField;

        private CE administrativeGenderCodeField;

        private TS birthTimeField;

        private string nullFlavorField;

        private string classCodeField;

        private string determinerCodeField;

        public SubjectPerson()
        {
            this.classCodeField = "PSN";
            this.determinerCodeField = "INSTANCE";
        }

        [XmlElement("realmCode")]
        public List<CS> RealmCodes
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.realmCodeField == null)
                    this.realmCodeField = new List<CS>();

                return this.realmCodeField;
            }
            set
            {
                this.realmCodeField = value;
            }
        }

        [XmlElement("typeId")]
        public InfrastructureRootTypeId TypeId
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.typeIdField == null)
                    this.typeIdField = new InfrastructureRootTypeId();

                return this.typeIdField;
            }
            set
            {
                this.typeIdField = value;
            }
        }

        [XmlElement("templateId")]
        public List<II> TemplateIds
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.templateIdField == null)
                    this.templateIdField = new List<II>();

                return this.templateIdField;
            }
            set
            {
                this.templateIdField = value;
            }
        }

        [XmlElement("name")]
        public List<PN> Names
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.nameField == null)
                    this.nameField = new List<PN>();

                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        [XmlElement("administrativeGenderCode")]
        public CE AdministrativeGenderCode
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.administrativeGenderCodeField == null)
                    this.administrativeGenderCodeField = new CE();

                return this.administrativeGenderCodeField;
            }
            set
            {
                this.administrativeGenderCodeField = value;
            }
        }

        [XmlElement("birthTime")]
        public TS BirthTime
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.birthTimeField == null)
                    this.birthTimeField = new TS();

                return this.birthTimeField;
            }
            set
            {
                this.birthTimeField = value;
            }
        }

        [XmlAttribute("nullFlavor")]
        public string NullFlavor
        {
            get
            {
                return this.nullFlavorField;
            }
            set
            {
                this.nullFlavorField = value;
            }
        }

        [XmlAttribute("classCode")]
        public string ClassCode
        {
            get
            {
                return this.classCodeField;
            }
            set
            {
                this.classCodeField = value;
            }
        }

        [XmlAttribute("determinerCode")]
        public string DeterminerCode
        {
            get
            {
                return this.determinerCodeField;
            }
            set
            {
                this.determinerCodeField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn:hl7-org:v3")]
    public partial class PN : EN
    {
    }

    [XmlIncludeAttribute(typeof(TN))]
    [XmlIncludeAttribute(typeof(ON))]
    [XmlIncludeAttribute(typeof(PN))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn:hl7-org:v3")]
    public partial class EN : ANY
    {

        private ENXP[] itemsField;

        private IVL_TS validTimeField;

        private string[] textField;

        private string[] useField;

        [XmlElement("delimiter", typeof(endelimiter))]
        [XmlElement("family", typeof(enfamily))]
        [XmlElement("given", typeof(engiven))]
        [XmlElement("prefix", typeof(enprefix))]
        [XmlElement("suffix", typeof(ensuffix))]
        public ENXP[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        [XmlElement("validTime")]
        public IVL_TS ValidTime
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.validTimeField == null)
                    this.validTimeField = new IVL_TS();

                return this.validTimeField;
            }
            set
            {
                this.validTimeField = value;
            }
        }

        [XmlTextAttribute()]
        public string[] Text
        {
            get
            {
                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }

        [XmlAttribute("use")]
        public string[] Use
        {
            get
            {
                return this.useField;
            }
            set
            {
                this.useField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn:hl7-org:v3")]
    public partial class IVL_TS : SXCM_TS
    {

        private QTY[] itemsField;

        private ItemsChoiceType[] itemsElementNameField;

        [XmlElement("center", typeof(TS))]
        [XmlElement("high", typeof(IVXB_TS))]
        [XmlElement("low", typeof(IVXB_TS))]
        [XmlElement("width", typeof(PQ))]
        [XmlChoiceIdentifierAttribute("ItemsElementName")]
        public QTY[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        [XmlElement("ItemsElementName")]
        [XmlIgnore()]
        public ItemsChoiceType[] ItemsElementName
        {
            get
            {
                return this.itemsElementNameField;
            }
            set
            {
                this.itemsElementNameField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn:hl7-org:v3")]
    public partial class IVXB_TS : TS
    {

        private bool inclusiveField;

        public IVXB_TS()
        {
            this.inclusiveField = true;
        }

        [XmlAttribute("inclusive")]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool Inclusive
        {
            get
            {
                return this.inclusiveField;
            }
            set
            {
                this.inclusiveField = value;
            }
        }
    }

    [XmlIncludeAttribute(typeof(HXIT_PQ))]
    [XmlIncludeAttribute(typeof(PPD_PQ))]
    [XmlIncludeAttribute(typeof(IVXB_PPD_PQ))]
    [XmlIncludeAttribute(typeof(SXCM_PPD_PQ))]
    [XmlIncludeAttribute(typeof(IVL_PPD_PQ))]
    [XmlIncludeAttribute(typeof(IVXB_PQ))]
    [XmlIncludeAttribute(typeof(SXCM_PQ))]
    [XmlIncludeAttribute(typeof(IVL_PQ))]
    [XmlIncludeAttribute(typeof(BXIT_IVL_PQ))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn:hl7-org:v3")]
    public partial class PQ : QTY
    {

        private List<PQR> translationField;

        private string valueField;

        private string unitField;

        public PQ()
        {
            this.unitField = "1";
        }

        [XmlElement("translation")]
        public List<PQR> Translations
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.translationField == null)
                    this.translationField = new List<PQR>();

                return this.translationField;
            }
            set
            {
                this.translationField = value;
            }
        }

        [XmlAttribute("value")]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }

        [XmlAttribute(AttributeName = "unit", DataType = "token")]
        [System.ComponentModel.DefaultValueAttribute("1")]
        public string Unit
        {
            get
            {
                return this.unitField;
            }
            set
            {
                this.unitField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn:hl7-org:v3")]
    public partial class PQR : CV
    {

        private string valueField;

        [XmlAttribute("value")]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn:hl7-org:v3")]
    public partial class HXIT_PQ : PQ
    {

        private IVL_TS validTimeField;

        [XmlElement("validTime")]
        public IVL_TS ValidTime
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.validTimeField == null)
                    this.validTimeField = new IVL_TS();

                return this.validTimeField;
            }
            set
            {
                this.validTimeField = value;
            }
        }
    }

    [XmlIncludeAttribute(typeof(IVXB_PPD_PQ))]
    [XmlIncludeAttribute(typeof(SXCM_PPD_PQ))]
    [XmlIncludeAttribute(typeof(IVL_PPD_PQ))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn:hl7-org:v3")]
    public partial class PPD_PQ : PQ
    {

        private PQ standardDeviationField;

        private DistributionTypes distributionTypeField;

        private bool distributionTypeFieldSpecified;

        [XmlElement("standardDeviation")]
        public PQ StandardDeviation
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.standardDeviationField == null)
                    this.standardDeviationField = new PQ();

                return this.standardDeviationField;
            }
            set
            {
                this.standardDeviationField = value;
            }
        }

        [XmlAttribute("distributionType")]
        public DistributionTypes DistributionType
        {
            get
            {
                return this.distributionTypeField;
            }
            set
            {
                this.distributionTypeField = value;
            }
        }

        [XmlIgnore()]
        public bool DistributionTypeSpecified
        {
            get
            {
                return this.distributionTypeFieldSpecified;
            }
            set
            {
                this.distributionTypeFieldSpecified = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn:hl7-org:v3")]
    public partial class IVXB_PPD_PQ : PPD_PQ
    {

        private bool inclusiveField;

        public IVXB_PPD_PQ()
        {
            this.inclusiveField = true;
        }

        [XmlAttribute("inclusive")]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool Inclusive
        {
            get
            {
                return this.inclusiveField;
            }
            set
            {
                this.inclusiveField = value;
            }
        }
    }

    [XmlIncludeAttribute(typeof(IVL_PPD_PQ))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn:hl7-org:v3")]
    public partial class SXCM_PPD_PQ : PPD_PQ
    {

        private Operators operatorField;

        public SXCM_PPD_PQ()
        {
            this.operatorField = Operators.I;
        }

        [XmlAttribute("operator")]
        [System.ComponentModel.DefaultValueAttribute(Operators.I)]
        public Operators Operator
        {
            get
            {
                return this.operatorField;
            }
            set
            {
                this.operatorField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn:hl7-org:v3")]
    public partial class IVL_PPD_PQ : SXCM_PPD_PQ
    {

        private PPD_PQ[] itemsField;

        private ItemsChoiceType[] itemsElementNameField;

        [XmlElement("center", typeof(PPD_PQ))]
        [XmlElement("high", typeof(IVXB_PPD_PQ))]
        [XmlElement("low", typeof(IVXB_PPD_PQ))]
        [XmlElement("width", typeof(PPD_PQ))]
        [XmlChoiceIdentifierAttribute("ItemsElementName")]
        public PPD_PQ[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        [XmlElement("ItemsElementName")]
        [XmlIgnore()]
        public ItemsChoiceType[] ItemsElementName
        {
            get
            {
                return this.itemsElementNameField;
            }
            set
            {
                this.itemsElementNameField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn:hl7-org:v3")]
    public partial class IVXB_PQ : PQ
    {

        private bool inclusiveField;

        public IVXB_PQ()
        {
            this.inclusiveField = true;
        }

        [XmlAttribute("inclusive")]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool Inclusive
        {
            get
            {
                return this.inclusiveField;
            }
            set
            {
                this.inclusiveField = value;
            }
        }
    }

    [XmlIncludeAttribute(typeof(IVL_PQ))]
    [XmlIncludeAttribute(typeof(BXIT_IVL_PQ))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn:hl7-org:v3")]
    public partial class SXCM_PQ : PQ
    {

        private Operators operatorField;

        public SXCM_PQ()
        {
            this.operatorField = Operators.I;
        }

        [XmlAttribute("operator")]
        [System.ComponentModel.DefaultValueAttribute(Operators.I)]
        public Operators Operator
        {
            get
            {
                return this.operatorField;
            }
            set
            {
                this.operatorField = value;
            }
        }
    }

    [XmlIncludeAttribute(typeof(BXIT_IVL_PQ))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn:hl7-org:v3")]
    public partial class IVL_PQ : SXCM_PQ
    {

        private PQ[] itemsField;

        private ItemsChoiceType[] itemsElementNameField;

        [XmlElement("center", typeof(PQ))]
        [XmlElement("high", typeof(IVXB_PQ))]
        [XmlElement("low", typeof(IVXB_PQ))]
        [XmlElement("width", typeof(PQ))]
        [XmlChoiceIdentifierAttribute("ItemsElementName")]
        public PQ[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        [XmlElement("ItemsElementName")]
        [XmlIgnore()]
        public ItemsChoiceType[] ItemsElementName
        {
            get
            {
                return this.itemsElementNameField;
            }
            set
            {
                this.itemsElementNameField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn:hl7-org:v3")]
    public partial class BXIT_IVL_PQ : IVL_PQ
    {

        private string qtyField;

        public BXIT_IVL_PQ()
        {
            this.qtyField = "1";
        }

        [XmlAttribute(AttributeName = "qty", DataType = "integer")]
        [System.ComponentModel.DefaultValueAttribute("1")]
        public string QuantityInteger
        {
            get
            {
                return this.qtyField;
            }
            set
            {
                this.qtyField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn:hl7-org:v3")]
    public partial class TN : EN
    {
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn:hl7-org:v3")]
    public partial class ON : EN
    {
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName = ".Author", Namespace = "urn:hl7-org:v3")]
    public partial class Author
    {

        private List<CS> realmCodeField;

        private InfrastructureRootTypeId typeIdField;

        private List<II> templateIdField;

        private CE functionCodeField;

        private TS timeField;

        private AssignedAuthor assignedAuthorField;

        private string nullFlavorField;

        private string typeCodeField;

        private string contextControlCodeField;

        public Author()
        {
            this.typeCodeField = "AUT";
            this.contextControlCodeField = "OP";
        }

        [XmlElement("realmCode")]
        public List<CS> RealmCodes
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.realmCodeField == null)
                    this.realmCodeField = new List<CS>();

                return this.realmCodeField;
            }
            set
            {
                this.realmCodeField = value;
            }
        }

        [XmlElement("typeId")]
        public InfrastructureRootTypeId TypeId
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.typeIdField == null)
                    this.typeIdField = new InfrastructureRootTypeId();

                return this.typeIdField;
            }
            set
            {
                this.typeIdField = value;
            }
        }

        [XmlElement("templateId")]
        public List<II> TemplateIds
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.templateIdField == null)
                    this.templateIdField = new List<II>();

                return this.templateIdField;
            }
            set
            {
                this.templateIdField = value;
            }
        }

        [XmlElement("functionCode")]
        public CE FunctionCode
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.functionCodeField == null)
                    this.functionCodeField = new CE();

                return this.functionCodeField;
            }
            set
            {
                this.functionCodeField = value;
            }
        }

        [XmlElement("time")]
        public TS Time
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.timeField == null)
                    this.timeField = new TS();

                return this.timeField;
            }
            set
            {
                this.timeField = value;
            }
        }

        [XmlElement("assignedAuthor")]
        public AssignedAuthor AssignedAuthor
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.assignedAuthorField == null)
                    this.assignedAuthorField = new AssignedAuthor();

                return this.assignedAuthorField;
            }
            set
            {
                this.assignedAuthorField = value;
            }
        }

        [XmlAttribute("nullFlavor")]
        public string NullFlavor
        {
            get
            {
                return this.nullFlavorField;
            }
            set
            {
                this.nullFlavorField = value;
            }
        }

        [XmlAttribute("typeCode")]
        public string TypeCode
        {
            get
            {
                return this.typeCodeField;
            }
            set
            {
                this.typeCodeField = value;
            }
        }

        [XmlAttribute("contextControlCode")]
        public string ContextControlCode
        {
            get
            {
                return this.contextControlCodeField;
            }
            set
            {
                this.contextControlCodeField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName = ".AssignedAuthor", Namespace = "urn:hl7-org:v3")]
    public partial class AssignedAuthor
    {

        private List<CS> realmCodeField;

        private InfrastructureRootTypeId typeIdField;

        private List<II> templateIdField;

        private List<II> idField;

        private CE codeField;

        private List<AD> addrField;

        private List<TEL> telecomField;

        private object itemField;

        private Organization representedOrganizationField;

        private string nullFlavorField;

        private string classCodeField;

        public AssignedAuthor()
        {
            this.classCodeField = "ASSIGNED";
        }

        [XmlElement("realmCode")]
        public List<CS> RealmCodes
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.realmCodeField == null)
                    this.realmCodeField = new List<CS>();

                return this.realmCodeField;
            }
            set
            {
                this.realmCodeField = value;
            }
        }

        [XmlElement("typeId")]
        public InfrastructureRootTypeId TypeId
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.typeIdField == null)
                    this.typeIdField = new InfrastructureRootTypeId();

                return this.typeIdField;
            }
            set
            {
                this.typeIdField = value;
            }
        }

        [XmlElement("templateId")]
        public List<II> TemplateIds
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.templateIdField == null)
                    this.templateIdField = new List<II>();

                return this.templateIdField;
            }
            set
            {
                this.templateIdField = value;
            }
        }

        [XmlElement("id")]
        public List<II> Ids
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.idField == null)
                    this.idField = new List<II>();

                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        [XmlElement("code")]
        public CE Code
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.codeField == null)
                    this.codeField = new CE();

                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }

        [XmlElement("addr")]
        public List<AD> Addr
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.addrField == null)
                    this.addrField = new List<AD>();

                return this.addrField;
            }
            set
            {
                this.addrField = value;
            }
        }

        [XmlElement("telecom")]
        public List<TEL> Telecom
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.telecomField == null)
                    this.telecomField = new List<TEL>();

                return this.telecomField;
            }
            set
            {
                this.telecomField = value;
            }
        }

        [XmlElement("assignedAuthoringDevice", typeof(AuthoringDevice))]
        [XmlElement("assignedPerson", typeof(Person))]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        [XmlElement("representedOrganization")]
        public Organization RepresentedOrganization
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.representedOrganizationField == null)
                    this.representedOrganizationField = new Organization();

                return this.representedOrganizationField;
            }
            set
            {
                this.representedOrganizationField = value;
            }
        }

        [XmlAttribute("nullFlavor")]
        public string NullFlavor
        {
            get
            {
                return this.nullFlavorField;
            }
            set
            {
                this.nullFlavorField = value;
            }
        }

        [XmlAttribute("classCode")]
        public string ClassCode
        {
            get
            {
                return this.classCodeField;
            }
            set
            {
                this.classCodeField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName = ".AuthoringDevice", Namespace = "urn:hl7-org:v3")]
    public partial class AuthoringDevice
    {

        private List<CS> realmCodeField;

        private InfrastructureRootTypeId typeIdField;

        private List<II> templateIdField;

        private CE codeField;

        private SC manufacturerModelNameField;

        private SC softwareNameField;

        private List<MaintainedEntity> asMaintainedEntityField;

        private string nullFlavorField;

        private DeviceClassCodes classCodeField;

        private bool classCodeFieldSpecified;

        private string determinerCodeField;

        public AuthoringDevice()
        {
            this.classCodeField = DeviceClassCodes.DEV;
            this.determinerCodeField = "INSTANCE";
        }

        [XmlElement("realmCode")]
        public List<CS> RealmCodes
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.realmCodeField == null)
                    this.realmCodeField = new List<CS>();

                return this.realmCodeField;
            }
            set
            {
                this.realmCodeField = value;
            }
        }

        [XmlElement("typeId")]
        public InfrastructureRootTypeId TypeId
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.typeIdField == null)
                    this.typeIdField = new InfrastructureRootTypeId();

                return this.typeIdField;
            }
            set
            {
                this.typeIdField = value;
            }
        }

        [XmlElement("templateId")]
        public List<II> TemplateIds
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.templateIdField == null)
                    this.templateIdField = new List<II>();

                return this.templateIdField;
            }
            set
            {
                this.templateIdField = value;
            }
        }

        [XmlElement("code")]
        public CE Code
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.codeField == null)
                    this.codeField = new CE();

                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }

        [XmlElement("manufacturerModelName")]
        public SC ManufacturerModelName
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.manufacturerModelNameField == null)
                    this.manufacturerModelNameField = new SC();

                return this.manufacturerModelNameField;
            }
            set
            {
                this.manufacturerModelNameField = value;
            }
        }

        [XmlElement("softwareName")]
        public SC SoftwareName
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.softwareNameField == null)
                    this.softwareNameField = new SC();

                return this.softwareNameField;
            }
            set
            {
                this.softwareNameField = value;
            }
        }

        [XmlElement("asMaintainedEntity")]
        public List<MaintainedEntity> AsMaintainedEntity
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.asMaintainedEntityField == null)
                    this.asMaintainedEntityField = new List<MaintainedEntity>();

                return this.asMaintainedEntityField;
            }
            set
            {
                this.asMaintainedEntityField = value;
            }
        }

        [XmlAttribute("nullFlavor")]
        public string NullFlavor
        {
            get
            {
                return this.nullFlavorField;
            }
            set
            {
                this.nullFlavorField = value;
            }
        }

        [XmlAttribute("classCode")]
        public DeviceClassCodes ClassCode
        {
            get
            {
                return this.classCodeField;
            }
            set
            {
                this.classCodeField = value;
            }
        }

        [XmlIgnore()]
        public bool ClassCodeSpecified
        {
            get
            {
                return this.classCodeFieldSpecified;
            }
            set
            {
                this.classCodeFieldSpecified = value;
            }
        }

        [XmlAttribute("determinerCode")]
        public string DeterminerCode
        {
            get
            {
                return this.determinerCodeField;
            }
            set
            {
                this.determinerCodeField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName = ".MaintainedEntity", Namespace = "urn:hl7-org:v3")]
    public partial class MaintainedEntity
    {

        private List<CS> realmCodeField;

        private InfrastructureRootTypeId typeIdField;

        private List<II> templateIdField;

        private IVL_TS effectiveTimeField;

        private Person maintainingPersonField;

        private string nullFlavorField;

        private string classCodeField;

        public MaintainedEntity()
        {
            this.classCodeField = "MNT";
        }

        [XmlElement("realmCode")]
        public List<CS> RealmCodes
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.realmCodeField == null)
                    this.realmCodeField = new List<CS>();

                return this.realmCodeField;
            }
            set
            {
                this.realmCodeField = value;
            }
        }

        [XmlElement("typeId")]
        public InfrastructureRootTypeId TypeId
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.typeIdField == null)
                    this.typeIdField = new InfrastructureRootTypeId();

                return this.typeIdField;
            }
            set
            {
                this.typeIdField = value;
            }
        }

        [XmlElement("templateId")]
        public List<II> TemplateIds
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.templateIdField == null)
                    this.templateIdField = new List<II>();

                return this.templateIdField;
            }
            set
            {
                this.templateIdField = value;
            }
        }

        [XmlElement("effectiveTime")]
        public IVL_TS EffectiveTime
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.effectiveTimeField == null)
                    this.effectiveTimeField = new IVL_TS();

                return this.effectiveTimeField;
            }
            set
            {
                this.effectiveTimeField = value;
            }
        }

        [XmlElement("maintainingPerson")]
        public Person MaintainingPerson
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.maintainingPersonField == null)
                    this.maintainingPersonField = new Person();

                return this.maintainingPersonField;
            }
            set
            {
                this.maintainingPersonField = value;
            }
        }

        [XmlAttribute("nullFlavor")]
        public string NullFlavor
        {
            get
            {
                return this.nullFlavorField;
            }
            set
            {
                this.nullFlavorField = value;
            }
        }

        [XmlAttribute("classCode")]
        public string ClassCode
        {
            get
            {
                return this.classCodeField;
            }
            set
            {
                this.classCodeField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName = ".Person", Namespace = "urn:hl7-org:v3")]
    public partial class Person
    {

        private List<CS> realmCodeField;

        private InfrastructureRootTypeId typeIdField;

        private List<II> templateIdField;

        private List<PN> nameField;

        private string nullFlavorField;

        private string classCodeField;

        private string determinerCodeField;

        public Person()
        {
            this.classCodeField = "PSN";
            this.determinerCodeField = "INSTANCE";
        }

        [XmlElement("realmCode")]
        public List<CS> RealmCodes
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.realmCodeField == null)
                    this.realmCodeField = new List<CS>();

                return this.realmCodeField;
            }
            set
            {
                this.realmCodeField = value;
            }
        }

        [XmlElement("typeId")]
        public InfrastructureRootTypeId TypeId
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.typeIdField == null)
                    this.typeIdField = new InfrastructureRootTypeId();

                return this.typeIdField;
            }
            set
            {
                this.typeIdField = value;
            }
        }

        [XmlElement("templateId")]
        public List<II> TemplateIds
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.templateIdField == null)
                    this.templateIdField = new List<II>();

                return this.templateIdField;
            }
            set
            {
                this.templateIdField = value;
            }
        }

        [XmlElement("name")]
        public List<PN> Name
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.nameField == null)
                    this.nameField = new List<PN>();

                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        [XmlAttribute("nullFlavor")]
        public string NullFlavor
        {
            get
            {
                return this.nullFlavorField;
            }
            set
            {
                this.nullFlavorField = value;
            }
        }

        [XmlAttribute("classCode")]
        public string ClassCode
        {
            get
            {
                return this.classCodeField;
            }
            set
            {
                this.classCodeField = value;
            }
        }

        [XmlAttribute("determinerCode")]
        public string DeterminerCode
        {
            get
            {
                return this.determinerCodeField;
            }
            set
            {
                this.determinerCodeField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName = ".Organization", Namespace = "urn:hl7-org:v3")]
    public partial class Organization
    {

        private List<CS> realmCodeField;

        private InfrastructureRootTypeId typeIdField;

        private List<II> templateIdField;

        private List<II> idField;

        private ON[] nameField;

        private List<TEL> telecomField;

        private List<AD> addrField;

        private CE standardIndustryClassCodeField;

        private OrganizationPartOf asOrganizationPartOfField;

        private string nullFlavorField;

        private string classCodeField;

        private string determinerCodeField;

        public Organization()
        {
            this.classCodeField = "ORG";
            this.determinerCodeField = "INSTANCE";
        }

        [XmlElement("realmCode")]
        public List<CS> RealmCodes
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.realmCodeField == null)
                    this.realmCodeField = new List<CS>();

                return this.realmCodeField;
            }
            set
            {
                this.realmCodeField = value;
            }
        }

        [XmlElement("typeId")]
        public InfrastructureRootTypeId TypeId
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.typeIdField == null)
                    this.typeIdField = new InfrastructureRootTypeId();

                return this.typeIdField;
            }
            set
            {
                this.typeIdField = value;
            }
        }

        [XmlElement("templateId")]
        public List<II> TemplateIds
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.templateIdField == null)
                    this.templateIdField = new List<II>();

                return this.templateIdField;
            }
            set
            {
                this.templateIdField = value;
            }
        }

        [XmlElement("id")]
        public List<II> Ids
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.idField == null)
                    this.idField = new List<II>();

                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        [XmlElement("name")]
        public ON[] Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        [XmlElement("telecom")]
        public List<TEL> Telecom
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.telecomField == null)
                    this.telecomField = new List<TEL>();

                return this.telecomField;
            }
            set
            {
                this.telecomField = value;
            }
        }

        [XmlElement("addr")]
        public List<AD> Addr
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.addrField == null)
                    this.addrField = new List<AD>();

                return this.addrField;
            }
            set
            {
                this.addrField = value;
            }
        }

        [XmlElement("standardIndustryClassCode")]
        public CE StandardIndustryClassCode
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.standardIndustryClassCodeField == null)
                    this.standardIndustryClassCodeField = new CE();

                return this.standardIndustryClassCodeField;
            }
            set
            {
                this.standardIndustryClassCodeField = value;
            }
        }

        [XmlElement("asOrganizationPartOf")]
        public OrganizationPartOf AsOrganizationPartOf
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.asOrganizationPartOfField == null)
                    this.asOrganizationPartOfField = new OrganizationPartOf();

                return this.asOrganizationPartOfField;
            }
            set
            {
                this.asOrganizationPartOfField = value;
            }
        }

        [XmlAttribute("nullFlavor")]
        public string NullFlavor
        {
            get
            {
                return this.nullFlavorField;
            }
            set
            {
                this.nullFlavorField = value;
            }
        }

        [XmlAttribute("classCode")]
        public string ClassCode
        {
            get
            {
                return this.classCodeField;
            }
            set
            {
                this.classCodeField = value;
            }
        }

        [XmlAttribute("determinerCode")]
        public string DeterminerCode
        {
            get
            {
                return this.determinerCodeField;
            }
            set
            {
                this.determinerCodeField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName = ".OrganizationPartOf", Namespace = "urn:hl7-org:v3")]
    public partial class OrganizationPartOf
    {

        private List<CS> realmCodeField;

        private InfrastructureRootTypeId typeIdField;

        private List<II> templateIdField;

        private List<II> idField;

        private CE codeField;

        private CS statusCodeField;

        private IVL_TS effectiveTimeField;

        private Organization wholeOrganizationField;

        private string nullFlavorField;

        private string classCodeField;

        public OrganizationPartOf()
        {
            this.classCodeField = "PART";
        }

        [XmlElement("realmCode")]
        public List<CS> RealmCodes
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.realmCodeField == null)
                    this.realmCodeField = new List<CS>();

                return this.realmCodeField;
            }
            set
            {
                this.realmCodeField = value;
            }
        }

        [XmlElement("typeId")]
        public InfrastructureRootTypeId TypeId
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.typeIdField == null)
                    this.typeIdField = new InfrastructureRootTypeId();

                return this.typeIdField;
            }
            set
            {
                this.typeIdField = value;
            }
        }

        [XmlElement("templateId")]
        public List<II> TemplateIds
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.templateIdField == null)
                    this.templateIdField = new List<II>();

                return this.templateIdField;
            }
            set
            {
                this.templateIdField = value;
            }
        }

        [XmlElement("id")]
        public List<II> Ids
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.idField == null)
                    this.idField = new List<II>();

                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        [XmlElement("code")]
        public CE Code
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.codeField == null)
                    this.codeField = new CE();

                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }

        [XmlElement("statusCode")]
        public CS StatusCode
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.statusCodeField == null)
                    this.statusCodeField = new CS();

                return this.statusCodeField;
            }
            set
            {
                this.statusCodeField = value;
            }
        }

        [XmlElement("effectiveTime")]
        public IVL_TS EffectiveTime
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.effectiveTimeField == null)
                    this.effectiveTimeField = new IVL_TS();

                return this.effectiveTimeField;
            }
            set
            {
                this.effectiveTimeField = value;
            }
        }

        [XmlElement("wholeOrganization")]
        public Organization WholeOrganization
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.wholeOrganizationField == null)
                    this.wholeOrganizationField = new Organization();

                return this.wholeOrganizationField;
            }
            set
            {
                this.wholeOrganizationField = value;
            }
        }

        [XmlAttribute("nullFlavor")]
        public string NullFlavor
        {
            get
            {
                return this.nullFlavorField;
            }
            set
            {
                this.nullFlavorField = value;
            }
        }

        [XmlAttribute("classCode")]
        public string ClassCode
        {
            get
            {
                return this.classCodeField;
            }
            set
            {
                this.classCodeField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName = ".Informant12", Namespace = "urn:hl7-org:v3")]
    public partial class Informant12
    {

        private List<CS> realmCodeField;

        private InfrastructureRootTypeId typeIdField;

        private List<II> templateIdField;

        private object itemField;

        private string nullFlavorField;

        private string typeCodeField;

        private string contextControlCodeField;

        public Informant12()
        {
            this.typeCodeField = "INF";
            this.contextControlCodeField = "OP";
        }

        [XmlElement("realmCode")]
        public List<CS> RealmCodes
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.realmCodeField == null)
                    this.realmCodeField = new List<CS>();

                return this.realmCodeField;
            }
            set
            {
                this.realmCodeField = value;
            }
        }

        [XmlElement("typeId")]
        public InfrastructureRootTypeId TypeId
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.typeIdField == null)
                    this.typeIdField = new InfrastructureRootTypeId();

                return this.typeIdField;
            }
            set
            {
                this.typeIdField = value;
            }
        }

        [XmlElement("templateId")]
        public List<II> TemplateIds
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.templateIdField == null)
                    this.templateIdField = new List<II>();

                return this.templateIdField;
            }
            set
            {
                this.templateIdField = value;
            }
        }

        [XmlElement("assignedEntity", typeof(AssignedEntity))]
        [XmlElement("relatedEntity", typeof(RelatedEntity))]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        [XmlAttribute("nullFlavor")]
        public string NullFlavor
        {
            get
            {
                return this.nullFlavorField;
            }
            set
            {
                this.nullFlavorField = value;
            }
        }

        [XmlAttribute("typeCode")]
        public string TypeCode
        {
            get
            {
                return this.typeCodeField;
            }
            set
            {
                this.typeCodeField = value;
            }
        }

        [XmlAttribute("contextControlCode")]
        public string ContextControlCode
        {
            get
            {
                return this.contextControlCodeField;
            }
            set
            {
                this.contextControlCodeField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName = ".AssignedEntity", Namespace = "urn:hl7-org:v3")]
    public partial class AssignedEntity
    {

        private List<CS> realmCodeField;

        private InfrastructureRootTypeId typeIdField;

        private List<II> templateIdField;

        private List<II> idField;

        private CE codeField;

        private List<AD> addrField;

        private List<TEL> telecomField;

        private Person assignedPersonField;

        private Organization representedOrganizationField;

        private string nullFlavorField;

        private string classCodeField;

        public AssignedEntity()
        {
            this.classCodeField = "ASSIGNED";
        }

        [XmlElement("realmCode")]
        public List<CS> RealmCodes
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.realmCodeField == null)
                    this.realmCodeField = new List<CS>();

                return this.realmCodeField;
            }
            set
            {
                this.realmCodeField = value;
            }
        }

        [XmlElement("typeId")]
        public InfrastructureRootTypeId TypeId
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.typeIdField == null)
                    this.typeIdField = new InfrastructureRootTypeId();

                return this.typeIdField;
            }
            set
            {
                this.typeIdField = value;
            }
        }

        [XmlElement("templateId")]
        public List<II> TemplateIds
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.templateIdField == null)
                    this.templateIdField = new List<II>();

                return this.templateIdField;
            }
            set
            {
                this.templateIdField = value;
            }
        }

        [XmlElement("id")]
        public List<II> Ids
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.idField == null)
                    this.idField = new List<II>();

                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        [XmlElement("code")]
        public CE Code
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.codeField == null)
                    this.codeField = new CE();

                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }

        [XmlElement("addr")]
        public List<AD> Addr
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.addrField == null)
                    this.addrField = new List<AD>();

                return this.addrField;
            }
            set
            {
                this.addrField = value;
            }
        }

        [XmlElement("telecom")]
        public List<TEL> Telecom
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.telecomField == null)
                    this.telecomField = new List<TEL>();

                return this.telecomField;
            }
            set
            {
                this.telecomField = value;
            }
        }

        [XmlElement("assignedPerson")]
        public Person AssignedPerson
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.assignedPersonField == null)
                    this.assignedPersonField = new Person();

                return this.assignedPersonField;
            }
            set
            {
                this.assignedPersonField = value;
            }
        }

        [XmlElement("representedOrganization")]
        public Organization RepresentedOrganization
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.representedOrganizationField == null)
                    this.representedOrganizationField = new Organization();

                return this.representedOrganizationField;
            }
            set
            {
                this.representedOrganizationField = value;
            }
        }

        [XmlAttribute("nullFlavor")]
        public string NullFlavor
        {
            get
            {
                return this.nullFlavorField;
            }
            set
            {
                this.nullFlavorField = value;
            }
        }

        [XmlAttribute("classCode")]
        public string ClassCode
        {
            get
            {
                return this.classCodeField;
            }
            set
            {
                this.classCodeField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName = ".RelatedEntity", Namespace = "urn:hl7-org:v3")]
    public partial class RelatedEntity
    {

        private List<CS> realmCodeField;

        private InfrastructureRootTypeId typeIdField;

        private List<II> templateIdField;

        private CE codeField;

        private List<AD> addrField;

        private List<TEL> telecomField;

        private IVL_TS effectiveTimeField;

        private Person relatedPersonField;

        private string nullFlavorField;

        private string classCodeField;

        [XmlElement("realmCode")]
        public List<CS> RealmCodes
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.realmCodeField == null)
                    this.realmCodeField = new List<CS>();

                return this.realmCodeField;
            }
            set
            {
                this.realmCodeField = value;
            }
        }

        [XmlElement("typeId")]
        public InfrastructureRootTypeId TypeId
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.typeIdField == null)
                    this.typeIdField = new InfrastructureRootTypeId();

                return this.typeIdField;
            }
            set
            {
                this.typeIdField = value;
            }
        }

        [XmlElement("templateId")]
        public List<II> TemplateIds
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.templateIdField == null)
                    this.templateIdField = new List<II>();

                return this.templateIdField;
            }
            set
            {
                this.templateIdField = value;
            }
        }

        [XmlElement("code")]
        public CE Code
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.codeField == null)
                    this.codeField = new CE();

                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }

        [XmlElement("addr")]
        public List<AD> Addr
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.addrField == null)
                    this.addrField = new List<AD>();

                return this.addrField;
            }
            set
            {
                this.addrField = value;
            }
        }

        [XmlElement("telecom")]
        public List<TEL> Telecom
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.telecomField == null)
                    this.telecomField = new List<TEL>();

                return this.telecomField;
            }
            set
            {
                this.telecomField = value;
            }
        }

        [XmlElement("effectiveTime")]
        public IVL_TS EffectiveTime
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.effectiveTimeField == null)
                    this.effectiveTimeField = new IVL_TS();

                return this.effectiveTimeField;
            }
            set
            {
                this.effectiveTimeField = value;
            }
        }

        [XmlElement("relatedPerson")]
        public Person RelatedPerson
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.relatedPersonField == null)
                    this.relatedPersonField = new Person();

                return this.relatedPersonField;
            }
            set
            {
                this.relatedPersonField = value;
            }
        }

        [XmlAttribute("nullFlavor")]
        public string NullFlavor
        {
            get
            {
                return this.nullFlavorField;
            }
            set
            {
                this.nullFlavorField = value;
            }
        }

        [XmlAttribute("classCode")]
        public string ClassCode
        {
            get
            {
                return this.classCodeField;
            }
            set
            {
                this.classCodeField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName = ".Entry", Namespace = "urn:hl7-org:v3")]
    public partial class Entry
    {

        private List<CS> realmCodeField;

        private InfrastructureRootTypeId typeIdField;

        private List<II> templateIdField;

        private object itemField;

        private string nullFlavorField;

        private EntryTypeCodes typeCodeField;

        private bool contextConductionIndField;

        private bool contextConductionIndFieldSpecified;

        public Entry()
        {
            this.typeCodeField = EntryTypeCodes.COMP;
            this.contextConductionIndField = true;
        }

        [XmlElement("realmCode")]
        public List<CS> RealmCodes
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.realmCodeField == null)
                    this.realmCodeField = new List<CS>();

                return this.realmCodeField;
            }
            set
            {
                this.realmCodeField = value;
            }
        }

        [XmlElement("typeId")]
        public InfrastructureRootTypeId TypeId
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.typeIdField == null)
                    this.typeIdField = new InfrastructureRootTypeId();

                return this.typeIdField;
            }
            set
            {
                this.typeIdField = value;
            }
        }

        [XmlElement("templateId")]
        public List<II> TemplateIds
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.templateIdField == null)
                    this.templateIdField = new List<II>();

                return this.templateIdField;
            }
            set
            {
                this.templateIdField = value;
            }
        }

        [XmlElement("act", typeof(Act))]
        [XmlElement("encounter", typeof(Encounter))]
        [XmlElement("observation", typeof(Observation))]
        [XmlElement("observationMedia", typeof(ObservationMedia))]
        [XmlElement("organizer", typeof(Organizer))]
        [XmlElement("procedure", typeof(Procedure))]
        [XmlElement("regionOfInterest", typeof(RegionOfInterest))]
        [XmlElement("substanceAdministration", typeof(SubstanceAdministration))]
        [XmlElement("supply", typeof(Supply))]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        [XmlAttribute("nullFlavor")]
        public string NullFlavor
        {
            get
            {
                return this.nullFlavorField;
            }
            set
            {
                this.nullFlavorField = value;
            }
        }

        [XmlAttribute("typeCode")]
        [System.ComponentModel.DefaultValueAttribute(EntryTypeCodes.COMP)]
        public EntryTypeCodes TypeCode
        {
            get
            {
                return this.typeCodeField;
            }
            set
            {
                this.typeCodeField = value;
            }
        }

        [XmlAttribute("contextConductionInd")]
        public bool ContextConductionInd
        {
            get
            {
                return this.contextConductionIndField;
            }
            set
            {
                this.contextConductionIndField = value;
            }
        }

        [XmlIgnore()]
        public bool ContextConductionIndSpecified
        {
            get
            {
                return this.contextConductionIndFieldSpecified;
            }
            set
            {
                this.contextConductionIndFieldSpecified = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName = ".Act", Namespace = "urn:hl7-org:v3")]
    public partial class Act : IClinicalStatement
    {

        private List<CS> realmCodeField;

        private InfrastructureRootTypeId typeIdField;

        private List<II> templateIdField;

        private List<II> idField;

        private CD codeField;

        private ED textField;

        private CS statusCodeField;

        private IVL_TS effectiveTimeField;

        private CE priorityCodeField;

        private CS languageCodeField;

        private Subject subjectField;

        private List<Specimen> specimenField;

        private List<Performer2> performerField;

        private List<Author> authorField;

        private List<Informant12> informantField;

        private List<Participant2> participantField;

        private List<EntryRelationship> entryRelationshipField;

        private List<Reference> referenceField;

        private List<Precondition> preconditionField;

        private string nullFlavorField;

        private ActClassCodes classCodeField;

        private ActMoodCodes moodCodeField;

        private bool negationIndField;

        private bool negationIndFieldSpecified;

        [XmlElement("realmCode")]
        public List<CS> RealmCodes
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.realmCodeField == null)
                    this.realmCodeField = new List<CS>();

                return this.realmCodeField;
            }
            set
            {
                this.realmCodeField = value;
            }
        }

        [XmlElement("typeId")]
        public InfrastructureRootTypeId TypeId
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.typeIdField == null)
                    this.typeIdField = new InfrastructureRootTypeId();

                return this.typeIdField;
            }
            set
            {
                this.typeIdField = value;
            }
        }

        [XmlElement("templateId")]
        public List<II> TemplateIds
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.templateIdField == null)
                    this.templateIdField = new List<II>();

                return this.templateIdField;
            }
            set
            {
                this.templateIdField = value;
            }
        }

        [XmlElement("id")]
        public List<II> Ids
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.idField == null)
                    this.idField = new List<II>();

                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        [XmlElement("code")]
        public CD Code
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.codeField == null)
                    this.codeField = new CD();

                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }

        [XmlElement("text")]
        public ED Text
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.textField == null)
                    this.textField = new ED();

                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }

        [XmlElement("statusCode")]
        public CS StatusCode
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.statusCodeField == null)
                    this.statusCodeField = new CS();

                return this.statusCodeField;
            }
            set
            {
                this.statusCodeField = value;
            }
        }

        [XmlElement("effectiveTime")]
        public IVL_TS EffectiveTime
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.effectiveTimeField == null)
                    this.effectiveTimeField = new IVL_TS();

                return this.effectiveTimeField;
            }
            set
            {
                this.effectiveTimeField = value;
            }
        }

        [XmlElement("priorityCode")]
        public CE PriorityCode
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.priorityCodeField == null)
                    this.priorityCodeField = new CE();

                return this.priorityCodeField;
            }
            set
            {
                this.priorityCodeField = value;
            }
        }

        [XmlElement("languageCode")]
        public CS LanguageCode
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.languageCodeField == null)
                    this.languageCodeField = new CS();

                return this.languageCodeField;
            }
            set
            {
                this.languageCodeField = value;
            }
        }

        [XmlElement("subject")]
        public Subject Subject
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.subjectField == null)
                    this.subjectField = new Subject();

                return this.subjectField;
            }
            set
            {
                this.subjectField = value;
            }
        }

        [XmlElement("specimen")]
        public List<Specimen> Specimens
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.specimenField == null)
                    this.specimenField = new List<Specimen>();

                return this.specimenField;
            }
            set
            {
                this.specimenField = value;
            }
        }

        [XmlElement("performer")]
        public List<Performer2> Performers
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.performerField == null)
                    this.performerField = new List<Performer2>();

                return this.performerField;
            }
            set
            {
                this.performerField = value;
            }
        }

        [XmlElement("author")]
        public List<Author> Authors
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.authorField == null)
                    this.authorField = new List<Author>();

                return this.authorField;
            }
            set
            {
                this.authorField = value;
            }
        }

        [XmlElement("informant")]
        public List<Informant12> Informants
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.informantField == null)
                    this.informantField = new List<Informant12>();

                return this.informantField;
            }
            set
            {
                this.informantField = value;
            }
        }

        [XmlElement("participant")]
        public List<Participant2> Participants
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.participantField == null)
                    this.participantField = new List<Participant2>();

                return this.participantField;
            }
            set
            {
                this.participantField = value;
            }
        }

        [XmlElement("entryRelationship")]
        public List<EntryRelationship> EntryRelationships
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.entryRelationshipField == null)
                    this.entryRelationshipField = new List<EntryRelationship>();

                return this.entryRelationshipField;
            }
            set
            {
                this.entryRelationshipField = value;
            }
        }

        [XmlElement("reference")]
        public List<Reference> References
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.referenceField == null)
                    this.referenceField = new List<Reference>();

                return this.referenceField;
            }
            set
            {
                this.referenceField = value;
            }
        }

        [XmlElement("precondition")]
        public List<Precondition> Preconditions
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.preconditionField == null)
                    this.preconditionField = new List<Precondition>();

                return this.preconditionField;
            }
            set
            {
                this.preconditionField = value;
            }
        }

        [XmlAttribute("nullFlavor")]
        public string NullFlavor
        {
            get
            {
                return this.nullFlavorField;
            }
            set
            {
                this.nullFlavorField = value;
            }
        }

        [XmlAttribute("classCode")]
        public ActClassCodes ClassCode
        {
            get
            {
                return this.classCodeField;
            }
            set
            {
                this.classCodeField = value;
            }
        }

        [XmlAttribute("moodCode")]
        public ActMoodCodes MoodCode
        {
            get
            {
                return this.moodCodeField;
            }
            set
            {
                this.moodCodeField = value;
            }
        }

        [XmlAttribute("negationInd")]
        public bool NegationInd
        {
            get
            {
                return this.negationIndField;
            }
            set
            {
                this.negationIndField = value;
            }
        }

        [XmlIgnore()]
        public bool NegationIndSpecified
        {
            get
            {
                return this.negationIndFieldSpecified;
            }
            set
            {
                this.negationIndFieldSpecified = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName = ".Specimen", Namespace = "urn:hl7-org:v3")]
    public partial class Specimen
    {

        private List<CS> realmCodeField;

        private InfrastructureRootTypeId typeIdField;

        private List<II> templateIdField;

        private SpecimenRole specimenRoleField;

        private string nullFlavorField;

        private string typeCodeField;

        public Specimen()
        {
            this.typeCodeField = "SPC";
        }

        [XmlElement("realmCode")]
        public List<CS> RealmCodes
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.realmCodeField == null)
                    this.realmCodeField = new List<CS>();

                return this.realmCodeField;
            }
            set
            {
                this.realmCodeField = value;
            }
        }

        [XmlElement("typeId")]
        public InfrastructureRootTypeId TypeId
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.typeIdField == null)
                    this.typeIdField = new InfrastructureRootTypeId();

                return this.typeIdField;
            }
            set
            {
                this.typeIdField = value;
            }
        }

        [XmlElement("templateId")]
        public List<II> TemplateIds
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.templateIdField == null)
                    this.templateIdField = new List<II>();

                return this.templateIdField;
            }
            set
            {
                this.templateIdField = value;
            }
        }

        [XmlElement("specimenRole")]
        public SpecimenRole SpecimenRole
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.specimenRoleField == null)
                    this.specimenRoleField = new SpecimenRole();

                return this.specimenRoleField;
            }
            set
            {
                this.specimenRoleField = value;
            }
        }

        [XmlAttribute("nullFlavor")]
        public string NullFlavor
        {
            get
            {
                return this.nullFlavorField;
            }
            set
            {
                this.nullFlavorField = value;
            }
        }

        [XmlAttribute("typeCode")]
        public string TypeCode
        {
            get
            {
                return this.typeCodeField;
            }
            set
            {
                this.typeCodeField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName = ".SpecimenRole", Namespace = "urn:hl7-org:v3")]
    public partial class SpecimenRole
    {

        private List<CS> realmCodeField;

        private InfrastructureRootTypeId typeIdField;

        private List<II> templateIdField;

        private List<II> idField;

        private PlayingEntity specimenPlayingEntityField;

        private string nullFlavorField;

        private SpecimenRoleClassCodes classCodeField;

        private bool classCodeFieldSpecified;

        public SpecimenRole()
        {
            this.classCodeField = SpecimenRoleClassCodes.SPEC;
        }

        [XmlElement("realmCode")]
        public List<CS> RealmCodes
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.realmCodeField == null)
                    this.realmCodeField = new List<CS>();

                return this.realmCodeField;
            }
            set
            {
                this.realmCodeField = value;
            }
        }

        [XmlElement("typeId")]
        public InfrastructureRootTypeId TypeId
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.typeIdField == null)
                    this.typeIdField = new InfrastructureRootTypeId();

                return this.typeIdField;
            }
            set
            {
                this.typeIdField = value;
            }
        }

        [XmlElement("templateId")]
        public List<II> TemplateIds
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.templateIdField == null)
                    this.templateIdField = new List<II>();

                return this.templateIdField;
            }
            set
            {
                this.templateIdField = value;
            }
        }

        [XmlElement("id")]
        public List<II> Ids
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.idField == null)
                    this.idField = new List<II>();

                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        [XmlElement("specimenPlayingEntity")]
        public PlayingEntity SpecimenPlayingEntity
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.specimenPlayingEntityField == null)
                    this.specimenPlayingEntityField = new PlayingEntity();

                return this.specimenPlayingEntityField;
            }
            set
            {
                this.specimenPlayingEntityField = value;
            }
        }

        [XmlAttribute("nullFlavor")]
        public string NullFlavor
        {
            get
            {
                return this.nullFlavorField;
            }
            set
            {
                this.nullFlavorField = value;
            }
        }

        [XmlAttribute("classCode")]
        public SpecimenRoleClassCodes ClassCode
        {
            get
            {
                return this.classCodeField;
            }
            set
            {
                this.classCodeField = value;
            }
        }

        [XmlIgnore()]
        public bool ClassCodeSpecified
        {
            get
            {
                return this.classCodeFieldSpecified;
            }
            set
            {
                this.classCodeFieldSpecified = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName = ".PlayingEntity", Namespace = "urn:hl7-org:v3")]
    public partial class PlayingEntity
    {

        private List<CS> realmCodeField;

        private InfrastructureRootTypeId typeIdField;

        private List<II> templateIdField;

        private CE codeField;

        private PQ[] quantityField;

        private List<PN> nameField;

        private ED descField;

        private string nullFlavorField;

        private string classCodeField;

        private string determinerCodeField;

        public PlayingEntity()
        {
            this.classCodeField = "ENT";
            this.determinerCodeField = "INSTANCE";
        }

        [XmlElement("realmCode")]
        public List<CS> RealmCodes
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.realmCodeField == null)
                    this.realmCodeField = new List<CS>();

                return this.realmCodeField;
            }
            set
            {
                this.realmCodeField = value;
            }
        }

        [XmlElement("typeId")]
        public InfrastructureRootTypeId TypeId
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.typeIdField == null)
                    this.typeIdField = new InfrastructureRootTypeId();

                return this.typeIdField;
            }
            set
            {
                this.typeIdField = value;
            }
        }

        [XmlElement("templateId")]
        public List<II> TemplateIds
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.templateIdField == null)
                    this.templateIdField = new List<II>();

                return this.templateIdField;
            }
            set
            {
                this.templateIdField = value;
            }
        }

        [XmlElement("code")]
        public CE Code
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.codeField == null)
                    this.codeField = new CE();

                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }

        [XmlElement("quantity")]
        public PQ[] Quantity
        {
            get
            {
                return this.quantityField;
            }
            set
            {
                this.quantityField = value;
            }
        }

        [XmlElement("name")]
        public List<PN> Name
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.nameField == null)
                    this.nameField = new List<PN>();

                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        [XmlElement("desc")]
        public ED Desc
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.descField == null)
                    this.descField = new ED();

                return this.descField;
            }
            set
            {
                this.descField = value;
            }
        }

        [XmlAttribute("nullFlavor")]
        public string NullFlavor
        {
            get
            {
                return this.nullFlavorField;
            }
            set
            {
                this.nullFlavorField = value;
            }
        }

        [XmlAttribute("classCode")]
        [System.ComponentModel.DefaultValueAttribute("ENT")]
        public string ClassCode
        {
            get
            {
                return this.classCodeField;
            }
            set
            {
                this.classCodeField = value;
            }
        }

        [XmlAttribute("determinerCode")]
        public string DeterminerCode
        {
            get
            {
                return this.determinerCodeField;
            }
            set
            {
                this.determinerCodeField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName = ".Performer2", Namespace = "urn:hl7-org:v3")]
    public partial class Performer2
    {

        private List<CS> realmCodeField;

        private InfrastructureRootTypeId typeIdField;

        private List<II> templateIdField;

        private IVL_TS timeField;

        private CE modeCodeField;

        private AssignedEntity assignedEntityField;

        private string nullFlavorField;

        private Performer2TypeCodes typeCodeField;

        private bool typeCodeFieldSpecified;

        public Performer2()
        {
            this.typeCodeField = Performer2TypeCodes.PRF;
        }

        [XmlElement("realmCode")]
        public List<CS> RealmCodes
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.realmCodeField == null)
                    this.realmCodeField = new List<CS>();

                return this.realmCodeField;
            }
            set
            {
                this.realmCodeField = value;
            }
        }

        [XmlElement("typeId")]
        public InfrastructureRootTypeId TypeId
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.typeIdField == null)
                    this.typeIdField = new InfrastructureRootTypeId();

                return this.typeIdField;
            }
            set
            {
                this.typeIdField = value;
            }
        }

        [XmlElement("templateId")]
        public List<II> TemplateIds
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.templateIdField == null)
                    this.templateIdField = new List<II>();

                return this.templateIdField;
            }
            set
            {
                this.templateIdField = value;
            }
        }

        [XmlElement("time")]
        public IVL_TS Time
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.timeField == null)
                    this.timeField = new IVL_TS();

                return this.timeField;
            }
            set
            {
                this.timeField = value;
            }
        }

        [XmlElement("modeCode")]
        public CE ModeCode
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.modeCodeField == null)
                    this.modeCodeField = new CE();

                return this.modeCodeField;
            }
            set
            {
                this.modeCodeField = value;
            }
        }

        [XmlElement("assignedEntity")]
        public AssignedEntity AssignedEntity
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.assignedEntityField == null)
                    this.assignedEntityField = new AssignedEntity();

                return this.assignedEntityField;
            }
            set
            {
                this.assignedEntityField = value;
            }
        }

        [XmlAttribute("nullFlavor")]
        public string NullFlavor
        {
            get
            {
                return this.nullFlavorField;
            }
            set
            {
                this.nullFlavorField = value;
            }
        }

        [XmlAttribute("typeCode")]
        public Performer2TypeCodes TypeCode
        {
            get
            {
                return this.typeCodeField;
            }
            set
            {
                this.typeCodeField = value;
            }
        }

        [XmlIgnore()]
        public bool TypeCodeSpecified
        {
            get
            {
                return this.typeCodeFieldSpecified;
            }
            set
            {
                this.typeCodeFieldSpecified = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName = ".Participant2", Namespace = "urn:hl7-org:v3")]
    public partial class Participant2
    {

        private List<CS> realmCodeField;

        private InfrastructureRootTypeId typeIdField;

        private List<II> templateIdField;

        private IVL_TS timeField;

        private CE awarenessCodeField;

        private ParticipantRole participantRoleField;

        private string nullFlavorField;

        private string typeCodeField;

        private string contextControlCodeField;

        public Participant2()
        {
            this.contextControlCodeField = "OP";
        }

        [XmlElement("realmCode")]
        public List<CS> RealmCodes
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.realmCodeField == null)
                    this.realmCodeField = new List<CS>();

                return this.realmCodeField;
            }
            set
            {
                this.realmCodeField = value;
            }
        }

        [XmlElement("typeId")]
        public InfrastructureRootTypeId TypeId
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.typeIdField == null)
                    this.typeIdField = new InfrastructureRootTypeId();

                return this.typeIdField;
            }
            set
            {
                this.typeIdField = value;
            }
        }

        [XmlElement("templateId")]
        public List<II> TemplateIds
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.templateIdField == null)
                    this.templateIdField = new List<II>();

                return this.templateIdField;
            }
            set
            {
                this.templateIdField = value;
            }
        }

        [XmlElement("time")]
        public IVL_TS Time
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.timeField == null)
                    this.timeField = new IVL_TS();

                return this.timeField;
            }
            set
            {
                this.timeField = value;
            }
        }

        [XmlElement("awarenessCode")]
        public CE AwarenessCode
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.awarenessCodeField == null)
                    this.awarenessCodeField = new CE();

                return this.awarenessCodeField;
            }
            set
            {
                this.awarenessCodeField = value;
            }
        }

        [XmlElement("participantRole")]
        public ParticipantRole ParticipantRole
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.participantRoleField == null)
                    this.participantRoleField = new ParticipantRole();

                return this.participantRoleField;
            }
            set
            {
                this.participantRoleField = value;
            }
        }

        [XmlAttribute("nullFlavor")]
        public string NullFlavor
        {
            get
            {
                return this.nullFlavorField;
            }
            set
            {
                this.nullFlavorField = value;
            }
        }

        [XmlAttribute("typeCode")]
        public string TypeCode
        {
            get
            {
                return this.typeCodeField;
            }
            set
            {
                this.typeCodeField = value;
            }
        }

        [XmlAttribute("contextControlCode")]
        public string ContextControlCode
        {
            get
            {
                return this.contextControlCodeField;
            }
            set
            {
                this.contextControlCodeField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName = ".ParticipantRole", Namespace = "urn:hl7-org:v3")]
    public partial class ParticipantRole
    {

        private List<CS> realmCodeField;

        private InfrastructureRootTypeId typeIdField;

        private List<II> templateIdField;

        private List<II> idField;

        private CE codeField;

        private List<AD> addrField;

        private List<TEL> telecomField;

        private object itemField;

        private Entity scopingEntityField;

        private string nullFlavorField;

        private string classCodeField;

        public ParticipantRole()
        {
            this.classCodeField = "ROL";
        }

        [XmlElement("realmCode")]
        public List<CS> RealmCodes
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.realmCodeField == null)
                    this.realmCodeField = new List<CS>();

                return this.realmCodeField;
            }
            set
            {
                this.realmCodeField = value;
            }
        }

        [XmlElement("typeId")]
        public InfrastructureRootTypeId TypeId
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.typeIdField == null)
                    this.typeIdField = new InfrastructureRootTypeId();

                return this.typeIdField;
            }
            set
            {
                this.typeIdField = value;
            }
        }

        [XmlElement("templateId")]
        public List<II> TemplateIds
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.templateIdField == null)
                    this.templateIdField = new List<II>();

                return this.templateIdField;
            }
            set
            {
                this.templateIdField = value;
            }
        }

        [XmlElement("id")]
        public List<II> Ids
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.idField == null)
                    this.idField = new List<II>();

                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        [XmlElement("code")]
        public CE Code
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.codeField == null)
                    this.codeField = new CE();

                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }

        [XmlElement("addr")]
        public List<AD> Addr
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.addrField == null)
                    this.addrField = new List<AD>();

                return this.addrField;
            }
            set
            {
                this.addrField = value;
            }
        }

        [XmlElement("telecom")]
        public List<TEL> Telecom
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.telecomField == null)
                    this.telecomField = new List<TEL>();

                return this.telecomField;
            }
            set
            {
                this.telecomField = value;
            }
        }

        [XmlElement("playingDevice", typeof(Device))]
        [XmlElement("playingEntity", typeof(PlayingEntity))]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        [XmlElement("scopingEntity")]
        public Entity ScopingEntity
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.scopingEntityField == null)
                    this.scopingEntityField = new Entity();

                return this.scopingEntityField;
            }
            set
            {
                this.scopingEntityField = value;
            }
        }

        [XmlAttribute("nullFlavor")]
        public string NullFlavor
        {
            get
            {
                return this.nullFlavorField;
            }
            set
            {
                this.nullFlavorField = value;
            }
        }

        [XmlAttribute("classCode")]
        [System.ComponentModel.DefaultValueAttribute("ROL")]
        public string ClassCode
        {
            get
            {
                return this.classCodeField;
            }
            set
            {
                this.classCodeField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName = ".Device", Namespace = "urn:hl7-org:v3")]
    public partial class Device
    {

        private List<CS> realmCodeField;

        private InfrastructureRootTypeId typeIdField;

        private List<II> templateIdField;

        private CE codeField;

        private SC manufacturerModelNameField;

        private SC softwareNameField;

        private string nullFlavorField;

        private DeviceClassCodes classCodeField;

        private string determinerCodeField;

        public Device()
        {
            this.classCodeField = DeviceClassCodes.DEV;
            this.determinerCodeField = "INSTANCE";
        }

        [XmlElement("realmCode")]
        public List<CS> RealmCodes
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.realmCodeField == null)
                    this.realmCodeField = new List<CS>();

                return this.realmCodeField;
            }
            set
            {
                this.realmCodeField = value;
            }
        }

        [XmlElement("typeId")]
        public InfrastructureRootTypeId TypeId
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.typeIdField == null)
                    this.typeIdField = new InfrastructureRootTypeId();

                return this.typeIdField;
            }
            set
            {
                this.typeIdField = value;
            }
        }

        [XmlElement("templateId")]
        public List<II> TemplateIds
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.templateIdField == null)
                    this.templateIdField = new List<II>();

                return this.templateIdField;
            }
            set
            {
                this.templateIdField = value;
            }
        }

        [XmlElement("code")]
        public CE Code
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.codeField == null)
                    this.codeField = new CE();

                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }

        [XmlElement("manufacturerModelName")]
        public SC ManufacturerModelName
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.manufacturerModelNameField == null)
                    this.manufacturerModelNameField = new SC();

                return this.manufacturerModelNameField;
            }
            set
            {
                this.manufacturerModelNameField = value;
            }
        }

        [XmlElement("softwareName")]
        public SC SoftwareName
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.softwareNameField == null)
                    this.softwareNameField = new SC();

                return this.softwareNameField;
            }
            set
            {
                this.softwareNameField = value;
            }
        }

        [XmlAttribute("nullFlavor")]
        public string NullFlavor
        {
            get
            {
                return this.nullFlavorField;
            }
            set
            {
                this.nullFlavorField = value;
            }
        }

        [XmlAttribute("classCode")]
        [System.ComponentModel.DefaultValueAttribute(DeviceClassCodes.DEV)]
        public DeviceClassCodes ClassCode
        {
            get
            {
                return this.classCodeField;
            }
            set
            {
                this.classCodeField = value;
            }
        }

        [XmlAttribute("determinerCode")]
        public string DeterminerCode
        {
            get
            {
                return this.determinerCodeField;
            }
            set
            {
                this.determinerCodeField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName = ".Entity", Namespace = "urn:hl7-org:v3")]
    public partial class Entity
    {

        private List<CS> realmCodeField;

        private InfrastructureRootTypeId typeIdField;

        private List<II> templateIdField;

        private List<II> idField;

        private CE codeField;

        private ED descField;

        private string nullFlavorField;

        private string classCodeField;

        private string determinerCodeField;

        public Entity()
        {
            this.classCodeField = "ENT";
            this.determinerCodeField = "INSTANCE";
        }

        [XmlElement("realmCode")]
        public List<CS> RealmCodes
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.realmCodeField == null)
                    this.realmCodeField = new List<CS>();

                return this.realmCodeField;
            }
            set
            {
                this.realmCodeField = value;
            }
        }

        [XmlElement("typeId")]
        public InfrastructureRootTypeId TypeId
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.typeIdField == null)
                    this.typeIdField = new InfrastructureRootTypeId();

                return this.typeIdField;
            }
            set
            {
                this.typeIdField = value;
            }
        }

        [XmlElement("templateId")]
        public List<II> TemplateIds
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.templateIdField == null)
                    this.templateIdField = new List<II>();

                return this.templateIdField;
            }
            set
            {
                this.templateIdField = value;
            }
        }

        [XmlElement("id")]
        public List<II> Ids
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.idField == null)
                    this.idField = new List<II>();

                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        [XmlElement("code")]
        public CE Code
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.codeField == null)
                    this.codeField = new CE();

                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }

        [XmlElement("desc")]
        public ED Desc
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.descField == null)
                    this.descField = new ED();

                return this.descField;
            }
            set
            {
                this.descField = value;
            }
        }

        [XmlAttribute("nullFlavor")]
        public string NullFlavor
        {
            get
            {
                return this.nullFlavorField;
            }
            set
            {
                this.nullFlavorField = value;
            }
        }

        [XmlAttribute("classCode")]
        [System.ComponentModel.DefaultValueAttribute("ENT")]
        public string ClassCode
        {
            get
            {
                return this.classCodeField;
            }
            set
            {
                this.classCodeField = value;
            }
        }

        [XmlAttribute("determinerCode")]
        public string DeterminerCode
        {
            get
            {
                return this.determinerCodeField;
            }
            set
            {
                this.determinerCodeField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName = ".EntryRelationship", Namespace = "urn:hl7-org:v3")]
    public partial class EntryRelationship
    {

        private List<CS> realmCodeField;

        private InfrastructureRootTypeId typeIdField;

        private List<II> templateIdField;

        private INT sequenceNumberField;

        private BL seperatableIndField;

        private object itemField;

        private string nullFlavorField;

        private EntryRelationshipTypeCodes typeCodeField;

        private bool inversionIndField;

        private bool inversionIndFieldSpecified;

        private bool contextConductionIndField;

        private bool negationIndField;

        private bool negationIndFieldSpecified;

        public EntryRelationship()
        {
            this.contextConductionIndField = true;
        }

        [XmlElement("realmCode")]
        public List<CS> RealmCodes
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.realmCodeField == null)
                    this.realmCodeField = new List<CS>();

                return this.realmCodeField;
            }
            set
            {
                this.realmCodeField = value;
            }
        }

        [XmlElement("typeId")]
        public InfrastructureRootTypeId TypeId
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.typeIdField == null)
                    this.typeIdField = new InfrastructureRootTypeId();

                return this.typeIdField;
            }
            set
            {
                this.typeIdField = value;
            }
        }

        [XmlElement("templateId")]
        public List<II> TemplateIds
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.templateIdField == null)
                    this.templateIdField = new List<II>();

                return this.templateIdField;
            }
            set
            {
                this.templateIdField = value;
            }
        }

        [XmlElement("sequenceNumber")]
        public INT SequenceNumber
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.sequenceNumberField == null)
                    this.sequenceNumberField = new INT();

                return this.sequenceNumberField;
            }
            set
            {
                this.sequenceNumberField = value;
            }
        }

        [XmlElement("seperatableInd")]
        public BL SeperatableInd
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.seperatableIndField == null)
                    this.seperatableIndField = new BL();

                return this.seperatableIndField;
            }
            set
            {
                this.seperatableIndField = value;
            }
        }

        [XmlElement("act", typeof(Act))]
        [XmlElement("encounter", typeof(Encounter))]
        [XmlElement("observation", typeof(Observation))]
        [XmlElement("observationMedia", typeof(ObservationMedia))]
        [XmlElement("organizer", typeof(Organizer))]
        [XmlElement("procedure", typeof(Procedure))]
        [XmlElement("regionOfInterest", typeof(RegionOfInterest))]
        [XmlElement("substanceAdministration", typeof(SubstanceAdministration))]
        [XmlElement("supply", typeof(Supply))]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        [XmlAttribute("nullFlavor")]
        public string NullFlavor
        {
            get
            {
                return this.nullFlavorField;
            }
            set
            {
                this.nullFlavorField = value;
            }
        }

        [XmlAttribute("typeCode")]
        public EntryRelationshipTypeCodes TypeCode
        {
            get
            {
                return this.typeCodeField;
            }
            set
            {
                this.typeCodeField = value;
            }
        }

        [XmlAttribute("inversionInd")]
        public bool InversionInd
        {
            get
            {
                return this.inversionIndField;
            }
            set
            {
                this.inversionIndField = value;
            }
        }

        [XmlIgnore()]
        public bool InversionIndSpecified
        {
            get
            {
                return this.inversionIndFieldSpecified;
            }
            set
            {
                this.inversionIndFieldSpecified = value;
            }
        }

        [XmlAttribute("contextConductionInd")]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool ContextConductionInd
        {
            get
            {
                return this.contextConductionIndField;
            }
            set
            {
                this.contextConductionIndField = value;
            }
        }

        [XmlAttribute("negationInd")]
        public bool NegationInd
        {
            get
            {
                return this.negationIndField;
            }
            set
            {
                this.negationIndField = value;
            }
        }

        [XmlIgnore()]
        public bool NegationIndSpecified
        {
            get
            {
                return this.negationIndFieldSpecified;
            }
            set
            {
                this.negationIndFieldSpecified = value;
            }
        }
    }

    [XmlIncludeAttribute(typeof(RegionOfInterestvalue))]
    [XmlIncludeAttribute(typeof(IVXB_INT))]
    [XmlIncludeAttribute(typeof(SXCM_INT))]
    [XmlIncludeAttribute(typeof(IVL_INT))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn:hl7-org:v3")]
    public partial class INT : QTY
    {

        private string valueField;

        [XmlAttribute(AttributeName = "value", DataType = "integer")]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName = ".RegionOfInterest.value", Namespace = "urn:hl7-org:v3")]
    public partial class RegionOfInterestvalue : INT
    {

        private bool unsortedField;

        public RegionOfInterestvalue()
        {
            this.unsortedField = false;
        }

        [XmlAttribute("unsorted")]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool Unsorted
        {
            get
            {
                return this.unsortedField;
            }
            set
            {
                this.unsortedField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn:hl7-org:v3")]
    public partial class IVXB_INT : INT
    {

        private bool inclusiveField;

        public IVXB_INT()
        {
            this.inclusiveField = true;
        }

        [XmlAttribute("inclusive")]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool Inclusive
        {
            get
            {
                return this.inclusiveField;
            }
            set
            {
                this.inclusiveField = value;
            }
        }
    }

    [XmlIncludeAttribute(typeof(IVL_INT))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn:hl7-org:v3")]
    public partial class SXCM_INT : INT
    {

        private Operators operatorField;

        public SXCM_INT()
        {
            this.operatorField = Operators.I;
        }

        [XmlAttribute("operator")]
        [System.ComponentModel.DefaultValueAttribute(Operators.I)]
        public Operators Operator
        {
            get
            {
                return this.operatorField;
            }
            set
            {
                this.operatorField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn:hl7-org:v3")]
    public partial class IVL_INT : SXCM_INT
    {

        private INT[] itemsField;

        private ItemsChoiceType[] itemsElementNameField;

        [XmlElement("center", typeof(INT))]
        [XmlElement("high", typeof(IVXB_INT))]
        [XmlElement("low", typeof(IVXB_INT))]
        [XmlElement("width", typeof(INT))]
        [XmlChoiceIdentifierAttribute("ItemsElementName")]
        public INT[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        [XmlElement("ItemsElementName")]
        [XmlIgnore()]
        public ItemsChoiceType[] ItemsElementName
        {
            get
            {
                return this.itemsElementNameField;
            }
            set
            {
                this.itemsElementNameField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn:hl7-org:v3")]
    public partial class BL : ANY
    {

        private bool valueField;

        private bool valueFieldSpecified;

        [XmlAttribute("value")]
        public bool Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }

        [XmlIgnore()]
        public bool ValueSpecified
        {
            get
            {
                return this.valueFieldSpecified;
            }
            set
            {
                this.valueFieldSpecified = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName = ".Encounter", Namespace = "urn:hl7-org:v3")]
    public partial class Encounter : IClinicalStatement
    {

        private List<CS> realmCodeField;

        private InfrastructureRootTypeId typeIdField;

        private List<II> templateIdField;

        private List<II> idField;

        private CD codeField;

        private ED textField;

        private CS statusCodeField;

        private IVL_TS effectiveTimeField;

        private CE priorityCodeField;

        private Subject subjectField;

        private List<Specimen> specimenField;

        private List<Performer2> performerField;

        private List<Author> authorField;

        private List<Informant12> informantField;

        private List<Participant2> participantField;

        private List<EntryRelationship> entryRelationshipField;

        private List<Reference> referenceField;

        private List<Precondition> preconditionField;

        private string nullFlavorField;

        private string classCodeField;

        private EncounterMoodCodes moodCodeField;

        [XmlElement("realmCode")]
        public List<CS> RealmCodes
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.realmCodeField == null)
                    this.realmCodeField = new List<CS>();

                return this.realmCodeField;
            }
            set
            {
                this.realmCodeField = value;
            }
        }

        [XmlElement("typeId")]
        public InfrastructureRootTypeId TypeId
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.typeIdField == null)
                    this.typeIdField = new InfrastructureRootTypeId();

                return this.typeIdField;
            }
            set
            {
                this.typeIdField = value;
            }
        }

        [XmlElement("templateId")]
        public List<II> TemplateIds
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.templateIdField == null)
                    this.templateIdField = new List<II>();

                return this.templateIdField;
            }
            set
            {
                this.templateIdField = value;
            }
        }

        [XmlElement("id")]
        public List<II> Ids
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.idField == null)
                    this.idField = new List<II>();

                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        [XmlElement("code")]
        public CD Code
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.codeField == null)
                    this.codeField = new CD();

                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }

        [XmlElement("text")]
        public ED Text
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.textField == null)
                    this.textField = new ED();

                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }

        [XmlElement("statusCode")]
        public CS StatusCode
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.statusCodeField == null)
                    this.statusCodeField = new CS();

                return this.statusCodeField;
            }
            set
            {
                this.statusCodeField = value;
            }
        }

        [XmlElement("effectiveTime")]
        public IVL_TS EffectiveTime
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.effectiveTimeField == null)
                    this.effectiveTimeField = new IVL_TS();

                return this.effectiveTimeField;
            }
            set
            {
                this.effectiveTimeField = value;
            }
        }

        [XmlElement("priorityCode")]
        public CE PriorityCode
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.priorityCodeField == null)
                    this.priorityCodeField = new CE();

                return this.priorityCodeField;
            }
            set
            {
                this.priorityCodeField = value;
            }
        }

        [XmlElement("subject")]
        public Subject Subject
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.subjectField == null)
                    this.subjectField = new Subject();

                return this.subjectField;
            }
            set
            {
                this.subjectField = value;
            }
        }

        [XmlElement("specimen")]
        public List<Specimen> Specimens
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.specimenField == null)
                    this.specimenField = new List<Specimen>();

                return this.specimenField;
            }
            set
            {
                this.specimenField = value;
            }
        }

        [XmlElement("performer")]
        public List<Performer2> Performers
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.performerField == null)
                    this.performerField = new List<Performer2>();

                return this.performerField;
            }
            set
            {
                this.performerField = value;
            }
        }

        [XmlElement("author")]
        public List<Author> Authors
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.authorField == null)
                    this.authorField = new List<Author>();

                return this.authorField;
            }
            set
            {
                this.authorField = value;
            }
        }

        [XmlElement("informant")]
        public List<Informant12> Informants
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.informantField == null)
                    this.informantField = new List<Informant12>();

                return this.informantField;
            }
            set
            {
                this.informantField = value;
            }
        }

        [XmlElement("participant")]
        public List<Participant2> Participants
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.participantField == null)
                    this.participantField = new List<Participant2>();

                return this.participantField;
            }
            set
            {
                this.participantField = value;
            }
        }

        [XmlElement("entryRelationship")]
        public List<EntryRelationship> EntryRelationships
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.entryRelationshipField == null)
                    this.entryRelationshipField = new List<EntryRelationship>();

                return this.entryRelationshipField;
            }
            set
            {
                this.entryRelationshipField = value;
            }
        }

        [XmlElement("reference")]
        public List<Reference> References
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.referenceField == null)
                    this.referenceField = new List<Reference>();

                return this.referenceField;
            }
            set
            {
                this.referenceField = value;
            }
        }

        [XmlElement("precondition")]
        public List<Precondition> Preconditions
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.preconditionField == null)
                    this.preconditionField = new List<Precondition>();

                return this.preconditionField;
            }
            set
            {
                this.preconditionField = value;
            }
        }

        [XmlAttribute("nullFlavor")]
        public string NullFlavor
        {
            get
            {
                return this.nullFlavorField;
            }
            set
            {
                this.nullFlavorField = value;
            }
        }

        [XmlAttribute("classCode")]
        public string ClassCode
        {
            get
            {
                return this.classCodeField;
            }
            set
            {
                this.classCodeField = value;
            }
        }

        [XmlAttribute("moodCode")]
        public EncounterMoodCodes MoodCode
        {
            get
            {
                return this.moodCodeField;
            }
            set
            {
                this.moodCodeField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName = ".Reference", Namespace = "urn:hl7-org:v3")]
    public partial class Reference
    {

        private List<CS> realmCodeField;

        private InfrastructureRootTypeId typeIdField;

        private List<II> templateIdField;

        private BL seperatableIndField;

        private object itemField;

        private string nullFlavorField;

        private ReferenceTypeCodes typeCodeField;

        [XmlElement("realmCode")]
        public List<CS> RealmCodes
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.realmCodeField == null)
                    this.realmCodeField = new List<CS>();

                return this.realmCodeField;
            }
            set
            {
                this.realmCodeField = value;
            }
        }

        [XmlElement("typeId")]
        public InfrastructureRootTypeId TypeId
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.typeIdField == null)
                    this.typeIdField = new InfrastructureRootTypeId();

                return this.typeIdField;
            }
            set
            {
                this.typeIdField = value;
            }
        }

        [XmlElement("templateId")]
        public List<II> TemplateIds
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.templateIdField == null)
                    this.templateIdField = new List<II>();

                return this.templateIdField;
            }
            set
            {
                this.templateIdField = value;
            }
        }

        [XmlElement("seperatableInd")]
        public BL SeperatableInd
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.seperatableIndField == null)
                    this.seperatableIndField = new BL();

                return this.seperatableIndField;
            }
            set
            {
                this.seperatableIndField = value;
            }
        }

        [XmlElement("externalAct", typeof(ExternalAct))]
        [XmlElement("externalDocument", typeof(ExternalDocument))]
        [XmlElement("externalObservation", typeof(ExternalObservation))]
        [XmlElement("externalProcedure", typeof(ExternalProcedure))]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        [XmlAttribute("nullFlavor")]
        public string NullFlavor
        {
            get
            {
                return this.nullFlavorField;
            }
            set
            {
                this.nullFlavorField = value;
            }
        }

        [XmlAttribute("typeCode")]
        public ReferenceTypeCodes TypeCode
        {
            get
            {
                return this.typeCodeField;
            }
            set
            {
                this.typeCodeField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName = ".ExternalAct", Namespace = "urn:hl7-org:v3")]
    public partial class ExternalAct
    {

        private List<CS> realmCodeField;

        private InfrastructureRootTypeId typeIdField;

        private List<II> templateIdField;

        private List<II> idField;

        private CD codeField;

        private ED textField;

        private string nullFlavorField;

        private string classCodeField;

        private string moodCodeField;

        public ExternalAct()
        {
            this.classCodeField = "ACT";
            this.moodCodeField = "EVN";
        }

        [XmlElement("realmCode")]
        public List<CS> RealmCodes
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.realmCodeField == null)
                    this.realmCodeField = new List<CS>();

                return this.realmCodeField;
            }
            set
            {
                this.realmCodeField = value;
            }
        }

        [XmlElement("typeId")]
        public InfrastructureRootTypeId TypeId
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.typeIdField == null)
                    this.typeIdField = new InfrastructureRootTypeId();

                return this.typeIdField;
            }
            set
            {
                this.typeIdField = value;
            }
        }

        [XmlElement("templateId")]
        public List<II> TemplateIds
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.templateIdField == null)
                    this.templateIdField = new List<II>();

                return this.templateIdField;
            }
            set
            {
                this.templateIdField = value;
            }
        }

        [XmlElement("id")]
        public List<II> Ids
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.idField == null)
                    this.idField = new List<II>();

                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        [XmlElement("code")]
        public CD Code
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.codeField == null)
                    this.codeField = new CD();

                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }

        [XmlElement("text")]
        public ED Text
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.textField == null)
                    this.textField = new ED();

                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }

        [XmlAttribute("nullFlavor")]
        public string NullFlavor
        {
            get
            {
                return this.nullFlavorField;
            }
            set
            {
                this.nullFlavorField = value;
            }
        }

        [XmlAttribute("classCode")]
        [System.ComponentModel.DefaultValueAttribute("ACT")]
        public string ClassCode
        {
            get
            {
                return this.classCodeField;
            }
            set
            {
                this.classCodeField = value;
            }
        }

        [XmlAttribute("moodCode")]
        public string MoodCode
        {
            get
            {
                return this.moodCodeField;
            }
            set
            {
                this.moodCodeField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName = ".ExternalDocument", Namespace = "urn:hl7-org:v3")]
    public partial class ExternalDocument
    {

        private List<CS> realmCodeField;

        private InfrastructureRootTypeId typeIdField;

        private List<II> templateIdField;

        private List<II> idField;

        private CD codeField;

        private ED textField;

        private II setIdField;

        private INT versionNumberField;

        private string nullFlavorField;

        private string classCodeField;

        private string moodCodeField;

        public ExternalDocument()
        {
            this.classCodeField = "DOC";
            this.moodCodeField = "EVN";
        }

        [XmlElement("realmCode")]
        public List<CS> RealmCodes
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.realmCodeField == null)
                    this.realmCodeField = new List<CS>();

                return this.realmCodeField;
            }
            set
            {
                this.realmCodeField = value;
            }
        }

        [XmlElement("typeId")]
        public InfrastructureRootTypeId TypeId
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.typeIdField == null)
                    this.typeIdField = new InfrastructureRootTypeId();

                return this.typeIdField;
            }
            set
            {
                this.typeIdField = value;
            }
        }

        [XmlElement("templateId")]
        public List<II> TemplateIds
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.templateIdField == null)
                    this.templateIdField = new List<II>();

                return this.templateIdField;
            }
            set
            {
                this.templateIdField = value;
            }
        }

        [XmlElement("id")]
        public List<II> Ids
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.idField == null)
                    this.idField = new List<II>();

                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        [XmlElement("code")]
        public CD Code
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.codeField == null)
                    this.codeField = new CD();

                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }

        [XmlElement("text")]
        public ED Text
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.textField == null)
                    this.textField = new ED();

                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }

        [XmlElement("setId")]
        public II SetId
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.setIdField == null)
                    this.setIdField = new II();

                return this.setIdField;
            }
            set
            {
                this.setIdField = value;
            }
        }

        [XmlElement("versionNumber")]
        public INT VersionNumber
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.versionNumberField == null)
                    this.versionNumberField = new INT();

                return this.versionNumberField;
            }
            set
            {
                this.versionNumberField = value;
            }
        }

        [XmlAttribute("nullFlavor")]
        public string NullFlavor
        {
            get
            {
                return this.nullFlavorField;
            }
            set
            {
                this.nullFlavorField = value;
            }
        }

        [XmlAttribute("classCode")]
        [System.ComponentModel.DefaultValueAttribute("DOC")]
        public string ClassCode
        {
            get
            {
                return this.classCodeField;
            }
            set
            {
                this.classCodeField = value;
            }
        }

        [XmlAttribute("moodCode")]
        public string MoodCode
        {
            get
            {
                return this.moodCodeField;
            }
            set
            {
                this.moodCodeField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName = ".ExternalObservation", Namespace = "urn:hl7-org:v3")]
    public partial class ExternalObservation
    {

        private List<CS> realmCodeField;

        private InfrastructureRootTypeId typeIdField;

        private List<II> templateIdField;

        private List<II> idField;

        private CD codeField;

        private ED textField;

        private string nullFlavorField;

        private string classCodeField;

        private string moodCodeField;

        public ExternalObservation()
        {
            this.classCodeField = "OBS";
            this.moodCodeField = "EVN";
        }

        [XmlElement("realmCode")]
        public List<CS> RealmCodes
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.realmCodeField == null)
                    this.realmCodeField = new List<CS>();

                return this.realmCodeField;
            }
            set
            {
                this.realmCodeField = value;
            }
        }

        [XmlElement("typeId")]
        public InfrastructureRootTypeId TypeId
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.typeIdField == null)
                    this.typeIdField = new InfrastructureRootTypeId();

                return this.typeIdField;
            }
            set
            {
                this.typeIdField = value;
            }
        }

        [XmlElement("templateId")]
        public List<II> TemplateIds
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.templateIdField == null)
                    this.templateIdField = new List<II>();

                return this.templateIdField;
            }
            set
            {
                this.templateIdField = value;
            }
        }

        [XmlElement("id")]
        public List<II> Ids
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.idField == null)
                    this.idField = new List<II>();

                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        [XmlElement("code")]
        public CD Code
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.codeField == null)
                    this.codeField = new CD();

                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }

        [XmlElement("text")]
        public ED Text
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.textField == null)
                    this.textField = new ED();

                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }

        [XmlAttribute("nullFlavor")]
        public string NullFlavor
        {
            get
            {
                return this.nullFlavorField;
            }
            set
            {
                this.nullFlavorField = value;
            }
        }

        [XmlAttribute("classCode")]
        [System.ComponentModel.DefaultValueAttribute("OBS")]
        public string ClassCode
        {
            get
            {
                return this.classCodeField;
            }
            set
            {
                this.classCodeField = value;
            }
        }

        [XmlAttribute("moodCode")]
        public string MoodCode
        {
            get
            {
                return this.moodCodeField;
            }
            set
            {
                this.moodCodeField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName = ".ExternalProcedure", Namespace = "urn:hl7-org:v3")]
    public partial class ExternalProcedure
    {

        private List<CS> realmCodeField;

        private InfrastructureRootTypeId typeIdField;

        private List<II> templateIdField;

        private List<II> idField;

        private CD codeField;

        private ED textField;

        private string nullFlavorField;

        private string classCodeField;

        private string moodCodeField;

        public ExternalProcedure()
        {
            this.classCodeField = "PROC";
            this.moodCodeField = "EVN";
        }

        [XmlElement("realmCode")]
        public List<CS> RealmCodes
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.realmCodeField == null)
                    this.realmCodeField = new List<CS>();

                return this.realmCodeField;
            }
            set
            {
                this.realmCodeField = value;
            }
        }

        [XmlElement("typeId")]
        public InfrastructureRootTypeId TypeId
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.typeIdField == null)
                    this.typeIdField = new InfrastructureRootTypeId();

                return this.typeIdField;
            }
            set
            {
                this.typeIdField = value;
            }
        }

        [XmlElement("templateId")]
        public List<II> TemplateIds
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.templateIdField == null)
                    this.templateIdField = new List<II>();

                return this.templateIdField;
            }
            set
            {
                this.templateIdField = value;
            }
        }

        [XmlElement("id")]
        public List<II> Ids
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.idField == null)
                    this.idField = new List<II>();

                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        [XmlElement("code")]
        public CD Code
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.codeField == null)
                    this.codeField = new CD();

                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }

        [XmlElement("text")]
        public ED Text
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.textField == null)
                    this.textField = new ED();

                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }

        [XmlAttribute("nullFlavor")]
        public string NullFlavor
        {
            get
            {
                return this.nullFlavorField;
            }
            set
            {
                this.nullFlavorField = value;
            }
        }

        [XmlAttribute("classCode")]
        public string ClassCode
        {
            get
            {
                return this.classCodeField;
            }
            set
            {
                this.classCodeField = value;
            }
        }

        [XmlAttribute("moodCode")]
        public string MoodCode
        {
            get
            {
                return this.moodCodeField;
            }
            set
            {
                this.moodCodeField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName = ".Precondition", Namespace = "urn:hl7-org:v3")]
    public partial class Precondition
    {

        private List<CS> realmCodeField;

        private InfrastructureRootTypeId typeIdField;

        private List<II> templateIdField;

        private Criterion criterionField;

        private string nullFlavorField;

        private string typeCodeField;

        public Precondition()
        {
            this.typeCodeField = "PRCN";
        }

        [XmlElement("realmCode")]
        public List<CS> RealmCodes
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.realmCodeField == null)
                    this.realmCodeField = new List<CS>();

                return this.realmCodeField;
            }
            set
            {
                this.realmCodeField = value;
            }
        }

        [XmlElement("typeId")]
        public InfrastructureRootTypeId TypeId
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.typeIdField == null)
                    this.typeIdField = new InfrastructureRootTypeId();

                return this.typeIdField;
            }
            set
            {
                this.typeIdField = value;
            }
        }

        [XmlElement("templateId")]
        public List<II> TemplateIds
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.templateIdField == null)
                    this.templateIdField = new List<II>();

                return this.templateIdField;
            }
            set
            {
                this.templateIdField = value;
            }
        }

        [XmlElement("criterion")]
        public Criterion Criterion
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.criterionField == null)
                    this.criterionField = new Criterion();

                return this.criterionField;
            }
            set
            {
                this.criterionField = value;
            }
        }

        [XmlAttribute("nullFlavor")]
        public string NullFlavor
        {
            get
            {
                return this.nullFlavorField;
            }
            set
            {
                this.nullFlavorField = value;
            }
        }

        [XmlAttribute("typeCode")]
        public string TypeCode
        {
            get
            {
                return this.typeCodeField;
            }
            set
            {
                this.typeCodeField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName = ".Criterion", Namespace = "urn:hl7-org:v3")]
    public partial class Criterion
    {

        private List<CS> realmCodeField;

        private InfrastructureRootTypeId typeIdField;

        private List<II> templateIdField;

        private CD codeField;

        private ED textField;

        private ANY valueField;

        private string nullFlavorField;

        private string classCodeField;

        private string moodCodeField;

        public Criterion()
        {
            this.classCodeField = "OBS";
            this.moodCodeField = "EVN.CRT";
        }

        [XmlElement("realmCode")]
        public List<CS> RealmCodes
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.realmCodeField == null)
                    this.realmCodeField = new List<CS>();

                return this.realmCodeField;
            }
            set
            {
                this.realmCodeField = value;
            }
        }

        [XmlElement("typeId")]
        public InfrastructureRootTypeId TypeId
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.typeIdField == null)
                    this.typeIdField = new InfrastructureRootTypeId();

                return this.typeIdField;
            }
            set
            {
                this.typeIdField = value;
            }
        }

        [XmlElement("templateId")]
        public List<II> TemplateIds
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.templateIdField == null)
                    this.templateIdField = new List<II>();

                return this.templateIdField;
            }
            set
            {
                this.templateIdField = value;
            }
        }

        [XmlElement("code")]
        public CD Code
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.codeField == null)
                    this.codeField = new CD();

                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }

        [XmlElement("text")]
        public ED Text
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.textField == null)
                    this.textField = new ED();

                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }

        [XmlElement("value")]
        public ANY Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }

        [XmlAttribute("nullFlavor")]
        public string NullFlavor
        {
            get
            {
                return this.nullFlavorField;
            }
            set
            {
                this.nullFlavorField = value;
            }
        }

        [XmlAttribute("classCode")]
        [System.ComponentModel.DefaultValueAttribute("OBS")]
        public string ClassCode
        {
            get
            {
                return this.classCodeField;
            }
            set
            {
                this.classCodeField = value;
            }
        }

        [XmlAttribute("moodCode")]
        public string MoodCode
        {
            get
            {
                return this.moodCodeField;
            }
            set
            {
                this.moodCodeField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName = ".Observation", Namespace = "urn:hl7-org:v3")]
    public partial class Observation : IClinicalStatement
    {

        private List<CS> realmCodeField;

        private InfrastructureRootTypeId typeIdField;

        private List<II> templateIdField;

        private List<II> idField;

        private CD codeField;

        private ST derivationExprField;

        private ED textField;

        private CS statusCodeField;

        private IVL_TS effectiveTimeField;

        private CE priorityCodeField;

        private IVL_INT repeatNumberField;

        private CS languageCodeField;

        private ANY[] valueField;

        private List<CE> interpretationCodeField;

        private List<CE> methodCodeField;

        private List<CD> targetSiteCodeField;

        private Subject subjectField;

        private List<Specimen> specimenField;

        private List<Performer2> performerField;

        private List<Author> authorField;

        private List<Informant12> informantField;

        private List<Participant2> participantField;

        private List<EntryRelationship> entryRelationshipField;

        private List<Reference> referenceField;

        private List<Precondition> preconditionField;

        private List<ReferenceRange> referenceRangeField;

        private string nullFlavorField;

        private string classCodeField;

        private ObservationMoodCodes moodCodeField;

        private bool negationIndField;

        private bool negationIndFieldSpecified;

        [XmlElement("realmCode")]
        public List<CS> RealmCodes
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.realmCodeField == null)
                    this.realmCodeField = new List<CS>();

                return this.realmCodeField;
            }
            set
            {
                this.realmCodeField = value;
            }
        }

        [XmlElement("typeId")]
        public InfrastructureRootTypeId TypeId
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.typeIdField == null)
                    this.typeIdField = new InfrastructureRootTypeId();

                return this.typeIdField;
            }
            set
            {
                this.typeIdField = value;
            }
        }

        [XmlElement("templateId")]
        public List<II> TemplateIds
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.templateIdField == null)
                    this.templateIdField = new List<II>();

                return this.templateIdField;
            }
            set
            {
                this.templateIdField = value;
            }
        }

        [XmlElement("id")]
        public List<II> Ids
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.idField == null)
                    this.idField = new List<II>();

                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        [XmlElement("code")]
        public CD Code
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.codeField == null)
                    this.codeField = new CD();

                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }

        [XmlElement("derivationExpr")]
        public ST DerivationExpr
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.derivationExprField == null)
                    this.derivationExprField = new ST();

                return this.derivationExprField;
            }
            set
            {
                this.derivationExprField = value;
            }
        }

        [XmlElement("text")]
        public ED Text
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.textField == null)
                    this.textField = new ED();

                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }

        [XmlElement("statusCode")]
        public CS StatusCode
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.statusCodeField == null)
                    this.statusCodeField = new CS();

                return this.statusCodeField;
            }
            set
            {
                this.statusCodeField = value;
            }
        }

        [XmlElement("effectiveTime")]
        public IVL_TS EffectiveTime
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.effectiveTimeField == null)
                    this.effectiveTimeField = new IVL_TS();

                return this.effectiveTimeField;
            }
            set
            {
                this.effectiveTimeField = value;
            }
        }

        [XmlElement("priorityCode")]
        public CE PriorityCode
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.priorityCodeField == null)
                    this.priorityCodeField = new CE();

                return this.priorityCodeField;
            }
            set
            {
                this.priorityCodeField = value;
            }
        }

        [XmlElement("repeatNumber")]
        public IVL_INT RepeatNumber
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.repeatNumberField == null)
                    this.repeatNumberField = new IVL_INT();

                return this.repeatNumberField;
            }
            set
            {
                this.repeatNumberField = value;
            }
        }

        [XmlElement("languageCode")]
        public CS LanguageCode
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.languageCodeField == null)
                    this.languageCodeField = new CS();

                return this.languageCodeField;
            }
            set
            {
                this.languageCodeField = value;
            }
        }

        [XmlElement("value")]
        public ANY[] Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }

        [XmlElement("interpretationCode")]
        public List<CE> InterpretationCodes
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.interpretationCodeField == null)
                    this.interpretationCodeField = new List<CE>();

                return this.interpretationCodeField;
            }
            set
            {
                this.interpretationCodeField = value;
            }
        }

        [XmlElement("methodCode")]
        public List<CE> MethodCodes
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.methodCodeField == null)
                    this.methodCodeField = new List<CE>();

                return this.methodCodeField;
            }
            set
            {
                this.methodCodeField = value;
            }
        }

        [XmlElement("targetSiteCode")]
        public List<CD> TargetSiteCodes
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.targetSiteCodeField == null)
                    this.targetSiteCodeField = new List<CD>();

                return this.targetSiteCodeField;
            }
            set
            {
                this.targetSiteCodeField = value;
            }
        }

        [XmlElement("subject")]
        public Subject Subject
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.subjectField == null)
                    this.subjectField = new Subject();

                return this.subjectField;
            }
            set
            {
                this.subjectField = value;
            }
        }

        [XmlElement("specimen")]
        public List<Specimen> Specimens
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.specimenField == null)
                    this.specimenField = new List<Specimen>();

                return this.specimenField;
            }
            set
            {
                this.specimenField = value;
            }
        }

        [XmlElement("performer")]
        public List<Performer2> Performers
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.performerField == null)
                    this.performerField = new List<Performer2>();

                return this.performerField;
            }
            set
            {
                this.performerField = value;
            }
        }

        [XmlElement("author")]
        public List<Author> Authors
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.authorField == null)
                    this.authorField = new List<Author>();

                return this.authorField;
            }
            set
            {
                this.authorField = value;
            }
        }

        [XmlElement("informant")]
        public List<Informant12> Informants
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.informantField == null)
                    this.informantField = new List<Informant12>();

                return this.informantField;
            }
            set
            {
                this.informantField = value;
            }
        }

        [XmlElement("participant")]
        public List<Participant2> Participants
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.participantField == null)
                    this.participantField = new List<Participant2>();

                return this.participantField;
            }
            set
            {
                this.participantField = value;
            }
        }

        [XmlElement("entryRelationship")]
        public List<EntryRelationship> EntryRelationships
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.entryRelationshipField == null)
                    this.entryRelationshipField = new List<EntryRelationship>();

                return this.entryRelationshipField;
            }
            set
            {
                this.entryRelationshipField = value;
            }
        }

        [XmlElement("reference")]
        public List<Reference> References
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.referenceField == null)
                    this.referenceField = new List<Reference>();

                return this.referenceField;
            }
            set
            {
                this.referenceField = value;
            }
        }

        [XmlElement("precondition")]
        public List<Precondition> Preconditions
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.preconditionField == null)
                    this.preconditionField = new List<Precondition>();

                return this.preconditionField;
            }
            set
            {
                this.preconditionField = value;
            }
        }

        [XmlElement("referenceRange")]
        public List<ReferenceRange> ReferenceRanges
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.referenceRangeField == null)
                    this.referenceRangeField = new List<ReferenceRange>();

                return this.referenceRangeField;
            }
            set
            {
                this.referenceRangeField = value;
            }
        }

        [XmlAttribute("nullFlavor")]
        public string NullFlavor
        {
            get
            {
                return this.nullFlavorField;
            }
            set
            {
                this.nullFlavorField = value;
            }
        }

        [XmlAttribute("classCode")]
        public string ClassCode
        {
            get
            {
                return this.classCodeField;
            }
            set
            {
                this.classCodeField = value;
            }
        }

        [XmlAttribute("moodCode")]
        public ObservationMoodCodes MoodCode
        {
            get
            {
                return this.moodCodeField;
            }
            set
            {
                this.moodCodeField = value;
            }
        }

        [XmlAttribute("negationInd")]
        public bool NegationInd
        {
            get
            {
                return this.negationIndField;
            }
            set
            {
                this.negationIndField = value;
            }
        }

        [XmlIgnore()]
        public bool NegationIndSpecified
        {
            get
            {
                return this.negationIndFieldSpecified;
            }
            set
            {
                this.negationIndFieldSpecified = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName = ".ReferenceRange", Namespace = "urn:hl7-org:v3")]
    public partial class ReferenceRange
    {

        private List<CS> realmCodeField;

        private InfrastructureRootTypeId typeIdField;

        private List<II> templateIdField;

        private ObservationRange observationRangeField;

        private string nullFlavorField;

        private string typeCodeField;

        public ReferenceRange()
        {
            this.typeCodeField = "REFV";
        }

        [XmlElement("realmCode")]
        public List<CS> RealmCodes
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.realmCodeField == null)
                    this.realmCodeField = new List<CS>();

                return this.realmCodeField;
            }
            set
            {
                this.realmCodeField = value;
            }
        }

        [XmlElement("typeId")]
        public InfrastructureRootTypeId TypeId
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.typeIdField == null)
                    this.typeIdField = new InfrastructureRootTypeId();

                return this.typeIdField;
            }
            set
            {
                this.typeIdField = value;
            }
        }

        [XmlElement("templateId")]
        public List<II> TemplateIds
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.templateIdField == null)
                    this.templateIdField = new List<II>();

                return this.templateIdField;
            }
            set
            {
                this.templateIdField = value;
            }
        }

        [XmlElement("observationRange")]
        public ObservationRange ObservationRange
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.observationRangeField == null)
                    this.observationRangeField = new ObservationRange();

                return this.observationRangeField;
            }
            set
            {
                this.observationRangeField = value;
            }
        }

        [XmlAttribute("nullFlavor")]
        public string NullFlavor
        {
            get
            {
                return this.nullFlavorField;
            }
            set
            {
                this.nullFlavorField = value;
            }
        }

        [XmlAttribute("typeCode")]
        public string TypeCode
        {
            get
            {
                return this.typeCodeField;
            }
            set
            {
                this.typeCodeField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName = ".ObservationRange", Namespace = "urn:hl7-org:v3")]
    public partial class ObservationRange
    {

        private List<CS> realmCodeField;

        private InfrastructureRootTypeId typeIdField;

        private List<II> templateIdField;

        private CD codeField;

        private ED textField;

        private ANY valueField;

        private CE interpretationCodeField;

        private string nullFlavorField;

        private string classCodeField;

        private string moodCodeField;

        public ObservationRange()
        {
            this.classCodeField = "OBS";
            this.moodCodeField = "EVN.CRT";
        }

        [XmlElement("realmCode")]
        public List<CS> RealmCodes
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.realmCodeField == null)
                    this.realmCodeField = new List<CS>();

                return this.realmCodeField;
            }
            set
            {
                this.realmCodeField = value;
            }
        }

        [XmlElement("typeId")]
        public InfrastructureRootTypeId TypeId
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.typeIdField == null)
                    this.typeIdField = new InfrastructureRootTypeId();

                return this.typeIdField;
            }
            set
            {
                this.typeIdField = value;
            }
        }

        [XmlElement("templateId")]
        public List<II> TemplateIds
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.templateIdField == null)
                    this.templateIdField = new List<II>();

                return this.templateIdField;
            }
            set
            {
                this.templateIdField = value;
            }
        }

        [XmlElement("code")]
        public CD Code
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.codeField == null)
                    this.codeField = new CD();

                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }

        [XmlElement("text")]
        public ED Text
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.textField == null)
                    this.textField = new ED();

                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }

        [XmlElement("value")]
        public ANY Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }

        [XmlElement("interpretationCode")]
        public CE InterpretationCode
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.interpretationCodeField == null)
                    this.interpretationCodeField = new CE();

                return this.interpretationCodeField;
            }
            set
            {
                this.interpretationCodeField = value;
            }
        }

        [XmlAttribute("nullFlavor")]
        public string NullFlavor
        {
            get
            {
                return this.nullFlavorField;
            }
            set
            {
                this.nullFlavorField = value;
            }
        }

        [XmlAttribute("classCode")]
        [System.ComponentModel.DefaultValueAttribute("OBS")]
        public string ClassCode
        {
            get
            {
                return this.classCodeField;
            }
            set
            {
                this.classCodeField = value;
            }
        }

        [XmlAttribute("moodCode")]
        public string MoodCode
        {
            get
            {
                return this.moodCodeField;
            }
            set
            {
                this.moodCodeField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName = ".ObservationMedia", Namespace = "urn:hl7-org:v3")]
    public partial class ObservationMedia : IClinicalStatement
    {

        private List<CS> realmCodeField;

        private InfrastructureRootTypeId typeIdField;

        private List<II> templateIdField;

        private List<II> idField;

        private CS languageCodeField;

        private ED valueField;

        private Subject subjectField;

        private List<Specimen> specimenField;

        private List<Performer2> performerField;

        private List<Author> authorField;

        private List<Informant12> informantField;

        private List<Participant2> participantField;

        private List<EntryRelationship> entryRelationshipField;

        private List<Reference> referenceField;

        private List<Precondition> preconditionField;

        private string idField1;

        private string nullFlavorField;

        private string classCodeField;

        private string moodCodeField;

        [XmlElement("realmCode")]
        public List<CS> RealmCodes
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.realmCodeField == null)
                    this.realmCodeField = new List<CS>();

                return this.realmCodeField;
            }
            set
            {
                this.realmCodeField = value;
            }
        }

        [XmlElement("typeId")]
        public InfrastructureRootTypeId TypeId
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.typeIdField == null)
                    this.typeIdField = new InfrastructureRootTypeId();

                return this.typeIdField;
            }
            set
            {
                this.typeIdField = value;
            }
        }

        [XmlElement("templateId")]
        public List<II> TemplateIds
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.templateIdField == null)
                    this.templateIdField = new List<II>();

                return this.templateIdField;
            }
            set
            {
                this.templateIdField = value;
            }
        }

        [XmlElement("id")]
        public List<II> Ids
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.idField == null)
                    this.idField = new List<II>();

                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        [XmlElement("languageCode")]
        public CS LanguageCode
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.languageCodeField == null)
                    this.languageCodeField = new CS();

                return this.languageCodeField;
            }
            set
            {
                this.languageCodeField = value;
            }
        }

        [XmlElement("value")]
        public ED Value
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.valueField == null)
                    this.valueField = new ED();

                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }

        [XmlElement("subject")]
        public Subject Subject
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.subjectField == null)
                    this.subjectField = new Subject();

                return this.subjectField;
            }
            set
            {
                this.subjectField = value;
            }
        }

        [XmlElement("specimen")]
        public List<Specimen> Specimens
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.specimenField == null)
                    this.specimenField = new List<Specimen>();

                return this.specimenField;
            }
            set
            {
                this.specimenField = value;
            }
        }

        [XmlElement("performer")]
        public List<Performer2> Performers
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.performerField == null)
                    this.performerField = new List<Performer2>();

                return this.performerField;
            }
            set
            {
                this.performerField = value;
            }
        }

        [XmlElement("author")]
        public List<Author> Authors
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.authorField == null)
                    this.authorField = new List<Author>();

                return this.authorField;
            }
            set
            {
                this.authorField = value;
            }
        }

        [XmlElement("informant")]
        public List<Informant12> Informants
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.informantField == null)
                    this.informantField = new List<Informant12>();

                return this.informantField;
            }
            set
            {
                this.informantField = value;
            }
        }

        [XmlElement("participant")]
        public List<Participant2> Participants
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.participantField == null)
                    this.participantField = new List<Participant2>();

                return this.participantField;
            }
            set
            {
                this.participantField = value;
            }
        }

        [XmlElement("entryRelationship")]
        public List<EntryRelationship> EntryRelationships
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.entryRelationshipField == null)
                    this.entryRelationshipField = new List<EntryRelationship>();

                return this.entryRelationshipField;
            }
            set
            {
                this.entryRelationshipField = value;
            }
        }

        [XmlElement("reference")]
        public List<Reference> References
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.referenceField == null)
                    this.referenceField = new List<Reference>();

                return this.referenceField;
            }
            set
            {
                this.referenceField = value;
            }
        }

        [XmlElement("precondition")]
        public List<Precondition> Preconditions
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.preconditionField == null)
                    this.preconditionField = new List<Precondition>();

                return this.preconditionField;
            }
            set
            {
                this.preconditionField = value;
            }
        }

        [XmlAttribute(AttributeName = "ID", DataType = "ID")]
        public string ReferenceId
        {
            get
            {
                return this.idField1;
            }
            set
            {
                this.idField1 = value;
            }
        }

        [XmlAttribute("nullFlavor")]
        public string NullFlavor
        {
            get
            {
                return this.nullFlavorField;
            }
            set
            {
                this.nullFlavorField = value;
            }
        }

        [XmlAttribute("classCode")]
        public string ClassCode
        {
            get
            {
                return this.classCodeField;
            }
            set
            {
                this.classCodeField = value;
            }
        }

        [XmlAttribute("moodCode")]
        public string MoodCode
        {
            get
            {
                return this.moodCodeField;
            }
            set
            {
                this.moodCodeField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName = ".Organizer", Namespace = "urn:hl7-org:v3")]
    public partial class Organizer : IClinicalStatement
    {

        private List<CS> realmCodeField;

        private InfrastructureRootTypeId typeIdField;

        private List<II> templateIdField;

        private List<II> idField;

        private CD codeField;

        private CS statusCodeField;

        private IVL_TS effectiveTimeField;

        private Subject subjectField;

        private List<Specimen> specimenField;

        private List<Performer2> performerField;

        private List<Author> authorField;

        private List<Informant12> informantField;

        private List<Participant2> participantField;

        private List<Reference> referenceField;

        private List<Precondition> preconditionField;

        private Component4[] componentField;

        private string nullFlavorField;

        private OrganizerClassCodes classCodeField;

        private string moodCodeField;

        [XmlElement("realmCode")]
        public List<CS> RealmCodes
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.realmCodeField == null)
                    this.realmCodeField = new List<CS>();

                return this.realmCodeField;
            }
            set
            {
                this.realmCodeField = value;
            }
        }

        [XmlElement("typeId")]
        public InfrastructureRootTypeId TypeId
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.typeIdField == null)
                    this.typeIdField = new InfrastructureRootTypeId();

                return this.typeIdField;
            }
            set
            {
                this.typeIdField = value;
            }
        }

        [XmlElement("templateId")]
        public List<II> TemplateIds
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.templateIdField == null)
                    this.templateIdField = new List<II>();

                return this.templateIdField;
            }
            set
            {
                this.templateIdField = value;
            }
        }

        [XmlElement("id")]
        public List<II> Ids
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.idField == null)
                    this.idField = new List<II>();

                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        [XmlElement("code")]
        public CD Code
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.codeField == null)
                    this.codeField = new CD();

                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }

        [XmlElement("statusCode")]
        public CS StatusCode
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.statusCodeField == null)
                    this.statusCodeField = new CS();

                return this.statusCodeField;
            }
            set
            {
                this.statusCodeField = value;
            }
        }

        [XmlElement("effectiveTime")]
        public IVL_TS EffectiveTime
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.effectiveTimeField == null)
                    this.effectiveTimeField = new IVL_TS();

                return this.effectiveTimeField;
            }
            set
            {
                this.effectiveTimeField = value;
            }
        }

        [XmlElement("subject")]
        public Subject Subject
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.subjectField == null)
                    this.subjectField = new Subject();

                return this.subjectField;
            }
            set
            {
                this.subjectField = value;
            }
        }

        [XmlElement("specimen")]
        public List<Specimen> Specimens
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.specimenField == null)
                    this.specimenField = new List<Specimen>();

                return this.specimenField;
            }
            set
            {
                this.specimenField = value;
            }
        }

        [XmlElement("performer")]
        public List<Performer2> Performers
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.performerField == null)
                    this.performerField = new List<Performer2>();

                return this.performerField;
            }
            set
            {
                this.performerField = value;
            }
        }

        [XmlElement("author")]
        public List<Author> Authors
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.authorField == null)
                    this.authorField = new List<Author>();

                return this.authorField;
            }
            set
            {
                this.authorField = value;
            }
        }

        [XmlElement("informant")]
        public List<Informant12> Informants
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.informantField == null)
                    this.informantField = new List<Informant12>();

                return this.informantField;
            }
            set
            {
                this.informantField = value;
            }
        }

        [XmlElement("participant")]
        public List<Participant2> Participants
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.participantField == null)
                    this.participantField = new List<Participant2>();

                return this.participantField;
            }
            set
            {
                this.participantField = value;
            }
        }

        [XmlElement("reference")]
        public List<Reference> References
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.referenceField == null)
                    this.referenceField = new List<Reference>();

                return this.referenceField;
            }
            set
            {
                this.referenceField = value;
            }
        }

        [XmlElement("precondition")]
        public List<Precondition> Preconditions
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.preconditionField == null)
                    this.preconditionField = new List<Precondition>();

                return this.preconditionField;
            }
            set
            {
                this.preconditionField = value;
            }
        }

        [XmlElement("component")]
        public Component4[] Component
        {
            get
            {
                return this.componentField;
            }
            set
            {
                this.componentField = value;
            }
        }

        [XmlAttribute("nullFlavor")]
        public string NullFlavor
        {
            get
            {
                return this.nullFlavorField;
            }
            set
            {
                this.nullFlavorField = value;
            }
        }

        [XmlAttribute("classCode")]
        public OrganizerClassCodes ClassCode
        {
            get
            {
                return this.classCodeField;
            }
            set
            {
                this.classCodeField = value;
            }
        }

        [XmlAttribute("moodCode")]
        public string MoodCode
        {
            get
            {
                return this.moodCodeField;
            }
            set
            {
                this.moodCodeField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName = ".Component4", Namespace = "urn:hl7-org:v3")]
    public partial class Component4
    {

        private List<CS> realmCodeField;

        private InfrastructureRootTypeId typeIdField;

        private List<II> templateIdField;

        private INT sequenceNumberField;

        private BL seperatableIndField;

        private object itemField;

        private string nullFlavorField;

        private ComponentTypeCodes typeCodeField;

        private bool typeCodeFieldSpecified;

        private bool contextConductionIndField;

        private bool contextConductionIndFieldSpecified;

        public Component4()
        {
            this.typeCodeField = ComponentTypeCodes.COMP;
            this.contextConductionIndField = true;
        }

        [XmlElement("realmCode")]
        public List<CS> RealmCodes
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.realmCodeField == null)
                    this.realmCodeField = new List<CS>();

                return this.realmCodeField;
            }
            set
            {
                this.realmCodeField = value;
            }
        }

        [XmlElement("typeId")]
        public InfrastructureRootTypeId TypeId
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.typeIdField == null)
                    this.typeIdField = new InfrastructureRootTypeId();

                return this.typeIdField;
            }
            set
            {
                this.typeIdField = value;
            }
        }

        [XmlElement("templateId")]
        public List<II> TemplateIds
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.templateIdField == null)
                    this.templateIdField = new List<II>();

                return this.templateIdField;
            }
            set
            {
                this.templateIdField = value;
            }
        }

        [XmlElement("sequenceNumber")]
        public INT SequenceNumber
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.sequenceNumberField == null)
                    this.sequenceNumberField = new INT();

                return this.sequenceNumberField;
            }
            set
            {
                this.sequenceNumberField = value;
            }
        }

        [XmlElement("seperatableInd")]
        public BL SeperatableInd
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.seperatableIndField == null)
                    this.seperatableIndField = new BL();

                return this.seperatableIndField;
            }
            set
            {
                this.seperatableIndField = value;
            }
        }

        [XmlElement("act", typeof(Act))]
        [XmlElement("encounter", typeof(Encounter))]
        [XmlElement("observation", typeof(Observation))]
        [XmlElement("observationMedia", typeof(ObservationMedia))]
        [XmlElement("organizer", typeof(Organizer))]
        [XmlElement("procedure", typeof(Procedure))]
        [XmlElement("regionOfInterest", typeof(RegionOfInterest))]
        [XmlElement("substanceAdministration", typeof(SubstanceAdministration))]
        [XmlElement("supply", typeof(Supply))]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        [XmlAttribute("nullFlavor")]
        public string NullFlavor
        {
            get
            {
                return this.nullFlavorField;
            }
            set
            {
                this.nullFlavorField = value;
            }
        }

        [XmlAttribute("typeCode")]
        public ComponentTypeCodes TypeCode
        {
            get
            {
                return this.typeCodeField;
            }
            set
            {
                this.typeCodeField = value;
            }
        }

        [XmlIgnore()]
        public bool TypeCodeSpecified
        {
            get
            {
                return this.typeCodeFieldSpecified;
            }
            set
            {
                this.typeCodeFieldSpecified = value;
            }
        }

        [XmlAttribute("contextConductionInd")]
        public bool ContextConductionInd
        {
            get
            {
                return this.contextConductionIndField;
            }
            set
            {
                this.contextConductionIndField = value;
            }
        }

        [XmlIgnore()]
        public bool ContextConductionIndSpecified
        {
            get
            {
                return this.contextConductionIndFieldSpecified;
            }
            set
            {
                this.contextConductionIndFieldSpecified = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName = ".Procedure", Namespace = "urn:hl7-org:v3")]
    public partial class Procedure : IClinicalStatement
    {

        private List<CS> realmCodeField;

        private InfrastructureRootTypeId typeIdField;

        private List<II> templateIdField;

        private List<II> idField;

        private CD codeField;

        private ED textField;

        private CS statusCodeField;

        private IVL_TS effectiveTimeField;

        private CE priorityCodeField;

        private CS languageCodeField;

        private List<CE> methodCodeField;

        private List<CD> approachSiteCodeField;

        private List<CD> targetSiteCodeField;

        private Subject subjectField;

        private List<Specimen> specimenField;

        private List<Performer2> performerField;

        private List<Author> authorField;

        private List<Informant12> informantField;

        private List<Participant2> participantField;

        private List<EntryRelationship> entryRelationshipField;

        private List<Reference> referenceField;

        private List<Precondition> preconditionField;

        private string nullFlavorField;

        private string classCodeField;

        private ProcedureMoodCodes moodCodeField;

        private bool negationIndField;

        private bool negationIndFieldSpecified;

        [XmlElement("realmCode")]
        public List<CS> RealmCodes
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.realmCodeField == null)
                    this.realmCodeField = new List<CS>();

                return this.realmCodeField;
            }
            set
            {
                this.realmCodeField = value;
            }
        }

        [XmlElement("typeId")]
        public InfrastructureRootTypeId TypeId
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.typeIdField == null)
                    this.typeIdField = new InfrastructureRootTypeId();

                return this.typeIdField;
            }
            set
            {
                this.typeIdField = value;
            }
        }

        [XmlElement("templateId")]
        public List<II> TemplateIds
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.templateIdField == null)
                    this.templateIdField = new List<II>();

                return this.templateIdField;
            }
            set
            {
                this.templateIdField = value;
            }
        }

        [XmlElement("id")]
        public List<II> Ids
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.idField == null)
                    this.idField = new List<II>();

                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        [XmlElement("code")]
        public CD Code
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.codeField == null)
                    this.codeField = new CD();

                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }

        [XmlElement("text")]
        public ED Text
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.textField == null)
                    this.textField = new ED();

                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }

        [XmlElement("statusCode")]
        public CS StatusCode
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.statusCodeField == null)
                    this.statusCodeField = new CS();

                return this.statusCodeField;
            }
            set
            {
                this.statusCodeField = value;
            }
        }

        [XmlElement("effectiveTime")]
        public IVL_TS EffectiveTime
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.effectiveTimeField == null)
                    this.effectiveTimeField = new IVL_TS();

                return this.effectiveTimeField;
            }
            set
            {
                this.effectiveTimeField = value;
            }
        }

        [XmlElement("priorityCode")]
        public CE PriorityCode
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.priorityCodeField == null)
                    this.priorityCodeField = new CE();

                return this.priorityCodeField;
            }
            set
            {
                this.priorityCodeField = value;
            }
        }

        [XmlElement("languageCode")]
        public CS LanguageCode
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.languageCodeField == null)
                    this.languageCodeField = new CS();

                return this.languageCodeField;
            }
            set
            {
                this.languageCodeField = value;
            }
        }

        [XmlElement("methodCode")]
        public List<CE> MethodCodes
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.methodCodeField == null)
                    this.methodCodeField = new List<CE>();

                return this.methodCodeField;
            }
            set
            {
                this.methodCodeField = value;
            }
        }

        [XmlElement("approachSiteCode")]
        public List<CD> ApproachSiteCodes
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.approachSiteCodeField == null)
                    this.approachSiteCodeField = new List<CD>();

                return this.approachSiteCodeField;
            }
            set
            {
                this.approachSiteCodeField = value;
            }
        }

        [XmlElement("targetSiteCode")]
        public List<CD> TargetSiteCodes
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.targetSiteCodeField == null)
                    this.targetSiteCodeField = new List<CD>();

                return this.targetSiteCodeField;
            }
            set
            {
                this.targetSiteCodeField = value;
            }
        }

        [XmlElement("subject")]
        public Subject Subject
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.subjectField == null)
                    this.subjectField = new Subject();

                return this.subjectField;
            }
            set
            {
                this.subjectField = value;
            }
        }

        [XmlElement("specimen")]
        public List<Specimen> Specimens
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.specimenField == null)
                    this.specimenField = new List<Specimen>();

                return this.specimenField;
            }
            set
            {
                this.specimenField = value;
            }
        }

        [XmlElement("performer")]
        public List<Performer2> Performers
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.performerField == null)
                    this.performerField = new List<Performer2>();

                return this.performerField;
            }
            set
            {
                this.performerField = value;
            }
        }

        [XmlElement("author")]
        public List<Author> Authors
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.authorField == null)
                    this.authorField = new List<Author>();

                return this.authorField;
            }
            set
            {
                this.authorField = value;
            }
        }

        [XmlElement("informant")]
        public List<Informant12> Informants
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.informantField == null)
                    this.informantField = new List<Informant12>();

                return this.informantField;
            }
            set
            {
                this.informantField = value;
            }
        }

        [XmlElement("participant")]
        public List<Participant2> Participants
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.participantField == null)
                    this.participantField = new List<Participant2>();

                return this.participantField;
            }
            set
            {
                this.participantField = value;
            }
        }

        [XmlElement("entryRelationship")]
        public List<EntryRelationship> EntryRelationships
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.entryRelationshipField == null)
                    this.entryRelationshipField = new List<EntryRelationship>();

                return this.entryRelationshipField;
            }
            set
            {
                this.entryRelationshipField = value;
            }
        }

        [XmlElement("reference")]
        public List<Reference> References
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.referenceField == null)
                    this.referenceField = new List<Reference>();

                return this.referenceField;
            }
            set
            {
                this.referenceField = value;
            }
        }

        [XmlElement("precondition")]
        public List<Precondition> Preconditions
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.preconditionField == null)
                    this.preconditionField = new List<Precondition>();

                return this.preconditionField;
            }
            set
            {
                this.preconditionField = value;
            }
        }

        [XmlAttribute("nullFlavor")]
        public string NullFlavor
        {
            get
            {
                return this.nullFlavorField;
            }
            set
            {
                this.nullFlavorField = value;
            }
        }

        [XmlAttribute("classCode")]
        public string ClassCode
        {
            get
            {
                return this.classCodeField;
            }
            set
            {
                this.classCodeField = value;
            }
        }

        [XmlAttribute("moodCode")]
        public ProcedureMoodCodes MoodCode
        {
            get
            {
                return this.moodCodeField;
            }
            set
            {
                this.moodCodeField = value;
            }
        }

        [XmlAttribute("negationInd")]
        public bool NegationInd
        {
            get
            {
                return this.negationIndField;
            }
            set
            {
                this.negationIndField = value;
            }
        }

        [XmlIgnore()]
        public bool NegationIndSpecified
        {
            get
            {
                return this.negationIndFieldSpecified;
            }
            set
            {
                this.negationIndFieldSpecified = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName = ".RegionOfInterest", Namespace = "urn:hl7-org:v3")]
    public partial class RegionOfInterest : IClinicalStatement
    {

        private List<CS> realmCodeField;

        private InfrastructureRootTypeId typeIdField;

        private List<II> templateIdField;

        private List<II> idField;

        private CS codeField;

        private RegionOfInterestvalue[] valueField;

        private Subject subjectField;

        private List<Specimen> specimenField;

        private List<Performer2> performerField;

        private List<Author> authorField;

        private List<Informant12> informantField;

        private List<Participant2> participantField;

        private List<EntryRelationship> entryRelationshipField;

        private List<Reference> referenceField;

        private List<Precondition> preconditionField;

        private string idField1;

        private string nullFlavorField;

        private string classCodeField;

        private string moodCodeField;

        public RegionOfInterest()
        {
            this.classCodeField = "ROIOVL";
            this.moodCodeField = "EVN";
        }

        [XmlElement("realmCode")]
        public List<CS> RealmCodes
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.realmCodeField == null)
                    this.realmCodeField = new List<CS>();

                return this.realmCodeField;
            }
            set
            {
                this.realmCodeField = value;
            }
        }

        [XmlElement("typeId")]
        public InfrastructureRootTypeId TypeId
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.typeIdField == null)
                    this.typeIdField = new InfrastructureRootTypeId();

                return this.typeIdField;
            }
            set
            {
                this.typeIdField = value;
            }
        }

        [XmlElement("templateId")]
        public List<II> TemplateIds
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.templateIdField == null)
                    this.templateIdField = new List<II>();

                return this.templateIdField;
            }
            set
            {
                this.templateIdField = value;
            }
        }

        [XmlElement("id")]
        public List<II> Ids
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.idField == null)
                    this.idField = new List<II>();

                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        [XmlElement("code")]
        public CS Code
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.codeField == null)
                    this.codeField = new CS();

                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }

        [XmlElement("value")]
        public RegionOfInterestvalue[] Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }

        [XmlElement("subject")]
        public Subject Subject
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.subjectField == null)
                    this.subjectField = new Subject();

                return this.subjectField;
            }
            set
            {
                this.subjectField = value;
            }
        }

        [XmlElement("specimen")]
        public List<Specimen> Specimens
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.specimenField == null)
                    this.specimenField = new List<Specimen>();

                return this.specimenField;
            }
            set
            {
                this.specimenField = value;
            }
        }

        [XmlElement("performer")]
        public List<Performer2> Performers
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.performerField == null)
                    this.performerField = new List<Performer2>();

                return this.performerField;
            }
            set
            {
                this.performerField = value;
            }
        }

        [XmlElement("author")]
        public List<Author> Authors
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.authorField == null)
                    this.authorField = new List<Author>();

                return this.authorField;
            }
            set
            {
                this.authorField = value;
            }
        }

        [XmlElement("informant")]
        public List<Informant12> Informants
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.informantField == null)
                    this.informantField = new List<Informant12>();

                return this.informantField;
            }
            set
            {
                this.informantField = value;
            }
        }

        [XmlElement("participant")]
        public List<Participant2> Participants
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.participantField == null)
                    this.participantField = new List<Participant2>();

                return this.participantField;
            }
            set
            {
                this.participantField = value;
            }
        }

        [XmlElement("entryRelationship")]
        public List<EntryRelationship> EntryRelationships
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.entryRelationshipField == null)
                    this.entryRelationshipField = new List<EntryRelationship>();

                return this.entryRelationshipField;
            }
            set
            {
                this.entryRelationshipField = value;
            }
        }

        [XmlElement("reference")]
        public List<Reference> References
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.referenceField == null)
                    this.referenceField = new List<Reference>();

                return this.referenceField;
            }
            set
            {
                this.referenceField = value;
            }
        }

        [XmlElement("precondition")]
        public List<Precondition> Preconditions
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.preconditionField == null)
                    this.preconditionField = new List<Precondition>();

                return this.preconditionField;
            }
            set
            {
                this.preconditionField = value;
            }
        }

        [XmlAttribute(AttributeName = "ID", DataType = "ID")]
        public string ID
        {
            get
            {
                return this.idField1;
            }
            set
            {
                this.idField1 = value;
            }
        }

        [XmlAttribute("nullFlavor")]
        public string NullFlavor
        {
            get
            {
                return this.nullFlavorField;
            }
            set
            {
                this.nullFlavorField = value;
            }
        }

        [XmlAttribute("classCode")]
        public string ClassCode
        {
            get
            {
                return this.classCodeField;
            }
            set
            {
                this.classCodeField = value;
            }
        }

        [XmlAttribute("moodCode")]
        public string MoodCode
        {
            get
            {
                return this.moodCodeField;
            }
            set
            {
                this.moodCodeField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName = ".SubstanceAdministration", Namespace = "urn:hl7-org:v3")]
    public partial class SubstanceAdministration : IClinicalStatement
    {

        private List<CS> realmCodeField;

        private InfrastructureRootTypeId typeIdField;

        private List<II> templateIdField;

        private List<II> idField;

        private CD codeField;

        private ED textField;

        private CS statusCodeField;

        private SXCM_TS[] effectiveTimeField;

        private CE priorityCodeField;

        private IVL_INT repeatNumberField;

        private CE routeCodeField;

        private List<CD> approachSiteCodeField;

        private IVL_PQ doseQuantityField;

        private IVL_PQ rateQuantityField;

        private RTO_PQ_PQ maxDoseQuantityField;

        private CE administrationUnitCodeField;

        private Subject subjectField;

        private List<Specimen> specimenField;

        private Consumable consumableField;

        private List<Performer2> performerField;

        private List<Author> authorField;

        private List<Informant12> informantField;

        private List<Participant2> participantField;

        private List<EntryRelationship> entryRelationshipField;

        private List<Reference> referenceField;

        private List<Precondition> preconditionField;

        private string nullFlavorField;

        private string classCodeField;

        private SubstanceMoodCodes moodCodeField;

        private bool negationIndField;

        private bool negationIndFieldSpecified;

        public SubstanceAdministration()
        {
            this.classCodeField = "SBADM";
        }

        [XmlElement("realmCode")]
        public List<CS> RealmCodes
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.realmCodeField == null)
                    this.realmCodeField = new List<CS>();

                return this.realmCodeField;
            }
            set
            {
                this.realmCodeField = value;
            }
        }

        [XmlElement("typeId")]
        public InfrastructureRootTypeId TypeId
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.typeIdField == null)
                    this.typeIdField = new InfrastructureRootTypeId();

                return this.typeIdField;
            }
            set
            {
                this.typeIdField = value;
            }
        }

        [XmlElement("templateId")]
        public List<II> TemplateIds
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.templateIdField == null)
                    this.templateIdField = new List<II>();

                return this.templateIdField;
            }
            set
            {
                this.templateIdField = value;
            }
        }

        [XmlElement("id")]
        public List<II> Ids
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.idField == null)
                    this.idField = new List<II>();

                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        [XmlElement("code")]
        public CD Code
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.codeField == null)
                    this.codeField = new CD();

                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }

        [XmlElement("text")]
        public ED Text
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.textField == null)
                    this.textField = new ED();

                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }

        [XmlElement("statusCode")]
        public CS StatusCode
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.statusCodeField == null)
                    this.statusCodeField = new CS();

                return this.statusCodeField;
            }
            set
            {
                this.statusCodeField = value;
            }
        }

        [XmlElement("effectiveTime")]
        public SXCM_TS[] EffectiveTime
        {
            get
            {
                return this.effectiveTimeField;
            }
            set
            {
                this.effectiveTimeField = value;
            }
        }

        [XmlElement("priorityCode")]
        public CE PriorityCode
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.priorityCodeField == null)
                    this.priorityCodeField = new CE();

                return this.priorityCodeField;
            }
            set
            {
                this.priorityCodeField = value;
            }
        }

        [XmlElement("repeatNumber")]
        public IVL_INT RepeatNumber
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.repeatNumberField == null)
                    this.repeatNumberField = new IVL_INT();

                return this.repeatNumberField;
            }
            set
            {
                this.repeatNumberField = value;
            }
        }

        [XmlElement("routeCode")]
        public CE RouteCode
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.routeCodeField == null)
                    this.routeCodeField = new CE();

                return this.routeCodeField;
            }
            set
            {
                this.routeCodeField = value;
            }
        }

        [XmlElement("approachSiteCode")]
        public List<CD> ApproachSiteCodes
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.approachSiteCodeField == null)
                    this.approachSiteCodeField = new List<CD>();

                return this.approachSiteCodeField;
            }
            set
            {
                this.approachSiteCodeField = value;
            }
        }

        [XmlElement("doseQuantity")]
        public IVL_PQ DoseQuantity
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.doseQuantityField == null)
                    this.doseQuantityField = new IVL_PQ();

                return this.doseQuantityField;
            }
            set
            {
                this.doseQuantityField = value;
            }
        }

        [XmlElement("rateQuantity")]
        public IVL_PQ RateQuantity
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.rateQuantityField == null)
                    this.rateQuantityField = new IVL_PQ();

                return this.rateQuantityField;
            }
            set
            {
                this.rateQuantityField = value;
            }
        }

        [XmlElement("maxDoseQuantity")]
        public RTO_PQ_PQ MaxDoseQuantity
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.maxDoseQuantityField == null)
                    this.maxDoseQuantityField = new RTO_PQ_PQ();

                return this.maxDoseQuantityField;
            }
            set
            {
                this.maxDoseQuantityField = value;
            }
        }

        [XmlElement("administrationUnitCode")]
        public CE AdministrationUnitCode
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.administrationUnitCodeField == null)
                    this.administrationUnitCodeField = new CE();

                return this.administrationUnitCodeField;
            }
            set
            {
                this.administrationUnitCodeField = value;
            }
        }

        [XmlElement("subject")]
        public Subject Subject
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.subjectField == null)
                    this.subjectField = new Subject();

                return this.subjectField;
            }
            set
            {
                this.subjectField = value;
            }
        }

        [XmlElement("specimen")]
        public List<Specimen> Specimens
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.specimenField == null)
                    this.specimenField = new List<Specimen>();

                return this.specimenField;
            }
            set
            {
                this.specimenField = value;
            }
        }

        [XmlElement("consumable")]
        public Consumable Consumable
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.consumableField == null)
                    this.consumableField = new Consumable();

                return this.consumableField;
            }
            set
            {
                this.consumableField = value;
            }
        }

        [XmlElement("performer")]
        public List<Performer2> Performers
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.performerField == null)
                    this.performerField = new List<Performer2>();

                return this.performerField;
            }
            set
            {
                this.performerField = value;
            }
        }

        [XmlElement("author")]
        public List<Author> Authors
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.authorField == null)
                    this.authorField = new List<Author>();

                return this.authorField;
            }
            set
            {
                this.authorField = value;
            }
        }

        [XmlElement("informant")]
        public List<Informant12> Informants
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.informantField == null)
                    this.informantField = new List<Informant12>();

                return this.informantField;
            }
            set
            {
                this.informantField = value;
            }
        }

        [XmlElement("participant")]
        public List<Participant2> Participants
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.participantField == null)
                    this.participantField = new List<Participant2>();

                return this.participantField;
            }
            set
            {
                this.participantField = value;
            }
        }

        [XmlElement("entryRelationship")]
        public List<EntryRelationship> EntryRelationships
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.entryRelationshipField == null)
                    this.entryRelationshipField = new List<EntryRelationship>();

                return this.entryRelationshipField;
            }
            set
            {
                this.entryRelationshipField = value;
            }
        }

        [XmlElement("reference")]
        public List<Reference> References
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.referenceField == null)
                    this.referenceField = new List<Reference>();

                return this.referenceField;
            }
            set
            {
                this.referenceField = value;
            }
        }

        [XmlElement("precondition")]
        public List<Precondition> Preconditions
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.preconditionField == null)
                    this.preconditionField = new List<Precondition>();

                return this.preconditionField;
            }
            set
            {
                this.preconditionField = value;
            }
        }

        [XmlAttribute("nullFlavor")]
        public string NullFlavor
        {
            get
            {
                return this.nullFlavorField;
            }
            set
            {
                this.nullFlavorField = value;
            }
        }

        [XmlAttribute("classCode")]
        public string ClassCode
        {
            get
            {
                return this.classCodeField;
            }
            set
            {
                this.classCodeField = value;
            }
        }

        [XmlAttribute("moodCode")]
        public SubstanceMoodCodes MoodCode
        {
            get
            {
                return this.moodCodeField;
            }
            set
            {
                this.moodCodeField = value;
            }
        }

        [XmlAttribute("negationInd")]
        public bool NegationInd
        {
            get
            {
                return this.negationIndField;
            }
            set
            {
                this.negationIndField = value;
            }
        }

        [XmlIgnore()]
        public bool NegationIndSpecified
        {
            get
            {
                return this.negationIndFieldSpecified;
            }
            set
            {
                this.negationIndFieldSpecified = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn:hl7-org:v3")]
    public partial class RTO_PQ_PQ : QTY
    {

        private PQ numeratorField;

        private PQ denominatorField;

        [XmlElement("numerator")]
        public PQ Numerator
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.numeratorField == null)
                    this.numeratorField = new PQ();

                return this.numeratorField;
            }
            set
            {
                this.numeratorField = value;
            }
        }

        [XmlElement("denominator")]
        public PQ Denominator
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.denominatorField == null)
                    this.denominatorField = new PQ();

                return this.denominatorField;
            }
            set
            {
                this.denominatorField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName = ".Consumable", Namespace = "urn:hl7-org:v3")]
    public partial class Consumable
    {

        private List<CS> realmCodeField;

        private InfrastructureRootTypeId typeIdField;

        private List<II> templateIdField;

        private ManufacturedProduct manufacturedProductField;

        private string nullFlavorField;

        private string typeCodeField;

        public Consumable()
        {
            this.typeCodeField = "CSM";
        }

        [XmlElement("realmCode")]
        public List<CS> RealmCodes
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.realmCodeField == null)
                    this.realmCodeField = new List<CS>();

                return this.realmCodeField;
            }
            set
            {
                this.realmCodeField = value;
            }
        }

        [XmlElement("typeId")]
        public InfrastructureRootTypeId TypeId
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.typeIdField == null)
                    this.typeIdField = new InfrastructureRootTypeId();

                return this.typeIdField;
            }
            set
            {
                this.typeIdField = value;
            }
        }

        [XmlElement("templateId")]
        public List<II> TemplateIds
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.templateIdField == null)
                    this.templateIdField = new List<II>();

                return this.templateIdField;
            }
            set
            {
                this.templateIdField = value;
            }
        }

        [XmlElement("manufacturedProduct")]
        public ManufacturedProduct ManufacturedProduct
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.manufacturedProductField == null)
                    this.manufacturedProductField = new ManufacturedProduct();

                return this.manufacturedProductField;
            }
            set
            {
                this.manufacturedProductField = value;
            }
        }

        [XmlAttribute("nullFlavor")]
        public string NullFlavor
        {
            get
            {
                return this.nullFlavorField;
            }
            set
            {
                this.nullFlavorField = value;
            }
        }

        [XmlAttribute("typeCode")]
        public string TypeCode
        {
            get
            {
                return this.typeCodeField;
            }
            set
            {
                this.typeCodeField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName = ".ManufacturedProduct", Namespace = "urn:hl7-org:v3")]
    public partial class ManufacturedProduct
    {

        private List<CS> realmCodeField;

        private InfrastructureRootTypeId typeIdField;

        private List<II> templateIdField;

        private List<II> idField;

        private object itemField;

        private Organization manufacturerOrganizationField;

        private string nullFlavorField;

        private ManufacturedProductClassCodes classCodeField;

        private bool classCodeFieldSpecified;

        public ManufacturedProduct()
        {
            this.classCodeField = ManufacturedProductClassCodes.MANU;
        }

        [XmlElement("realmCode")]
        public List<CS> RealmCodes
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.realmCodeField == null)
                    this.realmCodeField = new List<CS>();

                return this.realmCodeField;
            }
            set
            {
                this.realmCodeField = value;
            }
        }

        [XmlElement("typeId")]
        public InfrastructureRootTypeId TypeId
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.typeIdField == null)
                    this.typeIdField = new InfrastructureRootTypeId();

                return this.typeIdField;
            }
            set
            {
                this.typeIdField = value;
            }
        }

        [XmlElement("templateId")]
        public List<II> TemplateIds
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.templateIdField == null)
                    this.templateIdField = new List<II>();

                return this.templateIdField;
            }
            set
            {
                this.templateIdField = value;
            }
        }

        [XmlElement("id")]
        public List<II> Ids
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.idField == null)
                    this.idField = new List<II>();

                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        [XmlElement("manufacturedLabeledDrug", typeof(LabeledDrug))]
        [XmlElement("manufacturedMaterial", typeof(Material))]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        [XmlElement("manufacturerOrganization")]
        public Organization ManufacturerOrganization
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.manufacturerOrganizationField == null)
                    this.manufacturerOrganizationField = new Organization();

                return this.manufacturerOrganizationField;
            }
            set
            {
                this.manufacturerOrganizationField = value;
            }
        }

        [XmlAttribute("nullFlavor")]
        public string NullFlavor
        {
            get
            {
                return this.nullFlavorField;
            }
            set
            {
                this.nullFlavorField = value;
            }
        }

        [XmlAttribute("classCode")]
        public ManufacturedProductClassCodes ClassCode
        {
            get
            {
                return this.classCodeField;
            }
            set
            {
                this.classCodeField = value;
            }
        }

        [XmlIgnore()]
        public bool ClassCodeSpecified
        {
            get
            {
                return this.classCodeFieldSpecified;
            }
            set
            {
                this.classCodeFieldSpecified = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName = ".LabeledDrug", Namespace = "urn:hl7-org:v3")]
    public partial class LabeledDrug
    {

        private List<CS> realmCodeField;

        private InfrastructureRootTypeId typeIdField;

        private List<II> templateIdField;

        private CE codeField;

        private EN nameField;

        private string nullFlavorField;

        private string classCodeField;

        private DeterminerCodes determinerCodeField;

        private bool determinerCodeFieldSpecified;

        public LabeledDrug()
        {
            this.classCodeField = "MMAT";
            this.determinerCodeField = DeterminerCodes.KIND;
        }

        [XmlElement("realmCode")]
        public List<CS> RealmCodes
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.realmCodeField == null)
                    this.realmCodeField = new List<CS>();

                return this.realmCodeField;
            }
            set
            {
                this.realmCodeField = value;
            }
        }

        [XmlElement("typeId")]
        public InfrastructureRootTypeId TypeId
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.typeIdField == null)
                    this.typeIdField = new InfrastructureRootTypeId();

                return this.typeIdField;
            }
            set
            {
                this.typeIdField = value;
            }
        }

        [XmlElement("templateId")]
        public List<II> TemplateIds
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.templateIdField == null)
                    this.templateIdField = new List<II>();

                return this.templateIdField;
            }
            set
            {
                this.templateIdField = value;
            }
        }

        [XmlElement("code")]
        public CE Code
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.codeField == null)
                    this.codeField = new CE();

                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }

        [XmlElement("name")]
        public EN Name
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.nameField == null)
                    this.nameField = new EN();

                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        [XmlAttribute("nullFlavor")]
        public string NullFlavor
        {
            get
            {
                return this.nullFlavorField;
            }
            set
            {
                this.nullFlavorField = value;
            }
        }

        [XmlAttribute("classCode")]
        public string ClassCode
        {
            get
            {
                return this.classCodeField;
            }
            set
            {
                this.classCodeField = value;
            }
        }

        [XmlAttribute("determinerCode")]
        public DeterminerCodes DeterminerCode
        {
            get
            {
                return this.determinerCodeField;
            }
            set
            {
                this.determinerCodeField = value;
            }
        }

        [XmlIgnore()]
        public bool DeterminerCodeSpecified
        {
            get
            {
                return this.determinerCodeFieldSpecified;
            }
            set
            {
                this.determinerCodeFieldSpecified = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName = ".Material", Namespace = "urn:hl7-org:v3")]
    public partial class Material
    {

        private List<CS> realmCodeField;

        private InfrastructureRootTypeId typeIdField;

        private List<II> templateIdField;

        private CE codeField;

        private EN nameField;

        private ST lotNumberTextField;

        private string nullFlavorField;

        private string classCodeField;

        private DeterminerCodes determinerCodeField;

        private bool determinerCodeFieldSpecified;

        public Material()
        {
            this.classCodeField = "MMAT";
            this.determinerCodeField = DeterminerCodes.KIND;
        }

        [XmlElement("realmCode")]
        public List<CS> RealmCodes
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.realmCodeField == null)
                    this.realmCodeField = new List<CS>();

                return this.realmCodeField;
            }
            set
            {
                this.realmCodeField = value;
            }
        }

        [XmlElement("typeId")]
        public InfrastructureRootTypeId TypeId
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.typeIdField == null)
                    this.typeIdField = new InfrastructureRootTypeId();

                return this.typeIdField;
            }
            set
            {
                this.typeIdField = value;
            }
        }

        [XmlElement("templateId")]
        public List<II> TemplateIds
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.templateIdField == null)
                    this.templateIdField = new List<II>();

                return this.templateIdField;
            }
            set
            {
                this.templateIdField = value;
            }
        }

        [XmlElement("code")]
        public CE Code
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.codeField == null)
                    this.codeField = new CE();

                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }

        [XmlElement("name")]
        public EN Name
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.nameField == null)
                    this.nameField = new EN();

                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        [XmlElement("lotNumberText")]
        public ST LotNumberText
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.lotNumberTextField == null)
                    this.lotNumberTextField = new ST();

                return this.lotNumberTextField;
            }
            set
            {
                this.lotNumberTextField = value;
            }
        }

        [XmlAttribute("nullFlavor")]
        public string NullFlavor
        {
            get
            {
                return this.nullFlavorField;
            }
            set
            {
                this.nullFlavorField = value;
            }
        }

        [XmlAttribute("classCode")]
        public string ClassCode
        {
            get
            {
                return this.classCodeField;
            }
            set
            {
                this.classCodeField = value;
            }
        }

        [XmlAttribute("determinerCode")]
        public DeterminerCodes DeterminerCode
        {
            get
            {
                return this.determinerCodeField;
            }
            set
            {
                this.determinerCodeField = value;
            }
        }

        [XmlIgnore()]
        public bool DeterminerCodeSpecified
        {
            get
            {
                return this.determinerCodeFieldSpecified;
            }
            set
            {
                this.determinerCodeFieldSpecified = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName = ".Supply", Namespace = "urn:hl7-org:v3")]
    public partial class Supply : IClinicalStatement
    {

        private List<CS> realmCodeField;

        private InfrastructureRootTypeId typeIdField;

        private List<II> templateIdField;

        private List<II> idField;

        private CD codeField;

        private ED textField;

        private CS statusCodeField;

        private SXCM_TS[] effectiveTimeField;

        private List<CE> priorityCodeField;

        private IVL_INT repeatNumberField;

        private BL independentIndField;

        private PQ quantityField;

        private IVL_TS expectedUseTimeField;

        private Subject subjectField;

        private List<Specimen> specimenField;

        private Product productField;

        private List<Performer2> performerField;

        private List<Author> authorField;

        private List<Informant12> informantField;

        private List<Participant2> participantField;

        private List<EntryRelationship> entryRelationshipField;

        private List<Reference> referenceField;

        private List<Precondition> preconditionField;

        private string nullFlavorField;

        private SupplyClassCodes classCodeField;

        private SubstanceMoodCodes moodCodeField;

        public Supply()
        {
            this.classCodeField = SupplyClassCodes.SPLY;
        }

        [XmlElement("realmCode")]
        public List<CS> RealmCodes
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.realmCodeField == null)
                    this.realmCodeField = new List<CS>();

                return this.realmCodeField;
            }
            set
            {
                this.realmCodeField = value;
            }
        }

        [XmlElement("typeId")]
        public InfrastructureRootTypeId TypeId
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.typeIdField == null)
                    this.typeIdField = new InfrastructureRootTypeId();

                return this.typeIdField;
            }
            set
            {
                this.typeIdField = value;
            }
        }

        [XmlElement("templateId")]
        public List<II> TemplateIds
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.templateIdField == null)
                    this.templateIdField = new List<II>();

                return this.templateIdField;
            }
            set
            {
                this.templateIdField = value;
            }
        }

        [XmlElement("id")]
        public List<II> Ids
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.idField == null)
                    this.idField = new List<II>();

                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        [XmlElement("code")]
        public CD Code
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.codeField == null)
                    this.codeField = new CD();

                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }

        [XmlElement("text")]
        public ED Text
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.textField == null)
                    this.textField = new ED();

                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }

        [XmlElement("statusCode")]
        public CS StatusCode
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.statusCodeField == null)
                    this.statusCodeField = new CS();

                return this.statusCodeField;
            }
            set
            {
                this.statusCodeField = value;
            }
        }

        [XmlElement("effectiveTime")]
        public SXCM_TS[] EffectiveTime
        {
            get
            {
                return this.effectiveTimeField;
            }
            set
            {
                this.effectiveTimeField = value;
            }
        }

        [XmlElement("priorityCode")]
        public List<CE> PriorityCode
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.priorityCodeField == null)
                    this.priorityCodeField = new List<CE>();

                return this.priorityCodeField;
            }
            set
            {
                this.priorityCodeField = value;
            }
        }

        [XmlElement("repeatNumber")]
        public IVL_INT RepeatNumber
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.repeatNumberField == null)
                    this.repeatNumberField = new IVL_INT();

                return this.repeatNumberField;
            }
            set
            {
                this.repeatNumberField = value;
            }
        }

        [XmlElement("independentInd")]
        public BL IndependentInd
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.independentIndField == null)
                    this.independentIndField = new BL();

                return this.independentIndField;
            }
            set
            {
                this.independentIndField = value;
            }
        }

        [XmlElement("quantity")]
        public PQ Quantity
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.quantityField == null)
                    this.quantityField = new PQ();

                return this.quantityField;
            }
            set
            {
                this.quantityField = value;
            }
        }

        [XmlElement("expectedUseTime")]
        public IVL_TS ExpectedUseTime
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.expectedUseTimeField == null)
                    this.expectedUseTimeField = new IVL_TS();

                return this.expectedUseTimeField;
            }
            set
            {
                this.expectedUseTimeField = value;
            }
        }

        [XmlElement("subject")]
        public Subject Subject
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.subjectField == null)
                    this.subjectField = new Subject();

                return this.subjectField;
            }
            set
            {
                this.subjectField = value;
            }
        }

        [XmlElement("specimen")]
        public List<Specimen> Specimens
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.specimenField == null)
                    this.specimenField = new List<Specimen>();

                return this.specimenField;
            }
            set
            {
                this.specimenField = value;
            }
        }

        [XmlElement("product")]
        public Product Product
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.productField == null)
                    this.productField = new Product();

                return this.productField;
            }
            set
            {
                this.productField = value;
            }
        }

        [XmlElement("performer")]
        public List<Performer2> Performers
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.performerField == null)
                    this.performerField = new List<Performer2>();

                return this.performerField;
            }
            set
            {
                this.performerField = value;
            }
        }

        [XmlElement("author")]
        public List<Author> Authors
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.authorField == null)
                    this.authorField = new List<Author>();

                return this.authorField;
            }
            set
            {
                this.authorField = value;
            }
        }

        [XmlElement("informant")]
        public List<Informant12> Informants
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.informantField == null)
                    this.informantField = new List<Informant12>();

                return this.informantField;
            }
            set
            {
                this.informantField = value;
            }
        }

        [XmlElement("participant")]
        public List<Participant2> Participants
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.participantField == null)
                    this.participantField = new List<Participant2>();

                return this.participantField;
            }
            set
            {
                this.participantField = value;
            }
        }

        [XmlElement("entryRelationship")]
        public List<EntryRelationship> EntryRelationships
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.entryRelationshipField == null)
                    this.entryRelationshipField = new List<EntryRelationship>();

                return this.entryRelationshipField;
            }
            set
            {
                this.entryRelationshipField = value;
            }
        }

        [XmlElement("reference")]
        public List<Reference> References
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.referenceField == null)
                    this.referenceField = new List<Reference>();

                return this.referenceField;
            }
            set
            {
                this.referenceField = value;
            }
        }

        [XmlElement("precondition")]
        public List<Precondition> Preconditions
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.preconditionField == null)
                    this.preconditionField = new List<Precondition>();

                return this.preconditionField;
            }
            set
            {
                this.preconditionField = value;
            }
        }

        [XmlAttribute("nullFlavor")]
        public string NullFlavor
        {
            get
            {
                return this.nullFlavorField;
            }
            set
            {
                this.nullFlavorField = value;
            }
        }

        [XmlAttribute("classCode")]
        public SupplyClassCodes ClassCode
        {
            get
            {
                return this.classCodeField;
            }
            set
            {
                this.classCodeField = value;
            }
        }

        [XmlAttribute("moodCode")]
        public SubstanceMoodCodes MoodCode
        {
            get
            {
                return this.moodCodeField;
            }
            set
            {
                this.moodCodeField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName = ".Product", Namespace = "urn:hl7-org:v3")]
    public partial class Product
    {

        private List<CS> realmCodeField;

        private InfrastructureRootTypeId typeIdField;

        private List<II> templateIdField;

        private ManufacturedProduct manufacturedProductField;

        private string nullFlavorField;

        private string typeCodeField;

        public Product()
        {
            this.typeCodeField = "PRD";
        }

        [XmlElement("realmCode")]
        public List<CS> RealmCodes
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.realmCodeField == null)
                    this.realmCodeField = new List<CS>();

                return this.realmCodeField;
            }
            set
            {
                this.realmCodeField = value;
            }
        }

        [XmlElement("typeId")]
        public InfrastructureRootTypeId TypeId
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.typeIdField == null)
                    this.typeIdField = new InfrastructureRootTypeId();

                return this.typeIdField;
            }
            set
            {
                this.typeIdField = value;
            }
        }

        [XmlElement("templateId")]
        public List<II> TemplateIds
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.templateIdField == null)
                    this.templateIdField = new List<II>();

                return this.templateIdField;
            }
            set
            {
                this.templateIdField = value;
            }
        }

        [XmlElement("manufacturedProduct")]
        public ManufacturedProduct ManufacturedProduct
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.manufacturedProductField == null)
                    this.manufacturedProductField = new ManufacturedProduct();

                return this.manufacturedProductField;
            }
            set
            {
                this.manufacturedProductField = value;
            }
        }

        [XmlAttribute("nullFlavor")]
        public string NullFlavor
        {
            get
            {
                return this.nullFlavorField;
            }
            set
            {
                this.nullFlavorField = value;
            }
        }

        [XmlAttribute("typeCode")]
        public string TypeCode
        {
            get
            {
                return this.typeCodeField;
            }
            set
            {
                this.typeCodeField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName = ".Component3", Namespace = "urn:hl7-org:v3")]
    public partial class SectionComponent
    {

        private List<CS> realmCodeField;

        private InfrastructureRootTypeId typeIdField;

        private List<II> templateIdField;

        private Section sectionField;

        private string nullFlavorField;

        private ComponentTypeCodes typeCodeField;

        private bool typeCodeFieldSpecified;

        private bool contextConductionIndField;

        private bool contextConductionIndFieldSpecified;

        public SectionComponent()
        {
            this.typeCodeField = ComponentTypeCodes.COMP;
            this.contextConductionIndField = true;
        }

        [XmlElement("realmCode")]
        public List<CS> RealmCodes
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.realmCodeField == null)
                    this.realmCodeField = new List<CS>();

                return this.realmCodeField;
            }
            set
            {
                this.realmCodeField = value;
            }
        }

        [XmlElement("typeId")]
        public InfrastructureRootTypeId TypeId
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.typeIdField == null)
                    this.typeIdField = new InfrastructureRootTypeId();

                return this.typeIdField;
            }
            set
            {
                this.typeIdField = value;
            }
        }

        [XmlElement("templateId")]
        public List<II> TemplateIds
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.templateIdField == null)
                    this.templateIdField = new List<II>();

                return this.templateIdField;
            }
            set
            {
                this.templateIdField = value;
            }
        }

        [XmlElement("section")]
        public Section Section
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.sectionField == null)
                    this.sectionField = new Section();

                return this.sectionField;
            }
            set
            {
                this.sectionField = value;
            }
        }

        [XmlAttribute("nullFlavor")]
        public string NullFlavor
        {
            get
            {
                return this.nullFlavorField;
            }
            set
            {
                this.nullFlavorField = value;
            }
        }

        [XmlAttribute("typeCode")]
        public ComponentTypeCodes TypeCode
        {
            get
            {
                return this.typeCodeField;
            }
            set
            {
                this.typeCodeField = value;
            }
        }

        [XmlIgnore()]
        public bool TypeCodeSpecified
        {
            get
            {
                return this.typeCodeFieldSpecified;
            }
            set
            {
                this.typeCodeFieldSpecified = value;
            }
        }

        [XmlAttribute("contextConductionInd")]
        public bool ContextConductionInd
        {
            get
            {
                return this.contextConductionIndField;
            }
            set
            {
                this.contextConductionIndField = value;
            }
        }

        [XmlIgnore()]
        public bool ContextConductionIndSpecified
        {
            get
            {
                return this.contextConductionIndFieldSpecified;
            }
            set
            {
                this.contextConductionIndFieldSpecified = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName = ".StructuredBody", Namespace = "urn:hl7-org:v3")]
    public partial class StructuredBody
    {

        private List<CS> realmCodeField;

        private InfrastructureRootTypeId typeIdField;

        private List<II> templateIdField;

        private CE confidentialityCodeField;

        private CS languageCodeField;

        private List<SectionComponent> componentField;

        private string nullFlavorField;

        private string classCodeField;

        private string moodCodeField;

        public StructuredBody()
        {
            this.classCodeField = "DOCBODY";
            this.moodCodeField = "EVN";
        }

        [XmlElement("realmCode")]
        public List<CS> RealmCodes
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.realmCodeField == null)
                    this.realmCodeField = new List<CS>();

                return this.realmCodeField;
            }
            set
            {
                this.realmCodeField = value;
            }
        }

        [XmlElement("typeId")]
        public InfrastructureRootTypeId TypeId
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.typeIdField == null)
                    this.typeIdField = new InfrastructureRootTypeId();

                return this.typeIdField;
            }
            set
            {
                this.typeIdField = value;
            }
        }

        [XmlElement("templateId")]
        public List<II> TemplateIds
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.templateIdField == null)
                    this.templateIdField = new List<II>();

                return this.templateIdField;
            }
            set
            {
                this.templateIdField = value;
            }
        }

        [XmlElement("confidentialityCode")]
        public CE ConfidentialityCode
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.confidentialityCodeField == null)
                    this.confidentialityCodeField = new CE();

                return this.confidentialityCodeField;
            }
            set
            {
                this.confidentialityCodeField = value;
            }
        }

        [XmlElement("languageCode")]
        public CS LanguageCode
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.languageCodeField == null)
                    this.languageCodeField = new CS();

                return this.languageCodeField;
            }
            set
            {
                this.languageCodeField = value;
            }
        }

        [XmlElement("component")]
        public List<SectionComponent> Components
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.componentField == null)
                    this.componentField = new List<SectionComponent>();

                return this.componentField;
            }
            set
            {
                this.componentField = value;
            }
        }

        [XmlAttribute("nullFlavor")]
        public string NullFlavor
        {
            get
            {
                return this.nullFlavorField;
            }
            set
            {
                this.nullFlavorField = value;
            }
        }

        [XmlAttribute("classCode")]
        public string ClassCode
        {
            get
            {
                return this.classCodeField;
            }
            set
            {
                this.classCodeField = value;
            }
        }

        [XmlAttribute("moodCode")]
        public string MoodCode
        {
            get
            {
                return this.moodCodeField;
            }
            set
            {
                this.moodCodeField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName = ".NonXMLBody", Namespace = "urn:hl7-org:v3")]
    public partial class UnstructuredBody
    {

        private List<CS> realmCodeField;

        private InfrastructureRootTypeId typeIdField;

        private List<II> templateIdField;

        private ED textField;

        private CE confidentialityCodeField;

        private CS languageCodeField;

        private string nullFlavorField;

        private string classCodeField;

        private string moodCodeField;

        public UnstructuredBody()
        {
            this.classCodeField = "DOCBODY";
            this.moodCodeField = "EVN";
        }

        [XmlElement("realmCode")]
        public List<CS> RealmCodes
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.realmCodeField == null)
                    this.realmCodeField = new List<CS>();

                return this.realmCodeField;
            }
            set
            {
                this.realmCodeField = value;
            }
        }

        [XmlElement("typeId")]
        public InfrastructureRootTypeId TypeId
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.typeIdField == null)
                    this.typeIdField = new InfrastructureRootTypeId();

                return this.typeIdField;
            }
            set
            {
                this.typeIdField = value;
            }
        }

        [XmlElement("templateId")]
        public List<II> TemplateIds
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.templateIdField == null)
                    this.templateIdField = new List<II>();

                return this.templateIdField;
            }
            set
            {
                this.templateIdField = value;
            }
        }

        [XmlElement("text")]
        public ED Text
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.textField == null)
                    this.textField = new ED();

                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }

        [XmlElement("confidentialityCode")]
        public CE ConfidentialityCode
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.confidentialityCodeField == null)
                    this.confidentialityCodeField = new CE();

                return this.confidentialityCodeField;
            }
            set
            {
                this.confidentialityCodeField = value;
            }
        }

        [XmlElement("languageCode")]
        public CS LanguageCode
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.languageCodeField == null)
                    this.languageCodeField = new CS();

                return this.languageCodeField;
            }
            set
            {
                this.languageCodeField = value;
            }
        }

        [XmlAttribute("nullFlavor")]
        public string NullFlavor
        {
            get
            {
                return this.nullFlavorField;
            }
            set
            {
                this.nullFlavorField = value;
            }
        }

        [XmlAttribute("classCode")]
        public string ClassCode
        {
            get
            {
                return this.classCodeField;
            }
            set
            {
                this.classCodeField = value;
            }
        }

        [XmlAttribute("moodCode")]
        public string MoodCode
        {
            get
            {
                return this.moodCodeField;
            }
            set
            {
                this.moodCodeField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName = ".Component2", Namespace = "urn:hl7-org:v3")]
    public partial class BodyComponent
    {

        private List<CS> realmCodeField;

        private InfrastructureRootTypeId typeIdField;

        private List<II> templateIdField;

        private object itemField;

        private string nullFlavorField;

        private ComponentTypeCodes typeCodeField;

        private bool typeCodeFieldSpecified;

        private bool contextConductionIndField;

        private bool contextConductionIndFieldSpecified;

        public BodyComponent()
        {
            this.typeCodeField = ComponentTypeCodes.COMP;
            this.contextConductionIndField = true;
        }

        [XmlElement("realmCode")]
        public List<CS> RealmCodes
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.realmCodeField == null)
                    this.realmCodeField = new List<CS>();

                return this.realmCodeField;
            }
            set
            {
                this.realmCodeField = value;
            }
        }

        [XmlElement("typeId")]
        public InfrastructureRootTypeId TypeId
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.typeIdField == null)
                    this.typeIdField = new InfrastructureRootTypeId();

                return this.typeIdField;
            }
            set
            {
                this.typeIdField = value;
            }
        }

        [XmlElement("templateId")]
        public List<II> TemplateIds
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.templateIdField == null)
                    this.templateIdField = new List<II>();

                return this.templateIdField;
            }
            set
            {
                this.templateIdField = value;
            }
        }

        [XmlElement("nonXMLBody", typeof(UnstructuredBody))]
        [XmlElement("structuredBody", typeof(StructuredBody))]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        [XmlAttribute("nullFlavor")]
        public string NullFlavor
        {
            get
            {
                return this.nullFlavorField;
            }
            set
            {
                this.nullFlavorField = value;
            }
        }

        [XmlAttribute("typeCode")]
        public ComponentTypeCodes TypeCode
        {
            get
            {
                return this.typeCodeField;
            }
            set
            {
                this.typeCodeField = value;
            }
        }

        [XmlIgnore()]
        public bool TypeCodeSpecified
        {
            get
            {
                return this.typeCodeFieldSpecified;
            }
            set
            {
                this.typeCodeFieldSpecified = value;
            }
        }

        [XmlAttribute("contextConductionInd")]
        public bool ContextConductionInd
        {
            get
            {
                return this.contextConductionIndField;
            }
            set
            {
                this.contextConductionIndField = value;
            }
        }

        [XmlIgnore()]
        public bool ContextConductionIndSpecified
        {
            get
            {
                return this.contextConductionIndFieldSpecified;
            }
            set
            {
                this.contextConductionIndFieldSpecified = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName = ".HealthCareFacility", Namespace = "urn:hl7-org:v3")]
    public partial class HealthCareFacility
    {

        private List<CS> realmCodeField;

        private InfrastructureRootTypeId typeIdField;

        private List<II> templateIdField;

        private List<II> idField;

        private CE codeField;

        private Place locationField;

        private Organization serviceProviderOrganizationField;

        private string nullFlavorField;

        private HealthCareFacilityClassCodes classCodeField;

        public HealthCareFacility()
        {
            this.classCodeField = HealthCareFacilityClassCodes.SDLOC;
        }

        [XmlElement("realmCode")]
        public List<CS> RealmCodes
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.realmCodeField == null)
                    this.realmCodeField = new List<CS>();

                return this.realmCodeField;
            }
            set
            {
                this.realmCodeField = value;
            }
        }

        [XmlElement("typeId")]
        public InfrastructureRootTypeId TypeId
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.typeIdField == null)
                    this.typeIdField = new InfrastructureRootTypeId();

                return this.typeIdField;
            }
            set
            {
                this.typeIdField = value;
            }
        }

        [XmlElement("templateId")]
        public List<II> TemplateIds
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.templateIdField == null)
                    this.templateIdField = new List<II>();

                return this.templateIdField;
            }
            set
            {
                this.templateIdField = value;
            }
        }

        [XmlElement("id")]
        public List<II> Ids
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.idField == null)
                    this.idField = new List<II>();

                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        [XmlElement("code")]
        public CE Code
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.codeField == null)
                    this.codeField = new CE();

                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }

        [XmlElement("location")]
        public Place Location
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.locationField == null)
                    this.locationField = new Place();

                return this.locationField;
            }
            set
            {
                this.locationField = value;
            }
        }

        [XmlElement("serviceProviderOrganization")]
        public Organization ServiceProviderOrganization
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.serviceProviderOrganizationField == null)
                    this.serviceProviderOrganizationField = new Organization();

                return this.serviceProviderOrganizationField;
            }
            set
            {
                this.serviceProviderOrganizationField = value;
            }
        }

        [XmlAttribute("nullFlavor")]
        public string NullFlavor
        {
            get
            {
                return this.nullFlavorField;
            }
            set
            {
                this.nullFlavorField = value;
            }
        }

        [XmlAttribute("classCode")]
        [System.ComponentModel.DefaultValueAttribute(HealthCareFacilityClassCodes.SDLOC)]
        public HealthCareFacilityClassCodes ClassCode
        {
            get
            {
                return this.classCodeField;
            }
            set
            {
                this.classCodeField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName = ".Place", Namespace = "urn:hl7-org:v3")]
    public partial class Place
    {

        private List<CS> realmCodeField;

        private InfrastructureRootTypeId typeIdField;

        private List<II> templateIdField;

        private EN nameField;

        private AD addrField;

        private string nullFlavorField;

        private PlaceClassCodes classCodeField;

        private bool classCodeFieldSpecified;

        private string determinerCodeField;

        public Place()
        {
            this.classCodeField = PlaceClassCodes.PLC;
            this.determinerCodeField = "INSTANCE";
        }

        [XmlElement("realmCode")]
        public List<CS> RealmCodes
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.realmCodeField == null)
                    this.realmCodeField = new List<CS>();

                return this.realmCodeField;
            }
            set
            {
                this.realmCodeField = value;
            }
        }

        [XmlElement("typeId")]
        public InfrastructureRootTypeId TypeId
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.typeIdField == null)
                    this.typeIdField = new InfrastructureRootTypeId();

                return this.typeIdField;
            }
            set
            {
                this.typeIdField = value;
            }
        }

        [XmlElement("templateId")]
        public List<II> TemplateIds
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.templateIdField == null)
                    this.templateIdField = new List<II>();

                return this.templateIdField;
            }
            set
            {
                this.templateIdField = value;
            }
        }

        [XmlElement("name")]
        public EN Name
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.nameField == null)
                    this.nameField = new EN();

                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        [XmlElement("addr")]
        public AD Addr
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.addrField == null)
                    this.addrField = new AD();

                return this.addrField;
            }
            set
            {
                this.addrField = value;
            }
        }

        [XmlAttribute("nullFlavor")]
        public string NullFlavor
        {
            get
            {
                return this.nullFlavorField;
            }
            set
            {
                this.nullFlavorField = value;
            }
        }

        [XmlAttribute("classCode")]
        public PlaceClassCodes ClassCode
        {
            get
            {
                return this.classCodeField;
            }
            set
            {
                this.classCodeField = value;
            }
        }

        [XmlIgnore()]
        public bool ClassCodeSpecified
        {
            get
            {
                return this.classCodeFieldSpecified;
            }
            set
            {
                this.classCodeFieldSpecified = value;
            }
        }

        [XmlAttribute("determinerCode")]
        public string DeterminerCode
        {
            get
            {
                return this.determinerCodeField;
            }
            set
            {
                this.determinerCodeField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName = ".Location", Namespace = "urn:hl7-org:v3")]
    public partial class Location
    {

        private List<CS> realmCodeField;

        private InfrastructureRootTypeId typeIdField;

        private List<II> templateIdField;

        private HealthCareFacility healthCareFacilityField;

        private string nullFlavorField;

        private LocationTypeCodes typeCodeField;

        private bool typeCodeFieldSpecified;

        public Location()
        {
            this.typeCodeField = LocationTypeCodes.LOC;
        }

        [XmlElement("realmCode")]
        public List<CS> RealmCodes
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.realmCodeField == null)
                    this.realmCodeField = new List<CS>();

                return this.realmCodeField;
            }
            set
            {
                this.realmCodeField = value;
            }
        }

        [XmlElement("typeId")]
        public InfrastructureRootTypeId TypeId
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.typeIdField == null)
                    this.typeIdField = new InfrastructureRootTypeId();

                return this.typeIdField;
            }
            set
            {
                this.typeIdField = value;
            }
        }

        [XmlElement("templateId")]
        public List<II> TemplateIds
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.templateIdField == null)
                    this.templateIdField = new List<II>();

                return this.templateIdField;
            }
            set
            {
                this.templateIdField = value;
            }
        }

        [XmlElement("healthCareFacility")]
        public HealthCareFacility HealthCareFacility
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.healthCareFacilityField == null)
                    this.healthCareFacilityField = new HealthCareFacility();

                return this.healthCareFacilityField;
            }
            set
            {
                this.healthCareFacilityField = value;
            }
        }

        [XmlAttribute("nullFlavor")]
        public string NullFlavor
        {
            get
            {
                return this.nullFlavorField;
            }
            set
            {
                this.nullFlavorField = value;
            }
        }

        [XmlAttribute("typeCode")]
        public LocationTypeCodes TypeCode
        {
            get
            {
                return this.typeCodeField;
            }
            set
            {
                this.typeCodeField = value;
            }
        }

        [XmlIgnore()]
        public bool TypeCodeSpecified
        {
            get
            {
                return this.typeCodeFieldSpecified;
            }
            set
            {
                this.typeCodeFieldSpecified = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName = ".EncounterParticipant", Namespace = "urn:hl7-org:v3")]
    public partial class EncounterParticipant
    {

        private List<CS> realmCodeField;

        private InfrastructureRootTypeId typeIdField;

        private List<II> templateIdField;

        private IVL_TS timeField;

        private AssignedEntity assignedEntityField;

        private string nullFlavorField;

        private EncounterParticipantTypeCodes typeCodeField;

        [XmlElement("realmCode")]
        public List<CS> RealmCodes
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.realmCodeField == null)
                    this.realmCodeField = new List<CS>();

                return this.realmCodeField;
            }
            set
            {
                this.realmCodeField = value;
            }
        }

        [XmlElement("typeId")]
        public InfrastructureRootTypeId TypeId
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.typeIdField == null)
                    this.typeIdField = new InfrastructureRootTypeId();

                return this.typeIdField;
            }
            set
            {
                this.typeIdField = value;
            }
        }

        [XmlElement("templateId")]
        public List<II> TemplateIds
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.templateIdField == null)
                    this.templateIdField = new List<II>();

                return this.templateIdField;
            }
            set
            {
                this.templateIdField = value;
            }
        }

        [XmlElement("time")]
        public IVL_TS Time
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.timeField == null)
                    this.timeField = new IVL_TS();

                return this.timeField;
            }
            set
            {
                this.timeField = value;
            }
        }

        [XmlElement("assignedEntity")]
        public AssignedEntity AssignedEntity
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.assignedEntityField == null)
                    this.assignedEntityField = new AssignedEntity();

                return this.assignedEntityField;
            }
            set
            {
                this.assignedEntityField = value;
            }
        }

        [XmlAttribute("nullFlavor")]
        public string NullFlavor
        {
            get
            {
                return this.nullFlavorField;
            }
            set
            {
                this.nullFlavorField = value;
            }
        }

        [XmlAttribute("typeCode")]
        public EncounterParticipantTypeCodes TypeCode
        {
            get
            {
                return this.typeCodeField;
            }
            set
            {
                this.typeCodeField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName = ".ResponsibleParty", Namespace = "urn:hl7-org:v3")]
    public partial class ResponsibleParty
    {

        private List<CS> realmCodeField;

        private InfrastructureRootTypeId typeIdField;

        private List<II> templateIdField;

        private AssignedEntity assignedEntityField;

        private string nullFlavorField;

        private string typeCodeField;

        public ResponsibleParty()
        {
            this.typeCodeField = "RESP";
        }

        [XmlElement("realmCode")]
        public List<CS> RealmCodes
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.realmCodeField == null)
                    this.realmCodeField = new List<CS>();

                return this.realmCodeField;
            }
            set
            {
                this.realmCodeField = value;
            }
        }

        [XmlElement("typeId")]
        public InfrastructureRootTypeId TypeId
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.typeIdField == null)
                    this.typeIdField = new InfrastructureRootTypeId();

                return this.typeIdField;
            }
            set
            {
                this.typeIdField = value;
            }
        }

        [XmlElement("templateId")]
        public List<II> TemplateIds
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.templateIdField == null)
                    this.templateIdField = new List<II>();

                return this.templateIdField;
            }
            set
            {
                this.templateIdField = value;
            }
        }

        [XmlElement("assignedEntity")]
        public AssignedEntity AssignedEntity
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.assignedEntityField == null)
                    this.assignedEntityField = new AssignedEntity();

                return this.assignedEntityField;
            }
            set
            {
                this.assignedEntityField = value;
            }
        }

        [XmlAttribute("nullFlavor")]
        public string NullFlavor
        {
            get
            {
                return this.nullFlavorField;
            }
            set
            {
                this.nullFlavorField = value;
            }
        }

        [XmlAttribute("typeCode")]
        public string TypeCode
        {
            get
            {
                return this.typeCodeField;
            }
            set
            {
                this.typeCodeField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName = ".EncompassingEncounter", Namespace = "urn:hl7-org:v3")]
    public partial class EncompassingEncounter
    {

        private List<CS> realmCodeField;

        private InfrastructureRootTypeId typeIdField;

        private List<II> templateIdField;

        private List<II> idField;

        private CE codeField;

        private IVL_TS effectiveTimeField;

        private CE dischargeDispositionCodeField;

        private ResponsibleParty responsiblePartyField;

        private EncounterParticipant[] encounterParticipantField;

        private Location locationField;

        private string nullFlavorField;

        private string classCodeField;

        private string moodCodeField;

        public EncompassingEncounter()
        {
            this.classCodeField = "ENC";
            this.moodCodeField = "EVN";
        }

        [XmlElement("realmCode")]
        public List<CS> RealmCodes
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.realmCodeField == null)
                    this.realmCodeField = new List<CS>();

                return this.realmCodeField;
            }
            set
            {
                this.realmCodeField = value;
            }
        }

        [XmlElement("typeId")]
        public InfrastructureRootTypeId TypeId
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.typeIdField == null)
                    this.typeIdField = new InfrastructureRootTypeId();

                return this.typeIdField;
            }
            set
            {
                this.typeIdField = value;
            }
        }

        [XmlElement("templateId")]
        public List<II> TemplateIds
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.templateIdField == null)
                    this.templateIdField = new List<II>();

                return this.templateIdField;
            }
            set
            {
                this.templateIdField = value;
            }
        }

        [XmlElement("id")]
        public List<II> Ids
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.idField == null)
                    this.idField = new List<II>();

                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        [XmlElement("code")]
        public CE Code
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.codeField == null)
                    this.codeField = new CE();

                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }

        [XmlElement("effectiveTime")]
        public IVL_TS EffectiveTime
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.effectiveTimeField == null)
                    this.effectiveTimeField = new IVL_TS();

                return this.effectiveTimeField;
            }
            set
            {
                this.effectiveTimeField = value;
            }
        }

        [XmlElement("dischargeDispositionCode")]
        public CE DischargeDispositionCode
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.dischargeDispositionCodeField == null)
                    this.dischargeDispositionCodeField = new CE();

                return this.dischargeDispositionCodeField;
            }
            set
            {
                this.dischargeDispositionCodeField = value;
            }
        }

        [XmlElement("responsibleParty")]
        public ResponsibleParty ResponsibleParty
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.responsiblePartyField == null)
                    this.responsiblePartyField = new ResponsibleParty();

                return this.responsiblePartyField;
            }
            set
            {
                this.responsiblePartyField = value;
            }
        }

        [XmlElement("encounterParticipant")]
        public EncounterParticipant[] EncounterParticipant
        {
            get
            {
                return this.encounterParticipantField;
            }
            set
            {
                this.encounterParticipantField = value;
            }
        }

        [XmlElement("location")]
        public Location Location
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.locationField == null)
                    this.locationField = new Location();

                return this.locationField;
            }
            set
            {
                this.locationField = value;
            }
        }

        [XmlAttribute("nullFlavor")]
        public string NullFlavor
        {
            get
            {
                return this.nullFlavorField;
            }
            set
            {
                this.nullFlavorField = value;
            }
        }

        [XmlAttribute("classCode")]
        public string ClassCode
        {
            get
            {
                return this.classCodeField;
            }
            set
            {
                this.classCodeField = value;
            }
        }

        [XmlAttribute("moodCode")]
        public string MoodCode
        {
            get
            {
                return this.moodCodeField;
            }
            set
            {
                this.moodCodeField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName = ".Component1", Namespace = "urn:hl7-org:v3")]
    public partial class Component1
    {

        private List<CS> realmCodeField;

        private InfrastructureRootTypeId typeIdField;

        private List<II> templateIdField;

        private EncompassingEncounter encompassingEncounterField;

        private string nullFlavorField;

        private ComponentTypeCodes typeCodeField;

        private bool typeCodeFieldSpecified;

        public Component1()
        {
            this.typeCodeField = ComponentTypeCodes.COMP;
        }

        [XmlElement("realmCode")]
        public List<CS> RealmCodes
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.realmCodeField == null)
                    this.realmCodeField = new List<CS>();

                return this.realmCodeField;
            }
            set
            {
                this.realmCodeField = value;
            }
        }

        [XmlElement("typeId")]
        public InfrastructureRootTypeId TypeId
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.typeIdField == null)
                    this.typeIdField = new InfrastructureRootTypeId();

                return this.typeIdField;
            }
            set
            {
                this.typeIdField = value;
            }
        }

        [XmlElement("templateId")]
        public List<II> TemplateIds
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.templateIdField == null)
                    this.templateIdField = new List<II>();

                return this.templateIdField;
            }
            set
            {
                this.templateIdField = value;
            }
        }

        [XmlElement("encompassingEncounter")]
        public EncompassingEncounter EncompassingEncounter
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.encompassingEncounterField == null)
                    this.encompassingEncounterField = new EncompassingEncounter();

                return this.encompassingEncounterField;
            }
            set
            {
                this.encompassingEncounterField = value;
            }
        }

        [XmlAttribute("nullFlavor")]
        public string NullFlavor
        {
            get
            {
                return this.nullFlavorField;
            }
            set
            {
                this.nullFlavorField = value;
            }
        }

        [XmlAttribute("typeCode")]
        public ComponentTypeCodes TypeCode
        {
            get
            {
                return this.typeCodeField;
            }
            set
            {
                this.typeCodeField = value;
            }
        }

        [XmlIgnore()]
        public bool TypeCodeSpecified
        {
            get
            {
                return this.typeCodeFieldSpecified;
            }
            set
            {
                this.typeCodeFieldSpecified = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName = ".Consent", Namespace = "urn:hl7-org:v3")]
    public partial class Consent
    {

        private List<CS> realmCodeField;

        private InfrastructureRootTypeId typeIdField;

        private List<II> templateIdField;

        private List<II> idField;

        private CE codeField;

        private CS statusCodeField;

        private string nullFlavorField;

        private string classCodeField;

        private string moodCodeField;

        public Consent()
        {
            this.classCodeField = "CONS";
            this.moodCodeField = "EVN";
        }

        [XmlElement("realmCode")]
        public List<CS> RealmCodes
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.realmCodeField == null)
                    this.realmCodeField = new List<CS>();

                return this.realmCodeField;
            }
            set
            {
                this.realmCodeField = value;
            }
        }

        [XmlElement("typeId")]
        public InfrastructureRootTypeId TypeId
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.typeIdField == null)
                    this.typeIdField = new InfrastructureRootTypeId();

                return this.typeIdField;
            }
            set
            {
                this.typeIdField = value;
            }
        }

        [XmlElement("templateId")]
        public List<II> TemplateIds
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.templateIdField == null)
                    this.templateIdField = new List<II>();

                return this.templateIdField;
            }
            set
            {
                this.templateIdField = value;
            }
        }

        [XmlElement("id")]
        public List<II> Ids
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.idField == null)
                    this.idField = new List<II>();

                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        [XmlElement("code")]
        public CE Code
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.codeField == null)
                    this.codeField = new CE();

                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }

        [XmlElement("statusCode")]
        public CS StatusCode
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.statusCodeField == null)
                    this.statusCodeField = new CS();

                return this.statusCodeField;
            }
            set
            {
                this.statusCodeField = value;
            }
        }

        [XmlAttribute("nullFlavor")]
        public string NullFlavor
        {
            get
            {
                return this.nullFlavorField;
            }
            set
            {
                this.nullFlavorField = value;
            }
        }

        [XmlAttribute("classCode")]
        public string ClassCode
        {
            get
            {
                return this.classCodeField;
            }
            set
            {
                this.classCodeField = value;
            }
        }

        [XmlAttribute("moodCode")]
        public string MoodCode
        {
            get
            {
                return this.moodCodeField;
            }
            set
            {
                this.moodCodeField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName = ".Authorization", Namespace = "urn:hl7-org:v3")]
    public partial class Authorization
    {

        private List<CS> realmCodeField;

        private InfrastructureRootTypeId typeIdField;

        private List<II> templateIdField;

        private Consent consentField;

        private string nullFlavorField;

        private string typeCodeField;

        public Authorization()
        {
            this.typeCodeField = "AUTH";
        }

        [XmlElement("realmCode")]
        public List<CS> RealmCodes
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.realmCodeField == null)
                    this.realmCodeField = new List<CS>();

                return this.realmCodeField;
            }
            set
            {
                this.realmCodeField = value;
            }
        }

        [XmlElement("typeId")]
        public InfrastructureRootTypeId TypeId
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.typeIdField == null)
                    this.typeIdField = new InfrastructureRootTypeId();

                return this.typeIdField;
            }
            set
            {
                this.typeIdField = value;
            }
        }

        [XmlElement("templateId")]
        public List<II> TemplateIds
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.templateIdField == null)
                    this.templateIdField = new List<II>();

                return this.templateIdField;
            }
            set
            {
                this.templateIdField = value;
            }
        }

        [XmlElement("consent")]
        public Consent Consent
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.consentField == null)
                    this.consentField = new Consent();

                return this.consentField;
            }
            set
            {
                this.consentField = value;
            }
        }

        [XmlAttribute("nullFlavor")]
        public string NullFlavor
        {
            get
            {
                return this.nullFlavorField;
            }
            set
            {
                this.nullFlavorField = value;
            }
        }

        [XmlAttribute("typeCode")]
        public string TypeCode
        {
            get
            {
                return this.typeCodeField;
            }
            set
            {
                this.typeCodeField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName = ".ParentDocument", Namespace = "urn:hl7-org:v3")]
    public partial class ParentDocument
    {

        private List<CS> realmCodeField;

        private InfrastructureRootTypeId typeIdField;

        private List<II> templateIdField;

        private List<II> idField;

        private CD codeField;

        private ED textField;

        private II setIdField;

        private INT versionNumberField;

        private string nullFlavorField;

        private ParentDocumentClassCodes classCodeField;

        private bool classCodeFieldSpecified;

        private string moodCodeField;

        public ParentDocument()
        {
            this.classCodeField = ParentDocumentClassCodes.DOCCLIN;
            this.moodCodeField = "EVN";
        }

        [XmlElement("realmCode")]
        public List<CS> RealmCodes
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.realmCodeField == null)
                    this.realmCodeField = new List<CS>();

                return this.realmCodeField;
            }
            set
            {
                this.realmCodeField = value;
            }
        }

        [XmlElement("typeId")]
        public InfrastructureRootTypeId TypeId
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.typeIdField == null)
                    this.typeIdField = new InfrastructureRootTypeId();

                return this.typeIdField;
            }
            set
            {
                this.typeIdField = value;
            }
        }

        [XmlElement("templateId")]
        public List<II> TemplateIds
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.templateIdField == null)
                    this.templateIdField = new List<II>();

                return this.templateIdField;
            }
            set
            {
                this.templateIdField = value;
            }
        }

        [XmlElement("id")]
        public List<II> Ids
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.idField == null)
                    this.idField = new List<II>();

                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        [XmlElement("code")]
        public CD Code
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.codeField == null)
                    this.codeField = new CD();

                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }

        [XmlElement("text")]
        public ED Text
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.textField == null)
                    this.textField = new ED();

                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }

        [XmlElement("setId")]
        public II SetId
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.setIdField == null)
                    this.setIdField = new II();

                return this.setIdField;
            }
            set
            {
                this.setIdField = value;
            }
        }

        [XmlElement("versionNumber")]
        public INT VersionNumber
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.versionNumberField == null)
                    this.versionNumberField = new INT();

                return this.versionNumberField;
            }
            set
            {
                this.versionNumberField = value;
            }
        }

        [XmlAttribute("nullFlavor")]
        public string NullFlavor
        {
            get
            {
                return this.nullFlavorField;
            }
            set
            {
                this.nullFlavorField = value;
            }
        }

        [XmlAttribute("classCode")]
        public ParentDocumentClassCodes ClassCode
        {
            get
            {
                return this.classCodeField;
            }
            set
            {
                this.classCodeField = value;
            }
        }

        [XmlIgnore()]
        public bool ClassCodeSpecified
        {
            get
            {
                return this.classCodeFieldSpecified;
            }
            set
            {
                this.classCodeFieldSpecified = value;
            }
        }

        [XmlAttribute("moodCode")]
        public string MoodCode
        {
            get
            {
                return this.moodCodeField;
            }
            set
            {
                this.moodCodeField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName = ".RelatedDocument", Namespace = "urn:hl7-org:v3")]
    public partial class RelatedDocument
    {

        private List<CS> realmCodeField;

        private InfrastructureRootTypeId typeIdField;

        private List<II> templateIdField;

        private ParentDocument parentDocumentField;

        private string nullFlavorField;

        private RelatedDocumentTypeCodes typeCodeField;

        [XmlElement("realmCode")]
        public List<CS> RealmCodes
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.realmCodeField == null)
                    this.realmCodeField = new List<CS>();

                return this.realmCodeField;
            }
            set
            {
                this.realmCodeField = value;
            }
        }

        [XmlElement("typeId")]
        public InfrastructureRootTypeId TypeId
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.typeIdField == null)
                    this.typeIdField = new InfrastructureRootTypeId();

                return this.typeIdField;
            }
            set
            {
                this.typeIdField = value;
            }
        }

        [XmlElement("templateId")]
        public List<II> TemplateIds
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.templateIdField == null)
                    this.templateIdField = new List<II>();

                return this.templateIdField;
            }
            set
            {
                this.templateIdField = value;
            }
        }

        [XmlElement("parentDocument")]
        public ParentDocument ParentDocument
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.parentDocumentField == null)
                    this.parentDocumentField = new ParentDocument();

                return this.parentDocumentField;
            }
            set
            {
                this.parentDocumentField = value;
            }
        }

        [XmlAttribute("nullFlavor")]
        public string NullFlavor
        {
            get
            {
                return this.nullFlavorField;
            }
            set
            {
                this.nullFlavorField = value;
            }
        }

        [XmlAttribute("typeCode")]
        public RelatedDocumentTypeCodes TypeCode
        {
            get
            {
                return this.typeCodeField;
            }
            set
            {
                this.typeCodeField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName = ".Performer1", Namespace = "urn:hl7-org:v3")]
    public partial class Performer1
    {

        private List<CS> realmCodeField;

        private InfrastructureRootTypeId typeIdField;

        private List<II> templateIdField;

        private CE functionCodeField;

        private IVL_TS timeField;

        private AssignedEntity assignedEntityField;

        private string nullFlavorField;

        private Performer1TypeCodes typeCodeField;

        [XmlElement("realmCode")]
        public List<CS> RealmCodes
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.realmCodeField == null)
                    this.realmCodeField = new List<CS>();

                return this.realmCodeField;
            }
            set
            {
                this.realmCodeField = value;
            }
        }

        [XmlElement("typeId")]
        public InfrastructureRootTypeId TypeId
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.typeIdField == null)
                    this.typeIdField = new InfrastructureRootTypeId();

                return this.typeIdField;
            }
            set
            {
                this.typeIdField = value;
            }
        }

        [XmlElement("templateId")]
        public List<II> TemplateIds
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.templateIdField == null)
                    this.templateIdField = new List<II>();

                return this.templateIdField;
            }
            set
            {
                this.templateIdField = value;
            }
        }

        [XmlElement("functionCode")]
        public CE FunctionCode
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.functionCodeField == null)
                    this.functionCodeField = new CE();

                return this.functionCodeField;
            }
            set
            {
                this.functionCodeField = value;
            }
        }

        [XmlElement("time")]
        public IVL_TS Time
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.timeField == null)
                    this.timeField = new IVL_TS();

                return this.timeField;
            }
            set
            {
                this.timeField = value;
            }
        }

        [XmlElement("assignedEntity")]
        public AssignedEntity AssignedEntity
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.assignedEntityField == null)
                    this.assignedEntityField = new AssignedEntity();

                return this.assignedEntityField;
            }
            set
            {
                this.assignedEntityField = value;
            }
        }

        [XmlAttribute("nullFlavor")]
        public string NullFlavor
        {
            get
            {
                return this.nullFlavorField;
            }
            set
            {
                this.nullFlavorField = value;
            }
        }

        [XmlAttribute("typeCode")]
        public Performer1TypeCodes TypeCode
        {
            get
            {
                return this.typeCodeField;
            }
            set
            {
                this.typeCodeField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName = ".ServiceEvent", Namespace = "urn:hl7-org:v3")]
    public partial class ServiceEvent
    {

        private List<CS> realmCodeField;

        private InfrastructureRootTypeId typeIdField;

        private List<II> templateIdField;

        private List<II> idField;

        private CE codeField;

        private IVL_TS effectiveTimeField;

        private Performer1[] performerField;

        private string nullFlavorField;

        private string classCodeField;

        private string moodCodeField;

        public ServiceEvent()
        {
            this.classCodeField = "ACT";
            this.moodCodeField = "EVN";
        }

        [XmlElement("realmCode")]
        public List<CS> RealmCodes
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.realmCodeField == null)
                    this.realmCodeField = new List<CS>();

                return this.realmCodeField;
            }
            set
            {
                this.realmCodeField = value;
            }
        }

        [XmlElement("typeId")]
        public InfrastructureRootTypeId TypeId
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.typeIdField == null)
                    this.typeIdField = new InfrastructureRootTypeId();

                return this.typeIdField;
            }
            set
            {
                this.typeIdField = value;
            }
        }

        [XmlElement("templateId")]
        public List<II> TemplateIds
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.templateIdField == null)
                    this.templateIdField = new List<II>();

                return this.templateIdField;
            }
            set
            {
                this.templateIdField = value;
            }
        }

        [XmlElement("id")]
        public List<II> Ids
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.idField == null)
                    this.idField = new List<II>();

                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        [XmlElement("code")]
        public CE Code
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.codeField == null)
                    this.codeField = new CE();

                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }

        [XmlElement("effectiveTime")]
        public IVL_TS EffectiveTime
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.effectiveTimeField == null)
                    this.effectiveTimeField = new IVL_TS();

                return this.effectiveTimeField;
            }
            set
            {
                this.effectiveTimeField = value;
            }
        }

        [XmlElement("performer")]
        public Performer1[] Performer
        {
            get
            {
                return this.performerField;
            }
            set
            {
                this.performerField = value;
            }
        }

        [XmlAttribute("nullFlavor")]
        public string NullFlavor
        {
            get
            {
                return this.nullFlavorField;
            }
            set
            {
                this.nullFlavorField = value;
            }
        }

        [XmlAttribute("classCode")]
        [System.ComponentModel.DefaultValueAttribute("ACT")]
        public string ClassCode
        {
            get
            {
                return this.classCodeField;
            }
            set
            {
                this.classCodeField = value;
            }
        }

        [XmlAttribute("moodCode")]
        public string MoodCode
        {
            get
            {
                return this.moodCodeField;
            }
            set
            {
                this.moodCodeField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName = ".DocumentationOf", Namespace = "urn:hl7-org:v3")]
    public partial class DocumentationOf
    {

        private List<CS> realmCodeField;

        private InfrastructureRootTypeId typeIdField;

        private List<II> templateIdField;

        private ServiceEvent serviceEventField;

        private string nullFlavorField;

        private string typeCodeField;

        public DocumentationOf()
        {
            this.typeCodeField = "DOC";
        }

        [XmlElement("realmCode")]
        public List<CS> RealmCodes
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.realmCodeField == null)
                    this.realmCodeField = new List<CS>();

                return this.realmCodeField;
            }
            set
            {
                this.realmCodeField = value;
            }
        }

        [XmlElement("typeId")]
        public InfrastructureRootTypeId TypeId
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.typeIdField == null)
                    this.typeIdField = new InfrastructureRootTypeId();

                return this.typeIdField;
            }
            set
            {
                this.typeIdField = value;
            }
        }

        [XmlElement("templateId")]
        public List<II> TemplateIds
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.templateIdField == null)
                    this.templateIdField = new List<II>();

                return this.templateIdField;
            }
            set
            {
                this.templateIdField = value;
            }
        }

        [XmlElement("serviceEvent")]
        public ServiceEvent ServiceEvent
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.serviceEventField == null)
                    this.serviceEventField = new ServiceEvent();

                return this.serviceEventField;
            }
            set
            {
                this.serviceEventField = value;
            }
        }

        [XmlAttribute("nullFlavor")]
        public string NullFlavor
        {
            get
            {
                return this.nullFlavorField;
            }
            set
            {
                this.nullFlavorField = value;
            }
        }

        [XmlAttribute("typeCode")]
        public string TypeCode
        {
            get
            {
                return this.typeCodeField;
            }
            set
            {
                this.typeCodeField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName = ".Order", Namespace = "urn:hl7-org:v3")]
    public partial class Order
    {

        private List<CS> realmCodeField;

        private InfrastructureRootTypeId typeIdField;

        private List<II> templateIdField;

        private List<II> idField;

        private CE codeField;

        private CE priorityCodeField;

        private string nullFlavorField;

        private string classCodeField;

        private string moodCodeField;

        public Order()
        {
            this.classCodeField = "ACT";
            this.moodCodeField = "RQO";
        }

        [XmlElement("realmCode")]
        public List<CS> RealmCodes
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.realmCodeField == null)
                    this.realmCodeField = new List<CS>();

                return this.realmCodeField;
            }
            set
            {
                this.realmCodeField = value;
            }
        }

        [XmlElement("typeId")]
        public InfrastructureRootTypeId TypeId
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.typeIdField == null)
                    this.typeIdField = new InfrastructureRootTypeId();

                return this.typeIdField;
            }
            set
            {
                this.typeIdField = value;
            }
        }

        [XmlElement("templateId")]
        public List<II> TemplateIds
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.templateIdField == null)
                    this.templateIdField = new List<II>();

                return this.templateIdField;
            }
            set
            {
                this.templateIdField = value;
            }
        }

        [XmlElement("id")]
        public List<II> Ids
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.idField == null)
                    this.idField = new List<II>();

                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        [XmlElement("code")]
        public CE Code
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.codeField == null)
                    this.codeField = new CE();

                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }

        [XmlElement("priorityCode")]
        public CE PriorityCode
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.priorityCodeField == null)
                    this.priorityCodeField = new CE();

                return this.priorityCodeField;
            }
            set
            {
                this.priorityCodeField = value;
            }
        }

        [XmlAttribute("nullFlavor")]
        public string NullFlavor
        {
            get
            {
                return this.nullFlavorField;
            }
            set
            {
                this.nullFlavorField = value;
            }
        }

        [XmlAttribute("classCode")]
        [System.ComponentModel.DefaultValueAttribute("ACT")]
        public string ClassCode
        {
            get
            {
                return this.classCodeField;
            }
            set
            {
                this.classCodeField = value;
            }
        }

        [XmlAttribute("moodCode")]
        public string MoodCode
        {
            get
            {
                return this.moodCodeField;
            }
            set
            {
                this.moodCodeField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName = ".InFulfillmentOf", Namespace = "urn:hl7-org:v3")]
    public partial class InFulfillmentOf
    {

        private List<CS> realmCodeField;

        private InfrastructureRootTypeId typeIdField;

        private List<II> templateIdField;

        private Order orderField;

        private string nullFlavorField;

        private InFulfillmentOfTypeCodes typeCodeField;

        private bool typeCodeFieldSpecified;

        public InFulfillmentOf()
        {
            this.typeCodeField = InFulfillmentOfTypeCodes.FLFS;
        }

        [XmlElement("realmCode")]
        public List<CS> RealmCodes
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.realmCodeField == null)
                    this.realmCodeField = new List<CS>();

                return this.realmCodeField;
            }
            set
            {
                this.realmCodeField = value;
            }
        }

        [XmlElement("typeId")]
        public InfrastructureRootTypeId TypeId
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.typeIdField == null)
                    this.typeIdField = new InfrastructureRootTypeId();

                return this.typeIdField;
            }
            set
            {
                this.typeIdField = value;
            }
        }

        [XmlElement("templateId")]
        public List<II> TemplateIds
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.templateIdField == null)
                    this.templateIdField = new List<II>();

                return this.templateIdField;
            }
            set
            {
                this.templateIdField = value;
            }
        }

        [XmlElement("order")]
        public Order Order
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.orderField == null)
                    this.orderField = new Order();

                return this.orderField;
            }
            set
            {
                this.orderField = value;
            }
        }

        [XmlAttribute("nullFlavor")]
        public string NullFlavor
        {
            get
            {
                return this.nullFlavorField;
            }
            set
            {
                this.nullFlavorField = value;
            }
        }

        [XmlAttribute("typeCode")]
        public InFulfillmentOfTypeCodes TypeCode
        {
            get
            {
                return this.typeCodeField;
            }
            set
            {
                this.typeCodeField = value;
            }
        }

        [XmlIgnore()]
        public bool TypeCodeSpecified
        {
            get
            {
                return this.typeCodeFieldSpecified;
            }
            set
            {
                this.typeCodeFieldSpecified = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName = ".AssociatedEntity", Namespace = "urn:hl7-org:v3")]
    public partial class AssociatedEntity
    {

        private List<CS> realmCodeField;

        private InfrastructureRootTypeId typeIdField;

        private List<II> templateIdField;

        private List<II> idField;

        private CE codeField;

        private List<AD> addrField;

        private List<TEL> telecomField;

        private Person associatedPersonField;

        private Organization scopingOrganizationField;

        private string nullFlavorField;

        private string classCodeField;

        [XmlElement("realmCode")]
        public List<CS> RealmCodes
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.realmCodeField == null)
                    this.realmCodeField = new List<CS>();

                return this.realmCodeField;
            }
            set
            {
                this.realmCodeField = value;
            }
        }

        [XmlElement("typeId")]
        public InfrastructureRootTypeId TypeId
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.typeIdField == null)
                    this.typeIdField = new InfrastructureRootTypeId();

                return this.typeIdField;
            }
            set
            {
                this.typeIdField = value;
            }
        }

        [XmlElement("templateId")]
        public List<II> TemplateIds
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.templateIdField == null)
                    this.templateIdField = new List<II>();

                return this.templateIdField;
            }
            set
            {
                this.templateIdField = value;
            }
        }

        [XmlElement("id")]
        public List<II> Ids
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.idField == null)
                    this.idField = new List<II>();

                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        [XmlElement("code")]
        public CE Code
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.codeField == null)
                    this.codeField = new CE();

                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }

        [XmlElement("addr")]
        public List<AD> Addr
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.addrField == null)
                    this.addrField = new List<AD>();

                return this.addrField;
            }
            set
            {
                this.addrField = value;
            }
        }

        [XmlElement("telecom")]
        public List<TEL> Telecom
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.telecomField == null)
                    this.telecomField = new List<TEL>();

                return this.telecomField;
            }
            set
            {
                this.telecomField = value;
            }
        }

        [XmlElement("associatedPerson")]
        public Person AssociatedPerson
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.associatedPersonField == null)
                    this.associatedPersonField = new Person();

                return this.associatedPersonField;
            }
            set
            {
                this.associatedPersonField = value;
            }
        }

        [XmlElement("scopingOrganization")]
        public Organization ScopingOrganization
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.scopingOrganizationField == null)
                    this.scopingOrganizationField = new Organization();

                return this.scopingOrganizationField;
            }
            set
            {
                this.scopingOrganizationField = value;
            }
        }

        [XmlAttribute("nullFlavor")]
        public string NullFlavor
        {
            get
            {
                return this.nullFlavorField;
            }
            set
            {
                this.nullFlavorField = value;
            }
        }

        [XmlAttribute("classCode")]
        public string ClassCode
        {
            get
            {
                return this.classCodeField;
            }
            set
            {
                this.classCodeField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName = ".Participant1", Namespace = "urn:hl7-org:v3")]
    public partial class Participant1
    {

        private List<CS> realmCodeField;

        private InfrastructureRootTypeId typeIdField;

        private List<II> templateIdField;

        private CE functionCodeField;

        private IVL_TS timeField;

        private AssociatedEntity associatedEntityField;

        private string nullFlavorField;

        private string typeCodeField;

        private string contextControlCodeField;

        public Participant1()
        {
            this.contextControlCodeField = "OP";
        }

        [XmlElement("realmCode")]
        public List<CS> RealmCodes
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.realmCodeField == null)
                    this.realmCodeField = new List<CS>();

                return this.realmCodeField;
            }
            set
            {
                this.realmCodeField = value;
            }
        }

        [XmlElement("typeId")]
        public InfrastructureRootTypeId TypeId
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.typeIdField == null)
                    this.typeIdField = new InfrastructureRootTypeId();

                return this.typeIdField;
            }
            set
            {
                this.typeIdField = value;
            }
        }

        [XmlElement("templateId")]
        public List<II> TemplateIds
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.templateIdField == null)
                    this.templateIdField = new List<II>();

                return this.templateIdField;
            }
            set
            {
                this.templateIdField = value;
            }
        }

        [XmlElement("functionCode")]
        public CE FunctionCode
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.functionCodeField == null)
                    this.functionCodeField = new CE();

                return this.functionCodeField;
            }
            set
            {
                this.functionCodeField = value;
            }
        }

        [XmlElement("time")]
        public IVL_TS Time
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.timeField == null)
                    this.timeField = new IVL_TS();

                return this.timeField;
            }
            set
            {
                this.timeField = value;
            }
        }

        [XmlElement("associatedEntity")]
        public AssociatedEntity AssociatedEntity
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.associatedEntityField == null)
                    this.associatedEntityField = new AssociatedEntity();

                return this.associatedEntityField;
            }
            set
            {
                this.associatedEntityField = value;
            }
        }

        [XmlAttribute("nullFlavor")]
        public string NullFlavor
        {
            get
            {
                return this.nullFlavorField;
            }
            set
            {
                this.nullFlavorField = value;
            }
        }

        [XmlAttribute("typeCode")]
        public string TypeCode
        {
            get
            {
                return this.typeCodeField;
            }
            set
            {
                this.typeCodeField = value;
            }
        }

        [XmlAttribute("contextControlCode")]
        public string ContextControlCode
        {
            get
            {
                return this.contextControlCodeField;
            }
            set
            {
                this.contextControlCodeField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName = ".Authenticator", Namespace = "urn:hl7-org:v3")]
    public partial class Authenticator
    {

        private List<CS> realmCodeField;

        private InfrastructureRootTypeId typeIdField;

        private List<II> templateIdField;

        private TS timeField;

        private CS signatureCodeField;

        private AssignedEntity assignedEntityField;

        private string nullFlavorField;

        private string typeCodeField;

        public Authenticator()
        {
            this.typeCodeField = "AUTHEN";
        }

        [XmlElement("realmCode")]
        public List<CS> RealmCodes
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.realmCodeField == null)
                    this.realmCodeField = new List<CS>();

                return this.realmCodeField;
            }
            set
            {
                this.realmCodeField = value;
            }
        }

        [XmlElement("typeId")]
        public InfrastructureRootTypeId TypeId
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.typeIdField == null)
                    this.typeIdField = new InfrastructureRootTypeId();

                return this.typeIdField;
            }
            set
            {
                this.typeIdField = value;
            }
        }

        [XmlElement("templateId")]
        public List<II> TemplateIds
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.templateIdField == null)
                    this.templateIdField = new List<II>();

                return this.templateIdField;
            }
            set
            {
                this.templateIdField = value;
            }
        }

        [XmlElement("time")]
        public TS Time
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.timeField == null)
                    this.timeField = new TS();

                return this.timeField;
            }
            set
            {
                this.timeField = value;
            }
        }

        [XmlElement("signatureCode")]
        public CS SignatureCode
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.signatureCodeField == null)
                    this.signatureCodeField = new CS();

                return this.signatureCodeField;
            }
            set
            {
                this.signatureCodeField = value;
            }
        }

        [XmlElement("assignedEntity")]
        public AssignedEntity AssignedEntity
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.assignedEntityField == null)
                    this.assignedEntityField = new AssignedEntity();

                return this.assignedEntityField;
            }
            set
            {
                this.assignedEntityField = value;
            }
        }

        [XmlAttribute("nullFlavor")]
        public string NullFlavor
        {
            get
            {
                return this.nullFlavorField;
            }
            set
            {
                this.nullFlavorField = value;
            }
        }

        [XmlAttribute("typeCode")]
        public string TypeCode
        {
            get
            {
                return this.typeCodeField;
            }
            set
            {
                this.typeCodeField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName = ".LegalAuthenticator", Namespace = "urn:hl7-org:v3")]
    public partial class LegalAuthenticator
    {

        private List<CS> realmCodeField;

        private InfrastructureRootTypeId typeIdField;

        private List<II> templateIdField;

        private TS timeField;

        private CS signatureCodeField;

        private AssignedEntity assignedEntityField;

        private string nullFlavorField;

        private string typeCodeField;

        private string contextControlCodeField;

        public LegalAuthenticator()
        {
            this.typeCodeField = "LA";
            this.contextControlCodeField = "OP";
        }

        [XmlElement("realmCode")]
        public List<CS> RealmCodes
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.realmCodeField == null)
                    this.realmCodeField = new List<CS>();

                return this.realmCodeField;
            }
            set
            {
                this.realmCodeField = value;
            }
        }

        [XmlElement("typeId")]
        public InfrastructureRootTypeId TypeId
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.typeIdField == null)
                    this.typeIdField = new InfrastructureRootTypeId();

                return this.typeIdField;
            }
            set
            {
                this.typeIdField = value;
            }
        }

        [XmlElement("templateId")]
        public List<II> TemplateIds
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.templateIdField == null)
                    this.templateIdField = new List<II>();

                return this.templateIdField;
            }
            set
            {
                this.templateIdField = value;
            }
        }

        [XmlElement("time")]
        public TS Time
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.timeField == null)
                    this.timeField = new TS();

                return this.timeField;
            }
            set
            {
                this.timeField = value;
            }
        }

        [XmlElement("signatureCode")]
        public CS SignatureCode
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.signatureCodeField == null)
                    this.signatureCodeField = new CS();

                return this.signatureCodeField;
            }
            set
            {
                this.signatureCodeField = value;
            }
        }

        [XmlElement("assignedEntity")]
        public AssignedEntity AssignedEntity
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.assignedEntityField == null)
                    this.assignedEntityField = new AssignedEntity();

                return this.assignedEntityField;
            }
            set
            {
                this.assignedEntityField = value;
            }
        }

        [XmlAttribute("nullFlavor")]
        public string NullFlavor
        {
            get
            {
                return this.nullFlavorField;
            }
            set
            {
                this.nullFlavorField = value;
            }
        }

        [XmlAttribute("typeCode")]
        public string TypeCode
        {
            get
            {
                return this.typeCodeField;
            }
            set
            {
                this.typeCodeField = value;
            }
        }

        [XmlAttribute("contextControlCode")]
        public string ContextControlCode
        {
            get
            {
                return this.contextControlCodeField;
            }
            set
            {
                this.contextControlCodeField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName = ".IntendedRecipient", Namespace = "urn:hl7-org:v3")]
    public partial class IntendedRecipient
    {

        private List<CS> realmCodeField;

        private InfrastructureRootTypeId typeIdField;

        private List<II> templateIdField;

        private List<II> idField;

        private List<AD> addrField;

        private List<TEL> telecomField;

        private Person informationRecipientField;

        private Organization receivedOrganizationField;

        private string nullFlavorField;

        private IntendedRecipientClassCodes classCodeField;

        public IntendedRecipient()
        {
            this.classCodeField = IntendedRecipientClassCodes.ASSIGNED;
        }

        [XmlElement("realmCode")]
        public List<CS> RealmCodes
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.realmCodeField == null)
                    this.realmCodeField = new List<CS>();

                return this.realmCodeField;
            }
            set
            {
                this.realmCodeField = value;
            }
        }

        [XmlElement("typeId")]
        public InfrastructureRootTypeId TypeId
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.typeIdField == null)
                    this.typeIdField = new InfrastructureRootTypeId();

                return this.typeIdField;
            }
            set
            {
                this.typeIdField = value;
            }
        }

        [XmlElement("templateId")]
        public List<II> TemplateIds
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.templateIdField == null)
                    this.templateIdField = new List<II>();

                return this.templateIdField;
            }
            set
            {
                this.templateIdField = value;
            }
        }

        [XmlElement("id")]
        public List<II> Ids
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.idField == null)
                    this.idField = new List<II>();

                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        [XmlElement("addr")]
        public List<AD> Addr
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.addrField == null)
                    this.addrField = new List<AD>();

                return this.addrField;
            }
            set
            {
                this.addrField = value;
            }
        }

        [XmlElement("telecom")]
        public List<TEL> Telecom
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.telecomField == null)
                    this.telecomField = new List<TEL>();

                return this.telecomField;
            }
            set
            {
                this.telecomField = value;
            }
        }

        public Person InformationRecipient
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.informationRecipientField == null)
                    this.informationRecipientField = new Person();

                return this.informationRecipientField;
            }
            set
            {
                this.informationRecipientField = value;
            }
        }

        [XmlElement("receivedOrganization")]
        public Organization ReceivedOrganization
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.receivedOrganizationField == null)
                    this.receivedOrganizationField = new Organization();

                return this.receivedOrganizationField;
            }
            set
            {
                this.receivedOrganizationField = value;
            }
        }

        [XmlAttribute("nullFlavor")]
        public string NullFlavor
        {
            get
            {
                return this.nullFlavorField;
            }
            set
            {
                this.nullFlavorField = value;
            }
        }

        [XmlAttribute("classCode")]
        [System.ComponentModel.DefaultValueAttribute(IntendedRecipientClassCodes.ASSIGNED)]
        public IntendedRecipientClassCodes ClassCode
        {
            get
            {
                return this.classCodeField;
            }
            set
            {
                this.classCodeField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName = ".InformationRecipient", Namespace = "urn:hl7-org:v3")]
    public partial class InformationRecipient
    {

        private List<CS> realmCodeField;

        private InfrastructureRootTypeId typeIdField;

        private List<II> templateIdField;

        private IntendedRecipient intendedRecipientField;

        private string nullFlavorField;

        private InformationRecipientTypeCodes typeCodeField;

        public InformationRecipient()
        {
            this.typeCodeField = InformationRecipientTypeCodes.PRCP;
        }

        [XmlElement("realmCode")]
        public List<CS> RealmCodes
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.realmCodeField == null)
                    this.realmCodeField = new List<CS>();

                return this.realmCodeField;
            }
            set
            {
                this.realmCodeField = value;
            }
        }

        [XmlElement("typeId")]
        public InfrastructureRootTypeId TypeId
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.typeIdField == null)
                    this.typeIdField = new InfrastructureRootTypeId();

                return this.typeIdField;
            }
            set
            {
                this.typeIdField = value;
            }
        }

        [XmlElement("templateId")]
        public List<II> TemplateIds
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.templateIdField == null)
                    this.templateIdField = new List<II>();

                return this.templateIdField;
            }
            set
            {
                this.templateIdField = value;
            }
        }

        [XmlElement("intendedRecipient")]
        public IntendedRecipient IntendedRecipient
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.intendedRecipientField == null)
                    this.intendedRecipientField = new IntendedRecipient();

                return this.intendedRecipientField;
            }
            set
            {
                this.intendedRecipientField = value;
            }
        }

        [XmlAttribute("nullFlavor")]
        public string NullFlavor
        {
            get
            {
                return this.nullFlavorField;
            }
            set
            {
                this.nullFlavorField = value;
            }
        }

        [XmlAttribute("typeCode")]
        [System.ComponentModel.DefaultValueAttribute(InformationRecipientTypeCodes.PRCP)]
        public InformationRecipientTypeCodes TypeCode
        {
            get
            {
                return this.typeCodeField;
            }
            set
            {
                this.typeCodeField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName = ".CustodianOrganization", Namespace = "urn:hl7-org:v3")]
    public partial class CustodianOrganization
    {

        private List<CS> realmCodeField;

        private InfrastructureRootTypeId typeIdField;

        private List<II> templateIdField;

        private List<II> idField;

        private ON nameField;

        private TEL telecomField;

        private AD addrField;

        private string nullFlavorField;

        private string classCodeField;

        private string determinerCodeField;

        public CustodianOrganization()
        {
            this.classCodeField = "ORG";
            this.determinerCodeField = "INSTANCE";
        }

        [XmlElement("realmCode")]
        public List<CS> RealmCodes
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.realmCodeField == null)
                    this.realmCodeField = new List<CS>();

                return this.realmCodeField;
            }
            set
            {
                this.realmCodeField = value;
            }
        }

        [XmlElement("typeId")]
        public InfrastructureRootTypeId TypeId
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.typeIdField == null)
                    this.typeIdField = new InfrastructureRootTypeId();

                return this.typeIdField;
            }
            set
            {
                this.typeIdField = value;
            }
        }

        [XmlElement("templateId")]
        public List<II> TemplateIds
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.templateIdField == null)
                    this.templateIdField = new List<II>();

                return this.templateIdField;
            }
            set
            {
                this.templateIdField = value;
            }
        }

        [XmlElement("id")]
        public List<II> Ids
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.idField == null)
                    this.idField = new List<II>();

                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        [XmlElement("name")]
        public ON Name
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.nameField == null)
                    this.nameField = new ON();

                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        [XmlElement("telecom")]
        public TEL Telecom
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.telecomField == null)
                    this.telecomField = new TEL();

                return this.telecomField;
            }
            set
            {
                this.telecomField = value;
            }
        }

        [XmlElement("addr")]
        public AD Addr
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.addrField == null)
                    this.addrField = new AD();

                return this.addrField;
            }
            set
            {
                this.addrField = value;
            }
        }

        [XmlAttribute("nullFlavor")]
        public string NullFlavor
        {
            get
            {
                return this.nullFlavorField;
            }
            set
            {
                this.nullFlavorField = value;
            }
        }

        [XmlAttribute("classCode")]
        public string ClassCode
        {
            get
            {
                return this.classCodeField;
            }
            set
            {
                this.classCodeField = value;
            }
        }

        [XmlAttribute("determinerCode")]
        public string DeterminerCode
        {
            get
            {
                return this.determinerCodeField;
            }
            set
            {
                this.determinerCodeField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName = ".AssignedCustodian", Namespace = "urn:hl7-org:v3")]
    public partial class AssignedCustodian
    {

        private List<CS> realmCodeField;

        private InfrastructureRootTypeId typeIdField;

        private List<II> templateIdField;

        private CustodianOrganization representedCustodianOrganizationField;

        private string nullFlavorField;

        private string classCodeField;

        public AssignedCustodian()
        {
            this.classCodeField = "ASSIGNED";
        }

        [XmlElement("realmCode")]
        public List<CS> RealmCodes
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.realmCodeField == null)
                    this.realmCodeField = new List<CS>();

                return this.realmCodeField;
            }
            set
            {
                this.realmCodeField = value;
            }
        }

        [XmlElement("typeId")]
        public InfrastructureRootTypeId TypeId
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.typeIdField == null)
                    this.typeIdField = new InfrastructureRootTypeId();

                return this.typeIdField;
            }
            set
            {
                this.typeIdField = value;
            }
        }

        [XmlElement("templateId")]
        public List<II> TemplateIds
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.templateIdField == null)
                    this.templateIdField = new List<II>();

                return this.templateIdField;
            }
            set
            {
                this.templateIdField = value;
            }
        }

        [XmlElement("representedCustodianOrganization")]
        public CustodianOrganization RepresentedCustodianOrganization
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.representedCustodianOrganizationField == null)
                    this.representedCustodianOrganizationField = new CustodianOrganization();

                return this.representedCustodianOrganizationField;
            }
            set
            {
                this.representedCustodianOrganizationField = value;
            }
        }

        [XmlAttribute("nullFlavor")]
        public string NullFlavor
        {
            get
            {
                return this.nullFlavorField;
            }
            set
            {
                this.nullFlavorField = value;
            }
        }

        [XmlAttribute("classCode")]
        public string ClassCode
        {
            get
            {
                return this.classCodeField;
            }
            set
            {
                this.classCodeField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName = ".Custodian", Namespace = "urn:hl7-org:v3")]
    public partial class Custodian
    {

        private List<CS> realmCodeField;

        private InfrastructureRootTypeId typeIdField;

        private List<II> templateIdField;

        private AssignedCustodian assignedCustodianField;

        private string nullFlavorField;

        private string typeCodeField;

        public Custodian()
        {
            this.typeCodeField = "CST";
        }

        [XmlElement("realmCode")]
        public List<CS> RealmCodes
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.realmCodeField == null)
                    this.realmCodeField = new List<CS>();

                return this.realmCodeField;
            }
            set
            {
                this.realmCodeField = value;
            }
        }

        [XmlElement("typeId")]
        public InfrastructureRootTypeId TypeId
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.typeIdField == null)
                    this.typeIdField = new InfrastructureRootTypeId();

                return this.typeIdField;
            }
            set
            {
                this.typeIdField = value;
            }
        }

        [XmlElement("templateId")]
        public List<II> TemplateIds
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.templateIdField == null)
                    this.templateIdField = new List<II>();

                return this.templateIdField;
            }
            set
            {
                this.templateIdField = value;
            }
        }

        [XmlElement("assignedCustodian")]
        public AssignedCustodian AssignedCustodian
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.assignedCustodianField == null)
                    this.assignedCustodianField = new AssignedCustodian();

                return this.assignedCustodianField;
            }
            set
            {
                this.assignedCustodianField = value;
            }
        }

        [XmlAttribute("nullFlavor")]
        public string NullFlavor
        {
            get
            {
                return this.nullFlavorField;
            }
            set
            {
                this.nullFlavorField = value;
            }
        }

        [XmlAttribute("typeCode")]
        public string TypeCode
        {
            get
            {
                return this.typeCodeField;
            }
            set
            {
                this.typeCodeField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName = ".DataEnterer", Namespace = "urn:hl7-org:v3")]
    public partial class DataEnterer
    {

        private List<CS> realmCodeField;

        private InfrastructureRootTypeId typeIdField;

        private List<II> templateIdField;

        private TS timeField;

        private AssignedEntity assignedEntityField;

        private string nullFlavorField;

        private string typeCodeField;

        private string contextControlCodeField;

        public DataEnterer()
        {
            this.typeCodeField = "ENT";
            this.contextControlCodeField = "OP";
        }

        [XmlElement("realmCode")]
        public List<CS> RealmCodes
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.realmCodeField == null)
                    this.realmCodeField = new List<CS>();

                return this.realmCodeField;
            }
            set
            {
                this.realmCodeField = value;
            }
        }

        [XmlElement("typeId")]
        public InfrastructureRootTypeId TypeId
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.typeIdField == null)
                    this.typeIdField = new InfrastructureRootTypeId();

                return this.typeIdField;
            }
            set
            {
                this.typeIdField = value;
            }
        }

        [XmlElement("templateId")]
        public List<II> TemplateIds
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.templateIdField == null)
                    this.templateIdField = new List<II>();

                return this.templateIdField;
            }
            set
            {
                this.templateIdField = value;
            }
        }

        [XmlElement("time")]
        public TS Time
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.timeField == null)
                    this.timeField = new TS();

                return this.timeField;
            }
            set
            {
                this.timeField = value;
            }
        }

        [XmlElement("assignedEntity")]
        public AssignedEntity AssignedEntity
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.assignedEntityField == null)
                    this.assignedEntityField = new AssignedEntity();

                return this.assignedEntityField;
            }
            set
            {
                this.assignedEntityField = value;
            }
        }

        [XmlAttribute("nullFlavor")]
        public string NullFlavor
        {
            get
            {
                return this.nullFlavorField;
            }
            set
            {
                this.nullFlavorField = value;
            }
        }

        [XmlAttribute("typeCode")]
        public string TypeCode
        {
            get
            {
                return this.typeCodeField;
            }
            set
            {
                this.typeCodeField = value;
            }
        }

        [XmlAttribute("contextControlCode")]
        public string ContextControlCode
        {
            get
            {
                return this.contextControlCodeField;
            }
            set
            {
                this.contextControlCodeField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName = ".LanguageCommunication", Namespace = "urn:hl7-org:v3")]
    public partial class LanguageCommunication
    {

        private List<CS> realmCodeField;

        private InfrastructureRootTypeId typeIdField;

        private List<II> templateIdField;

        private CS languageCodeField;

        private CE modeCodeField;

        private CE proficiencyLevelCodeField;

        private BL preferenceIndField;

        private string nullFlavorField;

        [XmlElement("realmCode")]
        public List<CS> RealmCodes
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.realmCodeField == null)
                    this.realmCodeField = new List<CS>();

                return this.realmCodeField;
            }
            set
            {
                this.realmCodeField = value;
            }
        }

        [XmlElement("typeId")]
        public InfrastructureRootTypeId TypeId
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.typeIdField == null)
                    this.typeIdField = new InfrastructureRootTypeId();

                return this.typeIdField;
            }
            set
            {
                this.typeIdField = value;
            }
        }

        [XmlElement("templateId")]
        public List<II> TemplateIds
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.templateIdField == null)
                    this.templateIdField = new List<II>();

                return this.templateIdField;
            }
            set
            {
                this.templateIdField = value;
            }
        }

        [XmlElement("languageCode")]
        public CS LanguageCode
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.languageCodeField == null)
                    this.languageCodeField = new CS();

                return this.languageCodeField;
            }
            set
            {
                this.languageCodeField = value;
            }
        }

        [XmlElement("modeCode")]
        public CE ModeCode
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.modeCodeField == null)
                    this.modeCodeField = new CE();

                return this.modeCodeField;
            }
            set
            {
                this.modeCodeField = value;
            }
        }

        [XmlElement("proficiencyLevelCode")]
        public CE ProficiencyLevelCode
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.proficiencyLevelCodeField == null)
                    this.proficiencyLevelCodeField = new CE();

                return this.proficiencyLevelCodeField;
            }
            set
            {
                this.proficiencyLevelCodeField = value;
            }
        }

        [XmlElement("preferenceInd")]
        public BL PreferenceInd
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.preferenceIndField == null)
                    this.preferenceIndField = new BL();

                return this.preferenceIndField;
            }
            set
            {
                this.preferenceIndField = value;
            }
        }

        [XmlAttribute("nullFlavor")]
        public string NullFlavor
        {
            get
            {
                return this.nullFlavorField;
            }
            set
            {
                this.nullFlavorField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName = ".Birthplace", Namespace = "urn:hl7-org:v3")]
    public partial class Birthplace
    {

        private List<CS> realmCodeField;

        private InfrastructureRootTypeId typeIdField;

        private List<II> templateIdField;

        private Place placeField;

        private string nullFlavorField;

        private string classCodeField;

        public Birthplace()
        {
            this.classCodeField = "BIRTHPL";
        }

        [XmlElement("realmCode")]
        public List<CS> RealmCodes
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.realmCodeField == null)
                    this.realmCodeField = new List<CS>();

                return this.realmCodeField;
            }
            set
            {
                this.realmCodeField = value;
            }
        }

        [XmlElement("typeId")]
        public InfrastructureRootTypeId TypeId
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.typeIdField == null)
                    this.typeIdField = new InfrastructureRootTypeId();

                return this.typeIdField;
            }
            set
            {
                this.typeIdField = value;
            }
        }

        [XmlElement("templateId")]
        public List<II> TemplateIds
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.templateIdField == null)
                    this.templateIdField = new List<II>();

                return this.templateIdField;
            }
            set
            {
                this.templateIdField = value;
            }
        }

        [XmlElement("place")]
        public Place Place
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.placeField == null)
                    this.placeField = new Place();

                return this.placeField;
            }
            set
            {
                this.placeField = value;
            }
        }

        [XmlAttribute("nullFlavor")]
        public string NullFlavor
        {
            get
            {
                return this.nullFlavorField;
            }
            set
            {
                this.nullFlavorField = value;
            }
        }

        [XmlAttribute("classCode")]
        public string ClassCode
        {
            get
            {
                return this.classCodeField;
            }
            set
            {
                this.classCodeField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName = ".Guardian", Namespace = "urn:hl7-org:v3")]
    public partial class Guardian
    {

        private List<CS> realmCodeField;

        private InfrastructureRootTypeId typeIdField;

        private List<II> templateIdField;

        private List<II> idField;

        private CE codeField;

        private List<AD> addrField;

        private List<TEL> telecomField;

        private object itemField;

        private string nullFlavorField;

        private string classCodeField;

        public Guardian()
        {
            this.classCodeField = "GUARD";
        }

        [XmlElement("realmCode")]
        public List<CS> RealmCodes
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.realmCodeField == null)
                    this.realmCodeField = new List<CS>();

                return this.realmCodeField;
            }
            set
            {
                this.realmCodeField = value;
            }
        }

        [XmlElement("typeId")]
        public InfrastructureRootTypeId TypeId
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.typeIdField == null)
                    this.typeIdField = new InfrastructureRootTypeId();

                return this.typeIdField;
            }
            set
            {
                this.typeIdField = value;
            }
        }

        [XmlElement("templateId")]
        public List<II> TemplateIds
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.templateIdField == null)
                    this.templateIdField = new List<II>();

                return this.templateIdField;
            }
            set
            {
                this.templateIdField = value;
            }
        }

        [XmlElement("id")]
        public List<II> Ids
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.idField == null)
                    this.idField = new List<II>();

                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        [XmlElement("code")]
        public CE Code
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.codeField == null)
                    this.codeField = new CE();

                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }

        [XmlElement("addr")]
        public List<AD> Addr
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.addrField == null)
                    this.addrField = new List<AD>();

                return this.addrField;
            }
            set
            {
                this.addrField = value;
            }
        }

        [XmlElement("telecom")]
        public List<TEL> Telecom
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.telecomField == null)
                    this.telecomField = new List<TEL>();

                return this.telecomField;
            }
            set
            {
                this.telecomField = value;
            }
        }

        [XmlElement("guardianOrganization", typeof(Organization))]
        [XmlElement("guardianPerson", typeof(Person))]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        [XmlAttribute("nullFlavor")]
        public string NullFlavor
        {
            get
            {
                return this.nullFlavorField;
            }
            set
            {
                this.nullFlavorField = value;
            }
        }

        [XmlAttribute("classCode")]
        public string ClassCode
        {
            get
            {
                return this.classCodeField;
            }
            set
            {
                this.classCodeField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName = ".Patient", Namespace = "urn:hl7-org:v3")]
    public partial class Patient
    {

        private List<CS> realmCodeField;

        private InfrastructureRootTypeId typeIdField;

        private List<II> templateIdField;

        private II idField;

        private List<PN> nameField;

        private CE administrativeGenderCodeField;

        private TS birthTimeField;

        private CE maritalStatusCodeField;

        private CE religiousAffiliationCodeField;

        private CE raceCodeField;

        private CE ethnicGroupCodeField;

        private Guardian[] guardianField;

        private Birthplace birthplaceField;

        private LanguageCommunication[] languageCommunicationField;

        private string nullFlavorField;

        private string classCodeField;

        private string determinerCodeField;

        public Patient()
        {
            this.classCodeField = "PSN";
            this.determinerCodeField = "INSTANCE";
        }

        [XmlElement("realmCode")]
        public List<CS> RealmCodes
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.realmCodeField == null)
                    this.realmCodeField = new List<CS>();

                return this.realmCodeField;
            }
            set
            {
                this.realmCodeField = value;
            }
        }

        [XmlElement("typeId")]
        public InfrastructureRootTypeId TypeId
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.typeIdField == null)
                    this.typeIdField = new InfrastructureRootTypeId();

                return this.typeIdField;
            }
            set
            {
                this.typeIdField = value;
            }
        }

        [XmlElement("templateId")]
        public List<II> TemplateIds
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.templateIdField == null)
                    this.templateIdField = new List<II>();

                return this.templateIdField;
            }
            set
            {
                this.templateIdField = value;
            }
        }

        [XmlElement("id")]
        public II Id
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.idField == null)
                    this.idField = new II();

                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        [XmlElement("name")]
        public List<PN> Name
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.nameField == null)
                    this.nameField = new List<PN>();

                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        [XmlElement("administrativeGenderCode")]
        public CE AdministrativeGenderCode
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.administrativeGenderCodeField == null)
                    this.administrativeGenderCodeField = new CE();

                return this.administrativeGenderCodeField;
            }
            set
            {
                this.administrativeGenderCodeField = value;
            }
        }

        [XmlElement("birthTime")]
        public TS BirthTime
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.birthTimeField == null)
                    this.birthTimeField = new TS();

                return this.birthTimeField;
            }
            set
            {
                this.birthTimeField = value;
            }
        }

        [XmlElement("maritalStatusCode")]
        public CE MaritalStatusCode
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.maritalStatusCodeField == null)
                    this.maritalStatusCodeField = new CE();

                return this.maritalStatusCodeField;
            }
            set
            {
                this.maritalStatusCodeField = value;
            }
        }

        [XmlElement("religiousAffiliationCode")]
        public CE ReligiousAffiliationCode
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.religiousAffiliationCodeField == null)
                    this.religiousAffiliationCodeField = new CE();

                return this.religiousAffiliationCodeField;
            }
            set
            {
                this.religiousAffiliationCodeField = value;
            }
        }

        [XmlElement("raceCode")]
        public CE RaceCode
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.raceCodeField == null)
                    this.raceCodeField = new CE();

                return this.raceCodeField;
            }
            set
            {
                this.raceCodeField = value;
            }
        }

        [XmlElement("ethnicGroupCode")]
        public CE EthnicGroupCode
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.ethnicGroupCodeField == null)
                    this.ethnicGroupCodeField = new CE();

                return this.ethnicGroupCodeField;
            }
            set
            {
                this.ethnicGroupCodeField = value;
            }
        }

        [XmlElement("guardian")]
        public Guardian[] Guardians
        {
            get
            {
                return this.guardianField;
            }
            set
            {
                this.guardianField = value;
            }
        }

        [XmlElement("birthplace")]
        public Birthplace Birthplace
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.birthplaceField == null)
                    this.birthplaceField = new Birthplace();

                return this.birthplaceField;
            }
            set
            {
                this.birthplaceField = value;
            }
        }

        [XmlElement("languageCommunication")]
        public LanguageCommunication[] LanguageCommunication
        {
            get
            {
                return this.languageCommunicationField;
            }
            set
            {
                this.languageCommunicationField = value;
            }
        }

        [XmlAttribute("nullFlavor")]
        public string NullFlavor
        {
            get
            {
                return this.nullFlavorField;
            }
            set
            {
                this.nullFlavorField = value;
            }
        }

        [XmlAttribute("classCode")]
        public string ClassCode
        {
            get
            {
                return this.classCodeField;
            }
            set
            {
                this.classCodeField = value;
            }
        }

        [XmlAttribute("determinerCode")]
        public string DeterminerCode
        {
            get
            {
                return this.determinerCodeField;
            }
            set
            {
                this.determinerCodeField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName = ".PatientRole", Namespace = "urn:hl7-org:v3")]
    public partial class PatientRole
    {

        private List<CS> realmCodeField;

        private InfrastructureRootTypeId typeIdField;

        private List<II> templateIdField;

        private List<II> idField;

        private List<AD> addrField;

        private List<TEL> telecomField;

        private Patient patientField;

        private Organization providerOrganizationField;

        private string nullFlavorField;

        private string classCodeField;

        public PatientRole()
        {
            this.classCodeField = "PAT";
        }

        [XmlElement("realmCode")]
        public List<CS> RealmCodes
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.realmCodeField == null)
                    this.realmCodeField = new List<CS>();

                return this.realmCodeField;
            }
            set
            {
                this.realmCodeField = value;
            }
        }

        [XmlElement("typeId")]
        public InfrastructureRootTypeId TypeId
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.typeIdField == null)
                    this.typeIdField = new InfrastructureRootTypeId();

                return this.typeIdField;
            }
            set
            {
                this.typeIdField = value;
            }
        }

        [XmlElement("templateId")]
        public List<II> TemplateIds
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.templateIdField == null)
                    this.templateIdField = new List<II>();

                return this.templateIdField;
            }
            set
            {
                this.templateIdField = value;
            }
        }

        [XmlElement("id")]
        public List<II> Ids
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.idField == null)
                    this.idField = new List<II>();

                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        [XmlElement("addr")]
        public List<AD> Addresses
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.addrField == null)
                    this.addrField = new List<AD>();

                return this.addrField;
            }
            set
            {
                this.addrField = value;
            }
        }

        [XmlElement("telecom")]
        public List<TEL> Telephones
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.telecomField == null)
                    this.telecomField = new List<TEL>();

                return this.telecomField;
            }
            set
            {
                this.telecomField = value;
            }
        }

        [XmlElement("patient")]
        public Patient Patient
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.patientField == null)
                    this.patientField = new Patient();

                return this.patientField;
            }
            set
            {
                this.patientField = value;
            }
        }

        [XmlElement("providerOrganization")]
        public Organization ProviderOrganization
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.providerOrganizationField == null)
                    this.providerOrganizationField = new Organization();

                return this.providerOrganizationField;
            }
            set
            {
                this.providerOrganizationField = value;
            }
        }

        [XmlAttribute("nullFlavor")]
        public string NullFlavor
        {
            get
            {
                return this.nullFlavorField;
            }
            set
            {
                this.nullFlavorField = value;
            }
        }

        [XmlAttribute("classCode")]
        public string ClassCode
        {
            get
            {
                return this.classCodeField;
            }
            set
            {
                this.classCodeField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName = ".RecordTarget", Namespace = "urn:hl7-org:v3")]
    public partial class RecordTarget
    {

        private List<CS> realmCodeField;

        private InfrastructureRootTypeId typeIdField;

        private List<II> templateIdField;

        private PatientRole patientRoleField;

        private string nullFlavorField;

        private string typeCodeField;

        private string contextControlCodeField;

        public RecordTarget()
        {
            this.typeCodeField = "RCT";
            this.contextControlCodeField = "OP";
        }

        [XmlElement("realmCode")]
        public List<CS> RealmCodes
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.realmCodeField == null)
                    this.realmCodeField = new List<CS>();

                return this.realmCodeField;
            }
            set
            {
                this.realmCodeField = value;
            }
        }

        [XmlElement("typeId")]
        public InfrastructureRootTypeId TypeId
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.typeIdField == null)
                    this.typeIdField = new InfrastructureRootTypeId();

                return this.typeIdField;
            }
            set
            {
                this.typeIdField = value;
            }
        }

        [XmlElement("templateId")]
        public List<II> TemplateIds
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.templateIdField == null)
                    this.templateIdField = new List<II>();

                return this.templateIdField;
            }
            set
            {
                this.templateIdField = value;
            }
        }

        [XmlElement("patientRole")]
        public PatientRole PatientRole
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.patientRoleField == null)
                    this.patientRoleField = new PatientRole();

                return this.patientRoleField;
            }
            set
            {
                this.patientRoleField = value;
            }
        }

        [XmlAttribute("nullFlavor")]
        public string NullFlavor
        {
            get
            {
                return this.nullFlavorField;
            }
            set
            {
                this.nullFlavorField = value;
            }
        }

        [XmlAttribute("typeCode")]
        public string TypeCode
        {
            get
            {
                return this.typeCodeField;
            }
            set
            {
                this.typeCodeField = value;
            }
        }

        [XmlAttribute("contextControlCode")]
        public string ContextControlCode
        {
            get
            {
                return this.contextControlCodeField;
            }
            set
            {
                this.contextControlCodeField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn:hl7-org:v3")]
    public partial class GLIST_PQ : ANY
    {

        private PQ headField;

        private PQ incrementField;

        private string periodField;

        private string denominatorField;

        [XmlElement("head")]
        public PQ Head
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.headField == null)
                    this.headField = new PQ();

                return this.headField;
            }
            set
            {
                this.headField = value;
            }
        }

        [XmlElement("increment")]
        public PQ Increment
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.incrementField == null)
                    this.incrementField = new PQ();

                return this.incrementField;
            }
            set
            {
                this.incrementField = value;
            }
        }

        [XmlAttribute(AttributeName = "period", DataType = "integer")]
        public string Period
        {
            get
            {
                return this.periodField;
            }
            set
            {
                this.periodField = value;
            }
        }

        [XmlAttribute(AttributeName = "denominator", DataType = "integer")]
        public string Denominator
        {
            get
            {
                return this.denominatorField;
            }
            set
            {
                this.denominatorField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn:hl7-org:v3")]
    public partial class GLIST_TS : ANY
    {

        private TS headField;

        private PQ incrementField;

        private string periodField;

        private string denominatorField;

        [XmlElement("head")]
        public TS Head
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.headField == null)
                    this.headField = new TS();

                return this.headField;
            }
            set
            {
                this.headField = value;
            }
        }

        [XmlElement("increment")]
        public PQ Increment
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.incrementField == null)
                    this.incrementField = new PQ();

                return this.incrementField;
            }
            set
            {
                this.incrementField = value;
            }
        }

        [XmlAttribute(AttributeName = "period", DataType = "integer")]
        public string Period
        {
            get
            {
                return this.periodField;
            }
            set
            {
                this.periodField = value;
            }
        }

        [XmlAttribute(AttributeName = "denominator", DataType = "integer")]
        public string Denominator
        {
            get
            {
                return this.denominatorField;
            }
            set
            {
                this.denominatorField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn:hl7-org:v3")]
    public partial class SLIST_TS : ANY
    {

        private TS originField;

        private PQ scaleField;

        private string digitsField;

        [XmlElement("origin")]
        public TS Origin
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.originField == null)
                    this.originField = new TS();

                return this.originField;
            }
            set
            {
                this.originField = value;
            }
        }

        [XmlElement("scale")]
        public PQ Scale
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.scaleField == null)
                    this.scaleField = new PQ();

                return this.scaleField;
            }
            set
            {
                this.scaleField = value;
            }
        }

        [XmlElement("digits")]
        public string Digits
        {
            get
            {
                return this.digitsField;
            }
            set
            {
                this.digitsField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn:hl7-org:v3")]
    public partial class SLIST_PQ : ANY
    {

        private PQ originField;

        private PQ scaleField;

        private string digitsField;

        [XmlElement("origin")]
        public PQ Origin
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.originField == null)
                    this.originField = new PQ();

                return this.originField;
            }
            set
            {
                this.originField = value;
            }
        }

        [XmlElement("scale")]
        public PQ Scale
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.scaleField == null)
                    this.scaleField = new PQ();

                return this.scaleField;
            }
            set
            {
                this.scaleField = value;
            }
        }

        [XmlElement("digits")]
        public string Digits
        {
            get
            {
                return this.digitsField;
            }
            set
            {
                this.digitsField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn:hl7-org:v3")]
    public partial class CR : ANY
    {

        private CV nameField;

        private CD valueField;

        private bool invertedField;

        public CR()
        {
            this.invertedField = false;
        }

        [XmlElement("name")]
        public CV Name
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.nameField == null)
                    this.nameField = new CV();

                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        [XmlElement("value")]
        public CD Value
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.valueField == null)
                    this.valueField = new CD();

                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }

        [XmlAttribute("inverted")]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool Inverted
        {
            get
            {
                return this.invertedField;
            }
            set
            {
                this.invertedField = value;
            }
        }
    }

    [XmlIncludeAttribute(typeof(TEL))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn:hl7-org:v3")]
    public abstract partial class URL : ANY
    {

        private string valueField;

        [XmlAttribute(AttributeName = "value", DataType = "anyURI")]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    [XmlIncludeAttribute(typeof(ED))]
    [XmlIncludeAttribute(typeof(ST))]
    [XmlIncludeAttribute(typeof(ENXP))]
    [XmlIncludeAttribute(typeof(ensuffix))]
    [XmlIncludeAttribute(typeof(enprefix))]
    [XmlIncludeAttribute(typeof(engiven))]
    [XmlIncludeAttribute(typeof(enfamily))]
    [XmlIncludeAttribute(typeof(endelimiter))]
    [XmlIncludeAttribute(typeof(ADXP))]
    [XmlIncludeAttribute(typeof(adxpprecinct))]
    [XmlIncludeAttribute(typeof(adxppostBox))]
    [XmlIncludeAttribute(typeof(adxpbuildingNumberSuffix))]
    [XmlIncludeAttribute(typeof(adxpdeliveryModeIdentifier))]
    [XmlIncludeAttribute(typeof(adxpdeliveryMode))]
    [XmlIncludeAttribute(typeof(adxpdeliveryInstallationQualifier))]
    [XmlIncludeAttribute(typeof(adxpdeliveryInstallationArea))]
    [XmlIncludeAttribute(typeof(adxpdeliveryInstallationType))]
    [XmlIncludeAttribute(typeof(adxpdeliveryAddressLine))]
    [XmlIncludeAttribute(typeof(adxpcensusTract))]
    [XmlIncludeAttribute(typeof(adxpcareOf))]
    [XmlIncludeAttribute(typeof(adxpunitType))]
    [XmlIncludeAttribute(typeof(adxpunitID))]
    [XmlIncludeAttribute(typeof(adxpadditionalLocator))]
    [XmlIncludeAttribute(typeof(adxpstreetNameType))]
    [XmlIncludeAttribute(typeof(adxpstreetNameBase))]
    [XmlIncludeAttribute(typeof(adxpstreetName))]
    [XmlIncludeAttribute(typeof(adxpdirection))]
    [XmlIncludeAttribute(typeof(adxphouseNumberNumeric))]
    [XmlIncludeAttribute(typeof(adxphouseNumber))]
    [XmlIncludeAttribute(typeof(adxpstreetAddressLine))]
    [XmlIncludeAttribute(typeof(adxppostalCode))]
    [XmlIncludeAttribute(typeof(adxpcity))]
    [XmlIncludeAttribute(typeof(adxpcounty))]
    [XmlIncludeAttribute(typeof(adxpstate))]
    [XmlIncludeAttribute(typeof(adxpcountry))]
    [XmlIncludeAttribute(typeof(adxpdelimiter))]
    [XmlIncludeAttribute(typeof(SC))]
    [XmlIncludeAttribute(typeof(thumbnail))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn:hl7-org:v3")]
    public abstract partial class BIN : ANY
    {

        private BinaryDataEncodings representationField;

        private string[] textField;

        public BIN()
        {
            this.representationField = BinaryDataEncodings.TXT;
        }

        [XmlAttribute("representation")]
        [System.ComponentModel.DefaultValueAttribute(BinaryDataEncodings.TXT)]
        public BinaryDataEncodings Representation
        {
            get
            {
                return this.representationField;
            }
            set
            {
                this.representationField = value;
            }
        }

        [XmlTextAttribute()]
        public string[] Text
        {
            get
            {
                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }
    }

    [XmlIncludeAttribute(typeof(BN))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn:hl7-org:v3")]
    public partial class ANYNonNull : ANY
    {
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn:hl7-org:v3")]
    public partial class BN : ANYNonNull
    {

        private bool valueField;

        private bool valueFieldSpecified;

        [XmlAttribute("value")]
        public bool Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }

        [XmlIgnore()]
        public bool ValueSpecified
        {
            get
            {
                return this.valueFieldSpecified;
            }
            set
            {
                this.valueFieldSpecified = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn:hl7-org:v3")]
    public partial class RTO_MO_PQ : QTY
    {

        private MO numeratorField;

        private PQ denominatorField;

        [XmlElement("numerator")]
        public MO Numerator
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.numeratorField == null)
                    this.numeratorField = new MO();

                return this.numeratorField;
            }
            set
            {
                this.numeratorField = value;
            }
        }

        [XmlElement("denominator")]
        public PQ Denominator
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.denominatorField == null)
                    this.denominatorField = new PQ();

                return this.denominatorField;
            }
            set
            {
                this.denominatorField = value;
            }
        }
    }

    [XmlIncludeAttribute(typeof(IVXB_MO))]
    [XmlIncludeAttribute(typeof(SXCM_MO))]
    [XmlIncludeAttribute(typeof(IVL_MO))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn:hl7-org:v3")]
    public partial class MO : QTY
    {

        private string valueField;

        private string currencyField;

        [XmlAttribute("value")]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }

        [XmlAttribute(AttributeName = "currency", DataType = "token")]
        public string Currency
        {
            get
            {
                return this.currencyField;
            }
            set
            {
                this.currencyField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn:hl7-org:v3")]
    public partial class IVXB_MO : MO
    {

        private bool inclusiveField;

        public IVXB_MO()
        {
            this.inclusiveField = true;
        }

        [XmlAttribute("inclusive")]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool Inclusive
        {
            get
            {
                return this.inclusiveField;
            }
            set
            {
                this.inclusiveField = value;
            }
        }
    }

    [XmlIncludeAttribute(typeof(IVL_MO))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn:hl7-org:v3")]
    public partial class SXCM_MO : MO
    {

        private Operators operatorField;

        public SXCM_MO()
        {
            this.operatorField = Operators.I;
        }

        [XmlAttribute("operator")]
        [System.ComponentModel.DefaultValueAttribute(Operators.I)]
        public Operators Operator
        {
            get
            {
                return this.operatorField;
            }
            set
            {
                this.operatorField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn:hl7-org:v3")]
    public partial class IVL_MO : SXCM_MO
    {

        private MO[] itemsField;

        private ItemsChoiceType[] itemsElementNameField;

        [XmlElement("center", typeof(MO))]
        [XmlElement("high", typeof(IVXB_MO))]
        [XmlElement("low", typeof(IVXB_MO))]
        [XmlElement("width", typeof(MO))]
        [XmlChoiceIdentifierAttribute("ItemsElementName")]
        public MO[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        [XmlElement("ItemsElementName")]
        [XmlIgnore()]
        public ItemsChoiceType[] ItemsElementName
        {
            get
            {
                return this.itemsElementNameField;
            }
            set
            {
                this.itemsElementNameField = value;
            }
        }
    }

    [XmlIncludeAttribute(typeof(RTO))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn:hl7-org:v3")]
    public partial class RTO_QTY_QTY : QTY
    {

        private QTY numeratorField;

        private QTY denominatorField;

        [XmlElement("numerator")]
        public QTY Numerator
        {
            get
            {
                return this.numeratorField;
            }
            set
            {
                this.numeratorField = value;
            }
        }

        [XmlElement("denominator")]
        public QTY Denominator
        {
            get
            {
                return this.denominatorField;
            }
            set
            {
                this.denominatorField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn:hl7-org:v3")]
    public partial class RTO : RTO_QTY_QTY
    {
    }

    [XmlIncludeAttribute(typeof(IVXB_REAL))]
    [XmlIncludeAttribute(typeof(SXCM_REAL))]
    [XmlIncludeAttribute(typeof(IVL_REAL))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn:hl7-org:v3")]
    public partial class REAL : QTY
    {

        private string valueField;

        [XmlAttribute("value")]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn:hl7-org:v3")]
    public partial class IVXB_REAL : REAL
    {

        private bool inclusiveField;

        public IVXB_REAL()
        {
            this.inclusiveField = true;
        }

        [XmlAttribute("inclusive")]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool Inclusive
        {
            get
            {
                return this.inclusiveField;
            }
            set
            {
                this.inclusiveField = value;
            }
        }
    }

    [XmlIncludeAttribute(typeof(IVL_REAL))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn:hl7-org:v3")]
    public partial class SXCM_REAL : REAL
    {

        private Operators operatorField;

        public SXCM_REAL()
        {
            this.operatorField = Operators.I;
        }

        [XmlAttribute("operator")]
        [System.ComponentModel.DefaultValueAttribute(Operators.I)]
        public Operators Operator
        {
            get
            {
                return this.operatorField;
            }
            set
            {
                this.operatorField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn:hl7-org:v3")]
    public partial class IVL_REAL : SXCM_REAL
    {

        private REAL[] itemsField;

        private ItemsChoiceType[] itemsElementNameField;

        [XmlElement("center", typeof(REAL))]
        [XmlElement("high", typeof(IVXB_REAL))]
        [XmlElement("low", typeof(IVXB_REAL))]
        [XmlElement("width", typeof(REAL))]
        [XmlChoiceIdentifierAttribute("ItemsElementName")]
        public REAL[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        [XmlElement("ItemsElementName")]
        [XmlIgnore()]
        public ItemsChoiceType[] ItemsElementName
        {
            get
            {
                return this.itemsElementNameField;
            }
            set
            {
                this.itemsElementNameField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn:hl7-org:v3")]
    public partial class UVP_TS : TS
    {

        private double probabilityField;

        private bool probabilityFieldSpecified;

        [XmlAttribute("probability")]
        public double Probability
        {
            get
            {
                return this.probabilityField;
            }
            set
            {
                this.probabilityField = value;
            }
        }

        [XmlIgnore()]
        public bool ProbabilitySpecified
        {
            get
            {
                return this.probabilityFieldSpecified;
            }
            set
            {
                this.probabilityFieldSpecified = value;
            }
        }
    }

    [XmlIncludeAttribute(typeof(IVXB_PPD_TS))]
    [XmlIncludeAttribute(typeof(SXCM_PPD_TS))]
    [XmlIncludeAttribute(typeof(EIVL_PPD_TS))]
    [XmlIncludeAttribute(typeof(IVL_PPD_TS))]
    [XmlIncludeAttribute(typeof(PIVL_PPD_TS))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn:hl7-org:v3")]
    public partial class PPD_TS : TS
    {

        private PQ standardDeviationField;

        private DistributionTypes distributionTypeField;

        private bool distributionTypeFieldSpecified;

        [XmlElement("standardDeviation")]
        public PQ StandardDeviation
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.standardDeviationField == null)
                    this.standardDeviationField = new PQ();

                return this.standardDeviationField;
            }
            set
            {
                this.standardDeviationField = value;
            }
        }

        [XmlAttribute("distributionType")]
        public DistributionTypes DistributionType
        {
            get
            {
                return this.distributionTypeField;
            }
            set
            {
                this.distributionTypeField = value;
            }
        }

        [XmlIgnore()]
        public bool DistributionTypeSpecified
        {
            get
            {
                return this.distributionTypeFieldSpecified;
            }
            set
            {
                this.distributionTypeFieldSpecified = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn:hl7-org:v3")]
    public partial class IVXB_PPD_TS : PPD_TS
    {

        private bool inclusiveField;

        public IVXB_PPD_TS()
        {
            this.inclusiveField = true;
        }

        [XmlAttribute("inclusive")]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool Inclusive
        {
            get
            {
                return this.inclusiveField;
            }
            set
            {
                this.inclusiveField = value;
            }
        }
    }

    [XmlIncludeAttribute(typeof(EIVL_PPD_TS))]
    [XmlIncludeAttribute(typeof(IVL_PPD_TS))]
    [XmlIncludeAttribute(typeof(PIVL_PPD_TS))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn:hl7-org:v3")]
    public partial class SXCM_PPD_TS : PPD_TS
    {

        private Operators operatorField;

        public SXCM_PPD_TS()
        {
            this.operatorField = Operators.I;
        }

        [XmlAttribute("operator")]
        [System.ComponentModel.DefaultValueAttribute(Operators.I)]
        public Operators Operator
        {
            get
            {
                return this.operatorField;
            }
            set
            {
                this.operatorField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn:hl7-org:v3")]
    public partial class EIVL_PPD_TS : SXCM_PPD_TS
    {

        private EIVLevent eventField;

        private IVL_PPD_PQ offsetField;

        [XmlElement("event")]
        public EIVLevent Event
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.eventField == null)
                    this.eventField = new EIVLevent();

                return this.eventField;
            }
            set
            {
                this.eventField = value;
            }
        }

        [XmlElement("offset")]
        public IVL_PPD_PQ Offset
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.offsetField == null)
                    this.offsetField = new IVL_PPD_PQ();

                return this.offsetField;
            }
            set
            {
                this.offsetField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName = "EIVL.event", Namespace = "urn:hl7-org:v3")]
    public partial class EIVLevent : CE
    {
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn:hl7-org:v3")]
    public partial class IVL_PPD_TS : SXCM_PPD_TS
    {

        private QTY[] itemsField;

        private ItemsChoiceType[] itemsElementNameField;

        [XmlElement("center", typeof(PPD_TS))]
        [XmlElement("high", typeof(IVXB_PPD_TS))]
        [XmlElement("low", typeof(IVXB_PPD_TS))]
        [XmlElement("width", typeof(PPD_PQ))]
        [XmlChoiceIdentifierAttribute("ItemsElementName")]
        public QTY[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        [XmlElement("ItemsElementName")]
        [XmlIgnore()]
        public ItemsChoiceType[] ItemsElementName
        {
            get
            {
                return this.itemsElementNameField;
            }
            set
            {
                this.itemsElementNameField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn:hl7-org:v3")]
    public partial class PIVL_PPD_TS : SXCM_PPD_TS
    {

        private IVL_PPD_TS phaseField;

        private PPD_PQ periodField;

        private string alignmentField;

        private bool institutionSpecified1Field;

        public PIVL_PPD_TS()
        {
            this.institutionSpecified1Field = false;
        }

        [XmlElement("phase")]
        public IVL_PPD_TS Phase
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.phaseField == null)
                    this.phaseField = new IVL_PPD_TS();

                return this.phaseField;
            }
            set
            {
                this.phaseField = value;
            }
        }

        [XmlElement("period")]
        public PPD_PQ Period
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.periodField == null)
                    this.periodField = new PPD_PQ();

                return this.periodField;
            }
            set
            {
                this.periodField = value;
            }
        }

        [XmlAttribute("alignment")]
        public string Alignment
        {
            get
            {
                return this.alignmentField;
            }
            set
            {
                this.alignmentField = value;
            }
        }

        [XmlAttribute("institutionSpecified")]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool InstitutionSpecified
        {
            get
            {
                return this.institutionSpecified1Field;
            }
            set
            {
                this.institutionSpecified1Field = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn:hl7-org:v3")]
    public partial class SXPR_TS : SXCM_TS
    {

        private List<SXCM_TS> compField;

        [XmlElement("comp")]
        public List<SXCM_TS> Comps
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.compField == null)
                    this.compField = new List<SXCM_TS>();

                return this.compField;
            }
            set
            {
                this.compField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn:hl7-org:v3")]
    public partial class EIVL_TS : SXCM_TS
    {

        private EIVLevent eventField;

        private IVL_PQ offsetField;

        [XmlElement("event")]
        public EIVLevent Event
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.eventField == null)
                    this.eventField = new EIVLevent();

                return this.eventField;
            }
            set
            {
                this.eventField = value;
            }
        }

        [XmlElement("offset")]
        public IVL_PQ Offset
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.offsetField == null)
                    this.offsetField = new IVL_PQ();

                return this.offsetField;
            }
            set
            {
                this.offsetField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn:hl7-org:v3")]
    public partial class PIVL_TS : SXCM_TS
    {

        private IVL_TS phaseField;

        private PQ periodField;

        private string alignmentField;

        private bool institutionSpecified1Field;

        public PIVL_TS()
        {
            this.institutionSpecified1Field = false;
        }

        [XmlElement("phase")]
        public IVL_TS Phase
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.phaseField == null)
                    this.phaseField = new IVL_TS();

                return this.phaseField;
            }
            set
            {
                this.phaseField = value;
            }
        }

        [XmlElement("period")]
        public PQ Period
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.periodField == null)
                    this.periodField = new PQ();

                return this.periodField;
            }
            set
            {
                this.periodField = value;
            }
        }

        [XmlAttribute("alignment")]
        public string Alignment
        {
            get
            {
                return this.alignmentField;
            }
            set
            {
                this.alignmentField = value;
            }
        }

        [XmlAttribute("institutionSpecified")]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool InstitutionSpecified
        {
            get
            {
                return this.institutionSpecified1Field;
            }
            set
            {
                this.institutionSpecified1Field = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn:hl7-org:v3")]
    public partial class thumbnail : ED
    {
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn:hl7-org:v3")]
    public partial class BXIT_CD : CD
    {

        private string qtyField;

        public BXIT_CD()
        {
            this.qtyField = "1";
        }

        [XmlAttribute("qty", DataType = "integer")]
        [System.ComponentModel.DefaultValueAttribute("1")]
        public string Quantity
        {
            get
            {
                return this.qtyField;
            }
            set
            {
                this.qtyField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn:hl7-org:v3")]
    public partial class SXCM_CD : CD
    {

        private Operators operatorField;

        public SXCM_CD()
        {
            this.operatorField = Operators.I;
        }

        [XmlAttribute("operator")]
        [System.ComponentModel.DefaultValueAttribute(Operators.I)]
        public Operators Operator
        {
            get
            {
                return this.operatorField;
            }
            set
            {
                this.operatorField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn:hl7-org:v3")]
    public partial class HXIT_CE : CE
    {

        private IVL_TS validTimeField;

        [XmlElement("validTime")]
        public IVL_TS ValidTime
        {
            get
            {
                if (ClinicalDocumentDesigner.IsDesigning && this.validTimeField == null)
                    this.validTimeField = new IVL_TS();

                return this.validTimeField;
            }
            set
            {
                this.validTimeField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn:hl7-org:v3")]
    public partial class CO : CV
    {
    }

}
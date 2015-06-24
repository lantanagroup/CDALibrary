using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace CDALibrary.Core.Model
{
    public enum RegionOfInterestCodes
    {
        CIRCLE,
        ELLIPSE,
        POINT,
        POLY
    }

    public enum AllMoodCodes
    {
        INT,
        APT,
        ARQ,
        DEF,
        EVN,
        PRMS,
        PRP,
        RQO,
        GOL
    }

    /// <summary>
    /// Valueset ActClassObservation
    /// </summary>
    public enum ActClassObservationClassCodes
    {
        OBS,
        ROIBND,
        ROIOVL,
        LLD,
        PRN,
        RLD,
        SFWL,
        SIT,
        STN,
        SUP,
        RTRD,
        TRD,
        ALRT,
        BATTERY,
        CLNTRL,
        CNOD,
        CONC,
        COND,
        CASE,
        OUTB,
        DGIMG,
        GEN,
        DETPOL,
        EXP,
        LOC,
        PHN,
        POL,
        SEQ,
        SEQVAR,
        INVSTG,
        OBSSER,
        OBSCOR,
        POS,
        POSACC,
        POSCOORD,
        SPCOBS,
        VERIF
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(Namespace = "urn:hl7-org:v3")]
    public enum ProcedureMoodCodes
    {
        INT,
        APT,
        ARQ,
        DEF,
        EVN,
        PRMS,
        PRP,
        RQO,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(Namespace = "urn:hl7-org:v3")]
    public enum SubstanceMoodCodes
    {
        INT,
        EVN,
        PRMS,
        PRP,
        RQO,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(Namespace = "urn:hl7-org:v3")]
    public enum ActMoodCodes
    {
        INT,
        APT,
        ARQ,
        DEF,
        EVN,
        PRMS,
        PRP,
        RQO,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(Namespace = "urn:hl7-org:v3")]
    public enum EncounterMoodCodes
    {
        INT,
        APT,
        ARQ,
        EVN,
        PRMS,
        PRP,
        RQO,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(Namespace = "urn:hl7-org:v3")]
    public enum ObservationMoodCodes
    {
        INT,
        DEF,
        EVN,
        GOL,
        PRMS,
        PRP,
        RQO,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(Namespace = "urn:hl7-org:v3")]
    public enum SupplyClassCodes
    {
        SPLY,
        DIET,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(Namespace = "urn:hl7-org:v3")]
    public enum ComponentTypeCodes
    {
        COMP,
        ARR,
        CTRLV,
        DEP,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(Namespace = "urn:hl7-org:v3")]
    public enum OrganizerClassCodes
    {
        BATTERY,
        CLUSTER,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(Namespace = "urn:hl7-org:v3")]
    public enum EntryRelationshipTypeCodes
    {
        XCRPT,
        COMP,
        RSON,
        SPRT,
        CAUS,
        GEVL,
        MFST,
        REFR,
        SAS,
        SUBJ,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(Namespace = "urn:hl7-org:v3")]
    public enum ActClassCodes
    {
        ACT,
        ACCM,
        CONS,
        CTTEVENT,
        INC,
        INFRM,
        PCPR,
        REG,
        SPCTRT,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(Namespace = "urn:hl7-org:v3")]
    public enum EntryTypeCodes
    {
        COMP,
        DRIV,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(Namespace = "urn:hl7-org:v3")]
    public enum EncounterParticipantTypeCodes
    {
        ADM,
        ATND,
        CON,
        DIS,
        REF,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(Namespace = "urn:hl7-org:v3")]
    public enum RelatedDocumentTypeCodes
    {
        RPLC,
        APND,
        XFRM,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(Namespace = "urn:hl7-org:v3")]
    public enum Performer1TypeCodes
    {
        PRF,
        PPRF,
        SPRF,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(Namespace = "urn:hl7-org:v3")]
    public enum IntendedRecipientClassCodes
    {
        ASSIGNED,
        HLTHCHRT,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(Namespace = "urn:hl7-org:v3")]
    public enum InformationRecipientTypeCodes
    {
        PRCP,
        TRC,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(Namespace = "urn:hl7-org:v3")]
    public enum RelatedSubjectClassCodes
    {
        PAT,
        PRS,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(Namespace = "urn:hl7-org:v3")]
    public enum SubjectTypeCodes
    {
        SBJ,
        SPC,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(Namespace = "urn:hl7-org:v3")]
    public enum ReferenceTypeCodes
    {
        XCRPT,
        RPLC,
        SPRT,
        ELNK,
        REFR,
        SUBJ,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(Namespace = "urn:hl7-org:v3")]
    public enum Operators
    {
        A,
        E,
        H,
        I,
        P,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(Namespace = "urn:hl7-org:v3")]
    public enum DistributionTypes
    {
        B,
        E,
        F,
        G,
        LN,
        N,
        T,
        U,
        X2,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(Namespace = "urn:hl7-org:v3", IncludeInSchema = false)]
    public enum ItemsChoiceType
    {
        center,
        high,
        low,
        width,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(Namespace = "urn:hl7-org:v3")]
    public enum DeviceClassCodes
    {
        DEV,
        CER,
        MODDV,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(Namespace = "urn:hl7-org:v3")]
    public enum SpecimenRoleClassCodes
    {
        SPEC,
        ALQT,
        ISLT,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(Namespace = "urn:hl7-org:v3")]
    public enum Performer2TypeCodes
    {
        PRF,
        DIST,
        PPRF,
        SPRF,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(Namespace = "urn:hl7-org:v3")]
    public enum DeterminerCodes
    {
        KIND,
        QUANTIFIED_KIND,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(Namespace = "urn:hl7-org:v3")]
    public enum ManufacturedProductClassCodes
    {
        MANU,
        THER,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(Namespace = "urn:hl7-org:v3")]
    public enum PlaceClassCodes
    {
        PLC,
        CITY,
        COUNTRY,
        COUNTY,
        PROVINCE,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(Namespace = "urn:hl7-org:v3")]
    public enum HealthCareFacilityClassCodes
    {
        SDLOC,
        DSDLOC,
        ISDLOC,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(Namespace = "urn:hl7-org:v3")]
    public enum LocationTypeCodes
    {
        LOC,
        DST,
        ELOC,
        ORG,
        RML,
        VIA,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(Namespace = "urn:hl7-org:v3")]
    public enum ParentDocumentClassCodes
    {
        DOCCLIN,
        CDALVLONE,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(Namespace = "urn:hl7-org:v3")]
    public enum InFulfillmentOfTypeCodes
    {
        FLFS,
        OCCR,
        OREF,
        SCH,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(Namespace = "urn:hl7-org:v3")]
    public enum BinaryDataEncodings
    {
        B64,
        TXT,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(Namespace = "urn:hl7-org:v3")]
    public enum CompressionAlgorithms
    {
        DF,
        GZ,
        Z,
        ZL,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(Namespace = "urn:hl7-org:v3")]
    public enum IntegrityCheckAlgorithms
    {
        [XmlEnumAttribute("SHA-1")]
        SHA1,
        [XmlEnumAttribute("SHA-256")]
        SHA256,
    }
}

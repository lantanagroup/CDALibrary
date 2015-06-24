using System;
using System.IO;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;


using Lantana.CDA.Model;

namespace Lantana.CDA.Logic
{
    public static class ClinicalDocumentFactory
    {
        public const string DefaultRealmCode = "en-US";
        public const string TypeIdRoot = "2.16.840.1.113883.1.3";
        public const string TypeIdExtension = "POCD_HD000040";
        public const string DefaultDateFormat = "yyyyMMddhhmmss";

        private static string[] DateFormats = new string[] 
        {
            DefaultDateFormat,
            "yyyyMMddhhmm",
            "yyyyMMdd",
            "yyyy"
        };

        public static ClinicalDocument CreateDocument(string id, string title, CE code, ConfidentialityCodes confidentiality, Author author, Custodian custodian, RecordTarget recordTarget)
        {
            using (new ClinicalDocumentDesigner())
            {
                ClinicalDocument cda = new ClinicalDocument()
                {
                    Id = new II(id),
                    Code = code,
                    Confidentiality = confidentiality,
                    Title = new ST(title),
                    TypeId = new InfrastructureRootTypeId(TypeIdRoot, TypeIdExtension),
                    EffectiveTime = new TS(GetDateNow()),
                    Custodian = custodian,
                };

                cda.RealmCodes.Add(new CS(DefaultRealmCode));
                cda.Authors.Add(author);
                cda.RecordTargets.Add(recordTarget);

                return cda;
            }
        }

        public static string GetDate(DateTime date)
        {
            return date.ToString(DefaultDateFormat);
        }

        public static DateTime GetDate(string date)
        {
            return DateTime.ParseExact(date, DateFormats, CultureInfo.InvariantCulture, DateTimeStyles.None);
        }

        public static string GetDateNow()
        {
            return DateTime.Now.ToString(DefaultDateFormat);
        }

        public static string ConvertToXmlDocument(ClinicalDocument cda)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(ClinicalDocument));

                using (StringWriter sw = new StringWriter())
                {
                    serializer.Serialize(sw, cda);

                    return sw.ToString();
                }
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex.ToString());
                throw ex;
            }
        }

        public static ClinicalDocument ConvertFromXmlDocument(string xml)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(ClinicalDocument));

            using (StringReader sr = new StringReader(xml))
            {
                return serializer.Deserialize(sr) as ClinicalDocument;
            }
        }

        /// <summary>
        /// Validates the given xml instance against the CDA schema
        /// </summary>
        /// <param name="xml">The XML instance content to validate.</param>
        /// <returns>A list of errors</returns>
        public static List<string> ValidateStructure(string xml)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Validates the given XML instance content against the specified schematron definition.
        /// </summary>
        /// <param name="xml">The XML instance to validate</param>
        /// <param name="schLocation">The location of the SCH file containing the schematron definition</param>
        /// <returns>A list of errors</returns>
        public static List<string> ValidateSchematron(string xml, string schLocation)
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lantana.CDA.Tests
{
    public static class Helper
    {
        public static bool ValidateCDA(string xml)
        {
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.Schemas.Add("urn:hl7-org:v3", "infrastructure/cda/CDA.xsd");
            settings.ValidationType = ValidationType.Schema;
            int errors = 0;

            Console.WriteLine("Document to validate:\r\n" + xml);

            using (StringReader sr = new StringReader(xml))
            {
                XmlReader reader = XmlReader.Create(sr, settings);
                XmlDocument document = new XmlDocument();

                try
                {
                    document.Load(reader);
                }
                catch (Exception ex)
                {
                    Console.Error.WriteLine("Error validating document: " + ex.Message);
                }

                ValidationEventHandler eventHandler = new ValidationEventHandler(
                    delegate(object sender, ValidationEventArgs args)
                    {
                        if (args.Severity == XmlSeverityType.Error)
                            errors += 1;
                    });

                // the following call to Validate succeeds.
                document.Validate(eventHandler);
            }

            return errors == 0;
        }
    }
}

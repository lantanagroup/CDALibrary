using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using CDALibrary.Core.Logic;

namespace CDALibrary.Core.Model
{
    public partial class ClinicalDocument
    {
        public string GetXml()
        {
            return ClinicalDocumentFactory.ConvertToXmlDocument(this);
        }

        [System.Xml.Serialization.XmlIgnore()]
        public ConfidentialityCodes? Confidentiality
        {
            get
            {
                if (this.ConfidentialityCode == null)
                {
                    this.ConfidentialityCode = new CE();
                }

                switch (this.ConfidentialityCode.Code)
                {
                    case "N":
                        return ConfidentialityCodes.Normal;
                    case "R":
                        return ConfidentialityCodes.Restricted;
                    case "V":
                        return ConfidentialityCodes.VeryRestricted;
                    default:
                        return null;
                }
            }
            set
            {
                if (value == null)
                {
                    this.ConfidentialityCode = null;
                }

                this.ConfidentialityCode = new CE();

                switch (value)
                {
                    case ConfidentialityCodes.Normal:
                        this.ConfidentialityCode.Code = "N";
                        break;
                    case ConfidentialityCodes.Restricted:
                        this.ConfidentialityCode.Code = "R";
                        break;
                    case ConfidentialityCodes.VeryRestricted:
                        this.ConfidentialityCode.Code = "V";
                        break;
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Lantana.CDA.Logic;

namespace Lantana.CDA.Model
{
    public partial class PN
    {
        public PN()
        {

        }

        public PN(string firstName, string middleName, string lastName)
        {
            this.AddGivenName(firstName);
            this.AddGivenName(middleName);
            this.AddFamilyName(lastName);
        }

        public PN(string prefix, string firstName, string middleName, string lastName, string suffix)
        {
            this.AddPrefixName(prefix);
            this.AddGivenName(firstName);
            this.AddGivenName(middleName);
            this.AddFamilyName(lastName);
            this.AddSuffixName(suffix);
        }

        public void AddPrefixName(string prefixName)
        {
            if (!string.IsNullOrEmpty(prefixName))
            {
                List<ENXP> nameParts = new List<ENXP>(this.Items);

                nameParts.Add(
                    new enprefix()
                    {
                        Text = new string[] { prefixName }
                    });

                this.Items = nameParts.ToArray();
            }
        }

        public void AddSuffixName(string suffixName)
        {
            if (!string.IsNullOrEmpty(suffixName))
            {
                List<ENXP> nameParts = new List<ENXP>(this.Items);

                nameParts.Add(
                    new ensuffix()
                    {
                        Text = new string[] { suffixName }
                    });

                this.Items = nameParts.ToArray();
            }
        }

        public void AddGivenName(string givenName)
        {
            if (!string.IsNullOrEmpty(givenName))
            {
                List<ENXP> nameParts = new List<ENXP>(this.Items);

                nameParts.Add(
                    new engiven()
                    {
                        Text = new string[] { givenName }
                    });

                this.Items = nameParts.ToArray();
            }
        }

        public void AddFamilyName(string familyName)
        {
            if (!string.IsNullOrEmpty(familyName))
            {
                List<ENXP> nameParts = new List<ENXP>(this.Items);

                nameParts.Add(
                    new enfamily()
                    {
                        Text = new string[] { familyName }
                    });

                this.Items = nameParts.ToArray();
            }
        }
    }
}

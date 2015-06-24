using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using CDALibrary.Core.Logic;

namespace CDALibrary.Core.Model
{
    public partial class StructuredBody
    {
        public StructuredBody(params Section[] sections)
        {
            using (new ClinicalDocumentDesigner())
            {
                foreach (Section currentSection in sections)
                {
                    this.Components.Add(new SectionComponent()
                    {
                        Section = currentSection
                    });
                }
            }
        }

        public void AddSection(Section section)
        {
            using (new ClinicalDocumentDesigner())
            {
                this.Components.Add(new SectionComponent()
                {
                    Section = section
                });
            }
        }

        public void AddSections(params Section[] sections)
        {
            using (new ClinicalDocumentDesigner())
            {
                foreach (Section currentSection in sections)
                {
                    this.Components.Add(new SectionComponent()
                    {
                        Section = currentSection
                    });
                }
            }
        }
    }
}

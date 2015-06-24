using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lantana.CDA.Model
{
    public partial class ClinicalDocument
    {
        public StructuredBody AddStructuredBody()
        {
            if (this.BodyComponent != null)
            {
                throw new Exception(Properties.Resources.ClinicalDocumentBodyAlreadyDefinedError);
            }

            this.BodyComponent = new BodyComponent();
            this.BodyComponent.Item = new StructuredBody();

            return this.BodyComponent.Item as StructuredBody;
        }

        public StructuredBody AddStructuredBody(params Section[] sections)
        {
            StructuredBody body = this.AddStructuredBody();
            body.AddSections(sections);

            return body;
        }

        public UnstructuredBody AddUnstructuredBody()
        {
            if (this.BodyComponent != null)
            {
                throw new Exception(Properties.Resources.ClinicalDocumentBodyAlreadyDefinedError);
            }

            this.BodyComponent = new BodyComponent();
            this.BodyComponent.Item = new UnstructuredBody();

            return this.BodyComponent.Item as UnstructuredBody;
        }
    }
}

using System.Collections.Generic;
using System.Xml.Serialization;

using Lantana.CDA.Logic;

namespace Lantana.CDA.Model
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName = "StrucDoc.Text", Namespace = "urn:hl7-org:v3")]
    public partial class StrucDocText
    {

        private object[] itemsField;

        private string[] textField;

        private string idField;

        private string languageField;

        private string styleCodeField;

        private string mediaTypeField;

        public StrucDocText()
        {
            this.mediaTypeField = "text/x-hl7-text+xml";
        }

        [XmlElement("br", typeof(StrucDocBr))]
        [XmlElement("content", typeof(StrucDocContent))]
        [XmlElement("footnote", typeof(StrucDocFootnote))]
        [XmlElement("footnoteRef", typeof(StrucDocFootnoteRef))]
        [XmlElement("linkHtml", typeof(StrucDocLinkHtml))]
        [XmlElement("list", typeof(StrucDocList))]
        [XmlElement("paragraph", typeof(StrucDocParagraph))]
        [XmlElement("renderMultiMedia", typeof(StrucDocRenderMultiMedia))]
        [XmlElement("sub", typeof(StrucDocSub))]
        [XmlElement("sup", typeof(StrucDocSup))]
        [XmlElement("table", typeof(StrucDocTable))]
        public object[] Items
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

        [XmlAttribute(DataType = "ID")]
        public string ID
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        [XmlAttribute(AttributeName = "language", DataType = "NMTOKEN")]
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

        [XmlAttribute(AttributeName = "styleCode", DataType = "NMTOKENS")]
        public string StyleCode
        {
            get
            {
                return this.styleCodeField;
            }
            set
            {
                this.styleCodeField = value;
            }
        }

        [XmlAttribute("mediaType")]
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
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName = "StrucDoc.Br", Namespace = "urn:hl7-org:v3")]
    public partial class StrucDocBr
    {
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName = "StrucDoc.Content", Namespace = "urn:hl7-org:v3")]
    public partial class StrucDocContent
    {

        private object[] itemsField;

        private string[] textField;

        private string idField;

        private string languageField;

        private string styleCodeField;

        private StrucDocContentRevised revisedField;

        private bool revisedFieldSpecified;

        [XmlElement("br", typeof(StrucDocBr))]
        [XmlElement("content", typeof(StrucDocContent))]
        [XmlElement("footnote", typeof(StrucDocFootnote))]
        [XmlElement("footnoteRef", typeof(StrucDocFootnoteRef))]
        [XmlElement("linkHtml", typeof(StrucDocLinkHtml))]
        [XmlElement("renderMultiMedia", typeof(StrucDocRenderMultiMedia))]
        [XmlElement("sub", typeof(StrucDocSub))]
        [XmlElement("sup", typeof(StrucDocSup))]
        public object[] Items
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

        [XmlAttribute(DataType = "ID")]
        public string ID
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        [XmlAttribute(AttributeName = "language", DataType = "NMTOKEN")]
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

        [XmlAttribute(AttributeName = "styleCode", DataType = "NMTOKENS")]
        public string StyleCode
        {
            get
            {
                return this.styleCodeField;
            }
            set
            {
                this.styleCodeField = value;
            }
        }

        [XmlAttribute("revised")]
        public StrucDocContentRevised Revised
        {
            get
            {
                return this.revisedField;
            }
            set
            {
                this.revisedField = value;
            }
        }

        [XmlIgnore()]
        public bool RevisedSpecified
        {
            get
            {
                return this.revisedFieldSpecified;
            }
            set
            {
                this.revisedFieldSpecified = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName = "StrucDoc.Footnote", Namespace = "urn:hl7-org:v3")]
    public partial class StrucDocFootnote
    {

        private object[] itemsField;

        private string[] textField;

        private string idField;

        private string languageField;

        private string styleCodeField;

        [XmlElement("br", typeof(StrucDocBr))]
        [XmlElement("content", typeof(StrucDocContent))]
        [XmlElement("linkHtml", typeof(StrucDocLinkHtml))]
        [XmlElement("list", typeof(StrucDocList))]
        [XmlElement("paragraph", typeof(StrucDocParagraph))]
        [XmlElement("renderMultiMedia", typeof(StrucDocRenderMultiMedia))]
        [XmlElement("sub", typeof(StrucDocSub))]
        [XmlElement("sup", typeof(StrucDocSup))]
        [XmlElement("table", typeof(StrucDocTable))]
        public object[] Items
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

        [XmlAttribute(DataType = "ID")]
        public string ID
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        [XmlAttribute(DataType = "NMTOKEN")]
        public string language
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

        [XmlAttribute(DataType = "NMTOKENS")]
        public string styleCode
        {
            get
            {
                return this.styleCodeField;
            }
            set
            {
                this.styleCodeField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName = "StrucDoc.LinkHtml", Namespace = "urn:hl7-org:v3")]
    public partial class StrucDocLinkHtml
    {

        private object[] itemsField;

        private string[] textField;

        private string nameField;

        private string hrefField;

        private string relField;

        private string revField;

        private string titleField;

        private string idField;

        private string languageField;

        private string styleCodeField;

        [XmlElement("footnote", typeof(StrucDocFootnote))]
        [XmlElement("footnoteRef", typeof(StrucDocFootnoteRef))]
        public object[] Items
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

        [XmlAttribute()]
        public string name
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

        [XmlAttribute()]
        public string href
        {
            get
            {
                return this.hrefField;
            }
            set
            {
                this.hrefField = value;
            }
        }

        [XmlAttribute()]
        public string rel
        {
            get
            {
                return this.relField;
            }
            set
            {
                this.relField = value;
            }
        }

        [XmlAttribute()]
        public string rev
        {
            get
            {
                return this.revField;
            }
            set
            {
                this.revField = value;
            }
        }

        [XmlAttribute()]
        public string title
        {
            get
            {
                return this.titleField;
            }
            set
            {
                this.titleField = value;
            }
        }

        [XmlAttribute(DataType = "ID")]
        public string ID
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        [XmlAttribute(DataType = "NMTOKEN")]
        public string language
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

        [XmlAttribute(DataType = "NMTOKENS")]
        public string styleCode
        {
            get
            {
                return this.styleCodeField;
            }
            set
            {
                this.styleCodeField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName = "StrucDoc.FootnoteRef", Namespace = "urn:hl7-org:v3")]
    public partial class StrucDocFootnoteRef
    {

        private string idField;

        private string languageField;

        private string styleCodeField;

        private string iDREFField;

        [XmlAttribute(DataType = "ID")]
        public string ID
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        [XmlAttribute(DataType = "NMTOKEN")]
        public string language
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

        [XmlAttribute(DataType = "NMTOKENS")]
        public string styleCode
        {
            get
            {
                return this.styleCodeField;
            }
            set
            {
                this.styleCodeField = value;
            }
        }

        [XmlAttribute(DataType = "IDREF")]
        public string IDREF
        {
            get
            {
                return this.iDREFField;
            }
            set
            {
                this.iDREFField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName = "StrucDoc.List", Namespace = "urn:hl7-org:v3")]
    public partial class StrucDocList
    {

        private StrucDocCaption captionField;

        private List<StrucDocItem> itemField;

        private string idField;

        private string languageField;

        private string styleCodeField;

        private StrucDocListListType listTypeField;

        public StrucDocList()
        {
            this.listTypeField = StrucDocListListType.unordered;
        }

        public StrucDocCaption caption
        {
            get
            {
                return this.captionField;
            }
            set
            {
                this.captionField = value;
            }
        }

        [XmlElement("item")]
        public List<StrucDocItem> item
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

        [XmlAttribute(DataType = "ID")]
        public string ID
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        [XmlAttribute(DataType = "NMTOKEN")]
        public string language
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

        [XmlAttribute(DataType = "NMTOKENS")]
        public string styleCode
        {
            get
            {
                return this.styleCodeField;
            }
            set
            {
                this.styleCodeField = value;
            }
        }

        [XmlAttribute()]
        [System.ComponentModel.DefaultValueAttribute(StrucDocListListType.unordered)]
        public StrucDocListListType listType
        {
            get
            {
                return this.listTypeField;
            }
            set
            {
                this.listTypeField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName = "StrucDoc.Caption", Namespace = "urn:hl7-org:v3")]
    public partial class StrucDocCaption
    {

        private object[] itemsField;

        private string[] textField;

        private string idField;

        private string languageField;

        private string styleCodeField;

        [XmlElement("footnote", typeof(StrucDocFootnote))]
        [XmlElement("footnoteRef", typeof(StrucDocFootnoteRef))]
        [XmlElement("linkHtml", typeof(StrucDocLinkHtml))]
        [XmlElement("sub", typeof(StrucDocSub))]
        [XmlElement("sup", typeof(StrucDocSup))]
        public object[] Items
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

        [XmlAttribute(DataType = "ID")]
        public string ID
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        [XmlAttribute(DataType = "NMTOKEN")]
        public string language
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

        [XmlAttribute(DataType = "NMTOKENS")]
        public string styleCode
        {
            get
            {
                return this.styleCodeField;
            }
            set
            {
                this.styleCodeField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName = "StrucDoc.Sub", Namespace = "urn:hl7-org:v3")]
    public partial class StrucDocSub
    {

        private string[] textField;

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

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName = "StrucDoc.Sup", Namespace = "urn:hl7-org:v3")]
    public partial class StrucDocSup
    {

        private string[] textField;

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

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName = "StrucDoc.Item", Namespace = "urn:hl7-org:v3")]
    public partial class StrucDocItem
    {

        private StrucDocCaption captionField;

        private object[] itemsField;

        private string[] textField;

        private string idField;

        private string languageField;

        private string styleCodeField;

        public StrucDocCaption caption
        {
            get
            {
                return this.captionField;
            }
            set
            {
                this.captionField = value;
            }
        }

        [XmlElement("br", typeof(StrucDocBr))]
        [XmlElement("content", typeof(StrucDocContent))]
        [XmlElement("footnote", typeof(StrucDocFootnote))]
        [XmlElement("footnoteRef", typeof(StrucDocFootnoteRef))]
        [XmlElement("linkHtml", typeof(StrucDocLinkHtml))]
        [XmlElement("list", typeof(StrucDocList))]
        [XmlElement("paragraph", typeof(StrucDocParagraph))]
        [XmlElement("renderMultiMedia", typeof(StrucDocRenderMultiMedia))]
        [XmlElement("sub", typeof(StrucDocSub))]
        [XmlElement("sup", typeof(StrucDocSup))]
        [XmlElement("table", typeof(StrucDocTable))]
        public object[] Items
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

        [XmlAttribute(DataType = "ID")]
        public string ID
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        [XmlAttribute(DataType = "NMTOKEN")]
        public string language
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

        [XmlAttribute(DataType = "NMTOKENS")]
        public string styleCode
        {
            get
            {
                return this.styleCodeField;
            }
            set
            {
                this.styleCodeField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName = "StrucDoc.Paragraph", Namespace = "urn:hl7-org:v3")]
    public partial class StrucDocParagraph
    {

        private StrucDocCaption captionField;

        private object[] itemsField;

        private string[] textField;

        private string idField;

        private string languageField;

        private string styleCodeField;

        public StrucDocCaption caption
        {
            get
            {
                return this.captionField;
            }
            set
            {
                this.captionField = value;
            }
        }

        [XmlElement("br", typeof(StrucDocBr))]
        [XmlElement("content", typeof(StrucDocContent))]
        [XmlElement("footnote", typeof(StrucDocFootnote))]
        [XmlElement("footnoteRef", typeof(StrucDocFootnoteRef))]
        [XmlElement("linkHtml", typeof(StrucDocLinkHtml))]
        [XmlElement("renderMultiMedia", typeof(StrucDocRenderMultiMedia))]
        [XmlElement("sub", typeof(StrucDocSub))]
        [XmlElement("sup", typeof(StrucDocSup))]
        public object[] Items
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

        [XmlAttribute(DataType = "ID")]
        public string ID
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        [XmlAttribute(DataType = "NMTOKEN")]
        public string language
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

        [XmlAttribute(DataType = "NMTOKENS")]
        public string styleCode
        {
            get
            {
                return this.styleCodeField;
            }
            set
            {
                this.styleCodeField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName = "StrucDoc.RenderMultiMedia", Namespace = "urn:hl7-org:v3")]
    public partial class StrucDocRenderMultiMedia
    {

        private StrucDocCaption captionField;

        private string referencedObjectField;

        private string idField;

        private string languageField;

        private string styleCodeField;

        public StrucDocCaption caption
        {
            get
            {
                return this.captionField;
            }
            set
            {
                this.captionField = value;
            }
        }

        [XmlAttribute(DataType = "IDREFS")]
        public string referencedObject
        {
            get
            {
                return this.referencedObjectField;
            }
            set
            {
                this.referencedObjectField = value;
            }
        }

        [XmlAttribute(DataType = "ID")]
        public string ID
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        [XmlAttribute(DataType = "NMTOKEN")]
        public string language
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

        [XmlAttribute(DataType = "NMTOKENS")]
        public string styleCode
        {
            get
            {
                return this.styleCodeField;
            }
            set
            {
                this.styleCodeField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName = "StrucDoc.Table", Namespace = "urn:hl7-org:v3")]
    public partial class StrucDocTable
    {

        private StrucDocCaption captionField;

        private object[] itemsField;

        private StrucDocThead theadField;

        private StrucDocTfoot tfootField;

        private StrucDocTbody[] tbodyField;

        private string idField;

        private string languageField;

        private string styleCodeField;

        private string summaryField;

        private string widthField;

        private string borderField;

        private StrucDocTableFrame frameField;

        private bool frameFieldSpecified;

        private StrucDocTableRules rulesField;

        private bool rulesFieldSpecified;

        private string cellspacingField;

        private string cellpaddingField;

        public StrucDocCaption caption
        {
            get
            {
                return this.captionField;
            }
            set
            {
                this.captionField = value;
            }
        }

        [XmlElement("col", typeof(StrucDocCol))]
        [XmlElement("colgroup", typeof(StrucDocColgroup))]
        public object[] Items
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

        public StrucDocThead thead
        {
            get
            {
                return this.theadField;
            }
            set
            {
                this.theadField = value;
            }
        }

        public StrucDocTfoot tfoot
        {
            get
            {
                return this.tfootField;
            }
            set
            {
                this.tfootField = value;
            }
        }

        [XmlElement("tbody")]
        public StrucDocTbody[] tbody
        {
            get
            {
                return this.tbodyField;
            }
            set
            {
                this.tbodyField = value;
            }
        }

        [XmlAttribute(DataType = "ID")]
        public string ID
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        [XmlAttribute(DataType = "NMTOKEN")]
        public string language
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

        [XmlAttribute(DataType = "NMTOKENS")]
        public string styleCode
        {
            get
            {
                return this.styleCodeField;
            }
            set
            {
                this.styleCodeField = value;
            }
        }

        [XmlAttribute()]
        public string summary
        {
            get
            {
                return this.summaryField;
            }
            set
            {
                this.summaryField = value;
            }
        }

        [XmlAttribute()]
        public string width
        {
            get
            {
                return this.widthField;
            }
            set
            {
                this.widthField = value;
            }
        }

        [XmlAttribute()]
        public string border
        {
            get
            {
                return this.borderField;
            }
            set
            {
                this.borderField = value;
            }
        }

        [XmlAttribute()]
        public StrucDocTableFrame frame
        {
            get
            {
                return this.frameField;
            }
            set
            {
                this.frameField = value;
            }
        }

        [XmlIgnore()]
        public bool frameSpecified
        {
            get
            {
                return this.frameFieldSpecified;
            }
            set
            {
                this.frameFieldSpecified = value;
            }
        }

        [XmlAttribute()]
        public StrucDocTableRules rules
        {
            get
            {
                return this.rulesField;
            }
            set
            {
                this.rulesField = value;
            }
        }

        [XmlIgnore()]
        public bool rulesSpecified
        {
            get
            {
                return this.rulesFieldSpecified;
            }
            set
            {
                this.rulesFieldSpecified = value;
            }
        }

        [XmlAttribute()]
        public string cellspacing
        {
            get
            {
                return this.cellspacingField;
            }
            set
            {
                this.cellspacingField = value;
            }
        }

        [XmlAttribute()]
        public string cellpadding
        {
            get
            {
                return this.cellpaddingField;
            }
            set
            {
                this.cellpaddingField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName = "StrucDoc.Col", Namespace = "urn:hl7-org:v3")]
    public partial class StrucDocCol
    {

        private string idField;

        private string languageField;

        private string styleCodeField;

        private string spanField;

        private string widthField;

        private StrucDocColAlign alignField;

        private bool alignFieldSpecified;

        private string charField;

        private string charoffField;

        private StrucDocColValign valignField;

        private bool valignFieldSpecified;

        public StrucDocCol()
        {
            this.spanField = "1";
        }

        [XmlAttribute(DataType = "ID")]
        public string ID
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        [XmlAttribute(DataType = "NMTOKEN")]
        public string language
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

        [XmlAttribute(DataType = "NMTOKENS")]
        public string styleCode
        {
            get
            {
                return this.styleCodeField;
            }
            set
            {
                this.styleCodeField = value;
            }
        }

        [XmlAttribute()]
        [System.ComponentModel.DefaultValueAttribute("1")]
        public string span
        {
            get
            {
                return this.spanField;
            }
            set
            {
                this.spanField = value;
            }
        }

        [XmlAttribute()]
        public string width
        {
            get
            {
                return this.widthField;
            }
            set
            {
                this.widthField = value;
            }
        }

        [XmlAttribute()]
        public StrucDocColAlign align
        {
            get
            {
                return this.alignField;
            }
            set
            {
                this.alignField = value;
            }
        }

        [XmlIgnore()]
        public bool alignSpecified
        {
            get
            {
                return this.alignFieldSpecified;
            }
            set
            {
                this.alignFieldSpecified = value;
            }
        }

        [XmlAttribute()]
        public string @char
        {
            get
            {
                return this.charField;
            }
            set
            {
                this.charField = value;
            }
        }

        [XmlAttribute()]
        public string charoff
        {
            get
            {
                return this.charoffField;
            }
            set
            {
                this.charoffField = value;
            }
        }

        [XmlAttribute()]
        public StrucDocColValign valign
        {
            get
            {
                return this.valignField;
            }
            set
            {
                this.valignField = value;
            }
        }

        [XmlIgnore()]
        public bool valignSpecified
        {
            get
            {
                return this.valignFieldSpecified;
            }
            set
            {
                this.valignFieldSpecified = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
    public enum StrucDocColAlign
    {

        left,

        center,

        right,

        justify,

        @char,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
    public enum StrucDocColValign
    {

        top,

        middle,

        bottom,

        baseline,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName = "StrucDoc.Colgroup", Namespace = "urn:hl7-org:v3")]
    public partial class StrucDocColgroup
    {

        private List<StrucDocCol> colField;

        private string idField;

        private string languageField;

        private string styleCodeField;

        private string spanField;

        private string widthField;

        private StrucDocColgroupAlign alignField;

        private bool alignFieldSpecified;

        private string charField;

        private string charoffField;

        private StrucDocColgroupValign valignField;

        private bool valignFieldSpecified;

        public StrucDocColgroup()
        {
            this.spanField = "1";
        }

        [XmlElement("col")]
        public List<StrucDocCol> col
        {
            get
            {
                return this.colField;
            }
            set
            {
                this.colField = value;
            }
        }

        [XmlAttribute(DataType = "ID")]
        public string ID
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        [XmlAttribute(DataType = "NMTOKEN")]
        public string language
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

        [XmlAttribute(DataType = "NMTOKENS")]
        public string styleCode
        {
            get
            {
                return this.styleCodeField;
            }
            set
            {
                this.styleCodeField = value;
            }
        }

        [XmlAttribute()]
        [System.ComponentModel.DefaultValueAttribute("1")]
        public string span
        {
            get
            {
                return this.spanField;
            }
            set
            {
                this.spanField = value;
            }
        }

        [XmlAttribute()]
        public string width
        {
            get
            {
                return this.widthField;
            }
            set
            {
                this.widthField = value;
            }
        }

        [XmlAttribute()]
        public StrucDocColgroupAlign align
        {
            get
            {
                return this.alignField;
            }
            set
            {
                this.alignField = value;
            }
        }

        [XmlIgnore()]
        public bool alignSpecified
        {
            get
            {
                return this.alignFieldSpecified;
            }
            set
            {
                this.alignFieldSpecified = value;
            }
        }

        [XmlAttribute()]
        public string @char
        {
            get
            {
                return this.charField;
            }
            set
            {
                this.charField = value;
            }
        }

        [XmlAttribute()]
        public string charoff
        {
            get
            {
                return this.charoffField;
            }
            set
            {
                this.charoffField = value;
            }
        }

        [XmlAttribute()]
        public StrucDocColgroupValign valign
        {
            get
            {
                return this.valignField;
            }
            set
            {
                this.valignField = value;
            }
        }

        [XmlIgnore()]
        public bool valignSpecified
        {
            get
            {
                return this.valignFieldSpecified;
            }
            set
            {
                this.valignFieldSpecified = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
    public enum StrucDocColgroupAlign
    {

        left,

        center,

        right,

        justify,

        @char,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
    public enum StrucDocColgroupValign
    {

        top,

        middle,

        bottom,

        baseline,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName = "StrucDoc.Thead", Namespace = "urn:hl7-org:v3")]
    public partial class StrucDocThead
    {

        private List<StrucDocTr> trField;

        private string idField;

        private string languageField;

        private string styleCodeField;

        private StrucDocTheadAlign alignField;

        private bool alignFieldSpecified;

        private string charField;

        private string charoffField;

        private StrucDocTheadValign valignField;

        private bool valignFieldSpecified;

        [XmlElement("tr")]
        public List<StrucDocTr> tr
        {
            get
            {
                return this.trField;
            }
            set
            {
                this.trField = value;
            }
        }

        [XmlAttribute(DataType = "ID")]
        public string ID
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        [XmlAttribute(DataType = "NMTOKEN")]
        public string language
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

        [XmlAttribute(DataType = "NMTOKENS")]
        public string styleCode
        {
            get
            {
                return this.styleCodeField;
            }
            set
            {
                this.styleCodeField = value;
            }
        }

        [XmlAttribute()]
        public StrucDocTheadAlign align
        {
            get
            {
                return this.alignField;
            }
            set
            {
                this.alignField = value;
            }
        }

        [XmlIgnore()]
        public bool alignSpecified
        {
            get
            {
                return this.alignFieldSpecified;
            }
            set
            {
                this.alignFieldSpecified = value;
            }
        }

        [XmlAttribute()]
        public string @char
        {
            get
            {
                return this.charField;
            }
            set
            {
                this.charField = value;
            }
        }

        [XmlAttribute()]
        public string charoff
        {
            get
            {
                return this.charoffField;
            }
            set
            {
                this.charoffField = value;
            }
        }

        [XmlAttribute()]
        public StrucDocTheadValign valign
        {
            get
            {
                return this.valignField;
            }
            set
            {
                this.valignField = value;
            }
        }

        [XmlIgnore()]
        public bool valignSpecified
        {
            get
            {
                return this.valignFieldSpecified;
            }
            set
            {
                this.valignFieldSpecified = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName = "StrucDoc.Tr", Namespace = "urn:hl7-org:v3")]
    public partial class StrucDocTr
    {

        private object[] itemsField;

        private string idField;

        private string languageField;

        private string styleCodeField;

        private StrucDocTrAlign alignField;

        private bool alignFieldSpecified;

        private string charField;

        private string charoffField;

        private StrucDocTrValign valignField;

        private bool valignFieldSpecified;

        [XmlElement("td", typeof(StrucDocTd))]
        [XmlElement("th", typeof(StrucDocTh))]
        public object[] Items
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

        [XmlAttribute(DataType = "ID")]
        public string ID
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        [XmlAttribute(DataType = "NMTOKEN")]
        public string language
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

        [XmlAttribute(DataType = "NMTOKENS")]
        public string styleCode
        {
            get
            {
                return this.styleCodeField;
            }
            set
            {
                this.styleCodeField = value;
            }
        }

        [XmlAttribute()]
        public StrucDocTrAlign align
        {
            get
            {
                return this.alignField;
            }
            set
            {
                this.alignField = value;
            }
        }

        [XmlIgnore()]
        public bool alignSpecified
        {
            get
            {
                return this.alignFieldSpecified;
            }
            set
            {
                this.alignFieldSpecified = value;
            }
        }

        [XmlAttribute()]
        public string @char
        {
            get
            {
                return this.charField;
            }
            set
            {
                this.charField = value;
            }
        }

        [XmlAttribute()]
        public string charoff
        {
            get
            {
                return this.charoffField;
            }
            set
            {
                this.charoffField = value;
            }
        }

        [XmlAttribute()]
        public StrucDocTrValign valign
        {
            get
            {
                return this.valignField;
            }
            set
            {
                this.valignField = value;
            }
        }

        [XmlIgnore()]
        public bool valignSpecified
        {
            get
            {
                return this.valignFieldSpecified;
            }
            set
            {
                this.valignFieldSpecified = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName = "StrucDoc.Td", Namespace = "urn:hl7-org:v3")]
    public partial class StrucDocTd
    {

        private object[] itemsField;

        private string[] textField;

        private string idField;

        private string languageField;

        private string styleCodeField;

        private string abbrField;

        private string axisField;

        private string headersField;

        private StrucDocTdScope scopeField;

        private bool scopeFieldSpecified;

        private string rowspanField;

        private string colspanField;

        private StrucDocTdAlign alignField;

        private bool alignFieldSpecified;

        private string charField;

        private string charoffField;

        private StrucDocTdValign valignField;

        private bool valignFieldSpecified;

        public StrucDocTd()
        {
            this.rowspanField = "1";
            this.colspanField = "1";
        }

        [XmlElement("br", typeof(StrucDocBr))]
        [XmlElement("content", typeof(StrucDocContent))]
        [XmlElement("footnote", typeof(StrucDocFootnote))]
        [XmlElement("footnoteRef", typeof(StrucDocFootnoteRef))]
        [XmlElement("linkHtml", typeof(StrucDocLinkHtml))]
        [XmlElement("list", typeof(StrucDocList))]
        [XmlElement("paragraph", typeof(StrucDocParagraph))]
        [XmlElement("renderMultiMedia", typeof(StrucDocRenderMultiMedia))]
        [XmlElement("sub", typeof(StrucDocSub))]
        [XmlElement("sup", typeof(StrucDocSup))]
        public object[] Items
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

        [XmlAttribute(DataType = "ID")]
        public string ID
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        [XmlAttribute(DataType = "NMTOKEN")]
        public string language
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

        [XmlAttribute(DataType = "NMTOKENS")]
        public string styleCode
        {
            get
            {
                return this.styleCodeField;
            }
            set
            {
                this.styleCodeField = value;
            }
        }

        [XmlAttribute()]
        public string abbr
        {
            get
            {
                return this.abbrField;
            }
            set
            {
                this.abbrField = value;
            }
        }

        [XmlAttribute()]
        public string axis
        {
            get
            {
                return this.axisField;
            }
            set
            {
                this.axisField = value;
            }
        }

        [XmlAttribute(DataType = "IDREFS")]
        public string headers
        {
            get
            {
                return this.headersField;
            }
            set
            {
                this.headersField = value;
            }
        }

        [XmlAttribute()]
        public StrucDocTdScope scope
        {
            get
            {
                return this.scopeField;
            }
            set
            {
                this.scopeField = value;
            }
        }

        [XmlIgnore()]
        public bool scopeSpecified
        {
            get
            {
                return this.scopeFieldSpecified;
            }
            set
            {
                this.scopeFieldSpecified = value;
            }
        }

        [XmlAttribute()]
        [System.ComponentModel.DefaultValueAttribute("1")]
        public string rowspan
        {
            get
            {
                return this.rowspanField;
            }
            set
            {
                this.rowspanField = value;
            }
        }

        [XmlAttribute()]
        [System.ComponentModel.DefaultValueAttribute("1")]
        public string colspan
        {
            get
            {
                return this.colspanField;
            }
            set
            {
                this.colspanField = value;
            }
        }

        [XmlAttribute()]
        public StrucDocTdAlign align
        {
            get
            {
                return this.alignField;
            }
            set
            {
                this.alignField = value;
            }
        }

        [XmlIgnore()]
        public bool alignSpecified
        {
            get
            {
                return this.alignFieldSpecified;
            }
            set
            {
                this.alignFieldSpecified = value;
            }
        }

        [XmlAttribute()]
        public string @char
        {
            get
            {
                return this.charField;
            }
            set
            {
                this.charField = value;
            }
        }

        [XmlAttribute()]
        public string charoff
        {
            get
            {
                return this.charoffField;
            }
            set
            {
                this.charoffField = value;
            }
        }

        [XmlAttribute()]
        public StrucDocTdValign valign
        {
            get
            {
                return this.valignField;
            }
            set
            {
                this.valignField = value;
            }
        }

        [XmlIgnore()]
        public bool valignSpecified
        {
            get
            {
                return this.valignFieldSpecified;
            }
            set
            {
                this.valignFieldSpecified = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
    public enum StrucDocTdScope
    {

        row,

        col,

        rowgroup,

        colgroup,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
    public enum StrucDocTdAlign
    {

        left,

        center,

        right,

        justify,

        @char,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
    public enum StrucDocTdValign
    {

        top,

        middle,

        bottom,

        baseline,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName = "StrucDoc.Th", Namespace = "urn:hl7-org:v3")]
    public partial class StrucDocTh
    {

        private object[] itemsField;

        private string[] textField;

        private string idField;

        private string languageField;

        private string styleCodeField;

        private string abbrField;

        private string axisField;

        private string headersField;

        private StrucDocThScope scopeField;

        private bool scopeFieldSpecified;

        private string rowspanField;

        private string colspanField;

        private StrucDocThAlign alignField;

        private bool alignFieldSpecified;

        private string charField;

        private string charoffField;

        private StrucDocThValign valignField;

        private bool valignFieldSpecified;

        public StrucDocTh()
        {
            this.rowspanField = "1";
            this.colspanField = "1";
        }

        [XmlElement("br", typeof(StrucDocBr))]
        [XmlElement("content", typeof(StrucDocContent))]
        [XmlElement("footnote", typeof(StrucDocFootnote))]
        [XmlElement("footnoteRef", typeof(StrucDocFootnoteRef))]
        [XmlElement("linkHtml", typeof(StrucDocLinkHtml))]
        [XmlElement("renderMultiMedia", typeof(StrucDocRenderMultiMedia))]
        [XmlElement("sub", typeof(StrucDocSub))]
        [XmlElement("sup", typeof(StrucDocSup))]
        public object[] Items
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

        [XmlAttribute(DataType = "ID")]
        public string ID
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        [XmlAttribute(DataType = "NMTOKEN")]
        public string language
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

        [XmlAttribute(DataType = "NMTOKENS")]
        public string styleCode
        {
            get
            {
                return this.styleCodeField;
            }
            set
            {
                this.styleCodeField = value;
            }
        }

        [XmlAttribute()]
        public string abbr
        {
            get
            {
                return this.abbrField;
            }
            set
            {
                this.abbrField = value;
            }
        }

        [XmlAttribute()]
        public string axis
        {
            get
            {
                return this.axisField;
            }
            set
            {
                this.axisField = value;
            }
        }

        [XmlAttribute(DataType = "IDREFS")]
        public string headers
        {
            get
            {
                return this.headersField;
            }
            set
            {
                this.headersField = value;
            }
        }

        [XmlAttribute()]
        public StrucDocThScope scope
        {
            get
            {
                return this.scopeField;
            }
            set
            {
                this.scopeField = value;
            }
        }

        [XmlIgnore()]
        public bool scopeSpecified
        {
            get
            {
                return this.scopeFieldSpecified;
            }
            set
            {
                this.scopeFieldSpecified = value;
            }
        }

        [XmlAttribute()]
        [System.ComponentModel.DefaultValueAttribute("1")]
        public string rowspan
        {
            get
            {
                return this.rowspanField;
            }
            set
            {
                this.rowspanField = value;
            }
        }

        [XmlAttribute()]
        [System.ComponentModel.DefaultValueAttribute("1")]
        public string colspan
        {
            get
            {
                return this.colspanField;
            }
            set
            {
                this.colspanField = value;
            }
        }

        [XmlAttribute()]
        public StrucDocThAlign align
        {
            get
            {
                return this.alignField;
            }
            set
            {
                this.alignField = value;
            }
        }

        [XmlIgnore()]
        public bool alignSpecified
        {
            get
            {
                return this.alignFieldSpecified;
            }
            set
            {
                this.alignFieldSpecified = value;
            }
        }

        [XmlAttribute()]
        public string @char
        {
            get
            {
                return this.charField;
            }
            set
            {
                this.charField = value;
            }
        }

        [XmlAttribute()]
        public string charoff
        {
            get
            {
                return this.charoffField;
            }
            set
            {
                this.charoffField = value;
            }
        }

        [XmlAttribute()]
        public StrucDocThValign valign
        {
            get
            {
                return this.valignField;
            }
            set
            {
                this.valignField = value;
            }
        }

        [XmlIgnore()]
        public bool valignSpecified
        {
            get
            {
                return this.valignFieldSpecified;
            }
            set
            {
                this.valignFieldSpecified = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
    public enum StrucDocThScope
    {

        row,

        col,

        rowgroup,

        colgroup,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
    public enum StrucDocThAlign
    {

        left,

        center,

        right,

        justify,

        @char,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
    public enum StrucDocThValign
    {

        top,

        middle,

        bottom,

        baseline,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
    public enum StrucDocTrAlign
    {

        left,

        center,

        right,

        justify,

        @char,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
    public enum StrucDocTrValign
    {

        top,

        middle,

        bottom,

        baseline,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
    public enum StrucDocTheadAlign
    {

        left,

        center,

        right,

        justify,

        @char,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
    public enum StrucDocTheadValign
    {

        top,

        middle,

        bottom,

        baseline,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName = "StrucDoc.Tfoot", Namespace = "urn:hl7-org:v3")]
    public partial class StrucDocTfoot
    {

        private List<StrucDocTr> trField;

        private string idField;

        private string languageField;

        private string styleCodeField;

        private StrucDocTfootAlign alignField;

        private bool alignFieldSpecified;

        private string charField;

        private string charoffField;

        private StrucDocTfootValign valignField;

        private bool valignFieldSpecified;

        [XmlElement("tr")]
        public List<StrucDocTr> tr
        {
            get
            {
                return this.trField;
            }
            set
            {
                this.trField = value;
            }
        }

        [XmlAttribute(DataType = "ID")]
        public string ID
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        [XmlAttribute(DataType = "NMTOKEN")]
        public string language
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

        [XmlAttribute(DataType = "NMTOKENS")]
        public string styleCode
        {
            get
            {
                return this.styleCodeField;
            }
            set
            {
                this.styleCodeField = value;
            }
        }

        [XmlAttribute()]
        public StrucDocTfootAlign align
        {
            get
            {
                return this.alignField;
            }
            set
            {
                this.alignField = value;
            }
        }

        [XmlIgnore()]
        public bool alignSpecified
        {
            get
            {
                return this.alignFieldSpecified;
            }
            set
            {
                this.alignFieldSpecified = value;
            }
        }

        [XmlAttribute()]
        public string @char
        {
            get
            {
                return this.charField;
            }
            set
            {
                this.charField = value;
            }
        }

        [XmlAttribute()]
        public string charoff
        {
            get
            {
                return this.charoffField;
            }
            set
            {
                this.charoffField = value;
            }
        }

        [XmlAttribute()]
        public StrucDocTfootValign valign
        {
            get
            {
                return this.valignField;
            }
            set
            {
                this.valignField = value;
            }
        }

        [XmlIgnore()]
        public bool valignSpecified
        {
            get
            {
                return this.valignFieldSpecified;
            }
            set
            {
                this.valignFieldSpecified = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
    public enum StrucDocTfootAlign
    {

        left,

        center,

        right,

        justify,

        @char,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
    public enum StrucDocTfootValign
    {

        top,

        middle,

        bottom,

        baseline,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName = "StrucDoc.Tbody", Namespace = "urn:hl7-org:v3")]
    public partial class StrucDocTbody
    {

        private List<StrucDocTr> trField;

        private string idField;

        private string languageField;

        private string styleCodeField;

        private StrucDocTbodyAlign alignField;

        private bool alignFieldSpecified;

        private string charField;

        private string charoffField;

        private StrucDocTbodyValign valignField;

        private bool valignFieldSpecified;

        [XmlElement("tr")]
        public List<StrucDocTr> tr
        {
            get
            {
                return this.trField;
            }
            set
            {
                this.trField = value;
            }
        }

        [XmlAttribute(DataType = "ID")]
        public string ID
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        [XmlAttribute(DataType = "NMTOKEN")]
        public string language
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

        [XmlAttribute(DataType = "NMTOKENS")]
        public string styleCode
        {
            get
            {
                return this.styleCodeField;
            }
            set
            {
                this.styleCodeField = value;
            }
        }

        [XmlAttribute()]
        public StrucDocTbodyAlign align
        {
            get
            {
                return this.alignField;
            }
            set
            {
                this.alignField = value;
            }
        }

        [XmlIgnore()]
        public bool alignSpecified
        {
            get
            {
                return this.alignFieldSpecified;
            }
            set
            {
                this.alignFieldSpecified = value;
            }
        }

        [XmlAttribute()]
        public string @char
        {
            get
            {
                return this.charField;
            }
            set
            {
                this.charField = value;
            }
        }

        [XmlAttribute()]
        public string charoff
        {
            get
            {
                return this.charoffField;
            }
            set
            {
                this.charoffField = value;
            }
        }

        [XmlAttribute()]
        public StrucDocTbodyValign valign
        {
            get
            {
                return this.valignField;
            }
            set
            {
                this.valignField = value;
            }
        }

        [XmlIgnore()]
        public bool valignSpecified
        {
            get
            {
                return this.valignFieldSpecified;
            }
            set
            {
                this.valignFieldSpecified = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
    public enum StrucDocTbodyAlign
    {

        left,

        center,

        right,

        justify,

        @char,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
    public enum StrucDocTbodyValign
    {

        top,

        middle,

        bottom,

        baseline,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
    public enum StrucDocTableFrame
    {

        @void,

        above,

        below,

        hsides,

        lhs,

        rhs,

        vsides,

        box,

        border,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
    public enum StrucDocTableRules
    {

        none,

        groups,

        rows,

        cols,

        all,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
    public enum StrucDocListListType
    {

        ordered,

        unordered,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
    public enum StrucDocContentRevised
    {

        insert,

        delete,
    }
}

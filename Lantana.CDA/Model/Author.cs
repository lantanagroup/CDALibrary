using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using CDALibrary.Core.Logic;

namespace CDALibrary.Core.Model
{
    public partial class Author
    {
        public Author(II assignedAuthorId, DateTime authorDate)
        {
            using (new ClinicalDocumentDesigner())
            {
                this.AssignedAuthor.Ids.Add(assignedAuthorId);
                this.Time.Value = ClinicalDocumentFactory.GetDate(authorDate);
            }
        }
    }
}

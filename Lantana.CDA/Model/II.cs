using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lantana.CDA.Model
{
    public partial class II
    {
        public II()
        {

        }

        public II(string root, string extension)
        {
            this.Root = root;
            this.Extension = extension;
        }

        public II(string root)
        {
            this.Root = root;
        }
    }
}

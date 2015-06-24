using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CDALibrary.Core.Model
{
    public partial class ManufacturedProduct
    {
        public ManufacturedProduct(Material material)
        {
            this.Item = material;
        }

        public ManufacturedProduct(LabeledDrug labeledDrug)
        {
            this.Item = labeledDrug;
        }
    }
}

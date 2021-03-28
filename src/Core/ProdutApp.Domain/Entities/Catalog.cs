using ProdutApp.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdutApp.Domain.Entities
{
    public class Catalog : BaseEntity
    {
        public String Name { get; set; }
        public Decimal Value { get; set; }
        public int Quantity { get; set; }

    }
}

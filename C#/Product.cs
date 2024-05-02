using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    internal class Product
    {
        public int ProductId { get; set; }

        public string CategoryId { get; set; }
        public string ProductName { get; set; }
        public short UnistinStock { get; set; }
        public int UnitPrice { get; set; }

    }
}

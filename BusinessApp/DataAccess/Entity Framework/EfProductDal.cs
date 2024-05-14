using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entity_Framework
{
    public class EfProductDal : EfReposityoryBaseClass<Product, NorthwindContext>, IProductDal
    {
    }
}

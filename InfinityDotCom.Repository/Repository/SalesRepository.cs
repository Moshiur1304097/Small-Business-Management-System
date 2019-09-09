using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InfinityDotCom.Models.Models;
using InfinityDotCom.DatabaseContext.DatabaseContext;

namespace InfinityDotCom.Repository.Repository
{
    public class SalesRepository
    {
        InfinityDBContext db = new InfinityDBContext();
        public int Add(List<SalesProduct> salesProducts)
        {
            int isAdd = 0;

            db.salesProducts.AddRange(salesProducts);
            isAdd = db.SaveChanges();
            if (isAdd > 0)
                return 1;
            return 0;
        }
        public List<SalesProduct> GetProductQ(int ProductID)
        {
            return db.salesProducts.Where(c => c.ProductID == ProductID).ToList();
        }
    }
}

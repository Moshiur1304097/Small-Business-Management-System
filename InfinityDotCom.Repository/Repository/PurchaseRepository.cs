using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InfinityDotCom.Models.Models;
using InfinityDotCom.DatabaseContext.DatabaseContext;

namespace InfinityDotCom.Repository.Repository
{
    public class PurchaseRepository
    {
        InfinityDBContext db = new InfinityDBContext();
        public int Add(List<PurchaseProduct> purchaseProducts)
        {
            int isAdd = 0;

            db.purchaseProducts.AddRange(purchaseProducts);
            isAdd = db.SaveChanges();
            if (isAdd > 0)
                return 1;
            return 0;
        }
        public List<PurchaseProduct> GetProductQ(int ProductID)
        {
            return db.purchaseProducts.Where(c => c.ProductID == ProductID).ToList();  
        }
    }
}

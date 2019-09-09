using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InfinityDotCom.Models.Models;
using InfinityDotCom.Repository.Repository;

namespace InfinityDotCom.BLL.BLL
{
    public class PurchaseManager
    {
        PurchaseRepository _purchaseRepository = new PurchaseRepository();
        public int Add(List<PurchaseProduct> purchaseProducts)
        {
            return _purchaseRepository.Add(purchaseProducts);
        }
        public List<PurchaseProduct> GetProductQ(int ProductID)
        {
            return _purchaseRepository.GetProductQ(ProductID);
        }
    }
}

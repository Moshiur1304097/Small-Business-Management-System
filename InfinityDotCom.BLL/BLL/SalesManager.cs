using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InfinityDotCom.Models.Models;
using InfinityDotCom.Repository.Repository;

namespace InfinityDotCom.BLL.BLL
{
    public class SalesManager
    {
        SalesRepository _salesRepository = new SalesRepository();
        public int Add(List<SalesProduct> salesProducts)
        {
            return _salesRepository.Add(salesProducts);
        }
        public List<SalesProduct> GetProductQ(int ProductID)
        {
            return _salesRepository.GetProductQ(ProductID);
        }
    }
}

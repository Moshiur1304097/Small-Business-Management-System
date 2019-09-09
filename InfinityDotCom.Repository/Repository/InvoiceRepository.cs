using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InfinityDotCom.Models.Models;
using InfinityDotCom.DatabaseContext.DatabaseContext;

namespace InfinityDotCom.Repository.Repository
{
    public class InvoiceRepository
    {
        InfinityDBContext db = new InfinityDBContext();
        public int Add(Invoice invoice)
        {
            int isAdd = 0;

            db.invoices.Add(invoice);
            isAdd = db.SaveChanges();
            if (isAdd > 0)
                return 1;
            return 0;
        }
    }
}

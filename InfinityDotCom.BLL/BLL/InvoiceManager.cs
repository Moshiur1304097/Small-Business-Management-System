using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InfinityDotCom.Models.Models;
using InfinityDotCom.Repository.Repository;

namespace InfinityDotCom.BLL.BLL
{
    public class InvoiceManager
    {
        InvoiceRepository _invoiceRepository = new InvoiceRepository();
        public int Add(Invoice invoice)
        {
            return _invoiceRepository.Add(invoice);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using InfinityDotCom.BLL.BLL;
using InfinityDotCom.Models.Models;
using InfinityDotCom.Models;

namespace InfinityDotCom.Controllers
{
    public class PurchaseController : Controller
    {
        SupplierManager _supplierManager = new SupplierManager();
        ProductManager _productManager = new ProductManager();
        InvoiceManager _invoiceManager = new InvoiceManager();
        PurchaseVM _purchaseVM = new PurchaseVM();
        PurchaseManager _purchaseManager = new PurchaseManager();

        [HttpGet]
        public ActionResult Add()
        {
            _purchaseVM.Suppliers = _supplierManager.GetAll();
            _purchaseVM.Products = _productManager.GetAll();
            return View(_purchaseVM);
        }

        [HttpPost]
        public ActionResult Add(PurchaseVM purchaseVM)
        {
            _invoiceManager.Add(purchaseVM.Invoice);
            _purchaseManager.Add(purchaseVM.PurchaseProducts);

            _purchaseVM.Suppliers = _supplierManager.GetAll();
            _purchaseVM.Products = _productManager.GetAll();
            return View(_purchaseVM);
        }
        public ActionResult GetProductQ(int ProductID)
        {
            var products = _purchaseManager.GetProductQ(ProductID);

            return Json(products);
        }
    }
}
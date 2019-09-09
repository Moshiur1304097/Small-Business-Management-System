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
    public class SalesController : Controller
    {
        CustomerManager _customerManager = new CustomerManager();
        ProductManager _productManager = new ProductManager();
        SalesManager _salesManager = new SalesManager();
        SalesVM salesVM = new SalesVM();

        [HttpGet]
        public ActionResult Index()
        {
            salesVM.Customers = _customerManager.GetAll();
            salesVM.Products = _productManager.GetAll();
            return View(salesVM);
        }
        [HttpPost]
        public ActionResult Index(SalesVM salesVM)
        {
            _salesManager.Add(salesVM.SalesProducts);
            salesVM.Customers = _customerManager.GetAll();
            salesVM.Products = _productManager.GetAll();
            return View(salesVM);
        }

        public ActionResult GetProductQ(int ProductID)
        {
            var products = _salesManager.GetProductQ(ProductID);

            return Json(products);
        }
    }
}
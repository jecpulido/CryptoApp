using Chrypto.ServiceLayer.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Chrypto.WebApp.Controllers
{
    public class ChryptoController : Controller
    {
        private ICurrencyService _currencyService;

        public ChryptoController(ICurrencyService currencyService)
        {
            _currencyService = currencyService;
        }

        // GET: Chrypto
        public ActionResult Index()
        {
            
            return View();
        }

        public JsonResult Get_data()
        {
            var res = _currencyService.GetCurrencys();
            if (res != null && res.Status?.ErrorCode == 0)
                return Json(res.Data, JsonRequestBehavior.AllowGet);

            return Json("Error", JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetExchangeCurrency(int amount, long id, string symbols) {
            var res = _currencyService.GetExchangeCurrency(amount,id, symbols);
            if (res != null)
                return Json(res, JsonRequestBehavior.AllowGet);

            return Json("Error", JsonRequestBehavior.AllowGet);
        }
    }
}
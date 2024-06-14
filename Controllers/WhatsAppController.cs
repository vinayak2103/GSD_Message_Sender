using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WhatsAppApi;
using GSD_Message_Sender.Models;

namespace GSD_Message_Sender.Controllers
{
    public class WhatsAppController : Controller
    {
        // GET: WhatsApp
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult SendMessage(WhatsAppMessageModel model)
        {
            if (ModelState.IsValid)
            {
                string message = $"काकाजी आज रोज तारीख {model.Date} को {model.Item} टन {model.Weight} भाव {model.Rate} डिलेवरी {model.Location} में बेचवाल {model.Seller} ,खरीदार {model.Buyer} का सौदा नोट करना जी";

                if (!string.IsNullOrEmpty(model.Remark))
                {
                    message += $"\n\nनोट: {model.Remark}";
                }

                if (!string.IsNullOrEmpty(model.BrokerName))
                {
                    message += $"\n\nदलाल का नाम: {model.BrokerName}";
                }

                string url = $"https://api.whatsapp.com/send?text={Uri.EscapeDataString(message)}";

                return Json(new { success = true, url = url });
            }
            return Json(new { success = false });
        }
    }
}
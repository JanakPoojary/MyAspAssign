using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PromactAsp.Data;
using PromactAsp.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PromactAsp.Controllers
{
    public class PostmController : Controller
    {
        // ------------------------------------------------------------Coede for posting a new message-----------------------------------------------------------------------
        private readonly PromactAspContext _pcontext;
        public PostmController(PromactAspContext pcontext)
        {
            _pcontext = pcontext;
        }
        
        public IActionResult Postm()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public RedirectToActionResult Postm(Message pm)
        {
            _pcontext.Add(pm);
            _pcontext.SaveChanges();
            return RedirectToAction("Index", "Message", new { area = "" });
        }
        //--------------------------------------------------------code for comment---------------------------------------------------------------------------------------------
        public IActionResult Comment()
        {
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public RedirectToActionResult Comment(int id, Message pm)
        {
            int temp = id;
            _pcontext.Add(pm);
            _pcontext.SaveChanges();
            pm.parentid = temp;
            _pcontext.SaveChanges();
            return RedirectToAction("Index", "Message", new { area = "" });
        }
        //----------------------------------------------------------------------------------------code for sharring-----------------------------------------------------------
        public IActionResult Share()
        {
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public RedirectToActionResult Share(int id, Message pm)
        {
            int temp = id;
            _pcontext.Add(pm);
            _pcontext.SaveChanges();
            pm.shareid = temp;
            _pcontext.SaveChanges();
            return RedirectToAction("Index", "Message", new { area = "" });
        }


        public RedirectToActionResult Like(int id)
        {
            var m = _pcontext.Message.Find(id);
            m.msglikes = m.msglikes + 1;
            _pcontext.SaveChanges();
            return RedirectToAction("Index", "Message", new { area = "" });
        }
    }
}

using And.BilgeMarket.Core.Model;
using And.BilgeMarket.UI.WEB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace And.BilgeMarket.UI.WEB.Controllers
{
    public class CategoryController : AndControllerBase
    {
        // GET: Category
        [Route("Kategori/{isim}/{id}")]
        public ActionResult Index(string isim,int id)
        {
            var db = new AndDB();

            var data = db.Products.Where(x => x.IsActive == true && x.CategoryID == id).ToList();
           ViewBag.category = db.Categories.Where(x => x.ID == id).FirstOrDefault();
            

            return View(data);
        }
    }
}
using System.Collections.Generic;
using System.IO;
using System.Web;
using System.Web.Mvc;
using SGC.Business;
using SGC.Comum.Entities;

namespace SGC.UI.WEB.MVC.Controllers
{
    public class ContatoController : Controller
    {
        public ActionResult Lista()
        {
            return View((new ContatoBusiness().ObtemTodos()));
        } 

        [HttpPost]
        public ActionResult Carrega()
        {
            IEnumerable<Contato> contatoList = null;

            foreach (string fileName in Request.Files)
            {
                HttpPostedFileBase postedFile = Request.Files[fileName];
                var fileNameUp = Server.MapPath("~/Uploads/") + Path.GetFileName(postedFile.FileName);
                postedFile.SaveAs(fileNameUp);

                var contatoBusiness = new ContatoBusiness();
                contatoList = contatoBusiness.LoadFromFile(fileNameUp);
                contatoBusiness.InsereLista(contatoList);
            }

            return View("Lista", contatoList);
        } 

    }
}
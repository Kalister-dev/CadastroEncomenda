using System.Linq;
using System.Web.Mvc;
using CadastroEncomenda.Models;

namespace CadastroEncomenda.Controllers
{
    public class EncomendaController : Controller
    {
        //
        // GET: /Encomenda/

        private static Encomenda _encomenda = new Encomenda();

        public ActionResult Index()
        {
            var encomendas = from e in _encomenda.listaEncomendas
                             select e;

            encomendas = encomendas.OrderByDescending(e => e.Frete);
            return View(encomendas);
        }

        public ActionResult AdicionaEncomenda()
        {
           

            return View();
        }

        [HttpPost]
        public ActionResult AdicionaEncomenda(EncomendaModel __EncomendaModel)
        {


            _encomenda.CriaEncomenda(__EncomendaModel);

            return View();
        }
        public ViewResult DeletaEncomenda(string id)
        {
            return View(_encomenda.GetEncomenda(id));

        }

        [HttpPost]
        public RedirectToRouteResult DeletaEncomenda(string id, FormCollection collection)
        {
            _encomenda.DeletarEncomenda(id);
            return RedirectToAction("Index");
        }
    }
}
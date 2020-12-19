using System.Web.Mvc;
using CadastroEncomenda.Models;

namespace CadastroEncomenda.Controllers
{
    public class Dados_VeiculoController : Controller
    {
        //
        // GET: /Dados/

        private static Dados_Veiculo _dados_veiculo = new Dados_Veiculo();

        public ActionResult Index()
        {
            return View(_dados_veiculo.listaDados);
        }

        public ActionResult AdicionaDados_Veiculo()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AdicionaDados_Veiculo(Dados_VeiculoModel _dadosModel)
        {
            _dados_veiculo.CriaDados_Veiculo(_dadosModel);
            return View();
        }
        public ViewResult DeletaDados(string id)
        {
            return View(_dados_veiculo.GetDados_Veiculo(id));

        }

        [HttpPost]
        public RedirectToRouteResult DeletaDados(string id, FormCollection collection)
        {
            _dados_veiculo.DeletarDados_Veiculo(id);
            return RedirectToAction("Index");
        }
    }
}
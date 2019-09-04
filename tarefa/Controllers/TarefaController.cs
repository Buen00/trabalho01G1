using tarefa.Models;
using Microsoft.AspNetCore.Mvc;

namespace tarefa.Controllers
{
    public class TarefaController : Controller
    {
        CadastroRepository _repository = 
        new CadastroRepository();

        public IActionResult Index()
        {
            var cad1 = _repository.GetAll();          

            return View(cad1);
        }

        public IActionResult Abertas()
        {
            var cad1 = _repository.GetAbertas();          

            return View(cad1);
        }

        public IActionResult Concluidas()
        {
            var cad1 = _repository.GetPorcento();          

            return View(cad1);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Cadastro cad)
        {
            _repository.Create(cad);

            return RedirectToAction("index");
        }

        public IActionResult Delete(int id)
        {
            _repository.Delete(id);
            return RedirectToAction("Index");
        }

        public IActionResult Dell(int percent)
        {
            _repository.Dell(percent);
            return RedirectToAction("Index");
        }

       [HttpGet]
        public IActionResult Edit(int id)
        {
            var per = _repository.GetById(id);
            return View(per);
        }

        [HttpPost]
        public IActionResult Edit(Cadastro cadAlterado)
        {
            _repository.Update(cadAlterado);

            return RedirectToAction("index");
        }
    
    }
}
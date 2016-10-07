using AutoMapper;
using P1DotNetVF.Application.Interface;
using P1DotNetVF.Domain.Entities;
using P1DotNetVF.VisaoMVC.ViewModels;
using System.Collections.Generic;
using System.Web.Mvc;

namespace P1DotNetVF.VisaoMVC.Controllers
{
    public class CorrentistasController : Controller
    {
		private readonly ICorrentistaAppService _correntistaAppService;

		public CorrentistasController(ICorrentistaAppService correntistaAppService)
		{
			_correntistaAppService = correntistaAppService;
		}

		// GET: Correntistas
		public ActionResult Index()
        {
			var correntistaViewModel = Mapper.Map<IEnumerable<Correntista>, IEnumerable<CorrentistaViewModel>>(_correntistaAppService.GetAll());
            return View(correntistaViewModel);
        }

        // GET: Correntistas/Details/5
        public ActionResult Details(int id)
        {
			var correntista = _correntistaAppService.GetByID(id);
			var correntistaViewModel = Mapper.Map<Correntista, CorrentistaViewModel>(correntista);
			return View(correntistaViewModel);

        }

        // GET: Correntistas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Correntistas/Create
        [HttpPost]
		[ValidateAntiForgeryToken]
        public ActionResult Create(CorrentistaViewModel correntista)
        {
			if (ModelState.IsValid)
			{
				var correntistaDomain = Mapper.Map<CorrentistaViewModel, Correntista>(correntista);
				_correntistaAppService.Add(correntistaDomain);
				return RedirectToAction("Index");
			}
			return View(correntista);
		}

        // GET: Correntistas/Edit/5
        public ActionResult Edit(int id)
        {
			var correntista = _correntistaAppService.GetByID(id);
			var correntistaViewModel = Mapper.Map<Correntista, CorrentistaViewModel>(correntista);
			return View(correntistaViewModel);
		}

        // POST: Correntistas/Edit/5
        [HttpPost]
        public ActionResult Edit(CorrentistaViewModel correntista)
        {
			if (ModelState.IsValid)
			{
				var correntistaDomain = Mapper.Map<CorrentistaViewModel, Correntista>(correntista);
				_correntistaAppService.Add(correntistaDomain);
				return RedirectToAction("Index");
			}
			return View(correntista);
		}

        // GET: Correntistas/Delete/5
        public ActionResult Delete(int id)
        {
			var correntista = _correntistaAppService.GetByID(id);
			var correntistaViewModel = Mapper.Map<Correntista, CorrentistaViewModel>(correntista);
			return View(correntistaViewModel);
		}

        // POST: Correntistas/Delete/5
        
		[HttpPost, ActionName("Delete")]
		[ValidateAntiForgeryToken]

		public ActionResult DeleteConfirmed(int id)
        {
			var correntista = _correntistaAppService.GetByID(id);
			_correntistaAppService.Remove(correntista);
			return RedirectToAction("Index");          
		}
    }
}

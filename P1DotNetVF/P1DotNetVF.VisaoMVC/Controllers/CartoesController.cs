using AutoMapper;
using P1DotNetVF.Application.Interface;
using P1DotNetVF.Domain.Entities;
using P1DotNetVF.VisaoMVC.ViewModels;
using System.Collections.Generic;
using System.Web.Mvc;

namespace P1DotNetVF.VisaoMVC.Controllers
{
	public class CartoesController : Controller
	{
		private readonly ICartaoAppService _cartaoAppService;
		private readonly ICorrentistaAppService _correntistaAppService;

		public CartoesController(ICartaoAppService cartaoAppService, ICorrentistaAppService correntistaAppService)
		{
			_cartaoAppService = cartaoAppService;
			_correntistaAppService = correntistaAppService;
		}

		// GET: Cartao
		public ActionResult Index()
		{
			var cartaoViewModel = Mapper.Map<IEnumerable<Cartao>, IEnumerable<CartaoViewModel>>(_cartaoAppService.GetAll());
			return View(cartaoViewModel);
		}

		// GET: Cartao/Details/5
		public ActionResult Details(int id)
		{
			var cartao = _cartaoAppService.GetByID(id);
			var cartaoViewModel = Mapper.Map<Cartao, CartaoViewModel>(cartao);
			return View(cartaoViewModel);

		}

		// GET: Cartao/Create
		public ActionResult Create()
		{
			ViewBag.CorrentistaID = new SelectList(_correntistaAppService.GetAll(), "CorrentistaID", "Nome");
			return View();
		}

		// POST: Cartao/Create
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Create(CartaoViewModel cartao)
		{
			if (ModelState.IsValid)
			{
				var cartaoDomain = Mapper.Map<CartaoViewModel, Cartao>(cartao);
				_cartaoAppService.Add(cartaoDomain);
				return RedirectToAction("Index");
			}
			return View(cartao);
		}

		// GET: Cartao/Edit/5
		public ActionResult Edit(int id)
		{
			var cartao = _cartaoAppService.GetByID(id);
			var cartaoViewModel = Mapper.Map<Cartao, CartaoViewModel>(cartao);
			return View(cartaoViewModel);
		}

		// POST: Cartao/Edit/5
		[HttpPost]
		public ActionResult Edit(CartaoViewModel cartao)
		{
			if (ModelState.IsValid)
			{
				var cartaoDomain = Mapper.Map<CartaoViewModel, Cartao>(cartao);
				_cartaoAppService.Add(cartaoDomain);
				return RedirectToAction("Index");
			}
			return View(cartao);
		}

		// GET: Cartao/Delete/5
		public ActionResult Delete(int id)
		{
			var cartao = _cartaoAppService.GetByID(id);
			var cartaoViewModel = Mapper.Map<Cartao, CartaoViewModel>(cartao);
			return View(cartaoViewModel);
		}

		// POST: Cartao/Delete/5

		[HttpPost, ActionName("Delete")]
		[ValidateAntiForgeryToken]

		public ActionResult DeleteConfirmed(int id)
		{
			var cartao = _cartaoAppService.GetByID(id);
			_cartaoAppService.Remove(cartao);
			return RedirectToAction("Index");
		}
	}
}
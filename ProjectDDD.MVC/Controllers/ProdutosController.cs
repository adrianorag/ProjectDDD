using AutoMapper;
using ProjectDDD.Application.Interface;
using ProjectDDD.Domain.Entities;
using ProjectDDD.MVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectDDD.MVC.Controllers
{
    public class ProdutosController : Controller
    {
        private readonly IClienteAppService _clienteAppService;
        private readonly IProdutoAppService _produtoAppService;


        public ProdutosController(IProdutoAppService produtoAppService, IClienteAppService clienteAppService)
        {
            _produtoAppService = produtoAppService;
            _clienteAppService = clienteAppService;
        }

        // GET: Produtos
        public ActionResult Index()
        {
            var produtoViewModel = Mapper.Map<IEnumerable<Produto>, IEnumerable<ProdutoViewModel>>(_produtoAppService.GetAll());

            return View(produtoViewModel);
        }

        // GET: Produtos/Details/5
        public ActionResult Details(int id)
        {

            var produto = _produtoAppService.GetById(id);
            var produtoViewModel = Mapper.Map<Produto, ProdutoViewModel>(produto);
            return View(produtoViewModel);
        }

        // GET: Produtos/Create
        public ActionResult Create()
        {
            ViewBag.ClienteId = new SelectList(_clienteAppService.GetAll(), "ClienteId", "Nome");

            return View();
        }

        // POST: Produtos/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ProdutoViewModel produtoViewModel)
        {
           
            if (ModelState.IsValid)
            {
                var produto = Mapper.Map<ProdutoViewModel, Produto>(produtoViewModel);
                _produtoAppService.Add(produto);

                return RedirectToAction("Index");
            }
            ViewBag.ClienteId = new SelectList(_clienteAppService.GetAll(), "ClienteId", "Nome", produtoViewModel.ClienteId);
            return View(produtoViewModel);
        }

        // GET: Produtos/Edit/5
        public ActionResult Edit(int id)
        {
            var produto = _produtoAppService.GetById(id);
            var produtoViewModel = Mapper.Map<Produto, ProdutoViewModel>(produto);
            ViewBag.ClienteId = new SelectList(_clienteAppService.GetAll(), "ClienteId", "Nome", produtoViewModel.ClienteId);
            return View(produtoViewModel);
        }

        // POST: Produtos/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ProdutoViewModel produtoViewModel)
        {
            if (ModelState.IsValid)
            {
                var produto = Mapper.Map<ProdutoViewModel, Produto>(produtoViewModel);
                _produtoAppService.Update(produto);

                return RedirectToAction("Index");
            }
            ViewBag.ClienteId = new SelectList(_clienteAppService.GetAll(), "ClienteId", "Nome", produtoViewModel.ClienteId);
            return View(produtoViewModel);
        }

        // GET: Produtos/Delete/5
        public ActionResult Delete(int id)
        {
            var produto = _produtoAppService.GetById(id);
            var produtoViewModel = Mapper.Map<Produto, ProdutoViewModel>(produto);
            
            return View(produtoViewModel);
        }

        // POST: Produtos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {

            var produto = _produtoAppService.GetById(id);
            _produtoAppService.Remove(produto);

            return RedirectToAction("Index");
            
        }
    }
}

﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using NwindMVC.Models;

namespace NwindMVC.Controllers
{
    public class OrderController : Controller
    {
        private RepositoryOrders _repositoryOrders;
        public OrderController(RepositoryOrders repository)
        {
            _repositoryOrders = repository;
        }

        // GET: OrderController
        public ActionResult Index()
        {
            List<int> orderIds = _repositoryOrders.GetAllOrdersId();
            ViewBag.OrderIds = new SelectList(orderIds);
            return View();
        }
        //[HttpPost]
        //public IActionResult GetOrderDetails(int selectedOrderId)
        //{
        //    Order order = _repositoryOrders.FindOrdersById(selectedOrderId);
        //    return PartialView("_OrderDetailsPartial", order);
        //}
        [HttpPost]
        public IActionResult GetOrderDetails(int selectedOrderId)
        {
            Order order = _repositoryOrders.FindOrdersById(selectedOrderId);
            return PartialView("_OrderDetailsPartial", order);
        }

        // GET: OrderController/Details/5
        public ActionResult Details(int id)
        {
            Order order = _repositoryOrders.FindOrdersById(id);
            return View(order);
        }


        // GET: OrderController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: OrderController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: OrderController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: OrderController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: OrderController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: OrderController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}

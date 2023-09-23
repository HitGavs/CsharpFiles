﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVCEFAPP.Model;
using MVCEFAPP.Models;

namespace MVCEFAPP.Controllers
{
    public class AppointmentController : Controller
    {
        // GET: AppointmentController
        public ActionResult Index()
        {
            List<Appointment> appointments = RepositoryAppointment.GetAppointment();
            if (appointments != null && appointments.Count > 0)
                return View(appointments);
            else
                return RedirectToAction("Create");
            
        }

        // GET: AppointmentController/Details/5
        public ActionResult Details(int id)
        {
            Appointment appointment = RepositoryAppointment.GetAppointmentById(id); 
            return View(appointment);
            
        }

        // GET: AppointmentController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AppointmentController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection, Appointment appointment)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    RepositoryAppointment.AddNewAppointment(appointment);
                }
                return RedirectToAction(nameof(Index));
            }
            catch(Exception err)
            {
                return View();
            }
        }

        // GET: AppointmentController/Edit/5
        public ActionResult Edit(int id)
        {
            Appointment appointment = RepositoryAppointment.GetAppointmentById(id);
            return View();
        }

        // POST: AppointmentController/Edit/5
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

        // GET: AppointmentController/Delete/5
        public ActionResult Delete(int id)
        {
            Appointment appointment = RepositoryAppointment.GetAppointmentById(id);
            return View();
        }

        // POST: AppointmentController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    RepositoryAppointment.RemoveAppointment(id);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}

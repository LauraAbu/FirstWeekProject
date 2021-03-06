﻿using FirstWeekProject.Data.Interfaces;
using FirstWeekProject.Data.Models;
using FirstWeekProject.Data.Repository;
using System;
using System.Web.Mvc;

namespace FirstWeekProject.Controllers
{
    public class ContactController : Controller
    {
        private readonly IContactRepository _contactRepository;

        public ContactController()
        {
            _contactRepository = new ContactRepository();
        }

        public ActionResult Index()
        {
            var contacts = _contactRepository.GetAll();

            return View(contacts);

        }

        // GET: Contact/Details/5
        // [Route("contact/{Id}")]
        public ActionResult Details(int id)
        {
            var contact = _contactRepository.GetById(id);

            return View(contact);
        }

        private ActionResult View(object name, int id)
        {
            throw new NotImplementedException();
        }

        // GET: Contact/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Contact/Create
        [HttpPost]
        public ActionResult Create(Contact contact)
        {
            try
            {
                if (!ModelState.IsValid)
                    return View();

                _contactRepository.Create(contact);

                return RedirectToAction("Index", "Home");
            }
            catch
            {
                return View();
            }
        }

        // GET: Contact/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Contact/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Contact/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Contact/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}

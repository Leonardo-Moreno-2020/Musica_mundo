﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Musica_mundo.Models;
namespace Musica_mundo.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario
        public ActionResult Index()
        {
            List<usuario> usuarios = new List<usuario>(); //instanciar la lista de usuarios
            using (musica_mundoEntities users = new musica_mundoEntities()) // instanciando los elementos de la bd
            {
                usuarios = users.usuario.ToList<usuario>(); //consultado todo lo que esta en la tabla usuario

            }


                return View(usuarios);
        }

        // GET: Usuario/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Usuario/Create
        public ActionResult Create()
        {

            return View(new usuario()); // retornando a la vista de usuarios 
        }

        // POST: Usuario/Create
        [HttpPost]
        public ActionResult Create(usuario usuarios)
        {
            using (musica_mundoEntities musica_mundo = new musica_mundoEntities()) //instanciando la bd
            {
                musica_mundo.usuario.Add(usuarios); // adicionar usuarios y los datos del formulario  
                musica_mundo.SaveChanges(); // guardando los cambios en la base de datos
            }
            return RedirectToAction("Index");
        }

        // GET: Usuario/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Usuario/Edit/5
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

        // GET: Usuario/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Usuario/Delete/5
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

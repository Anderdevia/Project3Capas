﻿using BE;
using IdentityServer3.Core.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class CategoriaController : Controller
    {

        // Instancia del gestor de productos desde la capa de negocio
        Proyecto.BL.Categoria gestor = new Proyecto.BL.Categoria();

        // GET: Categoria
        public ActionResult Index()
        {
            return View();
        }
        // Método para mostrar la lista de Categorias 
        public ActionResult Listar()
        {
            // Llama al método Listar() del gestor para obtener la lista de productos
            var Categorias = gestor.Listar();

            // Retorna la vista "Index" con la lista de Categorias como modelo
            return View(Categorias);
        }


        [HttpGet]
        public JsonResult GetComboCategoria()
        {
            var Categorias = gestor.Listar();
            List<Categoria> data = new List<Categoria>();

            foreach (var dr in Categorias)
            {
                Categoria obj = new Categoria()
                {
                    Codigo = int.Parse(dr.Codigo.ToString()), // Asumiendo que el primer elemento de dr es el código
                    Nombre = dr.Nombre.ToString()             // Asumiendo que el segundo elemento de dr es el nombre
                };
                data.Add(obj);
            }

            return Json(data, JsonRequestBehavior.AllowGet);


        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class ProductosController : Controller
    {
        // Instancia del gestor de productos desde la capa de negocio
        Proyecto.BL.Productos gestor = new Proyecto.BL.Productos();

        // Método para mostrar la lista de productos en la vista "Index"
        public ActionResult Index()
        {
            // Llama al método Listar() del gestor para obtener la lista de productos
            var Productos = gestor.Listar();

            // Retorna la vista "Index" con la lista de productos como modelo
            return View(Productos);
        }

        // Método para mostrar la vista de creación de productos
        public ActionResult Crear()
        {
            // Retorna la vista de creación de productos
            return View();
        }


        // Método para mostrar la vista de detalle de productos
        public ActionResult Details(int id)
        {
            // Llama al método Listar(id) del gestor para obtener el producto específico
            BE.Producto productos = gestor.Listar(id);

            return View(productos);
        }


        // Método POST para crear un nuevo producto
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Crear(BE.Producto producto)
        {
            // Llama al método Grabar() del gestor para guardar el nuevo producto
            gestor.Grabar(producto);

            // Redirige al usuario al método "Index" después de crear el producto
            return RedirectToAction("Index");
        }

        // Método para mostrar la vista de edición de productos basado en un ID
        public ActionResult Update(int id)
        {
            // Llama al método Listar(id) del gestor para obtener el producto específico
            BE.Producto productos = gestor.Listar(id);

            // Retorna la vista de edición con el producto como modelo
            return View(productos);
        }

        // Método POST para actualizar un producto
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Update(BE.Producto producto)
        {
            // Llama al método Grabar() del gestor para actualizar el producto
            gestor.Grabar(producto);

            // Redirige al usuario al método "Index" después de actualizar el producto
            return RedirectToAction("Index");
        }

        // Método para mostrar la vista de confirmación de eliminación basado en un ID
        public ActionResult Delete(int id)
        {
            // Llama al método Listar(id) del gestor para obtener el producto específico
            BE.Producto productos = gestor.Listar(id);

            // Retorna la vista de confirmación de eliminación con el producto como modelo
            return View(productos);
        }

        // Método POST para eliminar un producto
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(BE.Producto producto)
        {
            // Llama al método Borrar() del gestor para eliminar el producto
            gestor.Borrar(producto);

            // Redirige al usuario al método "Index" después de eliminar el producto
            return RedirectToAction("Index");
        }
    }
}

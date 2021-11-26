using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Lab14.Controllers
{
    public class CategoriesController : Controller
    {
        #region Contexto
        // ATRIBUTO CONTEXTO
        private NORTHWNDEntities _contexto;

        // PROPIEDAD CONTEXTO
        public NORTHWNDEntities Contexto
        {
            set { _contexto = value; }
            get
            {
                if (_contexto == null)
                    _contexto = new NORTHWNDEntities();
                return _contexto;
            }
        }
        #endregion
        // GET: Categories
        public ActionResult Index()
        {
            return View(Contexto.Categories.ToList());
        }

        // GET: Categories/Details/5
        public ActionResult Details(int id)
        {
            var productosPorcategoria = from p in Contexto.Products
                                        orderby p.ProductName ascending
                                        where p.CategoryID == id
                                        select p;
            return View(productosPorcategoria.ToList());
        }

        // GET: /Categories/Create
        //mostrar formulario
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Categories/Create
        // registrar nueva categoria en la BD
        [HttpPost]
        public ActionResult Create(Categories nuevaCategoria)
        {
            try
            {
                // validamos los datos ingresados
                if (ModelState.IsValid)
                {
                    //registramos la nueva categoria
                    Contexto.Categories.Add(nuevaCategoria);
                    Contexto.SaveChanges();
                    //llamamos al metodo index
                    return RedirectToAction("Index");
                }
                //muestra la vista "create" con datos ingresados
                return View(nuevaCategoria);
            }
            catch
            {
                //muestra la vista "create" vacia
                return View();
            }
        }

        // GET: /Categories/Edit/5
        //muestra formulario para edicion
        public ActionResult Edit(int? id)
        {
            // si el ID es nulo
            if (id == null) // muestra un mensaje de error
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            //buscar la categoria a editar
            Categories CategoriaEditar = Contexto.Categories.Find(id);

            // si entidad es NULO (categoria no existe)
            if (CategoriaEditar == null)
                return HttpNotFound();

            // envia la cateogira a editar a la vista
            return View(CategoriaEditar);
        }

        // POST: /Categories/Edit/5
        //registrar cambios de la categoria en la BD
        [HttpPost]
        public ActionResult Edit(Categories CategoriaEditar)
        {
            try
            {//validamos los datos ingresados
                if (ModelState.IsValid)
                {// graba los cambios de la categoria
                    Contexto.Entry(CategoriaEditar).State = System.Data.Entity.EntityState.Modified;
                    Contexto.SaveChanges();

                    // llama al metodo index
                    return RedirectToAction("Index");
                }
                //muestra la vista Edit con los datos ingresados
                return View(CategoriaEditar);
            }
            catch
            {// muestra la vista Edit vacia
                return View();
            }
        }

        // GET: /categories/Delete/5
        public ActionResult Delete(int? id)
        {
            // si el ID es nulo
            if (id == null) // muestra un mensaje de error
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            Categories CategoriaEliminar = Contexto.Categories.Find(id);
            // Valida que categoria existe
            if (CategoriaEliminar == null)
                return HttpNotFound();

            // envia la cateogira a eliminar a la vista
            return View(CategoriaEliminar);
        }

        // POST: /Categories/Delete/5        
        [HttpPost]
        public ActionResult Delete(int? id, Categories Categoria1)
        {
            try
            {
                Categories CategoriaEliminar = new Categories();
                if (ModelState.IsValid)
                {
                    if (id == null)
                        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                    CategoriaEliminar = Contexto.Categories.Find(id);
                    if (CategoriaEliminar == null)
                        return HttpNotFound();
                    Contexto.Categories.Remove(CategoriaEliminar);
                    Contexto.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(CategoriaEliminar);
            }
            catch
            {
                return View();
            }
        }
        // ********* PRODUCTS *********
        // GET: /Categories/CreateProduct
        //mostrar formulario
        public ActionResult CreateProduct()
        {
            return View();
        }

        // POST:/Categories/CreateProduct
        // registrar nueva categoria en la BD
        [HttpPost]
        public ActionResult CreateProduct(Products nuevoProducto)
        {
            try
            {
                // validamos los datos ingresados
                if (ModelState.IsValid)
                {
                    //registramos el nuevo producto
                    Contexto.Products.Add(nuevoProducto);
                    Contexto.SaveChanges();
                    //llamamos al metodo index
                    return RedirectToAction("Details/" + nuevoProducto.CategoryID);
                }
                //muestra la vista "create" con datos ingresados
                return View(nuevoProducto);
            }
            catch
            {
                //muestra la vista "create" vacia
                return View();
            }
        }

        // GET: /Categories/EditProduct/5
        //muestra formulario para edicion
        public ActionResult EditProduct(int? id)
        {
            // si el ID es nulo
            if (id == null) // muestra un mensaje de error
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            //buscar el producto a editar
            Products ProductEditar = Contexto.Products.Find(id);

            // si entidad es NULO (producto no existe)
            if (ProductEditar == null)
                return HttpNotFound();

            // envia el producto a editar a la vista
            return View(ProductEditar);
        }

        // POST: /Categories/Edit/5
        //registrar cambios del producto en la BD
        [HttpPost]
        public ActionResult EditProduct(Products ProductEditar)
        {
            try
            {//validamos los datos ingresados
                if (ModelState.IsValid)
                {// graba los cambios del producto
                    Contexto.Entry(ProductEditar).State = System.Data.Entity.EntityState.Modified;
                    Contexto.SaveChanges();

                    // llama al metodo index
                    return RedirectToAction("Details/" + ProductEditar.CategoryID);
                }
                //muestra la vista Edit con los datos ingresados
                return View(ProductEditar);
            }
            catch
            {// muestra la vista Edit vacia
                return View();
            }
        }

        // GET: /categories/Delete/5
        public ActionResult DeleteProduct(int? id)
        {
            // si el ID es nulo
            if (id == null) // muestra un mensaje de error
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            Products ProductoEliminar = Contexto.Products.Find(id);

            if (ProductoEliminar == null)
                return HttpNotFound();

            return View(ProductoEliminar);
        }

        // POST: /Categories/Delete/5        
        [HttpPost]
        public ActionResult DeleteProduct(int? id, Products Producto1)
        {
            try
            {
                Products ProductoEliminar = new Products();
                if (ModelState.IsValid)
                {
                    if (id == null)
                        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                    ProductoEliminar = Contexto.Products.Find(id);
                    if (ProductoEliminar == null)
                        return HttpNotFound();
                    Contexto.Products.Remove(ProductoEliminar);
                    Contexto.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(ProductoEliminar);
            }
            catch
            {
                return View();
            }
        }
    }
}
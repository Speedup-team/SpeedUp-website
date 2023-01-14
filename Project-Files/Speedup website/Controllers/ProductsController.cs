using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Speedup_website.Entitys.Products;
using Speedup_website.Data;

namespace Speedup_website.Controllers
{
    public class ProductsController : Controller
    {
        public IRepository<Product> ProductsRepository { get; set; }

        public ProductsController(IRepository<Product> productsRepository)
        {
            ProductsRepository = productsRepository;

        }

        // GET: ProductsController
        public ActionResult Index() => View(ProductsRepository.List());

        // GET: ProductsController/Details/5
        public ActionResult Details(int id) => View(ProductsRepository.Find(id));

        // GET: ProductsController/Create
        public ActionResult Create() => View();

        // POST: ProductsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Product product)
        {
            try
            {
                ProductsRepository.Add(product);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductsController/Edit/5
        public ActionResult Edit(int id) => View(ProductsRepository.Find(id));

        // POST: ProductsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Product product)
        {
            try
            {
                ProductsRepository.Update(id, product);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductsController/Delete/5
        public ActionResult Delete(int id) => View(ProductsRepository.Find(id));

        // POST: ProductsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                ProductsRepository.Delete(id);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
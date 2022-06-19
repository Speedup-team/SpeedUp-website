using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Speedup_website.Data;
using Speedup_website.Data.Repositorys;
using Speedup_website.Entitys.Orders;
using Speedup_website.Entitys.Products;

namespace Speedup_website.Controllers;
public class HomeController : Controller
{
    private readonly SpeedupWebsiteDBContext _dbContext = new SpeedupWebsiteDBContext(new DbContextOptions<SpeedupWebsiteDBContext>());

    private readonly DbSet<Product> products;

    private readonly DbSet<ShoppingSassion> ShoppingSassion;

    public HomeController()
    {
        products=_dbContext.Set<Product>();
        ShoppingSassion=_dbContext.Set<ShoppingSassion>();
    }

    // GET: HomeController
    public IActionResult Index()
    {
        IEnumerable<Product> products = this.products.ToList();

        return View(products);
    }

    // GET: HomeController/Details/5
    public IActionResult ProductDetails(int id) => View(products.Find(id));

    public void AddToCart(int id)
    {

    }
}
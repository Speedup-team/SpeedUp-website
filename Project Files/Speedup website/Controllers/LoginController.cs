using Microsoft.AspNetCore.Mvc;
using Speedup_website.Data;
using Speedup_website.Entitys.People;

namespace Speedup_website.Controllers;

public class LoginController : Controller
{
    GenericRepository<User> usersRepository;

    IActionResult returnAction;

    public LoginController(IActionResult action)
    {
        usersRepository = new GenericRepository<User>();
        returnAction = action;
    }

    public IActionResult Index() => View();

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Login(Speedup_website.ViewModels.LoginViewModel viewModel)
    {
        Type userType = typeof(User);

        if (ModelState.IsValid)
        {
            User? user = usersRepository.Search(viewModel.userName, new System.Reflection.PropertyInfo[] { userType.GetProperty(nameof(userType.Name)) })[0];

            if (user != null)
            {
                if (user.password == viewModel.password)
                    return View(returnAction);

                ModelState.AddModelError("Error", "Password Not correct");
                return View();
            }
            ModelState.AddModelError("Error", "User Name not found");
            return View();
        }
        ModelState.AddModelError("Error", "Some fields gets an error");

        return View();
    }
}
using Microsoft.AspNetCore.Mvc;
using VideoCardsStore.Models;

namespace VideoCardsStore.Controllers
{
    public class HomeController : Controller
    {
        private IStoreRepository repository;

        public HomeController(IStoreRepository repo)
        {
            repository = repo;
        }

        public IActionResult Index()
        {
            return View(repository.Products);
        }
    }
}

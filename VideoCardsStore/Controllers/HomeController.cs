using Microsoft.AspNetCore.Mvc;
using VideoCardsStore.Models;
using VideoCardsStore.Models.ViewModels;

namespace VideoCardsStore.Controllers
{
    public class HomeController : Controller
    {
        private IStoreRepository repository;
        public int PageSize = 4;

        public HomeController(IStoreRepository repo)
        {
            repository = repo;
        }

        public ViewResult Index(string category, int productPage = 1)
         => View(new ProductsListViewModel
         {
             Products = repository.Products
                 .Where(p => category == null || p.Category == category)
                 .OrderBy(p => p.ProductId)
                 .Skip((productPage - 1) * PageSize)
                 .Take(PageSize),
             PagingInfo = new PagingInfo
             {
                 CurrentPage = productPage,
                 ItemsPerPage = PageSize,
                 TotalItems = repository.Products.Count()
             },
             CurrentCategory = category
         });
    }
}

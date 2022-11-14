using System.Collections.Generic;
using VideoCardsStore.Models;

namespace VideoCardsStore.Models.ViewModels {

    public class ProductsListViewModel {
        public IEnumerable<Product> Products { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}

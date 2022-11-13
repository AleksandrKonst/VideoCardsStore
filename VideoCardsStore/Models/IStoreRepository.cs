using System.Linq;

namespace VideoCardsStore.Models {
    public interface IStoreRepository {

        IQueryable<Product> Products { get; }
    }
}

using SportsStore.Domain.Entites;
using System.Collections.Generic;


namespace SportsStore.Domain.Abstract
{
    public interface IProductsRepository
    {
        IEnumerable<Product> Products { get; }
    }
}

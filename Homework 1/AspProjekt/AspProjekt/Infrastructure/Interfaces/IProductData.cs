using System.Collections.Generic;
using WebStore.Domain.Models;
using WebStore.Domain.Filters;

namespace AspProjekt.Infrastructure.Interfaces
{
    public  interface IProductData
    {
        IEnumerable<Section> GetSections();
        IEnumerable<Brand> GetBrands();

        IEnumerable<Product> GetProducts(ProductFilter filter);

    }
}

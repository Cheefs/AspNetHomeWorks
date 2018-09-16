using System;
using System.Collections.Generic;
using System.Linq;
using WebStore.Domain.Models;
using AspProjekt.Infrastructure.Interfaces;
using WebStore.Domain.Filters;

namespace AspProjekt.Infrastructure.Implementations
{
    public class ProductData : IProductData
    {
        private readonly List<Section> _sections;
        private readonly List<Brand> _brands;
        private readonly List<Product> _products;

        private Section NewSection( int id, string Name, int order, int? parentId)
        {
            return new Section { Id = id, Name = Name, Order = order, ParentId = parentId };
        }

        private Brand NewBrand(int id, string Name, int order)
        {
            return new Brand { Id = id, Name = Name, Order = order};
        }

        private Product NewProduct(int id, string Name, int price, string immage, int order, int sectionId, int brandId)
        {
            return new Product { Id = id, Name = Name, Price = price, ImageUrl = immage, Order = order, SectionId = sectionId, BrandId = brandId };
        }

        public ProductData()
        {
            _sections = new List<Section>()
            {

                NewSection(1, "Sportswear",0,null),
                NewSection(2, "Nike", 0, 0),
                NewSection(3, "Under Armour", 1, 1),
                NewSection(4, "Adidas", 2, 1),
                NewSection(5, "Puma", 3, 1),
                NewSection(6, "ASICS", 4, 1),

                NewSection(7, "Mens", 1, null),
                NewSection(8, "Fendi", 0, 7),
                NewSection(9, "Guess", 1, 7),
                NewSection(10, "Valentino", 2, 7),
                NewSection(11, "Dior", 3, 7),
                NewSection(12, "Versace", 4, 7),
                NewSection(13, "Armani", 5, 7),
                NewSection(14, "Prada", 6, 7),
                NewSection(15, "Dolce and Gabbana", 7, 7),
                NewSection(16, "Chanel", 8, 7),
                NewSection(17, "Gucci", 1, 7),

                NewSection(18, "Womens", 2, null),
                NewSection(19, "Fendi", 0, 18),
                NewSection(20, "Guess", 1, 7),
                NewSection(21, "Valentino", 2, 18),
                NewSection(22, "Dior", 3, 7),
                NewSection(23, "Versace", 4, 18),

                NewSection(24, "Kids", 3, null),
                NewSection(25, "Fasion", 4, null),

                NewSection(26, "Interiors", 6, null),
                NewSection(27, "Clothing", 7, null),
                NewSection(28, "Bags", 8, null),
                NewSection(29, "Shoes", 9, null),

            };


            _brands = new List<Brand>()
            {
                NewBrand(1,"Acne", 0 ),

                NewBrand(2,"Grüne Erde", 1 ),
                NewBrand(3,"Albiro", 2 ),
                NewBrand(4,"Ronhill", 3 ),
                NewBrand(5,"Oddmolly", 4 ),
                NewBrand(6,"Boudestijn", 5 ),
                NewBrand(7,"Rösch creative culture", 6 ), 
            };

            _products = new List<Product>()
            {
               NewProduct(1,"Easy Polo Black Edition", 1025, "product1.jpg", 0, 2, 1),
               NewProduct(2,"Easy Polo Black Edition", 1025, "product2.jpg", 1, 2, 1),
               NewProduct(3,"Easy Polo Black Edition", 1025, "product3.jpg", 2, 2, 1),
               NewProduct(4,"Easy Polo Black Edition", 1025, "product4.jpg", 3, 2, 1),
               NewProduct(5,"Easy Polo Black Edition", 1025, "product5.jpg", 4, 2, 2),
               NewProduct(6,"Easy Polo Black Edition", 1025, "product6.jpg", 5, 2, 2),
               NewProduct(7,"Easy Polo Black Edition", 1025, "product7.jpg", 6, 2, 2),
               NewProduct(8,"Easy Polo Black Edition", 1025, "product8.jpg", 7, 25, 2),
               NewProduct(9,"Easy Polo Black Edition", 1025, "product9.jpg", 8, 25, 2),
               NewProduct(10,"Easy Polo Black Edition", 1025, "product10.jpg", 9, 25, 3),
               NewProduct(11,"Easy Polo Black Edition", 1025, "product11.jpg", 10, 25, 3),
               NewProduct(12,"Easy Polo Black Edition", 1025, "product12.jpg", 11, 25, 3),
            };
        }

        public IEnumerable<Section> GetSections()
        {
            return _sections;
        }

        public IEnumerable<Brand> GetBrands()
        {
            return _brands;
        }

        public IEnumerable<Product> GetProducts(ProductFilter filter)
        {
            var products = _products;
            if (filter.SectionId.HasValue)
                products = products.Where(p => p.SectionId.Equals(filter.SectionId)).ToList();
            if (filter.BrandId.HasValue)
                products = products.Where(p => p.BrandId.HasValue && p.BrandId.Value.Equals(filter.BrandId.Value)).ToList();
            return products;
        }
    }
}


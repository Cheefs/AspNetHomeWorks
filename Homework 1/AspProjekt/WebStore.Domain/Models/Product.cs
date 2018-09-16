using WebStore.Domain.Models.Base;

namespace WebStore.Domain.Models
{
    public class Product: NameEntity , IOrderEntity
    {
        public int Order { get; set; }

        public int SectionId { get; set; }

        public int? BrandId { get; set; }

        public string ImageUrl { get; set; }

        public decimal Price { get; set; }
    }
}

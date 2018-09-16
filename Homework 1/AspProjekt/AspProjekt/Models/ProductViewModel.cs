using WebStore.Domain.Models.Base;

namespace AspProjekt.Models
{
    public class ProductViewModel : INameEntity, IOrderEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Order { get; set; }
        public string ImageUrl { get; set; }
        public decimal Price { get; set; }
    }

}

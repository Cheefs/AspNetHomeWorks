using WebStore.Domain.Models.Base;

namespace AspProjekt.Models
{
    public class BrandViewModel : INameEntity, IOrderEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ProductsCount { get; set; }
        public int Order { get; set; }
    }

}


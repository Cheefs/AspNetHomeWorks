using WebStore.Domain.Models.Base;

namespace WebStore.Domain.Models
{
    public class Section: NameEntity, IOrderEntity
    {
        public int? ParentId { get; set; }

        public int Order { get; set;  }
    }
}

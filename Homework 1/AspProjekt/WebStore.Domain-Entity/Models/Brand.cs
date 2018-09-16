using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using WebStore.Domain.Models.Base;

namespace WebStore.Domain.Models
{
    [Table("Brands")]
    public class Brand : NameEntity, IOrderEntity
    {
        public int Order { get; set; }
        public virtual ICollection<Product> Products { get; set; }

    }
}

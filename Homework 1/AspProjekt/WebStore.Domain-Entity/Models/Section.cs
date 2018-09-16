using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using WebStore.Domain.Models.Base;

namespace WebStore.Domain.Models
{
    [Table("Sections")]
    public class Section: NameEntity, IOrderEntity
    {
        public int? ParentId { get; set; }

        public int Order { get; set;  }

        [ForeignKey("ParentId")]
        public virtual Section ParentSection { get; set; }

        public virtual ICollection<Product> Products { get; set; }

    }
}

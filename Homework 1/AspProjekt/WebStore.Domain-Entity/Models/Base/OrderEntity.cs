namespace WebStore.Domain.Models.Base
{
   public class OrderEntity: NameEntity, IOrderEntity
    {
        public int Order { get; set; }
    }
}

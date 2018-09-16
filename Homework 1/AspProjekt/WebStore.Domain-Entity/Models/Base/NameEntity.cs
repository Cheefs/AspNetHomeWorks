namespace WebStore.Domain.Models.Base
{
   public class NameEntity:BaseEntity , INameEntity
    {
        public string Name { get; set; }
    }
}

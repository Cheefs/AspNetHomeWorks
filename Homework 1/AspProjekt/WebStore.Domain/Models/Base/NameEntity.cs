namespace WebStore.Domain.Models.Base
{
   public class NameEntity:BaseEntity , INameEntity
    {
       // public int Id { get; set; }
        public string Name { get; set; }
    }
}

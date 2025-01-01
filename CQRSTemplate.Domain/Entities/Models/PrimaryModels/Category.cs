namespace CQRSTemplate.Domain.Entities.Models.PrimaryModels
{
    public class Category
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public List<Category> ChildCategories { get; set; }
    }
}

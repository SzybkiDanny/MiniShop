namespace Catalog.Entities;

public class Category
{
    public Guid Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;
     
    public Category? ParentCategory { get; set; } = null!;
     
    public ICollection<Category> SubCategories { get; set; } = new List<Category>();
    
    public ICollection<Product> Products { get; set; } = new List<Product>();
}
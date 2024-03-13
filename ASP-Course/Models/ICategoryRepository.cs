namespace ASP_Course.Models
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> AllCategories { get; }
    }
}

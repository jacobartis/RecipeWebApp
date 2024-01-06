using Microsoft.EntityFrameworkCore;

namespace RecipeApp.Data
{
    public class RecipeContext : DbContext
    {
        public RecipeContext(DbContextOptions<RecipeContext> options) : base(options)
        {
        }
    }
}
using RecipeApp.Data;
using RecipeApp.Models;

namespace RecipeApp.Services
{
    public class RecipeService
    {
        private readonly RecipeContext _context = default!;

        public RecipeService(RecipeContext context)
        {
            context.Database.EnsureCreated();
            
            if (context.Recipes !=null && !context.Recipes.Any())
            {
                context.Recipes.Add(new Recipe {Title = "Jam on Toast" });
                context.Recipes.Add(new Recipe {Title = "Tomato Soup" });
                context.SaveChanges();
            }
            _context = context;
        }

        //ToDo replace with real method.
        public IList<Recipe> GetRecipes()
        {
            if (_context.Recipes == null) return new List<Recipe>();
            return _context.Recipes.ToList();
        }

        public IList<Recipe> GetRecipesWithName(String name)
        {
            if (_context.Recipes == null) return new List<Recipe>();
            return _context.Recipes.Where(recipe => recipe.Title!=null && recipe.Title.ToLower().Contains(name.ToLower()) ).ToList();
        }
    }
}
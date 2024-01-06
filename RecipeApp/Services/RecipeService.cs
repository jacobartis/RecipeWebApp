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
                context.Recipes.Add(new Recipe {Title = "Jam on Toast", CookTimeMins = 2, PrepTimeMins = 0, Servings= 2, Instructions = ["Toast bread.","Butter toast.", "Spread jam on toast."] });
                context.Recipes.Add(new Recipe {Title = "Tomato Soup" , CookTimeMins = 5, PrepTimeMins = 1, Servings= 1, Instructions = ["Open soup can.","Microwave soup."] });
                context.SaveChanges();
            }
            _context = context;
        }
        
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

        public Recipe? GetRecipeById(int Id){
            if (_context.Recipes == null) return null;
            return _context.Recipes.FirstOrDefault(recipe => recipe.Id==Id);
        }
    }
}
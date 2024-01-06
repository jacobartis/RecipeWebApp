using RecipeApp.Data;

namespace RecipeApp.Services
{
    public class RecipeService
    {
        private readonly RecipeContext _context = default!;

        public RecipeService(RecipeContext context)
        {
            _context = context;
        }

        //ToDo replace with real method.
        public string GetRecipes()
        {
            return "Got recipes";
        }
    }
}
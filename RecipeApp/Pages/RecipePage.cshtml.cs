using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RecipeApp.Pages{
    public class RecipePageModel: PageModel{
        private readonly ILogger<RecipePageModel> _logger;
        public String? Recipe;
        public RecipePageModel(ILogger<RecipePageModel> logger){
            _logger = logger;
        }

        public void OnGet(String recipe){
            Recipe = recipe;
        }
    }
}
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RecipeApp.Models;
using RecipeApp.Services;

namespace RecipeApp.Pages{
    public class RecipePageModel: PageModel{
        private readonly RecipeService _service;
        public Recipe? Recipe;
        public RecipePageModel(RecipeService service){
            _service = service;
        }

        public IActionResult OnGet(int recipeId){
            Recipe = _service.GetRecipeById(recipeId);
            if (Recipe == null){
                return NotFound();
            }
            return Page();
        }
    }
}
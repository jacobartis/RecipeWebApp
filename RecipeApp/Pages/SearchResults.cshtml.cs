using Microsoft.AspNetCore.Mvc.RazorPages;
using RecipeApp.Services;
using RecipeApp.Models;

namespace RecipeApp.Pages{
    public class SearchResultsModel: PageModel{
        private readonly RecipeService _service;
        public String? SearchInput;
        public IList<Recipe> RecipeList {get; set;} = default!;

        public SearchResultsModel(RecipeService service){
            _service = service;
        }

        public void OnGet(String searchInput){
            SearchInput = searchInput;
            RecipeList = _service.GetRecipes();
        }
    }
}
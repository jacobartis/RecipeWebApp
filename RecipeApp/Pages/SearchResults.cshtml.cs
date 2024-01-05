using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RecipeApp.Pages{
    public class SearchResultsModel: PageModel{
        private readonly ILogger<IndexModel> _logger;

        public SearchResultsModel(ILogger<IndexModel> logger){
            _logger = logger;
        }

        public void OnGet(){
            
        }
    }
}
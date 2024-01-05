using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RecipeApp.Pages{
    public class SearchResultsModel: PageModel{
        private readonly ILogger<SearchResultsModel> _logger;
        public String? SearchInput;
        public SearchResultsModel(ILogger<SearchResultsModel> logger){
            _logger = logger;
        }

        public void OnGet(String searchInput){
            SearchInput = searchInput;
        }
    }
}
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RecipeApp.Pages{
    public class ErrorModel: PageModel{
        private readonly ILogger<ErrorModel> _logger;

        public ErrorModel(ILogger<ErrorModel> logger){
            _logger = logger;
        }

        public void OnGet(){
            
        }
    }
}
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RecipeApp.Pages{
    public class AccountModel: PageModel{
        private readonly ILogger<AccountModel> _logger;
        public String? Account;
        public AccountModel(ILogger<AccountModel> logger){
            _logger = logger;
        }

        public void OnGet(String account){
            Account = account;
        }
    }
}
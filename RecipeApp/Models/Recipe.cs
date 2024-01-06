using System.ComponentModel.DataAnnotations;

namespace RecipeApp.Models
{
    public class Recipe
    {
        public int Id {get; set;}

        [Required]
        public string? Title {get; set;}
        public int Servings {get; set;}
        public int CookTimeMins {get; set;}
        public int PrepTimeMins {get; set;}
        public IList<String>? Instructions {get; set;}
    }

}
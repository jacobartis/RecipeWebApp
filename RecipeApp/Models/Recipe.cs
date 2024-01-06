using System.ComponentModel.DataAnnotations;

namespace RecipeApp.Models
{
    public class Recipe
    {
        public int Id {get; set;}

        [Required]
        public string? Title {get; set;}
        //ToDo: Add more data beyond test title
    }

}
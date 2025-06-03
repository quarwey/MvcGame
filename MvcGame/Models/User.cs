using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace MvcGame.Models
{
    public class User
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Number { get; set; }
    }
}

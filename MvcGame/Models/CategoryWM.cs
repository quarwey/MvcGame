using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace MvcGame.Models;

public class ItemGenreViewModel
{
    public List<Game>? Items { get; set; }
    public SelectList? Categories { get; set; }
    public string? ItemsCategories { get; set; }
    public string? SearchString { get; set; }
}
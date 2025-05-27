using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcGame.Models;

public class Game
{
    public int Id { get; set; }
    public int Item { get; set; }
    [StringLength(60, MinimumLength = 2)]
    [Required]
    public string? Category { get; set; }
    [StringLength(60, MinimumLength = 2)]
    [Required]
    public string? User { get; set; }
    [Range(0, 99999)]
    public int Cost { get; set; }
}
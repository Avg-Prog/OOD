using System.ComponentModel.DataAnnotations;
using Ucll.OOD.Validations.Models.Validators;

namespace Ucll.OOD.Validations.Models;

public class Book
{
    public int Id { get; set; }
    [Required]
    public string? Name { get; set; }
    [Required]
    [StringLength(13)]
    [ISBN]
    public string? ISBN13 { get; set; }
    [Required]
    [StringLength(10)]
    [ISBN]
    public string? ISBN10 { get; set; }
    [Required]
    public string? Author { get; set; }
    [Required]
    [Year]
    public int? Releaseyear { get; set; }
}

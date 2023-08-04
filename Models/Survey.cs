#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace _7_Dojo_Survey_with_Validations.Models;

public class Survey
{
    [Required]
    [MinLength(2, ErrorMessage = "Name required at least 2 chars")]
    public string Name { get; set; }
    [Required]
    public string Location { get; set; }
    [Required]    
    public string Language { get; set; }
    [MinLength(20, ErrorMessage = "Min character length is 20 chars")]
    public string? Comment { get; set; }
}
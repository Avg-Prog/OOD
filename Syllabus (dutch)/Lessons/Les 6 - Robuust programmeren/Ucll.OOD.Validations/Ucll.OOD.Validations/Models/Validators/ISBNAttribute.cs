using System.ComponentModel.DataAnnotations;

namespace Ucll.OOD.Validations.Models.Validators;

public class ISBNAttribute : ValidationAttribute
{
    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
        var book = validationContext.ObjectInstance as Book;
        if (book == null) return null;

        if(book.ISBN13.Equals($"978{book.ISBN10}", StringComparison.InvariantCultureIgnoreCase))
        {
            return ValidationResult.Success;
        }

        return new ValidationResult("ISBN10 and ISBN13 do not match");
    }
}

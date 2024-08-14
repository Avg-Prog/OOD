using System.ComponentModel.DataAnnotations;

namespace Ucll.OOD.Validations.Models.Validators;

public class YearAttribute : ValidationAttribute
{
    public override bool IsValid(object? value)
    {
        var year = value as int?;
        if (year == null) return false;

        return year >= 1800 && year <= DateTime.Now.Year;
    }

    public override string FormatErrorMessage(string name)
    {
        return $"{name} should be between 1800 and {DateTime.Now.Year}";
    }
}

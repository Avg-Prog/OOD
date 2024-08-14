namespace Ucll.OOD.TDD;

public static class PasswordValidator
{
    public static bool Validate(string password)
    {
        return password.Length >= 8 &&
            password.Any(char.IsDigit) &&
            password.Any(char.IsUpper) &&
            password.Any(char.IsLower);
    }
}

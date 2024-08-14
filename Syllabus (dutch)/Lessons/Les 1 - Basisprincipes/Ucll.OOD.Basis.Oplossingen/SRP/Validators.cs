namespace SRP;

internal static class Validators
{
    public static bool ValidateSSN(string ssn)
    {
        if (ssn.Length == 11)
        {
            if (int.TryParse(ssn.Substring(0, 9).ToString(), out int firstNine))
            {
                if (int.TryParse(ssn.Substring(9).ToString(), out int checkNumber))
                {
                    int remainder = firstNine % 97;
                    if (97 - remainder == checkNumber)
                    {
                        return true;
                    }
                }
            }
        }
        return false;
    }
}

namespace OCP;

internal class TotalIncomeCalculator
{
    internal static int CalculateTotal(int nettIncome, int nightPremium, int weekendPremium)
    {
        return nettIncome + nightPremium + weekendPremium;
    }
}

namespace OCP
{
    internal class TotalIncomeCalculator
    {
        internal static int CalculateTotal(List<int> incomes)
        {
            int result = 0;
            foreach (var income in incomes)
            {
                result += income;
            }
            return result;
        }
    }
}

using OCP;

List<int> listOfIncomes = new List<int>();
listOfIncomes.Add(100);
listOfIncomes.Add(100);
listOfIncomes.Add(100);

var totalIncome = TotalIncomeCalculator.CalculateTotal(listOfIncomes);
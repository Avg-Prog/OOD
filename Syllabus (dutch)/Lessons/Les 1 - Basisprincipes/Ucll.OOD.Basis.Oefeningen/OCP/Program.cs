using OCP;

//CalculateTotal will receive multiple incomes in the future
//How can we adjust the method to make sure we don't have to change it each time this happens?
var totalIncome = TotalIncomeCalculator.CalculateTotal(1000, 100, 100);
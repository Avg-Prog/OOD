namespace UnitTesting;

public class ComplexCalculator
{
    public int CalculateTotal(int start, bool extraComplexity)
    {
        if (extraComplexity)
        {
            if (start <= 0)
                return -1;
            else
                return start + 26;
        }
        else
        {
            if (start <= 0)
                return 0;
            else
                return start + 20;
        }
    }

    public CalculatorResult CalculateCalculatorResult(int start, bool type)
    {
        if (start < 0)
            throw new ArgumentOutOfRangeException("Start can't be below zero"); 

       
        if (type)
        {
            return new CalculatorResult { Description = "My Result", Result = start + 5 };

        }
        return new CalculatorResult { Description = "Another Result", Result = start - 5 };
    }
}
    
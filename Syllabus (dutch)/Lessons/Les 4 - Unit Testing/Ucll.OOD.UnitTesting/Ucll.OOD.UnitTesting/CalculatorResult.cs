namespace UnitTesting;

public class CalculatorResult
{
    public string Description { get; set; }
    public int Result { get; set; }

    public override bool Equals(object? obj)
    {
        var caculatorResult = obj as CalculatorResult;
        if (caculatorResult is null) return false;

        return caculatorResult.Description == Description &&
            caculatorResult.Result == Result;
    }
}

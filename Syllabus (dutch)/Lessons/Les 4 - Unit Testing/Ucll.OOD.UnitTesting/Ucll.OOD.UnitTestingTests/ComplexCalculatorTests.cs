using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting.Tests;

[TestClass()]
public class ComplexCalculatorTests
{
    private ComplexCalculator _calculator;

    public ComplexCalculatorTests()
    {
        _calculator = new ComplexCalculator();
    }

    [TestMethod()]
    public void CalculateTotalStartNegativeComplexTrueTest()
    {
        Assert.AreEqual(-1, _calculator.CalculateTotal(-5, true));
    }
    [TestMethod()]
    public void CalculateTotalStartZeroComplexTrueTest()
    {
        Assert.AreEqual(-1, _calculator.CalculateTotal(0, true));
    }
    [TestMethod()]
    public void CalculateTotalStartPositiveComplexTrueTest()
    {
        Assert.AreEqual(31, _calculator.CalculateTotal(5, true));
    }
    [TestMethod()]
    public void CalculateTotalStartNegativeComplexFalseTest()
    {
        Assert.AreEqual(0, _calculator.CalculateTotal(-5, false));
    }
    [TestMethod()]
    public void CalculateTotalStartZeroComplexFalseTest()
    {
        Assert.AreEqual(0, _calculator.CalculateTotal(0, false));
    }
    [TestMethod()]
    public void CalculateTotalStartPositiveComplexFalseTest()
    {
        Assert.AreEqual(25, _calculator.CalculateTotal(5, false));
    }

    [TestMethod()]
    public void CalculateCalculatorResultTestTypeTrue()
    {
        var correct = new CalculatorResult
        {
            Description = "My Result",
            Result = 10
        };
        Assert.AreEqual(correct, _calculator.CalculateCalculatorResult(5, true));
    }

    [TestMethod()]
    public void CalculateCalculatorResultTestException()
    {
        Assert.ThrowsException<ArgumentOutOfRangeException>(() => _calculator.CalculateCalculatorResult(-5, true));
    }
}
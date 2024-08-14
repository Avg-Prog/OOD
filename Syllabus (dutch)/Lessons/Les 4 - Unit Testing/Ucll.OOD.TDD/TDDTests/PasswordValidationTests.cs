using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ucll.OOD.TDD;

namespace TDDTests;

[TestClass]
public class PasswordValidationTests
{
    [TestMethod]
    public void PasswordValidationMinimumTest()
    {
        Assert.AreEqual(true, PasswordValidator.Validate("Abcdef12"));
    }

    [TestMethod]
    public void PasswordValidationTooShortTest()
    {
        Assert.AreEqual(false, PasswordValidator.Validate("Abcd12"));
    }

    [TestMethod]
    public void PasswordValidationNoDigitTest()
    {
        Assert.AreEqual(false, PasswordValidator.Validate("Abcdefgh"));
    }

    [TestMethod]
    public void PasswordValidationNoUppercaseTest()
    {
        Assert.AreEqual(false, PasswordValidator.Validate("abcdefgh"));
    }

    [TestMethod]
    public void PasswordValidationOnlyDigitsTest()
    {
        Assert.AreEqual(false, PasswordValidator.Validate("12345678"));
    }

    [TestMethod]
    public void PasswordValidationOnlyUppercaseTest()
    {
        Assert.AreEqual(false, PasswordValidator.Validate("ABCDEFGH"));
    }

    [TestMethod]
    public void PasswordValidationOnlyUppercaseAndDigitsTest()
    {
        Assert.AreEqual(false, PasswordValidator.Validate("ABCD1234"));
    }
}

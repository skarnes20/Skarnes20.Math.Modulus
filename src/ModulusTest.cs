using Xunit;

namespace Skarnes20.Math.Modulus;

public class ModulusTest
{
    [Theory]
    [InlineData("1234.56.78903", true)]
    [InlineData("1234.56.78902", false)]
    public void Valid_AccountNumber_Expected(string accountNumber, bool expected)
    {
        Assert.Equal(expected, Modulus.IsMod11Valid(accountNumber));
    }
}
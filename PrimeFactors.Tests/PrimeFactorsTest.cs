
using System.Collections.Generic;
using NUnit.Framework;

public class PrimeFactorsTest
{
    PrimeFactorsSut _sut;

    [SetUp]
    public void Initialize()
    {
        _sut = new PrimeFactorsSut();
    }

    [Test]
    public void GetFactorsOfNumber20()
    {
        List<int> expected = new List<int>{2, 2, 5};
        List<int> factors = _sut.GetFactors(20);
        Assert.AreEqual(factors, expected);
    }

    [Test]
    public void GetFactorsOfNumber120()
    {
        List<int> expected = new List<int>{2,2,2,3,5};
        List<int> factors = _sut.GetFactors(120);
        Assert.AreEqual(factors, expected);
    }
}
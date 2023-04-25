using TestDateFormat;
using NUnit.Framework;
namespace Library.Tests;

public class DateFormatterTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        Assert.Pass();
    }


    [Test]
    public void ValidarSeparadores()
    {
        const string input = "11-10-2005";
        const string expected = "";

        string actual = DateFormatter.ChangeFormat(input);

        Assert.That(actual, Is.EqualTo(expected));
    }

     [Test]
    public void ValidarLargo()
    {
        const string input = "11-0-200";
        const string expected = "";

        string actual = DateFormatter.ChangeFormat(input);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void ValidarFecha()
    {
        const string input = "811-330-1987";
        const string expected = "";

        string actual = DateFormatter.ChangeFormat(input);

        Assert.That(actual, Is.EqualTo(expected));
    }

    



}
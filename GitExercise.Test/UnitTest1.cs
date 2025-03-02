namespace GitExercise.Test;
using NUnit.Framework;
using GitExercise;

[TestFixture]
public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1_Adding()
    {

        //Arrange
        double a = 5;
        double b = 6;
        double expected = 11;
        //Act
        double actual = OptionsManager.Addd(a, b);
        //Assert
        Assert.That(expected, Is.EqualTo( actual), "Error!");
    }

    [Test]
    public void Test2_Multiply()
    {

        //Arrange
        double a = 5;
        double b = 7;
        double expected = 35;
        //Act
        double actual = OptionsManager.Multiplyy(a, b);
        //Assert
        Assert.That(expected, Is.EqualTo(actual), "Error!");
    }
}

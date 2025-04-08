namespace ExceptsGame.Tests;
using NUnit.Framework;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void MessageOfChosenException()
    {
        try
        {
            throw new AlreadyChosenException("That number was already chosen.");
        }catch(AlreadyChosenException e)
        {
            // Assert.IsTrue(e.Message == "That number was already chosen"); // Gives broken code Assert does not have a definition for IsTrue
            Assert.That(e.Message, Is.EqualTo("That number was already chosen."));
        }
    }
    [Test]
    public void TestDefaultMessageForAlreadyChosneException()
    {
        try
        {
            throw new AlreadyChosenException();
        }catch(AlreadyChosenException e)
        {
            Assert.That(e.Message, Is.EqualTo("Repeated chosen number."));
        }
    }
    [Test]
    public void RaisinCookieExceptionChosenMessage()
    {
        try
        {
            throw new RaisinCookieException("Eww yucky oatmeal raisen cookie.");
        }catch(RaisinCookieException e)
        {
            Assert.That(e.Message, Is.EqualTo("Eww yucky oatmeal raisen cookie."));
        }
    }
    [Test]
    public void RaisinCookieException()
    {
        try
        {
            throw new RaisinCookieException();
        }catch(RaisinCookieException e)
        {
            Assert.That(e.Message, Is.EqualTo("Looks like you got the yucky oatmeal raisin cookie."));
        }        
    }
}

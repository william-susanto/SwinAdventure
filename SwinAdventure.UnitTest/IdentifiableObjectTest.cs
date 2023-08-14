using Microsoft.VisualStudio.TestPlatform.ObjectModel;

namespace SwinAdventure.UnitTest;

[TestFixture]
public class IdentifiableObjectTest
{
    private IdentifiableObject _testObject1;
    private IdentifiableObject _testObject2;

    [SetUp]
    public void Setup()
    {
        _testObject1 = new IdentifiableObject(new string[] { "fred", "bob" });
        _testObject2 = new IdentifiableObject(new string[] { });
    }

    [Test]
    public void TestAreYou()
    {
        Assert.True(_testObject1.AreYou("fred"));
    }

    [Test]
    public void TestNotAreYou()
    {
        Assert.False(_testObject1.AreYou("wilma"));
    }

    [Test]
    public void TestCaseSensitive()
    {
        Assert.True(_testObject1.AreYou("BOB"));
    }

    [Test]
    public void TestFirstId()
    {
        Assert.That(_testObject1.FirstId, Is.EqualTo("fred"));
    }

    [Test]
    public void TestNotFirstId()
    {
        Assert.That(_testObject2.FirstId, Is.EqualTo(""));
    }

    [Test]
    public void TestAddId()
    {
        _testObject1.AddIdentifier("wilma");
        Assert.That(_testObject1.AreYou("fred") && _testObject1.AreYou("bob") && _testObject1.AreYou("wilma"));
    }

}
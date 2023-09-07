using Microsoft.VisualStudio.TestPlatform.ObjectModel;

namespace SwinAdventure.UnitTest;

[TestFixture]
public class ItemTest
{
    private Item _testObject1;

    [SetUp]
    public void Setup()
    {
        _testObject1 = new Item(new string[] { "sword", "bronze" }, "bronze sword", "A short sword cast from bronze");
    }

    [Test]
    public void TestItemIdentifiable()
    {
        Assert.True(_testObject1.AreYou("sword"));
    }

    [Test]
    public void TestShortDescription()
    {
        Assert.That(_testObject1.ShortDescription, Is.EqualTo("a bronze sword (sword)"));
    }

    [Test]
    public void TestFullDescription()
    {
        Assert.That(_testObject1.FullDescription, Is.EqualTo("A short sword cast from bronze"));
    }
}
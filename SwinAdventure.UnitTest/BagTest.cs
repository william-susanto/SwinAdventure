using Microsoft.VisualStudio.TestPlatform.ObjectModel;

namespace SwinAdventure.UnitTest;

[TestFixture]
public class BagTest
{
    private Bag _testBag1;
    private Bag _testBag2;

    private Item _newItem1;
    private Item _newItem2;
    private Item _newItem3;

    [SetUp]
    public void Setup()
    {
        _testBag1 = new Bag(new string[] { "self", "backpack" }, "brown backpack", "A short sword cast from bronze");
        _testBag2 = new Bag(new string[] { "self", "bag" }, "mini bag", "A short sword cast from bronze");

        _newItem1 = new Item(new string[] { "sword", "bronze" }, "bronze sword", "A short sword cast from bronze");
        _newItem2 = new Item(new string[] { "shovel", "spade" }, "shovel", "This is a might fine shovel");
        _newItem3 = new Item(new string[] { "water", "bottle" }, "water bottle", "Carry water with this item");

    }

    [Test]
    public void TestBagLocatesItem()
    {
        Assert.That(_testBag1.Locate("shovel"), Is.EqualTo(_newItem2));
    }

    [Test]
    public void TestBagLocatesItself()
    {
        Assert.That(_testBag1.Locate("self"), Is.EqualTo(_testBag1));

    }

    //[Test]
    //public void TestPlayerLocatesItself()
    //{
    //    Assert.That(_testObject1.FullDescription, Is.EqualTo("A short sword cast from bronze"));
    //}

    //[Test]
    //public void TestPlayerLocatesNothing()
    //{
    //    Assert.That(_testObject1.FullDescription, Is.EqualTo("A short sword cast from bronze"));
    //}

    //[Test]
    //public void TestPlayerFullDescription()
    //{
    //    Assert.That(_testObject1.FullDescription, Is.EqualTo("You are William, Just another player in this world. You are carrying: sword, shovel, "));
    //}
}
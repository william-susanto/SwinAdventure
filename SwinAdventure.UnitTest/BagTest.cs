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
        _testBag1 = new Bag(new string[] { "backpack", "self" }, "brown backpack", "A short sword cast from bronze");
        _testBag2 = new Bag(new string[] { "bag", "self" }, "mini bag", "A short sword cast from bronze");

        _newItem1 = new Item(new string[] { "sword", "bronze" }, "bronze sword", "A short sword cast from bronze");
        _newItem2 = new Item(new string[] { "shovel", "spade" }, "shovel", "This is a might fine shovel");
        _newItem3 = new Item(new string[] { "water", "bottle" }, "water bottle", "Carry water with this item");


        _testBag1.Inventory.Put(_newItem1);
        _testBag1.Inventory.Put(_newItem2);
        _testBag1.Inventory.Put(_newItem3);
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

    [Test]
    public void TestBagLocatesNothing()
    {
        Assert.That(_testBag1.Locate("123"), Is.EqualTo(null));

    }

    [Test]
    public void TestBagFullDescription()
    {
        Assert.That(_testBag1.FullDescription, Is.EqualTo("In the brown backpack you can see: sword, shovel, water, "));
    }

    [Test]
    public void TestBagInBag()
    {
        _testBag1.Inventory.Put(_testBag2);

        Assert.That(_testBag1.Locate("bag"), Is.EqualTo(_testBag2));
        Assert.That(_testBag1.Locate("shovel"), Is.EqualTo(_newItem2));
        Assert.That(_testBag1.Locate("shove2"), !Is.EqualTo(_newItem2));
    }
}
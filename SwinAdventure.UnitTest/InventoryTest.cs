using Microsoft.VisualStudio.TestPlatform.ObjectModel;

namespace SwinAdventure.UnitTest;

[TestFixture]
public class InventoryTest
{
    private Inventory _testObject1;
    private Item _newItem1;
    private Item _newItem2;


    [SetUp]
    public void Setup()
    {
        _testObject1 = new Inventory();
        _newItem1 = new Item(new string[] { "sword", "bronze" }, "bronze sword", "A short sword cast from bronze");
        _newItem2 = new Item(new string[] { "shovel", "spade" }, "shovel", "This is a might fine shovel");

        _testObject1.Put(_newItem1);
        _testObject1.Put(_newItem2);
    }

    [Test]
    public void TestFindItem()
    {
        Assert.True(_testObject1.HasItem("sword"));
    }

    //[Test]
    //public void TestNoItemFind()
    //{
    //    Assert.False(_testObject1.HasItem("bob"));
    //}

    [Test]
    public void TestFetchItem()
    {
        Assert.That(_testObject1.Fetch("sword"), Is.EqualTo(_newItem1));
    }

    [Test]
    public void TestTakeItem()
    {
        Assert.That(_testObject1.Fetch("sword"), Is.EqualTo(_newItem1));
        Assert.False(_testObject1.HasItem("sword"));
    }

    [Test]
    public void TestItemList()
    {
        Assert.That(_testObject1.ItemList, Is.EqualTo("sword, shovel, "));
    }
}
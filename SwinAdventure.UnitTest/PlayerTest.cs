﻿using Microsoft.VisualStudio.TestPlatform.ObjectModel;

namespace SwinAdventure.UnitTest;

[TestFixture]
public class PlayerTest
{
    private Player _testObject1;
    private Item _newItem1;
    private Item _newItem2;

    [SetUp]
    public void Setup()
    {
        _testObject1 = new Player("William", "Just another player in this world");
    }

    [Test]
    public void TestPlayerIdentifiable()
    {
        Assert.True(_testObject1.AreYou("me"));
    }

    [Test]
    public void TestPlayerLocatesItem()
    {
        _newItem1 = new Item(new string[] { "sword", "bronze" }, "bronze sword", "A short sword cast from bronze");
        _newItem2 = new Item(new string[] { "shovel", "spade" }, "shovel", "This is a might fine shovel");

        _testObject1.Inventory.Put(_newItem1);
        _testObject1.Inventory.Put(_newItem2);

        Assert.That(_testObject1.Locate("sword"), Is.EqualTo(_newItem1));
    }

    [Test]
    public void TestPlayerLocatesItself()
    {
        Assert.That(_testObject1.Locate("me"), Is.EqualTo(_testObject1));
    }

    [Test]
    public void TestPlayerLocatesNothing()
    {
        Assert.That(_testObject1.Locate("123"), Is.EqualTo(null));
    }

    [Test]
    public void TestPlayerFullDescription()
    {
        _newItem1 = new Item(new string[] { "sword", "bronze" }, "bronze sword", "A short sword cast from bronze");
        _newItem2 = new Item(new string[] { "shovel", "spade" }, "shovel", "This is a might fine shovel");

        _testObject1.Inventory.Put(_newItem1);
        _testObject1.Inventory.Put(_newItem2);

        Assert.That(_testObject1.FullDescription, Is.EqualTo("You are: William, Just another player in this world. You are carrying: sword, shovel, "));
    }
}
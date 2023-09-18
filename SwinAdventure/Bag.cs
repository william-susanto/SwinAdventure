﻿using System;
namespace SwinAdventure
{
	public class Bag : Item
	{
		private Inventory _inventory;

		public Bag(string[] ids, string name, string desc) : base(ids, name, desc)
		{
			_inventory = new Inventory();
		}

		public GameObject? Locate(string id)
		{
			if (AreYou(id))
			{
				return this;
			}
			else
			{
				return _inventory.Fetch(id);
			}
		}

		public override string FullDescription
		{
			get
			{
				return $"In the {Name} you can see: {_inventory.ItemList}";
			}
		}

		public Inventory Inventory
		{
			get
			{
				return _inventory;
			}
		}
	}
}


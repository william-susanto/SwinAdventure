using System;
namespace SwinAdventure
{
	public class Inventory
	{
		private List<Item> _items;

		public Inventory()
		{
			_items = new List<Item>();
		}

		public bool HasItem(string id)
		{
			foreach (Item i in _items)
			{
				if (i.AreYou(id))
				{
					return true;
				}
			}
			return false;
		}

		public void Put(Item item)
		{
			_items.Add(item);
		}

		public Item? Take(string id)
		{
            foreach (Item i in _items)
            {
                if (i.AreYou(id))
                {
					Item temp = i;
                    _items.Remove(i);
                    return temp;
                }
            }
            return null;
        }

		public Item? Fetch(string id)
		{
			foreach (Item i in _items)
			{
				if (i.AreYou(id))
				{
					return i;
				}
			}
			return null;
		}

		public string ItemList
		{
			get
			{
                string invShortDesc = "";
				foreach (Item i in _items)
				{
					invShortDesc += $"{i.FirstId}, ";
				}
				return invShortDesc;
            }
		}
	}
}


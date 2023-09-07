using System;
namespace SwinAdventure
{
	public abstract class GameObject : IdentifiableObject
	{
		private string _description;
		private string _name;

        public GameObject(string[] ids, string name, string desc) : base(ids)
		{
			_name = name;
			_description = desc;
		}

		public string Name
		{
			get => _name;
		}

		public string ShortDescription
		{
			get => "a " + _name + " (" + FirstId + ")";
		}

		public virtual string FullDescription
		{
			get => _description;
		}
	}
}


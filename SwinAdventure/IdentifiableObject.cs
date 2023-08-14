using System;
namespace SwinAdventure
{
    public class IdentifiableObject
    {
        // private Variables
        List<string> _identifiers;

        // Adds identifiers to the Identifiable Object from the passed in array
        public IdentifiableObject(string[] idents)
        {
            _identifiers = new List<string>();

            foreach (string id in idents)
            {
                AddIdentifier(id);
            }
        }

        // Checks if the passed in identifier is in the _identifiers
        public bool AreYou(string id)
        {
            return _identifiers.Contains(id.ToLower());
        }

        // Returns the first identifier from _identifiers, or an empty string if the object has no identifiers
        public string FirstId
        {
            get
            {
                if (_identifiers.Count > 0)
                {
                    return _identifiers[0];
                }
                else
                {
                    return "";
                }
            }
        }

        // Converts the identifier to lower case and stores it in _identifiers
        public void AddIdentifier(string id)
        {
            _identifiers.Add(id.ToLower());
        }
    }
}


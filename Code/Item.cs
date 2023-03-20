using System.Collections;
using System.Collections.Generic;

namespace Assignment
{
    // Enum - Type of item
    public enum ItemType
    {
        Clothing,
        Spell,
        LeftHand,
        RightHand,
        TwoHand,
        Stat,
    }

    public abstract class Item
    {
        // Type of item
        private ItemType _typeOfItem;
        // Name of item
        private string _name;
        // Description of item
        private string _description;
        // Weight of item
        private int _weight;
        // Cost of item
        private int _cost;
        // Cleaning magic of item
        private int _cleaningMagic;
        // Protective magic of item
        private int _protectiveMagic;
        // Icon name, this will use a given icon in the GUI
        // there are three other icons you can set this to, either "clothing-icon", "spell-icon" or "hand-icon"
        protected string _iconName = "default-icon";
        //comment

        // Constructor for an Item
        public Item(ItemType typeOfItem, string name, int cost, int weight, int cleaningMagic,
            int protectiveMagic, string description)
        {
            _typeOfItem = typeOfItem;
            _name = name;
            _cost = cost;
            _weight = weight;
            _cleaningMagic = cleaningMagic;
            _protectiveMagic = protectiveMagic;
            _description = description;
        }



        public ItemType TypeOfItem { get { return _typeOfItem; } }
        public string Name { get { return _name; } }
        public string Description { get { return _description; } }
        public int Weight { get { return _weight; } }
        public int Cost { get { return _cost; } }
        public int CleaningMagic { get { return _cleaningMagic; } }
        public int ProtectiveMagic { get { return _protectiveMagic; } }
        public string IconName { get { return _iconName; } }

    }

    //The next set of classes below are extensions of the original item class
    //Each item will have a different type so these will let me create an item of that type without having to input the enum each time.
    public class ClothingItem : Item
    {
        public ClothingItem(string name, int cost, int weight, int cleaningMagic,
            int protectiveMagic, string description) : base(ItemType.Clothing, name, cost, weight, cleaningMagic, protectiveMagic, description)
        {
            _iconName = "clothing-icon";
        }
    }
    public class Spell : Item
    {
        public Spell(string name, int cost, int weight, int cleaningMagic,
            int protectiveMagic, string description) : base(ItemType.Spell, name, cost, weight, cleaningMagic, protectiveMagic, description)
        {
            _iconName = "spell-icon";
        }
    }

    public class Hand : Item
    {
        public Hand(ItemType typeOfItem, string name, int cost, int weight, int cleaningMagic,
    int protectiveMagic, string description) : base(typeOfItem, name, cost, weight, cleaningMagic, protectiveMagic, description)
        {
            _iconName = "hand-icon";
        }
    }
    public class TwoHand : Hand
    {
        public TwoHand(string name, int cost, int weight, int cleaningMagic,
            int protectiveMagic, string description) : base(ItemType.TwoHand, name, cost, weight, cleaningMagic, protectiveMagic, description)
        {
        }
    }
    public class LeftHand : Hand
    {
        public LeftHand(string name, int cost, int weight, int cleaningMagic,
            int protectiveMagic, string description) : base(ItemType.LeftHand, name, cost, weight, cleaningMagic, protectiveMagic, description)
        {
        }
    }
    public class RightHand : Hand
    {
        public RightHand(string name, int cost, int weight, int cleaningMagic,
            int protectiveMagic, string description) : base(ItemType.RightHand, name, cost, weight, cleaningMagic, protectiveMagic, description)
        {
        }
    }

    //This will be used to compare items in each list.
    //The return data will be used to sort each list
    public class ItemComparer : IComparer<Item>
    {
        public int Compare(Item x, Item y)
        {
            return x.Name.CompareTo(y.Name);
        }

    }

}
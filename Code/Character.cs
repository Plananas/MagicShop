using System;
using System.Collections.Generic;

namespace Assignment
{
    public class Character
    {
        // This is the list that manages the items in the characters inventory
        private List<Item> _inventoryList = new List<Item>();
        // This is the list that manages the hand items that are equipped to the character        
        private List<Item> _handItemList = new List<Item>();
        // This is the list that manages the clothing items that are equipped to the character
        private List<Item> _clothingList = new List<Item>();
        // This is the list that manages the spell items that are equipped to the character
        private List<Item> _spellList = new List<Item>();
        // Keeps track of the number of items equipped to each area of the character and whether the hands are full
        private int _numberSpellsEquipped = 0;
        private int _numberClothingEquipped = 0;
        public bool _rightHandFull = false;
        public bool _leftHandFull = false;
        // Keeps track of the characters attributes
        private int _gold;
        private int _currentWeight;
        private int _cleaningMagic;
        private int _protectiveMagic;
        private int _maxWeight;

        private ItemComparer _comparer = new ItemComparer();

        public Character(int gold, int maxWeight)
        {
            // you should add the ability to set the gold and weight when creating the character
            _maxWeight = maxWeight;
            _gold = gold;
        }

        public List<Item> InventoryList { get { return _inventoryList; } }
        public List<Item> HandItemList { get { return _handItemList; } }
        public List<Item> ClothingList { get { return _clothingList; } }
        public List<Item> SpellList { get { return _spellList; } }
        public int Gold { get { return _gold; } }
        public int CurrentWeight { get { return _currentWeight; } }
        public int CleaningMagic { get { return _cleaningMagic; } }
        public int ProtectiveMagic { get { return _protectiveMagic; } }
        public int MaxWeight { get { return _maxWeight; } }


        // Check if the character has enough weight left to carry the given item.
        // If it is successful it should return true otherwise false
        public bool EnoughWeight(Item item)
        {
            if (MaxWeight - CurrentWeight >= item.Weight)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Check if the character has enough gold left to buy the item.
        // If it is successful it should return true otherwise false
        public bool EnoughGold(Item item)
        {
            if (item.Cost <= Gold)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        // Equip the character with a given item based on its type.
        // Either a left-hand, right-hand, two-hand, clothing or spell item.
        // This should add an item from the correct character’s list and remove it from the inventory.
        // If it is successful it should return true otherwise false.
        public bool EquipItem(Item item)
        {
            //If the user has enough weight to equip the item it will let them
            if (EnoughWeight(item))
            {
                //depending on the item it will add it to the right inventory
                //Each type will call their corresponding function.
                switch (item.TypeOfItem)
                {
                    case ItemType.Clothing:
                        return EquipClothing(item);
                    case ItemType.Spell:
                        return EquipSpell(item);
                    case ItemType.LeftHand:
                        return EquipLeftHand(item);
                    case ItemType.RightHand:
                        return EquipRightHand(item);
                    case ItemType.TwoHand:
                        return EquipTwoHand(item);
                    default:
                        return false;
                }
            }
            else
            {
                return false;
            }
        }
        //Will add the clothing to the equipped clothing list, remove it from the inventory, and then will update the values.
        public bool EquipClothing(Item item)
        {
            if (_numberClothingEquipped < 2)
            {
                ClothingList.Add(item);
                InventoryList.Remove(item);
                AddValues(item);
                _numberClothingEquipped++;
                ClothingList.Sort(_comparer);
                return true;
            }
            else
            {
                return false;
            }

        }
        //Will add the spell to the equipped spells list, remove it from the inventory, and then will update the values.
        public bool EquipSpell(Item item)
        {
            if(_numberSpellsEquipped < 2)
            {
                SpellList.Add(item);
                InventoryList.Remove(item);
                AddValues(item);
                SpellList.Sort(_comparer);
                _numberSpellsEquipped++;
                return true;
            }
            else
            {
                return false;
            }

        }
        //The Equip to hand functions are used to check if the users hands are free before you can equip the item.
        public bool EquipRightHand(Item item)
        {
            if (!_rightHandFull)
            {
                HandItemList.Add(item);
                InventoryList.Remove(item);
                _rightHandFull = true;
                AddValues(item);
                HandItemList.Sort(_comparer);
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool EquipLeftHand(Item item)
        {
            if (!_leftHandFull)
            {
                HandItemList.Add(item);
                InventoryList.Remove(item);
                _leftHandFull = true;
                AddValues(item);
                HandItemList.Sort(_comparer);
                return true;
            }
            else
            {

                return false;
            }
        }
        public bool EquipTwoHand(Item item)
        {
            if ((!_rightHandFull) && (!_leftHandFull))
            {
                HandItemList.Add(item);
                InventoryList.Remove(item);
                _rightHandFull = true;
                _leftHandFull = true;
                AddValues(item);
                HandItemList.Sort(_comparer);
                return true;
            }
            else
            {
                return false;
            }
        }

        //Adds the protective magic, cleaning magic, and weight values to their corresponding variables.
        public void AddValues(Item item)
        {
            _protectiveMagic += item.ProtectiveMagic;
            _cleaningMagic += item.CleaningMagic;
            _currentWeight += item.Weight;
        }

        // Unequip an item from the character.
        // This should remove an item from the correct character’s list and add it to the inventory.
        // If it is successful it should return true otherwise false.
        public bool UnequipItem(Item item)
        {
            //Updates protective magic, cleaning magic and weight.
            _protectiveMagic -= item.ProtectiveMagic;
            _cleaningMagic -= item.CleaningMagic;
            _currentWeight -= item.Weight;

            //adds the item back to the inventory
            InventoryList.Add(item);
            InventoryList.Sort(_comparer);
            //depending on the item type it will remove the item from the equip slot
            switch (item.TypeOfItem)
            {
                case ItemType.Clothing:
                    ClothingList.Remove(item);
                    _numberClothingEquipped--;
                    return true;

                case ItemType.Spell:
                    SpellList.Remove(item);
                    _numberSpellsEquipped--;
                    return true ;

                case ItemType.LeftHand:
                    HandItemList.Remove(item);
                    _leftHandFull = false;
                    return true;

                case ItemType.RightHand:
                    HandItemList.Remove(item);
                    _rightHandFull = false;
                    return true;

                case ItemType.TwoHand:
                    HandItemList.Remove(item);
                    _rightHandFull = false ;
                    _leftHandFull = false;
                    return true;

                default:
                    return false ;
            }

        }

        // This item should buy an item if the character has enough gold. 
        // It should then be added to the characters inventory list.
        // return true if successful, false otherwise.
        public bool BuyItem(Item item)
        {
            if(EnoughGold(item))
            {
                InventoryList.Add(item); 
                InventoryList.Sort(_comparer);
                _gold -= item.Cost;
                return true;
            }
            else
            {
                return false;
            }
            
        }

        // This should remove an item from the characters inventory list
        // If it is successful it should return true otherwise false
        public bool SellItem(Item item)
        {
            InventoryList.Remove(item);
            _gold += item.Cost;
            return true;
        }
    }
}

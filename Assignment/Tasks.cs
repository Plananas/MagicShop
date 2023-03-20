using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.IO;
using System.Windows.Forms;

namespace Assignment
{
    public partial class Tasks
    {
        // Create an instance of the shop
        // This is used to keep track of the shops current state
        private Shop _theShop = new Shop();

        // Create an instance of the character
        // This is used to keep track of the characters current state
        //they star with 150kg weight and 200 gold
        private Character _theCharacter = new Character(200, 150);
        private ItemComparer _comparer = new ItemComparer();


        // TASK 1 -----------------------------------------------
        // 1a - Create the item hierarchy
        // 1b - Load the items from the file and create instances of the items
        // 1c - Add the items to the shop list
        // ------------------------------------------------------

        // This should load the items from the file and create instances of the items adding them to the shop.
        public void LoadShop()
        {

            //will add each item from the file to the list.
            foreach(var item in FiletoList("\\items.txt"))
            {
                _theShop.ShopList.Add(item);
            }

            //will sort the items in the list of shop items.
            _theShop.ShopList.Sort(_comparer);

        }

        //This function will create a list of objects from a specified file.
        public List<Item> FiletoList(string fileName)
        {
            //gets the current directory
            string path = Directory.GetCurrentDirectory();

            //will read the items.txt file from my directory.
            StreamReader fileReader = new StreamReader(path + fileName);
            string theText = fileReader.ReadToEnd();

            //splits the file up by each line
            string[] fileSplit = theText.Split("\n");
            List<Item> returnList = new List<Item>();

            //for each line in the text, check what the starting character is and create an item of it.
            foreach (var v in fileSplit)
            {
                string[] itemSplit;
                //each if statement will create a new instance of the item and put it into the list.
                // "|" will tell me where there is a new piece of info.
                if (v.IndexOf("C|") == 0)
                {
                    itemSplit = v.Split("|");
                    returnList.Add(new ClothingItem(itemSplit[1], int.Parse(itemSplit[3]), int.Parse(itemSplit[4]), int.Parse(itemSplit[5]), int.Parse(itemSplit[6]), itemSplit[2]));
                }
                else if (v.IndexOf("S|") == 0)
                {
                    itemSplit = v.Split("|");
                    returnList.Add(new Spell(itemSplit[1], int.Parse(itemSplit[3]), int.Parse(itemSplit[4]), int.Parse(itemSplit[5]), int.Parse(itemSplit[6]), itemSplit[2]));
                }
                else if (v.IndexOf("H1L|") == 0)
                {
                    itemSplit = v.Split("|");
                    returnList.Add(new LeftHand(itemSplit[1], int.Parse(itemSplit[3]), int.Parse(itemSplit[4]), int.Parse(itemSplit[5]), int.Parse(itemSplit[6]), itemSplit[2]));
                }
                else if (v.IndexOf("H1R|") == 0)
                {
                    itemSplit = v.Split("|");
                    returnList.Add(new RightHand(itemSplit[1], int.Parse(itemSplit[3]), int.Parse(itemSplit[4]), int.Parse(itemSplit[5]), int.Parse(itemSplit[6]), itemSplit[2]));
                }
                else if (v.IndexOf("H2|") == 0)
                {
                    itemSplit = v.Split("|");
                    returnList.Add(new TwoHand(itemSplit[1], int.Parse(itemSplit[3]), int.Parse(itemSplit[4]), int.Parse(itemSplit[5]), int.Parse(itemSplit[6]), itemSplit[2]));
                }
            }

            //close the file after ive finished reading it.
            fileReader.Close();
            //Will return the new list of objects.
            return returnList;

        }



        // TASK 2 -------------------------------------------------------
        // 2a - Buy Items from the shop into the inventory 
        // 2b - Sell items from the inventory into the shop 
        // 2c - Update the character's constructur so that when it is created it starts with the correct gold and max weight
        //      Update the characters gold based on the items that the character has equipped in their 3 type inventories
        //      Update the Buy Items to only buy items if the player has enough gold
        // 2d - Add a new item to the shop 
        // 2e - Remove a selected item from the shop 
        // --------------------------------------------------------------


        // This is called when the Buy button is clicked.
        // The selected item in the shop has been passed to this method for you.
        // This should call the appropriate methods provided by the shop and character classes
        public bool BuyItemFromShop(Item item)
        {
            //If character can buy item it is removed from list.
            if (_theCharacter.BuyItem(item))
            {
                return RemoveShopItem(item);
            }
            else
            {
                return false;
            }
        }

        // This is called when the Sell button is clicked.
        // The selected item in the inventory has been passed to this method for you.
        // This should call the appropriate methods provided by the shop and character classes
        public bool SellItemToShop(Item item)
        {
            //If character can buy item it is removed from list.
            if (_theCharacter.SellItem(item))
            {
                _theShop.AddItem(item);
                _theShop.ShopList.Sort(_comparer);
                return true;
            }
            else
            {
                return false;
            }
        }

        // This is called when the Create button is clicked.
        // This should create a new dialog box which allows a new item to be created.
        public void CreateShopItem()
        {
            //creates new instance of the form.
            CreateBox createForm = new CreateBox();

            //when showdialogue is ok we can take the new item created and pass it into the shop.
            if (createForm.ShowDialog() == DialogResult.OK)
            {
                _theShop.AddItem(createForm.TheItem);
                _theShop.ShopList.Sort(_comparer);
            }
        }




        // This is called when the Remove button is clicked.
        // This should remove the selected item from the shop.
        public bool RemoveShopItem(Item item)
        {
            _theShop.RemoveItem(item);
            return true;
        }

        // TASK 3 -------------------------------------------------------
        // 3a - Eqiup character with item in correct list (hand, clothing or spell)
        // 3b - Unequip the selected item so it appears back in the inventory
        // 3c - Update the cleaning magic label
        // 3d - Update the protective magic label
        // 3e - Update the Equip character so that it only Equips based on the equipping rules
        // 3f - Sort any list of type List<Item> by implementing the IComparable interface.
        //      You will need to call sort in the right places. 
        // --------------------------------------------------------------

        // This is called when the Euip button is clicked.
        // The selected item in the inventory has been passed to this method for you.
        // This should call the appropriate method provided by the character class
        public bool EquipItem(Item item)
        {
            return (_theCharacter.EquipItem(item));
        }

        // TODO: This is called when the Uneuip button is clicked.
        // The selected item in the character’s panel has been passed to this method for you.
        // This should call the appropriate method provided by the character class
        public bool UnequipItem(Item item)
        {
            return (_theCharacter.UnequipItem(item));
        }


        // TASK 4 -------------------------------------------------------
        // 4a - Save the current state of the program
        // 4b - Load the current state of the program
        // --------------------------------------------------------------

        // TODO: This is called when the Save menu item is clicked.
        // This should save the state of the program.
        public void SaveState()
        {
            //sends each list to a function that saves them to the desired file.
            SaveToFile(_theShop.ShopList, "ShopSave.txt");
            SaveToFile(_theCharacter.InventoryList, "InventorySave.txt");
            SaveToFile(_theCharacter.ClothingList, "ClothingSave.txt");
            SaveToFile(_theCharacter.SpellList, "SpellSave.txt");
            SaveToFile(_theCharacter.HandItemList, "HandSave.txt");

        }


        //This will save the list to the file specified
        public void SaveToFile(List<Item> saveFrom, string fileName)
        {
            //changes the inputted list to the correct format for the file
            List<string> theList = CreateList(saveFrom);
            StreamWriter theFile = new StreamWriter(fileName, false);

            //For each of the items in the list it will write it to the file
            foreach (var x in theList)
            {
                theFile.WriteLine(x);
            }
            theFile.Close();
        }

        //This function will create a list in the correct format to be saved in the txt file.
        //will change starting characters depending on the item.
        public List<string> CreateList(List<Item> theList)
        {
            List<string> newList = new List<string>();
            foreach (var x in theList)
            {
                string listAsString = x.Name + "|" + x.Description + "|" + x.Cost.ToString() + "|" + x.Weight.ToString() + "|" + x.CleaningMagic.ToString() + "|" + x.ProtectiveMagic.ToString();
                if (x.TypeOfItem == ItemType.Clothing)
                {
                    newList.Add("C|" + listAsString);
                }
                else if (x.TypeOfItem == ItemType.Spell)
                {
                    newList.Add("S|" + listAsString);
                }
                else if (x.TypeOfItem == ItemType.RightHand)
                {
                    newList.Add("H1R|" + listAsString);
                }
                else if (x.TypeOfItem == ItemType.LeftHand)
                {
                    newList.Add("H1L|" + listAsString);
                }
                else if (x.TypeOfItem == ItemType.TwoHand)
                {
                    newList.Add("H2|" + listAsString);
                }
            }
            return newList;
        }
        // This is called when the Load menu item is clicked.
        // This should load a previous state of the program.
        public void LoadState()
        {
            // saves the contents of the files to lists
            List<Item> shopLoad = FiletoList("\\ShopSave.txt");
            List<Item> inventoryLoad = FiletoList("\\InventorySave.txt");
            List<Item> clothingLoad = FiletoList("\\ClothingSave.txt");
            List<Item> spellLoad = FiletoList("\\SpellSave.txt");
            List<Item> handLoad = FiletoList("\\HandSave.txt");

            //will clear each list and put all the loaded items into each list.
            _theShop.ShopList.Clear();
            foreach(var item in shopLoad)
            {
                _theShop.ShopList.Add(item);
            }

            _theCharacter.InventoryList.Clear();
            foreach(var item in inventoryLoad)
            {
                BuyItemFromShop(item);
            }

            _theCharacter.HandItemList.Clear();
            foreach(var item in handLoad)
            {
                BuyItemFromShop(item);
                _theCharacter.EquipItem(item);
            }

            _theCharacter.ClothingList.Clear();
            foreach (var item in clothingLoad)
            {
                BuyItemFromShop(item);
                _theCharacter.EquipItem(item);

            }

            _theCharacter.SpellList.Clear();
            foreach (var item in spellLoad)
            {
                BuyItemFromShop(item);
                _theCharacter.EquipItem(item);
            }

        }
    }
}

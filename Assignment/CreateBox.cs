using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public partial class CreateBox : Form
    {
        Item _i;
        public CreateBox()
        {
            InitializeComponent();
        }

        public Item TheItem
        {
            get { return _i; }
        }

        private void nameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {


            
            //takes all the values inputted and saves them to variables.
            string itemType = itemTypeBox.Text;
            string itemName = nameBox.Text;
            int itemCost = IsAnInt(costBox.Text);
            int itemWeight = IsAnInt(weightBox.Text);
            int itemProtection = IsAnInt(protectiveBox.Text);
            int itemCleaning = IsAnInt(protectiveBox.Text);
            string itemDescription = Description.Text;
            //Will create the correct type of object based on the itemtype.
            switch (itemType)
            {
                case "Clothes":
                    _i = new ClothingItem(itemName, itemCost, itemWeight, itemProtection, itemCleaning, itemDescription);
                    break;
                case "Spell":
                    _i = new Spell(itemName, itemCost, itemWeight, itemProtection, itemCleaning, itemDescription);
                    break;
                case "Right Handed":
                    _i = new RightHand(itemName, itemCost, itemWeight, itemProtection, itemCleaning, itemDescription);
                    break;
                case "Left Handed":
                    _i = new LeftHand(itemName, itemCost, itemWeight, itemProtection, itemCleaning, itemDescription);
                    break;
                case "Two Handed":
                    _i = new TwoHand(itemName, itemCost, itemWeight, itemProtection, itemCleaning, itemDescription);
                    break;
                default:
                    _i = new ClothingItem(itemName, itemCost, itemWeight, itemProtection, itemCleaning, itemDescription);
                    break;
            }
           
            //This will be used to make sure the item is created.
            DialogResult = DialogResult.OK;


        }


        public int IsAnInt(string testVal)
        {
            if (int.TryParse(testVal, out int value))
            {
                return int.Parse(testVal);
            }
            else
            {
                return 0;
            }
        }

    }

}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Day8.BLL;
using Day8.Model;

namespace Day8
{
    public partial class Items : Form
    {
        ItemManager _itemManager = new ItemManager();
        Item _item = new Item();
        public Items()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string item= orderTextBox.Text;
            bool isAdd = false;
            if (_itemManager.IsItemExists(item))
            {
                MessageBox.Show("Item already exists");
                return;
            }
            if (string.IsNullOrEmpty(item))
            {
                MessageBox.Show("Please insert your Order");
                return;
            }
            _item.Items = orderTextBox.Text;
            isAdd = _itemManager.Connection(_item);
            if (!isAdd)
            {
                MessageBox.Show("Your Information added");
                itemsDataGridView.DataSource = _itemManager.ShowItemInformation();
            }
            else
            {
                MessageBox.Show("Not add");
                return;
            }
            
             
        }
        private void showButton_Click(object sender, EventArgs e)
        {
           itemsDataGridView.DataSource = _itemManager.ShowItemInformation();   
        }
        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(idTextBox.Text))
            {
                MessageBox.Show("You must fillup id");
            }
            if (_itemManager.Delete(Convert.ToInt32(idTextBox.Text)))
            {
                MessageBox.Show("Delete Successfull");

            }
            else
            {
                MessageBox.Show("Not delete");
            }
            itemsDataGridView.DataSource = _itemManager.ShowItemInformation();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(idTextBox.Text))
            {
                MessageBox.Show("Id must be fillup");
                return;
            }
            if (string.IsNullOrEmpty(orderTextBox.Text))
            {
                MessageBox.Show("Order must be fillup");
                return;
            }
            if (_itemManager.Update(orderTextBox.Text, Convert.ToInt32(idTextBox.Text)))
            {
                MessageBox.Show("Your information updated");
                itemsDataGridView.DataSource = _itemManager.ShowItemInformation();
            }
        }

        
    }
}

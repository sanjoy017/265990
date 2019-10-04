using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Day8.BLL;
using Day8.Model;

namespace Day8
{
    public partial class Quantity : Form
    {
        QuantityManager _quantityManager = new QuantityManager();
        
        public Quantity()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            
           int quantity =Convert.ToInt32(quantityTextBox.Text);
            bool isAdd = false;
           
            if (quantity==0)
            {
                MessageBox.Show("Please insert your Order");
                return;
            }
             isAdd = _quantityManager.Connection(quantity);
            if (!isAdd)
            {
                MessageBox.Show("Your Information added");
                quantityDataGridView.DataSource = _quantityManager.ShowInformation();
            }
            else
            {
                MessageBox.Show("Not add");
                return;
            }

        }


        private void showButton_Click(object sender, EventArgs e)
        {
            quantityDataGridView.DataSource = _quantityManager.ShowInformation();
        }
        

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(idTextBox.Text))
            {
                MessageBox.Show("You must fillup id");
            }
            if (_quantityManager.Delete(Convert.ToInt32(idTextBox.Text)))
            {
                MessageBox.Show("Delete Successfull");

            }
            else
            {
                MessageBox.Show("Not delete");
            }
            quantityDataGridView.DataSource = _quantityManager.ShowInformation();
        }

        

        private void updateButton_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(idTextBox.Text))
            {
                MessageBox.Show("Id must be fillup");
                return;
            }
            if (string.IsNullOrEmpty(quantityTextBox.Text))
            {
                MessageBox.Show("Order must be fillup");
                return;
            }
            if (_quantityManager.Update(Convert.ToInt32(quantityTextBox.Text), Convert.ToInt32(idTextBox.Text)))
            {
                MessageBox.Show("Your information updated");
                quantityDataGridView.DataSource = _quantityManager.ShowInformation();
            }
        }

        
    }
}

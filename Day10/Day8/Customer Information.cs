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
    public partial class customerInformationForm : Form
    {
        CustomerManager _customerManager = new CustomerManager();
        Customer _customer = new Customer();
        Delete _delete = new Delete();
        Update _update = new Update();
        Search _search = new Search();

        public customerInformationForm()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            _customer.CustomerName = customerNameTextBox.Text;
            //_customer.Contact = Convert.ToInt32(contactNoTextBox.Text);
            _customer.Address =addressTextBox.Text;

            bool isAdded = false;
            if (_customerManager.IsNameExists(_customer.CustomerName))
            {
                MessageBox.Show(_customer.CustomerName + " Already Exists");
                return;
            }
            if (!String.IsNullOrEmpty(_customer.CustomerName))
            {
                if (!String.IsNullOrEmpty(contactNoTextBox.Text))

                    if (!String.IsNullOrEmpty(_customer.Address))
                    {
                        _customer.Contact = contactNoTextBox.Text;

                        isAdded = _customerManager.Add(_customer);
                        
                        if (!isAdded)
                        {
                            MessageBox.Show("Your Information Add Sucessfully");
                        }
                        else
                        {
                            MessageBox.Show("Not Add Your Information");
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Address box must be fillup");
                        return;
                    }

                else
                {
                    MessageBox.Show("Contact No Box must be fillup");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Name Box must be fillup");
            }
            showDataGridView.DataSource=_customerManager.ShowInformation();
        }
        private void showButton_Click(object sender, EventArgs e)
        {
           showDataGridView.DataSource =_customerManager.ShowInformation();
        }
        

        private void deleteButton_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(deletedIDTextBox.Text))
            {
                MessageBox.Show("You must fillup id");
            }
            _delete.Id = Convert.ToInt32(deletedIDTextBox.Text);
            if (_customerManager.Delete(_delete))
            {
                MessageBox.Show("Delete Successfull");

            }
            else
            {
                MessageBox.Show("Not delete");
            }
            showDataGridView.DataSource = _customerManager.ShowInformation();
          
        }

        

        private void updateButton_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(deletedIDTextBox.Text))
            {
                MessageBox.Show("Id Must be fillup");
                return;
            }
            if (string.IsNullOrEmpty(customerNameTextBox.Text))
            {
                MessageBox.Show("Name must be fillup");
                return;
            }
            _update.Id = Convert.ToInt32(deletedIDTextBox.Text);
            _update.Name = customerNameTextBox.Text;
            _update.Contact = Convert.ToInt32(contactNoTextBox.Text);
            _update.Address = addressTextBox.Text;
           if(_customerManager.Update(_update))
            {
                MessageBox.Show("Update Your Information");
                showDataGridView.DataSource= _customerManager.ShowInformation();
            }


            //Update(customerNameTextBox.Text,Convert.ToInt32(contactNoTextBox.Text),addressTextBox.Text,Convert.ToInt32(deletedIDTextBox.Text));
        }

       

        private void searchButton_Click(object sender, EventArgs e)
        {
            _search.Name = searchTextBox.Text;
            if (string.IsNullOrEmpty(_search.Name))
            {
                MessageBox.Show("Search name Must be fillup");
                return;
            }
            DataTable dataTable = _customerManager.Search(_search);
            if(dataTable != null)
            {
                MessageBox.Show("Found");
                showDataGridView.DataSource = dataTable;
            }
            else
            {

                MessageBox.Show("Not found");
            }

            
        }

        

        private void TextInput(KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Input only alphabetic characters");
            }
        }
        private void NumberInput(KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Input only numbers...");
            }
        }
        

        private void CustomerNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextInput(e);
        }

        private void ContactNoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {

            NumberInput(e);
            if (contactNoTextBox.Text.Length > 11)
            {
                MessageBox.Show("Only 11 Number input");
                contactNoTextBox.MaxLength = 11;
            }
        }

        private void DeletedId_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumberInput(e);
        }

        //private void showDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (showDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
        //    {
        //        showDataGridView.CurrentRow.Selected = true;

        //        customerNameTextBox.Text = showDataGridView.Rows[e.RowIndex].Cells["Name"].Value.ToString();
        //        contactNoTextBox.Text = showDataGridView.Rows[e.RowIndex].Cells["Contact"].Value.ToString();
        //        addressTextBox.Text = showDataGridView.Rows[e.RowIndex].Cells["Address"].Value.ToString();

        //        _customer.Id = showDataGridView.Rows[e.RowIndex].Cells["Id"].Value.ToString();
        //    }
        //}

        //private void showDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (e.RowIndex > 0)
        //    {
        //        DataGridViewRow row = this.showDataGridView.Rows[e.RowIndex];
        //        deletedIDTextBox.Text = row.Cells["Id"].Value.ToString();
        //        customerNameTextBox.Text = row.Cells["CustomerName"].Value.ToString();
        //        contactNoTextBox.Text = row.Cells["ContactNo"].Value.ToString();
        //        addressTextBox.Text = row.Cells["Address"].Value.ToString();
        //    }
        //}

        private void showDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0)
            {
                DataGridViewRow row = this.showDataGridView.Rows[e.RowIndex];
                deletedIDTextBox.Text = row.Cells["Id"].Value.ToString();
                customerNameTextBox.Text = row.Cells["CustomerName"].Value.ToString();
                contactNoTextBox.Text = row.Cells["ContactNo"].Value.ToString();
                addressTextBox.Text = row.Cells["Address"].Value.ToString();
            }

        }
    }
}

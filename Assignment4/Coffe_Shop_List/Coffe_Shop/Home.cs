using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffe_Shop
{
    public partial class Home : System.Windows.Forms.Form
    {
        List<string> customername = new List<string>{ };
        List<string> contactno = new List<string> { };
        List<string> address = new List<string> { };
        List<string> order = new List<string> { };
        List<string> quantity = new List<string> { };
        List<string> totalprice = new List<string> { };
        int customernumber = 1;
        string message = " ";
        int price =0;


    public Home()
        {          
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {

            SaveInformation();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            ShowInformation();
        }

        private void SaveInformation()
        {
            if(orderComboBox.Text !=" ")
            {
                if(quantityTextBox.Text !=" ")
                {
                    if( !customername.Contains(customerNameTextBox.Text))
                    {
                        customername.Add(customerNameTextBox.Text);
                        contactno.Add(contactNoTextBox.Text);
                        address.Add(addressTextBox.Text);
                        order.Add(orderComboBox.Text);
                        quantity.Add(quantityTextBox.Text);

                        price = Calculate();
                        totalprice.Add(Convert.ToString(price));
                        Information();
                        
                    }
                    else
                    {
                        MessageBox.Show("Customer is already exits");
                    }
                        

                }
                else
                {
                    MessageBox.Show("Please Select Your Order Quantity");
                }

            }
            else
            {
                MessageBox.Show("Please Enter Your Order");
            }
            
        }
        private int Calculate()
        {
            
            if(orderComboBox.Text=="Black")
            {
                price =int.Parse(quantityTextBox.Text) * 120;
            }
            if(orderComboBox.Text=="Cold")
            {
                price = int.Parse(quantityTextBox.Text) * 100;
            }
            if(orderComboBox.Text=="Hot")
            {
                price = int.Parse(quantityTextBox.Text) * 90;
            }
            if(orderComboBox.Text=="Regular")
            {
                price = int.Parse(quantityTextBox.Text) * 80;
            }
            return price;
        }

        private void Information()
        {
            message = "Customer Number: "+customernumber+"\nCustomer Name: " + customerNameTextBox.Text +
                "\nContact No: "+ contactNoTextBox.Text +
                "\nAddress: " + addressTextBox.Text +
                "\nOrder: " + orderComboBox.Text +
                "\nQuantity: " + quantityTextBox.Text +
                "\nTotal Price: " + price;

            richTextBox.Text = message;
            customernumber++;
            Clear();
        }

        public void Clear()
        {
            customerNameTextBox.Text = "";
            contactNoTextBox.Text = "";
            addressTextBox.Text = "";
            orderComboBox.Text = "";
            quantityTextBox.Text = "";
        }

        private void ShowInformation()
        {
            richTextBox.Text = "";

            for(int i=0;i<order.Count;i++)
            {
                message += "\n\nCustomer No: " + (i+1) + "\nCustomer Name: " + customername[i] + "\nContact No: " +
                    contactno[i] + "\nAddress: " + address[i] + "\nOrder: " + order[i] + "\nQuantity: " +
                    quantity[i]+"\nTotal Price: "+totalprice[i]+
                    "\n.......\n";
            }
            richTextBox.Text = message;
        }
    }
}

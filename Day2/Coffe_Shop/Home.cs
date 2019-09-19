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
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 0;
            int b = Convert.ToInt32(quantityTextBox.Text);
            
            richTextBox.Text +="Name:"+ customerNameTextBox.Text+"\n";
            richTextBox.Text += "Contact No: "+contactNoTextBox.Text+"\n";
            richTextBox.Text +="Address: "+ addressTextBox.Text+"\n";
            richTextBox.Text +="Order: " +orderComboBox.Text+"\n";
            richTextBox.Text +="Quantity: " +quantityTextBox.Text+"\n";
            
            richTextBox.Text += "Per Order Price: " + orderComboBox.Text.ToString()+"\n";

            if (orderComboBox.SelectedItem.ToString() == "Black-120")
            {
                a = 120;
                richTextBox.Text += "Total Price: " + a * b;
            }
            else if (orderComboBox.SelectedItem.ToString() == "Cold-100")
            {
                a = 100;
                richTextBox.Text += "Total Price: " + a * b;
            }
            else if (orderComboBox.SelectedItem.ToString() == "Hot-90")
            {
                a = 90;
                richTextBox.Text += "Total Price: " + a * b;
            }
            else if (orderComboBox.SelectedItem.ToString() == "Regular-80")
            {
                a = 80;
                richTextBox.Text += "Total Price: " + a * b;
            }
        }
    }
}

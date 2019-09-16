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
        const int size = 10;
        string[] array = new string[size];
        int[] array1 = new int[size];
        public Home()
        {
            

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            array[0] = customerNameTextBox.Text;
            array[1] = contactNoTextBox.Text;
            array[2] = addressTextBox.Text;
            array[3] = orderComboBox.Text;
            array1[0] = Convert.ToInt32(quantityTextBox.Text);
            int price = 0;

            if(array[3]=="Black")
            {
                price = array1[0] * 120;
            }
            if(array[3]=="Cold")
            {
                price = array1[0] * 100;
            }
            if(array[3]=="Hot")
            {
                price = array1[0] * 90;
            }
            if(array[3]=="Regular")
            {
                price = array1[0] * 80;
            }
            
            richTextBox.AppendText("\nCustomer Name: "+array[0]+"\nContact No: "+array[1]+"\nAddress: "+array[2]
                +"\nOdder: "+array[3]+"\nQuantity: "+array1[0]+"\n Total Price: "+price+"\n");
            customerNameTextBox.Text = " ";
            contactNoTextBox.Text = " ";
            addressTextBox.Text = " ";
            orderComboBox.Text = " ";
            quantityTextBox.Text = " ";

        }
    }
}

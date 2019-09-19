using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrayReverse
{
    public partial class Home : Form
    {
        const int size = 10;
        int a = 0;
        int[] element = new int[size];
        string message = "";


        public Home()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < a; i++)
            {
                element[i] = i;
            }
            for (int index = a - 1; index >= 0; index--)
            {
                message += element[index];
            }
            MessageBox.Show(message);
        }

        private void inputSizeButton_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(inputSizeTextBox.Text);
            inputSizeTextBox.Text = "";
            MessageBox.Show("Size: " + a);
        }
    }
}

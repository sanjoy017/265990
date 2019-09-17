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
    public partial class ListExample : Form
    {
        List<string> names = new List<string> {"Sanjoy"};
        
        public ListExample()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            
            names.Add(nameTextBox.Text);
            

            //for (int i = 0; i < name.Count; i++)
            //{

            //    message += "Name: " + name[i] + "\n";
            //}
            ShowCustomer();
            
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            ShowCustomer();

        }
        private void ShowCustomer()
        {
            string message = "";
            foreach (string name in names)
            {
                message += "Name: " + name + "\n";
            }

            MessageBox.Show(message);

        }
    }
        
}

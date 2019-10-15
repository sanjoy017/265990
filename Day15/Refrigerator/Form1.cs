using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using  Refrigerator.Model;

namespace Refrigerator
{
    public partial class refrigeratorForm : Form
    {
        Refrigeartor _refrigeartor;
        public refrigeratorForm()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            _refrigeartor=new Refrigeartor(double.Parse(maxWightTextBox.Text));
            maxWightTextBox.ReadOnly = true;

        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            double itemWeight = double.Parse(weightUnitTextBox.Text);

            if (itemWeight <= _refrigeartor.MaximumWeight)
            {
                currentTextBox.Text = _refrigeartor.CurrentWeight(double.Parse(weightUnitTextBox.Text)) +" ";
                remainingTextBox.Text = _refrigeartor.RemainingWeight() +" ";
            }
            else
            {
                MessageBox.Show("Overflow");
            }

        }
    }
}

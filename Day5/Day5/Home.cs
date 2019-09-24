using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day5
{
    public partial class Home : Form
    {
        List<string> id = new List<string> { };
        List<string> name = new List<string> { };
        List<string> mobile = new List<string> { };
        List<string> age = new List<string> { };
        List<string> address = new List<string> { };
        List<string> gpa = new List<string> { };

        public Home()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddInformation();

        }
        private void AddInformation()
        {
            
            
        }
        Boolean check = false;
        
    }
}

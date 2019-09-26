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

namespace ItemInformation
{
    public partial class Item : Form
    {
        public Item()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string connectionString = @"Server=PC-301-20\SQLEXPRESS; Database=CoffeShop; Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            string commandstring = @"INSERT INTO Items (Name, Price) Values ('" + nameTextBox.Text + "'," + priceTextBox.Text + ")";
            SqlCommand sqlCommand = new SqlCommand(commandstring, sqlConnection);

            sqlConnection.Open();

            sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();

        }

        private void showButton_Click(object sender, EventArgs e)
        {
            string connectionString = @"Server=PC-301-20\SQLEXPRESS; Database=CoffeShop; Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            string commandstring = @"SELECT * FROM Items";
            SqlCommand sqlCommand = new SqlCommand(commandstring, sqlConnection);

            sqlConnection.Open();

           // sqlCommand.ExecuteNonQuery();

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

            DataTable dataTable = new DataTable();

            sqlDataAdapter.Fill(dataTable);

            showDataGridView.DataSource = dataTable;
            

            sqlConnection.Close();


        }


    }
}

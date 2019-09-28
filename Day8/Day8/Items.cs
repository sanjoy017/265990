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

namespace Day8
{
    public partial class Items : Form
    {
        public Items()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Connection();
        }
        private void Connection()
        {
            try
            {
                //connection...
                string connectionString = @"Server=Sanjoy-PC; Database=CoffeShop; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //Command
                string commandString = @"INSERT INTO ItemsInformation(OrderName) VALUES('" + orderTextBox.Text + "')";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                //Connection Open
                sqlConnection.Open();

                int isexcuted = sqlCommand.ExecuteNonQuery();
                if (isexcuted > 0)
                {
                    MessageBox.Show("Your Information Add Sucessfully");
                }
                else
                {
                    MessageBox.Show("Not Add Your Information");
                }

                //Close
                sqlConnection.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }


        }

        private void showButton_Click(object sender, EventArgs e)
        {
            ShowInformation();
        }
        private void ShowInformation()
        {
            try
            {
                //connection...
                string connectionString = @"Server=Sanjoy-PC; Database=CoffeShop; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //Command
                string commandString = @"SELECT * FROM ItemsInformation";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                //Connection Open
                sqlConnection.Open();

                //show
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();

                itemsGataGridView.DataSource = dataTable;

                sqlDataAdapter.Fill(dataTable);



                //Close
                sqlConnection.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void Delete()
        {
            try
            {
                //connection...
                string connectionString = @"Server=Sanjoy-PC; Database=CoffeShop; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //Command
                string commandString = @"DELETE FROM ItemsInformation WHERE ID=" + idTextBox.Text + "";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                //Connection Open
                sqlConnection.Open();

                int isexcuted = sqlCommand.ExecuteNonQuery();
                if (isexcuted > 0)
                {
                    MessageBox.Show("Your Information Deleted Sucessfully");
                }
                else
                {
                    MessageBox.Show("Not Delete Your Information");
                }

                //Close
                sqlConnection.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            Update();
        }

        private void Update()
        {
            try
            {
                //connection...
                string connectionString = @"Server=Sanjoy-PC; Database=CoffeShop; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //Command
                string commandString = @"UPDATE ItemsInformation SET OrderName='" + orderTextBox.Text + "' WHERE ID='" + idTextBox.Text + "'";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                //Connection Open
                sqlConnection.Open();

                int isexcuted = sqlCommand.ExecuteNonQuery();
                if (isexcuted > 0)
                {
                    MessageBox.Show("Your Information Updated Sucessfully");
                }
                else
                {
                    MessageBox.Show("Not Update Your Information");
                }

                //Close
                sqlConnection.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }


        }
    }
}

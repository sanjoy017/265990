using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Day8.BLL;
using Day8.Model;

namespace Day8.Repository
{
    public class ItemRepository
    {
        

        public bool Connection(Item item)
        {
            bool isAdd = false;
            try
            {
                //connection...
                string connectionString = @"Server=Sanjoy-PC; Database=CoffeShop; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //Command
                string commandString = @"INSERT INTO ItemsInformation(OrderName) VALUES('" +item.Items+ "')";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                //Connection Open
                sqlConnection.Open();

                int isexcuted = sqlCommand.ExecuteNonQuery();
                if (isexcuted > 0)
                {
                    return isAdd;
                }
                else
                {
                    // MessageBox.Show("Not Add Your Information");
                }

                //Close
                sqlConnection.Close();
            }
            catch (Exception exception)
            {
                // MessageBox.Show(exception.Message);
            }

            return isAdd;
        }

        public DataTable ShowItemInformation()
        {
            //Connection
            string connectionString = @"Server=Sanjoy-PC; Database=CoffeShop; Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            //Command 
            //INSERT INTO Items (Name, Price) Values ('Black', 120)
            string commandString = @"SELECT * FROM ItemsInformation";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

            //Open
            sqlConnection.Open();

            //Show
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);


            //if (dataTable.Rows.Count > 0)
            //{
            //    return dataTable;
            //    //showDataGridView.DataSource = dataTable;
            //}
            //else
            //{
            //    MessageBox.Show("No Data Found");
            //}

            //Close
            sqlConnection.Close();
            return dataTable;

        }
        public bool IsItemExists(string item)
        {
            bool exists = false;
            try
            {
                //Connection
                string connectionString = @"Server=BITM-TRAINER-30\SQLEXPRESS; Database=CoffeeShop; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //Command 
                //INSERT INTO Items (Name, Price) Values ('Black', 120)
                string commandString = @"SELECT * FROM ItemsInformation WHERE Name='" + item + "'";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                //Open
                sqlConnection.Open();
                //Show
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                if (dataTable.Rows.Count > 0)
                {
                    exists = true;
                }
                //Close
                sqlConnection.Close();

            }
            catch (Exception exeption)
            {
                //MessageBox.Show(exeption.Message);
            }

            return exists;
        }
        public bool Delete(int id)
        {
            if (!(id == 0))
            {
                try
                {
                    //connection...
                    string connectionString = @"Server=Sanjoy-PC; Database=CoffeShop; Integrated Security=True";
                    SqlConnection sqlConnection = new SqlConnection(connectionString);

                    //Command
                    string commandString = @"DELETE FROM ItemsInformation WHERE ID=" + id + "";
                    SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                    //Connection Open
                    sqlConnection.Open();

                    int isexcuted = sqlCommand.ExecuteNonQuery();
                    if (isexcuted > 0)
                    {
                        return true;
                    }
                    else
                    {
                        // MessageBox.Show("Not Delete Your Information");
                    }

                    //Close
                    sqlConnection.Close();
                }
                catch (Exception exception)
                {
                    // MessageBox.Show(exception.Message);
                }
            }
            return false;

        }
        public bool Update(string name,int id)
        {
            try
            {
                //connection...
                string connectionString = @"Server=Sanjoy-PC; Database=CoffeShop; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //Command
                string commandString = @"UPDATE ItemsInformation SET OrderName='" + name + "' WHERE ID='" + id + "'";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                //Connection Open
                sqlConnection.Open();

                int isexcuted = sqlCommand.ExecuteNonQuery();
                if (isexcuted > 0)
                {
                    return true;
                }
                else
                {
                   // MessageBox.Show("Not Update Your Information");
                }

                //Close
                sqlConnection.Close();
            }
            catch (Exception exception)
            {
              //  MessageBox.Show(exception.Message);
            }

            return false;
        }
    }
}

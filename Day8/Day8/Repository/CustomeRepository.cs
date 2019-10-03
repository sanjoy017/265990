using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using Day8.BLL;
using Day8.Model;

namespace Day8.Repository
{
    public class CustomeRepository
    {
        public bool Add(Customer customer)
        {
            bool isAdded = false;
            try
            {
                if (!(customer.CustomerName == "" || customer.Contact == 0 || customer.Address == ""))
                {
                    string connectionString = @"Server=Sanjoy-PC; Database=CoffeShop; Integrated Security=True";
                    SqlConnection sqlConnection = new SqlConnection(connectionString);

                    string commandString = @"INSERT INTO CustomerInformation(CustomerName,ContactNo,Address) VALUES('" + customer.CustomerName + "','" + customer.Contact + "','" + customer.Address + "')";
                    SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                    sqlConnection.Open();
                    int isexcuted = sqlCommand.ExecuteNonQuery();
                    if (isexcuted > 0)
                    {
                        return isAdded;
                    }


                    //Close
                    sqlConnection.Close();
                }
                else
                {
                    //MessageBox.Show("You must fill up all form");
                }
            }
            catch (Exception exception)
            {
               // MessageBox.Show(exception.Message);
            }
            return isAdded;
        }
        public bool IsNameExists(string name)
        {
            bool exists = false;
            try
            {
                //connection...
                string connectionString = @"Server=Sanjoy-PC; Database=CoffeShop; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //Command
                string commandString = @"SELECT * FROM CustomerInformation WHERE CustomerName LIKE '%" + name + "%'";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                //Connection Open
                sqlConnection.Open();

                //show
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
            catch (Exception exception)
            {
               // MessageBox.Show(exception.Message);
            }
            return exists;

        }
        public bool Delete(Delete delete)
        {
            
            try
            {
                if (!(delete.Id==0))
                {

                    //connection...
                    string connectionString = @"Server=Sanjoy-PC; Database=CoffeShop; Integrated Security=True";
                    SqlConnection sqlConnection = new SqlConnection(connectionString);

                    //Command
                    string commandString = @"DELETE FROM CustomerInformation WHERE ID=" + delete.Id + "";
                    SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                    //Connection Open
                    sqlConnection.Open();

                    int isexcuted = sqlCommand.ExecuteNonQuery();
                    if (isexcuted > 0)
                    {
                        return true;
                    }

                    sqlConnection.Close();
                }
                else
                {
                   // MessageBox.Show("Insert id field");
                }
            }

            catch (Exception exception)
            {
               // MessageBox.Show(exception.Message);
            }
            return false;

        }
        public DataTable ShowInformation()
        {

            //Connection
            string connectionString = @"Server=Sanjoy-PC; Database=CoffeShop; Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            //Command 
            //INSERT INTO Items (Name, Price) Values ('Black', 120)
            string commandString = @"SELECT * FROM CustomerInformation";
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
        public bool Update(Update update)
        {
            try
            {
                //connection...
                string connectionString = @"Server=Sanjoy-PC; Database=CoffeShop; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //Command
                string commandString = @"UPDATE CustomerInformation SET CustomerName='" + update.Name + "',ContactNo='" + update.Contact + "',Address='" + update.Address + "' WHERE ID='" + update.Id + "'";
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
               // MessageBox.Show(exception.Message);
            }
            return false;

        }
        public DataTable Search(Search search)
        {
            DataTable dataTable = new DataTable();
            bool success = false;
            try
            {
                //connection...
                string connectionString = @"Server=Sanjoy-PC; Database=CoffeShop; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //Command
                string commandString = @"SELECT * FROM CustomerInformation WHERE CustomerName LIKE '%" + search.Name + "%'";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                //Connection Open
                sqlConnection.Open();

                //show
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                
                sqlDataAdapter.Fill(dataTable);
                if (dataTable.Rows.Count > 0)
                {
                    success = true;

                }
                
                //Close
                sqlConnection.Close();
            }
            catch (Exception exception)
            {
               // MessageBox.Show(exception.Message);
            }
            if (success)
            {
                return dataTable;
            }
            else
            {
                dataTable = null;
                return dataTable;
            }
            
        }

        


    }
}

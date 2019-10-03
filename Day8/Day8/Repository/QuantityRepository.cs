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
    
    public class QuantityRepository
    {
        public bool Connection(int quantity)
        {
            bool isAdd = false;
            try
            {
                //connection...
                string connectionString = @"Server=Sanjoy-PC; Database=CoffeShop; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //Command
                string commandString = @"INSERT INTO QuantityInformation(Quantity) VALUES('" +quantity+ "')";
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
        public DataTable ShowInformation()
        {
            
                //connection...
                string connectionString = @"Server=Sanjoy-PC; Database=CoffeShop; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //Command
                string commandString = @"SELECT * FROM QuantityInformation";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                //Connection Open
                sqlConnection.Open();

                //show
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);



                //Close
                sqlConnection.Close();
                return dataTable;
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
                    string commandString = @"DELETE FROM QuantityInformation WHERE ID=" + id + "";
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
                        //MessageBox.Show("Not Delete Your Information");
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
        public bool Update(int quantity,int id)
        {
            try
            {
                //connection...
                string connectionString = @"Server=Sanjoy-PC; Database=CoffeShop; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //Command
                string commandString = @"UPDATE QuantityInformation SET Quantity='" + quantity + "' WHERE ID='" + id + "'";
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


    }
    }


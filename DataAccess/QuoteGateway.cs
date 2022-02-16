using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tech.PracticalAplications.FactoryMethod.MyApp.DataAccess
{
    public class QuoteGateway
    {
        public static DataSet FindAllQuotes()
        {
            try
            {
                string connetionString;
                SqlConnection cnn;

                connetionString = "Server = localhost; Database = MyAppFactoryMethod; Integrated Security = SSPI";

                using (cnn = new SqlConnection(connetionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    adapter.TableMappings.Add("Table", "Quote");
                    cnn.Open();
                    SqlCommand command = new SqlCommand("SP_FindAllQuotes", cnn);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    adapter.SelectCommand = command;
                    DataSet dataSet = new DataSet("Quotes");
                    adapter.Fill(dataSet);
                    return dataSet;
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }

        public static DataSet FindQuoteByID(int ID)
        {
            try
            {
                string connetionString;
                SqlConnection cnn;

                connetionString = "Server = localhost; Database = MyAppFactoryMethod; Integrated Security = SSPI";

                using (cnn = new SqlConnection(connetionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    adapter.TableMappings.Add("Table", "Quote");
                    cnn.Open();
                    SqlCommand command;

                    using (command = new SqlCommand("SP_FindQuoteByID", cnn))
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@ID", ID);
                        adapter.SelectCommand = command;
                        DataSet dataSet = new DataSet("Quotes");
                        adapter.Fill(dataSet);
                        return dataSet;
                    }
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }

        public static bool UpdateQuote(int ID, DateTime date, string line, string author)
        {
            try
            {
                string connetionString;
                SqlConnection cnn;

                connetionString = "Server = localhost; Database = MyAppFactoryMethod; Integrated Security = SSPI";

                using (cnn = new SqlConnection(connetionString))
                {
                    cnn.Open();
                    SqlCommand command;

                    using (command = new SqlCommand("SP_UpdateQuote", cnn))
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@ID", ID);
                        command.Parameters.AddWithValue("@Date", date);
                        command.Parameters.AddWithValue("@Line", line);
                        command.Parameters.AddWithValue("@Author", author);
                        command.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

        public static bool InsertQuote(int ID, DateTime date, string line, string author)
        {
            try
            {
                string connetionString;
                SqlConnection cnn;

                connetionString = "Server = localhost; Database = MyAppFactoryMethod; Integrated Security = SSPI";

                using (cnn = new SqlConnection(connetionString))
                {
                    cnn.Open();
                    SqlCommand command;

                    using (command = new SqlCommand("SP_InsertQuote", cnn))
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@ID", ID);
                        command.Parameters.AddWithValue("@Date", date);
                        command.Parameters.AddWithValue("@Line", line);
                        command.Parameters.AddWithValue("@Author", author);
                        command.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

        public static bool DeleteQuote(int ID)
        {
            try
            {
                string connetionString;
                SqlConnection cnn;

                connetionString = "Server = localhost; Database = MyAppFactoryMethod; Integrated Security = SSPI";

                using (cnn = new SqlConnection(connetionString))
                {
                    cnn.Open();
                    SqlCommand command;

                    using (command = new SqlCommand("SP_DeleteQuote", cnn))
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@ID", ID);
                        command.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }
    }
}

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
    public class LinkGateway
    {     
        public static DataSet FindAllLinks()
        {
            try
            {
                string connetionString;
                SqlConnection cnn;
                 
                connetionString = "Server = localhost; Database = MyAppFactoryMethod; Integrated Security = SSPI";
                
                using (cnn = new SqlConnection(connetionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    adapter.TableMappings.Add("Table", "Link");
                    cnn.Open();
                    SqlCommand command = new SqlCommand("SP_FindAllLinks", cnn);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    adapter.SelectCommand = command;
                    DataSet dataSet = new DataSet("Links");
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

        public static DataSet FindLinkByID(int ID)
        {
            try
            {
                string connetionString;
                SqlConnection cnn;

                connetionString = "Server = localhost; Database = MyAppFactoryMethod; Integrated Security = SSPI";

                using (cnn = new SqlConnection(connetionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    adapter.TableMappings.Add("Table", "Link");
                    cnn.Open();
                    SqlCommand command;

                    using (command = new SqlCommand("SP_FindLinkByID", cnn))
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@ID", ID);
                        adapter.SelectCommand = command;
                        DataSet dataSet = new DataSet("Links");
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

        public static bool UpdateLink(int ID, string name, string line)
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

                    using (command = new SqlCommand("SP_UpdateLink", cnn))
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@ID", ID);
                        command.Parameters.AddWithValue("@Name", name);
                        command.Parameters.AddWithValue("@Line", line);
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

        public static bool InsertLink(int ID, string name, string line)
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

                    using (command = new SqlCommand("SP_InsertLink", cnn))
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@ID", ID);
                        command.Parameters.AddWithValue("@Name", name);
                        command.Parameters.AddWithValue("@Line", line);
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

        public static bool DeleteLink(int ID)
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

                    using (command = new SqlCommand("SP_DeleteLink", cnn))
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

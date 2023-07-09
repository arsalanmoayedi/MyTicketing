using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace MyTicketing 
{
    class TicketingRepository : ITicketingRepository
    {
        private string ConnectioString = "Data Source =.;Initial Catalog=Contact_DB;Integrated security=true";
        public bool Delete(int contactID)
        {
            SqlConnection connection = new SqlConnection(ConnectioString);
            try
            {
                string query = "delete from MyTicketing where contactid=@contactid ";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@contactid", contactID);
                connection.Open();
                command.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
            finally
            {
                connection.Close();
            }
        }

        //public bool Insert(string name, string family, string number, string email, string title, string description)
        //{
        //    SqlConnection connection = new SqlConnection(ConnectioString);
        //    try
        //    {
        //        string query = "insert into MyTicketing (name,family,number,email,tiltile,description,) values (@name,@family,@number,@email,@title,@description)";
        //        SqlCommand command = new SqlCommand(query, connection);
        //        command.Parameters.AddWithValue("@name", name);
        //        command.Parameters.AddWithValue("@family", family);
        //        command.Parameters.AddWithValue("@number", number);
        //        command.Parameters.AddWithValue("@email", email);
        //        command.Parameters.AddWithValue("@title", title);
        //        command.Parameters.AddWithValue("@description", description);
        //        connection.Open();
        //        command.ExecuteNonQuery();
        //        return true;
        //    }
        //    catch (Exception)
        //    {

        //        return false;
        //    }
        //    finally
        //    {
        //        connection.Close();
        //    }
        //}

        public bool Insert(string name, string family, string number, string email, string title, string description)
        {
            SqlConnection connection = new SqlConnection(ConnectioString);
            try
            {
                string query = "insert into MyTicketing (name,family,number,email,tiltile,description) values (@name,@family,@number,@email,@title,@description)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@family", family);
                command.Parameters.AddWithValue("@number", number);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@title", title);
                command.Parameters.AddWithValue("@description", description);
              //  command.Parameters.AddWithValue("@answer", answer);
                connection.Open();
                command.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
            finally
            {
                connection.Close();
            }
        }

        public bool Insertanswer(int contactid ,string answer)
        {
            SqlConnection connection = new SqlConnection(ConnectioString);
            try
            {
                string query = "update MyTicketing set  answer=@answer where contactid=@contactid";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@answer", answer);
                command.Parameters.AddWithValue("@contactid", contactid);
                connection.Open();
                command.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
            finally
            {
                connection.Close();
            }
        }

        public DataTable SelectAll()
        {
            string Query = "select * from MyTicketing";
            SqlConnection connection = new SqlConnection(ConnectioString);
            SqlDataAdapter adapter = new SqlDataAdapter(Query, connection);
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;
        }

        public DataTable SelectRow(int contactID)
        {
            string Query = "select * from MyTicketing where contactid="+contactID;
            SqlConnection connection = new SqlConnection(ConnectioString);
            SqlDataAdapter adapter = new SqlDataAdapter(Query, connection);
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;
        }
    }
}

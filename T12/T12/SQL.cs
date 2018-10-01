using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace T12
{
    class SQL
    {
        SqlConnection MyConnection;
        private void CreateConnection()
        {
            try
            {
                MyConnection = new SqlConnection("Data Source=185.101.93.152;Integrated Security=False;User ID=SA;Password=Voimamiina-12;Application Name=30");
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Connection Error:" + e);
            }
        }

        public void OpenConnection()
        {
            CreateConnection();

            try
            {
                MyConnection.Open();
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Connection Error:" + e);
            }
        }

        public void CloseConnection()
        {
            if (MyConnection != null) MyConnection.Close();
        }

        public Array GetData(int type)
        {
            switch (type)
            {
                default:
                    return null;
            }
        }

        private Array SQLQuery(String Query)
        {

            try
            {

                SqlDataReader dataReader = null;
                SqlCommand command = new SqlCommand(Query, MyConnection);

                dataReader = command.ExecuteReader();

                dataReader.GetValues();
            }
            catch (Exception e)
            {

                throw;
            }

            

        }
    }
}

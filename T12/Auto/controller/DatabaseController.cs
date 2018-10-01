using System.Data.Sql;
using Auto;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Auto.controller
{
    public class DatabaseController
    {
        private  SqlConnection connection;


        public DatabaseController()
        {
            connection = new SqlConnection("Server=185.101.93.152;Database=autokauppa;User Id=SA;Password=Voimamiina-12;");
        }

        public bool connectDatabase()
        {
            try
            {
                this.connection.Open();
                return true;
            }
            catch(Exception e)
            { 
                Console.WriteLine("Virheilmoitukset:" + e);
                this.connection.Close();
                return false;

            }
            
        }

        public void disconnectDatabase()
        {
            this.connection.Close();
        }

        public bool saveAutoIntoDatabase(Auto.model.Auto newAuto)
        {
            try
            {
                connection.Open();

                SqlDataReader reader;
                SqlCommand getAll = new SqlCommand("INSERT INTO auto(Hinta,Rekisteri_paivamaara,Moottorin_tilavuus,Mittarilukema,AutonMerkkiID,AutonMalliID,VaritID,PolttoaineID) VALUES (" + newAuto.Hinta + "," + "'2018-09-20'" + "," + newAuto.Moottorin_tilavuus + "," + newAuto.Mittarilukema + "," + newAuto.AutonMerkki + "," + newAuto.AutonMalli + "," + newAuto.Varit + "," + newAuto.Polttoaine + ");", connection);

                reader = getAll.ExecuteReader();

                reader.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        public List<string> getAllAutoMakersFromDatabase()
        {
            connection.Open();

            SqlDataReader reader;
            SqlCommand getAll = new SqlCommand("SELECT Merkki FROM AutonMerkki", connection);

            reader = getAll.ExecuteReader();

            List<string> s = (from IDataRecord r in reader select (string)r["Merkki"]).ToList();

            reader.Close();
            connection.Close();

            return s;
        }

        public List<string> getAutoModelsByMakerId(int makerId) 
        {
            connection.Open();
            SqlDataReader reader;
            SqlCommand getAll = new SqlCommand("SELECT Auton_mallin_nimi FROM AutonMallit WHERE AutonMerkkiId=" + makerId.ToString(), connection);
            reader = getAll.ExecuteReader();
            List<string> s = (from IDataRecord r in reader select (string)r["Auton_mallin_nimi"]).ToList();
            reader.Close();
            connection.Close();
            return s;
        }

        public List<string> getAllPoltoaineetFromDatabase()
        {
            connection.Open();
            SqlDataReader reader;

            SqlCommand getAll = new SqlCommand("SELECT Polttoaineen_nimi FROM Polttoaine", connection);

            reader = getAll.ExecuteReader();

            List<string> s = (from IDataRecord r in reader select (string)r["Polttoaineen_nimi"]).ToList();

            reader.Close();
            connection.Close();

            return s;
        }

        public List<string> getAllVaritFromDatabase()
        {
            connection.Open();

            SqlDataReader reader;
            SqlCommand getAll = new SqlCommand("SELECT Varin_nimi FROM Varit", connection);

            reader = getAll.ExecuteReader();

            List<string> s = (from IDataRecord r in reader select (string)r["Varin_nimi"]).ToList();

            reader.Close();
            connection.Close();
            return s;
        }

        public List<string> GetAutoFromDatabase(int id)
        {
            List<string> Data = new List<string> { };
            connection.Open();
            SqlDataReader reader;
            SqlCommand getAll = new SqlCommand("SELECT * FROM auto WHERE ID=" + id.ToString(), connection);
            reader = getAll.ExecuteReader();
            while(reader.Read())
            {
                Data.Add(reader.GetDecimal(1).ToString()); ;
                Data.Add(reader.GetDateTime(2).ToString().Replace(" 0.00.00", ""));
                Data.Add(reader.GetDecimal(3).ToString());
                Data.Add(reader.GetInt32(4).ToString());
                Data.Add(reader.GetInt32(5).ToString());
                Data.Add(reader.GetInt32(6).ToString());
                Data.Add(reader.GetInt32(7).ToString());
                Data.Add(reader.GetInt32(8).ToString());
            }
            reader.Close();
            connection.Close();
            return Data;
        }

        public List<string> GetAllModelsFromDatabase()
        {
            connection.Open();
            SqlDataReader reader;
            SqlCommand getAll = new SqlCommand("SELECT Auton_mallin_nimi FROM AutonMallit", connection);
            reader = getAll.ExecuteReader();
            List<string> s = (from IDataRecord r in reader select (string)r["Auton_mallin_nimi"]).ToList();
            reader.Close();
            connection.Close();
            return s;
        }
    }
}

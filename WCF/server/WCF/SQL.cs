using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace WCF
{
    public class SQL
    {
        SqlConnection MyConnection;
        private void CreateConnection()
        {
            MyConnection = new SqlConnection("Server = 185.101.93.152; Database = autokauppa; User Id = DBuser;Password = 1234;");
        }

        private void OpenConnection()
        {
            CreateConnection();
            MyConnection.Open();
        }

        public bool IDCheck(int id)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand("SELECT ID FROM auto where ID = " + id + ";", MyConnection);
            SqlDataReader reader;

            reader = cmd.ExecuteReader();

            return reader.HasRows;
        }

        public decimal SelectHintaData(int id)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand("SELECT Hinta FROM auto where ID = " + id + ";", MyConnection);
            SqlDataReader reader;

            reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Read();
                decimal DCData = decimal.Parse(reader[0].ToString());
                return DCData;
            }
            else
            {
                return 0;
            }
        }

        public string SelectDateData(int id)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand("SELECT Rekisteri_paivamaara FROM auto where ID = " + id + ";", MyConnection);
            SqlDataReader reader;

            reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Read();
                string DataS = reader[0].ToString();
                string[] DataSA = DataS.Split(' ');
                return DataSA[0];
            }
            else
            {
                return null;
            }
        }

        public decimal SelectMTData(int id)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand("SELECT Moottorin_tilavuus FROM auto where ID = " + id + ";", MyConnection);
            SqlDataReader reader;

            reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Read();
                decimal DCData = decimal.Parse(reader[0].ToString());
                return DCData;
            }
            else
            {
                return 0;
            }
        }

        public int SelectMLData(int id)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand("SELECT Mittarilukema FROM auto where ID = " + id + ";", MyConnection);
            SqlDataReader reader;

            reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Read();
                int MLData = int.Parse(reader[0].ToString());
                return MLData;
            }
            else
            {
                return 0;
            }
        }

        public string SelectAMData(int id)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand("SELECT AutonMerkkiID FROM auto where ID = " + id + ";", MyConnection);
            SqlDataReader reader;

            reader = cmd.ExecuteReader();

            int autonmerkkiid = 0;

            reader.Read();
            autonmerkkiid = int.Parse(reader[0].ToString());

            reader.Close();
            cmd.Dispose();

            SqlCommand cmdMerkki = new SqlCommand("SELECT Merkki FROM AutonMerkki where ID = " + autonmerkkiid + ";", MyConnection);
            SqlDataReader readerMerkki;

            readerMerkki = cmdMerkki.ExecuteReader();

            if (readerMerkki.HasRows)
            {
                readerMerkki.Read();
                return readerMerkki[0].ToString();
            }
            else
            {
                return null;
            }
        }

        public string SelectAUMData(int id)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand("SELECT AutonMalliID FROM auto where ID = " + id + ";", MyConnection);
            SqlDataReader reader;

            reader = cmd.ExecuteReader();

            int autonmalliid = 0;

            reader.Read();
            autonmalliid = int.Parse(reader[0].ToString());

            reader.Close();
            cmd.Dispose();

            SqlCommand cmdMalli = new SqlCommand("SELECT Auton_mallin_nimi FROM AutonMallit where ID = " + autonmalliid + ";", MyConnection);
            SqlDataReader readerMalli;

            readerMalli = cmdMalli.ExecuteReader();

            if (readerMalli.HasRows)
            {
                readerMalli.Read();
                return readerMalli[0].ToString();
            }
            else
            {
                return null;
            }
        }

        public string SelectVData(int id)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand("SELECT VaritID FROM auto where ID = " + id + ";", MyConnection);
            SqlDataReader reader;

            reader = cmd.ExecuteReader();

            int V = 0;

            reader.Read();
            V = int.Parse(reader[0].ToString());

            reader.Close();
            cmd.Dispose();

            SqlCommand cmdVari = new SqlCommand("SELECT Varin_nimi FROM Varit where ID = " + V + ";", MyConnection);
            SqlDataReader readerVari;

            readerVari = cmdVari.ExecuteReader();

            if (readerVari.HasRows)
            {
                readerVari.Read();
                return readerVari[0].ToString();
            }
            else
            {
                return null;
            }
        }

        public string SelectPData(int id)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand("SELECT PolttoaineID FROM auto where ID = " + id + ";", MyConnection);
            SqlDataReader reader;

            reader = cmd.ExecuteReader();

            int P = 0;

            reader.Read();
            P = int.Parse(reader[0].ToString());

            reader.Close();
            cmd.Dispose();

            SqlCommand cmdP = new SqlCommand("SELECT Polttoaineen_nimi FROM Polttoaine where ID = " + P + ";", MyConnection);
            SqlDataReader readerP;

            readerP = cmdP.ExecuteReader();

            if (readerP.HasRows)
            {
                readerP.Read();
                return readerP[0].ToString();
            }
            else
            {
                return null;
            }
        }

        public void InsertData()
        {
            
        } 
    }
}
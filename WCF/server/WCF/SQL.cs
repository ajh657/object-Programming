﻿using System;
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
    }
}
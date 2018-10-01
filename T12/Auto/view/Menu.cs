using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Auto;

namespace Auto.view
{
    public partial class Menu : Form
    {
        private int id = 10491;
        controller.AutoRegisterHandler autoRegisterHandler = new Auto.controller.AutoRegisterHandler();
        controller.DatabaseController dataBaseController = new Auto.controller.DatabaseController();

        public Menu()
        {
            InitializeComponent();
            foreach(string s in dataBaseController.getAllAutoMakersFromDatabase())
            {
                comboBox1.Items.Add(s);
            }
            foreach(string s in dataBaseController.getAllPoltoaineetFromDatabase())
            {
                comboBox3.Items.Add(s);
            }
            foreach(string s in dataBaseController.getAllVaritFromDatabase())
            {
                comboBox4.Items.Add(s);
            }
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void testaaTietokantayhteyttäToolStripMenuItem_Click(object sender, EventArgs e)
        {
            autoRegisterHandler = new controller.AutoRegisterHandler();
            if (autoRegisterHandler.TestDatabaseConnection())
            {
                MessageBox.Show("Toimii");
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            foreach (string s in dataBaseController.getAutoModelsByMakerId(comboBox1.SelectedIndex + 1))
            {
                comboBox2.Items.Add(s);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            comboBox4.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            model.Auto auto = new model.Auto();
            int.TryParse(textBox1.Text, out int mittariLukema);
            int.TryParse(textBox2.Text, out int moottorinTilavuus);
            int.TryParse(textBox3.Text, out int hinta);
            auto.Mittarilukema = mittariLukema;
            auto.Moottorin_tilavuus = moottorinTilavuus;
            auto.Hinta = hinta;
            auto.AutonMerkki = comboBox1.SelectedIndex + 1;
            auto.AutonMalli = comboBox2.SelectedIndex + 1;
            auto.Polttoaine = comboBox3.SelectedIndex + 1;
            auto.Varit = comboBox4.SelectedIndex + 1;
            dataBaseController.saveAutoIntoDatabase(auto);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            List<string> s = dataBaseController.GetAutoFromDatabase(id+1);
            Browse(s);
            id++;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            List<string> s = dataBaseController.GetAutoFromDatabase(id-1);
            Browse(s);
            id--;
        }

        private void Browse(List<string> s)
        {
            try
            {
                List<string> a = dataBaseController.GetAllModelsFromDatabase();
                textBox1.Text = s[3];
                textBox2.Text = s[2];
                textBox3.Text = s[0];
                int.TryParse(s[4], out int merkkiID);
                comboBox1.SelectedIndex = merkkiID - 1;
                int.TryParse(s[5], out int malliID);
                comboBox2.Items.Clear();
                foreach (string e in dataBaseController.getAutoModelsByMakerId(comboBox1.SelectedIndex + 1))
                {
                    comboBox2.Items.Add(e);
                }
                comboBox2.SelectedIndex = comboBox2.Items.IndexOf(a[malliID - 425]);
                int.TryParse(s[7], out int polttoaineID);
                comboBox3.SelectedIndex = polttoaineID - 1;
                /// int.TryParse(s[6], out int variID);
                /// comboBox4.SelectedIndex = variID - 1;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

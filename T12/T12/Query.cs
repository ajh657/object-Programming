using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T12
{
    public partial class Query : Form
    {
        SQL DataBase = new SQL();
        public Query()
        {
            InitializeComponent();
            DataBase.OpenConnection();
        }

        private void Query_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}

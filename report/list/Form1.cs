using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace list
{
    public partial class Form1 : Form
    {
        DataSet ds = new DataSet();
        public Form1()
        {
            InitializeComponent();
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            bool bCheckTable = false;

            if (ds.Tables.Contains(comboBox_check.Text))
            {
                bCheckTable = true;
            }

            DataTable dt = null;
        }

        private void delbutton_Click(object sender, EventArgs e)
        {

        }
    }
}

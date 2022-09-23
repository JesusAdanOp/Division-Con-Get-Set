using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Division_Con_Get_Set
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cldivision div = new cldivision();
            div.V1 = double.Parse(txtv1.Text);
            div.V2 = double.Parse(txtv2.Text);

            txtres.Text = div.dividir().ToString();
        }
    }
}

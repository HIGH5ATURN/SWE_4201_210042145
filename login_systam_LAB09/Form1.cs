using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login_systam_LAB09
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void form1_to_reg_button_Click(object sender, EventArgs e)
        {
            Reg regis= new Reg();

            this.Hide();
            regis.Show();
        }
    }
}

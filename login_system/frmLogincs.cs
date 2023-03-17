using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace login_system
{
    public partial class frmLogincs : Form
    {
        public frmLogincs()
        {
            InitializeComponent();
        }
      
        
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_users.mdb");

        OleDbCommand cmd = new OleDbCommand();

        OleDbDataAdapter da = new OleDbDataAdapter();

        private void gunaGradientTileButton1_Click(object sender, EventArgs e)
        {
            con.Open();
            string login = "SELECT * FROM tbl_users where username= '" + txtusername.Text + "'and password= '" + txtPassword.Text + "'";
            cmd = new OleDbCommand(login, con);
            OleDbDataReader dr =cmd.ExecuteReader();

            if(dr.Read())
            {
                new dashboard().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password,Please Try again","Login Failed",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtusername.Text = "";
                txtPassword.Text = "";
                txtusername.Focus();
            }
        }

        private void checkBxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBxShowPassword.Checked)
            {
                txtPassword.PasswordChar = '\0';
               
            }
            else
            {
                txtPassword.PasswordChar = 'X';
               
            }
        }

        private void gunaLinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new frmRegister().Show();
            this.Hide();
        }

        private void gunaControlBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            Application.Exit();
        }
    }
}

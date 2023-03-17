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
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();

        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_users.mdb");

        OleDbCommand cmd = new OleDbCommand();

        OleDbDataAdapter da = new OleDbDataAdapter();

        private void frmRegister_Load(object sender, EventArgs e)
        {

        }

        private void gunaGradientTileButton1_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text=="" && txtpassword.Text=="" && txtComPassword.Text=="")
            {
                MessageBox.Show("Username and password fields are empty","Registration failed",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else if(txtpassword.Text==txtComPassword.Text)
            {
                con.Open();

                string register = "INSERT INTO tbl_users Values('" + txtUsername.Text + "','" + txtpassword.Text + "')";

                cmd = new OleDbCommand(register,con);
                cmd.ExecuteNonQuery();
                con.Close();

                txtUsername.Text = "";
                txtpassword.Text = "";
                txtComPassword.Text = "";

                MessageBox.Show("Your account has been succesfully created");


            }
            else
            {
                MessageBox.Show("passwords does not match, Please re-enter","registration failed",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtpassword.Text = "";
                txtComPassword.Text = "";
                txtpassword.Focus();
            }
        }

        private void checkBxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBxShowPassword.Checked)
            {
                txtpassword.PasswordChar = '\0';
                txtComPassword.PasswordChar = '\0';
            }
            else
            {
                txtpassword.PasswordChar = '*';
                txtComPassword.PasswordChar = '*';
            }
        }

        private void gunaLinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new frmLogincs().Show();
            this.Hide();
        }

        private void gunaControlBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            Application.Exit();
        }
    }
}

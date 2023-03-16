using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace login_systam_LAB09
{
    public partial class login : Form
    {
        string file = @"D:\git csharp lab\login_systam_LAB09\bin\Debug\Username1.txt";
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

        private void login_Button_Click(object sender, EventArgs e)
        {
            if(File.Exists(file))
            {
                string[]lines= File.ReadAllLines(file);

                bool name = false;
                bool pass = false;
                foreach(string line in lines)
                {
                    if(lin_name_textBox.Text == line) { name = true; }
                    
                    if(lin_pass_textBox.Text == line) { pass = true;}
                    if(name && pass)
                    {
                        this.Hide();
                        dashboard dash = new dashboard();

                        dash.Show();
                        break;
                    }
                }
            }
        }
    }
}

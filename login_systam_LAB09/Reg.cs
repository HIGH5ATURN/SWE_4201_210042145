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
    public partial class Reg : Form
    {
        public Reg()
        {
            InitializeComponent();
        }

        int x = 0;
        private void sign_up_Button_Click(object sender, EventArgs e)
        {
           
            if(first_pass_textbox.Text==check_pass_textbox.Text)
            {
                x++;
                using(StreamWriter sw =  new StreamWriter($"Username{x}.txt"))
                {
                    sw.WriteLine(reg_u_name.Text);
                    sw.WriteLine(first_pass_textbox.Text);
                    sw.WriteLine(reg_name.Text);
                }
                
                login log = new login();
                this.Hide();
                log.Show();
                
            }
            else
            {
                MessageBox.Show("Please retype the correct password!");
            }
        }
    }
}

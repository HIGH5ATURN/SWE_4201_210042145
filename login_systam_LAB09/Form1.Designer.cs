namespace login_systam_LAB09
{
    partial class login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lin_name_textBox = new System.Windows.Forms.TextBox();
            this.lin_pass_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.login_Button = new Guna.UI.WinForms.GunaGradientTileButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.form1_to_reg_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 286);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "User-name :";
            // 
            // lin_name_textBox
            // 
            this.lin_name_textBox.BackColor = System.Drawing.SystemColors.Control;
            this.lin_name_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lin_name_textBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lin_name_textBox.Location = new System.Drawing.Point(140, 288);
            this.lin_name_textBox.Name = "lin_name_textBox";
            this.lin_name_textBox.Size = new System.Drawing.Size(270, 23);
            this.lin_name_textBox.TabIndex = 1;
            // 
            // lin_pass_textBox
            // 
            this.lin_pass_textBox.BackColor = System.Drawing.SystemColors.Control;
            this.lin_pass_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lin_pass_textBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lin_pass_textBox.Location = new System.Drawing.Point(141, 332);
            this.lin_pass_textBox.Name = "lin_pass_textBox";
            this.lin_pass_textBox.Size = new System.Drawing.Size(270, 23);
            this.lin_pass_textBox.TabIndex = 3;
            this.lin_pass_textBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 334);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password :";
            // 
            // login_Button
            // 
            this.login_Button.Animated = true;
            this.login_Button.AnimationHoverSpeed = 0.07F;
            this.login_Button.AnimationSpeed = 0.03F;
            this.login_Button.BackColor = System.Drawing.Color.Transparent;
            this.login_Button.BaseColor1 = System.Drawing.Color.MidnightBlue;
            this.login_Button.BaseColor2 = System.Drawing.Color.SkyBlue;
            this.login_Button.BorderColor = System.Drawing.Color.Black;
            this.login_Button.DialogResult = System.Windows.Forms.DialogResult.None;
            this.login_Button.FocusedColor = System.Drawing.Color.Empty;
            this.login_Button.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_Button.ForeColor = System.Drawing.Color.White;
            this.login_Button.Image = null;
            this.login_Button.ImageSize = new System.Drawing.Size(52, 52);
            this.login_Button.Location = new System.Drawing.Point(67, 393);
            this.login_Button.Name = "login_Button";
            this.login_Button.OnHoverBaseColor1 = System.Drawing.Color.SkyBlue;
            this.login_Button.OnHoverBaseColor2 = System.Drawing.Color.MidnightBlue;
            this.login_Button.OnHoverBorderColor = System.Drawing.Color.Black;
            this.login_Button.OnHoverForeColor = System.Drawing.Color.White;
            this.login_Button.OnHoverImage = null;
            this.login_Button.OnPressedColor = System.Drawing.Color.Black;
            this.login_Button.Radius = 20;
            this.login_Button.Size = new System.Drawing.Size(269, 88);
            this.login_Button.TabIndex = 4;
            this.login_Button.Text = "LOGIN";
            this.login_Button.Click += new System.EventHandler(this.login_Button_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Location = new System.Drawing.Point(141, 313);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(269, 1);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel2.Location = new System.Drawing.Point(141, 361);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(269, 1);
            this.panel2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(76, 498);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Don\'t have an account?";
            // 
            // form1_to_reg_button
            // 
            this.form1_to_reg_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.form1_to_reg_button.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.form1_to_reg_button.ForeColor = System.Drawing.Color.Red;
            this.form1_to_reg_button.Location = new System.Drawing.Point(304, 492);
            this.form1_to_reg_button.Name = "form1_to_reg_button";
            this.form1_to_reg_button.Size = new System.Drawing.Size(106, 40);
            this.form1_to_reg_button.TabIndex = 8;
            this.form1_to_reg_button.Text = "Create One!";
            this.form1_to_reg_button.UseVisualStyleBackColor = true;
            this.form1_to_reg_button.Click += new System.EventHandler(this.form1_to_reg_button_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 571);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.form1_to_reg_button);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.login_Button);
            this.Controls.Add(this.lin_pass_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lin_name_textBox);
            this.Controls.Add(this.label1);
            this.Name = "login";
            this.Text = "LOGIN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lin_name_textBox;
        private System.Windows.Forms.TextBox lin_pass_textBox;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaGradientTileButton login_Button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button form1_to_reg_button;
    }
}


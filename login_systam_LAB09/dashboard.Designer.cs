namespace login_systam_LAB09
{
    partial class dashboard
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
            this.label4 = new System.Windows.Forms.Label();
            this.log_out_Button = new Guna.UI.WinForms.GunaGradientTileButton();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(167, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 41);
            this.label4.TabIndex = 18;
            this.label4.Text = "Hello ! ";
            // 
            // log_out_Button
            // 
            this.log_out_Button.Animated = true;
            this.log_out_Button.AnimationHoverSpeed = 0.07F;
            this.log_out_Button.AnimationSpeed = 0.03F;
            this.log_out_Button.BackColor = System.Drawing.Color.Transparent;
            this.log_out_Button.BaseColor1 = System.Drawing.Color.MidnightBlue;
            this.log_out_Button.BaseColor2 = System.Drawing.Color.SkyBlue;
            this.log_out_Button.BorderColor = System.Drawing.Color.Black;
            this.log_out_Button.DialogResult = System.Windows.Forms.DialogResult.None;
            this.log_out_Button.FocusedColor = System.Drawing.Color.Empty;
            this.log_out_Button.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log_out_Button.ForeColor = System.Drawing.Color.White;
            this.log_out_Button.Image = null;
            this.log_out_Button.ImageSize = new System.Drawing.Size(52, 52);
            this.log_out_Button.Location = new System.Drawing.Point(238, 413);
            this.log_out_Button.Name = "log_out_Button";
            this.log_out_Button.OnHoverBaseColor1 = System.Drawing.Color.SkyBlue;
            this.log_out_Button.OnHoverBaseColor2 = System.Drawing.Color.MidnightBlue;
            this.log_out_Button.OnHoverBorderColor = System.Drawing.Color.Black;
            this.log_out_Button.OnHoverForeColor = System.Drawing.Color.White;
            this.log_out_Button.OnHoverImage = null;
            this.log_out_Button.OnPressedColor = System.Drawing.Color.Black;
            this.log_out_Button.Radius = 20;
            this.log_out_Button.Size = new System.Drawing.Size(269, 44);
            this.log_out_Button.TabIndex = 19;
            this.log_out_Button.Text = "LOG OUT";
            // 
            // dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 569);
            this.Controls.Add(this.log_out_Button);
            this.Controls.Add(this.label4);
            this.Name = "dashboard";
            this.Text = "dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaGradientTileButton log_out_Button;
    }
}
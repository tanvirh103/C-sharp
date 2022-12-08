namespace fw2
{
    partial class Registration
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
            this.lblname = new System.Windows.Forms.Label();
            this.lblpass = new System.Windows.Forms.Label();
            this.lbldate = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnsign = new System.Windows.Forms.Button();
            this.lbllogo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblname.Location = new System.Drawing.Point(83, 92);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(60, 21);
            this.lblname.TabIndex = 0;
            this.lblname.Text = "Name :";
            // 
            // lblpass
            // 
            this.lblpass.AutoSize = true;
            this.lblpass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblpass.Location = new System.Drawing.Point(83, 136);
            this.lblpass.Name = "lblpass";
            this.lblpass.Size = new System.Drawing.Size(83, 21);
            this.lblpass.TabIndex = 1;
            this.lblpass.Text = "Password :";
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lbldate.Location = new System.Drawing.Point(83, 217);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(111, 21);
            this.lbldate.TabIndex = 2;
            this.lbldate.Text = "Date OF Birth :";
            this.lbldate.Click += new System.EventHandler(this.lbldate_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblEmail.Location = new System.Drawing.Point(83, 174);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(56, 21);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Email :";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblPhone.Location = new System.Drawing.Point(83, 257);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(123, 21);
            this.lblPhone.TabIndex = 4;
            this.lblPhone.Text = "Phone Number :";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(186, 90);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(214, 23);
            this.txtname.TabIndex = 5;
            this.txtname.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(186, 174);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(214, 23);
            this.textBox2.TabIndex = 6;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(212, 255);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(188, 23);
            this.textBox3.TabIndex = 7;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(186, 134);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(214, 23);
            this.textBox4.TabIndex = 8;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(200, 215);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 9;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // btnsign
            // 
            this.btnsign.ForeColor = System.Drawing.Color.IndianRed;
            this.btnsign.Location = new System.Drawing.Point(256, 307);
            this.btnsign.Name = "btnsign";
            this.btnsign.Size = new System.Drawing.Size(75, 23);
            this.btnsign.TabIndex = 10;
            this.btnsign.Text = "Sign Up!";
            this.btnsign.UseVisualStyleBackColor = true;
            this.btnsign.Click += new System.EventHandler(this.btnsign_Click);
            // 
            // lbllogo
            // 
            this.lbllogo.AutoSize = true;
            this.lbllogo.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbllogo.ForeColor = System.Drawing.Color.Black;
            this.lbllogo.Location = new System.Drawing.Point(271, 33);
            this.lbllogo.Name = "lbllogo";
            this.lbllogo.Size = new System.Drawing.Size(78, 25);
            this.lbllogo.TabIndex = 11;
            this.lbllogo.Text = "Sign UP";
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbllogo);
            this.Controls.Add(this.btnsign);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lbldate);
            this.Controls.Add(this.lblpass);
            this.Controls.Add(this.lblname);
            this.Name = "Registration";
            this.Text = "Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblname;
        private Label lblpass;
        private Label lbldate;
        private Label lblEmail;
        private Label lblPhone;
        private TextBox txtname;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private DateTimePicker dateTimePicker1;
        private Button btnsign;
        private Label lbllogo;
    }
}
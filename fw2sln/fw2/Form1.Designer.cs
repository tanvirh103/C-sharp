namespace fw2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblSgnin = new System.Windows.Forms.Label();
            this.lbluname = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnLgn = new System.Windows.Forms.Button();
            this.link = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lblSgnin
            // 
            this.lblSgnin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSgnin.AutoSize = true;
            this.lblSgnin.BackColor = System.Drawing.Color.Transparent;
            this.lblSgnin.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSgnin.ForeColor = System.Drawing.Color.Black;
            this.lblSgnin.Location = new System.Drawing.Point(219, 54);
            this.lblSgnin.Name = "lblSgnin";
            this.lblSgnin.Size = new System.Drawing.Size(80, 22);
            this.lblSgnin.TabIndex = 0;
            this.lblSgnin.Text = "Sign in";
            this.lblSgnin.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbluname
            // 
            this.lbluname.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbluname.AutoSize = true;
            this.lbluname.BackColor = System.Drawing.Color.Transparent;
            this.lbluname.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbluname.ForeColor = System.Drawing.Color.Black;
            this.lbluname.Location = new System.Drawing.Point(73, 121);
            this.lbluname.Name = "lbluname";
            this.lbluname.Size = new System.Drawing.Size(100, 22);
            this.lbluname.TabIndex = 1;
            this.lbluname.Text = "User Name";
            // 
            // lblPass
            // 
            this.lblPass.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPass.AutoSize = true;
            this.lblPass.BackColor = System.Drawing.Color.Transparent;
            this.lblPass.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPass.ForeColor = System.Drawing.Color.Black;
            this.lblPass.Location = new System.Drawing.Point(83, 184);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(90, 22);
            this.lblPass.TabIndex = 2;
            this.lblPass.Text = "Password";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(179, 120);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(142, 23);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(179, 184);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(142, 23);
            this.textBox2.TabIndex = 4;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btnLgn
            // 
            this.btnLgn.Location = new System.Drawing.Point(202, 257);
            this.btnLgn.Name = "btnLgn";
            this.btnLgn.Size = new System.Drawing.Size(87, 26);
            this.btnLgn.TabIndex = 6;
            this.btnLgn.Text = "Log In";
            this.btnLgn.UseVisualStyleBackColor = true;
            this.btnLgn.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // link
            // 
            this.link.AutoSize = true;
            this.link.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.link.Location = new System.Drawing.Point(219, 299);
            this.link.Name = "link";
            this.link.Size = new System.Drawing.Size(70, 15);
            this.link.TabIndex = 7;
            this.link.TabStop = true;
            this.link.Text = "Registration";
            this.link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(510, 450);
            this.Controls.Add(this.link);
            this.Controls.Add(this.btnLgn);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lbluname);
            this.Controls.Add(this.lblSgnin);
            this.Name = "Form1";
            this.Text = "System Architect Authentication";
            this.TransparencyKey = System.Drawing.SystemColors.ActiveBorder;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblSgnin;
        private Label lbluname;
        private Label lblPass;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button btnLgn;
        private LinkLabel link;
    }
}

namespace Bussiness_Manager
{
    partial class Form1
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
            this.PnlLogin = new System.Windows.Forms.Panel();
            this.PnlRegister = new System.Windows.Forms.Panel();
            this.X = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.linkRegister = new System.Windows.Forms.LinkLabel();
            this.LabelLogin = new System.Windows.Forms.Label();
            this.BtnExit = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BtnLoginHome = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labelUserName = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.PnlTitle = new System.Windows.Forms.Panel();
            this.labelTitleLogin = new System.Windows.Forms.Label();
            this.PnlLogin.SuspendLayout();
            this.PnlRegister.SuspendLayout();
            this.PnlTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlLogin
            // 
            this.PnlLogin.Controls.Add(this.PnlRegister);
            this.PnlLogin.Controls.Add(this.linkRegister);
            this.PnlLogin.Controls.Add(this.LabelLogin);
            this.PnlLogin.Controls.Add(this.BtnExit);
            this.PnlLogin.Controls.Add(this.textBox1);
            this.PnlLogin.Controls.Add(this.BtnLoginHome);
            this.PnlLogin.Controls.Add(this.textBox2);
            this.PnlLogin.Controls.Add(this.labelUserName);
            this.PnlLogin.Controls.Add(this.labelPassword);
            this.PnlLogin.Location = new System.Drawing.Point(585, 11);
            this.PnlLogin.Name = "PnlLogin";
            this.PnlLogin.Size = new System.Drawing.Size(525, 522);
            this.PnlLogin.TabIndex = 9;
            this.PnlLogin.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlLogin_Paint);
            // 
            // PnlRegister
            // 
            this.PnlRegister.Controls.Add(this.X);
            this.PnlRegister.Controls.Add(this.textBox6);
            this.PnlRegister.Controls.Add(this.label6);
            this.PnlRegister.Controls.Add(this.textBox5);
            this.PnlRegister.Controls.Add(this.label10);
            this.PnlRegister.Controls.Add(this.label7);
            this.PnlRegister.Controls.Add(this.textBox3);
            this.PnlRegister.Controls.Add(this.button4);
            this.PnlRegister.Controls.Add(this.textBox4);
            this.PnlRegister.Controls.Add(this.label8);
            this.PnlRegister.Controls.Add(this.label9);
            this.PnlRegister.Location = new System.Drawing.Point(3, 512);
            this.PnlRegister.Name = "PnlRegister";
            this.PnlRegister.Size = new System.Drawing.Size(525, 10);
            this.PnlRegister.TabIndex = 9;
            // 
            // X
            // 
            this.X.Location = new System.Drawing.Point(454, 35);
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(48, 40);
            this.X.TabIndex = 22;
            this.X.UseVisualStyleBackColor = true;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(64, 344);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(331, 22);
            this.textBox6.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(59, 304);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 24);
            this.label6.TabIndex = 20;
            this.label6.Text = "Confirm Password";
            // 
            // textBox5
            // 
            this.textBox5.CausesValidation = false;
            this.textBox5.Location = new System.Drawing.Point(63, 191);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(331, 22);
            this.textBox5.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label10.Location = new System.Drawing.Point(59, 154);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 24);
            this.label10.TabIndex = 18;
            this.label10.Text = "Email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label7.Location = new System.Drawing.Point(56, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 39);
            this.label7.TabIndex = 15;
            this.label7.Text = "Sign Up";
            // 
            // textBox3
            // 
            this.textBox3.CausesValidation = false;
            this.textBox3.Location = new System.Drawing.Point(63, 111);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(331, 22);
            this.textBox3.TabIndex = 11;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.Highlight;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button4.Location = new System.Drawing.Point(63, 378);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(330, 41);
            this.button4.TabIndex = 9;
            this.button4.Text = "Register";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(64, 269);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(331, 22);
            this.textBox4.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label8.Location = new System.Drawing.Point(60, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 24);
            this.label8.TabIndex = 13;
            this.label8.Text = "User Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label9.Location = new System.Drawing.Point(59, 227);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 24);
            this.label9.TabIndex = 14;
            this.label9.Text = "Password";
            // 
            // linkRegister
            // 
            this.linkRegister.AutoSize = true;
            this.linkRegister.Location = new System.Drawing.Point(215, 430);
            this.linkRegister.Name = "linkRegister";
            this.linkRegister.Size = new System.Drawing.Size(0, 17);
            this.linkRegister.TabIndex = 8;
            this.linkRegister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkRegister_LinkClicked);
            // 
            // LabelLogin
            // 
            this.LabelLogin.AutoSize = true;
            this.LabelLogin.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelLogin.ForeColor = System.Drawing.SystemColors.Highlight;
            this.LabelLogin.Location = new System.Drawing.Point(56, 29);
            this.LabelLogin.Name = "LabelLogin";
            this.LabelLogin.Size = new System.Drawing.Size(121, 39);
            this.LabelLogin.TabIndex = 6;
            this.LabelLogin.Text = "LOGIN";
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnExit.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.BtnExit.Location = new System.Drawing.Point(95, 373);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(329, 40);
            this.BtnExit.TabIndex = 1;
            this.BtnExit.Text = "EXIT";
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // textBox1
            // 
            this.textBox1.CausesValidation = false;
            this.textBox1.Location = new System.Drawing.Point(93, 159);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(331, 22);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // BtnLoginHome
            // 
            this.BtnLoginHome.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnLoginHome.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLoginHome.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.BtnLoginHome.Location = new System.Drawing.Point(93, 317);
            this.BtnLoginHome.Name = "BtnLoginHome";
            this.BtnLoginHome.Size = new System.Drawing.Size(329, 41);
            this.BtnLoginHome.TabIndex = 0;
            this.BtnLoginHome.Text = "LOGIN";
            this.BtnLoginHome.UseVisualStyleBackColor = false;
            this.BtnLoginHome.Click += new System.EventHandler(this.BtnLoginHome_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(93, 246);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(331, 22);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelUserName.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserName.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelUserName.Location = new System.Drawing.Point(88, 114);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(107, 19);
            this.labelUserName.TabIndex = 4;
            this.labelUserName.Text = "USERNAME: ";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelPassword.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelPassword.Location = new System.Drawing.Point(91, 207);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(111, 19);
            this.labelPassword.TabIndex = 5;
            this.labelPassword.Text = "PASSWORD: ";
            // 
            // PnlTitle
            // 
            this.PnlTitle.BackColor = System.Drawing.SystemColors.Highlight;
            this.PnlTitle.Controls.Add(this.labelTitleLogin);
            this.PnlTitle.Location = new System.Drawing.Point(10, 11);
            this.PnlTitle.Name = "PnlTitle";
            this.PnlTitle.Size = new System.Drawing.Size(557, 522);
            this.PnlTitle.TabIndex = 8;
            // 
            // labelTitleLogin
            // 
            this.labelTitleLogin.AutoSize = true;
            this.labelTitleLogin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTitleLogin.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleLogin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelTitleLogin.Location = new System.Drawing.Point(86, 180);
            this.labelTitleLogin.Name = "labelTitleLogin";
            this.labelTitleLogin.Size = new System.Drawing.Size(351, 46);
            this.labelTitleLogin.TabIndex = 0;
            this.labelTitleLogin.Text = "Business Manager";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 545);
            this.Controls.Add(this.PnlLogin);
            this.Controls.Add(this.PnlTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.PnlLogin.ResumeLayout(false);
            this.PnlLogin.PerformLayout();
            this.PnlRegister.ResumeLayout(false);
            this.PnlRegister.PerformLayout();
            this.PnlTitle.ResumeLayout(false);
            this.PnlTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlLogin;
        private System.Windows.Forms.Panel PnlRegister;
        private System.Windows.Forms.Button X;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.LinkLabel linkRegister;
        private System.Windows.Forms.Label LabelLogin;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button BtnLoginHome;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Panel PnlTitle;
        private System.Windows.Forms.Label labelTitleLogin;
    }
}


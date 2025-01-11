
namespace Bussiness_Manager
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.BtnBack = new System.Windows.Forms.Button();
            this.BtnEmployees = new System.Windows.Forms.Button();
            this.PnlMain1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnReset = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textBoxExp = new System.Windows.Forms.TextBox();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelExp = new System.Windows.Forms.Label();
            this.labelAge = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.dataDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataDataSet = new Bussiness_Manager.DataDataSet();
            this.PnlEnter = new System.Windows.Forms.Panel();
            this.BtnExit = new System.Windows.Forms.Button();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.experienceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.businessManagerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PnlMain1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet)).BeginInit();
            this.PnlEnter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.businessManagerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnBack
            // 
            this.BtnBack.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBack.Location = new System.Drawing.Point(29, 37);
            this.BtnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(216, 119);
            this.BtnBack.TabIndex = 5;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // BtnEmployees
            // 
            this.BtnEmployees.BackColor = System.Drawing.Color.White;
            this.BtnEmployees.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEmployees.Location = new System.Drawing.Point(33, 209);
            this.BtnEmployees.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnEmployees.Name = "BtnEmployees";
            this.BtnEmployees.Size = new System.Drawing.Size(213, 135);
            this.BtnEmployees.TabIndex = 3;
            this.BtnEmployees.Text = "Employees";
            this.BtnEmployees.UseVisualStyleBackColor = false;
            this.BtnEmployees.Click += new System.EventHandler(this.BtnEmployees_Click);
            // 
            // PnlMain1
            // 
            this.PnlMain1.BackColor = System.Drawing.SystemColors.Highlight;
            this.PnlMain1.Controls.Add(this.comboBox4);
            this.PnlMain1.Controls.Add(this.button1);
            this.PnlMain1.Controls.Add(this.BtnReset);
            this.PnlMain1.Controls.Add(this.BtnDelete);
            this.PnlMain1.Controls.Add(this.label2);
            this.PnlMain1.Controls.Add(this.comboBox2);
            this.PnlMain1.Controls.Add(this.label1);
            this.PnlMain1.Controls.Add(this.comboBox1);
            this.PnlMain1.Controls.Add(this.dataGridView1);
            this.PnlMain1.Controls.Add(this.buttonAdd);
            this.PnlMain1.Controls.Add(this.buttonClear);
            this.PnlMain1.Controls.Add(this.labelEmail);
            this.PnlMain1.Controls.Add(this.textBoxEmail);
            this.PnlMain1.Controls.Add(this.textBoxPhone);
            this.PnlMain1.Controls.Add(this.textBoxExp);
            this.PnlMain1.Controls.Add(this.textBoxAge);
            this.PnlMain1.Controls.Add(this.labelPhone);
            this.PnlMain1.Controls.Add(this.labelExp);
            this.PnlMain1.Controls.Add(this.labelAge);
            this.PnlMain1.Controls.Add(this.labelName);
            this.PnlMain1.Controls.Add(this.textBoxName);
            this.PnlMain1.Controls.Add(this.button2);
            this.PnlMain1.Location = new System.Drawing.Point(0, 0);
            this.PnlMain1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PnlMain1.Name = "PnlMain1";
            this.PnlMain1.Size = new System.Drawing.Size(763, 494);
            this.PnlMain1.TabIndex = 4;
            this.PnlMain1.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlMain1_Paint);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(137, 428);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 34);
            this.button1.TabIndex = 21;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // BtnReset
            // 
            this.BtnReset.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReset.Location = new System.Drawing.Point(8, 428);
            this.BtnReset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(75, 34);
            this.BtnReset.TabIndex = 20;
            this.BtnReset.Text = "Reset";
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.Location = new System.Drawing.Point(221, 369);
            this.BtnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(83, 34);
            this.BtnDelete.TabIndex = 19;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 19);
            this.label2.TabIndex = 18;
            this.label2.Text = "Spacielty";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Salesmen",
            "Customer service",
            "Towing service",
            "Road service"});
            this.comboBox2.Location = new System.Drawing.Point(172, 112);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 16;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 19);
            this.label1.TabIndex = 15;
            this.label1.Text = "Hire new: ";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Worker",
            "Contractor"});
            this.comboBox1.Location = new System.Drawing.Point(172, 62);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 14;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.experienceDataGridViewTextBoxColumn,
            this.PhoneNumber,
            this.Column1});
            this.dataGridView1.DataSource = this.businessManagerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(320, 66);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(424, 395);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.DataPropertyName = "PhoneNumber";
            this.PhoneNumber.HeaderText = "PhoneNumber";
            this.PhoneNumber.MinimumWidth = 6;
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Width = 125;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Email";
            this.Column1.HeaderText = "Email";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAdd.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(123, 372);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 32);
            this.buttonAdd.TabIndex = 12;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.Location = new System.Drawing.Point(8, 372);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(85, 32);
            this.buttonClear.TabIndex = 11;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelEmail.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(19, 313);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(63, 19);
            this.labelEmail.TabIndex = 10;
            this.labelEmail.Text = "Email :";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(115, 309);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(169, 22);
            this.textBoxEmail.TabIndex = 9;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(172, 265);
            this.textBoxPhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(111, 22);
            this.textBoxPhone.TabIndex = 8;
            this.textBoxPhone.TextChanged += new System.EventHandler(this.textBoxPhone_TextChanged);
            // 
            // textBoxExp
            // 
            this.textBoxExp.Location = new System.Drawing.Point(183, 229);
            this.textBoxExp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxExp.Name = "textBoxExp";
            this.textBoxExp.Size = new System.Drawing.Size(100, 22);
            this.textBoxExp.TabIndex = 7;
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(183, 190);
            this.textBoxAge.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(100, 22);
            this.textBoxAge.TabIndex = 6;
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelPhone.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhone.Location = new System.Drawing.Point(19, 268);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(137, 19);
            this.labelPhone.TabIndex = 5;
            this.labelPhone.Text = "PhoneNumber :";
            // 
            // labelExp
            // 
            this.labelExp.AutoSize = true;
            this.labelExp.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelExp.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExp.Location = new System.Drawing.Point(19, 231);
            this.labelExp.Name = "labelExp";
            this.labelExp.Size = new System.Drawing.Size(101, 19);
            this.labelExp.TabIndex = 4;
            this.labelExp.Text = "Experince :";
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelAge.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAge.Location = new System.Drawing.Point(19, 192);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(59, 19);
            this.labelAge.TabIndex = 3;
            this.labelAge.Text = "Age : ";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelName.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(19, 150);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(75, 19);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Name : ";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(183, 150);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 22);
            this.textBoxName.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(699, 15);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(45, 42);
            this.button2.TabIndex = 0;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Towing service",
            "Road service"});
            this.comboBox3.Location = new System.Drawing.Point(433, 144);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 24);
            this.comboBox3.TabIndex = 17;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // dataDataSetBindingSource
            // 
            this.dataDataSetBindingSource.DataSource = this.dataDataSet;
            this.dataDataSetBindingSource.Position = 0;
            // 
            // dataDataSet
            // 
            this.dataDataSet.DataSetName = "DataDataSet";
            this.dataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PnlEnter
            // 
            this.PnlEnter.BackColor = System.Drawing.SystemColors.Highlight;
            this.PnlEnter.Controls.Add(this.PnlMain1);
            this.PnlEnter.Location = new System.Drawing.Point(261, 37);
            this.PnlEnter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PnlEnter.Name = "PnlEnter";
            this.PnlEnter.Size = new System.Drawing.Size(763, 494);
            this.PnlEnter.TabIndex = 6;
            this.PnlEnter.TabStop = true;
            // 
            // BtnExit
            // 
            this.BtnExit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.Location = new System.Drawing.Point(33, 395);
            this.BtnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(213, 135);
            this.BtnExit.TabIndex = 7;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "Salesmen",
            "Customer service",
            "Towing service",
            "Road service"});
            this.comboBox4.Location = new System.Drawing.Point(172, 112);
            this.comboBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 24);
            this.comboBox4.TabIndex = 22;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "Age";
            this.ageDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            this.ageDataGridViewTextBoxColumn.Width = 125;
            // 
            // experienceDataGridViewTextBoxColumn
            // 
            this.experienceDataGridViewTextBoxColumn.DataPropertyName = "Experience";
            this.experienceDataGridViewTextBoxColumn.HeaderText = "Experience";
            this.experienceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.experienceDataGridViewTextBoxColumn.Name = "experienceDataGridViewTextBoxColumn";
            this.experienceDataGridViewTextBoxColumn.Width = 125;
            // 
            // businessManagerBindingSource
            // 
            this.businessManagerBindingSource.DataSource = typeof(Bussiness_Manager.BusinessManager);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 560);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.PnlEnter);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.BtnEmployees);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.PnlMain1.ResumeLayout(false);
            this.PnlMain1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet)).EndInit();
            this.PnlEnter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.businessManagerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Button BtnEmployees;
        private System.Windows.Forms.Panel PnlMain1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.TextBox textBoxExp;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelExp;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource dataDataSetBindingSource;
        private DataDataSet dataDataSet;
        private System.Windows.Forms.BindingSource businessManagerBindingSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn experienceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Panel PnlEnter;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox4;
    }
}
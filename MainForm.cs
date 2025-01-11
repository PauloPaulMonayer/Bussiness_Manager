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
using System.Runtime.Serialization.Formatters.Binary;

namespace Bussiness_Manager
{
    public partial class MainForm : Form
    {
        private Form1 _form1_ref = null;
        private bool _is_eployee_open = false;
        private BindingList<BusinessManager> _employe_list = new BindingList<BusinessManager>();
        private string userChoice;
        public MainForm(Form1 form1_ref)
        {
            InitializeComponent();
            this._form1_ref = form1_ref;
            this.PnlMain1.Hide();
            this.comboBox2.Hide();
            this.comboBox3.Hide();
            this.label2.Hide();
        }
        private void save_data(BindingList<BusinessManager> data, string file_directory)
        {
            using (FileStream fileStream = new FileStream(file_directory, FileMode.Create))
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(fileStream, data);
            }
        }
        private void load_data(string file_directory)
        {
            try
            {
                using(FileStream file_stream = new FileStream(file_directory, FileMode.Open))
                {
                    BinaryFormatter binaryFormatter = new BinaryFormatter();
                    this._employe_list = (BindingList<BusinessManager>)binaryFormatter.Deserialize(file_stream);
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show($"File not found: {file_directory}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            this._form1_ref.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MeExit();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            //string name = textBoxName.Text;
            //int age = Int32.Parse(textBoxAge.Text);
            //int experience = Int32.Parse(textBoxExp.Text);
            //int phonenumber = Int32.Parse(textBoxPhone.Text);
            //string email = textBoxEmail.Text;

            this.textBoxName.Text = "";
            this.textBoxAge.Text = "";
            this.textBoxExp.Text = "";
            this.textBoxPhone.Text = "";
            this.textBoxEmail.Text = "";


        }


        

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string new_staff = this.comboBox2.Text;
            BusinessManager user_add = null;
            switch (new_staff)
            {
                case "Salesmen":
                    user_add = new SalesMen(this.textBoxName.Text, int.Parse(this.textBoxAge.Text), int.Parse(this.textBoxExp.Text), int.Parse(this.textBoxPhone.Text), this.textBoxEmail.Text);
                    break;
                case "Customer service":
                    user_add = new CustomerService(this.textBoxName.Text, int.Parse(this.textBoxAge.Text), int.Parse(this.textBoxExp.Text), int.Parse(this.textBoxPhone.Text), this.textBoxEmail.Text, 0, 0);
                    break;
                case "Towing service":
                    user_add = new TowingServices(this.textBoxName.Text, int.Parse(this.textBoxAge.Text), int.Parse(this.textBoxExp.Text), int.Parse(this.textBoxPhone.Text), this.textBoxEmail.Text, 0, 0, 0);
                    break;
                case "Road service":
                    user_add = new Roadservices(this.textBoxName.Text, int.Parse(this.textBoxAge.Text), int.Parse(this.textBoxExp.Text), int.Parse(this.textBoxPhone.Text), this.textBoxEmail.Text, 0, 0, 0);
                    break;
                default:
                    MessageBox.Show("Please choose type.");
                    break;
            }
            if(user_add != null)
            {
                this._employe_list.Add(user_add);
            }
            else
            {
                MessageBox.Show("Error, please try again.");
            }
            this.refresh_grid();
            //dataGridView1.Rows.Add(textBoxName.Text, textBoxAge.Text, textBoxExp.Text, textBoxPhone.Text, textBoxEmail.Text);
            //if (IsValidForm())
            //{
            //    string name = textBoxName.Text;
            //    int age = Int32.Parse(textBoxAge.Text);
            //    int experience = Int32.Parse(textBoxExp.Text);
            //    int phonenumber = Int32.Parse(textBoxPhone.Text);
            //    string email = textBoxEmail.Text;


            //    //lbldisplay.text = name + " " + age + " " + experience + " " + phonenumber + " " + email + " ";


            //    display();

            //}
        }
        private bool IsValidForm()
        {
            int age;
            return Int32.TryParse(textBoxAge.Text, out age);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PnlMain1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnEmployees_Click(object sender, EventArgs e)
        {
            if (this._is_eployee_open == false)
            {
                this.PnlMain1.Show();
                this._is_eployee_open = true;
            }
            else
            {
                this.PnlMain1.Hide();
                this._is_eployee_open = false;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.load_data("Staff.bin");
            this.dataGridView1.DataSource = this._employe_list;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.comboBox1.Text == "Worker")
            {
                this.label2.Show();
                this.comboBox2.Show();
                this.comboBox4.Hide();
            }
            else if(this.comboBox1.Text == "Contractor")
            {
                this.label2.Show();
                this.comboBox4.Show();
                this.comboBox2.Hide();
            }
            else
            {
                this.label2.Hide();
                this.comboBox2.Hide();
                this.comboBox4.Hide();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            MeExit();
        }
        private void MeExit()
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Confirm if you want to Exit", "Save DataGridView", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (iExit==DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            iDelete();
        }

        private void iDelete()
        {
            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(item.Index);
            }
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            iReset();
        }

        private void iReset()
        {//=============================Clears All Data on Textbox=====================================
            foreach(var c in this.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text = string.Empty;
                }
            }


            //===========================Clears the DataGridView=================================
            int numRows = dataGridView1.Rows.Count;
            for(int i=0;i<numRows;i++)
            {
                try
                {
                    int max = dataGridView1.Rows.Count - 1;
                    dataGridView1.Rows.Remove(dataGridView1.Rows[max]);
                }
                catch(Exception exe)
                {
                    MessageBox.Show("All rows are to be deleted " + exe, "DataGridView Delete",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        public void refresh_grid()
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = this._employe_list;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.save_data(this._employe_list, "Staff.bin");
            MessageBox.Show("Saved!");
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPhone_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

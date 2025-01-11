using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bussiness_Manager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnLoginHome_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //MainForm BB = new MainForm(this);
            //BB.Show();

            if (textBox1.Text == "Paulom" && textBox2.Text == "12345" || textBox1.Text == "tomer7x" && textBox2.Text == "54321")
            {
                MainForm Enter = new MainForm(this);
                Enter.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void PnlLogin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
         
        }
    }
   
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch12_Prog_EX_CarDealer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btn_1990Bronco_Click(object sender, EventArgs e)
        { 
            Form2 f2 = new Form2();
            this.Hide();
            f2.ShowDialog();
          
        }

        private void label_address_Click(object sender, EventArgs e)
        {

        }

        private void label_directions_Click(object sender, EventArgs e)
        {

        }

        private void btn_1995Bronco_Click(object sender, EventArgs e)
       {
            Form3 f3 = new Form3();
            this.Hide();
            f3.ShowDialog();
        }

        private void btn_1985Bronco_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            this.Hide();
            f4.ShowDialog();
        }

        private void btn_1995Bronco_Click_1(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            this.Hide();
            f2.ShowDialog();
        }
    }
}

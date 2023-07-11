using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace Rezervasyon_Panel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Liste.Items.Add("Rota: " + comboBox1.Text + "-" + comboBox2.Text);
            Liste.Items.Add("Uçuþ Günü: " + maskedTextBox4.Text);
            Liste.Items.Add("Uçuþ Saati: " + maskedTextBox1.Text);
            Liste.Items.Add(" ");
            Liste.Items.Add(" ");
            Liste.Items.Add("Yolcu Adý SoyAdý: " + textBox1.Text);
            Liste.Items.Add("Yolcu Tc Kimlik No:" + maskedTextBox2.Text);
            Liste.Items.Add("Yolcu Telefon No: " + maskedTextBox3.Text);
            MessageBox.Show("Yolcu Kaydý Yapýldý.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label10.Text = comboBox2.Text;
            comboBox2.Text = comboBox1.Text;
            comboBox1.Text = label10.Text;


        }
    }
}
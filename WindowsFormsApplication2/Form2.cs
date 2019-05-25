using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            //layanan
            //0. Economic
            //1. Standard(Recommended)
            //2. OverNight
            //3. Same Day
        }

        private void comboBox2_selectedIndexChanged(object sender, EventArgs e)
        {
            //kota asal
            //0. Jakarta
            //1. Bandung
            //2. Semarang
            //3. Surabaya
            //4. Yogyakarta
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //kota tujuan
            //0. Jakarta
            //1. Bandung
            //2. Semarang
            //3. Surabaya
            //4. Yogyakarta
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Economic: Paket dengan harga ekonomis - Estimasi sampai > 4 hari \nStandard: Paket terlaris - Estimasi sampai 2-4 hari \nOverNight: Pengiriman paket dalam waktu semalam \nSame Day: Jaminan paket sampai pada hari yang sama");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            comboBox3.Items.Clear();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ekonomis = 3000;
            int standard = 6500;
            int overnight = 12000;
            int sameday = 16000;
            int berat;
            float ongkos;

            if (comboBox3.SelectedIndex == 0)
            {
                if (comboBox2.SelectedIndex == 0)
                {
                    if (comboBox1.SelectedIndex == 0)
                    {
                        ongkos = (ekonomis + 0) ;
                    }
                }
            }
        }
    }
}

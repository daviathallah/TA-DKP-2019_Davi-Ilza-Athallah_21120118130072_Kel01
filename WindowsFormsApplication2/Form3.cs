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
    public partial class Form3 : Form
    {

        public Form3()
        {
            InitializeComponent();
            ShowIcon = false;
            MinimizeBox = false;
            MaximizeBox = false;
        }

        private string content;
        private string services;
        private string citi;
        private string address;
        private string berat;
        private string note;
        private string ongkir;

        //getter resi

        public string isi
        {
            set { textBox3.Text = value; }
            get { return textBox3.Text; }
        }

        public string layanan
        {
            get { return comboBox1.Text; }
            set { services = value; }
        }

        public string kota
        {
            get { return comboBox2.Text; }
            set { comboBox2.Text = value; }
        }

        public string alamat
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }

        public string weight
        {
            get { return textBox2.Text; }
            set { textBox2.Text = value; }
        }

        public string catatan
        {
            get { return textBox5.Text; }
            set { textBox5.Text = value; }
        }

        public string ongkos
        {
            get { return textBox4.Text; }
            set { textBox4.Text = value; }
        }

        

        //GUI
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult info = MessageBox.Show(
                "Economic : Paket harga murah meriah\n" +
                "Regular  : Pengiriman kecepatan standar (2-4 hari)\n" +
                "OneNight : Pengiriman kebut semalam\n" +
                "Sameday  : Pengiriman akan sampai hari itu juga\n" ,
                "Information" ,
                MessageBoxButtons.OK ,
                MessageBoxIcon.Information);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //kota
        }

        public void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //jenis layanan
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //berat 

     
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (true)
            {
                    DialogResult asuransi = MessageBox.Show(
                    "Penggunaan asuransi akan menambah ongkos sebesar 20% dari ongkos normal\n" +
                    "Apakah anda ingin tetap memakai asuransi?",
                    "Warning",
                    MessageBoxButtons.YesNo ,
                    MessageBoxIcon.Warning);
            }

            else 
            {
                
            }
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }


        //button cek ongkos
        public void button4_Click(object sender, EventArgs e)
        {
            string services;
            string destination;
            float berat;
            float ongkos;
            string input;
            input = textBox2.Text;
            float.TryParse(input, out berat);
            services = comboBox1.SelectedItem.ToString();

            
            
            tarif rute = new tarif();
            
            //getter
            float jktsmg = rute.set_jktsmg;
            float smgsby = rute.set_smgsby;
            float smgyogya = rute.set_smgyogya;
            float sbysolo = rute.set_sbysolo;
            float soloyogya = rute.set_soloyogya;

            //setter
            rute.set_jktsmg = 20000;
            rute.set_smgsby = 15000;
            rute.set_smgyogya = 10000;
            rute.set_sbysolo = 18000;
            rute.set_soloyogya = 5000;
            

            if (comboBox1.SelectedItem.ToString() == "ECONOMIC")
            {
                float economic = 0.3F;

                destination = comboBox2.SelectedItem.ToString();
                if (comboBox2.SelectedItem.ToString() == "Jakarta - Semarang")
                {

                    ongkos = economic * rute.set_jktsmg * berat;
                    textBox4.Text = ongkos.ToString();
                }
                else if (comboBox2.SelectedItem.ToString() == "Jakarta - Surabaya")
                {
                    ongkos = economic * rute.set_jktsby * berat;
                    textBox4.Text = ongkos.ToString();
                }
                else if (comboBox2.SelectedItem.ToString() == "Semarang - Surabaya")
                {
                    ongkos = economic * rute.set_smgsby * berat;
                    textBox4.Text = ongkos.ToString();
                }
                else if (comboBox2.SelectedItem.ToString() == "Semarang - Yogya")
                {
                    ongkos = economic * rute.set_smgyogya * berat;
                    textBox4.Text = ongkos.ToString();
                }
                else if (comboBox2.SelectedItem.ToString() == "Surabaya - Solo")
                {
                    ongkos = economic * rute.set_sbysolo * berat;
                    textBox4.Text = ongkos.ToString();
                }
                else if (comboBox2.SelectedItem.ToString() == "Solo - Yogya")
                {
                    ongkos = economic * rute.set_soloyogya * berat;
                    
                }
            }


            else if (comboBox1.SelectedItem.ToString() == "REGULAR")
            {
                float regular = 0.6F;

                destination = comboBox2.SelectedItem.ToString();
                if (comboBox2.SelectedItem.ToString() == "Jakarta - Semarang")
                {

                    ongkos = regular * rute.set_jktsmg * berat;
                    textBox4.Text = ongkos.ToString();
                }
                else if (comboBox2.SelectedItem.ToString() == "Jakarta - Surabaya")
                {
                    ongkos = regular * rute.set_jktsby * berat;
                    textBox4.Text = ongkos.ToString();
                }
                else if (comboBox2.SelectedItem.ToString() == "Semarang - Surabaya")
                {
                    ongkos = regular * rute.set_smgsby * berat;
                    textBox4.Text = ongkos.ToString();
                }
                else if (comboBox2.SelectedItem.ToString() == "Semarang - Yogya")
                {
                    ongkos = regular * rute.set_smgyogya * berat;
                    textBox4.Text = ongkos.ToString();
                }
                else if (comboBox2.SelectedItem.ToString() == "Surabaya - Solo")
                {
                    ongkos = regular * rute.set_sbysolo * berat;
                    textBox4.Text = ongkos.ToString();
                }
                else if (comboBox2.SelectedItem.ToString() == "Solo - Yogya")
                {
                    ongkos = regular * rute.set_soloyogya * berat;
                    textBox4.Text = ongkos.ToString();
                }

            }

            else if (comboBox1.SelectedItem.ToString() == "ONE - NIGHT")
            {
                float onenight = 1.2F;
                destination = comboBox2.SelectedItem.ToString();
                if (comboBox2.SelectedItem.ToString() == "Jakarta - Semarang")
                {

                    ongkos = onenight * rute.set_jktsmg * berat;
                    textBox4.Text = ongkos.ToString();
                }
                else if (comboBox2.SelectedItem.ToString() == "Jakarta - Surabaya")
                {
                    ongkos = onenight * rute.set_jktsby * berat;
                    textBox4.Text = ongkos.ToString();
                }
                else if (comboBox2.SelectedItem.ToString() == "Semarang - Surabaya")
                {
                    ongkos = onenight * rute.set_smgsby * berat;
                    textBox4.Text = ongkos.ToString();
                }
                else if (comboBox2.SelectedItem.ToString() == "Semarang - Yogya")
                {
                    ongkos = onenight * rute.set_smgyogya * berat;
                    textBox4.Text = ongkos.ToString();
                }
                else if (comboBox2.SelectedItem.ToString() == "Surabaya - Solo")
                {
                    ongkos = onenight * rute.set_sbysolo * berat;
                    textBox4.Text = ongkos.ToString();
                }
                else if (comboBox2.SelectedItem.ToString() == "Solo - Yogya")
                {
                    ongkos = onenight * rute.set_soloyogya * berat;
                    textBox4.Text = ongkos.ToString();
                }


            }

            else if (comboBox1.SelectedItem.ToString() == "SAMEDAY")
            {
                float sameday = 2;

                destination = comboBox2.SelectedItem.ToString();
                if (comboBox2.SelectedItem.ToString() == "Jakarta - Semarang")
                {
                    ongkos = sameday * rute.set_jktsmg * berat;
                    textBox4.Text = ongkos.ToString();
                }
                else if (comboBox2.SelectedItem.ToString() == "Jakarta - Surabaya")
                {
                    ongkos = sameday * rute.set_jktsby * berat;
                    textBox4.Text = ongkos.ToString();
                }
                else if (comboBox2.SelectedItem.ToString() == "Semarang - Surabaya")
                {
                    ongkos = sameday * rute.set_smgsby * berat;
                    textBox4.Text = ongkos.ToString();
                }
                else if (comboBox2.SelectedItem.ToString() == "Semarang - Yogya")
                {
                    ongkos = sameday * rute.set_smgyogya * berat;
                    textBox4.Text = ongkos.ToString();
                }
                else if (comboBox2.SelectedItem.ToString() == "Surabaya - Solo")
                {
                    ongkos = sameday * rute.set_sbysolo * berat;
                    textBox4.Text = ongkos.ToString();
                }
                else if (comboBox2.SelectedItem.ToString() == "Solo - Yogya")
                {
                    ongkos = sameday * rute.set_soloyogya * berat;
                    textBox4.Text = ongkos.ToString();
                }

            }


        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            //ongkos
        }


        //process
        public void button2_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                DialogResult info = MessageBox.Show(
                "Silahkan cek ongkos dahulu sebelum melanjutkan!",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }

            else
            {
                
            }
        }

        public void button3_Click(object sender, EventArgs e)
        {
            Form3 menu = new Form3();
            menu.Show();
            Hide();
        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        public void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
           
            textBox4.Clear();
            textBox5.Clear();
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {
            //alamat
        }

        public void textBox5_TextChanged(object sender, EventArgs e)
        {
            //catatan
        }


        public void dateTimePicker1_ValueChanged_2(object sender, EventArgs e)
        {
           
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        public void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}


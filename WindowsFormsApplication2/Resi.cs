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
    public partial class Resi : Form
    {
        public Resi()
        {
            InitializeComponent();
            ShowIcon = false;
            MinimizeBox = false;
            MaximizeBox = false;
        }

        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 data = new Form3();
            
            string content = data.isi;
            string services = data.layanan;
            string city = data.kota;
            string address = data.alamat;
            string berat = data.weight;
            string notes = data.catatan;
            string price = data.ongkos;


            //buat cetak no resi
            Random r = new Random();
            int num = r.Next(10000000, 100000000);

            richTextBox1.Text = (
                "=====================================\n" +
                "  KILATZ - Your expedition solution\n" +
                "=====================================\n" +
                "\nSTRUK PENGIRIMAN PAKET" +
                "\nTanggal       : " + DateTime.Now +
                "\nNo. Resi      : " + num +
                "\nIsi           : " + content +
                "\nLayanan       : " + services +
                "\nRute Kota     : " + city +
                "\nAlamat Tujuan : " + address +
                "\nBerat         : " + berat + " kg" +
                "\nCatatan       : " + notes +
                "\nTOTAL ONGKOS  : " + "Rp" + price
                );
        }
    }
}

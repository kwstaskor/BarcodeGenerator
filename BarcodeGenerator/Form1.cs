using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using BarcodeLib;

namespace BarcodeGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnGen_Click(object sender, EventArgs e)
        {
            //Barcode barcode = new Barcode();
            //Image img = barcode.Encode(TYPE.UPCA, "12345678910", Color.Black, Color.WhiteSmoke,190,80);
            //pictureBox1.Image = img;
            ////this.appData1.Clear();
            //using (MemoryStream ms = new MemoryStream())
            //{
            //    img.Save(ms, ImageFormat.Png);
            //    for (int i = 0; i < 11; i++)
            //    {
            //        this.appData1.Barcode.AddBarcodeRow("12345678910", ms.ToArray());
            //    }
            //}

            using (FormReport formReport = new FormReport(this.appData1.Barcode))
            {
                formReport.ShowDialog();
            }
        }

        private void textBar_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            Barcode barcode = new Barcode();
            Image img = barcode.Encode(TYPE.UPCA, "12345678910", Color.Black, Color.WhiteSmoke, 190, 60);
            pictureBox1.Image = img;
            
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, ImageFormat.Png);
                this.appData1.Barcode.AddBarcodeRow(textBox1.Text, ms.ToArray());
                this.numberBox.Text = this.appData1.Barcode.Count.ToString();
                this.textBox1.Clear();
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            this.appData1.Clear();
            this.numberBox.Clear();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void numberBox_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml.Linq;

namespace MonthlySpendingPieChart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            float d1, d2, d3, d4, d5, toplam;
            d1 = int.Parse(gida.Text);
            d2 = int.Parse(akaryakit.Text);
            d3 = int.Parse(egitim.Text);
            d4 = int.Parse(saglik.Text);
            d5 = int.Parse(diger.Text);

            toplam = d1 + d2 + d3 + d4 + d5;

            float pd1, pd2, pd3, pd4, pd5;
            double yd1, yd2, yd3, yd4, yd5;
            pd1 = (d1 / toplam) * 360;
            pd2 = (d2 / toplam) * 360;
            pd3 = (d3 / toplam) * 360;
            pd4 = (d4 / toplam) * 360;
            pd5 = (d5 / toplam) * 360;

            yd1 = (d1 / toplam) * 100;
            yd2 = (d2 / toplam) * 100;
            yd3 = (d3 / toplam) * 100;
            yd4 = (d4 / toplam) * 100;
            yd5 = (d5 / toplam) * 100;


            chart1.Titles.Add("Harcamaların Pasta Grafiği");
            chart1.Series["s1"].Points.AddXY("%" + yd1.ToString("0.0") +"\nGıda",pd1);
            chart1.Series["s1"].Points.AddXY("%" + yd2.ToString("0.0")+ "\nAkaryakıt",pd2);
            chart1.Series["s1"].Points.AddXY("%" + yd3.ToString("0.0")+ "\nEğitim", pd3);
            chart1.Series["s1"].Points.AddXY("%" + yd4.ToString("0.0")+ "\nSağlık", pd4);
            chart1.Series["s1"].Points.AddXY("%" + yd5.ToString("0.0")+"\nDiğer", pd5);

            chart1.Series["s1"].Points[0].LegendText = "Gıda";
            chart1.Series["s1"].Points[1].LegendText = "Akaryakıt";
            chart1.Series["s1"].Points[2].LegendText = "Eğitim";
            chart1.Series["s1"].Points[3].LegendText = "Sağlık";
            chart1.Series["s1"].Points[4].LegendText = "Diğer";


        }

        private void button2_Click(object sender, EventArgs e)
        {

            float d1, d2, d3, d4, d5, toplam;
            d1 = int.Parse(gida.Text);
            d2 = int.Parse(akaryakit.Text);
            d3 = int.Parse(egitim.Text);
            d4 = int.Parse(saglik.Text);
            d5 = int.Parse(diger.Text);

            toplam = d1 + d2 + d3 + d4 + d5;
            double yd1, yd2, yd3, yd4, yd5;

            yd1 = (d1 / toplam) * 100;
            yd2 = (d2 / toplam) * 100;
            yd3 = (d3 / toplam) * 100;
            yd4 = (d4 / toplam) * 100;
            yd5 = (d5 / toplam) * 100;

            string turuNe = comboBox1.SelectedItem.ToString();

            if (turuNe.Equals("Gıda"))
            {
                label6.Text = turuNe + " harcamaları %" + yd1.ToString("0.0") + " oranındadır";
            }
            else if (turuNe.Equals("Akaryakıt"))
            {
                label6.Text = turuNe + " harcamaları %" + yd2.ToString("0.0") + " oranındadır";

            }
            else if (turuNe.Equals("Eğitim"))
            {
                label6.Text = turuNe + " harcamaları %" + yd3.ToString("0.0") + " oranındadır";
            }
            else if (turuNe.Equals("Sağlık"))
            {
                label6.Text = turuNe + " harcamaları %" + yd4.ToString("0.0") + " oranındadır";
            }
            else if (turuNe.Equals("Diğer"))
            {
                label6.Text = turuNe + " harcamalar %" + yd5.ToString("0.0") + " oranındadır";
            }
        }
    }
}

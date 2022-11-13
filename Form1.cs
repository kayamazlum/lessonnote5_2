using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tekrar5_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //[1] iki tane parametreleri farklı isimleri aynı metot - aşırı yüklenme
        public void metot1(int s1, int s2)
        {
            int carpim = s1 * s2;
            label2.Text = carpim.ToString();
        }

        public void metot1(int s1, int s2, int s3)
        {
            int carpim = s1 * s2 * s3;
            label2.Text = carpim.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            metot1(10, 2);
            //metot1(20, 2, 3);
        }

        //[2] iki tane parametrelerindeki değişken türü farklı isimleri aynı metot - aşırı yüklenme
        public void metot2(int a, int b)
        {
            int s = a * b;
            label3.Text = s.ToString(); 
        }
        public void metot2(double a, double b)
        {
            double s = a * b;
            label3.Text = s.ToString();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //metot2(2, 4);
            metot2(2.0, 2.5);
        }

        // [2] Bazı matematiksel metotlar
        private void button3_Click(object sender, EventArgs e)
        {
            // üs alır
            /*double sonuc = Math.Pow(2, 3);
            label1.Text = sonuc.ToString();*/


            //karekör alır
            /*double sonuc = Math.Sqrt(2);
            label1.Text = sonuc.ToString();*/

            //mutlak değer alır
            /*double sonuc = Math.Abs(100);
            label1.Text = sonuc.ToString();*/

            //yuvarlar / aşağı doğru yuvarlar
            /*double sonuc = Math.Floor(19.98);
            label1.Text = sonuc.ToString(); */

            //yukarı yuvarlar
            /*double sonuc = Math.Ceiling(1.04);
            label1.Text = sonuc.ToString();*/

            //yakına yuvarlar
            /*double sonuc = Math.Round(1.54);
            label1.Text = sonuc.ToString();*/

            //min sayıyı bulur
            /*double sonuc = Math.Min(10 , 54);
            label1.Text = sonuc.ToString(); */

            // max sayıyı bulur
            double sonuc = Math.Max(5, 8);
            label1.Text = sonuc.ToString();
        }
    }
}

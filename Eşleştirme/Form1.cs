using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eşleştirme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKontrol_Click(object sender, EventArgs e)
        {
            string secim;
            bool cevap1 , cevap2 ;
            secim=listBox2.SelectedItem.ToString();
            cevap1 = radioButton1.Checked;
            cevap2=radioButton2.Checked;
            if (cevap1 == true && (secim == "MP4" || secim== "MOV"))
            {
                MessageBox.Show("Cevabınız dogru");
            }
            if (cevap2 == false && (secim == "MP4" || secim == "MOV"))
            {
                MessageBox.Show("Cevabınız yanlış");
            }
            if (cevap1 == true && (secim == "JPG" || secim == "PNG"))
            {
                MessageBox.Show("Cevabınız dogru");
            }
            if (cevap1 == false && (secim == "JPG" || secim == "PNG"))
            {
                MessageBox.Show("Cevabınız yanlış");
            }
        }
    }
}

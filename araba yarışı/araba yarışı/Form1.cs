using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace araba_yarışı
{
    public partial class Form1 : Form
    {
        int arabalarhizi = 3;
        int yer = 8;
        int skorr = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void oyuntimer(object sender, EventArgs e)
        {
            araba.Top += yer;
            ustaraba1.Left -= arabalarhizi;
            altaraba1.Left -= arabalarhizi;
            ustaraba2.Left -= arabalarhizi;
            altaraba2.Left -= arabalarhizi;
            ortaraba.Left -= arabalarhizi;
            sskor.Text = "Skor : " + skorr;
            if (ustaraba1.Left < -50)
            {
                ustaraba1.Left = 900;
                skorr++;
            }
            if (altaraba1.Left < -50)
            {
                altaraba1.Left = 900;

            }
            if (araba.Bounds.IntersectsWith(ustaraba1.Bounds) || araba.Bounds.IntersectsWith(altaraba1.Bounds))
            {
                
            }
            if (ustaraba2.Left < -50)
            {
                ustaraba2.Left = 900;
                skorr++;
            }
            if (altaraba2.Left < -50)
            {
                altaraba2.Left = 900;

            }
            if (araba.Bounds.IntersectsWith(ustaraba2.Bounds) || araba.Bounds.IntersectsWith(altaraba2.Bounds))
            {
                
            }

            if (ortaraba.Left < -50)
            {
                ortaraba.Left = 900;

            }

            if (skorr > 5)
            {
                arabalarhizi = 4;
            }

            if (araba.Top < -25)
            {
                

            }

        }



        private void assa(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                yer = -8;
            }

        }

        private void yukari(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                yer = 3;
            }

        }
    }


    
    }

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilliardProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int Price = 7;
        private int Counter1 = 0;
        private int Counter2 = 0;
        private int Counter3 = 0;
        private int Counter4 = 0;
        private int Counter5 = 0;
        private int Counter6 = 0;





        private void timer1_Tick(object sender, EventArgs e)
        {
            Counter1++;
            lbTime1.Text = Counter1.ToString();
            lbPrice1.Text = (Counter1 / 60 * Price).ToString();

        }

   
        

        private void timer2_Tick(object sender, EventArgs e)
        {
            Counter2++;
            lbTime2.Text = Counter2.ToString();
            lbPrice2.Text = (Counter2 / 60 * Price).ToString();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            Counter3++;
            lbTime3.Text = Counter3.ToString();
            lbPrice3.Text = (Counter3 / 60 * Price).ToString();
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            Counter4++;
            lbTime4.Text = Counter4.ToString();
            lbPrice4.Text = (Counter4 / 60 * Price).ToString();
        }
        private void timer5_Tick(object sender, EventArgs e)
        {
            Counter5++;
            lbTime5.Text = Counter5.ToString();
            lbPrice5.Text = (Counter5 / 60 * Price).ToString();
        }
        private void timer6_Tick(object sender, EventArgs e)
        {
            Counter6++;
            lbTime6.Text = Counter6.ToString();
            lbPrice6.Text = (Counter6 / 60 * Price).ToString();
        }


        private void btnStrat1_Click(object sender, EventArgs e)
        {
            Counter1 = 0;
            timer1.Enabled = true;
            btnStrat1.Enabled = false;
            btnEnd1.Enabled = true;

        }

        private void btnEnd1_Click(object sender, EventArgs e)
        {
            Counter1 = 0;
            timer1.Enabled = false;
            btnStrat1.Enabled = false;

            MessageBox.Show("Total Price " + lbPrice1.Text.ToString() + "$", "Table 1 ");
        }

        private void btnPused1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void btnStrat2_Click(object sender, EventArgs e)
        {
            Counter2 = 0;
            timer2.Enabled = true;
            btnStrat2.Enabled = false;
            btnEnd2.Enabled = true;


        }

        private void btnEnd2_Click(object sender, EventArgs e)
        {
            Counter2 = 0;
            timer2.Enabled = false;
            btnStrat2.Enabled = false;


            MessageBox.Show("Total Price " + lbPrice2.Text.ToString() + "$", "Table 2 ");
        }

        private void btnPused2_Click(object sender, EventArgs e)
        {
            timer2.Enabled = true;
        }

        private void btnStrat3_Click(object sender, EventArgs e)
        {
            Counter3 = 0;
            timer3.Enabled = true;
            btnStrat3.Enabled = false;
            btnEnd3.Enabled = true;


        }

        private void btnEnd3_Click(object sender, EventArgs e)
        {
            Counter3 = 0;
            timer3.Enabled = false;
            btnStrat3.Enabled = true;


            MessageBox.Show("Total Price " + lbPrice3.Text.ToString() + "$", "Table 3 ");
        }

        private void btnPused3_Click(object sender, EventArgs e)
        {
            timer3.Enabled = true;
        }

        private void btnStrat4_Click(object sender, EventArgs e)
        {
            Counter4 = 0;
            timer4.Enabled = true;
            btnStrat4.Enabled = false;
            btnEnd14.Enabled = true;


        }

        private void btnEnd14_Click(object sender, EventArgs e)
        {
            Counter4 = 0;
            timer4.Enabled = false;
            btnStrat4.Enabled = true;


            MessageBox.Show("Total Price " + lbPrice4.Text.ToString() + "$", "Table 5 ");
        }

        private void btnPused4_Click(object sender, EventArgs e)
        {
            timer4.Enabled = true;
        }

        private void btnStrat5_Click(object sender, EventArgs e)
        {
            Counter5 = 0;
            timer5.Enabled = true;
            btnStrat5.Enabled = false;
            btnEnd5.Enabled = true;


        }

        private void btnEnd5_Click(object sender, EventArgs e)
        {
            Counter5 = 0;
            timer5.Enabled = false;
            btnStrat5.Enabled = true;

            MessageBox.Show("Total Price " + lbPrice5.Text.ToString() + "$", "Table 5 ");
        }

        private void btnPused5_Click(object sender, EventArgs e)
        {
            timer5.Enabled = true;
        }

        private void btnStrat16_Click(object sender, EventArgs e)
        {
            Counter6 = 0;
            timer6.Enabled = true;
            btnStrat16.Enabled = false;
            btnEnd6.Enabled = true;

        }

        private void btnEnd6_Click(object sender, EventArgs e)
        {
            Counter6 = 0;
            timer6.Enabled = false;
            btnStrat16.Enabled = true;

            MessageBox.Show("Total Price " + lbPrice6.Text.ToString() + "$", "Table 6 ");
        }

        private void btnPused6_Click(object sender, EventArgs e)
        {
            timer6.Enabled = true;
        }

        private int TotalPrices()
        {

            int TotalPrice = (Counter1 + Counter2 + Counter3 + Counter4 + Counter5 + Counter6) / 7;

            return TotalPrice;

        }

        private int TotalTime()
        {
            int TotalTime = (Counter1 + Counter2 + Counter3 + Counter4 + Counter5 + Counter6) * 7;

            return TotalTime;

        }

        private void lbTotalPreices_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbTotalPreices.Text = TotalPrices().ToString() + "$";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lbTotalTimes.Text = TotalTime().ToString() + "s";

        }
    }
}

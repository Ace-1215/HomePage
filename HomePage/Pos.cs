using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomePage
{
    public partial class Pos : Form
    {
        public Pos()
        {
            InitializeComponent();
        }

        public int beer = 0;
        public int tequila = 0;
        public int whisky = 0;
        public int redwine = 0;

        public int total = 0;

        public int beerprice = 120;
        public int tequilaprice = 180;
        public int whiskyprice = 350;
        public int redwineprice = 320;

        private void btn_beer_Click(object sender, EventArgs e)
        {
            beer++;
            total += beerprice;
            int beercost = beerprice * beer;

            listBox1.Items[0] = ("啤酒" + beer + "杯" + "NT" + beercost + "元");
            txt_total.Text = "NT:" + total;
        }

        private void btn_tequila_Click(object sender, EventArgs e)
        {
            tequila++;
            total += tequilaprice;
            int tequilacost = tequilaprice * tequila;

            listBox1.Items[1] = ("龍舌蘭" + tequila + "杯" + "NT" + tequilacost + "元");
            txt_total.Text = "NT:" + total;
        }

        private void btn_whiskey_Click(object sender, EventArgs e)
        {
            whisky++;
            total += whiskyprice;
            int whiskycost = whiskyprice * whisky;

            listBox1.Items[2] = ("威士忌" + whisky + "杯" + "NT" + whiskycost + "元");
            txt_total.Text = "NT:" + total;
        }

        private void btn_redwine_Click(object sender, EventArgs e)
        {
            redwine++;
            total += redwineprice;
            int redwincost = redwineprice * redwine;

            listBox1.Items[3] = ("紅酒" + redwine + "杯" + "NT" + redwincost + "元");
            txt_total.Text = "NT:" + total;
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            beer = 0;
            tequila = 0;
            whisky = 0;
            redwine = 0;
            txt_total.Text = null;
            listBox1.Items.Clear();
        }

        private void btn_pay_Click(object sender, EventArgs e)
        {
            MessageBox.Show("總金額:" + total + "元");
        }

        private void btn_creditcard_Click(object sender, EventArgs e)
        {
            MessageBox.Show("總金額:" + total * 0.9 + "元");
        }
    }
}

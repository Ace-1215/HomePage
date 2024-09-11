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
    public partial class Loan : Form
    {
        public Loan()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double goat = double.Parse(txt_goat.Text);
            double year = double.Parse(txt_year.Text);
            double pasento = double.Parse(txt_pasento.Text);
            double firstgoat = double.Parse(txt_firstgoat.Text);

            double month = year * 12;
            double month_pasento = pasento / 12 / 100;

            double PMT = Convert.ToInt32(goat * (month_pasento *
                Math.Pow(1 + (month_pasento), month))
                / (Math.Pow((1 + (month_pasento)), month) - 1));

            MessageBox.Show("月付金額 :" + PMT + "元");


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            double goat = double.Parse(txt_goat.Text);
            double year = double.Parse(txt_year.Text);
            double pasento = double.Parse(txt_pasento.Text);
            double firstgoat = double.Parse(txt_firstgoat.Text);

            double month = year * 12;
            double month_pasento = pasento / 12 / 100;

            double PMT = Convert.ToInt32(goat * (month_pasento *
                Math.Pow(1 + (month_pasento), month))
                / (Math.Pow((1 + (month_pasento)), month) - 1));

            double pay = Convert.ToInt32(PMT * (year * 12));

            MessageBox.Show("總金額 :" + pay + "元");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double goat = double.Parse(txt_goat.Text);
            double year = double.Parse(txt_year.Text);
            double pasento = double.Parse(txt_pasento.Text);
            double firstgoat = double.Parse(txt_firstgoat.Text);
            
            txt_goat.Text=null;
            txt_year.Text=null;
            txt_pasento.Text=null;
            txt_firstgoat.Text = null;
        }
    }
}

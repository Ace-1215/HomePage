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
    public partial class Hello : Form
    {
        public Hello()
        {
            InitializeComponent();
        }

        private void btn_Hello_Click(object sender, EventArgs e)
        {
            string name = txt_name.Text;
            string egname = txt_egname.Text;
            string sex = txt_sex.Text;
            string constellation = txt_constellation.Text;


            MessageBox.Show("Hello!!!" + "\n我是 :" + name + "\n英文名是 :" + egname + "\n性別 :" + sex + "\n星座 :" + constellation);
        }

        private void btn_Hi_Click(object sender, EventArgs e)
        {
            string name = txt_name.Text;
            string egname = txt_egname.Text;
            string sex = txt_sex.Text;
            string constellation = txt_constellation.Text;


            MessageBox.Show("Hi Hi!!!" + "\n我是 :" + name + "\n英文名是 :" + egname + "\n性別 :" + sex + "\n星座 :" + constellation);
        }
    }
}

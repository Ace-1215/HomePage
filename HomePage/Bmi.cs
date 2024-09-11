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
    public partial class Bmi : Form
    {
        public Bmi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float dHeight =float.Parse(txt_height.Text);
            float dWeight =float.Parse(txt_weight.Text);
            float dBmi = 0;

            dHeight = dHeight / 100;

            dBmi = dWeight / dHeight / dHeight;

            txt_bmi.Text =Convert.ToString(dBmi);

        }
    }
}

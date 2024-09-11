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
    public partial class student_strucform : Form
    {
        public string sName = "";
        public string sChinese = "";
        public string sEnglish = "";
        public string sMath = "";
        public bool bCheckSave = false; //判斷是否有按存檔
        public student_strucform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sName = txt_name.Text;
            sChinese = txt_chinese.Text;
            sEnglish = txt_english.Text;
            sMath = txt_math.Text;

            if (sName.Trim() == "")
            {
                MessageBox.Show("請輸入名稱");
            }

            if (sChinese.Trim() == "")
            {
                MessageBox.Show("請輸入國文分數");
            }
            else
            {
                int iChinese = 0;
                bool bChinese = int.TryParse(sChinese, out iChinese);

                if (bChinese == false)
                {
                    MessageBox.Show("請輸入國文數字分數");
                }
            }

            if (sEnglish.Trim() == "")
            {
                MessageBox.Show("請輸入英文分數");
            }
            else
            {
                int iEnglish = 0;
                bool bEnglish = int.TryParse(sEnglish, out iEnglish);

                if (bEnglish == false)
                {
                    MessageBox.Show("請輸入英文數字分數");
                }
            }

            if (sMath.Trim() == "")
            {
                MessageBox.Show("請輸入數學分數");
            }
            else
            {
                int iMath = 0;
                bool bMath = int.TryParse(sMath, out iMath);

                if (bMath == false)
                {
                    MessageBox.Show("請輸入數學數字分數");
                }
            }

            if (sName != "" && sChinese != "" && sEnglish != "" && sMath != "")
            {
                bCheckSave = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (bCheckSave == true)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add(sName + " 成績");
                listBox1.Items.Add("國文分數: " + sChinese);
                listBox1.Items.Add("英文分數: " + sEnglish);
                listBox1.Items.Add("數學分數: " + sMath);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int iChineses = int.Parse(sChinese);
            int iEnglish = int.Parse(sEnglish);
            int iMath = int.Parse(sMath);
            int imax = 0;
            int imin = 0;
            int[] PK = { iChineses, iEnglish, iMath };
            listBox2.Items.Clear();
            listBox2.Items.Add(sName + " 最高/最低分數");

            for (int i = 0; i < PK.Length; i++) 
            {
                if( i == 0 || PK[i] >imax)imax = PK[i];//最大值
                if (i == 0 || PK[i] < imin) imin = PK[i];//最小值
            }
            if (imax == iChineses)
            {
                listBox2.Items.Add("最高國文" + iChineses + "分");
            }
            if (imax == iEnglish)
            {
                listBox2.Items.Add("最高英文" + iEnglish + "分");
            }
            if (imax == iMath)
            {
                listBox2.Items.Add("最高數學" + iMath + "分");
            }
            if(imin == iChineses)
            {
                listBox2.Items.Add("最低國文" + iChineses + "分");
            }
            if (imin == iEnglish)
            {
                listBox2.Items.Add("最低英文" + iEnglish + "分");
            }
            if (imin == iMath)
            {
                listBox2.Items.Add("最低數學" + iMath + "分");
            }
        }
    }
}

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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void btn_hello_Click(object sender, EventArgs e)
        {
            //清除panel2欄位上的東西
            splitContainer1.Panel2.Controls.Clear();
            //抓取Hello到HomePage裡並初始化
            Hello newFrm = new Hello();
            //將Hello表單 單獨運行
            newFrm.TopLevel = false;
            //將Hello顯示出來
            newFrm.Show();
            //Hello顯示到Panel2
            splitContainer1.Panel2.Controls.Add(newFrm);
        }

        private void btn_loan_Click(object sender, EventArgs e)
        {
            //清除panel2欄位上的東西
            splitContainer1.Panel2.Controls.Clear();
            //抓取Loan到HomePage裡並初始化
            Loan newFrm = new Loan();
            //將Loan表單 單獨運行
            newFrm.TopLevel = false;
            //將Loan顯示出來
            newFrm.Show();
            //Loan顯示到Panel2
            splitContainer1.Panel2.Controls.Add(newFrm);
        }

        private void btn_pos_Click(object sender, EventArgs e)
        {
            //清除panel2欄位上的東西
            splitContainer1.Panel2.Controls.Clear();
            //抓取Pos到HomePage裡並初始化
            Pos newFrm = new Pos();
            //將Pos表單 單獨運行
            newFrm.TopLevel = false;
            //將Pos顯示出來
            newFrm.Show();
            //Pos顯示到Panel2
            splitContainer1.Panel2.Controls.Add(newFrm);
        }

        private void btn_student_struc_Click(object sender, EventArgs e)
        {
            //清除panel2欄位上的東西
            splitContainer1.Panel2.Controls.Clear();
            //抓取student_strucform到HomePage裡並初始化
            student_strucform newFrm = new student_strucform();
            //將student_strucform表單 單獨運行
            newFrm.TopLevel = false;
            //將student_strucform顯示出來
            newFrm.Show();
            //student_strucform顯示到Panel2
            splitContainer1.Panel2.Controls.Add(newFrm);
        }

        private void btn_studaentsgrade_Click(object sender, EventArgs e)
        {
            //清除panel2欄位上的東西
            splitContainer1.Panel2.Controls.Clear();
            //抓取studentsgrade到HomePage裡並初始化
            studentsgrade newFrm = new studentsgrade();
            //將studentsgrade表單 單獨運行
            newFrm.TopLevel = false;
            //將studentsgrade顯示出來
            newFrm.Show();
            //studentsgrade顯示到Panel2
            splitContainer1.Panel2.Controls.Add(newFrm);
        }

        private void btn_studaentsgrade_list_Click(object sender, EventArgs e)
        {

        }

        private void btn_method_Click(object sender, EventArgs e)
        {

        }

        private void btn_myclac_Click(object sender, EventArgs e)
        {

        }

        private void btn_for_do_while_Click(object sender, EventArgs e)
        {

        }

        private void btn_oxgame_Click(object sender, EventArgs e)
        {

        }

        private void btn_screensaver_Click(object sender, EventArgs e)
        {

        }

        private void btn_notepad_Click(object sender, EventArgs e)
        {

        }

        private void btn_draw_Click(object sender, EventArgs e)
        {

        }

        private void btn_pictureviewer_Click(object sender, EventArgs e)
        {

        }

        private void btn_bmi_Click(object sender, EventArgs e)
        {
            //清除panel2欄位上的東西
            splitContainer1.Panel2.Controls.Clear();
            //抓取Bmi到HomePage裡並初始化
            Bmi newFrm = new Bmi();
            //將Bmi表單 單獨運行
            newFrm.TopLevel = false;
            //將Bmi顯示出來
            newFrm.Show();
            //Bmi顯示到Panel2
            splitContainer1.Panel2.Controls.Add(newFrm);
        }

        private void btn_triangle_Click(object sender, EventArgs e)
        {
            //清除panel2欄位上的東西
            splitContainer1.Panel2.Controls.Clear();
            //抓取Triangle到HomePage裡並初始化
            Triangle newFrm = new Triangle();
            //將Triangle表單 單獨運行
            newFrm.TopLevel = false;
            //將Triangle顯示出來
            newFrm.Show();
            //Triangle顯示到Panel2
            splitContainer1.Panel2.Controls.Add(newFrm);
        }
    }
}

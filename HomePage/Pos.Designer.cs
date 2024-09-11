namespace HomePage
{
    partial class Pos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            btn_redwine = new Button();
            btn_whiskey = new Button();
            btn_tequila = new Button();
            btn_beer = new Button();
            groupBox2 = new GroupBox();
            txt_total = new TextBox();
            groupBox3 = new GroupBox();
            label1 = new Label();
            btn_creditcard = new Button();
            btn_pay = new Button();
            groupBox4 = new GroupBox();
            btn_clear = new Button();
            listBox1 = new ListBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_redwine);
            groupBox1.Controls.Add(btn_whiskey);
            groupBox1.Controls.Add(btn_tequila);
            groupBox1.Controls.Add(btn_beer);
            groupBox1.Location = new Point(12, 85);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(248, 283);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "菜單menu";
            // 
            // btn_redwine
            // 
            btn_redwine.Font = new Font("標楷體", 12F);
            btn_redwine.Location = new Point(122, 146);
            btn_redwine.Name = "btn_redwine";
            btn_redwine.Size = new Size(120, 118);
            btn_redwine.TabIndex = 3;
            btn_redwine.Text = "紅酒\r\nNT$320";
            btn_redwine.UseVisualStyleBackColor = true;
            btn_redwine.Click += btn_redwine_Click;
            // 
            // btn_whiskey
            // 
            btn_whiskey.Font = new Font("標楷體", 12F);
            btn_whiskey.Location = new Point(2, 146);
            btn_whiskey.Name = "btn_whiskey";
            btn_whiskey.Size = new Size(120, 118);
            btn_whiskey.TabIndex = 2;
            btn_whiskey.Text = "威士忌\r\nNT$350";
            btn_whiskey.UseVisualStyleBackColor = true;
            btn_whiskey.Click += btn_whiskey_Click;
            // 
            // btn_tequila
            // 
            btn_tequila.Font = new Font("標楷體", 12F);
            btn_tequila.Location = new Point(122, 23);
            btn_tequila.Name = "btn_tequila";
            btn_tequila.Size = new Size(120, 118);
            btn_tequila.TabIndex = 1;
            btn_tequila.Text = "龍舌蘭\r\nNT$180\r\n";
            btn_tequila.UseVisualStyleBackColor = true;
            btn_tequila.Click += btn_tequila_Click;
            // 
            // btn_beer
            // 
            btn_beer.Font = new Font("標楷體", 12F);
            btn_beer.Location = new Point(2, 23);
            btn_beer.Name = "btn_beer";
            btn_beer.Size = new Size(120, 118);
            btn_beer.TabIndex = 0;
            btn_beer.Text = "啤酒\r\nNT$120";
            btn_beer.UseVisualStyleBackColor = true;
            btn_beer.Click += btn_beer_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txt_total);
            groupBox2.Location = new Point(266, 85);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(217, 135);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "總金額total";
            // 
            // txt_total
            // 
            txt_total.Location = new Point(29, 57);
            txt_total.Name = "txt_total";
            txt_total.Size = new Size(164, 23);
            txt_total.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(btn_creditcard);
            groupBox3.Controls.Add(btn_pay);
            groupBox3.Location = new Point(266, 226);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(217, 142);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "付款方式";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("標楷體", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 136);
            label1.Location = new Point(82, 126);
            label1.Name = "label1";
            label1.Size = new Size(129, 13);
            label1.TabIndex = 2;
            label1.Text = "信用卡打九折!!!!";
            // 
            // btn_creditcard
            // 
            btn_creditcard.Font = new Font("標楷體", 14.25F);
            btn_creditcard.Location = new Point(115, 53);
            btn_creditcard.Name = "btn_creditcard";
            btn_creditcard.Size = new Size(96, 56);
            btn_creditcard.TabIndex = 1;
            btn_creditcard.Text = "信用卡";
            btn_creditcard.UseVisualStyleBackColor = true;
            btn_creditcard.Click += btn_creditcard_Click;
            // 
            // btn_pay
            // 
            btn_pay.Font = new Font("標楷體", 14.25F);
            btn_pay.Location = new Point(6, 53);
            btn_pay.Name = "btn_pay";
            btn_pay.Size = new Size(96, 56);
            btn_pay.TabIndex = 0;
            btn_pay.Text = "現金";
            btn_pay.UseVisualStyleBackColor = true;
            btn_pay.Click += btn_pay_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btn_clear);
            groupBox4.Controls.Add(listBox1);
            groupBox4.Location = new Point(489, 85);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(264, 283);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "購物清單";
            // 
            // btn_clear
            // 
            btn_clear.Font = new Font("標楷體", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            btn_clear.Location = new Point(183, 243);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(75, 34);
            btn_clear.TabIndex = 1;
            btn_clear.Text = "清除";
            btn_clear.UseVisualStyleBackColor = true;
            btn_clear.Click += btn_clear_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Items.AddRange(new object[] { "尚未購物", "", "", "" });
            listBox1.Location = new Point(7, 23);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(252, 214);
            listBox1.TabIndex = 0;
            // 
            // Pos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Pos";
            Text = "Pos";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private Button btn_redwine;
        private Button btn_whiskey;
        private Button btn_tequila;
        private Button btn_beer;
        private TextBox txt_total;
        private Label label1;
        private Button btn_creditcard;
        private Button btn_pay;
        private ListBox listBox1;
        private Button btn_clear;
    }
}
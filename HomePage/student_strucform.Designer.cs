namespace HomePage
{
    partial class student_strucform
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            txt_name = new TextBox();
            txt_chinese = new TextBox();
            txt_english = new TextBox();
            txt_math = new TextBox();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("標楷體", 14.25F);
            label1.Location = new Point(84, 87);
            label1.Name = "label1";
            label1.Size = new Size(59, 19);
            label1.TabIndex = 0;
            label1.Text = "姓名:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("標楷體", 14.25F);
            label2.Location = new Point(84, 141);
            label2.Name = "label2";
            label2.Size = new Size(59, 19);
            label2.TabIndex = 1;
            label2.Text = "國文:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("標楷體", 14.25F);
            label3.Location = new Point(84, 194);
            label3.Name = "label3";
            label3.Size = new Size(59, 19);
            label3.TabIndex = 2;
            label3.Text = "英文:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("標楷體", 14.25F);
            label4.Location = new Point(84, 254);
            label4.Name = "label4";
            label4.Size = new Size(59, 19);
            label4.TabIndex = 3;
            label4.Text = "數學:";
            // 
            // button1
            // 
            button1.Font = new Font("標楷體", 15.75F);
            button1.Location = new Point(43, 340);
            button1.Name = "button1";
            button1.Size = new Size(142, 46);
            button1.TabIndex = 4;
            button1.Text = "儲存";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("標楷體", 15.75F);
            button2.Location = new Point(191, 340);
            button2.Name = "button2";
            button2.Size = new Size(152, 46);
            button2.TabIndex = 5;
            button2.Text = "顯示儲存內容";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // txt_name
            // 
            txt_name.Location = new Point(149, 87);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(100, 23);
            txt_name.TabIndex = 6;
            // 
            // txt_chinese
            // 
            txt_chinese.Location = new Point(149, 141);
            txt_chinese.Name = "txt_chinese";
            txt_chinese.Size = new Size(100, 23);
            txt_chinese.TabIndex = 7;
            // 
            // txt_english
            // 
            txt_english.Location = new Point(149, 194);
            txt_english.Name = "txt_english";
            txt_english.Size = new Size(100, 23);
            txt_english.TabIndex = 8;
            // 
            // txt_math
            // 
            txt_math.Location = new Point(149, 254);
            txt_math.Name = "txt_math";
            txt_math.Size = new Size(100, 23);
            txt_math.TabIndex = 9;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Items.AddRange(new object[] { "", "", "", "" });
            listBox1.Location = new Point(395, 52);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(277, 124);
            listBox1.TabIndex = 10;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Items.AddRange(new object[] { "", "", "", "", "" });
            listBox2.Location = new Point(395, 202);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(277, 109);
            listBox2.TabIndex = 11;
            // 
            // button3
            // 
            button3.Font = new Font("標楷體", 15.75F);
            button3.Location = new Point(448, 340);
            button3.Name = "button3";
            button3.Size = new Size(176, 46);
            button3.TabIndex = 12;
            button3.Text = "最高分/最低分";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // student_strucform
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(txt_math);
            Controls.Add(txt_english);
            Controls.Add(txt_chinese);
            Controls.Add(txt_name);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "student_strucform";
            Text = "student_strucform";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private Button button2;
        private TextBox txt_name;
        private TextBox txt_chinese;
        private TextBox txt_english;
        private TextBox txt_math;
        private ListBox listBox1;
        private ListBox listBox2;
        private Button button3;
    }
}
namespace HomePage
{
    partial class Hello
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
            btn_Hello = new Button();
            btn_Hi = new Button();
            txt_name = new TextBox();
            txt_egname = new TextBox();
            txt_sex = new TextBox();
            txt_constellation = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("標楷體", 14.25F);
            label1.Location = new Point(132, 69);
            label1.Name = "label1";
            label1.Size = new Size(59, 19);
            label1.TabIndex = 0;
            label1.Text = "姓名:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("標楷體", 14.25F);
            label2.Location = new Point(132, 108);
            label2.Name = "label2";
            label2.Size = new Size(59, 19);
            label2.TabIndex = 1;
            label2.Text = "英文:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("標楷體", 14.25F);
            label3.Location = new Point(132, 158);
            label3.Name = "label3";
            label3.Size = new Size(59, 19);
            label3.TabIndex = 2;
            label3.Text = "性別:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("標楷體", 14.25F);
            label4.Location = new Point(132, 205);
            label4.Name = "label4";
            label4.Size = new Size(59, 19);
            label4.TabIndex = 3;
            label4.Text = "星座:";
            // 
            // btn_Hello
            // 
            btn_Hello.Location = new Point(132, 273);
            btn_Hello.Name = "btn_Hello";
            btn_Hello.Size = new Size(75, 23);
            btn_Hello.TabIndex = 4;
            btn_Hello.Text = "SayHello !";
            btn_Hello.UseVisualStyleBackColor = true;
            btn_Hello.Click += btn_Hello_Click;
            // 
            // btn_Hi
            // 
            btn_Hi.Location = new Point(222, 273);
            btn_Hi.Name = "btn_Hi";
            btn_Hi.Size = new Size(75, 23);
            btn_Hi.TabIndex = 5;
            btn_Hi.Text = "SayHi !";
            btn_Hi.UseVisualStyleBackColor = true;
            btn_Hi.Click += btn_Hi_Click;
            // 
            // txt_name
            // 
            txt_name.Location = new Point(197, 65);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(100, 23);
            txt_name.TabIndex = 6;
            txt_name.Text = "小明";
            // 
            // txt_egname
            // 
            txt_egname.Location = new Point(197, 108);
            txt_egname.Name = "txt_egname";
            txt_egname.Size = new Size(100, 23);
            txt_egname.TabIndex = 7;
            txt_egname.Text = "simon";
            // 
            // txt_sex
            // 
            txt_sex.Location = new Point(197, 154);
            txt_sex.Name = "txt_sex";
            txt_sex.Size = new Size(100, 23);
            txt_sex.TabIndex = 8;
            txt_sex.Text = "男";
            // 
            // txt_constellation
            // 
            txt_constellation.Location = new Point(197, 201);
            txt_constellation.Name = "txt_constellation";
            txt_constellation.Size = new Size(100, 23);
            txt_constellation.TabIndex = 9;
            txt_constellation.Text = "牡羊";
            // 
            // Hello
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(423, 351);
            Controls.Add(txt_constellation);
            Controls.Add(txt_sex);
            Controls.Add(txt_egname);
            Controls.Add(txt_name);
            Controls.Add(btn_Hi);
            Controls.Add(btn_Hello);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Hello";
            Text = "Hello";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btn_Hello;
        private Button btn_Hi;
        private TextBox txt_name;
        private TextBox txt_egname;
        private TextBox txt_sex;
        private TextBox txt_constellation;
    }
}
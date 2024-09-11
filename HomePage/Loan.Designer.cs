namespace HomePage
{
    partial class Loan
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
            txt_goat = new TextBox();
            txt_year = new TextBox();
            txt_pasento = new TextBox();
            txt_firstgoat = new TextBox();
            btn_payment = new Button();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("標楷體", 14.25F);
            label1.Location = new Point(97, 73);
            label1.Name = "label1";
            label1.Size = new Size(99, 19);
            label1.TabIndex = 0;
            label1.Text = "貸款金額:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("標楷體", 14.25F);
            label2.Location = new Point(97, 137);
            label2.Name = "label2";
            label2.Size = new Size(99, 19);
            label2.TabIndex = 1;
            label2.Text = "期限(年):";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("標楷體", 14.25F);
            label3.Location = new Point(137, 192);
            label3.Name = "label3";
            label3.Size = new Size(59, 19);
            label3.TabIndex = 2;
            label3.Text = "利率:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("標楷體", 14.25F);
            label4.Location = new Point(117, 247);
            label4.Name = "label4";
            label4.Size = new Size(79, 19);
            label4.TabIndex = 3;
            label4.Text = "頭期款:";
            // 
            // txt_goat
            // 
            txt_goat.Location = new Point(202, 73);
            txt_goat.Name = "txt_goat";
            txt_goat.Size = new Size(100, 23);
            txt_goat.TabIndex = 4;
            txt_goat.Text = "100000";
            // 
            // txt_year
            // 
            txt_year.Location = new Point(202, 137);
            txt_year.Name = "txt_year";
            txt_year.Size = new Size(100, 23);
            txt_year.TabIndex = 5;
            txt_year.Text = "2";
            // 
            // txt_pasento
            // 
            txt_pasento.Location = new Point(202, 192);
            txt_pasento.Name = "txt_pasento";
            txt_pasento.Size = new Size(100, 23);
            txt_pasento.TabIndex = 6;
            txt_pasento.Text = "10";
            // 
            // txt_firstgoat
            // 
            txt_firstgoat.Location = new Point(202, 247);
            txt_firstgoat.Name = "txt_firstgoat";
            txt_firstgoat.Size = new Size(100, 23);
            txt_firstgoat.TabIndex = 7;
            txt_firstgoat.Text = "0";
            // 
            // btn_payment
            // 
            btn_payment.Location = new Point(108, 320);
            btn_payment.Name = "btn_payment";
            btn_payment.Size = new Size(75, 23);
            btn_payment.TabIndex = 8;
            btn_payment.Text = "PAT(月付";
            btn_payment.UseVisualStyleBackColor = true;
            btn_payment.Click += button1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(227, 320);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 9;
            button1.Text = "總付款";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Location = new Point(328, 375);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 10;
            button2.Text = "清除";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Loan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(415, 423);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btn_payment);
            Controls.Add(txt_firstgoat);
            Controls.Add(txt_pasento);
            Controls.Add(txt_year);
            Controls.Add(txt_goat);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Loan";
            Text = "Loan";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txt_goat;
        private TextBox txt_year;
        private TextBox txt_pasento;
        private TextBox txt_firstgoat;
        private Button btn_payment;
        private Button button1;
        private Button button2;
    }
}
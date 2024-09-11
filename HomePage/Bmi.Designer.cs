namespace HomePage
{
    partial class Bmi
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
            button1 = new Button();
            button2 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txt_height = new TextBox();
            txt_weight = new TextBox();
            txt_bmi = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(109, 252);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "計算BMI";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(218, 252);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "清除";
            button2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(109, 106);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 3;
            label2.Text = "身高:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(109, 145);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 4;
            label3.Text = "體重:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(190, 188);
            label4.Name = "label4";
            label4.Size = new Size(29, 15);
            label4.TabIndex = 5;
            label4.Text = "BMI";
            // 
            // txt_height
            // 
            txt_height.Location = new Point(157, 103);
            txt_height.Name = "txt_height";
            txt_height.Size = new Size(100, 23);
            txt_height.TabIndex = 7;
            // 
            // txt_weight
            // 
            txt_weight.Location = new Point(157, 142);
            txt_weight.Name = "txt_weight";
            txt_weight.Size = new Size(100, 23);
            txt_weight.TabIndex = 8;
            // 
            // txt_bmi
            // 
            txt_bmi.Location = new Point(157, 206);
            txt_bmi.Name = "txt_bmi";
            txt_bmi.Size = new Size(100, 23);
            txt_bmi.TabIndex = 9;
            // 
            // Bmi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(371, 383);
            Controls.Add(txt_bmi);
            Controls.Add(txt_weight);
            Controls.Add(txt_height);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Bmi";
            Text = "Bmi";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txt_height;
        private TextBox txt_weight;
        private TextBox txt_bmi;
    }
}
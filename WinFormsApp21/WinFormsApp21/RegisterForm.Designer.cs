namespace WinFormsApp21
{
    partial class RegisterForm
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
            label7 = new Label();
            label6 = new Label();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            button3 = new Button();
            label2 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(170, 132);
            label7.Name = "label7";
            label7.Size = new Size(31, 15);
            label7.TabIndex = 36;
            label7.Text = "Имя";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(170, 94);
            label6.Name = "label6";
            label6.Size = new Size(41, 15);
            label6.TabIndex = 35;
            label6.Text = "Логин";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(225, 129);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 34;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(225, 91);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 33;
            // 
            // button3
            // 
            button3.Location = new Point(171, 214);
            button3.Name = "button3";
            button3.Size = new Size(154, 23);
            button3.TabIndex = 32;
            button3.Text = "Регистрация";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 18);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 40;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(170, 173);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 42;
            label1.Text = "Пароль";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(225, 170);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 41;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(478, 340);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(button3);
            Name = "RegisterForm";
            Text = "RegisterForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private Label label6;
        private TextBox textBox3;
        private TextBox textBox2;
        private Button button3;
        private Label label2;
        private Label label1;
        private TextBox textBox1;
    }
}
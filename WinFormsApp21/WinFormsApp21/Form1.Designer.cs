namespace WinFormsApp21
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            dataGridView1 = new DataGridView();
            label3 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            button6 = new Button();
            label4 = new Label();
            label2 = new Label();
            button3 = new Button();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 198);
            button1.Name = "button1";
            button1.Size = new Size(238, 23);
            button1.TabIndex = 0;
            button1.Text = "Посмотреть все книги";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(10, 9);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(555, 150);
            dataGridView1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(602, 482);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 6;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(335, 225);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 19;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(335, 192);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 20;
            label1.Text = "Код книги";
            // 
            // button6
            // 
            button6.Location = new Point(320, 270);
            button6.Name = "button6";
            button6.Size = new Size(132, 23);
            button6.TabIndex = 22;
            button6.Text = "Посмотреть данные";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(756, 477);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 24;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(693, 12);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 25;
            label2.Text = "Привет, ";
            label2.Click += label2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(700, 121);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 27;
            button3.Text = "Войти";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(744, 44);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 28;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(744, 82);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 29;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(689, 47);
            label6.Name = "label6";
            label6.Size = new Size(41, 15);
            label6.TabIndex = 30;
            label6.Text = "Логин";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(689, 85);
            label7.Name = "label7";
            label7.Size = new Size(49, 15);
            label7.TabIndex = 31;
            label7.Text = "Пароль";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(752, 12);
            label8.Name = "label8";
            label8.Size = new Size(30, 15);
            label8.TabIndex = 32;
            label8.Text = "User";
            // 
            // button5
            // 
            button5.Location = new Point(781, 121);
            button5.Name = "button5";
            button5.Size = new Size(91, 23);
            button5.TabIndex = 34;
            button5.Text = "Регистрация";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Turquoise;
            ClientSize = new Size(1034, 382);
            Controls.Add(button5);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(button3);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(button6);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private DataGridView dataGridView1;
        private Label label3;
        private TextBox textBox1;
        private Label label1;
        private Button button6;
        private Label label4;
        private Label label2;
        private Button button3;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button button5;
    }
}
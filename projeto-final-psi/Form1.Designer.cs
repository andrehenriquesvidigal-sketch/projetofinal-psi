namespace projeto_final_psi{    partial class Form1    {        /// <summary>        ///  Required designer variable.        /// </summary>        private System.ComponentModel.IContainer components = null;        /// <summary>        ///  Clean up any resources being used.        /// </summary>        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>        protected override void Dispose(bool disposing)        {            if (disposing && (components != null))            {                components.Dispose();            }            base.Dispose(disposing);        }































        #region Windows Form Designer generated code
        /// <summary>        ///  Required method for Designer support - do not modify        ///  the contents of this method with the code editor.        /// </summary>                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  private void InitializeComponent()        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label5 = new Label();
            dateTimePicker1 = new DateTimePicker();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(455, 46);
            label1.Name = "label1";
            label1.Size = new Size(79, 31);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(455, 145);
            label2.Name = "label2";
            label2.Size = new Size(82, 31);
            label2.TabIndex = 1;
            label2.Text = "E-mail";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(455, 260);
            label3.Name = "label3";
            label3.Size = new Size(114, 31);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(455, 360);
            label4.Name = "label4";
            label4.Size = new Size(239, 31);
            label4.TabIndex = 3;
            label4.Text = "Confirme a password";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(455, 101);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(360, 27);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(455, 197);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(360, 27);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(455, 419);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(360, 27);
            textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(455, 307);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(360, 27);
            textBox4.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(455, 468);
            label5.Name = "label5";
            label5.Size = new Size(226, 31);
            label5.TabIndex = 8;
            label5.Text = "Data de nascimento";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(455, 529);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(360, 27);
            dateTimePicker1.TabIndex = 9;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Highlight;
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(496, 637);
            button1.Name = "button1";
            button1.Size = new Size(261, 75);
            button1.TabIndex = 10;
            button1.Text = "Criar Conta";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1206, 764);
            Controls.Add(button1);
            Controls.Add(dateTimePicker1);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion
        private Label label1;        private Label label2;        private Label label3;        private Label label4;        private TextBox textBox1;        private TextBox textBox2;        private TextBox textBox3;        private TextBox textBox4;        private Label label5;        private DateTimePicker dateTimePicker1;        private Button button1;    }}
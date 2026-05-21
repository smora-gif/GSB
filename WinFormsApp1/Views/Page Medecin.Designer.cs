namespace WinFormsApp1
{
    partial class Page_Medecin
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
            comboBox1 = new ComboBox();
            label1 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            comboBox2 = new ComboBox();
            label7 = new Label();
            label8 = new Label();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            label9 = new Label();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            btnValider = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(661, 68);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(661, 45);
            label1.Name = "label1";
            label1.Size = new Size(61, 20);
            label1.TabIndex = 1;
            label1.Text = "Patient :";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Info;
            button1.Location = new Point(910, 333);
            button1.Name = "button1";
            button1.Size = new Size(155, 38);
            button1.TabIndex = 2;
            button1.Text = "Nouveau Patient";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(555, 108);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(812, 108);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(186, 27);
            textBox2.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(555, 76);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 5;
            label2.Text = "Nom :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(812, 76);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 6;
            label3.Text = "Prenom :";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(555, 185);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(139, 27);
            textBox3.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(555, 162);
            label4.Name = "label4";
            label4.Size = new Size(139, 20);
            label4.TabIndex = 8;
            label4.Text = "Date de Naissance :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(838, 162);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 9;
            label5.Text = "Taille :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(740, 162);
            label6.Name = "label6";
            label6.Size = new Size(51, 20);
            label6.TabIndex = 10;
            label6.Text = "Poids :";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(740, 185);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(61, 27);
            textBox4.TabIndex = 11;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(838, 185);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(139, 27);
            textBox5.TabIndex = 12;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(555, 257);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(553, 234);
            label7.Name = "label7";
            label7.Size = new Size(47, 20);
            label7.TabIndex = 14;
            label7.Text = "Sexe :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(775, 234);
            label8.Name = "label8";
            label8.Size = new Size(93, 20);
            label8.TabIndex = 15;
            label8.Text = "Pathologies :";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(775, 258);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(223, 27);
            textBox6.TabIndex = 16;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(555, 342);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(218, 27);
            textBox7.TabIndex = 17;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(555, 319);
            label9.Name = "label9";
            label9.Size = new Size(198, 20);
            label9.TabIndex = 18;
            label9.Text = "Numero de Securité sociale :";
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlDark;
            button2.Location = new Point(794, 342);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 19;
            button2.Text = "Modifier";
            button2.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(428, 375);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(706, 137);
            dataGridView1.TabIndex = 20;
            // 
            // btnValider
            // 
            btnValider.Location = new Point(1089, 338);
            btnValider.Name = "btnValider";
            btnValider.Size = new Size(120, 29);
            btnValider.TabIndex = 21;
            btnValider.Text = "Liste des Patients";
            btnValider.UseVisualStyleBackColor = true;
            btnValider.Click += button3_Click;
            // 
            // Page_Medecin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1481, 520);
            Controls.Add(btnValider);
            Controls.Add(dataGridView1);
            Controls.Add(button2);
            Controls.Add(label9);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(comboBox2);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Name = "Page_Medecin";
            Text = "Page_Medecin";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label label1;
        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox4;
        private TextBox textBox5;
        private ComboBox comboBox2;
        private Label label7;
        private Label label8;
        private TextBox textBox6;
        private TextBox textBox7;
        private Label label9;
        private Button button2;
        private DataGridView dataGridView1;
        private Button btnValider;
    }
}
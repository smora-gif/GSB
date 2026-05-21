namespace WinFormsApp1
{
    partial class Form2
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
            label9 = new Label();
            TxtBoxNSecu = new TextBox();
            TxtBoxPatho = new TextBox();
            label8 = new Label();
            label7 = new Label();
            comboBoxSexe = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            TxtBoxPrenom = new TextBox();
            TxtBoxNom = new TextBox();
            CreerPatient = new Button();
            label1 = new Label();
            comboBox1 = new ComboBox();
            DateDeNaissance = new DateTimePicker();
            NumPoids = new NumericUpDown();
            NumTaille = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)NumPoids).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumTaille).BeginInit();
            SuspendLayout();
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(488, 392);
            label9.Name = "label9";
            label9.Size = new Size(198, 20);
            label9.TabIndex = 38;
            label9.Text = "Numero de Securité sociale :";
            // 
            // TxtBoxNSecu
            // 
            TxtBoxNSecu.Location = new Point(488, 415);
            TxtBoxNSecu.Name = "TxtBoxNSecu";
            TxtBoxNSecu.Size = new Size(218, 27);
            TxtBoxNSecu.TabIndex = 37;
            // 
            // TxtBoxPatho
            // 
            TxtBoxPatho.Location = new Point(708, 331);
            TxtBoxPatho.Name = "TxtBoxPatho";
            TxtBoxPatho.Size = new Size(223, 27);
            TxtBoxPatho.TabIndex = 36;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(708, 307);
            label8.Name = "label8";
            label8.Size = new Size(93, 20);
            label8.TabIndex = 35;
            label8.Text = "Pathologies :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(486, 307);
            label7.Name = "label7";
            label7.Size = new Size(47, 20);
            label7.TabIndex = 34;
            label7.Text = "Sexe :";
            // 
            // comboBoxSexe
            // 
            comboBoxSexe.FormattingEnabled = true;
            comboBoxSexe.Location = new Point(488, 330);
            comboBoxSexe.Name = "comboBoxSexe";
            comboBoxSexe.Size = new Size(151, 28);
            comboBoxSexe.TabIndex = 33;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(771, 235);
            label6.Name = "label6";
            label6.Size = new Size(51, 20);
            label6.TabIndex = 30;
            label6.Text = "Poids :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(858, 235);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 29;
            label5.Text = "Taille :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(488, 235);
            label4.Name = "label4";
            label4.Size = new Size(139, 20);
            label4.TabIndex = 28;
            label4.Text = "Date de Naissance :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(745, 149);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 26;
            label3.Text = "Prenom :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(488, 149);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 25;
            label2.Text = "Nom :";
            // 
            // TxtBoxPrenom
            // 
            TxtBoxPrenom.Location = new Point(745, 181);
            TxtBoxPrenom.Name = "TxtBoxPrenom";
            TxtBoxPrenom.Size = new Size(186, 27);
            TxtBoxPrenom.TabIndex = 24;
            // 
            // TxtBoxNom
            // 
            TxtBoxNom.Location = new Point(488, 181);
            TxtBoxNom.Name = "TxtBoxNom";
            TxtBoxNom.Size = new Size(125, 27);
            TxtBoxNom.TabIndex = 23;
            // 
            // CreerPatient
            // 
            CreerPatient.BackColor = Color.Thistle;
            CreerPatient.Location = new Point(776, 404);
            CreerPatient.Name = "CreerPatient";
            CreerPatient.Size = new Size(155, 38);
            CreerPatient.TabIndex = 22;
            CreerPatient.Text = "Créer";
            CreerPatient.UseVisualStyleBackColor = false;
            CreerPatient.Click += CreerPatient_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(594, 75);
            label1.Name = "label1";
            label1.Size = new Size(61, 20);
            label1.TabIndex = 21;
            label1.Text = "Patient :";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(594, 107);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 20;
            // 
            // DateDeNaissance
            // 
            DateDeNaissance.Location = new Point(486, 258);
            DateDeNaissance.Name = "DateDeNaissance";
            DateDeNaissance.Size = new Size(220, 27);
            DateDeNaissance.TabIndex = 0;
            DateDeNaissance.ValueChanged += DateDeNaissance_ValueChanged;
            // 
            // NumPoids
            // 
            NumPoids.Location = new Point(774, 261);
            NumPoids.Name = "NumPoids";
            NumPoids.Size = new Size(48, 27);
            NumPoids.TabIndex = 39;
            // 
            // NumTaille
            // 
            NumTaille.Location = new Point(858, 261);
            NumTaille.Name = "NumTaille";
            NumTaille.Size = new Size(73, 27);
            NumTaille.TabIndex = 40;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1485, 519);
            Controls.Add(NumTaille);
            Controls.Add(NumPoids);
            Controls.Add(DateDeNaissance);
            Controls.Add(label9);
            Controls.Add(TxtBoxNSecu);
            Controls.Add(TxtBoxPatho);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(comboBoxSexe);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(TxtBoxPrenom);
            Controls.Add(TxtBoxNom);
            Controls.Add(CreerPatient);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)NumPoids).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumTaille).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label9;
        private TextBox TxtBoxNSecu;
        private TextBox TxtBoxPatho;
        private Label label8;
        private Label label7;
        private ComboBox comboBoxSexe;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox TxtBoxPrenom;
        private TextBox TxtBoxNom;
        private Button CreerPatient;
        private Label label1;
        private ComboBox comboBox1;
        private DateTimePicker DateDeNaissance;
        private NumericUpDown NumPoids;
        private NumericUpDown NumTaille;
    }
}
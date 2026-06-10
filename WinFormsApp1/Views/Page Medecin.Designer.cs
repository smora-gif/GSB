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
            txtNom = new TextBox();
            txtPrenom = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtPoids = new TextBox();
            txtTaille = new TextBox();
            comboBoxSexe = new ComboBox();
            label7 = new Label();
            label8 = new Label();
            txtPatho = new TextBox();
            txtSecu = new TextBox();
            label9 = new Label();
            btnValider = new Button();
            btnModifier = new Button();
            dateNaissance = new DateTimePicker();
            btnOrdonnaces = new Button();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(667, 55);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(667, 32);
            label1.Name = "label1";
            label1.Size = new Size(61, 20);
            label1.TabIndex = 1;
            label1.Text = "Patient :";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Info;
            button1.Location = new Point(910, 348);
            button1.Name = "button1";
            button1.Size = new Size(155, 38);
            button1.TabIndex = 2;
            button1.Text = "Nouveau Patient";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtNom
            // 
            txtNom.Location = new Point(555, 123);
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(125, 27);
            txtNom.TabIndex = 3;
            // 
            // txtPrenom
            // 
            txtPrenom.Location = new Point(812, 123);
            txtPrenom.Name = "txtPrenom";
            txtPrenom.Size = new Size(186, 27);
            txtPrenom.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(555, 91);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 5;
            label2.Text = "Nom :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(812, 91);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 6;
            label3.Text = "Prenom :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(617, 173);
            label4.Name = "label4";
            label4.Size = new Size(139, 20);
            label4.TabIndex = 8;
            label4.Text = "Date de Naissance :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(900, 173);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 9;
            label5.Text = "Taille :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(802, 173);
            label6.Name = "label6";
            label6.Size = new Size(51, 20);
            label6.TabIndex = 10;
            label6.Text = "Poids :";
            // 
            // txtPoids
            // 
            txtPoids.Location = new Point(802, 196);
            txtPoids.Name = "txtPoids";
            txtPoids.Size = new Size(61, 27);
            txtPoids.TabIndex = 11;
            // 
            // txtTaille
            // 
            txtTaille.Location = new Point(900, 196);
            txtTaille.Name = "txtTaille";
            txtTaille.Size = new Size(97, 27);
            txtTaille.TabIndex = 12;
            // 
            // comboBoxSexe
            // 
            comboBoxSexe.FormattingEnabled = true;
            comboBoxSexe.Location = new Point(555, 272);
            comboBoxSexe.Name = "comboBoxSexe";
            comboBoxSexe.Size = new Size(151, 28);
            comboBoxSexe.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(553, 249);
            label7.Name = "label7";
            label7.Size = new Size(47, 20);
            label7.TabIndex = 14;
            label7.Text = "Sexe :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(775, 249);
            label8.Name = "label8";
            label8.Size = new Size(93, 20);
            label8.TabIndex = 15;
            label8.Text = "Pathologies :";
            // 
            // txtPatho
            // 
            txtPatho.Location = new Point(775, 273);
            txtPatho.Name = "txtPatho";
            txtPatho.Size = new Size(223, 27);
            txtPatho.TabIndex = 16;
            // 
            // txtSecu
            // 
            txtSecu.Location = new Point(555, 357);
            txtSecu.Name = "txtSecu";
            txtSecu.Size = new Size(218, 27);
            txtSecu.TabIndex = 17;
            txtSecu.TextChanged += textBox7_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(555, 334);
            label9.Name = "label9";
            label9.Size = new Size(198, 20);
            label9.TabIndex = 18;
            label9.Text = "Numero de Securité sociale :";
            // 
            // btnValider
            // 
            btnValider.Location = new Point(553, 404);
            btnValider.Name = "btnValider";
            btnValider.Size = new Size(200, 56);
            btnValider.TabIndex = 21;
            btnValider.Text = "Liste des Patients";
            btnValider.UseVisualStyleBackColor = true;
            btnValider.Click += button3_Click;
            // 
            // btnModifier
            // 
            btnModifier.BackColor = Color.Plum;
            btnModifier.ForeColor = SystemColors.ActiveCaptionText;
            btnModifier.Location = new Point(794, 353);
            btnModifier.Name = "btnModifier";
            btnModifier.Size = new Size(94, 29);
            btnModifier.TabIndex = 22;
            btnModifier.Text = "Modifier";
            btnModifier.UseVisualStyleBackColor = false;
            btnModifier.Click += btnModifier_Click_1;
            // 
            // dateNaissance
            // 
            dateNaissance.Format = DateTimePickerFormat.Short;
            dateNaissance.Location = new Point(555, 196);
            dateNaissance.Name = "dateNaissance";
            dateNaissance.Size = new Size(235, 27);
            dateNaissance.TabIndex = 23;
            // 
            // btnOrdonnaces
            // 
            btnOrdonnaces.Location = new Point(794, 404);
            btnOrdonnaces.Name = "btnOrdonnaces";
            btnOrdonnaces.Size = new Size(198, 56);
            btnOrdonnaces.TabIndex = 24;
            btnOrdonnaces.Text = "Page Ordonnaces";
            btnOrdonnaces.UseVisualStyleBackColor = true;
            btnOrdonnaces.Click += btnOrdonnaces_Click;
            // 
            // Page_Medecin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1481, 520);
            Controls.Add(btnOrdonnaces);
            Controls.Add(dateNaissance);
            Controls.Add(btnModifier);
            Controls.Add(btnValider);
            Controls.Add(label9);
            Controls.Add(txtSecu);
            Controls.Add(txtPatho);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(comboBoxSexe);
            Controls.Add(txtTaille);
            Controls.Add(txtPoids);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtPrenom);
            Controls.Add(txtNom);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Name = "Page_Medecin";
            Text = "Page_Medecin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label label1;
        private Button button1;
        private TextBox txtNom;
        private TextBox txtPrenom;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtPoids;
        private TextBox txtTaille;
        private ComboBox comboBoxSexe;
        private Label label7;
        private Label label8;
        private TextBox txtPatho;
        private TextBox txtSecu;
        private Label label9;
        private Button btnValider;
        private Button btnModifier;
        private DateTimePicker dateNaissance;
        private Button btnOrdonnaces;
    }
}
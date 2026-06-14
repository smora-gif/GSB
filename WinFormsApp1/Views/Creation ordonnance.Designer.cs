namespace WinFormsApp1
{
    partial class Creation_ordonnance
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
            ComBoxMedicament = new ComboBox();
            comboBoxUnitDose = new ComboBox();
            label1 = new Label();
            ListDose = new NumericUpDown();
            label2 = new Label();
            label3 = new Label();
            TxtBoxFrequence = new TextBox();
            label4 = new Label();
            label7 = new Label();
            BtnValider = new Button();
            TabMeds = new DataGridView();
            Medicament = new DataGridViewTextBoxColumn();
            Dose = new DataGridViewTextBoxColumn();
            Frequence = new DataGridViewTextBoxColumn();
            Limite = new DataGridViewTextBoxColumn();
            button3 = new Button();
            DateLimConsomation = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)ListDose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TabMeds).BeginInit();
            SuspendLayout();
            // 
            // ComBoxMedicament
            // 
            ComBoxMedicament.FormattingEnabled = true;
            ComBoxMedicament.Location = new Point(374, 50);
            ComBoxMedicament.Margin = new Padding(3, 2, 3, 2);
            ComBoxMedicament.Name = "ComBoxMedicament";
            ComBoxMedicament.Size = new Size(133, 23);
            ComBoxMedicament.TabIndex = 0;
            ComBoxMedicament.SelectedIndexChanged += ComBoxMedicament_SelectedIndexChanged;
            // 
            // comboBoxUnitDose
            // 
            comboBoxUnitDose.FormattingEnabled = true;
            comboBoxUnitDose.Location = new Point(529, 112);
            comboBoxUnitDose.Margin = new Padding(3, 2, 3, 2);
            comboBoxUnitDose.Name = "comboBoxUnitDose";
            comboBoxUnitDose.Size = new Size(47, 23);
            comboBoxUnitDose.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(374, 32);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 4;
            label1.Text = "Medicament :";
            // 
            // ListDose
            // 
            ListDose.Location = new Point(374, 113);
            ListDose.Margin = new Padding(3, 2, 3, 2);
            ListDose.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            ListDose.Name = "ListDose";
            ListDose.Size = new Size(131, 23);
            ListDose.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(374, 96);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 6;
            label2.Text = "Dose :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(374, 146);
            label3.Name = "label3";
            label3.Size = new Size(68, 15);
            label3.TabIndex = 7;
            label3.Text = "Frequence :";
            // 
            // TxtBoxFrequence
            // 
            TxtBoxFrequence.Location = new Point(374, 164);
            TxtBoxFrequence.Margin = new Padding(3, 2, 3, 2);
            TxtBoxFrequence.Name = "TxtBoxFrequence";
            TxtBoxFrequence.Size = new Size(110, 23);
            TxtBoxFrequence.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(550, 96);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 9;
            label4.Text = "unité :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(713, 67);
            label7.Name = "label7";
            label7.Size = new Size(73, 15);
            label7.TabIndex = 14;
            label7.Text = "Date Limite :";
            // 
            // BtnValider
            // 
            BtnValider.BackColor = SystemColors.GradientInactiveCaption;
            BtnValider.Location = new Point(397, 345);
            BtnValider.Margin = new Padding(3, 2, 3, 2);
            BtnValider.Name = "BtnValider";
            BtnValider.Size = new Size(109, 35);
            BtnValider.TabIndex = 16;
            BtnValider.Text = "Valider";
            BtnValider.UseVisualStyleBackColor = false;
            BtnValider.Click += BtnValider_Click;
            // 
            // TabMeds
            // 
            TabMeds.AllowUserToAddRows = false;
            TabMeds.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TabMeds.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            TabMeds.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            TabMeds.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TabMeds.Columns.AddRange(new DataGridViewColumn[] { Medicament, Dose, Frequence, Limite });
            TabMeds.Location = new Point(374, 191);
            TabMeds.Margin = new Padding(3, 2, 3, 2);
            TabMeds.Name = "TabMeds";
            TabMeds.RowHeadersWidth = 51;
            TabMeds.Size = new Size(569, 150);
            TabMeds.TabIndex = 17;
            // 
            // Medicament
            // 
            Medicament.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Medicament.HeaderText = "Medicament";
            Medicament.MinimumWidth = 6;
            Medicament.Name = "Medicament";
            // 
            // Dose
            // 
            Dose.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Dose.HeaderText = "Dose";
            Dose.MinimumWidth = 6;
            Dose.Name = "Dose";
            // 
            // Frequence
            // 
            Frequence.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Frequence.HeaderText = "Frequence";
            Frequence.MinimumWidth = 6;
            Frequence.Name = "Frequence";
            // 
            // Limite
            // 
            Limite.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Limite.HeaderText = "Limite";
            Limite.MinimumWidth = 6;
            Limite.Name = "Limite";
            // 
            // button3
            // 
            button3.BackColor = Color.DarkGray;
            button3.Location = new Point(713, 345);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(93, 35);
            button3.TabIndex = 19;
            button3.Text = "Supprimer";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // DateLimConsomation
            // 
            DateLimConsomation.Location = new Point(640, 84);
            DateLimConsomation.Margin = new Padding(3, 2, 3, 2);
            DateLimConsomation.Name = "DateLimConsomation";
            DateLimConsomation.Size = new Size(219, 23);
            DateLimConsomation.TabIndex = 20;
            // 
            // Creation_ordonnance
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1299, 400);
            Controls.Add(DateLimConsomation);
            Controls.Add(button3);
            Controls.Add(TabMeds);
            Controls.Add(BtnValider);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(TxtBoxFrequence);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(ListDose);
            Controls.Add(label1);
            Controls.Add(comboBoxUnitDose);
            Controls.Add(ComBoxMedicament);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Creation_ordonnance";
            Text = "Creation_ordonnance";
            Load += Creation_ordonnance_Load;
            ((System.ComponentModel.ISupportInitialize)ListDose).EndInit();
            ((System.ComponentModel.ISupportInitialize)TabMeds).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion
        private ComboBox ComBoxMedicament;
        private ComboBox comboBoxUnitDose;
        private Label label1;
        private NumericUpDown ListDose;
        private Label label2;
        private Label label3;
        private TextBox TxtBoxFrequence;
        private Label label4;
        private Label label6;
        private ComboBox comboBox3;
        private Label label7;
        private TextBox TxtBoxDateLimite;
        private Button BtnValider;
        private DataGridView TabMeds;
        private DataGridViewTextBoxColumn Medicament;
        private DataGridViewTextBoxColumn Dose;
        private DataGridViewTextBoxColumn Frequence;
        private DataGridViewTextBoxColumn Limite;
        private Button button3;
        private DateTimePicker DateLimConsomation;
    }
}
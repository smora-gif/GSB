namespace WinFormsApp1.Views
{
    partial class PatientDetailForm
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
            lblNom = new Label();
            lblPrenom = new Label();
            lblDateNaissance = new Label();
            lblAge = new Label();
            lblNumeroSecu = new Label();
            lstAllergies = new ListBox();
            dgvHistorique = new DataGridView();
            btnFermer = new Button();
            txtName = new TextBox();
            TxtDetailNee = new TextBox();
            txtDetailNumSecu = new TextBox();
            txtDetailAge = new TextBox();
            txtDetailPrenom = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvHistorique).BeginInit();
            SuspendLayout();
            // 
            // lblNom
            // 
            lblNom.AutoSize = true;
            lblNom.Location = new Point(55, 36);
            lblNom.Name = "lblNom";
            lblNom.Size = new Size(49, 20);
            lblNom.TabIndex = 0;
            lblNom.Text = "Nom :";
            // 
            // lblPrenom
            // 
            lblPrenom.AutoSize = true;
            lblPrenom.Location = new Point(487, 36);
            lblPrenom.Name = "lblPrenom";
            lblPrenom.Size = new Size(60, 20);
            lblPrenom.TabIndex = 1;
            lblPrenom.Text = "Prenom";
            // 
            // lblDateNaissance
            // 
            lblDateNaissance.AutoSize = true;
            lblDateNaissance.Location = new Point(55, 92);
            lblDateNaissance.Name = "lblDateNaissance";
            lblDateNaissance.Size = new Size(69, 20);
            lblDateNaissance.TabIndex = 2;
            lblDateNaissance.Text = "Né(e) le :";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Location = new Point(487, 92);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(43, 20);
            lblAge.TabIndex = 3;
            lblAge.Text = "Âge :";
            // 
            // lblNumeroSecu
            // 
            lblNumeroSecu.AutoSize = true;
            lblNumeroSecu.Location = new Point(56, 164);
            lblNumeroSecu.Name = "lblNumeroSecu";
            lblNumeroSecu.Size = new Size(68, 20);
            lblNumeroSecu.TabIndex = 4;
            lblNumeroSecu.Text = "N° Sécu :";
            // 
            // lstAllergies
            // 
            lstAllergies.FormattingEnabled = true;
            lstAllergies.Location = new Point(12, 217);
            lstAllergies.Name = "lstAllergies";
            lstAllergies.Size = new Size(444, 324);
            lstAllergies.TabIndex = 5;
            // 
            // dgvHistorique
            // 
            dgvHistorique.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistorique.Location = new Point(487, 217);
            dgvHistorique.Name = "dgvHistorique";
            dgvHistorique.RowHeadersWidth = 51;
            dgvHistorique.Size = new Size(580, 316);
            dgvHistorique.TabIndex = 6;
            // 
            // btnFermer
            // 
            btnFermer.Location = new Point(903, 539);
            btnFermer.Name = "btnFermer";
            btnFermer.Size = new Size(164, 57);
            btnFermer.TabIndex = 7;
            btnFermer.Text = "Fermer";
            btnFermer.UseVisualStyleBackColor = true;
            btnFermer.Click += btnFermer_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(113, 37);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 8;
            // 
            // TxtDetailNee
            // 
            TxtDetailNee.Location = new Point(130, 92);
            TxtDetailNee.Name = "TxtDetailNee";
            TxtDetailNee.Size = new Size(125, 27);
            TxtDetailNee.TabIndex = 9;
            // 
            // txtDetailNumSecu
            // 
            txtDetailNumSecu.Location = new Point(130, 164);
            txtDetailNumSecu.Name = "txtDetailNumSecu";
            txtDetailNumSecu.Size = new Size(177, 27);
            txtDetailNumSecu.TabIndex = 10;
            // 
            // txtDetailAge
            // 
            txtDetailAge.Location = new Point(536, 89);
            txtDetailAge.Name = "txtDetailAge";
            txtDetailAge.Size = new Size(83, 27);
            txtDetailAge.TabIndex = 11;
            // 
            // txtDetailPrenom
            // 
            txtDetailPrenom.Location = new Point(553, 33);
            txtDetailPrenom.Name = "txtDetailPrenom";
            txtDetailPrenom.Size = new Size(125, 27);
            txtDetailPrenom.TabIndex = 12;
            // 
            // PatientDetailForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1092, 605);
            Controls.Add(txtDetailPrenom);
            Controls.Add(txtDetailAge);
            Controls.Add(txtDetailNumSecu);
            Controls.Add(TxtDetailNee);
            Controls.Add(txtName);
            Controls.Add(btnFermer);
            Controls.Add(dgvHistorique);
            Controls.Add(lstAllergies);
            Controls.Add(lblNumeroSecu);
            Controls.Add(lblAge);
            Controls.Add(lblDateNaissance);
            Controls.Add(lblPrenom);
            Controls.Add(lblNom);
            Name = "PatientDetailForm";
            Text = "PatientDetailForm";
            Load += PatientDetailForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvHistorique).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNom;
        private Label lblPrenom;
        private Label lblDateNaissance;
        private Label lblAge;
        private Label lblNumeroSecu;
        private ListBox lstAllergies;
        private DataGridView dgvHistorique;
        private Button btnFermer;
        private TextBox txtName;
        private TextBox TxtDetailNee;
        private TextBox txtDetailNumSecu;
        private TextBox txtDetailAge;
        private TextBox txtDetailPrenom;
    }
}
using WinFormsApp1.Modele;

namespace WinFormsApp1.Views
{
    partial class PatientListForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvPatients;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dgvPatients = new DataGridView();
            label1 = new Label();
            txtRecherche = new TextBox();
            btnReset = new Button();
            btnRechercher = new Button();
            lblNbPatients = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPatients).BeginInit();
            SuspendLayout();
            // 
            // dgvPatients
            // 
            dgvPatients.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvPatients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPatients.Location = new Point(12, 12);
            dgvPatients.Name = "dgvPatients";
            dgvPatients.RowHeadersWidth = 51;
            dgvPatients.Size = new Size(1122, 483);
            dgvPatients.TabIndex = 0;
            dgvPatients.CellDoubleClick += dgvPatients_CellDoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(130, 508);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 1;
            label1.Text = "Recherche";
            // 
            // txtRecherche
            // 
            txtRecherche.Location = new Point(213, 505);
            txtRecherche.Name = "txtRecherche";
            txtRecherche.Size = new Size(125, 27);
            txtRecherche.TabIndex = 2;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(980, 499);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(154, 39);
            btnReset.TabIndex = 3;
            btnReset.Text = "Tout Afficher";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnRechercher
            // 
            btnRechercher.Location = new Point(644, 501);
            btnRechercher.Name = "btnRechercher";
            btnRechercher.Size = new Size(112, 39);
            btnRechercher.TabIndex = 4;
            btnRechercher.Text = "Valider";
            btnRechercher.UseVisualStyleBackColor = true;
            btnRechercher.UseWaitCursor = true;
            btnRechercher.Click += btnRechercher_Click_1;
            // 
            // lblNbPatients
            // 
            lblNbPatients.AutoSize = true;
            lblNbPatients.Location = new Point(364, 510);
            lblNbPatients.Name = "lblNbPatients";
            lblNbPatients.Size = new Size(91, 20);
            lblNbPatients.TabIndex = 5;
            lblNbPatients.Text = "Nb Patients :";
            // 
            // PatientListForm
            // 
            ClientSize = new Size(1162, 549);
            Controls.Add(lblNbPatients);
            Controls.Add(btnRechercher);
            Controls.Add(btnReset);
            Controls.Add(txtRecherche);
            Controls.Add(label1);
            Controls.Add(dgvPatients);
            Name = "PatientListForm";
            Text = "Liste des patients";
            Load += PatientListForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPatients).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1;
        private TextBox txtRecherche;
        private Button btnReset;
        private Button btnRechercher;
        private Label lblNbPatients;
    }
}
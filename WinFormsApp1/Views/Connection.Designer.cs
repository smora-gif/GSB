namespace WinFormsApp1
{
    partial class Connection
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
            txtboxUtilisateur = new TextBox();
            label1 = new Label();
            txtboxMdp = new TextBox();
            label2 = new Label();
            btnConnection = new Button();
            label3 = new Label();
            linkInscription = new LinkLabel();
            SuspendLayout();
            // 
            // txtboxUtilisateur
            // 
            txtboxUtilisateur.Location = new Point(602, 97);
            txtboxUtilisateur.Name = "txtboxUtilisateur";
            txtboxUtilisateur.Size = new Size(242, 27);
            txtboxUtilisateur.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(592, 74);
            label1.Name = "label1";
            label1.Size = new Size(83, 20);
            label1.TabIndex = 1;
            label1.Text = "Utilisateur :";
            // 
            // txtboxMdp
            // 
            txtboxMdp.Location = new Point(602, 189);
            txtboxMdp.Name = "txtboxMdp";
            txtboxMdp.Size = new Size(242, 27);
            txtboxMdp.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(602, 166);
            label2.Name = "label2";
            label2.Size = new Size(105, 20);
            label2.TabIndex = 3;
            label2.Text = "Mot de passe :";
            // 
            // btnConnection
            // 
            btnConnection.BackColor = SystemColors.ActiveCaption;
            btnConnection.ForeColor = Color.Black;
            btnConnection.Location = new Point(665, 257);
            btnConnection.Name = "btnConnection";
            btnConnection.Size = new Size(122, 44);
            btnConnection.TabIndex = 4;
            btnConnection.Text = "Se connecter";
            btnConnection.UseVisualStyleBackColor = false;
            btnConnection.Click += btnConnection_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(659, 346);
            label3.Name = "label3";
            label3.Size = new Size(38, 28);
            label3.TabIndex = 5;
            label3.Text = "Ou";
            // 
            // linkInscription
            // 
            linkInscription.AutoSize = true;
            linkInscription.Font = new Font("Segoe UI", 12F);
            linkInscription.Location = new Point(697, 346);
            linkInscription.Name = "linkInscription";
            linkInscription.Size = new Size(90, 28);
            linkInscription.TabIndex = 7;
            linkInscription.TabStop = true;
            linkInscription.Text = "S'inscrire";
            linkInscription.LinkClicked += linkInscription_LinkClicked;
            // 
            // Connection
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1469, 508);
            Controls.Add(linkInscription);
            Controls.Add(label3);
            Controls.Add(btnConnection);
            Controls.Add(label2);
            Controls.Add(txtboxMdp);
            Controls.Add(label1);
            Controls.Add(txtboxUtilisateur);
            Name = "Connection";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtboxUtilisateur;
        private Label label1;
        private TextBox txtboxMdp;
        private Label label2;
        private Button btnConnection;
        private Label label3;
        private LinkLabel linkInscription;
    }
}

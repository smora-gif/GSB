namespace WinFormsApp1
{
    partial class Inscription
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            TxtboxNomIn = new TextBox();
            TxtBoxPrenomIn = new TextBox();
            TxtBoxEmail = new TextBox();
            TxtBoxMdpIn = new TextBox();
            TxtBoxConfirmdp = new TextBox();
            BtnSinscrire = new Button();
            TxtBoxRpps = new TextBox();
            TxtBoxSpe = new TextBox();
            label7 = new Label();
            dtpDateNaissance = new DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(428, 75);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 0;
            label1.Text = "Nom :";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(818, 75);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 1;
            label2.Text = "Prenom :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(428, 198);
            label3.Name = "label3";
            label3.Size = new Size(103, 20);
            label3.TabIndex = 2;
            label3.Text = "Numero RPPS:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(818, 198);
            label4.Name = "label4";
            label4.Size = new Size(53, 20);
            label4.TabIndex = 3;
            label4.Text = "Email :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(428, 322);
            label5.Name = "label5";
            label5.Size = new Size(105, 20);
            label5.TabIndex = 4;
            label5.Text = "Mot de passe :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(818, 322);
            label6.Name = "label6";
            label6.Size = new Size(196, 20);
            label6.TabIndex = 5;
            label6.Text = "Confirmation Mot de passe :";
            // 
            // TxtboxNomIn
            // 
            TxtboxNomIn.Location = new Point(428, 108);
            TxtboxNomIn.Name = "TxtboxNomIn";
            TxtboxNomIn.Size = new Size(188, 27);
            TxtboxNomIn.TabIndex = 6;
            TxtboxNomIn.TextChanged += textBox1_TextChanged;
            // 
            // TxtBoxPrenomIn
            // 
            TxtBoxPrenomIn.Location = new Point(818, 108);
            TxtBoxPrenomIn.Name = "TxtBoxPrenomIn";
            TxtBoxPrenomIn.Size = new Size(188, 27);
            TxtBoxPrenomIn.TabIndex = 7;
            // 
            // TxtBoxEmail
            // 
            TxtBoxEmail.Location = new Point(818, 243);
            TxtBoxEmail.Name = "TxtBoxEmail";
            TxtBoxEmail.Size = new Size(188, 27);
            TxtBoxEmail.TabIndex = 9;
            // 
            // TxtBoxMdpIn
            // 
            TxtBoxMdpIn.Location = new Point(428, 367);
            TxtBoxMdpIn.Name = "TxtBoxMdpIn";
            TxtBoxMdpIn.Size = new Size(188, 27);
            TxtBoxMdpIn.TabIndex = 10;
            // 
            // TxtBoxConfirmdp
            // 
            TxtBoxConfirmdp.Location = new Point(818, 367);
            TxtBoxConfirmdp.Name = "TxtBoxConfirmdp";
            TxtBoxConfirmdp.Size = new Size(188, 27);
            TxtBoxConfirmdp.TabIndex = 11;
            // 
            // BtnSinscrire
            // 
            BtnSinscrire.BackColor = SystemColors.ActiveCaption;
            BtnSinscrire.Location = new Point(659, 442);
            BtnSinscrire.Name = "BtnSinscrire";
            BtnSinscrire.Size = new Size(131, 44);
            BtnSinscrire.TabIndex = 12;
            BtnSinscrire.Text = "S'inscrire";
            BtnSinscrire.UseVisualStyleBackColor = false;
            BtnSinscrire.Click += BtnSinscrire_Click;
            // 
            // TxtBoxRpps
            // 
            TxtBoxRpps.Location = new Point(428, 243);
            TxtBoxRpps.Name = "TxtBoxRpps";
            TxtBoxRpps.Size = new Size(188, 27);
            TxtBoxRpps.TabIndex = 8;
            // 
            // TxtBoxSpe
            // 
            TxtBoxSpe.Location = new Point(638, 302);
            TxtBoxSpe.Name = "TxtBoxSpe";
            TxtBoxSpe.Size = new Size(152, 27);
            TxtBoxSpe.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(638, 279);
            label7.Name = "label7";
            label7.Size = new Size(77, 20);
            label7.TabIndex = 14;
            label7.Text = "Specialité:";
            // 
            // dtpDateNaissance
            // 
            dtpDateNaissance.Location = new Point(593, 168);
            dtpDateNaissance.Name = "dtpDateNaissance";
            dtpDateNaissance.Size = new Size(254, 27);
            dtpDateNaissance.TabIndex = 0;
            // 
            // Inscription
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1475, 527);
            Controls.Add(dtpDateNaissance);
            Controls.Add(label7);
            Controls.Add(TxtBoxSpe);
            Controls.Add(BtnSinscrire);
            Controls.Add(TxtBoxConfirmdp);
            Controls.Add(TxtBoxMdpIn);
            Controls.Add(TxtBoxEmail);
            Controls.Add(TxtBoxRpps);
            Controls.Add(TxtBoxPrenomIn);
            Controls.Add(TxtboxNomIn);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Inscription";
            Text = "Inscription";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox TxtboxNomIn;
        private TextBox TxtBoxPrenomIn;
        private TextBox TxtBoxEmail;
        private TextBox TxtBoxMdpIn;
        private TextBox TxtBoxConfirmdp;
        private Button BtnSinscrire;
        private TextBox TxtBoxRpps;
        private TextBox TxtBoxSpe;
        private Label label7;
        private DateTimePicker dtpDateNaissance;
    }
}
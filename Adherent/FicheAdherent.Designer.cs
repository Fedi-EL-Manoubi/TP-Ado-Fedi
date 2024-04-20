namespace TPlivre
{
    partial class FicheAdherent
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
            components = new System.ComponentModel.Container();
            lb_num = new Label();
            lb_nom = new Label();
            lb_prenom = new Label();
            lb_rue = new Label();
            btn_cancel = new Button();
            btn_submit = new Button();
            txb_rue = new TextBox();
            bs_fiche = new BindingSource(components);
            txb_prenom = new TextBox();
            txb_nom = new TextBox();
            txb_num = new TextBox();
            txb_cp = new TextBox();
            lb_cp = new Label();
            txb_tel = new TextBox();
            lb_tel = new Label();
            txb_ville = new TextBox();
            lb_ville = new Label();
            txb_mel = new TextBox();
            lb_mel = new Label();
            ((System.ComponentModel.ISupportInitialize)bs_fiche).BeginInit();
            SuspendLayout();
            // 
            // lb_num
            // 
            lb_num.AutoSize = true;
            lb_num.Location = new Point(43, 35);
            lb_num.Name = "lb_num";
            lb_num.Size = new Size(59, 15);
            lb_num.TabIndex = 0;
            lb_num.Text = "Numéro *";
            // 
            // lb_nom
            // 
            lb_nom.AutoSize = true;
            lb_nom.Location = new Point(43, 64);
            lb_nom.Name = "lb_nom";
            lb_nom.Size = new Size(42, 15);
            lb_nom.TabIndex = 1;
            lb_nom.Text = "Nom *";
            // 
            // lb_prenom
            // 
            lb_prenom.AutoSize = true;
            lb_prenom.Location = new Point(43, 93);
            lb_prenom.Name = "lb_prenom";
            lb_prenom.Size = new Size(57, 15);
            lb_prenom.TabIndex = 2;
            lb_prenom.Text = "Prenom *";
            // 
            // lb_rue
            // 
            lb_rue.AutoSize = true;
            lb_rue.Location = new Point(43, 122);
            lb_rue.Name = "lb_rue";
            lb_rue.Size = new Size(27, 15);
            lb_rue.TabIndex = 3;
            lb_rue.Text = "Rue";
            // 
            // btn_cancel
            // 
            btn_cancel.Location = new Point(43, 304);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(75, 23);
            btn_cancel.TabIndex = 4;
            btn_cancel.Text = "Annuler";
            btn_cancel.UseVisualStyleBackColor = true;
            btn_cancel.Click += btn_cancel_Click;
            // 
            // btn_submit
            // 
            btn_submit.Location = new Point(209, 304);
            btn_submit.Name = "btn_submit";
            btn_submit.Size = new Size(75, 23);
            btn_submit.TabIndex = 5;
            btn_submit.Text = "Valider";
            btn_submit.UseVisualStyleBackColor = true;
            btn_submit.Click += btn_submit_Click;
            // 
            // txb_rue
            // 
            txb_rue.DataBindings.Add(new Binding("Text", bs_fiche, "AdrRue", true));
            txb_rue.Location = new Point(114, 119);
            txb_rue.Name = "txb_rue";
            txb_rue.Size = new Size(170, 23);
            txb_rue.TabIndex = 6;
            // 
            // bs_fiche
            // 
            bs_fiche.DataSource = typeof(Entity.Adherent);
            // 
            // txb_prenom
            // 
            txb_prenom.DataBindings.Add(new Binding("Text", bs_fiche, "Prenom", true));
            txb_prenom.Location = new Point(114, 90);
            txb_prenom.Name = "txb_prenom";
            txb_prenom.Size = new Size(170, 23);
            txb_prenom.TabIndex = 7;
            // 
            // txb_nom
            // 
            txb_nom.DataBindings.Add(new Binding("Text", bs_fiche, "Nom", true));
            txb_nom.Location = new Point(114, 61);
            txb_nom.Name = "txb_nom";
            txb_nom.Size = new Size(170, 23);
            txb_nom.TabIndex = 8;
            // 
            // txb_num
            // 
            txb_num.DataBindings.Add(new Binding("Text", bs_fiche, "Num", true, DataSourceUpdateMode.OnValidation, null, "N2"));
            txb_num.Enabled = false;
            txb_num.Location = new Point(114, 32);
            txb_num.Name = "txb_num";
            txb_num.Size = new Size(170, 23);
            txb_num.TabIndex = 9;
            // 
            // txb_cp
            // 
            txb_cp.DataBindings.Add(new Binding("Text", bs_fiche, "AdrCP", true));
            txb_cp.Location = new Point(114, 148);
            txb_cp.Name = "txb_cp";
            txb_cp.Size = new Size(170, 23);
            txb_cp.TabIndex = 11;
            // 
            // lb_cp
            // 
            lb_cp.AutoSize = true;
            lb_cp.Location = new Point(43, 151);
            lb_cp.Name = "lb_cp";
            lb_cp.Size = new Size(70, 15);
            lb_cp.TabIndex = 10;
            lb_cp.Text = "Code postal";
            // 
            // txb_tel
            // 
            txb_tel.DataBindings.Add(new Binding("Text", bs_fiche, "Tel", true));
            txb_tel.Location = new Point(114, 206);
            txb_tel.Name = "txb_tel";
            txb_tel.Size = new Size(170, 23);
            txb_tel.TabIndex = 15;
            // 
            // lb_tel
            // 
            lb_tel.AutoSize = true;
            lb_tel.Location = new Point(43, 209);
            lb_tel.Name = "lb_tel";
            lb_tel.Size = new Size(61, 15);
            lb_tel.TabIndex = 14;
            lb_tel.Text = "Téléphone";
            // 
            // txb_ville
            // 
            txb_ville.DataBindings.Add(new Binding("Text", bs_fiche, "AdrVille", true));
            txb_ville.Location = new Point(114, 177);
            txb_ville.Name = "txb_ville";
            txb_ville.Size = new Size(170, 23);
            txb_ville.TabIndex = 13;
            // 
            // lb_ville
            // 
            lb_ville.AutoSize = true;
            lb_ville.Location = new Point(43, 180);
            lb_ville.Name = "lb_ville";
            lb_ville.Size = new Size(29, 15);
            lb_ville.TabIndex = 12;
            lb_ville.Text = "Ville";
            // 
            // txb_mel
            // 
            txb_mel.DataBindings.Add(new Binding("Text", bs_fiche, "Mel", true));
            txb_mel.Location = new Point(114, 234);
            txb_mel.Name = "txb_mel";
            txb_mel.Size = new Size(170, 23);
            txb_mel.TabIndex = 17;
            // 
            // lb_mel
            // 
            lb_mel.AutoSize = true;
            lb_mel.Location = new Point(43, 237);
            lb_mel.Name = "lb_mel";
            lb_mel.Size = new Size(27, 15);
            lb_mel.TabIndex = 16;
            lb_mel.Text = "Mél";
            // 
            // FicheAdherent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(340, 356);
            Controls.Add(txb_mel);
            Controls.Add(lb_mel);
            Controls.Add(txb_tel);
            Controls.Add(lb_tel);
            Controls.Add(txb_ville);
            Controls.Add(lb_ville);
            Controls.Add(txb_cp);
            Controls.Add(lb_cp);
            Controls.Add(txb_num);
            Controls.Add(txb_nom);
            Controls.Add(txb_prenom);
            Controls.Add(txb_rue);
            Controls.Add(btn_submit);
            Controls.Add(btn_cancel);
            Controls.Add(lb_rue);
            Controls.Add(lb_prenom);
            Controls.Add(lb_nom);
            Controls.Add(lb_num);
            Name = "FicheAdherent";
            Text = "FicheAdherent";
            ((System.ComponentModel.ISupportInitialize)bs_fiche).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_num;
        private Label lb_nom;
        private Label lb_prenom;
        private Label lb_rue;
        private Button btn_cancel;
        private Button btn_submit;
        private TextBox txb_rue;
        private TextBox txb_prenom;
        private TextBox txb_nom;
        private TextBox txb_num;
        private BindingSource bs_fiche;
        private TextBox txb_cp;
        private Label lb_cp;
        private TextBox txb_tel;
        private Label lb_tel;
        private TextBox txb_ville;
        private Label lb_ville;
        private TextBox txb_mel;
        private Label lb_mel;
    }
}
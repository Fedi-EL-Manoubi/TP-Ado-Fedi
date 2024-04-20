namespace TPlivre
{
    partial class FicheLivre
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
            lb_isbn = new Label();
            lb_titre = new Label();
            lb_prix = new Label();
            btn_cancel = new Button();
            btn_submit = new Button();
            txb_prix = new TextBox();
            bs_fiche = new BindingSource(components);
            txb_titre = new TextBox();
            txb_isbn = new TextBox();
            txb_num = new TextBox();
            txb_editeur = new TextBox();
            lb_editeur = new Label();
            txb_langue = new TextBox();
            lb_langue = new Label();
            txb_annee = new TextBox();
            lb_annee = new Label();
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
            // lb_isbn
            // 
            lb_isbn.AutoSize = true;
            lb_isbn.Location = new Point(43, 64);
            lb_isbn.Name = "lb_isbn";
            lb_isbn.Size = new Size(40, 15);
            lb_isbn.TabIndex = 1;
            lb_isbn.Text = "ISBN *";
            // 
            // lb_titre
            // 
            lb_titre.AutoSize = true;
            lb_titre.Location = new Point(43, 93);
            lb_titre.Name = "lb_titre";
            lb_titre.Size = new Size(38, 15);
            lb_titre.TabIndex = 2;
            lb_titre.Text = "Titre *";
            // 
            // lb_prix
            // 
            lb_prix.AutoSize = true;
            lb_prix.Location = new Point(43, 122);
            lb_prix.Name = "lb_prix";
            lb_prix.Size = new Size(27, 15);
            lb_prix.TabIndex = 3;
            lb_prix.Text = "Prix";
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
            // txb_prix
            // 
            txb_prix.DataBindings.Add(new Binding("Text", bs_fiche, "Prix", true));
            txb_prix.Location = new Point(114, 119);
            txb_prix.Name = "txb_prix";
            txb_prix.Size = new Size(170, 23);
            txb_prix.TabIndex = 6;
            // 
            // bs_fiche
            // 
            bs_fiche.DataSource = typeof(Entity.Livre);
            // 
            // txb_titre
            // 
            txb_titre.DataBindings.Add(new Binding("Text", bs_fiche, "Titre", true));
            txb_titre.Location = new Point(114, 90);
            txb_titre.Name = "txb_titre";
            txb_titre.Size = new Size(170, 23);
            txb_titre.TabIndex = 7;
            // 
            // txb_isbn
            // 
            txb_isbn.DataBindings.Add(new Binding("Text", bs_fiche, "Isbn", true));
            txb_isbn.Location = new Point(114, 61);
            txb_isbn.Name = "txb_isbn";
            txb_isbn.Size = new Size(170, 23);
            txb_isbn.TabIndex = 8;
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
            // txb_editeur
            // 
            txb_editeur.DataBindings.Add(new Binding("Text", bs_fiche, "Editeur", true));
            txb_editeur.Location = new Point(114, 148);
            txb_editeur.Name = "txb_editeur";
            txb_editeur.Size = new Size(170, 23);
            txb_editeur.TabIndex = 11;
            // 
            // lb_editeur
            // 
            lb_editeur.AutoSize = true;
            lb_editeur.Location = new Point(43, 151);
            lb_editeur.Name = "lb_editeur";
            lb_editeur.Size = new Size(44, 15);
            lb_editeur.TabIndex = 10;
            lb_editeur.Text = "Editeur";
            // 
            // txb_langue
            // 
            txb_langue.DataBindings.Add(new Binding("Text", bs_fiche, "Langue", true));
            txb_langue.Location = new Point(114, 206);
            txb_langue.Name = "txb_langue";
            txb_langue.Size = new Size(170, 23);
            txb_langue.TabIndex = 15;
            // 
            // lb_langue
            // 
            lb_langue.AutoSize = true;
            lb_langue.Location = new Point(43, 209);
            lb_langue.Name = "lb_langue";
            lb_langue.Size = new Size(46, 15);
            lb_langue.TabIndex = 14;
            lb_langue.Text = "Langue";
            // 
            // txb_annee
            // 
            txb_annee.DataBindings.Add(new Binding("Text", bs_fiche, "Annee", true));
            txb_annee.Location = new Point(114, 177);
            txb_annee.Name = "txb_annee";
            txb_annee.Size = new Size(170, 23);
            txb_annee.TabIndex = 13;
            // 
            // lb_annee
            // 
            lb_annee.AutoSize = true;
            lb_annee.Location = new Point(43, 180);
            lb_annee.Name = "lb_annee";
            lb_annee.Size = new Size(41, 15);
            lb_annee.TabIndex = 12;
            lb_annee.Text = "Année";
            // 
            // FicheLivre
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(340, 356);
            Controls.Add(txb_langue);
            Controls.Add(lb_langue);
            Controls.Add(txb_annee);
            Controls.Add(lb_annee);
            Controls.Add(txb_editeur);
            Controls.Add(lb_editeur);
            Controls.Add(txb_num);
            Controls.Add(txb_isbn);
            Controls.Add(txb_titre);
            Controls.Add(txb_prix);
            Controls.Add(btn_submit);
            Controls.Add(btn_cancel);
            Controls.Add(lb_prix);
            Controls.Add(lb_titre);
            Controls.Add(lb_isbn);
            Controls.Add(lb_num);
            Name = "FicheLivre";
            Text = "FicheLivre";
            ((System.ComponentModel.ISupportInitialize)bs_fiche).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_num;
        private Label lb_isbn;
        private Label lb_titre;
        private Label lb_prix;
        private Button btn_cancel;
        private Button btn_submit;
        private TextBox txb_prix;
        private TextBox txb_titre;
        private TextBox txb_isbn;
        private TextBox txb_num;
        private BindingSource bs_fiche;
        private TextBox txb_editeur;
        private Label lb_editeur;
        private TextBox txb_langue;
        private Label lb_langue;
        private TextBox txb_annee;
        private Label lb_annee;
    }
}
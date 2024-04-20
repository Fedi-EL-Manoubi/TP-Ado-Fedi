namespace TPlivre
{
    partial class FicheAuteur
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
            lb_natio = new Label();
            btn_cancel = new Button();
            btn_submit = new Button();
            txb_natio = new TextBox();
            bs_fiche = new BindingSource(components);
            txb_prenom = new TextBox();
            txb_nom = new TextBox();
            txb_num = new TextBox();
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
            lb_prenom.Size = new Size(49, 15);
            lb_prenom.TabIndex = 2;
            lb_prenom.Text = "Prénom";
            // 
            // lb_natio
            // 
            lb_natio.AutoSize = true;
            lb_natio.Location = new Point(43, 122);
            lb_natio.Name = "lb_natio";
            lb_natio.Size = new Size(65, 15);
            lb_natio.TabIndex = 3;
            lb_natio.Text = "Nationalité";
            // 
            // btn_cancel
            // 
            btn_cancel.Location = new Point(43, 173);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(75, 23);
            btn_cancel.TabIndex = 4;
            btn_cancel.Text = "Annuler";
            btn_cancel.UseVisualStyleBackColor = true;
            btn_cancel.Click += btn_cancel_Click;
            // 
            // btn_submit
            // 
            btn_submit.Location = new Point(209, 173);
            btn_submit.Name = "btn_submit";
            btn_submit.Size = new Size(75, 23);
            btn_submit.TabIndex = 5;
            btn_submit.Text = "Valider";
            btn_submit.UseVisualStyleBackColor = true;
            btn_submit.Click += btn_submit_Click;
            // 
            // txb_natio
            // 
            txb_natio.DataBindings.Add(new Binding("Text", bs_fiche, "Nationalite", true));
            txb_natio.Location = new Point(114, 119);
            txb_natio.Name = "txb_natio";
            txb_natio.Size = new Size(170, 23);
            txb_natio.TabIndex = 6;
            // 
            // bs_fiche
            // 
            bs_fiche.DataSource = typeof(Entity.Auteur);
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
            // FicheAuteur
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(340, 226);
            Controls.Add(txb_num);
            Controls.Add(txb_nom);
            Controls.Add(txb_prenom);
            Controls.Add(txb_natio);
            Controls.Add(btn_submit);
            Controls.Add(btn_cancel);
            Controls.Add(lb_natio);
            Controls.Add(lb_prenom);
            Controls.Add(lb_nom);
            Controls.Add(lb_num);
            Name = "FicheAuteur";
            Text = "FicheAuteur";
            ((System.ComponentModel.ISupportInitialize)bs_fiche).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_num;
        private Label lb_nom;
        private Label lb_prenom;
        private Label lb_natio;
        private Button btn_cancel;
        private Button btn_submit;
        private TextBox txb_natio;
        private TextBox txb_prenom;
        private TextBox txb_nom;
        private TextBox txb_num;
        private BindingSource bs_fiche;
    }
}
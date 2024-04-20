namespace TPlivre
{
    partial class FicheGenre
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
            lb_lib = new Label();
            btn_cancel = new Button();
            btn_submit = new Button();
            bs_fiche = new BindingSource(components);
            txb_lib = new TextBox();
            txb_num = new TextBox();
            ((System.ComponentModel.ISupportInitialize)bs_fiche).BeginInit();
            SuspendLayout();
            // 
            // lb_num
            // 
            lb_num.AutoSize = true;
            lb_num.Location = new Point(43, 63);
            lb_num.Name = "lb_num";
            lb_num.Size = new Size(59, 15);
            lb_num.TabIndex = 0;
            lb_num.Text = "Numéro *";
            // 
            // lb_lib
            // 
            lb_lib.AutoSize = true;
            lb_lib.Location = new Point(43, 92);
            lb_lib.Name = "lb_lib";
            lb_lib.Size = new Size(49, 15);
            lb_lib.TabIndex = 1;
            lb_lib.Text = "Libelle *";
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
            // bs_fiche
            // 
            bs_fiche.DataSource = typeof(Entity.Genre);
            // 
            // txb_lib
            // 
            txb_lib.DataBindings.Add(new Binding("Text", bs_fiche, "Libelle", true));
            txb_lib.Location = new Point(114, 89);
            txb_lib.Name = "txb_lib";
            txb_lib.Size = new Size(170, 23);
            txb_lib.TabIndex = 8;
            // 
            // txb_num
            // 
            txb_num.DataBindings.Add(new Binding("Text", bs_fiche, "Num", true, DataSourceUpdateMode.OnValidation, null, "N2"));
            txb_num.Enabled = false;
            txb_num.Location = new Point(114, 60);
            txb_num.Name = "txb_num";
            txb_num.Size = new Size(170, 23);
            txb_num.TabIndex = 9;
            // 
            // FicheGenre
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(340, 226);
            Controls.Add(txb_num);
            Controls.Add(txb_lib);
            Controls.Add(btn_submit);
            Controls.Add(btn_cancel);
            Controls.Add(lb_lib);
            Controls.Add(lb_num);
            Name = "FicheGenre";
            Text = "FicheGenre";
            ((System.ComponentModel.ISupportInitialize)bs_fiche).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_num;
        private Label lb_lib;
        private Label lb_prenom;
        private Label lb_natio;
        private Button btn_cancel;
        private Button btn_submit;
        private TextBox txb_natio;
        private TextBox txb_prenom;
        private TextBox txb_lib;
        private TextBox txb_num;
        private BindingSource bs_fiche;
    }
}
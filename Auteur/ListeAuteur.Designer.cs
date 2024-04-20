namespace TPlivre
{
    partial class Form_listeAuteur : Form
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
            components = new System.ComponentModel.Container();
            dgv_ListeAuteur = new DataGridView();
            numDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nomDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            prenomDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nationaliteDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bs_table = new BindingSource(components);
            btn_afficher = new Button();
            btn_edit = new Button();
            btn_suppr = new Button();
            btn_add = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_ListeAuteur).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bs_table).BeginInit();
            SuspendLayout();
            // 
            // dgv_ListeAuteur
            // 
            dgv_ListeAuteur.AllowUserToAddRows = false;
            dgv_ListeAuteur.AllowUserToDeleteRows = false;
            dgv_ListeAuteur.AutoGenerateColumns = false;
            dgv_ListeAuteur.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_ListeAuteur.BorderStyle = BorderStyle.None;
            dgv_ListeAuteur.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv_ListeAuteur.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_ListeAuteur.Columns.AddRange(new DataGridViewColumn[] { numDataGridViewTextBoxColumn, nomDataGridViewTextBoxColumn, prenomDataGridViewTextBoxColumn, nationaliteDataGridViewTextBoxColumn });
            dgv_ListeAuteur.DataSource = bs_table;
            dgv_ListeAuteur.Location = new Point(12, 12);
            dgv_ListeAuteur.MultiSelect = false;
            dgv_ListeAuteur.Name = "dgv_ListeAuteur";
            dgv_ListeAuteur.ReadOnly = true;
            dgv_ListeAuteur.RowTemplate.Height = 25;
            dgv_ListeAuteur.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_ListeAuteur.Size = new Size(575, 398);
            dgv_ListeAuteur.TabIndex = 0;
            // 
            // numDataGridViewTextBoxColumn
            // 
            numDataGridViewTextBoxColumn.DataPropertyName = "Num";
            numDataGridViewTextBoxColumn.HeaderText = "Numéro";
            numDataGridViewTextBoxColumn.Name = "numDataGridViewTextBoxColumn";
            numDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomDataGridViewTextBoxColumn
            // 
            nomDataGridViewTextBoxColumn.DataPropertyName = "Nom";
            nomDataGridViewTextBoxColumn.HeaderText = "Nom";
            nomDataGridViewTextBoxColumn.Name = "nomDataGridViewTextBoxColumn";
            nomDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prenomDataGridViewTextBoxColumn
            // 
            prenomDataGridViewTextBoxColumn.DataPropertyName = "Prenom";
            prenomDataGridViewTextBoxColumn.HeaderText = "Prenom";
            prenomDataGridViewTextBoxColumn.Name = "prenomDataGridViewTextBoxColumn";
            prenomDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nationaliteDataGridViewTextBoxColumn
            // 
            nationaliteDataGridViewTextBoxColumn.DataPropertyName = "Nationalite";
            nationaliteDataGridViewTextBoxColumn.HeaderText = "Nationalité";
            nationaliteDataGridViewTextBoxColumn.Name = "nationaliteDataGridViewTextBoxColumn";
            nationaliteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bs_table
            // 
            bs_table.DataSource = typeof(Entity.Auteur);
            // 
            // btn_afficher
            // 
            btn_afficher.Location = new Point(12, 416);
            btn_afficher.Name = "btn_afficher";
            btn_afficher.Size = new Size(75, 23);
            btn_afficher.TabIndex = 1;
            btn_afficher.Text = "Afficher";
            btn_afficher.UseVisualStyleBackColor = true;
            btn_afficher.Click += btn_afficher_Click;
            // 
            // btn_edit
            // 
            btn_edit.Location = new Point(93, 416);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new Size(75, 23);
            btn_edit.TabIndex = 2;
            btn_edit.Text = "Modifier";
            btn_edit.UseVisualStyleBackColor = true;
            btn_edit.Click += btn_edit_Click;
            // 
            // btn_suppr
            // 
            btn_suppr.Location = new Point(174, 416);
            btn_suppr.Name = "btn_suppr";
            btn_suppr.Size = new Size(75, 23);
            btn_suppr.TabIndex = 3;
            btn_suppr.Text = "Supprimer";
            btn_suppr.UseVisualStyleBackColor = true;
            btn_suppr.Click += btn_suppr_Click;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(255, 416);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(75, 23);
            btn_add.TabIndex = 4;
            btn_add.Text = "Ajouter";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // Form_listeAuteur
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(599, 451);
            Controls.Add(btn_add);
            Controls.Add(btn_suppr);
            Controls.Add(btn_edit);
            Controls.Add(btn_afficher);
            Controls.Add(dgv_ListeAuteur);
            Name = "Form_listeAuteur";
            Text = "Liste des auteurs";
            ((System.ComponentModel.ISupportInitialize)dgv_ListeAuteur).EndInit();
            ((System.ComponentModel.ISupportInitialize)bs_table).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgv_ListeAuteur;
        private Button btn_afficher;
        private Button btn_edit;
        private Button btn_suppr;
        private Button btn_add;
        private BindingSource bs_table;
        private DataGridViewTextBoxColumn numDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn prenomDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nationaliteDataGridViewTextBoxColumn;
    }
}
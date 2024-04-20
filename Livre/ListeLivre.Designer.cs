namespace TPlivre
{
    partial class Form_listeLivre : Form
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
            dgv_ListeLivre = new DataGridView();
            numDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            isbnDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            titreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            prixDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            editeurDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            anneeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            langueDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bs_table = new BindingSource(components);
            btn_afficher = new Button();
            btn_edit = new Button();
            btn_suppr = new Button();
            btn_add = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_ListeLivre).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bs_table).BeginInit();
            SuspendLayout();
            // 
            // dgv_ListeLivre
            // 
            dgv_ListeLivre.AllowUserToAddRows = false;
            dgv_ListeLivre.AllowUserToDeleteRows = false;
            dgv_ListeLivre.AutoGenerateColumns = false;
            dgv_ListeLivre.BorderStyle = BorderStyle.None;
            dgv_ListeLivre.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv_ListeLivre.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_ListeLivre.Columns.AddRange(new DataGridViewColumn[] { numDataGridViewTextBoxColumn, isbnDataGridViewTextBoxColumn, titreDataGridViewTextBoxColumn, prixDataGridViewTextBoxColumn, editeurDataGridViewTextBoxColumn, anneeDataGridViewTextBoxColumn, langueDataGridViewTextBoxColumn });
            dgv_ListeLivre.DataSource = bs_table;
            dgv_ListeLivre.Location = new Point(12, 12);
            dgv_ListeLivre.MultiSelect = false;
            dgv_ListeLivre.Name = "dgv_ListeLivre";
            dgv_ListeLivre.ReadOnly = true;
            dgv_ListeLivre.RowTemplate.Height = 25;
            dgv_ListeLivre.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_ListeLivre.Size = new Size(575, 398);
            dgv_ListeLivre.TabIndex = 0;
            // 
            // numDataGridViewTextBoxColumn
            // 
            numDataGridViewTextBoxColumn.DataPropertyName = "Num";
            numDataGridViewTextBoxColumn.HeaderText = "Num";
            numDataGridViewTextBoxColumn.Name = "numDataGridViewTextBoxColumn";
            numDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // isbnDataGridViewTextBoxColumn
            // 
            isbnDataGridViewTextBoxColumn.DataPropertyName = "Isbn";
            isbnDataGridViewTextBoxColumn.HeaderText = "Isbn";
            isbnDataGridViewTextBoxColumn.Name = "isbnDataGridViewTextBoxColumn";
            isbnDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // titreDataGridViewTextBoxColumn
            // 
            titreDataGridViewTextBoxColumn.DataPropertyName = "Titre";
            titreDataGridViewTextBoxColumn.HeaderText = "Titre";
            titreDataGridViewTextBoxColumn.Name = "titreDataGridViewTextBoxColumn";
            titreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prixDataGridViewTextBoxColumn
            // 
            prixDataGridViewTextBoxColumn.DataPropertyName = "Prix";
            prixDataGridViewTextBoxColumn.HeaderText = "Prix";
            prixDataGridViewTextBoxColumn.Name = "prixDataGridViewTextBoxColumn";
            prixDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // editeurDataGridViewTextBoxColumn
            // 
            editeurDataGridViewTextBoxColumn.DataPropertyName = "Editeur";
            editeurDataGridViewTextBoxColumn.HeaderText = "Editeur";
            editeurDataGridViewTextBoxColumn.Name = "editeurDataGridViewTextBoxColumn";
            editeurDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // anneeDataGridViewTextBoxColumn
            // 
            anneeDataGridViewTextBoxColumn.DataPropertyName = "Annee";
            anneeDataGridViewTextBoxColumn.HeaderText = "Annee";
            anneeDataGridViewTextBoxColumn.Name = "anneeDataGridViewTextBoxColumn";
            anneeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // langueDataGridViewTextBoxColumn
            // 
            langueDataGridViewTextBoxColumn.DataPropertyName = "Langue";
            langueDataGridViewTextBoxColumn.HeaderText = "Langue";
            langueDataGridViewTextBoxColumn.Name = "langueDataGridViewTextBoxColumn";
            langueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bs_table
            // 
            bs_table.DataSource = typeof(Entity.Livre);
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
            // Form_listeLivre
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(599, 451);
            Controls.Add(btn_add);
            Controls.Add(btn_suppr);
            Controls.Add(btn_edit);
            Controls.Add(btn_afficher);
            Controls.Add(dgv_ListeLivre);
            Name = "Form_listeLivre";
            Text = "Liste des livres";
            ((System.ComponentModel.ISupportInitialize)dgv_ListeLivre).EndInit();
            ((System.ComponentModel.ISupportInitialize)bs_table).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgv_ListeLivre;
        private Button btn_afficher;
        private Button btn_edit;
        private Button btn_suppr;
        private Button btn_add;
        private BindingSource bs_table;
        private DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn prenomDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nationaliteDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn numDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn isbnDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn titreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn prixDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn editeurDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn anneeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn langueDataGridViewTextBoxColumn;
    }
}
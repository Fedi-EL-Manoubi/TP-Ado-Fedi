namespace TPlivre
{
    partial class Form_listeAdherent : Form
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
            dgv_ListeAdherent = new DataGridView();
            numDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            adrRueDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            adrCPDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            adrVilleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            telDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            melDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bs_table = new BindingSource(components);
            btn_afficher = new Button();
            btn_edit = new Button();
            btn_suppr = new Button();
            btn_add = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_ListeAdherent).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bs_table).BeginInit();
            SuspendLayout();
            // 
            // dgv_ListeAdherent
            // 
            dgv_ListeAdherent.AllowUserToAddRows = false;
            dgv_ListeAdherent.AllowUserToDeleteRows = false;
            dgv_ListeAdherent.AutoGenerateColumns = false;
            dgv_ListeAdherent.BorderStyle = BorderStyle.None;
            dgv_ListeAdherent.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv_ListeAdherent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_ListeAdherent.Columns.AddRange(new DataGridViewColumn[] { numDataGridViewTextBoxColumn, dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, adrRueDataGridViewTextBoxColumn, adrCPDataGridViewTextBoxColumn, adrVilleDataGridViewTextBoxColumn, telDataGridViewTextBoxColumn, melDataGridViewTextBoxColumn });
            dgv_ListeAdherent.DataSource = bs_table;
            dgv_ListeAdherent.Location = new Point(12, 12);
            dgv_ListeAdherent.MultiSelect = false;
            dgv_ListeAdherent.Name = "dgv_ListeAdherent";
            dgv_ListeAdherent.ReadOnly = true;
            dgv_ListeAdherent.RowTemplate.Height = 25;
            dgv_ListeAdherent.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_ListeAdherent.Size = new Size(575, 397);
            dgv_ListeAdherent.TabIndex = 0;
            // 
            // numDataGridViewTextBoxColumn
            // 
            numDataGridViewTextBoxColumn.DataPropertyName = "Num";
            numDataGridViewTextBoxColumn.HeaderText = "Num";
            numDataGridViewTextBoxColumn.Name = "numDataGridViewTextBoxColumn";
            numDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "Nom";
            dataGridViewTextBoxColumn1.HeaderText = "Nom";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "Prenom";
            dataGridViewTextBoxColumn2.HeaderText = "Prenom";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // adrRueDataGridViewTextBoxColumn
            // 
            adrRueDataGridViewTextBoxColumn.DataPropertyName = "AdrRue";
            adrRueDataGridViewTextBoxColumn.HeaderText = "AdrRue";
            adrRueDataGridViewTextBoxColumn.Name = "adrRueDataGridViewTextBoxColumn";
            adrRueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adrCPDataGridViewTextBoxColumn
            // 
            adrCPDataGridViewTextBoxColumn.DataPropertyName = "AdrCP";
            adrCPDataGridViewTextBoxColumn.HeaderText = "AdrCP";
            adrCPDataGridViewTextBoxColumn.Name = "adrCPDataGridViewTextBoxColumn";
            adrCPDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adrVilleDataGridViewTextBoxColumn
            // 
            adrVilleDataGridViewTextBoxColumn.DataPropertyName = "AdrVille";
            adrVilleDataGridViewTextBoxColumn.HeaderText = "AdrVille";
            adrVilleDataGridViewTextBoxColumn.Name = "adrVilleDataGridViewTextBoxColumn";
            adrVilleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telDataGridViewTextBoxColumn
            // 
            telDataGridViewTextBoxColumn.DataPropertyName = "Tel";
            telDataGridViewTextBoxColumn.HeaderText = "Tel";
            telDataGridViewTextBoxColumn.Name = "telDataGridViewTextBoxColumn";
            telDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // melDataGridViewTextBoxColumn
            // 
            melDataGridViewTextBoxColumn.DataPropertyName = "Mel";
            melDataGridViewTextBoxColumn.HeaderText = "Mel";
            melDataGridViewTextBoxColumn.Name = "melDataGridViewTextBoxColumn";
            melDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bs_table
            // 
            bs_table.DataSource = typeof(Entity.Adherent);
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
            // Form_listeAdherent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(599, 451);
            Controls.Add(btn_add);
            Controls.Add(btn_suppr);
            Controls.Add(btn_edit);
            Controls.Add(btn_afficher);
            Controls.Add(dgv_ListeAdherent);
            Name = "Form_listeAdherent";
            Text = "Liste des adhérents";
            ((System.ComponentModel.ISupportInitialize)dgv_ListeAdherent).EndInit();
            ((System.ComponentModel.ISupportInitialize)bs_table).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgv_ListeAdherent;
        private Button btn_afficher;
        private Button btn_edit;
        private Button btn_suppr;
        private Button btn_add;
        private BindingSource bs_table;
        private DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn prenomDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nationaliteDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn isbnDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn titreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn prixDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn editeurDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn anneeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn langueDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn numDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn adrRueDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn adrCPDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn adrVilleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn telDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn melDataGridViewTextBoxColumn;
    }
}
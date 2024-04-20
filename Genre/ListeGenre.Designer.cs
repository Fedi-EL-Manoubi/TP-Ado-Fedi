namespace TPlivre
{
    partial class Form_listeGenre : Form
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
            dgv_ListeGenre = new DataGridView();
            numDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            libelleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bs_table = new BindingSource(components);
            btn_afficher = new Button();
            btn_edit = new Button();
            btn_suppr = new Button();
            btn_add = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_ListeGenre).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bs_table).BeginInit();
            SuspendLayout();
            // 
            // dgv_ListeGenre
            // 
            dgv_ListeGenre.AllowUserToAddRows = false;
            dgv_ListeGenre.AllowUserToDeleteRows = false;
            dgv_ListeGenre.AutoGenerateColumns = false;
            dgv_ListeGenre.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_ListeGenre.BorderStyle = BorderStyle.None;
            dgv_ListeGenre.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv_ListeGenre.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_ListeGenre.Columns.AddRange(new DataGridViewColumn[] { numDataGridViewTextBoxColumn, libelleDataGridViewTextBoxColumn });
            dgv_ListeGenre.DataSource = bs_table;
            dgv_ListeGenre.Location = new Point(12, 12);
            dgv_ListeGenre.MultiSelect = false;
            dgv_ListeGenre.Name = "dgv_ListeGenre";
            dgv_ListeGenre.ReadOnly = true;
            dgv_ListeGenre.RowTemplate.Height = 25;
            dgv_ListeGenre.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_ListeGenre.Size = new Size(575, 398);
            dgv_ListeGenre.TabIndex = 0;
            // 
            // numDataGridViewTextBoxColumn
            // 
            numDataGridViewTextBoxColumn.DataPropertyName = "Num";
            numDataGridViewTextBoxColumn.HeaderText = "Num";
            numDataGridViewTextBoxColumn.Name = "numDataGridViewTextBoxColumn";
            numDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // libelleDataGridViewTextBoxColumn
            // 
            libelleDataGridViewTextBoxColumn.DataPropertyName = "Libelle";
            libelleDataGridViewTextBoxColumn.HeaderText = "Libelle";
            libelleDataGridViewTextBoxColumn.Name = "libelleDataGridViewTextBoxColumn";
            libelleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bs_table
            // 
            bs_table.DataSource = typeof(Entity.Genre);
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
            // Form_listeGenre
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(599, 451);
            Controls.Add(btn_add);
            Controls.Add(btn_suppr);
            Controls.Add(btn_edit);
            Controls.Add(btn_afficher);
            Controls.Add(dgv_ListeGenre);
            Name = "Form_listeGenre";
            Text = "Liste des genres";
            ((System.ComponentModel.ISupportInitialize)dgv_ListeGenre).EndInit();
            ((System.ComponentModel.ISupportInitialize)bs_table).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgv_ListeGenre;
        private Button btn_afficher;
        private Button btn_edit;
        private Button btn_suppr;
        private Button btn_add;
        private BindingSource bs_table;
        private DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn prenomDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nationaliteDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn numDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn libelleDataGridViewTextBoxColumn;
    }
}
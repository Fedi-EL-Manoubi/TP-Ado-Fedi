namespace TPlivre
{
    partial class Form_Menu
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
            menuStrip1 = new MenuStrip();
            quitterToolStripMenuItem = new ToolStripMenuItem();
            tabesToolStripMenuItem = new ToolStripMenuItem();
            auteurToolStripMenuItem = new ToolStripMenuItem();
            genresToolStripMenuItem = new ToolStripMenuItem();
            livresToolStripMenuItem = new ToolStripMenuItem();
            adhérentToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { quitterToolStripMenuItem, tabesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(335, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // quitterToolStripMenuItem
            // 
            quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            quitterToolStripMenuItem.Size = new Size(56, 20);
            quitterToolStripMenuItem.Text = "Quitter";
            quitterToolStripMenuItem.Click += quitterToolStripMenuItem_Click;
            // 
            // tabesToolStripMenuItem
            // 
            tabesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { auteurToolStripMenuItem, genresToolStripMenuItem, livresToolStripMenuItem, adhérentToolStripMenuItem });
            tabesToolStripMenuItem.Name = "tabesToolStripMenuItem";
            tabesToolStripMenuItem.Size = new Size(51, 20);
            tabesToolStripMenuItem.Text = "Tables";
            // 
            // auteurToolStripMenuItem
            // 
            auteurToolStripMenuItem.Name = "auteurToolStripMenuItem";
            auteurToolStripMenuItem.Size = new Size(180, 22);
            auteurToolStripMenuItem.Text = "Auteurs";
            auteurToolStripMenuItem.Click += auteurToolStripMenuItem_Click;
            // 
            // genresToolStripMenuItem
            // 
            genresToolStripMenuItem.Name = "genresToolStripMenuItem";
            genresToolStripMenuItem.Size = new Size(180, 22);
            genresToolStripMenuItem.Text = "Genres";
            genresToolStripMenuItem.Click += genresToolStripMenuItem_Click;
            // 
            // livresToolStripMenuItem
            // 
            livresToolStripMenuItem.Name = "livresToolStripMenuItem";
            livresToolStripMenuItem.Size = new Size(180, 22);
            livresToolStripMenuItem.Text = "Livres";
            livresToolStripMenuItem.Click += livresToolStripMenuItem_Click;
            // 
            // adhérentToolStripMenuItem
            // 
            adhérentToolStripMenuItem.Name = "adhérentToolStripMenuItem";
            adhérentToolStripMenuItem.Size = new Size(180, 22);
            adhérentToolStripMenuItem.Text = "Adhérent";
            adhérentToolStripMenuItem.Click += adhérentToolStripMenuItem_Click;
            // 
            // Form_Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(335, 280);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form_Menu";
            Text = "Menu";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem quitterToolStripMenuItem;
        private ToolStripMenuItem tabesToolStripMenuItem;
        private ToolStripMenuItem auteurToolStripMenuItem;
        private ToolStripMenuItem genresToolStripMenuItem;
        private ToolStripMenuItem livresToolStripMenuItem;
        private ToolStripMenuItem adhérentToolStripMenuItem;
    }
}

namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /////// Required designer variable.
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.EditMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ComputerMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.NewGameMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.LoadGameMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveGameMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.UndoMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.RedoMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowLogMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowMoveMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.NullMovePrunningMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.PrincipalVariationSearchMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.QuiescentSearchMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowComputerThinkDepthMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenu,
            this.EditMenu,
            this.ComputerMenu,
            this.HelpMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileMenu
            // 
            this.FileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewGameMenu,
            this.LoadGameMenu,
            this.SaveGameMenu,
            this.ExitMenu});
            this.FileMenu.Name = "FileMenu";
            this.FileMenu.Size = new System.Drawing.Size(50, 24);
            this.FileMenu.Text = "File ";
            // 
            // EditMenu
            // 
            this.EditMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UndoMenu,
            this.RedoMenu,
            this.ShowLogMenu,
            this.ShowMoveMenu});
            this.EditMenu.Name = "EditMenu";
            this.EditMenu.Size = new System.Drawing.Size(53, 24);
            this.EditMenu.Text = "Edit ";
            // 
            // ComputerMenu
            // 
            this.ComputerMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NullMovePrunningMenu,
            this.PrincipalVariationSearchMenu,
            this.QuiescentSearchMenu,
            this.ShowComputerThinkDepthMenu});
            this.ComputerMenu.Name = "ComputerMenu";
            this.ComputerMenu.Size = new System.Drawing.Size(89, 24);
            this.ComputerMenu.Text = "Computer";
            // 
            // HelpMenu
            // 
            this.HelpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutMenu});
            this.HelpMenu.Name = "HelpMenu";
            this.HelpMenu.Size = new System.Drawing.Size(55, 24);
            this.HelpMenu.Text = "Help";
            // 
            // NewGameMenu
            // 
            this.NewGameMenu.Name = "NewGameMenu";
            this.NewGameMenu.Size = new System.Drawing.Size(224, 26);
            this.NewGameMenu.Text = "New Game";
            // 
            // LoadGameMenu
            // 
            this.LoadGameMenu.Name = "LoadGameMenu";
            this.LoadGameMenu.Size = new System.Drawing.Size(224, 26);
            this.LoadGameMenu.Text = "Load Game";
            this.LoadGameMenu.Click += new System.EventHandler(this.loadGameToolStripMenuItem_Click);
            // 
            // SaveGameMenu
            // 
            this.SaveGameMenu.Name = "SaveGameMenu";
            this.SaveGameMenu.Size = new System.Drawing.Size(224, 26);
            this.SaveGameMenu.Text = "Save Game ";
            // 
            // ExitMenu
            // 
            this.ExitMenu.Name = "ExitMenu";
            this.ExitMenu.Size = new System.Drawing.Size(224, 26);
            this.ExitMenu.Text = "EXIT";
            // 
            // UndoMenu
            // 
            this.UndoMenu.Name = "UndoMenu";
            this.UndoMenu.Size = new System.Drawing.Size(224, 26);
            this.UndoMenu.Text = "Undo";
            // 
            // RedoMenu
            // 
            this.RedoMenu.Name = "RedoMenu";
            this.RedoMenu.Size = new System.Drawing.Size(224, 26);
            this.RedoMenu.Text = "Redo";
            // 
            // ShowLogMenu
            // 
            this.ShowLogMenu.Name = "ShowLogMenu";
            this.ShowLogMenu.Size = new System.Drawing.Size(224, 26);
            this.ShowLogMenu.Text = "Show Log";
            // 
            // ShowMoveMenu
            // 
            this.ShowMoveMenu.Name = "ShowMoveMenu";
            this.ShowMoveMenu.Size = new System.Drawing.Size(224, 26);
            this.ShowMoveMenu.Text = "Show Move Help";
            // 
            // NullMovePrunningMenu
            // 
            this.NullMovePrunningMenu.Name = "NullMovePrunningMenu";
            this.NullMovePrunningMenu.Size = new System.Drawing.Size(282, 26);
            this.NullMovePrunningMenu.Text = "Null Move Prunning ";
            // 
            // PrincipalVariationSearchMenu
            // 
            this.PrincipalVariationSearchMenu.Name = "PrincipalVariationSearchMenu";
            this.PrincipalVariationSearchMenu.Size = new System.Drawing.Size(282, 26);
            this.PrincipalVariationSearchMenu.Text = "Principal Variation Search";
            // 
            // QuiescentSearchMenu
            // 
            this.QuiescentSearchMenu.Name = "QuiescentSearchMenu";
            this.QuiescentSearchMenu.Size = new System.Drawing.Size(282, 26);
            this.QuiescentSearchMenu.Text = "Quiescent Search";
            // 
            // ShowComputerThinkDepthMenu
            // 
            this.ShowComputerThinkDepthMenu.Name = "ShowComputerThinkDepthMenu";
            this.ShowComputerThinkDepthMenu.Size = new System.Drawing.Size(282, 26);
            this.ShowComputerThinkDepthMenu.Text = "Show Computer Think Depth";
            // 
            // AboutMenu
            // 
            this.AboutMenu.Name = "AboutMenu";
            this.AboutMenu.Size = new System.Drawing.Size(224, 26);
            this.AboutMenu.Text = "About";
            this.AboutMenu.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileMenu;
        private System.Windows.Forms.ToolStripMenuItem NewGameMenu;
        private System.Windows.Forms.ToolStripMenuItem LoadGameMenu;
        private System.Windows.Forms.ToolStripMenuItem SaveGameMenu;
        private System.Windows.Forms.ToolStripMenuItem ExitMenu;
        private System.Windows.Forms.ToolStripMenuItem EditMenu;
        private System.Windows.Forms.ToolStripMenuItem UndoMenu;
        private System.Windows.Forms.ToolStripMenuItem RedoMenu;
        private System.Windows.Forms.ToolStripMenuItem ShowLogMenu;
        private System.Windows.Forms.ToolStripMenuItem ShowMoveMenu;
        private System.Windows.Forms.ToolStripMenuItem ComputerMenu;
        private System.Windows.Forms.ToolStripMenuItem NullMovePrunningMenu;
        private System.Windows.Forms.ToolStripMenuItem PrincipalVariationSearchMenu;
        private System.Windows.Forms.ToolStripMenuItem QuiescentSearchMenu;
        private System.Windows.Forms.ToolStripMenuItem ShowComputerThinkDepthMenu;
        private System.Windows.Forms.ToolStripMenuItem HelpMenu;
        private System.Windows.Forms.ToolStripMenuItem AboutMenu;
    }
}


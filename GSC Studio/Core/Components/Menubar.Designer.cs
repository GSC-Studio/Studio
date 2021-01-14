
namespace GSC_Studio.Core.Components
{
    partial class Menubar
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateProject = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateFile = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.SaveCurrentFile = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveWholeProject = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.LastProjects = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseCurrentProject = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.QuitStudio = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buildToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.debugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.Cut = new System.Windows.Forms.ToolStripMenuItem();
            this.Copy = new System.Windows.Forms.ToolStripMenuItem();
            this.Paste = new System.Windows.Forms.ToolStripMenuItem();
            this.Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.SelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.Undo = new System.Windows.Forms.ToolStripMenuItem();
            this.Redo = new System.Windows.Forms.ToolStripMenuItem();
            this.BuildProject = new System.Windows.Forms.ToolStripMenuItem();
            this.platfromToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BuildForConsole = new System.Windows.Forms.ToolStripMenuItem();
            this.BuildForPC = new System.Windows.Forms.ToolStripMenuItem();
            this.DebugOnPS3 = new System.Windows.Forms.ToolStripMenuItem();
            this.DebugOnXBOX = new System.Windows.Forms.ToolStripMenuItem();
            this.DebugOnPC = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip1
            // 
            this.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.MenuStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.buildToolStripMenuItem,
            this.debugToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip1.Name = "MenuStrip1";
            this.MenuStrip1.Size = new System.Drawing.Size(541, 63);
            this.MenuStrip1.TabIndex = 0;
            this.MenuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator1,
            this.SaveCurrentFile,
            this.SaveWholeProject,
            this.toolStripSeparator2,
            this.LastProjects,
            this.CloseCurrentProject,
            this.toolStripSeparator3,
            this.QuitStudio});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 59);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateProject,
            this.CreateFile});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // CreateProject
            // 
            this.CreateProject.Name = "CreateProject";
            this.CreateProject.Size = new System.Drawing.Size(180, 22);
            this.CreateProject.Text = "Project";
            // 
            // CreateFile
            // 
            this.CreateFile.Name = "CreateFile";
            this.CreateFile.Size = new System.Drawing.Size(180, 22);
            this.CreateFile.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projectToolStripMenuItem1,
            this.fileToolStripMenuItem2});
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // projectToolStripMenuItem1
            // 
            this.projectToolStripMenuItem1.Name = "projectToolStripMenuItem1";
            this.projectToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.projectToolStripMenuItem1.Text = "Project";
            // 
            // fileToolStripMenuItem2
            // 
            this.fileToolStripMenuItem2.Name = "fileToolStripMenuItem2";
            this.fileToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.fileToolStripMenuItem2.Text = "File";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // SaveCurrentFile
            // 
            this.SaveCurrentFile.Name = "SaveCurrentFile";
            this.SaveCurrentFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.SaveCurrentFile.Size = new System.Drawing.Size(180, 22);
            this.SaveCurrentFile.Text = "Save";
            // 
            // SaveWholeProject
            // 
            this.SaveWholeProject.Name = "SaveWholeProject";
            this.SaveWholeProject.Size = new System.Drawing.Size(180, 22);
            this.SaveWholeProject.Text = "Save all";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // LastProjects
            // 
            this.LastProjects.Name = "LastProjects";
            this.LastProjects.Size = new System.Drawing.Size(180, 22);
            this.LastProjects.Text = "Last Projects";
            // 
            // CloseCurrentProject
            // 
            this.CloseCurrentProject.Name = "CloseCurrentProject";
            this.CloseCurrentProject.Size = new System.Drawing.Size(180, 22);
            this.CloseCurrentProject.Text = "Close Project";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(177, 6);
            // 
            // QuitStudio
            // 
            this.QuitStudio.Name = "QuitStudio";
            this.QuitStudio.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.QuitStudio.Size = new System.Drawing.Size(180, 22);
            this.QuitStudio.Text = "Exit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Redo,
            this.Undo,
            this.toolStripSeparator4,
            this.Cut,
            this.Copy,
            this.Paste,
            this.Delete,
            this.toolStripSeparator5,
            this.SelectAll});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 59);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // buildToolStripMenuItem
            // 
            this.buildToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BuildProject,
            this.platfromToolStripMenuItem});
            this.buildToolStripMenuItem.Name = "buildToolStripMenuItem";
            this.buildToolStripMenuItem.Size = new System.Drawing.Size(46, 59);
            this.buildToolStripMenuItem.Text = "Build";
            // 
            // debugToolStripMenuItem
            // 
            this.debugToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DebugOnPS3,
            this.DebugOnXBOX,
            this.DebugOnPC});
            this.debugToolStripMenuItem.Name = "debugToolStripMenuItem";
            this.debugToolStripMenuItem.Size = new System.Drawing.Size(54, 59);
            this.debugToolStripMenuItem.Text = "Debug";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenAbout,
            this.OpenSettings});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 59);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(177, 6);
            // 
            // Cut
            // 
            this.Cut.Name = "Cut";
            this.Cut.Size = new System.Drawing.Size(180, 22);
            this.Cut.Text = "Cut";
            // 
            // Copy
            // 
            this.Copy.Name = "Copy";
            this.Copy.Size = new System.Drawing.Size(180, 22);
            this.Copy.Text = "Copy";
            // 
            // Paste
            // 
            this.Paste.Name = "Paste";
            this.Paste.Size = new System.Drawing.Size(180, 22);
            this.Paste.Text = "Paste";
            // 
            // Delete
            // 
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(180, 22);
            this.Delete.Text = "Delete";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(177, 6);
            // 
            // SelectAll
            // 
            this.SelectAll.Name = "SelectAll";
            this.SelectAll.Size = new System.Drawing.Size(180, 22);
            this.SelectAll.Text = "Select All";
            // 
            // Undo
            // 
            this.Undo.Name = "Undo";
            this.Undo.Size = new System.Drawing.Size(180, 22);
            this.Undo.Text = "Undo";
            // 
            // Redo
            // 
            this.Redo.Name = "Redo";
            this.Redo.Size = new System.Drawing.Size(180, 22);
            this.Redo.Text = "Redo";
            // 
            // BuildProject
            // 
            this.BuildProject.Name = "BuildProject";
            this.BuildProject.Size = new System.Drawing.Size(180, 22);
            this.BuildProject.Text = "Project";
            // 
            // platfromToolStripMenuItem
            // 
            this.platfromToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BuildForConsole,
            this.BuildForPC});
            this.platfromToolStripMenuItem.Name = "platfromToolStripMenuItem";
            this.platfromToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.platfromToolStripMenuItem.Text = "Platform";
            // 
            // BuildForConsole
            // 
            this.BuildForConsole.Name = "BuildForConsole";
            this.BuildForConsole.Size = new System.Drawing.Size(180, 22);
            this.BuildForConsole.Text = "Console";
            // 
            // BuildForPC
            // 
            this.BuildForPC.Name = "BuildForPC";
            this.BuildForPC.Size = new System.Drawing.Size(180, 22);
            this.BuildForPC.Text = "PC";
            // 
            // DebugOnPS3
            // 
            this.DebugOnPS3.Name = "DebugOnPS3";
            this.DebugOnPS3.Size = new System.Drawing.Size(180, 22);
            this.DebugOnPS3.Text = "PS3";
            // 
            // DebugOnXBOX
            // 
            this.DebugOnXBOX.Name = "DebugOnXBOX";
            this.DebugOnXBOX.Size = new System.Drawing.Size(180, 22);
            this.DebugOnXBOX.Text = "XBOX";
            // 
            // DebugOnPC
            // 
            this.DebugOnPC.Name = "DebugOnPC";
            this.DebugOnPC.Size = new System.Drawing.Size(180, 22);
            this.DebugOnPC.Text = "PC";
            // 
            // OpenAbout
            // 
            this.OpenAbout.Name = "OpenAbout";
            this.OpenAbout.Size = new System.Drawing.Size(180, 22);
            this.OpenAbout.Text = "About";
            // 
            // OpenSettings
            // 
            this.OpenSettings.Name = "OpenSettings";
            this.OpenSettings.Size = new System.Drawing.Size(180, 22);
            this.OpenSettings.Text = "Settings";
            // 
            // Menubar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MenuStrip1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Menubar";
            this.Size = new System.Drawing.Size(541, 63);
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buildToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem debugToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CreateProject;
        private System.Windows.Forms.ToolStripMenuItem CreateFile;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projectToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem SaveCurrentFile;
        private System.Windows.Forms.ToolStripMenuItem SaveWholeProject;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem LastProjects;
        private System.Windows.Forms.ToolStripMenuItem CloseCurrentProject;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem QuitStudio;
        private System.Windows.Forms.ToolStripMenuItem Redo;
        private System.Windows.Forms.ToolStripMenuItem Undo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem Cut;
        private System.Windows.Forms.ToolStripMenuItem Copy;
        private System.Windows.Forms.ToolStripMenuItem Paste;
        private System.Windows.Forms.ToolStripMenuItem Delete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem SelectAll;
        private System.Windows.Forms.ToolStripMenuItem BuildProject;
        private System.Windows.Forms.ToolStripMenuItem platfromToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BuildForConsole;
        private System.Windows.Forms.ToolStripMenuItem BuildForPC;
        private System.Windows.Forms.ToolStripMenuItem DebugOnPS3;
        private System.Windows.Forms.ToolStripMenuItem DebugOnXBOX;
        private System.Windows.Forms.ToolStripMenuItem DebugOnPC;
        private System.Windows.Forms.ToolStripMenuItem OpenAbout;
        private System.Windows.Forms.ToolStripMenuItem OpenSettings;
    }
}

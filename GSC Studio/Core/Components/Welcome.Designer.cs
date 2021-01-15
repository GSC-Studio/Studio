
namespace GSC_Studio.Core.Components
{
    partial class Welcome
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.title = new System.Windows.Forms.Label();
            this.NewProject = new System.Windows.Forms.Label();
            this.OpenProject = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Splitter = new System.Windows.Forms.Panel();
            this.LastProjects = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LastProjects);
            this.panel1.Controls.Add(this.Splitter);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.OpenProject);
            this.panel1.Controls.Add(this.NewProject);
            this.panel1.Controls.Add(this.title);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(423, 533);
            this.panel1.TabIndex = 0;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(13, 13);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(136, 37);
            this.title.TabIndex = 0;
            this.title.Text = "Welcome";
            // 
            // NewProject
            // 
            this.NewProject.AutoSize = true;
            this.NewProject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NewProject.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewProject.ForeColor = System.Drawing.Color.DodgerBlue;
            this.NewProject.Location = new System.Drawing.Point(16, 88);
            this.NewProject.Name = "NewProject";
            this.NewProject.Size = new System.Drawing.Size(82, 19);
            this.NewProject.TabIndex = 1;
            this.NewProject.Text = "New Project";
            // 
            // OpenProject
            // 
            this.OpenProject.AutoSize = true;
            this.OpenProject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OpenProject.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenProject.ForeColor = System.Drawing.Color.DodgerBlue;
            this.OpenProject.Location = new System.Drawing.Point(16, 117);
            this.OpenProject.Name = "OpenProject";
            this.OpenProject.Size = new System.Drawing.Size(89, 19);
            this.OpenProject.TabIndex = 2;
            this.OpenProject.Text = "Open Project";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkGray;
            this.label3.Location = new System.Drawing.Point(16, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(255, 38);
            this.label3.TabIndex = 3;
            this.label3.Text = "Create your own mods with GSC Studio.\r\n\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkGray;
            this.label4.Location = new System.Drawing.Point(16, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Recently opened";
            // 
            // Splitter
            // 
            this.Splitter.BackColor = System.Drawing.Color.DarkGray;
            this.Splitter.Location = new System.Drawing.Point(20, 276);
            this.Splitter.Name = "Splitter";
            this.Splitter.Size = new System.Drawing.Size(300, 2);
            this.Splitter.TabIndex = 5;
            // 
            // LastProjects
            // 
            this.LastProjects.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.LastProjects.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LastProjects.ForeColor = System.Drawing.Color.White;
            this.LastProjects.FormattingEnabled = true;
            this.LastProjects.Location = new System.Drawing.Point(20, 284);
            this.LastProjects.Name = "LastProjects";
            this.LastProjects.Size = new System.Drawing.Size(300, 156);
            this.LastProjects.TabIndex = 6;
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(543, 533);
            this.Controls.Add(this.panel1);
            this.DockAreas = WeifenLuo.WinFormsUI.Docking.DockAreas.Document;
            this.Name = "Welcome";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Welcome";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox LastProjects;
        private System.Windows.Forms.Panel Splitter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label OpenProject;
        private System.Windows.Forms.Label NewProject;
        private System.Windows.Forms.Label title;
    }
}

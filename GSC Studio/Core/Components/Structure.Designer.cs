
namespace GSC_Studio.Core.Components
{
    partial class Structure
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
            this.Statusbar = new System.Windows.Forms.StatusStrip();
            this.Docker = new WeifenLuo.WinFormsUI.Docking.DockPanel();
            this.DarkTheme = new WeifenLuo.WinFormsUI.Docking.VS2015DarkTheme();
            this.SuspendLayout();
            // 
            // Statusbar
            // 
            this.Statusbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.Statusbar.Location = new System.Drawing.Point(0, 362);
            this.Statusbar.Name = "Statusbar";
            this.Statusbar.Size = new System.Drawing.Size(664, 22);
            this.Statusbar.SizingGrip = false;
            this.Statusbar.TabIndex = 0;
            this.Statusbar.Text = "Statusbar";
            // 
            // Docker
            // 
            this.Docker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Docker.DockBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Docker.DocumentStyle = WeifenLuo.WinFormsUI.Docking.DocumentStyle.DockingWindow;
            this.Docker.Location = new System.Drawing.Point(0, 0);
            this.Docker.Name = "Docker";
            this.Docker.Padding = new System.Windows.Forms.Padding(6);
            this.Docker.ShowAutoHideContentOnHover = false;
            this.Docker.Size = new System.Drawing.Size(664, 362);
            this.Docker.TabIndex = 1;
            this.Docker.Theme = this.DarkTheme;
            // 
            // Structure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.Docker);
            this.Controls.Add(this.Statusbar);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Structure";
            this.Size = new System.Drawing.Size(664, 384);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip Statusbar;
        private WeifenLuo.WinFormsUI.Docking.DockPanel Docker;
        private WeifenLuo.WinFormsUI.Docking.VS2015DarkTheme DarkTheme;
    }
}

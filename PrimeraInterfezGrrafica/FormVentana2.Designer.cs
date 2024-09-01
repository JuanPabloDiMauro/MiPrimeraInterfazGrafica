namespace PrimeraInterfezGrrafica
{
    partial class FormPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MsPerfil = new System.Windows.Forms.ToolStripMenuItem();
            this.trabajoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hobbiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MsPerfil,
            this.trabajoToolStripMenuItem,
            this.deportesToolStripMenuItem,
            this.hobbiesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(875, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MsPerfil
            // 
            this.MsPerfil.Name = "MsPerfil";
            this.MsPerfil.Size = new System.Drawing.Size(46, 20);
            this.MsPerfil.Text = "&perfil";
            this.MsPerfil.Click += new System.EventHandler(this.MsPerfil_Click);
            // 
            // trabajoToolStripMenuItem
            // 
            this.trabajoToolStripMenuItem.Name = "trabajoToolStripMenuItem";
            this.trabajoToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.trabajoToolStripMenuItem.Text = "trabajo";
            // 
            // deportesToolStripMenuItem
            // 
            this.deportesToolStripMenuItem.Name = "deportesToolStripMenuItem";
            this.deportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.deportesToolStripMenuItem.Text = "deportes";
            // 
            // hobbiesToolStripMenuItem
            // 
            this.hobbiesToolStripMenuItem.Name = "hobbiesToolStripMenuItem";
            this.hobbiesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.hobbiesToolStripMenuItem.Text = "hobbies";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormPrincipal";
            this.Text = "FormVentana2";
            this.Load += new System.EventHandler(this.FormVentana2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MsPerfil;
        private System.Windows.Forms.ToolStripMenuItem trabajoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hobbiesToolStripMenuItem;
    }
}
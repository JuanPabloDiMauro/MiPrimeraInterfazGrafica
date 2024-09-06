namespace PrimeraInterfezGrrafica
{
    partial class Form3deportes
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
            this.dgvPartNegocio = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartNegocio)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPartNegocio
            // 
            this.dgvPartNegocio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPartNegocio.Location = new System.Drawing.Point(105, 28);
            this.dgvPartNegocio.Name = "dgvPartNegocio";
            this.dgvPartNegocio.Size = new System.Drawing.Size(589, 150);
            this.dgvPartNegocio.TabIndex = 0;
            this.dgvPartNegocio.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Form3deportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvPartNegocio);
            this.Name = "Form3deportes";
            this.Text = "Form3deportes";
            this.Load += new System.EventHandler(this.Form3deportes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartNegocio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPartNegocio;
    }
}
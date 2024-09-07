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
            this.PbParticipantes = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartNegocio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbParticipantes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPartNegocio
            // 
            this.dgvPartNegocio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPartNegocio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPartNegocio.Location = new System.Drawing.Point(24, 30);
            this.dgvPartNegocio.Name = "dgvPartNegocio";
            this.dgvPartNegocio.Size = new System.Drawing.Size(702, 150);
            this.dgvPartNegocio.TabIndex = 0;
            this.dgvPartNegocio.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgvPartNegocio.SelectionChanged += new System.EventHandler(this.dgvPartNegocio_SelectionChanged);
            // 
            // PbParticipantes
            // 
            this.PbParticipantes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PbParticipantes.Location = new System.Drawing.Point(753, 30);
            this.PbParticipantes.Name = "PbParticipantes";
            this.PbParticipantes.Size = new System.Drawing.Size(265, 150);
            this.PbParticipantes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbParticipantes.TabIndex = 1;
            this.PbParticipantes.TabStop = false;
            this.PbParticipantes.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form3deportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 450);
            this.Controls.Add(this.PbParticipantes);
            this.Controls.Add(this.dgvPartNegocio);
            this.Name = "Form3deportes";
            this.Text = "Form3deportes";
            this.Load += new System.EventHandler(this.Form3deportes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartNegocio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbParticipantes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPartNegocio;
        private System.Windows.Forms.PictureBox PbParticipantes;
    }
}
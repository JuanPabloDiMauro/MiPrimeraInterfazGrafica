namespace PrimeraInterfezGrrafica
{
    partial class Ventana3
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
            this.lblTrabajoNombre = new System.Windows.Forms.Label();
            this.txtbxTrabajo = new System.Windows.Forms.TextBox();
            this.lblFechaIngreso = new System.Windows.Forms.Label();
            this.dtFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.numAntig = new System.Windows.Forms.NumericUpDown();
            this.lblAñosTrabajo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbxLugarTrabajo = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lstvwMuestraDatos = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.numAntig)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTrabajoNombre
            // 
            this.lblTrabajoNombre.AutoSize = true;
            this.lblTrabajoNombre.Location = new System.Drawing.Point(43, 82);
            this.lblTrabajoNombre.Name = "lblTrabajoNombre";
            this.lblTrabajoNombre.Size = new System.Drawing.Size(49, 13);
            this.lblTrabajoNombre.TabIndex = 0;
            this.lblTrabajoNombre.Text = "Trabajo: ";
            this.lblTrabajoNombre.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtbxTrabajo
            // 
            this.txtbxTrabajo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbxTrabajo.Location = new System.Drawing.Point(141, 79);
            this.txtbxTrabajo.Name = "txtbxTrabajo";
            this.txtbxTrabajo.Size = new System.Drawing.Size(236, 20);
            this.txtbxTrabajo.TabIndex = 1;
            // 
            // lblFechaIngreso
            // 
            this.lblFechaIngreso.AutoSize = true;
            this.lblFechaIngreso.Location = new System.Drawing.Point(43, 122);
            this.lblFechaIngreso.Name = "lblFechaIngreso";
            this.lblFechaIngreso.Size = new System.Drawing.Size(92, 13);
            this.lblFechaIngreso.TabIndex = 2;
            this.lblFechaIngreso.Text = "Fecha de ingreso:";
            // 
            // dtFechaIngreso
            // 
            this.dtFechaIngreso.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtFechaIngreso.Location = new System.Drawing.Point(141, 116);
            this.dtFechaIngreso.Name = "dtFechaIngreso";
            this.dtFechaIngreso.Size = new System.Drawing.Size(236, 20);
            this.dtFechaIngreso.TabIndex = 3;
            // 
            // numAntig
            // 
            this.numAntig.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numAntig.Location = new System.Drawing.Point(141, 156);
            this.numAntig.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.numAntig.Name = "numAntig";
            this.numAntig.Size = new System.Drawing.Size(236, 20);
            this.numAntig.TabIndex = 4;
            // 
            // lblAñosTrabajo
            // 
            this.lblAñosTrabajo.AutoSize = true;
            this.lblAñosTrabajo.Location = new System.Drawing.Point(43, 163);
            this.lblAñosTrabajo.Name = "lblAñosTrabajo";
            this.lblAñosTrabajo.Size = new System.Drawing.Size(87, 13);
            this.lblAñosTrabajo.TabIndex = 5;
            this.lblAñosTrabajo.Text = "Años trabajando:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(308, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 31);
            this.label3.TabIndex = 6;
            this.label3.Text = "TRABAJO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "lugar de trabajo:";
            // 
            // txtbxLugarTrabajo
            // 
            this.txtbxLugarTrabajo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbxLugarTrabajo.Location = new System.Drawing.Point(141, 193);
            this.txtbxLugarTrabajo.Name = "txtbxLugarTrabajo";
            this.txtbxLugarTrabajo.Size = new System.Drawing.Size(236, 20);
            this.txtbxLugarTrabajo.TabIndex = 8;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(46, 236);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(119, 23);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.Text = "Agregar Trabajo";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lstvwMuestraDatos
            // 
            this.lstvwMuestraDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lstvwMuestraDatos.CausesValidation = false;
            this.lstvwMuestraDatos.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lstvwMuestraDatos.HideSelection = false;
            this.lstvwMuestraDatos.Location = new System.Drawing.Point(434, 79);
            this.lstvwMuestraDatos.Name = "lstvwMuestraDatos";
            this.lstvwMuestraDatos.Size = new System.Drawing.Size(314, 134);
            this.lstvwMuestraDatos.TabIndex = 11;
            this.lstvwMuestraDatos.UseCompatibleStateImageBehavior = false;
            this.lstvwMuestraDatos.View = System.Windows.Forms.View.List;
            this.lstvwMuestraDatos.SelectedIndexChanged += new System.EventHandler(this.lstvwMuestraDatos_SelectedIndexChanged);
            // 
            // Ventana3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(820, 482);
            this.Controls.Add(this.lstvwMuestraDatos);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtbxLugarTrabajo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblAñosTrabajo);
            this.Controls.Add(this.numAntig);
            this.Controls.Add(this.dtFechaIngreso);
            this.Controls.Add(this.lblFechaIngreso);
            this.Controls.Add(this.txtbxTrabajo);
            this.Controls.Add(this.lblTrabajoNombre);
            this.MaximumSize = new System.Drawing.Size(1467, 521);
            this.MinimumSize = new System.Drawing.Size(836, 413);
            this.Name = "Ventana3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventana3";
            ((System.ComponentModel.ISupportInitialize)(this.numAntig)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTrabajoNombre;
        private System.Windows.Forms.TextBox txtbxTrabajo;
        private System.Windows.Forms.Label lblFechaIngreso;
        private System.Windows.Forms.DateTimePicker dtFechaIngreso;
        private System.Windows.Forms.NumericUpDown numAntig;
        private System.Windows.Forms.Label lblAñosTrabajo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbxLugarTrabajo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ListView lstvwMuestraDatos;
    }
}
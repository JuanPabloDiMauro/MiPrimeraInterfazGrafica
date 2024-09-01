namespace PrimeraInterfezGrrafica
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.MostrarDatosUser = new System.Windows.Forms.Button();
            this.lblIngrNom = new System.Windows.Forms.Label();
            this.TextBoxNameUser = new System.Windows.Forms.TextBox();
            this.LblMostrarDatosUser = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.rbtEstadoCivil1 = new System.Windows.Forms.RadioButton();
            this.rbtEstadoCivil2 = new System.Windows.Forms.RadioButton();
            this.rbtEstadoCivil3 = new System.Windows.Forms.RadioButton();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.CheckBoxMascota1 = new System.Windows.Forms.CheckBox();
            this.CheckBoxMascota2 = new System.Windows.Forms.CheckBox();
            this.checkBoxMascota3 = new System.Windows.Forms.CheckBox();
            this.groupBoxEstadoCivil = new System.Windows.Forms.GroupBox();
            this.PicBox = new System.Windows.Forms.PictureBox();
            this.dateTimeFechaNac = new System.Windows.Forms.DateTimePicker();
            this.lblFechaNac = new System.Windows.Forms.Label();
            this.lblMascotas = new System.Windows.Forms.Label();
            this.numericUpDownCantMascotas = new System.Windows.Forms.NumericUpDown();
            this.lblCantMascotas = new System.Windows.Forms.Label();
            this.lblTituloSeccion = new System.Windows.Forms.Label();
            this.groupBoxEstadoCivil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCantMascotas)).BeginInit();
            this.SuspendLayout();
            // 
            // MostrarDatosUser
            // 
            this.MostrarDatosUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MostrarDatosUser.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.MostrarDatosUser.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.MostrarDatosUser.ForeColor = System.Drawing.Color.Black;
            this.MostrarDatosUser.Location = new System.Drawing.Point(430, 239);
            this.MostrarDatosUser.Name = "MostrarDatosUser";
            this.MostrarDatosUser.Size = new System.Drawing.Size(290, 90);
            this.MostrarDatosUser.TabIndex = 7;
            this.MostrarDatosUser.Text = "mostrar datos del usuario";
            this.MostrarDatosUser.UseVisualStyleBackColor = false;
            this.MostrarDatosUser.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblIngrNom
            // 
            this.lblIngrNom.AutoSize = true;
            this.lblIngrNom.Location = new System.Drawing.Point(30, 93);
            this.lblIngrNom.Name = "lblIngrNom";
            this.lblIngrNom.Size = new System.Drawing.Size(85, 13);
            this.lblIngrNom.TabIndex = 1;
            this.lblIngrNom.Text = "ingresar nombre:";
            // 
            // TextBoxNameUser
            // 
            this.TextBoxNameUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxNameUser.Location = new System.Drawing.Point(182, 90);
            this.TextBoxNameUser.Name = "TextBoxNameUser";
            this.TextBoxNameUser.Size = new System.Drawing.Size(191, 20);
            this.TextBoxNameUser.TabIndex = 0;
            this.TextBoxNameUser.TextChanged += new System.EventHandler(this.TextBoxNameUser_TextChanged);
            // 
            // LblMostrarDatosUser
            // 
            this.LblMostrarDatosUser.AutoSize = true;
            this.LblMostrarDatosUser.Location = new System.Drawing.Point(455, 316);
            this.LblMostrarDatosUser.Name = "LblMostrarDatosUser";
            this.LblMostrarDatosUser.Size = new System.Drawing.Size(0, 13);
            this.LblMostrarDatosUser.TabIndex = 5;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // rbtEstadoCivil1
            // 
            this.rbtEstadoCivil1.AutoSize = true;
            this.rbtEstadoCivil1.Checked = true;
            this.rbtEstadoCivil1.Location = new System.Drawing.Point(0, 34);
            this.rbtEstadoCivil1.Name = "rbtEstadoCivil1";
            this.rbtEstadoCivil1.Size = new System.Drawing.Size(56, 17);
            this.rbtEstadoCivil1.TabIndex = 7;
            this.rbtEstadoCivil1.TabStop = true;
            this.rbtEstadoCivil1.Text = "soltero";
            this.rbtEstadoCivil1.UseVisualStyleBackColor = true;
            // 
            // rbtEstadoCivil2
            // 
            this.rbtEstadoCivil2.AutoSize = true;
            this.rbtEstadoCivil2.Location = new System.Drawing.Point(104, 34);
            this.rbtEstadoCivil2.Name = "rbtEstadoCivil2";
            this.rbtEstadoCivil2.Size = new System.Drawing.Size(60, 17);
            this.rbtEstadoCivil2.TabIndex = 8;
            this.rbtEstadoCivil2.Text = "casado";
            this.rbtEstadoCivil2.UseVisualStyleBackColor = true;
            // 
            // rbtEstadoCivil3
            // 
            this.rbtEstadoCivil3.AutoSize = true;
            this.rbtEstadoCivil3.Location = new System.Drawing.Point(204, 34);
            this.rbtEstadoCivil3.Name = "rbtEstadoCivil3";
            this.rbtEstadoCivil3.Size = new System.Drawing.Size(74, 17);
            this.rbtEstadoCivil3.TabIndex = 9;
            this.rbtEstadoCivil3.Text = "divorciado";
            this.rbtEstadoCivil3.UseVisualStyleBackColor = true;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // CheckBoxMascota1
            // 
            this.CheckBoxMascota1.AccessibleName = "";
            this.CheckBoxMascota1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CheckBoxMascota1.AutoSize = true;
            this.CheckBoxMascota1.BackColor = System.Drawing.SystemColors.Control;
            this.CheckBoxMascota1.Location = new System.Drawing.Point(39, 189);
            this.CheckBoxMascota1.Name = "CheckBoxMascota1";
            this.CheckBoxMascota1.Size = new System.Drawing.Size(50, 17);
            this.CheckBoxMascota1.TabIndex = 2;
            this.CheckBoxMascota1.Text = "perro";
            this.CheckBoxMascota1.UseVisualStyleBackColor = false;
            this.CheckBoxMascota1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            this.CheckBoxMascota1.TextChanged += new System.EventHandler(this.mascotas);
            // 
            // CheckBoxMascota2
            // 
            this.CheckBoxMascota2.AccessibleName = "";
            this.CheckBoxMascota2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CheckBoxMascota2.AutoSize = true;
            this.CheckBoxMascota2.BackColor = System.Drawing.SystemColors.Control;
            this.CheckBoxMascota2.Location = new System.Drawing.Point(118, 189);
            this.CheckBoxMascota2.Name = "CheckBoxMascota2";
            this.CheckBoxMascota2.Size = new System.Drawing.Size(47, 17);
            this.CheckBoxMascota2.TabIndex = 3;
            this.CheckBoxMascota2.Text = "gato";
            this.CheckBoxMascota2.UseVisualStyleBackColor = false;
            this.CheckBoxMascota2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            this.CheckBoxMascota2.TextChanged += new System.EventHandler(this.mascotas);
            // 
            // checkBoxMascota3
            // 
            this.checkBoxMascota3.AccessibleName = "";
            this.checkBoxMascota3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.checkBoxMascota3.AutoSize = true;
            this.checkBoxMascota3.BackColor = System.Drawing.SystemColors.Control;
            this.checkBoxMascota3.Location = new System.Drawing.Point(182, 189);
            this.checkBoxMascota3.Name = "checkBoxMascota3";
            this.checkBoxMascota3.Size = new System.Drawing.Size(55, 17);
            this.checkBoxMascota3.TabIndex = 4;
            this.checkBoxMascota3.Text = "pajaro";
            this.checkBoxMascota3.UseVisualStyleBackColor = false;
            this.checkBoxMascota3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            this.checkBoxMascota3.TextChanged += new System.EventHandler(this.mascotas);
            // 
            // groupBoxEstadoCivil
            // 
            this.groupBoxEstadoCivil.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBoxEstadoCivil.Controls.Add(this.rbtEstadoCivil1);
            this.groupBoxEstadoCivil.Controls.Add(this.rbtEstadoCivil2);
            this.groupBoxEstadoCivil.Controls.Add(this.rbtEstadoCivil3);
            this.groupBoxEstadoCivil.Location = new System.Drawing.Point(33, 258);
            this.groupBoxEstadoCivil.Name = "groupBoxEstadoCivil";
            this.groupBoxEstadoCivil.Size = new System.Drawing.Size(298, 75);
            this.groupBoxEstadoCivil.TabIndex = 6;
            this.groupBoxEstadoCivil.TabStop = false;
            this.groupBoxEstadoCivil.Text = "Estado Civil";
            // 
            // PicBox
            // 
            this.PicBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PicBox.Image = global::PrimeraInterfezGrrafica.Properties.Resources.pain;
            this.PicBox.Location = new System.Drawing.Point(430, 44);
            this.PicBox.Name = "PicBox";
            this.PicBox.Size = new System.Drawing.Size(290, 183);
            this.PicBox.TabIndex = 17;
            this.PicBox.TabStop = false;
            // 
            // dateTimeFechaNac
            // 
            this.dateTimeFechaNac.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimeFechaNac.Location = new System.Drawing.Point(182, 121);
            this.dateTimeFechaNac.Name = "dateTimeFechaNac";
            this.dateTimeFechaNac.Size = new System.Drawing.Size(191, 20);
            this.dateTimeFechaNac.TabIndex = 1;
            this.dateTimeFechaNac.Value = new System.DateTime(2024, 8, 31, 0, 0, 0, 0);
            // 
            // lblFechaNac
            // 
            this.lblFechaNac.AutoSize = true;
            this.lblFechaNac.Location = new System.Drawing.Point(30, 121);
            this.lblFechaNac.Name = "lblFechaNac";
            this.lblFechaNac.Size = new System.Drawing.Size(146, 13);
            this.lblFechaNac.TabIndex = 3;
            this.lblFechaNac.Text = "ingresar fecha de nacimiento:";
            this.lblFechaNac.Click += new System.EventHandler(this.lblIngrTrabajo_Click);
            // 
            // lblMascotas
            // 
            this.lblMascotas.AutoSize = true;
            this.lblMascotas.Location = new System.Drawing.Point(36, 160);
            this.lblMascotas.Name = "lblMascotas";
            this.lblMascotas.Size = new System.Drawing.Size(105, 13);
            this.lblMascotas.TabIndex = 20;
            this.lblMascotas.Text = "Que mascota tenes?";
            // 
            // numericUpDownCantMascotas
            // 
            this.numericUpDownCantMascotas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownCantMascotas.Location = new System.Drawing.Point(152, 212);
            this.numericUpDownCantMascotas.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericUpDownCantMascotas.Name = "numericUpDownCantMascotas";
            this.numericUpDownCantMascotas.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownCantMascotas.TabIndex = 5;
            // 
            // lblCantMascotas
            // 
            this.lblCantMascotas.AutoSize = true;
            this.lblCantMascotas.Location = new System.Drawing.Point(30, 214);
            this.lblCantMascotas.Name = "lblCantMascotas";
            this.lblCantMascotas.Size = new System.Drawing.Size(116, 13);
            this.lblCantMascotas.TabIndex = 22;
            this.lblCantMascotas.Text = "Cantidad de Mascotas:";
            // 
            // lblTituloSeccion
            // 
            this.lblTituloSeccion.AutoSize = true;
            this.lblTituloSeccion.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloSeccion.Location = new System.Drawing.Point(78, 29);
            this.lblTituloSeccion.Name = "lblTituloSeccion";
            this.lblTituloSeccion.Size = new System.Drawing.Size(233, 34);
            this.lblTituloSeccion.TabIndex = 23;
            this.lblTituloSeccion.Text = "PERFIL DE USUARIO";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 450);
            this.Controls.Add(this.lblTituloSeccion);
            this.Controls.Add(this.lblCantMascotas);
            this.Controls.Add(this.numericUpDownCantMascotas);
            this.Controls.Add(this.lblMascotas);
            this.Controls.Add(this.dateTimeFechaNac);
            this.Controls.Add(this.PicBox);
            this.Controls.Add(this.groupBoxEstadoCivil);
            this.Controls.Add(this.checkBoxMascota3);
            this.Controls.Add(this.CheckBoxMascota2);
            this.Controls.Add(this.CheckBoxMascota1);
            this.Controls.Add(this.LblMostrarDatosUser);
            this.Controls.Add(this.lblFechaNac);
            this.Controls.Add(this.TextBoxNameUser);
            this.Controls.Add(this.lblIngrNom);
            this.Controls.Add(this.MostrarDatosUser);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MI PRIMERA APP";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxEstadoCivil.ResumeLayout(false);
            this.groupBoxEstadoCivil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCantMascotas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button MostrarDatosUser;
        private System.Windows.Forms.Label lblIngrNom;
        private System.Windows.Forms.TextBox TextBoxNameUser;
        private System.Windows.Forms.Label LblMostrarDatosUser;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.RadioButton rbtEstadoCivil1;
        private System.Windows.Forms.RadioButton rbtEstadoCivil2;
        private System.Windows.Forms.RadioButton rbtEstadoCivil3;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.CheckBox CheckBoxMascota1;
        private System.Windows.Forms.CheckBox CheckBoxMascota2;
        private System.Windows.Forms.CheckBox checkBoxMascota3;
        private System.Windows.Forms.GroupBox groupBoxEstadoCivil;
        private System.Windows.Forms.PictureBox PicBox;
        private System.Windows.Forms.DateTimePicker dateTimeFechaNac;
        private System.Windows.Forms.Label lblFechaNac;
        private System.Windows.Forms.Label lblMascotas;
        private System.Windows.Forms.NumericUpDown numericUpDownCantMascotas;
        private System.Windows.Forms.Label lblCantMascotas;
        private System.Windows.Forms.Label lblTituloSeccion;
    }
}


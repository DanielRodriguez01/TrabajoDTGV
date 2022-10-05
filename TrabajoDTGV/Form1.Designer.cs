namespace TrabajoDTGV
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
            this.dgvdatos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtgmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtagregar = new System.Windows.Forms.Button();
            this.dgvprofesor = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btngregar2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_nombreprofesor = new System.Windows.Forms.TextBox();
            this.txtMateria = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvprofesor)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvdatos
            // 
            this.dgvdatos.BackgroundColor = System.Drawing.SystemColors.InfoText;
            this.dgvdatos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvdatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvdatos.Location = new System.Drawing.Point(14, 12);
            this.dgvdatos.Name = "dgvdatos";
            this.dgvdatos.Size = new System.Drawing.Size(241, 270);
            this.dgvdatos.TabIndex = 0;
            this.dgvdatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nombre";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Gmail";
            this.Column2.Name = "Column2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(261, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre:";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(314, 67);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(151, 20);
            this.txtnombre.TabIndex = 2;
            // 
            // txtgmail
            // 
            this.txtgmail.Location = new System.Drawing.Point(314, 93);
            this.txtgmail.Name = "txtgmail";
            this.txtgmail.Size = new System.Drawing.Size(151, 20);
            this.txtgmail.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(272, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Gmail:";
            // 
            // txtagregar
            // 
            this.txtagregar.Location = new System.Drawing.Point(346, 142);
            this.txtagregar.Name = "txtagregar";
            this.txtagregar.Size = new System.Drawing.Size(75, 23);
            this.txtagregar.TabIndex = 5;
            this.txtagregar.Text = "Agregar";
            this.txtagregar.UseVisualStyleBackColor = true;
            this.txtagregar.Click += new System.EventHandler(this.txtagregar_Click);
            // 
            // dgvprofesor
            // 
            this.dgvprofesor.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvprofesor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvprofesor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvprofesor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column4});
            this.dgvprofesor.Location = new System.Drawing.Point(586, 12);
            this.dgvprofesor.Name = "dgvprofesor";
            this.dgvprofesor.Size = new System.Drawing.Size(240, 184);
            this.dgvprofesor.TabIndex = 6;
            this.dgvprofesor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvprofesor_CellContentClick);
            // 
            // Column3
            // 
            this.Column3.HeaderText = "NombreProfesor";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Materia";
            this.Column4.Name = "Column4";
            // 
            // btngregar2
            // 
            this.btngregar2.Location = new System.Drawing.Point(644, 328);
            this.btngregar2.Name = "btngregar2";
            this.btngregar2.Size = new System.Drawing.Size(75, 23);
            this.btngregar2.TabIndex = 7;
            this.btngregar2.Text = "Agregar";
            this.btngregar2.UseVisualStyleBackColor = true;
            this.btngregar2.Click += new System.EventHandler(this.txtagregar2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(594, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nombre del profesor :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(596, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Materia del profesor: ";
            // 
            // txt_nombreprofesor
            // 
            this.txt_nombreprofesor.Location = new System.Drawing.Point(708, 220);
            this.txt_nombreprofesor.Name = "txt_nombreprofesor";
            this.txt_nombreprofesor.Size = new System.Drawing.Size(118, 20);
            this.txt_nombreprofesor.TabIndex = 10;
            // 
            // txtMateria
            // 
            this.txtMateria.Location = new System.Drawing.Point(708, 259);
            this.txtMateria.Name = "txtMateria";
            this.txtMateria.Size = new System.Drawing.Size(118, 20);
            this.txtMateria.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(893, 450);
            this.Controls.Add(this.txtMateria);
            this.Controls.Add(this.txt_nombreprofesor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btngregar2);
            this.Controls.Add(this.dgvprofesor);
            this.Controls.Add(this.txtagregar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtgmail);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvdatos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvdatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvprofesor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvdatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtgmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button txtagregar;
        private System.Windows.Forms.DataGridView dgvprofesor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button btngregar2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_nombreprofesor;
        private System.Windows.Forms.TextBox txtMateria;
    }
}


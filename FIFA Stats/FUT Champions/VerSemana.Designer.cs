namespace FIFA_Stats.FUT_Champions
{
    partial class VerSemana
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_partidos = new System.Windows.Forms.DataGridView();
            this.btn_agregarPartido = new System.Windows.Forms.Button();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rival = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Resultado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Goles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Localia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_DatosFilas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_partidos)).BeginInit();
            this.panelContenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_partidos
            // 
            this.dgv_partidos.AllowUserToAddRows = false;
            this.dgv_partidos.AllowUserToDeleteRows = false;
            this.dgv_partidos.AllowUserToResizeColumns = false;
            this.dgv_partidos.AllowUserToResizeRows = false;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.dgv_partidos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle19;
            this.dgv_partidos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_partidos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_partidos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_partidos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_partidos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(76)))), ((int)(((byte)(122)))));
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(76)))), ((int)(((byte)(122)))));
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_partidos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.dgv_partidos.ColumnHeadersHeight = 35;
            this.dgv_partidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_partidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Numero,
            this.Rival,
            this.Resultado,
            this.Goles,
            this.Localia});
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(168)))), ((int)(((byte)(209)))));
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_partidos.DefaultCellStyle = dataGridViewCellStyle21;
            this.dgv_partidos.Location = new System.Drawing.Point(12, 41);
            this.dgv_partidos.Name = "dgv_partidos";
            this.dgv_partidos.ReadOnly = true;
            this.dgv_partidos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_partidos.RowHeadersVisible = false;
            this.dgv_partidos.RowTemplate.Height = 35;
            this.dgv_partidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_partidos.Size = new System.Drawing.Size(1220, 490);
            this.dgv_partidos.TabIndex = 1;
            // 
            // btn_agregarPartido
            // 
            this.btn_agregarPartido.Location = new System.Drawing.Point(12, 12);
            this.btn_agregarPartido.Name = "btn_agregarPartido";
            this.btn_agregarPartido.Size = new System.Drawing.Size(133, 23);
            this.btn_agregarPartido.TabIndex = 0;
            this.btn_agregarPartido.Text = "Agregar Partido";
            this.btn_agregarPartido.UseVisualStyleBackColor = true;
            this.btn_agregarPartido.Click += new System.EventHandler(this.btn_agregarPartido_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.Controls.Add(this.lbl_DatosFilas);
            this.panelContenedor.Controls.Add(this.btn_salir);
            this.panelContenedor.Controls.Add(this.btn_guardar);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1244, 569);
            this.panelContenedor.TabIndex = 2;
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(290, 12);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(133, 23);
            this.btn_salir.TabIndex = 1;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(151, 12);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(133, 23);
            this.btn_guardar.TabIndex = 0;
            this.btn_guardar.Text = "Guardar cambios";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // Numero
            // 
            this.Numero.HeaderText = "Partido";
            this.Numero.Name = "Numero";
            this.Numero.ReadOnly = true;
            this.Numero.Width = 60;
            // 
            // Rival
            // 
            this.Rival.HeaderText = "Rival";
            this.Rival.Name = "Rival";
            this.Rival.ReadOnly = true;
            this.Rival.Width = 200;
            // 
            // Resultado
            // 
            this.Resultado.HeaderText = "Resultado";
            this.Resultado.Name = "Resultado";
            this.Resultado.ReadOnly = true;
            // 
            // Goles
            // 
            this.Goles.HeaderText = "Goles";
            this.Goles.Name = "Goles";
            this.Goles.ReadOnly = true;
            // 
            // Localia
            // 
            this.Localia.HeaderText = "Condición";
            this.Localia.Name = "Localia";
            this.Localia.ReadOnly = true;
            // 
            // lbl_DatosFilas
            // 
            this.lbl_DatosFilas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_DatosFilas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(76)))), ((int)(((byte)(122)))));
            this.lbl_DatosFilas.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DatosFilas.ForeColor = System.Drawing.Color.White;
            this.lbl_DatosFilas.Location = new System.Drawing.Point(12, 532);
            this.lbl_DatosFilas.Name = "lbl_DatosFilas";
            this.lbl_DatosFilas.Size = new System.Drawing.Size(560, 24);
            this.lbl_DatosFilas.TabIndex = 2;
            this.lbl_DatosFilas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // VerSemana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 569);
            this.Controls.Add(this.dgv_partidos);
            this.Controls.Add(this.btn_agregarPartido);
            this.Controls.Add(this.panelContenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VerSemana";
            this.Text = "Editar Semana";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_partidos)).EndInit();
            this.panelContenedor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_partidos;
        private System.Windows.Forms.Button btn_agregarPartido;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rival;
        private System.Windows.Forms.DataGridViewTextBoxColumn Resultado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Goles;
        private System.Windows.Forms.DataGridViewTextBoxColumn Localia;
        private System.Windows.Forms.Label lbl_DatosFilas;
    }
}
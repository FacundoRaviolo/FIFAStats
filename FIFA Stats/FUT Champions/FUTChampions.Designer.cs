namespace FIFA_Stats.FUT_Champions
{
    partial class FUTChampions
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FUTChampions));
            this.dgv_semanas = new System.Windows.Forms.DataGridView();
            this.SemanaNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IconoRango = new System.Windows.Forms.DataGridViewImageColumn();
            this.Rango = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Victorias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Derrotas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartidosJugados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ver = new System.Windows.Forms.DataGridViewImageColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.btn_agregarsemana = new System.Windows.Forms.Button();
            this.panelContenedor1 = new System.Windows.Forms.Panel();
            this.lbl_DatosFilas = new System.Windows.Forms.Label();
            this.btn_Actualizar = new System.Windows.Forms.Button();
            this.panelContenedor2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_semanas)).BeginInit();
            this.panelContenedor1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_semanas
            // 
            this.dgv_semanas.AllowUserToAddRows = false;
            this.dgv_semanas.AllowUserToDeleteRows = false;
            this.dgv_semanas.AllowUserToResizeColumns = false;
            this.dgv_semanas.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.dgv_semanas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_semanas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgv_semanas.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_semanas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_semanas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_semanas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(76)))), ((int)(((byte)(122)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(76)))), ((int)(((byte)(122)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_semanas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_semanas.ColumnHeadersHeight = 35;
            this.dgv_semanas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_semanas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SemanaNumero,
            this.Fecha,
            this.IconoRango,
            this.Rango,
            this.Victorias,
            this.Derrotas,
            this.PartidosJugados,
            this.Ver,
            this.Eliminar});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Trebuchet MS", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(168)))), ((int)(((byte)(209)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_semanas.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_semanas.Location = new System.Drawing.Point(12, 41);
            this.dgv_semanas.Name = "dgv_semanas";
            this.dgv_semanas.ReadOnly = true;
            this.dgv_semanas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_semanas.RowHeadersVisible = false;
            this.dgv_semanas.RowTemplate.Height = 35;
            this.dgv_semanas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_semanas.Size = new System.Drawing.Size(562, 490);
            this.dgv_semanas.TabIndex = 1;
            this.dgv_semanas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_semanas_CellContentClick);
            this.dgv_semanas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_semanas_CellDoubleClick);
            this.dgv_semanas.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_semanas_CellFormatting);
            this.dgv_semanas.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgv_semanas_CellPainting);
            // 
            // SemanaNumero
            // 
            this.SemanaNumero.HeaderText = "Semana";
            this.SemanaNumero.Name = "SemanaNumero";
            this.SemanaNumero.ReadOnly = true;
            this.SemanaNumero.Width = 60;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // IconoRango
            // 
            this.IconoRango.HeaderText = "";
            this.IconoRango.Name = "IconoRango";
            this.IconoRango.ReadOnly = true;
            this.IconoRango.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.IconoRango.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.IconoRango.Width = 35;
            // 
            // Rango
            // 
            this.Rango.HeaderText = "Rango";
            this.Rango.Name = "Rango";
            this.Rango.ReadOnly = true;
            // 
            // Victorias
            // 
            this.Victorias.HeaderText = "Victorias";
            this.Victorias.Name = "Victorias";
            this.Victorias.ReadOnly = true;
            this.Victorias.Width = 60;
            // 
            // Derrotas
            // 
            this.Derrotas.HeaderText = "Derrotas";
            this.Derrotas.Name = "Derrotas";
            this.Derrotas.ReadOnly = true;
            this.Derrotas.Width = 60;
            // 
            // PartidosJugados
            // 
            this.PartidosJugados.HeaderText = "Jugados";
            this.PartidosJugados.Name = "PartidosJugados";
            this.PartidosJugados.ReadOnly = true;
            this.PartidosJugados.Width = 60;
            // 
            // Ver
            // 
            this.Ver.HeaderText = "";
            this.Ver.Name = "Ver";
            this.Ver.ReadOnly = true;
            this.Ver.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Ver.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Ver.Width = 35;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Eliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Eliminar.Width = 35;
            // 
            // btn_agregarsemana
            // 
            this.btn_agregarsemana.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(76)))), ((int)(((byte)(122)))));
            this.btn_agregarsemana.FlatAppearance.BorderSize = 0;
            this.btn_agregarsemana.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregarsemana.ForeColor = System.Drawing.Color.White;
            this.btn_agregarsemana.Location = new System.Drawing.Point(12, 12);
            this.btn_agregarsemana.Name = "btn_agregarsemana";
            this.btn_agregarsemana.Size = new System.Drawing.Size(133, 23);
            this.btn_agregarsemana.TabIndex = 0;
            this.btn_agregarsemana.Text = "Agregar Semana";
            this.btn_agregarsemana.UseVisualStyleBackColor = false;
            this.btn_agregarsemana.Click += new System.EventHandler(this.btn_agregarsemana_Click);
            // 
            // panelContenedor1
            // 
            this.panelContenedor1.Controls.Add(this.lbl_DatosFilas);
            this.panelContenedor1.Controls.Add(this.btn_Actualizar);
            this.panelContenedor1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelContenedor1.Location = new System.Drawing.Point(0, 0);
            this.panelContenedor1.Name = "panelContenedor1";
            this.panelContenedor1.Size = new System.Drawing.Size(596, 569);
            this.panelContenedor1.TabIndex = 2;
            // 
            // lbl_DatosFilas
            // 
            this.lbl_DatosFilas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_DatosFilas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(76)))), ((int)(((byte)(122)))));
            this.lbl_DatosFilas.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DatosFilas.ForeColor = System.Drawing.Color.White;
            this.lbl_DatosFilas.Location = new System.Drawing.Point(12, 532);
            this.lbl_DatosFilas.Name = "lbl_DatosFilas";
            this.lbl_DatosFilas.Size = new System.Drawing.Size(545, 24);
            this.lbl_DatosFilas.TabIndex = 0;
            this.lbl_DatosFilas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Actualizar
            // 
            this.btn_Actualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(76)))), ((int)(((byte)(122)))));
            this.btn_Actualizar.FlatAppearance.BorderSize = 0;
            this.btn_Actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Actualizar.ForeColor = System.Drawing.Color.White;
            this.btn_Actualizar.Location = new System.Drawing.Point(151, 12);
            this.btn_Actualizar.Name = "btn_Actualizar";
            this.btn_Actualizar.Size = new System.Drawing.Size(133, 23);
            this.btn_Actualizar.TabIndex = 0;
            this.btn_Actualizar.Text = "Actualizar";
            this.btn_Actualizar.UseVisualStyleBackColor = false;
            this.btn_Actualizar.EnabledChanged += new System.EventHandler(this.btn_Actualizar_EnabledChanged);
            this.btn_Actualizar.Click += new System.EventHandler(this.btn_Actualizar_Click);
            this.btn_Actualizar.Paint += new System.Windows.Forms.PaintEventHandler(this.btn_Actualizar_Paint);
            // 
            // panelContenedor2
            // 
            this.panelContenedor2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelContenedor2.BackgroundImage")));
            this.panelContenedor2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelContenedor2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor2.Location = new System.Drawing.Point(596, 0);
            this.panelContenedor2.Name = "panelContenedor2";
            this.panelContenedor2.Size = new System.Drawing.Size(648, 569);
            this.panelContenedor2.TabIndex = 3;
            // 
            // FUTChampions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 569);
            this.Controls.Add(this.panelContenedor2);
            this.Controls.Add(this.btn_agregarsemana);
            this.Controls.Add(this.dgv_semanas);
            this.Controls.Add(this.panelContenedor1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FUTChampions";
            this.Text = "FUT Champions";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_semanas)).EndInit();
            this.panelContenedor1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_semanas;
        private System.Windows.Forms.Button btn_agregarsemana;
        private System.Windows.Forms.Panel panelContenedor1;
        private System.Windows.Forms.Button btn_Actualizar;
        private System.Windows.Forms.Label lbl_DatosFilas;
        private System.Windows.Forms.Panel panelContenedor2;
        private System.Windows.Forms.DataGridViewTextBoxColumn SemanaNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewImageColumn IconoRango;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rango;
        private System.Windows.Forms.DataGridViewTextBoxColumn Victorias;
        private System.Windows.Forms.DataGridViewTextBoxColumn Derrotas;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartidosJugados;
        private System.Windows.Forms.DataGridViewImageColumn Ver;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
    }
}
namespace FIFA_Stats
{
    partial class MenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.btn_cerrar = new System.Windows.Forms.PictureBox();
            this.img_futChampions = new System.Windows.Forms.PictureBox();
            this.img_modoCarrera = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_futChampions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_modoCarrera)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(24, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(480, 151);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(168)))), ((int)(((byte)(209)))));
            this.BarraTitulo.Controls.Add(this.btn_cerrar);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(529, 35);
            this.BarraTitulo.TabIndex = 3;
            this.BarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseDown);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cerrar.Image = ((System.Drawing.Image)(resources.GetObject("btn_cerrar.Image")));
            this.btn_cerrar.Location = new System.Drawing.Point(498, 4);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(27, 27);
            this.btn_cerrar.TabIndex = 1;
            this.btn_cerrar.TabStop = false;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // img_futChampions
            // 
            this.img_futChampions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.img_futChampions.Image = ((System.Drawing.Image)(resources.GetObject("img_futChampions.Image")));
            this.img_futChampions.Location = new System.Drawing.Point(150, 179);
            this.img_futChampions.Name = "img_futChampions";
            this.img_futChampions.Size = new System.Drawing.Size(100, 100);
            this.img_futChampions.TabIndex = 4;
            this.img_futChampions.TabStop = false;
            this.img_futChampions.Click += new System.EventHandler(this.img_futChampions_Click);
            this.img_futChampions.MouseEnter += new System.EventHandler(this.img_futChampions_MouseEnter);
            this.img_futChampions.MouseLeave += new System.EventHandler(this.img_futChampions_MouseLeave);
            // 
            // img_modoCarrera
            // 
            this.img_modoCarrera.Cursor = System.Windows.Forms.Cursors.Hand;
            this.img_modoCarrera.Image = ((System.Drawing.Image)(resources.GetObject("img_modoCarrera.Image")));
            this.img_modoCarrera.Location = new System.Drawing.Point(279, 179);
            this.img_modoCarrera.Name = "img_modoCarrera";
            this.img_modoCarrera.Size = new System.Drawing.Size(100, 100);
            this.img_modoCarrera.TabIndex = 5;
            this.img_modoCarrera.TabStop = false;
            this.img_modoCarrera.MouseEnter += new System.EventHandler(this.img_modoCarrera_MouseEnter);
            this.img_modoCarrera.MouseLeave += new System.EventHandler(this.img_modoCarrera_MouseLeave);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(76)))), ((int)(((byte)(122)))));
            this.ClientSize = new System.Drawing.Size(529, 305);
            this.Controls.Add(this.img_modoCarrera);
            this.Controls.Add(this.img_futChampions);
            this.Controls.Add(this.BarraTitulo);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(529, 305);
            this.MinimumSize = new System.Drawing.Size(529, 305);
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FIFA Stats";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.BarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_futChampions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_modoCarrera)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.PictureBox btn_cerrar;
        private System.Windows.Forms.PictureBox img_futChampions;
        private System.Windows.Forms.PictureBox img_modoCarrera;
    }
}


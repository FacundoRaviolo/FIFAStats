namespace FIFA_Stats.FUT_Champions
{
    partial class AgregarPartido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarPartido));
            this.lbl_numero = new System.Windows.Forms.Label();
            this.txt_numero = new System.Windows.Forms.TextBox();
            this.txt_rival = new System.Windows.Forms.TextBox();
            this.lbl_rival = new System.Windows.Forms.Label();
            this.txt_golesFavor = new System.Windows.Forms.TextBox();
            this.txt_golesContra = new System.Windows.Forms.TextBox();
            this.txt_penalesFavor = new System.Windows.Forms.TextBox();
            this.txt_penalesContra = new System.Windows.Forms.TextBox();
            this.chk_localia = new System.Windows.Forms.CheckBox();
            this.lbl_golesFavor = new System.Windows.Forms.Label();
            this.lbl_golesContra = new System.Windows.Forms.Label();
            this.lbl_penalesFavor = new System.Windows.Forms.Label();
            this.lbl_penalesContra = new System.Windows.Forms.Label();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_numero
            // 
            this.lbl_numero.AutoSize = true;
            this.lbl_numero.Location = new System.Drawing.Point(12, 15);
            this.lbl_numero.Name = "lbl_numero";
            this.lbl_numero.Size = new System.Drawing.Size(44, 13);
            this.lbl_numero.TabIndex = 0;
            this.lbl_numero.Text = "Número";
            // 
            // txt_numero
            // 
            this.txt_numero.Location = new System.Drawing.Point(62, 12);
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Size = new System.Drawing.Size(99, 20);
            this.txt_numero.TabIndex = 1;
            // 
            // txt_rival
            // 
            this.txt_rival.Location = new System.Drawing.Point(62, 38);
            this.txt_rival.Name = "txt_rival";
            this.txt_rival.Size = new System.Drawing.Size(99, 20);
            this.txt_rival.TabIndex = 3;
            // 
            // lbl_rival
            // 
            this.lbl_rival.AutoSize = true;
            this.lbl_rival.Location = new System.Drawing.Point(25, 41);
            this.lbl_rival.Name = "lbl_rival";
            this.lbl_rival.Size = new System.Drawing.Size(31, 13);
            this.lbl_rival.TabIndex = 2;
            this.lbl_rival.Text = "Rival";
            // 
            // txt_golesFavor
            // 
            this.txt_golesFavor.Location = new System.Drawing.Point(275, 12);
            this.txt_golesFavor.Name = "txt_golesFavor";
            this.txt_golesFavor.Size = new System.Drawing.Size(99, 20);
            this.txt_golesFavor.TabIndex = 5;
            this.txt_golesFavor.TextChanged += new System.EventHandler(this.txt_golesFavor_TextChanged);
            // 
            // txt_golesContra
            // 
            this.txt_golesContra.Location = new System.Drawing.Point(275, 38);
            this.txt_golesContra.Name = "txt_golesContra";
            this.txt_golesContra.Size = new System.Drawing.Size(99, 20);
            this.txt_golesContra.TabIndex = 7;
            this.txt_golesContra.TextChanged += new System.EventHandler(this.txt_golesContra_TextChanged);
            // 
            // txt_penalesFavor
            // 
            this.txt_penalesFavor.Location = new System.Drawing.Point(275, 64);
            this.txt_penalesFavor.Name = "txt_penalesFavor";
            this.txt_penalesFavor.Size = new System.Drawing.Size(99, 20);
            this.txt_penalesFavor.TabIndex = 9;
            // 
            // txt_penalesContra
            // 
            this.txt_penalesContra.Location = new System.Drawing.Point(275, 90);
            this.txt_penalesContra.Name = "txt_penalesContra";
            this.txt_penalesContra.Size = new System.Drawing.Size(99, 20);
            this.txt_penalesContra.TabIndex = 11;
            // 
            // chk_localia
            // 
            this.chk_localia.AutoSize = true;
            this.chk_localia.Location = new System.Drawing.Point(62, 64);
            this.chk_localia.Name = "chk_localia";
            this.chk_localia.Size = new System.Drawing.Size(62, 17);
            this.chk_localia.TabIndex = 12;
            this.chk_localia.Text = "Localía";
            this.chk_localia.UseVisualStyleBackColor = true;
            // 
            // lbl_golesFavor
            // 
            this.lbl_golesFavor.AutoSize = true;
            this.lbl_golesFavor.Location = new System.Drawing.Point(196, 15);
            this.lbl_golesFavor.Name = "lbl_golesFavor";
            this.lbl_golesFavor.Size = new System.Drawing.Size(73, 13);
            this.lbl_golesFavor.TabIndex = 4;
            this.lbl_golesFavor.Text = "Goles a Favor";
            // 
            // lbl_golesContra
            // 
            this.lbl_golesContra.AutoSize = true;
            this.lbl_golesContra.Location = new System.Drawing.Point(186, 41);
            this.lbl_golesContra.Name = "lbl_golesContra";
            this.lbl_golesContra.Size = new System.Drawing.Size(83, 13);
            this.lbl_golesContra.TabIndex = 6;
            this.lbl_golesContra.Text = "Goles en Contra";
            // 
            // lbl_penalesFavor
            // 
            this.lbl_penalesFavor.AutoSize = true;
            this.lbl_penalesFavor.Location = new System.Drawing.Point(185, 67);
            this.lbl_penalesFavor.Name = "lbl_penalesFavor";
            this.lbl_penalesFavor.Size = new System.Drawing.Size(84, 13);
            this.lbl_penalesFavor.TabIndex = 8;
            this.lbl_penalesFavor.Text = "Penales a Favor";
            // 
            // lbl_penalesContra
            // 
            this.lbl_penalesContra.AutoSize = true;
            this.lbl_penalesContra.Location = new System.Drawing.Point(175, 93);
            this.lbl_penalesContra.Name = "lbl_penalesContra";
            this.lbl_penalesContra.Size = new System.Drawing.Size(94, 13);
            this.lbl_penalesContra.TabIndex = 10;
            this.lbl_penalesContra.Text = "Penales en Contra";
            // 
            // btn_agregar
            // 
            this.btn_agregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_agregar.Location = new System.Drawing.Point(299, 130);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(75, 23);
            this.btn_agregar.TabIndex = 13;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // AgregarPartido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 165);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.chk_localia);
            this.Controls.Add(this.lbl_penalesContra);
            this.Controls.Add(this.lbl_penalesFavor);
            this.Controls.Add(this.lbl_golesContra);
            this.Controls.Add(this.lbl_golesFavor);
            this.Controls.Add(this.lbl_rival);
            this.Controls.Add(this.lbl_numero);
            this.Controls.Add(this.txt_penalesContra);
            this.Controls.Add(this.txt_penalesFavor);
            this.Controls.Add(this.txt_golesContra);
            this.Controls.Add(this.txt_golesFavor);
            this.Controls.Add(this.txt_rival);
            this.Controls.Add(this.txt_numero);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AgregarPartido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Partido";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_numero;
        private System.Windows.Forms.TextBox txt_numero;
        private System.Windows.Forms.TextBox txt_rival;
        private System.Windows.Forms.Label lbl_rival;
        private System.Windows.Forms.TextBox txt_golesFavor;
        private System.Windows.Forms.TextBox txt_golesContra;
        private System.Windows.Forms.TextBox txt_penalesFavor;
        private System.Windows.Forms.TextBox txt_penalesContra;
        private System.Windows.Forms.CheckBox chk_localia;
        private System.Windows.Forms.Label lbl_golesFavor;
        private System.Windows.Forms.Label lbl_golesContra;
        private System.Windows.Forms.Label lbl_penalesFavor;
        private System.Windows.Forms.Label lbl_penalesContra;
        private System.Windows.Forms.Button btn_agregar;
    }
}
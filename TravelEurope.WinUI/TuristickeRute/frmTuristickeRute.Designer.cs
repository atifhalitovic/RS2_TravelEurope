namespace TravelEurope.WinUI.TuristickeRute
{
    partial class frmTuristickeRute
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
            this.btnDodajRutu = new System.Windows.Forms.Button();
            this.txtNazivRute = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvTuristRuta = new System.Windows.Forms.DataGridView();
            this.TuristRutaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kategorija = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TuristickiVodic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lokacija = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbSearchKategorija = new System.Windows.Forms.ComboBox();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTuristRuta)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDodajRutu
            // 
            this.btnDodajRutu.BackColor = System.Drawing.Color.LawnGreen;
            this.btnDodajRutu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajRutu.ForeColor = System.Drawing.Color.Black;
            this.btnDodajRutu.Location = new System.Drawing.Point(29, 72);
            this.btnDodajRutu.Name = "btnDodajRutu";
            this.btnDodajRutu.Size = new System.Drawing.Size(175, 23);
            this.btnDodajRutu.TabIndex = 14;
            this.btnDodajRutu.Text = "Dodaj novu turističku rutu";
            this.btnDodajRutu.UseVisualStyleBackColor = false;
            this.btnDodajRutu.Click += new System.EventHandler(this.btnDodajRutu_Click);
            // 
            // txtNazivRute
            // 
            this.txtNazivRute.Location = new System.Drawing.Point(87, 32);
            this.txtNazivRute.Name = "txtNazivRute";
            this.txtNazivRute.Size = new System.Drawing.Size(117, 22);
            this.txtNazivRute.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Menu;
            this.label1.Location = new System.Drawing.Point(26, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Naziv rute";
            // 
            // dgvTuristRuta
            // 
            this.dgvTuristRuta.AllowUserToAddRows = false;
            this.dgvTuristRuta.AllowUserToDeleteRows = false;
            this.dgvTuristRuta.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvTuristRuta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTuristRuta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TuristRutaId,
            this.Naziv,
            this.Kategorija,
            this.TuristickiVodic,
            this.Lokacija});
            this.dgvTuristRuta.Location = new System.Drawing.Point(12, 114);
            this.dgvTuristRuta.MultiSelect = false;
            this.dgvTuristRuta.Name = "dgvTuristRuta";
            this.dgvTuristRuta.ReadOnly = true;
            this.dgvTuristRuta.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.dgvTuristRuta.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvTuristRuta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTuristRuta.Size = new System.Drawing.Size(560, 235);
            this.dgvTuristRuta.TabIndex = 10;
            this.dgvTuristRuta.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTuristRuta_CellDoubleClick);
            // 
            // TuristRutaId
            // 
            this.TuristRutaId.DataPropertyName = "TuristRutaId";
            this.TuristRutaId.HeaderText = "TuristRutaId";
            this.TuristRutaId.Name = "TuristRutaId";
            this.TuristRutaId.ReadOnly = true;
            this.TuristRutaId.Visible = false;
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            // 
            // Kategorija
            // 
            this.Kategorija.DataPropertyName = "Kategorija";
            this.Kategorija.HeaderText = "Kategorija";
            this.Kategorija.Name = "Kategorija";
            this.Kategorija.ReadOnly = true;
            // 
            // TuristickiVodic
            // 
            this.TuristickiVodic.DataPropertyName = "TuristickiVodic";
            this.TuristickiVodic.HeaderText = "Turisticki vodic";
            this.TuristickiVodic.Name = "TuristickiVodic";
            this.TuristickiVodic.ReadOnly = true;
            this.TuristickiVodic.Width = 145;
            // 
            // Lokacija
            // 
            this.Lokacija.DataPropertyName = "Lokacija";
            this.Lokacija.HeaderText = "Lokacija";
            this.Lokacija.Name = "Lokacija";
            this.Lokacija.ReadOnly = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label5.Location = new System.Drawing.Point(226, 34);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Kategorija";
            // 
            // cmbSearchKategorija
            // 
            this.cmbSearchKategorija.FormattingEnabled = true;
            this.cmbSearchKategorija.Location = new System.Drawing.Point(295, 31);
            this.cmbSearchKategorija.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.cmbSearchKategorija.Name = "cmbSearchKategorija";
            this.cmbSearchKategorija.Size = new System.Drawing.Size(159, 21);
            this.cmbSearchKategorija.TabIndex = 105;
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnPrikazi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrikazi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPrikazi.Location = new System.Drawing.Point(474, 22);
            this.btnPrikazi.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(89, 36);
            this.btnPrikazi.TabIndex = 106;
            this.btnPrikazi.Text = "Prikaži";
            this.btnPrikazi.UseVisualStyleBackColor = false;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPretraga_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(474, 64);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 36);
            this.button1.TabIndex = 113;
            this.button1.Text = "Prikaži sve";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.frmTuristRuta_Load);
            // 
            // frmTuristickeRute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.cmbSearchKategorija);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnDodajRutu);
            this.Controls.Add(this.txtNazivRute);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvTuristRuta);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.ForeColor = System.Drawing.SystemColors.Menu;
            this.Name = "frmTuristickeRute";
            this.Text = "frmTuristickeRute";
            this.Load += new System.EventHandler(this.frmTuristRuta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTuristRuta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDodajRutu;
        private System.Windows.Forms.TextBox txtNazivRute;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvTuristRuta;
        private System.Windows.Forms.DataGridViewTextBoxColumn TuristRutaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kategorija;
        private System.Windows.Forms.DataGridViewTextBoxColumn TuristickiVodic;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lokacija;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbSearchKategorija;
        private System.Windows.Forms.Button btnPrikazi;
        private System.Windows.Forms.Button button1;
    }
}
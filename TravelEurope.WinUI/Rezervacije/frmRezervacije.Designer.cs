namespace TravelEurope.WinUI.Rezervacije
{
    partial class frmRezervacije
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
            this.dgvRezervacija = new System.Windows.Forms.DataGridView();
            this.RezervacijaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TuristRuta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumRezervacije = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Korisnik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chbDo = new System.Windows.Forms.CheckBox();
            this.chBOd = new System.Windows.Forms.CheckBox();
            this.dtpDo = new System.Windows.Forms.DateTimePicker();
            this.dtpOd = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRezervacija)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvRezervacija
            // 
            this.dgvRezervacija.AllowUserToAddRows = false;
            this.dgvRezervacija.AllowUserToDeleteRows = false;
            this.dgvRezervacija.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvRezervacija.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRezervacija.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RezervacijaId,
            this.TuristRuta,
            this.DatumRezervacije,
            this.Korisnik});
            this.dgvRezervacija.Location = new System.Drawing.Point(29, 204);
            this.dgvRezervacija.MultiSelect = false;
            this.dgvRezervacija.Name = "dgvRezervacija";
            this.dgvRezervacija.ReadOnly = true;
            this.dgvRezervacija.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.dgvRezervacija.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvRezervacija.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRezervacija.Size = new System.Drawing.Size(466, 235);
            this.dgvRezervacija.TabIndex = 15;
            // 
            // RezervacijaId
            // 
            this.RezervacijaId.DataPropertyName = "RezervacijaId";
            this.RezervacijaId.HeaderText = "RezervacijaId";
            this.RezervacijaId.Name = "RezervacijaId";
            this.RezervacijaId.ReadOnly = true;
            this.RezervacijaId.Visible = false;
            // 
            // TuristRuta
            // 
            this.TuristRuta.DataPropertyName = "TuristRuta";
            this.TuristRuta.HeaderText = "Turist ruta";
            this.TuristRuta.Name = "TuristRuta";
            this.TuristRuta.ReadOnly = true;
            // 
            // DatumRezervacije
            // 
            this.DatumRezervacije.DataPropertyName = "DatumRezervacije";
            this.DatumRezervacije.HeaderText = "Datum rezervacije";
            this.DatumRezervacije.Name = "DatumRezervacije";
            this.DatumRezervacije.ReadOnly = true;
            this.DatumRezervacije.Width = 125;
            // 
            // Korisnik
            // 
            this.Korisnik.DataPropertyName = "Korisnik";
            this.Korisnik.HeaderText = "Klijent";
            this.Korisnik.Name = "Korisnik";
            this.Korisnik.ReadOnly = true;
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnPrikazi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrikazi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPrikazi.Location = new System.Drawing.Point(406, 87);
            this.btnPrikazi.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(89, 36);
            this.btnPrikazi.TabIndex = 116;
            this.btnPrikazi.Text = "Prikaži";
            this.btnPrikazi.UseVisualStyleBackColor = false;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPretraga_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.chbDo);
            this.groupBox2.Controls.Add(this.chBOd);
            this.groupBox2.Controls.Add(this.dtpDo);
            this.groupBox2.Controls.Add(this.dtpOd);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox2.Location = new System.Drawing.Point(29, 30);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(328, 152);
            this.groupBox2.TabIndex = 129;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datum važenja rezervacije";
            // 
            // chbDo
            // 
            this.chbDo.Location = new System.Drawing.Point(295, 109);
            this.chbDo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbDo.Name = "chbDo";
            this.chbDo.Size = new System.Drawing.Size(27, 25);
            this.chbDo.TabIndex = 106;
            this.chbDo.UseVisualStyleBackColor = true;
            this.chbDo.CheckedChanged += new System.EventHandler(this.chbDo_CheckedChanged);
            // 
            // chBOd
            // 
            this.chBOd.Location = new System.Drawing.Point(295, 56);
            this.chBOd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chBOd.Name = "chBOd";
            this.chBOd.Size = new System.Drawing.Size(27, 23);
            this.chBOd.TabIndex = 106;
            this.chBOd.UseVisualStyleBackColor = true;
            this.chBOd.CheckedChanged += new System.EventHandler(this.chBOd_CheckedChanged);
            // 
            // dtpDo
            // 
            this.dtpDo.Enabled = false;
            this.dtpDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtpDo.Location = new System.Drawing.Point(11, 110);
            this.dtpDo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpDo.MaxDate = new System.DateTime(2029, 12, 31, 0, 0, 0, 0);
            this.dtpDo.MinDate = new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
            this.dtpDo.Name = "dtpDo";
            this.dtpDo.Size = new System.Drawing.Size(267, 23);
            this.dtpDo.TabIndex = 67;
            this.dtpDo.Value = new System.DateTime(2020, 5, 10, 0, 0, 0, 0);
            // 
            // dtpOd
            // 
            this.dtpOd.Enabled = false;
            this.dtpOd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtpOd.Location = new System.Drawing.Point(11, 57);
            this.dtpOd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpOd.MaxDate = new System.DateTime(2029, 12, 31, 0, 0, 0, 0);
            this.dtpOd.MinDate = new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
            this.dtpOd.Name = "dtpOd";
            this.dtpOd.Size = new System.Drawing.Size(267, 23);
            this.dtpOd.TabIndex = 64;
            this.dtpOd.Value = new System.DateTime(2020, 5, 10, 0, 0, 0, 0);
            // 
            // frmRezervacije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(549, 474);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.dgvRezervacija);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.ForeColor = System.Drawing.SystemColors.Menu;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmRezervacije";
            this.Text = "frmRezervacije";
            this.Load += new System.EventHandler(this.frmRezervacija_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRezervacija)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvRezervacija;
        private System.Windows.Forms.Button btnPrikazi;
        private System.Windows.Forms.DataGridViewTextBoxColumn RezervacijaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn TuristRuta;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumRezervacije;
        private System.Windows.Forms.DataGridViewTextBoxColumn Korisnik;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chbDo;
        private System.Windows.Forms.CheckBox chBOd;
        private System.Windows.Forms.DateTimePicker dtpDo;
        private System.Windows.Forms.DateTimePicker dtpOd;
    }
}
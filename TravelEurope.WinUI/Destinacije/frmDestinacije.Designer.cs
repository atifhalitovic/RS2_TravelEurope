namespace TravelEurope.WinUI.Destinacije
{
    partial class frmDestinacije
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNazivDestinacije = new System.Windows.Forms.TextBox();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.cmbSearchDrzave = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDodajDestinaciju = new System.Windows.Forms.Button();
            this.dgvDestinacije = new System.Windows.Forms.DataGridView();
            this.LokacijaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Drzava = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDestinacije)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(365, 56);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 36);
            this.button1.TabIndex = 120;
            this.button1.Text = "Prikaži sve";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.frmDestinacije_Load);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 119;
            this.label1.Text = "Naziv destinacije";
            // 
            // txtNazivDestinacije
            // 
            this.txtNazivDestinacije.Location = new System.Drawing.Point(36, 27);
            this.txtNazivDestinacije.Name = "txtNazivDestinacije";
            this.txtNazivDestinacije.Size = new System.Drawing.Size(117, 20);
            this.txtNazivDestinacije.TabIndex = 118;
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnPrikazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPrikazi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPrikazi.Location = new System.Drawing.Point(365, 17);
            this.btnPrikazi.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(89, 36);
            this.btnPrikazi.TabIndex = 117;
            this.btnPrikazi.Text = "Prikaži";
            this.btnPrikazi.UseVisualStyleBackColor = false;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPretraga_Click);
            // 
            // cmbSearchDrzave
            // 
            this.cmbSearchDrzave.FormattingEnabled = true;
            this.cmbSearchDrzave.Location = new System.Drawing.Point(206, 27);
            this.cmbSearchDrzave.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.cmbSearchDrzave.Name = "cmbSearchDrzave";
            this.cmbSearchDrzave.Size = new System.Drawing.Size(99, 21);
            this.cmbSearchDrzave.TabIndex = 116;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(225, 11);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 115;
            this.label5.Text = "Država";
            // 
            // btnDodajDestinaciju
            // 
            this.btnDodajDestinaciju.BackColor = System.Drawing.Color.LawnGreen;
            this.btnDodajDestinaciju.ForeColor = System.Drawing.Color.Black;
            this.btnDodajDestinaciju.Location = new System.Drawing.Point(31, 64);
            this.btnDodajDestinaciju.Name = "btnDodajDestinaciju";
            this.btnDodajDestinaciju.Size = new System.Drawing.Size(136, 23);
            this.btnDodajDestinaciju.TabIndex = 114;
            this.btnDodajDestinaciju.Text = "Dodaj novu destinaciju";
            this.btnDodajDestinaciju.UseVisualStyleBackColor = false;
            this.btnDodajDestinaciju.Click += new System.EventHandler(this.btnDodajDestinaciju_Click);
            // 
            // dgvDestinacije
            // 
            this.dgvDestinacije.AllowUserToAddRows = false;
            this.dgvDestinacije.AllowUserToDeleteRows = false;
            this.dgvDestinacije.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvDestinacije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDestinacije.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LokacijaId,
            this.Naziv,
            this.Drzava});
            this.dgvDestinacije.Location = new System.Drawing.Point(12, 107);
            this.dgvDestinacije.MultiSelect = false;
            this.dgvDestinacije.Name = "dgvDestinacije";
            this.dgvDestinacije.ReadOnly = true;
            this.dgvDestinacije.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.dgvDestinacije.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDestinacije.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDestinacije.Size = new System.Drawing.Size(451, 235);
            this.dgvDestinacije.TabIndex = 113;
            this.dgvDestinacije.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDestinacije_CellDoubleClick);
            // 
            // LokacijaId
            // 
            this.LokacijaId.DataPropertyName = "LokacijaId";
            this.LokacijaId.HeaderText = "LokacijaId";
            this.LokacijaId.Name = "LokacijaId";
            this.LokacijaId.ReadOnly = true;
            this.LokacijaId.Visible = false;
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            // 
            // Drzava
            // 
            this.Drzava.DataPropertyName = "Drzava";
            this.Drzava.HeaderText = "Država";
            this.Drzava.Name = "Drzava";
            this.Drzava.ReadOnly = true;
            // 
            // frmDestinacije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(481, 357);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNazivDestinacije);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.cmbSearchDrzave);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnDodajDestinaciju);
            this.Controls.Add(this.dgvDestinacije);
            this.ForeColor = System.Drawing.SystemColors.Menu;
            this.Name = "frmDestinacije";
            this.Text = "frmDestinacije";
            this.Load += new System.EventHandler(this.frmDestinacije_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDestinacije)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNazivDestinacije;
        private System.Windows.Forms.Button btnPrikazi;
        private System.Windows.Forms.ComboBox cmbSearchDrzave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDodajDestinaciju;
        private System.Windows.Forms.DataGridView dgvDestinacije;
        private System.Windows.Forms.DataGridViewTextBoxColumn LokacijaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Drzava;
    }
}
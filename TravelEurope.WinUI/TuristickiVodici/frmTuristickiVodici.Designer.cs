namespace TravelEurope.WinUI.TuristickiVodici
{
    partial class frmTuristickiVodici
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
            this.btnDodajVodica = new System.Windows.Forms.Button();
            this.dgvVodici = new System.Windows.Forms.DataGridView();
            this.TuristickiVodicId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StraniJezik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.cmbSearchJezici = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtImeVodica = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVodici)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDodajVodica
            // 
            this.btnDodajVodica.BackColor = System.Drawing.Color.LawnGreen;
            this.btnDodajVodica.ForeColor = System.Drawing.Color.Black;
            this.btnDodajVodica.Location = new System.Drawing.Point(31, 71);
            this.btnDodajVodica.Name = "btnDodajVodica";
            this.btnDodajVodica.Size = new System.Drawing.Size(201, 23);
            this.btnDodajVodica.TabIndex = 19;
            this.btnDodajVodica.Text = "Dodaj novog turističkog vodiča";
            this.btnDodajVodica.UseVisualStyleBackColor = false;
            this.btnDodajVodica.Click += new System.EventHandler(this.btnDodajVodica_Click);
            // 
            // dgvVodici
            // 
            this.dgvVodici.AllowUserToAddRows = false;
            this.dgvVodici.AllowUserToDeleteRows = false;
            this.dgvVodici.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvVodici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVodici.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TuristickiVodicId,
            this.Ime,
            this.Prezime,
            this.StraniJezik});
            this.dgvVodici.Location = new System.Drawing.Point(12, 114);
            this.dgvVodici.MultiSelect = false;
            this.dgvVodici.Name = "dgvVodici";
            this.dgvVodici.ReadOnly = true;
            this.dgvVodici.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.dgvVodici.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvVodici.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVodici.Size = new System.Drawing.Size(451, 235);
            this.dgvVodici.TabIndex = 15;
            this.dgvVodici.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTuristickiVodic_CellDoubleClick);
            // 
            // TuristickiVodicId
            // 
            this.TuristickiVodicId.DataPropertyName = "TuristickiVodicId";
            this.TuristickiVodicId.HeaderText = "TuristickiVodicId";
            this.TuristickiVodicId.Name = "TuristickiVodicId";
            this.TuristickiVodicId.ReadOnly = true;
            this.TuristickiVodicId.Visible = false;
            // 
            // Ime
            // 
            this.Ime.DataPropertyName = "Ime";
            this.Ime.HeaderText = "Ime";
            this.Ime.Name = "Ime";
            this.Ime.ReadOnly = true;
            this.Ime.Width = 90;
            // 
            // Prezime
            // 
            this.Prezime.DataPropertyName = "Prezime";
            this.Prezime.HeaderText = "Prezime";
            this.Prezime.Name = "Prezime";
            this.Prezime.ReadOnly = true;
            // 
            // StraniJezik
            // 
            this.StraniJezik.DataPropertyName = "StraniJezik";
            this.StraniJezik.HeaderText = "Strani jezik";
            this.StraniJezik.Name = "StraniJezik";
            this.StraniJezik.ReadOnly = true;
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnPrikazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPrikazi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPrikazi.Location = new System.Drawing.Point(365, 24);
            this.btnPrikazi.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(89, 36);
            this.btnPrikazi.TabIndex = 109;
            this.btnPrikazi.Text = "Prikaži";
            this.btnPrikazi.UseVisualStyleBackColor = false;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPretraga_Click);
            // 
            // cmbSearchJezici
            // 
            this.cmbSearchJezici.FormattingEnabled = true;
            this.cmbSearchJezici.Location = new System.Drawing.Point(206, 34);
            this.cmbSearchJezici.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.cmbSearchJezici.Name = "cmbSearchJezici";
            this.cmbSearchJezici.Size = new System.Drawing.Size(99, 21);
            this.cmbSearchJezici.TabIndex = 108;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(225, 18);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 107;
            this.label5.Text = "Strani jezik";
            // 
            // txtImeVodica
            // 
            this.txtImeVodica.Location = new System.Drawing.Point(36, 34);
            this.txtImeVodica.Name = "txtImeVodica";
            this.txtImeVodica.Size = new System.Drawing.Size(117, 22);
            this.txtImeVodica.TabIndex = 110;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 111;
            this.label1.Text = "Ime vodiča";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(365, 63);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 36);
            this.button1.TabIndex = 112;
            this.button1.Text = "Prikaži sve";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.frmTuristickiVodic_Load);
            // 
            // frmTuristickiVodici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(487, 368);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtImeVodica);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.cmbSearchJezici);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnDodajVodica);
            this.Controls.Add(this.dgvVodici);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.ForeColor = System.Drawing.SystemColors.Menu;
            this.Name = "frmTuristickiVodici";
            this.Text = "frmTuristickiVodici";
            this.Load += new System.EventHandler(this.frmTuristickiVodic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVodici)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDodajVodica;
        private System.Windows.Forms.DataGridView dgvVodici;
        private System.Windows.Forms.DataGridViewTextBoxColumn TuristickiVodicId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn StraniJezik;
        private System.Windows.Forms.Button btnPrikazi;
        private System.Windows.Forms.ComboBox cmbSearchJezici;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtImeVodica;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}
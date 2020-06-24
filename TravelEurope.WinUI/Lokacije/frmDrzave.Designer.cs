namespace TravelEurope.WinUI.Lokacije
{
    partial class frmDrzave
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
            this.txtNazivDrzave = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPretraga = new System.Windows.Forms.Button();
            this.dgvDrzave = new System.Windows.Forms.DataGridView();
            this.DrzavaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDodajVodica = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrzave)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNazivDrzave
            // 
            this.txtNazivDrzave.Location = new System.Drawing.Point(104, 32);
            this.txtNazivDrzave.Name = "txtNazivDrzave";
            this.txtNazivDrzave.Size = new System.Drawing.Size(143, 22);
            this.txtNazivDrzave.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Menu;
            this.label1.Location = new System.Drawing.Point(30, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Naziv države";
            // 
            // btnPretraga
            // 
            this.btnPretraga.ForeColor = System.Drawing.Color.Black;
            this.btnPretraga.Location = new System.Drawing.Point(253, 30);
            this.btnPretraga.Name = "btnPretraga";
            this.btnPretraga.Size = new System.Drawing.Size(75, 23);
            this.btnPretraga.TabIndex = 6;
            this.btnPretraga.Text = "Pretraga";
            this.btnPretraga.UseVisualStyleBackColor = true;
            this.btnPretraga.Click += new System.EventHandler(this.btnPretraga_Click);
            // 
            // dgvDrzave
            // 
            this.dgvDrzave.AllowUserToAddRows = false;
            this.dgvDrzave.AllowUserToDeleteRows = false;
            this.dgvDrzave.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvDrzave.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDrzave.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DrzavaId,
            this.Naziv});
            this.dgvDrzave.Location = new System.Drawing.Point(12, 114);
            this.dgvDrzave.MultiSelect = false;
            this.dgvDrzave.Name = "dgvDrzave";
            this.dgvDrzave.ReadOnly = true;
            this.dgvDrzave.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.dgvDrzave.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDrzave.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDrzave.Size = new System.Drawing.Size(560, 235);
            this.dgvDrzave.TabIndex = 0;
            this.dgvDrzave.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDrzava_CellDoubleClick);
            // 
            // DrzavaId
            // 
            this.DrzavaId.DataPropertyName = "DrzavaId";
            this.DrzavaId.HeaderText = "DrzavaId";
            this.DrzavaId.Name = "DrzavaId";
            this.DrzavaId.ReadOnly = true;
            this.DrzavaId.Visible = false;
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            this.Naziv.Width = 200;
            // 
            // btnDodajVodica
            // 
            this.btnDodajVodica.BackColor = System.Drawing.Color.LawnGreen;
            this.btnDodajVodica.ForeColor = System.Drawing.Color.Black;
            this.btnDodajVodica.Location = new System.Drawing.Point(343, 30);
            this.btnDodajVodica.Name = "btnDodajVodica";
            this.btnDodajVodica.Size = new System.Drawing.Size(123, 23);
            this.btnDodajVodica.TabIndex = 20;
            this.btnDodajVodica.Text = "Dodaj novu državu";
            this.btnDodajVodica.UseVisualStyleBackColor = false;
            this.btnDodajVodica.Click += new System.EventHandler(this.btnDodajDrzavu_Click);
            // 
            // frmDrzave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.btnDodajVodica);
            this.Controls.Add(this.txtNazivDrzave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPretraga);
            this.Controls.Add(this.dgvDrzave);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.ForeColor = System.Drawing.SystemColors.Menu;
            this.Name = "frmDrzave";
            this.Text = "frmDrzave";
            this.Load += new System.EventHandler(this.frmDrzava_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrzave)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNazivDrzave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPretraga;
        private System.Windows.Forms.DataGridView dgvDrzave;
        private System.Windows.Forms.DataGridViewTextBoxColumn DrzavaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.Button btnDodajVodica;
    }
}
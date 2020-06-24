namespace TravelEurope.WinUI.Lokacije
{
    partial class frmUrediDrzavu
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.btnUredi = new System.Windows.Forms.Button();
            this.dgvGradovi = new System.Windows.Forms.DataGridView();
            this.GradId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDodajVodica = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGradovi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Menu;
            this.label1.Location = new System.Drawing.Point(13, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv države";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(89, 20);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(140, 22);
            this.txtNaziv.TabIndex = 1;
            // 
            // btnUredi
            // 
            this.btnUredi.ForeColor = System.Drawing.Color.Black;
            this.btnUredi.Location = new System.Drawing.Point(154, 48);
            this.btnUredi.Name = "btnUredi";
            this.btnUredi.Size = new System.Drawing.Size(75, 23);
            this.btnUredi.TabIndex = 2;
            this.btnUredi.Text = "Uredi";
            this.btnUredi.UseVisualStyleBackColor = true;
            this.btnUredi.Click += new System.EventHandler(this.btnUredi_Click);
            // 
            // dgvGradovi
            // 
            this.dgvGradovi.AllowUserToAddRows = false;
            this.dgvGradovi.AllowUserToDeleteRows = false;
            this.dgvGradovi.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvGradovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGradovi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GradId,
            this.Naziv});
            this.dgvGradovi.Location = new System.Drawing.Point(16, 90);
            this.dgvGradovi.MultiSelect = false;
            this.dgvGradovi.Name = "dgvGradovi";
            this.dgvGradovi.ReadOnly = true;
            this.dgvGradovi.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvGradovi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGradovi.Size = new System.Drawing.Size(213, 233);
            this.dgvGradovi.TabIndex = 3;
            this.dgvGradovi.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGradovi_CellDoubleClick);
            // 
            // GradId
            // 
            this.GradId.DataPropertyName = "GradId";
            this.GradId.HeaderText = "GradId";
            this.GradId.Name = "GradId";
            this.GradId.ReadOnly = true;
            this.GradId.Visible = false;
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            this.Naziv.Width = 150;
            // 
            // btnDodajVodica
            // 
            this.btnDodajVodica.BackColor = System.Drawing.Color.LawnGreen;
            this.btnDodajVodica.ForeColor = System.Drawing.Color.Black;
            this.btnDodajVodica.Location = new System.Drawing.Point(116, 331);
            this.btnDodajVodica.Name = "btnDodajVodica";
            this.btnDodajVodica.Size = new System.Drawing.Size(113, 23);
            this.btnDodajVodica.TabIndex = 20;
            this.btnDodajVodica.Text = "Dodaj novi grad";
            this.btnDodajVodica.UseVisualStyleBackColor = false;
            this.btnDodajVodica.Click += new System.EventHandler(this.btnDodajGrad_Click);
            // 
            // frmUrediDrzavu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(241, 366);
            this.Controls.Add(this.btnDodajVodica);
            this.Controls.Add(this.dgvGradovi);
            this.Controls.Add(this.btnUredi);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.ForeColor = System.Drawing.Color.Silver;
            this.MaximizeBox = false;
            this.Name = "frmUrediDrzavu";
            this.Text = "Uredi državu";
            this.Load += new System.EventHandler(this.frmUrediDrzavu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGradovi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Button btnUredi;
        private System.Windows.Forms.DataGridView dgvGradovi;
        private System.Windows.Forms.DataGridViewTextBoxColumn GradId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.Button btnDodajVodica;
    }
}
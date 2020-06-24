namespace TravelEurope.WinUI
{
    partial class frmIndex
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
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.korisniciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajKorisnikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.državeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajDržavuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prevozniciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajPrevoznikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.turističkiVodičiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregl = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajTurističkogVodičaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lokacijeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajLokacijuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rezervacijeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledToolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.rezervacijeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnVozila = new System.Windows.Forms.Button();
            this.btnKorisnici = new System.Windows.Forms.Button();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.Black;
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.korisniciToolStripMenuItem,
            this.državeToolStripMenuItem,
            this.prevozniciToolStripMenuItem,
            this.turističkiVodičiToolStripMenuItem,
            this.lokacijeToolStripMenuItem,
            this.rezervacijeToolStripMenuItem1});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(714, 24);
            this.menuStrip2.TabIndex = 7;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // korisniciToolStripMenuItem
            // 
            this.korisniciToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pregledToolStripMenuItem,
            this.dodajKorisnikaToolStripMenuItem});
            this.korisniciToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.korisniciToolStripMenuItem.Name = "korisniciToolStripMenuItem";
            this.korisniciToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.korisniciToolStripMenuItem.Text = "Korisnici";
            // 
            // pregledToolStripMenuItem
            // 
            this.pregledToolStripMenuItem.Name = "pregledToolStripMenuItem";
            this.pregledToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.pregledToolStripMenuItem.Text = "Pregled";
            this.pregledToolStripMenuItem.Click += new System.EventHandler(this.PregledKorisnikaToolStripMenuItem_Click);
            // 
            // dodajKorisnikaToolStripMenuItem
            // 
            this.dodajKorisnikaToolStripMenuItem.Name = "dodajKorisnikaToolStripMenuItem";
            this.dodajKorisnikaToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.dodajKorisnikaToolStripMenuItem.Text = "Dodaj korisnika";
            this.dodajKorisnikaToolStripMenuItem.Click += new System.EventHandler(this.dodajKorisnikaToolStripMenuItem_Click);
            // 
            // državeToolStripMenuItem
            // 
            this.državeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pregledToolStripMenuItem1,
            this.dodajDržavuToolStripMenuItem});
            this.državeToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.državeToolStripMenuItem.Name = "državeToolStripMenuItem";
            this.državeToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.državeToolStripMenuItem.Text = "Države";
            // 
            // pregledToolStripMenuItem1
            // 
            this.pregledToolStripMenuItem1.Name = "pregledToolStripMenuItem1";
            this.pregledToolStripMenuItem1.Size = new System.Drawing.Size(143, 22);
            this.pregledToolStripMenuItem1.Text = "Pregled";
            this.pregledToolStripMenuItem1.Click += new System.EventHandler(this.PregledDrzavaToolStripMenuItem1_Click);
            // 
            // dodajDržavuToolStripMenuItem
            // 
            this.dodajDržavuToolStripMenuItem.Name = "dodajDržavuToolStripMenuItem";
            this.dodajDržavuToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.dodajDržavuToolStripMenuItem.Text = "Dodaj državu";
            this.dodajDržavuToolStripMenuItem.Click += new System.EventHandler(this.dodajDržavuToolStripMenuItem_Click);
            // 
            // prevozniciToolStripMenuItem
            // 
            this.prevozniciToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pregledToolStripMenuItem3,
            this.dodajPrevoznikaToolStripMenuItem});
            this.prevozniciToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.prevozniciToolStripMenuItem.Name = "prevozniciToolStripMenuItem";
            this.prevozniciToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.prevozniciToolStripMenuItem.Text = "Turističke rute";
            // 
            // pregledToolStripMenuItem3
            // 
            this.pregledToolStripMenuItem3.Name = "pregledToolStripMenuItem3";
            this.pregledToolStripMenuItem3.Size = new System.Drawing.Size(182, 22);
            this.pregledToolStripMenuItem3.Text = "Pregled";
            this.pregledToolStripMenuItem3.Click += new System.EventHandler(this.pregledToolStripMenuItem3_Click);
            // 
            // dodajPrevoznikaToolStripMenuItem
            // 
            this.dodajPrevoznikaToolStripMenuItem.Name = "dodajPrevoznikaToolStripMenuItem";
            this.dodajPrevoznikaToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.dodajPrevoznikaToolStripMenuItem.Text = "Dodaj turističku rutu";
            this.dodajPrevoznikaToolStripMenuItem.Click += new System.EventHandler(this.dodajTuristRutuToolStripMenuItem_Click);
            // 
            // turističkiVodičiToolStripMenuItem
            // 
            this.turističkiVodičiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pregl,
            this.dodajTurističkogVodičaToolStripMenuItem});
            this.turističkiVodičiToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.turističkiVodičiToolStripMenuItem.Name = "turističkiVodičiToolStripMenuItem";
            this.turističkiVodičiToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.turističkiVodičiToolStripMenuItem.Text = "Turistički vodiči";
            // 
            // pregl
            // 
            this.pregl.Name = "pregl";
            this.pregl.Size = new System.Drawing.Size(202, 22);
            this.pregl.Text = "Pregled";
            this.pregl.Click += new System.EventHandler(this.pregl_Click);
            // 
            // dodajTurističkogVodičaToolStripMenuItem
            // 
            this.dodajTurističkogVodičaToolStripMenuItem.Name = "dodajTurističkogVodičaToolStripMenuItem";
            this.dodajTurističkogVodičaToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.dodajTurističkogVodičaToolStripMenuItem.Text = "Dodaj turističkog vodiča";
            this.dodajTurističkogVodičaToolStripMenuItem.Click += new System.EventHandler(this.dodajTurističkogVodičaToolStripMenuItem_Click);
            // 
            // lokacijeToolStripMenuItem
            // 
            this.lokacijeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pregledToolStripMenuItem2,
            this.dodajLokacijuToolStripMenuItem});
            this.lokacijeToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Menu;
            this.lokacijeToolStripMenuItem.Name = "lokacijeToolStripMenuItem";
            this.lokacijeToolStripMenuItem.Size = new System.Drawing.Size(132, 20);
            this.lokacijeToolStripMenuItem.Text = "Destinacije putovanja";
            // 
            // pregledToolStripMenuItem2
            // 
            this.pregledToolStripMenuItem2.Name = "pregledToolStripMenuItem2";
            this.pregledToolStripMenuItem2.Size = new System.Drawing.Size(165, 22);
            this.pregledToolStripMenuItem2.Text = "Pregled";
            this.pregledToolStripMenuItem2.Click += new System.EventHandler(this.pregledToolStripMenuItem2_Click);
            // 
            // dodajLokacijuToolStripMenuItem
            // 
            this.dodajLokacijuToolStripMenuItem.Name = "dodajLokacijuToolStripMenuItem";
            this.dodajLokacijuToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.dodajLokacijuToolStripMenuItem.Text = "Dodaj destinaciju";
            this.dodajLokacijuToolStripMenuItem.Click += new System.EventHandler(this.dodajLokacijuToolStripMenuItem_Click);
            // 
            // rezervacijeToolStripMenuItem1
            // 
            this.rezervacijeToolStripMenuItem1.BackColor = System.Drawing.Color.Black;
            this.rezervacijeToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pregledToolStripMenuItem6});
            this.rezervacijeToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rezervacijeToolStripMenuItem1.Name = "rezervacijeToolStripMenuItem1";
            this.rezervacijeToolStripMenuItem1.Size = new System.Drawing.Size(77, 20);
            this.rezervacijeToolStripMenuItem1.Text = "Rezervacije";
            // 
            // pregledToolStripMenuItem6
            // 
            this.pregledToolStripMenuItem6.Name = "pregledToolStripMenuItem6";
            this.pregledToolStripMenuItem6.Size = new System.Drawing.Size(172, 22);
            this.pregledToolStripMenuItem6.Text = "Pregled rezervacija";
            this.pregledToolStripMenuItem6.Click += new System.EventHandler(this.pregledToolStripMenuItem6_Click);
            // 
            // rezervacijeToolStripMenuItem
            // 
            this.rezervacijeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pregledToolStripMenuItem5});
            this.rezervacijeToolStripMenuItem.Name = "rezervacijeToolStripMenuItem";
            this.rezervacijeToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.rezervacijeToolStripMenuItem.Text = "Rezervacije";
            // 
            // pregledToolStripMenuItem5
            // 
            this.pregledToolStripMenuItem5.Name = "pregledToolStripMenuItem5";
            this.pregledToolStripMenuItem5.Size = new System.Drawing.Size(114, 22);
            this.pregledToolStripMenuItem5.Text = "Pregled";
            // 
            // btnVozila
            // 
            this.btnVozila.FlatAppearance.BorderSize = 0;
            this.btnVozila.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVozila.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVozila.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVozila.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVozila.Location = new System.Drawing.Point(478, 162);
            this.btnVozila.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnVozila.Name = "btnVozila";
            this.btnVozila.Size = new System.Drawing.Size(155, 38);
            this.btnVozila.TabIndex = 9;
            this.btnVozila.Text = "    Turisticki paketi";
            this.btnVozila.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVozila.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVozila.UseVisualStyleBackColor = true;
            this.btnVozila.Click += new System.EventHandler(this.btnVozila_Click);
            // 
            // btnKorisnici
            // 
            this.btnKorisnici.FlatAppearance.BorderSize = 0;
            this.btnKorisnici.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKorisnici.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKorisnici.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnKorisnici.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKorisnici.Location = new System.Drawing.Point(126, 162);
            this.btnKorisnici.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnKorisnici.Name = "btnKorisnici";
            this.btnKorisnici.Size = new System.Drawing.Size(155, 38);
            this.btnKorisnici.TabIndex = 8;
            this.btnKorisnici.Text = "    Korisnici";
            this.btnKorisnici.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKorisnici.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKorisnici.UseVisualStyleBackColor = true;
            this.btnKorisnici.Click += new System.EventHandler(this.btnKorisnici_Click);
            // 
            // frmIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(714, 361);
            this.Controls.Add(this.btnVozila);
            this.Controls.Add(this.btnKorisnici);
            this.Controls.Add(this.menuStrip2);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.Name = "frmIndex";
            this.Text = "frmIndex";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem korisniciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem državeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dodajDržavuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajKorisnikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prevozniciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem dodajPrevoznikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem turističkiVodičiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregl;
        private System.Windows.Forms.ToolStripMenuItem dodajTurističkogVodičaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rezervacijeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pregledToolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem rezervacijeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledToolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem lokacijeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem dodajLokacijuToolStripMenuItem;
        private System.Windows.Forms.Button btnVozila;
        private System.Windows.Forms.Button btnKorisnici;
    }
}
namespace UmplePoligonul
{
    partial class UmplePoligon
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
            this.lgrosime = new System.Windows.Forms.Label();
            this.grosime = new System.Windows.Forms.NumericUpDown();
            this.bculoare = new System.Windows.Forms.Button();
            this.lvarfuri = new System.Windows.Forms.Label();
            this.numere = new System.Windows.Forms.NumericUpDown();
            this.okgen = new System.Windows.Forms.Button();
            this.genereaza = new System.Windows.Forms.Button();
            this.lalege = new System.Windows.Forms.Label();
            this.dinfis = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.umpleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scanLineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boundaryFillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cu4PuncteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cu8PuncteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.floodFillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cu4PuncteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cu8PuncteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fiserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salveazaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iesireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.status = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.grosime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numere)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.status.SuspendLayout();
            this.SuspendLayout();
            // 
            // lgrosime
            // 
            this.lgrosime.AutoSize = true;
            this.lgrosime.BackColor = System.Drawing.Color.Transparent;
            this.lgrosime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lgrosime.Location = new System.Drawing.Point(116, 233);
            this.lgrosime.Name = "lgrosime";
            this.lgrosime.Size = new System.Drawing.Size(61, 17);
            this.lgrosime.TabIndex = 25;
            this.lgrosime.Text = "Grosime";
            this.lgrosime.Visible = false;
            // 
            // grosime
            // 
            this.grosime.Location = new System.Drawing.Point(119, 257);
            this.grosime.Name = "grosime";
            this.grosime.Size = new System.Drawing.Size(68, 20);
            this.grosime.TabIndex = 24;
            this.grosime.Visible = false;
            // 
            // bculoare
            // 
            this.bculoare.BackColor = System.Drawing.Color.Silver;
            this.bculoare.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bculoare.Location = new System.Drawing.Point(30, 283);
            this.bculoare.Name = "bculoare";
            this.bculoare.Size = new System.Drawing.Size(157, 23);
            this.bculoare.TabIndex = 23;
            this.bculoare.Text = "Culoare";
            this.bculoare.UseVisualStyleBackColor = false;
            this.bculoare.Visible = false;
            this.bculoare.Click += new System.EventHandler(this.bculoare_Click);
            // 
            // lvarfuri
            // 
            this.lvarfuri.AutoSize = true;
            this.lvarfuri.BackColor = System.Drawing.Color.Transparent;
            this.lvarfuri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvarfuri.Location = new System.Drawing.Point(30, 233);
            this.lvarfuri.Name = "lvarfuri";
            this.lvarfuri.Size = new System.Drawing.Size(50, 17);
            this.lvarfuri.TabIndex = 22;
            this.lvarfuri.Text = "Varfuri";
            this.lvarfuri.Visible = false;
            // 
            // numere
            // 
            this.numere.Location = new System.Drawing.Point(30, 257);
            this.numere.Name = "numere";
            this.numere.Size = new System.Drawing.Size(70, 20);
            this.numere.TabIndex = 21;
            this.numere.Visible = false;
            // 
            // okgen
            // 
            this.okgen.BackColor = System.Drawing.Color.LightSkyBlue;
            this.okgen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okgen.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.okgen.Location = new System.Drawing.Point(30, 312);
            this.okgen.Name = "okgen";
            this.okgen.Size = new System.Drawing.Size(157, 28);
            this.okgen.TabIndex = 20;
            this.okgen.Text = "OK";
            this.okgen.UseVisualStyleBackColor = false;
            this.okgen.Visible = false;
            this.okgen.Click += new System.EventHandler(this.okgen_Click);
            // 
            // genereaza
            // 
            this.genereaza.BackColor = System.Drawing.Color.LightSkyBlue;
            this.genereaza.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genereaza.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.genereaza.Location = new System.Drawing.Point(30, 178);
            this.genereaza.Name = "genereaza";
            this.genereaza.Size = new System.Drawing.Size(157, 37);
            this.genereaza.TabIndex = 19;
            this.genereaza.Text = "Genereaza";
            this.genereaza.UseVisualStyleBackColor = false;
            this.genereaza.Click += new System.EventHandler(this.genereaza_Click);
            // 
            // lalege
            // 
            this.lalege.AutoSize = true;
            this.lalege.BackColor = System.Drawing.Color.Transparent;
            this.lalege.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lalege.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lalege.Location = new System.Drawing.Point(30, 117);
            this.lalege.Name = "lalege";
            this.lalege.Size = new System.Drawing.Size(94, 17);
            this.lalege.TabIndex = 18;
            this.lalege.Text = "Alege poligon";
            // 
            // dinfis
            // 
            this.dinfis.BackColor = System.Drawing.Color.LightSkyBlue;
            this.dinfis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dinfis.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.dinfis.Location = new System.Drawing.Point(30, 137);
            this.dinfis.Name = "dinfis";
            this.dinfis.Size = new System.Drawing.Size(157, 35);
            this.dinfis.TabIndex = 17;
            this.dinfis.Text = "Din fisier...";
            this.dinfis.UseVisualStyleBackColor = false;
            this.dinfis.Click += new System.EventHandler(this.dinfis_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(215, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(369, 24);
            this.label1.TabIndex = 16;
            this.label1.Text = "Scan-Line && Boundary-Fill && Flood-Fill";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(219, 90);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(457, 410);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.umpleToolStripMenuItem,
            this.fiserToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(689, 27);
            this.menuStrip1.TabIndex = 26;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // umpleToolStripMenuItem
            // 
            this.umpleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scanLineToolStripMenuItem,
            this.boundaryFillToolStripMenuItem,
            this.floodFillToolStripMenuItem});
            this.umpleToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.umpleToolStripMenuItem.ForeColor = System.Drawing.Color.DodgerBlue;
            this.umpleToolStripMenuItem.Name = "umpleToolStripMenuItem";
            this.umpleToolStripMenuItem.Size = new System.Drawing.Size(65, 23);
            this.umpleToolStripMenuItem.Text = "Umple";
            // 
            // scanLineToolStripMenuItem
            // 
            this.scanLineToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.scanLineToolStripMenuItem.ForeColor = System.Drawing.Color.DodgerBlue;
            this.scanLineToolStripMenuItem.Name = "scanLineToolStripMenuItem";
            this.scanLineToolStripMenuItem.Size = new System.Drawing.Size(159, 24);
            this.scanLineToolStripMenuItem.Text = "Scan-Line";
            this.scanLineToolStripMenuItem.Click += new System.EventHandler(this.scanLineToolStripMenuItem_Click);
            // 
            // boundaryFillToolStripMenuItem
            // 
            this.boundaryFillToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cu4PuncteToolStripMenuItem,
            this.cu8PuncteToolStripMenuItem});
            this.boundaryFillToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.boundaryFillToolStripMenuItem.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.boundaryFillToolStripMenuItem.Name = "boundaryFillToolStripMenuItem";
            this.boundaryFillToolStripMenuItem.Size = new System.Drawing.Size(159, 24);
            this.boundaryFillToolStripMenuItem.Text = "Boundary-Fill";
            // 
            // cu4PuncteToolStripMenuItem
            // 
            this.cu4PuncteToolStripMenuItem.ForeColor = System.Drawing.Color.DodgerBlue;
            this.cu4PuncteToolStripMenuItem.Name = "cu4PuncteToolStripMenuItem";
            this.cu4PuncteToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
            this.cu4PuncteToolStripMenuItem.Text = "Cu 4 puncte";
            this.cu4PuncteToolStripMenuItem.Click += new System.EventHandler(this.cu4PuncteToolStripMenuItem_Click);
            // 
            // cu8PuncteToolStripMenuItem
            // 
            this.cu8PuncteToolStripMenuItem.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.cu8PuncteToolStripMenuItem.Name = "cu8PuncteToolStripMenuItem";
            this.cu8PuncteToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
            this.cu8PuncteToolStripMenuItem.Text = "Cu 8 puncte";
            this.cu8PuncteToolStripMenuItem.Click += new System.EventHandler(this.cu8PuncteToolStripMenuItem_Click);
            // 
            // floodFillToolStripMenuItem
            // 
            this.floodFillToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cu4PuncteToolStripMenuItem1,
            this.cu8PuncteToolStripMenuItem1});
            this.floodFillToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.floodFillToolStripMenuItem.ForeColor = System.Drawing.Color.DodgerBlue;
            this.floodFillToolStripMenuItem.Name = "floodFillToolStripMenuItem";
            this.floodFillToolStripMenuItem.Size = new System.Drawing.Size(159, 24);
            this.floodFillToolStripMenuItem.Text = "Flood-Fill";
            // 
            // cu4PuncteToolStripMenuItem1
            // 
            this.cu4PuncteToolStripMenuItem1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.cu4PuncteToolStripMenuItem1.Name = "cu4PuncteToolStripMenuItem1";
            this.cu4PuncteToolStripMenuItem1.Size = new System.Drawing.Size(153, 24);
            this.cu4PuncteToolStripMenuItem1.Text = "Cu 4 puncte";
            this.cu4PuncteToolStripMenuItem1.Click += new System.EventHandler(this.cu4PuncteToolStripMenuItem1_Click);
            // 
            // cu8PuncteToolStripMenuItem1
            // 
            this.cu8PuncteToolStripMenuItem1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.cu8PuncteToolStripMenuItem1.Name = "cu8PuncteToolStripMenuItem1";
            this.cu8PuncteToolStripMenuItem1.Size = new System.Drawing.Size(153, 24);
            this.cu8PuncteToolStripMenuItem1.Text = "Cu 8 puncte";
            this.cu8PuncteToolStripMenuItem1.Click += new System.EventHandler(this.cu8PuncteToolStripMenuItem1_Click);
            // 
            // fiserToolStripMenuItem
            // 
            this.fiserToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salveazaToolStripMenuItem,
            this.iesireToolStripMenuItem});
            this.fiserToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.fiserToolStripMenuItem.ForeColor = System.Drawing.Color.DodgerBlue;
            this.fiserToolStripMenuItem.Name = "fiserToolStripMenuItem";
            this.fiserToolStripMenuItem.Size = new System.Drawing.Size(56, 23);
            this.fiserToolStripMenuItem.Text = "Fisier";
            this.fiserToolStripMenuItem.Click += new System.EventHandler(this.fiserToolStripMenuItem_Click);
            // 
            // salveazaToolStripMenuItem
            // 
            this.salveazaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.salveazaToolStripMenuItem.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.salveazaToolStripMenuItem.Name = "salveazaToolStripMenuItem";
            this.salveazaToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.salveazaToolStripMenuItem.Text = "Salveaza";
            this.salveazaToolStripMenuItem.Click += new System.EventHandler(this.salveazaToolStripMenuItem_Click);
            // 
            // iesireToolStripMenuItem
            // 
            this.iesireToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.iesireToolStripMenuItem.ForeColor = System.Drawing.Color.DodgerBlue;
            this.iesireToolStripMenuItem.Name = "iesireToolStripMenuItem";
            this.iesireToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.iesireToolStripMenuItem.Text = "Iesire";
            this.iesireToolStripMenuItem.Click += new System.EventHandler(this.iesireToolStripMenuItem_Click);
            // 
            // status
            // 
            this.status.BackColor = System.Drawing.Color.Transparent;
            this.status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.status.Location = new System.Drawing.Point(0, 516);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(689, 24);
            this.status.TabIndex = 27;
            this.status.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Enabled = false;
            this.statusLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(40, 19);
            this.statusLabel.Text = "ceva";
            this.statusLabel.Visible = false;
            this.statusLabel.Click += new System.EventHandler(this.statusLabel_Click);
            // 
            // UmplePoligon
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::UmplePoligonul.Properties.Resources.cover_form;
            this.ClientSize = new System.Drawing.Size(689, 540);
            this.Controls.Add(this.status);
            this.Controls.Add(this.lgrosime);
            this.Controls.Add(this.grosime);
            this.Controls.Add(this.bculoare);
            this.Controls.Add(this.lvarfuri);
            this.Controls.Add(this.numere);
            this.Controls.Add(this.okgen);
            this.Controls.Add(this.genereaza);
            this.Controls.Add(this.lalege);
            this.Controls.Add(this.dinfis);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "UmplePoligon";
            this.Text = "Umplere Poligoane";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grosime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numere)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.status.ResumeLayout(false);
            this.status.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lgrosime;
        private System.Windows.Forms.NumericUpDown grosime;
        private System.Windows.Forms.Button bculoare;
        private System.Windows.Forms.Label lvarfuri;
        private System.Windows.Forms.NumericUpDown numere;
        private System.Windows.Forms.Button okgen;
        private System.Windows.Forms.Button genereaza;
        private System.Windows.Forms.Label lalege;
        private System.Windows.Forms.Button dinfis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem umpleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scanLineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem boundaryFillToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cu4PuncteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cu8PuncteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem floodFillToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cu4PuncteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cu8PuncteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fiserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salveazaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iesireToolStripMenuItem;
        private System.Windows.Forms.StatusStrip status;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
    }
}


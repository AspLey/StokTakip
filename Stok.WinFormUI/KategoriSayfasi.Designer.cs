namespace Stok.WinFormUI
{
    partial class KategoriSayfasi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KategoriSayfasi));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.txtkategorisearch = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtkategoriadi = new System.Windows.Forms.TextBox();
            this.txtkategoriacikla = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtkategoriadguncel = new System.Windows.Forms.TextBox();
            this.txtkategoriguncelacik = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.kategoritemizle = new System.Windows.Forms.Button();
            this.kategoriguncel = new System.Windows.Forms.Button();
            this.kategorisil = new System.Windows.Forms.Button();
            this.kategoriekle = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 393);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(998, 241);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(484, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 25);
            this.label7.TabIndex = 15;
            this.label7.Text = "Arama";
            // 
            // txtkategorisearch
            // 
            this.txtkategorisearch.Location = new System.Drawing.Point(428, 58);
            this.txtkategorisearch.Name = "txtkategorisearch";
            this.txtkategorisearch.Size = new System.Drawing.Size(182, 30);
            this.txtkategorisearch.TabIndex = 12;
            this.txtkategorisearch.TextChanged += new System.EventHandler(this.txtkategorisearch_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtkategoriadi);
            this.groupBox1.Controls.Add(this.txtkategoriacikla);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(365, 262);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "EKLEME İŞLEMİ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "AÇIKLAMA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "KATEGORİ ADI";
            // 
            // txtkategoriadi
            // 
            this.txtkategoriadi.Location = new System.Drawing.Point(171, 92);
            this.txtkategoriadi.Name = "txtkategoriadi";
            this.txtkategoriadi.Size = new System.Drawing.Size(182, 30);
            this.txtkategoriadi.TabIndex = 2;
            // 
            // txtkategoriacikla
            // 
            this.txtkategoriacikla.Location = new System.Drawing.Point(171, 141);
            this.txtkategoriacikla.Name = "txtkategoriacikla";
            this.txtkategoriacikla.Size = new System.Drawing.Size(182, 30);
            this.txtkategoriacikla.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtkategoriadguncel);
            this.groupBox2.Controls.Add(this.txtkategoriguncelacik);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox2.Location = new System.Drawing.Point(647, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(365, 262);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "GÜNCELLEME İŞLEMİ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "AÇIKLAMA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "KATEGORİ ADI";
            // 
            // txtkategoriadguncel
            // 
            this.txtkategoriadguncel.Location = new System.Drawing.Point(171, 92);
            this.txtkategoriadguncel.Name = "txtkategoriadguncel";
            this.txtkategoriadguncel.Size = new System.Drawing.Size(182, 30);
            this.txtkategoriadguncel.TabIndex = 2;
            // 
            // txtkategoriguncelacik
            // 
            this.txtkategoriguncelacik.Location = new System.Drawing.Point(171, 141);
            this.txtkategoriguncelacik.Name = "txtkategoriguncelacik";
            this.txtkategoriguncelacik.Size = new System.Drawing.Size(182, 30);
            this.txtkategoriguncelacik.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.kategoritemizle);
            this.panel1.Controls.Add(this.kategoriguncel);
            this.panel1.Controls.Add(this.kategorisil);
            this.panel1.Controls.Add(this.kategoriekle);
            this.panel1.Location = new System.Drawing.Point(13, 297);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(998, 86);
            this.panel1.TabIndex = 7;
            // 
            // kategoritemizle
            // 
            this.kategoritemizle.BackColor = System.Drawing.Color.Snow;
            this.kategoritemizle.Image = global::Stok.WinFormUI.Properties.Resources.clear;
            this.kategoritemizle.Location = new System.Drawing.Point(723, 5);
            this.kategoritemizle.Name = "kategoritemizle";
            this.kategoritemizle.Size = new System.Drawing.Size(168, 74);
            this.kategoritemizle.TabIndex = 7;
            this.kategoritemizle.Text = "TEMİZLE";
            this.kategoritemizle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.kategoritemizle.UseVisualStyleBackColor = false;
            this.kategoritemizle.Click += new System.EventHandler(this.kategoritemizle_Click);
            // 
            // kategoriguncel
            // 
            this.kategoriguncel.BackColor = System.Drawing.Color.Snow;
            this.kategoriguncel.Image = global::Stok.WinFormUI.Properties.Resources.update;
            this.kategoriguncel.Location = new System.Drawing.Point(499, 5);
            this.kategoriguncel.Name = "kategoriguncel";
            this.kategoriguncel.Size = new System.Drawing.Size(196, 74);
            this.kategoriguncel.TabIndex = 6;
            this.kategoriguncel.Text = "GÜNCELLE";
            this.kategoriguncel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.kategoriguncel.UseVisualStyleBackColor = false;
            this.kategoriguncel.Click += new System.EventHandler(this.kategoriguncel_Click);
            // 
            // kategorisil
            // 
            this.kategorisil.BackColor = System.Drawing.Color.Snow;
            this.kategorisil.Image = global::Stok.WinFormUI.Properties.Resources.delete1;
            this.kategorisil.Location = new System.Drawing.Point(303, 5);
            this.kategorisil.Name = "kategorisil";
            this.kategorisil.Size = new System.Drawing.Size(168, 74);
            this.kategorisil.TabIndex = 5;
            this.kategorisil.Text = "SİLME";
            this.kategorisil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.kategorisil.UseVisualStyleBackColor = false;
            this.kategorisil.Click += new System.EventHandler(this.kategorisil_Click);
            // 
            // kategoriekle
            // 
            this.kategoriekle.BackColor = System.Drawing.Color.Snow;
            this.kategoriekle.Image = global::Stok.WinFormUI.Properties.Resources.add64;
            this.kategoriekle.Location = new System.Drawing.Point(107, 5);
            this.kategoriekle.Name = "kategoriekle";
            this.kategoriekle.Size = new System.Drawing.Size(168, 74);
            this.kategoriekle.TabIndex = 0;
            this.kategoriekle.Text = "EKLEME";
            this.kategoriekle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.kategoriekle.UseVisualStyleBackColor = false;
            this.kategoriekle.Click += new System.EventHandler(this.kategoriekle_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Snow;
            this.button1.Image = global::Stok.WinFormUI.Properties.Resources.back21;
            this.button1.Location = new System.Drawing.Point(428, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 74);
            this.button1.TabIndex = 17;
            this.button1.Text = "Personel Sayfası";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Snow;
            this.button2.Image = global::Stok.WinFormUI.Properties.Resources.back21;
            this.button2.Location = new System.Drawing.Point(428, 200);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(180, 74);
            this.button2.TabIndex = 9;
            this.button2.Text = "Admin Sayfası";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // KategoriSayfasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::Stok.WinFormUI.Properties.Resources._7;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1024, 647);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtkategorisearch);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "KategoriSayfasi";
            this.Text = "KATEGORİ SAYFASI";
            this.Load += new System.EventHandler(this.KategoriSayfasi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtkategorisearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtkategoriadi;
        private System.Windows.Forms.TextBox txtkategoriacikla;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtkategoriadguncel;
        private System.Windows.Forms.TextBox txtkategoriguncelacik;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button kategoritemizle;
        private System.Windows.Forms.Button kategoriguncel;
        private System.Windows.Forms.Button kategorisil;
        private System.Windows.Forms.Button kategoriekle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
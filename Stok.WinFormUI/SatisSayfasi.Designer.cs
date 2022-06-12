namespace Stok.WinFormUI
{
    partial class SatisSayfasi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SatisSayfasi));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.satisurun = new System.Windows.Forms.ComboBox();
            this.satispersonel = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.satismüsteri = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.satistarih = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.satisfiyat = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.satistemizle = new System.Windows.Forms.Button();
            this.satissilme = new System.Windows.Forms.Button();
            this.satiekle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.satisadet = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.satisadet);
            this.groupBox1.Controls.Add(this.satisurun);
            this.groupBox1.Controls.Add(this.satispersonel);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.satismüsteri);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.satistarih);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.satisfiyat);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(-2, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(994, 329);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "EKLEME İŞLEMİ";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // satisurun
            // 
            this.satisurun.FormattingEnabled = true;
            this.satisurun.Location = new System.Drawing.Point(429, 52);
            this.satisurun.Name = "satisurun";
            this.satisurun.Size = new System.Drawing.Size(182, 33);
            this.satisurun.TabIndex = 13;
            // 
            // satispersonel
            // 
            this.satispersonel.FormattingEnabled = true;
            this.satispersonel.Location = new System.Drawing.Point(429, 242);
            this.satispersonel.Name = "satispersonel";
            this.satispersonel.Size = new System.Drawing.Size(182, 33);
            this.satispersonel.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(304, 245);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 25);
            this.label9.TabIndex = 11;
            this.label9.Text = "PERSONEL";
            // 
            // satismüsteri
            // 
            this.satismüsteri.FormattingEnabled = true;
            this.satismüsteri.Location = new System.Drawing.Point(429, 193);
            this.satismüsteri.Name = "satismüsteri";
            this.satismüsteri.Size = new System.Drawing.Size(182, 33);
            this.satismüsteri.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(322, 198);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 25);
            this.label8.TabIndex = 9;
            this.label8.Text = "MÜŞTERİ";
            // 
            // satistarih
            // 
            this.satistarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.satistarih.Location = new System.Drawing.Point(429, 147);
            this.satistarih.Name = "satistarih";
            this.satistarih.Size = new System.Drawing.Size(182, 30);
            this.satistarih.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(352, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "TARİH";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(285, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "SATIŞ FİYATi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(356, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "ÜRÜN";
            // 
            // satisfiyat
            // 
            this.satisfiyat.Location = new System.Drawing.Point(429, 101);
            this.satisfiyat.Name = "satisfiyat";
            this.satisfiyat.Size = new System.Drawing.Size(182, 30);
            this.satisfiyat.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.satistemizle);
            this.panel1.Controls.Add(this.satissilme);
            this.panel1.Controls.Add(this.satiekle);
            this.panel1.Location = new System.Drawing.Point(13, 357);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(998, 86);
            this.panel1.TabIndex = 13;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Snow;
            this.button2.Image = global::Stok.WinFormUI.Properties.Resources.back21;
            this.button2.Location = new System.Drawing.Point(609, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(180, 74);
            this.button2.TabIndex = 18;
            this.button2.Text = "Admin Sayfası";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Snow;
            this.button1.Image = global::Stok.WinFormUI.Properties.Resources.back21;
            this.button1.Location = new System.Drawing.Point(799, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 74);
            this.button1.TabIndex = 19;
            this.button1.Text = "Personel Sayfası";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // satistemizle
            // 
            this.satistemizle.BackColor = System.Drawing.Color.Snow;
            this.satistemizle.Image = global::Stok.WinFormUI.Properties.Resources.clear;
            this.satistemizle.Location = new System.Drawing.Point(422, 3);
            this.satistemizle.Name = "satistemizle";
            this.satistemizle.Size = new System.Drawing.Size(168, 74);
            this.satistemizle.TabIndex = 7;
            this.satistemizle.Text = "TEMİZLE";
            this.satistemizle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.satistemizle.UseVisualStyleBackColor = false;
            this.satistemizle.Click += new System.EventHandler(this.satistemizle_Click);
            // 
            // satissilme
            // 
            this.satissilme.BackColor = System.Drawing.Color.Snow;
            this.satissilme.Image = global::Stok.WinFormUI.Properties.Resources.delete1;
            this.satissilme.Location = new System.Drawing.Point(216, 3);
            this.satissilme.Name = "satissilme";
            this.satissilme.Size = new System.Drawing.Size(168, 74);
            this.satissilme.TabIndex = 5;
            this.satissilme.Text = "SİLME";
            this.satissilme.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.satissilme.UseVisualStyleBackColor = false;
            this.satissilme.Click += new System.EventHandler(this.satissilme_Click);
            // 
            // satiekle
            // 
            this.satiekle.BackColor = System.Drawing.Color.Snow;
            this.satiekle.Image = global::Stok.WinFormUI.Properties.Resources.add64;
            this.satiekle.Location = new System.Drawing.Point(11, 3);
            this.satiekle.Name = "satiekle";
            this.satiekle.Size = new System.Drawing.Size(168, 74);
            this.satiekle.TabIndex = 0;
            this.satiekle.Text = "EKLEME";
            this.satiekle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.satiekle.UseVisualStyleBackColor = false;
            this.satiekle.Click += new System.EventHandler(this.satiekle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 453);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1007, 241);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(285, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "SATIŞ ADEDİ";
            // 
            // satisadet
            // 
            this.satisadet.Location = new System.Drawing.Point(429, 286);
            this.satisadet.Name = "satisadet";
            this.satisadet.Size = new System.Drawing.Size(182, 30);
            this.satisadet.TabIndex = 14;
            // 
            // SatisSayfasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Stok.WinFormUI.Properties.Resources._7;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1016, 698);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SatisSayfasi";
            this.Text = "SATIŞ SAYFASI";
            this.Load += new System.EventHandler(this.SatisSayfasi_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox satisfiyat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button satistemizle;
        private System.Windows.Forms.Button satissilme;
        private System.Windows.Forms.Button satiekle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker satistarih;
        private System.Windows.Forms.ComboBox satispersonel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox satismüsteri;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox satisurun;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox satisadet;
    }
}
namespace Stok.WinFormUI
{
    partial class UrunSayfasi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UrunSayfasi));
            this.panel1 = new System.Windows.Forms.Panel();
            this.uruntemiz = new System.Windows.Forms.Button();
            this.urunguncel = new System.Windows.Forms.Button();
            this.urunsilme = new System.Windows.Forms.Button();
            this.urunekle = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.urunarama = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Uruneklead = new System.Windows.Forms.TextBox();
            this.UrunSatis = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.UrunTarih = new System.Windows.Forms.DateTimePicker();
            this.UrunAlis = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.UrunKategori = new System.Windows.Forms.ComboBox();
            this.Urunmarka = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.urungunceladi = new System.Windows.Forms.TextBox();
            this.urunguncelsatis = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.urungunceltarih = new System.Windows.Forms.DateTimePicker();
            this.urunguncelalis = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.urunguncelkategori = new System.Windows.Forms.ComboBox();
            this.Urunguncelmarka = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.uruntemiz);
            this.panel1.Controls.Add(this.urunguncel);
            this.panel1.Controls.Add(this.urunsilme);
            this.panel1.Controls.Add(this.urunekle);
            this.panel1.Location = new System.Drawing.Point(14, 361);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(991, 86);
            this.panel1.TabIndex = 32;
            // 
            // uruntemiz
            // 
            this.uruntemiz.BackColor = System.Drawing.Color.Snow;
            this.uruntemiz.Image = global::Stok.WinFormUI.Properties.Resources.clear;
            this.uruntemiz.Location = new System.Drawing.Point(719, 5);
            this.uruntemiz.Name = "uruntemiz";
            this.uruntemiz.Size = new System.Drawing.Size(168, 74);
            this.uruntemiz.TabIndex = 7;
            this.uruntemiz.Text = "TEMİZLE";
            this.uruntemiz.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.uruntemiz.UseVisualStyleBackColor = false;
            this.uruntemiz.Click += new System.EventHandler(this.uruntemiz_Click);
            // 
            // urunguncel
            // 
            this.urunguncel.BackColor = System.Drawing.Color.Snow;
            this.urunguncel.Image = global::Stok.WinFormUI.Properties.Resources.update;
            this.urunguncel.Location = new System.Drawing.Point(495, 5);
            this.urunguncel.Name = "urunguncel";
            this.urunguncel.Size = new System.Drawing.Size(196, 74);
            this.urunguncel.TabIndex = 6;
            this.urunguncel.Text = "GÜNCELLE";
            this.urunguncel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.urunguncel.UseVisualStyleBackColor = false;
            this.urunguncel.Click += new System.EventHandler(this.urunguncel_Click);
            // 
            // urunsilme
            // 
            this.urunsilme.BackColor = System.Drawing.Color.Snow;
            this.urunsilme.Image = global::Stok.WinFormUI.Properties.Resources.delete1;
            this.urunsilme.Location = new System.Drawing.Point(299, 5);
            this.urunsilme.Name = "urunsilme";
            this.urunsilme.Size = new System.Drawing.Size(168, 74);
            this.urunsilme.TabIndex = 5;
            this.urunsilme.Text = "SİLME";
            this.urunsilme.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.urunsilme.UseVisualStyleBackColor = false;
            this.urunsilme.Click += new System.EventHandler(this.urunsilme_Click);
            // 
            // urunekle
            // 
            this.urunekle.BackColor = System.Drawing.Color.Snow;
            this.urunekle.Image = global::Stok.WinFormUI.Properties.Resources.add64;
            this.urunekle.Location = new System.Drawing.Point(103, 5);
            this.urunekle.Name = "urunekle";
            this.urunekle.Size = new System.Drawing.Size(168, 74);
            this.urunekle.TabIndex = 0;
            this.urunekle.Text = "EKLEME";
            this.urunekle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.urunekle.UseVisualStyleBackColor = false;
            this.urunekle.Click += new System.EventHandler(this.urunekle_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(424, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(169, 25);
            this.label7.TabIndex = 30;
            this.label7.Text = "İSME GÖRE ARA";
            // 
            // urunarama
            // 
            this.urunarama.Location = new System.Drawing.Point(417, 74);
            this.urunarama.Name = "urunarama";
            this.urunarama.Size = new System.Drawing.Size(182, 30);
            this.urunarama.TabIndex = 28;
            this.urunarama.TextChanged += new System.EventHandler(this.urunarama_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.Uruneklead);
            this.groupBox1.Controls.Add(this.UrunSatis);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.UrunTarih);
            this.groupBox1.Controls.Add(this.UrunAlis);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.UrunKategori);
            this.groupBox1.Controls.Add(this.Urunmarka);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(14, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(365, 340);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "EKLEME İŞLEMİ";
            // 
            // Uruneklead
            // 
            this.Uruneklead.Location = new System.Drawing.Point(161, 35);
            this.Uruneklead.Name = "Uruneklead";
            this.Uruneklead.Size = new System.Drawing.Size(182, 30);
            this.Uruneklead.TabIndex = 26;
            // 
            // UrunSatis
            // 
            this.UrunSatis.Location = new System.Drawing.Point(161, 229);
            this.UrunSatis.Name = "UrunSatis";
            this.UrunSatis.Size = new System.Drawing.Size(182, 30);
            this.UrunSatis.TabIndex = 26;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 230);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(139, 25);
            this.label11.TabIndex = 25;
            this.label11.Text = "SATIŞ FİYATI";
            // 
            // UrunTarih
            // 
            this.UrunTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.UrunTarih.Location = new System.Drawing.Point(161, 276);
            this.UrunTarih.Name = "UrunTarih";
            this.UrunTarih.Size = new System.Drawing.Size(182, 30);
            this.UrunTarih.TabIndex = 24;
            // 
            // UrunAlis
            // 
            this.UrunAlis.Location = new System.Drawing.Point(161, 182);
            this.UrunAlis.Name = "UrunAlis";
            this.UrunAlis.Size = new System.Drawing.Size(182, 30);
            this.UrunAlis.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(89, 278);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 25);
            this.label12.TabIndex = 23;
            this.label12.Text = "TARİH";
            // 
            // UrunKategori
            // 
            this.UrunKategori.FormattingEnabled = true;
            this.UrunKategori.Location = new System.Drawing.Point(161, 132);
            this.UrunKategori.Name = "UrunKategori";
            this.UrunKategori.Size = new System.Drawing.Size(182, 33);
            this.UrunKategori.TabIndex = 16;
            // 
            // Urunmarka
            // 
            this.Urunmarka.FormattingEnabled = true;
            this.Urunmarka.Location = new System.Drawing.Point(161, 82);
            this.Urunmarka.Name = "Urunmarka";
            this.Urunmarka.Size = new System.Drawing.Size(182, 33);
            this.Urunmarka.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(37, 182);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 25);
            this.label8.TabIndex = 9;
            this.label8.Text = "ALIŞ FİYATI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "KATEGORİ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "MARKA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "ÜRÜN ADI";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 457);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1007, 241);
            this.dataGridView1.TabIndex = 27;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.urungunceladi);
            this.groupBox2.Controls.Add(this.urunguncelsatis);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.urungunceltarih);
            this.groupBox2.Controls.Add(this.urunguncelalis);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.urunguncelkategori);
            this.groupBox2.Controls.Add(this.Urunguncelmarka);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox2.Location = new System.Drawing.Point(640, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(365, 340);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "GÜNCELLEME VE SİLME İŞLEMİ";
            // 
            // urungunceladi
            // 
            this.urungunceladi.Location = new System.Drawing.Point(161, 35);
            this.urungunceladi.Name = "urungunceladi";
            this.urungunceladi.Size = new System.Drawing.Size(182, 30);
            this.urungunceladi.TabIndex = 26;
            // 
            // urunguncelsatis
            // 
            this.urunguncelsatis.Location = new System.Drawing.Point(161, 229);
            this.urunguncelsatis.Name = "urunguncelsatis";
            this.urunguncelsatis.Size = new System.Drawing.Size(182, 30);
            this.urunguncelsatis.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 25);
            this.label4.TabIndex = 25;
            this.label4.Text = "SATIŞ FİYATI";
            // 
            // urungunceltarih
            // 
            this.urungunceltarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.urungunceltarih.Location = new System.Drawing.Point(161, 276);
            this.urungunceltarih.Name = "urungunceltarih";
            this.urungunceltarih.Size = new System.Drawing.Size(182, 30);
            this.urungunceltarih.TabIndex = 24;
            // 
            // urunguncelalis
            // 
            this.urunguncelalis.Location = new System.Drawing.Point(161, 182);
            this.urunguncelalis.Name = "urunguncelalis";
            this.urunguncelalis.Size = new System.Drawing.Size(182, 30);
            this.urunguncelalis.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(89, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 25);
            this.label5.TabIndex = 23;
            this.label5.Text = "TARİH";
            // 
            // urunguncelkategori
            // 
            this.urunguncelkategori.FormattingEnabled = true;
            this.urunguncelkategori.Location = new System.Drawing.Point(161, 132);
            this.urunguncelkategori.Name = "urunguncelkategori";
            this.urunguncelkategori.Size = new System.Drawing.Size(182, 33);
            this.urunguncelkategori.TabIndex = 16;
            // 
            // Urunguncelmarka
            // 
            this.Urunguncelmarka.FormattingEnabled = true;
            this.Urunguncelmarka.Location = new System.Drawing.Point(161, 82);
            this.Urunguncelmarka.Name = "Urunguncelmarka";
            this.Urunguncelmarka.Size = new System.Drawing.Size(182, 33);
            this.Urunguncelmarka.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "ALIŞ FİYATI";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(45, 134);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 25);
            this.label9.TabIndex = 7;
            this.label9.Text = "KATEGORİ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(76, 86);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 25);
            this.label10.TabIndex = 6;
            this.label10.Text = "MARKA";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(55, 38);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(105, 25);
            this.label13.TabIndex = 5;
            this.label13.Text = "ÜRÜN ADI";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Snow;
            this.button2.Image = global::Stok.WinFormUI.Properties.Resources.back21;
            this.button2.Location = new System.Drawing.Point(413, 269);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(180, 74);
            this.button2.TabIndex = 33;
            this.button2.Text = "Admin Sayfası";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Snow;
            this.button1.Image = global::Stok.WinFormUI.Properties.Resources.back21;
            this.button1.Location = new System.Drawing.Point(413, 189);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 74);
            this.button1.TabIndex = 34;
            this.button1.Text = "Personel Sayfası";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UrunSayfasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Stok.WinFormUI.Properties.Resources._7;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1016, 699);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.urunarama);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UrunSayfasi";
            this.Text = "ÜRÜN SAYFASI";
            this.Load += new System.EventHandler(this.UrunSayfasi_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button uruntemiz;
        private System.Windows.Forms.Button urunguncel;
        private System.Windows.Forms.Button urunsilme;
        private System.Windows.Forms.Button urunekle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox urunarama;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker UrunTarih;
        private System.Windows.Forms.TextBox UrunAlis;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox UrunKategori;
        private System.Windows.Forms.ComboBox Urunmarka;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox Uruneklead;
        private System.Windows.Forms.TextBox UrunSatis;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox urungunceladi;
        private System.Windows.Forms.TextBox urunguncelsatis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker urungunceltarih;
        private System.Windows.Forms.TextBox urunguncelalis;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox urunguncelkategori;
        private System.Windows.Forms.ComboBox Urunguncelmarka;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}
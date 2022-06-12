namespace Stok.WinFormUI
{
    partial class StokSayfasi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StokSayfasi));
            this.label7 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.stoktarih = new System.Windows.Forms.DateTimePicker();
            this.stokadet = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.stokkategori = new System.Windows.Forms.ComboBox();
            this.stokmarka = new System.Windows.Forms.ComboBox();
            this.stokurun = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.stokguncelurun = new System.Windows.Forms.ComboBox();
            this.stokgunceltarih = new System.Windows.Forms.DateTimePicker();
            this.stokgunceladet = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.stokguncelkategori = new System.Windows.Forms.ComboBox();
            this.stokguncelmarka = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.stoktemizle = new System.Windows.Forms.Button();
            this.stokguncel = new System.Windows.Forms.Button();
            this.stoksil = new System.Windows.Forms.Button();
            this.stokekleme = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(476, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 25);
            this.label7.TabIndex = 23;
            this.label7.Text = "Arama";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(420, 68);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(182, 30);
            this.textBox5.TabIndex = 20;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.stoktarih);
            this.groupBox1.Controls.Add(this.stokadet);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.stokkategori);
            this.groupBox1.Controls.Add(this.stokmarka);
            this.groupBox1.Controls.Add(this.stokurun);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(14, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(365, 329);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "EKLEME İŞLEMİ";
            // 
            // stoktarih
            // 
            this.stoktarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.stoktarih.Location = new System.Drawing.Point(161, 270);
            this.stoktarih.Name = "stoktarih";
            this.stoktarih.Size = new System.Drawing.Size(182, 30);
            this.stoktarih.TabIndex = 24;
            // 
            // stokadet
            // 
            this.stokadet.Location = new System.Drawing.Point(161, 225);
            this.stokadet.Name = "stokadet";
            this.stokadet.Size = new System.Drawing.Size(182, 30);
            this.stokadet.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(84, 272);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 25);
            this.label12.TabIndex = 23;
            this.label12.Text = "TARİH";
            // 
            // stokkategori
            // 
            this.stokkategori.FormattingEnabled = true;
            this.stokkategori.Location = new System.Drawing.Point(161, 177);
            this.stokkategori.Name = "stokkategori";
            this.stokkategori.Size = new System.Drawing.Size(182, 33);
            this.stokkategori.TabIndex = 16;
            // 
            // stokmarka
            // 
            this.stokmarka.FormattingEnabled = true;
            this.stokmarka.Location = new System.Drawing.Point(161, 129);
            this.stokmarka.Name = "stokmarka";
            this.stokmarka.Size = new System.Drawing.Size(182, 33);
            this.stokmarka.TabIndex = 15;
            // 
            // stokurun
            // 
            this.stokurun.FormattingEnabled = true;
            this.stokurun.Location = new System.Drawing.Point(161, 81);
            this.stokurun.Name = "stokurun";
            this.stokurun.Size = new System.Drawing.Size(182, 33);
            this.stokurun.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 225);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 25);
            this.label8.TabIndex = 9;
            this.label8.Text = "STOK ADEDİ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "KATEGORİ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "MARKA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "ÜRÜN";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(5, 446);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1007, 241);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.stokguncelurun);
            this.groupBox2.Controls.Add(this.stokgunceltarih);
            this.groupBox2.Controls.Add(this.stokgunceladet);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.stokguncelkategori);
            this.groupBox2.Controls.Add(this.stokguncelmarka);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox2.Location = new System.Drawing.Point(639, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(365, 329);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "GÜNCELLEME VE SİLME İŞLEMİ";
            // 
            // stokguncelurun
            // 
            this.stokguncelurun.FormattingEnabled = true;
            this.stokguncelurun.Location = new System.Drawing.Point(161, 81);
            this.stokguncelurun.Name = "stokguncelurun";
            this.stokguncelurun.Size = new System.Drawing.Size(182, 33);
            this.stokguncelurun.TabIndex = 25;
            // 
            // stokgunceltarih
            // 
            this.stokgunceltarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.stokgunceltarih.Location = new System.Drawing.Point(161, 270);
            this.stokgunceltarih.Name = "stokgunceltarih";
            this.stokgunceltarih.Size = new System.Drawing.Size(182, 30);
            this.stokgunceltarih.TabIndex = 24;
            // 
            // stokgunceladet
            // 
            this.stokgunceladet.Location = new System.Drawing.Point(161, 225);
            this.stokgunceladet.Name = "stokgunceladet";
            this.stokgunceladet.Size = new System.Drawing.Size(182, 30);
            this.stokgunceladet.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 25);
            this.label4.TabIndex = 23;
            this.label4.Text = "TARİH";
            // 
            // stokguncelkategori
            // 
            this.stokguncelkategori.FormattingEnabled = true;
            this.stokguncelkategori.Location = new System.Drawing.Point(161, 177);
            this.stokguncelkategori.Name = "stokguncelkategori";
            this.stokguncelkategori.Size = new System.Drawing.Size(182, 33);
            this.stokguncelkategori.TabIndex = 16;
            // 
            // stokguncelmarka
            // 
            this.stokguncelmarka.FormattingEnabled = true;
            this.stokguncelmarka.Location = new System.Drawing.Point(161, 129);
            this.stokguncelmarka.Name = "stokguncelmarka";
            this.stokguncelmarka.Size = new System.Drawing.Size(182, 33);
            this.stokguncelmarka.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "STOK ADEDİ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 25);
            this.label6.TabIndex = 7;
            this.label6.Text = "KATEGORİ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(71, 131);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 25);
            this.label9.TabIndex = 6;
            this.label9.Text = "MARKA";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(88, 84);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 25);
            this.label10.TabIndex = 5;
            this.label10.Text = "ÜRÜN";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.stoktemizle);
            this.panel1.Controls.Add(this.stokguncel);
            this.panel1.Controls.Add(this.stoksil);
            this.panel1.Controls.Add(this.stokekleme);
            this.panel1.Location = new System.Drawing.Point(13, 349);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(991, 86);
            this.panel1.TabIndex = 26;
            // 
            // stoktemizle
            // 
            this.stoktemizle.BackColor = System.Drawing.Color.Snow;
            this.stoktemizle.Image = global::Stok.WinFormUI.Properties.Resources.clear;
            this.stoktemizle.Location = new System.Drawing.Point(719, 5);
            this.stoktemizle.Name = "stoktemizle";
            this.stoktemizle.Size = new System.Drawing.Size(168, 74);
            this.stoktemizle.TabIndex = 7;
            this.stoktemizle.Text = "TEMİZLE";
            this.stoktemizle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.stoktemizle.UseVisualStyleBackColor = false;
            this.stoktemizle.Click += new System.EventHandler(this.stoktemizle_Click);
            // 
            // stokguncel
            // 
            this.stokguncel.BackColor = System.Drawing.Color.Snow;
            this.stokguncel.Image = global::Stok.WinFormUI.Properties.Resources.update;
            this.stokguncel.Location = new System.Drawing.Point(495, 5);
            this.stokguncel.Name = "stokguncel";
            this.stokguncel.Size = new System.Drawing.Size(196, 74);
            this.stokguncel.TabIndex = 6;
            this.stokguncel.Text = "GÜNCELLE";
            this.stokguncel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.stokguncel.UseVisualStyleBackColor = false;
            this.stokguncel.Click += new System.EventHandler(this.stokguncel_Click);
            // 
            // stoksil
            // 
            this.stoksil.BackColor = System.Drawing.Color.Snow;
            this.stoksil.Image = global::Stok.WinFormUI.Properties.Resources.delete1;
            this.stoksil.Location = new System.Drawing.Point(299, 5);
            this.stoksil.Name = "stoksil";
            this.stoksil.Size = new System.Drawing.Size(168, 74);
            this.stoksil.TabIndex = 5;
            this.stoksil.Text = "SİLME";
            this.stoksil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.stoksil.UseVisualStyleBackColor = false;
            this.stoksil.Click += new System.EventHandler(this.stoksil_Click);
            // 
            // stokekleme
            // 
            this.stokekleme.BackColor = System.Drawing.Color.Snow;
            this.stokekleme.Image = global::Stok.WinFormUI.Properties.Resources.add64;
            this.stokekleme.Location = new System.Drawing.Point(103, 5);
            this.stokekleme.Name = "stokekleme";
            this.stokekleme.Size = new System.Drawing.Size(168, 74);
            this.stokekleme.TabIndex = 0;
            this.stokekleme.Text = "EKLEME";
            this.stokekleme.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.stokekleme.UseVisualStyleBackColor = false;
            this.stokekleme.Click += new System.EventHandler(this.stokekleme_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Snow;
            this.button2.Image = global::Stok.WinFormUI.Properties.Resources.back21;
            this.button2.Location = new System.Drawing.Point(420, 247);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(180, 74);
            this.button2.TabIndex = 27;
            this.button2.Text = "Admin Sayfası";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Snow;
            this.button1.Image = global::Stok.WinFormUI.Properties.Resources.back21;
            this.button1.Location = new System.Drawing.Point(420, 167);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 74);
            this.button1.TabIndex = 28;
            this.button1.Text = "Personel Sayfası";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // StokSayfasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Stok.WinFormUI.Properties.Resources._7;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1016, 701);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StokSayfasi";
            this.Text = "STOK SAYFASI";
            this.Load += new System.EventHandler(this.StokSayfasi_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker stoktarih;
        private System.Windows.Forms.TextBox stokadet;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox stokkategori;
        private System.Windows.Forms.ComboBox stokmarka;
        private System.Windows.Forms.ComboBox stokurun;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker stokgunceltarih;
        private System.Windows.Forms.TextBox stokgunceladet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox stokguncelkategori;
        private System.Windows.Forms.ComboBox stokguncelmarka;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button stoktemizle;
        private System.Windows.Forms.Button stokguncel;
        private System.Windows.Forms.Button stoksil;
        private System.Windows.Forms.Button stokekleme;
        private System.Windows.Forms.ComboBox stokguncelurun;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}
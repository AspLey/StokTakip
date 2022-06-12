namespace Stok.WinFormUI
{
    partial class MarkaSayfasi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MarkaSayfasi));
            this.label7 = new System.Windows.Forms.Label();
            this.markasearch = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxeklekategori = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txteklemarka = new System.Windows.Forms.TextBox();
            this.txtekleacik = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbxguncelkategori = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtguncelmarka = new System.Windows.Forms.TextBox();
            this.txtguncelacik = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.markatemizle = new System.Windows.Forms.Button();
            this.markaguncel = new System.Windows.Forms.Button();
            this.markasil = new System.Windows.Forms.Button();
            this.markaekle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(471, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 25);
            this.label7.TabIndex = 17;
            this.label7.Text = "Arama";
            // 
            // markasearch
            // 
            this.markasearch.Location = new System.Drawing.Point(415, 55);
            this.markasearch.Name = "markasearch";
            this.markasearch.Size = new System.Drawing.Size(182, 30);
            this.markasearch.TabIndex = 14;
            this.markasearch.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cbxeklekategori);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txteklemarka);
            this.groupBox1.Controls.Add(this.txtekleacik);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(13, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(365, 262);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "EKLEME İŞLEMİ";
            // 
            // cbxeklekategori
            // 
            this.cbxeklekategori.FormattingEnabled = true;
            this.cbxeklekategori.Location = new System.Drawing.Point(140, 161);
            this.cbxeklekategori.Name = "cbxeklekategori";
            this.cbxeklekategori.Size = new System.Drawing.Size(182, 33);
            this.cbxeklekategori.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Kategori";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Açıklama";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Marka";
            // 
            // txteklemarka
            // 
            this.txteklemarka.Location = new System.Drawing.Point(140, 74);
            this.txteklemarka.Name = "txteklemarka";
            this.txteklemarka.Size = new System.Drawing.Size(182, 30);
            this.txteklemarka.TabIndex = 2;
            // 
            // txtekleacik
            // 
            this.txtekleacik.Location = new System.Drawing.Point(140, 118);
            this.txtekleacik.Name = "txtekleacik";
            this.txtekleacik.Size = new System.Drawing.Size(182, 30);
            this.txtekleacik.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.cbxguncelkategori);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtguncelmarka);
            this.groupBox2.Controls.Add(this.txtguncelacik);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox2.Location = new System.Drawing.Point(642, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(365, 262);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "GÜNCELLEME VE SİLME İŞLEMİ";
            // 
            // cbxguncelkategori
            // 
            this.cbxguncelkategori.FormattingEnabled = true;
            this.cbxguncelkategori.Location = new System.Drawing.Point(140, 158);
            this.cbxguncelkategori.Name = "cbxguncelkategori";
            this.cbxguncelkategori.Size = new System.Drawing.Size(182, 33);
            this.cbxguncelkategori.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Kategori";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Açıklama";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(67, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Marka";
            // 
            // txtguncelmarka
            // 
            this.txtguncelmarka.Location = new System.Drawing.Point(140, 71);
            this.txtguncelmarka.Name = "txtguncelmarka";
            this.txtguncelmarka.Size = new System.Drawing.Size(182, 30);
            this.txtguncelmarka.TabIndex = 9;
            // 
            // txtguncelacik
            // 
            this.txtguncelacik.Location = new System.Drawing.Point(140, 115);
            this.txtguncelacik.Name = "txtguncelacik";
            this.txtguncelacik.Size = new System.Drawing.Size(182, 30);
            this.txtguncelacik.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.markatemizle);
            this.panel1.Controls.Add(this.markaguncel);
            this.panel1.Controls.Add(this.markasil);
            this.panel1.Controls.Add(this.markaekle);
            this.panel1.Location = new System.Drawing.Point(13, 290);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(998, 86);
            this.panel1.TabIndex = 13;
            // 
            // markatemizle
            // 
            this.markatemizle.BackColor = System.Drawing.Color.Snow;
            this.markatemizle.Image = global::Stok.WinFormUI.Properties.Resources.clear;
            this.markatemizle.Location = new System.Drawing.Point(723, 5);
            this.markatemizle.Name = "markatemizle";
            this.markatemizle.Size = new System.Drawing.Size(168, 74);
            this.markatemizle.TabIndex = 7;
            this.markatemizle.Text = "TEMİZLE";
            this.markatemizle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.markatemizle.UseVisualStyleBackColor = false;
            this.markatemizle.Click += new System.EventHandler(this.markatemizle_Click);
            // 
            // markaguncel
            // 
            this.markaguncel.BackColor = System.Drawing.Color.Snow;
            this.markaguncel.Image = global::Stok.WinFormUI.Properties.Resources.update;
            this.markaguncel.Location = new System.Drawing.Point(499, 5);
            this.markaguncel.Name = "markaguncel";
            this.markaguncel.Size = new System.Drawing.Size(196, 74);
            this.markaguncel.TabIndex = 6;
            this.markaguncel.Text = "GÜNCELLE";
            this.markaguncel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.markaguncel.UseVisualStyleBackColor = false;
            this.markaguncel.Click += new System.EventHandler(this.markaguncel_Click);
            // 
            // markasil
            // 
            this.markasil.BackColor = System.Drawing.Color.Snow;
            this.markasil.Image = global::Stok.WinFormUI.Properties.Resources.delete1;
            this.markasil.Location = new System.Drawing.Point(303, 5);
            this.markasil.Name = "markasil";
            this.markasil.Size = new System.Drawing.Size(168, 74);
            this.markasil.TabIndex = 5;
            this.markasil.Text = "SİLME";
            this.markasil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.markasil.UseVisualStyleBackColor = false;
            this.markasil.Click += new System.EventHandler(this.markasil_Click);
            // 
            // markaekle
            // 
            this.markaekle.BackColor = System.Drawing.Color.Snow;
            this.markaekle.Image = global::Stok.WinFormUI.Properties.Resources.add64;
            this.markaekle.Location = new System.Drawing.Point(107, 5);
            this.markaekle.Name = "markaekle";
            this.markaekle.Size = new System.Drawing.Size(168, 74);
            this.markaekle.TabIndex = 0;
            this.markaekle.Text = "EKLEME";
            this.markaekle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.markaekle.UseVisualStyleBackColor = false;
            this.markaekle.Click += new System.EventHandler(this.markaekle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.IndianRed;
            this.dataGridView1.Location = new System.Drawing.Point(13, 386);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(998, 241);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Snow;
            this.button2.Image = global::Stok.WinFormUI.Properties.Resources.back21;
            this.button2.Location = new System.Drawing.Point(417, 209);
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
            this.button1.Location = new System.Drawing.Point(417, 129);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 74);
            this.button1.TabIndex = 19;
            this.button1.Text = "Personel Sayfası";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MarkaSayfasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Stok.WinFormUI.Properties.Resources._7;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1024, 647);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.markasearch);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MarkaSayfasi";
            this.Text = "MARKA SAYFASI";
            this.Load += new System.EventHandler(this.MarkaSayfasi_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox markasearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txteklemarka;
        private System.Windows.Forms.TextBox txtekleacik;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button markatemizle;
        private System.Windows.Forms.Button markaguncel;
        private System.Windows.Forms.Button markasil;
        private System.Windows.Forms.Button markaekle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbxeklekategori;
        private System.Windows.Forms.ComboBox cbxguncelkategori;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtguncelmarka;
        private System.Windows.Forms.TextBox txtguncelacik;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}
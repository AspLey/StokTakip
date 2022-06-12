
namespace Stok.WinFormUI
{
    partial class PersonelSayfasi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonelSayfasi));
            this.panel1 = new System.Windows.Forms.Panel();
            this.personeltemiz = new System.Windows.Forms.Button();
            this.personelguncel = new System.Windows.Forms.Button();
            this.personelsil = new System.Windows.Forms.Button();
            this.personelekle = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.personelarama = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.personelyetki = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.personelsifre = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.personeladsoyad = new System.Windows.Forms.TextBox();
            this.personelmaas = new System.Windows.Forms.TextBox();
            this.personelkullanici = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.personeladres = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.personelguncelsifre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.personelguncelad = new System.Windows.Forms.TextBox();
            this.personelguncelmaas = new System.Windows.Forms.TextBox();
            this.personelguncelkullanici = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.personelgunceladres = new System.Windows.Forms.TextBox();
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
            this.panel1.Controls.Add(this.personeltemiz);
            this.panel1.Controls.Add(this.personelguncel);
            this.panel1.Controls.Add(this.personelsil);
            this.panel1.Controls.Add(this.personelekle);
            this.panel1.Location = new System.Drawing.Point(13, 358);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(998, 86);
            this.panel1.TabIndex = 24;
            // 
            // personeltemiz
            // 
            this.personeltemiz.BackColor = System.Drawing.Color.Snow;
            this.personeltemiz.Image = global::Stok.WinFormUI.Properties.Resources.clear;
            this.personeltemiz.Location = new System.Drawing.Point(723, 5);
            this.personeltemiz.Name = "personeltemiz";
            this.personeltemiz.Size = new System.Drawing.Size(168, 74);
            this.personeltemiz.TabIndex = 7;
            this.personeltemiz.Text = "TEMİZLE";
            this.personeltemiz.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.personeltemiz.UseVisualStyleBackColor = false;
            this.personeltemiz.Click += new System.EventHandler(this.personeltemiz_Click);
            // 
            // personelguncel
            // 
            this.personelguncel.BackColor = System.Drawing.Color.Snow;
            this.personelguncel.Image = global::Stok.WinFormUI.Properties.Resources.update;
            this.personelguncel.Location = new System.Drawing.Point(499, 5);
            this.personelguncel.Name = "personelguncel";
            this.personelguncel.Size = new System.Drawing.Size(196, 74);
            this.personelguncel.TabIndex = 6;
            this.personelguncel.Text = "GÜNCELLE";
            this.personelguncel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.personelguncel.UseVisualStyleBackColor = false;
            this.personelguncel.Click += new System.EventHandler(this.personelguncel_Click);
            // 
            // personelsil
            // 
            this.personelsil.BackColor = System.Drawing.Color.Snow;
            this.personelsil.Image = global::Stok.WinFormUI.Properties.Resources.delete1;
            this.personelsil.Location = new System.Drawing.Point(303, 5);
            this.personelsil.Name = "personelsil";
            this.personelsil.Size = new System.Drawing.Size(168, 74);
            this.personelsil.TabIndex = 5;
            this.personelsil.Text = "SİLME";
            this.personelsil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.personelsil.UseVisualStyleBackColor = false;
            this.personelsil.Click += new System.EventHandler(this.personelsil_Click);
            // 
            // personelekle
            // 
            this.personelekle.BackColor = System.Drawing.Color.Snow;
            this.personelekle.Image = global::Stok.WinFormUI.Properties.Resources.add64;
            this.personelekle.Location = new System.Drawing.Point(107, 5);
            this.personelekle.Name = "personelekle";
            this.personelekle.Size = new System.Drawing.Size(168, 74);
            this.personelekle.TabIndex = 0;
            this.personelekle.Text = "EKLEME";
            this.personelekle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.personelekle.UseVisualStyleBackColor = false;
            this.personelekle.Click += new System.EventHandler(this.personelekle_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(484, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 25);
            this.label7.TabIndex = 29;
            this.label7.Text = "Arama";
            // 
            // personelarama
            // 
            this.personelarama.Location = new System.Drawing.Point(428, 67);
            this.personelarama.Name = "personelarama";
            this.personelarama.Size = new System.Drawing.Size(182, 30);
            this.personelarama.TabIndex = 26;
            this.personelarama.TextChanged += new System.EventHandler(this.personelarama_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.personelyetki);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.personelsifre);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.personeladsoyad);
            this.groupBox1.Controls.Add(this.personelmaas);
            this.groupBox1.Controls.Add(this.personelkullanici);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.personeladres);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(18, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(365, 334);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "EKLEME İŞLEMİ";
            // 
            // personelyetki
            // 
            this.personelyetki.FormattingEnabled = true;
            this.personelyetki.Location = new System.Drawing.Point(169, 266);
            this.personelyetki.Name = "personelyetki";
            this.personelyetki.Size = new System.Drawing.Size(182, 33);
            this.personelyetki.TabIndex = 20;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(93, 269);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 25);
            this.label13.TabIndex = 19;
            this.label13.Text = "YETKİ";
            // 
            // personelsifre
            // 
            this.personelsifre.Location = new System.Drawing.Point(172, 220);
            this.personelsifre.Name = "personelsifre";
            this.personelsifre.Size = new System.Drawing.Size(179, 30);
            this.personelsifre.TabIndex = 18;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(97, 223);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 25);
            this.label12.TabIndex = 17;
            this.label12.Text = "ŞİFRE";
            // 
            // personeladsoyad
            // 
            this.personeladsoyad.Location = new System.Drawing.Point(169, 36);
            this.personeladsoyad.Name = "personeladsoyad";
            this.personeladsoyad.Size = new System.Drawing.Size(182, 30);
            this.personeladsoyad.TabIndex = 16;
            // 
            // personelmaas
            // 
            this.personelmaas.Location = new System.Drawing.Point(172, 128);
            this.personelmaas.Name = "personelmaas";
            this.personelmaas.Size = new System.Drawing.Size(179, 30);
            this.personelmaas.TabIndex = 15;
            // 
            // personelkullanici
            // 
            this.personelkullanici.Location = new System.Drawing.Point(172, 174);
            this.personelkullanici.Name = "personelkullanici";
            this.personelkullanici.Size = new System.Drawing.Size(179, 30);
            this.personelkullanici.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 177);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(153, 25);
            this.label9.TabIndex = 11;
            this.label9.Text = "KULLANICI ADI";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(95, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 25);
            this.label8.TabIndex = 9;
            this.label8.Text = "MAAŞ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "ADRES";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "AD SOYAD";
            // 
            // personeladres
            // 
            this.personeladres.Location = new System.Drawing.Point(172, 82);
            this.personeladres.Name = "personeladres";
            this.personeladres.Size = new System.Drawing.Size(179, 30);
            this.personeladres.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 445);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1007, 241);
            this.dataGridView1.TabIndex = 25;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.personelguncelsifre);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.personelguncelad);
            this.groupBox2.Controls.Add(this.personelguncelmaas);
            this.groupBox2.Controls.Add(this.personelguncelkullanici);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.personelgunceladres);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox2.Location = new System.Drawing.Point(648, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(365, 334);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "GÜNCELLEME İŞLEMİ";
            // 
            // personelguncelsifre
            // 
            this.personelguncelsifre.Location = new System.Drawing.Point(172, 244);
            this.personelguncelsifre.Name = "personelguncelsifre";
            this.personelguncelsifre.Size = new System.Drawing.Size(179, 30);
            this.personelguncelsifre.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(97, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 25);
            this.label4.TabIndex = 17;
            this.label4.Text = "ŞİFRE";
            // 
            // personelguncelad
            // 
            this.personelguncelad.Location = new System.Drawing.Point(169, 60);
            this.personelguncelad.Name = "personelguncelad";
            this.personelguncelad.Size = new System.Drawing.Size(182, 30);
            this.personelguncelad.TabIndex = 16;
            // 
            // personelguncelmaas
            // 
            this.personelguncelmaas.Location = new System.Drawing.Point(172, 152);
            this.personelguncelmaas.Name = "personelguncelmaas";
            this.personelguncelmaas.Size = new System.Drawing.Size(179, 30);
            this.personelguncelmaas.TabIndex = 15;
            // 
            // personelguncelkullanici
            // 
            this.personelguncelkullanici.Location = new System.Drawing.Point(172, 198);
            this.personelguncelkullanici.Name = "personelguncelkullanici";
            this.personelguncelkullanici.Size = new System.Drawing.Size(179, 30);
            this.personelguncelkullanici.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "KULLANICI ADI";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(95, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "MAAŞ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(86, 109);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 25);
            this.label10.TabIndex = 6;
            this.label10.Text = "ADRES";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(47, 60);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(116, 25);
            this.label11.TabIndex = 5;
            this.label11.Text = "AD SOYAD";
            // 
            // personelgunceladres
            // 
            this.personelgunceladres.Location = new System.Drawing.Point(172, 106);
            this.personelgunceladres.Name = "personelgunceladres";
            this.personelgunceladres.Size = new System.Drawing.Size(179, 30);
            this.personelgunceladres.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Snow;
            this.button2.Image = global::Stok.WinFormUI.Properties.Resources.back21;
            this.button2.Location = new System.Drawing.Point(428, 270);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(180, 74);
            this.button2.TabIndex = 30;
            this.button2.Text = "Admin Sayfası";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Snow;
            this.button1.Image = global::Stok.WinFormUI.Properties.Resources.back21;
            this.button1.Location = new System.Drawing.Point(428, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 74);
            this.button1.TabIndex = 31;
            this.button1.Text = "Personel Sayfası";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PersonelSayfasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Stok.WinFormUI.Properties.Resources._7;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1024, 693);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.personelarama);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PersonelSayfasi";
            this.Text = "PersonelSayfasi";
            this.Load += new System.EventHandler(this.PersonelSayfasi_Load);
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
        private System.Windows.Forms.Button personeltemiz;
        private System.Windows.Forms.Button personelguncel;
        private System.Windows.Forms.Button personelsil;
        private System.Windows.Forms.Button personelekle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox personelarama;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox personelyetki;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox personelsifre;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox personeladsoyad;
        private System.Windows.Forms.TextBox personelmaas;
        private System.Windows.Forms.TextBox personelkullanici;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox personeladres;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox personelguncelsifre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox personelguncelad;
        private System.Windows.Forms.TextBox personelguncelmaas;
        private System.Windows.Forms.TextBox personelguncelkullanici;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox personelgunceladres;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}
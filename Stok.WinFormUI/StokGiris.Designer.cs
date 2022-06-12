namespace Stok.WinFormUI
{
    partial class StokGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StokGiris));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnpersgiris = new System.Windows.Forms.Button();
            this.tbxstokperssifre = new System.Windows.Forms.TextBox();
            this.tbxstokperskullanici = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Sifregoster = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(678, 466);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Stok.WinFormUI.Properties.Resources.analogo1;
            this.pictureBox1.Location = new System.Drawing.Point(3, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(338, 444);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Sifregoster);
            this.groupBox2.Controls.Add(this.btnpersgiris);
            this.groupBox2.Controls.Add(this.tbxstokperssifre);
            this.groupBox2.Controls.Add(this.tbxstokperskullanici);
            this.groupBox2.Controls.Add(this.pictureBox4);
            this.groupBox2.Controls.Add(this.pictureBox3);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(362, 46);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(301, 384);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ADMİN VE PERSONEL GİRİŞİ";
            // 
            // btnpersgiris
            // 
            this.btnpersgiris.BackColor = System.Drawing.Color.Transparent;
            this.btnpersgiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnpersgiris.ForeColor = System.Drawing.Color.Black;
            this.btnpersgiris.Location = new System.Drawing.Point(68, 332);
            this.btnpersgiris.Name = "btnpersgiris";
            this.btnpersgiris.Size = new System.Drawing.Size(165, 35);
            this.btnpersgiris.TabIndex = 9;
            this.btnpersgiris.Text = "Giriş";
            this.btnpersgiris.UseVisualStyleBackColor = false;
            this.btnpersgiris.Click += new System.EventHandler(this.btnpersgiris_Click);
            // 
            // tbxstokperssifre
            // 
            this.tbxstokperssifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxstokperssifre.Location = new System.Drawing.Point(47, 254);
            this.tbxstokperssifre.Multiline = true;
            this.tbxstokperssifre.Name = "tbxstokperssifre";
            this.tbxstokperssifre.PasswordChar = '*';
            this.tbxstokperssifre.Size = new System.Drawing.Size(207, 30);
            this.tbxstokperssifre.TabIndex = 8;
            this.tbxstokperssifre.Text = "ŞİFRE";
            // 
            // tbxstokperskullanici
            // 
            this.tbxstokperskullanici.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxstokperskullanici.Location = new System.Drawing.Point(47, 205);
            this.tbxstokperskullanici.Name = "tbxstokperskullanici";
            this.tbxstokperskullanici.Size = new System.Drawing.Size(207, 30);
            this.tbxstokperskullanici.TabIndex = 7;
            this.tbxstokperskullanici.Text = "KULLANICI ADI";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Stok.WinFormUI.Properties.Resources.erkek;
            this.pictureBox4.Location = new System.Drawing.Point(134, 21);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(161, 169);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Stok.WinFormUI.Properties.Resources.kadin;
            this.pictureBox3.Location = new System.Drawing.Point(8, 21);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(161, 169);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // Sifregoster
            // 
            this.Sifregoster.AutoSize = true;
            this.Sifregoster.Location = new System.Drawing.Point(47, 305);
            this.Sifregoster.Name = "Sifregoster";
            this.Sifregoster.Size = new System.Drawing.Size(144, 21);
            this.Sifregoster.TabIndex = 10;
            this.Sifregoster.Text = "ŞİFREYİ GÖSTER";
            this.Sifregoster.UseVisualStyleBackColor = true;
            this.Sifregoster.CheckedChanged += new System.EventHandler(this.Sifregoster_CheckedChanged);
            // 
            // StokGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Stok.WinFormUI.Properties.Resources._2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(706, 490);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StokGiris";
            this.Text = "Stok Takip Giriş Paneli";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnpersgiris;
        private System.Windows.Forms.TextBox tbxstokperssifre;
        private System.Windows.Forms.TextBox tbxstokperskullanici;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox Sifregoster;
    }
}


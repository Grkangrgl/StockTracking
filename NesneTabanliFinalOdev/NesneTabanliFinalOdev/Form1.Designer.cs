
namespace NesneTabanliFinalOdev
{
    partial class Form1
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
            this.UrunSil = new System.Windows.Forms.Button();
            this.UrunKaydet = new System.Windows.Forms.Button();
            this.TxtStokMiktarı = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtUrunFiyat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtUrunAd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtUrunID = new System.Windows.Forms.TextBox();
            this.StokMiktarı = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtUrunAdArama = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // UrunSil
            // 
            this.UrunSil.Location = new System.Drawing.Point(337, 6);
            this.UrunSil.Name = "UrunSil";
            this.UrunSil.Size = new System.Drawing.Size(103, 104);
            this.UrunSil.TabIndex = 33;
            this.UrunSil.Text = "Sil";
            this.UrunSil.UseVisualStyleBackColor = true;
            this.UrunSil.Click += new System.EventHandler(this.UrunSil_Click);
            // 
            // UrunKaydet
            // 
            this.UrunKaydet.Location = new System.Drawing.Point(228, 8);
            this.UrunKaydet.Name = "UrunKaydet";
            this.UrunKaydet.Size = new System.Drawing.Size(103, 104);
            this.UrunKaydet.TabIndex = 31;
            this.UrunKaydet.Text = "Kaydet";
            this.UrunKaydet.UseVisualStyleBackColor = true;
            this.UrunKaydet.Click += new System.EventHandler(this.UrunKaydet_Click);
            // 
            // TxtStokMiktarı
            // 
            this.TxtStokMiktarı.Location = new System.Drawing.Point(122, 90);
            this.TxtStokMiktarı.Name = "TxtStokMiktarı";
            this.TxtStokMiktarı.Size = new System.Drawing.Size(100, 22);
            this.TxtStokMiktarı.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "ÜrünNo";
            // 
            // TxtUrunFiyat
            // 
            this.TxtUrunFiyat.Location = new System.Drawing.Point(122, 62);
            this.TxtUrunFiyat.Name = "TxtUrunFiyat";
            this.TxtUrunFiyat.Size = new System.Drawing.Size(100, 22);
            this.TxtUrunFiyat.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 24;
            this.label2.Text = "ÜrünAd";
            // 
            // TxtUrunAd
            // 
            this.TxtUrunAd.Location = new System.Drawing.Point(122, 34);
            this.TxtUrunAd.Name = "TxtUrunAd";
            this.TxtUrunAd.Size = new System.Drawing.Size(100, 22);
            this.TxtUrunAd.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 25;
            this.label4.Text = "BirimFiyat";
            // 
            // TxtUrunID
            // 
            this.TxtUrunID.Location = new System.Drawing.Point(122, 6);
            this.TxtUrunID.Name = "TxtUrunID";
            this.TxtUrunID.Size = new System.Drawing.Size(100, 22);
            this.TxtUrunID.TabIndex = 27;
            // 
            // StokMiktarı
            // 
            this.StokMiktarı.AutoSize = true;
            this.StokMiktarı.Location = new System.Drawing.Point(12, 93);
            this.StokMiktarı.Name = "StokMiktarı";
            this.StokMiktarı.Size = new System.Drawing.Size(77, 17);
            this.StokMiktarı.TabIndex = 26;
            this.StokMiktarı.Text = "StokMiktarı";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 118);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(921, 415);
            this.dataGridView1.TabIndex = 34;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(446, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 17);
            this.label3.TabIndex = 35;
            this.label3.Text = "Arama Yapılacak Ürün Adı";
            // 
            // TxtUrunAdArama
            // 
            this.TxtUrunAdArama.Location = new System.Drawing.Point(625, 47);
            this.TxtUrunAdArama.Name = "TxtUrunAdArama";
            this.TxtUrunAdArama.Size = new System.Drawing.Size(172, 22);
            this.TxtUrunAdArama.TabIndex = 36;
            this.TxtUrunAdArama.TextChanged += new System.EventHandler(this.TxtUrunAdArama_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 607);
            this.Controls.Add(this.TxtUrunAdArama);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.UrunSil);
            this.Controls.Add(this.UrunKaydet);
            this.Controls.Add(this.TxtStokMiktarı);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtUrunFiyat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtUrunAd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtUrunID);
            this.Controls.Add(this.StokMiktarı);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UrunSil;
        private System.Windows.Forms.Button UrunKaydet;
        private System.Windows.Forms.TextBox TxtStokMiktarı;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtUrunFiyat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtUrunAd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtUrunID;
        private System.Windows.Forms.Label StokMiktarı;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtUrunAdArama;
    }
}


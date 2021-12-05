namespace Ucaksavar
{
    /*****************************************************
* *         Fakülte Adı : Haşim Gürdamar Bilgisayar ve Bilişim Bilimleri Fakültesi
* *         Bölüm : Bilişim Mühendisliği
* *         Öğrenci Adı : Buğra Ömer
* *         Öğrenci Soyadı : POLAT
* *         Öğrenci numarası : B171200052
* *         Sınıf : 1-A
* *         Öğretim Üyesi : Dr. Muhammed KOTAN
* *                     
* *****************************************************/
    partial class AnaForm
    {
        private System.ComponentModel.IContainer components = null;
      
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.oyunBaslatmaLabel = new System.Windows.Forms.Label();
            this.ucaksavarHareketLabel = new System.Windows.Forms.Label();
            this.atesLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.oyunPaneli = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.oyunPaneli.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // oyunBaslatmaLabel
            // 
            this.oyunBaslatmaLabel.AutoSize = true;
            this.oyunBaslatmaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.oyunBaslatmaLabel.ForeColor = System.Drawing.Color.White;
            this.oyunBaslatmaLabel.Location = new System.Drawing.Point(12, 9);
            this.oyunBaslatmaLabel.Name = "oyunBaslatmaLabel";
            this.oyunBaslatmaLabel.Size = new System.Drawing.Size(323, 17);
            this.oyunBaslatmaLabel.TabIndex = 1;
            this.oyunBaslatmaLabel.Text = "Oyunu başlatmak için ENTER tuşuna basın.";
            // 
            // ucaksavarHareketLabel
            // 
            this.ucaksavarHareketLabel.AutoSize = true;
            this.ucaksavarHareketLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ucaksavarHareketLabel.ForeColor = System.Drawing.Color.White;
            this.ucaksavarHareketLabel.Location = new System.Drawing.Point(12, 26);
            this.ucaksavarHareketLabel.Name = "ucaksavarHareketLabel";
            this.ucaksavarHareketLabel.Size = new System.Drawing.Size(503, 17);
            this.ucaksavarHareketLabel.TabIndex = 2;
            this.ucaksavarHareketLabel.Text = "Uçaksavarı hareket ettirmek için SAĞ/SOL YÖN TUŞLARINI kullanın.";
            // 
            // atesLabel
            // 
            this.atesLabel.AutoSize = true;
            this.atesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.atesLabel.ForeColor = System.Drawing.Color.White;
            this.atesLabel.Location = new System.Drawing.Point(12, 43);
            this.atesLabel.Name = "atesLabel";
            this.atesLabel.Size = new System.Drawing.Size(229, 17);
            this.atesLabel.TabIndex = 4;
            this.atesLabel.Text = "Ateş etmek için Space basınız.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Durdurmak için ESC tuşuna basınız.";
            // 
            // oyunPaneli
            // 
            this.oyunPaneli.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.oyunPaneli.BackColor = System.Drawing.Color.PaleTurquoise;
            this.oyunPaneli.Controls.Add(this.panel1);
            this.oyunPaneli.Location = new System.Drawing.Point(-1, 80);
            this.oyunPaneli.Name = "oyunPaneli";
            this.oyunPaneli.Size = new System.Drawing.Size(915, 557);
            this.oyunPaneli.TabIndex = 0;
            this.oyunPaneli.Paint += new System.Windows.Forms.PaintEventHandler(this.oyunPaneli_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(338, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(227, 277);
            this.panel1.TabIndex = 0;
            this.panel1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gray;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(33, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "EN İYİ PUANLAR";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Window;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(573, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(301, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Score 30 olduğunda uçak gelme hızı ve harekte hızı artacaktır.";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Crimson;
            this.ClientSize = new System.Drawing.Size(914, 637);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.atesLabel);
            this.Controls.Add(this.ucaksavarHareketLabel);
            this.Controls.Add(this.oyunBaslatmaLabel);
            this.Controls.Add(this.oyunPaneli);
            this.KeyPreview = true;
            this.Name = "AnaForm";
            this.Text = "UÇAKSAVAR";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AnaForm_KeyDown);
            this.oyunPaneli.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.Label oyunBaslatmaLabel;
        private System.Windows.Forms.Label ucaksavarHareketLabel;
        private System.Windows.Forms.Label atesLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel oyunPaneli;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}


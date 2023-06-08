namespace Ders_Gecen_Kalan_WinForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            rbtnGecti = new RadioButton();
            rbtnKaldı = new RadioButton();
            btnEkle = new Button();
            label3 = new Label();
            label4 = new Label();
            lsbGecenler = new ListBox();
            lsbKalanlar = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 35);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 0;
            label1.Text = "Adı: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 70);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 1;
            label2.Text = "Soyadı: ";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(91, 32);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(160, 23);
            txtAd.TabIndex = 2;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(91, 67);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(160, 23);
            txtSoyad.TabIndex = 3;
            // 
            // rbtnGecti
            // 
            rbtnGecti.AutoSize = true;
            rbtnGecti.Checked = true;
            rbtnGecti.Location = new Point(38, 124);
            rbtnGecti.Name = "rbtnGecti";
            rbtnGecti.Size = new Size(52, 19);
            rbtnGecti.TabIndex = 4;
            rbtnGecti.TabStop = true;
            rbtnGecti.Text = "Gecti";
            rbtnGecti.UseVisualStyleBackColor = true;
            // 
            // rbtnKaldı
            // 
            rbtnKaldı.AutoSize = true;
            rbtnKaldı.Location = new Point(147, 124);
            rbtnKaldı.Name = "rbtnKaldı";
            rbtnKaldı.Size = new Size(51, 19);
            rbtnKaldı.TabIndex = 5;
            rbtnKaldı.Text = "Kaldı";
            rbtnKaldı.UseVisualStyleBackColor = true;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(39, 172);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(213, 23);
            btnEkle.TabIndex = 6;
            btnEkle.Text = "EKLE";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(348, 32);
            label3.Name = "label3";
            label3.Size = new Size(82, 15);
            label3.TabIndex = 7;
            label3.Text = "Dersi Gecenler";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(488, 32);
            label4.Name = "label4";
            label4.Size = new Size(92, 15);
            label4.TabIndex = 8;
            label4.Text = "Dersten Kalanlar";
            // 
            // lsbGecenler
            // 
            lsbGecenler.FormattingEnabled = true;
            lsbGecenler.ItemHeight = 15;
            lsbGecenler.Location = new Point(348, 56);
            lsbGecenler.Name = "lsbGecenler";
            lsbGecenler.Size = new Size(120, 139);
            lsbGecenler.TabIndex = 9;
            // 
            // lsbKalanlar
            // 
            lsbKalanlar.FormattingEnabled = true;
            lsbKalanlar.ItemHeight = 15;
            lsbKalanlar.Location = new Point(488, 56);
            lsbKalanlar.Name = "lsbKalanlar";
            lsbKalanlar.Size = new Size(120, 139);
            lsbKalanlar.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(635, 229);
            Controls.Add(lsbKalanlar);
            Controls.Add(lsbGecenler);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnEkle);
            Controls.Add(rbtnKaldı);
            Controls.Add(rbtnGecti);
            Controls.Add(txtSoyad);
            Controls.Add(txtAd);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtAd;
        private TextBox txtSoyad;
        private RadioButton rbtnGecti;
        private RadioButton rbtnKaldı;
        private Button btnEkle;
        private Label label3;
        private Label label4;
        private ListBox lsbGecenler;
        private ListBox lsbKalanlar;
    }
}
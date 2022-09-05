
namespace YurtKayitOtomasyonu
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtograd = new System.Windows.Forms.TextBox();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.msktc = new System.Windows.Forms.MaskedTextBox();
            this.msktelefon = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mskdtarihi = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbbolum = new System.Windows.Forms.ComboBox();
            this.txtmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbodano = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtveli = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.mskvelitelefon = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.rchadres = new System.Windows.Forms.RichTextBox();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Öğrenci Ad:";
            // 
            // txtograd
            // 
            this.txtograd.BackColor = System.Drawing.Color.AliceBlue;
            this.txtograd.Location = new System.Drawing.Point(142, 29);
            this.txtograd.Name = "txtograd";
            this.txtograd.Size = new System.Drawing.Size(282, 25);
            this.txtograd.TabIndex = 1;
            // 
            // txtsoyad
            // 
            this.txtsoyad.BackColor = System.Drawing.Color.AliceBlue;
            this.txtsoyad.Location = new System.Drawing.Point(142, 74);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(282, 25);
            this.txtsoyad.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Öğrenci Soyad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "TC:";
            // 
            // msktc
            // 
            this.msktc.BackColor = System.Drawing.Color.AliceBlue;
            this.msktc.Location = new System.Drawing.Point(143, 116);
            this.msktc.Mask = "00000000000";
            this.msktc.Name = "msktc";
            this.msktc.Size = new System.Drawing.Size(281, 25);
            this.msktc.TabIndex = 6;
            this.msktc.ValidatingType = typeof(int);
            // 
            // msktelefon
            // 
            this.msktelefon.BackColor = System.Drawing.Color.AliceBlue;
            this.msktelefon.Location = new System.Drawing.Point(143, 159);
            this.msktelefon.Mask = "(999) 000-0000";
            this.msktelefon.Name = "msktelefon";
            this.msktelefon.Size = new System.Drawing.Size(281, 25);
            this.msktelefon.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Telefon:";
            // 
            // mskdtarihi
            // 
            this.mskdtarihi.BackColor = System.Drawing.Color.AliceBlue;
            this.mskdtarihi.Location = new System.Drawing.Point(143, 204);
            this.mskdtarihi.Mask = "00/00/0000";
            this.mskdtarihi.Name = "mskdtarihi";
            this.mskdtarihi.Size = new System.Drawing.Size(281, 25);
            this.mskdtarihi.TabIndex = 10;
            this.mskdtarihi.ValidatingType = typeof(System.DateTime);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Doğum Tarihi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "Öğrenci Bölümü:";
            // 
            // cmbbolum
            // 
            this.cmbbolum.BackColor = System.Drawing.Color.AliceBlue;
            this.cmbbolum.FormattingEnabled = true;
            this.cmbbolum.Location = new System.Drawing.Point(143, 249);
            this.cmbbolum.Name = "cmbbolum";
            this.cmbbolum.Size = new System.Drawing.Size(281, 26);
            this.cmbbolum.TabIndex = 13;
            // 
            // txtmail
            // 
            this.txtmail.BackColor = System.Drawing.Color.AliceBlue;
            this.txtmail.Location = new System.Drawing.Point(142, 291);
            this.txtmail.Name = "txtmail";
            this.txtmail.Size = new System.Drawing.Size(282, 25);
            this.txtmail.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(91, 294);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 18);
            this.label7.TabIndex = 14;
            this.label7.Text = "Mail:";
            // 
            // cmbodano
            // 
            this.cmbodano.BackColor = System.Drawing.Color.AliceBlue;
            this.cmbodano.FormattingEnabled = true;
            this.cmbodano.Location = new System.Drawing.Point(142, 334);
            this.cmbodano.Name = "cmbodano";
            this.cmbodano.Size = new System.Drawing.Size(281, 26);
            this.cmbodano.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(66, 337);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 18);
            this.label8.TabIndex = 16;
            this.label8.Text = "Oda No:";
            // 
            // txtveli
            // 
            this.txtveli.BackColor = System.Drawing.Color.AliceBlue;
            this.txtveli.Location = new System.Drawing.Point(142, 373);
            this.txtveli.Name = "txtveli";
            this.txtveli.Size = new System.Drawing.Size(282, 25);
            this.txtveli.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 378);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 18);
            this.label9.TabIndex = 18;
            this.label9.Text = "Veli Ad Soyad:";
            // 
            // mskvelitelefon
            // 
            this.mskvelitelefon.BackColor = System.Drawing.Color.AliceBlue;
            this.mskvelitelefon.Location = new System.Drawing.Point(142, 408);
            this.mskvelitelefon.Mask = "(999) 000-0000";
            this.mskvelitelefon.Name = "mskvelitelefon";
            this.mskvelitelefon.Size = new System.Drawing.Size(281, 25);
            this.mskvelitelefon.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(31, 411);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 18);
            this.label10.TabIndex = 20;
            this.label10.Text = "Veli Telefon:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(78, 449);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 18);
            this.label11.TabIndex = 22;
            this.label11.Text = "Adres:";
            // 
            // rchadres
            // 
            this.rchadres.BackColor = System.Drawing.Color.AliceBlue;
            this.rchadres.Location = new System.Drawing.Point(142, 446);
            this.rchadres.Name = "rchadres";
            this.rchadres.Size = new System.Drawing.Size(281, 53);
            this.rchadres.TabIndex = 23;
            this.rchadres.Text = "";
            // 
            // btnkaydet
            // 
            this.btnkaydet.BackColor = System.Drawing.Color.AliceBlue;
            this.btnkaydet.Location = new System.Drawing.Point(181, 505);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(203, 34);
            this.btnkaydet.TabIndex = 24;
            this.btnkaydet.Text = "Kaydet";
            this.btnkaydet.UseVisualStyleBackColor = false;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(43, 485);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 18);
            this.label12.TabIndex = 25;
            this.label12.Text = "label12";
            this.label12.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(445, 545);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnkaydet);
            this.Controls.Add(this.rchadres);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.mskvelitelefon);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtveli);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbodano);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtmail);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbbolum);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.mskdtarihi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.msktelefon);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.msktc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtsoyad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtograd);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Öğrenci Kayıt";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtograd;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox msktc;
        private System.Windows.Forms.MaskedTextBox msktelefon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mskdtarihi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbbolum;
        private System.Windows.Forms.TextBox txtmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbodano;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtveli;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox mskvelitelefon;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RichTextBox rchadres;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.Label label12;
    }
}


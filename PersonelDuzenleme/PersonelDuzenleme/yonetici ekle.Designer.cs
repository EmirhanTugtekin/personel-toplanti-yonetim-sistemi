namespace PersonelDuzenleme
{
    partial class yonetici_ekle
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
            this.btnYoneticiEkle = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtYeniYonBolumID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtYeniYonSoyad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtYeniYonAD = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnYoneticiEkle
            // 
            this.btnYoneticiEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYoneticiEkle.Location = new System.Drawing.Point(262, 303);
            this.btnYoneticiEkle.Name = "btnYoneticiEkle";
            this.btnYoneticiEkle.Size = new System.Drawing.Size(262, 47);
            this.btnYoneticiEkle.TabIndex = 21;
            this.btnYoneticiEkle.Text = "yönetici ekle";
            this.btnYoneticiEkle.UseVisualStyleBackColor = true;
            this.btnYoneticiEkle.Click += new System.EventHandler(this.btnYoneticiEkle_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(122, 211);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "bölüm ID:";
            // 
            // txtYeniYonBolumID
            // 
            this.txtYeniYonBolumID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYeniYonBolumID.Location = new System.Drawing.Point(262, 211);
            this.txtYeniYonBolumID.Margin = new System.Windows.Forms.Padding(4);
            this.txtYeniYonBolumID.Name = "txtYeniYonBolumID";
            this.txtYeniYonBolumID.Size = new System.Drawing.Size(262, 30);
            this.txtYeniYonBolumID.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(122, 143);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "soyad:";
            // 
            // txtYeniYonSoyad
            // 
            this.txtYeniYonSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYeniYonSoyad.Location = new System.Drawing.Point(262, 137);
            this.txtYeniYonSoyad.Margin = new System.Windows.Forms.Padding(4);
            this.txtYeniYonSoyad.Name = "txtYeniYonSoyad";
            this.txtYeniYonSoyad.Size = new System.Drawing.Size(262, 30);
            this.txtYeniYonSoyad.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(122, 72);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "ad:";
            // 
            // txtYeniYonAD
            // 
            this.txtYeniYonAD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYeniYonAD.Location = new System.Drawing.Point(262, 65);
            this.txtYeniYonAD.Margin = new System.Windows.Forms.Padding(4);
            this.txtYeniYonAD.Name = "txtYeniYonAD";
            this.txtYeniYonAD.Size = new System.Drawing.Size(262, 30);
            this.txtYeniYonAD.TabIndex = 11;
            // 
            // yonetici_ekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(640, 450);
            this.Controls.Add(this.btnYoneticiEkle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtYeniYonBolumID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtYeniYonSoyad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtYeniYonAD);
            this.Name = "yonetici_ekle";
            this.Text = "yonetici_ekle";
            this.Load += new System.EventHandler(this.yonetici_ekle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnYoneticiEkle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtYeniYonBolumID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtYeniYonSoyad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtYeniYonAD;
    }
}
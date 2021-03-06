namespace PersonelDuzenleme
{
    partial class Personel_Ekle
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
            this.txtyeniPersAD = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtyeniPersSOYAD = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtyeniPersUnvan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnPersEkle = new System.Windows.Forms.Button();
            this.mskyeniPersTlfn = new System.Windows.Forms.MaskedTextBox();
            this.txtYeniPersMail = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtyeniPersAD
            // 
            this.txtyeniPersAD.Location = new System.Drawing.Point(232, 64);
            this.txtyeniPersAD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtyeniPersAD.Name = "txtyeniPersAD";
            this.txtyeniPersAD.Size = new System.Drawing.Size(262, 28);
            this.txtyeniPersAD.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 139);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "soyad:";
            // 
            // txtyeniPersSOYAD
            // 
            this.txtyeniPersSOYAD.Location = new System.Drawing.Point(232, 133);
            this.txtyeniPersSOYAD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtyeniPersSOYAD.Name = "txtyeniPersSOYAD";
            this.txtyeniPersSOYAD.Size = new System.Drawing.Size(262, 28);
            this.txtyeniPersSOYAD.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 207);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "unvan:";
            // 
            // txtyeniPersUnvan
            // 
            this.txtyeniPersUnvan.Location = new System.Drawing.Point(232, 200);
            this.txtyeniPersUnvan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtyeniPersUnvan.Name = "txtyeniPersUnvan";
            this.txtyeniPersUnvan.Size = new System.Drawing.Size(262, 28);
            this.txtyeniPersUnvan.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(92, 270);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "telefon:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(92, 333);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "mail:";
            // 
            // btnPersEkle
            // 
            this.btnPersEkle.Location = new System.Drawing.Point(232, 407);
            this.btnPersEkle.Name = "btnPersEkle";
            this.btnPersEkle.Size = new System.Drawing.Size(262, 47);
            this.btnPersEkle.TabIndex = 10;
            this.btnPersEkle.Text = "personel ekle";
            this.btnPersEkle.UseVisualStyleBackColor = true;
            this.btnPersEkle.Click += new System.EventHandler(this.btnPersEkle_Click);
            // 
            // mskyeniPersTlfn
            // 
            this.mskyeniPersTlfn.Location = new System.Drawing.Point(232, 271);
            this.mskyeniPersTlfn.Mask = "(999) 000-0000";
            this.mskyeniPersTlfn.Name = "mskyeniPersTlfn";
            this.mskyeniPersTlfn.Size = new System.Drawing.Size(262, 28);
            this.mskyeniPersTlfn.TabIndex = 11;
            // 
            // txtYeniPersMail
            // 
            this.txtYeniPersMail.Location = new System.Drawing.Point(232, 329);
            this.txtYeniPersMail.Margin = new System.Windows.Forms.Padding(4);
            this.txtYeniPersMail.Name = "txtYeniPersMail";
            this.txtYeniPersMail.Size = new System.Drawing.Size(262, 28);
            this.txtYeniPersMail.TabIndex = 8;
            // 
            // Personel_Ekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(618, 510);
            this.Controls.Add(this.mskyeniPersTlfn);
            this.Controls.Add(this.btnPersEkle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtYeniPersMail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtyeniPersUnvan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtyeniPersSOYAD);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtyeniPersAD);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Personel_Ekle";
            this.Text = "Personel_Ekle";
            this.Load += new System.EventHandler(this.Personel_Ekle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtyeniPersAD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtyeniPersSOYAD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtyeniPersUnvan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnPersEkle;
        private System.Windows.Forms.MaskedTextBox mskyeniPersTlfn;
        private System.Windows.Forms.TextBox txtYeniPersMail;
    }
}
namespace ÇiftSayıYazdırma
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.girdi = new System.Windows.Forms.TextBox();
            this.sonucGoster = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(22, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bir Sayı Girin:";
            // 
            // girdi
            // 
            this.girdi.Location = new System.Drawing.Point(166, 157);
            this.girdi.Name = "girdi";
            this.girdi.Size = new System.Drawing.Size(149, 22);
            this.girdi.TabIndex = 1;
            // 
            // sonucGoster
            // 
            this.sonucGoster.Location = new System.Drawing.Point(166, 211);
            this.sonucGoster.Name = "sonucGoster";
            this.sonucGoster.Size = new System.Drawing.Size(152, 36);
            this.sonucGoster.TabIndex = 2;
            this.sonucGoster.Text = "Göster";
            this.sonucGoster.UseVisualStyleBackColor = true;
            this.sonucGoster.Click += new System.EventHandler(this.sonucGoster_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(362, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(152, 404);
            this.listBox1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 422);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.sonucGoster);
            this.Controls.Add(this.girdi);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Çift Sayı Yazdırma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox girdi;
        private System.Windows.Forms.Button sonucGoster;
        private System.Windows.Forms.ListBox listBox1;
    }
}


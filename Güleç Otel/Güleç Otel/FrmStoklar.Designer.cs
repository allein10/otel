
namespace Güleç_Otel
{
    partial class FrmStoklar
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtGidalar = new System.Windows.Forms.TextBox();
            this.TxtIcecekler = new System.Windows.Forms.TextBox();
            this.TxtAtistirmalik = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Gıdalar = new System.Windows.Forms.ColumnHeader();
            this.İçecekler = new System.Windows.Forms.ColumnHeader();
            this.Atıştırmalıklar = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(24, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gıda Tutarı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "İçecek Tutarı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(6, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Atıştırmalıklar :";
            // 
            // TxtGidalar
            // 
            this.TxtGidalar.Location = new System.Drawing.Point(115, 39);
            this.TxtGidalar.Name = "TxtGidalar";
            this.TxtGidalar.Size = new System.Drawing.Size(168, 23);
            this.TxtGidalar.TabIndex = 3;
            // 
            // TxtIcecekler
            // 
            this.TxtIcecekler.Location = new System.Drawing.Point(115, 81);
            this.TxtIcecekler.Name = "TxtIcecekler";
            this.TxtIcecekler.Size = new System.Drawing.Size(168, 23);
            this.TxtIcecekler.TabIndex = 4;
            // 
            // TxtAtistirmalik
            // 
            this.TxtAtistirmalik.Location = new System.Drawing.Point(115, 117);
            this.TxtAtistirmalik.Name = "TxtAtistirmalik";
            this.TxtAtistirmalik.Size = new System.Drawing.Size(168, 23);
            this.TxtAtistirmalik.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(115, 163);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 28);
            this.button1.TabIndex = 6;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Gıdalar,
            this.İçecekler,
            this.Atıştırmalıklar});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 310);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(435, 128);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Gıdalar
            // 
            this.Gıdalar.Text = "Gıdalar";
            this.Gıdalar.Width = 160;
            // 
            // İçecekler
            // 
            this.İçecekler.Text = "İçecekler";
            this.İçecekler.Width = 160;
            // 
            // Atıştırmalıklar
            // 
            this.Atıştırmalıklar.Text = "Atıştırmalıklar";
            this.Atıştırmalıklar.Width = 160;
            // 
            // FrmStoklar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(459, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TxtAtistirmalik);
            this.Controls.Add(this.TxtIcecekler);
            this.Controls.Add(this.TxtGidalar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmStoklar";
            this.Text = "FrmStoklar";
            this.Load += new System.EventHandler(this.FrmStoklar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtGidalar;
        private System.Windows.Forms.TextBox TxtIcecekler;
        private System.Windows.Forms.TextBox TxtAtistirmalik;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Gıdalar;
        private System.Windows.Forms.ColumnHeader İçecekler;
        private System.Windows.Forms.ColumnHeader Atıştırmalıklar;
    }
}
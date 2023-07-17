
namespace Güleç_Otel
{
    partial class FrmFaturalar
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.Elektrik = new System.Windows.Forms.ColumnHeader();
            this.Su = new System.Windows.Forms.ColumnHeader();
            this.İnternet = new System.Windows.Forms.ColumnHeader();
            this.button1 = new System.Windows.Forms.Button();
            this.Txtinternet = new System.Windows.Forms.TextBox();
            this.TxtSu = new System.Windows.Forms.TextBox();
            this.TxtElektrik = new System.Windows.Forms.TextBox();
            this.Lblinternet = new System.Windows.Forms.Label();
            this.LblSu = new System.Windows.Forms.Label();
            this.LblElektirik = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Elektrik,
            this.Su,
            this.İnternet});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 294);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(469, 144);
            this.listView1.TabIndex = 15;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Elektrik
            // 
            this.Elektrik.Text = "Elektrik";
            this.Elektrik.Width = 160;
            // 
            // Su
            // 
            this.Su.Text = "Su";
            this.Su.Width = 160;
            // 
            // İnternet
            // 
            this.İnternet.Text = "İnternet";
            this.İnternet.Width = 160;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(124, 147);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 28);
            this.button1.TabIndex = 14;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Txtinternet
            // 
            this.Txtinternet.Location = new System.Drawing.Point(124, 101);
            this.Txtinternet.Name = "Txtinternet";
            this.Txtinternet.Size = new System.Drawing.Size(168, 23);
            this.Txtinternet.TabIndex = 13;
            // 
            // TxtSu
            // 
            this.TxtSu.Location = new System.Drawing.Point(124, 65);
            this.TxtSu.Name = "TxtSu";
            this.TxtSu.Size = new System.Drawing.Size(168, 23);
            this.TxtSu.TabIndex = 12;
            // 
            // TxtElektrik
            // 
            this.TxtElektrik.Location = new System.Drawing.Point(124, 23);
            this.TxtElektrik.Name = "TxtElektrik";
            this.TxtElektrik.Size = new System.Drawing.Size(168, 23);
            this.TxtElektrik.TabIndex = 11;
            // 
            // Lblinternet
            // 
            this.Lblinternet.AutoSize = true;
            this.Lblinternet.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lblinternet.Location = new System.Drawing.Point(46, 104);
            this.Lblinternet.Name = "Lblinternet";
            this.Lblinternet.Size = new System.Drawing.Size(60, 15);
            this.Lblinternet.TabIndex = 10;
            this.Lblinternet.Text = "İnternet :";
            // 
            // LblSu
            // 
            this.LblSu.AutoSize = true;
            this.LblSu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblSu.Location = new System.Drawing.Point(79, 68);
            this.LblSu.Name = "LblSu";
            this.LblSu.Size = new System.Drawing.Size(27, 15);
            this.LblSu.TabIndex = 9;
            this.LblSu.Text = "Su :";
            // 
            // LblElektirik
            // 
            this.LblElektirik.AutoSize = true;
            this.LblElektirik.BackColor = System.Drawing.Color.Transparent;
            this.LblElektirik.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblElektirik.Location = new System.Drawing.Point(50, 26);
            this.LblElektirik.Name = "LblElektirik";
            this.LblElektirik.Size = new System.Drawing.Size(56, 15);
            this.LblElektirik.TabIndex = 8;
            this.LblElektirik.Text = "Elektrik :";
            // 
            // FrmFaturalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(493, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Txtinternet);
            this.Controls.Add(this.TxtSu);
            this.Controls.Add(this.TxtElektrik);
            this.Controls.Add(this.Lblinternet);
            this.Controls.Add(this.LblSu);
            this.Controls.Add(this.LblElektirik);
            this.Name = "FrmFaturalar";
            this.Text = "Faturalar";
            this.Load += new System.EventHandler(this.FrmFaturalar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Elektrik;
        private System.Windows.Forms.ColumnHeader Su;
        private System.Windows.Forms.ColumnHeader İnternet;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Txtinternet;
        private System.Windows.Forms.TextBox TxtSu;
        private System.Windows.Forms.TextBox TxtElektrik;
        private System.Windows.Forms.Label Lblinternet;
        private System.Windows.Forms.Label LblSu;
        private System.Windows.Forms.Label LblElektirik;
    }
}
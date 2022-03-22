namespace Perhitungan
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
			this.txt_bil1 = new System.Windows.Forms.TextBox();
			this.txt_bil2 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.bttn_tambah = new System.Windows.Forms.Button();
			this.bttn_kurang = new System.Windows.Forms.Button();
			this.bttn_kali = new System.Windows.Forms.Button();
			this.bttn_bagi = new System.Windows.Forms.Button();
			this.txt_hasil = new System.Windows.Forms.TextBox();
			this.button5 = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txt_bil1
			// 
			this.txt_bil1.Location = new System.Drawing.Point(365, 125);
			this.txt_bil1.Name = "txt_bil1";
			this.txt_bil1.Size = new System.Drawing.Size(145, 23);
			this.txt_bil1.TabIndex = 0;
			// 
			// txt_bil2
			// 
			this.txt_bil2.Location = new System.Drawing.Point(365, 175);
			this.txt_bil2.Name = "txt_bil2";
			this.txt_bil2.Size = new System.Drawing.Size(145, 23);
			this.txt_bil2.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(305, 128);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(40, 15);
			this.label1.TabIndex = 2;
			this.label1.Text = "Nilai 1";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(305, 178);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(40, 15);
			this.label2.TabIndex = 3;
			this.label2.Text = "Nilai 2";
			// 
			// bttn_tambah
			// 
			this.bttn_tambah.Location = new System.Drawing.Point(268, 229);
			this.bttn_tambah.Name = "bttn_tambah";
			this.bttn_tambah.Size = new System.Drawing.Size(75, 23);
			this.bttn_tambah.TabIndex = 4;
			this.bttn_tambah.Text = "+";
			this.bttn_tambah.UseVisualStyleBackColor = true;
			this.bttn_tambah.Click += new System.EventHandler(this.bttn_tambah_Click);
			// 
			// bttn_kurang
			// 
			this.bttn_kurang.Location = new System.Drawing.Point(365, 229);
			this.bttn_kurang.Name = "bttn_kurang";
			this.bttn_kurang.Size = new System.Drawing.Size(75, 23);
			this.bttn_kurang.TabIndex = 5;
			this.bttn_kurang.Text = "-";
			this.bttn_kurang.UseVisualStyleBackColor = true;
			this.bttn_kurang.Click += new System.EventHandler(this.bttn_kurang_Click);
			// 
			// bttn_kali
			// 
			this.bttn_kali.Location = new System.Drawing.Point(459, 229);
			this.bttn_kali.Name = "bttn_kali";
			this.bttn_kali.Size = new System.Drawing.Size(75, 23);
			this.bttn_kali.TabIndex = 6;
			this.bttn_kali.Text = "x";
			this.bttn_kali.UseVisualStyleBackColor = true;
			this.bttn_kali.Click += new System.EventHandler(this.bttn_kali_Click);
			// 
			// bttn_bagi
			// 
			this.bttn_bagi.Location = new System.Drawing.Point(552, 229);
			this.bttn_bagi.Name = "bttn_bagi";
			this.bttn_bagi.Size = new System.Drawing.Size(75, 23);
			this.bttn_bagi.TabIndex = 7;
			this.bttn_bagi.Text = "/";
			this.bttn_bagi.UseVisualStyleBackColor = true;
			this.bttn_bagi.Click += new System.EventHandler(this.bttn_bagi_Click);
			// 
			// txt_hasil
			// 
			this.txt_hasil.Location = new System.Drawing.Point(365, 285);
			this.txt_hasil.Name = "txt_hasil";
			this.txt_hasil.Size = new System.Drawing.Size(145, 23);
			this.txt_hasil.TabIndex = 8;
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(552, 285);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(75, 23);
			this.button5.TabIndex = 9;
			this.button5.Text = "Hapus";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(305, 289);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(33, 15);
			this.label3.TabIndex = 10;
			this.label3.Text = "Hasil";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.txt_hasil);
			this.Controls.Add(this.bttn_bagi);
			this.Controls.Add(this.bttn_kali);
			this.Controls.Add(this.bttn_kurang);
			this.Controls.Add(this.bttn_tambah);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txt_bil2);
			this.Controls.Add(this.txt_bil1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private TextBox txt_bil1;
		private TextBox txt_bil2;
		private Label label1;
		private Label label2;
		private Button bttn_tambah;
		private Button bttn_kurang;
		private Button bttn_kali;
		private Button bttn_bagi;
		private TextBox txt_hasil;
		private Button button5;
		private Label label3;
	}
}
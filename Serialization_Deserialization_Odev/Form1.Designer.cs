namespace Serialization_Deserialization_Odev
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
			lblAd = new Label();
			btnJsonOlustur = new Button();
			btnJsonOku = new Button();
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			txtUrunKod = new TextBox();
			cmbMarka = new ComboBox();
			cmbUrunAd = new ComboBox();
			nmrFiyat = new NumericUpDown();
			txtDosyadi = new TextBox();
			label4 = new Label();
			((System.ComponentModel.ISupportInitialize)nmrFiyat).BeginInit();
			SuspendLayout();
			// 
			// lblAd
			// 
			lblAd.AutoSize = true;
			lblAd.Font = new Font("Cascadia Code SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
			lblAd.Location = new Point(51, 99);
			lblAd.Name = "lblAd";
			lblAd.Size = new Size(90, 20);
			lblAd.TabIndex = 0;
			lblAd.Text = "Ürün Adı:";
			// 
			// btnJsonOlustur
			// 
			btnJsonOlustur.Font = new Font("Cascadia Code SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
			btnJsonOlustur.Location = new Point(51, 322);
			btnJsonOlustur.Name = "btnJsonOlustur";
			btnJsonOlustur.Size = new Size(152, 63);
			btnJsonOlustur.TabIndex = 10;
			btnJsonOlustur.Text = "Json Oluştur";
			btnJsonOlustur.UseVisualStyleBackColor = true;
			btnJsonOlustur.Click += btnJsonOlustur_Click;
			// 
			// btnJsonOku
			// 
			btnJsonOku.Font = new Font("Cascadia Code SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
			btnJsonOku.Location = new Point(293, 322);
			btnJsonOku.Name = "btnJsonOku";
			btnJsonOku.Size = new Size(152, 63);
			btnJsonOku.TabIndex = 11;
			btnJsonOku.Text = "Json Oku";
			btnJsonOku.UseVisualStyleBackColor = true;
			btnJsonOku.Click += btnJsonOku_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Cascadia Code SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
			label1.Location = new Point(51, 146);
			label1.Name = "label1";
			label1.Size = new Size(72, 20);
			label1.TabIndex = 12;
			label1.Text = "Fiyatı:";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Cascadia Code SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
			label2.Location = new Point(51, 55);
			label2.Name = "label2";
			label2.Size = new Size(63, 20);
			label2.TabIndex = 13;
			label2.Text = "Marka:";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Cascadia Code SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
			label3.Location = new Point(51, 189);
			label3.Name = "label3";
			label3.Size = new Size(99, 20);
			label3.TabIndex = 14;
			label3.Text = "Ürün Kodu:";
			// 
			// txtUrunKod
			// 
			txtUrunKod.Enabled = false;
			txtUrunKod.Font = new Font("Cascadia Code SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
			txtUrunKod.Location = new Point(182, 189);
			txtUrunKod.Name = "txtUrunKod";
			txtUrunKod.Size = new Size(182, 25);
			txtUrunKod.TabIndex = 17;
			// 
			// cmbMarka
			// 
			cmbMarka.Font = new Font("Cascadia Code SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
			cmbMarka.FormattingEnabled = true;
			cmbMarka.Items.AddRange(new object[] { "Msi", "Casper", "Asus" });
			cmbMarka.Location = new Point(182, 47);
			cmbMarka.Name = "cmbMarka";
			cmbMarka.Size = new Size(182, 28);
			cmbMarka.TabIndex = 20;
			cmbMarka.SelectedIndexChanged += cmbMarka_SelectedIndexChanged;
			// 
			// cmbUrunAd
			// 
			cmbUrunAd.Font = new Font("Cascadia Code SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
			cmbUrunAd.FormattingEnabled = true;
			cmbUrunAd.Location = new Point(182, 99);
			cmbUrunAd.Name = "cmbUrunAd";
			cmbUrunAd.Size = new Size(182, 28);
			cmbUrunAd.TabIndex = 21;
			cmbUrunAd.SelectedIndexChanged += cmbUrunAd_SelectedIndexChanged;
			// 
			// nmrFiyat
			// 
			nmrFiyat.Enabled = false;
			nmrFiyat.Font = new Font("Cascadia Code SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
			nmrFiyat.Location = new Point(182, 146);
			nmrFiyat.Maximum = new decimal(new int[] { 1410065407, 2, 0, 0 });
			nmrFiyat.Name = "nmrFiyat";
			nmrFiyat.Size = new Size(182, 25);
			nmrFiyat.TabIndex = 22;
			// 
			// txtDosyadi
			// 
			txtDosyadi.Font = new Font("Cascadia Code SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
			txtDosyadi.Location = new Point(182, 231);
			txtDosyadi.Name = "txtDosyadi";
			txtDosyadi.Size = new Size(182, 25);
			txtDosyadi.TabIndex = 23;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Cascadia Code SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
			label4.Location = new Point(51, 236);
			label4.Name = "label4";
			label4.Size = new Size(99, 20);
			label4.TabIndex = 24;
			label4.Text = "Dosya Adi:";
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(517, 481);
			Controls.Add(label4);
			Controls.Add(txtDosyadi);
			Controls.Add(nmrFiyat);
			Controls.Add(cmbUrunAd);
			Controls.Add(cmbMarka);
			Controls.Add(txtUrunKod);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(btnJsonOku);
			Controls.Add(btnJsonOlustur);
			Controls.Add(lblAd);
			Name = "Form1";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Form1";
			((System.ComponentModel.ISupportInitialize)nmrFiyat).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label lblAd;
		private Button btnJsonOlustur;
		private Button btnJsonOku;
		private Label label1;
		private Label label2;
		private Label label3;
		private TextBox textBox1;
		private TextBox txtUrunKod;
		private ComboBox cmbMarka;
		private ComboBox cmbUrunAd;
		private NumericUpDown nmrFiyat;
		private TextBox txtDosyadi;
		private Label label4;
	}
}

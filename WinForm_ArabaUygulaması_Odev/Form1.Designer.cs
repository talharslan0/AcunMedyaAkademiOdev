namespace WinForm_ArabaUygulaması_Odev
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
			groupBox1 = new GroupBox();
			cmbAracRenk = new ComboBox();
			label5 = new Label();
			label4 = new Label();
			label3 = new Label();
			label2 = new Label();
			label1 = new Label();
			txtAliciSoyad = new TextBox();
			txtAliciAdi = new TextBox();
			btnGoster = new Button();
			cmbAracMarka = new ComboBox();
			cmbAracModel = new ComboBox();
			groupBox1.SuspendLayout();
			SuspendLayout();
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(cmbAracRenk);
			groupBox1.Controls.Add(label5);
			groupBox1.Controls.Add(label4);
			groupBox1.Controls.Add(label3);
			groupBox1.Controls.Add(label2);
			groupBox1.Controls.Add(label1);
			groupBox1.Controls.Add(txtAliciSoyad);
			groupBox1.Controls.Add(txtAliciAdi);
			groupBox1.Controls.Add(btnGoster);
			groupBox1.Controls.Add(cmbAracMarka);
			groupBox1.Controls.Add(cmbAracModel);
			groupBox1.ForeColor = SystemColors.ActiveCaptionText;
			groupBox1.Location = new Point(134, 72);
			groupBox1.Margin = new Padding(3, 2, 3, 2);
			groupBox1.Name = "groupBox1";
			groupBox1.Padding = new Padding(3, 2, 3, 2);
			groupBox1.Size = new Size(466, 364);
			groupBox1.TabIndex = 0;
			groupBox1.TabStop = false;
			groupBox1.Text = "  ";
			// 
			// cmbAracRenk
			// 
			cmbAracRenk.Font = new Font("Cascadia Code", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
			cmbAracRenk.FormattingEnabled = true;
			cmbAracRenk.Location = new Point(180, 190);
			cmbAracRenk.Margin = new Padding(3, 2, 3, 2);
			cmbAracRenk.Name = "cmbAracRenk";
			cmbAracRenk.Size = new Size(263, 32);
			cmbAracRenk.TabIndex = 7;
			cmbAracRenk.SelectedIndexChanged += cmbAracRenk_SelectedIndexChanged;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Cascadia Code", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
			label5.Location = new Point(52, 190);
			label5.Name = "label5";
			label5.Size = new Size(122, 25);
			label5.TabIndex = 4;
			label5.Text = "Araç Renk:";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Cascadia Code", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
			label4.Location = new Point(41, 154);
			label4.Name = "label4";
			label4.Size = new Size(133, 25);
			label4.TabIndex = 4;
			label4.Text = "Araç Model:";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Cascadia Code", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
			label3.Location = new Point(19, 118);
			label3.Name = "label3";
			label3.Size = new Size(155, 25);
			label3.TabIndex = 4;
			label3.Text = "Araç Markası:";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Cascadia Code", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
			label2.Location = new Point(19, 81);
			label2.Name = "label2";
			label2.Size = new Size(155, 25);
			label2.TabIndex = 4;
			label2.Text = "Alıcı Soyadı:";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Cascadia Code", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
			label1.Location = new Point(52, 48);
			label1.Name = "label1";
			label1.Size = new Size(122, 25);
			label1.TabIndex = 4;
			label1.Text = "Alıcı Adı:";
			// 
			// txtAliciSoyad
			// 
			txtAliciSoyad.Font = new Font("Cascadia Code", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
			txtAliciSoyad.Location = new Point(180, 81);
			txtAliciSoyad.Name = "txtAliciSoyad";
			txtAliciSoyad.Size = new Size(263, 30);
			txtAliciSoyad.TabIndex = 2;
			txtAliciSoyad.TextChanged += txtAliciSoyad_TextChanged;
			// 
			// txtAliciAdi
			// 
			txtAliciAdi.Font = new Font("Cascadia Code", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
			txtAliciAdi.Location = new Point(180, 45);
			txtAliciAdi.Name = "txtAliciAdi";
			txtAliciAdi.Size = new Size(263, 30);
			txtAliciAdi.TabIndex = 1;
			txtAliciAdi.TextChanged += txtAliciAdi_TextChanged;
			// 
			// btnGoster
			// 
			btnGoster.Location = new Point(128, 258);
			btnGoster.Margin = new Padding(3, 2, 3, 2);
			btnGoster.Name = "btnGoster";
			btnGoster.Size = new Size(204, 49);
			btnGoster.TabIndex = 6;
			btnGoster.Text = "Bilgileri Göster";
			btnGoster.UseVisualStyleBackColor = true;
			btnGoster.Click += btnGoster_Click;
			// 
			// cmbAracMarka
			// 
			cmbAracMarka.BackColor = SystemColors.HighlightText;
			cmbAracMarka.Font = new Font("Cascadia Code", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
			cmbAracMarka.FormattingEnabled = true;
			cmbAracMarka.Items.AddRange(new object[] { "Bmw", "Audi", "Porsche" });
			cmbAracMarka.Location = new Point(180, 116);
			cmbAracMarka.Margin = new Padding(3, 2, 3, 2);
			cmbAracMarka.Name = "cmbAracMarka";
			cmbAracMarka.Size = new Size(263, 32);
			cmbAracMarka.TabIndex = 3;
			cmbAracMarka.SelectedIndexChanged += cmbAracMarka_SelectedIndexChanged;
			// 
			// cmbAracModel
			// 
			cmbAracModel.Font = new Font("Cascadia Code", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
			cmbAracModel.FormattingEnabled = true;
			cmbAracModel.Location = new Point(180, 152);
			cmbAracModel.Margin = new Padding(3, 2, 3, 2);
			cmbAracModel.Name = "cmbAracModel";
			cmbAracModel.Size = new Size(263, 32);
			cmbAracModel.TabIndex = 4;
			cmbAracModel.SelectedIndexChanged += cmbAracModel_SelectedIndexChanged;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(723, 518);
			Controls.Add(groupBox1);
			Margin = new Padding(3, 2, 3, 2);
			Name = "Form1";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Form1";
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private GroupBox groupBox1;
		private ComboBox cmbAracMarka;
		private ComboBox cmbAracModel;
		private Button btnGoster;
		private TextBox txtAliciSoyad;
		private TextBox txtAliciAdi;
		private Label label5;
		private Label label4;
		private Label label3;
		private Label label2;
		private Label label1;
		private ComboBox cmbAracRenk;
	}
}

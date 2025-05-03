namespace CustomAttribute_Ödevi
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
			txtAd = new TextBox();
			txtSoyad = new TextBox();
			txtBolum = new TextBox();
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			btnDogrula = new Button();
			lblSonuc = new Label();
			SuspendLayout();
			// 
			// txtAd
			// 
			txtAd.Location = new Point(399, 45);
			txtAd.Name = "txtAd";
			txtAd.Size = new Size(260, 23);
			txtAd.TabIndex = 0;
			// 
			// txtSoyad
			// 
			txtSoyad.Location = new Point(399, 98);
			txtSoyad.Name = "txtSoyad";
			txtSoyad.Size = new Size(260, 23);
			txtSoyad.TabIndex = 1;
			// 
			// txtBolum
			// 
			txtBolum.Location = new Point(399, 164);
			txtBolum.Name = "txtBolum";
			txtBolum.Size = new Size(260, 23);
			txtBolum.TabIndex = 2;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(306, 53);
			label1.Name = "label1";
			label1.Size = new Size(73, 15);
			label1.TabIndex = 3;
			label1.Text = "Öğrenci Adı:";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(289, 106);
			label2.Name = "label2";
			label2.Size = new Size(90, 15);
			label2.TabIndex = 4;
			label2.Text = "Öğrenci Soyadı:";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(289, 167);
			label3.Name = "label3";
			label3.Size = new Size(90, 15);
			label3.TabIndex = 5;
			label3.Text = "Öğrenci Bölüm:";
			// 
			// btnDogrula
			// 
			btnDogrula.Location = new Point(371, 238);
			btnDogrula.Name = "btnDogrula";
			btnDogrula.Size = new Size(223, 49);
			btnDogrula.TabIndex = 6;
			btnDogrula.Text = "Doğrula";
			btnDogrula.UseVisualStyleBackColor = true;
			btnDogrula.Click += btnDogrula_Click;
			// 
			// lblSonuc
			// 
			lblSonuc.AutoSize = true;
			lblSonuc.Location = new Point(865, 109);
			lblSonuc.Name = "lblSonuc";
			lblSonuc.Size = new Size(43, 15);
			lblSonuc.TabIndex = 7;
			lblSonuc.Text = "Sonuç:";
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1400, 721);
			Controls.Add(lblSonuc);
			Controls.Add(btnDogrula);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(txtBolum);
			Controls.Add(txtSoyad);
			Controls.Add(txtAd);
			Name = "Form1";
			Text = "Form1";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox txtAd;
		private TextBox txtSoyad;
		private TextBox txtBolum;
		private Label label1;
		private Label label2;
		private Label label3;
		private Button btnDogrula;
		private Label lblSonuc;
	}
}

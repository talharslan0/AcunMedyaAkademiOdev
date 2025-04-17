namespace Serialization_Deserialization_Odev
{
	partial class Form2
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
			btnOku = new Button();
			lstJsonDosya = new ListBox();
			rchJsonOkunmus = new RichTextBox();
			SuspendLayout();
			// 
			// btnOku
			// 
			btnOku.Font = new Font("Cascadia Code SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
			btnOku.Location = new Point(238, 500);
			btnOku.Name = "btnOku";
			btnOku.Size = new Size(180, 73);
			btnOku.TabIndex = 0;
			btnOku.Text = "Oku";
			btnOku.UseVisualStyleBackColor = true;
			btnOku.Click += btnOku_Click;
			// 
			// lstJsonDosya
			// 
			lstJsonDosya.FormattingEnabled = true;
			lstJsonDosya.ItemHeight = 15;
			lstJsonDosya.Location = new Point(12, 12);
			lstJsonDosya.Name = "lstJsonDosya";
			lstJsonDosya.Size = new Size(295, 394);
			lstJsonDosya.TabIndex = 1;
			// 
			// rchJsonOkunmus
			// 
			rchJsonOkunmus.Location = new Point(372, 12);
			rchJsonOkunmus.Name = "rchJsonOkunmus";
			rchJsonOkunmus.Size = new Size(295, 394);
			rchJsonOkunmus.TabIndex = 2;
			rchJsonOkunmus.Text = "";
			// 
			// Form2
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(681, 632);
			Controls.Add(rchJsonOkunmus);
			Controls.Add(lstJsonDosya);
			Controls.Add(btnOku);
			Name = "Form2";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Form2";
			ResumeLayout(false);
		}

		#endregion

		private Button btnOku;
		private ListBox lstJsonDosya;
		private RichTextBox rchJsonOkunmus;
	}
}
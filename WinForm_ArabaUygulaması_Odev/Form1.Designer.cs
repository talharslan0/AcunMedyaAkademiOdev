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
			cmbAracMarka = new ComboBox();
			cmbAracModel = new ComboBox();
			btnGoster = new Button();
			groupBox1.SuspendLayout();
			SuspendLayout();
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(btnGoster);
			groupBox1.Controls.Add(cmbAracMarka);
			groupBox1.Controls.Add(cmbAracModel);
			groupBox1.ForeColor = SystemColors.ActiveCaptionText;
			groupBox1.Location = new Point(37, 64);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(532, 486);
			groupBox1.TabIndex = 0;
			groupBox1.TabStop = false;
			groupBox1.Text = "  ";
			// 
			// cmbAracMarka
			// 
			cmbAracMarka.BackColor = SystemColors.HighlightText;
			cmbAracMarka.Font = new Font("Cascadia Code", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
			cmbAracMarka.FormattingEnabled = true;
			cmbAracMarka.Items.AddRange(new object[] { "Bmw", "Audi", "Porsche" });
			cmbAracMarka.Location = new Point(37, 73);
			cmbAracMarka.Name = "cmbAracMarka";
			cmbAracMarka.Size = new Size(300, 38);
			cmbAracMarka.TabIndex = 1;
			cmbAracMarka.Text = "Araç Markası Seçiniz";
			cmbAracMarka.SelectedIndexChanged += cmbAracMarka_SelectedIndexChanged;
			// 
			// cmbAracModel
			// 
			cmbAracModel.Font = new Font("Cascadia Code", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
			cmbAracModel.FormattingEnabled = true;
			cmbAracModel.Location = new Point(37, 156);
			cmbAracModel.Name = "cmbAracModel";
			cmbAracModel.Size = new Size(300, 38);
			cmbAracModel.TabIndex = 0;
			cmbAracModel.Text = "Araç Model";
			cmbAracModel.SelectedIndexChanged += cmbAracModel_SelectedIndexChanged;
			// 
			// btnGoster
			// 
			btnGoster.Location = new Point(104, 278);
			btnGoster.Name = "btnGoster";
			btnGoster.Size = new Size(233, 65);
			btnGoster.TabIndex = 2;
			btnGoster.Text = "Bilgileri Göster";
			btnGoster.UseVisualStyleBackColor = true;
			btnGoster.Click += btnGoster_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1270, 690);
			Controls.Add(groupBox1);
			Name = "Form1";
			Text = "Form1";
			groupBox1.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private GroupBox groupBox1;
		private ComboBox cmbAracMarka;
		private ComboBox cmbAracModel;
		private Button btnGoster;
	}
}

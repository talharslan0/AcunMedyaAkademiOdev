

namespace WinForm_ArabaUygulaması_Odev
{
	public partial class Form1 : Form
	{

		public int aracmarkaindex;
		public string marka;
		public string model;
		public string renk;
		public Form1()
		{
			InitializeComponent();
		}

		private void cmbAracMarka_SelectedIndexChanged(object sender, EventArgs e)
		{
			aracmarkaindex = cmbAracMarka.SelectedIndex;
			marka = cmbAracMarka.Text;

			cmbAracModel.Items.Clear();

			if (aracmarkaindex == 0)
			{
				cmbAracModel.Items.Add("X7");
				cmbAracModel.Items.Add("M8");
				cmbAracModel.Items.Add("M3");
			}
			else if (aracmarkaindex == 1)
			{
				cmbAracModel.Items.Add("Q4");
				cmbAracModel.Items.Add("A6");
				cmbAracModel.Items.Add("RS6");
			}
			else if (aracmarkaindex == 2)
			{
				cmbAracModel.Items.Add("GT3 RS");
				cmbAracModel.Items.Add("GT4");
				cmbAracModel.Items.Add("Panamera"); // 'Panemera' yerine doğru yazımı ekledim
			}

			model = ""; // Yeni marka seçildiğinde model sıfırlanmalı

		}

		private void cmbAracModel_SelectedIndexChanged(object sender, EventArgs e)
		{
			model = cmbAracModel.Text;
		}

		private void btnGoster_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(marka) && !string.IsNullOrEmpty(model))
			{
				MessageBox.Show("Marka: " + marka + "\nModel: " + model);
			}
			else
			{
				MessageBox.Show("Lütfen bir marka ve model seçiniz!");
			}
		}
	}
}

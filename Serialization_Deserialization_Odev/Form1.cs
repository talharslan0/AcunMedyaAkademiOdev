using Newtonsoft.Json;
using Serialization_Deserialization_Odev.Classes;

namespace Serialization_Deserialization_Odev
{
	public partial class Form1 : Form
	{
		Product product = new Product();
		public string dosyadi;
		public Form1()
		{
			InitializeComponent();
			Temizle();
		}
		private void Temizle()
		{
			cmbMarka.Text = "";
			cmbUrunAd.Text = "";
			nmrFiyat.Text = "";
			txtUrunKod.Text = "";
			txtDosyadi.Text = "";
		}
		private void cmbMarka_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cmbMarka.SelectedIndex == 0)
			{
				cmbUrunAd.Items.Clear();
				cmbUrunAd.Items.Add("Msi Laptop");
				cmbUrunAd.Items.Add("Msi Klavye");
				cmbUrunAd.Items.Add("Msi Mause");
				cmbUrunAd.Items.Add("Msi Kulaklýk");
			}
			else if (cmbMarka.SelectedIndex == 1)
			{
				cmbUrunAd.Items.Clear();
				cmbUrunAd.Items.Add("Casper Laptop");
				cmbUrunAd.Items.Add("Casper Klavye");
				cmbUrunAd.Items.Add("Casper Mause");
				cmbUrunAd.Items.Add("Casper Kulaklýk");
			}
			else if (cmbMarka.SelectedIndex == 2)
			{
				cmbUrunAd.Items.Clear();
				cmbUrunAd.Items.Add("Asus Laptop");
				cmbUrunAd.Items.Add("Asus Klavye");
				cmbUrunAd.Items.Add("Asus Mause");
				cmbUrunAd.Items.Add("Asus Kulaklýk");
			}
		}

		private void cmbUrunAd_SelectedIndexChanged(object sender, EventArgs e)
		{
			var urunler = new Dictionary<string, (decimal fiyat, string kod)>
			{
				{ "Msi Laptop", (30000, "A1B1C1") },
				{ "Msi Klavye", (2500, "A1B2C2") },
				{ "Msi Mause", (1350, "A1B3C3") },
				{ "Msi Kulaklýk", (2400, "A1B4C4") },

				{ "Casper Laptop", (35000, "A2B1C1") },
				{ "Casper Klavye", (2200, "A2B2C2") },
				{ "Casper Mause", (1650, "A2B3C3") },
				{ "Casper Kulaklýk", (1600, "A2B4C4") },

				{ "Asus Laptop", (33000, "A3B1C1") },
				{ "Asus Klavye", (2100, "A3B2C2") },
				{ "Asus Mause", (1450, "A3B3C3") },
				{ "Asus Kulaklýk", (1400, "A3B4C4") },
			};

			if (urunler.TryGetValue(cmbUrunAd.Text, out var urunBilgi))
			{
				nmrFiyat.Value = urunBilgi.fiyat;
				txtUrunKod.Text = urunBilgi.kod;
			}
		}

		private void btnJsonOlustur_Click(object sender, EventArgs e)
		{
			// Boþluk kontrolleri
			if (string.IsNullOrWhiteSpace(cmbMarka.Text))
			{
				MessageBox.Show("Lütfen Marka seçiniz");
				return; // Ýþlemi durdur
			}
			else if (string.IsNullOrWhiteSpace(cmbUrunAd.Text))
			{
				MessageBox.Show("Lütfen Ürün adý seçiniz");
				return; // Ýþlemi durdur
			}
			else if (string.IsNullOrWhiteSpace(txtDosyadi.Text))
			{
				MessageBox.Show("Lütfen dosya adý giriniz");
				return; // Ýþlemi durdur
			}


			product.Marka = cmbMarka.Text;
			product.UrunAd = cmbUrunAd.Text;
			product.Fiyat = nmrFiyat.Value;
			product.UrunKod = txtUrunKod.Text;
			product.Tarih = DateTime.Now;
			dosyadi = txtDosyadi.Text;
			try
			{
				JsonSerializer jsonSerializer = new JsonSerializer();
				using (StreamWriter sr = new StreamWriter($@"C:\Users\talha\Documents\AcunMedyaAkademiOdev\Serialization_Deserialization_Odev\{dosyadi}.json"))
				using (JsonWriter jsonWriter = new JsonTextWriter(sr))
				{
					jsonSerializer.Serialize(jsonWriter, product);
					MessageBox.Show("Product Json formatýna dönüþtürüldü");
				}
				Temizle();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Hata oluþtu : " + ex.Message.ToString());
			}
		}

		private void btnJsonOku_Click(object sender, EventArgs e)
		{
			Form2 form2 = new Form2();
			form2.Show();
		}
	}
}

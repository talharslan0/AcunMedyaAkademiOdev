using Newtonsoft.Json;
using Serialization_Deserialization_Odev.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Serialization_Deserialization_Odev
{
	public partial class Form2 : Form
	{
		string klasorYolu = @"C:\Users\talha\Documents\AcunMedyaAkademiOdev\Serialization_Deserialization_Odev";
		public Form2()
		{
			InitializeComponent();
			JsonDosyalariniListele();
		}

		private void JsonDosyalariniListele()
		{
			lstJsonDosya.Items.Clear();

			if (Directory.Exists(klasorYolu))
			{
				string[] jsonDosyalari = Directory.GetFiles(klasorYolu, "*.json");

				foreach (string dosya in jsonDosyalari)
				{
					lstJsonDosya.Items.Add(Path.GetFileName(dosya));
				}
			}
			else
			{
				MessageBox.Show("JSON klasörü bulunamadı.");
			}
		}

		private void btnOku_Click(object sender, EventArgs e)
		{
			if (lstJsonDosya.SelectedItem == null)
			{
				MessageBox.Show("Lütfen bir dosya seçiniz.");
				return;
			}

			string secilenDosyaAdi = lstJsonDosya.SelectedItem.ToString();
			string dosyaYolu = Path.Combine(klasorYolu, secilenDosyaAdi);

			try
			{
				string json = File.ReadAllText(dosyaYolu);
				Product product = JsonConvert.DeserializeObject<Product>(json);

				if (product != null)
				{
					string bilgiler = $"Marka: {product.Marka}\n" +
									  $"Ürün Adı: {product.UrunAd}\n" +
									  $"Fiyat: {product.Fiyat}₺\n" +
									  $"Ürün Kodu: {product.UrunKod}\n" +
									  $"Tarih: {product.Tarih}";

					rchJsonOkunmus.Text = bilgiler;
				}
				else
				{
					MessageBox.Show("Veri okunamadı.");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Hata: " + ex.Message);
			}
		}
	}
}

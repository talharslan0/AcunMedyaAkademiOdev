using System.Reflection;

namespace CustomAttribute_Ödevi
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnDogrula_Click(object sender, EventArgs e)
		{
			Ogrenci ogrenci = new Ogrenci
			{
				Ad = txtAd.Text,
				Soyad = txtSoyad.Text,
				Bolum = txtBolum.Text
			};

			// Tüm TextBox'ları varsayılan rengine al
			txtAd.BackColor = SystemColors.Window;
			txtSoyad.BackColor = SystemColors.Window;
			txtBolum.BackColor = SystemColors.Window;

			// Doğrulama işlemi
			PropertyInfo[] properties = typeof(Ogrenci).GetProperties();
			foreach (var prop in properties)
			{
				var attr = prop.GetCustomAttribute<ZorunluAlanAttribute>();
				if (attr != null)
				{
					string value = prop.GetValue(ogrenci)?.ToString();
					if (string.IsNullOrWhiteSpace(value))
					{
						MessageBox.Show(attr.HataMesaji, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

						// Hangi alan boşsa arayüzde renklendir
						if (prop.Name == "Ad") txtAd.BackColor = Color.LightPink;
						else if (prop.Name == "Soyad") txtSoyad.BackColor = Color.LightPink;
						else if (prop.Name == "Bolum") txtBolum.BackColor = Color.LightPink;

						return; // İlk hatada çık
					}
				}
			}

			// Tüm alanlar doluysa sonucu yaz
			lblSonuc.Text = $"Ad: {ogrenci.Ad}, Soyad: {ogrenci.Soyad}, Bölüm: {ogrenci.Bolum}";
		}
	}
}

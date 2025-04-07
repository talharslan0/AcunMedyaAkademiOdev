

namespace WinForm_ArabaUygulaması_Odev
{
	public partial class Form1 : Form
	{
		//formda kullanılacak gerekli değişkenlerin tanımlamaları
		public int aracmarkaindex;
		public string aliciAd;
		public string aliciSoyad;
		public string marka;
		public string model;
		public string renk;
		public int kapiSayisi;
		public int pencereSayisi;
		public double ortalamaYakit;
		public Form1()
		{
			InitializeComponent();
		}

		private void cmbAracMarka_SelectedIndexChanged(object sender, EventArgs e)
		{
			//combobox tan seçilen index i bir değişkene atıyoruz 
			aracmarkaindex = cmbAracMarka.SelectedIndex;
			//marka combobox sın textini bir değişkene atıyoruz 
			marka = cmbAracMarka.Text;

			cmbAracModel.Text = null;
			//seçilen markanın indexine göre model combobox sına modelleri ekliyoruz
			if (aracmarkaindex == 0)
			{
				cmbAracModel.Items.Clear();
				cmbAracModel.Items.Add("X7");
				cmbAracModel.Items.Add("M8");
				cmbAracModel.Items.Add("M3");
			}
			else if (aracmarkaindex == 1)
			{
				cmbAracModel.Items.Clear();
				cmbAracModel.Items.Add("Q5");
				cmbAracModel.Items.Add("A6");
				cmbAracModel.Items.Add("RS6");
			}
			else if (aracmarkaindex == 2)
			{
				cmbAracModel.Items.Clear();
				cmbAracModel.Items.Add("GT3 RS");
				cmbAracModel.Items.Add("GT4");
				cmbAracModel.Items.Add("Panamera");;
			}


		}

		private void cmbAracModel_SelectedIndexChanged(object sender, EventArgs e)
		{
			
			model = cmbAracModel.Text;
			cmbAracRenk.Text = null;
			//seçilen modele göre renk combobox sına renkleri ve o araca ait diğer bilgileri
			//bir değişkene ekliyoruz
			if (cmbAracModel.Text == "X7")
			{
				cmbAracRenk.Items.Clear();
				cmbAracRenk.Items.Add("Beyaz");
				cmbAracRenk.Items.Add("Siyah");
				cmbAracRenk.Items.Add("Kırmızı");
				kapiSayisi = 5;
				pencereSayisi = 5;
				ortalamaYakit = 11.2;
			}
			else if(cmbAracModel.Text == "M8")
			{
				cmbAracRenk.Items.Clear();
				cmbAracRenk.Items.Add("Gri");
				cmbAracRenk.Items.Add("Yeşil");
				cmbAracRenk.Items.Add("Sarı");
				kapiSayisi = 2;
				pencereSayisi = 2;
				ortalamaYakit = 11.6;
			}
			else if(cmbAracModel.Text == "M3")
			{
				cmbAracRenk.Items.Clear();
				cmbAracRenk.Items.Add("Siyah");
				kapiSayisi = 4;
				pencereSayisi = 4;
				ortalamaYakit = 11;
			}
			else if(cmbAracModel.Text == "Q5")
			{
				cmbAracRenk.Items.Clear();
				cmbAracRenk.Items.Add("Siyah");
				cmbAracRenk.Items.Add("Beyaz");
				kapiSayisi = 5;
				pencereSayisi = 5;
				ortalamaYakit = 8.5;
			}
			else if(cmbAracModel.Text == "A6")
			{
				cmbAracRenk.Items.Clear();
				cmbAracRenk.Items.Add("Siyah");
				cmbAracRenk.Items.Add("Gri");
				cmbAracRenk.Items.Add("Mavi");
				kapiSayisi = 4;
				pencereSayisi = 4;
				ortalamaYakit = 8.5;
			}
			else if(cmbAracModel.Text == "RS6")
			{
				cmbAracRenk.Items.Clear();
				cmbAracRenk.Items.Add("Piano Black");
				cmbAracRenk.Items.Add("Gri");
				cmbAracRenk.Items.Add("Kırmızı");
				kapiSayisi = 5;
				pencereSayisi = 5;
				ortalamaYakit = 12.5;
			}
			else if(cmbAracModel.Text == "GT3 RS")
			{
				cmbAracRenk.Items.Clear();
				cmbAracRenk.Items.Add("Beyaz");
				cmbAracRenk.Items.Add("Siyah");
				cmbAracRenk.Items.Add("Yeşil");
				cmbAracRenk.Items.Add("Sarı");
				kapiSayisi = 2;
				pencereSayisi = 2;
				ortalamaYakit = 13;
			}
			else if(cmbAracModel.Text == "GT4")
			{
				cmbAracRenk.Items.Clear();
				cmbAracRenk.Items.Add("Sarı");
				cmbAracRenk.Items.Add("Beyaz");
				cmbAracRenk.Items.Add("Gri");
				kapiSayisi = 2;
				pencereSayisi = 2;
				ortalamaYakit = 11;
			}
			else if(cmbAracModel.Text == "Panamera")
			{
				cmbAracRenk.Items.Clear();
				cmbAracRenk.Items.Add("Sarı");
				cmbAracRenk.Items.Add("Beyaz");
				cmbAracRenk.Items.Add("Gri");
				kapiSayisi = 4;
				pencereSayisi = 4;
				ortalamaYakit = 11.5;
			}
		}

		private void btnGoster_Click(object sender, EventArgs e)
		{
			//boş alan kontorlü yapıp gerekli bilgileri bir message box ile yazdırıyoruz
			if (!string.IsNullOrEmpty(aliciAd) && !string.IsNullOrEmpty(aliciSoyad) && !string.IsNullOrEmpty(marka) && !string.IsNullOrEmpty(model) && !string.IsNullOrEmpty(renk))
			{
				MessageBox.Show(
					"Alıcı Adı: "+aliciAd+ 
					"\nAlıcı Soyadı: " + aliciSoyad + 
					"\nMarka: " + marka + 
					"\nModel: " + model + 
					"\nRenk: " + renk + 
					"\nKapı Sayısı: " + kapiSayisi +
					"\nPencere Sayısı: " + pencereSayisi +
					"\n100km'deki ortalama yakıtı: " + ortalamaYakit+ " LT");
			}
			else
			{
				MessageBox.Show("Lütfen eksik yerleri doldurunuz!!");
			}
		}

		private void cmbAracRenk_SelectedIndexChanged(object sender, EventArgs e)
		{
			renk = cmbAracRenk.Text;
		}

		private void txtAliciAdi_TextChanged(object sender, EventArgs e)
		{
			aliciAd = txtAliciAdi.Text;
		}

		private void txtAliciSoyad_TextChanged(object sender, EventArgs e)
		{
			aliciSoyad = txtAliciSoyad.Text;
		}
	}
}

using Prolab_6.Tablolar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Prolab_6
{
    public partial class AnaForm : Form
    {
        List<string> FilmListesi;
        List<string> ÖnerilenFilmListesi;
        List<string> TurAramaSonucListesi;
        List<string> TurSecim;
        List<string> AnlikArama;

        Mysqlislemleri mysqlislemleri;
        BağlantıBilgileriOku oku;

        List<PictureBox> KartPanel;
        List<Label> KartPanelAciklama;
        List<Label> Bölümler;
        List<Label> ZamanSayaclari;
        StringBuilder Detaylar;
        ProgramTur FilmDetay;

        System.Windows.Forms.Panel önanapanel;
        System.Windows.Forms.Panel önyanpanel;
        System.Windows.Forms.ComboBox puanbox;

        int PicBoyutX = 185, PicBoyutY = 294;
        int LblBoyutX = 185, LblBoyutY = 40;
        int secilenBölümİndexi = -1;
        string KullaniciEposta;
        int kalinanBölüm = -1, kalinanZaman = -1;
        float puan = -1;
        int puanVermeKontrol = 0;

        public AnaForm()
        {
            InitializeComponent();
            FilmListesi = new List<string>();
            FilmDetay = new ProgramTur();
            oku = new BağlantıBilgileriOku();
            mysqlislemleri = new Mysqlislemleri(oku.password, oku.datasource, oku.port, oku.username);
            TurAramaSonucListesi = new List<string>();
            AnlikArama = new List<string>();
            ÖnerilenFilmListesi = new List<string>();
            Detaylar = new StringBuilder();
            Bölümler = new List<Label>();
            önyanpanel = new Panel();
            önanapanel = new Panel();
            ZamanSayaclari = new List<Label>();

            PanelOlustur(önanapanel);
            PanelOlustur(önyanpanel);

            this.tbllayoutönpanel.RowCount = 1;
            this.tbllayoutönpanel.ColumnCount = 1;
        }

        public void KullaniciGirisVerisiAl(string eposta)
        {
            // giriş formundan kullanıcnın girdiği e postayı çekme işlemi
            KullaniciEposta = eposta;
        }

        private void PanelKontrolEt(List<string> Liste, List<string> Liste2, Panel panel)
        {
            // önerilen listesi dikkate alınarak kart oluşturma işlemleri
            if (TurSecim == null)
            {
                if (Liste == null) Liste = FilmListesi;

                tbllayoutönpanel.Controls.Clear();
                tbllayoutönpanel.Controls.Add(panel);
                panel.Dock = DockStyle.Fill;
                panel.Visible = true;
                KartOlustur(Liste, null, panel);
            }
            else
            {
                tbllayoutönpanel.Controls.Clear();
                tbllayoutönpanel.Controls.Add(panel);
                panel.Dock = DockStyle.Fill;
                panel.Visible = true;
                KartOlustur(Liste, Liste2, panel);
            }
        }

        private void KartOlustur(List<string> Liste, List<string> Liste2, Panel panel)
        {
            // önanapanele uygun şekilde kartların oluşturulma işlemleri
            panel.Controls.Clear();
            int index = 1, Xartis = 0, Yartis = 0;
            KartPanel = new List<PictureBox>();
            KartPanelAciklama = new List<Label>();
            int X = 5, Y = 27;

            if (Liste2 != null)
            {
                ÖnerilenResimKartları(Liste2, panel, ref index, ref Xartis, ref Yartis, ref X, ref Y);

                if (ÖnerilenFilmListesi.Count % 5 == 0) Yartis = 450;
                else Yartis += 450;
                Xartis = 0;
                index = 1;

                NormalResimKartları(Liste, panel, ref index, ref Xartis, ref Yartis, ref X, ref Y);
            }
            else NormalResimKartları(Liste, panel, ref index, ref Xartis, ref Yartis, ref X, ref Y);
        }

        private void NormalResimKartları(List<string> Liste, Panel panel, ref int index, ref int Xartis, ref int Yartis, ref int X, ref int Y)
        {
            foreach (var Film in Liste)
            {
                // Kartların PictureBox kısmı
                System.Windows.Forms.PictureBox pcb = new PictureBox();
                pcb.Size = new System.Drawing.Size(PicBoyutX, PicBoyutY);
                pcb.Location = new System.Drawing.Point(X + Xartis, Y + Yartis);
                pcb.Image = Image.FromFile($"..\\resorce\\Film Kapakları\\{Film}.jpg");
                pcb.SizeMode = PictureBoxSizeMode.StretchImage;
                pcb.Click += new System.EventHandler(this.AnaSayfaFilmTıkla);
                pcb.Name = Film.ToString();

                // Kartların Label Kısmı
                System.Windows.Forms.Label label = new Label();
                label.Text = Film;
                label.ForeColor = Color.White;
                label.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular,
                    System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                label.Size = new System.Drawing.Size(LblBoyutX, LblBoyutY);
                label.Location = new System.Drawing.Point(X + Xartis, Y + PicBoyutY + Yartis);
                label.BackColor = Color.FromArgb(50, 50, 50);
                label.TextAlign = ContentAlignment.MiddleCenter;
                label.Click += new System.EventHandler(this.AnaSayfaFilmTıkla);
                label.Name = Film.ToString();

                Xartis += 220;
                if (index % 5 == 0 && index != 0)
                {
                    Yartis += 370;
                    Xartis = 0;
                }
                KartPanel.Add(pcb);
                KartPanelAciklama.Add(label);

                panel.Controls.Add(pcb);
                panel.Controls.Add(label);
                index++;
            }
        }

        private void ÖnerilenResimKartları(List<string> Liste2, Panel panel, ref int index, ref int Xartis, ref int Yartis, ref int X, ref int Y)
        {
            // önerilen filmler yazısının yazılması
            System.Windows.Forms.Label ÖnerilenlerYazisi = new Label();
            ÖnerilenlerYazisi.Text = "Sizin İçin Önerilenler";
            ÖnerilenlerYazisi.ForeColor = Color.White;
            ÖnerilenlerYazisi.Size = new System.Drawing.Size(300, 35);
            ÖnerilenlerYazisi.Location = new System.Drawing.Point(5, 10);
            ÖnerilenlerYazisi.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ÖnerilenlerYazisi.TextAlign = ContentAlignment.TopLeft;
            önanapanel.Controls.Add(ÖnerilenlerYazisi);

            X = 5;
            Y = 45;

            foreach (var Film in Liste2)
            {
                // Önerilen Kartların Picturebox Kısmı
                System.Windows.Forms.PictureBox pcbÖner = new PictureBox();
                pcbÖner.Size = new System.Drawing.Size(PicBoyutX, PicBoyutY);
                pcbÖner.Location = new System.Drawing.Point(X + Xartis, Y + Yartis);
                pcbÖner.Image = Image.FromFile($"..\\resorce\\Film Kapakları\\{Film}.jpg");
                pcbÖner.SizeMode = PictureBoxSizeMode.StretchImage;
                pcbÖner.Click += new System.EventHandler(this.AnaSayfaFilmTıkla);
                pcbÖner.Name = Film.ToString() + " önerilen";

                // Önerilen Kartların Label Kısmı
                System.Windows.Forms.Label lblÖner = new Label();
                lblÖner.Text = Film;
                lblÖner.ForeColor = Color.White;
                lblÖner.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular,
                    System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lblÖner.Size = new System.Drawing.Size(LblBoyutX, LblBoyutY);
                lblÖner.Location = new System.Drawing.Point(5 + Xartis, Y + PicBoyutY + Yartis);
                lblÖner.BackColor = Color.DarkRed;
                lblÖner.TextAlign = ContentAlignment.MiddleCenter;
                lblÖner.Click += new System.EventHandler(this.AnaSayfaFilmTıkla);
                lblÖner.Name = Film.ToString() + " önerilen";

                Xartis += 220;
                if (index % 5 == 0 && index != 0)
                {
                    Yartis += 370;
                    Xartis = 0;
                }
                KartPanel.Add(pcbÖner);
                KartPanelAciklama.Add(lblÖner);

                panel.Controls.Add(pcbÖner);
                panel.Controls.Add(lblÖner);
                index++;
            }
        }

        private void AnaSayfaFilmTıkla(object sender, EventArgs e)
        {
            // Hangi Resmin veya Labelin Seçildiğinin Bulunması
            int index = 0, index2 = 0;

            foreach (var pcb in KartPanel)
            {
                if (sender.GetHashCode() == pcb.GetHashCode()) break;
                index++;
            }

            foreach (var lbl in KartPanelAciklama)
            {
                if (sender.GetHashCode() == lbl.GetHashCode()) break;
                index2++;
            }

            if (index < KartPanel.Count)
            {
                if (KartPanel[index].Name.Contains(" önerilen"))
                {
                    string name = KartPanel[index].Name.Substring(0, KartPanel[index].Name.Length - 9);
                    DetaySayfasıOlustur(FilmListesi.IndexOf(name));
                }
                else
                {
                    DetaySayfasıOlustur(FilmListesi.IndexOf(KartPanel[index].Name));
                }
            }

            else if (index2 < KartPanelAciklama.Count)
            {
                if (KartPanel[index2].Name.Contains(" önerilen"))
                {
                    string name = KartPanel[index2].Name.Substring(0, KartPanel[index2].Name.Length - 9);
                    DetaySayfasıOlustur(FilmListesi.IndexOf(name));
                }
                else
                {
                    DetaySayfasıOlustur(FilmListesi.IndexOf(KartPanelAciklama[index2].Name));
                }
            }
        }

        private void DetaySayfasıOlustur(int index)
        {
            // önyanpanelin görünür kılınıp önanapanelin görünürlüğünü yoketmek
            tbllayoutönpanel.Controls.Remove(önanapanel);
            tbllayoutönpanel.Controls.Add(önyanpanel);
            önanapanel.Visible = false;
            önyanpanel.Visible = true;
            önyanpanel.Dock = DockStyle.Fill;

            //0. indeks Uzunluk 1. indeks BolumSayisi 2. index Puan
            mysqlislemleri.FilmDetay(FilmDetay, FilmListesi[index]);
            mysqlislemleri.Filmİzlenmismi(ref kalinanBölüm, ref kalinanZaman, KullaniciEposta, FilmDetay.ProgramAd);
            mysqlislemleri.PuanGöster(ref puan, KullaniciEposta, FilmDetay.ProgramAd);

            DetayStringiOlustur(FilmDetay);
            DetaySayfaComponentleri(index, FilmDetay.bölümsayisi);
            Detaylar.Clear();
            FilmDetay.Tur.Clear();
        }

        private void DetaySayfaComponentleri(int index, int bölümSayisi)
        {
            // Seçilen Filmin Resminin Bastırılması
            System.Windows.Forms.PictureBox SecilenFilmResmi = new PictureBox();
            SecilenFilmResmi.Size = new System.Drawing.Size(256, 390);
            SecilenFilmResmi.Location = new System.Drawing.Point(30, 85);
            SecilenFilmResmi.Image = Image.FromFile($"..\\resorce\\Film Kapakları\\{FilmListesi[index]}.jpg");
            SecilenFilmResmi.SizeMode = PictureBoxSizeMode.StretchImage;
            önyanpanel.Controls.Add(SecilenFilmResmi);

            // Film Ad Detay Kısmı
            System.Windows.Forms.Label SecilenFilmAd = new Label();
            SecilenFilmAd.Text = FilmListesi[index] + "\n";
            SecilenFilmAd.ForeColor = Color.White;
            SecilenFilmAd.Size = new System.Drawing.Size(370, 40);
            SecilenFilmAd.Location = new System.Drawing.Point(30, 480);
            SecilenFilmAd.TextAlign = ContentAlignment.TopLeft;
            önyanpanel.Controls.Add(SecilenFilmAd);

            // Film Tür ve Diğer Detaylar
            System.Windows.Forms.Label SecilenFilmDetay = new Label();
            SecilenFilmDetay.Text = Detaylar.ToString();
            SecilenFilmDetay.ForeColor = Color.White;
            SecilenFilmDetay.Size = new System.Drawing.Size(370, 180);
            SecilenFilmDetay.Location = new System.Drawing.Point(30, 520);
            SecilenFilmDetay.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            SecilenFilmDetay.TextAlign = ContentAlignment.TopLeft;
            önyanpanel.Controls.Add(SecilenFilmDetay);

            // Geri Çık Butonu
            System.Windows.Forms.Button geriCik = new Button();
            geriCik.BackColor = System.Drawing.Color.FromArgb(50, 50, 50);
            geriCik.ForeColor = Color.White;
            geriCik.FlatAppearance.BorderSize = 0;
            geriCik.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            geriCik.Font = new System.Drawing.Font("Arial", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            geriCik.Location = new System.Drawing.Point(30, 6);
            geriCik.Size = new System.Drawing.Size(113, 43);
            geriCik.Text = "Geri Çık";
            geriCik.UseVisualStyleBackColor = false;
            önyanpanel.Controls.Add(geriCik);
            geriCik.Click += new System.EventHandler(this.AnaSayfayaDön);

            //oynatma ve durduma, reset butonları
            System.Windows.Forms.PictureBox Oynat = new PictureBox();
            Oynat.Parent = önyanpanel;
            Oynat.BackColor = Color.Transparent;
            Oynat.Size = new System.Drawing.Size(50, 50);
            Oynat.Location = new System.Drawing.Point(415, 495);
            Oynat.Image = Image.FromFile("..\\resorce\\video butonları\\play.png");
            Oynat.SizeMode = PictureBoxSizeMode.StretchImage;
            Oynat.Click += new System.EventHandler(this.oynat);
            önyanpanel.Controls.Add(Oynat);

            // duraklat butonunun oluşturulması
            System.Windows.Forms.PictureBox Duraklat = new PictureBox();
            Duraklat.Parent = önyanpanel;
            Duraklat.BackColor = Color.Transparent;
            Duraklat.Size = new System.Drawing.Size(50, 50);
            Duraklat.Location = new System.Drawing.Point(480, 495);
            Duraklat.Image = Image.FromFile("..\\resorce\\video butonları\\stop.png");
            Duraklat.SizeMode = PictureBoxSizeMode.StretchImage;
            Duraklat.Click += new System.EventHandler(this.duraklat);
            önyanpanel.Controls.Add(Duraklat);

            // reset butonunun oluşturulması
            System.Windows.Forms.PictureBox Reset = new PictureBox();
            Reset.Parent = önyanpanel;
            Reset.BackColor = Color.Transparent;
            Reset.Size = new System.Drawing.Size(50, 50);
            Reset.Location = new System.Drawing.Point(545, 495);
            Reset.Image = Image.FromFile("..\\resorce\\video butonları\\reset.png");
            Reset.SizeMode = PictureBoxSizeMode.StretchImage;
            Reset.Click += new System.EventHandler(this.Sıfırla);
            önyanpanel.Controls.Add(Reset);

            // puan labeli ve puan listesi
            System.Windows.Forms.Label lblPuan = new Label();
            lblPuan.Parent = önyanpanel;
            lblPuan.Text = "Puan Ver : ";
            lblPuan.Size = new System.Drawing.Size(115, 50);
            lblPuan.Location = new System.Drawing.Point(415, 570);
            lblPuan.ForeColor = Color.White;
            lblPuan.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular,
                    System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            lblPuan.TextAlign = ContentAlignment.TopLeft;
            önyanpanel.Controls.Add(lblPuan);

            // puan verme kısmı oluşturulması
            puanbox = new ComboBox();
            puanbox.Size = new System.Drawing.Size(80, 50);
            puanbox.FlatStyle = FlatStyle.Flat;
            puanbox.DropDownStyle = ComboBoxStyle.DropDown;
            puanbox.Location = new System.Drawing.Point(535, 570);
            puanbox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular,
              System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            puanbox.BackColor = Color.FromArgb(32, 32, 32);
            puanbox.ForeColor = Color.White;
            puanbox.SelectedIndexChanged += new EventHandler(this.PuanKaydet);
            puanbox.Items.Add("");
            for (int i = 0; i <= 10; i++) puanbox.Items.Add(i.ToString());
            önyanpanel.Controls.Add(puanbox);

            int Yartislbl = 0;
            for (int i = 0; i < bölümSayisi; i++)
            {
                // bölüm labelleri
                System.Windows.Forms.Label lblBölümSayisi = new Label();
                lblBölümSayisi.Text = "Bölüm " + (i + 1);
                lblBölümSayisi.Name = "Bölüm " + (i + 1);
                lblBölümSayisi.ForeColor = Color.White;
                lblBölümSayisi.Size = new System.Drawing.Size(80, 40);
                lblBölümSayisi.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular,
                    System.Drawing.GraphicsUnit.Point, ((byte)(162)));
                lblBölümSayisi.Location = new System.Drawing.Point(970, 85 + Yartislbl);
                lblBölümSayisi.Click += new System.EventHandler(this.BölümSec);
                lblBölümSayisi.TextAlign = ContentAlignment.MiddleCenter;
                lblBölümSayisi.BackColor = Color.FromArgb(50, 50, 50);
                önyanpanel.Controls.Add(lblBölümSayisi);
                Bölümler.Add(lblBölümSayisi);
                Yartislbl += 50;

                // zaman labelleri 
                System.Windows.Forms.Label lblZamanSayaç = new Label();
                lblZamanSayaç.Text = 0.ToString(); ;
                lblZamanSayaç.Name = "Zaman " + (i + 1);
                lblZamanSayaç.ForeColor = Color.White;
                lblZamanSayaç.Size = new System.Drawing.Size(540, 390);
                lblZamanSayaç.Font = new System.Drawing.Font("Arial", 50F, System.Drawing.FontStyle.Bold,
                    System.Drawing.GraphicsUnit.Point, ((byte)(162)));
                lblZamanSayaç.Location = new System.Drawing.Point(415, 85);
                lblZamanSayaç.TextAlign = ContentAlignment.MiddleCenter;
                lblZamanSayaç.BackColor = Color.FromArgb(15, 15, 15);
                önyanpanel.Controls.Add(lblZamanSayaç);
                lblZamanSayaç.Visible = false;
                ZamanSayaclari.Add(lblZamanSayaç);
            }

            // kullanicinin kaldığı yerden başlaması
            if (kalinanBölüm != -1 && kalinanZaman != -1)
            {
                puanVermeKontrol = -1;
                Bölümler[kalinanBölüm - 1].BackColor = Color.FromArgb(229, 9, 20);
                ZamanSayaclari[kalinanBölüm - 1].Visible = true;
                ZamanSayaclari[kalinanBölüm - 1].Text = kalinanZaman.ToString();
                secilenBölümİndexi = kalinanBölüm - 1;
            }

            //kullanicinin verdiği puanı görmesi
            if(puan != -1) puanbox.Text = puan.ToString();
        }

        private void DetayStringiOlustur(ProgramTur FilmDetay)
        {
            // ön yan panel detay yazıları oluştur
            Detaylar.Clear();
            int denetim = 0;
            foreach (var detay in FilmDetay.Tur)
            {
                Detaylar.Append(FilmDetay.Tur[denetim]);
                if (denetim != FilmDetay.Tur.Count() - 1) Detaylar.Append(", ");
                denetim++;
            }
            Detaylar.Append("\n");
            Detaylar.Append("Tip : " + FilmDetay.Tip);
            if (FilmDetay.bölümsayisi > 1)
            {
                Detaylar.Append("\n");
                Detaylar.Append("Bölüm Sayısı : " + FilmDetay.bölümsayisi.ToString());
            }
            Detaylar.Append("\n");
            Detaylar.Append("Süre : " + FilmDetay.programuzunluk.ToString());
            Detaylar.Append("\n");
            Detaylar.Append("Puan : " + FilmDetay.Puan.ToString());
        }

        private void oynat(object sender, EventArgs e)
        {
            puanVermeKontrol = -1;
            // seçilen bölüme göre oynatma
            if (secilenBölümİndexi != -1)
            {
                if (mysqlislemleri.FilmİzletmeKontrolEt(KullaniciEposta, FilmDetay.ProgramAd) == 0)
                    mysqlislemleri.Filmİzletme(KullaniciEposta, FilmDetay.ProgramAd);

                if (FilmOynatma.Enabled == true) FilmOynatma.Start();
                else
                {
                    FilmOynatma.Enabled = true;
                    FilmOynatma.Start();
                }
            }
        }

        private void Sıfırla(object sender, EventArgs e)
        {
            // oynatılan filmi sıfırlama
            ZamanSayaclari[secilenBölümİndexi].Text = 0.ToString();
            FilmOynatma.Enabled = false;
            mysqlislemleri.FilmİzlemeDetayKaydet(KullaniciEposta, FilmDetay.ProgramAd,
                    Convert.ToInt32(ZamanSayaclari[secilenBölümİndexi].Text), secilenBölümİndexi + 1);
        }

        private void duraklat(object sender, EventArgs e)
        {
            // oynatılan filmi duraklatma
            if (secilenBölümİndexi != -1)
                FilmOynatma.Stop();
        }

        private void BölümSec(object sender, EventArgs e)
        {
            // film detay classından gelen bölüm sayısına göre bölüm seçme işlemi
            FilmOynatma.Enabled = false;
            int index = 0;
            foreach (var bölüm in Bölümler)
            {
                bölüm.BackColor = Color.FromArgb(50, 50, 50);
                if (sender.GetHashCode() == bölüm.GetHashCode())
                {
                    secilenBölümİndexi = index;
                }
                index++;
            }
            Bölümler[secilenBölümİndexi].BackColor = Color.FromArgb(229, 9, 20);
            foreach (var sayac in ZamanSayaclari)
                sayac.Visible = false;

            ZamanSayaclari[secilenBölümİndexi].Visible = true;
        }

        private void PuanKaydet(object sender, EventArgs e)
        {
            //puan kaydetme
            if(puanbox.Text != "" && secilenBölümİndexi != -1 && puanVermeKontrol==-1)
            {
                mysqlislemleri.PuanKaydet(KullaniciEposta,FilmDetay.ProgramAd,Convert.ToSingle(puanbox.Text));
            }
        }

        private void AnaSayfayaDön(object sender, EventArgs e)
        {
            // Ana Menüye Dönme işlemi
            Detaylar.Clear();
            önyanpanel.Controls.Clear();
            tbllayoutönpanel.Controls.Remove(önyanpanel);
            tbllayoutönpanel.Controls.Add(önanapanel);
            önanapanel.Visible = true;
            FilmOynatma.Enabled = false;
            Bölümler.Clear();
            secilenBölümİndexi = -1;
            ZamanSayaclari.Clear();
            kalinanBölüm = -1;
            kalinanZaman = -1;
            puan = -1;
            puanVermeKontrol = 0;
        }

        private void PanelOlustur(Panel panel)
        {
            // önanapanel ve önyanpanellerin oluşturulması
            panel.Anchor = AnchorStyles.Top;
            panel.Anchor = AnchorStyles.Left;
            panel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel.AutoScroll = true;
            panel.Visible = false;
        }

        public void ÖnerilenTurCek(List<string> TurSecim)
        {
            // kayıt sayfasında kullanıcının seçtiği türlerin çekilme işlemi
            this.TurSecim = TurSecim;
            ÖnerilenFilmListesi = mysqlislemleri.ÖnerilenFilmlerBul(TurSecim);
        }

        private void TurAraİslemi(string tur)
        {
            // formda yer alan tür yazılarına göre film getirme işlemi
            TurAramaSonucListesi = mysqlislemleri.TurAra(tur);
            PanelKontrolEt(TurAramaSonucListesi, ÖnerilenFilmListesi, önanapanel);
            TurAramaSonucListesi.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // textbox kısmından film aratıldığında film getirme işlemi 
            foreach (var Film in FilmListesi)
            {
                if (Film.ToLower().Contains(txtarama.Text.ToLower())) AnlikArama.Add(Film);
            }
            PanelKontrolEt(AnlikArama, ÖnerilenFilmListesi, önanapanel);
            AnlikArama.Clear();
        }

        private void lblanasayfa_Click(object sender, EventArgs e)
        {
            if (FilmListesi.Count * 2 != önanapanel.Controls.Count)
            {
                PanelKontrolEt(FilmListesi, ÖnerilenFilmListesi, önanapanel);
            }
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {
            FilmListesi = mysqlislemleri.FilmListele();
            PanelKontrolEt(FilmListesi, ÖnerilenFilmListesi, önanapanel);
        }

        private void FilmOynatma_Tick(object sender, EventArgs e)
        {
            // timera göre film oynatma işlemleri
            if (FilmDetay.programuzunluk > Convert.ToInt32(ZamanSayaclari[secilenBölümİndexi].Text))
            {
                ZamanSayaclari[secilenBölümİndexi].Text = (Convert.ToInt32(ZamanSayaclari[secilenBölümİndexi].Text) + 1).ToString();

                mysqlislemleri.FilmİzlemeDetayKaydet(KullaniciEposta, FilmDetay.ProgramAd,
                    Convert.ToInt32(ZamanSayaclari[secilenBölümİndexi].Text), secilenBölümİndexi + 1);
            }
            else FilmOynatma.Stop();
        }

        private void lblaksiyon_Click(object sender, EventArgs e)
        {
            TurAraİslemi("Aksiyon ve Macera");
        }

        private void lblbilimkurgu_Click(object sender, EventArgs e)
        {
            TurAraİslemi("Bilim Kurgu ve Fantastik");
        }

        private void lblbelgesel_Click(object sender, EventArgs e)
        {
            TurAraİslemi("Belgesel");
        }

        private void lblbilimvedoga_Click(object sender, EventArgs e)
        {
            TurAraİslemi("Bilim ve Doğa");
        }

        private void lbldrama_Click(object sender, EventArgs e)
        {
            TurAraİslemi("Drama");
        }

        private void lblgerilim_Click(object sender, EventArgs e)
        {
            TurAraİslemi("Gerilim");
        }

        private void lblkomedi_Click(object sender, EventArgs e)
        {
            TurAraİslemi("Komedi");
        }

        private void lblreality_Click(object sender, EventArgs e)
        {
            TurAraİslemi("Reality Program");
        }

        private void lblromantizm_Click(object sender, EventArgs e)
        {
            TurAraİslemi("Romantizm");
        }

        private void lblcocuk_Click(object sender, EventArgs e)
        {
            TurAraİslemi("Çocuk ve Aile");
        }

        private void lblanime_Click(object sender, EventArgs e)
        {
            TurAraİslemi("Anime");
        }

        private void lblkorku_Click(object sender, EventArgs e)
        {
            TurAraİslemi("Korku");
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pcbçıkışlogo_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}

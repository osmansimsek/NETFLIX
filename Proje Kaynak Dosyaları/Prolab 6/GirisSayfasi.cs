using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Runtime.CompilerServices;
using Prolab_6.Tablolar;

namespace Prolab_6
{
    public partial class GirisSayfasi : Form
    {
        private (bool secim, string ad) aksiyon = (false, "Aksiyon ve Macera");
        private (bool secim, string ad) komedi = (false, "Komedi");
        private (bool secim, string ad) belgesel = (false, "Belgesel");
        private (bool secim, string ad) bilimkurgu = (false, "Bilim Kurgu ve Fantastik");
        private (bool secim, string ad) doga = (false, "Bilim ve Doğa");
        private (bool secim, string ad) korku = (false, "Korku");
        private (bool secim, string ad) romantizim = (false, "Romantizm");
        private (bool secim, string ad) gerilim = (false, "Gerilim");
        private (bool secim, string ad) drama = (false, "Drama");
        private (bool secim, string ad) aile = (false, "Çocuk ve Aile");
        private (bool secim, string ad) anime = (false, "Anime");
        private (bool secim, string ad) reality = (false, "Reality Program");
        private int toplamSecim = 1;

        AnaForm anaSayfa;
        Mysqlislemleri mysql;
        BağlantıBilgileriOku oku;
        List<string> emails;
        List<string> TurSecim;

        public GirisSayfasi()
        {
            InitializeComponent();
            oku = new BağlantıBilgileriOku();
            mysql = new Mysqlislemleri(oku.password, oku.datasource, oku.port, oku.username);
            emails = new List<string>();
            TurSecim = new List<string>();
            emails = mysql.EmailKontrol();

            pnlkayıtSayfası.SuspendLayout();
            pnlkayıtSayfası2.SuspendLayout();

            Transparent();
            lblkayıtsorun.Text = "";
            lblkayıtbilgilendir.Text = "*Bir sonraki kategori bölümünde\n" +
                "3 kategori seçilmesi gerekmektedir.";
        }

        // labelların arkalarını transparent yapma
        private void Transparent()
        {

            lblgirisbilgilendir.Parent = pnlgirispaneli;
            lblgirisbilgilendir.BackColor = Color.Transparent;

            lblkayıtsorun.Parent = pnlkayıtSayfası;
            lblkayıtsorun.BackColor = Color.Transparent;

            lblkayıtbilgilendir.Parent = pnlkayıtSayfası;
            lblkayıtbilgilendir.BackColor = Color.Transparent;

            lblkayıt2bilgilendir.Parent = pnlkayıtSayfası2;
            lblkayıt2bilgilendir.BackColor = Color.Transparent;
        }


        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            if (mysql.baglanti == 0)
            {
                MessageBox.Show("Connection bilgileri doldurulmadan devam edilemez.", "Bağlanma Uyarısı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Application.Exit();
            }

            else
            {
                this.Controls.Clear();
                this.Controls.Add(pnlkayıtSayfası);
                pnlgirispaneli.SuspendLayout();
                pnlkayıtSayfası2.SuspendLayout();
            }
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (mysql.baglanti == 0)
            {
                MessageBox.Show("Connection bilgileri doldurulmadan devam edilemez.", "Bağlanma Uyarısı",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Application.Exit();
            }
            if (txtgiriseposta.Text == "" && txtgirissifre.Text == "")
            {
                lblgirisbilgilendir.Text = "*Şifre ve e-posta kısımları \n" +
                    " doldurulmadan devam edilemez!!";
            }
            else
            {
                bool girisyapsinmi;
                girisyapsinmi = mysql.GirisYap(txtgiriseposta.Text, txtgirissifre.Text);

                if (girisyapsinmi == true)
                {
                    anaSayfa = new AnaForm();
                    anaSayfa.KullaniciGirisVerisiAl(txtgiriseposta.Text);
                    this.Owner = anaSayfa;
                    anaSayfa.Show();
                    this.Hide();
                }
                else
                    lblgirisbilgilendir.Text = "*Kullanıcı bulunamadı !!";
            }
        }

        // kullanici kayıt formunu doldururuken kontrol edilme işlemleri
        private int KayıtKontrol()
        {
            if (txtkayıteposta.Text != "" && txtkayıtsifre.Text != "" && txtkayıtad.Text != "" && txtkayıtdgtarih.Text != "")
            {
                foreach (var item in emails)
                    if (txtkayıteposta.Text == item) return 4;


                if (txtkayıtdgtarih.Text.IndexOf(" ") != -1)
                    return 3;

                if (1900 >= Convert.ToInt32(txtkayıtdgtarih.Text.Substring(0, 4)) || 2020 < Convert.ToInt32(txtkayıtdgtarih.Text.Substring(0, 4))) return 5;
                else if (0 >= Convert.ToInt32(txtkayıtdgtarih.Text.Substring(5, 2)) || 12 < Convert.ToInt32(txtkayıtdgtarih.Text.Substring(5, 2))) return 5;
                else if (0 >= Convert.ToInt32(txtkayıtdgtarih.Text.Substring(8, 2)) || 31 < Convert.ToInt32(txtkayıtdgtarih.Text.Substring(8, 2))) return 5;

                string eposta = txtkayıteposta.Text;
                int index1 = eposta.IndexOf("@");

                if (index1 == 0 || index1 == -1)
                    return 2;

                else
                {
                    int index2 = eposta.IndexOf(".com");

                    if (index2 - index1 > 1)
                        return 0;

                    else
                        return 2;
                }
            }
            return 1;
        }

        private void btnDevamEt_Click(object sender, EventArgs e)
        {
            int denetim = 0;
            denetim = KayıtKontrol();

            if (denetim == 1)
            {
                lblkayıtsorun.Text = "*Yukarıdaki alanlar \n" +
                    " doldurulmadan devam edilemez!!";
            }
            else if (denetim == 2)
            {
                lblkayıtsorun.Text = "e posta alanını yanlış doldurdunuz.\n" +
                    " lütfen tekrar giriniz.";
            }
            else if (denetim == 3)
            {
                lblkayıtsorun.Text = "date kısmını eksik doldurdunuz. \n" +
                    "yıl-ay-gün şeklinde boş kalmıcak\nşekilde doldurulmalıdır.";
            }
            else if (denetim == 4)
            {
                lblkayıtsorun.Text = "Bu e-posta sistemde kayıtlıdır.\n" +
                    "Lütfen tekrar e-posta giriniz";
            }
            else if (denetim == 5)
            {
                lblkayıtsorun.Text = "Tarih Kısmını Yanlış Doldurdunuz.\n" +
                    "Yıl en az 1900 en fazla 2020 olabilir. \n" +
                    "Ay ve gün kısımlarınada normal \ndeğerler giriniz.";
            }
            else
            {
                this.Controls.Clear();
                this.Controls.Add(pnlkayıtSayfası2);
                pnlgirispaneli.SuspendLayout();
                pnlkayıtSayfası.SuspendLayout();
            }
        }

        private void btngeri_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(pnlgirispaneli);
            pnlkayıtSayfası.SuspendLayout();
            pnlkayıtSayfası2.SuspendLayout();
        }

        // son kayıt sayfasındaki türlerden hangisini seçtiğini bulma
        private void TurSecimKontrol(ref (bool secim, string ad) tur, Label lbl, PictureBox pic)
        {
            if (tur.secim == false && toplamSecim < 4)
            {
                toplamSecim += 1;
                tur.secim = true;
                TurSecim.Add(tur.ad);
                lbl.BackColor = Color.FromArgb(229, 9, 20);
                pic.BackColor = Color.FromArgb(229, 9, 20);
            }
            else if (tur.secim == true)
            {
                toplamSecim -= 1;
                tur.secim = false;
                TurSecim.Remove(tur.ad);
                lbl.BackColor = Color.FromArgb(105, 105, 105);
                pic.BackColor = Color.FromArgb(105, 105, 105);
            }
        }

        private void btnkayıt2KayitKaydet_Click(object sender, EventArgs e)
        {
            if (toplamSecim == 4)
            {
                mysql.KayitOl(txtkayıtad.Text, txtkayıteposta.Text, txtkayıtsifre.Text, txtkayıtdgtarih.Text);
                anaSayfa = new AnaForm();
                anaSayfa.ÖnerilenTurCek(TurSecim);
                anaSayfa.KullaniciGirisVerisiAl(txtkayıteposta.Text);
                this.Owner = anaSayfa;
                anaSayfa.Show();
                this.Hide();
            }
            else lblkayıt2bilgilendir.Text = "3 farklı tür seçmeniz\ngerekmektedir.";
        }

        private void lblkayıt2aksiyon_Click(object sender, EventArgs e)
        {
            TurSecimKontrol(ref aksiyon, lblkayıt2aksiyon, pickayıt2aksiyon);
        }

        private void lblkayıt2bilimvedoga_Click(object sender, EventArgs e)
        {
            TurSecimKontrol(ref doga, lblkayıt2bilimvedoga, pickayıt2bilimvedoga);
        }

        private void lblkayıt2komedi_Click(object sender, EventArgs e)
        {
            TurSecimKontrol(ref komedi, lblkayıt2komedi, pickayıt2komedi);
        }

        private void lblkayıt2cocukveaile_Click(object sender, EventArgs e)
        {
            TurSecimKontrol(ref aile, lblkayıt2cocukveaile, pickayıt2cocuk);
        }

        private void lblkayıt2belgesel_Click(object sender, EventArgs e)
        {
            TurSecimKontrol(ref belgesel, lblkayıt2belgesel, pickayıt2belgesel);
        }

        private void lblkayıt2gerilim_Click(object sender, EventArgs e)
        {
            TurSecimKontrol(ref gerilim, lblkayıt2gerilim, pickayıt2gerilim);
        }

        private void lblkayıt2korku_Click(object sender, EventArgs e)
        {
            TurSecimKontrol(ref korku, lblkayıt2korku, pickayıt2korku);
        }

        private void lblkayıt2romantizim_Click(object sender, EventArgs e)
        {
            TurSecimKontrol(ref romantizim, lblkayıt2romantizim, pickayıt2romantizim);
        }

        private void lblkayıt2bilimkurgu_Click(object sender, EventArgs e)
        {
            TurSecimKontrol(ref bilimkurgu, lblkayıt2bilimkurgu, pickayıt2bilimkurgu);
        }

        private void lblkayıt2drama_Click(object sender, EventArgs e)
        {
            TurSecimKontrol(ref drama, lblkayıt2drama, pickayıt2drama);
        }

        private void lblkayıt2reality_Click(object sender, EventArgs e)
        {
            TurSecimKontrol(ref reality, lblkayıt2reality, pickayıt2reality);
        }

        private void lblkayıt2anime_Click(object sender, EventArgs e)
        {
            TurSecimKontrol(ref anime, lblkayıt2anime, pickayıt2anime);
        }

    }
}

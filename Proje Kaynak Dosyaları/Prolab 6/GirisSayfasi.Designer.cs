using System.Drawing;
using System.Windows.Forms;

namespace Prolab_6
{
    partial class GirisSayfasi
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GirisSayfasi));
            this.pnlgirispaneli = new System.Windows.Forms.Panel();
            this.lblgirissifre = new System.Windows.Forms.Label();
            this.lblgiriseposta = new System.Windows.Forms.Label();
            this.txtgirissifre = new System.Windows.Forms.TextBox();
            this.txtgiriseposta = new System.Windows.Forms.TextBox();
            this.btngirisKayitOl = new System.Windows.Forms.Button();
            this.btngirisGiris = new System.Windows.Forms.Button();
            this.lblgirisbilgilendir = new System.Windows.Forms.Label();
            this.pnlkayıtSayfası2 = new System.Windows.Forms.Panel();
            this.lblkayıt2bilgilendir = new System.Windows.Forms.Label();
            this.pickayıt2anime = new System.Windows.Forms.PictureBox();
            this.pickayıt2reality = new System.Windows.Forms.PictureBox();
            this.lblkayıt2anime = new System.Windows.Forms.Label();
            this.lblkayıt2reality = new System.Windows.Forms.Label();
            this.btnkayıt2kayıtol = new System.Windows.Forms.Button();
            this.pickayıt2drama = new System.Windows.Forms.PictureBox();
            this.pickayıt2bilimkurgu = new System.Windows.Forms.PictureBox();
            this.pickayıt2romantizim = new System.Windows.Forms.PictureBox();
            this.pickayıt2korku = new System.Windows.Forms.PictureBox();
            this.pickayıt2gerilim = new System.Windows.Forms.PictureBox();
            this.pickayıt2cocuk = new System.Windows.Forms.PictureBox();
            this.pickayıt2bilimvedoga = new System.Windows.Forms.PictureBox();
            this.pickayıt2belgesel = new System.Windows.Forms.PictureBox();
            this.pickayıt2komedi = new System.Windows.Forms.PictureBox();
            this.pickayıt2aksiyon = new System.Windows.Forms.PictureBox();
            this.lblkayıt2drama = new System.Windows.Forms.Label();
            this.lblkayıt2romantizim = new System.Windows.Forms.Label();
            this.lblkayıt2gerilim = new System.Windows.Forms.Label();
            this.lblkayıt2cocukveaile = new System.Windows.Forms.Label();
            this.lblkayıt2bilimkurgu = new System.Windows.Forms.Label();
            this.lblkayıt2korku = new System.Windows.Forms.Label();
            this.lblkayıt2belgesel = new System.Windows.Forms.Label();
            this.lblkayıt2komedi = new System.Windows.Forms.Label();
            this.lblkayıt2bilimvedoga = new System.Windows.Forms.Label();
            this.lblkayıt2aksiyon = new System.Windows.Forms.Label();
            this.pnlkayıtSayfası = new System.Windows.Forms.Panel();
            this.btnkayıtgeri = new System.Windows.Forms.Button();
            this.txtkayıtdgtarih = new System.Windows.Forms.MaskedTextBox();
            this.lblkayıtdgtarihi = new System.Windows.Forms.Label();
            this.lblkayıtad = new System.Windows.Forms.Label();
            this.txtkayıtad = new System.Windows.Forms.TextBox();
            this.lblkayıtbilgilendir = new System.Windows.Forms.Label();
            this.lblkayıtsorun = new System.Windows.Forms.Label();
            this.btnkayıtdevamet = new System.Windows.Forms.Button();
            this.lblkayıtsifre = new System.Windows.Forms.Label();
            this.lblkayıteposta = new System.Windows.Forms.Label();
            this.txtkayıtsifre = new System.Windows.Forms.TextBox();
            this.txtkayıteposta = new System.Windows.Forms.TextBox();
            this.pnlgirispaneli.SuspendLayout();
            this.pnlkayıtSayfası2.SuspendLayout();
            this.pnlkayıtSayfası.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlgirispaneli
            // 
            this.pnlgirispaneli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.pnlgirispaneli.BackgroundImage = Image.FromFile("..\\resorce\\arkaplan ve icon\\Netflix arkaplan.jpg");
            this.pnlgirispaneli.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlgirispaneli.Controls.Add(this.lblgirissifre);
            this.pnlgirispaneli.Controls.Add(this.lblgiriseposta);
            this.pnlgirispaneli.Controls.Add(this.txtgirissifre);
            this.pnlgirispaneli.Controls.Add(this.txtgiriseposta);
            this.pnlgirispaneli.Controls.Add(this.btngirisKayitOl);
            this.pnlgirispaneli.Controls.Add(this.btngirisGiris);
            this.pnlgirispaneli.Controls.Add(this.lblgirisbilgilendir);
            this.pnlgirispaneli.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlgirispaneli.Location = new System.Drawing.Point(0, 0);
            this.pnlgirispaneli.Name = "pnlgirispaneli";
            this.pnlgirispaneli.Size = new System.Drawing.Size(782, 553);
            this.pnlgirispaneli.TabIndex = 1;
            // 
            // lblgirissifre
            // 
            this.lblgirissifre.AutoSize = true;
            this.lblgirissifre.BackColor = System.Drawing.Color.Transparent;
            this.lblgirissifre.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblgirissifre.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblgirissifre.Location = new System.Drawing.Point(268, 333);
            this.lblgirissifre.Name = "lblgirissifre";
            this.lblgirissifre.Size = new System.Drawing.Size(66, 26);
            this.lblgirissifre.TabIndex = 10;
            this.lblgirissifre.Text = "Şifre:";
            // 
            // lblgiriseposta
            // 
            this.lblgiriseposta.AutoSize = true;
            this.lblgiriseposta.BackColor = System.Drawing.Color.Transparent;
            this.lblgiriseposta.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblgiriseposta.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblgiriseposta.Location = new System.Drawing.Point(268, 254);
            this.lblgiriseposta.Name = "lblgiriseposta";
            this.lblgiriseposta.Size = new System.Drawing.Size(99, 26);
            this.lblgiriseposta.TabIndex = 11;
            this.lblgiriseposta.Text = "E Posta:";
            // 
            // txtgirissifre
            // 
            this.txtgirissifre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.txtgirissifre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtgirissifre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtgirissifre.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.txtgirissifre.Location = new System.Drawing.Point(271, 368);
            this.txtgirissifre.Name = "txtgirissifre";
            this.txtgirissifre.Size = new System.Drawing.Size(245, 30);
            this.txtgirissifre.TabIndex = 1;
            this.txtgirissifre.UseSystemPasswordChar = true;
            // 
            // txtgiriseposta
            // 
            this.txtgiriseposta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.txtgiriseposta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtgiriseposta.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtgiriseposta.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.txtgiriseposta.Location = new System.Drawing.Point(271, 289);
            this.txtgiriseposta.Name = "txtgiriseposta";
            this.txtgiriseposta.Size = new System.Drawing.Size(245, 30);
            this.txtgiriseposta.TabIndex = 0;
            // 
            // btngirisKayitOl
            // 
            this.btngirisKayitOl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(9)))), ((int)(((byte)(20)))));
            this.btngirisKayitOl.FlatAppearance.BorderSize = 0;
            this.btngirisKayitOl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngirisKayitOl.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btngirisKayitOl.Location = new System.Drawing.Point(403, 421);
            this.btngirisKayitOl.Name = "btngirisKayitOl";
            this.btngirisKayitOl.Size = new System.Drawing.Size(113, 43);
            this.btngirisKayitOl.TabIndex = 3;
            this.btngirisKayitOl.Text = "Kayıt Ol";
            this.btngirisKayitOl.UseVisualStyleBackColor = false;
            this.btngirisKayitOl.Click += new System.EventHandler(this.btnKayitOl_Click);
            // 
            // btngirisGiris
            // 
            this.btngirisGiris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(9)))), ((int)(((byte)(20)))));
            this.btngirisGiris.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(9)))), ((int)(((byte)(20)))));
            this.btngirisGiris.FlatAppearance.BorderSize = 0;
            this.btngirisGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngirisGiris.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btngirisGiris.Location = new System.Drawing.Point(271, 421);
            this.btngirisGiris.Name = "btngirisGiris";
            this.btngirisGiris.Size = new System.Drawing.Size(117, 43);
            this.btngirisGiris.TabIndex = 2;
            this.btngirisGiris.Text = "Giris";
            this.btngirisGiris.UseVisualStyleBackColor = false;
            this.btngirisGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // lblgirisbilgilendir
            // 
            this.lblgirisbilgilendir.AutoSize = true;
            this.lblgirisbilgilendir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
            this.lblgirisbilgilendir.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblgirisbilgilendir.Location = new System.Drawing.Point(267, 487);
            this.lblgirisbilgilendir.MinimumSize = new System.Drawing.Size(247, 40);
            this.lblgirisbilgilendir.Name = "lblgirisbilgilendir";
            this.lblgirisbilgilendir.Size = new System.Drawing.Size(247, 40);
            this.lblgirisbilgilendir.TabIndex = 3;
            // 
            // pnlkayıtSayfası2
            // 
            this.pnlkayıtSayfası2.BackgroundImage = Image.FromFile("..\\resorce\\arkaplan ve icon\\KayıtSayfası.jpg");
            this.pnlkayıtSayfası2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlkayıtSayfası2.Controls.Add(this.lblkayıt2bilgilendir);
            this.pnlkayıtSayfası2.Controls.Add(this.pickayıt2anime);
            this.pnlkayıtSayfası2.Controls.Add(this.pickayıt2reality);
            this.pnlkayıtSayfası2.Controls.Add(this.lblkayıt2anime);
            this.pnlkayıtSayfası2.Controls.Add(this.lblkayıt2reality);
            this.pnlkayıtSayfası2.Controls.Add(this.btnkayıt2kayıtol);
            this.pnlkayıtSayfası2.Controls.Add(this.pickayıt2drama);
            this.pnlkayıtSayfası2.Controls.Add(this.pickayıt2bilimkurgu);
            this.pnlkayıtSayfası2.Controls.Add(this.pickayıt2romantizim);
            this.pnlkayıtSayfası2.Controls.Add(this.pickayıt2korku);
            this.pnlkayıtSayfası2.Controls.Add(this.pickayıt2gerilim);
            this.pnlkayıtSayfası2.Controls.Add(this.pickayıt2cocuk);
            this.pnlkayıtSayfası2.Controls.Add(this.pickayıt2bilimvedoga);
            this.pnlkayıtSayfası2.Controls.Add(this.pickayıt2belgesel);
            this.pnlkayıtSayfası2.Controls.Add(this.pickayıt2komedi);
            this.pnlkayıtSayfası2.Controls.Add(this.pickayıt2aksiyon);
            this.pnlkayıtSayfası2.Controls.Add(this.lblkayıt2drama);
            this.pnlkayıtSayfası2.Controls.Add(this.lblkayıt2romantizim);
            this.pnlkayıtSayfası2.Controls.Add(this.lblkayıt2gerilim);
            this.pnlkayıtSayfası2.Controls.Add(this.lblkayıt2cocukveaile);
            this.pnlkayıtSayfası2.Controls.Add(this.lblkayıt2bilimkurgu);
            this.pnlkayıtSayfası2.Controls.Add(this.lblkayıt2korku);
            this.pnlkayıtSayfası2.Controls.Add(this.lblkayıt2belgesel);
            this.pnlkayıtSayfası2.Controls.Add(this.lblkayıt2komedi);
            this.pnlkayıtSayfası2.Controls.Add(this.lblkayıt2bilimvedoga);
            this.pnlkayıtSayfası2.Controls.Add(this.lblkayıt2aksiyon);
            this.pnlkayıtSayfası2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlkayıtSayfası2.Location = new System.Drawing.Point(0, 0);
            this.pnlkayıtSayfası2.Name = "pnlkayıtSayfası2";
            this.pnlkayıtSayfası2.Size = new System.Drawing.Size(782, 553);
            this.pnlkayıtSayfası2.TabIndex = 6;
            // 
            // lblkayıt2bilgilendir
            // 
            this.lblkayıt2bilgilendir.AutoSize = true;
            this.lblkayıt2bilgilendir.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblkayıt2bilgilendir.Location = new System.Drawing.Point(106, 451);
            this.lblkayıt2bilgilendir.MinimumSize = new System.Drawing.Size(250, 40);
            this.lblkayıt2bilgilendir.Name = "lblkayıt2bilgilendir";
            this.lblkayıt2bilgilendir.Size = new System.Drawing.Size(250, 40);
            this.lblkayıt2bilgilendir.TabIndex = 51;
            // 
            // pickayıt2anime
            // 
            this.pickayıt2anime.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pickayıt2anime.Image = Image.FromFile("..\\resorce\\kategoriler\\anime.jpg");
            this.pickayıt2anime.Location = new System.Drawing.Point(598, 306);
            this.pickayıt2anime.Name = "pickayıt2anime";
            this.pickayıt2anime.Size = new System.Drawing.Size(90, 60);
            this.pickayıt2anime.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pickayıt2anime.TabIndex = 50;
            this.pickayıt2anime.TabStop = false;
            // 
            // pickayıt2reality
            // 
            this.pickayıt2reality.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pickayıt2reality.Image = Image.FromFile("..\\resorce\\kategoriler\\reality.jpg");
            this.pickayıt2reality.Location = new System.Drawing.Point(598, 375);
            this.pickayıt2reality.Name = "pickayıt2reality";
            this.pickayıt2reality.Size = new System.Drawing.Size(90, 60);
            this.pickayıt2reality.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pickayıt2reality.TabIndex = 49;
            this.pickayıt2reality.TabStop = false;
            // 
            // lblkayıt2anime
            // 
            this.lblkayıt2anime.AutoSize = true;
            this.lblkayıt2anime.BackColor = System.Drawing.Color.DimGray;
            this.lblkayıt2anime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblkayıt2anime.Location = new System.Drawing.Point(476, 320);
            this.lblkayıt2anime.MinimumSize = new System.Drawing.Size(180, 35);
            this.lblkayıt2anime.Name = "lblkayıt2anime";
            this.lblkayıt2anime.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblkayıt2anime.Size = new System.Drawing.Size(180, 35);
            this.lblkayıt2anime.TabIndex = 10;
            this.lblkayıt2anime.Text = "Anime";
            this.lblkayıt2anime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblkayıt2anime.Click += new System.EventHandler(this.lblkayıt2anime_Click);
            // 
            // lblkayıt2reality
            // 
            this.lblkayıt2reality.AutoSize = true;
            this.lblkayıt2reality.BackColor = System.Drawing.Color.DimGray;
            this.lblkayıt2reality.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblkayıt2reality.Location = new System.Drawing.Point(475, 387);
            this.lblkayıt2reality.MinimumSize = new System.Drawing.Size(180, 35);
            this.lblkayıt2reality.Name = "lblkayıt2reality";
            this.lblkayıt2reality.Padding = new System.Windows.Forms.Padding(10, 0, 0, 2);
            this.lblkayıt2reality.Size = new System.Drawing.Size(180, 38);
            this.lblkayıt2reality.TabIndex = 12;
            this.lblkayıt2reality.Text = "Reality \r\nProgram";
            this.lblkayıt2reality.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblkayıt2reality.Click += new System.EventHandler(this.lblkayıt2reality_Click);
            // 
            // btnkayıt2kayıtol
            // 
            this.btnkayıt2kayıtol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnkayıt2kayıtol.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnkayıt2kayıtol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnkayıt2kayıtol.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnkayıt2kayıtol.ForeColor = System.Drawing.SystemColors.Control;
            this.btnkayıt2kayıtol.Location = new System.Drawing.Point(568, 451);
            this.btnkayıt2kayıtol.Name = "btnkayıt2kayıtol";
            this.btnkayıt2kayıtol.Size = new System.Drawing.Size(120, 37);
            this.btnkayıt2kayıtol.TabIndex = 13;
            this.btnkayıt2kayıtol.Text = "Kaydet";
            this.btnkayıt2kayıtol.UseVisualStyleBackColor = false;
            this.btnkayıt2kayıtol.Click += new System.EventHandler(this.btnkayıt2KayitKaydet_Click);
            // 
            // pickayıt2drama
            // 
            this.pickayıt2drama.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pickayıt2drama.Image = Image.FromFile("..\\resorce\\kategoriler\\drama.jpg");
            this.pickayıt2drama.Location = new System.Drawing.Point(598, 168);
            this.pickayıt2drama.Name = "pickayıt2drama";
            this.pickayıt2drama.Size = new System.Drawing.Size(90, 60);
            this.pickayıt2drama.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pickayıt2drama.TabIndex = 46;
            this.pickayıt2drama.TabStop = false;
            // 
            // pickayıt2bilimkurgu
            // 
            this.pickayıt2bilimkurgu.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pickayıt2bilimkurgu.Image = Image.FromFile("..\\resorce\\kategoriler\\bilim_kurgu.png");
            this.pickayıt2bilimkurgu.Location = new System.Drawing.Point(225, 375);
            this.pickayıt2bilimkurgu.Name = "pickayıt2bilimkurgu";
            this.pickayıt2bilimkurgu.Size = new System.Drawing.Size(90, 60);
            this.pickayıt2bilimkurgu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pickayıt2bilimkurgu.TabIndex = 45;
            this.pickayıt2bilimkurgu.TabStop = false;
            // 
            // pickayıt2romantizim
            // 
            this.pickayıt2romantizim.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pickayıt2romantizim.Image = Image.FromFile("..\\resorce\\kategoriler\\romantizm.jpg");
            this.pickayıt2romantizim.Location = new System.Drawing.Point(225, 238);
            this.pickayıt2romantizim.Name = "pickayıt2romantizim";
            this.pickayıt2romantizim.Size = new System.Drawing.Size(90, 60);
            this.pickayıt2romantizim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pickayıt2romantizim.TabIndex = 44;
            this.pickayıt2romantizim.TabStop = false;
            // 
            // pickayıt2korku
            // 
            this.pickayıt2korku.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pickayıt2korku.Image = Image.FromFile("..\\resorce\\kategoriler\\korku.jpeg");
            this.pickayıt2korku.Location = new System.Drawing.Point(598, 101);
            this.pickayıt2korku.Name = "pickayıt2korku";
            this.pickayıt2korku.Size = new System.Drawing.Size(90, 60); 
            this.pickayıt2korku.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pickayıt2korku.TabIndex = 43;
            this.pickayıt2korku.TabStop = false;
            // 
            // pickayıt2gerilim
            // 
            this.pickayıt2gerilim.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pickayıt2gerilim.Image = Image.FromFile("..\\resorce\\kategoriler\\gerilim.jpg");
            this.pickayıt2gerilim.Location = new System.Drawing.Point(598, 238);
            this.pickayıt2gerilim.Name = "pickayıt2gerilim";
            this.pickayıt2gerilim.Size = new System.Drawing.Size(90, 60);
            this.pickayıt2gerilim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pickayıt2gerilim.TabIndex = 42;
            this.pickayıt2gerilim.TabStop = false;
            // 
            // pickayıt2cocuk
            // 
            this.pickayıt2cocuk.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pickayıt2cocuk.Image = Image.FromFile("..\\resorce\\kategoriler\\cocukveaile.jpg");
            this.pickayıt2cocuk.Location = new System.Drawing.Point(598, 32);
            this.pickayıt2cocuk.Name = "pickayıt2cocuk";
            this.pickayıt2cocuk.Size = new System.Drawing.Size(90, 60);
            this.pickayıt2cocuk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pickayıt2cocuk.TabIndex = 41;
            this.pickayıt2cocuk.TabStop = false;
            // 
            // pickayıt2bilimvedoga
            // 
            this.pickayıt2bilimvedoga.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pickayıt2bilimvedoga.Image = Image.FromFile("..\\resorce\\kategoriler\\bilimvedoga.jpg");
            this.pickayıt2bilimvedoga.Location = new System.Drawing.Point(225, 306);
            this.pickayıt2bilimvedoga.Name = "pickayıt2bilimvedoga";
            this.pickayıt2bilimvedoga.Size = new System.Drawing.Size(90, 60);
            this.pickayıt2bilimvedoga.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pickayıt2bilimvedoga.TabIndex = 40;
            this.pickayıt2bilimvedoga.TabStop = false;
            // 
            // pickayıt2belgesel
            // 
            this.pickayıt2belgesel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pickayıt2belgesel.Image = Image.FromFile("..\\resorce\\kategoriler\\belgesel.jpg");
            this.pickayıt2belgesel.Location = new System.Drawing.Point(225, 168);
            this.pickayıt2belgesel.Name = "pickayıt2belgesel";
            this.pickayıt2belgesel.Size = new System.Drawing.Size(90, 60);
            this.pickayıt2belgesel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pickayıt2belgesel.TabIndex = 39;
            this.pickayıt2belgesel.TabStop = false;
            // 
            // pickayıt2komedi
            // 
            this.pickayıt2komedi.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pickayıt2komedi.Image = Image.FromFile("..\\resorce\\kategoriler\\komedi.jpg");
            this.pickayıt2komedi.Location = new System.Drawing.Point(224, 100);
            this.pickayıt2komedi.Name = "pickayıt2komedi";
            this.pickayıt2komedi.Size = new System.Drawing.Size(90, 60);
            this.pickayıt2komedi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pickayıt2komedi.TabIndex = 38;
            this.pickayıt2komedi.TabStop = false;
            // 
            // pickayıt2aksiyon
            // 
            this.pickayıt2aksiyon.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pickayıt2aksiyon.Image = Image.FromFile("..\\resorce\\kategoriler\\aksiyon.jpg");
            this.pickayıt2aksiyon.Location = new System.Drawing.Point(224, 32);
            this.pickayıt2aksiyon.Name = "pickayıt2aksiyon";
            this.pickayıt2aksiyon.Size = new System.Drawing.Size(90, 60);
            this.pickayıt2aksiyon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pickayıt2aksiyon.TabIndex = 37;
            this.pickayıt2aksiyon.TabStop = false;
            // 
            // lblkayıt2drama
            // 
            this.lblkayıt2drama.AutoSize = true;
            this.lblkayıt2drama.BackColor = System.Drawing.Color.DimGray;
            this.lblkayıt2drama.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblkayıt2drama.Location = new System.Drawing.Point(475, 182);
            this.lblkayıt2drama.MinimumSize = new System.Drawing.Size(180, 35);
            this.lblkayıt2drama.Name = "lblkayıt2drama";
            this.lblkayıt2drama.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblkayıt2drama.Size = new System.Drawing.Size(180, 35);
            this.lblkayıt2drama.TabIndex = 6;
            this.lblkayıt2drama.Text = "Drama";
            this.lblkayıt2drama.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblkayıt2drama.Click += new System.EventHandler(this.lblkayıt2drama_Click);
            // 
            // lblkayıt2romantizim
            // 
            this.lblkayıt2romantizim.AutoSize = true;
            this.lblkayıt2romantizim.BackColor = System.Drawing.Color.DimGray;
            this.lblkayıt2romantizim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblkayıt2romantizim.Location = new System.Drawing.Point(105, 251);
            this.lblkayıt2romantizim.MinimumSize = new System.Drawing.Size(180, 35);
            this.lblkayıt2romantizim.Name = "lblkayıt2romantizim";
            this.lblkayıt2romantizim.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblkayıt2romantizim.Size = new System.Drawing.Size(180, 35);
            this.lblkayıt2romantizim.TabIndex = 7;
            this.lblkayıt2romantizim.Text = "Romantizim";
            this.lblkayıt2romantizim.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblkayıt2romantizim.Click += new System.EventHandler(this.lblkayıt2romantizim_Click);
            // 
            // lblkayıt2gerilim
            // 
            this.lblkayıt2gerilim.AutoSize = true;
            this.lblkayıt2gerilim.BackColor = System.Drawing.Color.DimGray;
            this.lblkayıt2gerilim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblkayıt2gerilim.Location = new System.Drawing.Point(477, 251);
            this.lblkayıt2gerilim.MinimumSize = new System.Drawing.Size(180, 35);
            this.lblkayıt2gerilim.Name = "lblkayıt2gerilim";
            this.lblkayıt2gerilim.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblkayıt2gerilim.Size = new System.Drawing.Size(180, 35);
            this.lblkayıt2gerilim.TabIndex = 8;
            this.lblkayıt2gerilim.Text = "Gerilim";
            this.lblkayıt2gerilim.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblkayıt2gerilim.Click += new System.EventHandler(this.lblkayıt2gerilim_Click);
            // 
            // lblkayıt2cocukveaile
            // 
            this.lblkayıt2cocukveaile.AutoSize = true;
            this.lblkayıt2cocukveaile.BackColor = System.Drawing.Color.DimGray;
            this.lblkayıt2cocukveaile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblkayıt2cocukveaile.Location = new System.Drawing.Point(475, 46);
            this.lblkayıt2cocukveaile.MinimumSize = new System.Drawing.Size(180, 35);
            this.lblkayıt2cocukveaile.Name = "lblkayıt2cocukveaile";
            this.lblkayıt2cocukveaile.Padding = new System.Windows.Forms.Padding(10, 6, 0, 0);
            this.lblkayıt2cocukveaile.Size = new System.Drawing.Size(180, 35);
            this.lblkayıt2cocukveaile.TabIndex = 2;
            this.lblkayıt2cocukveaile.Text = "Çocuk ve Aile\r\n";
            this.lblkayıt2cocukveaile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblkayıt2cocukveaile.Click += new System.EventHandler(this.lblkayıt2cocukveaile_Click);
            // 
            // lblkayıt2bilimkurgu
            // 
            this.lblkayıt2bilimkurgu.AutoSize = true;
            this.lblkayıt2bilimkurgu.BackColor = System.Drawing.Color.DimGray;
            this.lblkayıt2bilimkurgu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblkayıt2bilimkurgu.Location = new System.Drawing.Point(105, 387);
            this.lblkayıt2bilimkurgu.MinimumSize = new System.Drawing.Size(180, 35);
            this.lblkayıt2bilimkurgu.Name = "lblkayıt2bilimkurgu";
            this.lblkayıt2bilimkurgu.Padding = new System.Windows.Forms.Padding(10, 0, 0, 2);
            this.lblkayıt2bilimkurgu.Size = new System.Drawing.Size(180, 38);
            this.lblkayıt2bilimkurgu.TabIndex = 11;
            this.lblkayıt2bilimkurgu.Text = "Bilim Kurgu ve\r\nFantastik";
            this.lblkayıt2bilimkurgu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblkayıt2bilimkurgu.Click += new System.EventHandler(this.lblkayıt2bilimkurgu_Click);
            // 
            // lblkayıt2korku
            // 
            this.lblkayıt2korku.AutoSize = true;
            this.lblkayıt2korku.BackColor = System.Drawing.Color.DimGray;
            this.lblkayıt2korku.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblkayıt2korku.Location = new System.Drawing.Point(475, 113);
            this.lblkayıt2korku.MinimumSize = new System.Drawing.Size(180, 35);
            this.lblkayıt2korku.Name = "lblkayıt2korku";
            this.lblkayıt2korku.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblkayıt2korku.Size = new System.Drawing.Size(180, 35);
            this.lblkayıt2korku.TabIndex = 4;
            this.lblkayıt2korku.Text = "Korku";
            this.lblkayıt2korku.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblkayıt2korku.Click += new System.EventHandler(this.lblkayıt2korku_Click);
            // 
            // lblkayıt2belgesel
            // 
            this.lblkayıt2belgesel.AutoSize = true;
            this.lblkayıt2belgesel.BackColor = System.Drawing.Color.DimGray;
            this.lblkayıt2belgesel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblkayıt2belgesel.Location = new System.Drawing.Point(105, 182);
            this.lblkayıt2belgesel.MinimumSize = new System.Drawing.Size(180, 35);
            this.lblkayıt2belgesel.Name = "lblkayıt2belgesel";
            this.lblkayıt2belgesel.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblkayıt2belgesel.Size = new System.Drawing.Size(180, 35);
            this.lblkayıt2belgesel.TabIndex = 5;
            this.lblkayıt2belgesel.Text = "Belgesel";
            this.lblkayıt2belgesel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblkayıt2belgesel.Click += new System.EventHandler(this.lblkayıt2belgesel_Click);
            // 
            // lblkayıt2komedi
            // 
            this.lblkayıt2komedi.AutoSize = true;
            this.lblkayıt2komedi.BackColor = System.Drawing.Color.DimGray;
            this.lblkayıt2komedi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblkayıt2komedi.Location = new System.Drawing.Point(105, 115);
            this.lblkayıt2komedi.MinimumSize = new System.Drawing.Size(180, 35);
            this.lblkayıt2komedi.Name = "lblkayıt2komedi";
            this.lblkayıt2komedi.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblkayıt2komedi.Size = new System.Drawing.Size(180, 35);
            this.lblkayıt2komedi.TabIndex = 3;
            this.lblkayıt2komedi.Text = "Komedi";
            this.lblkayıt2komedi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblkayıt2komedi.Click += new System.EventHandler(this.lblkayıt2komedi_Click);
            // 
            // lblkayıt2bilimvedoga
            // 
            this.lblkayıt2bilimvedoga.AutoSize = true;
            this.lblkayıt2bilimvedoga.BackColor = System.Drawing.Color.DimGray;
            this.lblkayıt2bilimvedoga.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblkayıt2bilimvedoga.Location = new System.Drawing.Point(105, 318);
            this.lblkayıt2bilimvedoga.MinimumSize = new System.Drawing.Size(180, 35);
            this.lblkayıt2bilimvedoga.Name = "lblkayıt2bilimvedoga";
            this.lblkayıt2bilimvedoga.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblkayıt2bilimvedoga.Size = new System.Drawing.Size(180, 35);
            this.lblkayıt2bilimvedoga.TabIndex = 9;
            this.lblkayıt2bilimvedoga.Text = "Bilim ve Doğa";
            this.lblkayıt2bilimvedoga.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblkayıt2bilimvedoga.Click += new System.EventHandler(this.lblkayıt2bilimvedoga_Click);
            // 
            // lblkayıt2aksiyon
            // 
            this.lblkayıt2aksiyon.AutoSize = true;
            this.lblkayıt2aksiyon.BackColor = System.Drawing.Color.DimGray;
            this.lblkayıt2aksiyon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblkayıt2aksiyon.Location = new System.Drawing.Point(105, 46);
            this.lblkayıt2aksiyon.MinimumSize = new System.Drawing.Size(180, 35);
            this.lblkayıt2aksiyon.Name = "lblkayıt2aksiyon";
            this.lblkayıt2aksiyon.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblkayıt2aksiyon.Size = new System.Drawing.Size(180, 35);
            this.lblkayıt2aksiyon.TabIndex = 1;
            this.lblkayıt2aksiyon.Text = "Aksiyon";
            this.lblkayıt2aksiyon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblkayıt2aksiyon.Click += new System.EventHandler(this.lblkayıt2aksiyon_Click);
            // 
            // pnlkayıtSayfası
            // 
            this.pnlkayıtSayfası.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.pnlkayıtSayfası.BackgroundImage = Image.FromFile("..\\resorce\\arkaplan ve icon\\KayıtSayfası.jpg");
            this.pnlkayıtSayfası.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlkayıtSayfası.Controls.Add(this.btnkayıtgeri);
            this.pnlkayıtSayfası.Controls.Add(this.txtkayıtdgtarih);
            this.pnlkayıtSayfası.Controls.Add(this.lblkayıtdgtarihi);
            this.pnlkayıtSayfası.Controls.Add(this.lblkayıtad);
            this.pnlkayıtSayfası.Controls.Add(this.txtkayıtad);
            this.pnlkayıtSayfası.Controls.Add(this.lblkayıtbilgilendir);
            this.pnlkayıtSayfası.Controls.Add(this.lblkayıtsorun);
            this.pnlkayıtSayfası.Controls.Add(this.btnkayıtdevamet);
            this.pnlkayıtSayfası.Controls.Add(this.lblkayıtsifre);
            this.pnlkayıtSayfası.Controls.Add(this.lblkayıteposta);
            this.pnlkayıtSayfası.Controls.Add(this.txtkayıtsifre);
            this.pnlkayıtSayfası.Controls.Add(this.txtkayıteposta);
            this.pnlkayıtSayfası.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlkayıtSayfası.Location = new System.Drawing.Point(0, 0);
            this.pnlkayıtSayfası.Name = "pnlkayıtSayfası";
            this.pnlkayıtSayfası.Size = new System.Drawing.Size(782, 553);
            this.pnlkayıtSayfası.TabIndex = 0;
            // 
            // btnkayıtgeri
            // 
            this.btnkayıtgeri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnkayıtgeri.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnkayıtgeri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnkayıtgeri.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnkayıtgeri.ForeColor = System.Drawing.SystemColors.Control;
            this.btnkayıtgeri.Location = new System.Drawing.Point(259, 468);
            this.btnkayıtgeri.Name = "btnkayıtgeri";
            this.btnkayıtgeri.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.btnkayıtgeri.Size = new System.Drawing.Size(124, 39);
            this.btnkayıtgeri.TabIndex = 6;
            this.btnkayıtgeri.Text = "Geri";
            this.btnkayıtgeri.UseVisualStyleBackColor = false;
            this.btnkayıtgeri.Click += new System.EventHandler(this.btngeri_Click);
            // 
            // txtkayıtdgtarih
            // 
            this.txtkayıtdgtarih.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.txtkayıtdgtarih.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtkayıtdgtarih.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtkayıtdgtarih.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtkayıtdgtarih.Location = new System.Drawing.Point(259, 264);
            this.txtkayıtdgtarih.Mask = "0000/00/00";
            this.txtkayıtdgtarih.Name = "txtkayıtdgtarih";
            this.txtkayıtdgtarih.Size = new System.Drawing.Size(261, 27);
            this.txtkayıtdgtarih.TabIndex = 4;
            this.txtkayıtdgtarih.ValidatingType = typeof(System.DateTime);
            // 
            // lblkayıtdgtarihi
            // 
            this.lblkayıtdgtarihi.AutoSize = true;
            this.lblkayıtdgtarihi.BackColor = System.Drawing.Color.Transparent;
            this.lblkayıtdgtarihi.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblkayıtdgtarihi.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblkayıtdgtarihi.Location = new System.Drawing.Point(258, 230);
            this.lblkayıtdgtarihi.Name = "lblkayıtdgtarihi";
            this.lblkayıtdgtarihi.Size = new System.Drawing.Size(119, 19);
            this.lblkayıtdgtarihi.TabIndex = 30;
            this.lblkayıtdgtarihi.Text = "Doğum Tarihi:";
            // 
            // lblkayıtad
            // 
            this.lblkayıtad.AutoSize = true;
            this.lblkayıtad.BackColor = System.Drawing.Color.Transparent;
            this.lblkayıtad.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblkayıtad.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblkayıtad.Location = new System.Drawing.Point(257, 27);
            this.lblkayıtad.Name = "lblkayıtad";
            this.lblkayıtad.Size = new System.Drawing.Size(36, 19);
            this.lblkayıtad.TabIndex = 29;
            this.lblkayıtad.Text = "Ad:";
            // 
            // txtkayıtad
            // 
            this.txtkayıtad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.txtkayıtad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtkayıtad.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtkayıtad.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.txtkayıtad.Location = new System.Drawing.Point(259, 56);
            this.txtkayıtad.Margin = new System.Windows.Forms.Padding(5);
            this.txtkayıtad.Name = "txtkayıtad";
            this.txtkayıtad.Size = new System.Drawing.Size(266, 27);
            this.txtkayıtad.TabIndex = 1;
            // 
            // lblkayıtbilgilendir
            // 
            this.lblkayıtbilgilendir.AutoSize = true;
            this.lblkayıtbilgilendir.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblkayıtbilgilendir.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblkayıtbilgilendir.Location = new System.Drawing.Point(258, 315);
            this.lblkayıtbilgilendir.MinimumSize = new System.Drawing.Size(266, 52);
            this.lblkayıtbilgilendir.Name = "lblkayıtbilgilendir";
            this.lblkayıtbilgilendir.Size = new System.Drawing.Size(266, 52);
            this.lblkayıtbilgilendir.TabIndex = 28;
            // 
            // lblkayıtsorun
            // 
            this.lblkayıtsorun.AutoSize = true;
            this.lblkayıtsorun.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblkayıtsorun.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblkayıtsorun.Location = new System.Drawing.Point(257, 373);
            this.lblkayıtsorun.MinimumSize = new System.Drawing.Size(266, 80);
            this.lblkayıtsorun.Name = "lblkayıtsorun";
            this.lblkayıtsorun.Size = new System.Drawing.Size(266, 80);
            this.lblkayıtsorun.TabIndex = 27;
            // 
            // btnkayıtdevamet
            // 
            this.btnkayıtdevamet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnkayıtdevamet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnkayıtdevamet.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnkayıtdevamet.ForeColor = System.Drawing.SystemColors.Control;
            this.btnkayıtdevamet.Location = new System.Drawing.Point(401, 468);
            this.btnkayıtdevamet.Name = "btnkayıtdevamet";
            this.btnkayıtdevamet.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.btnkayıtdevamet.Size = new System.Drawing.Size(124, 39);
            this.btnkayıtdevamet.TabIndex = 5;
            this.btnkayıtdevamet.Text = "Devam Et";
            this.btnkayıtdevamet.UseVisualStyleBackColor = false;
            this.btnkayıtdevamet.Click += new System.EventHandler(this.btnDevamEt_Click);
            // 
            // lblkayıtsifre
            // 
            this.lblkayıtsifre.AutoSize = true;
            this.lblkayıtsifre.BackColor = System.Drawing.Color.Transparent;
            this.lblkayıtsifre.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblkayıtsifre.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblkayıtsifre.Location = new System.Drawing.Point(258, 160);
            this.lblkayıtsifre.Name = "lblkayıtsifre";
            this.lblkayıtsifre.Size = new System.Drawing.Size(51, 19);
            this.lblkayıtsifre.TabIndex = 26;
            this.lblkayıtsifre.Text = "Şifre:";
            // 
            // lblkayıteposta
            // 
            this.lblkayıteposta.AutoSize = true;
            this.lblkayıteposta.BackColor = System.Drawing.Color.Transparent;
            this.lblkayıteposta.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblkayıteposta.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblkayıteposta.Location = new System.Drawing.Point(258, 94);
            this.lblkayıteposta.Name = "lblkayıteposta";
            this.lblkayıteposta.Size = new System.Drawing.Size(76, 19);
            this.lblkayıteposta.TabIndex = 2;
            this.lblkayıteposta.Text = "E Posta:";
            // 
            // txtkayıtsifre
            // 
            this.txtkayıtsifre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.txtkayıtsifre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtkayıtsifre.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtkayıtsifre.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.txtkayıtsifre.Location = new System.Drawing.Point(259, 188);
            this.txtkayıtsifre.Margin = new System.Windows.Forms.Padding(5);
            this.txtkayıtsifre.Name = "txtkayıtsifre";
            this.txtkayıtsifre.Size = new System.Drawing.Size(266, 27);
            this.txtkayıtsifre.TabIndex = 3;
            this.txtkayıtsifre.UseSystemPasswordChar = true;
            // 
            // txtkayıteposta
            // 
            this.txtkayıteposta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.txtkayıteposta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtkayıteposta.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtkayıteposta.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.txtkayıteposta.Location = new System.Drawing.Point(260, 123);
            this.txtkayıteposta.Margin = new System.Windows.Forms.Padding(5);
            this.txtkayıteposta.Name = "txtkayıteposta";
            this.txtkayıteposta.Size = new System.Drawing.Size(266, 27);
            this.txtkayıteposta.TabIndex = 2;
            // 
            // GirisSayfasi
            // 
            this.AcceptButton = this.btngirisGiris;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.pnlgirispaneli);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GirisSayfasi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Netflix";
            this.pnlgirispaneli.ResumeLayout(false);
            this.pnlgirispaneli.PerformLayout();
            this.pnlkayıtSayfası2.ResumeLayout(false);
            this.pnlkayıtSayfası2.PerformLayout();
            this.pnlkayıtSayfası.ResumeLayout(false);
            this.pnlkayıtSayfası.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlgirispaneli;
        private Label lblgirisbilgilendir;
        private Panel pnlkayıtSayfası;
        private Button btnkayıtgeri;
        private MaskedTextBox txtkayıtdgtarih;
        private Label lblkayıtdgtarihi;
        private Label lblkayıtad;
        private TextBox txtkayıtad;
        private Label lblkayıtbilgilendir;
        private Label lblkayıtsorun;
        private Button btnkayıtdevamet;
        private Label lblkayıtsifre;
        private Label lblkayıteposta;
        private TextBox txtkayıtsifre;
        private TextBox txtkayıteposta;
        private Panel pnlkayıtSayfası2;
        private Label lblkayıt2bilgilendir;
        private PictureBox pickayıt2anime;
        private PictureBox pickayıt2reality;
        private Label lblkayıt2anime;
        private Label lblkayıt2reality;
        private Button btnkayıt2kayıtol;
        private PictureBox pickayıt2drama;
        private PictureBox pickayıt2bilimkurgu;
        private PictureBox pickayıt2romantizim;
        private PictureBox pickayıt2korku;
        private PictureBox pickayıt2gerilim;
        private PictureBox pickayıt2cocuk;
        private PictureBox pickayıt2bilimvedoga;
        private PictureBox pickayıt2belgesel;
        private PictureBox pickayıt2komedi;
        private PictureBox pickayıt2aksiyon;
        private Label lblkayıt2drama;
        private Label lblkayıt2romantizim;
        private Label lblkayıt2gerilim;
        private Label lblkayıt2cocukveaile;
        private Label lblkayıt2bilimkurgu;
        private Label lblkayıt2korku;
        private Label lblkayıt2belgesel;
        private Label lblkayıt2komedi;
        private Label lblkayıt2bilimvedoga;
        private Label lblkayıt2aksiyon;
        private Label lblgirissifre;
        private Label lblgiriseposta;
        private TextBox txtgirissifre;
        private TextBox txtgiriseposta;
        private Button btngirisKayitOl;
        private Button btngirisGiris;
    }
}


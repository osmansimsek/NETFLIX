using System.Drawing;

namespace Prolab_6
{
    partial class AnaForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaForm));
            this.tbllayoutarkapanel = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pcbçıkışlogo = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblanasayfa = new System.Windows.Forms.Label();
            this.lblkorku = new System.Windows.Forms.Label();
            this.lblanime = new System.Windows.Forms.Label();
            this.lblcocuk = new System.Windows.Forms.Label();
            this.lblromantizm = new System.Windows.Forms.Label();
            this.lblreality = new System.Windows.Forms.Label();
            this.lblkomedi = new System.Windows.Forms.Label();
            this.lblgerilim = new System.Windows.Forms.Label();
            this.lbldrama = new System.Windows.Forms.Label();
            this.lblbilimvedoga = new System.Windows.Forms.Label();
            this.lblbelgesel = new System.Windows.Forms.Label();
            this.lblbilimkurgu = new System.Windows.Forms.Label();
            this.lblaksiyon = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtarama = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbllayoutönpanel = new System.Windows.Forms.TableLayoutPanel();
            this.FilmOynatma = new System.Windows.Forms.Timer(this.components);
            this.tbllayoutarkapanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbllayoutarkapanel
            // 
            this.tbllayoutarkapanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tbllayoutarkapanel.ColumnCount = 2;
            this.tbllayoutarkapanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tbllayoutarkapanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82F));
            this.tbllayoutarkapanel.Controls.Add(this.panel1, 0, 0);
            this.tbllayoutarkapanel.Controls.Add(this.panel2, 1, 0);
            this.tbllayoutarkapanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbllayoutarkapanel.Location = new System.Drawing.Point(0, 0);
            this.tbllayoutarkapanel.Margin = new System.Windows.Forms.Padding(0);
            this.tbllayoutarkapanel.Name = "tbllayoutarkapanel";
            this.tbllayoutarkapanel.RowCount = 2;
            this.tbllayoutarkapanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbllayoutarkapanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbllayoutarkapanel.Size = new System.Drawing.Size(1342, 721);
            this.tbllayoutarkapanel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.pcbçıkışlogo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblanasayfa);
            this.panel1.Controls.Add(this.lblkorku);
            this.panel1.Controls.Add(this.lblanime);
            this.panel1.Controls.Add(this.lblcocuk);
            this.panel1.Controls.Add(this.lblromantizm);
            this.panel1.Controls.Add(this.lblreality);
            this.panel1.Controls.Add(this.lblkomedi);
            this.panel1.Controls.Add(this.lblgerilim);
            this.panel1.Controls.Add(this.lbldrama);
            this.panel1.Controls.Add(this.lblbilimvedoga);
            this.panel1.Controls.Add(this.lblbelgesel);
            this.panel1.Controls.Add(this.lblbilimkurgu);
            this.panel1.Controls.Add(this.lblaksiyon);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtarama);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.tbllayoutarkapanel.SetRowSpan(this.panel1, 2);
            this.panel1.Size = new System.Drawing.Size(235, 715);
            this.panel1.TabIndex = 0;
            // 
            // pcbçıkışlogo
            // 
            this.pcbçıkışlogo.Image = Image.FromFile("..\\resorce\\arkaplan ve icon\\logout.png");
            this.pcbçıkışlogo.Location = new System.Drawing.Point(187, 671);
            this.pcbçıkışlogo.MaximumSize = new System.Drawing.Size(35, 35);
            this.pcbçıkışlogo.MinimumSize = new System.Drawing.Size(35, 35);
            this.pcbçıkışlogo.Name = "pcbçıkışlogo";
            this.pcbçıkışlogo.Size = new System.Drawing.Size(35, 35);
            this.pcbçıkışlogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbçıkışlogo.TabIndex = 16;
            this.pcbçıkışlogo.TabStop = false;
            this.pcbçıkışlogo.Click += new System.EventHandler(this.pcbçıkışlogo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(121, 671);
            this.label2.MinimumSize = new System.Drawing.Size(60, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 35);
            this.label2.TabIndex = 17;
            this.label2.Text = "Çıkış";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblanasayfa
            // 
            this.lblanasayfa.AutoSize = true;
            this.lblanasayfa.Location = new System.Drawing.Point(6, 225);
            this.lblanasayfa.Name = "lblanasayfa";
            this.lblanasayfa.Size = new System.Drawing.Size(105, 22);
            this.lblanasayfa.TabIndex = 15;
            this.lblanasayfa.Text = ". Ana Sayfa";
            this.lblanasayfa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblanasayfa.Click += new System.EventHandler(this.lblanasayfa_Click);
            // 
            // lblkorku
            // 
            this.lblkorku.AutoSize = true;
            this.lblkorku.Location = new System.Drawing.Point(6, 557);
            this.lblkorku.Name = "lblkorku";
            this.lblkorku.Size = new System.Drawing.Size(69, 22);
            this.lblkorku.TabIndex = 14;
            this.lblkorku.Text = ". Korku";
            this.lblkorku.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblkorku.Click += new System.EventHandler(this.lblkorku_Click);
            // 
            // lblanime
            // 
            this.lblanime.AutoSize = true;
            this.lblanime.Location = new System.Drawing.Point(6, 289);
            this.lblanime.Name = "lblanime";
            this.lblanime.Size = new System.Drawing.Size(73, 22);
            this.lblanime.TabIndex = 13;
            this.lblanime.Text = ". Anime";
            this.lblanime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblanime.Click += new System.EventHandler(this.lblanime_Click);
            // 
            // lblcocuk
            // 
            this.lblcocuk.AutoSize = true;
            this.lblcocuk.Location = new System.Drawing.Point(5, 424);
            this.lblcocuk.Name = "lblcocuk";
            this.lblcocuk.Size = new System.Drawing.Size(135, 22);
            this.lblcocuk.TabIndex = 12;
            this.lblcocuk.Text = ". Çocuk ve Aile";
            this.lblcocuk.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblcocuk.Click += new System.EventHandler(this.lblcocuk_Click);
            // 
            // lblromantizm
            // 
            this.lblromantizm.AutoSize = true;
            this.lblromantizm.Location = new System.Drawing.Point(6, 626);
            this.lblromantizm.Name = "lblromantizm";
            this.lblromantizm.Size = new System.Drawing.Size(115, 22);
            this.lblromantizm.TabIndex = 11;
            this.lblromantizm.Text = ". Romantizm";
            this.lblromantizm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblromantizm.Click += new System.EventHandler(this.lblromantizm_Click);
            // 
            // lblreality
            // 
            this.lblreality.AutoSize = true;
            this.lblreality.Location = new System.Drawing.Point(6, 592);
            this.lblreality.Name = "lblreality";
            this.lblreality.Size = new System.Drawing.Size(155, 22);
            this.lblreality.TabIndex = 10;
            this.lblreality.Text = ". Reality Program";
            this.lblreality.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblreality.Click += new System.EventHandler(this.lblreality_Click);
            // 
            // lblkomedi
            // 
            this.lblkomedi.AutoSize = true;
            this.lblkomedi.Location = new System.Drawing.Point(5, 523);
            this.lblkomedi.Name = "lblkomedi";
            this.lblkomedi.Size = new System.Drawing.Size(86, 22);
            this.lblkomedi.TabIndex = 9;
            this.lblkomedi.Text = ". Komedi";
            this.lblkomedi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblkomedi.Click += new System.EventHandler(this.lblkomedi_Click);
            // 
            // lblgerilim
            // 
            this.lblgerilim.AutoSize = true;
            this.lblgerilim.Location = new System.Drawing.Point(5, 491);
            this.lblgerilim.Name = "lblgerilim";
            this.lblgerilim.Size = new System.Drawing.Size(80, 22);
            this.lblgerilim.TabIndex = 8;
            this.lblgerilim.Text = ". Gerilim";
            this.lblgerilim.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblgerilim.Click += new System.EventHandler(this.lblgerilim_Click);
            // 
            // lbldrama
            // 
            this.lbldrama.AutoSize = true;
            this.lbldrama.Location = new System.Drawing.Point(5, 458);
            this.lbldrama.Name = "lbldrama";
            this.lbldrama.Size = new System.Drawing.Size(76, 22);
            this.lbldrama.TabIndex = 7;
            this.lbldrama.Text = ". Drama";
            this.lbldrama.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbldrama.Click += new System.EventHandler(this.lbldrama_Click);
            // 
            // lblbilimvedoga
            // 
            this.lblbilimvedoga.AutoSize = true;
            this.lblbilimvedoga.Location = new System.Drawing.Point(5, 390);
            this.lblbilimvedoga.Name = "lblbilimvedoga";
            this.lblbilimvedoga.Size = new System.Drawing.Size(137, 22);
            this.lblbilimvedoga.TabIndex = 6;
            this.lblbilimvedoga.Text = ". Bilim ve Doğa";
            this.lblbilimvedoga.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblbilimvedoga.Click += new System.EventHandler(this.lblbilimvedoga_Click);
            // 
            // lblbelgesel
            // 
            this.lblbelgesel.AutoSize = true;
            this.lblbelgesel.Location = new System.Drawing.Point(6, 321);
            this.lblbelgesel.Name = "lblbelgesel";
            this.lblbelgesel.Size = new System.Drawing.Size(95, 22);
            this.lblbelgesel.TabIndex = 5;
            this.lblbelgesel.Text = ". Belgesel";
            this.lblbelgesel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblbelgesel.Click += new System.EventHandler(this.lblbelgesel_Click);
            // 
            // lblbilimkurgu
            // 
            this.lblbilimkurgu.AutoSize = true;
            this.lblbilimkurgu.Location = new System.Drawing.Point(6, 356);
            this.lblbilimkurgu.Name = "lblbilimkurgu";
            this.lblbilimkurgu.Size = new System.Drawing.Size(221, 22);
            this.lblbilimkurgu.TabIndex = 4;
            this.lblbilimkurgu.Text = ". Bilim Kurgu ve Fantastik";
            this.lblbilimkurgu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblbilimkurgu.Click += new System.EventHandler(this.lblbilimkurgu_Click);
            // 
            // lblaksiyon
            // 
            this.lblaksiyon.AutoSize = true;
            this.lblaksiyon.Location = new System.Drawing.Point(5, 257);
            this.lblaksiyon.Name = "lblaksiyon";
            this.lblaksiyon.Size = new System.Drawing.Size(177, 22);
            this.lblaksiyon.TabIndex = 3;
            this.lblaksiyon.Text = ". Aksiyon ve Macera";
            this.lblaksiyon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblaksiyon.Click += new System.EventHandler(this.lblaksiyon_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(3, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ara :";
            // 
            // txtarama
            // 
            this.txtarama.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtarama.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtarama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtarama.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtarama.ForeColor = System.Drawing.Color.White;
            this.txtarama.Location = new System.Drawing.Point(0, 178);
            this.txtarama.Name = "txtarama";
            this.txtarama.Size = new System.Drawing.Size(235, 32);
            this.txtarama.TabIndex = 1;
            this.txtarama.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = Image.FromFile("..\\resorce\\arkaplan ve icon\\Netflix-Logo.png");
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(10);
            this.pictureBox1.Size = new System.Drawing.Size(235, 127);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel2.Controls.Add(this.tbllayoutönpanel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(244, 3);
            this.panel2.Name = "panel2";
            this.tbllayoutarkapanel.SetRowSpan(this.panel2, 2);
            this.panel2.Size = new System.Drawing.Size(1095, 715);
            this.panel2.TabIndex = 1;
            // 
            // tbllayoutönpanel
            // 
            this.tbllayoutönpanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbllayoutönpanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tbllayoutönpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.tbllayoutönpanel.ColumnCount = 2;
            this.tbllayoutönpanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.22748F));
            this.tbllayoutönpanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.77252F));
            this.tbllayoutönpanel.Font = new System.Drawing.Font("Montserrat Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbllayoutönpanel.Location = new System.Drawing.Point(-4, 0);
            this.tbllayoutönpanel.Name = "tbllayoutönpanel";
            this.tbllayoutönpanel.RowCount = 2;
            this.tbllayoutönpanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.53147F));
            this.tbllayoutönpanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.46853F));
            this.tbllayoutönpanel.Size = new System.Drawing.Size(1099, 715);
            this.tbllayoutönpanel.TabIndex = 0;
            // 
            // FilmOynatma
            // 
            this.FilmOynatma.Interval = 400;
            this.FilmOynatma.Tick += new System.EventHandler(this.FilmOynatma_Tick);
            // 
            // AnaForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1342, 721);
            this.Controls.Add(this.tbllayoutarkapanel);
            this.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AnaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Netfflix";
            this.Load += new System.EventHandler(this.AnaForm_Load);
            this.tbllayoutarkapanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbçıkışlogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tbllayoutarkapanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtarama;
        private System.Windows.Forms.Label lblkorku;
        private System.Windows.Forms.Label lblanime;
        private System.Windows.Forms.Label lblcocuk;
        private System.Windows.Forms.Label lblromantizm;
        private System.Windows.Forms.Label lblreality;
        private System.Windows.Forms.Label lblkomedi;
        private System.Windows.Forms.Label lblgerilim;
        private System.Windows.Forms.Label lbldrama;
        private System.Windows.Forms.Label lblbilimvedoga;
        private System.Windows.Forms.Label lblbelgesel;
        private System.Windows.Forms.Label lblbilimkurgu;
        private System.Windows.Forms.Label lblaksiyon;
        private System.Windows.Forms.TableLayoutPanel tbllayoutönpanel;
        private System.Windows.Forms.Label lblanasayfa;
        private System.Windows.Forms.Timer FilmOynatma;
        private System.Windows.Forms.PictureBox pcbçıkışlogo;
        private System.Windows.Forms.Label label2;
    }
}
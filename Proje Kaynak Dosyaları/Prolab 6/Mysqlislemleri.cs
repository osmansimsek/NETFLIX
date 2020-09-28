using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Threading;
using Prolab_6.Tablolar;

namespace Prolab_6
{
    public class Mysqlislemleri
    {

        string datasource;
        string port;
        string username;
        string password;
        public int baglanti = 0;
        MySqlConnection connect;


        public Mysqlislemleri(string password, string datasource, string port, string username)
        {

            if (!(string.IsNullOrEmpty(datasource) && string.IsNullOrEmpty(port) && string.IsNullOrEmpty(username) && string.IsNullOrEmpty(password)))
            {
                this.datasource = datasource;
                this.port = port;
                this.username = username;
                this.password = password;
                baglanti = 1;
                Connection();
            }
            else
                MessageBox.Show("Connection bilgileri boştur.", "Bağlanma Uyarısı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private static string FilmAdKontrolü(string FilmAd)
        {
            StringBuilder builder = new StringBuilder();

            int sayac = 0;
            if (FilmAd.Contains("\'"))
            {
                List<char> liste = FilmAd.ToList();
                int index = liste.IndexOf('\'');

                foreach (var item in liste)
                {
                    if (sayac < index) builder.Append(item);
                    else if (sayac == index) builder.Append("\\'");
                    else builder.Append(item);
                    sayac++;
                }
                FilmAd = builder.ToString();
            }

            return FilmAd;
        }

        public void Connection()
        {
            string connectionString = $"datasource={datasource};port={port};username={username};password={password};";

            try
            {
                connect = new MySqlConnection(connectionString);
            }
            catch (Exception)
            {
                MessageBox.Show("Mysql ile bağlantı yapılamadı.", "Bağlanma Uyarısı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public List<string> EmailKontrol()
        {
            List<string> Emails = new List<string>();

            if (connect != null)
            {
                using (var command = new MySqlCommand(@"select email from netflix.t_kullanici;", connect))
                {
                    if (connect.State == System.Data.ConnectionState.Closed)
                    {
                        connect.Open();
                        MySqlDataReader reader;

                        try
                        {
                            reader = command.ExecuteReader();

                            while (reader.Read()) Emails.Add(reader["email"].ToString());

                            reader.Close();
                            connect.Close();

                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Email Kontrolü Yapılamadı.", "Kontrol Uyarısı",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return null;
                        }
                    }
                }
                return Emails;
            }
            else
            {
                return null;
            }
        }

        public void KayitOl(params string[] Veriler)
        {
            if (connect != null)
            {
                using (var command = new MySqlCommand(@"insert into netflix.t_kullanici values(@p1,@p2,@p3,@p4);", connect))
                {
                    if (connect.State == System.Data.ConnectionState.Closed)
                    {
                        connect.Open();
                        try
                        {
                            command.Parameters.AddWithValue("@p1", Veriler[0]);
                            command.Parameters.AddWithValue("@p2", Veriler[1]);
                            command.Parameters.AddWithValue("@p3", Veriler[2]);
                            command.Parameters.AddWithValue("@p4", Veriler[3]);
                            command.ExecuteNonQuery();
                            connect.Close();

                            MessageBox.Show("Kayıt Başarılı Bir Şekilde Gerçekleştirildi.", "Bilgilendirme",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Kayıt Yapılamadı.", "Kayıt Hatası",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
        }

        public bool GirisYap(string email, string sifre)
        {
            int denetim = 0;

            if (connect != null)
            {
                using (var command = new MySqlCommand(@"select * from netflix.t_kullanici where email= '" + email +
                    "' and sifre= '" + sifre + "';", connect))
                {
                    if (connect.State == System.Data.ConnectionState.Closed)
                    {
                        connect.Open();
                        MySqlDataReader reader;

                        try
                        {
                            reader = command.ExecuteReader();

                            while (reader.Read()) denetim++;

                            reader.Close();
                            connect.Close();

                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Giriş Yapılamadı", "Kayıt Hatası",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return false;
                        }
                    }
                }
            }
            if (denetim != 0) return true;
            else return false;
        }

        public List<string> FilmListele()
        {
            List<string> FilmListesi = new List<string>();

            if (connect != null)
            {
                using (var command = new MySqlCommand(@"select ad from netflix.t_program;", connect))
                {
                    if (connect.State == System.Data.ConnectionState.Closed)
                    {
                        connect.Open();
                        MySqlDataReader reader;

                        try
                        {
                            reader = command.ExecuteReader();

                            while (reader.Read()) FilmListesi.Add(reader["ad"].ToString());

                            reader.Close();
                            connect.Close();

                        }
                        catch (Exception)
                        {
                            return null;
                        }
                    }
                }
            }
            return FilmListesi;
        }

        public List<string> TurAra(string tur)
        {
            List<string> Tur = new List<string>();

            if (connect != null)
            {
                using (var command = new MySqlCommand("select programad from netflix.t_programtur where turad = '" + tur + "';", connect))
                {
                    if (connect.State == System.Data.ConnectionState.Closed)
                    {
                        connect.Open();
                        MySqlDataReader reader;

                        try
                        {
                            reader = command.ExecuteReader();

                            while (reader.Read()) Tur.Add(reader["programad"].ToString());

                            reader.Close();
                            connect.Close();

                        }
                        catch (Exception)
                        {
                            return null;
                        }
                    }
                }
            }
            return Tur;
        }

        public void FilmDetay(ProgramTur programTur, string FilmAd)
        {
            FilmAd = FilmAdKontrolü(FilmAd);
            int sayac = 0;

            if (connect != null)
            {
                using (var command = new MySqlCommand(@"select ad,tip,bölümsayisi,programuzunluk,turad from netflix.t_program inner join" +
                        " netflix.t_programtur on ad = programad where programad = '" + FilmAd + "';", connect))
                {
                    if (connect.State == System.Data.ConnectionState.Closed)
                    {
                        connect.Open();
                        MySqlDataReader reader;

                        try
                        {
                            reader = command.ExecuteReader();

                            while (reader.Read())
                            {
                                if (sayac == 0)
                                {
                                    programTur.ProgramAd = reader["ad"].ToString();
                                    programTur.Tip = reader["tip"].ToString();
                                    programTur.bölümsayisi = reader.GetInt32(2);
                                    programTur.programuzunluk = reader.GetInt32(3);
                                }
                                programTur.Tur.Add(reader["turad"].ToString());
                                sayac++;
                            }
                            reader.Close();
                            connect.Close();
                        }
                        catch (Exception)
                        {

                        }
                    }
                }

                using (var command = new MySqlCommand(@"select ad,avg(puan) from netflix.t_program left join netflix.t_kullaniciprogram on ad = programad" +
                                        " where programad = '" + FilmAd + "' group by programad;", connect))
                {
                    if (connect.State == System.Data.ConnectionState.Closed)
                    {
                        connect.Open();
                        MySqlDataReader reader;

                        try
                        {
                            reader = command.ExecuteReader();
                            while (reader.Read()) programTur.Puan = reader.GetFloat(1);

                            reader.Close();
                            connect.Close();
                        }
                        catch (Exception)
                        {

                        }
                    }
                }
            }
        }

        public List<string> ÖnerilenFilmlerBul(List<string> Turler)
        {
            List<string> ÖnerilenFilmler = new List<string>();

            foreach (var Tur in Turler)
            {
                if (connect != null)
                {
                    using (var command = new MySqlCommand("select t_programtur.programad,avg(puan) as 'puan',turad from netflix.t_programtur inner join netflix.t_kullaniciprogram on " +
                                         "t_programtur.programad = t_kullaniciprogram.programad where t_programtur.turad = '" + Tur + "' group by programad order by puan desc;", connect))
                    {
                        if (connect.State == System.Data.ConnectionState.Closed)
                        {
                            connect.Open();
                            MySqlDataReader reader;
                            int sayac = 0;
                            reader = command.ExecuteReader();

                            while (reader.Read())
                            {
                                if (sayac < 2)
                                {
                                    ÖnerilenFilmler.Add(reader["programad"].ToString()); ;
                                }
                                else break;
                                sayac++;
                            }
                            reader.Close();
                            connect.Close();

                        }
                    }
                }
            }

            ÖnerilenFilmler.Sort();

            for (int i = 0; i < ÖnerilenFilmler.Count - 1; i++)
            {
                if (ÖnerilenFilmler[i] == ÖnerilenFilmler[i + 1]) ÖnerilenFilmler.RemoveAt(i);
            }

            return ÖnerilenFilmler;
        }

        public void Filmİzletme(string eposta, string FilmAd)
        {
            FilmAd = FilmAdKontrolü(FilmAd);

            if (connect != null)
            {
                using (var command = new MySqlCommand("insert into netflix.t_kullaniciprogram values ( '" + eposta + "', '" + FilmAd + "', " +
                                                       " curdate(), 0, 0.0, 0 );", connect))
                {
                    if (connect.State == System.Data.ConnectionState.Closed)
                    {
                        try
                        {
                            connect.Open();
                            command.ExecuteNonQuery();
                            connect.Close();
                        }
                        catch (Exception)
                        {
                            connect.Close();
                        }

                    }
                }
            }
        }
        public void FilmİzlemeDetayKaydet(string eposta, string FilmAd, int izlenmeSüresi, int kalinanBölüm)
        {
            FilmAd = FilmAdKontrolü(FilmAd);

            if (connect != null)
            {
                using (var command = new MySqlCommand("Update netflix.t_kullaniciprogram set izlenmetarihi = curdate(), izlenmesüresi = @izlenmeSüresi, puan = 0.0, kalinanbölüm = @kalinanBölüm " +
                                                   "where t_kullaniciprogram.programad = '" + FilmAd + "' and t_kullaniciprogram.kullaniciemail = '" + eposta + "';", connect))
                {
                    if (connect.State == System.Data.ConnectionState.Closed)
                    {
                        try
                        {
                            connect.Open();
                            command.Parameters.AddWithValue("@izlenmeSüresi", izlenmeSüresi);
                            command.Parameters.AddWithValue("@kalinanBölüm", kalinanBölüm);
                            command.ExecuteNonQuery();
                            connect.Close();
                        }
                        catch (Exception)
                        {
                            throw;
                        }
                    }
                }
            }
        }

        public int FilmİzletmeKontrolEt(string eposta, string FilmAd)
        {
            int kontrol = 0;

            FilmAd = FilmAdKontrolü(FilmAd);

            if (connect != null)
            {
                using (var command = new MySqlCommand("select * from netflix.t_kullaniciprogram where t_kullaniciprogram.programad = '" + FilmAd + "' and " +
                                                         "t_kullaniciprogram.kullaniciemail = '" + eposta + "' ;", connect))
                {
                    if (connect.State == System.Data.ConnectionState.Closed)
                    {
 
                        try
                        {
                            connect.Open();
                            MySqlDataReader reader;
                            reader = command.ExecuteReader();

                            while (reader.Read()) kontrol++;

                            reader.Close();
                            connect.Close();
                        }
                        catch (Exception)
                        {
                            throw;
                        }
                    }
                }
            }
            return kontrol;
        }
        public void Filmİzlenmismi(ref int kalinanBölüm,ref int kalinanZaman,string eposta,string FilmAd)
        {
            FilmAd = FilmAdKontrolü(FilmAd);
           
            if (connect != null)
            {
                using (var command = new MySqlCommand("select kalinanbölüm,izlenmesüresi from netflix.t_kullaniciprogram where t_kullaniciprogram.programad = '" + FilmAd + "' and " +
                                                         "t_kullaniciprogram.kullaniciemail = '" + eposta + "' ;", connect))
                {
                    if (connect.State == System.Data.ConnectionState.Closed)
                    {

                        try
                        {
                            connect.Open();
                            MySqlDataReader reader;
                            reader = command.ExecuteReader();

                            while (reader.Read())
                            {
                                kalinanBölüm = reader.GetInt32(0);
                                kalinanZaman = reader.GetInt32(1);
                            }

                            reader.Close();
                            connect.Close();
                        }
                        catch (Exception)
                        {
                            throw;
                        }
                    }
                }
            }
        }

        public void PuanGöster(ref float puan, string eposta, string FilmAd)
        {
            FilmAd = FilmAdKontrolü(FilmAd);

            if (connect != null)
            {
                using (var command = new MySqlCommand("select puan from netflix.t_kullaniciprogram where t_kullaniciprogram.programad = '" + FilmAd + "' and " +
                                                         "t_kullaniciprogram.kullaniciemail = '" + eposta + "';", connect))
                {
                    if (connect.State == System.Data.ConnectionState.Closed)
                    {
                        try
                        {
                            connect.Open();
                            MySqlDataReader reader;
                            reader = command.ExecuteReader();
                            while (reader.Read()) puan = reader.GetFloat(0);
                            connect.Close();
                        }
                        catch (Exception)
                        {
                            throw;
                        }
                    }
                }
            }
        }
      
        public void PuanKaydet(string eposta, string FilmAd, float puan)
        {
            FilmAd = FilmAdKontrolü(FilmAd);

            if (connect != null)
            {
                using (var command = new MySqlCommand(" Update netflix.t_kullaniciprogram  set puan = @Puan where t_kullaniciprogram.programad = '" + FilmAd + "' and " +
                                                         "t_kullaniciprogram.kullaniciemail = '" + eposta + "';", connect))
                {
                    if (connect.State == System.Data.ConnectionState.Closed)
                    {
                        try
                        {
                            connect.Open();
                            command.Parameters.AddWithValue("@Puan", puan);
                            command.ExecuteNonQuery();
                            connect.Close();
                        }
                        catch (Exception)
                        {
                            throw;
                        }
                    }
                }
            }
        }
    }
}


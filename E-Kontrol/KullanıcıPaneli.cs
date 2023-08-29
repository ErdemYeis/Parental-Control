using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Net;
using System.Diagnostics;

namespace E_Kontrol
{
    public partial class ApplicationContext : Form
    {
        string connectionString = "Data Source=DESKTOP-HOOKELP\\SQLEXPRESS;Initial Catalog=EKontrol;Integrated Security=True";
        int s = 0,m=0,h=0,klns,klnd;
        private void KullanıcıPaneli_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.olds = s; Properties.Settings.Default.oldm = m; Properties.Settings.Default.oldh = h;
            Properties.Settings.Default.Save();
            if (h!=Properties.Settings.Default.Time)
            {
                
                if (e.CloseReason != CloseReason.ApplicationExitCall)
                {
                    e.Cancel = true;
                    DialogResult res = MessageBox.Show("Uygulamayı Kapatmak İstediğine Emin Misin? İlgili Kişiye Mail Gidecektir.", "Bilgilendirme Penceresi", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (res == DialogResult.OK)
                    {
                        MessageBox.Show("Uygulamayı Kapatmaya Yetkin Yok!, İlgili Kişiye Mail Gönderildi.", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        using (MailMessage mail = new MailMessage())
                        {
                            mail.From = new MailAddress("e.kontrol0@gmail.com");
                            mail.To.Add(Properties.Settings.Default.UserMail);
                            mail.Subject = "Önemli! Uygulama Kapatma İsteği";
                            mail.Body = " Kullanıcı Uygulamayı Kapatmaya Çalıştı.";
                            mail.IsBodyHtml = false;

                            using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                            {
                                smtp.UseDefaultCredentials = false;
                                smtp.Credentials = new NetworkCredential("e.kontrol0@gmail.com", "czwqtlcxwussklue");
                                smtp.EnableSsl = true;
                                smtp.Send(mail);
                            }
                        }
                    }
                    if (res == DialogResult.Cancel)
                    {
                        MessageBox.Show("İşlem İptal Edildi.", "Bilgilendirme Penceresi");
                    }
                }
                if (e.CloseReason != CloseReason.TaskManagerClosing)
                {
                    using (MailMessage mail = new MailMessage())
                    {
                        mail.From = new MailAddress("e.kontrol0@gmail.com");
                        mail.To.Add(Properties.Settings.Default.UserMail);
                        mail.Subject = "Önemli! Uygulama Kapandı.";
                        mail.Body = " Kullanıcı Uygulamayı Zorla Kapattı!.";
                        mail.IsBodyHtml = false;

                        using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                        {
                            smtp.UseDefaultCredentials = false;
                            smtp.Credentials = new NetworkCredential("e.kontrol0@gmail.com", "czwqtlcxwussklue");
                            smtp.EnableSsl = true;
                            smtp.Send(mail);
                        }
                    }
                }
            }
            
        }

        public ApplicationContext()
        {
            InitializeComponent();
        }
        private void KullanıcıPaneli_Load(object sender, EventArgs e)
        {
            pnlGntle.Visible = false;
            StringBuilder sb = new StringBuilder();
            string Date = Convert.ToString(DateTime.Now);
            for (int i = 0; i < Date.Length; i++)
            {
                if (Date.ElementAt(i) != Convert.ToChar(" "))
                {
                    sb.Append(Date.ElementAt(i));
                }
                else
                {
                    break;
                }
            }
            try
            {
                SqlConnection con = new SqlConnection(connectionString);
                con.Open(); 

                string insertQuery = "INSERT INTO GunSaatTable (Gun, KullanilanSaat) VALUES (@gn, @saat)";

                using (SqlCommand command = new SqlCommand(insertQuery, con))
                {
                    command.Parameters.AddWithValue("@gn", sb);
                    command.Parameters.AddWithValue("@saat", h);
                    command.ExecuteNonQuery();

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata Oluştu: " + ex.Message);
            }
            if (Properties.Settings.Default.OldDay == 0)
            {
                Properties.Settings.Default.OldDay = DateTime.Now.Day;
                Properties.Settings.Default.Save();
            }
            else 
            {
                Properties.Settings.Default.NewDay = DateTime.Now.Day;
                int a = Properties.Settings.Default.NewDay - Properties.Settings.Default.OldDay;
                Properties.Settings.Default.Save();
                if (a!=0)
                {
                    timer1.Stop();
                    string Tms = lblTime.Text;

                    

                    Properties.Settings.Default.OldDay = Properties.Settings.Default.NewDay;
                    Properties.Settings.Default.NewDay = DateTime.Now.Day;
                    s = 0; m = 0; h = 0;
                    Properties.Settings.Default.Save();
                }
                else
                {
                    s = Properties.Settings.Default.olds;m = Properties.Settings.Default.oldm;h = Properties.Settings.Default.oldh;
                    if (h >= Properties.Settings.Default.Time)
                    {
                        Process.Start("shutdown", "-s -f -t 2");

                        using (MailMessage mail = new MailMessage())
                        {
                            mail.From = new MailAddress("e.kontrol0@gmail.com");
                            mail.To.Add(Properties.Settings.Default.UserMail);
                            mail.Subject = "Dikkat";
                            mail.Body = "Kullanıcı Süresi Bitmesine Rağmen Bilgisayar'ı Açmaya Çalışmakta.";
                            mail.IsBodyHtml = false;

                            using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                            {
                                smtp.UseDefaultCredentials = false;
                                smtp.Credentials = new NetworkCredential("e.kontrol0@gmail.com", "czwqtlcxwussklue");
                                smtp.EnableSsl = true;
                                smtp.Send(mail);
                            }
                        }
                    }
                }
            }
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            SqlCommand cmd = new SqlCommand("SELECT DuzenlemeIzın FROM Kullanici where email = @mail", connection);
            cmd.Parameters.AddWithValue("@mail", Properties.Settings.Default.UserMail);
            bool izin = Convert.ToBoolean(cmd.ExecuteScalar());

            if (izin == false)
            {
                txtTime.Enabled = false;
                button1.Enabled = false;
            }
            else
            {
                txtTime.Enabled = true;
                button1.Enabled = true;
            }
            if (Properties.Settings.Default.Time != 0)
            {
                timer1.Interval = 1000; 
                timer1.Tick += timer1_Tick;

                timer1.Start();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pnlGntle.Visible = true;

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            SqlDataAdapter adapter = new SqlDataAdapter("Select * From GunSaatTable", connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            dtaGrd.DataSource = dataTable;
            connection.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            pnlGntle.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Time = Convert.ToInt32(txtTime.Text);
            Properties.Settings.Default.Save();
            MessageBox.Show("Saat Kaydedildi", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            SqlCommand cmd = new SqlCommand("update Kullanici set DuzenlemeIzın = 0 where email=@mail", connection);
            cmd.Parameters.AddWithValue("@mail", Properties.Settings.Default.UserMail);
            cmd.ExecuteNonQuery();
            txtTime.Enabled = false;
            button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            SqlCommand cmd = new SqlCommand("SELECT telno FROM Kullanici where email = @mail", connection);
            cmd.Parameters.AddWithValue("@mail", Properties.Settings.Default.UserMail);
            string phone = Convert.ToString(cmd.ExecuteScalar());

            using (MailMessage mail = new MailMessage())
            {
                mail.From = new MailAddress("e.kontrol0@gmail.com");
                mail.To.Add("e.kontrol0@gmail.com");
                mail.Subject = "Saat Düzenleme İsteği";
                mail.Body = Properties.Settings.Default.UserMail + " Adresli, " + phone + " Telefon nolu kullanıcı saatin düzenlenmesini istiyor.";
                mail.IsBodyHtml = false;

                using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                {
                    smtp.UseDefaultCredentials = false;
                    smtp.Credentials = new NetworkCredential("e.kontrol0@gmail.com", "czwqtlcxwussklue");
                    smtp.EnableSsl = true;
                    try
                    {
                        smtp.Send(mail);
                        MessageBox.Show("Eposta Gönderildi, Telefon ile İletişime Geçilecek.", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void btny_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.UserMail = "erdemkurt455@gmail.com";
            if (Properties.Settings.Default.UserMail == "erdemkurt455@gmail.com")
            {
                YönetimPaneli ynt = new YönetimPaneli();
                ynt.Show();
                this.Hide();   
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            s += 1;
            if (s==60)
            {
                s = 0;
                m += 1;
                if (m == 60)
                {
                    m = 0;
                    h += 1;
                    if (h == Properties.Settings.Default.Time)
                    {
                        MessageBox.Show("Kullanım Süreniz Dolmuştur.");

                        using (MailMessage mail = new MailMessage())
                        {
                            mail.From = new MailAddress("e.kontrol0@gmail.com");
                            mail.To.Add(Properties.Settings.Default.UserMail);
                            mail.Subject = "Kullanıcının Kullanım Süresi Bitmiştir";
                            mail.IsBodyHtml = false;

                            using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                            {
                                smtp.UseDefaultCredentials = false;
                                smtp.Credentials = new NetworkCredential("e.kontrol0@gmail.com", "czwqtlcxwussklue");
                                smtp.EnableSsl = true;
                                try
                                {
                                    smtp.Send(mail);
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message);
                                }
                            }
                        }

                        Process.Start("shutdown", "-s -f -t 5");
                    }
                }

                int a = Properties.Settings.Default.Time - h;
                if (a == 1 && m == 50)
                {
                    MessageBox.Show("Kullanım Süreniz Dolmasına 10 Dakika kalmıştır.");

                    using (MailMessage mail = new MailMessage())
                    {
                        mail.From = new MailAddress("e.kontrol0@gmail.com");
                        mail.To.Add(Properties.Settings.Default.UserMail);
                        mail.Subject = "Kullanıcının Kullanım Süresine 10 Dakika Kalmıştır.";
                        mail.IsBodyHtml = false;

                        using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                        {
                            smtp.UseDefaultCredentials = false;
                            smtp.Credentials = new NetworkCredential("e.kontrol0@gmail.com", "czwqtlcxwussklue");
                            smtp.EnableSsl = true;
                            try
                            {
                                smtp.Send(mail);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                    }
                }
                else if (a == 1 && m == 55)
                {
                    MessageBox.Show("Kullanım Süreniz Dolmasına 5 Dakika kalmıştır.");

                    using (MailMessage mail = new MailMessage())
                    {
                        mail.From = new MailAddress("e.kontrol0@gmail.com");
                        mail.To.Add(Properties.Settings.Default.UserMail);
                        mail.Subject = "Kalan Dakika Bildirim";
                        mail.Body = "Kullanıcının Kullanım Süresine 5 Dakika Kalmıştır.";
                        mail.IsBodyHtml = false;

                        using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                        {
                            smtp.UseDefaultCredentials = false;
                            smtp.Credentials = new NetworkCredential("e.kontrol0@gmail.com", "czwqtlcxwussklue");
                            smtp.EnableSsl = true;
                            try
                            {
                                smtp.Send(mail);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                    }
                }
            }

            lblTime.Text = $"{h:00}:{m:00}:{s:00}";
        }
    }
}

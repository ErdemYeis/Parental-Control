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
using System.Text.RegularExpressions;
using System.Globalization;

namespace E_Kontrol
{
    public partial class MainForm : Form
    {
        bool isTxtFull,isMailValid, isLogMailValid, isBigF, isSingup,FormArasıGecis;
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-HOOKELP\\SQLEXPRESS;Initial Catalog=EKontrol;Integrated Security=True");
        public MainForm()
        {
            InitializeComponent();
        }
        
        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email)) 
            {
                return false;
            }
            try
            {
                email = Regex.Replace(email, @"(@)(.+)$", DomainMapper,RegexOptions.None, TimeSpan.FromMilliseconds(200));

                string DomainMapper(Match match)
                {
                    var idn = new IdnMapping();

                    string domainName = idn.GetAscii(match.Groups[2].Value);

                    return match.Groups[1].Value + domainName;
                }
            }
            catch (RegexMatchTimeoutException e)
            {
                return false; ;
            }
            catch (ArgumentException e)
            {
                return false;
            }
            try
            {
                return Regex.IsMatch(email,
                    @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
                    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            pnlSGN.Visible = false;
            pnlLGN.Visible = true;
            FormArasıGecis = false;
            if (Properties.Settings.Default.UserMail != string.Empty)
            {
                txtMail.Text = Properties.Settings.Default.UserMail;
                txtPass.Text = Properties.Settings.Default.UserPassword;
                button1_Click(sender, e);
            }
        }

        private void btnSGN_Click(object sender, EventArgs e)
        {
            pnlSGN.Visible = true;
            pnlLGN.Visible = false;

            btnSGN.BackColor = Color.Yellow;
            btnLGN.BackColor = Color.White;
        }

        private void txtMail_Enter(object sender, EventArgs e)
        {
            if (txtMail.Text== "Email Adresi")
            {
                txtMail.Text = "";
            }
        }

        private void txtMail_Leave(object sender, EventArgs e)
        {
            if (txtMail.Text == "")
            {
                txtMail.Text = "Email Adresi";
            }
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "Şifre")
            {
                txtPass.Text = "";
            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                txtPass.Text = "Şifre";
            }
        }

        private void txtMail_TextChanged(object sender, EventArgs e)
        {
            if (txtMail.Text == "")
            {
                txtMail.ForeColor = Color.Black;
            }
            else if (txtMail.Text == "Email Adresi")
            {
                txtMail.ForeColor = Color.LightGray;
            }
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                txtPass.ForeColor = Color.Black;
            }
            else if (txtPass.Text == "Şifre")
            {
                txtPass.ForeColor = Color.LightGray;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //YETKİLİ GİRİŞ
            string mail = txtMail.Text;
            string passw = txtPass.Text;

            try
            {
                using (connection)
                {
                    connection.Open();

                    string query = "SELECT COUNT(*) FROM Kullanici WHERE KullanıcıID = 1 AND email = @mail AND sifre = @passw";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@mail", mail);
                        command.Parameters.AddWithValue("@passw", passw);

                        int result = (int)command.ExecuteScalar();

                        if (result > 0)
                        {
                            MessageBox.Show("Giriş başarılı!");
                            YönetimPaneli formyp = new YönetimPaneli();
                            formyp.Show();
                            this.Hide();
                            FormArasıGecis = true;
                        }
                        else
                        {
                            MessageBox.Show("Hatalı kullanıcı adı veya parola!");
                        }

                        connection.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void txtLogMail_TextChanged(object sender, EventArgs e)
        {
            isLogMailValid = IsValidEmail(txtLogMail.Text);
            if (isLogMailValid == false)
            {
                lblerron.Text = "Geçerli Bir Email Adresi Giriniz.";
                isSingup = false;
            }
            else
            {
                lblerron.Text = "";
                isSingup = true;
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (FormArasıGecis == true)
            {
                Application.Exit();
            }
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }

        private void txtLogPass_TextChanged(object sender, EventArgs e)
        {
            if (txtLogPass.Text.Length<=5|| txtLogPass.Text.Length >=20)
            {
                isSingup = false;
                lblerron.Text = "Şifre 5 Karakterden Büyük 20 Karakterden Küçük Olmalıdır.";
            }
            else
            {
                isSingup = true;
                lblerron.Text = "";
            }
        }

        private void txtLogPhone_TextChanged(object sender, EventArgs e)
        {
            if (txtLogPhone.Text.Length !=10)
            {
                lblerron.Text = "Geçerli Bir telefon numarası giriniz.";
                isSingup = false;
            }
            else
            {
                lblerron.Text = "";
                isSingup = true;
            }
        }

        private void btnSNG_Click(object sender, EventArgs e)
        {
            //ÜYE OLMA
            string anahtar = txtKey.Text;
            string email = txtLogMail.Text;
            string tel = txtLogPhone.Text;
            string sifre = txtLogPass.Text;

            isLogMailValid = IsValidEmail(email);

            if (string.IsNullOrEmpty(anahtar) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(tel) || string.IsNullOrEmpty(sifre))
            {
                MessageBox.Show("Kullanıcı adı ve şifre boş bırakılamaz.", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (isLogMailValid == true && isSingup == true)
            {
                try
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM Anahtarlar WHERE Anahtar = @anadi and KullanılıyorMu=0";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@anadi", anahtar);

                        int result = (int)command.ExecuteScalar();

                        if (result > 0)
                        {
                            //anahtar var

                            string queryMail = "SELECT COUNT(*) FROM Kullanici WHERE email = @mail";

                            using (SqlCommand cmdMail = new SqlCommand(queryMail, connection))
                            {
                                cmdMail.Parameters.AddWithValue("@mail", email);

                                int resultMail = (int)cmdMail.ExecuteScalar();

                                if (resultMail > 0)
                                {
                                    MessageBox.Show("Bu Eposta Daha Önce Kullanılmış.", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                {
                                    //MAİL DAHA ÖNCE KULLANILMAMIŞ

                                    SqlCommand cmds = new SqlCommand("INSERT INTO Kullanici (email, telno,sifre,DuzenlemeIzın) VALUES (@email, @tel, @sifre,1)", connection);
                                    cmds.Parameters.AddWithValue("@email", email);
                                    cmds.Parameters.AddWithValue("@tel", tel);
                                    cmds.Parameters.AddWithValue("@sifre", sifre);
                                    cmds.ExecuteNonQuery();

                                    MessageBox.Show("Kullanıcı Kaydedildi, Giriş Yapbilirsiniz.", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    SqlCommand cmd = new SqlCommand("SELECT AnahtarID FROM Anahtarlar where Anahtar = @anhtr", connection);
                                    cmd.Parameters.AddWithValue("@anhtr", anahtar);
                                    int anahtarid = Convert.ToInt32(cmd.ExecuteScalar());
                                    SqlCommand cmd2 = new SqlCommand("SELECT KullanıcıID FROM Kullanici where email = @mail", connection);
                                    cmd2.Parameters.AddWithValue("@mail", email);
                                    int kullanıcıid = Convert.ToInt32(cmd2.ExecuteScalar());

                                    SqlCommand updtcmd = new SqlCommand("Update Anahtarlar set KullanılıyorMu=1 where AnahtarID=@aid", connection);
                                    updtcmd.Parameters.AddWithValue("@aid", anahtarid);
                                    updtcmd.ExecuteNonQuery();

                                    SqlCommand inscmd = new SqlCommand("insert into KullaniciAnahtari (KullanıcıID,AnahtarID) values(@kid,@aid)", connection);
                                    inscmd.Parameters.AddWithValue("@kid", kullanıcıid);
                                    inscmd.Parameters.AddWithValue("@aid", anahtarid);
                                    inscmd.ExecuteNonQuery();

                                    txtLogMail.Text = "";
                                    txtKey.Text = "";
                                    txtLogPass.Text = "";
                                    txtLogPhone.Text = "";

                                    pnlSGN.Visible = false;
                                    pnlLGN.Visible = true;

                                    btnSGN.BackColor = Color.White;
                                    btnLGN.BackColor = Color.Yellow;
                                }
                            }
                            
                        }
                        else
                        {
                            MessageBox.Show("Anahtar Bulunmamaktadır veya Daha önce Kullanılmıştır Bir Hata Olduğunu Düşünüyorsanız Bize Ulaşınız: erdemkurt341@gmail.com", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kullanıcı kaydı sırasında bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void btnLGN_Click(object sender, EventArgs e)
        {
            pnlSGN.Visible = false;
            pnlLGN.Visible = true;

            btnSGN.BackColor = Color.White;
            btnLGN.BackColor = Color.Yellow;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            isMailValid = IsValidEmail(txtMail.Text);
            
            if (txtMail.Text == "" || txtPass.Text == "")
            {
                isTxtFull = false;
            }
            else
            {
                isTxtFull = true;
            }
            if (txtPass.Text.Length < 5)
            {
                isBigF = false;
            }
            else
            {
                isBigF = true;
            }

            if (isMailValid == false || isTxtFull == false || isBigF == false)
            {
                MessageBox.Show("Giriş Bilgileri Hatalı.", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string mail = txtMail.Text;
                string passw = txtPass.Text;

                try
                {
                    using (connection)
                    {
                        connection.Open();

                        string query = "SELECT COUNT(*) FROM Kullanici WHERE email = @mail AND sifre = @passw";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@mail", mail);
                            command.Parameters.AddWithValue("@passw", passw);

                            int result = (int)command.ExecuteScalar();

                            if (result > 0)
                            {
                                if (Properties.Settings.Default.UserMail == string.Empty)
                                {
                                    Properties.Settings.Default.UserMail = mail;
                                    Properties.Settings.Default.UserPassword = passw;
                                    Properties.Settings.Default.Save();
                                }
                                ApplicationContext usrpnl = new ApplicationContext();
                                usrpnl.Show();
                                this.WindowState = FormWindowState.Minimized;
                                this.ShowInTaskbar = false;
                            }
                            else
                            {
                                MessageBox.Show("Hatalı kullanıcı adı veya parola!", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                            connection.Close();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }
            }
        }
    }
}

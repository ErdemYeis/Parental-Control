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
using System.Diagnostics;

namespace E_Kontrol
{
    public partial class YönetimPaneli : Form
    {
        string connectionString = "Data Source=DESKTOP-HOOKELP\\SQLEXPRESS;Initial Catalog=EKontrol;Integrated Security=True";

        int k = 0,id;
        string harf = "QWERTYUIOPASDFGHJKLZXCVBNMQWERTYUIOPASDFGHJKLZXCVBNM";
        string numara = "012345678901234567890123456789";
        Random rdm = new Random();
        string KeyStr = "";
        public YönetimPaneli()
        {
            InitializeComponent();
        }
        void RandomKeyGenerator()
        {
            string keyContent = harf + numara;
            KeyStr = String.Empty;
            for (int i = 0; i < Convert.ToInt32(txtKeyCount.Text); i++)
            {
                KeyStr = String.Empty;
                for (int j = 0; j < 10; j++)
                {
                    int x = rdm.Next(0, keyContent.Length);
                    char c = keyContent[x];
                    KeyStr += c;
                }
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();

                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Anahtarlar WHERE Anahtar = @key", connection);
                cmd.Parameters.AddWithValue("@key", KeyStr);

                int resultKey = (int)cmd.ExecuteScalar();
                if (resultKey > 0)
                {
                    k++;
                    continue;
                }
                else
                {
                    SqlCommand cmdII = new SqlCommand("insert into Anahtarlar (Anahtar,KullanılıyorMu) values(@key,0)", connection);
                    cmdII.Parameters.AddWithValue("@key", KeyStr);
                    cmdII.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Yeni Anahtarlar Oluşturuldu", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        void LoadDtGridVwUsers()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            SqlDataAdapter adapter = new SqlDataAdapter("Select * From Kullanici", connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            dtGrdVw.DataSource = dataTable;
            connection.Close();
        }
        void LoadDtGridVwKeys() 
        {
            btnKey.BackColor = Color.Yellow;
            btnUsrs.BackColor = Color.White;

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            SqlDataAdapter adapter = new SqlDataAdapter("Select * From Anahtarlar", connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            dtGrdVw.DataSource = dataTable;
            connection.Close();
        }
        void UsedKeyLoad() 
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Anahtarlar where KullanılıyorMu = 0", connection);
            int Count = Convert.ToInt32(cmd.ExecuteScalar());
            txtUsedKey.Text = Convert.ToString(Count);

            connection.Close();
        }

        private void btnUsrs_Click(object sender, EventArgs e)
        {
            btnKey.BackColor = Color.White;
            btnUsrs.BackColor = Color.Yellow;
            LoadDtGridVwUsers();
        }

        private void btnKey_Click(object sender, EventArgs e)
        {
            UsedKeyLoad();
            LoadDtGridVwKeys();
        }
        private void YönetimPaneli_Load(object sender, EventArgs e)
        {
            LoadDtGridVwUsers();
            UsedKeyLoad();
        }

        private void YönetimPaneli_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Yeni Anahtarlar Oluşturmak İstediğine Emin Misin?", "Bilgilendirme Penceresi", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (res == DialogResult.OK)
            {
                RandomKeyGenerator();
            }
            if (res == DialogResult.Cancel)
            {
                MessageBox.Show("İşlem İptal Edildi.", "Bilgilendirme Penceresi");
            }
        }

        private void btnFnd_Click(object sender, EventArgs e)
        {
            if (cmBox.SelectedIndex == 0)
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter("Select * From Kullanici where KullanıcıID=@id", connection);
                adapter.SelectCommand.Parameters.AddWithValue("@id",Convert.ToInt32(txtFnd.Text));
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dtGrdVw.DataSource = dataTable;

                SqlCommand cmd = new SqlCommand("SELECT AnahtarID FROM KullaniciAnahtari where AnahtarID = @anhtr", connection);
                cmd.Parameters.AddWithValue("@anhtr", Convert.ToInt32(txtFnd.Text));
                int anahtarid = Convert.ToInt32(cmd.ExecuteScalar());
                txtFndID.Text = Convert.ToString(anahtarid);
            }
            else if (cmBox.SelectedIndex == 1)
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter("Select * From Kullanici where email=@mail", connection);
                adapter.SelectCommand.Parameters.AddWithValue("@mail", txtFnd.Text);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dtGrdVw.DataSource = dataTable;
                connection.Close();
                txtFndID.Text = "0";
                MessageBox.Show("Kullanıcının Anahtar ID'si Sadece KullanıcıID Girildiğinde Gözükür.", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void btnSve_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Düzenleme İznini Güncellemek İstediğine Emin Misin?", "Bilgilendirme Penceresi", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (res == DialogResult.OK)
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();

                SqlCommand cmd = new SqlCommand("update Kullanici set DuzenlemeIzın = 1 where KullanıcıID=@id", connection);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Güncelleme Kaydedildi.", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UsedKeyLoad();
            }
            if (res == DialogResult.Cancel)
            {
                MessageBox.Show("işlem İptal Edildi.");
            }
        }

        private void dtGrdVw_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex==4)
            {
                DataGridViewRow row = dtGrdVw.Rows[e.RowIndex];
                id = Convert.ToInt32(row.Cells[0].Value);
            }
        }
    }
}

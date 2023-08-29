
namespace E_Kontrol
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLGN = new System.Windows.Forms.Button();
            this.btnSGN = new System.Windows.Forms.Button();
            this.pnlLGN = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.pnlSGN = new System.Windows.Forms.Panel();
            this.lblerron = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtLogPass = new System.Windows.Forms.TextBox();
            this.btnSNG = new System.Windows.Forms.Button();
            this.txtLogPhone = new System.Windows.Forms.TextBox();
            this.txtLogMail = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.pnlLGN.SuspendLayout();
            this.pnlSGN.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(61, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "E-Kontrol";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(62, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hoşgeldiniz";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLGN
            // 
            this.btnLGN.BackColor = System.Drawing.Color.Yellow;
            this.btnLGN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLGN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLGN.ForeColor = System.Drawing.Color.Black;
            this.btnLGN.Location = new System.Drawing.Point(12, 92);
            this.btnLGN.Name = "btnLGN";
            this.btnLGN.Size = new System.Drawing.Size(118, 41);
            this.btnLGN.TabIndex = 2;
            this.btnLGN.Text = "Giriş Yap";
            this.btnLGN.UseVisualStyleBackColor = false;
            this.btnLGN.Click += new System.EventHandler(this.btnLGN_Click);
            // 
            // btnSGN
            // 
            this.btnSGN.BackColor = System.Drawing.Color.White;
            this.btnSGN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSGN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSGN.Location = new System.Drawing.Point(128, 92);
            this.btnSGN.Name = "btnSGN";
            this.btnSGN.Size = new System.Drawing.Size(121, 41);
            this.btnSGN.TabIndex = 3;
            this.btnSGN.Text = "Üye Ol";
            this.btnSGN.UseVisualStyleBackColor = false;
            this.btnSGN.Click += new System.EventHandler(this.btnSGN_Click);
            // 
            // pnlLGN
            // 
            this.pnlLGN.Controls.Add(this.button1);
            this.pnlLGN.Controls.Add(this.txtPass);
            this.pnlLGN.Controls.Add(this.txtMail);
            this.pnlLGN.Location = new System.Drawing.Point(12, 150);
            this.pnlLGN.Name = "pnlLGN";
            this.pnlLGN.Size = new System.Drawing.Size(237, 232);
            this.pnlLGN.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Yellow;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(65, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 41);
            this.button1.TabIndex = 5;
            this.button1.Text = "Giriş Yap";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPass.ForeColor = System.Drawing.Color.LightGray;
            this.txtPass.Location = new System.Drawing.Point(29, 67);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(170, 23);
            this.txtPass.TabIndex = 2;
            this.txtPass.Text = "Şifre";
            this.txtPass.TextChanged += new System.EventHandler(this.txtPass_TextChanged);
            this.txtPass.Enter += new System.EventHandler(this.txtPass_Enter);
            this.txtPass.Leave += new System.EventHandler(this.txtPass_Leave);
            // 
            // txtMail
            // 
            this.txtMail.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMail.ForeColor = System.Drawing.Color.LightGray;
            this.txtMail.Location = new System.Drawing.Point(29, 21);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(170, 23);
            this.txtMail.TabIndex = 0;
            this.txtMail.Text = "Email Adresi";
            this.txtMail.TextChanged += new System.EventHandler(this.txtMail_TextChanged);
            this.txtMail.Enter += new System.EventHandler(this.txtMail_Enter);
            this.txtMail.Leave += new System.EventHandler(this.txtMail_Leave);
            // 
            // pnlSGN
            // 
            this.pnlSGN.Controls.Add(this.lblerron);
            this.pnlSGN.Controls.Add(this.label6);
            this.pnlSGN.Controls.Add(this.txtKey);
            this.pnlSGN.Controls.Add(this.label5);
            this.pnlSGN.Controls.Add(this.label4);
            this.pnlSGN.Controls.Add(this.label3);
            this.pnlSGN.Controls.Add(this.textBox1);
            this.pnlSGN.Controls.Add(this.txtLogPass);
            this.pnlSGN.Controls.Add(this.btnSNG);
            this.pnlSGN.Controls.Add(this.txtLogPhone);
            this.pnlSGN.Controls.Add(this.txtLogMail);
            this.pnlSGN.Location = new System.Drawing.Point(12, 147);
            this.pnlSGN.Name = "pnlSGN";
            this.pnlSGN.Size = new System.Drawing.Size(237, 330);
            this.pnlSGN.TabIndex = 6;
            // 
            // lblerron
            // 
            this.lblerron.AutoSize = true;
            this.lblerron.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblerron.ForeColor = System.Drawing.Color.Red;
            this.lblerron.Location = new System.Drawing.Point(3, 308);
            this.lblerron.Name = "lblerron";
            this.lblerron.Size = new System.Drawing.Size(0, 13);
            this.lblerron.TabIndex = 13;
            this.lblerron.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(62, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "E-KontKey";
            // 
            // txtKey
            // 
            this.txtKey.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKey.ForeColor = System.Drawing.Color.Black;
            this.txtKey.Location = new System.Drawing.Point(29, 24);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(170, 23);
            this.txtKey.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(89, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Şifre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(52, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Telefon Numarası";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(62, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Email Adresi";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(29, 146);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(57, 23);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "TR - +90";
            // 
            // txtLogPass
            // 
            this.txtLogPass.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtLogPass.ForeColor = System.Drawing.Color.Black;
            this.txtLogPass.Location = new System.Drawing.Point(29, 212);
            this.txtLogPass.Name = "txtLogPass";
            this.txtLogPass.PasswordChar = '*';
            this.txtLogPass.Size = new System.Drawing.Size(170, 23);
            this.txtLogPass.TabIndex = 6;
            this.txtLogPass.TextChanged += new System.EventHandler(this.txtLogPass_TextChanged);
            // 
            // btnSNG
            // 
            this.btnSNG.BackColor = System.Drawing.Color.Yellow;
            this.btnSNG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSNG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSNG.ForeColor = System.Drawing.Color.Black;
            this.btnSNG.Location = new System.Drawing.Point(65, 251);
            this.btnSNG.Name = "btnSNG";
            this.btnSNG.Size = new System.Drawing.Size(93, 41);
            this.btnSNG.TabIndex = 5;
            this.btnSNG.Text = "Üye Ol";
            this.btnSNG.UseVisualStyleBackColor = false;
            this.btnSNG.Click += new System.EventHandler(this.btnSNG_Click);
            // 
            // txtLogPhone
            // 
            this.txtLogPhone.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtLogPhone.ForeColor = System.Drawing.Color.Black;
            this.txtLogPhone.Location = new System.Drawing.Point(92, 146);
            this.txtLogPhone.Name = "txtLogPhone";
            this.txtLogPhone.Size = new System.Drawing.Size(107, 23);
            this.txtLogPhone.TabIndex = 2;
            this.txtLogPhone.TextChanged += new System.EventHandler(this.txtLogPhone_TextChanged);
            // 
            // txtLogMail
            // 
            this.txtLogMail.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtLogMail.ForeColor = System.Drawing.Color.Black;
            this.txtLogMail.Location = new System.Drawing.Point(29, 86);
            this.txtLogMail.Name = "txtLogMail";
            this.txtLogMail.Size = new System.Drawing.Size(170, 23);
            this.txtLogMail.TabIndex = 0;
            this.txtLogMail.TextChanged += new System.EventHandler(this.txtLogMail_TextChanged);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(77, 483);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(93, 30);
            this.button3.TabIndex = 13;
            this.button3.Text = "Yetkili Giriş";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(261, 515);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.pnlSGN);
            this.Controls.Add(this.pnlLGN);
            this.Controls.Add(this.btnSGN);
            this.Controls.Add(this.btnLGN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "E-Kontrol";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnlLGN.ResumeLayout(false);
            this.pnlLGN.PerformLayout();
            this.pnlSGN.ResumeLayout(false);
            this.pnlSGN.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLGN;
        private System.Windows.Forms.Button btnSGN;
        private System.Windows.Forms.Panel pnlLGN;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Panel pnlSGN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtLogPass;
        private System.Windows.Forms.Button btnSNG;
        private System.Windows.Forms.TextBox txtLogPhone;
        private System.Windows.Forms.TextBox txtLogMail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblerron;
    }
}


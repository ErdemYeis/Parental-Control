
namespace E_Kontrol
{
    partial class YönetimPaneli
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtGrdVw = new System.Windows.Forms.DataGridView();
            this.btnKey = new System.Windows.Forms.Button();
            this.btnUsrs = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtFndID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnFnd = new System.Windows.Forms.Button();
            this.txtFnd = new System.Windows.Forms.TextBox();
            this.cmBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtKeyCount = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtUsedKey = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSve = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVw)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(208, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "E-Kontrol";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(195, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Yönetim Paneli";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtGrdVw
            // 
            this.dtGrdVw.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGrdVw.BackgroundColor = System.Drawing.Color.Beige;
            this.dtGrdVw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdVw.Location = new System.Drawing.Point(8, 137);
            this.dtGrdVw.Name = "dtGrdVw";
            this.dtGrdVw.Size = new System.Drawing.Size(406, 185);
            this.dtGrdVw.TabIndex = 3;
            this.dtGrdVw.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGrdVw_CellValueChanged);
            // 
            // btnKey
            // 
            this.btnKey.BackColor = System.Drawing.Color.White;
            this.btnKey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKey.Location = new System.Drawing.Point(124, 100);
            this.btnKey.Name = "btnKey";
            this.btnKey.Size = new System.Drawing.Size(121, 31);
            this.btnKey.TabIndex = 5;
            this.btnKey.Text = "Anahtarlar";
            this.btnKey.UseVisualStyleBackColor = false;
            this.btnKey.Click += new System.EventHandler(this.btnKey_Click);
            // 
            // btnUsrs
            // 
            this.btnUsrs.BackColor = System.Drawing.Color.Yellow;
            this.btnUsrs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsrs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUsrs.ForeColor = System.Drawing.Color.Black;
            this.btnUsrs.Location = new System.Drawing.Point(8, 100);
            this.btnUsrs.Name = "btnUsrs";
            this.btnUsrs.Size = new System.Drawing.Size(118, 31);
            this.btnUsrs.TabIndex = 4;
            this.btnUsrs.Text = "Kullanıcılar";
            this.btnUsrs.UseVisualStyleBackColor = false;
            this.btnUsrs.Click += new System.EventHandler(this.btnUsrs_Click);
            // 
            // panel1
            // 
            this.panel1.AccessibleName = "";
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.txtFndID);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btnFnd);
            this.panel1.Controls.Add(this.txtFnd);
            this.panel1.Controls.Add(this.cmBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(8, 339);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(278, 193);
            this.panel1.TabIndex = 6;
            // 
            // txtFndID
            // 
            this.txtFndID.Location = new System.Drawing.Point(165, 138);
            this.txtFndID.Name = "txtFndID";
            this.txtFndID.ReadOnly = true;
            this.txtFndID.Size = new System.Drawing.Size(72, 20);
            this.txtFndID.TabIndex = 12;
            this.txtFndID.Text = "0";
            this.txtFndID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(25, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Kullanııc Anahtar ID:";
            // 
            // btnFnd
            // 
            this.btnFnd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnFnd.Location = new System.Drawing.Point(72, 82);
            this.btnFnd.Name = "btnFnd";
            this.btnFnd.Size = new System.Drawing.Size(95, 36);
            this.btnFnd.TabIndex = 12;
            this.btnFnd.Text = "Kullanıcı Bul";
            this.btnFnd.UseVisualStyleBackColor = false;
            this.btnFnd.Click += new System.EventHandler(this.btnFnd_Click);
            // 
            // txtFnd
            // 
            this.txtFnd.Location = new System.Drawing.Point(81, 37);
            this.txtFnd.Name = "txtFnd";
            this.txtFnd.Size = new System.Drawing.Size(169, 20);
            this.txtFnd.TabIndex = 12;
            this.txtFnd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cmBox
            // 
            this.cmBox.FormattingEnabled = true;
            this.cmBox.Items.AddRange(new object[] {
            "ID",
            "E-mail"});
            this.cmBox.Location = new System.Drawing.Point(4, 36);
            this.cmBox.Name = "cmBox";
            this.cmBox.Size = new System.Drawing.Size(60, 21);
            this.cmBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Kullanıcı İşlemleri";
            // 
            // panel2
            // 
            this.panel2.AccessibleName = "";
            this.panel2.BackColor = System.Drawing.SystemColors.Info;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtKeyCount);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.txtUsedKey);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(307, 339);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(278, 193);
            this.panel2.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(3, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(185, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Oluşturalacak Anahtar Sayısı :";
            // 
            // txtKeyCount
            // 
            this.txtKeyCount.Location = new System.Drawing.Point(192, 102);
            this.txtKeyCount.Name = "txtKeyCount";
            this.txtKeyCount.Size = new System.Drawing.Size(72, 20);
            this.txtKeyCount.TabIndex = 10;
            this.txtKeyCount.Text = "10";
            this.txtKeyCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.Location = new System.Drawing.Point(91, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 36);
            this.button1.TabIndex = 8;
            this.button1.Text = "Anahtar Oluştur";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtUsedKey
            // 
            this.txtUsedKey.Location = new System.Drawing.Point(192, 35);
            this.txtUsedKey.Name = "txtUsedKey";
            this.txtUsedKey.ReadOnly = true;
            this.txtUsedKey.Size = new System.Drawing.Size(72, 20);
            this.txtUsedKey.TabIndex = 9;
            this.txtUsedKey.Text = "0";
            this.txtUsedKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(3, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Kullanılmayan Anahtar Sayısı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Anahtar İşlemleri";
            // 
            // btnSve
            // 
            this.btnSve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSve.Location = new System.Drawing.Point(445, 275);
            this.btnSve.Name = "btnSve";
            this.btnSve.Size = new System.Drawing.Size(106, 47);
            this.btnSve.TabIndex = 13;
            this.btnSve.Text = "Düzenleme Ayarını Kaydet";
            this.btnSve.UseVisualStyleBackColor = false;
            this.btnSve.Click += new System.EventHandler(this.btnSve_Click);
            // 
            // YönetimPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 558);
            this.Controls.Add(this.btnSve);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnKey);
            this.Controls.Add(this.btnUsrs);
            this.Controls.Add(this.dtGrdVw);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "YönetimPaneli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YönetimPaneli";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.YönetimPaneli_FormClosing);
            this.Load += new System.EventHandler(this.YönetimPaneli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVw)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtGrdVw;
        private System.Windows.Forms.Button btnKey;
        private System.Windows.Forms.Button btnUsrs;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUsedKey;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtKeyCount;
        private System.Windows.Forms.Button btnFnd;
        private System.Windows.Forms.TextBox txtFnd;
        private System.Windows.Forms.ComboBox cmBox;
        private System.Windows.Forms.TextBox txtFndID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSve;
    }
}
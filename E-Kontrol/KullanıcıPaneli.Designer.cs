
namespace E_Kontrol
{
    partial class ApplicationContext
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlTime = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.pnlGntle = new System.Windows.Forms.Panel();
            this.dtaGrd = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.pnlTime.SuspendLayout();
            this.pnlGntle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtaGrd)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(220, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kullanıcı Paneli";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(233, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "E-Kontrol";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlTime
            // 
            this.pnlTime.BackColor = System.Drawing.SystemColors.Info;
            this.pnlTime.Controls.Add(this.label4);
            this.pnlTime.Controls.Add(this.button2);
            this.pnlTime.Controls.Add(this.button1);
            this.pnlTime.Controls.Add(this.txtTime);
            this.pnlTime.Controls.Add(this.label3);
            this.pnlTime.Location = new System.Drawing.Point(12, 126);
            this.pnlTime.Name = "pnlTime";
            this.pnlTime.Size = new System.Drawing.Size(217, 230);
            this.pnlTime.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(27, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 50);
            this.label4.TabIndex = 4;
            this.label4.Text = "Düzenleme isteği gönderdiğinizde telefon ile aranacaksınız.";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button2.Location = new System.Drawing.Point(45, 119);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 37);
            this.button2.TabIndex = 3;
            this.button2.Text = "Düzenleme İsteği Gönder";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(64, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(6, 54);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(197, 20);
            this.txtTime.TabIndex = 1;
            this.txtTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(3, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Kaç Saat Kullanılmasını istiyorsunuz.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(260, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(378, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "Bilgisayar Açıldığından beri geçen Süre";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTime.Location = new System.Drawing.Point(367, 180);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(151, 37);
            this.lblTime.TabIndex = 9;
            this.lblTime.Text = "00:00:00";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(389, 317);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 37);
            this.button3.TabIndex = 10;
            this.button3.Text = "Kullanım Geçmişini Görüntüle";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pnlGntle
            // 
            this.pnlGntle.Controls.Add(this.dtaGrd);
            this.pnlGntle.Controls.Add(this.button4);
            this.pnlGntle.Location = new System.Drawing.Point(264, 82);
            this.pnlGntle.Name = "pnlGntle";
            this.pnlGntle.Size = new System.Drawing.Size(374, 272);
            this.pnlGntle.TabIndex = 11;
            // 
            // dtaGrd
            // 
            this.dtaGrd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtaGrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtaGrd.Location = new System.Drawing.Point(31, 35);
            this.dtaGrd.Name = "dtaGrd";
            this.dtaGrd.Size = new System.Drawing.Size(306, 209);
            this.dtaGrd.TabIndex = 1;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Red;
            this.button4.Location = new System.Drawing.Point(299, 9);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(38, 23);
            this.button4.TabIndex = 0;
            this.button4.Text = "X";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // ApplicationContext
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 366);
            this.Controls.Add(this.pnlGntle);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pnlTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ApplicationContext";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KullanıcıPaneli";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.KullanıcıPaneli_FormClosing);
            this.Load += new System.EventHandler(this.KullanıcıPaneli_Load);
            this.pnlTime.ResumeLayout(false);
            this.pnlTime.PerformLayout();
            this.pnlGntle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtaGrd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel pnlGntle;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dtaGrd;
    }
}
namespace usrCeviriciUretimDestek
{
    partial class UygulamaEkle
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
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.lblPath = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.TextBox();
            this.butonEkle = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.isim = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Active = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Konum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BgRenk = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FoRenk = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnYenile = new System.Windows.Forms.Button();
            this.lblUygulama = new System.Windows.Forms.Label();
            this.lblExe = new System.Windows.Forms.Label();
            this.btnKaldır = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.butonActive = new System.Windows.Forms.CheckBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnColor = new System.Windows.Forms.Button();
            this.btnTextColor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(620, 109);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 22);
            this.button1.TabIndex = 0;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblPath
            // 
            this.lblPath.Location = new System.Drawing.Point(374, 109);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(240, 22);
            this.lblPath.TabIndex = 1;
            this.lblPath.Click += new System.EventHandler(this.lblPath_Click);
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(374, 65);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(240, 22);
            this.lblName.TabIndex = 2;
            // 
            // butonEkle
            // 
            this.butonEkle.BackColor = System.Drawing.Color.Green;
            this.butonEkle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.butonEkle.Location = new System.Drawing.Point(589, 175);
            this.butonEkle.Name = "butonEkle";
            this.butonEkle.Size = new System.Drawing.Size(106, 57);
            this.butonEkle.TabIndex = 4;
            this.butonEkle.Text = "Listeye Ekle";
            this.butonEkle.UseVisualStyleBackColor = false;
            this.butonEkle.Click += new System.EventHandler(this.btnListEkle_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.DarkRed;
            this.btnReset.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReset.Location = new System.Drawing.Point(589, 489);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(106, 57);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Liste Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // listView1
            // 
            this.listView1.AllowDrop = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.isim,
            this.Active,
            this.Konum,
            this.BgRenk,
            this.FoRenk});
            this.listView1.FullRowSelect = true;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(2, 12);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(230, 468);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // isim
            // 
            this.isim.Text = "İsim";
            this.isim.Width = 90;
            // 
            // Active
            // 
            this.Active.Text = "Aktif";
            // 
            // Konum
            // 
            this.Konum.Text = "Konum";
            this.Konum.Width = 0;
            // 
            // BgRenk
            // 
            this.BgRenk.Text = "BgRenk";
            this.BgRenk.Width = 0;
            // 
            // FoRenk
            // 
            this.FoRenk.Text = "FoRenk";
            this.FoRenk.Width = 0;
            // 
            // btnYenile
            // 
            this.btnYenile.Location = new System.Drawing.Point(2, 489);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(118, 68);
            this.btnYenile.TabIndex = 7;
            this.btnYenile.Text = "Listeyi Güncellemeye Zorla";
            this.btnYenile.UseVisualStyleBackColor = true;
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // lblUygulama
            // 
            this.lblUygulama.AutoSize = true;
            this.lblUygulama.Location = new System.Drawing.Point(235, 65);
            this.lblUygulama.Name = "lblUygulama";
            this.lblUygulama.Size = new System.Drawing.Size(133, 16);
            this.lblUygulama.TabIndex = 8;
            this.lblUygulama.Text = "Uygulama ismi giriniz";
            // 
            // lblExe
            // 
            this.lblExe.AutoSize = true;
            this.lblExe.Location = new System.Drawing.Point(235, 115);
            this.lblExe.Name = "lblExe";
            this.lblExe.Size = new System.Drawing.Size(123, 16);
            this.lblExe.TabIndex = 9;
            this.lblExe.Text = "Uygulamayı seçiniz";
            // 
            // btnKaldır
            // 
            this.btnKaldır.BackColor = System.Drawing.Color.DarkRed;
            this.btnKaldır.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnKaldır.Location = new System.Drawing.Point(589, 423);
            this.btnKaldır.Name = "btnKaldır";
            this.btnKaldır.Size = new System.Drawing.Size(106, 57);
            this.btnKaldır.TabIndex = 10;
            this.btnKaldır.Text = "Listeden Kaldır";
            this.btnKaldır.UseVisualStyleBackColor = false;
            this.btnKaldır.Click += new System.EventHandler(this.btnListKaldır_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(112, 489);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(120, 68);
            this.buttonLoad.TabIndex = 11;
            this.buttonLoad.Text = "Butonları Güncellemeye Zorla";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonEkle_Click_1);
            // 
            // butonActive
            // 
            this.butonActive.AutoSize = true;
            this.butonActive.Checked = true;
            this.butonActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.butonActive.Location = new System.Drawing.Point(277, 149);
            this.butonActive.Name = "butonActive";
            this.butonActive.Size = new System.Drawing.Size(91, 20);
            this.butonActive.TabIndex = 13;
            this.butonActive.Text = "Buton Aktif";
            this.butonActive.UseVisualStyleBackColor = true;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.Gold;
            this.btnGuncelle.Location = new System.Drawing.Point(589, 238);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(106, 57);
            this.btnGuncelle.TabIndex = 14;
            this.btnGuncelle.Text = "Seçili Elemanı Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(238, 175);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(106, 57);
            this.btnColor.TabIndex = 15;
            this.btnColor.Text = "Arka Plan Rengi Seç";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnTextColor
            // 
            this.btnTextColor.Location = new System.Drawing.Point(350, 175);
            this.btnTextColor.Name = "btnTextColor";
            this.btnTextColor.Size = new System.Drawing.Size(106, 57);
            this.btnTextColor.TabIndex = 16;
            this.btnTextColor.Text = "Yazı Rengi Seç";
            this.btnTextColor.UseVisualStyleBackColor = true;
            this.btnTextColor.Click += new System.EventHandler(this.btnTextColor_Click);
            // 
            // UygulamaEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 569);
            this.Controls.Add(this.btnTextColor);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.butonActive);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.btnKaldır);
            this.Controls.Add(this.lblExe);
            this.Controls.Add(this.lblUygulama);
            this.Controls.Add(this.btnYenile);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.butonEkle);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.button1);
            this.Name = "UygulamaEkle";
            this.Text = "UygulamaEkle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox lblPath;
        private System.Windows.Forms.TextBox lblName;
        private System.Windows.Forms.Button butonEkle;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnYenile;
        private System.Windows.Forms.ColumnHeader Konum;
        private System.Windows.Forms.Label lblUygulama;
        private System.Windows.Forms.Label lblExe;
        private System.Windows.Forms.Button btnKaldır;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.ColumnHeader Active;
        private System.Windows.Forms.CheckBox butonActive;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.ColumnHeader BgRenk;
        private System.Windows.Forms.Button btnTextColor;
        private System.Windows.Forms.ColumnHeader isim;
        private System.Windows.Forms.ColumnHeader FoRenk;
    }
}
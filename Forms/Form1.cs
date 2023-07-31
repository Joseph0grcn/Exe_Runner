using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace usrCeviriciUretimDestek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            loadTable();

        }

        private void loadTable()
        {
            this.clearPanel();
            var apps = JsonConvert.DeserializeObject<List<AppSettings>>(Properties.Settings.Default.AppSettings) ?? new List<AppSettings>();
            foreach (var app in apps)
            {
                ListViewItem item = new ListViewItem(app.Name);
                item.SubItems.Add(app.IsActive.ToString());
                item.SubItems.Add(app.Path);
                item.SubItems.Add(app.BgRenk.ToString());
                item.SubItems.Add(app.FoRenk.ToString());
                //listView1.Items.Add(item);
                if (app.IsActive == true)
                {
                    this.AddButton(item);

                }
            }
        }

        //private void refresh()
        //{
        //    var apps = JsonConvert.DeserializeObject<List<AppSettings>>(Properties.Settings.Default.AppSettings) ?? new List<AppSettings>();




        //    foreach (AppSettings app in apps)
        //    {

        //            Button button = new Button();

        //            button.Text = app.Name;
        //            button.Visible = true;
        //            button.Enabled = true;
        //            //button.Font = new font( "Microsoft Sans Serif "19 8pt; style = Bold)
        //            button.Font = new Font("Microsoft Sans Serif", 20, FontStyle.Bold);
        //            button.Height = 122;
        //            button.Width = 150;
        //            button.Padding = new Padding(0);
        //            button.Margin = new Padding(3);

        //            button.Click += (s, e) =>
        //            {
        //                if (File.Exists(app.Path))
        //                {
        //                    System.Diagnostics.Process.Start(app.Path);
        //                }

        //            };
        //            button.Name = app.Name;

        //            flowLayoutPanel1.Controls.Add(button);


        //    }
        //}
        public void AddButton(ListViewItem item)
        {
            //itemdan argumentoutofrange hatası alınırsa yukarıdaki loadtable metodunda düzenlenme yapılmamış demektir orayı düzenleyiniz

            System.Windows.Forms.Button button = new System.Windows.Forms.Button();

           

            button.Text = item.SubItems[0].Text;
            button.Visible = true;
            button.Enabled = true;


            button.BackColor = Color.FromArgb(Convert.ToInt32( item.SubItems[3].Text));
            button.ForeColor = Color.FromArgb(Convert.ToInt32(item.SubItems[4].Text));
            button.Font = new Font("Microsoft Sans Serif", 20, FontStyle.Bold);
            button.Height = 122;
            button.Width = 150;
            button.Padding = new Padding(0);
            button.Margin = new Padding(0);



            button.Click += (s, e) =>
            {
                if (File.Exists(item.SubItems[2].Text))
                {
                    System.Diagnostics.Process.Start(item.SubItems[2].Text);
                }

            };
            //itemdan argumentoutofrange hatası alınırsa yukarıdaki loadtable metodunda düzenlenme yapılmamış demektir orayı düzenleyiniz
            button.Name = item.SubItems[0].Text;
            flowLayoutPanel1.Controls.Add(button);
        }
        

        private void btnMesaj_Click(object sender, EventArgs e)
        {
            String msjPanel = @"C:\Users\\yusuf\OneDrive\Masaüstü\staj dosyalar\Test Program\Test Programı (Son)\trunk\MessagePanelTester\EsitMessagelPanelTester\bin\Debug\EsitMessagelPanelTester.exe";
            System.Diagnostics.Process.Start(msjPanel);

            //btnMesaj.Text = btnMesaj.Width + " " + btnMesaj.Height;
        }

        

        private void btnArayuz_Click(object sender, EventArgs e)
        {

        }

        private void btnBoot_Click(object sender, EventArgs e)
        {

        }

        private void btnDonanım_Click(object sender, EventArgs e)
        {
            String donanımAyar = @"C:\Users\yusuf\OneDrive\Masaüstü\staj dosyalar\[Configuration-Software]USR-TCP232-M4_V2.3.4.106_1687230152.exe";
            System.Diagnostics.Process.Start(donanımAyar);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using (UygulamaEkle uygulamaEkle = new UygulamaEkle(this))
            {
                uygulamaEkle.ShowDialog();
                
               
            }
        }

        public void clearPanel()
        {
            flowLayoutPanel1.Controls.Clear();
        }
    }
}

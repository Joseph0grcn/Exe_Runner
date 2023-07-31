using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Security.Policy;
using System.Windows.Forms;
using usrCeviriciUretimDestek;

namespace usrCeviriciUretimDestek
{
    public partial class UygulamaEkle : Form
    {
        Form1 _form1;
        public UygulamaEkle(Form1 form1)
        {
            InitializeComponent();
            _form1 = form1;
            ListLoad();
            
            
        }

        
        public void LoadMain() 
        {
            _form1.clearPanel();
            var apps = JsonConvert.DeserializeObject<List<AppSettings>>(Properties.Settings.Default.AppSettings) ?? new List<AppSettings>();
            foreach (var app in apps)
            {
                ListViewItem item = new ListViewItem(app.Name);
                item.SubItems.Add(app.IsActive.ToString());
                item.SubItems.Add(app.Path);
                item.SubItems.Add(app.BgRenk.ToString());
                item.SubItems.Add(app.FoRenk.ToString());
                //listView1.Items.Add(item);
                if (app.IsActive==true )
                {
                    _form1.AddButton(item);
                    
                }
            }
            
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();

            file.Filter = "All Files (*.*)|*.exe";
            file.FilterIndex = 1;

            

            if (file.ShowDialog() == DialogResult.OK)
            {
               string fileName  = file.FileName;
                lblPath.Text = fileName;
            }

        }

        

        private void btnListEkle_Click(object sender, EventArgs e)
        {
            ıtemAdd();
            LoadMain();
            MessageBox.Show("Ekleme İşlemi Gerçekleşti", "Eleman Eklendi", MessageBoxButtons.OK);
        }

        private void ıtemAdd()
        {
            var apps = JsonConvert.DeserializeObject<List<AppSettings>>(Properties.Settings.Default.AppSettings) ?? new List<AppSettings>();

            foreach (var app in apps)
            {
                if (app.Name == lblName.Text)
                {
                    return ;
                }
            }
            var appSettings = new AppSettings
            {

                Name = lblName.Text,
                IsActive = butonActive.Checked,
                Path = lblPath.Text,
                BgRenk = btnColor.BackColor.ToArgb(),
                FoRenk = btnTextColor.ForeColor.ToArgb(),

            };
            
            apps.Add(appSettings);



            string jsonString = JsonConvert.SerializeObject(apps);
            Properties.Settings.Default.AppSettings = jsonString;
            Properties.Settings.Default.Save();
            ListLoad();
        }

        

        


        private void lblPath_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();

            file.Filter = "All Files (*.*)|*.exe";
            file.FilterIndex = 1;



            if (file.ShowDialog() == DialogResult.OK)
            {
                string fileName = file.FileName;
                lblPath.Text = fileName;
            }
        }
        private void btnYenile_Click(object sender, EventArgs e)
        {
            ListLoad();
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count == 0)
            {
                return;
            }
            ListViewItem item = listView1.SelectedItems[0];

            //listview den ilk sütundaki isim değişkenini label a yazıyor
            lblName.Text = item.SubItems[0].Text;


            //listview den ikinci sütundan butonun aktif olup olmadığı bilgisini checkbox a iletiyor
            if (item.SubItems[1].Text == "True")
            {
                butonActive.Checked = true;
            }
            else
            {
                butonActive.Checked = false;
            }
            
            //listview den 3. sütundaki path stringini gerekli olan bölgeye iletiyor
            lblPath.Text = item.SubItems[2].Text;

            //listview den 4. sütundaki tutulan renk ayarı arkaplan rengi seçme butonuna buton rengi olarak iletiliyor
            btnColor.BackColor = Color.FromArgb(Convert.ToInt32(item.SubItems[3].Text));
            btnTextColor.BackColor = Color.FromArgb(Convert.ToInt32(item.SubItems[3].Text));

            //listview den 5. sütundaki tutulan renk ayarı text rengi seçme butonuna buton rengi olarak iletiliyor
            btnTextColor.ForeColor = Color.FromArgb(Convert.ToInt32(item.SubItems[4].Text));
            btnColor.ForeColor = Color.FromArgb(Convert.ToInt32(item.SubItems[4].Text));



        }
        private void buttonEkle_Click_1(object sender, EventArgs e)
        {
            //Ana sayfaya buton aktif true olan butonları eklemek için istek yolluyor
            LoadMain();
            
        }
        private void btnListKaldır_Click(object sender, EventArgs e)
        {
            //json da tutulan buton elemanını kaldıran metodu çağırıyor
            DialogResult result = MessageBox.Show("Seçili Elemanın Listeden Kaldırılmasını İstiyor musunuz?", "Elemanı Kaldır", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                ıtemRemove();
                MessageBox.Show("Kaldırma İşlemi Gerçekleşti", "Kaldırma", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Kaldırma İşlemi İptal Edildi", "Kaldırma", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }


        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            
             if (listView1.SelectedItems.Count.Equals(1))
             {
                int selectedItem = listView1.SelectedItems[0].Index;
                var apps = JsonConvert.DeserializeObject<List<AppSettings>>(Properties.Settings.Default.AppSettings) ?? new List<AppSettings>();
                    
                
                apps[selectedItem].Name = lblName.Text;
                apps[selectedItem].IsActive = butonActive.Checked;
                apps[selectedItem].Path = lblPath.Text;
                apps[selectedItem].BgRenk = btnColor.BackColor.ToArgb();
                apps[selectedItem].FoRenk = btnColor.ForeColor.ToArgb();



                string jsonString = JsonConvert.SerializeObject(apps);
                Properties.Settings.Default.AppSettings = jsonString;
                Properties.Settings.Default.Save();
                ListLoad();
                LoadMain();
                MessageBox.Show("Güncelleme İşlemi Gerçekleşti", "Güncelleme", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Güncelleme İşlemi Gerçekleşmedi !", "Güncelleme", MessageBoxButtons.OK,MessageBoxIcon.Warning);

            }

        }
        private void ListLoad()
        {
            listView1.Items.Clear();
            var apps = JsonConvert.DeserializeObject<List<AppSettings>>(Properties.Settings.Default.AppSettings) ?? new List<AppSettings>();
            foreach (var app in apps)
            {
                ListViewItem item = new ListViewItem(app.Name);
                item.SubItems.Add(app.IsActive.ToString());
                item.SubItems.Add(app.Path);
                item.SubItems.Add(app.BgRenk.ToString());
                item.SubItems.Add(app.FoRenk.ToString());
                listView1.Items.Add(item);
            }
        }
        private void ıtemRemove()
        {
            if (listView1.SelectedItems.Count.Equals(1))
            {
                var apps = JsonConvert.DeserializeObject<List<AppSettings>>(Properties.Settings.Default.AppSettings) ?? new List<AppSettings>();
                apps.RemoveAt(listView1.SelectedItems[0].Index);
                string jsonString = JsonConvert.SerializeObject(apps);
                Properties.Settings.Default.AppSettings = jsonString;
                Properties.Settings.Default.Save();
                ListLoad();
            }

        }
        private void btnColor_Click(object sender, EventArgs e)
        {
            ColorDialog RenkSec = new ColorDialog();
            if (RenkSec.ShowDialog()==DialogResult.OK)
            {
                btnColor.BackColor = RenkSec.Color;
                btnTextColor.BackColor = RenkSec.Color;
            }
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Tüm Listenin Temizlenmesini İstiyor musunuz?", "Listeyi Temizle", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                Properties.Settings.Default.AppSettings = "";
                Properties.Settings.Default.Save();
                ListLoad();
                LoadMain();
                MessageBox.Show("Temizleme İşlemi Gerçekleşti", "Listeyi Temizle", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show("Temizleme İşlemi İptal Edildi", "Listeyi Temizle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            

        }

        private void btnTextColor_Click(object sender, EventArgs e)
        {
            ColorDialog RenkSec = new ColorDialog();
            if (RenkSec.ShowDialog() == DialogResult.OK)
            {
                btnTextColor.ForeColor = RenkSec.Color;
                btnColor.ForeColor = RenkSec.Color;
            }
        }
    }

    class AppSettings
    {
        public string Name;
        public bool IsActive;//aktif olanlar uygulama açılışında otomatik olarak ana ekrana eklenmiş olarak gelecek
        public string Path;

        public int BgRenk;//butonun arkaplan rengini tutuyor
        public int FoRenk;//butonun yazı rengini tutuyor
        
        
        
    }
}

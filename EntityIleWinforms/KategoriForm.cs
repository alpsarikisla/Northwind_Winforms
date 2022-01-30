using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityIleWinforms
{
    public partial class KategoriForm : Form
    {
        NORTHWNDEntities db = new NORTHWNDEntities();
        int id;
        public KategoriForm()
        {
            id = -1;
            InitializeComponent();
        }

        private void KategoriForm_Load(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = db.Categories.ToList();

            GridDoldur();
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            try
            {
                Categories c = new Categories();
                c.CategoryName = tb_isim.Text;
                c.Description = tb_aciklama.Text;
                db.Categories.Add(c);//Komut oluşturuldu işlem gerçekleştirilmedi
                db.SaveChanges();
                MessageBox.Show($"Kategori {c.CategoryID} ile başarıyla eklendi");
            }
            catch
            {
                MessageBox.Show("Ekleme Başarısız");
            }
            GridDoldur();
        }
        private void GridDoldur()
        {
            var kategoriler = from k in db.Categories
                              select new
                              {
                                  No = k.CategoryID,
                                  Isim = k.CategoryName,
                                  Aciklama = k.Description
                              };
            dataGridView1.DataSource = kategoriler.ToList();
        }

        private void dataGridView1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hit = dataGridView1.HitTest(e.X, e.Y);
                dataGridView1.ClearSelection();
                dataGridView1.Rows[hit.RowIndex].Selected = true;
                contextMenuStrip1.Show(dataGridView1,e.X, e.Y);
                id = Convert.ToInt32(dataGridView1.Rows[hit.RowIndex].Cells[0].Value);
            }
        }

        private void TSMI_Guncelle_Click(object sender, EventArgs e)
        {
            //find tablonun PrimaryKey Alanında yer alan id verisini alıp o id deki veriyi nesne olarak getirir.
            if (id != -1)
            {
                Categories c = db.Categories.Find(id);
                tb_id.Text = c.CategoryID.ToString();
                tb_isim.Text = c.CategoryName;
                tb_aciklama.Text = c.Description;
                btn_guncelle.Visible = true;
            }

        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            try
            {
                Categories c = db.Categories.Find(id);
                c.CategoryName = tb_isim.Text;
                c.Description = tb_aciklama.Text;
                db.SaveChanges();
                MessageBox.Show("Başarılı Oldu", "Başarılı");
                tb_id.Text = tb_isim.Text = tb_aciklama.Text = "";
                btn_guncelle.Visible = false;
            }
            catch
            {
                MessageBox.Show("Birşeyler Ters Gitti", "Eyvah");
            }
            GridDoldur();
        }

        private void TSMI_Sil_Click(object sender, EventArgs e)
        {
            Categories c = db.Categories.Find(id);
            db.Categories.Remove(c);
            db.SaveChanges();
            GridDoldur();
        }
    }
}

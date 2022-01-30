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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TSMI_KategoriFormAc_Click(object sender, EventArgs e)
        {
            bool Acik = false;

            foreach (Form item in this.MdiChildren)
            {
                if (item.GetType() == typeof(KategoriForm))
                {
                    item.Activate();
                    Acik = true;
                }
            }
            if (!Acik)
            {
                KategoriForm frm = new KategoriForm();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void TSMI_urun_Click(object sender, EventArgs e)
        {
            bool Acik = false;

            foreach (Form item in this.MdiChildren)
            {
                if (item.GetType() == typeof(UrunForm))
                {
                    item.Activate();
                    Acik = true;
                }
            }
            if (!Acik)
            {
                UrunForm frm = new UrunForm();
                frm.MdiParent = this;
                frm.Show();
            }
        }
    }
}

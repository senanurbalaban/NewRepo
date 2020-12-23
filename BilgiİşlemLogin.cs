using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Covid_19
{
    public partial class BilgiİşlemLogin : Form
    {
        public BilgiİşlemLogin()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void belirtiyiEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SistemeBelirtiEkle ekle = new SistemeBelirtiEkle();
            ekle.MdiParent = this;
            //ekle.FormBorderStyle = FormBorderStyle.None;
            ekle.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void belirtiyiSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SistemeBelirtiEkle sil = new SistemeBelirtiEkle();
            sil.MdiParent = this;
            //ekle.FormBorderStyle = FormBorderStyle.None;
            sil.Show();
        }

        private void belirtiyiGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SistemeBelirtiEkle güncelle = new SistemeBelirtiEkle();
            güncelle.MdiParent = this;
            //ekle.FormBorderStyle = FormBorderStyle.None;
            güncelle.Show();
        }

        private void belirtiEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}

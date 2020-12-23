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
    public partial class FrmGirisEkrani : Form
    {
        public FrmGirisEkrani()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (panel1.Width==20)
            {
                panel1.Width = 178;
                button1.Text = "<";
            }
            else
            {
                panel1.Width = 20;
                button1.Text = ">";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            cvdGirişEkrani form = new cvdGirişEkrani();
            form.Show();
            this.Hide();
        }
    }
}

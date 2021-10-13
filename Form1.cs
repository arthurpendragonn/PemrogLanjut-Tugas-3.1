using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TugasTiga1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            lblDataDiri.Text = "NIM    :\n" +
                               "Nama :\n" +
                               "Kelas  :";

        }

        private void btnTampilkan_Click(object sender, EventArgs e)
        {
            lblDataDiri.Text = "NIM    : 20.11.3564\n" +
                               "Nama : Abdillah Pramudito\n" +
                               "Kelas  : S1-TI05";
        }

        private void btnKosongkan_Click(object sender, EventArgs e)
        {
            lblDataDiri.Text = "NIM     :\n" +
                               "Nama  :\n" +
                               "Kelas   :";
        }
    }
}

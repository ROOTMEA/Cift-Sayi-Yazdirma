using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ÇiftSayıYazdırma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sonucGoster_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            int sayi = Convert.ToInt32(girdi.Text);
            int i;

            for (i=1;i<=sayi;i++)
            {
                if (i % 2 == 0)
                {
                    listBox1.Items.Add(i.ToString());
                }
            }
            girdi.Clear();
        }

    }
}

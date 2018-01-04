using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ornek
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {

            double a = 0.001;
            double istenen = 25.00;
            while (true)
            {

                a += 0.001;
                if (a * a >= istenen)
                    break;
            }
            MessageBox.Show(a.ToString());
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace WFAPersonelTakibi
{
    public partial class Form2 : MetroForm
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void CmsMenu_Opening(object sender, CancelEventArgs e)
        {

        }

        private void TsmDuzenle_Click(object sender, EventArgs e)
        {

        }

        private void TsmSil_Click(object sender, EventArgs e)
        {

        }

        private void TsmYeni_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            this.Hide();
            frm.ShowDialog();

        }

        private void TsmDetay_Click(object sender, EventArgs e)
        {

        }
    }
}

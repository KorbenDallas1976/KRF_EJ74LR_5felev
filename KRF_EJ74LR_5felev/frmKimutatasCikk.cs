﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KRF_EJ74LR_5felev
{
    public partial class frmKimutatasCikk : Form
    {
        public frmKimutatasCikk()
        {
            InitializeComponent();
        }

        private void frmKimutatasCikk_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'plussDataSet.statTop10Ar' table. You can move, or remove it, as needed.
            this.statTop10ArTableAdapter.Fill(this.plussDataSet.statTop10Ar);
            // TODO: This line of code loads data into the 'plussDataSet.StatFajta' table. You can move, or remove it, as needed.
            this.statFajtaTableAdapter.Fill(this.plussDataSet.StatFajta);
            // TODO: This line of code loads data into the 'plussDataSet.StatMegnev' table. You can move, or remove it, as needed.
            this.statMeretTableAdapter.Fill(this.plussDataSet.StatMeret);

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KRF_EJ74LR_5felev
{
    public partial class frmRendelesek : Form
    {
        public frmRendelesek()
        {
            InitializeComponent();
        }

        private void frmRendelesek_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'plussDataSet.RendelesLista' table. You can move, or remove it, as needed.
            this.rendelesListaTableAdapter.Fill(this.plussDataSet.RendelesLista);
            frissitRendelesLista();
        }

        private void frissitRendelesLista()
        {
            this.rendelesListaTableAdapter.Fill(this.plussDataSet.RendelesLista);
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            int rid;

            if (dataGridView1.CurrentRow.Cells["rendelesIdDataGridViewTextBoxColumn"].Value != null)
            {
                rid = (int)dataGridView1.CurrentRow.Cells["rendelesIdDataGridViewTextBoxColumn"].Value;

                using (frmRendelesReszletei frm_rendresz = new KRF_EJ74LR_5felev.frmRendelesReszletei(rid))
                {
                    frm_rendresz.ShowDialog();
                }
            }
        }

        private void btnUjRendeles_Click(object sender, EventArgs e)
        {
            using (frmRendelesReszletei frm_rendresz = new KRF_EJ74LR_5felev.frmRendelesReszletei())
            {
                frm_rendresz.ShowDialog();
            }

            frissitRendelesLista();

        }
    }
}

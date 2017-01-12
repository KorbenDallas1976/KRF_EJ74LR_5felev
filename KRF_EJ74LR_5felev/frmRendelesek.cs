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
                    if (frm_rendresz.ShowDialog() == DialogResult.OK)
                    {
                        frissitRendelesLista();
                    }
                }
            }
        }

        private void btnUjRendeles_Click(object sender, EventArgs e)
        {
            /*
            using (frmRendelesReszletei frm_rendresz = new KRF_EJ74LR_5felev.frmRendelesReszletei())
            {
                frm_rendresz.ShowDialog();
            }
            */
            using (frmUjRendeles frm_ujrend = new frmUjRendeles())
            {
                if (frm_ujrend.ShowDialog() == DialogResult.OK)
                {
                    frissitRendelesLista();

                    /*
                    rendelesListaBindingSource.ResetBindings(false);

                    dataGridView1.DataSource = null;
                    dataGridView1.Refresh();

                    dataGridView1.DataSource = rendelesListaBindingSource;
                    dataGridView1.Refresh();
                    */

                    // ugrás az utolsó sorra
                    dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.RowCount - 1;
                    // kijelölés
                    dataGridView1.ClearSelection();
                    dataGridView1.Rows[dataGridView1.RowCount - 1].Selected = true;
                }
            }
        }
    }
}

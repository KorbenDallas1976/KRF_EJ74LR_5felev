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
    public partial class frmRendelesReszletei : Form
    {
        private int? RendelesId = null;

        public frmRendelesReszletei()
        {
            InitializeComponent();
        }

        public frmRendelesReszletei(int RendelesId)
        {
            InitializeComponent();
            this.RendelesId = RendelesId;
        }

        private void frmRendelesReszletei_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'plussDataSet.Partnerek' table. You can move, or remove it, as needed.
            this.partnerekTableAdapter.Fill(this.plussDataSet.Partnerek);

            if (this.RendelesId != null)
            {
                this.rendelesFejTableAdapter.Fill(plussDataSet.RendelesFej);
                this.rendelesFejBindingSource.Filter = "RendelesId = " + this.RendelesId.ToString();

                this.rendelesTetelekTableAdapter.Fill(this.plussDataSet.RendelesTetelek);
                this.rendelesTetelekBindingSource.Filter = "RendelesId = " + this.RendelesId.ToString();

                this.dataGridView1.Enabled = true;
            }
        }

        private void btnMentes_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();

                if (this.RendelesId != null)
                {
                    // fej
                    this.rendelesFejBindingSource.EndEdit();
                    this.rendelesFejTableAdapter.Update(this.plussDataSet.RendelesFej);

                    // tételek
                    this.rendelesTetelekBindingSource.EndEdit();
                    this.rendelesTetelekTableAdapter.Update(this.plussDataSet.RendelesTetelek);
                }
                else
                {
                    // fej
                    this.rendelesFejBindingSource.EndEdit();
                    this.rendelesFejTableAdapter.Update(this.plussDataSet.RendelesFej);

                }

                MessageBox.Show("Változtatások elmentve.");
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Hiba a mentés során.");
            }

        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            dataGridView1.Rows[e.RowIndex].Cells["rendelesIdDataGridViewTextBoxColumn"].Value = this.RendelesId;
        }
    }
}

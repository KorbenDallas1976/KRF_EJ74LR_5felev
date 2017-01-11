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
    public partial class frmPartnerek : Form
    {
        public frmPartnerek()
        {
            InitializeComponent();
        }

        private void frmPartnerek_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'plussDataSet.Partnerek' table. You can move, or remove it, as needed.
            this.partnerekTableAdapter.Fill(this.plussDataSet.Partnerek);
        }

        private void btnMentes_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.partnerekBindingSource.EndEdit();
                this.partnerekTableAdapter.Update(plussDataSet.Partnerek);
                MessageBox.Show("Változtatások elmentve.");
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Hiba a mentés során.");
            }
        }
    }
}

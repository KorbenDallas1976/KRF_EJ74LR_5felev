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
    public partial class frmMeretek : Form
    {
        public frmMeretek()
        {
            InitializeComponent();
        }

        private void frmMeretek_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'plussDataSet.Meretek' table. You can move, or remove it, as needed.
            this.meretekTableAdapter.Fill(this.plussDataSet.Meretek);

        }

        private void btnMentes_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.meretekBindingSource.EndEdit();
                this.meretekTableAdapter.Update(this.plussDataSet.Meretek);
                MessageBox.Show("Változtatások elmentve.");
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Hiba a mentés során.");
            }
        }
    }
}

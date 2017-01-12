using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KRF_EJ74LR_5felev
{
    public partial class frmUjRendeles : Form
    {
        public frmUjRendeles()
        {
            InitializeComponent();
        }

        private void frmUjRendeles_Load(object sender, EventArgs e)
        {
            this.partnerekTableAdapter.Fill(this.plussDataSet.Partnerek);
            //rendelesFejBindingSource.AddNew();
            dateTimePicker1.Value = DateTime.Now;
        }

        private void btnMentes_Click(object sender, EventArgs e)
        {
            try
            {
                plussDataSet.RendelesFejRow r = this.plussDataSet.RendelesFej.NewRendelesFejRow();
                r.PartnerId = (int)comboBox1.SelectedValue;
                r.Datum = dateTimePicker1.Value.Date;
                this.plussDataSet.RendelesFej.AddRendelesFejRow(r);

                //this.Validate();

                // fej
                //this.rendelesFejBindingSource.EndEdit();
                this.rendelesFejTableAdapter.Update(this.plussDataSet.RendelesFej);

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Hiba a mentés során.");
            }

            /*
            OleDbConnection kapcsolat = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=.\db\pluss.accdb");

            try
            {

                kapcsolat.Open();

                OleDbCommand parancs_1 = kapcsolat.CreateCommand();

                // insert into kontinensek
                parancs_1.CommandText = "INSERT INTO RendelesFej (PartnerId, Datum) VALUES ("
                    + comboBox1.SelectedValue.ToString() + ", " + "#" + dateTimePicker1.Value.Date.ToString("yyyy'-'MM'-'dd") + "#"
                    + ")";
                parancs_1.ExecuteNonQuery();



                //MessageBox.Show("Változtatások elmentve.");
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Hiba a mentés során.");
            }
            finally
            {
                // off
                kapcsolat.Close();
                kapcsolat.Dispose();
            }
            */

        }

        private void btnMegse_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

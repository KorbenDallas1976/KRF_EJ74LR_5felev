using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KRF_EJ74LR_5felev
{
    public partial class frmCikkek : Form
    {

        public frmCikkek()
        {
            InitializeComponent();
        }

        private void frmCikkek_Load(object sender, EventArgs e)
        {
            // csatolt táblák betöltése
            this.fajtakTableAdapter.Fill(this.plussDataSet.Fajtak);
            this.meretekTableAdapter.Fill(this.plussDataSet.Meretek);

            // cikklista frissítése
            frissitCikkLista();
        }

        private void frissitCikkLista ()
        {
            try
            {
                this.cikkekTableAdapter.Fill(this.plussDataSet.Cikkek);
            }
            catch (Exception Ex)
            {
                Console.Out.WriteLine(Ex.Message);
            }
            finally
            {
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Index > 0)
            {
                labelKepfile.Text = dataGridView1.CurrentRow.Cells["kepFileDataGridViewTextBoxColumn"].Value.ToString();
                //labelKepfile.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();

                picKepfile.WaitOnLoad = false;
                string s = @".\pic\" + dataGridView1.CurrentRow.Cells["kepFileDataGridViewTextBoxColumn"].Value.ToString();
                Console.Out.WriteLine(s);
                try
                {
                    picKepfile.LoadAsync(s);
                }
                catch (UriFormatException UriEx)
                {
                    
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }

        }
    }
}

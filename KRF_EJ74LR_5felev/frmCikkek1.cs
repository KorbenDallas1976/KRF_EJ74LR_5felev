using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
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
            if (dataGridView1.CurrentRow.Index >= 0)
            {
                frissitKep();
            }
        }

        private void frissitKep()
        {
            picKepfile.WaitOnLoad = false;
            string s = @".\pic\" + dataGridView1.CurrentRow.Cells["kepFileDataGridViewTextBoxColumn"].Value.ToString();
            Console.Out.WriteLine(s);
            try
            {
                picKepfile.LoadAsync(s);
            }
            // ne hisztizzen a space-t tartalmazó URI-k miatt
            catch (UriFormatException UriEx)
            {

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

        }

        private void btnKepFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), "..\\pic"));
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.txbKepFile.Text = Path.GetFileName(openFileDialog1.FileName);
                
                // megmutatjuk az új képet
                frissitKep();
            }
        }

        private void btnMentes_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.cikkekBindingSource.EndEdit();
                this.cikkekTableAdapter.Update(this.plussDataSet.Cikkek);
                MessageBox.Show("Változtatások elmentve.");
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Hiba a mentés során.");
            }
        }

        private void btnUjCikk_Click(object sender, EventArgs e)
        {
            cikkekBindingSource.AddNew();
        }
    }
}

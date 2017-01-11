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
    public partial class frmUjCikk : Form
    {
        public frmUjCikk()
        {
            InitializeComponent();
        }

        private void frmUjCikk_Load(object sender, EventArgs e)
        {
            // csatolt táblák betöltése
            this.fajtakTableAdapter.Fill(this.plussDataSet.Fajtak);
            this.meretekTableAdapter.Fill(this.plussDataSet.Meretek);
        }


        private void frissitKep()
        {
            picKepfile.WaitOnLoad = false;
            string s = @".\pic\" + txbKepFile.Text;
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


    }
}

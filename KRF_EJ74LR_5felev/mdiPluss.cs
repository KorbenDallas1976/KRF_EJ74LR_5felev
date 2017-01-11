using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KRF_EJ74LR_5felev
{
    public partial class mdiPluss : Form
    {
        //private int childFormNumber = 0;

        public mdiPluss()
        {
            InitializeComponent();
        }

        /*
        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }
        */

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = mnuStatusBar.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void mnuCikkek_Click(object sender, EventArgs e)
        {
            frmCikkek frm_cikkek = new frmCikkek()
            {
                MdiParent = this
            };
            frm_cikkek.Show();
        }

        private void mnuMeretek_Click(object sender, EventArgs e)
        {
            frmMeretek frm_meretek = new frmMeretek()
            {
                MdiParent = this
            };
            frm_meretek.Show();

        }

        private void mnuFajtak_Click(object sender, EventArgs e)
        {
            frmFajtak frm_fajtak = new frmFajtak()
            {
                MdiParent = this
            };
            frm_fajtak.Show();
        }

        private void mnuKimutatasCIkk_Click(object sender, EventArgs e)
        {
            frmKimutatasCikk frm_kimutatascikk = new frmKimutatasCikk()
            {
                MdiParent = this
            };
            frm_kimutatascikk.Show();
        }

        private void mnuPartnerek_Click(object sender, EventArgs e)
        {
            frmPartnerek frm_partnerek = new frmPartnerek()
            {
                MdiParent = this
            };
            frm_partnerek.Show();
        }

        private void mnuRendelesek_Click(object sender, EventArgs e)
        {
            frmRendelesek frm_rendelesek = new frmRendelesek()
            {
                MdiParent = this
            };
            frm_rendelesek.Show();
        }

        private void mnuAbout_Click(object sender, EventArgs e)
        {
            aboutBox ab = new aboutBox();
            ab.ShowDialog();
        }
    }
}

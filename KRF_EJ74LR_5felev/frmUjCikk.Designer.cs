namespace KRF_EJ74LR_5felev
{
    partial class frmUjCikk
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnKepFile = new System.Windows.Forms.Button();
            this.txbKepFile = new System.Windows.Forms.TextBox();
            this.picKepfile = new System.Windows.Forms.PictureBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.labelFajta = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelMeret = new System.Windows.Forms.Label();
            this.txbKiskerAr = new System.Windows.Forms.TextBox();
            this.labelKiskerAr = new System.Windows.Forms.Label();
            this.txbMegnev = new System.Windows.Forms.TextBox();
            this.labelMegnev = new System.Windows.Forms.Label();
            this.txbCikkszam = new System.Windows.Forms.TextBox();
            this.labelCikkszam = new System.Windows.Forms.Label();
            this.cikkekBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.plussDataSet = new KRF_EJ74LR_5felev.plussDataSet();
            this.fajtakBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.meretekBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cikkekTableAdapter = new KRF_EJ74LR_5felev.plussDataSetTableAdapters.CikkekTableAdapter();
            this.meretekTableAdapter = new KRF_EJ74LR_5felev.plussDataSetTableAdapters.MeretekTableAdapter();
            this.fajtakTableAdapter = new KRF_EJ74LR_5felev.plussDataSetTableAdapters.FajtakTableAdapter();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picKepfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cikkekBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plussDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fajtakBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meretekBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnKepFile);
            this.panel1.Controls.Add(this.txbKepFile);
            this.panel1.Controls.Add(this.picKepfile);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.labelFajta);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.labelMeret);
            this.panel1.Controls.Add(this.txbKiskerAr);
            this.panel1.Controls.Add(this.labelKiskerAr);
            this.panel1.Controls.Add(this.txbMegnev);
            this.panel1.Controls.Add(this.labelMegnev);
            this.panel1.Controls.Add(this.txbCikkszam);
            this.panel1.Controls.Add(this.labelCikkszam);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(325, 403);
            this.panel1.TabIndex = 0;
            // 
            // btnKepFile
            // 
            this.btnKepFile.Location = new System.Drawing.Point(269, 323);
            this.btnKepFile.Name = "btnKepFile";
            this.btnKepFile.Size = new System.Drawing.Size(41, 23);
            this.btnKepFile.TabIndex = 26;
            this.btnKepFile.Text = "...";
            this.btnKepFile.UseVisualStyleBackColor = true;
            // 
            // txbKepFile
            // 
            this.txbKepFile.Location = new System.Drawing.Point(86, 325);
            this.txbKepFile.Name = "txbKepFile";
            this.txbKepFile.Size = new System.Drawing.Size(177, 20);
            this.txbKepFile.TabIndex = 25;
            // 
            // picKepfile
            // 
            this.picKepfile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picKepfile.Location = new System.Drawing.Point(86, 139);
            this.picKepfile.Name = "picKepfile";
            this.picKepfile.Size = new System.Drawing.Size(180, 180);
            this.picKepfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picKepfile.TabIndex = 24;
            this.picKepfile.TabStop = false;
            // 
            // comboBox2
            // 
            this.comboBox2.DisplayMember = "FajtaMegnev";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(86, 112);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 23;
            this.comboBox2.ValueMember = "FajtaAzon";
            // 
            // labelFajta
            // 
            this.labelFajta.AutoSize = true;
            this.labelFajta.Location = new System.Drawing.Point(12, 115);
            this.labelFajta.Name = "labelFajta";
            this.labelFajta.Size = new System.Drawing.Size(30, 13);
            this.labelFajta.TabIndex = 22;
            this.labelFajta.Text = "Fajta";
            // 
            // comboBox1
            // 
            this.comboBox1.DisplayMember = "MeretMegnev";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(86, 85);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 21;
            this.comboBox1.ValueMember = "MeretAzon";
            // 
            // labelMeret
            // 
            this.labelMeret.AutoSize = true;
            this.labelMeret.Location = new System.Drawing.Point(12, 88);
            this.labelMeret.Name = "labelMeret";
            this.labelMeret.Size = new System.Drawing.Size(34, 13);
            this.labelMeret.TabIndex = 20;
            this.labelMeret.Text = "Méret";
            // 
            // txbKiskerAr
            // 
            this.txbKiskerAr.Location = new System.Drawing.Point(86, 58);
            this.txbKiskerAr.Name = "txbKiskerAr";
            this.txbKiskerAr.Size = new System.Drawing.Size(138, 20);
            this.txbKiskerAr.TabIndex = 19;
            // 
            // labelKiskerAr
            // 
            this.labelKiskerAr.AutoSize = true;
            this.labelKiskerAr.Location = new System.Drawing.Point(12, 61);
            this.labelKiskerAr.Name = "labelKiskerAr";
            this.labelKiskerAr.Size = new System.Drawing.Size(48, 13);
            this.labelKiskerAr.TabIndex = 18;
            this.labelKiskerAr.Text = "Kisker ár";
            // 
            // txbMegnev
            // 
            this.txbMegnev.Location = new System.Drawing.Point(86, 32);
            this.txbMegnev.Name = "txbMegnev";
            this.txbMegnev.Size = new System.Drawing.Size(228, 20);
            this.txbMegnev.TabIndex = 17;
            // 
            // labelMegnev
            // 
            this.labelMegnev.AutoSize = true;
            this.labelMegnev.Location = new System.Drawing.Point(12, 35);
            this.labelMegnev.Name = "labelMegnev";
            this.labelMegnev.Size = new System.Drawing.Size(68, 13);
            this.labelMegnev.TabIndex = 16;
            this.labelMegnev.Text = "Megnevezés";
            // 
            // txbCikkszam
            // 
            this.txbCikkszam.Location = new System.Drawing.Point(86, 6);
            this.txbCikkszam.Name = "txbCikkszam";
            this.txbCikkszam.Size = new System.Drawing.Size(228, 20);
            this.txbCikkszam.TabIndex = 15;
            // 
            // labelCikkszam
            // 
            this.labelCikkszam.AutoSize = true;
            this.labelCikkszam.Location = new System.Drawing.Point(12, 9);
            this.labelCikkszam.Name = "labelCikkszam";
            this.labelCikkszam.Size = new System.Drawing.Size(52, 13);
            this.labelCikkszam.TabIndex = 14;
            this.labelCikkszam.Text = "Cikkszám";
            // 
            // cikkekBindingSource
            // 
            this.cikkekBindingSource.DataMember = "Cikkek";
            this.cikkekBindingSource.DataSource = this.plussDataSet;
            // 
            // plussDataSet
            // 
            this.plussDataSet.DataSetName = "plussDataSet";
            this.plussDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fajtakBindingSource
            // 
            this.fajtakBindingSource.DataMember = "Fajtak";
            this.fajtakBindingSource.DataSource = this.plussDataSet;
            // 
            // meretekBindingSource
            // 
            this.meretekBindingSource.DataMember = "Meretek";
            this.meretekBindingSource.DataSource = this.plussDataSet;
            // 
            // cikkekTableAdapter
            // 
            this.cikkekTableAdapter.ClearBeforeFill = true;
            // 
            // meretekTableAdapter
            // 
            this.meretekTableAdapter.ClearBeforeFill = true;
            // 
            // fajtakTableAdapter
            // 
            this.fajtakTableAdapter.ClearBeforeFill = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "jpg fileok|*.jpg";
            // 
            // frmUjCikk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 403);
            this.Controls.Add(this.panel1);
            this.Name = "frmUjCikk";
            this.Text = "Új cikk adatai";
            this.Load += new System.EventHandler(this.frmUjCikk_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picKepfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cikkekBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plussDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fajtakBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meretekBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnKepFile;
        private System.Windows.Forms.TextBox txbKepFile;
        private System.Windows.Forms.PictureBox picKepfile;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label labelFajta;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labelMeret;
        private System.Windows.Forms.TextBox txbKiskerAr;
        private System.Windows.Forms.Label labelKiskerAr;
        private System.Windows.Forms.TextBox txbMegnev;
        private System.Windows.Forms.Label labelMegnev;
        private System.Windows.Forms.TextBox txbCikkszam;
        private System.Windows.Forms.Label labelCikkszam;
        private System.Windows.Forms.BindingSource cikkekBindingSource;
        private plussDataSet plussDataSet;
        private System.Windows.Forms.BindingSource fajtakBindingSource;
        private System.Windows.Forms.BindingSource meretekBindingSource;
        private plussDataSetTableAdapters.CikkekTableAdapter cikkekTableAdapter;
        private plussDataSetTableAdapters.MeretekTableAdapter meretekTableAdapter;
        private plussDataSetTableAdapters.FajtakTableAdapter fajtakTableAdapter;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
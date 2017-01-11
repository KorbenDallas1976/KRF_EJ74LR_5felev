namespace KRF_EJ74LR_5felev
{
    partial class frmCikkek
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMentes = new System.Windows.Forms.Button();
            this.btnUjCikk = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cikkszamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cikkMegnevDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.meretAzonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fajtaAzonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kepFileDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kiskerArDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cikkekBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.plussDataSet = new KRF_EJ74LR_5felev.plussDataSet();
            this.panel2 = new System.Windows.Forms.Panel();
            this.picKepfile = new System.Windows.Forms.PictureBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.fajtakBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelFajta = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.meretekBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelMeret = new System.Windows.Forms.Label();
            this.txbKiskerAr = new System.Windows.Forms.TextBox();
            this.labelKiskerAr = new System.Windows.Forms.Label();
            this.txbMegnev = new System.Windows.Forms.TextBox();
            this.labelMegnev = new System.Windows.Forms.Label();
            this.txbCikkszam = new System.Windows.Forms.TextBox();
            this.labelCikkszam = new System.Windows.Forms.Label();
            this.cikkekTableAdapter = new KRF_EJ74LR_5felev.plussDataSetTableAdapters.CikkekTableAdapter();
            this.meretekTableAdapter = new KRF_EJ74LR_5felev.plussDataSetTableAdapters.MeretekTableAdapter();
            this.fajtakTableAdapter = new KRF_EJ74LR_5felev.plussDataSetTableAdapters.FajtakTableAdapter();
            this.txbKepFile = new System.Windows.Forms.TextBox();
            this.btnKepFile = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cikkekBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plussDataSet)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picKepfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fajtakBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meretekBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 320F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(795, 557);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel1, 2);
            this.panel1.Controls.Add(this.btnMentes);
            this.panel1.Controls.Add(this.btnUjCikk);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(789, 30);
            this.panel1.TabIndex = 0;
            // 
            // btnMentes
            // 
            this.btnMentes.Location = new System.Drawing.Point(90, 4);
            this.btnMentes.Name = "btnMentes";
            this.btnMentes.Size = new System.Drawing.Size(75, 23);
            this.btnMentes.TabIndex = 1;
            this.btnMentes.Text = "Mentés";
            this.btnMentes.UseVisualStyleBackColor = true;
            this.btnMentes.Click += new System.EventHandler(this.btnMentes_Click);
            // 
            // btnUjCikk
            // 
            this.btnUjCikk.Location = new System.Drawing.Point(9, 4);
            this.btnUjCikk.Name = "btnUjCikk";
            this.btnUjCikk.Size = new System.Drawing.Size(75, 23);
            this.btnUjCikk.TabIndex = 0;
            this.btnUjCikk.Text = "Új cikk";
            this.btnUjCikk.UseVisualStyleBackColor = true;
            this.btnUjCikk.Click += new System.EventHandler(this.btnUjCikk_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cikkszamDataGridViewTextBoxColumn,
            this.cikkMegnevDataGridViewTextBoxColumn,
            this.meretAzonDataGridViewTextBoxColumn,
            this.fajtaAzonDataGridViewTextBoxColumn,
            this.kepFileDataGridViewTextBoxColumn,
            this.kiskerArDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cikkekBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 39);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(469, 515);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // cikkszamDataGridViewTextBoxColumn
            // 
            this.cikkszamDataGridViewTextBoxColumn.DataPropertyName = "Cikkszam";
            this.cikkszamDataGridViewTextBoxColumn.HeaderText = "Cikkszam";
            this.cikkszamDataGridViewTextBoxColumn.Name = "cikkszamDataGridViewTextBoxColumn";
            this.cikkszamDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cikkMegnevDataGridViewTextBoxColumn
            // 
            this.cikkMegnevDataGridViewTextBoxColumn.DataPropertyName = "CikkMegnev";
            this.cikkMegnevDataGridViewTextBoxColumn.HeaderText = "CikkMegnev";
            this.cikkMegnevDataGridViewTextBoxColumn.Name = "cikkMegnevDataGridViewTextBoxColumn";
            this.cikkMegnevDataGridViewTextBoxColumn.ReadOnly = true;
            this.cikkMegnevDataGridViewTextBoxColumn.Width = 150;
            // 
            // meretAzonDataGridViewTextBoxColumn
            // 
            this.meretAzonDataGridViewTextBoxColumn.DataPropertyName = "MeretAzon";
            this.meretAzonDataGridViewTextBoxColumn.HeaderText = "MeretAzon";
            this.meretAzonDataGridViewTextBoxColumn.Name = "meretAzonDataGridViewTextBoxColumn";
            this.meretAzonDataGridViewTextBoxColumn.ReadOnly = true;
            this.meretAzonDataGridViewTextBoxColumn.Visible = false;
            // 
            // fajtaAzonDataGridViewTextBoxColumn
            // 
            this.fajtaAzonDataGridViewTextBoxColumn.DataPropertyName = "FajtaAzon";
            this.fajtaAzonDataGridViewTextBoxColumn.HeaderText = "FajtaAzon";
            this.fajtaAzonDataGridViewTextBoxColumn.Name = "fajtaAzonDataGridViewTextBoxColumn";
            this.fajtaAzonDataGridViewTextBoxColumn.ReadOnly = true;
            this.fajtaAzonDataGridViewTextBoxColumn.Visible = false;
            // 
            // kepFileDataGridViewTextBoxColumn
            // 
            this.kepFileDataGridViewTextBoxColumn.DataPropertyName = "KepFile";
            this.kepFileDataGridViewTextBoxColumn.HeaderText = "KepFile";
            this.kepFileDataGridViewTextBoxColumn.Name = "kepFileDataGridViewTextBoxColumn";
            this.kepFileDataGridViewTextBoxColumn.ReadOnly = true;
            this.kepFileDataGridViewTextBoxColumn.Visible = false;
            // 
            // kiskerArDataGridViewTextBoxColumn
            // 
            this.kiskerArDataGridViewTextBoxColumn.DataPropertyName = "KiskerAr";
            this.kiskerArDataGridViewTextBoxColumn.HeaderText = "KiskerAr";
            this.kiskerArDataGridViewTextBoxColumn.Name = "kiskerArDataGridViewTextBoxColumn";
            this.kiskerArDataGridViewTextBoxColumn.ReadOnly = true;
            this.kiskerArDataGridViewTextBoxColumn.Width = 60;
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
            // panel2
            // 
            this.panel2.Controls.Add(this.btnKepFile);
            this.panel2.Controls.Add(this.txbKepFile);
            this.panel2.Controls.Add(this.picKepfile);
            this.panel2.Controls.Add(this.comboBox2);
            this.panel2.Controls.Add(this.labelFajta);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.labelMeret);
            this.panel2.Controls.Add(this.txbKiskerAr);
            this.panel2.Controls.Add(this.labelKiskerAr);
            this.panel2.Controls.Add(this.txbMegnev);
            this.panel2.Controls.Add(this.labelMegnev);
            this.panel2.Controls.Add(this.txbCikkszam);
            this.panel2.Controls.Add(this.labelCikkszam);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(478, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(314, 515);
            this.panel2.TabIndex = 2;
            // 
            // picKepfile
            // 
            this.picKepfile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picKepfile.Location = new System.Drawing.Point(77, 137);
            this.picKepfile.Name = "picKepfile";
            this.picKepfile.Size = new System.Drawing.Size(180, 180);
            this.picKepfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picKepfile.TabIndex = 10;
            this.picKepfile.TabStop = false;
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.cikkekBindingSource, "FajtaAzon", true));
            this.comboBox2.DataSource = this.fajtakBindingSource;
            this.comboBox2.DisplayMember = "FajtaMegnev";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(77, 110);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 9;
            this.comboBox2.ValueMember = "FajtaAzon";
            // 
            // fajtakBindingSource
            // 
            this.fajtakBindingSource.DataMember = "Fajtak";
            this.fajtakBindingSource.DataSource = this.plussDataSet;
            // 
            // labelFajta
            // 
            this.labelFajta.AutoSize = true;
            this.labelFajta.Location = new System.Drawing.Point(3, 113);
            this.labelFajta.Name = "labelFajta";
            this.labelFajta.Size = new System.Drawing.Size(30, 13);
            this.labelFajta.TabIndex = 8;
            this.labelFajta.Text = "Fajta";
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.cikkekBindingSource, "MeretAzon", true));
            this.comboBox1.DataSource = this.meretekBindingSource;
            this.comboBox1.DisplayMember = "MeretMegnev";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(77, 83);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.ValueMember = "MeretAzon";
            // 
            // meretekBindingSource
            // 
            this.meretekBindingSource.DataMember = "Meretek";
            this.meretekBindingSource.DataSource = this.plussDataSet;
            // 
            // labelMeret
            // 
            this.labelMeret.AutoSize = true;
            this.labelMeret.Location = new System.Drawing.Point(3, 86);
            this.labelMeret.Name = "labelMeret";
            this.labelMeret.Size = new System.Drawing.Size(34, 13);
            this.labelMeret.TabIndex = 6;
            this.labelMeret.Text = "Méret";
            // 
            // txbKiskerAr
            // 
            this.txbKiskerAr.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cikkekBindingSource, "KiskerAr", true));
            this.txbKiskerAr.Location = new System.Drawing.Point(77, 56);
            this.txbKiskerAr.Name = "txbKiskerAr";
            this.txbKiskerAr.Size = new System.Drawing.Size(138, 20);
            this.txbKiskerAr.TabIndex = 5;
            // 
            // labelKiskerAr
            // 
            this.labelKiskerAr.AutoSize = true;
            this.labelKiskerAr.Location = new System.Drawing.Point(3, 59);
            this.labelKiskerAr.Name = "labelKiskerAr";
            this.labelKiskerAr.Size = new System.Drawing.Size(48, 13);
            this.labelKiskerAr.TabIndex = 4;
            this.labelKiskerAr.Text = "Kisker ár";
            // 
            // txbMegnev
            // 
            this.txbMegnev.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cikkekBindingSource, "CikkMegnev", true));
            this.txbMegnev.Location = new System.Drawing.Point(77, 30);
            this.txbMegnev.Name = "txbMegnev";
            this.txbMegnev.Size = new System.Drawing.Size(228, 20);
            this.txbMegnev.TabIndex = 3;
            // 
            // labelMegnev
            // 
            this.labelMegnev.AutoSize = true;
            this.labelMegnev.Location = new System.Drawing.Point(3, 33);
            this.labelMegnev.Name = "labelMegnev";
            this.labelMegnev.Size = new System.Drawing.Size(68, 13);
            this.labelMegnev.TabIndex = 2;
            this.labelMegnev.Text = "Megnevezés";
            // 
            // txbCikkszam
            // 
            this.txbCikkszam.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cikkekBindingSource, "Cikkszam", true));
            this.txbCikkszam.Location = new System.Drawing.Point(77, 4);
            this.txbCikkszam.Name = "txbCikkszam";
            this.txbCikkszam.Size = new System.Drawing.Size(228, 20);
            this.txbCikkszam.TabIndex = 1;
            // 
            // labelCikkszam
            // 
            this.labelCikkszam.AutoSize = true;
            this.labelCikkszam.Location = new System.Drawing.Point(3, 7);
            this.labelCikkszam.Name = "labelCikkszam";
            this.labelCikkszam.Size = new System.Drawing.Size(52, 13);
            this.labelCikkszam.TabIndex = 0;
            this.labelCikkszam.Text = "Cikkszám";
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
            // txbKepFile
            // 
            this.txbKepFile.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cikkekBindingSource, "KepFile", true));
            this.txbKepFile.Location = new System.Drawing.Point(77, 323);
            this.txbKepFile.Name = "txbKepFile";
            this.txbKepFile.Size = new System.Drawing.Size(177, 20);
            this.txbKepFile.TabIndex = 12;
            // 
            // btnKepFile
            // 
            this.btnKepFile.Location = new System.Drawing.Point(260, 321);
            this.btnKepFile.Name = "btnKepFile";
            this.btnKepFile.Size = new System.Drawing.Size(41, 23);
            this.btnKepFile.TabIndex = 13;
            this.btnKepFile.Text = "...";
            this.btnKepFile.UseVisualStyleBackColor = true;
            this.btnKepFile.Click += new System.EventHandler(this.btnKepFile_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "jpg fileok|*.jpg";
            // 
            // frmCikkek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 557);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmCikkek";
            this.Text = "Cikkek";
            this.Load += new System.EventHandler(this.frmCikkek_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cikkekBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plussDataSet)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picKepfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fajtakBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meretekBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnUjCikk;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private plussDataSet plussDataSet;
        private System.Windows.Forms.BindingSource cikkekBindingSource;
        private plussDataSetTableAdapters.CikkekTableAdapter cikkekTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cikkszamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cikkMegnevDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn meretAzonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fajtaAzonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kepFileDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kiskerArDataGridViewTextBoxColumn;
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
        private System.Windows.Forms.BindingSource meretekBindingSource;
        private plussDataSetTableAdapters.MeretekTableAdapter meretekTableAdapter;
        private System.Windows.Forms.BindingSource fajtakBindingSource;
        private plussDataSetTableAdapters.FajtakTableAdapter fajtakTableAdapter;
        private System.Windows.Forms.Button btnMentes;
        private System.Windows.Forms.Button btnKepFile;
        private System.Windows.Forms.TextBox txbKepFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}


namespace KRF_EJ74LR_5felev
{
    partial class frmKimutatasCikk
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
            this.tabctrlKimutatasCikk = new System.Windows.Forms.TabControl();
            this.tabpgTop10 = new System.Windows.Forms.TabPage();
            this.tabpgMeretek = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabpgFajtak = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.meretMegnevDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIkkekSzamaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statMeretBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.plussDataSet = new KRF_EJ74LR_5felev.plussDataSet();
            this.fajtaMegnevDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIkkekSzamaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statFajtaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statMeretTableAdapter = new KRF_EJ74LR_5felev.plussDataSetTableAdapters.StatMeretTableAdapter();
            this.statFajtaTableAdapter = new KRF_EJ74LR_5felev.plussDataSetTableAdapters.StatFajtaTableAdapter();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.statTop10ArBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statTop10ArTableAdapter = new KRF_EJ74LR_5felev.plussDataSetTableAdapters.statTop10ArTableAdapter();
            this.cikkszamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cikkMegnevDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.meretMegnevDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fajtaMegnevDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kiskerArDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabctrlKimutatasCikk.SuspendLayout();
            this.tabpgTop10.SuspendLayout();
            this.tabpgMeretek.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabpgFajtak.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statMeretBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plussDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statFajtaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statTop10ArBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabctrlKimutatasCikk
            // 
            this.tabctrlKimutatasCikk.Controls.Add(this.tabpgTop10);
            this.tabctrlKimutatasCikk.Controls.Add(this.tabpgMeretek);
            this.tabctrlKimutatasCikk.Controls.Add(this.tabpgFajtak);
            this.tabctrlKimutatasCikk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabctrlKimutatasCikk.Location = new System.Drawing.Point(0, 0);
            this.tabctrlKimutatasCikk.Name = "tabctrlKimutatasCikk";
            this.tabctrlKimutatasCikk.SelectedIndex = 0;
            this.tabctrlKimutatasCikk.Size = new System.Drawing.Size(589, 398);
            this.tabctrlKimutatasCikk.TabIndex = 0;
            // 
            // tabpgTop10
            // 
            this.tabpgTop10.Controls.Add(this.dataGridView3);
            this.tabpgTop10.Location = new System.Drawing.Point(4, 22);
            this.tabpgTop10.Name = "tabpgTop10";
            this.tabpgTop10.Padding = new System.Windows.Forms.Padding(3);
            this.tabpgTop10.Size = new System.Drawing.Size(581, 372);
            this.tabpgTop10.TabIndex = 0;
            this.tabpgTop10.Text = "Top 10 ár";
            this.tabpgTop10.UseVisualStyleBackColor = true;
            // 
            // tabpgMeretek
            // 
            this.tabpgMeretek.Controls.Add(this.dataGridView1);
            this.tabpgMeretek.Location = new System.Drawing.Point(4, 22);
            this.tabpgMeretek.Name = "tabpgMeretek";
            this.tabpgMeretek.Padding = new System.Windows.Forms.Padding(3);
            this.tabpgMeretek.Size = new System.Drawing.Size(581, 372);
            this.tabpgMeretek.TabIndex = 2;
            this.tabpgMeretek.Text = "Méretek";
            this.tabpgMeretek.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.meretMegnevDataGridViewTextBoxColumn,
            this.cIkkekSzamaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.statMeretBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(575, 366);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabpgFajtak
            // 
            this.tabpgFajtak.Controls.Add(this.dataGridView2);
            this.tabpgFajtak.Location = new System.Drawing.Point(4, 22);
            this.tabpgFajtak.Name = "tabpgFajtak";
            this.tabpgFajtak.Padding = new System.Windows.Forms.Padding(3);
            this.tabpgFajtak.Size = new System.Drawing.Size(581, 372);
            this.tabpgFajtak.TabIndex = 1;
            this.tabpgFajtak.Text = "Fajták";
            this.tabpgFajtak.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fajtaMegnevDataGridViewTextBoxColumn,
            this.cIkkekSzamaDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.statFajtaBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(575, 366);
            this.dataGridView2.TabIndex = 0;
            // 
            // meretMegnevDataGridViewTextBoxColumn
            // 
            this.meretMegnevDataGridViewTextBoxColumn.DataPropertyName = "MeretMegnev";
            this.meretMegnevDataGridViewTextBoxColumn.HeaderText = "MeretMegnev";
            this.meretMegnevDataGridViewTextBoxColumn.Name = "meretMegnevDataGridViewTextBoxColumn";
            this.meretMegnevDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cIkkekSzamaDataGridViewTextBoxColumn
            // 
            this.cIkkekSzamaDataGridViewTextBoxColumn.DataPropertyName = "CIkkekSzama";
            this.cIkkekSzamaDataGridViewTextBoxColumn.HeaderText = "CIkkekSzama";
            this.cIkkekSzamaDataGridViewTextBoxColumn.Name = "cIkkekSzamaDataGridViewTextBoxColumn";
            this.cIkkekSzamaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statMeretBindingSource
            // 
            this.statMeretBindingSource.DataMember = "StatMeret";
            this.statMeretBindingSource.DataSource = this.plussDataSet;
            // 
            // plussDataSet
            // 
            this.plussDataSet.DataSetName = "plussDataSet";
            this.plussDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fajtaMegnevDataGridViewTextBoxColumn
            // 
            this.fajtaMegnevDataGridViewTextBoxColumn.DataPropertyName = "FajtaMegnev";
            this.fajtaMegnevDataGridViewTextBoxColumn.HeaderText = "FajtaMegnev";
            this.fajtaMegnevDataGridViewTextBoxColumn.Name = "fajtaMegnevDataGridViewTextBoxColumn";
            this.fajtaMegnevDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cIkkekSzamaDataGridViewTextBoxColumn1
            // 
            this.cIkkekSzamaDataGridViewTextBoxColumn1.DataPropertyName = "CIkkekSzama";
            this.cIkkekSzamaDataGridViewTextBoxColumn1.HeaderText = "CIkkekSzama";
            this.cIkkekSzamaDataGridViewTextBoxColumn1.Name = "cIkkekSzamaDataGridViewTextBoxColumn1";
            this.cIkkekSzamaDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // statFajtaBindingSource
            // 
            this.statFajtaBindingSource.DataMember = "StatFajta";
            this.statFajtaBindingSource.DataSource = this.plussDataSet;
            // 
            // statMeretTableAdapter
            // 
            this.statMeretTableAdapter.ClearBeforeFill = true;
            // 
            // statFajtaTableAdapter
            // 
            this.statFajtaTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cikkszamDataGridViewTextBoxColumn,
            this.cikkMegnevDataGridViewTextBoxColumn,
            this.meretMegnevDataGridViewTextBoxColumn1,
            this.fajtaMegnevDataGridViewTextBoxColumn1,
            this.kiskerArDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.statTop10ArBindingSource;
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3.Location = new System.Drawing.Point(3, 3);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.Size = new System.Drawing.Size(575, 366);
            this.dataGridView3.TabIndex = 0;
            // 
            // statTop10ArBindingSource
            // 
            this.statTop10ArBindingSource.DataMember = "statTop10Ar";
            this.statTop10ArBindingSource.DataSource = this.plussDataSet;
            // 
            // statTop10ArTableAdapter
            // 
            this.statTop10ArTableAdapter.ClearBeforeFill = true;
            // 
            // cikkszamDataGridViewTextBoxColumn
            // 
            this.cikkszamDataGridViewTextBoxColumn.DataPropertyName = "Cikkszam";
            this.cikkszamDataGridViewTextBoxColumn.HeaderText = "Cikkszam";
            this.cikkszamDataGridViewTextBoxColumn.Name = "cikkszamDataGridViewTextBoxColumn";
            this.cikkszamDataGridViewTextBoxColumn.ReadOnly = true;
            this.cikkszamDataGridViewTextBoxColumn.Width = 77;
            // 
            // cikkMegnevDataGridViewTextBoxColumn
            // 
            this.cikkMegnevDataGridViewTextBoxColumn.DataPropertyName = "CikkMegnev";
            this.cikkMegnevDataGridViewTextBoxColumn.HeaderText = "CikkMegnev";
            this.cikkMegnevDataGridViewTextBoxColumn.Name = "cikkMegnevDataGridViewTextBoxColumn";
            this.cikkMegnevDataGridViewTextBoxColumn.ReadOnly = true;
            this.cikkMegnevDataGridViewTextBoxColumn.Width = 92;
            // 
            // meretMegnevDataGridViewTextBoxColumn1
            // 
            this.meretMegnevDataGridViewTextBoxColumn1.DataPropertyName = "MeretMegnev";
            this.meretMegnevDataGridViewTextBoxColumn1.HeaderText = "MeretMegnev";
            this.meretMegnevDataGridViewTextBoxColumn1.Name = "meretMegnevDataGridViewTextBoxColumn1";
            this.meretMegnevDataGridViewTextBoxColumn1.ReadOnly = true;
            this.meretMegnevDataGridViewTextBoxColumn1.Width = 98;
            // 
            // fajtaMegnevDataGridViewTextBoxColumn1
            // 
            this.fajtaMegnevDataGridViewTextBoxColumn1.DataPropertyName = "FajtaMegnev";
            this.fajtaMegnevDataGridViewTextBoxColumn1.HeaderText = "FajtaMegnev";
            this.fajtaMegnevDataGridViewTextBoxColumn1.Name = "fajtaMegnevDataGridViewTextBoxColumn1";
            this.fajtaMegnevDataGridViewTextBoxColumn1.ReadOnly = true;
            this.fajtaMegnevDataGridViewTextBoxColumn1.Width = 94;
            // 
            // kiskerArDataGridViewTextBoxColumn
            // 
            this.kiskerArDataGridViewTextBoxColumn.DataPropertyName = "KiskerAr";
            this.kiskerArDataGridViewTextBoxColumn.HeaderText = "KiskerAr";
            this.kiskerArDataGridViewTextBoxColumn.Name = "kiskerArDataGridViewTextBoxColumn";
            this.kiskerArDataGridViewTextBoxColumn.ReadOnly = true;
            this.kiskerArDataGridViewTextBoxColumn.Width = 71;
            // 
            // frmKimutatasCikk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 398);
            this.Controls.Add(this.tabctrlKimutatasCikk);
            this.Name = "frmKimutatasCikk";
            this.Text = "Cikk kimutatások";
            this.Load += new System.EventHandler(this.frmKimutatasCikk_Load);
            this.tabctrlKimutatasCikk.ResumeLayout(false);
            this.tabpgTop10.ResumeLayout(false);
            this.tabpgMeretek.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabpgFajtak.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statMeretBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plussDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statFajtaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statTop10ArBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabctrlKimutatasCikk;
        private System.Windows.Forms.TabPage tabpgTop10;
        private System.Windows.Forms.TabPage tabpgFajtak;
        private System.Windows.Forms.TabPage tabpgMeretek;
        private System.Windows.Forms.DataGridView dataGridView1;
        private plussDataSet plussDataSet;
        private System.Windows.Forms.BindingSource statMeretBindingSource;
        private plussDataSetTableAdapters.StatMeretTableAdapter statMeretTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn meretMegnevDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIkkekSzamaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource statFajtaBindingSource;
        private plussDataSetTableAdapters.StatFajtaTableAdapter statFajtaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn fajtaMegnevDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIkkekSzamaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.BindingSource statTop10ArBindingSource;
        private plussDataSetTableAdapters.statTop10ArTableAdapter statTop10ArTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cikkszamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cikkMegnevDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn meretMegnevDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fajtaMegnevDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn kiskerArDataGridViewTextBoxColumn;
    }
}
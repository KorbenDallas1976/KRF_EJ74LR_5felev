namespace KRF_EJ74LR_5felev
{
    partial class frmRendelesek
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nevDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rendelesIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tetelekSzamaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rendelesListaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.plussDataSet = new KRF_EJ74LR_5felev.plussDataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnUjRendeles = new System.Windows.Forms.Button();
            this.rendelesListaTableAdapter = new KRF_EJ74LR_5felev.plussDataSetTableAdapters.RendelesListaTableAdapter();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rendelesListaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plussDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(603, 358);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nevDataGridViewTextBoxColumn,
            this.rendelesIdDataGridViewTextBoxColumn,
            this.datumDataGridViewTextBoxColumn,
            this.tetelekSzamaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.rendelesListaBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(597, 316);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // nevDataGridViewTextBoxColumn
            // 
            this.nevDataGridViewTextBoxColumn.DataPropertyName = "Nev";
            this.nevDataGridViewTextBoxColumn.HeaderText = "Nev";
            this.nevDataGridViewTextBoxColumn.Name = "nevDataGridViewTextBoxColumn";
            this.nevDataGridViewTextBoxColumn.ReadOnly = true;
            this.nevDataGridViewTextBoxColumn.Width = 52;
            // 
            // rendelesIdDataGridViewTextBoxColumn
            // 
            this.rendelesIdDataGridViewTextBoxColumn.DataPropertyName = "RendelesId";
            this.rendelesIdDataGridViewTextBoxColumn.HeaderText = "RendelesId";
            this.rendelesIdDataGridViewTextBoxColumn.Name = "rendelesIdDataGridViewTextBoxColumn";
            this.rendelesIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.rendelesIdDataGridViewTextBoxColumn.Width = 86;
            // 
            // datumDataGridViewTextBoxColumn
            // 
            this.datumDataGridViewTextBoxColumn.DataPropertyName = "Datum";
            this.datumDataGridViewTextBoxColumn.HeaderText = "Datum";
            this.datumDataGridViewTextBoxColumn.Name = "datumDataGridViewTextBoxColumn";
            this.datumDataGridViewTextBoxColumn.ReadOnly = true;
            this.datumDataGridViewTextBoxColumn.Width = 63;
            // 
            // tetelekSzamaDataGridViewTextBoxColumn
            // 
            this.tetelekSzamaDataGridViewTextBoxColumn.DataPropertyName = "TetelekSzama";
            this.tetelekSzamaDataGridViewTextBoxColumn.HeaderText = "TetelekSzama";
            this.tetelekSzamaDataGridViewTextBoxColumn.Name = "tetelekSzamaDataGridViewTextBoxColumn";
            this.tetelekSzamaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rendelesListaBindingSource
            // 
            this.rendelesListaBindingSource.DataMember = "RendelesLista";
            this.rendelesListaBindingSource.DataSource = this.plussDataSet;
            // 
            // plussDataSet
            // 
            this.plussDataSet.DataSetName = "plussDataSet";
            this.plussDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnUjRendeles);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(597, 30);
            this.panel1.TabIndex = 1;
            // 
            // btnUjRendeles
            // 
            this.btnUjRendeles.Location = new System.Drawing.Point(3, 3);
            this.btnUjRendeles.Name = "btnUjRendeles";
            this.btnUjRendeles.Size = new System.Drawing.Size(75, 23);
            this.btnUjRendeles.TabIndex = 0;
            this.btnUjRendeles.Text = "Új rendelés";
            this.btnUjRendeles.UseVisualStyleBackColor = true;
            this.btnUjRendeles.Click += new System.EventHandler(this.btnUjRendeles_Click);
            // 
            // rendelesListaTableAdapter
            // 
            this.rendelesListaTableAdapter.ClearBeforeFill = true;
            // 
            // frmRendelesek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 358);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmRendelesek";
            this.Text = "Rendelések";
            this.Load += new System.EventHandler(this.frmRendelesek_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rendelesListaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plussDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private plussDataSet plussDataSet;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnUjRendeles;
        private System.Windows.Forms.BindingSource rendelesListaBindingSource;
        private plussDataSetTableAdapters.RendelesListaTableAdapter rendelesListaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nevDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rendelesIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tetelekSzamaDataGridViewTextBoxColumn;
    }
}
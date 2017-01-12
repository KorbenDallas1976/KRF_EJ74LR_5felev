namespace KRF_EJ74LR_5felev
{
    partial class frmUjRendeles
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
            this.btnMegse = new System.Windows.Forms.Button();
            this.btnMentes = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.rendelesFejBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.plussDataSet = new KRF_EJ74LR_5felev.plussDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.partnerekBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.partnerekTableAdapter = new KRF_EJ74LR_5felev.plussDataSetTableAdapters.PartnerekTableAdapter();
            this.rendelesFejTableAdapter = new KRF_EJ74LR_5felev.plussDataSetTableAdapters.RendelesFejTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rendelesFejBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plussDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partnerekBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnMegse);
            this.panel1.Controls.Add(this.btnMentes);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(271, 97);
            this.panel1.TabIndex = 2;
            // 
            // btnMegse
            // 
            this.btnMegse.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnMegse.Location = new System.Drawing.Point(179, 69);
            this.btnMegse.Name = "btnMegse";
            this.btnMegse.Size = new System.Drawing.Size(75, 23);
            this.btnMegse.TabIndex = 5;
            this.btnMegse.Text = "Mégse";
            this.btnMegse.UseVisualStyleBackColor = true;
            this.btnMegse.Click += new System.EventHandler(this.btnMegse_Click);
            // 
            // btnMentes
            // 
            this.btnMentes.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnMentes.Location = new System.Drawing.Point(9, 69);
            this.btnMentes.Name = "btnMentes";
            this.btnMentes.Size = new System.Drawing.Size(75, 23);
            this.btnMentes.TabIndex = 4;
            this.btnMentes.Text = "Mentés";
            this.btnMentes.UseVisualStyleBackColor = true;
            this.btnMentes.Click += new System.EventHandler(this.btnMentes_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(79, 31);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(110, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // rendelesFejBindingSource
            // 
            this.rendelesFejBindingSource.DataMember = "RendelesFej";
            this.rendelesFejBindingSource.DataSource = this.plussDataSet;
            // 
            // plussDataSet
            // 
            this.plussDataSet.DataSetName = "plussDataSet";
            this.plussDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Dátum";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Partner";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.partnerekBindingSource;
            this.comboBox1.DisplayMember = "Nev";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(79, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(178, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "PartnerId";
            // 
            // partnerekBindingSource
            // 
            this.partnerekBindingSource.DataMember = "Partnerek";
            this.partnerekBindingSource.DataSource = this.plussDataSet;
            // 
            // partnerekTableAdapter
            // 
            this.partnerekTableAdapter.ClearBeforeFill = true;
            // 
            // rendelesFejTableAdapter
            // 
            this.rendelesFejTableAdapter.ClearBeforeFill = true;
            // 
            // frmUjRendeles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 97);
            this.Controls.Add(this.panel1);
            this.Name = "frmUjRendeles";
            this.Text = "Új rendelés";
            this.Load += new System.EventHandler(this.frmUjRendeles_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rendelesFejBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plussDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partnerekBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMegse;
        private System.Windows.Forms.Button btnMentes;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private plussDataSet plussDataSet;
        private System.Windows.Forms.BindingSource partnerekBindingSource;
        private plussDataSetTableAdapters.PartnerekTableAdapter partnerekTableAdapter;
        private plussDataSetTableAdapters.RendelesFejTableAdapter rendelesFejTableAdapter;
        private System.Windows.Forms.BindingSource rendelesFejBindingSource;
    }
}
namespace Biblioteka
{
    partial class Form4
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.libralyDataSet = new Biblioteka.LibralyDataSet();
            this.russionClasicTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.russionClasicTableTableAdapter = new Biblioteka.LibralyDataSetTableAdapters.russionClasicTableTableAdapter();
            this.кодDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.авторDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наличиеНаСкладеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наличиеВБиблиотекеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uRLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libralyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.russionClasicTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодDataGridViewTextBoxColumn,
            this.авторDataGridViewTextBoxColumn,
            this.названиеDataGridViewTextBoxColumn,
            this.наличиеНаСкладеDataGridViewTextBoxColumn,
            this.наличиеВБиблиотекеDataGridViewTextBoxColumn,
            this.uRLDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.russionClasicTableBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(45, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(712, 396);
            this.dataGridView1.TabIndex = 0;
            // 
            // libralyDataSet
            // 
            this.libralyDataSet.DataSetName = "LibralyDataSet";
            this.libralyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // russionClasicTableBindingSource
            // 
            this.russionClasicTableBindingSource.DataMember = "russionClasicTable";
            this.russionClasicTableBindingSource.DataSource = this.libralyDataSet;
            // 
            // russionClasicTableTableAdapter
            // 
            this.russionClasicTableTableAdapter.ClearBeforeFill = true;
            // 
            // кодDataGridViewTextBoxColumn
            // 
            this.кодDataGridViewTextBoxColumn.DataPropertyName = "Код";
            this.кодDataGridViewTextBoxColumn.HeaderText = "Код";
            this.кодDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодDataGridViewTextBoxColumn.Name = "кодDataGridViewTextBoxColumn";
            this.кодDataGridViewTextBoxColumn.Width = 125;
            // 
            // авторDataGridViewTextBoxColumn
            // 
            this.авторDataGridViewTextBoxColumn.DataPropertyName = "Автор";
            this.авторDataGridViewTextBoxColumn.HeaderText = "Автор";
            this.авторDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.авторDataGridViewTextBoxColumn.Name = "авторDataGridViewTextBoxColumn";
            this.авторDataGridViewTextBoxColumn.Width = 125;
            // 
            // названиеDataGridViewTextBoxColumn
            // 
            this.названиеDataGridViewTextBoxColumn.DataPropertyName = "Название";
            this.названиеDataGridViewTextBoxColumn.HeaderText = "Название";
            this.названиеDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.названиеDataGridViewTextBoxColumn.Name = "названиеDataGridViewTextBoxColumn";
            this.названиеDataGridViewTextBoxColumn.Width = 125;
            // 
            // наличиеНаСкладеDataGridViewTextBoxColumn
            // 
            this.наличиеНаСкладеDataGridViewTextBoxColumn.DataPropertyName = "Наличие на складе";
            this.наличиеНаСкладеDataGridViewTextBoxColumn.HeaderText = "Наличие на складе";
            this.наличиеНаСкладеDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.наличиеНаСкладеDataGridViewTextBoxColumn.Name = "наличиеНаСкладеDataGridViewTextBoxColumn";
            this.наличиеНаСкладеDataGridViewTextBoxColumn.Width = 125;
            // 
            // наличиеВБиблиотекеDataGridViewTextBoxColumn
            // 
            this.наличиеВБиблиотекеDataGridViewTextBoxColumn.DataPropertyName = "Наличие в библиотеке";
            this.наличиеВБиблиотекеDataGridViewTextBoxColumn.HeaderText = "Наличие в библиотеке";
            this.наличиеВБиблиотекеDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.наличиеВБиблиотекеDataGridViewTextBoxColumn.Name = "наличиеВБиблиотекеDataGridViewTextBoxColumn";
            this.наличиеВБиблиотекеDataGridViewTextBoxColumn.Width = 125;
            // 
            // uRLDataGridViewTextBoxColumn
            // 
            this.uRLDataGridViewTextBoxColumn.DataPropertyName = "URL";
            this.uRLDataGridViewTextBoxColumn.HeaderText = "URL";
            this.uRLDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.uRLDataGridViewTextBoxColumn.Name = "uRLDataGridViewTextBoxColumn";
            this.uRLDataGridViewTextBoxColumn.Width = 125;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libralyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.russionClasicTableBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private LibralyDataSet libralyDataSet;
        private System.Windows.Forms.BindingSource russionClasicTableBindingSource;
        private LibralyDataSetTableAdapters.russionClasicTableTableAdapter russionClasicTableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn авторDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наличиеНаСкладеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наличиеВБиблиотекеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uRLDataGridViewTextBoxColumn;
    }
}
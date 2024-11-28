namespace Biblioteka
{
    partial class Form2
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.кодDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.авторDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наличиеНаСкладеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наличиеВБиблиотекеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uRLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.russionClasicTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libralyDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libralyDataSet = new Biblioteka.LibralyDataSet();
            this.russionClasicTableTableAdapter = new Biblioteka.LibralyDataSetTableAdapters.russionClasicTableTableAdapter();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.russionClasicTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libralyDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libralyDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.8F);
            this.textBox1.Location = new System.Drawing.Point(287, 376);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(306, 41);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.8F);
            this.textBox2.Location = new System.Drawing.Point(64, 376);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(217, 41);
            this.textBox2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.8F);
            this.button1.Location = new System.Drawing.Point(626, 376);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 44);
            this.button1.TabIndex = 2;
            this.button1.Text = "Поиск";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.label1.Location = new System.Drawing.Point(73, 334);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Автор:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.label2.Location = new System.Drawing.Point(292, 334);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(267, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Название произведения:";
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
            this.dataGridView1.Location = new System.Drawing.Point(658, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(139, 80);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.Visible = false;
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
            // russionClasicTableBindingSource
            // 
            this.russionClasicTableBindingSource.DataMember = "russionClasicTable";
            this.russionClasicTableBindingSource.DataSource = this.libralyDataSetBindingSource;
            // 
            // libralyDataSetBindingSource
            // 
            this.libralyDataSetBindingSource.DataSource = this.libralyDataSet;
            this.libralyDataSetBindingSource.Position = 0;
            // 
            // libralyDataSet
            // 
            this.libralyDataSet.DataSetName = "LibralyDataSet";
            this.libralyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // russionClasicTableTableAdapter
            // 
            this.russionClasicTableTableAdapter.ClearBeforeFill = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.8F);
            this.linkLabel1.Location = new System.Drawing.Point(346, 200);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(111, 36);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Потом";
            this.linkLabel1.Visible = false;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.8F);
            this.label3.Location = new System.Drawing.Point(231, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(352, 54);
            this.label3.TabIndex = 7;
            this.label3.Text = "Читать сейчас:";
            this.label3.Visible = false;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.8F);
            this.button2.Location = new System.Drawing.Point(626, 267);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 93);
            this.button2.TabIndex = 8;
            this.button2.Text = "Каталог";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.russionClasicTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libralyDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libralyDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource libralyDataSetBindingSource;
        private LibralyDataSet libralyDataSet;
        private System.Windows.Forms.BindingSource russionClasicTableBindingSource;
        private LibralyDataSetTableAdapters.russionClasicTableTableAdapter russionClasicTableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn авторDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наличиеНаСкладеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наличиеВБиблиотекеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uRLDataGridViewTextBoxColumn;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
    }
}
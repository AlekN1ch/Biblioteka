using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteka
{
    public partial class Form2 : Form
    {
        public static string connection = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Libraly.accdb";
        public OleDbConnection myConnection;
        public string url;
        public Form2()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connection);
            myConnection.Open();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "libralyDataSet.russionClasicTable". При необходимости она может быть перемещена или удалена.
            this.russionClasicTableTableAdapter.Fill(this.libralyDataSet.russionClasicTable);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string author=textBox2.Text;
            string book = textBox1.Text;
            try
            {
                string query = "SELECT [URL] FROM russionClasicTable WHERE [Автор]='" + author + "' AND [Название]='" + book + "'";
                OleDbCommand command = new OleDbCommand(query, myConnection);
                string url = command.ExecuteScalar().ToString();
                linkLabel1.Visible = true;
                label3.Visible = true;
                linkLabel1.Text = url;
            }
            catch 
            {
                MessageBox.Show("К сожалению,данной книги у нас нет\n,но вы можете добавить ее в книгу заявок\n:)))");
                Form3 form3 = new Form3();
                form3.Show();

            }

        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
             var url=linkLabel1.Text;
            System.Diagnostics.Process.Start(url);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
        }
    }
}

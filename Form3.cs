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
    public partial class Form3 : Form
    {
        public static string connection = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Libraly.accdb";
        public OleDbConnection myConnection;
        public Form3()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connection);
            myConnection.Open();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "libralyDataSet.bookListTable". При необходимости она может быть перемещена или удалена.
            this.bookListTableTableAdapter.Fill(this.libralyDataSet.bookListTable);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string author = textBox2.Text;
            string book = textBox1.Text;
            string query = "INSERT INTO  bookListTable ([Автор],[Название]) VALUES" + "('" + author + "' ,'" + book + "')";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            this.bookListTableTableAdapter.Fill(this.libralyDataSet.bookListTable);
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.bookListTableTableAdapter.Fill(this.libralyDataSet.bookListTable);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

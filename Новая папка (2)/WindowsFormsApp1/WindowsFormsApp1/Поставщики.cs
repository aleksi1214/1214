using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApp1
{
    public partial class Поставщики : Form
    {
        public static string connectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = Database1.mdb";
        private OleDbConnection myConnection;
        public Поставщики()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectionString);
            myConnection.Open();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Поставщики". При необходимости она может быть перемещена или удалена.
            this.поставщикиTableAdapter.Fill(this.database1DataSet.Поставщики);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Поставщики". При необходимости она может быть перемещена или удалена.
            this.поставщикиTableAdapter.Fill(this.database1DataSet.Поставщики);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (поставщикиBindingSource.Current == null)
                MessageBox.Show("Невозможно удалить пустую строку!", "Erorr");
            else
                поставщикиBindingSource.RemoveCurrent();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.поставщикиTableAdapter.Update(this.database1DataSet.Поставщики);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            поставщикиBindingSource.Filter = $"Наименования like'{textBox1.Text}%'";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            поставщикиBindingSource.Filter = $"Адрес like'{textBox2.Text}%'";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Добавить_поставщика form = new Добавить_поставщика(database1DataSet);
            form.ShowDialog();
        }

        private void Поставщики_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            object current2 = поставщикиBindingSource.Current;
            DataRow rowData2 = ((DataRowView)(current2)).Row;

            Database1DataSet.ПоставщикиRow row1 = (Database1DataSet.ПоставщикиRow)rowData2;

             редактирование_поставщиков form = new редактирование_поставщиков(row1);
            form.Show();
        }
    }
}

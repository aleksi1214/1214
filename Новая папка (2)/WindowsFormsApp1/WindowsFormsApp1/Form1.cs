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
    public partial class Form1 : Form
    {
        public static string connectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = Database1.mdb";
        private OleDbConnection myConnection;
        public Form1()
        {
            InitializeComponent();
            
            myConnection = new OleDbConnection(connectionString);
            myConnection.Open();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Детали_на_складе". При необходимости она может быть перемещена или удалена.
            this.детали_на_складеTableAdapter.Fill(this.database1DataSet.Детали_на_складе);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Накладная_поставок". При необходимости она может быть перемещена или удалена.
            this.накладная_поставокTableAdapter.Fill(this.database1DataSet.Накладная_поставок);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Поставщики". При необходимости она может быть перемещена или удалена.
            this.поставщикиTableAdapter.Fill(this.database1DataSet.Поставщики);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Поставки". При необходимости она может быть перемещена или удалена.
            this.поставкиTableAdapter.Fill(this.database1DataSet.Поставки);

        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {


        }

        private void dataGridView1_DataError_1(object sender, DataGridViewDataErrorEventArgs e)
        {


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_DataError_2(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.Exception.Message == "DataGridViewComboBoxCell value is not valid.")
            {
                object value = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                if (!((DataGridViewComboBoxColumn)dataGridView1.Columns[e.ColumnIndex]).Items.Contains(value))
                {
                    ((DataGridViewComboBoxColumn)dataGridView1.Columns[e.ColumnIndex]).Items.Add(value);
                    e.ThrowException = false;
                }
            }
        }

        private void dataGridView2_DragEnter(object sender, DragEventArgs e)
        {
           

            }

        private void dataGridView2_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.Exception.Message == "DataGridViewComboBoxCell value is not valid.")
            {
                object value = dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                if (!((DataGridViewComboBoxColumn)dataGridView2.Columns[e.ColumnIndex]).Items.Contains(value))
                {
                    ((DataGridViewComboBoxColumn)dataGridView2.Columns[e.ColumnIndex]).Items.Add(value);
                    e.ThrowException = false;
                }
            }
    }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Добавить_деталь form = new Добавить_деталь(database1DataSet);
            form.ShowDialog();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Добавить_поставщика form = new Добавить_поставщика(database1DataSet);
            form.ShowDialog();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (поставкиBindingSource.Current == null)
                MessageBox.Show("Невозможно удалить пустую строку!", "Erorr");
            else
                поставкиBindingSource.RemoveCurrent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.поставкиTableAdapter.Update(this.database1DataSet.Поставки);
            this.поставщикиTableAdapter.Update(this.database1DataSet.Поставщики);
            this.накладная_поставокTableAdapter.Update(this.database1DataSet.Накладная_поставок);
            this.детали_на_складеTableAdapter.Update(this.database1DataSet.Детали_на_складе);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (накладнаяПоставокBindingSource.Current == null)
                MessageBox.Show("Невозможно удалить пустую строку!", "Erorr");
            else
               накладнаяПоставокBindingSource.RemoveCurrent();
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
           поставкиBindingSource.Filter = "[Поставщик] = " + toolStripTextBox1.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            накладнаяПоставокBindingSource.Filter = $"номер_накладной like'{toolStripTextBox1.Text}%'";
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {

        }
    }
}

    


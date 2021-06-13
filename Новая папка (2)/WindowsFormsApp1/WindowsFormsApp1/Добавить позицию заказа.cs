using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Добавить_позицию_заказа : Form
    {
        private Database1DataSet Table;
        public Добавить_позицию_заказа(Database1DataSet tabel)
        {
            InitializeComponent();
            Table = tabel;

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}

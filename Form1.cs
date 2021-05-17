using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Massive1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            int m = Convert.ToInt32(textBox1.Text);
            int n = Convert.ToInt32(textBox2.Text);
            dataGridView1.RowCount = m;
            dataGridView1.ColumnCount = n;
            int[,] a = new int[m, n];
            int i, j;
            Random rand = new Random();
            for (i = 0; i < m; i++)
                for (j = 0; j < n; j++)
                    a[i, j] = rand.Next(-100, 100);

            for (i = 0; i < m; i++)
                for (j = 0; j < n; j++)
                    dataGridView1.Rows[i].Cells[j].Value = Convert.ToString(a[i, j]);

        }
    }
}

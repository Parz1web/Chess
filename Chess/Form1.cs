using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chess
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void start(object sender, EventArgs e)
        {

        }
    
        private void setupChessField(object sender, EventArgs e)
        {
            dataGridView1.RowCount = 8;
            dataGridView1.ColumnCount = 8;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (i % 2 == 0)
                    {
                        if (j % 2 == 0)
                        {
                            dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.Brown;
                            dataGridView1.Rows[i].Cells[j].Style.SelectionBackColor = Color.Brown;
                        }
                        else
                        {
                            dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.Black;
                            dataGridView1.Rows[i].Cells[j].Style.SelectionBackColor = Color.Black;
                        }
                    }
                    else
                    {
                        if (j % 2 == 0)
                        {
                            dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.Black;
                            dataGridView1.Rows[i].Cells[j].Style.SelectionBackColor = Color.Black;
                        }
                        else
                        {
                            dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.Brown;
                            dataGridView1.Rows[i].Cells[j].Style.SelectionBackColor = Color.Brown;
                        }
                    }
                }
                dataGridView1.Rows[i].Height = 100;
                dataGridView1.Columns[i].Width = 100;

            }
        }

    }
}

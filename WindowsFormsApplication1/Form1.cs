using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Color[] clr = new Color[15]{Color.Red, Color.RosyBrown, Color.Salmon, Color.Yellow, Color.Purple, Color.Maroon,  Color.LightBlue, Color.DeepPink,
                 Color.LightCoral, Color.LightSeaGreen, Color.LimeGreen, Color.Aqua, Color.Blue, Color.Gold, Color.LightBlue};
            int tmax = 0, m = 0, trow = 0;
            Random rnd = new Random();
            dataGridView1.ColumnCount = 15;
            dataGridView1.RowCount = 15;
            int n = 0;

            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 15; j++)
                {
                    n = rnd.Next(-30, 30);
                    dataGridView1.Rows[i].Cells[j].Value = n;
                }

            }
            for (int k = 0; k < 15; k++)
            {
                m = int.Parse(dataGridView1.Rows[k].Cells[k].Value.ToString());
                if (m > tmax)
                {
                    tmax = m;
                    trow = k;
                }
            }
            textBox1.Text = "Максимум  " + tmax.ToString() + "   " + "Строка  " + trow;

            for (int d = 0; d < 15; d++)
                dataGridView1.Rows[trow].Cells[d].Style.BackColor = clr[d];

        }

    }
}
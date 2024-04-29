using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            // Перетворення текстових рядків, які ввів користувач,
            // у змінні числового типу
            double x1min = double.Parse(tbx1min.Text);
            double x1max = double.Parse(tbx1max.Text);
            double x2min = double.Parse(tbx2min.Text);
            double x2max = double.Parse(tbx2max.Text);
            double dx1 = double.Parse(tbdx1.Text);
            double dx2 = double.Parse(tbdx2.Text);
            // Обчислення кількості рядків та стовпчиків таблиці
            gv.ColumnCount = (int)Math.Truncate((x2max - x2min) / dx2) + 3;
            gv.RowCount = (int)Math.Truncate((x1max - x1min) / dx1) + 2;
            // Вивід заголовків рядків та стовпців таблиці
            for (int i = 0; i < gv.RowCount - 1; i++)
                gv.Rows[i].HeaderCell.Value = (x1min + i * dx1).ToString("0.000");
            gv.RowHeadersWidth = 80;
            for (int i = 0; i < gv.ColumnCount - 1; i++)
            {
                gv.Columns[i].HeaderCell.Value = (x2min + i * dx2).ToString("0.000");
                gv.Columns[i].Width = 60;
            }
            gv.Columns[gv.ColumnCount - 2].HeaderCell.Value = "Sum negative";
            gv.Columns[gv.ColumnCount - 1].HeaderCell.Value = "Sum";
            gv.Rows[gv.RowCount - 1].HeaderCell.Value = "Sum";
            // Для автоматичного підлаштування розмірів стовпчиків та рядків
            // можна використовувати ці методи
            //gv.AutoResizeColumns();
            //gv.AutoResizeRows();
            int cl, rw;
            double x1, x2, y;
            // Розрахунок і вивід езультатів
            double[] columnSums = new double[gv.ColumnCount - 2];
            Double sum = 0;
            Double totalRowSum = 0;
            rw = 0; x1 = x1min;
            while (x1 <= x1max)
            {
                x2 = x2min; cl = 0;
                while (x2 <= x2max)
                {
                    y = Math.Pow(Math.Sin((x1 * (x2 / (x1 + 53 * Math.Pow(x2, 2))))), 2);
                    if (y< 0)
                    {
                        sum += y;
                    }
                    columnSums[cl] += y;
                    totalRowSum += y;
                    gv.Rows[rw].Cells[cl].Value = y.ToString("0.000");
                    x2 += dx2; cl++;
                }
                gv.Rows[rw].Cells[gv.ColumnCount - 2].Value = sum.ToString("0.000");
                gv.Rows[rw].Cells[gv.ColumnCount - 1].Value = totalRowSum.ToString("0.000");
                totalRowSum = 0;
                sum = 0;
                x1 += dx1;
                rw++;
            }
            for (int i = 0; i < gv.ColumnCount - 2; i++)
            {
                gv.Rows[gv.RowCount - 1].Cells[i].Value = columnSums[i].ToString("0.000");
            }
        }
    }
}

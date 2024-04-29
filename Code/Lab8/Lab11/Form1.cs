using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int buttonsSize = 5 * btnAdd.Width + 2 * tsSeparator1.Width + 30;
            btnExit.Margin = new Padding(Width - buttonsSize, 0, 0, 0);

            gvTowns.AutoGenerateColumns = false;
            DataGridViewColumn column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Name";
            column.Name = "Назва"; gvTowns.Columns.Add(column);
            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Description";
            column.Name = "Опис";
            gvTowns.Columns.Add(column);
            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Price";
            column.Name = "Ціна";
            gvTowns.Columns.Add(column);
            bindSrcTowns.Add(new Food("Хліб", "Чорний", 10.50));
            EventArgs args = new EventArgs();
            OnResize(args);


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Food food = new Food();
            TownEditor ft = new TownEditor(food);
            if (ft.ShowDialog() == DialogResult.OK)
            {
                bindSrcTowns.Add(food);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Food food = (Food)bindSrcTowns.List[bindSrcTowns.Position];
            TownEditor ft = new TownEditor(food);
            if (ft.ShowDialog() == DialogResult.OK)
            {
                bindSrcTowns.List[bindSrcTowns.Position] = food;
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Видалити поточний запис?",
"Видалення запису", MessageBoxButtons.OKCancel,
MessageBoxIcon.Warning) == DialogResult.OK)
            {
                bindSrcTowns.RemoveCurrent();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
"Очистити таблицю?\n\nВсі дані будуть втрачені",
"Очищення даних", MessageBoxButtons.OKCancel,
MessageBoxIcon.Question) == DialogResult.OK)
            {
                bindSrcTowns.Clear();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Закрити застосунок?", "Вихід з програми",
MessageBoxButtons.OKCancel,
MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}

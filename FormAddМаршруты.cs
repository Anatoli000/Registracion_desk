using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Касса_БЕЛ_ЖД.Controller;


namespace Касса_БЕЛ_ЖД
{
    public partial class FormAddМаршруты : Form
    {
        Query controller;
        public FormAddМаршруты()
        {
            InitializeComponent();
            controller = new Query(ConnectionString.ConnStr);
        }

        private void FormAddМаршруты_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = controller.UpdateМаршруты();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "") || (textBox2.Text == "") || (textBox3.Text == "") || (textBox4.Text == ""))
            {
                MessageBox.Show("Одно или несколько полей пусты. Все поля далжны быть заполнены.", "Ошибка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);

            }
            else
            {
                DialogResult dr = MessageBox.Show("Добавить запись?",
              "Добавление",
              MessageBoxButtons.OKCancel,
              MessageBoxIcon.Warning,
              MessageBoxDefaultButton.Button3);
                if (dr == DialogResult.OK)
                {
                    controller.AddМаршруты(textBox1.Text, textBox2.Text, int.Parse(textBox3.Text), double.Parse(textBox4.Text));
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Удалить запись?",
                "Удаление",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button3);
            if (dr == DialogResult.OK)
            {
                controller.DeleteМаршруты(int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["№_маршрута"].Value.ToString()));
            }
        }

        private void FormAddМаршруты_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormAddTickets formAdd = new FormAddTickets();
            formAdd.Activate();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            DialogResult dr = MessageBox.Show("Внести изменения?",
          "Изменение данных",
          MessageBoxButtons.OKCancel,
          MessageBoxIcon.Warning,
          MessageBoxDefaultButton.Button3);
            if (dr == DialogResult.OK)
            {
                groupBox1.Text = "Область изменения данных";
                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
                button4.Visible = true;
                button5.Visible = true;
                textBox1.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["Наименование_маршрута"].Value.ToString();
                textBox2.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["Линии_перевозок"].Value.ToString();
                textBox3.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["Длинна_маршрута_км"].Value.ToString();
                textBox4.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["Стоимость_за_1км"].Value.ToString();
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            {
                DialogResult dr = MessageBox.Show("Отменить изменения?",
              "Отмена",
              MessageBoxButtons.OKCancel,
              MessageBoxIcon.Warning,
              MessageBoxDefaultButton.Button3);
                if (dr == DialogResult.OK)
                {
                    groupBox1.Text = "Область добавления данных";
                    button1.Visible = true;
                    button2.Visible = true;
                    button3.Visible = true;
                    button4.Visible = false;
                    button5.Visible = false;
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "") || (textBox2.Text == "") || (textBox3.Text == "") || (textBox4.Text == ""))
            {
                MessageBox.Show("Одно или несколько полей пусты. Все поля далжны быть заполнены.", "Ошибка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
            else
            {
                DialogResult dr = MessageBox.Show("Сохранить изменения?",
              "Сохранение",
              MessageBoxButtons.OKCancel,
              MessageBoxIcon.Warning,
              MessageBoxDefaultButton.Button3);
                if (dr == DialogResult.OK)
                {
                    groupBox1.Text = "Область добавления данных";
                    button1.Visible = true;
                    button2.Visible = true;
                    button3.Visible = true;
                    button4.Visible = false;
                    button5.Visible = false;
                    controller.UpdateMarhrut(textBox1.Text, textBox2.Text, int.Parse(textBox3.Text), double.Parse(textBox4.Text), Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["№_маршрута"].Value.ToString()));
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                }
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (button5.Visible == true)
            {
                textBox1.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["Наименование_маршрута"].Value.ToString();
                textBox2.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["Линии_перевозок"].Value.ToString();
                textBox3.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["Длинна_маршрута_км"].Value.ToString();
                textBox4.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["Стоимость_за_1км"].Value.ToString();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if ((textBox5.Text == ""))
            {
                MessageBox.Show("Поле для поиска не должно быть пустым", "Ошибка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);

            }
            else
            {
                dataGridView1.DataSource = controller.SearchМаршруты(textBox5.Text);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox5.Text = "";
            dataGridView1.DataSource = controller.UpdateМаршруты();
        }
    }
}

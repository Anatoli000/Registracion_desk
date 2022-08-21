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
    public partial class FormAddВагоны : Form
    {
        Query controller;
        public FormAddВагоны()
        {
            InitializeComponent();
            controller = new Query(ConnectionString.ConnStr);
        }

        private void button1_Click(object sender, EventArgs e)
        {
         DialogResult result = MessageBox.Show(
         "Удалить?",
         "Сообщение",
         MessageBoxButtons.YesNo,
         MessageBoxIcon.Warning,
         MessageBoxDefaultButton.Button1,
         MessageBoxOptions.DefaultDesktopOnly);
            if (result == DialogResult.Yes)
            {
                controller.DeleteВагоны(int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["ID_вагона"].Value.ToString()));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Хотите изменить запись?",
              "Изменение данных",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Warning,
               MessageBoxDefaultButton.Button3);
            if (dr == DialogResult.Yes)
            {
                groupBox1.Text = "Область изменения данных";
                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
                button4.Visible = true;
                button5.Visible = true;
                textBox1.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["тип_вагона"].Value.ToString();
                textBox2.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["доплата"].Value.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "") || (textBox2.Text == ""))
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
                    controller.AddВагоны(textBox1.Text, double.Parse(textBox2.Text));
                }
            }
        }
        private void FormAddВагоны_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = controller.UpdateВагоны();
        }

        private void FormAddВагоны_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormAddTickets formAdd = new FormAddTickets();
            formAdd.Activate();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Хотите отменить изменения?",
           "Отмена",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning,
            MessageBoxDefaultButton.Button3);
            if (dr == DialogResult.Yes)
            {
                groupBox1.Text = "Область добавления данных";
                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
                button4.Visible = false;
                button5.Visible = false;
                textBox1.Text = "";
                textBox2.Text = "";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "") || (textBox2.Text == ""))
            {
                MessageBox.Show("Одно или несколько полей пусты. Все поля далжны быть заполнены.", "Ошибка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);

            }
            else
            {
                DialogResult dr = MessageBox.Show("Сохронить изменения?",
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
                    controller.UpdateVagon(textBox1.Text, double.Parse(textBox2.Text), Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["ID_вагона"].Value.ToString()));
                    textBox1.Text = "";
                    textBox2.Text = "";
                }
            }

        }    
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (button5.Visible == true)
            {
                textBox1.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["тип_вагона"].Value.ToString();
                textBox2.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["доплата"].Value.ToString();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox5.Text = "";
            dataGridView1.DataSource = controller.UpdateВагоны();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if ((textBox5.Text == ""))
            {
                MessageBox.Show("Введите данные для поиска.", "Ошибка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);

            }
            else
            {
                dataGridView1.DataSource = controller.SearchВагоны(textBox5.Text);
            }
        }
    }
}

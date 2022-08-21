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
    public partial class FormAddПоезда : Form

    {
        Query controller;

        public FormAddПоезда()
        {
            InitializeComponent();
            controller = new Query(ConnectionString.ConnStr);
        }

        private void FormAddПоезда_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = controller.UpdateПоезда();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Изменить запись?",
               "Изменение",
               MessageBoxButtons.OKCancel,
               MessageBoxIcon.Warning,
               MessageBoxDefaultButton.Button3);
            if (dr == DialogResult.OK)
            {
                groupBox1.Text = "Область изменения данных";
                buttonDelet.Visible = false;
                buttonAdd.Visible = false;
                buttonUpdate.Visible = false;
                button1.Visible = true;
                button2.Visible = true;
                textBox1.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["тип_поезда"].Value.ToString();
                textBox2.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["количество_вагонов"].Value.ToString();
                textBox3.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["Доплата_за_тип_поезда"].Value.ToString();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "") || (textBox2.Text == "") || (textBox3.Text == ""))
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
                    controller.Add(textBox1.Text, int.Parse(textBox2.Text), double.Parse(textBox3.Text));
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
                controller.Delete(int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["№_поезда"].Value.ToString()));
            }
        }

        private void FormAddПоезда_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormAddTickets formAdd = new FormAddTickets();
            formAdd.Activate();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if ((textBox1.Text == "") || (textBox2.Text == "") || (textBox3.Text == ""))
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
                    buttonDelet.Visible = true;
                    buttonAdd.Visible = true;
                    buttonUpdate.Visible = true;
                    button1.Visible = false;
                    button2.Visible = false;
                    controller.UpdateTable(textBox1.Text, int.Parse(textBox2.Text), double.Parse(textBox3.Text), Convert.ToInt32(dataGridView1[0, dataGridView1.CurrentCell.RowIndex].Value));
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Отменить изменения?",
                  "Отмена",
                  MessageBoxButtons.OKCancel,
                  MessageBoxIcon.Warning,
                  MessageBoxDefaultButton.Button3);
            if (dr == DialogResult.OK)
            {
                groupBox1.Text = "Область добавления данных";
                buttonDelet.Visible = true;
                buttonAdd.Visible = true;
                buttonUpdate.Visible = true;
                button1.Visible = false;
                button2.Visible = false;
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (buttonUpdate.Visible == false)
            { textBox1.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["тип_поезда"].Value.ToString();
              textBox2.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["количество_вагонов"].Value.ToString();
              textBox3.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["Доплата_за_тип_поезда"].Value.ToString();
            }

            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox5.Text == "")
            {
                MessageBox.Show("Поле для поиска не должно быть пустым", "Ошибка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);

            }
            else
            {
                dataGridView1.DataSource = controller.SearchПоезда(textBox5.Text);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox5.Text = "";
            dataGridView1.DataSource = controller.UpdateПоезда();
        }
    }
}

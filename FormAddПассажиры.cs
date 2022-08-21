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
    public partial class FormAddПассажиры : Form
    {
        Query controller;
        public FormAddПассажиры()
        {
            InitializeComponent();
            controller = new Query(ConnectionString.ConnStr);
        }

        private void FormAddПассажиры_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "касса_ЖД_вокзалаDataSet.Телефоны". При необходимости она может быть перемещена или удалена.
            this.телефоныTableAdapter.Fill(this.касса_ЖД_вокзалаDataSet.Телефоны);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "касса_ЖД_вокзалаDataSet.Адреса". При необходимости она может быть перемещена или удалена.
            this.адресаTableAdapter.Fill(this.касса_ЖД_вокзалаDataSet.Адреса);

            dataGridView1.DataSource = controller.UpdateПассажиры();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
          "Добавить новый адрес?",
          "Сообщение",
          MessageBoxButtons.YesNo,
          MessageBoxIcon.Information,
          MessageBoxDefaultButton.Button1,
          MessageBoxOptions.DefaultDesktopOnly);
            if (result == DialogResult.Yes)
            { 
                Visible = false;
                FormAddАдреса адресаAdd = new FormAddАдреса();
                адресаAdd.ShowDialog();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
          "Добавить новый телефон?",
          "Сообщение",
          MessageBoxButtons.YesNo,
          MessageBoxIcon.Information,
          MessageBoxDefaultButton.Button1,
          MessageBoxOptions.DefaultDesktopOnly);
            if (result == DialogResult.Yes)
            {
                Visible = false;
                FormAddТелефоны телефоныAdd = new FormAddТелефоны();
                телефоныAdd.ShowDialog();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "") || (textBox2.Text == "") || (textBox3.Text == ""))
            {
                MessageBox.Show("Одно или несколько полей пусты. Все поля далжны быть заполнены.", "Ошибка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);

            }
            else
            {
                DialogResult result = MessageBox.Show(
                      "Добавить нового пассажира?",
                      "Сообщение",
                      MessageBoxButtons.YesNo,
                      MessageBoxIcon.Information,
                      MessageBoxDefaultButton.Button1,
                      MessageBoxOptions.DefaultDesktopOnly);
                if (result == DialogResult.Yes)
                {
                    controller.AddПассажиры(textBox1.Text, textBox2.Text, textBox3.Text, int.Parse(comboBox1.Text), int.Parse(comboBox2.Text));
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
                controller.DeleteПассажиры(int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["id_пассажира"].Value.ToString()));
            }
        }

        private void FormAddПассажиры_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormAddTickets formAdd = new FormAddTickets();
            formAdd.Activate();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Хотите внести изменения?",
                  "Изменения",
                  MessageBoxButtons.YesNo,
                  MessageBoxIcon.Warning,
                  MessageBoxDefaultButton.Button3);
            if (dr == DialogResult.Yes)
            {
                groupBox1.Text = "Область изменения данных";
                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
                button4.Visible = false;
                button5.Visible = false;
                button6.Visible = true;
                button7.Visible = true;
                textBox1.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["фамилия"].Value.ToString();
                textBox2.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["имя"].Value.ToString();
                textBox3.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["отчество"].Value.ToString();
                comboBox1.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["ID_адресса"].Value.ToString();
                comboBox2.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["ID_телефона"].Value.ToString();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Отменить изменения?",
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
                button4.Visible = true;
                button5.Visible = true;
                button6.Visible = false;
                button7.Visible = false;
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
            }
        }

        private void button7_Click(object sender, EventArgs e)
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
                    button1.Visible = true;
                    button2.Visible = true;
                    button3.Visible = true;
                    button4.Visible = true;
                    button5.Visible = true;
                    button6.Visible = false;
                    button7.Visible = false;
                    controller.UpdateClient(textBox1.Text, textBox2.Text, textBox3.Text, int.Parse(comboBox1.Text), int.Parse(comboBox2.Text), Convert.ToInt32(dataGridView1[0, dataGridView1.CurrentCell.RowIndex].Value));
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                }
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if(button7.Visible == true)
            { 
            textBox1.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["фамилия"].Value.ToString();
            textBox2.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["имя"].Value.ToString();
            textBox3.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["отчество"].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["ID_адресса"].Value.ToString();
            comboBox2.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["ID_телефона"].Value.ToString();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox5.Text = "";
            textBox6.Text = "";
            textBox4.Text = "";
            dataGridView1.DataSource = controller.UpdateПассажиры();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if ((textBox5.Text == "") || (textBox6.Text == "") || (textBox4.Text == ""))
            {
                MessageBox.Show("Одно или несколько полей пусты. Все поля далжны быть заполнены.", "Ошибка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);

            }
            else
            {
                dataGridView1.DataSource = controller.SearchПассажиры(textBox5.Text, textBox6.Text, textBox4.Text);
            }
        }
    }
}

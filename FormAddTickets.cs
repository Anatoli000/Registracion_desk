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
    public partial class FormAddTickets : Form
    {
        Query controller;
        public FormAddTickets()
        {
            InitializeComponent();
            controller = new Query(ConnectionString.ConnStr);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if ((comboBox1.Text== "") || (comboBox2.Text== "") || (dateTimePicker1.Value == null) || (dateTimePicker2.Value== null) ||(comboBox3.Text== "")||(maskedTextBox4.Text== "")||(comboBox5.Text== "")||(textBox3.Text== "")||(textBox4.Text== ""))
             {
                 MessageBox.Show("Одно или несколько полей пусты. Все поля далжны быть заполнены.", "Ошибка",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Error);

             }
             else
             {
                 DialogResult result = MessageBox.Show(
                 "Добавить запись?",
                 "Сообщение",
                 MessageBoxButtons.YesNo,
                 MessageBoxIcon.Information,
                 MessageBoxDefaultButton.Button1,
                 MessageBoxOptions.DefaultDesktopOnly);
                 if (result == DialogResult.Yes)
                 {
                    controller.AddTickets(int.Parse(comboBox1.Text), int.Parse(comboBox2.Text), DateTime.Parse(dateTimePicker1.Value.ToString()), DateTime.Parse(dateTimePicker2.Value.ToString()), int.Parse(comboBox3.Text), int.Parse(maskedTextBox4.Text), int.Parse(comboBox5.Text), double.Parse(textBox3.Text), double.Parse(textBox4.Text));
                    MessageBox.Show("Данные успешно добавлены", "Сообщение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    Close();
                 }
             }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormAddTickets main = this.Owner as FormAddTickets;
            DialogResult result = MessageBox.Show(
             "Отменить изменения?  ",
             "Сообщение",
             MessageBoxButtons.YesNo,
             MessageBoxIcon.Information,
             MessageBoxDefaultButton.Button1,
             MessageBoxOptions.DefaultDesktopOnly);
            if (result == DialogResult.Yes)
            {
                Close();
            }
        }

        private void FormAddTickets_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "касса_ЖД_вокзалаDataSet.Вагоны". При необходимости она может быть перемещена или удалена.
            this.вагоныTableAdapter.Fill(this.касса_ЖД_вокзалаDataSet.Вагоны);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "касса_ЖД_вокзалаDataSet.Пассажиры". При необходимости она может быть перемещена или удалена.
            this.пассажирыTableAdapter.Fill(this.касса_ЖД_вокзалаDataSet.Пассажиры);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "касса_ЖД_вокзалаDataSet.Маршруты". При необходимости она может быть перемещена или удалена.
            this.маршрутыTableAdapter.Fill(this.касса_ЖД_вокзалаDataSet.Маршруты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "касса_ЖД_вокзалаDataSet.Поезда". При необходимости она может быть перемещена или удалена.
            this.поездаTableAdapter.Fill(this.касса_ЖД_вокзалаDataSet.Поезда);


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            double result = (double.Parse(textBox3.Text) + double.Parse(textBox5.Text) + double.Parse(textBox6.Text));
            textBox4.Text = result.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
          "Открыть окно добавления данных о поездах?",
          "Сообщение",
          MessageBoxButtons.YesNo,
          MessageBoxIcon.Information,
          MessageBoxDefaultButton.Button1,
          MessageBoxOptions.DefaultDesktopOnly);
            if (result == DialogResult.Yes)
            {
                FormAddПоезда поездаAdd = new FormAddПоезда();
                поездаAdd.ShowDialog();
                
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
          "Открыть окно добавления данных о маршрутах?",
          "Сообщение",
          MessageBoxButtons.YesNo,
          MessageBoxIcon.Information,
          MessageBoxDefaultButton.Button1,
          MessageBoxOptions.DefaultDesktopOnly);
            if (result == DialogResult.Yes)
            {
               FormAddМаршруты маршрутыAdd = new FormAddМаршруты();
                маршрутыAdd.ShowDialog();
                
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
          "Открыть окно добавления данных о пассажирах?",
          "Сообщение",
          MessageBoxButtons.YesNo,
          MessageBoxIcon.Information,
          MessageBoxDefaultButton.Button1,
          MessageBoxOptions.DefaultDesktopOnly);
            if (result == DialogResult.Yes)
            {
                FormAddПассажиры пассажирыAdd = new FormAddПассажиры();
                пассажирыAdd.ShowDialog();
                     
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
          "Открыть окно добавления данных о вагонах?",
          "Сообщение",
          MessageBoxButtons.YesNo,
          MessageBoxIcon.Information,
          MessageBoxDefaultButton.Button1,
          MessageBoxOptions.DefaultDesktopOnly);
            if (result == DialogResult.Yes)
            {
                FormAddВагоны вагоныAdd = new FormAddВагоны();
                вагоныAdd.ShowDialog();
                
            }
        }

        private void FormAddTickets_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormTickets formTickets = new FormTickets();
            formTickets.Visible = true;
        }

        private void FormAddTickets_Activated(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "касса_ЖД_вокзалаDataSet.Вагоны". При необходимости она может быть перемещена или удалена.
            this.вагоныTableAdapter.Fill(this.касса_ЖД_вокзалаDataSet.Вагоны);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "касса_ЖД_вокзалаDataSet.Пассажиры". При необходимости она может быть перемещена или удалена.
            this.пассажирыTableAdapter.Fill(this.касса_ЖД_вокзалаDataSet.Пассажиры);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "касса_ЖД_вокзалаDataSet.Маршруты". При необходимости она может быть перемещена или удалена.
            this.маршрутыTableAdapter.Fill(this.касса_ЖД_вокзалаDataSet.Маршруты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "касса_ЖД_вокзалаDataSet.Поезда". При необходимости она может быть перемещена или удалена.
            this.поездаTableAdapter.Fill(this.касса_ЖД_вокзалаDataSet.Поезда);
        }
    }
}

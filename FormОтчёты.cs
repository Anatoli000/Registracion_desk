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
    public partial class FormОтчёты : Form
    {
        
        
        Query controller;

        public FormОтчёты()
        {
            InitializeComponent();
            controller = new Query(ConnectionString.ConnStr);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Выйти?",
                  "Выход",
                  MessageBoxButtons.OKCancel,
                  MessageBoxIcon.Warning,
                  MessageBoxDefaultButton.Button3);
            if (dr == DialogResult.OK)
            {
                Close();
            }
        }


        private void button6_Click(object sender, EventArgs e)
        {
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button2.Visible = true;
            button7.Visible = true;
            comboBox4.Visible = true;
            label4.Visible = true;
            button1.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button2.Visible = true;
            button7.Visible = true;
            comboBox1.Visible = true;
            label1.Visible = true;
            button1.Visible = true;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button2.Visible = true;
            button7.Visible = true;
            comboBox2.Visible = true;
            label2.Visible = true;
            button1.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button2.Visible = true;
            button7.Visible = true;
            textBox1.Visible = true;
            label3.Visible = true;
            button1.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (comboBox1.Visible == true)
            {
                if (comboBox1.Text == "")
                {
                    MessageBox.Show("Введите значение для отбора");
                }
                else
                {
                    dataGridView1.DataSource = controller.SelectOne(comboBox1.Text);
                }
            }
            if (comboBox2.Visible == true)
            {
                if (comboBox2.Text == "")
                {
                    MessageBox.Show("Введите значение для отбора");
                }
                else
                {
                    dataGridView1.DataSource = controller.SelectTwo(comboBox2.Text);
                }
            }
            if (textBox1.Visible == true)
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Введите значение для отбора");
                }
                else
                {
                    dataGridView1.DataSource = controller.SelectThree(textBox1.Text);
                }
            }
            if (comboBox4.Visible == true)
            {
                if (comboBox4.Text == "")
                {
                    MessageBox.Show("Введите значение для отбора");
                }
                else
                {
                    dataGridView1.DataSource = controller.SelectFour(comboBox4.Text);
                }
            }
        }

        private void FormОтчёты_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "касса_ЖД_вокзалаDataSet.Вагоны". При необходимости она может быть перемещена или удалена.
            this.вагоныTableAdapter.Fill(this.касса_ЖД_вокзалаDataSet.Вагоны);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "касса_ЖД_вокзалаDataSet.Поезда". При необходимости она может быть перемещена или удалена.
            this.поездаTableAdapter.Fill(this.касса_ЖД_вокзалаDataSet.Поезда);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "касса_ЖД_вокзалаDataSet.Адреса". При необходимости она может быть перемещена или удалена.
            this.адресаTableAdapter.Fill(this.касса_ЖД_вокзалаDataSet.Адреса);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "касса_ЖД_вокзалаDataSet.Маршруты". При необходимости она может быть перемещена или удалена.
            this.маршрутыTableAdapter.Fill(this.касса_ЖД_вокзалаDataSet.Маршруты);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Возвратиться к выбору отчета?",
                  "Возврат",
                  MessageBoxButtons.OKCancel,
                  MessageBoxIcon.Warning,
                  MessageBoxDefaultButton.Button3);
            if (dr == DialogResult.OK)
            {
                FormОтчёты formОтчёты = new FormОтчёты();
                this.Dispose();
                formОтчёты.ShowDialog();
            } 
        }
    }
}

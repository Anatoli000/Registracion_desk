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
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;


namespace Касса_БЕЛ_ЖД
{
    public partial class FormTickets : System.Windows.Forms.Form
    {

        Query controller;
        public FormTickets()
        {
            InitializeComponent();
            controller = new Query(ConnectionString.ConnStr);
        }

        private void FormTickets_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "касса_ЖД_вокзалаDataSet.Билеты". При необходимости она может быть перемещена или удалена.
            this.билетыTableAdapter.Fill(this.касса_ЖД_вокзалаDataSet.Билеты);
            //dataGridView1.DataSource = controller.UpdateБилеты();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
          "Открыть окно добавления данных?",
          "Сообщение",
          MessageBoxButtons.YesNo,
          MessageBoxIcon.Information,
          MessageBoxDefaultButton.Button1,
          MessageBoxOptions.DefaultDesktopOnly);
            if (result == DialogResult.Yes)
            {
                Visible = false;
                FormAddTickets ticketsAdd = new FormAddTickets();
                ticketsAdd.Show();
            }
        }

        private void buttonDelet_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Удалить запись?",
                "Удаление",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button3);
            if (dr == DialogResult.OK)
            {
                dataGridView1.AllowUserToDeleteRows = true;
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    dataGridView1.Rows.Remove(row);
                    this.билетыTableAdapter.Update(касса_ЖД_вокзалаDataSet);
                    this.билетыTableAdapter.Fill(this.касса_ЖД_вокзалаDataSet.Билеты);
                }
            }
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Ведите значение для выборки");
            }
            else
            {
                dataGridView1.DataSource = controller.SelectTime(int.Parse(textBox1.Text));
                button1.Visible = true;
            }
        }
        

        private void FormTickets_FormClosed(object sender, FormClosedEventArgs e)
        {
            { Application.Exit(); }
        }
        
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void оНасToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.ShowDialog();
        }

        private void маршрутыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddМаршруты addМаршруты = new FormAddМаршруты();
            addМаршруты.ShowDialog();
        }

        private void поездаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddПоезда addПоезда = new FormAddПоезда();
            addПоезда.ShowDialog();
        }

        private void вагоныToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddВагоны addВагоны = new FormAddВагоны();
            addВагоны.ShowDialog();
        }

        private void пассажирыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddПассажиры addПассажиры = new FormAddПассажиры();
            addПассажиры.ShowDialog();
        }

        
        private void добавитьПользователяToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        
        private void отчётыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormОтчёты formОтчёты = new FormОтчёты();
            formОтчёты.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = controller.UpdateБилеты();
            
            button1.Visible = false;
        }
    }
}

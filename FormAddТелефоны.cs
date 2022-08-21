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
   
    public partial class FormAddТелефоны : Form
    { 
        Query controller;
        public FormAddТелефоны()
        {
            InitializeComponent();
            controller = new Query(ConnectionString.ConnStr);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text == "")
            {
                MessageBox.Show("Поле номер телефона не заполнено", "Ошибка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);

            }
            else
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
                    controller.AddТелефоны(maskedTextBox1.Text, maskedTextBox2.Text);
                }
            }
        }
        private void FormAddТелефоны_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = controller.UpdateТелефоны();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
       "Удалить телефон?",
       "Внимание",
       MessageBoxButtons.YesNo,
       MessageBoxIcon.Warning,
       MessageBoxDefaultButton.Button1,
       MessageBoxOptions.DefaultDesktopOnly);
            if (result == DialogResult.Yes)
            {
                controller.DeleteТелефоны(int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["ID_телефона"].Value.ToString()));
            }
        }

        private void FormAddТелефоны_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormAddПассажиры addПассажиры = new FormAddПассажиры();
            addПассажиры.Visible = true;
            addПассажиры.Refresh();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text == "")
            {
                MessageBox.Show("Поле номер телефона не заполнено", "Ошибка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);

            }
            else
            {
                DialogResult dr = MessageBox.Show("Сохранить изменения?",
              "Сохранение",
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
                    controller.UpdateTel(maskedTextBox1.Text, Convert.ToInt32(dataGridView1[0, dataGridView1.CurrentCell.RowIndex].Value), maskedTextBox2.Text);
                    maskedTextBox1.Text = "";
                    maskedTextBox2.Text = "";
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Хотите внести изменения?",
           "Изменение",
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
                maskedTextBox1.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["телефон"].Value.ToString();
                maskedTextBox2.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["дополнительный_телефон"].Value.ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e)
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
                maskedTextBox1.Text = "";
                maskedTextBox2.Text = "";
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (button5.Visible ==true)
            { 
                maskedTextBox1.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["телефон"].Value.ToString();
                maskedTextBox2.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["дополнительный_телефон"].Value.ToString();
            }
            
        }
    }
}

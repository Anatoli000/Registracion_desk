using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Касса_БЕЛ_ЖД
{
    public partial class Select : Form
    {
        public Select()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormОтчёты отчёты = new FormОтчёты();
            отчёты.ShowDialog();
        }

        private void Select_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "касса_ЖД_вокзалаDataSet.Пассажиры". При необходимости она может быть перемещена или удалена.
            this.пассажирыTableAdapter.Fill(this.касса_ЖД_вокзалаDataSet.Пассажиры);

        }
    }
}

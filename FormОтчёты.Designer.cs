
namespace Касса_БЕЛ_ЖД
{
    partial class FormОтчёты
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.маршрутыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.касса_ЖД_вокзалаDataSet = new Касса_БЕЛ_ЖД.Касса_ЖД_вокзалаDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.вагоныBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.поездаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.маршрутыTableAdapter = new Касса_БЕЛ_ЖД.Касса_ЖД_вокзалаDataSetTableAdapters.МаршрутыTableAdapter();
            this.адресаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.адресаTableAdapter = new Касса_БЕЛ_ЖД.Касса_ЖД_вокзалаDataSetTableAdapters.АдресаTableAdapter();
            this.поездаTableAdapter = new Касса_БЕЛ_ЖД.Касса_ЖД_вокзалаDataSetTableAdapters.ПоездаTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.вагоныTableAdapter = new Касса_БЕЛ_ЖД.Касса_ЖД_вокзалаDataSetTableAdapters.ВагоныTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.маршрутыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.касса_ЖД_вокзалаDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.вагоныBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.поездаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.адресаBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1069, 300);
            this.dataGridView1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(885, 335);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 86);
            this.button2.TabIndex = 2;
            this.button2.Text = "Выход";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(32, 325);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(193, 105);
            this.button3.TabIndex = 3;
            this.button3.Text = "Отобразить пасажиров ездивших по выбраному маршруту";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(308, 327);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(193, 105);
            this.button4.TabIndex = 4;
            this.button4.Text = "Отобразить маршруты с выбраным типом вагонов, и подсчётом стоимости";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(581, 325);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(193, 107);
            this.button5.TabIndex = 5;
            this.button5.Text = "Отобразить пасажиров проживающих на одной улице";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(859, 325);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(193, 103);
            this.button6.TabIndex = 6;
            this.button6.Text = "Отобразить билеты с определённым типом поезда и подсчётом стоимости с доплатой за" +
    " тип поезда";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(255, 335);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(125, 86);
            this.button7.TabIndex = 7;
            this.button7.Text = "Выполнить";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Visible = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.маршрутыBindingSource;
            this.comboBox1.DisplayMember = "Наименование_маршрута";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(42, 383);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(153, 21);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.Visible = false;
            // 
            // маршрутыBindingSource
            // 
            this.маршрутыBindingSource.DataMember = "Маршруты";
            this.маршрутыBindingSource.DataSource = this.касса_ЖД_вокзалаDataSet;
            // 
            // касса_ЖД_вокзалаDataSet
            // 
            this.касса_ЖД_вокзалаDataSet.DataSetName = "Касса_ЖД_вокзалаDataSet";
            this.касса_ЖД_вокзалаDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 348);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Выбирите наименование маршрута";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 350);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Выберите тип вагона";
            this.label2.Visible = false;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.вагоныBindingSource;
            this.comboBox2.DisplayMember = "тип_вагона";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(43, 383);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(162, 21);
            this.comboBox2.TabIndex = 10;
            this.comboBox2.Visible = false;
            // 
            // вагоныBindingSource
            // 
            this.вагоныBindingSource.DataMember = "Вагоны";
            this.вагоныBindingSource.DataSource = this.касса_ЖД_вокзалаDataSet;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 350);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Введите название улицы";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 350);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Выберите тип поезда";
            this.label4.Visible = false;
            // 
            // comboBox4
            // 
            this.comboBox4.DataSource = this.поездаBindingSource;
            this.comboBox4.DisplayMember = "тип_поезда";
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(41, 384);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(164, 21);
            this.comboBox4.TabIndex = 14;
            this.comboBox4.Visible = false;
            // 
            // поездаBindingSource
            // 
            this.поездаBindingSource.DataMember = "Поезда";
            this.поездаBindingSource.DataSource = this.касса_ЖД_вокзалаDataSet;
            // 
            // маршрутыTableAdapter
            // 
            this.маршрутыTableAdapter.ClearBeforeFill = true;
            // 
            // адресаBindingSource
            // 
            this.адресаBindingSource.DataMember = "Адреса";
            this.адресаBindingSource.DataSource = this.касса_ЖД_вокзалаDataSet;
            // 
            // адресаTableAdapter
            // 
            this.адресаTableAdapter.ClearBeforeFill = true;
            // 
            // поездаTableAdapter
            // 
            this.поездаTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(41, 384);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(166, 20);
            this.textBox1.TabIndex = 16;
            this.textBox1.Visible = false;
            // 
            // вагоныTableAdapter
            // 
            this.вагоныTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(556, 335);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 86);
            this.button1.TabIndex = 17;
            this.button1.Text = "Возврат";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormОтчёты
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 438);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormОтчёты";
            this.Text = "Отчёт";
            this.Load += new System.EventHandler(this.FormОтчёты_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.маршрутыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.касса_ЖД_вокзалаDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.вагоныBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.поездаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.адресаBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox4;
        private Касса_ЖД_вокзалаDataSet касса_ЖД_вокзалаDataSet;
        private System.Windows.Forms.BindingSource маршрутыBindingSource;
        private Касса_ЖД_вокзалаDataSetTableAdapters.МаршрутыTableAdapter маршрутыTableAdapter;
        private System.Windows.Forms.BindingSource адресаBindingSource;
        private Касса_ЖД_вокзалаDataSetTableAdapters.АдресаTableAdapter адресаTableAdapter;
        private System.Windows.Forms.BindingSource поездаBindingSource;
        private Касса_ЖД_вокзалаDataSetTableAdapters.ПоездаTableAdapter поездаTableAdapter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.BindingSource вагоныBindingSource;
        private Касса_ЖД_вокзалаDataSetTableAdapters.ВагоныTableAdapter вагоныTableAdapter;
        private System.Windows.Forms.Button button1;
    }
}
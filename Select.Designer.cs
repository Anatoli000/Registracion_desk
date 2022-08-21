
namespace Касса_БЕЛ_ЖД
{
    partial class Select
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
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.касса_ЖД_вокзалаDataSet = new Касса_БЕЛ_ЖД.Касса_ЖД_вокзалаDataSet();
            this.пассажирыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.пассажирыTableAdapter = new Касса_БЕЛ_ЖД.Касса_ЖД_вокзалаDataSetTableAdapters.ПассажирыTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.касса_ЖД_вокзалаDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.пассажирыBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Выберите  фамилию пассажира";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(47, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 48);
            this.button1.TabIndex = 2;
            this.button1.Text = "Выполнить запрос";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(248, 93);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 48);
            this.button2.TabIndex = 3;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(244, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Запрос отображающий все поездки пасажира";
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.пассажирыBindingSource, "фамилия", true));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(121, 66);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // касса_ЖД_вокзалаDataSet
            // 
            this.касса_ЖД_вокзалаDataSet.DataSetName = "Касса_ЖД_вокзалаDataSet";
            this.касса_ЖД_вокзалаDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // пассажирыBindingSource
            // 
            this.пассажирыBindingSource.DataMember = "Пассажиры";
            this.пассажирыBindingSource.DataSource = this.касса_ЖД_вокзалаDataSet;
            // 
            // пассажирыTableAdapter
            // 
            this.пассажирыTableAdapter.ClearBeforeFill = true;
            // 
            // Select
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 166);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Name = "Select";
            this.Text = "Запрос";
            this.Load += new System.EventHandler(this.Select_Load);
            ((System.ComponentModel.ISupportInitialize)(this.касса_ЖД_вокзалаDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.пассажирыBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private Касса_ЖД_вокзалаDataSet касса_ЖД_вокзалаDataSet;
        private System.Windows.Forms.BindingSource пассажирыBindingSource;
        private Касса_ЖД_вокзалаDataSetTableAdapters.ПассажирыTableAdapter пассажирыTableAdapter;
    }
}
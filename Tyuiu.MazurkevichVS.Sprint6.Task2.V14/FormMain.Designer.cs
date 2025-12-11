namespace Tyuiu.MazurkevichVS.Sprint6.Task2.V14
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            groupBoxDiscript_MVS = new GroupBox();
            textBoxDiscript_MVS = new TextBox();
            groupBoxRes_MVS = new GroupBox();
            dataGridView1 = new DataGridView();
            ColumnForX_MVS = new DataGridViewTextBoxColumn();
            ColumnForFx_MVS = new DataGridViewTextBoxColumn();
            textBoxResNamedOne_MVS = new TextBox();
            groupBoxInput_MVS = new GroupBox();
            ButtonDone_click_MVS = new Button();
            ButtonInfo_MVS = new Button();
            textBoxForEnd_MVS = new TextBox();
            textBoxForStart_MVS = new TextBox();
            textBoxEndInput_MVS = new TextBox();
            textBoxStartInput_MVS = new TextBox();
            chartRes_MVS = new System.Windows.Forms.DataVisualization.Charting.Chart();
            groupBoxDiscript_MVS.SuspendLayout();
            groupBoxRes_MVS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBoxInput_MVS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartRes_MVS).BeginInit();
            SuspendLayout();
            // 
            // groupBoxDiscript_MVS
            // 
            groupBoxDiscript_MVS.Controls.Add(textBoxDiscript_MVS);
            groupBoxDiscript_MVS.Location = new Point(0, 0);
            groupBoxDiscript_MVS.Name = "groupBoxDiscript_MVS";
            groupBoxDiscript_MVS.Size = new Size(538, 347);
            groupBoxDiscript_MVS.TabIndex = 0;
            groupBoxDiscript_MVS.TabStop = false;
            groupBoxDiscript_MVS.Text = "Условие";
            // 
            // textBoxDiscript_MVS
            // 
            textBoxDiscript_MVS.BackColor = SystemColors.Control;
            textBoxDiscript_MVS.BorderStyle = BorderStyle.None;
            textBoxDiscript_MVS.Location = new Point(3, 27);
            textBoxDiscript_MVS.Multiline = true;
            textBoxDiscript_MVS.Name = "textBoxDiscript_MVS";
            textBoxDiscript_MVS.Size = new Size(529, 90);
            textBoxDiscript_MVS.TabIndex = 0;
            textBoxDiscript_MVS.Text = "Протабулировать функцию 5 - 3х + (1 + sin(x))/(2x - 0,5) на заданном диапазоне. Результат вывести в DataGridView и построить график функции.";
            // 
            // groupBoxRes_MVS
            // 
            groupBoxRes_MVS.Controls.Add(chartRes_MVS);
            groupBoxRes_MVS.Controls.Add(dataGridView1);
            groupBoxRes_MVS.Controls.Add(textBoxResNamedOne_MVS);
            groupBoxRes_MVS.Location = new Point(544, 0);
            groupBoxRes_MVS.Name = "groupBoxRes_MVS";
            groupBoxRes_MVS.Size = new Size(640, 472);
            groupBoxRes_MVS.TabIndex = 0;
            groupBoxRes_MVS.TabStop = false;
            groupBoxRes_MVS.Text = "Вывод данных";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColumnForX_MVS, ColumnForFx_MVS });
            dataGridView1.Location = new Point(6, 63);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(103, 403);
            dataGridView1.TabIndex = 2;
            // 
            // ColumnForX_MVS
            // 
            ColumnForX_MVS.HeaderText = "X";
            ColumnForX_MVS.MinimumWidth = 8;
            ColumnForX_MVS.Name = "ColumnForX_MVS";
            ColumnForX_MVS.ReadOnly = true;
            ColumnForX_MVS.Width = 50;
            // 
            // ColumnForFx_MVS
            // 
            ColumnForFx_MVS.HeaderText = "F(x)";
            ColumnForFx_MVS.MinimumWidth = 8;
            ColumnForFx_MVS.Name = "ColumnForFx_MVS";
            ColumnForFx_MVS.ReadOnly = true;
            ColumnForFx_MVS.Width = 50;
            // 
            // textBoxResNamedOne_MVS
            // 
            textBoxResNamedOne_MVS.BackColor = SystemColors.Control;
            textBoxResNamedOne_MVS.BorderStyle = BorderStyle.None;
            textBoxResNamedOne_MVS.Location = new Point(6, 27);
            textBoxResNamedOne_MVS.Name = "textBoxResNamedOne_MVS";
            textBoxResNamedOne_MVS.Size = new Size(150, 24);
            textBoxResNamedOne_MVS.TabIndex = 1;
            textBoxResNamedOne_MVS.Text = "Результат:";
            // 
            // groupBoxInput_MVS
            // 
            groupBoxInput_MVS.Controls.Add(ButtonDone_click_MVS);
            groupBoxInput_MVS.Controls.Add(ButtonInfo_MVS);
            groupBoxInput_MVS.Controls.Add(textBoxForEnd_MVS);
            groupBoxInput_MVS.Controls.Add(textBoxForStart_MVS);
            groupBoxInput_MVS.Controls.Add(textBoxEndInput_MVS);
            groupBoxInput_MVS.Controls.Add(textBoxStartInput_MVS);
            groupBoxInput_MVS.Location = new Point(0, 353);
            groupBoxInput_MVS.Name = "groupBoxInput_MVS";
            groupBoxInput_MVS.Size = new Size(538, 119);
            groupBoxInput_MVS.TabIndex = 0;
            groupBoxInput_MVS.TabStop = false;
            groupBoxInput_MVS.Text = "Ввод данных";
            // 
            // ButtonDone_click_MVS
            // 
            ButtonDone_click_MVS.BackColor = Color.LightGreen;
            ButtonDone_click_MVS.Location = new Point(396, 30);
            ButtonDone_click_MVS.Name = "ButtonDone_click_MVS";
            ButtonDone_click_MVS.Size = new Size(136, 71);
            ButtonDone_click_MVS.TabIndex = 7;
            ButtonDone_click_MVS.Text = "Выполнить";
            ButtonDone_click_MVS.UseVisualStyleBackColor = false;
            ButtonDone_click_MVS.Click += new System.EventHandler(this.ButtonDone_click_MVS_Click);
            // 
            // ButtonInfo_MVS
            // 
            ButtonInfo_MVS.BackColor = Color.SandyBrown;
            ButtonInfo_MVS.Location = new Point(292, 30);
            ButtonInfo_MVS.Name = "ButtonInfo_MVS";
            ButtonInfo_MVS.Size = new Size(98, 71);
            ButtonInfo_MVS.TabIndex = 6;
            ButtonInfo_MVS.Text = "Справка";
            ButtonInfo_MVS.UseVisualStyleBackColor = false;
            ButtonInfo_MVS.Click += new System.EventHandler(this.ButtonInfo_MVS_Click);
            // 
            // textBoxForEnd_MVS
            // 
            textBoxForEnd_MVS.Location = new Point(159, 60);
            textBoxForEnd_MVS.Name = "textBoxForEnd_MVS";
            textBoxForEnd_MVS.Size = new Size(127, 31);
            textBoxForEnd_MVS.TabIndex = 5;
            // 
            // textBoxForStart_MVS
            // 
            textBoxForStart_MVS.Location = new Point(12, 60);
            textBoxForStart_MVS.Name = "textBoxForStart_MVS";
            textBoxForStart_MVS.Size = new Size(127, 31);
            textBoxForStart_MVS.TabIndex = 4;
            // 
            // textBoxEndInput_MVS
            // 
            textBoxEndInput_MVS.BackColor = SystemColors.Control;
            textBoxEndInput_MVS.BorderStyle = BorderStyle.None;
            textBoxEndInput_MVS.Location = new Point(159, 30);
            textBoxEndInput_MVS.Name = "textBoxEndInput_MVS";
            textBoxEndInput_MVS.Size = new Size(150, 24);
            textBoxEndInput_MVS.TabIndex = 3;
            textBoxEndInput_MVS.Text = "Конец шага:";
            // 
            // textBoxStartInput_MVS
            // 
            textBoxStartInput_MVS.BackColor = SystemColors.Control;
            textBoxStartInput_MVS.BorderStyle = BorderStyle.None;
            textBoxStartInput_MVS.Location = new Point(12, 30);
            textBoxStartInput_MVS.Name = "textBoxStartInput_MVS";
            textBoxStartInput_MVS.Size = new Size(150, 24);
            textBoxStartInput_MVS.TabIndex = 2;
            textBoxStartInput_MVS.Text = "Старт шага:";
            // 
            // chartRes_MVS
            // 
            chartArea1.Name = "ChartArea1";
            chartRes_MVS.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartRes_MVS.Legends.Add(legend1);
            chartRes_MVS.Location = new Point(115, 30);
            chartRes_MVS.Name = "chartRes_MVS";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartRes_MVS.Series.Add(series1);
            chartRes_MVS.Size = new Size(665, 436);
            chartRes_MVS.TabIndex = 3;
            chartRes_MVS.Text = "chart1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1196, 484);
            Controls.Add(groupBoxInput_MVS);
            Controls.Add(groupBoxRes_MVS);
            Controls.Add(groupBoxDiscript_MVS);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 2 | Вариант 14 | Мазуркевич В.С.";
            groupBoxDiscript_MVS.ResumeLayout(false);
            groupBoxDiscript_MVS.PerformLayout();
            groupBoxRes_MVS.ResumeLayout(false);
            groupBoxRes_MVS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBoxInput_MVS.ResumeLayout(false);
            groupBoxInput_MVS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartRes_MVS).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxDiscript_MVS;
        private TextBox textBoxDiscript_MVS;
        private GroupBox groupBoxRes_MVS;
        private TextBox textBoxResNamedOne_MVS;
        private GroupBox groupBoxInput_MVS;
        private TextBox textBoxEndInput_MVS;
        private TextBox textBoxStartInput_MVS;
        private Button ButtonInfo_MVS;
        private TextBox textBoxForEnd_MVS;
        private TextBox textBoxForStart_MVS;
        private Button ButtonDone_click_MVS;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ColumnForX_MVS;
        private DataGridViewTextBoxColumn ColumnForFx_MVS;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRes_MVS;
    }
}

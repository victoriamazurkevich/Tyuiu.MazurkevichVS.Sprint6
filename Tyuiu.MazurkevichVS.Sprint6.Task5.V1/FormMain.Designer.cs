namespace Tyuiu.MazurkevichVS.Sprint6.Task5.V1
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
            buttonInfo_MVS = new Button();
            buttonOpenFile_MVS = new Button();
            buttonDone_MVS = new Button();
            textBoxDiscript_MVS = new TextBox();
            groupBoxRes_MVS = new GroupBox();
            chartRes_MVS = new System.Windows.Forms.DataVisualization.Charting.Chart();
            dataGridViewRes_MVS = new DataGridView();
            groupBoxDiscript_MVS.SuspendLayout();
            groupBoxRes_MVS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartRes_MVS).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRes_MVS).BeginInit();
            SuspendLayout();
            // 
            // groupBoxDiscript_MVS
            // 
            groupBoxDiscript_MVS.Controls.Add(buttonInfo_MVS);
            groupBoxDiscript_MVS.Controls.Add(buttonOpenFile_MVS);
            groupBoxDiscript_MVS.Controls.Add(buttonDone_MVS);
            groupBoxDiscript_MVS.Controls.Add(textBoxDiscript_MVS);
            groupBoxDiscript_MVS.Location = new Point(0, 0);
            groupBoxDiscript_MVS.Name = "groupBoxDiscript_MVS";
            groupBoxDiscript_MVS.Size = new Size(992, 138);
            groupBoxDiscript_MVS.TabIndex = 0;
            groupBoxDiscript_MVS.TabStop = false;
            groupBoxDiscript_MVS.Text = "Условие";
            // 
            // buttonInfo_MVS
            // 
            buttonInfo_MVS.BackColor = Color.DeepSkyBlue;
            buttonInfo_MVS.Location = new Point(868, 30);
            buttonInfo_MVS.Name = "buttonInfo_MVS";
            buttonInfo_MVS.Size = new Size(112, 102);
            buttonInfo_MVS.TabIndex = 5;
            buttonInfo_MVS.Text = "Справка";
            buttonInfo_MVS.UseVisualStyleBackColor = false;
            buttonInfo_MVS.Click += buttonInfo_MVS_Click;
            // 
            // buttonOpenFile_MVS
            // 
            buttonOpenFile_MVS.BackColor = Color.Orchid;
            buttonOpenFile_MVS.Location = new Point(616, 30);
            buttonOpenFile_MVS.Name = "buttonOpenFile_MVS";
            buttonOpenFile_MVS.Size = new Size(186, 102);
            buttonOpenFile_MVS.TabIndex = 4;
            buttonOpenFile_MVS.Text = "Открыть Файл";
            buttonOpenFile_MVS.UseVisualStyleBackColor = false;
            buttonOpenFile_MVS.Click += buttonOpenFile_MVS_Click;
            // 
            // buttonDone_MVS
            // 
            buttonDone_MVS.BackColor = Color.SpringGreen;
            buttonDone_MVS.Location = new Point(409, 30);
            buttonDone_MVS.Name = "buttonDone_MVS";
            buttonDone_MVS.Size = new Size(201, 102);
            buttonDone_MVS.TabIndex = 3;
            buttonDone_MVS.Text = "Выполнить";
            buttonDone_MVS.UseVisualStyleBackColor = false;
            buttonDone_MVS.Click += buttonDone_MVS_Click;
            // 
            // textBoxDiscript_MVS
            // 
            textBoxDiscript_MVS.BackColor = SystemColors.Control;
            textBoxDiscript_MVS.BorderStyle = BorderStyle.None;
            textBoxDiscript_MVS.Location = new Point(6, 30);
            textBoxDiscript_MVS.Multiline = true;
            textBoxDiscript_MVS.Name = "textBoxDiscript_MVS";
            textBoxDiscript_MVS.Size = new Size(397, 108);
            textBoxDiscript_MVS.TabIndex = 2;
            textBoxDiscript_MVS.Text = "Прочитать данные из файла InPutDataFileTask5V1.txt. Вывести положительные значения в dataGridView и построить функцию.\r\n";
            // 
            // groupBoxRes_MVS
            // 
            groupBoxRes_MVS.Controls.Add(chartRes_MVS);
            groupBoxRes_MVS.Controls.Add(dataGridViewRes_MVS);
            groupBoxRes_MVS.Location = new Point(6, 144);
            groupBoxRes_MVS.Name = "groupBoxRes_MVS";
            groupBoxRes_MVS.Size = new Size(986, 525);
            groupBoxRes_MVS.TabIndex = 0;
            groupBoxRes_MVS.TabStop = false;
            groupBoxRes_MVS.Text = "Вывод";
            // 
            // chartRes_MVS
            // 
            chartArea1.Name = "ChartArea1";
            chartRes_MVS.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartRes_MVS.Legends.Add(legend1);
            chartRes_MVS.Location = new Point(186, 27);
            chartRes_MVS.Name = "chartRes_MVS";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartRes_MVS.Series.Add(series1);
            chartRes_MVS.Size = new Size(788, 492);
            chartRes_MVS.TabIndex = 1;
            chartRes_MVS.Text = "chart1";
            // 
            // dataGridViewRes_MVS
            // 
            dataGridViewRes_MVS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRes_MVS.Location = new Point(6, 27);
            dataGridViewRes_MVS.Name = "dataGridViewRes_MVS";
            dataGridViewRes_MVS.RowHeadersWidth = 62;
            dataGridViewRes_MVS.Size = new Size(160, 492);
            dataGridViewRes_MVS.TabIndex = 0;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(992, 672);
            Controls.Add(groupBoxRes_MVS);
            Controls.Add(groupBoxDiscript_MVS);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 5 | Вариант 1 | Мазуркевич В.С.";
            groupBoxDiscript_MVS.ResumeLayout(false);
            groupBoxDiscript_MVS.PerformLayout();
            groupBoxRes_MVS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartRes_MVS).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRes_MVS).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxDiscript_MVS;
        private TextBox textBoxDiscript_MVS;
        private GroupBox groupBoxRes_MVS;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRes_MVS;
        private DataGridView dataGridViewRes_MVS;
        private Button buttonInfo_MVS;
        private Button buttonOpenFile_MVS;
        private Button buttonDone_MVS;
    }
}

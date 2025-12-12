namespace Tyuiu.MazurkevichVS.Sprint6.Task4.V7
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            groupBoxdiscript_MVS = new GroupBox();
            textBoxDiscript_MVS = new TextBox();
            groupBoxInput_MVS = new GroupBox();
            buttonInfo_MVS = new Button();
            buttonSave_MVS = new Button();
            button1 = new Button();
            textBoxForEnd_MVS = new TextBox();
            textBoxForSTart_MVS = new TextBox();
            textBoxInputEnd_MVS = new TextBox();
            textBoxInputSTart_MVS = new TextBox();
            groupBoxRes_MVS = new GroupBox();
            textBoxResult_MVS = new TextBox();
            chartResult_MVS = new System.Windows.Forms.DataVisualization.Charting.Chart();
            groupBoxdiscript_MVS.SuspendLayout();
            groupBoxInput_MVS.SuspendLayout();
            groupBoxRes_MVS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartResult_MVS).BeginInit();
            SuspendLayout();
            // 
            // groupBoxdiscript_MVS
            // 
            groupBoxdiscript_MVS.Controls.Add(textBoxDiscript_MVS);
            groupBoxdiscript_MVS.Location = new Point(0, 0);
            groupBoxdiscript_MVS.Name = "groupBoxdiscript_MVS";
            groupBoxdiscript_MVS.Size = new Size(451, 116);
            groupBoxdiscript_MVS.TabIndex = 0;
            groupBoxdiscript_MVS.TabStop = false;
            groupBoxdiscript_MVS.Text = "Условие";
            // 
            // textBoxDiscript_MVS
            // 
            textBoxDiscript_MVS.BackColor = SystemColors.Control;
            textBoxDiscript_MVS.BorderStyle = BorderStyle.None;
            textBoxDiscript_MVS.Location = new Point(6, 30);
            textBoxDiscript_MVS.Multiline = true;
            textBoxDiscript_MVS.Name = "textBoxDiscript_MVS";
            textBoxDiscript_MVS.Size = new Size(445, 76);
            textBoxDiscript_MVS.TabIndex = 2;
            textBoxDiscript_MVS.Text = "Протабулировать функцию cos(x) + cos(x)/(x+2) - 3x на заданном диапазоне от -5 до 5\r\n, построить график функции и сохранить в файл OutPutFileTask4V7.txt\r\n";
            // 
            // groupBoxInput_MVS
            // 
            groupBoxInput_MVS.Controls.Add(buttonInfo_MVS);
            groupBoxInput_MVS.Controls.Add(buttonSave_MVS);
            groupBoxInput_MVS.Controls.Add(button1);
            groupBoxInput_MVS.Controls.Add(textBoxForEnd_MVS);
            groupBoxInput_MVS.Controls.Add(textBoxForSTart_MVS);
            groupBoxInput_MVS.Controls.Add(textBoxInputEnd_MVS);
            groupBoxInput_MVS.Controls.Add(textBoxInputSTart_MVS);
            groupBoxInput_MVS.Location = new Point(457, 0);
            groupBoxInput_MVS.Name = "groupBoxInput_MVS";
            groupBoxInput_MVS.Size = new Size(755, 116);
            groupBoxInput_MVS.TabIndex = 0;
            groupBoxInput_MVS.TabStop = false;
            groupBoxInput_MVS.Text = "Ввод";
            // 
            // buttonInfo_MVS
            // 
            buttonInfo_MVS.BackColor = Color.SkyBlue;
            buttonInfo_MVS.Location = new Point(637, 27);
            buttonInfo_MVS.Name = "buttonInfo_MVS";
            buttonInfo_MVS.Size = new Size(112, 79);
            buttonInfo_MVS.TabIndex = 7;
            buttonInfo_MVS.Text = "Справка";
            buttonInfo_MVS.UseVisualStyleBackColor = false;
            buttonInfo_MVS.Click += new System.EventHandler(this.buttonInfo_MVS_Click);
            // 
            // buttonSave_MVS
            // 
            buttonSave_MVS.BackColor = Color.SpringGreen;
            buttonSave_MVS.Location = new Point(417, 27);
            buttonSave_MVS.Name = "buttonSave_MVS";
            buttonSave_MVS.Size = new Size(112, 79);
            buttonSave_MVS.TabIndex = 6;
            buttonSave_MVS.Text = "Сохранить";
            buttonSave_MVS.UseVisualStyleBackColor = false;
            buttonSave_MVS.Click += new System.EventHandler(this.buttonSave_MVS_Click);
            // 
            // button1
            // 
            button1.BackColor = Color.Green;
            button1.Location = new Point(299, 27);
            button1.Name = "button1";
            button1.Size = new Size(112, 79);
            button1.TabIndex = 5;
            button1.Text = "Выполнить";
            button1.UseVisualStyleBackColor = false;
            button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxForEnd_MVS
            // 
            textBoxForEnd_MVS.Location = new Point(165, 57);
            textBoxForEnd_MVS.Name = "textBoxForEnd_MVS";
            textBoxForEnd_MVS.Size = new Size(119, 31);
            textBoxForEnd_MVS.TabIndex = 3;
            // 
            // textBoxForSTart_MVS
            // 
            textBoxForSTart_MVS.Location = new Point(9, 57);
            textBoxForSTart_MVS.Name = "textBoxForSTart_MVS";
            textBoxForSTart_MVS.Size = new Size(119, 31);
            textBoxForSTart_MVS.TabIndex = 2;
            // 
            // textBoxInputEnd_MVS
            // 
            textBoxInputEnd_MVS.BackColor = SystemColors.Control;
            textBoxInputEnd_MVS.BorderStyle = BorderStyle.None;
            textBoxInputEnd_MVS.Location = new Point(165, 27);
            textBoxInputEnd_MVS.Name = "textBoxInputEnd_MVS";
            textBoxInputEnd_MVS.Size = new Size(150, 24);
            textBoxInputEnd_MVS.TabIndex = 1;
            textBoxInputEnd_MVS.Text = "Конец шага:";
            // 
            // textBoxInputSTart_MVS
            // 
            textBoxInputSTart_MVS.BackColor = SystemColors.Control;
            textBoxInputSTart_MVS.BorderStyle = BorderStyle.None;
            textBoxInputSTart_MVS.Location = new Point(9, 27);
            textBoxInputSTart_MVS.Name = "textBoxInputSTart_MVS";
            textBoxInputSTart_MVS.Size = new Size(150, 24);
            textBoxInputSTart_MVS.TabIndex = 0;
            textBoxInputSTart_MVS.Text = "Старт шага:";
            // 
            // groupBoxRes_MVS
            // 
            groupBoxRes_MVS.Controls.Add(textBoxResult_MVS);
            groupBoxRes_MVS.Location = new Point(0, 112);
            groupBoxRes_MVS.Name = "groupBoxRes_MVS";
            groupBoxRes_MVS.Size = new Size(451, 609);
            groupBoxRes_MVS.TabIndex = 1;
            groupBoxRes_MVS.TabStop = false;
            groupBoxRes_MVS.Text = "Вывод";
            // 
            // textBoxResult_MVS
            // 
            textBoxResult_MVS.Location = new Point(6, 30);
            textBoxResult_MVS.Multiline = true;
            textBoxResult_MVS.Name = "textBoxResult_MVS";
            textBoxResult_MVS.ScrollBars = ScrollBars.Vertical;
            textBoxResult_MVS.Size = new Size(439, 573);
            textBoxResult_MVS.TabIndex = 4;
            // 
            // chartResult_MVS
            // 
            chartArea2.Name = "ChartArea1";
            chartResult_MVS.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chartResult_MVS.Legends.Add(legend2);
            chartResult_MVS.Location = new Point(466, 122);
            chartResult_MVS.Name = "chartResult_MVS";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chartResult_MVS.Series.Add(series2);
            chartResult_MVS.Size = new Size(740, 599);
            chartResult_MVS.TabIndex = 0;
            chartResult_MVS.Text = "chart1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1218, 733);
            Controls.Add(chartResult_MVS);
            Controls.Add(groupBoxRes_MVS);
            Controls.Add(groupBoxInput_MVS);
            Controls.Add(groupBoxdiscript_MVS);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 4 | Вариант 7 | Мазуркевич В.С.";
            groupBoxdiscript_MVS.ResumeLayout(false);
            groupBoxdiscript_MVS.PerformLayout();
            groupBoxInput_MVS.ResumeLayout(false);
            groupBoxInput_MVS.PerformLayout();
            groupBoxRes_MVS.ResumeLayout(false);
            groupBoxRes_MVS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartResult_MVS).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxdiscript_MVS;
        private GroupBox groupBoxInput_MVS;
        private GroupBox groupBoxRes_MVS;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResult_MVS;
        private TextBox textBoxDiscript_MVS;
        private TextBox textBoxInputEnd_MVS;
        private TextBox textBoxInputSTart_MVS;
        private Button buttonInfo_MVS;
        private Button buttonSave_MVS;
        private Button button1;
        private TextBox textBoxForEnd_MVS;
        private TextBox textBoxForSTart_MVS;
        private TextBox textBoxResult_MVS;
    }
}

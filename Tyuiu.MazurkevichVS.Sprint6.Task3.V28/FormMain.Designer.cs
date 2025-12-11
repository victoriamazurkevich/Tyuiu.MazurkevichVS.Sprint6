namespace Tyuiu.MazurkevichVS.Sprint6.Task3.V28
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
            groupBoxDiscript_MVS = new GroupBox();
            groupBoxRes_MVS = new GroupBox();
            textBoxDiscript_MVS = new TextBox();
            textBoxResNamedOne_MVS = new TextBox();
            dataGridViewMatrix_MVS = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            ButtonDone_click_MVS = new Button();
            ButtonInfo_MVS = new Button();
            groupBoxDiscript_MVS.SuspendLayout();
            groupBoxRes_MVS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix_MVS).BeginInit();
            SuspendLayout();
            // 
            // groupBoxDiscript_MVS
            // 
            groupBoxDiscript_MVS.Controls.Add(textBoxDiscript_MVS);
            groupBoxDiscript_MVS.Location = new Point(0, 0);
            groupBoxDiscript_MVS.Name = "groupBoxDiscript_MVS";
            groupBoxDiscript_MVS.Size = new Size(483, 416);
            groupBoxDiscript_MVS.TabIndex = 0;
            groupBoxDiscript_MVS.TabStop = false;
            groupBoxDiscript_MVS.Text = "Условие";
            // 
            // groupBoxRes_MVS
            // 
            groupBoxRes_MVS.Controls.Add(ButtonInfo_MVS);
            groupBoxRes_MVS.Controls.Add(ButtonDone_click_MVS);
            groupBoxRes_MVS.Controls.Add(dataGridViewMatrix_MVS);
            groupBoxRes_MVS.Controls.Add(textBoxResNamedOne_MVS);
            groupBoxRes_MVS.Location = new Point(489, 0);
            groupBoxRes_MVS.Name = "groupBoxRes_MVS";
            groupBoxRes_MVS.Size = new Size(283, 416);
            groupBoxRes_MVS.TabIndex = 0;
            groupBoxRes_MVS.TabStop = false;
            groupBoxRes_MVS.Text = "Вывод данных";
            // 
            // textBoxDiscript_MVS
            // 
            textBoxDiscript_MVS.BackColor = SystemColors.Control;
            textBoxDiscript_MVS.BorderStyle = BorderStyle.None;
            textBoxDiscript_MVS.Location = new Point(3, 27);
            textBoxDiscript_MVS.Multiline = true;
            textBoxDiscript_MVS.Name = "textBoxDiscript_MVS";
            textBoxDiscript_MVS.Size = new Size(474, 383);
            textBoxDiscript_MVS.TabIndex = 0;
            textBoxDiscript_MVS.Text = "Дана матрица 5 на 5\r\n\r\n -9   8   9  16 -18\r\n-13 -11 -20 -15  9\r\n 18  13 -12 -15 -11\r\n 10  -2  19  -4 -10\r\n  6 -20  -4  13 -14\r\n\r\nЗаменить четные значения в четвертой строке на 0.\r\n";
            textBoxDiscript_MVS.TextChanged += textBox1_TextChanged;
            // 
            // textBoxResNamedOne_MVS
            // 
            textBoxResNamedOne_MVS.BackColor = SystemColors.Control;
            textBoxResNamedOne_MVS.BorderStyle = BorderStyle.None;
            textBoxResNamedOne_MVS.Location = new Point(0, 30);
            textBoxResNamedOne_MVS.Name = "textBoxResNamedOne_MVS";
            textBoxResNamedOne_MVS.Size = new Size(150, 24);
            textBoxResNamedOne_MVS.TabIndex = 1;
            textBoxResNamedOne_MVS.Text = "Результат:";
            // 
            // dataGridViewMatrix_MVS
            // 
            dataGridViewMatrix_MVS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMatrix_MVS.ColumnHeadersVisible = false;
            dataGridViewMatrix_MVS.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dataGridViewMatrix_MVS.Location = new Point(6, 60);
            dataGridViewMatrix_MVS.Name = "dataGridViewMatrix_MVS";
            dataGridViewMatrix_MVS.RowHeadersVisible = false;
            dataGridViewMatrix_MVS.RowHeadersWidth = 62;
            dataGridViewMatrix_MVS.Size = new Size(255, 248);
            dataGridViewMatrix_MVS.TabIndex = 1;
            // 
            // Column1
            // 
            Column1.HeaderText = "Column1";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.Width = 50;
            // 
            // Column2
            // 
            Column2.HeaderText = "Column2";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.Width = 50;
            // 
            // Column3
            // 
            Column3.HeaderText = "Column3";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.Width = 50;
            // 
            // Column4
            // 
            Column4.HeaderText = "Column4";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            Column4.Width = 50;
            // 
            // Column5
            // 
            Column5.HeaderText = "Column5";
            Column5.MinimumWidth = 8;
            Column5.Name = "Column5";
            Column5.Width = 50;
            // 
            // ButtonDone_click_MVS
            // 
            ButtonDone_click_MVS.BackColor = Color.GreenYellow;
            ButtonDone_click_MVS.Location = new Point(79, 324);
            ButtonDone_click_MVS.Name = "ButtonDone_click_MVS";
            ButtonDone_click_MVS.Size = new Size(182, 77);
            ButtonDone_click_MVS.TabIndex = 2;
            ButtonDone_click_MVS.Text = "Выполнить";
            ButtonDone_click_MVS.UseVisualStyleBackColor = false;
            ButtonDone_click_MVS.Click += new System.EventHandler(this.ButtonDone_click_MVS_Click);
            // 
            // ButtonInfo_MVS
            // 
            ButtonInfo_MVS.Location = new Point(10, 324);
            ButtonInfo_MVS.Name = "ButtonInfo_MVS";
            ButtonInfo_MVS.Size = new Size(63, 77);
            ButtonInfo_MVS.TabIndex = 3;
            ButtonInfo_MVS.Text = "?";
            ButtonInfo_MVS.UseVisualStyleBackColor = true;
            ButtonInfo_MVS.Click += new System.EventHandler(this.ButtonInfo_MVS_Click);
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(785, 428);
            Controls.Add(groupBoxRes_MVS);
            Controls.Add(groupBoxDiscript_MVS);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 3 | Вариант 28 | Мазуркевич В.С.";
            Load += FormMain_Load;
            groupBoxDiscript_MVS.ResumeLayout(false);
            groupBoxDiscript_MVS.PerformLayout();
            groupBoxRes_MVS.ResumeLayout(false);
            groupBoxRes_MVS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix_MVS).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxDiscript_MVS;
        private TextBox textBoxDiscript_MVS;
        private GroupBox groupBoxRes_MVS;
        private TextBox textBoxResNamedOne_MVS;
        private DataGridView dataGridViewMatrix_MVS;
        private Button ButtonInfo_MVS;
        private Button ButtonDone_click_MVS;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
    }
}

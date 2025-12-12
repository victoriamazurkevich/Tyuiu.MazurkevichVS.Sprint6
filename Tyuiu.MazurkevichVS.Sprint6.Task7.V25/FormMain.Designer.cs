namespace Tyuiu.MazurkevichVS.Sprint6.Task7.V25
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            groupBoxDiscript_MVS = new GroupBox();
            textBoxDiscript_MVS = new TextBox();
            buttonLoad_MVS = new Button();
            buttonPush_MVS = new Button();
            buttonSave_MVS = new Button();
            buttonInfo_MVS = new Button();
            groupBoxInput_MVS = new GroupBox();
            dataGridViewInput_MVS = new DataGridView();
            groupBoxRes_MVS = new GroupBox();
            dataGridViewRes_MVS = new DataGridView();
            toolTipLoad_MVS = new ToolTip(components);
            toolTipPush_MVS = new ToolTip(components);
            toolTipSave_MVS = new ToolTip(components);
            openFileDialogTask_MVS = new OpenFileDialog();
            toolTipInfo_MVS = new ToolTip(components);
            saveFileDialog_MVS = new SaveFileDialog();
            groupBoxDiscript_MVS.SuspendLayout();
            groupBoxInput_MVS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInput_MVS).BeginInit();
            groupBoxRes_MVS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRes_MVS).BeginInit();
            SuspendLayout();
            // 
            // groupBoxDiscript_MVS
            // 
            groupBoxDiscript_MVS.Controls.Add(textBoxDiscript_MVS);
            groupBoxDiscript_MVS.Location = new Point(0, 110);
            groupBoxDiscript_MVS.Name = "groupBoxDiscript_MVS";
            groupBoxDiscript_MVS.Size = new Size(1053, 113);
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
            textBoxDiscript_MVS.ReadOnly = true;
            textBoxDiscript_MVS.Size = new Size(1044, 80);
            textBoxDiscript_MVS.TabIndex = 0;
            textBoxDiscript_MVS.Text = resources.GetString("textBoxDiscript_MVS.Text");
            // 
            // buttonLoad_MVS
            // 
            buttonLoad_MVS.BackgroundImage = Properties.Resources.folder_page;
            buttonLoad_MVS.BackgroundImageLayout = ImageLayout.Center;
            buttonLoad_MVS.Location = new Point(12, 12);
            buttonLoad_MVS.Name = "buttonLoad_MVS";
            buttonLoad_MVS.Size = new Size(98, 90);
            buttonLoad_MVS.TabIndex = 1;
            toolTipLoad_MVS.SetToolTip(buttonLoad_MVS, "Открыть файл для обработки данных в формате CSV\r\n");
            buttonLoad_MVS.UseVisualStyleBackColor = true;
            buttonLoad_MVS.Click += buttonLoad_MVS_Click;
            // 
            // buttonPush_MVS
            // 
            buttonPush_MVS.BackgroundImage = Properties.Resources.page_white_go;
            buttonPush_MVS.BackgroundImageLayout = ImageLayout.Center;
            buttonPush_MVS.Enabled = false;
            buttonPush_MVS.Location = new Point(125, 12);
            buttonPush_MVS.Name = "buttonPush_MVS";
            buttonPush_MVS.Size = new Size(98, 90);
            buttonPush_MVS.TabIndex = 2;
            toolTipPush_MVS.SetToolTip(buttonPush_MVS, "Выполнить обработку данных");
            buttonPush_MVS.UseVisualStyleBackColor = true;
            buttonPush_MVS.Click += buttonPush_MVS_Click;
            // 
            // buttonSave_MVS
            // 
            buttonSave_MVS.BackgroundImage = Properties.Resources.page_save;
            buttonSave_MVS.BackgroundImageLayout = ImageLayout.Center;
            buttonSave_MVS.Enabled = false;
            buttonSave_MVS.Location = new Point(238, 12);
            buttonSave_MVS.Name = "buttonSave_MVS";
            buttonSave_MVS.Size = new Size(98, 90);
            buttonSave_MVS.TabIndex = 3;
            toolTipSave_MVS.SetToolTip(buttonSave_MVS, "Сохранить обработанные данные в файл в формате CSV");
            buttonSave_MVS.UseVisualStyleBackColor = true;
            buttonSave_MVS.Click += ButtonSave_MVS_Click;
            // 
            // buttonInfo_MVS
            // 
            buttonInfo_MVS.Image = Properties.Resources.help;
            buttonInfo_MVS.Location = new Point(941, 14);
            buttonInfo_MVS.Name = "buttonInfo_MVS";
            buttonInfo_MVS.Size = new Size(98, 90);
            buttonInfo_MVS.TabIndex = 4;
            toolTipInfo_MVS.SetToolTip(buttonInfo_MVS, "Сведение о программе");
            buttonInfo_MVS.UseVisualStyleBackColor = true;
            buttonInfo_MVS.Click += buttonInfo_MVS_Click;
            // 
            // groupBoxInput_MVS
            // 
            groupBoxInput_MVS.Controls.Add(dataGridViewInput_MVS);
            groupBoxInput_MVS.Location = new Point(0, 229);
            groupBoxInput_MVS.Name = "groupBoxInput_MVS";
            groupBoxInput_MVS.Size = new Size(496, 458);
            groupBoxInput_MVS.TabIndex = 1;
            groupBoxInput_MVS.TabStop = false;
            groupBoxInput_MVS.Text = "Ввод:";
            // 
            // dataGridViewInput_MVS
            // 
            dataGridViewInput_MVS.AllowUserToAddRows = false;
            dataGridViewInput_MVS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInput_MVS.Location = new Point(9, 27);
            dataGridViewInput_MVS.Name = "dataGridViewInput_MVS";
            dataGridViewInput_MVS.ReadOnly = true;
            dataGridViewInput_MVS.RowHeadersVisible = false;
            dataGridViewInput_MVS.RowHeadersWidth = 62;
            dataGridViewInput_MVS.Size = new Size(487, 379);
            dataGridViewInput_MVS.TabIndex = 0;
            // 
            // groupBoxRes_MVS
            // 
            groupBoxRes_MVS.Controls.Add(dataGridViewRes_MVS);
            groupBoxRes_MVS.Location = new Point(498, 229);
            groupBoxRes_MVS.Name = "groupBoxRes_MVS";
            groupBoxRes_MVS.Size = new Size(541, 458);
            groupBoxRes_MVS.TabIndex = 2;
            groupBoxRes_MVS.TabStop = false;
            groupBoxRes_MVS.Text = "Вывод:";
            // 
            // dataGridViewRes_MVS
            // 
            dataGridViewRes_MVS.AllowUserToAddRows = false;
            dataGridViewRes_MVS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRes_MVS.Location = new Point(3, 27);
            dataGridViewRes_MVS.Name = "dataGridViewRes_MVS";
            dataGridViewRes_MVS.RowHeadersVisible = false;
            dataGridViewRes_MVS.RowHeadersWidth = 62;
            dataGridViewRes_MVS.Size = new Size(532, 379);
            dataGridViewRes_MVS.TabIndex = 0;
            // 
            // toolTipLoad_MVS
            // 
            toolTipLoad_MVS.ToolTipIcon = ToolTipIcon.Info;
            toolTipLoad_MVS.ToolTipTitle = "Открыть файл";
            // 
            // toolTipPush_MVS
            // 
            toolTipPush_MVS.ToolTipIcon = ToolTipIcon.Info;
            toolTipPush_MVS.ToolTipTitle = "Выполнить";
            // 
            // toolTipSave_MVS
            // 
            toolTipSave_MVS.ToolTipIcon = ToolTipIcon.Info;
            toolTipSave_MVS.ToolTipTitle = "Сохранить в файл";
            // 
            // openFileDialogTask_MVS
            // 
            openFileDialogTask_MVS.FileName = "openFileDialog1";
            // 
            // toolTipInfo_MVS
            // 
            toolTipInfo_MVS.ToolTipIcon = ToolTipIcon.Info;
            toolTipInfo_MVS.ToolTipTitle = "Справка";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1054, 693);
            Controls.Add(groupBoxRes_MVS);
            Controls.Add(groupBoxInput_MVS);
            Controls.Add(buttonInfo_MVS);
            Controls.Add(buttonSave_MVS);
            Controls.Add(buttonPush_MVS);
            Controls.Add(buttonLoad_MVS);
            Controls.Add(groupBoxDiscript_MVS);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 7 | Вариант 25 | Мазуркевич В.С.";
            Load += Form1_Load;
            groupBoxDiscript_MVS.ResumeLayout(false);
            groupBoxDiscript_MVS.PerformLayout();
            groupBoxInput_MVS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewInput_MVS).EndInit();
            groupBoxRes_MVS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewRes_MVS).EndInit();
            ResumeLayout(false);
        }



        #endregion

        private GroupBox groupBoxDiscript_MVS;
        private Button buttonLoad_MVS;
        private Button buttonPush_MVS;
        private Button buttonSave_MVS;
        private Button buttonInfo_MVS;
        private GroupBox groupBoxInput_MVS;
        private GroupBox groupBoxRes_MVS;
        private TextBox textBoxDiscript_MVS;
        private DataGridView dataGridViewInput_MVS;
        private DataGridView dataGridViewRes_MVS;
        private ToolTip toolTipLoad_MVS;
        private OpenFileDialog openFileDialogLoad_MVS;
        private ToolTip toolTipPush_MVS;
        private ToolTip toolTipSave_MVS;
        private OpenFileDialog openFileDialogTask_MVS;
        private ToolTip toolTipInfo_MVS;
        private SaveFileDialog saveFileDialog_MVS;
    }
}
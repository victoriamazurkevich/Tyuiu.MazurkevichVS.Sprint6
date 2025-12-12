namespace Tyuiu.MazurkevichVS.Sprint6.Task6.V8
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
            groupBoxForButtons_MVS = new GroupBox();
            buttonInfo_MVS = new Button();
            buttonPush_MVS = new Button();
            buttonLoad_MVS = new Button();
            groupBoxDiscript_MVS = new GroupBox();
            textBoxDiscript_MVS = new TextBox();
            groupBoxInput_MVS = new GroupBox();
            textBoxInput_MVS = new TextBox();
            groupBoxRes_MVS = new GroupBox();
            textBoxRes_MVS = new TextBox();
            toolTip_MVS = new ToolTip(components);
            openFileDialog_MVS = new OpenFileDialog();
            groupBoxForButtons_MVS.SuspendLayout();
            groupBoxDiscript_MVS.SuspendLayout();
            groupBoxInput_MVS.SuspendLayout();
            groupBoxRes_MVS.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxForButtons_MVS
            // 
            groupBoxForButtons_MVS.Controls.Add(buttonInfo_MVS);
            groupBoxForButtons_MVS.Controls.Add(buttonPush_MVS);
            groupBoxForButtons_MVS.Controls.Add(buttonLoad_MVS);
            groupBoxForButtons_MVS.Location = new Point(0, 0);
            groupBoxForButtons_MVS.Name = "groupBoxForButtons_MVS";
            groupBoxForButtons_MVS.Size = new Size(1056, 103);
            groupBoxForButtons_MVS.TabIndex = 0;
            groupBoxForButtons_MVS.TabStop = false;
            // 
            // buttonInfo_MVS
            // 
            buttonInfo_MVS.BackColor = SystemColors.Control;
            buttonInfo_MVS.BackgroundImage = Properties.Resources.help;
            buttonInfo_MVS.BackgroundImageLayout = ImageLayout.Center;
            buttonInfo_MVS.Location = new Point(962, 20);
            buttonInfo_MVS.Name = "buttonInfo_MVS";
            buttonInfo_MVS.Size = new Size(82, 77);
            buttonInfo_MVS.TabIndex = 5;
            buttonInfo_MVS.UseVisualStyleBackColor = false;
            buttonInfo_MVS.Click += buttonInfo_MVS_Click;
            // 
            // buttonPush_MVS
            // 
            buttonPush_MVS.BackColor = SystemColors.Control;
            buttonPush_MVS.BackgroundImage = Properties.Resources.page_go;
            buttonPush_MVS.BackgroundImageLayout = ImageLayout.Center;
            buttonPush_MVS.Location = new Point(114, 20);
            buttonPush_MVS.Name = "buttonPush_MVS";
            buttonPush_MVS.Size = new Size(82, 77);
            buttonPush_MVS.TabIndex = 4;
            buttonPush_MVS.UseVisualStyleBackColor = false;
            buttonPush_MVS.Click += buttonPush_MVS_Click;
            // 
            // buttonLoad_MVS
            // 
            buttonLoad_MVS.BackColor = SystemColors.Control;
            buttonLoad_MVS.BackgroundImage = Properties.Resources.folder_page;
            buttonLoad_MVS.BackgroundImageLayout = ImageLayout.Center;
            buttonLoad_MVS.Location = new Point(12, 20);
            buttonLoad_MVS.Name = "buttonLoad_MVS";
            buttonLoad_MVS.Size = new Size(82, 77);
            buttonLoad_MVS.TabIndex = 3;
            toolTip_MVS.SetToolTip(buttonLoad_MVS, "Открыть файл\r\nВыберите нужный файл для обработки\r\n");
            buttonLoad_MVS.UseVisualStyleBackColor = false;
            buttonLoad_MVS.Click += buttonLoad_MVS_Click;
            // 
            // groupBoxDiscript_MVS
            // 
            groupBoxDiscript_MVS.Controls.Add(textBoxDiscript_MVS);
            groupBoxDiscript_MVS.Location = new Point(0, 98);
            groupBoxDiscript_MVS.Name = "groupBoxDiscript_MVS";
            groupBoxDiscript_MVS.Size = new Size(1056, 107);
            groupBoxDiscript_MVS.TabIndex = 0;
            groupBoxDiscript_MVS.TabStop = false;
            groupBoxDiscript_MVS.Text = "Условие";
            // 
            // textBoxDiscript_MVS
            // 
            textBoxDiscript_MVS.BackColor = SystemColors.Control;
            textBoxDiscript_MVS.BorderStyle = BorderStyle.None;
            textBoxDiscript_MVS.Location = new Point(6, 30);
            textBoxDiscript_MVS.Multiline = true;
            textBoxDiscript_MVS.Name = "textBoxDiscript_MVS";
            textBoxDiscript_MVS.Size = new Size(1038, 77);
            textBoxDiscript_MVS.TabIndex = 2;
            textBoxDiscript_MVS.Text = resources.GetString("textBoxDiscript_MVS.Text");
            // 
            // groupBoxInput_MVS
            // 
            groupBoxInput_MVS.Controls.Add(textBoxInput_MVS);
            groupBoxInput_MVS.Location = new Point(0, 211);
            groupBoxInput_MVS.Name = "groupBoxInput_MVS";
            groupBoxInput_MVS.Size = new Size(516, 457);
            groupBoxInput_MVS.TabIndex = 0;
            groupBoxInput_MVS.TabStop = false;
            groupBoxInput_MVS.Text = "Ввод данных";
            // 
            // textBoxInput_MVS
            // 
            textBoxInput_MVS.Location = new Point(6, 27);
            textBoxInput_MVS.Multiline = true;
            textBoxInput_MVS.Name = "textBoxInput_MVS";
            textBoxInput_MVS.ScrollBars = ScrollBars.Vertical;
            textBoxInput_MVS.Size = new Size(510, 433);
            textBoxInput_MVS.TabIndex = 1;
            // 
            // groupBoxRes_MVS
            // 
            groupBoxRes_MVS.Controls.Add(textBoxRes_MVS);
            groupBoxRes_MVS.Location = new Point(522, 211);
            groupBoxRes_MVS.Name = "groupBoxRes_MVS";
            groupBoxRes_MVS.Size = new Size(534, 457);
            groupBoxRes_MVS.TabIndex = 0;
            groupBoxRes_MVS.TabStop = false;
            groupBoxRes_MVS.Text = "Вывод данных";
            // 
            // textBoxRes_MVS
            // 
            textBoxRes_MVS.Location = new Point(3, 27);
            textBoxRes_MVS.Multiline = true;
            textBoxRes_MVS.Name = "textBoxRes_MVS";
            textBoxRes_MVS.ScrollBars = ScrollBars.Vertical;
            textBoxRes_MVS.Size = new Size(525, 433);
            textBoxRes_MVS.TabIndex = 0;
            // 
            // toolTip_MVS
            // 
            toolTip_MVS.ToolTipIcon = ToolTipIcon.Info;
            toolTip_MVS.ToolTipTitle = "Подсказка";
            // 
            // openFileDialog_MVS
            // 
            openFileDialog_MVS.FileName = "openFileDialog1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1056, 680);
            Controls.Add(groupBoxRes_MVS);
            Controls.Add(groupBoxInput_MVS);
            Controls.Add(groupBoxDiscript_MVS);
            Controls.Add(groupBoxForButtons_MVS);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 6 | Вариант 8 | Мазуркевич В.С.";
            groupBoxForButtons_MVS.ResumeLayout(false);
            groupBoxDiscript_MVS.ResumeLayout(false);
            groupBoxDiscript_MVS.PerformLayout();
            groupBoxInput_MVS.ResumeLayout(false);
            groupBoxInput_MVS.PerformLayout();
            groupBoxRes_MVS.ResumeLayout(false);
            groupBoxRes_MVS.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxForButtons_MVS;
        private GroupBox groupBoxDiscript_MVS;
        private GroupBox groupBoxInput_MVS;
        private GroupBox groupBoxRes_MVS;
        private TextBox textBoxDiscript_MVS;
        private TextBox textBoxInput_MVS;
        private TextBox textBoxRes_MVS;
        private Button buttonPush_MVS;
        private Button buttonLoad_MVS;
        private Button buttonInfo_MVS;
        private ToolTip toolTip_MVS;
        private OpenFileDialog openFileDialog_MVS;
    }
}

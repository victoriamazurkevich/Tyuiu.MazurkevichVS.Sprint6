namespace Tyuiu.MazurkevichVS.Sprint6.Task0.V22
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            button2 = new Button();
            DiscriptTextBox_MVS = new Label();
            pictureBox1 = new PictureBox();
            groupBoxX_MVS = new GroupBox();
            textBoxForX_MVS = new TextBox();
            BoxWithX_MVS = new Label();
            textRes_MVS = new TextBox();
            groupBoxRes_MVS = new GroupBox();
            resBox_MVS = new Label();
            DiscriptGroupBox_MVS = new GroupBox();
            ButtonInfo_MVS = new Button();
            ButtonDone_click_MVS = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBoxX_MVS.SuspendLayout();
            groupBoxRes_MVS.SuspendLayout();
            DiscriptGroupBox_MVS.SuspendLayout();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(344, 0);
            button2.Margin = new Padding(2, 2, 2, 2);
            button2.Name = "button2";
            button2.Size = new Size(60, 5);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // DiscriptTextBox_MVS
            // 
            DiscriptTextBox_MVS.AutoSize = true;
            DiscriptTextBox_MVS.Location = new Point(10, 38);
            DiscriptTextBox_MVS.Margin = new Padding(2, 0, 2, 0);
            DiscriptTextBox_MVS.Name = "DiscriptTextBox_MVS";
            DiscriptTextBox_MVS.Size = new Size(306, 25);
            DiscriptTextBox_MVS.TabIndex = 5;
            DiscriptTextBox_MVS.Text = "Вычислить выражение по формуле.";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(424, 38);
            pictureBox1.Margin = new Padding(2, 2, 2, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(182, 90);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // groupBoxX_MVS
            // 
            groupBoxX_MVS.Controls.Add(textBoxForX_MVS);
            groupBoxX_MVS.Controls.Add(BoxWithX_MVS);
            groupBoxX_MVS.Location = new Point(46, 313);
            groupBoxX_MVS.Margin = new Padding(2, 2, 2, 2);
            groupBoxX_MVS.Name = "groupBoxX_MVS";
            groupBoxX_MVS.Padding = new Padding(2, 2, 2, 2);
            groupBoxX_MVS.Size = new Size(248, 135);
            groupBoxX_MVS.TabIndex = 7;
            groupBoxX_MVS.TabStop = false;
            groupBoxX_MVS.Text = "Ввод данных";
            // 
            // textBoxForX_MVS
            // 
            textBoxForX_MVS.Location = new Point(10, 84);
            textBoxForX_MVS.Margin = new Padding(2, 2, 2, 2);
            textBoxForX_MVS.Name = "textBoxForX_MVS";
            textBoxForX_MVS.Size = new Size(149, 31);
            textBoxForX_MVS.TabIndex = 1;
            textBoxForX_MVS.KeyPress += textBoxForX_KeyPress;
            // 
            // BoxWithX_MVS
            // 
            BoxWithX_MVS.AutoSize = true;
            BoxWithX_MVS.Location = new Point(10, 38);
            BoxWithX_MVS.Margin = new Padding(2, 0, 2, 0);
            BoxWithX_MVS.Name = "BoxWithX_MVS";
            BoxWithX_MVS.Size = new Size(134, 25);
            BoxWithX_MVS.TabIndex = 0;
            BoxWithX_MVS.Text = "Переменная Х:";
            // 
            // textRes_MVS
            // 
            textRes_MVS.Location = new Point(23, 75);
            textRes_MVS.Margin = new Padding(2, 2, 2, 2);
            textRes_MVS.Multiline = true;
            textRes_MVS.Name = "textRes_MVS";
            textRes_MVS.ReadOnly = true;
            textRes_MVS.Size = new Size(183, 45);
            textRes_MVS.TabIndex = 8;
            textRes_MVS.TextChanged += textRes_MVS_TextChanged;
            // 
            // groupBoxRes_MVS
            // 
            groupBoxRes_MVS.Controls.Add(resBox_MVS);
            groupBoxRes_MVS.Controls.Add(textRes_MVS);
            groupBoxRes_MVS.Location = new Point(417, 313);
            groupBoxRes_MVS.Margin = new Padding(2, 2, 2, 2);
            groupBoxRes_MVS.Name = "groupBoxRes_MVS";
            groupBoxRes_MVS.Padding = new Padding(2, 2, 2, 2);
            groupBoxRes_MVS.Size = new Size(261, 135);
            groupBoxRes_MVS.TabIndex = 9;
            groupBoxRes_MVS.TabStop = false;
            groupBoxRes_MVS.Text = "Вывод данных:";
            // 
            // resBox_MVS
            // 
            resBox_MVS.AutoSize = true;
            resBox_MVS.Location = new Point(23, 38);
            resBox_MVS.Margin = new Padding(2, 0, 2, 0);
            resBox_MVS.Name = "resBox_MVS";
            resBox_MVS.Size = new Size(93, 25);
            resBox_MVS.TabIndex = 9;
            resBox_MVS.Text = "Результат:";
            // 
            // DiscriptGroupBox_MVS
            // 
            DiscriptGroupBox_MVS.Controls.Add(DiscriptTextBox_MVS);
            DiscriptGroupBox_MVS.Controls.Add(pictureBox1);
            DiscriptGroupBox_MVS.Location = new Point(46, 36);
            DiscriptGroupBox_MVS.Margin = new Padding(2, 2, 2, 2);
            DiscriptGroupBox_MVS.Name = "DiscriptGroupBox_MVS";
            DiscriptGroupBox_MVS.Padding = new Padding(2, 2, 2, 2);
            DiscriptGroupBox_MVS.Size = new Size(632, 265);
            DiscriptGroupBox_MVS.TabIndex = 10;
            DiscriptGroupBox_MVS.TabStop = false;
            DiscriptGroupBox_MVS.Text = "Условие";
            // 
            // ButtonInfo_MVS
            // 
            ButtonInfo_MVS.FlatStyle = FlatStyle.Flat;
            ButtonInfo_MVS.Location = new Point(440, 466);
            ButtonInfo_MVS.Margin = new Padding(2, 2, 2, 2);
            ButtonInfo_MVS.Name = "ButtonInfo_MVS";
            ButtonInfo_MVS.Size = new Size(46, 38);
            ButtonInfo_MVS.TabIndex = 11;
            ButtonInfo_MVS.Text = "?";
            ButtonInfo_MVS.UseVisualStyleBackColor = true;
            ButtonInfo_MVS.Click += ButtonInfo_Click;
            // 
            // ButtonDone_click_MVS
            // 
            ButtonDone_click_MVS.FlatStyle = FlatStyle.Flat;
            ButtonDone_click_MVS.Location = new Point(541, 468);
            ButtonDone_click_MVS.Margin = new Padding(2, 2, 2, 2);
            ButtonDone_click_MVS.Name = "ButtonDone_click_MVS";
            ButtonDone_click_MVS.Size = new Size(111, 35);
            ButtonDone_click_MVS.TabIndex = 12;
            ButtonDone_click_MVS.Text = "Выполнить";
            ButtonDone_click_MVS.UseVisualStyleBackColor = true;
            ButtonDone_click_MVS.Click += buttonDone_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(715, 520);
            Controls.Add(ButtonDone_click_MVS);
            Controls.Add(ButtonInfo_MVS);
            Controls.Add(DiscriptGroupBox_MVS);
            Controls.Add(groupBoxRes_MVS);
            Controls.Add(groupBoxX_MVS);
            Controls.Add(button2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2, 2, 2, 2);
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 0 | Вариант 3 | Мазуркевич В.С.";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBoxX_MVS.ResumeLayout(false);
            groupBoxX_MVS.PerformLayout();
            groupBoxRes_MVS.ResumeLayout(false);
            groupBoxRes_MVS.PerformLayout();
            DiscriptGroupBox_MVS.ResumeLayout(false);
            DiscriptGroupBox_MVS.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button button2;
        private Label DiscriptTextBox_MVS;
        private PictureBox pictureBox1;
        private GroupBox groupBoxX_MVS;
        private TextBox textRes_MVS;
        private TextBox textBoxForX_MVS;
        private Label BoxWithX_MVS;
        private GroupBox groupBoxRes_MVS;
        private Label resBox_MVS;
        private GroupBox DiscriptGroupBox_MVS;
        private Button ButtonInfo_MVS;
        private Button ButtonDone_click_MVS;
    }
}
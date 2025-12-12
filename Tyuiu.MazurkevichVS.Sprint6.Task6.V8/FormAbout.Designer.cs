namespace Tyuiu.MazurkevichVS.Sprint6.Task6.V8
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            pictureBoxAbout_MVS = new PictureBox();
            textBoxAbout_MVS = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAbout_MVS).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxAbout_MVS
            // 
            pictureBoxAbout_MVS.Image = Properties.Resources.photo_2025_12_10_23_20_11;
            pictureBoxAbout_MVS.Location = new Point(12, 12);
            pictureBoxAbout_MVS.Name = "pictureBoxAbout_MVS";
            pictureBoxAbout_MVS.Size = new Size(234, 245);
            pictureBoxAbout_MVS.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxAbout_MVS.TabIndex = 0;
            pictureBoxAbout_MVS.TabStop = false;
            // 
            // textBoxAbout_MVS
            // 
            textBoxAbout_MVS.BackColor = SystemColors.Control;
            textBoxAbout_MVS.BorderStyle = BorderStyle.None;
            textBoxAbout_MVS.Location = new Point(252, 12);
            textBoxAbout_MVS.Multiline = true;
            textBoxAbout_MVS.Name = "textBoxAbout_MVS";
            textBoxAbout_MVS.Size = new Size(428, 301);
            textBoxAbout_MVS.TabIndex = 1;
            textBoxAbout_MVS.Text = resources.GetString("textBoxAbout_MVS.Text");
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(681, 311);
            Controls.Add(textBoxAbout_MVS);
            Controls.Add(pictureBoxAbout_MVS);
            Name = "FormAbout";
            Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)pictureBoxAbout_MVS).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxAbout_MVS;
        private TextBox textBoxAbout_MVS;
    }
}
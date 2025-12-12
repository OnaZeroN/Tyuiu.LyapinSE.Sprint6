namespace Tyuiu.LyapinSE.Sprint6.Task0.V23
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            label2 = new Label();
            textBoxVarX = new TextBox();
            groupBox3 = new GroupBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            label3 = new Label();
            textBoxResult = new TextBox();
            buttonDone = new Button();
            buttonInfo = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(628, 19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(117, 63);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBoxVarX);
            groupBox1.Location = new Point(37, 270);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(505, 100);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ввод данных";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 33);
            label2.Name = "label2";
            label2.Size = new Size(89, 15);
            label2.TabIndex = 3;
            label2.Text = "Переменная X:";
            // 
            // textBoxVarX
            // 
            textBoxVarX.Location = new Point(6, 51);
            textBoxVarX.Name = "textBoxVarX";
            textBoxVarX.Size = new Size(127, 23);
            textBoxVarX.TabIndex = 0;
            textBoxVarX.KeyPress += textBoxVarX_KeyPress;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(pictureBox1);
            groupBox3.Location = new Point(37, 39);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(751, 225);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Условие";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(205, 15);
            label1.TabIndex = 0;
            label1.Text = "Вычислить выражение по формуле";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(textBoxResult);
            groupBox2.Location = new Point(548, 270);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(234, 100);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Вывод данных";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 33);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 4;
            label3.Text = "Результат:";
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(6, 51);
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.Size = new Size(222, 23);
            textBoxResult.TabIndex = 4;
            // 
            // buttonDone
            // 
            buttonDone.Location = new Point(601, 376);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(181, 40);
            buttonDone.TabIndex = 5;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            // 
            // buttonInfo
            // 
            buttonInfo.FlatAppearance.BorderColor = Color.Black;
            buttonInfo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonInfo.Location = new Point(548, 376);
            buttonInfo.Name = "buttonInfo";
            buttonInfo.Size = new Size(47, 40);
            buttonInfo.TabIndex = 6;
            buttonInfo.Text = "?";
            buttonInfo.UseVisualStyleBackColor = true;
            buttonInfo.Click += buttonInfo_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(805, 450);
            Controls.Add(buttonInfo);
            Controls.Add(buttonDone);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск0 | Вариант 23 | Ляпин С.Е.";
            Load += FormMain_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private GroupBox groupBox3;
        private Label label1;
        private Label label2;
        private TextBox textBoxVarX;
        private GroupBox groupBox2;
        private Button buttonDone;
        private Button buttonInfo;
        private Label label3;
        private TextBox textBoxResult;
    }
}

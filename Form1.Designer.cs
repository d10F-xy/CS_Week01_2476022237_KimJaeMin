namespace WinFormsApp3
{
    partial class Form1
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = Properties.Resources._240301_메인_프로필_The_Poles_scaled;
            pictureBox1.Location = new Point(34, 54);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(250, 245);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 30F, FontStyle.Bold);
            label1.Location = new Point(358, 70);
            label1.Name = "label1";
            label1.Size = new Size(143, 54);
            label1.TabIndex = 1;
            label1.Text = "김재민";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("맑은 고딕", 15F);
            label2.Location = new Point(365, 146);
            label2.Name = "label2";
            label2.Size = new Size(209, 28);
            label2.TabIndex = 2;
            label2.Text = "수원대 컴퓨터SW학과";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("맑은 고딕", 15F);
            label3.Location = new Point(365, 224);
            label3.Name = "label3";
            label3.Size = new Size(149, 28);
            label3.TabIndex = 3;
            label3.Text = "010-2845-4772";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("맑은 고딕", 15F);
            label4.Location = new Point(365, 185);
            label4.Name = "label4";
            label4.Size = new Size(174, 28);
            label4.TabIndex = 4;
            label4.Text = "f01d_@naver.com";
            // 
            // button1
            // 
            button1.Font = new Font("함초롬돋움", 15F, FontStyle.Regular, GraphicsUnit.Point, 129);
            button1.Location = new Point(494, 311);
            button1.Name = "button1";
            button1.Size = new Size(153, 46);
            button1.TabIndex = 5;
            button1.Text = "배경색 바꾸기";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("함초롬돋움", 12F, FontStyle.Regular, GraphicsUnit.Point, 129);
            button2.Location = new Point(358, 267);
            button2.Name = "button2";
            button2.Size = new Size(102, 32);
            button2.TabIndex = 6;
            button2.Text = "Github";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("함초롬돋움", 17.9999981F, FontStyle.Regular, GraphicsUnit.Point, 129);
            button3.Location = new Point(98, 305);
            button3.Name = "button3";
            button3.Size = new Size(121, 47);
            button3.TabIndex = 7;
            button3.Text = "사진 변경";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(659, 369);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}

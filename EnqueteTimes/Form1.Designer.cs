namespace EnqueteTimes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            corimg = new PictureBox();
            palimg = new PictureBox();
            sanimg = new PictureBox();
            saoimg = new PictureBox();
            resCor = new Label();
            resSao = new Label();
            resSan = new Label();
            resPal = new Label();
            button1 = new Button();
            button2 = new Button();
            infoBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)corimg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)palimg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sanimg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)saoimg).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(318, 9);
            label1.Name = "label1";
            label1.Size = new Size(140, 45);
            label1.TabIndex = 0;
            label1.Text = "Enquete\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(137, 63);
            label2.Name = "label2";
            label2.Size = new Size(485, 25);
            label2.TabIndex = 1;
            label2.Text = "Qual dos quatro grandes clubes de São Paulo você prefere?\r\n";
            // 
            // corimg
            // 
            corimg.Image = (Image)resources.GetObject("corimg.Image");
            corimg.Location = new Point(54, 163);
            corimg.Name = "corimg";
            corimg.Size = new Size(150, 134);
            corimg.SizeMode = PictureBoxSizeMode.StretchImage;
            corimg.TabIndex = 2;
            corimg.TabStop = false;
            corimg.Click += corimg_Click;
            // 
            // palimg
            // 
            palimg.Image = (Image)resources.GetObject("palimg.Image");
            palimg.Location = new Point(231, 163);
            palimg.Name = "palimg";
            palimg.Size = new Size(150, 134);
            palimg.SizeMode = PictureBoxSizeMode.StretchImage;
            palimg.TabIndex = 3;
            palimg.TabStop = false;
            palimg.Click += palimg_Click;
            // 
            // sanimg
            // 
            sanimg.Image = (Image)resources.GetObject("sanimg.Image");
            sanimg.Location = new Point(407, 163);
            sanimg.Name = "sanimg";
            sanimg.Size = new Size(150, 134);
            sanimg.SizeMode = PictureBoxSizeMode.StretchImage;
            sanimg.TabIndex = 4;
            sanimg.TabStop = false;
            sanimg.Click += sanimg_Click;
            // 
            // saoimg
            // 
            saoimg.Image = (Image)resources.GetObject("saoimg.Image");
            saoimg.Location = new Point(582, 163);
            saoimg.Name = "saoimg";
            saoimg.Size = new Size(150, 134);
            saoimg.SizeMode = PictureBoxSizeMode.StretchImage;
            saoimg.TabIndex = 5;
            saoimg.TabStop = false;
            saoimg.Click += saoimg_Click;
            // 
            // resCor
            // 
            resCor.AutoSize = true;
            resCor.Location = new Point(113, 319);
            resCor.Name = "resCor";
            resCor.Size = new Size(22, 25);
            resCor.TabIndex = 6;
            resCor.Text = "0";
            // 
            // resSao
            // 
            resSao.AutoSize = true;
            resSao.Location = new Point(647, 319);
            resSao.Name = "resSao";
            resSao.Size = new Size(22, 25);
            resSao.TabIndex = 7;
            resSao.Text = "0";
            // 
            // resSan
            // 
            resSan.AutoSize = true;
            resSan.Location = new Point(470, 319);
            resSan.Name = "resSan";
            resSan.Size = new Size(22, 25);
            resSan.TabIndex = 8;
            resSan.Text = "0";
            // 
            // resPal
            // 
            resPal.AutoSize = true;
            resPal.Location = new Point(293, 319);
            resPal.Name = "resPal";
            resPal.Size = new Size(22, 25);
            resPal.TabIndex = 9;
            resPal.Text = "0";
            // 
            // button1
            // 
            button1.Location = new Point(420, 379);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 10;
            button1.Text = "Encerrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(246, 379);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 11;
            button2.Text = "Reiniciar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // infoBtn
            // 
            infoBtn.Location = new Point(12, 21);
            infoBtn.Name = "infoBtn";
            infoBtn.Size = new Size(30, 30);
            infoBtn.TabIndex = 12;
            infoBtn.Text = "i";
            infoBtn.UseVisualStyleBackColor = true;
            infoBtn.Click += infoBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(infoBtn);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(resPal);
            Controls.Add(resSan);
            Controls.Add(resSao);
            Controls.Add(resCor);
            Controls.Add(saoimg);
            Controls.Add(sanimg);
            Controls.Add(palimg);
            Controls.Add(corimg);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Enquete dos Clubes";
            ((System.ComponentModel.ISupportInitialize)corimg).EndInit();
            ((System.ComponentModel.ISupportInitialize)palimg).EndInit();
            ((System.ComponentModel.ISupportInitialize)sanimg).EndInit();
            ((System.ComponentModel.ISupportInitialize)saoimg).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private PictureBox corimg;
        private PictureBox palimg;
        private PictureBox sanimg;
        private PictureBox saoimg;
        private Label resCor;
        private Label resSao;
        private Label resSan;
        private Label resPal;
        private Button button1;
        private Button button2;
        private Button infoBtn;
    }
}

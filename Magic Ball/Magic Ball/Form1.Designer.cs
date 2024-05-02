namespace Magic_Ball
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Answer = new System.Windows.Forms.Label();
            this.Question = new System.Windows.Forms.TextBox();
            this.MagicPic = new System.Windows.Forms.PictureBox();
            this.labelP = new System.Windows.Forms.Label();
            this.labelK = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MagicPic)).BeginInit();
            this.SuspendLayout();
            // 
            // Answer
            // 
            this.Answer.AutoSize = true;
            this.Answer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(35)))), ((int)(((byte)(125)))));
            this.Answer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Answer.ForeColor = System.Drawing.Color.White;
            this.Answer.Location = new System.Drawing.Point(224, 197);
            this.Answer.MaximumSize = new System.Drawing.Size(140, 140);
            this.Answer.Name = "Answer";
            this.Answer.Size = new System.Drawing.Size(126, 75);
            this.Answer.TabIndex = 2;
            this.Answer.Text = "ффффффффффффффффф";
            this.Answer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Answer.Visible = false;
            // 
            // Question
            // 
            this.Question.Dock = System.Windows.Forms.DockStyle.Top;
            this.Question.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Question.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Question.Location = new System.Drawing.Point(0, 0);
            this.Question.Name = "Question";
            this.Question.Size = new System.Drawing.Size(572, 26);
            this.Question.TabIndex = 1;
            this.Question.Text = "Задайте свой вопрос и потрясите шар";
            this.Question.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Question.Click += new System.EventHandler(this.Question_Click);
            this.Question.TextChanged += new System.EventHandler(this.Question_TextChanged);
            // 
            // MagicPic
            // 
            this.MagicPic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MagicPic.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MagicPic.Image = global::Magic_Ball.Properties.Resources._8_Ball;
            this.MagicPic.Location = new System.Drawing.Point(0, 28);
            this.MagicPic.Name = "MagicPic";
            this.MagicPic.Size = new System.Drawing.Size(572, 455);
            this.MagicPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MagicPic.TabIndex = 0;
            this.MagicPic.TabStop = false;
            this.MagicPic.Click += new System.EventHandler(this.MagicPic_Click);
            // 
            // labelP
            // 
            this.labelP.AutoSize = true;
            this.labelP.Location = new System.Drawing.Point(25, 407);
            this.labelP.Name = "labelP";
            this.labelP.Size = new System.Drawing.Size(28, 16);
            this.labelP.TabIndex = 3;
            this.labelP.Text = "p = ";
            // 
            // labelK
            // 
            this.labelK.AutoSize = true;
            this.labelK.Location = new System.Drawing.Point(25, 441);
            this.labelK.Name = "labelK";
            this.labelK.Size = new System.Drawing.Size(27, 16);
            this.labelK.TabIndex = 4;
            this.labelK.Text = "k = ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 483);
            this.Controls.Add(this.labelK);
            this.Controls.Add(this.labelP);
            this.Controls.Add(this.Answer);
            this.Controls.Add(this.Question);
            this.Controls.Add(this.MagicPic);
            this.Name = "Form1";
            this.Text = "Magic 8 Ball";
            ((System.ComponentModel.ISupportInitialize)(this.MagicPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox MagicPic;
        private System.Windows.Forms.TextBox Question;
        private System.Windows.Forms.Label Answer;
        private System.Windows.Forms.Label labelP;
        private System.Windows.Forms.Label labelK;
    }
}


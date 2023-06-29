namespace YoketoruCS
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
            components = new System.ComponentModel.Container();
            timer1 = new System.Windows.Forms.Timer(components);
            labelTitle = new Label();
            buttonStart = new Button();
            buttonTitle = new Button();
            labelGmeover = new Label();
            labelclear = new Label();
            tempPlayer = new Label();
            labelHighScore = new Label();
            labelCopyright = new Label();
            tempObstacle = new Label();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 50;
            timer1.Tick += timer1_Tick;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Yu Gothic UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            labelTitle.Location = new Point(306, 90);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(189, 54);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "よけとるCS";
            labelTitle.Click += label1_Click;
            // 
            // buttonStart
            // 
            buttonStart.Location = new Point(349, 234);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(103, 42);
            buttonStart.TabIndex = 1;
            buttonStart.Text = "スタート!!";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += button1_Click;
            // 
            // buttonTitle
            // 
            buttonTitle.Location = new Point(349, 320);
            buttonTitle.Name = "buttonTitle";
            buttonTitle.Size = new Size(103, 39);
            buttonTitle.TabIndex = 2;
            buttonTitle.Text = "タイトルへ";
            buttonTitle.UseVisualStyleBackColor = true;
            buttonTitle.Click += button2_Click;
            // 
            // labelGmeover
            // 
            labelGmeover.AutoSize = true;
            labelGmeover.Font = new Font("Yu Gothic UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            labelGmeover.Location = new Point(284, 162);
            labelGmeover.Name = "labelGmeover";
            labelGmeover.Size = new Size(241, 54);
            labelGmeover.TabIndex = 3;
            labelGmeover.Text = "GAME OVER";
            // 
            // labelclear
            // 
            labelclear.AutoSize = true;
            labelclear.Font = new Font("Yu Gothic UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            labelclear.Location = new Point(317, 128);
            labelclear.Name = "labelclear";
            labelclear.Size = new Size(159, 54);
            labelclear.TabIndex = 4;
            labelclear.Text = "CLEAR!!";
            // 
            // tempPlayer
            // 
            tempPlayer.AutoSize = true;
            tempPlayer.Font = new Font("Yu Gothic UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            tempPlayer.Location = new Point(93, 188);
            tempPlayer.Name = "tempPlayer";
            tempPlayer.Size = new Size(57, 28);
            tempPlayer.TabIndex = 5;
            tempPlayer.Text = "( .    .)";
            // 
            // labelHighScore
            // 
            labelHighScore.AutoSize = true;
            labelHighScore.Font = new Font("Yu Gothic UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            labelHighScore.Location = new Point(349, 22);
            labelHighScore.Name = "labelHighScore";
            labelHighScore.Size = new Size(92, 37);
            labelHighScore.TabIndex = 6;
            labelHighScore.Text = "00000";
            // 
            // labelCopyright
            // 
            labelCopyright.AutoSize = true;
            labelCopyright.Font = new Font("Yu Gothic UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            labelCopyright.Location = new Point(172, 316);
            labelCopyright.Name = "labelCopyright";
            labelCopyright.Size = new Size(30, 25);
            labelCopyright.TabIndex = 7;
            labelCopyright.Text = "☆";
            // 
            // tempObstacle
            // 
            tempObstacle.AutoSize = true;
            tempObstacle.Font = new Font("Yu Gothic UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            tempObstacle.Location = new Point(629, 147);
            tempObstacle.Name = "tempObstacle";
            tempObstacle.Size = new Size(30, 25);
            tempObstacle.TabIndex = 8;
            tempObstacle.Text = "★";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tempObstacle);
            Controls.Add(labelCopyright);
            Controls.Add(labelHighScore);
            Controls.Add(tempPlayer);
            Controls.Add(labelclear);
            Controls.Add(labelGmeover);
            Controls.Add(buttonTitle);
            Controls.Add(buttonStart);
            Controls.Add(labelTitle);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Label labelTitle;
        private Button buttonStart;
        private Button buttonTitle;
        private Label labelGmeover;
        private Label labelclear;
        private Label tempPlayer;
        private Label labelHighScore;
        private Label labelCopyright;
        private Label tempObstacle;
    }
}
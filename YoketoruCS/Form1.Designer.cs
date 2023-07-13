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
            tempItem = new Label();
            tempObstacle = new Label();
            labelCopyright = new Label();
            labelTimer = new Label();
            labelscore = new Label();
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
            labelTitle.ForeColor = Color.Lime;
            labelTitle.Location = new Point(297, 108);
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
            tempPlayer.Location = new Point(121, 154);
            tempPlayer.Name = "tempPlayer";
            tempPlayer.Size = new Size(65, 28);
            tempPlayer.TabIndex = 5;
            tempPlayer.Text = "( .  _  .)";
            // 
            // labelHighScore
            // 
            labelHighScore.AutoSize = true;
            labelHighScore.Font = new Font("Yu Gothic UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            labelHighScore.Location = new Point(313, 61);
            labelHighScore.Name = "labelHighScore";
            labelHighScore.Size = new Size(163, 25);
            labelHighScore.TabIndex = 6;
            labelHighScore.Text = "High Score : 00000";
            // 
            // tempItem
            // 
            tempItem.AutoSize = true;
            tempItem.Font = new Font("Yu Gothic UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            tempItem.ForeColor = Color.Black;
            tempItem.Location = new Point(140, 334);
            tempItem.Name = "tempItem";
            tempItem.Size = new Size(30, 25);
            tempItem.TabIndex = 7;
            tempItem.Text = "☆";
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
            // labelCopyright
            // 
            labelCopyright.AutoSize = true;
            labelCopyright.Location = new Point(349, 405);
            labelCopyright.Name = "labelCopyright";
            labelCopyright.Size = new Size(102, 15);
            labelCopyright.TabIndex = 9;
            labelCopyright.Text = "(c) 2023 sakamoto";
            // 
            // labelTimer
            // 
            labelTimer.AutoSize = true;
            labelTimer.Font = new Font("Yu Gothic UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            labelTimer.Location = new Point(722, 400);
            labelTimer.Name = "labelTimer";
            labelTimer.Size = new Size(66, 41);
            labelTimer.TabIndex = 10;
            labelTimer.Text = "000";
            // 
            // labelscore
            // 
            labelscore.AutoSize = true;
            labelscore.Font = new Font("Yu Gothic UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            labelscore.Location = new Point(349, 9);
            labelscore.Name = "labelscore";
            labelscore.Size = new Size(92, 37);
            labelscore.TabIndex = 11;
            labelscore.Text = "00000";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tempPlayer);
            Controls.Add(labelscore);
            Controls.Add(labelTimer);
            Controls.Add(labelCopyright);
            Controls.Add(tempObstacle);
            Controls.Add(tempItem);
            Controls.Add(labelHighScore);
            Controls.Add(labelclear);
            Controls.Add(labelGmeover);
            Controls.Add(buttonTitle);
            Controls.Add(buttonStart);
            Controls.Add(labelTitle);
            Name = "Form1";
            Text = "form1";
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
        private Label tempItem;
        private Label tempObstacle;
        private Label labelCopyright;
        private Label labelTimer;
        private Label labelscore;
    }
}
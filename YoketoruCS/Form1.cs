using Microsoft.VisualBasic.ApplicationServices;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;

namespace YoketoruCS
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        public static extern short GetAsyncKeyState(int vKey);

        static int ScoreMax => 99999;
        static int SpeedMax = 10;
        static int PointRate => 100;

        static int PlayerMax => 1;
        static int ItemMax => 3;
        static int ObstacleMax => 3;
        static int PlayerIndex => 0;
        static int ObstacleIndex => PlayerIndex + PlayerMax;
        static int ItemIndex => ObstacleIndex + ObstacleMax;
        static int LabelMax => ItemIndex + ItemMax;
        Label[] chrLabels = new Label[LabelMax];
        int itemCount;

        int[] vx = new int[LabelMax];
        int[] vy = new int[LabelMax];

        static Random random = new Random();   

        //�񋓎qenum
        enum State
        {
            None = -1,
            Title,
            Game,
            Gameover,
            Clear
        }

        State nextState = State.Title;
        State currentState = State.None;

        int score;
        int timer;
        int highScore = 100;
        int StartTimer => 200;
        const int CStartTimer = 200;

        public Form1()
        {
            InitializeComponent();

            for (int i = 0; i < LabelMax; i++)
            {
                chrLabels[i] = new Label();
                chrLabels[i].AutoSize = true;
                chrLabels[i].Text = "( .  _  .)";
                chrLabels[i].Top = i * 24;
                Controls.Add(chrLabels[i]);
                if (i < ObstacleIndex)
                {
                    chrLabels[i].Text = tempPlayer.Text;
                    chrLabels[i].Font = tempPlayer.Font;
                    chrLabels[i].ForeColor = tempPlayer.ForeColor;
                }
                else if (i < ItemIndex)
                {
                    chrLabels[i].Text = tempObstacle.Text;
                    chrLabels[i].Font = tempObstacle.Font;
                    chrLabels[i].ForeColor = tempObstacle.ForeColor;
                }
                else
                {
                    chrLabels[i].Text = tempItem.Text;
                    chrLabels[i].Font = tempItem.Font;
                    chrLabels[i].ForeColor = tempItem.ForeColor;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ChangeState();
            UpdateState();
        }

        void ChangeState()
        {
            if (nextState == State.None) return;

            currentState = nextState;
            nextState = State.None;

            switch (currentState)
            {
                case State.Title:
                    labelTitle.Visible = true;
                    buttonStart.Visible = true;
                    buttonTitle.Visible = false;
                    labelGmeover.Visible = false;
                    labelclear.Visible = false;
                    labelHighScore.Visible = true;
                    tempPlayer.Visible = false;
                    tempObstacle.Visible = false;
                    tempItem.Visible = false;
                    labelCopyright.Visible = true;
                    break;

                case State.Game:
                    labelTitle.Visible = false;
                    buttonStart.Visible = false;
                    labelHighScore.Visible = false;
                    tempItem.Visible = false;
                    labelCopyright.Visible = false;
                    score = 0;
                    itemCount = ItemMax;
                    timer = StartTimer;
                    for (int i = ObstacleIndex; i < vx.Length; i++)
                    {
                        vx[i] = random.Next(-SpeedMax, SpeedMax + 1);
                        vy[i] = random.Next(-SpeedMax, SpeedMax + 1);
                    }
                    RandomObstacleAndItemPosition();                   
                    break;

                case State.Gameover:
                    labelGmeover.Visible = true;
                    buttonTitle.Visible = true;
                    labelHighScore.Visible = true;
                    break;

                case State.Clear:
                    labelclear.Visible = true;
                    buttonTitle.Visible = true;
                    labelHighScore.Visible = true;
                    break;
            }
        }

        void UpdateState()
        {
            switch (currentState)
            {
                case State.Game:
                    UpdateGame();
                    break;
            }
        }

        void UpdateGame()
        {
            if (GetAsyncKeyState((int)Keys.O) < 0)
            {
                nextState = State.Gameover;
            }
            if (GetAsyncKeyState((int)Keys.C) < 0)
            {
                nextState = State.Clear;
            }

            UpdatePlaer();
            UpdateObstacleAndItem();
            UpdateTimer();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            nextState = State.Game;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            nextState = State.Title;
        }

        void UpdatePlaer()
        {
            var mpos = PointToClient(MousePosition);

            chrLabels[PlayerIndex].Left = mpos.X - chrLabels[PlayerIndex].Width / 2;
            chrLabels[PlayerIndex].Top = mpos.Y - chrLabels[PlayerIndex].Height / 2;

        }

        void UpdateObstacleAndItem()
        {
            for (int i = ObstacleIndex; i < chrLabels.Length; i++)
            {
                chrLabels[i].Left += vx[i];
                chrLabels[i].Top += vy[i];

                if (chrLabels[i].Left < 0)
                {
                    vx[i] = Math.Abs(vx[i]);
                }
                else if (chrLabels[i].Right > ClientSize.Width)
                {
                    vx[i] = -Math.Abs(vx[i]);
                }
                if (chrLabels[i].Top < 0)
                {
                    vy[i] = Math.Abs(vy[i]);
                }
                else if (chrLabels[i].Bottom > ClientSize.Height)
                {
                    vy[i] = -Math.Abs(vy[i]);
                }

                //�����蔻��
                if (IsHit(chrLabels[i]))
                {
                    if (IsObstacle(i))
                    {
                        //��Q���ɂԂ�����
                        nextState = State.Gameover;
                    }
                    else
                    {
                        // TODO �A�C�e��
                        AddScore(timer * PointRate);
                        itemCount--;
                        chrLabels[i].Visible = false;
                        if (itemCount <= 0)
                        {
                            nextState = State.Clear;
                        }
                    }
                }
            }
        }

        void RandomObstacleAndItemPosition()
        {
            for (int i = ObstacleIndex; i < chrLabels.Length; i++)
            {
                chrLabels[i].Left = random.Next(ClientSize.Width - chrLabels[i].Width);
                chrLabels[i].Top = random.Next(ClientSize.Height - chrLabels[i].Height);
            }
        }

        void UpdateTimer()
        {
            timer--;
            if (timer <= 0)
            {
                timer = 0;
                nextState = State.Gameover;
            }

            labelTimer.Text = $"{timer:000}";
        }

        bool IsHit(Label target)
        {
            var mpos = PointToClient(MousePosition);

            return ((mpos.X >= target.Left)
                && (mpos.X < target.Right)
                && (mpos.Y >= target.Top)
                && (mpos.Y < target.Bottom));
        }

        bool IsObstacle(int index)
        {
            return (index >= ObstacleIndex)
                && (index < ItemIndex);
        }          

        void AddScore(int point)
        {
            // TODO ���_���Z
            score = Math.Min(score + point, ScoreMax);

            UpdateScore();
        }

        void UpdateScore()
        {
            labelScore.Text = $"{score:00000}";
        }

    }
}
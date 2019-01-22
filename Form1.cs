using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.IO;
using System.Timers;
using WMPLib;


namespace AoTGame
{

    public partial class Form1 : Form
    {
        //test comment for initial GitHub Commit!
        bool jumping = false;
        int pipeSpeed = 10;
        int gravity = 5;
        int Inscore = 0;
        Random randomGenerator = new Random();
        int xBounds;
        int yBounds;
        WMPLib.WindowsMediaPlayer swordSlash = new WMPLib.WindowsMediaPlayer();

        public void GameKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                jumping = true;
                gravity = -5;
            }
            else if (e.KeyCode == Keys.A)
            {
                slashBox.Enabled = true;
            }
            else
            {
                return;
            }
        }
       
        public async void GameKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                jumping = false;
                gravity = 5;
            }

            else if (e.KeyCode == Keys.A && gameOverView.Visible == false)
            {
                slashBox.Visible = true;
                swordSlash.URL = @"C:\Users\Logan Minor\documents\visual studio 2015\Projects\AoTGame\AoTGame\Resources\swordEffect.mp3";
                swordSlash.controls.play();
                await Task.Delay(500);
                slashBox.Visible = false;
                slashBox.Enabled = false;
            }

        }

        protected override CreateParams CreateParams
        {
            get
            {
                var cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;    // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }

        public Form1()
        {
            InitializeComponent();
            gameTimer.Enabled = false;

            //main menu view
            mainMenuBackground.Visible = true;
            mainMenuView.Visible = true;
            mainMenuView.Rows.Add();
            var row = (DataGridViewRow)mainMenuView.Rows[0].Clone();
            var row1 = (DataGridViewRow)mainMenuView.Rows[0].Clone();
            var row2 = (DataGridViewRow)mainMenuView.Rows[0].Clone();

            row.Cells[0].Value = "Play";
            row1.Cells[0].Value = "Controls";
            row2.Cells[0].Value = "Exit";

            mainMenuView.Rows.Add(row);
            mainMenuView.Rows.Add(row1);
            mainMenuView.Rows.Add(row2);
            mainMenuView.Rows.RemoveAt(0);

            DoubleBuffered = true;
            Level2.Text = "Level: 2";
            fuelLabel.Text = "Fuel Gauge: ";
            Level2.Visible = false;
            highScoreGridView.Visible = false;
            pipeTop.Left -= pipeSpeed;
            pipeBottom.Left -= pipeSpeed;
            sword.Left -= pipeSpeed;
            fuel.Left -= pipeSpeed;
            flappyBird.Top += gravity;
            flappyBird.BorderStyle = BorderStyle.None;
            slashBox.Top += gravity;
            slashBox.BorderStyle = BorderStyle.None;
            scoreText.Text = "Score: " + Inscore;
            fuelBar.Value--;
            ModifyProgressBarColor.SetState(fuelBar, 1);
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            //player.SoundLocation = @"C:\Users\Logan Minor\documents\visual studio 2015\Projects\AoTGame\AoTGame\Resources\gameBackgroundMusic.wav";
            //player.PlayLooping();
        }

        private void mainMenuView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)mainMenuView;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex == 0)
            {
                //Intialize Game
                mainMenuBackground.Visible = false;
                mainMenuView.Visible = false;
                gameTimer.Enabled = true;
            }

            else if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex == 1)
            {
                mainMenuBackground.Visible = false;

                //Show controls view
                mainMenuView.Visible = false;
                instructionsView.Visible = true;
                controlsHeader.Visible = true;
                controlsDesc.Visible = true;
                controlsDesc2.Visible = true;
                backButton.Enabled = true;
                backButton.Visible = true;
            }

            else if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex == 2)
            {
                //Exit Application
                Application.Exit();
            }

        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            fuelLabel.Text = "Fuel Gauge: ";
            highScoreGridView.Visible = false;
            pipeTop.Left -= pipeSpeed;
            pipeBottom.Left -= pipeSpeed;
            sword.Left -= pipeSpeed;
            fuel.Left -= pipeSpeed;
            flappyBird.Top += gravity;
            flappyBird.BorderStyle = BorderStyle.None;
            slashBox.Top += gravity;
            slashBox.BorderStyle = BorderStyle.None;
            scoreText.Text = "Score: " + Inscore;
            fuelBar.Value--;
            ModifyProgressBarColor.SetState(fuelBar, 1);

            if (slashBox.Visible && slashBox.Bounds.IntersectsWith(pipeTop.Bounds))
            {
                Random rnd = new Random();
                for (int ctr = 274; ctr <= 1500; ctr++)
                {
                    var newLocation = rnd.Next(275, 1500);
                    pipeTop.Location = new Point (newLocation, 0);
                }

                Inscore += 50;
            }

            else if (slashBox.Visible && slashBox.Bounds.IntersectsWith(pipeBottom.Bounds))
            {
                Random rnd = new Random();
                for (int ctr = 435; ctr <= 1500; ctr++)
                {
                    var newLocation = rnd.Next(436, 1500);
                    pipeBottom.Location = new Point(newLocation, 396);
                }
                Inscore += 100;
            }

            if (flappyBird.Bounds.IntersectsWith(ground.Bounds) || flappyBird.Bounds.IntersectsWith(pipeTop.Bounds) || flappyBird.Bounds.IntersectsWith(pipeBottom.Bounds))
            {
                endGame();
            }
            
            else if (flappyBird.Bounds.IntersectsWith(sword.Bounds))
            {
                Inscore += 25;
                xBounds = this.Width;
                yBounds = this.Height;
                moveSword();
            }
            else if (flappyBird.Bounds.IntersectsWith(fuel.Bounds))
            {
                fuelBar.Increment(200);
                xBounds = this.Width;
                yBounds = this.Height;
                moveFuel();
            }

            if (fuelBar.Value <= 1)
            {
                endGame();
            }

            if (sword.Bounds.IntersectsWith(ground.Bounds) || sword.Bounds.IntersectsWith(pipeTop.Bounds) || sword.Bounds.IntersectsWith(pipeBottom.Bounds))
            {
                moveSword();
            }

            if (fuel.Bounds.IntersectsWith(ground.Bounds) || fuel.Bounds.IntersectsWith(pipeTop.Bounds) || fuel.Bounds.IntersectsWith(pipeBottom.Bounds))
            {
                moveFuel();
            }
            
            if (pipeTop.Left < -80)
            {
                pipeTop.Enabled = true;
                pipeTop.Visible = true;
                pipeTop.Left = 1000;
                pipeTop.Visible = true;
                Inscore += 1;
            }
            else if (pipeBottom.Left < -95)
            {
                pipeTop.Enabled = true;
                pipeTop.Visible = true;
                pipeBottom.Left = 1100;
                pipeBottom.Visible = true;
                Inscore += 1;
            }
            else if (sword.Left < -80)
            {
                moveSword();
            }
            else if (fuel.Left < -2500)
            {
                moveFuel();
            }

            if (Inscore > 500)
            {
                Level2.Visible = true;
                pipeSpeed = 15;
            }

           else if (Inscore > 550)
            {
                Level2.Visible = false;
            }

           else if (Inscore > 800)
            {
                Level2.Visible = true;
                Level2.Text = "Level 3";
                pipeSpeed = 20;
            }

           else if (Inscore > 850)
            {
                Level2.Visible = false;
            }

            else if (Inscore > 1500)
            {
                Level2.Visible = true;
                Level2.Text = "Level 4";
                pipeSpeed = 25;
            }

            else if (Inscore > 5000)
            {
                Level2.Visible = true;
                Level2.Text = "Level 5";
                pipeSpeed = 30;
            }
        }

        private void moveSword()
        {
            //Save the generated numbers to an Int array.
            int[] numbers = GenerateRandomNumbers();

            //Move the sword picturebox.
            sword.Location = new Point(numbers[0], numbers[1]);
        }

        private void moveFuel()
        {
            int[] numbers = GenerateRandomNumbers();
            fuel.Location = new Point(numbers[0], numbers[1]);
        }

        private int[] GenerateRandomNumbers()
        {
            int[] RandomNumbers = new int[2];
            RandomNumbers[0] = randomGenerator.Next(0, xBounds);
            RandomNumbers[1] = randomGenerator.Next(0, yBounds);
            return RandomNumbers;
        }


        public class StringValue
        {
            public StringValue(string s)
            {
                _value = s;
            }
            public string Value { get { return _value; } set { _value = value; } }
            string _value;
        }
        
        public void endGame()
        {

            gameTimer.Stop();
            highScoreGridView.Visible = true;
            gameOverView.Visible = true;

            string fileName = @"scorelog.txt";
            using (FileStream fs = new FileStream(fileName, FileMode.Append, FileAccess.Write))
            using (StreamWriter sw = new StreamWriter(fs))

            {
                sw.WriteLine(Inscore);
            }

            var TopScore = File.ReadLines("scorelog.txt").Select(int.Parse).OrderByDescending(x => x).Take(10).ToList();
            highScoreGridView.DataSource = TopScore.ConvertAll(x => new { LeaderBoard = x });
            highScoreGridView.AutoGenerateColumns = true;
            highScoreGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;

            
            ListViewItem lvi = new ListViewItem("Game Over");
            ListViewItem lvi2 = new ListViewItem("Final Score: " + Inscore.ToString());
            ListViewItem lvi3 = new ListViewItem("Game Designer: Logan Minor");
            ListViewItem lvi4 = new ListViewItem("Press Enter to try again.");
            ListViewItem lvi5 = new ListViewItem("All art credit goes to the respective creators!");
            
            gameOverView.Items.Add(lvi);
            gameOverView.Items.Add(lvi2);
            gameOverView.Items.Add(lvi3);
            gameOverView.Items.Add(lvi4);
            gameOverView.Items.Add(lvi5);
            gameOverView.Columns[0].TextAlign = HorizontalAlignment.Center;
        }

       

    private void gameOverView_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Application.Restart();
            }
        }

        private void backButton_MouseClick(object sender, MouseEventArgs e)
        {
            if (backButton.Visible == true && instructionsView.Visible == true)
            {
                backButton.Visible = false;
                instructionsView.Visible = false;
                controlsHeader.Visible = false;
                controlsDesc.Visible = false;
                controlsDesc2.Visible = false;
                mainMenuView.Visible = true;
                mainMenuBackground.Visible = true;
            }
        }
    }

    public static class ModifyProgressBarColor
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr w, IntPtr l);
        public static void SetState(this ProgressBar pBar, int state)
        {
            SendMessage(pBar.Handle, 1040, (IntPtr)state, IntPtr.Zero);
        }
    }
}

using System;
using System.Drawing;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sports_Day_Scoreboard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

            Label8_Click(null, null);
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            label1.Left = this.Width / 2 - label1.Width / 2;
            label2.Left = this.Width / 2 - label2.Width / 2 + 10;
            LiveIndicator.Left = label2.Left - LiveIndicator.Width + 15;
            label3.Width = Width;
            ScoreWrapper.Width = label3.Width;
            ScoreWrapper.Height = Height - 149;

            GRajputs.Left = (Width / 4) * 1 - GRajputs.Width / 2 - 60;
            GAryans.Left = (Width / 4) * 2 - GAryans.Width / 2;
            GVikings.Left = (Width / 4) * 3 - GVikings.Width / 2 + 60;
            GMughals.Left = (Width / 3) * 1 - GMughals.Width / 2;
            GSpartans.Left = (Width / 3) * 2 - GSpartans.Width / 2;

            GRajputs.Top = (ScoreWrapper.Height / 4) - (GRajputs.Height / 2) + 60;
            GAryans.Top = (ScoreWrapper.Height / 4) - (GAryans.Height / 2) + 60;
            GVikings.Top = (ScoreWrapper.Height / 4) - (GVikings.Height / 2) + 60;
            GMughals.Top = (ScoreWrapper.Height / 4)  *3 - (GMughals.Height / 2) - 60;
            GSpartans.Top = (ScoreWrapper.Height / 4)  *3 - (GSpartans.Height / 2) - 60;
        }

        private void label2_DoubleClick(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private async void Label8_Click(object sender, EventArgs e)
        {
            while (true)
            {
                LiveIndicator.ForeColor = Color.Orange;

                await RefreshScores();
                await Task.Delay(10000);
            }
        }

        async Task RefreshScores()
        {
            string csv = "";

            await Task.Run(delegate
            {
                csv = new WebClient().DownloadString("https://drive.google.com/uc?export=download&id=1oGcIZw8VqhzekqsiCfGV7_7yaMSy5KGb");
            });

            var scores = csv.Split('\n')[1].Split(',');

            if (scores.Length == 5)
            {
                RajputsScore.Text = scores[0];
                AryansScore.Text = scores[1];
                VikingsScore.Text = scores[2];
                MughalsScore.Text = scores[3];
                SpartansScore.Text = scores[4];

                LiveIndicator.ForeColor = Color.LimeGreen;
            }
            else
                LiveIndicator.ForeColor = Color.Red;
        }

        private void ScoreWrapper_Paint(object sender, PaintEventArgs e)
        {   
           // ScoreWrapper.Graphics.Clear(box.Parent.BackColor);
        }
    }
}
using System.Diagnostics.Eventing.Reader;
using System.Media;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Runtime.InteropServices;
using System.ComponentModel;

namespace Roulette
{
    public partial class MainForm : Form
    {
        private Image wheelImage;
        private Ball ball;
        private Betting Betting;
        private Random random = new Random();
        private List<int> tickValues = new List<int>();
        private Dictionary<int, int> numbers = new Dictionary<int, int>()
        {
            { 598, 28 },
            { 593, 7 },
            { 588, 29 },
            { 583, 18 },
            { 578, 22 },
            { 573, 9 },
            { 569, 31 },
            { 564, 14 },
            { 559, 20 },
            { 554, 1 },
            { 549, 33 },
            { 544, 16 },
            { 540, 24 },
            { 535, 5 },
            { 530, 10 },
            { 525, 23 },
            { 520, 8 },
            { 515, 30 },
            { 510, 11 },
            { 506, 36 },
            { 501, 13 },
            { 496, 34 },
            { 491, 6 },
            { 486, 27 },
            { 481, 17 },
            { 476, 25 },
            { 471, 2 },
            { 467, 21 },
            { 462, 4 },
            { 457, 19 },
            { 452, 15 },
            { 447, 32 },
            { 442, 0 },
            { 437, 26 },
            { 433, 3 },
            { 428, 35 },
            { 423, 12 }
        };
        private Wallet wallet = new Wallet(0);
        private SoundPlayer player;

        private int ticks = 0;
        private int drawnNumber;
        private int duration;
        public MainForm()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.BackColor = Color.Green;

            wheelImage = Image.FromFile("wheel.png");
            wheelPictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            wheelPictureBox.TabStop = false;
            wheelPictureBox.BackColor = Color.Green;
            wheelPictureBox.Size = wheelImage.Size;
            wheelPictureBox.Image = wheelImage;
            wheelPictureBox.Location = new Point((30), (this.ClientSize.Height - wheelPictureBox.Height) - 20);

            currentBetsList.BackColor = Color.Green;
            tbCurrentBalance.Text = wallet.ToString();

            Betting = new Betting();
            ball = new Ball(new Point(200, 65));
            tickValues = new List<int>(numbers.Keys.ToArray());
            player = new SoundPlayer("clap.wav");
        }
        private void wheelPictureBox_Paint(object sender, PaintEventArgs e)
        {
            ball.Draw(e.Graphics);
        }
        private void timerBall_Tick(object sender, EventArgs e)
        {
            ticks++;
            ball.UpdatePosition();
            wheelPictureBox.Invalidate();

            if (ticks > 200)
            {
                ball.RotationSpeed = 2f;
            }

            if (ticks == duration)
            {
                timerBall.Stop();
                drawnNumber = numbers[duration];
                int amount = Betting.CalculateWinning(drawnNumber);
                if (amount > 0)
                {
                    player.Play();
                    DialogResult dg = MessageBox.Show("Congratulations! You won: " + amount.ToString(), "Congratulations!", MessageBoxButtons.OK);
                    if (dg == DialogResult.OK)
                    {
                        player.Stop();
                    }
                    wallet.addValue(amount);
                    updateCurrentBalance();
                }
                Betting.bets.Clear();
                showCurrentBets();
            }
        }
        public void showCurrentBets()
        {
            int i = 1;
            currentBetsList.Items.Clear();
            if (Betting.bets.Count > 0)
            {
                foreach (Bet bet in Betting.bets)
                {
                    currentBetsList.Items.Add($"{i}. " + bet);
                    i++;
                }
            }
        }
        private void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int number = int.Parse(button.Text);
            int containedBetAmount = 0;
            bool contains = false;
            int amount = int.Parse(amountNud.Text);
            if (int.Parse(tbCurrentBalance.Text) >= amount)
            {
                if (amount > 0)
                {
                    for (int i = Betting.bets.Count - 1; i >= 0; i--)
                    {
                        if (Betting.bets[i].Number == number)
                        {
                            containedBetAmount = Betting.bets[i].Amount;
                            Betting.bets.Remove(Betting.bets[i]);
                            contains = true;
                        }
                    }

                    if (contains)
                    {
                        Betting.bets.Add(new Bet(number, (amount + containedBetAmount)));
                    }

                    else
                    {
                        Betting.bets.Add(new Bet(number, amount));
                    }
                    wallet.removeValue(amount);
                }
                else
                {
                    DialogResult dg = MessageBox.Show("Please put amount for the bet", "Please put amount for the bet", MessageBoxButtons.OK);
                }
            }
            else
            {
                DialogResult dg = MessageBox.Show("You don't have enough balance", "Not enough balance", MessageBoxButtons.OK);
            }
            updateCurrentBalance();
            showCurrentBets();
        }
        private void buttonGreen_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int number = int.Parse(button.Text);
            int amount = int.Parse(amountNud.Text);

            if (int.Parse(tbCurrentBalance.Text) >= amount)
            {
                if (amount > 0)
                {
                    Betting.bets.Add(new Bet(number, amount));
                    wallet.removeValue(amount);
                }
                else
                {
                    DialogResult dg = MessageBox.Show("Please put amount for the bet", "Please put amount for the bet", MessageBoxButtons.OK);
                }
            }

            else
            {
                DialogResult dg = MessageBox.Show("You don't have enough balance", "Not enough balance", MessageBoxButtons.OK);
            }

            updateCurrentBalance();
            showCurrentBets();
        }
        private void buttonRed_Click(object sender, EventArgs e)
        {
            bool contains = false;
            int amount = int.Parse(amountNud.Text);
            int containedBetAmount = 0;
            if (int.Parse(tbCurrentBalance.Text) >= amount)
            {
                if (amount > 0)
                {
                    for (int i = Betting.bets.Count - 1; i >= 0; i--)
                    {
                        if (Betting.bets[i].Number == -1)
                        {
                            containedBetAmount = Betting.bets[i].Amount;
                            Betting.bets.Remove(Betting.bets[i]);
                            contains = true;
                        }
                    }

                    if (contains)
                    {
                        Betting.bets.Add(new Bet(-1, (amount + containedBetAmount)));
                    }

                    else
                    {
                        Betting.bets.Add(new Bet(-1, amount));
                    }
                    wallet.removeValue(amount);
                }
                else
                {
                    DialogResult dg = MessageBox.Show("Please put amount for the bet", "Please put amount for the bet", MessageBoxButtons.OK);
                }
            }
            else
            {
                DialogResult dg = MessageBox.Show("You don't have enough balance", "Not enough balance", MessageBoxButtons.OK);
            }
            updateCurrentBalance();
            showCurrentBets();
        }
        private void buttonBlack_Click(object sender, EventArgs e)
        {
            bool contains = false;
            int amount = int.Parse(amountNud.Text);
            int containedBetAmount = 0;
            if (int.Parse(tbCurrentBalance.Text) >= amount)
            {
                if (amount > 0)
                {
                    for (int i = Betting.bets.Count - 1; i >= 0; i--)
                    {
                        if (Betting.bets[i].Number == -2)
                        {
                            containedBetAmount = Betting.bets[i].Amount;
                            Betting.bets.Remove(Betting.bets[i]);
                            contains = true;
                        }
                    }

                    if (contains)
                    {
                        Betting.bets.Add(new Bet(-2, (amount + containedBetAmount)));
                    }

                    else
                    {
                        Betting.bets.Add(new Bet(-2, amount));
                    }
                    wallet.removeValue(amount);
                }
                else
                {
                    DialogResult dg = MessageBox.Show("Please put amount for the bet", "Please put amount for the bet", MessageBoxButtons.OK);
                }
            }
            else
            {
                DialogResult dg = MessageBox.Show("You don't have enough balance", "Not enough balance", MessageBoxButtons.OK);
            }

            updateCurrentBalance();
            showCurrentBets();
        }
        private void btnDepositMoney_Click(object sender, EventArgs e)
        {
            DepositForm form = new DepositForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                wallet.addValue(form.amount);
                updateCurrentBalance();
            }
        }
        private void btnRemoveLastBet_Click(object sender, EventArgs e)
        {
            if (Betting.bets.Count > 0)
            {
                Betting.RemoveLastBet(wallet);
            }
            showCurrentBets();
            updateCurrentBalance();
        }
        private void btnRemoveAllBets_Click(object sender, EventArgs e)
        {
            Betting.RemoveAllBets(wallet);
            showCurrentBets();
            updateCurrentBalance();
        }
        private void btnRules_Click(object sender, EventArgs e)
        {
            RulesForm form = new RulesForm();
            form.ShowDialog();
        }
        private void updateCurrentBalance()
        {
            tbCurrentBalance.Text = wallet.ToString();
        }
        private void spinButton_Click(object sender, EventArgs e)
        {
            if (!timerBall.Enabled)
            {
                ball = new Ball(new Point(200, 65));
                if (Betting.bets.Count > 0)
                {
                    timerBall.Start();
                    duration = tickValues[random.Next(tickValues.Count)];
                    amountNud.Value = 0;
                    ticks = 0;
                }
                else
                {
                    MessageBox.Show("Please place some bets", "Place bets", MessageBoxButtons.OK);
                }
            }           
            wheelPictureBox.Invalidate();
        }
    }
}

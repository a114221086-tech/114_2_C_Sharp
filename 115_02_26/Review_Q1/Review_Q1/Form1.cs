namespace Review_Q1
{
    public partial class Form1 : Form
    {
        private Random random;
        private const string ROCK = "石頭";
        private const string PAPER = "布";
        private const string SCISSORS = "剪刀";

        public Form1()
        {
            InitializeComponent();
            random = new Random();
        }

        private string GetComputerChoice()
        {
            int choice = random.Next(0, 3);
            return choice switch
            {
                0 => ROCK,
                1 => PAPER,
                _ => SCISSORS
            };
        }

        private string DetermineWinner(string playerChoice, string computerChoice)
        {
            if (playerChoice == computerChoice)
            {
                return "平手";
            }

            if ((playerChoice == ROCK && computerChoice == SCISSORS) ||
                (playerChoice == PAPER && computerChoice == ROCK) ||
                (playerChoice == SCISSORS && computerChoice == PAPER))
            {
                return "玩家贏";
            }

            return "電腦贏";
        }

        private void PlayGame(string playerChoice)
        {
            string computerChoice = GetComputerChoice();
            string result = DetermineWinner(playerChoice, computerChoice);

            lblComputerChoice.Text = computerChoice;
            lblPlayerChoice.Text = playerChoice;
            lblResult.Text = result;
        }

        private void BtnRock_Click(object sender, EventArgs e)
        {
            PlayGame(ROCK);
        }

        private void BtnPaper_Click(object sender, EventArgs e)
        {
            PlayGame(PAPER);
        }

        private void BtnScissors_Click(object sender, EventArgs e)
        {
            PlayGame(SCISSORS);
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

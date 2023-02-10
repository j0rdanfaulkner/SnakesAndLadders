namespace SnakesAndLadders
{
    public partial class MainWindow : Form
    {
        public int currentPlayer;
        public int positionP1;
        public int positionP2;
        private int rolledNumber;
        public MainWindow()
        {
            InitializeComponent();
            StartGame();
        }
        private void StartGame()
        {
            ResetGame();
            Random startingPlayer = new Random();
            currentPlayer = startingPlayer.Next(1, 3);
            MessageBox.Show("Player " + currentPlayer + " shall go first!", "Starting Player", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void ResetGame()
        {
            positionP1 = 0;
            positionP2 = 0;
        }
        private void EndCurrentTurn(int currentPlayer)
        {
            if (currentPlayer == 1)
            {
                currentPlayer = 2;
                // update labels
            }
            else if (currentPlayer == 2)
            {
                currentPlayer = 1;
                // update labels
            }
        }
        private int RollDice(int currentPlayer)
        {
            Random roll = new Random();
            rolledNumber = roll.Next(1, 7);
            MessageBox.Show("Player " + currentPlayer + " rolled a " + rolledNumber + "!", "Dice Rolled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return rolledNumber;
        }
        private void btnRollDice_Click(object sender, EventArgs e)
        {
            if (currentPlayer == 1)
            {
                RollDice(currentPlayer);
                positionP1 = positionP1 + rolledNumber;
            }
            else if (currentPlayer == 2) 
            {
                RollDice(currentPlayer);
                positionP2 = positionP2 + rolledNumber;
            }
            EndCurrentTurn(currentPlayer);
        }
    }
}
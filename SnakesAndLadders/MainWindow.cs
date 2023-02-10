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
        private void EndCurrentTurn(int playerNumber)
        {
            if (playerNumber == 1)
            {
                currentPlayer = 2;
                // update labels
            }
            else if (playerNumber == 2)
            {
                currentPlayer = 1;
                // update labels
            }
        }
        private int RollDice(int playerNumber)
        {
            Random roll = new Random();
            rolledNumber = roll.Next(1, 7);
            MessageBox.Show("Player " + playerNumber + " rolled a " + rolledNumber + "!", "Dice Rolled", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
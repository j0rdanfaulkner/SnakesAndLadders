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
            lblPlayer1PositionNumber.Text = positionP1.ToString();
            lblPlayer2PositionNumber.Text = positionP2.ToString();
        }
        private void UpdateLabels()
        {
            lblPlayer1PositionNumber.Text = positionP1.ToString();
            lblPlayer2PositionNumber.Text = positionP2.ToString();
        }
        private void CheckForWinner()
        {
            if (positionP1 == 100)
            {
                MessageBox.Show("Player 1 Wins!", "We Have a Winner", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (positionP2 == 100)
            {
                MessageBox.Show("Player 2 Wins!", "We Have a Winner", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private int CheckCurrentPosition(int playerPosition)
        {
            int currentPosition = playerPosition;
            // all the spaces that have snakes
            if (playerPosition == 17)
            {
                currentPosition = playerPosition - 10;
            }
            else if (playerPosition == 54 || playerPosition == 93 || playerPosition == 95)
            {
                currentPosition = playerPosition - 20;
            }
            else if (playerPosition == 62)
            {
                currentPosition = playerPosition - 43;
            }
            else if (playerPosition == 64)
            {
                currentPosition = playerPosition - 4;
            }
            else if (playerPosition == 87)
            {
                currentPosition = playerPosition - 63;
            }
            // all the spaces that have ladders
            else if (playerPosition == 1)
            {
                currentPosition = playerPosition + 37;
            }
            else if (playerPosition == 4)
            {
                currentPosition = playerPosition + 10;
            }
            else if (playerPosition == 9)
            {
                currentPosition = playerPosition + 22;
            }
            else if (playerPosition == 21)
            {
                currentPosition = playerPosition + 42;
            }
            else if (playerPosition == 28)
            {
                currentPosition = playerPosition + 56;
            }
            else if (playerPosition == 51)
            {
                currentPosition = playerPosition + 16;
            }
            else if (playerPosition == 71 || playerPosition == 80)
            {
                currentPosition = playerPosition + 20;
            }
            return currentPosition;
        }
        private void EndCurrentTurn(int playerNumber)
        {
            if (playerNumber == 1)
            {
                currentPlayer = 2;
            }
            else if (playerNumber == 2)
            {
                currentPlayer = 1;
            }
            UpdateLabels();
            CheckForWinner();
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
                positionP1 = CheckCurrentPosition(positionP1);
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
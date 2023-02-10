namespace SnakesAndLadders
{
    public partial class MainWindow : Form
    {
        public int currentPlayer;
        public int positionP1;
        public int positionP2;
        private int rolledNumber;
        private Point playerLabelLocation;
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
            UpdateLabels();
            positionP1 = 0;
            positionP2 = 0;
            lblPlayer1.Location = new Point(-55, 650);
            lblPlayer2.Location = new Point(-55, 650);
        }
        private void UpdateLabels()
        {
            lblPlayer1PositionNumber.Text = positionP1.ToString();
            lblPlayer2PositionNumber.Text = positionP2.ToString();
            if (currentPlayer == 1)
            {
                lblCurrentTurnArrow.Text = "<";
            }
            else if (currentPlayer == 2)
            {
                lblCurrentTurnArrow.Text = ">";
            }
        }
        private void CheckForWinner()
        {
            if (positionP1 >= 100)
            {
                MessageBox.Show("Player 1 Wins!", "We Have a Winner", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (positionP2 >= 100)
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
            else if (playerPosition == 98)
            {
                currentPosition = playerPosition - 19;
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
        private Point MovePlayer(int playerNumber, int diceNumber, int currentPosition)
        {
            int size = 0;
            int currentX = 0;
            int currentY = 0;
            if (currentPlayer == 1)
            {
                currentX = lblPlayer1.Location.X;
                currentY = lblPlayer1.Location.Y;
            }
            else if (currentPlayer == 2)
            {
                currentX = lblPlayer2.Location.X;
                currentY = lblPlayer2.Location.Y;
            }
            // for (int i = 0; i < diceNumber; i++)
            // {
            //     size = size + 70;
            // }
            // int newX = currentX + size;
            // playerLabelLocation.X = newX;
            if (currentPosition == 2)
            {
                playerLabelLocation = new Point(86, 650);
            }
            else if (currentPosition == 3)
            {
                playerLabelLocation = new Point(156, 650);
            }
            else if (currentPosition == 5)
            {
                playerLabelLocation = new Point(296, 650);
            }
            else if (currentPosition == 6)
            {
                playerLabelLocation = new Point(366, 650);
            }
            else if (currentPosition == 7)
            {
                playerLabelLocation = new Point(436, 650);
            }
            else if (currentPosition == 8)
            {
                playerLabelLocation = new Point(506, 650);
            }
            else if (currentPosition == 10)
            {
                playerLabelLocation = new Point(646, 650);
            }
            // if player landed on a space with a snake
            else if (currentPosition == 17)
            {
                MessageBox.Show("Player " + playerNumber + " landed on a snake!", "Slid Down a Snake", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                playerLabelLocation = new Point(425, 650);
            }
            else if (currentPosition == 54)
            {
                MessageBox.Show("Player " + playerNumber + " landed on a snake!", "Slid Down a Snake", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                playerLabelLocation = new Point(425, 450);
            }
            else if (currentPosition == 62)
            {
                MessageBox.Show("Player " + playerNumber + " landed on a snake!", "Slid Down a Snake", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                playerLabelLocation = new Point(83, 585);
            }
            else if (currentPosition == 64)
            {
                MessageBox.Show("Player " + playerNumber + " landed on a snake!", "Slid Down a Snake", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                playerLabelLocation = new Point(16, 310);
            }
            else if (currentPosition == 87)
            {
                MessageBox.Show("Player " + playerNumber + " landed on a snake!", "Slid Down a Snake", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                playerLabelLocation = new Point(223, 515);
            }
            else if (currentPosition == 93)
            {
                MessageBox.Show("Player " + playerNumber + " landed on a snake!", "Slid Down a Snake", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                playerLabelLocation = new Point(493, 175);
            }
            else if (currentPosition == 95)
            {
                MessageBox.Show("Player " + playerNumber + " landed on a snake!", "Slid Down a Snake", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                playerLabelLocation = new Point(356, 175);
            }
            else if (currentPosition == 98)
            {
                MessageBox.Show("Player " + playerNumber + " landed on a snake!", "Slid Down a Snake", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                playerLabelLocation = new Point(83, 175);
            }
            // if player landed on a space with a ladder
            else if (currentPosition == 1)
            {
                MessageBox.Show("Player " + playerNumber + " went up a ladder!", "Climbed Up a Ladder", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                playerLabelLocation = new Point(153, 450);
            }
            else if (currentPosition == 4)
            {
                MessageBox.Show("Player " + playerNumber + " went up a ladder!", "Climbed Up a Ladder", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                playerLabelLocation = new Point(425, 583);
            }
            else if (currentPosition == 9)
            {
                MessageBox.Show("Player " + playerNumber + " went up a ladder!", "Climbed Up a Ladder", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                playerLabelLocation = new Point(630, 455);
            }
            else if (currentPosition == 21)
            {
                MessageBox.Show("Player " + playerNumber + " went up a ladder!", "Climbed Up a Ladder", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                playerLabelLocation = new Point(83, 375);
            }
            else if (currentPosition == 28)
            {
                MessageBox.Show("Player " + playerNumber + " went up a ladder!", "Climbed Up a Ladder", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                playerLabelLocation = new Point(23, 105);
            }
            else if (currentPosition == 51)
            {
                MessageBox.Show("Player " + playerNumber + " went up a ladder!", "Climbed Up a Ladder", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                playerLabelLocation = new Point(425, 240);
            }
            else if (currentPosition == 71)
            {
                MessageBox.Show("Player " + playerNumber + " went up a ladder!", "Climbed Up a Ladder", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                playerLabelLocation = new Point(630, 75);
            }
            else if (currentPosition == 80)
            {
                MessageBox.Show("Player " + playerNumber + " went up a ladder!", "Climbed Up a Ladder", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                playerLabelLocation = new Point(15, 40);
            }
            return playerLabelLocation;
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
                lblPlayer1.Location = MovePlayer(currentPlayer, rolledNumber, positionP1);
                positionP1 = CheckCurrentPosition(positionP1);
            }
            else if (currentPlayer == 2) 
            {
                RollDice(currentPlayer);
                positionP2 = positionP2 + rolledNumber;
                lblPlayer2.Location = MovePlayer(currentPlayer, rolledNumber, positionP2);
                positionP2 = CheckCurrentPosition(positionP2);
                lblPlayer2.Location = MovePlayer(currentPlayer, rolledNumber, positionP2);
            }
            EndCurrentTurn(currentPlayer);
        }
    }
}
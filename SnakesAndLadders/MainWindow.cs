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
            switch (currentPosition)
            {
                case 1: // space with ladder
                    MessageBox.Show("Player " + playerNumber + " went up a ladder!", "Climbed Up a Ladder", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    playerLabelLocation = new Point(153, 450);
                    break;
                case 2:
                    playerLabelLocation = new Point(86, 650);
                    break;
                case 3:
                    playerLabelLocation = new Point(156, 650);
                    break;
                case 4: // space with ladder
                    MessageBox.Show("Player " + playerNumber + " went up a ladder!", "Climbed Up a Ladder", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    playerLabelLocation = new Point(425, 583);
                    break;
                case 5:
                    playerLabelLocation = new Point(296, 650);
                    break;
                case 6:
                    playerLabelLocation = new Point(366, 650);
                    break;
                case 7:
                    playerLabelLocation = new Point(436, 650);
                    break;
                case 8:
                    playerLabelLocation = new Point(506, 650);
                    break;
                case 9: // space with ladder
                    MessageBox.Show("Player " + playerNumber + " went up a ladder!", "Climbed Up a Ladder", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    playerLabelLocation = new Point(630, 455);
                    break;
                case 10:
                    playerLabelLocation = new Point(646, 650);
                    break;
                case 11:
                    break;
                case 12:
                    break;
                case 13:
                    break;
                case 14:
                    break;
                case 15:
                    break;
                case 16:
                    break;
                case 17: // space with snake
                    MessageBox.Show("Player " + playerNumber + " landed on a snake!", "Slid Down a Snake", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    playerLabelLocation = new Point(425, 650);
                    break;
                case 18:
                    break;
                case 19:
                    break;
                case 20:
                    break;
                case 21: // space with ladder
                    MessageBox.Show("Player " + playerNumber + " went up a ladder!", "Climbed Up a Ladder", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    playerLabelLocation = new Point(83, 375);
                    break;
                case 22:
                    break;
                case 23:
                    break;
                case 24:
                    break;
                case 25:
                    break;
                case 26:
                    break;
                case 27:
                    break;
                case 28: // space with ladder
                    MessageBox.Show("Player " + playerNumber + " went up a ladder!", "Climbed Up a Ladder", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    playerLabelLocation = new Point(23, 105);
                    break;
                case 29:
                    break;
                case 30:
                    break;
                case 31:
                    break;
                case 32:
                    break;
                case 33:
                    break;
                case 34:
                    break;
                case 35:
                    break;
                case 36:
                    break;
                case 37:
                    break;
                case 38:
                    break;
                case 39:
                    break;
                case 40:
                    break;
                case 41:
                    break;
                case 42:
                    break;
                case 43:
                    break;
                case 44:
                    break;
                case 45:
                    break;
                case 46:
                    break;
                case 47:
                    break;
                case 48:
                    break;
                case 49:
                    break;
                case 50:
                    break;
                case 51: // space with ladder
                    MessageBox.Show("Player " + playerNumber + " went up a ladder!", "Climbed Up a Ladder", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    playerLabelLocation = new Point(425, 240);
                    break;
                case 52:
                    break;
                case 53:
                    break;
                case 54: // space with snake
                    MessageBox.Show("Player " + playerNumber + " landed on a snake!", "Slid Down a Snake", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    playerLabelLocation = new Point(425, 450);
                    break;
                case 55:
                    break;
                case 56:
                    break;
                case 57:
                    break;
                case 58:
                    break;
                case 59:
                    break;
                case 60:
                    break;
                case 61:
                    break;
                case 62: // space with snake
                    MessageBox.Show("Player " + playerNumber + " landed on a snake!", "Slid Down a Snake", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    playerLabelLocation = new Point(83, 585);
                    break;
                case 63:
                    break;
                case 64: // space with snake
                    MessageBox.Show("Player " + playerNumber + " landed on a snake!", "Slid Down a Snake", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    playerLabelLocation = new Point(16, 310);
                    break;
                case 65:
                    break;
                case 66:
                    break;
                case 67:
                    break;
                case 68:
                    break;
                case 69:
                    break;
                case 70:
                    break;
                case 71: // space with ladder
                    MessageBox.Show("Player " + playerNumber + " went up a ladder!", "Climbed Up a Ladder", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    playerLabelLocation = new Point(630, 75);
                    break;
                case 72:
                    break;
                case 73:
                    break;
                case 74:
                    break;
                case 75:
                    break;
                case 76:
                    break;
                case 77:
                    break;
                case 78:
                    break;
                case 79:
                    break;
                case 80: // space with ladder
                    MessageBox.Show("Player " + playerNumber + " went up a ladder!", "Climbed Up a Ladder", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    playerLabelLocation = new Point(15, 40);
                    break;
                case 81:
                    break;
                case 82:
                    break;
                case 83:
                    break;
                case 84:
                    break;
                case 85:
                    break;
                case 86:
                    break;
                case 87: // space with snake
                    MessageBox.Show("Player " + playerNumber + " landed on a snake!", "Slid Down a Snake", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    playerLabelLocation = new Point(223, 515);
                    break;
                case 88:
                    break;
                case 89:
                    break;
                case 90:
                    break;
                case 91:
                    break;
                case 92:
                    break;
                case 93: // space with snake
                    MessageBox.Show("Player " + playerNumber + " landed on a snake!", "Slid Down a Snake", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    playerLabelLocation = new Point(493, 175);
                    break;
                case 94:
                    break;
                case 95: // space with snake
                    MessageBox.Show("Player " + playerNumber + " landed on a snake!", "Slid Down a Snake", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    playerLabelLocation = new Point(356, 175);
                    break;
                case 96:
                    break;
                case 97:
                    break;
                case 98: // space with snake
                    MessageBox.Show("Player " + playerNumber + " landed on a snake!", "Slid Down a Snake", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    playerLabelLocation = new Point(83, 175);
                    break;
                case 99:
                    break;
                case 100:
                    break;
                default:
                    break;
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
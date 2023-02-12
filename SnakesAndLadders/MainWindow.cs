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
                case 1: // space with ladder (1 -> 38)
                    MessageBox.Show("Player " + playerNumber + " went up a ladder!", "Climbed Up a Ladder", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    playerLabelLocation = new Point(153, 445);
                    break;
                case 2:
                    playerLabelLocation = new Point(83, 650);
                    break;
                case 3:
                    playerLabelLocation = new Point(153, 650);
                    break;
                case 4: // space with ladder (4 -> 14)
                    MessageBox.Show("Player " + playerNumber + " went up a ladder!", "Climbed Up a Ladder", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    playerLabelLocation = new Point(423, 585);
                    break;
                case 5:
                    playerLabelLocation = new Point(293, 650);
                    break;
                case 6:
                    playerLabelLocation = new Point(363, 650);
                    break;
                case 7:
                    playerLabelLocation = new Point(433, 650);
                    break;
                case 8:
                    playerLabelLocation = new Point(503, 650);
                    break;
                case 9: // space with ladder (9 -> 31)
                    MessageBox.Show("Player " + playerNumber + " went up a ladder!", "Climbed Up a Ladder", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    playerLabelLocation = new Point(633, 445);
                    break;
                case 10:
                    playerLabelLocation = new Point(646, 650);
                    break;
                case 11:
                    playerLabelLocation = new Point(630, 585);
                    break;
                case 12:
                    playerLabelLocation = new Point(563, 585);
                    break;
                case 13:
                    playerLabelLocation = new Point(493, 585);
                    break;
                case 14:
                    playerLabelLocation = new Point(423, 585);
                    break;
                case 15:
                    playerLabelLocation = new Point(353, 585);
                    break;
                case 16:
                    playerLabelLocation = new Point(283, 585);
                    break;
                case 17: // space with snake (17 -> 7)
                    MessageBox.Show("Player " + playerNumber + " landed on a snake!", "Slid Down a Snake", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    playerLabelLocation = new Point(433, 650);
                    break;
                case 18:
                    playerLabelLocation = new Point(153, 585);
                    break;
                case 19:
                    playerLabelLocation = new Point(83, 585);
                    break;
                case 20:
                    playerLabelLocation = new Point(13, 585);
                    break;
                case 21: // space with ladder (21 -> 42)
                    MessageBox.Show("Player " + playerNumber + " went up a ladder!", "Climbed Up a Ladder", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    playerLabelLocation = new Point(83, 375);
                    break;
                case 22:
                    playerLabelLocation = new Point(83, 515);
                    break;
                case 23:
                    playerLabelLocation = new Point(153, 515);
                    break;
                case 24:
                    playerLabelLocation = new Point(223, 515);
                    break;
                case 25:
                    playerLabelLocation = new Point(283, 515);
                    break;
                case 26:
                    playerLabelLocation = new Point(353, 515);
                    break;
                case 27:
                    playerLabelLocation = new Point(423, 515);
                    break;
                case 28: // space with ladder (28 -> 84)
                    MessageBox.Show("Player " + playerNumber + " went up a ladder!", "Climbed Up a Ladder", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    playerLabelLocation = new Point(23, 105);
                    break;
                case 29:
                    playerLabelLocation = new Point(563, 515);
                    break;
                case 30:
                    playerLabelLocation = new Point(633, 515);
                    break;
                case 31:
                    playerLabelLocation = new Point(633, 445);
                    break;
                case 32:
                    playerLabelLocation = new Point(563, 445);
                    break;
                case 33:
                    playerLabelLocation = new Point(493, 445);
                    break;
                case 34:
                    playerLabelLocation = new Point(423, 445);
                    break;
                case 35:
                    playerLabelLocation = new Point(353, 445);
                    break;
                case 36:
                    playerLabelLocation = new Point(283, 445);
                    break;
                case 37:
                    playerLabelLocation = new Point(223, 445);
                    break;
                case 38:
                    playerLabelLocation = new Point(153, 445);
                    break;
                case 39:
                    playerLabelLocation = new Point(83, 445);
                    break;
                case 40:
                    playerLabelLocation = new Point(13, 445);
                    break;
                case 41:
                    playerLabelLocation = new Point(13, 445);
                    break;
                case 42:
                    playerLabelLocation = new Point(83, 375);
                    break;
                case 43:
                    playerLabelLocation = new Point(153, 375);
                    break;
                case 44:
                    playerLabelLocation = new Point(223, 375);
                    break;
                case 45:
                    playerLabelLocation = new Point(283, 375);
                    break;
                case 46:
                    playerLabelLocation = new Point(353, 375);
                    break;
                case 47:
                    playerLabelLocation = new Point(423, 375);
                    break;
                case 48:
                    playerLabelLocation = new Point(493, 375);
                    break;
                case 49:
                    playerLabelLocation = new Point(563, 375);
                    break;
                case 50:
                    playerLabelLocation = new Point(633, 375);
                    break;
                case 51: // space with ladder (51 -> 67)
                    MessageBox.Show("Player " + playerNumber + " went up a ladder!", "Climbed Up a Ladder", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    playerLabelLocation = new Point(425, 240);
                    break;
                case 52:
                    playerLabelLocation = new Point(563, 315);
                    break;
                case 53:
                    playerLabelLocation = new Point(493, 315);
                    break;
                case 54: // space with snake (54 -> 34)
                    MessageBox.Show("Player " + playerNumber + " landed on a snake!", "Slid Down a Snake", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    playerLabelLocation = new Point(423, 445);
                    break;
                case 55:
                    playerLabelLocation = new Point(353, 315);
                    break;
                case 56:
                    playerLabelLocation = new Point(283, 315);
                    break;
                case 57:
                    playerLabelLocation = new Point(223, 315);
                    break;
                case 58:
                    playerLabelLocation = new Point(153, 315);
                    break;
                case 59:
                    playerLabelLocation = new Point(83, 315);
                    break;
                case 60:
                    playerLabelLocation = new Point(13, 315);
                    break;
                case 61:
                    playerLabelLocation = new Point(13, 245);
                    break;
                case 62: // space with snake (62 -> 19)
                    MessageBox.Show("Player " + playerNumber + " landed on a snake!", "Slid Down a Snake", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    playerLabelLocation = new Point(83, 585);
                    break;
                case 63:
                    playerLabelLocation = new Point(153, 245);
                    break;
                case 64: // space with snake (64 -> 60)
                    MessageBox.Show("Player " + playerNumber + " landed on a snake!", "Slid Down a Snake", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    playerLabelLocation = new Point(13, 315);
                    break;
                case 65:
                    playerLabelLocation = new Point(283, 245);
                    break;
                case 66:
                    playerLabelLocation = new Point(353, 245);
                    break;
                case 67:
                    playerLabelLocation = new Point(423, 245);
                    break;
                case 68:
                    playerLabelLocation = new Point(493, 245);
                    break;
                case 69:
                    playerLabelLocation = new Point(563, 245);
                    break;
                case 70:
                    playerLabelLocation = new Point(633, 245);
                    break;
                case 71: // space with ladder (71 -> 91)
                    MessageBox.Show("Player " + playerNumber + " went up a ladder!", "Climbed Up a Ladder", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    playerLabelLocation = new Point(633, 35);
                    break;
                case 72:
                    playerLabelLocation = new Point(563, 175);
                    break;
                case 73:
                    playerLabelLocation = new Point(493, 175);
                    break;
                case 74:
                    playerLabelLocation = new Point(423, 175);
                    break;
                case 75:
                    playerLabelLocation = new Point(353, 175);
                    break;
                case 76:
                    playerLabelLocation = new Point(283, 175);
                    break;
                case 77:
                    playerLabelLocation = new Point(223, 175);
                    break;
                case 78:
                    playerLabelLocation = new Point(153, 175);
                    break;
                case 79:
                    playerLabelLocation = new Point(83, 175);
                    break;
                case 80: // space with ladder (80 -> 100)
                    MessageBox.Show("Player " + playerNumber + " went up a ladder!", "Climbed Up a Ladder", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    playerLabelLocation = new Point(15, 35);
                    break;
                case 81:
                    playerLabelLocation = new Point(13, 105);
                    break;
                case 82:
                    playerLabelLocation = new Point(83, 105);
                    break;
                case 83:
                    playerLabelLocation = new Point(153, 105);
                    break;
                case 84:
                    playerLabelLocation = new Point(223, 105);
                    break;
                case 85:
                    playerLabelLocation = new Point(283, 105);
                    break;
                case 86:
                    playerLabelLocation = new Point(353, 105);
                    break;
                case 87: // space with snake (87 -> 24)
                    MessageBox.Show("Player " + playerNumber + " landed on a snake!", "Slid Down a Snake", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    playerLabelLocation = new Point(223, 515);
                    break;
                case 88:
                    playerLabelLocation = new Point(493, 105);
                    break;
                case 89:
                    playerLabelLocation = new Point(563, 105);
                    break;
                case 90:
                    playerLabelLocation = new Point(633, 105);
                    break;
                case 91:
                    playerLabelLocation = new Point(633, 35);
                    break;
                case 92:
                    playerLabelLocation = new Point(563, 35);
                    break;
                case 93: // space with snake (93 -> 73)
                    MessageBox.Show("Player " + playerNumber + " landed on a snake!", "Slid Down a Snake", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    playerLabelLocation = new Point(493, 175);
                    break;
                case 94:
                    playerLabelLocation = new Point(423, 35);
                    break;
                case 95: // space with snake (95 -> 75)
                    MessageBox.Show("Player " + playerNumber + " landed on a snake!", "Slid Down a Snake", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    playerLabelLocation = new Point(353, 175);
                    break;
                case 96:
                    playerLabelLocation = new Point(283, 35);
                    break;
                case 97:
                    playerLabelLocation = new Point(223, 35);
                    break;
                case 98: // space with snake (98 -> 79)
                    MessageBox.Show("Player " + playerNumber + " landed on a snake!", "Slid Down a Snake", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    playerLabelLocation = new Point(83, 175);
                    break;
                case 99:
                    playerLabelLocation = new Point(83, 35);
                    break;
                case 100:
                    playerLabelLocation = new Point(15, 35);
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
        /// <summary>
        /// ends the program when the exit button is clicked and the user confirms their action
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to end the game?", "End Game", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                this.Close();
                Application.Exit();
            }
        }
        /// <summary>
        /// restarts the current game when the reset button is clicked and the user confirms their action
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to restart the current game?", "Game In Process", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                StartGame();
            }
        }
    }
}
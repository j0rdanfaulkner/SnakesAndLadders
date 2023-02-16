namespace SnakesAndLadders
{
    public partial class MainWindow : Form
    {
        private int currentPlayer;
        private int rolledNumber;
        private Point playerLabelLocation;
        private Player player1;
        private Player player2;
        public MainWindow()
        {
            InitializeComponent();
            StartGame();
        }
        private void StartGame()
        {
            player1 = new Player(1);
            player2 = new Player(2);
            Random startingPlayer = new Random();
            currentPlayer = startingPlayer.Next(1, 3);
            if (currentPlayer == player1.id)
            {
                MessageBox.Show("Player 1 shall go first!", "Starting Player", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (currentPlayer == player2.id)
            {
                MessageBox.Show("Player 2 shall go first!", "Starting Player", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            ResetGame();
        }
        private void ResetGame()
        {
            UpdateLabels();
            player1.position = 0;
            player1.positionOnBoard = new Point(-55, 650);
            lblPlayer1.Location = player1.positionOnBoard;
            player2.position = 0;
            player2.positionOnBoard = new Point(-55, 650);
            lblPlayer2.Location = player2.positionOnBoard;
            pbxP1EventSpace.BackgroundImage = null;
            pbxP2EventSpace.BackgroundImage = null;
        }
        private void UpdateLabels()
        {
            lblPlayer1PositionNumber.Text = player1.position.ToString();
            lblPlayer2PositionNumber.Text = player2.position.ToString();
            if (currentPlayer == player1.id)
            {
                pbxCurrentTurnArrow.BackgroundImage = Properties.Resources.rightarrow;
            }
            else if (currentPlayer == player2.id)
            {
                pbxCurrentTurnArrow.BackgroundImage = Properties.Resources.leftarrow;
            }
        }
        private void RestartGame()
        {
            DialogResult result = MessageBox.Show("Are you sure you want to restart the current game?", "Restart Game", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                StartGame();
            }
        }
        private void CheckForWinner()
        {
            if (player1.position >= 100)
            {
                MessageBox.Show("Player 1 Wins!", "We Have a Winner", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RestartGame();
            }
            else if (player2.position >= 100)
            {
                MessageBox.Show("Player 2 Wins!", "We Have a Winner", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RestartGame();
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
            if (playerNumber == player1.id)
            {
                currentPlayer = player2.id;
            }
            else if (playerNumber == player2.id)
            {
                currentPlayer = player1.id;
            }
            UpdateLabels();
            CheckForWinner();
        }
        private Point MovePlayer(int playerNumber, int diceNumber, int currentPosition)
        {
            // int size = 0;
            int currentX = 0;
            int currentY = 0;
            if (currentPlayer == player1.id)
            {
                currentX = lblPlayer1.Location.X;
                currentY = lblPlayer1.Location.Y;
            }
            else if (currentPlayer == player2.id)
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
                    playerLabelLocation = new Point(153, 445);
                    EventSpace("ladder", playerNumber);
                    break;
                case 2:
                    playerLabelLocation = new Point(83, 650);
                    EventSpace("", playerNumber);
                    break;
                case 3:
                    playerLabelLocation = new Point(153, 650);
                    EventSpace("", playerNumber);
                    break;
                case 4: // space with ladder (4 -> 14)
                    playerLabelLocation = new Point(423, 585);
                    EventSpace("ladder", playerNumber);
                    break;
                case 5:
                    playerLabelLocation = new Point(293, 650);
                    EventSpace("", playerNumber);
                    break;
                case 6:
                    playerLabelLocation = new Point(363, 650);
                    EventSpace("", playerNumber);
                    break;
                case 7:
                    playerLabelLocation = new Point(433, 650);
                    EventSpace("", playerNumber);
                    break;
                case 8:
                    playerLabelLocation = new Point(503, 650);
                    EventSpace("", playerNumber);
                    break;
                case 9: // space with ladder (9 -> 31)
                    playerLabelLocation = new Point(633, 445);
                    EventSpace("ladder", playerNumber);
                    break;
                case 10:
                    playerLabelLocation = new Point(646, 650);
                    EventSpace("", playerNumber);
                    break;
                case 11:
                    playerLabelLocation = new Point(630, 585);
                    EventSpace("", playerNumber);
                    break;
                case 12:
                    playerLabelLocation = new Point(563, 585);
                    EventSpace("", playerNumber);
                    break;
                case 13:
                    playerLabelLocation = new Point(493, 585);
                    EventSpace("", playerNumber);
                    break;
                case 14:
                    playerLabelLocation = new Point(423, 585);
                    EventSpace("", playerNumber);
                    break;
                case 15:
                    playerLabelLocation = new Point(353, 585);
                    EventSpace("", playerNumber);
                    break;
                case 16:
                    playerLabelLocation = new Point(283, 585);
                    EventSpace("", playerNumber);
                    break;
                case 17: // space with snake (17 -> 7)
                    playerLabelLocation = new Point(433, 650);
                    EventSpace("snake", playerNumber);
                    break;
                case 18:
                    playerLabelLocation = new Point(153, 585);
                    EventSpace("", playerNumber);
                    break;
                case 19:
                    playerLabelLocation = new Point(83, 585);
                    EventSpace("", playerNumber);
                    break;
                case 20:
                    playerLabelLocation = new Point(13, 585);
                    EventSpace("", playerNumber);
                    break;
                case 21: // space with ladder (21 -> 42)
                    playerLabelLocation = new Point(83, 375);
                    EventSpace("ladder", playerNumber);
                    break;
                case 22:
                    playerLabelLocation = new Point(83, 515);
                    EventSpace("", playerNumber);
                    break;
                case 23:
                    playerLabelLocation = new Point(153, 515);
                    EventSpace("", playerNumber);
                    break;
                case 24:
                    playerLabelLocation = new Point(223, 515);
                    EventSpace("", playerNumber);
                    break;
                case 25:
                    playerLabelLocation = new Point(283, 515);
                    EventSpace("", playerNumber);
                    break;
                case 26:
                    playerLabelLocation = new Point(353, 515);
                    EventSpace("", playerNumber);
                    break;
                case 27:
                    playerLabelLocation = new Point(423, 515);
                    EventSpace("", playerNumber);
                    break;
                case 28: // space with ladder (28 -> 84)
                    playerLabelLocation = new Point(23, 105);
                    EventSpace("ladder", playerNumber);
                    break;
                case 29:
                    playerLabelLocation = new Point(563, 515);
                    EventSpace("", playerNumber);
                    break;
                case 30:
                    playerLabelLocation = new Point(633, 515);
                    EventSpace("", playerNumber);
                    break;
                case 31:
                    playerLabelLocation = new Point(633, 445);
                    EventSpace("", playerNumber);
                    break;
                case 32:
                    playerLabelLocation = new Point(563, 445);
                    EventSpace("", playerNumber);
                    break;
                case 33:
                    playerLabelLocation = new Point(493, 445);
                    EventSpace("", playerNumber);
                    break;
                case 34:
                    playerLabelLocation = new Point(423, 445);
                    EventSpace("", playerNumber);
                    break;
                case 35:
                    playerLabelLocation = new Point(353, 445);
                    EventSpace("", playerNumber);
                    break;
                case 36:
                    playerLabelLocation = new Point(283, 445);
                    EventSpace("", playerNumber);
                    break;
                case 37:
                    playerLabelLocation = new Point(223, 445);
                    EventSpace("", playerNumber);
                    break;
                case 38:
                    playerLabelLocation = new Point(153, 445);
                    EventSpace("", playerNumber);
                    break;
                case 39:
                    playerLabelLocation = new Point(83, 445);
                    EventSpace("", playerNumber);
                    break;
                case 40:
                    playerLabelLocation = new Point(13, 445);
                    EventSpace("", playerNumber);
                    break;
                case 41:
                    playerLabelLocation = new Point(13, 445);
                    EventSpace("", playerNumber);
                    break;
                case 42:
                    playerLabelLocation = new Point(83, 375);
                    EventSpace("", playerNumber);
                    break;
                case 43:
                    playerLabelLocation = new Point(153, 375);
                    EventSpace("", playerNumber);
                    break;
                case 44:
                    playerLabelLocation = new Point(223, 375);
                    EventSpace("", playerNumber);
                    break;
                case 45:
                    playerLabelLocation = new Point(283, 375);
                    EventSpace("", playerNumber);
                    break;
                case 46:
                    playerLabelLocation = new Point(353, 375);
                    EventSpace("", playerNumber);
                    break;
                case 47:
                    playerLabelLocation = new Point(423, 375);
                    EventSpace("", playerNumber);
                    break;
                case 48:
                    playerLabelLocation = new Point(493, 375);
                    EventSpace("", playerNumber);
                    break;
                case 49:
                    playerLabelLocation = new Point(563, 375);
                    EventSpace("", playerNumber);
                    break;
                case 50:
                    playerLabelLocation = new Point(633, 375);
                    EventSpace("", playerNumber);
                    break;
                case 51: // space with ladder (51 -> 67)
                    playerLabelLocation = new Point(425, 240);
                    EventSpace("ladder", playerNumber);
                    break;
                case 52:
                    playerLabelLocation = new Point(563, 315);
                    EventSpace("", playerNumber);
                    break;
                case 53:
                    playerLabelLocation = new Point(493, 315);
                    EventSpace("", playerNumber);
                    break;
                case 54: // space with snake (54 -> 34)
                    playerLabelLocation = new Point(423, 445);
                    EventSpace("snake", playerNumber);
                    break;
                case 55:
                    playerLabelLocation = new Point(353, 315);
                    EventSpace("", playerNumber);
                    break;
                case 56:
                    playerLabelLocation = new Point(283, 315);
                    EventSpace("", playerNumber);
                    break;
                case 57:
                    playerLabelLocation = new Point(223, 315);
                    EventSpace("", playerNumber);
                    break;
                case 58:
                    playerLabelLocation = new Point(153, 315);
                    EventSpace("", playerNumber);
                    break;
                case 59:
                    playerLabelLocation = new Point(83, 315);
                    EventSpace("", playerNumber);
                    break;
                case 60:
                    playerLabelLocation = new Point(13, 315);
                    EventSpace("", playerNumber);
                    break;
                case 61:
                    playerLabelLocation = new Point(13, 245);
                    EventSpace("", playerNumber);
                    break;
                case 62: // space with snake (62 -> 19)
                    playerLabelLocation = new Point(83, 585);
                    EventSpace("snake", playerNumber);
                    break;
                case 63:
                    playerLabelLocation = new Point(153, 245);
                    EventSpace("", playerNumber);
                    break;
                case 64: // space with snake (64 -> 60)
                    playerLabelLocation = new Point(13, 315);
                    EventSpace("snake", playerNumber);
                    break;
                case 65:
                    playerLabelLocation = new Point(283, 245);
                    EventSpace("", playerNumber);
                    break;
                case 66:
                    playerLabelLocation = new Point(353, 245);
                    EventSpace("", playerNumber);
                    break;
                case 67:
                    playerLabelLocation = new Point(423, 245);
                    EventSpace("", playerNumber);
                    break;
                case 68:
                    playerLabelLocation = new Point(493, 245);
                    EventSpace("", playerNumber);
                    break;
                case 69:
                    playerLabelLocation = new Point(563, 245);
                    EventSpace("", playerNumber);
                    break;
                case 70:
                    playerLabelLocation = new Point(633, 245);
                    EventSpace("", playerNumber);
                    break;
                case 71: // space with ladder (71 -> 91)
                    playerLabelLocation = new Point(633, 35);
                    EventSpace("ladder", playerNumber);
                    break;
                case 72:
                    playerLabelLocation = new Point(563, 175);
                    EventSpace("", playerNumber);
                    break;
                case 73:
                    playerLabelLocation = new Point(493, 175);
                    EventSpace("", playerNumber);
                    break;
                case 74:
                    playerLabelLocation = new Point(423, 175);
                    EventSpace("", playerNumber);
                    break;
                case 75:
                    playerLabelLocation = new Point(353, 175);
                    EventSpace("", playerNumber);
                    break;
                case 76:
                    playerLabelLocation = new Point(283, 175);
                    EventSpace("", playerNumber);
                    break;
                case 77:
                    playerLabelLocation = new Point(223, 175);
                    EventSpace("", playerNumber);
                    break;
                case 78:
                    playerLabelLocation = new Point(153, 175);
                    EventSpace("", playerNumber);
                    break;
                case 79:
                    playerLabelLocation = new Point(83, 175);
                    EventSpace("", playerNumber);
                    break;
                case 80: // space with ladder (80 -> 100)
                    playerLabelLocation = new Point(15, 35);
                    EventSpace("ladder", playerNumber);
                    break;
                case 81:
                    playerLabelLocation = new Point(13, 105);
                    EventSpace("", playerNumber);
                    break;
                case 82:
                    playerLabelLocation = new Point(83, 105);
                    EventSpace("", playerNumber);
                    break;
                case 83:
                    playerLabelLocation = new Point(153, 105);
                    EventSpace("", playerNumber);
                    break;
                case 84:
                    playerLabelLocation = new Point(223, 105);
                    EventSpace("", playerNumber);
                    break;
                case 85:
                    playerLabelLocation = new Point(283, 105);
                    EventSpace("", playerNumber);
                    break;
                case 86:
                    playerLabelLocation = new Point(353, 105);
                    EventSpace("", playerNumber);
                    break;
                case 87: // space with snake (87 -> 24)
                    playerLabelLocation = new Point(223, 515);
                    EventSpace("snake", playerNumber);
                    break;
                case 88:
                    playerLabelLocation = new Point(493, 105);
                    EventSpace("", playerNumber);
                    break;
                case 89:
                    playerLabelLocation = new Point(563, 105);
                    EventSpace("", playerNumber);
                    break;
                case 90:
                    playerLabelLocation = new Point(633, 105);
                    EventSpace("", playerNumber);
                    break;
                case 91:
                    playerLabelLocation = new Point(633, 35);
                    EventSpace("", playerNumber);
                    break;
                case 92:
                    playerLabelLocation = new Point(563, 35);
                    EventSpace("", playerNumber);
                    break;
                case 93:
                    playerLabelLocation = new Point(493, 35);
                    EventSpace("snake", playerNumber);
                    break;
                case 94:
                    playerLabelLocation = new Point(423, 35);
                    EventSpace("", playerNumber);
                    break;
                case 95: // space with snake (95 -> 75)
                    playerLabelLocation = new Point(353, 175);
                    EventSpace("snake", playerNumber);
                    break;
                case 96:
                    playerLabelLocation = new Point(283, 35);
                    EventSpace("", playerNumber);
                    break;
                case 97:
                    playerLabelLocation = new Point(223, 35);
                    EventSpace("", playerNumber);
                    break;
                case 98: // space with snake (98 -> 79)
                    playerLabelLocation = new Point(83, 175);
                    EventSpace("snake", playerNumber);
                    break;
                case 99:
                    playerLabelLocation = new Point(83, 35);
                    EventSpace("", playerNumber);
                    break;
                case 100:
                    playerLabelLocation = new Point(15, 35);
                    EventSpace("", playerNumber);
                    break;
                default:
                    break;
            }
            return playerLabelLocation;
        }/// <summary>
        /// shows a message box that says if the player has gone up a ladder/down a snake
        /// shows a ladder or snake icon next to their score to reflect this
        /// </summary>
        /// <param name="eventType"></param>
        /// <param name="playerNumber"></param>
        private void EventSpace(string eventType, int playerNumber)
        {
            if (eventType == "ladder")
            {
                MessageBox.Show("Player " + playerNumber + " went up a ladder!", "Climbed Up a Ladder", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                switch (playerNumber)
                {
                    case 1:
                        pbxP1EventSpace.BackgroundImage = Properties.Resources.ladder;
                        break;
                    case 2:
                        pbxP2EventSpace.BackgroundImage = Properties.Resources.ladder;
                        break;
                    default:
                        break;
                }
            }
            else if (eventType == "snake")
            {
                MessageBox.Show("Player " + playerNumber + " landed on a snake!", "Slid Down a Snake", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                switch (playerNumber)
                {
                    case 1:
                        pbxP1EventSpace.BackgroundImage = Properties.Resources.snake;
                        break;
                    case 2:
                        pbxP2EventSpace.BackgroundImage = Properties.Resources.snake;
                        break;
                    default:
                        break;
                }
            }
            else if (eventType == "")
            {
                switch (playerNumber)
                {
                    case 1:
                        pbxP1EventSpace.BackgroundImage = null;
                        break;
                    case 2:
                        pbxP2EventSpace.BackgroundImage = null;
                        break;
                    default:
                        break;
                }
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
            if (currentPlayer == player1.id)
            {
                RollDice(currentPlayer);
                player1.position = player1.position + rolledNumber;
                player1.positionOnBoard = MovePlayer(currentPlayer, rolledNumber, player1.position);
                lblPlayer1.Location = player1.positionOnBoard;
                player1.position = CheckCurrentPosition(player1.position);
            }
            else if (currentPlayer == player2.id) 
            {
                RollDice(currentPlayer);
                player2.position = player2.position + rolledNumber;
                player2.positionOnBoard = MovePlayer(currentPlayer, rolledNumber, player2.position);
                lblPlayer2.Location = player2.positionOnBoard;
                player2.position = CheckCurrentPosition(player2.position);
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
        /// runs the 'RestartGame' method when the restart button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            RestartGame();
        }
    }
}
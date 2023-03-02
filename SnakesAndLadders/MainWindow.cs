namespace SnakesAndLadders
{
    public partial class MainWindow : Form
    {
        private int rolledNumber;
        private string player1Name;
        private string player2Name;
        private Point playerLabelLocation;
        private Player player1;
        private Player player2;
        private Player currentPlayer;
        public MainWindow()
        {
            InitializeComponent();
            btnRollDice.Enabled = false;
            lblPlayer1.Hide();
            lblPlayer2.Hide();
        }
        /// <summary>
        /// creates 3 player objects using the Player class (player 1 and player 2, as well as 'currentPlayer')
        /// chooses the starting player at random, then displays a message box to show who the starting player is
        /// calls the ResetGame method to start the game with a new board
        /// </summary>
        private void StartGame()
        {
            player1 = new Player(1, player1Name);
            player2 = new Player(2, player2Name);
            currentPlayer = new Player(0, "");
            Random startingPlayer = new Random();
            currentPlayer.id = startingPlayer.Next(1, 3);
            if (currentPlayer.id == player1.id)
            {
                currentPlayer = player1;
                MessageBox.Show(player1.name + " shall go first!", "Starting Player", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (currentPlayer.id == player2.id)
            {
                currentPlayer = player2;
                MessageBox.Show(player2.name + " shall go first!", "Starting Player", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            btnRollDice.Enabled = true;
            ResetGame();
        }
        /// <summary>
        /// resets the properties of players 1 and 2 in terms of their current positions and board locations
        /// calls the UpdateLabels method to show that the game has been reset
        /// </summary>
        private void ResetGame()
        {
            player1.position = 0;
            player1.positionOnBoard = new Point(-55, 650);
            lblPlayer1.Location = player1.positionOnBoard;
            player2.position = 0;
            player2.positionOnBoard = new Point(-55, 650);
            lblPlayer2.Location = player2.positionOnBoard;
            pbxP1EventSpace.BackgroundImage = null;
            pbxP2EventSpace.BackgroundImage = null;
            UpdateLabels(currentPlayer);
        }
        /// <summary>
        /// updates the text labels of the UI to show the names of each player and their current positions
        /// also updates a picture box used to show an arrow that points to the player having their turn
        /// </summary>
        /// <param name="p"></param>
        private void UpdateLabels(Player p)
        {
            lblPlayer1Turn.Text = player1.name;
            lblPlayer1Positions.Text = player1.name;
            lblPlayer2Turn.Text = player2.name;
            lblPlayer2Positions.Text = player2.name;
            lblPlayer1PositionNumber.Text = player1.position.ToString();
            lblPlayer2PositionNumber.Text = player2.position.ToString();
            if (p.id == player1.id)
            {
                pbxCurrentTurnArrow.BackgroundImage = Properties.Resources.rightarrow;
            }
            else if (p.id == player2.id)
            {
                pbxCurrentTurnArrow.BackgroundImage = Properties.Resources.leftarrow;
            }
        }
        /// <summary>
        /// displays a message box asking if the game is to be restarted
        /// (if so, the StartGame method is run)
        /// </summary>
        private void RestartGame()
        {
            DialogResult result = MessageBox.Show("Do you want to start a new game?", "Rematch", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                StartGame();
            }
        }
        /// <summary>
        /// checks if player 'p' has reached position 100
        /// (runs the RestartGame method if there is a winning player)
        /// </summary>
        /// <param name="p"></param>
        private void CheckForWinner(Player p)
        {
            if (p.position >= 100)
            {
                MessageBox.Show(p.name + " Wins!", "We Have a Winner", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RestartGame();
            }
        }
        /// <summary>
        /// returns the position of player 'p' after they have moved up a ladder/down a snake
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        private int CheckCurrentPosition(Player p)
        {
            int currentPosition = p.position;
            // all the spaces that have snakes
            if (p.position == 17)
            {
                currentPosition = p.position - 10;
            }
            else if (p.position == 54 || p.position == 93 || p.position == 95)
            {
                currentPosition = p.position - 20;
            }
            else if (p.position == 62)
            {
                currentPosition = p.position - 43;
            }
            else if (p.position == 64)
            {
                currentPosition = p.position - 4;
            }
            else if (p.position == 87)
            {
                currentPosition = p.position - 63;
            }
            else if (p.position == 98)
            {
                currentPosition = p.position - 19;
            }
            // all the spaces that have ladders
            else if (p.position == 1)
            {
                currentPosition = p.position + 37;
            }
            else if (p.position == 4)
            {
                currentPosition = p.position + 10;
            }
            else if (p.position == 9)
            {
                currentPosition = p.position + 22;
            }
            else if (p.position == 21)
            {
                currentPosition = p.position + 42;
            }
            else if (p.position == 28)
            {
                currentPosition = p.position + 56;
            }
            else if (p.position == 51)
            {
                currentPosition = p.position + 16;
            }
            else if (p.position == 71 || p.position == 80)
            {
                currentPosition = p.position + 20;
            }
            return currentPosition;
        }
        /// <summary>
        /// ends the turn of the current player
        /// updates the text labels of the UI to show that the player's turn has ended
        /// also checks if the current player has reached position 100 (in other words, if they have won)
        /// </summary>
        /// <param name="p"></param>
        private void EndCurrentTurn(Player p)
        {
            if (p.id == player1.id)
            {
                currentPlayer = player2;
            }
            else if (p.id == player2.id)
            {
                currentPlayer = player1;
            }
            UpdateLabels(currentPlayer);
            CheckForWinner(currentPlayer);
        }
        /// <summary>
        /// moves the player label across the board once they have rolled the dice
        /// </summary>
        /// <param name="p"></param>
        /// <param name="diceNumber"></param>
        /// <returns></returns>
        private Point MovePlayer(Player p, int diceNumber)
        {
            // int size = 0;
            int currentX = 0;
            int currentY = 0;
            if (p.id == player1.id)
            {
                currentX = lblPlayer1.Location.X;
                currentY = lblPlayer1.Location.Y;
            }
            else if (p.id == player2.id)
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
            switch (p.position)
            {
                case 1: // space with ladder (1 -> 38)
                    playerLabelLocation = new Point(153, 445);
                    EventSpace("ladder", p);
                    break;
                case 2:
                    playerLabelLocation = new Point(83, 650);
                    EventSpace("", p);
                    break;
                case 3:
                    playerLabelLocation = new Point(153, 650);
                    EventSpace("", p);
                    break;
                case 4: // space with ladder (4 -> 14)
                    playerLabelLocation = new Point(423, 585);
                    EventSpace("ladder", p);
                    break;
                case 5:
                    playerLabelLocation = new Point(293, 650);
                    EventSpace("", p);
                    break;
                case 6:
                    playerLabelLocation = new Point(363, 650);
                    EventSpace("", p);
                    break;
                case 7:
                    playerLabelLocation = new Point(433, 650);
                    EventSpace("", p);
                    break;
                case 8:
                    playerLabelLocation = new Point(503, 650);
                    EventSpace("", p);
                    break;
                case 9: // space with ladder (9 -> 31)
                    playerLabelLocation = new Point(633, 445);
                    EventSpace("ladder", p);
                    break;
                case 10:
                    playerLabelLocation = new Point(646, 650);
                    EventSpace("", p);
                    break;
                case 11:
                    playerLabelLocation = new Point(630, 585);
                    EventSpace("", p);
                    break;
                case 12:
                    playerLabelLocation = new Point(563, 585);
                    EventSpace("", p);
                    break;
                case 13:
                    playerLabelLocation = new Point(493, 585);
                    EventSpace("", p);
                    break;
                case 14:
                    playerLabelLocation = new Point(423, 585);
                    EventSpace("", p);
                    break;
                case 15:
                    playerLabelLocation = new Point(353, 585);
                    EventSpace("", p);
                    break;
                case 16:
                    playerLabelLocation = new Point(283, 585);
                    EventSpace("", p);
                    break;
                case 17: // space with snake (17 -> 7)
                    playerLabelLocation = new Point(433, 650);
                    EventSpace("snake", p);
                    break;
                case 18:
                    playerLabelLocation = new Point(153, 585);
                    EventSpace("", p);
                    break;
                case 19:
                    playerLabelLocation = new Point(83, 585);
                    EventSpace("", p);
                    break;
                case 20:
                    playerLabelLocation = new Point(13, 585);
                    EventSpace("", p);
                    break;
                case 21: // space with ladder (21 -> 42)
                    playerLabelLocation = new Point(83, 375);
                    EventSpace("ladder", p);
                    break;
                case 22:
                    playerLabelLocation = new Point(83, 515);
                    EventSpace("", p);
                    break;
                case 23:
                    playerLabelLocation = new Point(153, 515);
                    EventSpace("", p);
                    break;
                case 24:
                    playerLabelLocation = new Point(223, 515);
                    EventSpace("", p);
                    break; 
                case 25:
                    playerLabelLocation = new Point(283, 515);
                    EventSpace("", p);
                    break;
                case 26:
                    playerLabelLocation = new Point(353, 515);
                    EventSpace("", p);
                    break;
                case 27:
                    playerLabelLocation = new Point(423, 515);
                    EventSpace("", p);
                    break;
                case 28: // space with ladder (28 -> 84)
                    playerLabelLocation = new Point(23, 105);
                    EventSpace("ladder", p);
                    break;
                case 29:
                    playerLabelLocation = new Point(563, 515);
                    EventSpace("", p);
                    break;
                case 30:
                    playerLabelLocation = new Point(633, 515);
                    EventSpace("", p);
                    break;
                case 31:
                    playerLabelLocation = new Point(633, 445);
                    EventSpace("", p);
                    break;
                case 32:
                    playerLabelLocation = new Point(563, 445);
                    EventSpace("", p);
                    break;
                case 33:
                    playerLabelLocation = new Point(493, 445);
                    EventSpace("", p);
                    break;
                case 34:
                    playerLabelLocation = new Point(423, 445);
                    EventSpace("", p);
                    break;
                case 35:
                    playerLabelLocation = new Point(353, 445);
                    EventSpace("", p);
                    break;
                case 36:
                    playerLabelLocation = new Point(283, 445);
                    EventSpace("", p);
                    break;
                case 37:
                    playerLabelLocation = new Point(223, 445);
                    EventSpace("", p);
                    break;
                case 38:
                    playerLabelLocation = new Point(153, 445);
                    EventSpace("", p);
                    break;
                case 39:
                    playerLabelLocation = new Point(83, 445);
                    EventSpace("", p);
                    break;
                case 40:
                    playerLabelLocation = new Point(13, 445);
                    EventSpace("", p);
                    break;
                case 41:
                    playerLabelLocation = new Point(13, 375);
                    EventSpace("", p);
                    break;
                case 42:
                    playerLabelLocation = new Point(83, 375);
                    EventSpace("", p);
                    break;
                case 43:
                    playerLabelLocation = new Point(153, 375);
                    EventSpace("", p);
                    break;
                case 44:
                    playerLabelLocation = new Point(223, 375);
                    EventSpace("", p);
                    break;
                case 45:
                    playerLabelLocation = new Point(283, 375);
                    EventSpace("", p);
                    break;
                case 46:
                    playerLabelLocation = new Point(353, 375);
                    EventSpace("", p);
                    break;
                case 47:
                    playerLabelLocation = new Point(423, 375);
                    EventSpace("", p);
                    break;
                case 48:
                    playerLabelLocation = new Point(493, 375);
                    EventSpace("", p);
                    break;
                case 49:
                    playerLabelLocation = new Point(563, 375);
                    EventSpace("", p);
                    break;
                case 50:
                    playerLabelLocation = new Point(633, 375);
                    EventSpace("", p);
                    break;
                case 51: // space with ladder (51 -> 67)
                    playerLabelLocation = new Point(425, 240);
                    EventSpace("ladder", p);
                    break;
                case 52:
                    playerLabelLocation = new Point(563, 315);
                    EventSpace("", p);
                    break;
                case 53:
                    playerLabelLocation = new Point(493, 315);
                    EventSpace("", p);
                    break;
                case 54: // space with snake (54 -> 34)
                    playerLabelLocation = new Point(423, 445);
                    EventSpace("snake", p);
                    break;
                case 55:
                    playerLabelLocation = new Point(353, 315);
                    EventSpace("", p);
                    break;
                case 56:
                    playerLabelLocation = new Point(283, 315);
                    EventSpace("", p);
                    break;
                case 57:
                    playerLabelLocation = new Point(223, 315);
                    EventSpace("", p);
                    break;
                case 58:
                    playerLabelLocation = new Point(153, 315);
                    EventSpace("", p);
                    break;
                case 59:
                    playerLabelLocation = new Point(83, 315);
                    EventSpace("", p);
                    break;
                case 60:
                    playerLabelLocation = new Point(13, 315);
                    EventSpace("", p);
                    break;
                case 61:
                    playerLabelLocation = new Point(13, 245);
                    EventSpace("", p);
                    break;
                case 62: // space with snake (62 -> 19)
                    playerLabelLocation = new Point(83, 585);
                    EventSpace("snake", p);
                    break;
                case 63:
                    playerLabelLocation = new Point(153, 245);
                    EventSpace("", p);
                    break;
                case 64: // space with snake (64 -> 60)
                    playerLabelLocation = new Point(13, 315);
                    EventSpace("snake", p);
                    break;
                case 65:
                    playerLabelLocation = new Point(283, 245);
                    EventSpace("", p);
                    break;
                case 66:
                    playerLabelLocation = new Point(353, 245);
                    EventSpace("", p);
                    break;
                case 67:
                    playerLabelLocation = new Point(423, 245);
                    EventSpace("", p);
                    break;
                case 68:
                    playerLabelLocation = new Point(493, 245);
                    EventSpace("", p);
                    break;
                case 69:
                    playerLabelLocation = new Point(563, 245);
                    EventSpace("", p);
                    break;
                case 70:
                    playerLabelLocation = new Point(633, 245);
                    EventSpace("", p);
                    break;
                case 71: // space with ladder (71 -> 91)
                    playerLabelLocation = new Point(633, 35);
                    EventSpace("ladder", p);
                    break;
                case 72:
                    playerLabelLocation = new Point(563, 175);
                    EventSpace("", p);
                    break;
                case 73:
                    playerLabelLocation = new Point(493, 175);
                    EventSpace("", p);
                    break;
                case 74:
                    playerLabelLocation = new Point(423, 175);
                    EventSpace("", p);
                    break;
                case 75:
                    playerLabelLocation = new Point(353, 175);
                    EventSpace("", p);
                    break;
                case 76:
                    playerLabelLocation = new Point(283, 175);
                    EventSpace("", p);
                    break;
                case 77:
                    playerLabelLocation = new Point(223, 175);
                    EventSpace("", p);
                    break;
                case 78:
                    playerLabelLocation = new Point(153, 175);
                    EventSpace("", p);
                    break;
                case 79:
                    playerLabelLocation = new Point(83, 175);
                    EventSpace("", p);
                    break;
                case 80: // space with ladder (80 -> 100)
                    playerLabelLocation = new Point(15, 35);
                    EventSpace("ladder", p);
                    break;
                case 81:
                    playerLabelLocation = new Point(13, 105);
                    EventSpace("", p);
                    break;
                case 82:
                    playerLabelLocation = new Point(83, 105);
                    EventSpace("", p);
                    break;
                case 83:
                    playerLabelLocation = new Point(153, 105);
                    EventSpace("", p);
                    break;
                case 84:
                    playerLabelLocation = new Point(223, 105);
                    EventSpace("", p);
                    break;
                case 85:
                    playerLabelLocation = new Point(283, 105);
                    EventSpace("", p);
                    break;
                case 86:
                    playerLabelLocation = new Point(353, 105);
                    EventSpace("", p);
                    break;
                case 87: // space with snake (87 -> 24)
                    playerLabelLocation = new Point(223, 515);
                    EventSpace("snake", p);
                    break;
                case 88:
                    playerLabelLocation = new Point(493, 105);
                    EventSpace("", p);
                    break;
                case 89:
                    playerLabelLocation = new Point(563, 105);
                    EventSpace("", p);
                    break;
                case 90:
                    playerLabelLocation = new Point(633, 105);
                    EventSpace("", p);
                    break;
                case 91:
                    playerLabelLocation = new Point(633, 35);
                    EventSpace("", p);
                    break;
                case 92:
                    playerLabelLocation = new Point(563, 35);
                    EventSpace("", p);
                    break;
                case 93: // space with snake (93 -> 73)
                    playerLabelLocation = new Point(493, 175);
                    EventSpace("snake", p);
                    break;
                case 94:
                    playerLabelLocation = new Point(423, 35);
                    EventSpace("", p);
                    break;
                case 95: // space with snake (95 -> 75)
                    playerLabelLocation = new Point(353, 175);
                    EventSpace("snake", p);
                    break;
                case 96:
                    playerLabelLocation = new Point(283, 35);
                    EventSpace("", p);
                    break;
                case 97:
                    playerLabelLocation = new Point(223, 35);
                    EventSpace("", p);
                    break;
                case 98: // space with snake (98 -> 79)
                    playerLabelLocation = new Point(83, 175);
                    EventSpace("snake", p);
                    break;
                case 99:
                    playerLabelLocation = new Point(83, 35);
                    EventSpace("", p);
                    break;
                case 100:
                    playerLabelLocation = new Point(15, 35);
                    EventSpace("", p);
                    break;
                default:
                    break;
            }
            return playerLabelLocation;
        }/// <summary>
        /// shows a message box that says if the player has gone up a ladder/down a snake
        /// (also shows a ladder or snake icon next to their score to reflect this)
        /// </summary>
        /// <param name="eventType"></param>
        /// <param name="playerNumber"></param>
        private void EventSpace(string eventType, Player p )
        {
            if (eventType == "ladder")
            {
                MessageBox.Show(p.name + " went up a ladder!", "Climbed Up a Ladder", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                switch (p.id)
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
                MessageBox.Show(p.name + " landed on a snake!", "Slid Down a Snake", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                switch (p.id)
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
                switch (p.id)
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
        /// <summary>
        /// generates a random number between 1 and 6 to represent rolling a 6-sided dice
        /// (returns this number as the 'rolledNumber' integer variable)
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        private int RollDice(Player p)
        {
            Random roll = new Random();
            rolledNumber = roll.Next(1, 7);
            MessageBox.Show(p.name + " rolled a " + rolledNumber + "!", "Dice Rolled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return rolledNumber;
        }
        /// <summary>
        /// calls the RollDice method with the player that rolled the dice as a parameter
        /// calls the MovePlayer method with the player that rolled the dice and the 'rolledNumber' variable as parameters
        /// sets the position of the player to their position on the board which they just moved to
        /// calls the CheckCurrentPosition method with the player that rolled the dice as a parameter
        /// calls the EndCurrentTurn method with currentPlayer as a parameter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRollDice_Click(object sender, EventArgs e)
        {
            if (currentPlayer.id == player1.id)
            {
                lblPlayer1.Show();
                RollDice(player1);
                player1.position = player1.position + rolledNumber;
                player1.positionOnBoard = MovePlayer(player1, rolledNumber);
                lblPlayer1.Location = player1.positionOnBoard;
                player1.position = CheckCurrentPosition(player1);
            }
            else if (currentPlayer.id == player2.id)
            {
                lblPlayer2.Show();
                RollDice(player2);
                player2.position = player2.position + rolledNumber;
                player2.positionOnBoard = MovePlayer(player2, rolledNumber);
                lblPlayer2.Location = player2.positionOnBoard;
                player2.position = CheckCurrentPosition(player2);
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
        /// checks to make sure player names have been given before the game is started when the 'START GAME' button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStartGame_Click(object sender, EventArgs e)
        {
            if (tbxP1Name.Text == "" || tbxP2Name.Text == "")
            {
                MessageBox.Show("Enter the names of each player before starting the game!", "Missing Player Names", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                GetPlayerNames();
            }
        }
        /// <summary>
        /// sets the names of player 1 and player 2 with the values entered in the corresponding textboxes
        /// (if no names are entered, a message box will appear with a prompt asking for both names to be given before proceeding)
        /// calls the StartGame method once the names are submitted and assigned to both players
        /// </summary>
        private void GetPlayerNames()
        {
            if (tbxP1Name.Text != "")
            {
                DialogResult result = MessageBox.Show("Are you sure '" + tbxP1Name.Text + "' is Player 1's name?", "Confirm Name", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    player1Name = tbxP1Name.Text;
                    tbxP1Name.Enabled = false;
                    tbxP1Name.Cursor = Cursors.No;
                }
                else
                {
                    tbxP1Name.Clear();
                    tbxP1Name.Enabled = true;
                    tbxP1Name.Cursor = Cursors.IBeam;
                }
            }
            if (tbxP2Name.Text != "")
            {
                DialogResult result = MessageBox.Show("Are you sure '" + tbxP2Name.Text + "' is Player 2's name?", "Confirm Name", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    player2Name = tbxP2Name.Text;
                    tbxP2Name.Enabled = false;
                    tbxP2Name.Cursor = Cursors.No;
                }
                else
                {
                    tbxP2Name.Clear();
                    tbxP2Name.Enabled = true;
                    tbxP2Name.Cursor = Cursors.IBeam;
                }
            }
            if (tbxP1Name.Text != "" && tbxP2Name.Text != "")
            {
                lblP1Name.Hide();
                tbxP1Name.Hide();
                lblP2Name.Hide();
                tbxP2Name.Hide();
                btnStartGame.Enabled = false;
                btnStartGame.Cursor = Cursors.No;
                StartGame();
            }
        }
    }
}
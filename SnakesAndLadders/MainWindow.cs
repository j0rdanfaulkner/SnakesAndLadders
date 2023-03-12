namespace SnakesAndLadders
{
    public partial class MainWindow : Form
    {
        private int rolledNumber;
        private string player1Name;
        private string player2Name;
        private Point playerLabelLocation;
        private Space[,] board;
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
        /// populates the board (2D array of Space objects) with 100 spaces
        /// </summary>
        /// <param name="w"></param>
        /// <param name="h"></param>
        private void CreateBoard(int w, int h)
        {
            board = new Space[w, h];
            int i = 0;
            int j = 0;
            int x = 0;
            int y = 0;
            for (i = 0; i < w; i++)
            {
                switch (i)
                {
                    case 0:
                        x = 13;
                        break;
                    case 1:
                        x = 83;
                        break;
                    case 2:
                        x = 153;
                        break;
                    case 3:
                        x = 223;
                        break;
                    case 4:
                        x = 293;
                        break;
                    case 5:
                        x = 363;
                        break;
                    case 6:
                        x = 433;
                        break;
                    case 7:
                        x = 503;
                        break;
                    case 8:
                        x = 563;
                        break;
                    case 9:
                        x = 633;
                        break;
                    default:
                        break;
                }
                for (j = 0; j < h; j++)
                {
                    switch (j)
                    {
                        case 0:
                            y = 35;
                            break;
                        case 1:
                            y = 105;
                            break;
                        case 2:
                            y = 175;
                            break;
                        case 3:
                            y = 245;
                            break;
                        case 4:
                            y = 315;
                            break;
                        case 5:
                            y = 375;
                            break;
                        case 6:
                            y = 445;
                            break;
                        case 7:
                            y = 515;
                            break;
                        case 8:
                            y = 585;
                            break;
                        case 9:
                            y = 650;
                            break;
                        default:
                            break;
                    }
                    Space space = new Space(x, y);
                    space.GetSpaceProperties(x, y);
                    board[i, j] = space;
                }
            }
        }
        /// <summary>
        /// calls the CreateBoard method with the width and height of the board as parameters
        /// creates 3 player objects using the Player class (player 1 and player 2, as well as 'currentPlayer')
        /// chooses the starting player at random, then displays a message box to show who the starting player is
        /// calls the ResetGame method to start the game with a new board
        /// </summary>
        private void StartGame()
        {
            CreateBoard(10, 10);
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
            if (p.id == 1)
            {
                pbxCurrentTurnArrow.BackgroundImage = Properties.Resources.rightarrow;
            }
            else if (p.id == 2)
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
                currentPosition = p.position + 21;
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
            if (p.id == 1)
            {
                currentPlayer = player2;
            }
            else if (p.id == 2)
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
            int currentX = 0;
            int currentY = 0;
            Space s = new Space(0, 0);
            if (p.id == 1)
            {
                currentX = lblPlayer1.Location.X;
                currentY = lblPlayer1.Location.Y;
            }
            else if (p.id == 2)
            {
                currentX = lblPlayer2.Location.X;
                currentY = lblPlayer2.Location.Y;
            }
            switch (p.position)
            {
                case 1: // space with ladder (1 -> 38)
                    s = board[0, 9];
                    playerLabelLocation = s.position;
                    EventSpace(s.eventType, p);
                    s = board[2, 6];
                    playerLabelLocation = s.position;   // space 38 within array
                    break;
                case 2:
                    s = board[1, 9];
                    playerLabelLocation = s.position;
                    EventSpace(s.eventType, p);
                    break;
                case 3:
                    s = board[2, 9];
                    playerLabelLocation = s.position;
                    EventSpace(s.eventType, p);
                    break;
                case 4: // space with ladder (4 -> 14)
                    s = board[3, 9];
                    playerLabelLocation = s.position;
                    EventSpace(s.eventType, p);
                    s = board[6, 8];    // space 14 within array
                    playerLabelLocation = s.position;
                    break;
                case 5:
                    s = board[4, 9];
                    playerLabelLocation = s.position;
                    EventSpace(s.eventType, p);
                    break;
                case 6:
                    s = board[5, 9];
                    playerLabelLocation = s.position;
                    EventSpace(s.eventType, p);
                    break;
                case 7:
                    s = board[6, 9];
                    playerLabelLocation = s.position;
                    EventSpace(s.eventType, p);
                    break;
                case 8:
                    s = board[7, 9];
                    playerLabelLocation = s.position;
                    EventSpace(s.eventType, p);
                    break;
                case 9: // space with ladder (9 -> 31)
                    s = board[8, 9];
                    playerLabelLocation = s.position;
                    EventSpace(s.eventType, p);
                    s = board[9, 6];    // space 31 within array
                    playerLabelLocation = s.position;
                    break;
                case 10:
                    s = board[9, 9];
                    playerLabelLocation = s.position;
                    EventSpace(s.eventType, p);
                    break;
                case 11:
                    s = board[9, 8];
                    playerLabelLocation = s.position;
                    EventSpace(s.eventType, p);
                    break;
                case 12:
                    s = board[8, 8];
                    playerLabelLocation = s.position;
                    EventSpace(s.eventType, p);
                    break;
                case 13:
                    s = board[7, 8];
                    playerLabelLocation = s.position;
                    EventSpace(s.eventType, p);
                    break;
                case 14:
                    s = board[6, 8];
                    playerLabelLocation = s.position;
                    EventSpace(s.eventType, p);
                    break;
                case 15:
                    s = board[5, 8];
                    playerLabelLocation = s.position;
                    EventSpace(s.eventType, p);
                    break;
                case 16:
                    s = board[4, 8];
                    playerLabelLocation = s.position;
                    EventSpace(s.eventType, p);
                    break;
                case 17: // space with snake (17 -> 7)
                    s = board[3, 8];
                    playerLabelLocation = s.position;
                    EventSpace(s.eventType, p);
                    s = board[6, 9];    // space 7 within array
                    playerLabelLocation = s.position;
                    break;
                case 18:
                    s = board[2, 8];
                    playerLabelLocation = s.position;
                    EventSpace(s.eventType, p);
                    break;
                case 19:
                    s = board[1, 8];
                    playerLabelLocation = s.position;
                    EventSpace(s.eventType, p);
                    break;
                case 20:
                    s = board[0, 8];
                    playerLabelLocation = s.position;
                    EventSpace(s.eventType, p);
                    break;
                case 21: // space with ladder (21 -> 42)
                    s = board[0, 7];
                    playerLabelLocation = s.position;
                    EventSpace(s.eventType, p);
                    s = board[1, 5];    // space 42 within array
                    playerLabelLocation = s.position;
                    break;
                case 22:
                    s = board[1, 7];
                    playerLabelLocation = s.position;
                    EventSpace(s.eventType, p);
                    break;
                case 23:
                    s = board[2, 7];
                    playerLabelLocation = s.position;
                    EventSpace(s.eventType, p);
                    break;
                case 24:
                    s = board[3, 7];
                    playerLabelLocation = s.position;
                    EventSpace(s.eventType, p);
                    break;
                case 25:
                    s = board[4, 7];
                    playerLabelLocation = s.position;
                    EventSpace(s.eventType, p);
                    break;
                case 26:
                    s = board[5, 7];
                    playerLabelLocation = s.position;
                    EventSpace(s.eventType, p);
                    break;
                case 27:
                    s = board[6, 7];
                    playerLabelLocation = s.position;
                    EventSpace(s.eventType, p);
                    break;
                case 28: // space with ladder (28 -> 84)
                    s = board[7, 7];
                    playerLabelLocation = s.position;
                    EventSpace(s.eventType, p);
                    s = board[3, 1];    // space 84 within array
                    playerLabelLocation = s.position;
                    break;
                case 29:
                    s = board[8, 7];
                    playerLabelLocation = s.position;
                    EventSpace(s.eventType, p);
                    break;
                case 30:
                    s = board[9, 7];
                    playerLabelLocation = s.position;
                    EventSpace(s.eventType, p);
                    break;
                case 31:
                    s = board[9, 6];
                    playerLabelLocation = s.position;
                    EventSpace(s.eventType, p);
                    break;
                case 32:
                    s = board[8, 6];
                    playerLabelLocation = s.position;
                    EventSpace(s.eventType, p);
                    break;
                case 33:
                    s = board[7, 6];
                    playerLabelLocation = s.position;
                    EventSpace(s.eventType, p);
                    break;
                case 34:
                    s = board[6, 6];
                    playerLabelLocation = s.position;
                    EventSpace(s.eventType, p);
                    break;
                case 35:
                    s = board[5, 6];
                    playerLabelLocation = s.position;
                    EventSpace(s.eventType, p);
                    break;
                case 36:
                    s = board[4, 6];
                    playerLabelLocation = s.position;
                    EventSpace(s.eventType, p);
                    break;
                case 37:
                    s = board[3, 6];
                    playerLabelLocation = s.position;
                    EventSpace(s.eventType, p);
                    break;
                case 38:
                    s = board[2, 6];
                    playerLabelLocation = s.position;
                    EventSpace(s.eventType, p);
                    break;
                case 39:
                    s = board[1, 6];
                    playerLabelLocation = s.position;
                    EventSpace(s.eventType, p);
                    break;
                case 40:
                    s = board[0, 6];
                    playerLabelLocation = s.position;
                    EventSpace(s.eventType, p);
                    break;
                case 41:
                    s = board[0, 5];
                    playerLabelLocation = s.position;
                    EventSpace(s.eventType, p);
                    break;
                case 42:
                    s = board[1, 5];
                    playerLabelLocation = s.position;
                    EventSpace(s.eventType, p);
                    break;
                case 43:
                    s = board[2, 5];
                    playerLabelLocation = s.position;
                    EventSpace(s.eventType, p);
                    break;
                case 44:
                    s = board[3, 5];
                    playerLabelLocation = s.position;
                    EventSpace(s.eventType, p);
                    break;
                case 45:
                    s = board[4, 5];
                    playerLabelLocation = s.position;
                    EventSpace(s.eventType, p);
                    break;
                case 46:
                    s = board[5, 5];
                    playerLabelLocation = s.position;
                    EventSpace(s.eventType, p);
                    break;
                case 47:
                    s = board[6, 5];
                    playerLabelLocation = s.position;
                    EventSpace(s.eventType, p);
                    break;
                case 48:
                    s = board[7, 5];
                    playerLabelLocation = s.position;
                    EventSpace(s.eventType, p);
                    break;
                case 49:
                    s = board[8, 5];
                    playerLabelLocation = s.position;
                    EventSpace(s.eventType, p);
                    break;
                case 50:
                    s = board[9, 5];
                    playerLabelLocation = s.position;
                    EventSpace(s.eventType, p);
                    break;
                case 51: // space with ladder (51 -> 67)
                    s = board[9, 4];
                    playerLabelLocation = s.position;
                    EventSpace(s.eventType, p);
                    s = board[6, 3];    // space 67 within array
                    playerLabelLocation = s.position;
                    break;
                case 52:
                    s = board[8, 4];
                    playerLabelLocation = s.position;
                    EventSpace(s.eventType, p);
                    break;
                case 53:
                    s = board[7, 4];
                    playerLabelLocation = s.position;
                    EventSpace(s.eventType, p);
                    break;
                case 54: // space with snake (54 -> 34)
                    s = board[6, 4];
                    playerLabelLocation = s.position;
                    EventSpace(s.eventType, p);
                    s = board[6, 6];    // space 34 within array
                    playerLabelLocation = s.position;
                    break;
                case 55:
                    s = board[5, 4];
                    playerLabelLocation = s.position;
                    EventSpace(s.eventType, p);
                    break;
                case 56:
                    s = board[4, 4];
                    playerLabelLocation = s.position;
                    EventSpace(s.eventType, p);
                    break;
                case 57:
                    s = board[3, 4];
                    playerLabelLocation = s.position;
                    EventSpace(s.eventType, p);
                    break;
                case 58:
                    s = board[2, 4];
                    playerLabelLocation = s.position;
                    EventSpace(s.eventType, p);
                    break;
                case 59:
                    s = board[1, 4];
                    playerLabelLocation = s.position;
                    EventSpace(s.eventType, p);
                    break;
                case 60:
                    s = board[0, 4];
                    playerLabelLocation = s.position;
                    EventSpace(s.eventType, p);
                    break;
                case 61:
                    s = board[0, 3];
                    playerLabelLocation = s.position;
                    EventSpace(s.eventType, p);
                    break;
                case 62: // space with snake (62 -> 19)
                    s = board[1, 3];
                    playerLabelLocation = s.position;
                    EventSpace(s.eventType, p);
                    s = board[1, 8];    // space 19 within array
                    playerLabelLocation = s.position;
                    break;
                case 63:
                    s = board[2, 3];
                    playerLabelLocation = s.position;
                    EventSpace(s.eventType, p);
                    break;
                case 64: // space with snake (64 -> 60)
                    s = board[3, 3];
                    playerLabelLocation = s.position;
                    EventSpace(s.eventType, p);
                    s = board[0, 4];    // space 60 within array
                    playerLabelLocation = s.position;
                    break;
                case 65:
                    s = board[4, 3];
                    playerLabelLocation = s.position;
                    EventSpace(s.eventType, p);
                    break;
                case 66:
                    s = board[5, 3];
                    playerLabelLocation = s.position;
                    EventSpace(s.eventType, p);
                    break;
                case 67:
                    s = board[6, 3];
                    playerLabelLocation = s.position;
                    EventSpace(s.eventType, p);
                    break;
                case 68:
                    s = board[7, 3];
                    playerLabelLocation = s.position;
                    EventSpace(s.eventType, p);
                    break;
                case 69:
                    s = board[8, 3];
                    playerLabelLocation = s.position;
                    EventSpace(s.eventType, p);
                    break;
                case 70:
                    s = board[9, 3];
                    playerLabelLocation = s.position;
                    EventSpace(s.eventType, p);
                    break;
                case 71: // space with ladder (71 -> 91)
                    s = board[9, 2];
                    playerLabelLocation = s.position;
                    EventSpace(s.eventType, p);
                    s = board[9, 0];    // space 91 within array
                    playerLabelLocation = s.position;
                    break;
                case 72:
                    s = board[8, 2];
                    playerLabelLocation = s.position;
                    EventSpace(s.eventType, p);
                    break;
                case 73:
                    s = board[7, 2];
                    playerLabelLocation = s.position;
                    EventSpace(s.eventType, p);
                    break;
                case 74:
                    s = board[6, 2];
                    playerLabelLocation = s.position;
                    EventSpace(s.eventType, p);
                    break;
                case 75:
                    s = board[5, 2];
                    playerLabelLocation = s.position;
                    EventSpace(s.eventType, p);
                    break;
                case 76:
                    s = board[4, 2];
                    playerLabelLocation = s.position;
                    EventSpace(s.eventType, p);
                    break;
                case 77:
                    s = board[3, 2];
                    playerLabelLocation = s.position;
                    EventSpace(s.eventType, p);
                    break;
                case 78:
                    s = board[2, 2];
                    playerLabelLocation = s.position;
                    EventSpace(s.eventType, p);
                    break;
                case 79:
                    s = board[1, 2];
                    playerLabelLocation = s.position;
                    EventSpace(s.eventType, p);
                    break;
                case 80: // space with ladder (80 -> 100)
                    s = board[0, 2];
                    playerLabelLocation = s.position;
                    EventSpace(s.eventType, p);
                    s = board[0, 0];    // space 100 within array
                    playerLabelLocation = s.position;
                    break;
                case 81:
                    s = board[0, 1];
                    playerLabelLocation = s.position;
                    EventSpace(s.eventType, p);
                    break;
                case 82:
                    s = board[1, 1];
                    playerLabelLocation = s.position;
                    EventSpace(s.eventType, p);
                    break;
                case 83:
                    s = board[2, 1];
                    playerLabelLocation = s.position;
                    EventSpace(s.eventType, p);
                    break;
                case 84:
                    s = board[3, 1];
                    playerLabelLocation = s.position;
                    EventSpace(s.eventType, p);
                    break;
                case 85:
                    s = board[4, 1];
                    playerLabelLocation = s.position;
                    EventSpace(s.eventType, p);
                    break;
                case 86:
                    s = board[5, 1];
                    playerLabelLocation = s.position;
                    EventSpace(s.eventType, p);
                    break;
                case 87: // space with snake (87 -> 24)
                    s = board[6, 1];
                    playerLabelLocation = s.position;
                    EventSpace(s.eventType, p);
                    s = board[3, 7];    // space 24 within array
                    playerLabelLocation = s.position;
                    break;
                case 88:
                    s = board[7, 1];
                    playerLabelLocation = s.position;
                    EventSpace(s.eventType, p);
                    break;
                case 89:
                    s = board[8, 1];
                    playerLabelLocation = s.position;
                    EventSpace(s.eventType, p);
                    break;
                case 90:
                    s = board[9, 1];
                    playerLabelLocation = s.position;
                    EventSpace(s.eventType, p);
                    break;
                case 91:
                    s = board[9, 0];
                    playerLabelLocation = s.position;
                    EventSpace(s.eventType, p);
                    break;
                case 92:
                    s = board[8, 0];
                    playerLabelLocation = s.position;
                    EventSpace(s.eventType, p);
                    break;
                case 93: // space with snake (93 -> 73)
                    s = board[7, 0];
                    playerLabelLocation = s.position;
                    EventSpace(s.eventType, p);
                    s = board[7, 2];    // space 73 within array
                    playerLabelLocation = s.position;
                    break;
                case 94:
                    s = board[6, 0];
                    playerLabelLocation = s.position;
                    EventSpace(s.eventType, p);
                    break;
                case 95: // space with snake (95 -> 75)
                    s = board[5, 0];
                    playerLabelLocation = s.position;
                    EventSpace(s.eventType, p);
                    s = board[5, 2];    // space 73 within array
                    playerLabelLocation = s.position;
                    break;
                case 96:
                    s = board[4, 0];
                    playerLabelLocation = s.position;
                    EventSpace(s.eventType, p);
                    break;
                case 97:
                    s = board[3, 0];
                    playerLabelLocation = s.position;
                    EventSpace(s.eventType, p);
                    break;
                case 98: // space with snake (98 -> 79)
                    s = board[2, 0];
                    playerLabelLocation = s.position;
                    EventSpace(s.eventType, p);
                    s = board[1, 2];    // space 79 within array
                    playerLabelLocation = s.position;
                    break;
                case 99:
                    s = board[1, 0];
                    playerLabelLocation = s.position;
                    EventSpace(s.eventType, p);
                    break;
                case 100:
                    s = board[0, 0];
                    playerLabelLocation = s.position;
                    EventSpace(s.eventType, p);
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
        private void EventSpace(string eventType, Player p)
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
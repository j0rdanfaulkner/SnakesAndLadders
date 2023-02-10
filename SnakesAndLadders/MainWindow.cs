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
        }
        private int RollDice()
        {
            Random roll = new Random();
            rolledNumber = roll.Next(1, 7);
            return rolledNumber;
        }
        private void btnRollDice_Click(object sender, EventArgs e)
        {
            if (currentPlayer == 1)
            {
                RollDice();
                positionP1 = positionP1 + rolledNumber;
            }
            else if (currentPlayer == 2) 
            {
                RollDice();
                positionP2 = positionP2 + rolledNumber;
            }
        }
    }
}
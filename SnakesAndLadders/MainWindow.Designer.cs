namespace SnakesAndLadders
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            panel1 = new Panel();
            pnlGameArea = new Panel();
            pnlBoard = new Panel();
            lblPlayer2 = new Label();
            lblPlayer1 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            lblP2Name = new Label();
            lblP1Name = new Label();
            tbxP2Name = new TextBox();
            tbxP1Name = new TextBox();
            pbxP2EventSpace = new PictureBox();
            pbxP1EventSpace = new PictureBox();
            pbxCurrentTurnArrow = new PictureBox();
            btnStartGame = new Button();
            lblPlayer2PositionNumber = new Label();
            btnExit = new Button();
            lblPlayer1PositionNumber = new Label();
            btnRollDice = new Button();
            lblPlayer2Positions = new Label();
            lblPlayer1Positions = new Label();
            lblCurrentPositions = new Label();
            lblCurrentTurn = new Label();
            lblPlayer2Turn = new Label();
            lblPlayer1Turn = new Label();
            panel1.SuspendLayout();
            pnlGameArea.SuspendLayout();
            pnlBoard.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxP2EventSpace).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxP1EventSpace).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxCurrentTurnArrow).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pnlGameArea);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1280, 720);
            panel1.TabIndex = 0;
            // 
            // pnlGameArea
            // 
            pnlGameArea.BackColor = Color.Transparent;
            pnlGameArea.Controls.Add(pnlBoard);
            pnlGameArea.Controls.Add(panel2);
            pnlGameArea.Dock = DockStyle.Fill;
            pnlGameArea.Location = new Point(0, 0);
            pnlGameArea.Name = "pnlGameArea";
            pnlGameArea.Size = new Size(1280, 720);
            pnlGameArea.TabIndex = 0;
            // 
            // pnlBoard
            // 
            pnlBoard.Anchor = AnchorStyles.None;
            pnlBoard.BackgroundImage = Properties.Resources.background;
            pnlBoard.Controls.Add(lblPlayer2);
            pnlBoard.Controls.Add(lblPlayer1);
            pnlBoard.Location = new Point(12, 8);
            pnlBoard.Name = "pnlBoard";
            pnlBoard.Size = new Size(702, 702);
            pnlBoard.TabIndex = 1;
            // 
            // lblPlayer2
            // 
            lblPlayer2.AutoSize = true;
            lblPlayer2.BackColor = Color.Transparent;
            lblPlayer2.FlatStyle = FlatStyle.Flat;
            lblPlayer2.Font = new Font("Eurostile LT Std Bold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblPlayer2.ForeColor = Color.Turquoise;
            lblPlayer2.Location = new Point(17, 379);
            lblPlayer2.Name = "lblPlayer2";
            lblPlayer2.Size = new Size(53, 33);
            lblPlayer2.TabIndex = 2;
            lblPlayer2.Text = "P2";
            // 
            // lblPlayer1
            // 
            lblPlayer1.AutoSize = true;
            lblPlayer1.BackColor = Color.Transparent;
            lblPlayer1.FlatStyle = FlatStyle.Flat;
            lblPlayer1.Font = new Font("Eurostile LT Std Bold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblPlayer1.ForeColor = Color.BlueViolet;
            lblPlayer1.Location = new Point(493, 173);
            lblPlayer1.Name = "lblPlayer1";
            lblPlayer1.Size = new Size(53, 33);
            lblPlayer1.TabIndex = 1;
            lblPlayer1.Text = "P1";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(723, 8);
            panel2.Name = "panel2";
            panel2.Size = new Size(546, 704);
            panel2.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(lblP2Name);
            panel3.Controls.Add(lblP1Name);
            panel3.Controls.Add(tbxP2Name);
            panel3.Controls.Add(tbxP1Name);
            panel3.Controls.Add(pbxP2EventSpace);
            panel3.Controls.Add(pbxP1EventSpace);
            panel3.Controls.Add(pbxCurrentTurnArrow);
            panel3.Controls.Add(btnStartGame);
            panel3.Controls.Add(lblPlayer2PositionNumber);
            panel3.Controls.Add(btnExit);
            panel3.Controls.Add(lblPlayer1PositionNumber);
            panel3.Controls.Add(btnRollDice);
            panel3.Controls.Add(lblPlayer2Positions);
            panel3.Controls.Add(lblPlayer1Positions);
            panel3.Controls.Add(lblCurrentPositions);
            panel3.Controls.Add(lblCurrentTurn);
            panel3.Controls.Add(lblPlayer2Turn);
            panel3.Controls.Add(lblPlayer1Turn);
            panel3.Location = new Point(21, 9);
            panel3.Name = "panel3";
            panel3.Size = new Size(508, 674);
            panel3.TabIndex = 2;
            // 
            // lblP2Name
            // 
            lblP2Name.AutoSize = true;
            lblP2Name.Font = new Font("Eurostile LT Std Bold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblP2Name.Location = new Point(29, 408);
            lblP2Name.Name = "lblP2Name";
            lblP2Name.Size = new Size(226, 30);
            lblP2Name.TabIndex = 19;
            lblP2Name.Text = "Player 2's Name:";
            // 
            // lblP1Name
            // 
            lblP1Name.AutoSize = true;
            lblP1Name.Font = new Font("Eurostile LT Std Bold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblP1Name.Location = new Point(29, 340);
            lblP1Name.Name = "lblP1Name";
            lblP1Name.Size = new Size(226, 30);
            lblP1Name.TabIndex = 15;
            lblP1Name.Text = "Player 1's Name:";
            // 
            // tbxP2Name
            // 
            tbxP2Name.Font = new Font("Eurostile LT Std Bold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            tbxP2Name.Location = new Point(261, 400);
            tbxP2Name.Name = "tbxP2Name";
            tbxP2Name.Size = new Size(177, 37);
            tbxP2Name.TabIndex = 14;
            // 
            // tbxP1Name
            // 
            tbxP1Name.Font = new Font("Eurostile LT Std Bold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            tbxP1Name.Location = new Point(261, 332);
            tbxP1Name.Name = "tbxP1Name";
            tbxP1Name.Size = new Size(177, 37);
            tbxP1Name.TabIndex = 13;
            // 
            // pbxP2EventSpace
            // 
            pbxP2EventSpace.BackgroundImageLayout = ImageLayout.Zoom;
            pbxP2EventSpace.Location = new Point(459, 249);
            pbxP2EventSpace.Name = "pbxP2EventSpace";
            pbxP2EventSpace.Size = new Size(32, 32);
            pbxP2EventSpace.TabIndex = 12;
            pbxP2EventSpace.TabStop = false;
            // 
            // pbxP1EventSpace
            // 
            pbxP1EventSpace.BackgroundImageLayout = ImageLayout.Zoom;
            pbxP1EventSpace.Location = new Point(147, 249);
            pbxP1EventSpace.Name = "pbxP1EventSpace";
            pbxP1EventSpace.Size = new Size(32, 32);
            pbxP1EventSpace.TabIndex = 11;
            pbxP1EventSpace.TabStop = false;
            // 
            // pbxCurrentTurnArrow
            // 
            pbxCurrentTurnArrow.BackgroundImage = Properties.Resources.leftarrow;
            pbxCurrentTurnArrow.BackgroundImageLayout = ImageLayout.Zoom;
            pbxCurrentTurnArrow.Location = new Point(233, 89);
            pbxCurrentTurnArrow.Name = "pbxCurrentTurnArrow";
            pbxCurrentTurnArrow.Size = new Size(48, 48);
            pbxCurrentTurnArrow.TabIndex = 10;
            pbxCurrentTurnArrow.TabStop = false;
            // 
            // btnStartGame
            // 
            btnStartGame.BackColor = Color.DeepSkyBlue;
            btnStartGame.Cursor = Cursors.Hand;
            btnStartGame.FlatAppearance.BorderColor = Color.Black;
            btnStartGame.FlatAppearance.BorderSize = 3;
            btnStartGame.FlatAppearance.MouseDownBackColor = Color.LightSkyBlue;
            btnStartGame.FlatAppearance.MouseOverBackColor = Color.SteelBlue;
            btnStartGame.FlatStyle = FlatStyle.Flat;
            btnStartGame.ForeColor = Color.Black;
            btnStartGame.Location = new Point(161, 581);
            btnStartGame.Name = "btnStartGame";
            btnStartGame.Size = new Size(192, 84);
            btnStartGame.TabIndex = 9;
            btnStartGame.Text = "START GAME";
            btnStartGame.UseVisualStyleBackColor = false;
            btnStartGame.Click += btnStartGame_Click;
            // 
            // lblPlayer2PositionNumber
            // 
            lblPlayer2PositionNumber.AutoSize = true;
            lblPlayer2PositionNumber.Font = new Font("Eurostile LT Std Bold", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblPlayer2PositionNumber.Location = new Point(341, 245);
            lblPlayer2PositionNumber.MinimumSize = new Size(150, 36);
            lblPlayer2PositionNumber.Name = "lblPlayer2PositionNumber";
            lblPlayer2PositionNumber.Size = new Size(150, 36);
            lblPlayer2PositionNumber.TabIndex = 8;
            lblPlayer2PositionNumber.Text = "0";
            lblPlayer2PositionNumber.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Transparent;
            btnExit.BackgroundImage = Properties.Resources.exit;
            btnExit.BackgroundImageLayout = ImageLayout.Zoom;
            btnExit.Cursor = Cursors.Hand;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Location = new Point(408, 575);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(96, 96);
            btnExit.TabIndex = 1;
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // lblPlayer1PositionNumber
            // 
            lblPlayer1PositionNumber.AutoSize = true;
            lblPlayer1PositionNumber.Font = new Font("Eurostile LT Std Bold", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblPlayer1PositionNumber.Location = new Point(29, 245);
            lblPlayer1PositionNumber.MinimumSize = new Size(150, 36);
            lblPlayer1PositionNumber.Name = "lblPlayer1PositionNumber";
            lblPlayer1PositionNumber.Size = new Size(150, 36);
            lblPlayer1PositionNumber.TabIndex = 7;
            lblPlayer1PositionNumber.Text = "0";
            lblPlayer1PositionNumber.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnRollDice
            // 
            btnRollDice.BackColor = Color.Transparent;
            btnRollDice.BackgroundImage = Properties.Resources.dice;
            btnRollDice.BackgroundImageLayout = ImageLayout.Zoom;
            btnRollDice.Cursor = Cursors.Hand;
            btnRollDice.FlatAppearance.BorderSize = 0;
            btnRollDice.FlatStyle = FlatStyle.Flat;
            btnRollDice.Location = new Point(3, 575);
            btnRollDice.Name = "btnRollDice";
            btnRollDice.Size = new Size(96, 96);
            btnRollDice.TabIndex = 0;
            btnRollDice.UseVisualStyleBackColor = false;
            btnRollDice.Click += btnRollDice_Click;
            // 
            // lblPlayer2Positions
            // 
            lblPlayer2Positions.AutoSize = true;
            lblPlayer2Positions.Font = new Font("Eurostile LT Std Bold", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblPlayer2Positions.Location = new Point(341, 202);
            lblPlayer2Positions.MinimumSize = new Size(150, 36);
            lblPlayer2Positions.Name = "lblPlayer2Positions";
            lblPlayer2Positions.Size = new Size(150, 36);
            lblPlayer2Positions.TabIndex = 6;
            lblPlayer2Positions.Text = "Player 2";
            lblPlayer2Positions.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPlayer1Positions
            // 
            lblPlayer1Positions.AutoSize = true;
            lblPlayer1Positions.Font = new Font("Eurostile LT Std Bold", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblPlayer1Positions.Location = new Point(29, 202);
            lblPlayer1Positions.MinimumSize = new Size(150, 36);
            lblPlayer1Positions.Name = "lblPlayer1Positions";
            lblPlayer1Positions.Size = new Size(150, 36);
            lblPlayer1Positions.TabIndex = 5;
            lblPlayer1Positions.Text = "Player 1";
            lblPlayer1Positions.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCurrentPositions
            // 
            lblCurrentPositions.AutoSize = true;
            lblCurrentPositions.Font = new Font("Eurostile LT Std Bold", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblCurrentPositions.Location = new Point(119, 149);
            lblCurrentPositions.Name = "lblCurrentPositions";
            lblCurrentPositions.Size = new Size(289, 36);
            lblCurrentPositions.TabIndex = 4;
            lblCurrentPositions.Text = "Current Positions:";
            // 
            // lblCurrentTurn
            // 
            lblCurrentTurn.AutoSize = true;
            lblCurrentTurn.Font = new Font("Eurostile LT Std Bold", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblCurrentTurn.Location = new Point(147, 50);
            lblCurrentTurn.Name = "lblCurrentTurn";
            lblCurrentTurn.Size = new Size(221, 36);
            lblCurrentTurn.TabIndex = 3;
            lblCurrentTurn.Text = "Current Turn:";
            // 
            // lblPlayer2Turn
            // 
            lblPlayer2Turn.AutoSize = true;
            lblPlayer2Turn.Font = new Font("Eurostile LT Std Bold", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblPlayer2Turn.Location = new Point(341, 97);
            lblPlayer2Turn.MinimumSize = new Size(150, 36);
            lblPlayer2Turn.Name = "lblPlayer2Turn";
            lblPlayer2Turn.Size = new Size(150, 36);
            lblPlayer2Turn.TabIndex = 1;
            lblPlayer2Turn.Text = "Player 2";
            lblPlayer2Turn.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPlayer1Turn
            // 
            lblPlayer1Turn.AutoSize = true;
            lblPlayer1Turn.Font = new Font("Eurostile LT Std Bold", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblPlayer1Turn.Location = new Point(29, 97);
            lblPlayer1Turn.MinimumSize = new Size(150, 36);
            lblPlayer1Turn.Name = "lblPlayer1Turn";
            lblPlayer1Turn.Size = new Size(150, 36);
            lblPlayer1Turn.TabIndex = 0;
            lblPlayer1Turn.Text = "Player 1";
            lblPlayer1Turn.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(1280, 720);
            Controls.Add(panel1);
            Font = new Font("Eurostile LT Std Bold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximumSize = new Size(1296, 759);
            MinimumSize = new Size(1296, 759);
            Name = "MainWindow";
            Text = "Snakes and Ladders";
            panel1.ResumeLayout(false);
            pnlGameArea.ResumeLayout(false);
            pnlBoard.ResumeLayout(false);
            pnlBoard.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbxP2EventSpace).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxP1EventSpace).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxCurrentTurnArrow).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel pnlGameArea;
        private Panel panel2;
        private Button btnRollDice;
        private Panel pnlBoard;
        private Button btnExit;
        private Panel panel3;
        private Label lblPlayer2PositionNumber;
        private Label lblPlayer1PositionNumber;
        private Label lblPlayer2Positions;
        private Label lblPlayer1Positions;
        private Label lblCurrentPositions;
        private Label lblCurrentTurn;
        private Label lblPlayer2Turn;
        private Label lblPlayer1Turn;
        private Label lblPlayer1;
        private Label lblPlayer2;
        private Button btnStartGame;
        private PictureBox pbxCurrentTurnArrow;
        private PictureBox pbxP2EventSpace;
        private PictureBox pbxP1EventSpace;
        private Label lblP2Name;
        private Label lblP1Name;
        private TextBox tbxP2Name;
        private TextBox tbxP1Name;
    }
}
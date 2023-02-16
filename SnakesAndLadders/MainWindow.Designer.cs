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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlGameArea = new System.Windows.Forms.Panel();
            this.pnlBoard = new System.Windows.Forms.Panel();
            this.lblPlayer2 = new System.Windows.Forms.Label();
            this.lblPlayer1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblP2Name = new System.Windows.Forms.Label();
            this.lblP1Name = new System.Windows.Forms.Label();
            this.tbxP2Name = new System.Windows.Forms.TextBox();
            this.tbxP1Name = new System.Windows.Forms.TextBox();
            this.pbxP2EventSpace = new System.Windows.Forms.PictureBox();
            this.pbxP1EventSpace = new System.Windows.Forms.PictureBox();
            this.pbxCurrentTurnArrow = new System.Windows.Forms.PictureBox();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.lblPlayer2PositionNumber = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblPlayer1PositionNumber = new System.Windows.Forms.Label();
            this.btnRollDice = new System.Windows.Forms.Button();
            this.lblPlayer2Positions = new System.Windows.Forms.Label();
            this.lblPlayer1Positions = new System.Windows.Forms.Label();
            this.lblCurrentPositions = new System.Windows.Forms.Label();
            this.lblCurrentTurn = new System.Windows.Forms.Label();
            this.lblPlayer2Turn = new System.Windows.Forms.Label();
            this.lblPlayer1Turn = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnlGameArea.SuspendLayout();
            this.pnlBoard.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxP2EventSpace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxP1EventSpace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCurrentTurnArrow)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnlGameArea);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1280, 720);
            this.panel1.TabIndex = 0;
            // 
            // pnlGameArea
            // 
            this.pnlGameArea.BackColor = System.Drawing.Color.Transparent;
            this.pnlGameArea.Controls.Add(this.pnlBoard);
            this.pnlGameArea.Controls.Add(this.panel2);
            this.pnlGameArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGameArea.Location = new System.Drawing.Point(0, 0);
            this.pnlGameArea.Name = "pnlGameArea";
            this.pnlGameArea.Size = new System.Drawing.Size(1280, 720);
            this.pnlGameArea.TabIndex = 0;
            // 
            // pnlBoard
            // 
            this.pnlBoard.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlBoard.BackgroundImage = global::SnakesAndLadders.Properties.Resources.background;
            this.pnlBoard.Controls.Add(this.lblPlayer2);
            this.pnlBoard.Controls.Add(this.lblPlayer1);
            this.pnlBoard.Location = new System.Drawing.Point(12, 8);
            this.pnlBoard.Name = "pnlBoard";
            this.pnlBoard.Size = new System.Drawing.Size(702, 702);
            this.pnlBoard.TabIndex = 1;
            // 
            // lblPlayer2
            // 
            this.lblPlayer2.AutoSize = true;
            this.lblPlayer2.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayer2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPlayer2.Font = new System.Drawing.Font("Eurostile LT Std Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPlayer2.ForeColor = System.Drawing.Color.Turquoise;
            this.lblPlayer2.Location = new System.Drawing.Point(153, 445);
            this.lblPlayer2.Name = "lblPlayer2";
            this.lblPlayer2.Size = new System.Drawing.Size(53, 33);
            this.lblPlayer2.TabIndex = 2;
            this.lblPlayer2.Text = "P2";
            // 
            // lblPlayer1
            // 
            this.lblPlayer1.AutoSize = true;
            this.lblPlayer1.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayer1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPlayer1.Font = new System.Drawing.Font("Eurostile LT Std Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPlayer1.ForeColor = System.Drawing.Color.BlueViolet;
            this.lblPlayer1.Location = new System.Drawing.Point(292, 40);
            this.lblPlayer1.Name = "lblPlayer1";
            this.lblPlayer1.Size = new System.Drawing.Size(53, 33);
            this.lblPlayer1.TabIndex = 1;
            this.lblPlayer1.Text = "P1";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(723, 8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(546, 704);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblP2Name);
            this.panel3.Controls.Add(this.lblP1Name);
            this.panel3.Controls.Add(this.tbxP2Name);
            this.panel3.Controls.Add(this.tbxP1Name);
            this.panel3.Controls.Add(this.pbxP2EventSpace);
            this.panel3.Controls.Add(this.pbxP1EventSpace);
            this.panel3.Controls.Add(this.pbxCurrentTurnArrow);
            this.panel3.Controls.Add(this.btnStartGame);
            this.panel3.Controls.Add(this.lblPlayer2PositionNumber);
            this.panel3.Controls.Add(this.btnExit);
            this.panel3.Controls.Add(this.lblPlayer1PositionNumber);
            this.panel3.Controls.Add(this.btnRollDice);
            this.panel3.Controls.Add(this.lblPlayer2Positions);
            this.panel3.Controls.Add(this.lblPlayer1Positions);
            this.panel3.Controls.Add(this.lblCurrentPositions);
            this.panel3.Controls.Add(this.lblCurrentTurn);
            this.panel3.Controls.Add(this.lblPlayer2Turn);
            this.panel3.Controls.Add(this.lblPlayer1Turn);
            this.panel3.Location = new System.Drawing.Point(21, 9);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(508, 674);
            this.panel3.TabIndex = 2;
            // 
            // lblP2Name
            // 
            this.lblP2Name.AutoSize = true;
            this.lblP2Name.Font = new System.Drawing.Font("Eurostile LT Std Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblP2Name.Location = new System.Drawing.Point(29, 408);
            this.lblP2Name.Name = "lblP2Name";
            this.lblP2Name.Size = new System.Drawing.Size(226, 30);
            this.lblP2Name.TabIndex = 19;
            this.lblP2Name.Text = "Player 2\'s Name:";
            // 
            // lblP1Name
            // 
            this.lblP1Name.AutoSize = true;
            this.lblP1Name.Font = new System.Drawing.Font("Eurostile LT Std Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblP1Name.Location = new System.Drawing.Point(29, 340);
            this.lblP1Name.Name = "lblP1Name";
            this.lblP1Name.Size = new System.Drawing.Size(226, 30);
            this.lblP1Name.TabIndex = 15;
            this.lblP1Name.Text = "Player 1\'s Name:";
            // 
            // tbxP2Name
            // 
            this.tbxP2Name.Font = new System.Drawing.Font("Eurostile LT Std Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbxP2Name.Location = new System.Drawing.Point(261, 400);
            this.tbxP2Name.Name = "tbxP2Name";
            this.tbxP2Name.Size = new System.Drawing.Size(177, 37);
            this.tbxP2Name.TabIndex = 14;
            // 
            // tbxP1Name
            // 
            this.tbxP1Name.Font = new System.Drawing.Font("Eurostile LT Std Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbxP1Name.Location = new System.Drawing.Point(261, 332);
            this.tbxP1Name.Name = "tbxP1Name";
            this.tbxP1Name.Size = new System.Drawing.Size(177, 37);
            this.tbxP1Name.TabIndex = 13;
            // 
            // pbxP2EventSpace
            // 
            this.pbxP2EventSpace.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxP2EventSpace.Location = new System.Drawing.Point(459, 249);
            this.pbxP2EventSpace.Name = "pbxP2EventSpace";
            this.pbxP2EventSpace.Size = new System.Drawing.Size(32, 32);
            this.pbxP2EventSpace.TabIndex = 12;
            this.pbxP2EventSpace.TabStop = false;
            // 
            // pbxP1EventSpace
            // 
            this.pbxP1EventSpace.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxP1EventSpace.Location = new System.Drawing.Point(147, 249);
            this.pbxP1EventSpace.Name = "pbxP1EventSpace";
            this.pbxP1EventSpace.Size = new System.Drawing.Size(32, 32);
            this.pbxP1EventSpace.TabIndex = 11;
            this.pbxP1EventSpace.TabStop = false;
            // 
            // pbxCurrentTurnArrow
            // 
            this.pbxCurrentTurnArrow.BackgroundImage = global::SnakesAndLadders.Properties.Resources.leftarrow;
            this.pbxCurrentTurnArrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxCurrentTurnArrow.Location = new System.Drawing.Point(233, 89);
            this.pbxCurrentTurnArrow.Name = "pbxCurrentTurnArrow";
            this.pbxCurrentTurnArrow.Size = new System.Drawing.Size(48, 48);
            this.pbxCurrentTurnArrow.TabIndex = 10;
            this.pbxCurrentTurnArrow.TabStop = false;
            // 
            // btnStartGame
            // 
            this.btnStartGame.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnStartGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStartGame.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnStartGame.FlatAppearance.BorderSize = 3;
            this.btnStartGame.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnStartGame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnStartGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartGame.ForeColor = System.Drawing.Color.Black;
            this.btnStartGame.Location = new System.Drawing.Point(161, 581);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(192, 84);
            this.btnStartGame.TabIndex = 9;
            this.btnStartGame.Text = "START GAME";
            this.btnStartGame.UseVisualStyleBackColor = false;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // lblPlayer2PositionNumber
            // 
            this.lblPlayer2PositionNumber.AutoSize = true;
            this.lblPlayer2PositionNumber.Font = new System.Drawing.Font("Eurostile LT Std Bold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPlayer2PositionNumber.Location = new System.Drawing.Point(341, 245);
            this.lblPlayer2PositionNumber.MinimumSize = new System.Drawing.Size(150, 36);
            this.lblPlayer2PositionNumber.Name = "lblPlayer2PositionNumber";
            this.lblPlayer2PositionNumber.Size = new System.Drawing.Size(150, 36);
            this.lblPlayer2PositionNumber.TabIndex = 8;
            this.lblPlayer2PositionNumber.Text = "0";
            this.lblPlayer2PositionNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImage = global::SnakesAndLadders.Properties.Resources.exit;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(408, 575);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(96, 96);
            this.btnExit.TabIndex = 1;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblPlayer1PositionNumber
            // 
            this.lblPlayer1PositionNumber.AutoSize = true;
            this.lblPlayer1PositionNumber.Font = new System.Drawing.Font("Eurostile LT Std Bold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPlayer1PositionNumber.Location = new System.Drawing.Point(29, 245);
            this.lblPlayer1PositionNumber.MinimumSize = new System.Drawing.Size(150, 36);
            this.lblPlayer1PositionNumber.Name = "lblPlayer1PositionNumber";
            this.lblPlayer1PositionNumber.Size = new System.Drawing.Size(150, 36);
            this.lblPlayer1PositionNumber.TabIndex = 7;
            this.lblPlayer1PositionNumber.Text = "0";
            this.lblPlayer1PositionNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRollDice
            // 
            this.btnRollDice.BackColor = System.Drawing.Color.Transparent;
            this.btnRollDice.BackgroundImage = global::SnakesAndLadders.Properties.Resources.dice;
            this.btnRollDice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRollDice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRollDice.FlatAppearance.BorderSize = 0;
            this.btnRollDice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRollDice.Location = new System.Drawing.Point(3, 575);
            this.btnRollDice.Name = "btnRollDice";
            this.btnRollDice.Size = new System.Drawing.Size(96, 96);
            this.btnRollDice.TabIndex = 0;
            this.btnRollDice.UseVisualStyleBackColor = false;
            this.btnRollDice.Click += new System.EventHandler(this.btnRollDice_Click);
            // 
            // lblPlayer2Positions
            // 
            this.lblPlayer2Positions.AutoSize = true;
            this.lblPlayer2Positions.Font = new System.Drawing.Font("Eurostile LT Std Bold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPlayer2Positions.Location = new System.Drawing.Point(341, 202);
            this.lblPlayer2Positions.MinimumSize = new System.Drawing.Size(150, 36);
            this.lblPlayer2Positions.Name = "lblPlayer2Positions";
            this.lblPlayer2Positions.Size = new System.Drawing.Size(150, 36);
            this.lblPlayer2Positions.TabIndex = 6;
            this.lblPlayer2Positions.Text = "Player 2";
            this.lblPlayer2Positions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlayer1Positions
            // 
            this.lblPlayer1Positions.AutoSize = true;
            this.lblPlayer1Positions.Font = new System.Drawing.Font("Eurostile LT Std Bold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPlayer1Positions.Location = new System.Drawing.Point(29, 202);
            this.lblPlayer1Positions.MinimumSize = new System.Drawing.Size(150, 36);
            this.lblPlayer1Positions.Name = "lblPlayer1Positions";
            this.lblPlayer1Positions.Size = new System.Drawing.Size(150, 36);
            this.lblPlayer1Positions.TabIndex = 5;
            this.lblPlayer1Positions.Text = "Player 1";
            this.lblPlayer1Positions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCurrentPositions
            // 
            this.lblCurrentPositions.AutoSize = true;
            this.lblCurrentPositions.Font = new System.Drawing.Font("Eurostile LT Std Bold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCurrentPositions.Location = new System.Drawing.Point(119, 149);
            this.lblCurrentPositions.Name = "lblCurrentPositions";
            this.lblCurrentPositions.Size = new System.Drawing.Size(289, 36);
            this.lblCurrentPositions.TabIndex = 4;
            this.lblCurrentPositions.Text = "Current Positions:";
            // 
            // lblCurrentTurn
            // 
            this.lblCurrentTurn.AutoSize = true;
            this.lblCurrentTurn.Font = new System.Drawing.Font("Eurostile LT Std Bold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCurrentTurn.Location = new System.Drawing.Point(147, 50);
            this.lblCurrentTurn.Name = "lblCurrentTurn";
            this.lblCurrentTurn.Size = new System.Drawing.Size(221, 36);
            this.lblCurrentTurn.TabIndex = 3;
            this.lblCurrentTurn.Text = "Current Turn:";
            // 
            // lblPlayer2Turn
            // 
            this.lblPlayer2Turn.AutoSize = true;
            this.lblPlayer2Turn.Font = new System.Drawing.Font("Eurostile LT Std Bold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPlayer2Turn.Location = new System.Drawing.Point(341, 97);
            this.lblPlayer2Turn.MinimumSize = new System.Drawing.Size(150, 36);
            this.lblPlayer2Turn.Name = "lblPlayer2Turn";
            this.lblPlayer2Turn.Size = new System.Drawing.Size(150, 36);
            this.lblPlayer2Turn.TabIndex = 1;
            this.lblPlayer2Turn.Text = "Player 2";
            this.lblPlayer2Turn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlayer1Turn
            // 
            this.lblPlayer1Turn.AutoSize = true;
            this.lblPlayer1Turn.Font = new System.Drawing.Font("Eurostile LT Std Bold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPlayer1Turn.Location = new System.Drawing.Point(29, 97);
            this.lblPlayer1Turn.MinimumSize = new System.Drawing.Size(150, 36);
            this.lblPlayer1Turn.Name = "lblPlayer1Turn";
            this.lblPlayer1Turn.Size = new System.Drawing.Size(150, 36);
            this.lblPlayer1Turn.TabIndex = 0;
            this.lblPlayer1Turn.Text = "Player 1";
            this.lblPlayer1Turn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Eurostile LT Std Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1296, 759);
            this.MinimumSize = new System.Drawing.Size(1296, 759);
            this.Name = "MainWindow";
            this.Text = "Snakes and Ladders";
            this.panel1.ResumeLayout(false);
            this.pnlGameArea.ResumeLayout(false);
            this.pnlBoard.ResumeLayout(false);
            this.pnlBoard.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxP2EventSpace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxP1EventSpace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCurrentTurnArrow)).EndInit();
            this.ResumeLayout(false);

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
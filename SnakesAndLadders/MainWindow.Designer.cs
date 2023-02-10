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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlGameArea = new System.Windows.Forms.Panel();
            this.pnlBoard = new System.Windows.Forms.Panel();
            this.lblPlayer1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRollDice = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.pnlGameArea.SuspendLayout();
            this.pnlBoard.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.pnlGameArea.Location = new System.Drawing.Point(0, 0);
            this.pnlGameArea.Name = "pnlGameArea";
            this.pnlGameArea.Size = new System.Drawing.Size(1280, 720);
            this.pnlGameArea.TabIndex = 0;
            // 
            // pnlBoard
            // 
            this.pnlBoard.BackgroundImage = global::SnakesAndLadders.Properties.Resources.background;
            this.pnlBoard.Controls.Add(this.lblPlayer1);
            this.pnlBoard.Location = new System.Drawing.Point(12, 8);
            this.pnlBoard.Name = "pnlBoard";
            this.pnlBoard.Size = new System.Drawing.Size(702, 702);
            this.pnlBoard.TabIndex = 1;
            // 
            // lblPlayer1
            // 
            this.lblPlayer1.AutoSize = true;
            this.lblPlayer1.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayer1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPlayer1.Font = new System.Drawing.Font("Eurostile LT Std Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPlayer1.ForeColor = System.Drawing.Color.BlueViolet;
            this.lblPlayer1.Location = new System.Drawing.Point(16, 640);
            this.lblPlayer1.Name = "lblPlayer1";
            this.lblPlayer1.Size = new System.Drawing.Size(53, 33);
            this.lblPlayer1.TabIndex = 1;
            this.lblPlayer1.Text = "P1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnRollDice);
            this.panel2.Location = new System.Drawing.Point(723, 8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(546, 704);
            this.panel2.TabIndex = 0;
            // 
            // btnRollDice
            // 
            this.btnRollDice.BackColor = System.Drawing.Color.DarkGray;
            this.btnRollDice.BackgroundImage = global::SnakesAndLadders.Properties.Resources.dice;
            this.btnRollDice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRollDice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRollDice.FlatAppearance.BorderSize = 0;
            this.btnRollDice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRollDice.Location = new System.Drawing.Point(14, 596);
            this.btnRollDice.Name = "btnRollDice";
            this.btnRollDice.Size = new System.Drawing.Size(96, 96);
            this.btnRollDice.TabIndex = 0;
            this.btnRollDice.UseVisualStyleBackColor = false;
            this.btnRollDice.Click += new System.EventHandler(this.btnRollDice_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Eurostile LT Std Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainWindow";
            this.Text = "Snakes and Ladders";
            this.panel1.ResumeLayout(false);
            this.pnlGameArea.ResumeLayout(false);
            this.pnlBoard.ResumeLayout(false);
            this.pnlBoard.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel pnlGameArea;
        private Panel panel2;
        private Button btnRollDice;
        private Label lblPlayer1;
        private Panel pnlBoard;
    }
}
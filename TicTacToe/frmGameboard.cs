namespace TicTacToe
{
    public partial class frmGameboard : Form
    {
        Button[] btnCells;
        chrPlayer[] chrPlayers;

        private bool IsWinnerDetermined = false;

        public frmGameboard()
        {
            InitializeComponent();

            SetGameState();
        }

        private void SetGameState()
        {
            btnCells = new Button[]
            {
                btnCell1, btnCell2, btnCell3, 
                btnCell4, btnCell5, btnCell6, 
                btnCell7, btnCell8, btnCell9
            };

            InitializeFirstTurn();
        }

        private void InitializeFirstTurn()
        {
            chrPlayers = new chrPlayer[] { new chrPlayer("X", Color.Green), new chrPlayer("O", Color.Red) };

            stateTurnQueue.IntializeTurnQueue(chrPlayers.Length);

            chrPlayer currentPlayer = chrPlayers[stateTurnQueue.AssignFirstTurnPlayerIndex()];

            stateTurnQueue.currentPlayer = currentPlayer;
            ShowCurrentPlayerTurn();
        }

        private void SetGameManagerBoard()
        {
            int I = 0;
            foreach (Button btnCell in btnCells)
            {
                stateConditionsManager.board[I] = btnCell.Text;
                I++;
            }
        }

        private void ShowCurrentPlayerTurn()
        {
            txtHeader.Text = String.Format("{0} turn", stateTurnQueue.currentPlayer.playerSymbol);
        }

        private void ProcessTurn(Button btnCell)
        {
            string headerTxt = "";

            stateConditionsManager.turnCount++;

            if (stateConditionsManager.hasWinner)
                return;

            if (!String.IsNullOrEmpty(btnCell.Text))
                return;

            btnCell.Text = stateTurnQueue.currentPlayer.playerSymbol;

            SetGameManagerBoard();

            // One player has to at least have completed 3 turns and the other 2, so the minimum amount of turns you can win in is 5
            if (stateConditionsManager.turnCount >= 5)
            {
                // This should be fine because it's turn based, which means that one person can win per turn only
                foreach (chrPlayer player in chrPlayers)
                {
                    if (stateConditionsManager.DetermineWinner(player.playerSymbol, out headerTxt))
                    {
                        IsWinnerDetermined = true;

                        ShowWinner(headerTxt, player.foreColor);
                        break;
                    }
                }
            }

            // Oh this entire giant function could be refactored even further.
            if (!IsWinnerDetermined)
            {
                if (stateConditionsManager.turnCount != 9)
                {
                    stateTurnQueue.currentPlayer = chrPlayers[stateTurnQueue.UpdateCurrentPlayerIndex()];
                    ShowCurrentPlayerTurn();
                }
                else
                    txtHeader.Text = headerTxt;
            }
        }

        private void ShowWinner(string headerTxt, Color winnerColor)
        {
            txtHeader.Text = headerTxt;

            // Get the winner, color the winning cells the actual winner's color
            foreach (int winningCell in stateConditionsManager.winningCells)
                btnCells[winningCell].ForeColor = winnerColor;
        }

        private void btnCell1_Click(object sender, EventArgs e)
        {
            ProcessTurn(btnCells[0]);
        }

        private void btnCell2_Click(object sender, EventArgs e)
        {
            ProcessTurn(btnCells[1]);
        }

        private void btnCell3_Click(object sender, EventArgs e)
        {
            ProcessTurn(btnCells[2]);
        }

        private void btnCell4_Click(object sender, EventArgs e)
        {
            ProcessTurn(btnCells[3]);
        }

        private void btnCell5_Click(object sender, EventArgs e)
        {
            ProcessTurn(btnCells[4]);
        }

        private void btnCell6_Click(object sender, EventArgs e)
        {
            ProcessTurn(btnCells[5]);
        }

        private void btnCell7_Click(object sender, EventArgs e)
        {
            ProcessTurn(btnCells[6]);
        }

        private void btnCell8_Click(object sender, EventArgs e)
        {
            ProcessTurn(btnCells[7]);
        }

        private void btnCell9_Click(object sender, EventArgs e)
        {
            ProcessTurn(btnCells[8]);
        }
    }
}

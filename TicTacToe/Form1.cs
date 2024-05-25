namespace TicTacToe
{
    public partial class Form1 : Form 
    
    {
        public Form1()
        {
            
            InitializeComponent();
            TicTacToeLogic.firstTurn();
            
        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "" && TicTacToeLogic.hasWon == false) {
                if (TicTacToeLogic.getPlayer1Turn() == true)
                {
                    string turnX = "X";
                    button1.Text = turnX;
                    TicTacToeLogic.player1_turn = false;
                    TicTacToeLogic.turnCount++;
                    textBox1.Text = "O turn";
                    TicTacToeLogic.checkForWinner();
                }
                else
                {
                    string turnY = "O";
                    button1.Text = turnY;
                    TicTacToeLogic.player1_turn = true;
                    TicTacToeLogic.turnCount++;
                    textBox1.Text = "X turn";
                    TicTacToeLogic.checkForWinner();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "" && TicTacToeLogic.hasWon == false)
            {
                if (TicTacToeLogic.getPlayer1Turn() == true)
                {
                    string turnX = "X";
                    button2.Text = turnX;
                    TicTacToeLogic.player1_turn = false;
                    TicTacToeLogic.turnCount++;
                    textBox1.Text = "O turn";
                    TicTacToeLogic.checkForWinner();
                }
                else
                {
                    string turnY = "O";
                    button2.Text = turnY;
                    TicTacToeLogic.player1_turn = true;
                    TicTacToeLogic.turnCount++;
                    textBox1.Text = "X turn";
                    TicTacToeLogic.checkForWinner();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == "" && TicTacToeLogic.hasWon == false)
            {
                if (TicTacToeLogic.getPlayer1Turn() == true)
                {
                    string turnX = "X";
                    button3.Text = turnX;
                    TicTacToeLogic.player1_turn = false;
                    TicTacToeLogic.turnCount++;
                    textBox1.Text = "O turn";
                    TicTacToeLogic.checkForWinner();
                }
                else
                {
                    string turnY = "O";
                    button3.Text = turnY;
                    TicTacToeLogic.player1_turn = true;
                    TicTacToeLogic.turnCount++;
                    textBox1.Text = "X turn";
                    TicTacToeLogic.checkForWinner();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.Text == "" && TicTacToeLogic.hasWon == false)
            {
                if (TicTacToeLogic.getPlayer1Turn() == true)
                {
                    string turnX = "X";
                    button4.Text = turnX;
                    TicTacToeLogic.player1_turn = false;
                    TicTacToeLogic.turnCount++;
                    textBox1.Text = "O turn";
                    TicTacToeLogic.checkForWinner();
                }
                else
                {
                    string turnY = "O";
                    button4.Text = turnY;
                    TicTacToeLogic.player1_turn = true;
                    TicTacToeLogic.turnCount++;
                    textBox1.Text = "X turn";
                    TicTacToeLogic.checkForWinner();
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button5.Text == "" && TicTacToeLogic.hasWon == false)
            {
                if (TicTacToeLogic.getPlayer1Turn() == true)
                {
                    string turnX = "X";
                    button5.Text = turnX;
                    TicTacToeLogic.player1_turn = false;
                    TicTacToeLogic.turnCount++;
                    textBox1.Text = "O turn";
                    TicTacToeLogic.checkForWinner();
                }
                else
                {
                    string turnY = "O";
                    button5.Text = turnY;
                    TicTacToeLogic.player1_turn = true;
                    TicTacToeLogic.turnCount++;
                    textBox1.Text = "X turn";
                    TicTacToeLogic.checkForWinner();
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button6.Text == "" && TicTacToeLogic.hasWon == false)
            {
                if (TicTacToeLogic.getPlayer1Turn() == true)
                {
                    string turnX = "X";
                    button6.Text = turnX;
                    TicTacToeLogic.player1_turn = false;
                    TicTacToeLogic.turnCount++;
                    textBox1.Text = "O turn";
                    TicTacToeLogic.checkForWinner();
                }
                else
                {
                    string turnY = "O";
                    button6.Text = turnY;
                    TicTacToeLogic.player1_turn = true;
                    TicTacToeLogic.turnCount++;
                    textBox1.Text = "X turn";
                    TicTacToeLogic.checkForWinner();
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button7.Text == "" && TicTacToeLogic.hasWon == false)
            {
                if (TicTacToeLogic.getPlayer1Turn() == true)
                {
                    string turnX = "X";
                    button7.Text = turnX;
                    TicTacToeLogic.player1_turn = false;
                    TicTacToeLogic.turnCount++;
                    textBox1.Text = "O turn";
                    TicTacToeLogic.checkForWinner();
                }
                else
                {
                    string turnY = "O";
                    button7.Text = turnY;
                    TicTacToeLogic.player1_turn = true;
                    TicTacToeLogic.turnCount++;
                    textBox1.Text = "X turn";
                    TicTacToeLogic.checkForWinner();
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (button8.Text == "" && TicTacToeLogic.hasWon == false)
            {
                if (TicTacToeLogic.getPlayer1Turn() == true)
                {
                    string turnX = "X";
                    button8.Text = turnX;
                    TicTacToeLogic.player1_turn = false;
                    TicTacToeLogic.turnCount++;
                    textBox1.Text = "O turn";
                    TicTacToeLogic.checkForWinner();
                }
                else
                {
                    string turnY = "O";
                    button8.Text = turnY;
                    TicTacToeLogic.player1_turn = true;
                    TicTacToeLogic.turnCount++;
                    textBox1.Text = "X turn";
                    TicTacToeLogic.checkForWinner();
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (button9.Text == "" && TicTacToeLogic.hasWon == false)
                {
                if (TicTacToeLogic.getPlayer1Turn() == true)
                {
                    string turnX = "X";
                    button9.Text = turnX;
                    TicTacToeLogic.player1_turn = false;
                    TicTacToeLogic.turnCount++;
                    textBox1.Text = "O turn";
                    TicTacToeLogic.checkForWinner();
                }
                else
                {
                    string turnY = "O";
                    button9.Text = turnY;
                    TicTacToeLogic.player1_turn = true;
                    TicTacToeLogic.turnCount++;
                    textBox1.Text = "X turn";
                    TicTacToeLogic.checkForWinner();
                }
            }
        }
    }
}

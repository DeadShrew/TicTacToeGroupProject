using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicTacToe;

namespace TicTacToe.UnitTests
{
    [TestClass]
    public class Form1Tests
    {
        [TestMethod]
        public void Button1_Click_PlayerXTurn()
        {
            TicTacToeLogic.player1_turn = true;
            Form1.button1.PerformClick();
            Assert.AreEqual("X", Form1.button1.Text);
            Assert.IsFalse(TicTacToeLogic.player1_turn);
            Assert.AreEqual("O turn", Form1.textBox1.Text);
        }

        [TestMethod]
        public void Button1_Click_PlayerOTurn()
        {
            TicTacToeLogic.player1_turn = false;
            Form1.button1.PerformClick();
            Assert.AreEqual("O", Form1.button1.Text);
            Assert.IsTrue(TicTacToeLogic.player1_turn);
            Assert.AreEqual("X turn", Form1.textBox1.Text);
        }

        [TestMethod]
        public void Button2_Click_PlayerXTurn()
        {
            TicTacToeLogic.player1_turn = true;
            Form1.button2.PerformClick();
            Assert.AreEqual("X", Form1.button2.Text);
            Assert.IsFalse(TicTacToeLogic.player1_turn);
            Assert.AreEqual("O turn", Form1.textBox1.Text);
        }

        [TestMethod]
        public void Button2_Click_PlayerOTurn()
        {
            TicTacToeLogic.player1_turn = false;
            Form1.button2.PerformClick();
            Assert.AreEqual("O", Form1.button2.Text);
            Assert.IsTrue(TicTacToeLogic.player1_turn);
            Assert.AreEqual("X turn", Form1.textBox1.Text);
        }
        [TestMethod]
        public void Button3_Click_PlayerXTurn()
        {
            TicTacToeLogic.player1_turn = true;
            Form1.button3.PerformClick();
            Assert.AreEqual("X", Form1.button3.Text);
            Assert.IsFalse(TicTacToeLogic.player1_turn);
            Assert.AreEqual("O turn", Form1.textBox1.Text);
        }

        [TestMethod]
        public void Button3_Click_PlayerOTurn()
        {
            TicTacToeLogic.player1_turn = false;
            Form1.button3.PerformClick();
            Assert.AreEqual("O", Form1.button3.Text);
            Assert.IsTrue(TicTacToeLogic.player1_turn);
            Assert.AreEqual("X turn", Form1.textBox1.Text);
        }
        [TestMethod]
        public void Button4_Click_PlayerXTurn()
        {
            TicTacToeLogic.player1_turn = true;
            Form1.button4.PerformClick();
            Assert.AreEqual("X", Form1.button4.Text);
            Assert.IsFalse(TicTacToeLogic.player1_turn);
            Assert.AreEqual("O turn", Form1.textBox1.Text);
        }

        [TestMethod]
        public void Button4_Click_PlayerOTurn()
        {
            TicTacToeLogic.player1_turn = false;
            Form1.button4.PerformClick();
            Assert.AreEqual("O", Form1.button4.Text);
            Assert.IsTrue(TicTacToeLogic.player1_turn);
            Assert.AreEqual("X turn", Form1.textBox1.Text);
        }

   
        [TestMethod]
        public void Button5_Click_PlayerXTurn()
        {
            TicTacToeLogic.player1_turn = true;
            Form1.button5.PerformClick();
            Assert.AreEqual("X", Form1.button5.Text);
            Assert.IsFalse(TicTacToeLogic.player1_turn);
            Assert.AreEqual("O turn", Form1.textBox1.Text);
        }

        [TestMethod]
        public void Button5_Click_PlayerOTurn()
        {
            TicTacToeLogic.player1_turn = false;
            Form1.button5.PerformClick();
            Assert.AreEqual("O", Form1.button5.Text);
            Assert.IsTrue(TicTacToeLogic.player1_turn);
            Assert.AreEqual("X turn", Form1.textBox1.Text);
        }

 
        [TestMethod]
        public void Button6_Click_PlayerXTurn()
        {
            TicTacToeLogic.player1_turn = true;
            Form1.button6.PerformClick();
            Assert.AreEqual("X", Form1.button6.Text);
            Assert.IsFalse(TicTacToeLogic.player1_turn);
            Assert.AreEqual("O turn", Form1.textBox1.Text);
        }

        [TestMethod]
        public void Button6_Click_PlayerOTurn()
        {
            TicTacToeLogic.player1_turn = false;
            Form1.button6.PerformClick();
            Assert.AreEqual("O", Form1.button6.Text);
            Assert.IsTrue(TicTacToeLogic.player1_turn);
            Assert.AreEqual("X turn", Form1.textBox1.Text);
        }

      
        [TestMethod]
        public void Button7_Click_PlayerXTurn()
        {
            TicTacToeLogic.player1_turn = true;
            Form1.button7.PerformClick();
            Assert.AreEqual("X", Form1.button7.Text);
            Assert.IsFalse(TicTacToeLogic.player1_turn);
            Assert.AreEqual("O turn", Form1.textBox1.Text);
        }

        [TestMethod]
        public void Button7_Click_PlayerOTurn()
        {
            TicTacToeLogic.player1_turn = false;
            Form1.button7.PerformClick();
            Assert.AreEqual("O", Form1.button7.Text);
            Assert.IsTrue(TicTacToeLogic.player1_turn);
            Assert.AreEqual("X turn", Form1.textBox1.Text);
        }

  
        [TestMethod]
        public void Button8_Click_PlayerXTurn()
        {
            TicTacToeLogic.player1_turn = true;
            Form1.button8.PerformClick();
            Assert.AreEqual("X", Form1.button8.Text);
            Assert.IsFalse(TicTacToeLogic.player1_turn);
            Assert.AreEqual("O turn", Form1.textBox1.Text);
        }

        [TestMethod]
        public void Button8_Click_PlayerOTurn()
        {
            TicTacToeLogic.player1_turn = false;
            Form1.button8.PerformClick();
            Assert.AreEqual("O", Form1.button8.Text);
            Assert.IsTrue(TicTacToeLogic.player1_turn);
            Assert.AreEqual("X turn", Form1.textBox1.Text);
        }

        [TestMethod]
        public void Button9_Click_PlayerXTurn()
        {
            TicTacToeLogic.player1_turn = true;
            Form1.button9.PerformClick();
            Assert.AreEqual("X", Form1.button9.Text);
            Assert.IsFalse(TicTacToeLogic.player1_turn);
            Assert.AreEqual("O turn", Form1.textBox1.Text);
        }

        [TestMethod]
        public void Button9_Click_PlayerOTurn()
        {
            TicTacToeLogic.player1_turn = false;
            Form1.button9.PerformClick();
            Assert.AreEqual("O", Form1.button9.Text);
            Assert.IsTrue(TicTacToeLogic.player1_turn);
            Assert.AreEqual("X turn", Form1.textBox1.Text);
        }

           }
}

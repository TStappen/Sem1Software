using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockPaperScissors
{ 
    public partial class Form1 : Form
    {
        Game m_game = new Game();
        
        public Form1()
        {
            InitializeComponent();
            
        }

        private void radioButtonPaper_Click(object sender, EventArgs e)
        {
            m_game.makeChoice(CHOICE.PAPER);
        }

        private void radioButtonScissors_Click(object sender, EventArgs e)
        {
            m_game.makeChoice(CHOICE.SCISSORS);
        }

        private void radioButtonRock_Click(object sender, EventArgs e)
        {
            m_game.makeChoice(CHOICE.ROCK);
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            // run game
            m_game.play();

            // update GUI
            string choiceEnemy = m_game.getEnemyChoice().ToString();
            textBoxEnemyChoice.Text = choiceEnemy;

            string choicePlayer = m_game.getPlayerChoice().ToString();

            string result = m_game.calcWin() ? "WIN" : "LOSE";
            textBoxHistory.AppendText(choicePlayer + " - " + choiceEnemy + " - " + result + "\r\n");
        }

        private void radioButtonPaper_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

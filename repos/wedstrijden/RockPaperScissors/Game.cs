using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    internal enum CHOICE
    {
        ROCK,
        PAPER,
        SCISSORS
    }

    internal class Player
    {
        Random rnd = new Random();

        String m_name;
        CHOICE m_choice;

        public Player()
        {

        }
        public Player(string name)
        {
            m_name = name;
        }
        public Player(string name, CHOICE choice)
        {
            m_name = name;
            m_choice = choice;
        }

        public string getName() { return m_name; }
        public CHOICE getChoice() { return m_choice; }

        public void setChoice(CHOICE choice)
        {
            m_choice = choice;
        }
        public void choseRandom()
        {
            Array values = Enum.GetValues(typeof(CHOICE));
            m_choice = (CHOICE)values.GetValue(rnd.Next(values.Length));
        }
    }

    internal class Game
    {
        Player m_player;
        Player m_enemy;
        public Game()
        {
            m_player = new Player("Tim", CHOICE.PAPER);
            m_enemy = new Player("Bob");
        }

        public void play()
        {
            m_enemy.choseRandom();
        }
        public void makeChoice(CHOICE choice)
        {
            m_player.setChoice(choice);
        }
        public CHOICE getEnemyChoice()
        {
            return m_enemy.getChoice();
        }
        public CHOICE getPlayerChoice()
        {
            return m_player.getChoice();
        }
        public bool calcWin()
        {
            /*
            Array values = Enum.GetValues(typeof(CHOICE));
            //values.Length;
            //m_choice = (CHOICE)values.GetValue(rnd.Next(values.Length));
            for (int i = 0; i < values.Length; i++)
            {

            }
            */

            if (getPlayerChoice() == getEnemyChoice())
                return false;

            if (getPlayerChoice() == CHOICE.ROCK)
            {
                if (getEnemyChoice() == CHOICE.PAPER)
                    return false;
                if (getEnemyChoice() == CHOICE.SCISSORS)
                    return true;
            }
            if (getPlayerChoice() == CHOICE.PAPER)
            {
                if (getEnemyChoice() == CHOICE.ROCK)
                    return true;
                if (getEnemyChoice() == CHOICE.SCISSORS)
                    return false;
            }
            if (getPlayerChoice() == CHOICE.SCISSORS)
            {
                if (getEnemyChoice() == CHOICE.ROCK)
                    return false;
                if (getEnemyChoice() == CHOICE.PAPER)
                    return true;
            }

            return false;
        }
    }
}

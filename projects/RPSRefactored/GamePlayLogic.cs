using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSRefactored
{
    internal class GamePlayLogic : RPS_Game
    {
        List<Player> players; //all the registered players
        List<Game> games;//all the played games

        //constructor
        public GamePlayLogic()
        {
            players = new List<Player>();
        }

        //overload constructor
        public GamePlayLogic(string fname, string lname)
        {
            //create player bassed on names after verifying they do not have a save
            players = new List<Player>(); //new player
            Player computer = new Player("Thomas", "Anderson");
            Game game = new Game();// current game
            Player player = new Player(); //create a new player
            players.Add(player); //add new player to current 
        }

        internal int ValidateUserChoice(string choice)
        {
            int convertedNumber;
            bool conversionBool = false;
            conversionBool = Int32.TryParse(choice, out convertedNumber);
            if (!conversionBool || convertedNumber < 1 || convertedNumber > 3)
            {
                return Choice.invalid;
            }
            return (Choice)convertedNumber;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LudoGame
{
    public enum GameColor { Green, Yellow, Red, Blue };

    public class Game
    {
        private int numberOfPlayers;
        private Player[] players;
        private readonly string header = "- - - - - - - - - LUDO GAME - - - - - - - - -";

        public Game() => MainMenu();

        public void MainMenu()
        {
            Header();
            Console.WriteLine("Welcome To My Ludo Game");
            SetNumberOfPlayers();
            CreatePlayers();
            VerifyPlayers();
            
        }

        public void SetNumberOfPlayers()
        {
            Header();
            string outputText = "Choose between 2 and 4 players: ";
            Console.WriteLine();
            Console.Write(outputText);
            this.numberOfPlayers = Int32.Parse(Console.ReadLine());
            
            while (this.numberOfPlayers < 2 || this.numberOfPlayers > 4)
            {
                if (!Int32.TryParse(Console.ReadLine().ToString(), out this.numberOfPlayers))
                {
                    Console.WriteLine("Incorret input");
                    Console.Write(outputText);
                }

            }
        }

        public void CreatePlayers()
        {
            Header();
            this.players = new Player[this.numberOfPlayers];
            
            for(int i = 0; i < this.numberOfPlayers; i++)
            {
                Console.Write("Player {0} name: ", (i + 1));
                string name = Console.ReadLine();
                
                while(String.IsNullOrEmpty(name))
                {
                    Console.Write("Player {0} name: ", (i + 1));
                    name = Console.ReadLine();
                }
                GameColor clr = 0;
                switch (i)
                {
                    case 0:
                        clr = GameColor.Green;
                        break;
                    case 1:
                        clr = GameColor.Yellow;
                        break;
                    case 2:
                        clr = GameColor.Red;
                        break;
                    case 3:
                        clr = GameColor.Blue;
                        break;
                }
                this.players[i] = new Player(name, clr);
            }
        }

        public void VerifyPlayers()
        {
            Header();
            int playerCount = 1;
            Console.WriteLine("Aight, these are your players");
            foreach(Player pl in this.players)
            {
                Console.WriteLine("Player" + playerCount + "; Color: " + pl.GetColor + ", Name: " + pl.GetName);
                playerCount++;
            }
        }

        public void Header()
        {
            Console.Clear();
            Console.WriteLine(header);
            Console.WriteLine();
        }

    }
}

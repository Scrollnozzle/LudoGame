using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LudoGame
{
    public class Player
    {
        // Class Field
        private readonly int playerID;
        private readonly string name;
        private GameColor color;

        public Player(int id, string playerName, GameColor clr)
        {
            this.name = playerName;
            this.playerID = id;
            this.color = clr;
            CreateTokens(clr);

        }
        private void CreateTokens(GameColor clr) {

        }
        public string GetName => this.name;
        public GameColor GetColor => this.color;
        
    }
}

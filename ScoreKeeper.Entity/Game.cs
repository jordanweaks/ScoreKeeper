using System;
using System.Collections.Generic;
using System.Text;

namespace ScoreKeeper.Entity
{
   public class Game
    {
        public int GameId { get; set; }
        public int TeamId { get; set; }
        public string Opponent { get; set; }

        public string Location { get; set; }
        public DateTime GameTime { get; set; }

    }
}

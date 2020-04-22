using System;
using System.Collections.Generic;
using System.Text;

namespace ScoreKeeper.Entity
{
  public class Player
    {
        public int PlayerId { get; set; }
        public int TeamId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int JerseyNumber { get; set; }

    }
}

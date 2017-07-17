using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RaceTrack
{
    class Bet
    {
        public int Amount;  // The amount of cash that was bet.
        public int Dog;     // The number of the dog the bet is on.
        public Guy Bettor;  // The guy who placed the bet.

        //Constractor
        public Bet(int Amount, int Dog, Guy Bettor)
        {
            this.Amount = Amount;
            this.Dog = Dog;
            this.Bettor = Bettor;
        }

        //Function[1]
        public string GetDescription()
        {
            string description = "";

            if (Amount > 0)
            {
                description = Bettor.Name + " bets " + Amount + " on dog " + Dog;
            }
            else
            {
                description = Bettor.Name + " hasn't placed any bets" ;
            }
            return description;
        }
        //Function[2]
        public int PayOut(int Winner)
        {
            if (Dog == Winner)
            {
                return Amount;
            }
            return -Amount;
        }
    }
}

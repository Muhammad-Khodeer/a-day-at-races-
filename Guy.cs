using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RaceTrack
{
    class Guy
    {
        //part1 : Variables and objects
        public string Name;
        public Bet MyBet;  // this is an object.
        public int Cash;
        //Guy GUI Controls
        public RadioButton MyRadioButton;
        public Label MyLabel;

        //constractor [5 inputs]
        public Guy(string Name, Bet MyBet, int Cash, RadioButton MyRadioButton, Label MyLabel)
        {
            this.Name = Name;
            this.MyBet = MyBet;
            this.Cash = Cash;
            this.MyRadioButton = MyRadioButton;
            this.MyLabel = MyLabel;
        }

        //Function[1]
        public void UpdateLables()
        {//this function update the inforamation about guys bets in the labels at form
            if (MyBet == null)
            {
                MyLabel.Text = String.Format("{0} hasn't placed any bets", Name);
            } 
            else 
            {
                MyLabel.Text = MyBet.GetDescription();
            }            
            MyRadioButton.Text = Name + " has " + Cash + " bucks";
        }

        //Function[2]
        public void ClearBet()
        {
            MyBet.Amount = 0;
        }
        //Function[3]
        public bool PlaceBet(int Amount, int Dog)
        {
            if (Amount <= Cash)
            {

                MyBet = new Bet(Amount, Dog, this);
                return true;
            }
            return false; // he return false if the amount > cash
        }
        //Function[4]
        public void Collect(int Winner)
        {
            Cash += MyBet.PayOut(Winner); // 
        }
    }
}

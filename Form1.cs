using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RaceTrack
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();            
        }

        //Part[1] : Objects
        // 4 objets 4 dogs
        Greyhound[] Dogs = new Greyhound[4];
        // 3Object for 3 guys
        Guy[] Guys = new Guy[3];

        private void Form1_Load(object sender, EventArgs e)
        {

            Dogs[0] = new Greyhound(Dog1); //
            Dogs[1] = new Greyhound(Dog2);
            Dogs[2] = new Greyhound(Dog3);
            Dogs[3] = new Greyhound(Dog4);


            Guys[0] = new Guy("Joe", null, 50, JoeButton, JoeBet);
            Guys[1] = new Guy("Bob", null, 75, BobButton, BobBet);
            Guys[2] = new Guy("Al", null, 45, AlButton, AlBet);

            for (int i = 0; i < 3; i++)
            {
                Guys[i].UpdateLables();
            }
        }


        private void JoeButton_CheckedChanged(object sender, EventArgs e)
        {
            Player.Text = "Joe";
        }

        private void BobButton_CheckedChanged(object sender, EventArgs e)
        {
            Player.Text = "Bob";
        }

        private void AlButton_CheckedChanged(object sender, EventArgs e)
        {
            Player.Text = "Al";
        }


        private void BetsButton_Click(object sender, EventArgs e)
        {
            int GuyNumber = 0;

            if (JoeButton.Checked)
            {
                GuyNumber = 0;
            }
            if (BobButton.Checked)
            {
                GuyNumber = 1;
            }
            if (AlButton.Checked)
            {
                GuyNumber = 2;
            }

            Guys[GuyNumber].PlaceBet((int)BetAmount.Value, (int)DogNumber.Value);
            Guys[GuyNumber].UpdateLables();
        }

        private void RunButton_Click(object sender, EventArgs e)
        {
            bool Winner = false;
            int WinningDog;

            while (!Winner)
            {
                for (int i = 0; i < 4; i++)
                {
                    Winner = Dogs[i].Run();
                    if (Winner)
                    {
                        WinningDog = i + 1;
                        for (int j = 0; j < 3; j++ )
                        {
                            if (Guys[j].MyBet != null)
                            {
                                Guys[j].Collect(WinningDog);
                                Guys[j].ClearBet();
                                Guys[j].UpdateLables();
                            }
                        }
                        Restart();
                        break;
                    }
                }
            }
        }

        public void Restart()
        {
            for (int i = 0; i < 4; i++)
            {
                Dogs[i].takeStartingPostion();
            }
        }

    }
}
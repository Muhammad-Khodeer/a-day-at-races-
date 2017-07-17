using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace RaceTrack
{
    class Greyhound
    {
        // the piblic variables in this class
        public int startingPosition = 14;   // the Dog start at position x = 14 
        public int raceTrackLength = 520;   // the lengh of the track is x = 510 
        public PictureBox myPictureBox = null;
        public int location = 0;
        // I make an object from the class random
        public Random randomizer;




        //Constructor. // when u use an object from Greyhound class
                       // you must pass a picturebox for it.
        public Greyhound(PictureBox my_dog)
        {
           this.myPictureBox = my_dog;
            
        }      
       
        // Function:1 // this function Run each dog with a step 
                      // and check if any of dogs reach the end
                      // True >> if a dog reach ,,, False >> if no dog reach
        public bool Run()
        {
           Point MyPoint = myPictureBox.Location; //the location of the dog picture
           randomizer = new Random();   //I nead a random variable every time as a speed. 
           if (MyPoint.X >= raceTrackLength)//condition means that a dog reached the end
           {    //so we have a winner
                MessageBox.Show("The winner is : #" + myPictureBox.Name);
                return true;
           }
           else //No dog reach the end
           {  // so we will move one new step
               MyPoint.X += randomizer.Next(1, 5); //get the new location
               
               myPictureBox.Location = MyPoint; //move to the new location.

               Application.DoEvents();

               System.Threading.Thread.Sleep(1);
               return false;
           }
        }

        //Return the pic of the dog to the starting position x = 14
        public void takeStartingPostion() 
        {
            myPictureBox.Left = startingPosition;
        }

    }
}

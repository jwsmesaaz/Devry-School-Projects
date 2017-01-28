using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmithWk1LabWarGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare Variables

            //Name
            string strPlayerName;
            //Cash
            Int64 intPlayerCash;
            //Play again
            string strMore = "YES";
            //Bet
            Int64 intBetAmount;
            //Player's Card
            int intPlayerVariable;
            //Dealer's Card
            int intDealerVariable;
            //Did player Win?
            bool boolPlayerWin;
            

            //Get user information

            //Get user's Name
            Console.WriteLine("Please enter your name: ");
            strPlayerName = Console.ReadLine();

            //Get Player's Cash
            Console.WriteLine("Please enter amount of cash: ");
            intPlayerCash = Convert.ToInt64(Console.ReadLine());

            //Welcome Player
            Console.WriteLine("Now for war " + strPlayerName + ". You have {0:c}.", intPlayerCash);

            do
            {
                //Get Bet amount
                intBetAmount = 0;
                do
                {
                    Console.WriteLine("Please enter the amount you would like to bet: ");
                    intBetAmount = Convert.ToInt64(Console.ReadLine());

                    //Makes sure the bet isn't more than the player's cash amount
                    if (intBetAmount > intPlayerCash)
                    {                        
                        Console.WriteLine("You do not have enough cash for that bet.");
                        Console.WriteLine("Your cash amount is {0:c}", intPlayerCash);
                    }
                    
                }
                while (intBetAmount > intPlayerCash);

                //Begins the game
                Console.WriteLine("Press enter to draw card.");
                Console.ReadLine();

                //Finding Player's Card
                intPlayerVariable = RandomCard();
                DisplayCardPlayer(intPlayerVariable);

                //Finds the dealer's Card
                Console.WriteLine("Press enter to display dealer's card.");
                Console.ReadLine();
                intDealerVariable = RandomCard();
                DisplayCardDealer(intDealerVariable);

                //finds the winner
                boolPlayerWin = Evaluate(intPlayerVariable, intDealerVariable);

                //Declares the winner and changes the amount of player's cash
                if (boolPlayerWin == true)
                {
                    Console.WriteLine(strPlayerName + ", you win.");
                    intPlayerCash = (intPlayerCash + intBetAmount);
                }
                else
                {
                    Console.WriteLine(strPlayerName + ", you lose.");
                    intPlayerCash = (intPlayerCash - intBetAmount);
                }

                //Askes for playing again and asks if they want to play again.
                if (intPlayerCash > 0)
                {
                    Console.WriteLine("You have {0:c}" + " in hand.", intPlayerCash);
                    Console.WriteLine("Play Again? (YES or NO)");
                    strMore = Console.ReadLine().ToUpper();

                    //Makes a "y" to a "YES" answer.
                    if (strMore == "Y")
                    {
                        strMore = "YES";
                    }
                }
                else
                {
                    Console.WriteLine("You are out of cash");
                    strMore = Console.ReadLine().ToUpper();

                    //Makes a "y" to a "YES" answer.
                    if (strMore == "Y")
                    {
                        strMore = "YES";
                    }
                }
            }
            while (strMore == "YES");
            //Thanks the user
            Console.WriteLine("Thanks for playing");


        }
        static int RandomCard()
        {
            //Method for finding random card
            int intRandomNumber = 0;
            Random random = new Random();
            intRandomNumber = random.Next(2, 14);
            return intRandomNumber;
        }
        static public void DisplayCardPlayer(int intPlayerVariable)
        {
            //Displaying what card the player recieved.
            if (intPlayerVariable == 14)
            {
                Console.WriteLine("Ace");
            }
            else if (intPlayerVariable == 13)
            {
                Console.WriteLine("King");
            }
            else if (intPlayerVariable == 12)
            {
                Console.WriteLine("Queen");
            }
            else if (intPlayerVariable == 11)
            {
                Console.WriteLine("Jack");
            }
            else
            {
                Console.WriteLine(Convert.ToString(intPlayerVariable));
            }
        }
        static public void DisplayCardDealer(int intDealerVariable)
        {
            //Displaying what card the player recieved.
            if (intDealerVariable == 14)
            {
                Console.WriteLine("Ace");
            }
            else if (intDealerVariable == 13)
            {
                Console.WriteLine("King");
            }
            else if (intDealerVariable == 12)
            {
                Console.WriteLine("Queen");
            }
            else if (intDealerVariable == 11)
            {
                Console.WriteLine("Jack");
            }
            else
            {
                Console.WriteLine(Convert.ToString(intDealerVariable));
            }
        }
        static public bool Evaluate(int intPlayerVariable, int intDealerVariable)
        {
            //Evaluates who is the winner
            if (intPlayerVariable > intDealerVariable)
            {
                return true;
            }
            else if (intPlayerVariable < intDealerVariable)
            {
                return false;
            }
            else
            {
                //If it is a tie this brings it into a war.
                Console.WriteLine("Tie, we go to war!!!");
                Console.WriteLine("Press enter to draw card.");
                Console.ReadLine();
                intPlayerVariable = RandomCard();
                DisplayCardPlayer(intPlayerVariable);
                Console.WriteLine("Press enter to display dealer's card.");
                Console.ReadLine();
                intDealerVariable = RandomCard();
                DisplayCardDealer(intDealerVariable);
                return Evaluate(intPlayerVariable, intDealerVariable);
            }
        }        
    }
}

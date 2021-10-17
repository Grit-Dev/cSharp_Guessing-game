using System;

class Program {
  public static void Main (string[] args) {

            // Choose a random number between 0 and 20
            int theNumber = new Random().Next(20);
            int EXIT = -1;
            int ZERO = 0;
            int userInput = 0;
            int counter = 0;
            bool breakTheLoop = false;
           
            

       
            //This was for testing purposes: Umcomment the line below if you would like to win everytime 
            //Console.WriteLine($"Testing purposes: {theNumber}");

            //Do while loop was used for this 
            do
            { 
                //Once we get within the nested if statement, and the user guesses correctly.
                //we need someway to ensure we break the loop and it does not start again 
                //If statement is put here
                if(breakTheLoop == true)
                {
                    break;
                }

                try
                {     

                    //Try Catch is in place here to catch any unhandled exception. 
                    //Example: The user types hello instead 

                    Console.WriteLine("Let's Play 'Guess the Number'!");
                    Console.WriteLine("I'm thinking of a number between 0 and 20. \n");
                    Console.WriteLine("Enter your guess, or -1 to give up.");
                    userInput =  Int32.Parse(Console.ReadLine());

                }
                catch(Exception e)
                {
                    Console.WriteLine("Apologises, you did not enter in a digit or typed a digit number \n");
                    Console.WriteLine("Please try again \n");

                    //Catch the exception and inform the user. Repeat the loop
                }


                    if(userInput == theNumber)
                    {
                    //Counter in place to count the number of times the person guessed
                        counter++;

                        Console.WriteLine("Congratulations! You won! \n");
                        break;
                    //Break to take us out of the game

                    }

                    else if( userInput < ZERO || userInput > 20)
                    {
                        Console.WriteLine("You did not enter a positive number between 0 - 20 \n");
                        Console.WriteLine("Please try again!  \n");

                    //Implemented to makesure the use does not enter a negative number or a number over 20
                    
                    }

                    else
                    {

                        while(userInput != EXIT)
                        { 
                        
                            counter++;

                            Console.WriteLine("You did not answer correctly. Quess again or -1 to Exit \n");
                            userInput = Int32.Parse (Console.ReadLine());


                        

                            if(userInput == EXIT)
                            {
                                //If the user wants to exit - Break the loop 
                                break;
                            }
                            else if(userInput == theNumber)
                            {
                                counter++;

                                Console.WriteLine("Congratulations! You won the game");
                                Console.WriteLine($"Computers number: [{theNumber}], your Guess [{theNumber}]");

                                breakTheLoop = true;

                                break;
                        
                            }

                        }
                   
                    }       

            }

            while(userInput != EXIT);

            Console.WriteLine("Thanks for playing");
            Console.WriteLine($"The total amount of guesses: {counter} \n");    
  
  }
}
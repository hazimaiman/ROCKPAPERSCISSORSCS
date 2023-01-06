using System.Runtime.CompilerServices;

namespace MyFirstProgram
    {
        class Program
        {
            static void Main(string[] args)
            {
                Random random= new Random();
                bool playAgain =true;
                String player;
                String computer;
                String answer;  

                while ( playAgain )
            {
                player = "";
                computer = "";
                answer = "";


                while ( player != "ROCK" && player != "PAPER" && player != "SCISSORS") 
                {
                Console.WriteLine("Enter ROCK, PAPER OR SCISSORS: ");
                player = Console.ReadLine();
                player = player.ToUpper();
                }

                
                switch (random.Next(1, 4))
                {
                    case 1:
                        computer = "ROCK";
                        break;
                    case 2:
                        computer = "PAPER";
                        break;
                    case 3:
                        computer = "SCISSORS";
                        break;


                }
                Console.WriteLine("Player: " + player);
                Console.WriteLine("Computer: " + computer);

                switch (player)
                {
                    case "ROCK":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("iTS A DRAW");
                        }
                        else if(computer == "PAPER")
                        {
                            Console.WriteLine("You lose!");
                        }
                        else
                        {
                            Console.WriteLine("YOU WUIN!");
                        }
                        break;
                    case "PAPER":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("you win");
                        }
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("draw");
                        }
                        else
                        {
                            Console.WriteLine("You lose");
                        }
                        break;
                    case "SCISSORS":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("you lsoe");
                        }
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("you win");
                        }
                        else
                        {
                            Console.WriteLine("draw");
                        }

                        break;


                }
                Console.Write("Would you like plau again (Y/N):  ");
                answer =Console.ReadLine();
                answer = answer.ToUpper();

                if (answer == "Y")
                {
                    playAgain= true;
                } 
                else
                {
                    playAgain= false;
                }
                    
            }

            Console.WriteLine("Thanks for playing");
                
               
            Console.ReadKey();
            }
        }
    }





  

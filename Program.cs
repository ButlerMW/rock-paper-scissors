using System;
using System.Linq;

namespace Test
{
  class Program
  {
    public static void ListDirectory() 
    {
      string[] commands = {"rock", "paper", "scissors", "exit"};
      foreach(string command in commands)
      {
        Console.WriteLine(command);
      }
      Console.WriteLine(" ");
    }
    public static void RockPaperScissors(string PlayerHand)
    {
      string[] hands = {"rock", "paper", "scissors"};
      Random options = new Random();
      int ComputerChoice = options.Next(0,3);
      string ComputerHand = hands[ComputerChoice];

      Console.WriteLine("You throw " + PlayerHand);
      Console.WriteLine(" ");
      Console.WriteLine("Computer throws " + ComputerHand);
      Console.WriteLine(" ");

      string Results = PlayerHand == "rock" && ComputerHand == "paper" ? "Paper beats rock, Computer Wins" : 
        PlayerHand == "rock" && ComputerHand == "scissors" ? "Rock beats scissors, Player Wins" :
          PlayerHand == "paper" && ComputerHand == "rock" ? "Paper beats rock, Player Wins" :
            PlayerHand == "paper" && ComputerHand == "scissors" ? "Scissors beats paper, Computer Wins" : 
              PlayerHand == "scissors" && ComputerHand == "paper" ? "Scissors beats paper, Player Wins" :
                PlayerHand == "scissors" && ComputerHand == "rock" ? "Rock beats scissors, Computer Wins" :
                  "It is a tie"; 

      Console.WriteLine(Results);
      Console.WriteLine(" ");
    }

    static void Main(string[] args)
    {
      string[] commands = {"list", "rock", "paper", "scissors", "exit"};
      bool gameover = false;

      Console.WriteLine("Let's play rock, paper, scissors!");

      while(!gameover)
      {
        Console.WriteLine("Choose rock, paper, or scissors!");
        string InputRPS = Console.ReadLine();
        Console.WriteLine(" ");
        if(commands.Contains(InputRPS)) {
          if(InputRPS == "list")
          {
            ListDirectory();
          }
          else if(InputRPS == "exit")
          {
            Console.WriteLine("Are you sure you want to quit the game? (y/n)");
            string ConfirmExit = Console.ReadLine();
            if(ConfirmExit == "y")
            {
              gameover = true;
            }
          }
          else {
            RockPaperScissors(InputRPS);
          }
        }
        else {
          Console.WriteLine(InputRPS + " is not recognized as a command. Please type in a correct command.");
          Console.WriteLine("");
        }
      }
    }
  }
}

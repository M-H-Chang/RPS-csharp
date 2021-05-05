using System;
using RockPaperScissors;

public class Program
{
  public static void Main()
  {
    // RPS gameOne = new RPS();   <-- We don't need this because we are dealing with a static method.
    Console.WriteLine("Welcome to the game Rock, Paper, Scissors.");
    Console.Write("Player one please choose Rock, Paper, or Scissors: ");
    string playerOne = Console.ReadLine();

    Console.Write("Player two please choose Rock, Paper, or Scissors: ");
    string playerTwo = Console.ReadLine();

    if (playerOne != "rock" || playerOne != "paper" || playerOne != "scissors" || playerTwo != "rock" || playerTwo != "paper" || playerTwo != "scissors")
    {
      Console.WriteLine("Please input rock, paper, or scissors.");
    }
    else if (RPS.PlayerOneWin(playerOne, playerTwo) == true)
    {
      Console.WriteLine("Player one wins!");
    }
    else if (RPS.PlayerTwoWin(playerTwo, playerOne) == true)
    {
      Console.WriteLine("Player two wins!");
    }
    else
    {
      Console.WriteLine("It was a tie!");
    }
  }
}


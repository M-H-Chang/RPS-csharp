using System.Collections.Generic;
using System;
// Rock v. Scissors = Rock wins
// Rock v. Paper = Paper wins
// Paper v. Scissors = Scissors wins

namespace RockPaperScissors
{
  public class RPS
  {
    public static bool PlayerOneWin(string player1, string player2)
    {
      string paper = "paper";
      string rock = "rock";
      string scissors = "scissors";
      if (player1 == rock && player2 == scissors)
      {
        return true;
      }
      else if (player1 == scissors && player2 == paper)
      {
        return true;
      }
      else if (player1 == paper && player2 == rock)
      {
        return true;
      }
      else
      {
        return false;
      }
    }
    public static bool PlayerTwoWin(string player2, string player1)
    {
      string paper = "paper";
      string rock = "rock";
      string scissors = "scissors";
      if (player2 == rock && player1 == scissors)
      {
        return true;
      }
      else if (player2 == scissors && player1 == paper)
      {
        return true;
      }
      else if (player2 == paper && player1 == rock)
      {
        return true;
      }
      else
      {
        return false;
      }
    }
  }
}
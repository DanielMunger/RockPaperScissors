using System;
using System.Collections.Generic;

namespace RockPaperScissors.Objects
{
  public class Game
  {
    public string Outcome {get; set;}
    private Dictionary<string, string> _playerChoices = new Dictionary<string, string> {};
    public string PlayerTurn {get; set;}
    private static List<Game> _gameList = new List<Game> {};

    public Game(string PlayerOneChoice, string PlayerTwoChoice)
    {
      _playerChoices.Add("Player One", PlayerOneChoice);
      _playerChoices.Add("Player Two", PlayerTwoChoice);
      PlayerTurn = "Player1";
      _gameList.Add(this);
    }

    public static List<Game> GetAll()
    {
      return _gameList;
    }

    public void SetPlayerOneChoice(string PlayerOneChoice)
    {
      _playerChoices["Player One"] = PlayerOneChoice;
    }
    public void SetPlayerTwoChoice(string PlayerTwoChoice)
    {
      _playerChoices["Player Two"] = PlayerTwoChoice;
    }

    public Dictionary<string, string> Compare()
    {
      string choice1 = _playerChoices["Player One"];
      string choice2 =  _playerChoices["Player Two"];
      if(choice1 == "foot" && choice2 == "cockroach"){
        this.Outcome = "Player One";
      }
      if(choice1 == "bomb" && choice2 == "foot"){
        this.Outcome = "Player One";
      }
      if(choice1 == "cockroach" && choice2 == "bomb"){
        this.Outcome = "Player One";
      }
      if(choice2 == "foot" && choice1 == "cockroach"){
        this.Outcome = "Player Two";
      }
      if(choice2 == "bomb" && choice1 == "foot"){
        this.Outcome = "Player Two";
      }
      if(choice2 == "cockroach" && choice1 == "bomb"){
        this.Outcome = "Player Two";
      }
      if(choice1 == choice2)
      {
        this.Outcome = "Tie";
      }
      return _playerChoices;
    }
  }
}

using Nancy;
using System;
using System.Collections.Generic;
using RockPaperScissors.Objects;

namespace RockPaperScissors
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        Game newGame = new Game("","");
        return View["RPS.cshtml", newGame.PlayerTurn];
      };
      Post["/result/{player}/{id}"] = parameters => {
        List<Game> newList = new List<Game> {};
        newList = Game.GetAll();
        Game newGame = newList[0];
        Dictionary<string, string> newDictionary = newGame.GetPlayerChoices();
        if(parameters.player == "Player1")
        {
          newGame.SetPlayerOneChoice(parameters.id);
          newGame.PlayerTurn = "Player2";
          return View["RPS.cshtml", newGame.PlayerTurn];
          //Console.WriteLine(parameters.id);
        }
        if(parameters.player == "Player2")
        {
          newGame.SetPlayerTwoChoice(parameters.id);
          newGame.Compare();
          Console.WriteLine(newDictionary["Player One"], newDictionary["Player Two"]);
          return View["Outcome.cshtml", newGame];
        }
        return View["Outcome.cshtml", newGame];
      };

    }
  }
}

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
        if(parameters.player == "Player1")
        {
          newGame.SetPlayerOneChoice(parameters.id);
          newGame.PlayerTurn = "Player2";
          return View["RPS.cshtml", newGame.PlayerTurn];
          //Console.WriteLine(parameters.id);
        }
        else
        {
          newGame.SetPlayerTwoChoice(parameters.id);
          newGame.Compare();
          return View["Outcome.cshtml", newGame];
          //Console.WriteLine(parameters.id);
        }
      };

    }
  }
}

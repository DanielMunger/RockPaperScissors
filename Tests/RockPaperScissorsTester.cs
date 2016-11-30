using Xunit;
using System;
using System.Collections.Generic;
using RockPaperScissors.Objects;

namespace  RockPaperScissors
{
  public class RockPaperScissorsTest
  {
    [Fact]
    public void RPSTest_PlayerOneChoice_true()
    {
      //Arrange
      Game newGame = new Game("Cockroach", "Bomb");
      //Act
      Dictionary<string, string> result = newGame.Compare();
      //Assert
      string returnedMove = result["Player One"];
      Assert.Equal(true, returnedMove == "Cockroach");
    }
    [Fact]
    public void RPSTest_PlayerTwoChoice_true()
    {
      //Arrange
      Game newGame = new Game("Cockroach", "Bomb");
      //Act
      Dictionary<string, string> result = newGame.Compare();
      // result = result[0];
      // System.Console.WriteLine(result);
      //Assert
      string returnedMove = result["Player Two"];
      Assert.Equal(true, returnedMove == "Bomb");
    }
    [Fact]
    public void RPSTest_ComparePlayerOneWins_true()
    {
      //Arrange
      Game newGame = new Game("cockroach", "bomb");
      //Act
      Dictionary<string, string> result = newGame.Compare();
      // result = result[0];
      // System.Console.WriteLine(result);
      //Assert
      Assert.Equal(true, "Player One" == newGame.Outcome);
    }
    [Fact]
    public void RPSTest_ComparePlayerTwoWins_true()
    {
      //Arrange
      Game newGame = new Game("foot", "bomb");
      //Act
      Dictionary<string, string> result = newGame.Compare();
      // result = result[0];
      // System.Console.WriteLine(result);
      //Assert
      Assert.Equal(true, "Player Two" == newGame.Outcome);
    }
    [Fact]
    public void RPSTest_Tie_true()
    {
      //Arrange
      Game newGame = new Game("foot", "foot");
      //Act
      Dictionary<string, string> result = newGame.Compare();
      // result = result[0];
      // System.Console.WriteLine(result);
      //Assert
      Assert.Equal(true, newGame.Outcome == "Tie");
    }
  }
}

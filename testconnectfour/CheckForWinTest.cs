using ConnectFour;
using static ConnectFour.GameState;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace testconnectfour
{
    public class UnitTesting
    {
        [Fact]
        public void CheckForWin_NoWinner_EmptyBoard()
        {
            // Arrange
            var gameState = new GameState();
            var expResult = gameState.CheckForWin();

            // Act
            var result = GameState.WinState.No_Winner;

            // Assert
            Assert.Equal(expResult, result);
        }

        [Fact]
        public void CheckForWin_TieGame()
        {
            // Arrange
            var gameState = new GameState();
            gameState.TheBoard = new List<int>
            {
                1, 2, 1, 2, 1, 2, 1,
                2, 1, 2, 1, 2, 1, 2,
                2, 1, 2, 1, 2, 1, 2,
                1, 2, 1, 2, 1, 2, 1,
                2, 1, 2, 1, 2, 1, 2,
                1, 2, 1, 2, 1, 2, 1
            };  //A tie game

            var expResult = GameState.WinState.Tie;

            // Act
            var result = gameState.CheckForWin();

            // Assert
            Assert.Equal(expResult, result);
        }
    }
}

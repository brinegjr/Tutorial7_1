using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;
using Tutorial7;

namespace CucumberTests
{
    [Binding]
    public class PawnMovementSteps
    {
        public Chessboard board = null;
        [Given(@"that I have an empty chessboard")]
        public void GivenThatIHaveAnEmptyChessboard()
        {
            board = new Chessboard();
        }

        public Pawn p = null;
        [Given(@"I have a white pawn at (.)(.)")]
        public void GivenIHaveAWhitePawnAtA(char x, int y)
        {
            p = new Pawn("white");
            board.placePiece(p, new Tuple<char, int>(x, y));
        }
        
        [When(@"I try to move the white pawn from (.)(.) to (.)(.)")]
        public void WhenITryToMoveTheWhitePawnFromAToA(char x, int y, char x2, int y2)
        {
            board.movePiece(new Tuple<char, int>(x, y), new Tuple<char, int>(x2, y2));
        }
        
        [Then(@"the white pawn is placed in (.)(.)\.")]
        public void ThenTheWhitePawnIsPlacedInA_(char x, int y)
        {
            Assert.AreEqual(new Tuple<char, int>(x, y), board.getLocation(p));
        }
    }
}

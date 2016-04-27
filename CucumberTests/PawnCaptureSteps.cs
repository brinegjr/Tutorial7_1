using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;
using Tutorial7;

namespace CucumberTests
{
    [Binding]
    public class PawnCaptureSteps
    {
        PawnMovementSteps moveSteps;
        public PawnCaptureSteps(PawnMovementSteps p)
        {
            moveSteps = p;
        }

        Pawn blackPawn = null;
        [Given(@"I have a black pawn at (.)(.)")]
        public void GivenIHaveABlackPawnAtE(char x, int y)
        {
            blackPawn = new Pawn("black");
            moveSteps.board.placePiece(blackPawn, new Tuple<char, int>(x, y));
        }

        [Then(@"the white pawn is placed in (.)(.)")]
        public void ThenTheWhitePawnIsPlacedInE(char x, int y)
        {
            Assert.AreEqual(new Tuple<char, int>(x, y), moveSteps.board.getLocation(moveSteps.p));
        }

        [Then(@"the black pawn is captured")]
        public void ThenTheBlackPawnIsCaptured()
        {
            Assert.IsTrue(blackPawn.isCaptured());
        }
    }
}

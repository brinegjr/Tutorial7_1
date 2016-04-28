using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;

namespace CucumberTests
{
    [Binding]
    public class OnlyMoveOneSpaceAfterFirstMoveSteps
    {
        public PawnMovementSteps p;
        public PawnCaptureSteps p2;

        public OnlyMoveOneSpaceAfterFirstMoveSteps(PawnMovementSteps p,
            PawnCaptureSteps p2)
        {
            this.p = p;
            this.p2 = p2;
        }

        [When(@"I try to move the black pawn from (.)(.) to (.)(.)")]
        public void WhenITryToMoveTheBlackPawnFromEToE(char x1, int p1, char x2, int p2)
        {
            this.p.board.movePiece(new Tuple<char, int>(x1, p1), new Tuple<char, int>(x2, p2));
        }
        
        [Then(@"the white pawn should not move")]
        public void ThenTheWhitePawnShouldNotMove()
        {
            Assert.AreEqual(new Tuple<char, int>('d', 4), this.p.board.getLocation(this.p.p));
        }
        
        [Then(@"the black pawn should not move")]
        public void ThenTheBlackPawnShouldNotMove()
        {
            Assert.AreEqual(new Tuple<char, int>('e', 4), this.p.board.getLocation(this.p2.blackPawn));
        }
    }
}

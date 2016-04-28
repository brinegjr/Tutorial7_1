using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;

namespace CucumberTests
{
    [Binding]
    public class PawnsInitial2MoveCannotPassThroughOtherPiecesSteps
    {
        public PawnMovementSteps p;
        public PawnCaptureSteps p2;

        public PawnsInitial2MoveCannotPassThroughOtherPiecesSteps(PawnMovementSteps p,
            PawnCaptureSteps p2)
        {
            this.p = p;
            this.p2 = p2;
        }

        [Then(@"the white pawn does not move again")]
        public void ThenTheWhitePawnDoesNotMoveAgain()
        {
            Assert.AreEqual(new Tuple<char, int>('e', 2),
                this.p.board.getLocation(this.p.p));
        }
    }
}

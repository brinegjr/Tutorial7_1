using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;

namespace CucumberTests
{
    [Binding]
    public class CannotMoveThroghOtherPiecesSteps
    {
        public PawnMovementSteps steps;
        public PawnCaptureSteps capt;

        public CannotMoveThroghOtherPiecesSteps(PawnMovementSteps steps,
            PawnCaptureSteps capt)
        {
            this.steps = steps;
            this.capt = capt;
        }

        [Then(@"the white pawn does not move")]
        public void ThenTheWhitePawnDoesNotMove()
        {
            Assert.AreEqual(new Tuple<char, int>('e', 4),
                this.steps.board.getLocation(this.steps.p));
        }
    }
}

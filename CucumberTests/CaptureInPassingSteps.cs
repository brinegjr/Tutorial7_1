using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;

namespace CucumberTests
{
    [Binding]
    public class CaptureInPassingSteps
    {
        public PawnMovementSteps p;
        public PawnCaptureSteps p2;

        public CaptureInPassingSteps(PawnMovementSteps p,
            PawnCaptureSteps p2)
        {
            this.p = p;
            this.p2 = p2;
        }

        [Then(@"the black pawn is captured in passing")]
        public void ThenTheBlackPawnIsCapturedInPassing()
        {
            Assert.IsTrue(this.p2.blackPawn.isCaptured());
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;

namespace CucumberTests
{
    [Binding]
    public class CaptureOnlyWhenDiagonalSteps
    {
        public PawnMovementSteps p;
        public PawnCaptureSteps p2;

        public CaptureOnlyWhenDiagonalSteps(PawnMovementSteps p,
            PawnCaptureSteps p2)
        {
            this.p = p;
            this.p2 = p2;
        }

        [When(@"the white pawn is not captured")]
        public void WhenTheWhitePawnIsNotCaptured()
        {
            Assert.IsFalse(this.p.p.isCaptured());
        }
    }
}

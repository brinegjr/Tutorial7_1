Feature: CaptureInPassing

@capture @happypath
Scenario: Capture in passing
	Given that I have an empty chessboard
	And I have a white pawn at e5
	And I have a black pawn at f7
	When I try to move the black pawn from f7 to f5
	And I try to move the white pawn from e5 to f6
	Then the black pawn is captured in passing

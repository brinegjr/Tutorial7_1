Feature: CaptureOnlyWhenDiagonal

@capture @happypath
Scenario: Capture only when diagonal
	Given that I have an empty chessboard
	And I have a white pawn at e4
	And I have a black pawn at f6
	When I try to move the black pawn from f6 to e4 
	And the white pawn is not captured

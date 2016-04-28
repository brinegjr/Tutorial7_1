Feature: OnlyMoveOneSpaceAfterFirstMove

@mytag
Scenario: OnlyMoveOneSpaceAfterFirstMove
	Given that I have an empty chessboard
	And I have a black pawn at e6
	And I have a white pawn at d2
	When I try to move the white pawn from d2 to d4
	And I try to move the black pawn from e6 to e4
	And I try to move the white pawn from d4 to d6
	And I try to move the black pawn from e4 to e2
	Then the white pawn should not move
	And the black pawn should not move

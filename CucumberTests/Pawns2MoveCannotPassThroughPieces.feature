Feature: Pawns initial 2 move cannot pass through other pieces

@movement @happypath
Scenario: 2MoveThroughPieces
	Given that I have an empty chessboard
	And I have a black pawn at e3
	And I have a white pawn at e2
	When I try to move the white pawn from e2 to e4
	Then the white pawn does not move again

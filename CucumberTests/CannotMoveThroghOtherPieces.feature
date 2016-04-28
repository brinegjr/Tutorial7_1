Feature: CannotMoveThroghOtherPieces
	As a player, I want my to not be able to
	move through other pieces.

@movement @happypath
Scenario: Cannot move through other pieces
	Given that I have an empty chessboard
	And I have a black pawn at e5
	And I have a white pawn at e4
	When I try to move the white pawn from e4 to e5
	Then the white pawn does not move

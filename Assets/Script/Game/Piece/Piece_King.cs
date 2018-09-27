﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piece_King : Piece
{
    public override void Init(BoardPoint point)
    {
        currentPoint = point;
        type = Enums.PieceType.King;

        pieceMovement.isMoveOnlyInField = true;
        pieceMovement.mustJumpOtherPiece = false;
        pieceMovement.canUseDiagonal = true;
        pieceMovement.canMoveInfinite = false;

        pieceMovement.moveDirection = new int[,] {
            { 0,0,0,0,0,0,0},
            { 0,0,0,0,0,0,0},
            { 0,0,2,2,2,0,0},
            { 0,0,2,1,2,0,0},
            { 0,0,2,2,2,0,0},
            { 0,0,0,0,0,0,0},
            { 0,0,0,0,0,0,0},
        };

        transform.localPosition = point.transform.localPosition;
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GAMECOTUONG
{
    //Xe
    public class Rook : Piece
    {
        #region Constructor
        public Rook(string strPos, ECons.Color Color) : base(Color)
        {
            Pos = strPos;
            Col = Convert.ToInt16(strPos);
            switch (Color)
            {
                case ECons.Color.Black:
                    Row = 0;
                    Pic.Image = GAMECOTUONG.Properties.Resources.blackRook;
                    break;
                case ECons.Color.Red:
                    Row = 9;
                    Pic.Image = GAMECOTUONG.Properties.Resources.redRook;
                    break;
            }
            base.InitXY();
            Game.bBoard[Row, Col].Trong = false;
            Game.bBoard[Row, Col].Color = Color;
            Game.bBoard[Row, Col].Pos = strPos;
            Game.bBoard[Row, Col].PieceType = ECons.Piece.Rook;
        }
        #endregion

        #region Methods
        public override void CreateMoves()
        {
            listMove = new List<Move>();
            #region Cùng cột 
            int iRow = Row - 1;
            while (iRow >= 0 && Game.bBoard[iRow, Col].Trong == true)
            {
                if (BoardControl.CoQuanCheTuong(this, iRow, Col))
                    listMove.Add(new Move(this.Row, this.Col, iRow, this.Col));
                iRow--;
            }
            if (iRow >= 0)
            {
                if (BoardControl.CoQuanCheTuong(this, iRow, Col))
                    if (Game.bBoard[iRow, Col].Color != this.Color)
                        listMove.Add(new Move(this.Row, this.Col, iRow, this.Col));
            }

            iRow = Row + 1;
            while (iRow < 10 && Game.bBoard[iRow, Col].Trong == true)
            {
                if (BoardControl.CoQuanCheTuong(this, iRow, Col))
                    listMove.Add(new Move(this.Row, this.Col, iRow, this.Col));
                iRow++;
            }

            if (iRow < 10)
            {
                if (BoardControl.CoQuanCheTuong(this, iRow, Col))
                    if (Game.bBoard[iRow, Col].Color != this.Color)
                        listMove.Add(new Move(this.Row, this.Col, iRow, this.Col));
            }
            #endregion

            #region Cùng hàng 
            int iCol = Col - 1;
            while (iCol >= 0 && Game.bBoard[Row, iCol].Trong == true)
            {
                if (BoardControl.CoQuanCheTuong(this, Row, iCol))
                    listMove.Add(new Move(this.Row, this.Col, this.Row, iCol));
                iCol--;
            }
            if (iCol >= 0)
            {
                if (BoardControl.CoQuanCheTuong(this, Row, iCol))
                    if (Game.bBoard[Row, iCol].Color != this.Color)
                        listMove.Add(new Move(this.Row, this.Col, this.Row, iCol));
            }

            iCol = Col + 1;
            while (iCol < 9 && Game.bBoard[Row, iCol].Trong == true)
            {
                if (BoardControl.CoQuanCheTuong(this, Row, iCol))
                    listMove.Add(new Move(this.Row, this.Col, this.Row, iCol));
                iCol++;
            }
            if (iCol < 9)
            {
                if (BoardControl.CoQuanCheTuong(this, Row, iCol))
                    if (Game.bBoard[Row, iCol].Color != this.Color)
                        listMove.Add(new Move(this.Row, this.Col, this.Row, iCol));
            }
            #endregion
        } 
        #endregion
    }
}
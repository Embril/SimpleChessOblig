using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleChess
{
    class Pawn : Piece
    {
        public Pawn() : base("PWN")
        {
            
        }

        public override bool Move(string fromPosition, string toPosition)
        {
            var diffCol = fromPosition[0] - toPosition[0];
            var diffRow = fromPosition[1] - toPosition[1];



            if (diffCol > 0)
            {
                if (diffCol == 1)
                {
                    if (diffRow== 1 || diffRow== -1)
                    {
                        return true;
                    }

                    if (diffRow == 0)
                    {
                        return true;
                    }
                }
                if (diffCol   ==   2 && diffRow == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}

//diffCol diffRow   ja/nei
//-1        -1       nei 
//-1         0       nei
//-1         1       nei

//0        -1        nei 
//0         0        nei
//0         1        nei
        
//1        -1        ja - Kun hvis det står en brikke der
//1         0        ja 
//1         1        ja - kun hvis det står en brikke der   

//2        0         ja - hvis første trekk
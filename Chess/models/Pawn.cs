using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.models
{
    public class Pawn : AChess
    {
        public Pawn()
        {
            Coordinate = new Coordinate(12,44);
        }

        public override List<Coordinate> searchWay()
        {
            List<Coordinate> result = new();
            if(Color == ColorType.WHITE)
            {
                result.Add(new Coordinate(Coordinate.X, Coordinate.Y+1));
                result.Add(new Coordinate(Coordinate.X+1, Coordinate.Y+1));
                result.Add(new Coordinate(Coordinate.X-1, Coordinate.Y+1));
            }
            if (Color == ColorType.BLACK)
            {
                result.Add(new Coordinate(Coordinate.X, Coordinate.Y - 1));
                result.Add(new Coordinate(Coordinate.X+1, Coordinate.Y - 1));
                result.Add(new Coordinate(Coordinate.X-1, Coordinate.Y - 1));
            }
            return result;

        }
    }
}

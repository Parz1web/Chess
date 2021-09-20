using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.models
{
    public abstract class AChess
    {

        private ColorType color;
        private Coordinate coordinate;

        public AChess(ColorType color, Coordinate coordinate)
        {
            Color = color;
            Coordinate = coordinate;
        }

        public AChess() { }

        public ColorType Color { get => color; set => color = value; }
        public Coordinate Coordinate { get => coordinate; set => coordinate = value; }


        public void move(int x, int y)
        {
            coordinate.X = x;
            coordinate.Y = y;
        }
        abstract public List<Coordinate> searchWay();

        public enum ColorType
        {
            BLACK, WHITE
        }
    }


    
}

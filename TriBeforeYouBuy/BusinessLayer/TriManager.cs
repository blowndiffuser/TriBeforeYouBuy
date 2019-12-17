using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TriBeforeYouBuy.Models;

namespace TriBeforeYouBuy.BusinessLayer
{
    public  class TriManager
    {
        /// <summary>
        /// Calculate triangle coordinates given a specified row and column
        /// </summary>
        /// <param name="row"></param>
        /// <param name="col"></param>
        /// <returns></returns>
        public static Triangle GetTriangleCoords(int row, int col)
        {
            var col_even = col % 2 == 0;
            var size = 10;

            var r = row * size;

            var coffset = (col * size) / 2;
            var c = col_even ? col * size - coffset : col * size - (coffset + (size / 2));

            var coords = new Triangle
            {
                V1 = new Point(c, r),
                V2 = new Point(col_even ? c : c + size, col_even ? r + size : r),
                V3 = new Point(c + size, r + size)
            };            

            return coords;
        }


        /// <summary>
        /// Get Row/Col coordinate from triangle coordinates
        /// </summary>
        /// <param name="triangle"></param>
        /// <returns></returns>
        public static Coordinate GetCoordinateFromTriangle(Triangle triangle)
        {
            for (int c = 0; c < 12; c++)
            {
                for (int r = 0; r < 12; r++)
                {
                    var tempCoords = GetTriangleCoords(r, c);

                    if (tempCoords.V1.X == triangle.V1.X &&
                        tempCoords.V1.Y == triangle.V1.Y &&
                        tempCoords.V2.X == triangle.V2.X &&
                        tempCoords.V2.Y == triangle.V2.Y &&
                        tempCoords.V3.X == triangle.V3.X &&
                        tempCoords.V3.Y == triangle.V3.Y
                        )
                    {
                        return new Coordinate
                        {
                            Row = r,
                            Col = c
                        };
                    }
                }
            }

            return null;
        }

    }
}

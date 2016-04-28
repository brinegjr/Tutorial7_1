using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial7
{
    public class Chessboard
    {
        Dictionary<Tuple<char, int>, Pawn> dict;
        public Chessboard()
        {
            dict = new Dictionary<Tuple<char, int>, Pawn>();
        }

        public void placePiece(Pawn p, Tuple<char, int> tuple)
        {
            dict.Add(tuple, p);
        }

        public void movePiece(Tuple<char, int> tuple1, Tuple<char, int> tuple2)
        {
            Pawn p = dict[tuple1];
            bool otherP = dict.ContainsKey(tuple2);

            if (Math.Abs(tuple1.Item2 - tuple2.Item2) > 2)
            {
                return;
            }

            if (p.hasMoved && Math.Abs(tuple1.Item2 - tuple2.Item2) == 2)
            {
                return;
            }

            if (dict.Remove(tuple1))
            {
                if (otherP)
                {
                    if (tuple1.Item1 == tuple2.Item1)
                    {
                        dict.Add(tuple1, p);
                        return;
                    } else
                    {
                        dict.Remove(tuple2);
                        dict.Add(tuple2, p);
                    }
                } else
                {
                    if (((tuple1.Item2 == 2 && tuple2.Item2 == 4 && p.type == "white")
                        || (tuple1.Item2 == 6 && tuple2.Item2 == 4 && p.type == "black"))
                        && tuple1.Item1 == tuple2.Item1
                        && dict.ContainsKey(new Tuple<char, int>(tuple1.Item1, 3)))
                    {
                        dict.Add(tuple1, p);
                        return;
                    } else
                    {
                        dict.Add(tuple2, p);
                    }
                }
            }
            p.hasMoved = true;
        }

        public Tuple<char, int> getLocation(Pawn p)
        {
            foreach(Tuple<char, int> tup in dict.Keys)
            {
                if (dict[tup] == p)
                {
                    return tup;
                }
            }
            return null;
        }
    }
}

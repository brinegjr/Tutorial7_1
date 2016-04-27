﻿using System;
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
            if (dict.Remove(tuple1))
            {
                if (otherP)
                {
                    if (dict.Remove(tuple2))
                    {
                        dict.Add(tuple2, p);
                    }
                } else
                {
                    dict.Add(tuple2, p);
                }
            }
            
            
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

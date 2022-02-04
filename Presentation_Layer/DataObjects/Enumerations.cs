using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects
{
    public enum Suit
    {
        Spades, //0
        Hearts, //1
        Clubs, //2
        Diamonds //3
    }

    public enum FaceValue
    {
        Ace = 1, 
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King
    }

    public enum HandValue
    {
        Nothing = 0,
        Pair = 1,
        Two_Pair = 3,
        Three_of_a_Kind = 10,
        Straight = 30,
        Flush = 50,
        Full_House = 75,
        Four_of_a_Kind = 100,
        Straight_Flush = 250,
        Royal_Flush = 500
    }
}

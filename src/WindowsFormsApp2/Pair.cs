﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    // diperluin biar representasi koordinat lebih rapih, dan C# gak ada built in pair
    public class Pair<T1, T2>
    {
        public T1 first { get; set; }
        public T2 second { get; set; }

        public Pair(T1 a, T2 b)
        {
            first = a;
            second = b;
        }

        public override string ToString() 
        {
            return "(" + first.ToString() + "," + second.ToString() + ")";
        }
        public Pair<T1, T2> Clone()
        {
            return new Pair<T1, T2>(first, second);
        }

        public static Pair<T1, T2> operator + (Pair<T1, T2> a, Pair<T1, T2> b)
        {
            return new Pair<T1, T2>((dynamic) a.first + b.first, (dynamic) a.second + b.second);
        }

        public static Pair<T1, T2> operator - (Pair<T1, T2> a, Pair<T1, T2> b)
        {
            return new Pair<T1, T2>((dynamic) a.first - b.first, (dynamic) a.second - b.second);
        }

        public override bool Equals(object other)
        {
            if (other == null)
                return false;
            if (GetType() != other.GetType())
                return false;
            var otherp = (Pair<T1, T2>)other;
            return (first.Equals(otherp.first)) && (second.Equals(otherp.second));
        }

        public override int GetHashCode()
        {   // ? gatau ini bener apa gak cuma bikin karena dibutuhin
            return ToString().GetHashCode();
        }

        public static bool operator ==(Pair<T1, T2> a, Pair<T1, T2> b)
        {
            return a.first.Equals(b.first) && a.second.Equals(b.second);
        }

        public static bool operator !=(Pair<T1, T2> a, Pair<T1, T2> b)
        {
            return !(a.first.Equals(b.first)) || !(a.second.Equals(b.second));
        }
    }
}

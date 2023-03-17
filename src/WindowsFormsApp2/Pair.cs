using System.Collections.Generic;

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
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    internal class TraverseRule
    {
        public readonly static Dictionary<string, Pair<int, int>> moveDirection =
            new Dictionary<string, Pair<int, int>>()
            {
                {"L", new Pair<int, int>(0, -1) },
                {"R", new Pair<int, int>(0, 1) },
                {"U", new Pair<int, int>(-1, 0) },
                {"D", new Pair<int, int>(1, 0) }
            };

        public readonly static Dictionary<string, string> reverseDirection = new Dictionary<string, string>()
        {
            {"L", "R"},
            {"R", "L"},
            {"U", "D"},
            {"D", "U"},
            {"", ""}
        };
    }
}

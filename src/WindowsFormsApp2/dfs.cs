using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    internal class DFS
    {
        private static List<Pair<string,Pair<int, int>>> moveDirection = 
            new List<Pair<string, Pair<int, int>>>()
        {
            new Pair<string, Pair<int, int>>("L", new Pair<int, int>(0, -1)),
            new Pair<string, Pair<int, int>>("R", new Pair<int, int>(0, 1)),
            new Pair<string, Pair<int, int>>("U", new Pair<int, int>(-1, 0)),
            new Pair<string, Pair<int, int>>("D", new Pair<int, int>(1, 0))
        };

        private static Dictionary<string, string> reverseDirection = new Dictionary<string, string>()
        {
            {"L", "R"},
            {"R", "L"},
            {"U", "D"},
            {"D", "U"},
            {"", ""}
        };

        private int sizeX, sizeY;
        private char[,] peta;
        private Pair<int, int> startCoordinate;
        private List<Pair<int, int>> treasuresCoordinate;
        private bool[,] visited;
        private Pair<int, int>[,] pred;

        public DFS(InputUtils inputUtils)
        {
            this.peta = (char[,]) inputUtils.matrix.Clone();
            this.startCoordinate = inputUtils.startCoordinate;
            this.treasuresCoordinate = new List<Pair<int, int>>(inputUtils.treasureCoordinate);

            this.sizeX = inputUtils.matrix.GetLength(0);
            this.sizeY = inputUtils.matrix.GetLength(1);

            this.pred = new Pair<int, int>[sizeX, sizeY];
            this.visited = new bool[sizeX,sizeY];
        }
        private void traverse(Pair<int, int> pos, ref string path, string prevDirection = "")
        {
            if (outside(pos)) { return; }
            if (this.visited[pos.first, pos.second]) { return; }
            this.visited[pos.first, pos.second] = true;

            path += prevDirection;

            foreach (var direction in moveDirection)
            {
                traverse(pos + direction.second, ref path, direction.first);
            }

            path += reverseDirection[prevDirection];
        }
        public string solve()
        {
            string path = "";
            traverse(startCoordinate, ref path);
            
            return path;
        }

        public void test()
        {
            MessageBox.Show(peta.ToString());
        }

        private bool outside(Pair<int, int> pos)
        {
            return pos.first < 0 || pos.second < 0 || pos.first >= sizeX || pos.second >= sizeY;
        }
    }
}

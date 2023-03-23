using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.Pkcs;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    internal class DFS
    {
        private int sizeX, sizeY;
        private char[,] petaAwal;
        private char[,] peta;
        private Pair<int, int> startCoordinate;
        private List<Pair<int, int>> treasuresCoordinate;
        private bool[,] visited;
        private bool[,] needed;
        private Pair<int, int>[,] pred;

        private int found;
        private StringBuilder directPath;
        private int nodeTraversed;

        public DFS(InputUtils inputUtils)
        {
            this.petaAwal = (char[,]) inputUtils.matrix.Clone();
            this.startCoordinate = inputUtils.startCoordinate.Clone();
            this.treasuresCoordinate = new List<Pair<int, int>>(inputUtils.treasureCoordinate);

            this.sizeX = inputUtils.matrix.GetLength(0);
            this.sizeY = inputUtils.matrix.GetLength(1);

            this.pred = new Pair<int, int>[sizeX, sizeY];
            this.visited = new bool[sizeX,sizeY];
            this.needed = new bool[sizeX,sizeY];
        }
        private bool traverse(Pair<int, int> pos, ref List<(PathAction, Pair<int, int>)> path, string prevDirection = "")
        {
            if (found == treasuresCoordinate.Count) { return false; }
            if (Outside(pos)) { return false; }
            if (this.visited[pos.first, pos.second]) { return false; }
            if (peta[pos.first, pos.second] == 'X') { return false; }
            this.visited[pos.first, pos.second] = true;
            nodeTraversed++;

            path.Add((PathAction.ProcessStart, pos));
            directPath.Append(prevDirection);
            var currentNodeNeeded = false;

            if (peta[pos.first, pos.second] == 'T')
            {
                found++;
                currentNodeNeeded = true;
            }

            foreach (var direction in TraverseRule.moveDirection)
            {
                currentNodeNeeded |= traverse(pos + direction.Value, ref path, direction.Key);
            }

            path.Add((PathAction.ProcessFinish, pos));
            if (found != treasuresCoordinate.Count) 
            { 
                directPath.Append(TraverseRule.reverseDirection[prevDirection]); 
            }
            return needed[pos.first, pos.second] = currentNodeNeeded;
        }
        public (List<(PathAction, Pair<int, int>)>, string, int, int) Solve()
        {
            HardReset();
            var searchPath = new List<(PathAction, Pair<int, int>)>();
            string path = "";
            
            traverse(startCoordinate, ref searchPath);
            var coordinate = new Pair<int, int>(startCoordinate.first, startCoordinate.second);

            foreach (char c in directPath.ToString())
            {
                bool prevNeed = needed[coordinate.first, coordinate.second];
                coordinate += TraverseRule.moveDirection[c.ToString()];
                if (needed[coordinate.first, coordinate.second] && prevNeed)
                {
                    path += c;
                }
            }
            
            return (searchPath, path, nodeTraversed, path.Length);
        }
        private void HardReset()
        {
            peta = (char[,])petaAwal.Clone();
            found = 0;
            nodeTraversed = 0;
            directPath = new StringBuilder();
            for (int i = 0; i < pred.GetLength(0); i++)
            {
                for (int j = 0; j < pred.GetLength(1); j++)
                {
                    pred[i, j] = new Pair<int, int>(0, 0);

                    visited[i, j] = false;
                    needed[i, j] = false;
                }
            }
        }

        private bool Outside(Pair<int, int> pos)
        {
            return pos.first < 0 || pos.second < 0 || pos.first >= sizeX || pos.second >= sizeY;
        }
    }
}

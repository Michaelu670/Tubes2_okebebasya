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
        private int sizeX, sizeY;
        private char[,] petaAwal;
        private char[,] peta;
        private Pair<int, int> startCoordinate;
        private List<Pair<int, int>> treasuresCoordinate;
        private bool[,] visited;
        private Pair<int, int>[,] pred;

        private int found;
        private bool currentSearchFound;
        private string directPath;

        public DFS(InputUtils inputUtils)
        {
            this.petaAwal = (char[,]) inputUtils.matrix.Clone();
            this.startCoordinate = inputUtils.startCoordinate.Clone();
            this.treasuresCoordinate = new List<Pair<int, int>>(inputUtils.treasureCoordinate);

            this.sizeX = inputUtils.matrix.GetLength(0);
            this.sizeY = inputUtils.matrix.GetLength(1);

            this.pred = new Pair<int, int>[sizeX, sizeY];
            this.visited = new bool[sizeX,sizeY];
        }
        private void traverse(Pair<int, int> pos, ref string path, string prevDirection = "")
        {
            if (currentSearchFound) { return; }
            if (Outside(pos)) { return; }
            if (this.visited[pos.first, pos.second]) { return; }
            if (peta[pos.first, pos.second] == 'X') { return; }
            this.visited[pos.first, pos.second] = true;

            if (peta[pos.first, pos.second] == 'T')
            {
                found++;
                currentSearchFound = true;
                peta[pos.first, pos.second] = 'R';

                startCoordinate = pos;
                return;
            }

            path += prevDirection;

            foreach (var direction in TraverseRule.moveDirection)
            {
                traverse(pos + direction.Value, ref path, direction.Key);
                if (currentSearchFound)
                {
                    directPath += direction.Key;
                    break;
                }
            }

            path += TraverseRule.reverseDirection[prevDirection];
        }
        public (string, string) Solve()
        {
            HardReset();
            string searchPath = "";
            string path = "";
            
            for (int i = 0; i < treasuresCoordinate.Count; i++)
            {
                SoftReset();
                traverse(startCoordinate, ref searchPath);
                char[] charArr = directPath.ToCharArray();
                Array.Reverse(charArr);
                path += new string(charArr);
            }
            
            return (searchPath, path);
        }
        private void HardReset()
        {
            peta = (char[,])petaAwal.Clone();
            found = 0;
        }
        private void SoftReset()
        {
            directPath = "";
            currentSearchFound = false;
            for (int i = 0; i < pred.GetLength(0); i++)
            {
                for (int j = 0; j < pred.GetLength(1); j++)
                {
                    pred[i, j] = new Pair<int, int>(0, 0);

                    visited[i, j] = false;
                }
            }
        }

        private bool Outside(Pair<int, int> pos)
        {
            return pos.first < 0 || pos.second < 0 || pos.first >= sizeX || pos.second >= sizeY;
        }
    }
}

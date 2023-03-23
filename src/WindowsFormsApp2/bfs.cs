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
    internal class BFS
    {
        private int sizeX, sizeY;
        private char[,] petaAwal;
        private char[,] peta;
        private Pair<int, int> startCoordinate;
        private List<Pair<int, int>> treasuresCoordinateAwal;
        private bool[,] visited;
        private bool[,,] canMove;

        private string[,] moveFrom;

        public BFS(InputUtils inputUtils)
        {
            this.petaAwal = (char[,])inputUtils.matrix.Clone();
            this.startCoordinate = inputUtils.startCoordinate.Clone();
            this.treasuresCoordinateAwal = new List<Pair<int, int>>(inputUtils.treasureCoordinate);
            this.canMove = (bool[,,])inputUtils.canMove.Clone();

            this.sizeX = inputUtils.matrix.GetLength(0);
            this.sizeY = inputUtils.matrix.GetLength(1);

            this.moveFrom = new string[sizeX, sizeY];
            this.visited = new bool[sizeX, sizeY];
        }
        public (List<(PathAction, Pair<int, int>)>, string, int, int) Solve()
        {
            // return value
            List<(PathAction, Pair<int, int>)> stateChange = new List<(PathAction, Pair<int, int>)>();
            string path = "";
            int nodeVisited = 0;
            int steps;

            // intiliaze bfs variable
            List<Pair<int, int>> treasuresCoordinate = new List<Pair<int, int>>(treasuresCoordinateAwal);
            Queue<Pair<int,int>> searchQueue = new Queue<Pair<int, int>>();
            string[] move = {"L", "R", "U", "D"};

            // start from K
            Pair<int,int> start = startCoordinate.Clone();
            searchQueue.Enqueue(start);
            visited[start.first, start.second] = true;
            stateChange.Add((PathAction.ProcessStart, start));


            // bfs
            HardReset();
            while(searchQueue.Count > 0 && treasuresCoordinate.Count > 0){
                Pair<int,int> curr = searchQueue.Dequeue();
                bool found = false;

                for(int i=0;i<4;i++){
                    if(canMove[curr.first, curr.second, i] == false){continue;}
                    Pair<int,int> next = curr + TraverseRule.moveDirection[move[i]];
                    if(visited[next.first, next.second] == true){continue;}
                
                    visited[next.first, next.second] = true;
                    moveFrom[next.first, next.second] = move[i];

                    if(treasuresCoordinate.Contains(next)){ // found
                        // write path
                        stateChange.Add((PathAction.ProcessStart, next));
                        Pair<int,int> currBacktrack = next.Clone();
                        string currPath = "";
                        while(currBacktrack != start){
                            string backmove = moveFrom[currBacktrack.first, currBacktrack.second];
                            currPath += backmove;
                            currBacktrack -= TraverseRule.moveDirection[backmove];
                        }
                        currPath = new string(currPath.Reverse().ToArray());
                        path += currPath;
                        stateChange.Add((PathAction.Reset, next));
                        treasuresCoordinate.Remove(next);

                        // start again
                        SoftReset();
                        searchQueue.Clear();
                        start = next.Clone();
                        searchQueue.Enqueue(start);
                        visited[start.first, start.second] = true;
                        stateChange.Add((PathAction.ProcessStart, start));

                        // stop this loop
                        found = true;
                        break;
                    }else{ // continue search
                        searchQueue.Enqueue(next);
                        stateChange.Add((PathAction.ProcessStart, next));
                    }
                }
                if(!found){stateChange.Add((PathAction.ProcessFinish, curr));}

            }

            nodeVisited = stateChange.Count(el => el.Item1 == PathAction.ProcessStart); // ? mungkin gini aja bener
            steps = path.Length;
            return (stateChange, path, nodeVisited, steps);
        }
        private void HardReset()
        {
            peta = (char[,])petaAwal.Clone();
        }
        private void SoftReset()
        {
            for (int i = 0; i < sizeX; i++)
            {
                for (int j = 0; j < sizeY; j++)
                {
                    moveFrom[i, j] = "";
                    visited[i, j] = false;
                }
            }
        }
    }
}

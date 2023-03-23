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
    internal class TSP
    {
        private int sizeX, sizeY;
        private char[,] petaAwal;
        private Pair<int, int> startCoordinate;
        private List<Pair<int, int>> treasuresCoordinateAwal;
        private bool[,,] canMove;

        private int[,] shortestPathMove;
        private string[,] shortestPathString;
        private string[,] moveFrom;

        public TSP(InputUtils inputUtils)
        {
            this.petaAwal = (char[,])inputUtils.matrix.Clone();
            this.startCoordinate = inputUtils.startCoordinate.Clone();
            this.treasuresCoordinateAwal = new List<Pair<int, int>>(inputUtils.treasureCoordinate);
            this.canMove = (bool[,,])inputUtils.canMove.Clone();

            this.sizeX = inputUtils.matrix.GetLength(0);
            this.sizeY = inputUtils.matrix.GetLength(1);
        }
        public (List<(PathAction, Pair<int, int>)>, string, int, int) Solve()
        {
            // return value
            string path = "";

            calculateShortestPath();
            
            int banyakTreasure = treasuresCoordinateAwal.Count();
            int[] indexTreasure = new int[banyakTreasure];
            for(int i=0;i<banyakTreasure;i++){
                indexTreasure[i] = i;
            }
            List<int[]> permutations = Permutation.Permutations(indexTreasure);

            int bestAnswerMove = int.MaxValue;
            string bestAnswerPath = "";
            int startIndex = banyakTreasure;
            foreach(int[] p in permutations){
                int distance = 0;
                string currpath = "";
                
                distance += shortestPathMove[startIndex, p[0]];
                currpath += shortestPathString[startIndex, p[0]];
                for(int i=0;i<banyakTreasure-1;i++){ // ? bisa di exhaustive tapi gak improve banyak
                    distance += shortestPathMove[i, i+1];
                    currpath += shortestPathString[i, i+1];
                }
                distance += shortestPathMove[p[banyakTreasure-1], startIndex];
                currpath += shortestPathString[p[banyakTreasure-1], startIndex];

                if(distance < bestAnswerMove){
                    bestAnswerMove = distance;
                    bestAnswerPath = (string)currpath.Clone();
                }
            }

            List<(PathAction, Pair<int, int>)> stateChange = new List<(PathAction, Pair<int, int>)>(); // null for TSP
            path = (string)bestAnswerPath.Clone();
            int nodeVisited = 0; // null for TSP
            int steps = path.Length;
            return (stateChange, path, nodeVisited, steps);
        }
        private void calculateShortestPath(){
            // calculate treasure all pair shortest path
            treasuresCoordinateAwal.Add(startCoordinate); // titik awal juga dihitung

            int banyakTreasure = treasuresCoordinateAwal.Count();
            this.shortestPathMove = new int[banyakTreasure, banyakTreasure];
            this.shortestPathString = new string[banyakTreasure, banyakTreasure];
            for(int i=0;i<banyakTreasure;i++){
                bfs(i);
            }

            treasuresCoordinateAwal.Remove(startCoordinate);
        }
        private void bfs(int index){
            // search treasure single source shortest path using bfs
            // bfs variable
            string[] move = {"L", "R", "U", "D"};
            int banyakTreasure = treasuresCoordinateAwal.Count();
            bool[,] visited = new bool[sizeX, sizeY];
            this.moveFrom = new string[sizeX, sizeY];

            // start from current index
            Queue<Pair<int,int>> searchQueue = new Queue<Pair<int, int>>();
            searchQueue.Enqueue(treasuresCoordinateAwal[index]);
            visited[treasuresCoordinateAwal[index].first, treasuresCoordinateAwal[index].second] = true;

            while(searchQueue.Count > 0){
                Pair<int,int> curr = searchQueue.Dequeue();
                for(int i=0;i<4;i++){
                    if(canMove[curr.first, curr.second, i] == false){continue;}
                    Pair<int,int> next = curr + TraverseRule.moveDirection[move[i]];
                    if(visited[next.first, next.second] == true){continue;}
                
                    visited[next.first, next.second] = true;
                    moveFrom[next.first, next.second] = move[i];
                    searchQueue.Enqueue(next);
                }
            }

            for(int i=0;i<banyakTreasure;i++){
                string path = backtrackPath(i, index);
                shortestPathMove[index, i] = path.Length;
                shortestPathString[index, i] = path;
            }
        }
        private string backtrackPath(int from, int start){
            string path = "";
            Pair<int,int> curr = treasuresCoordinateAwal[from];
            while(curr != treasuresCoordinateAwal[start]){
                string backmove = moveFrom[curr.first, curr.second];
                path += backmove;
                curr -= TraverseRule.moveDirection[backmove];
            }
            path = new string(path.Reverse().ToArray());
            return path;
        }

    }
}

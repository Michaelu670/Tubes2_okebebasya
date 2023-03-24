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
        public (List<(PathAction, Pair<int, int>)>, string, int, int) Bruteforce()
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
                    distance += shortestPathMove[p[i], p[i+1]];
                    currpath += shortestPathString[p[i], p[i+1]];
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
        public (List<(PathAction, Pair<int, int>)>, string, int, int) DP()
        {
            // init
            calculateShortestPath();
            int banyakTreasure = treasuresCoordinateAwal.Count + 1;

            // dp table n * 2^n
            int n = banyakTreasure;
            int start = banyakTreasure - 1;
            int nmask = (1 << n);
            int[,] dp = new int[n, nmask];
            int[,] prev = new int[n, nmask];

            const int infinity = int.MaxValue/4; // kalo maxvalue doang overflow, kalo long masalah casting
            for(int i=0;i<n;i++){
                for(int j=0;j<nmask;j++){
                    dp[i, j] = infinity;
                    prev[i, j] = -1;
                }
            }

            dp[start, (1<<start)] = 0; // init base case

            // iterate dp sub-problem
            int mask, curr, next, last;
            for(mask=1;mask<nmask;mask++){ // kita visit semua treasure yang masknya on
                for(last=0;last<n;last++){ // misal di mask itu kita terakhir di last
                    for(next=0;next<n;next++){ // misal kita mau jalan dari last ke next
                        int new_mask = mask | (1 << next); // tandain next udah ke visit
                        int newdist = dp[last, mask] + shortestPathMove[last, next]; // catet new dist kalo visit next
                        if(newdist < dp[next, new_mask]){
                            dp[next, new_mask] = newdist;
                            prev[next, new_mask] = last;
                        }
                    }
                }
            }

            int ans = infinity;
            int last_treasure = -1;
            for(last=0;last<n;last++){
                if(last != start){
                    int newans = dp[last, nmask - 1] + shortestPathMove[start, last];
                    if(newans < ans){
                        ans = newans;
                        last_treasure = last;
                    }
                }
            }

            // backtracking path
            string path = "";
            mask = nmask - 1;
            curr = last_treasure;
            path += shortestPathString[start, curr];
            while(curr != start){
                next = prev[curr, mask];
                path += shortestPathString[curr, next];
                mask ^= (1 << curr); // unvisit yang sekarang
                curr = next;
            }

            List<(PathAction, Pair<int, int>)> stateChange = new List<(PathAction, Pair<int, int>)>(); // null for TSP
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

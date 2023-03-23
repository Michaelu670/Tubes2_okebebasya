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
    public class Permutation // for TSP bruteforce
    {
        public static List<int[]> Permutations(int[] array){
            List<int[]> permutations = new List<int[]>();
            int[] arrayCopy = (int[])array.Clone();
            generatePermutation(ref arrayCopy, 0, ref permutations);
            return permutations;
        }

        private static void generatePermutation(ref int[] array, int idx, ref List<int[]> permutations){
            if(idx == (array.Count() - 1)){
                permutations.Add((int[]) array.Clone());
            }

            int prev = -1;
            for(int j=idx;j<array.Count();j++){
                int[] tmp = (int[])array.Clone();
                if(j > idx && tmp[idx].Equals(tmp[j]))continue;
                if(prev != -1 && prev == array[j])continue;
                swap(ref tmp, idx, j);
                prev = array[j];
                generatePermutation(ref tmp, idx + 1, ref permutations);
            }
        }

        private static void swap(ref int[] array, int i, int j){
            int tmp = array[i];
            array[i] = array[j];
            array[j] = tmp;
        }
    }
}

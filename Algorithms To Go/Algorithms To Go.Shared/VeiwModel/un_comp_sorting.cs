using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms_To_Go.VeiwModel
{
    public class un_comp_sorting
    {
        public int ID { get; set; }
        public string PName { get; set; }
        public string PImage { get; set; }
        public string desc { get; set; }
        public string comp { get; set; }

        public string link1 { get; set; }
        public string link2 { get; set; }
        public string Images1 { get; set; }
        public string Images2 { get; set; }
        public string Images3 { get; set; }
        public string Images4 { get; set; }
        public string Images5 { get; set; }
        public string Images6 { get; set; }
        public string Images7 { get; set; }

        public string pseudo_code1 { get; set; }
        public string pseudo_code2 { get; set; }
        public string analysis { get; set; }


        public string code_c_plus_plus { get; set; }
        public string code_c_charp { get; set; }
        public string code_java { get; set; }


    }


    public class Data6
    {
        public List<un_comp_sorting> myList6
        {
            get
            {
                return privateList;
            }
        }

        private List<un_comp_sorting> privateList = new List<un_comp_sorting>();


        public void Data_in()
        {
            myList6.Add(new un_comp_sorting()
            {
                ID = 0,
                PName = "Bucket Sort",
              
                PImage = "Assets/unsortings/Bucket/face.png",
                desc = "Combines the better attributes of merge sort and insertion sort.\nLike merge sort, but unlike insertion sort, running time is O(n lg n).\nLike insertion sort, but unlike merge sort, sorts in place.\nIntroduces an algorithm design technique \nCreate data structure (heap) to manage information during the execution of an algorithm.\nArray viewed as a nearly complete binary tree.\nPhysically – linear array.\nLogically – binary tree, filled on all levels (except lowest.)",
                link1 = "NvZG0dZ60RQ",
                link2 = "woTbZMli6z4",
                Images1 = "Assets/unsortings/Bucket/1.png",
                Images2 = "Assets/unsortings/Bucket/2.png",
                Images3 = "Assets/unsortings/Bucket/3.png",
                Images4 = "Assets/unsortings/Bucket/4.png",
                Images5 = "Assets/unsortings/Bucket/5.png",
                Images6 = "Assets/unsortings/Bucket/6.png",
                Images7 = "Assets/unsortings/Bucket/7.png",
                pseudo_code1 = "Assets/unsortings/Bucket/pseudo.PNG",
                pseudo_code2 = "Assets/unsortings/Bucket/pseudo max heap.PNG",
                analysis = "Assets/unsortings/Bucket/analysis.PNG",
                //////////////////////////////////////////////
                code_c_plus_plus = "#include <iostream>\nusing namespace std;\n//Bucket Sort\nvoid bucket_sort (int arr[], int n)\n{\n//Here range is [1,100]\nint m = 101;\n//Create m empty buckets\nint buckets[m];\n//Intialize all buckets to 0\nfor (int i = 0; i < m; ++i)\nbuckets[i] = 0;\n//Increment the number of times each element is present in the input\n//array. Insert them in the buckets\nfor (int i = 0; i < n; ++i)\n++buckets[arr[i]];\n//Sort using insertion sort and concatenate \nfor (int i = 0, j = 0; j < m; ++j)\nfor (int k = buckets[j]; k > 0; --k)\narr[i++] = j;\n}\n//Driver function to test above function\nint main()\n{	\nint input_ar[] = {10, 24, 22, 62, 1, 50, 100, 75, 2, 3};\nint n = sizeof (input_ar) / sizeof (input_ar[0]);\nbucket_sort (input_ar, n);\ncout << \"Sorted Array : \" << endl;	\nfor (int i = 0; i < n; ++i)\ncout << input_ar[i] << \" \";	\nreturn 0;\n}" ,
                code_c_charp = "using System;\nusing System.Collections.Generic;\nusing System.Text;\nnamespace BucketSort\n{\nclass BucketSort\n{\nprivate void Sort(int[] integers)\n{\n//Verify input\nif (integers == null || integers.Length == 0)\nreturn;\n//Find the maximum and minimum values in the array\nint maxValue = integers[0]; //start with first element\nint minValue = integers[0];\n//Note: start from index 1\nfor (int i = 1; i < integers.Length; i++)\n{\nif (integers[i] > maxValue)\nmaxValue = integers[i];\nif (integers[i] < minValue)\nminValue = integers[i];\n}\n//Create a temporary \"bucket\" to store the values in order\n//each value will be stored in its corresponding index\n//scooting everything over to the left as much as possible (minValue)\n//e.g. 34 => index at 34 - minValue\nList<int>[] bucket = new List<int>[maxValue - minValue + 1];\n//Initialize the bucket\nfor (int i = 0; i < bucket.Length; i++)\n{\nbucket[i] = new List<int>();\n}\n//Move items to bucket\nfor (int i = 0; i < integers.Length; i++)\n{\nbucket[integers[i] - minValue].Add(integers[i]);\n}\n//Move items in the bucket back to the original array in order\nint k = 0; //index for original array\nfor (int i = 0; i < bucket.Length; i++)\n{\nif (bucket[i].Count > 0)\n{\nfor (int j = 0; j < bucket[i].Count; j++)\n{\nintegers[k] = bucket[i][j];\nk++;\n}\n}\n}\n}\n}\n} ",
                code_java = "import java.util.Random;\npublic class Bucket_Sort \n{\nstatic int[] sort(int[] sequence, int maxValue) \n{\n// Bucket Sort\nint[] Bucket = new int[maxValue + 1];\nint[] sorted_sequence = new int[sequence.length];\nfor (int i = 0; i < sequence.length; i++)\nBucket[sequence[i]]++;\nint outPos = 0;\nfor (int i = 0; i < Bucket.length; i++)\nfor (int j = 0; j < Bucket[i]; j++)\nsorted_sequence[outPos++] = i;\nreturn sorted_sequence;\n}\nstatic void printSequence(int[] sorted_sequence) \n{\nfor (int i = 0; i < sorted_sequence.length; i++)\nSystem.out.print(sorted_sequence[i] + \" \");\n}\nstatic int maxValue(int[] sequence) \n{\nint maxValue = 0;\nfor (int i = 0; i < sequence.length; i++)\nif (sequence[i] > maxValue)\nmaxValue = sequence[i];\nreturn maxValue;\n}\npublic static void main(String args[]) \n{\nSystem.out.println(\"Sorting of randomly generated numbers using BUCKET SORT\");\nRandom random = new Random();\nint N = 20;\nint[] sequence = new int[N];\nfor (int i = 0; i < N; i++)\nsequence[i] = Math.abs(random.nextInt(100));\nint maxValue = maxValue(sequence);\nSystem.out.println(\"\nOriginal Sequence: \");\nprintSequence(sequence);\nSystem.out.println(\"\nSorted Sequence: \");\nprintSequence(sort(sequence, maxValue));\n}\n}",
                comp = " Complexity : O(n + k)",   

            });


            myList6.Add(new un_comp_sorting()
            {
                ID = 2,
                PName = "Counting Sort",
                // need data
                PImage = "Assets/unsortings/Counting/face.png",
                desc = "Combines the better attributes of merge sort and insertion sort.\nLike merge sort, but unlike insertion sort, running time is O(n lg n).\nLike insertion sort, but unlike merge sort, sorts in place.\nIntroduces an algorithm design technique \nCreate data structure (heap) to manage information during the execution of an algorithm.\nArray viewed as a nearly complete binary tree.\nPhysically – linear array.\nLogically – binary tree, filled on all levels (except lowest.)",
                link1 = "Nz1KZXbghj8",
                link2 = "GrFrAl9TAJ4",
                Images1 = "Assets/unsortings/Counting/1.png",
                Images2 = "Assets/unsortings/Counting/2.png",
                Images3 = "Assets/unsortings/Counting/3.png",
                Images4 = "Assets/unsortings/Counting/4.png",
                Images5 = "Assets/unsortings/Counting/5.png",
                Images6 = "Assets/unsortings/Counting/6.png",
                Images7 = "Assets/unsortings/Counting/7.png",
                pseudo_code1 = "Assets/unsortings/Counting/pseudo.PNG",
                pseudo_code2 = "Assets/unsortings/Counting/pseudo max heap.PNG",
                analysis = "Assets/unsortings/Counting/analysis.PNG",
                //////////////////////////////////////////////
                code_c_plus_plus = "#include <iostream>\nusing namespace std;\nconst int INPUT_SIZE = 20;\nconst int BUCKET_K = 10;\nvoid print(int *input)\n{\nfor ( int i = 0; i < INPUT_SIZE; i++ )\ncout << input[i] << \" \";\ncout << endl;\n}\nvoid countingsort(int* input)\n{\nint CountArr[BUCKET_K] = { 0 };\nfor (int i=0;i<INPUT_SIZE;i++)\n{\nCountArr[input[i]]++;\n}\nint outputindex=0;\nfor (int j=0;j<BUCKET_K;j++)\n{\nwhile (CountArr[j]--)\ninput[outputindex++] = j;\n}\n}\nint main()\n{\nint input[INPUT_SIZE] = { 2, 4, 6, 4, 7, 1, 4, 9, 5, 3, 7, 2, 2, 6, 9, 3, 7, 3, 4, 4 };\ncout << \"Input: \";\nprint(input);\ncountingsort(input);\ncout << \"Output: \";\nprint(input);\nreturn 0;\n}" ,
                code_c_charp = "Oops couldn't found suitable Code.",
                code_java = "Oops couldn't found suitable Code.",
                comp = " Complexity : O(n + k)",   // check this

            });

        }
    }
}

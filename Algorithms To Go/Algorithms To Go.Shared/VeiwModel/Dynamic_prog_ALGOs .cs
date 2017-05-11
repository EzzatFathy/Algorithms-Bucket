using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms_To_Go.VeiwModel
{
    public class Dynamic_prog_ALGOs 
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


    public class Data5
    {
        public List<Dynamic_prog_ALGOs> myList5
        {
            get
            {
                return privateList;
            }
        }

        private List<Dynamic_prog_ALGOs> privateList = new List<Dynamic_prog_ALGOs>();


        public void Data_in()
        {
            myList5.Add(new Dynamic_prog_ALGOs()
            {
                ID = 0,
                PName = "Knapsack Problem",

                /////////////// 
                PImage = "Assets/dynm_prog/Knapsack/face.png",
                desc = "The knapsack problem or rucksack problem is \na problem in combinatorial optimization: \nGiven a set of items, each with a mass and a value, determine the \nnumber of each item to include in a collection so that \nthe total weight is less than or equal to a \ngiven limit and the total value is as large as possible.\n It derives its \n name from the problem faced by someone who is constrained \nby a fixed-size knapsack and must fill it with the most valuable items",
                Images1 = "Assets/dynm_prog/Knapsack/1.png",
                Images2 = "Assets/dynm_prog/Knapsack/4.png",
                Images3 = "Assets/dynm_prog/Knapsack/5.png",
                Images4 = "Assets/dynm_prog/Knapsack/6.png",
                Images5 = "Assets/dynm_prog/Knapsack/7.png",
                Images6 = "Assets/dynm_prog/Knapsack/8.png",
                Images7 = "Assets/dynm_prog/Knapsack/9.png",
                pseudo_code1 = "Assets/dynm_prog/Knapsack/pseudo1.PNG",
                pseudo_code2 = "Assets/dynm_prog/Knapsack/pseudo2.PNG",
                analysis = "Assets/dynm_prog/Knapsack/analysis.PNG",
                /////////////////////////

                code_c_plus_plus = "#include <stdio.h>\n#define max(a,b) (a > b ? a : b)\nint matrix[100][100] = {0};\nint picks[100][100] = {0};\nint knapsack(int nItems, int size, int weights[], int values[]){\nint i,j;\nfor (i=1;i<=nItems;i++){\nfor (j=0;j<=size;j++){\nif (weights[i-1]<=j){\nmatrix[i][j] = max(matrix[i-1][j],values[i-1]+matrix[i-1][j-weights[i-1]]);\nif (values[i-1]+matrix[i-1][j-weights[i-1]]>matrix[i-1][j])\npicks[i][j]=1;\nelse\npicks[i][j]=-1;\n}\nelse{\npicks[i][j] = -1;\nmatrix[i][j] = matrix[i-1][j];\n}\n}\n}\nreturn matrix[nItems][size];\n}",
                code_c_charp = "public List<Item> FindItemsToPack(List<Item> items, int capacity,out int totalValue)\n{\nint[,] price = new int[items.Count + 1, capacity + 1];\nbool[,] keep = new bool[items.Count + 1, capacity + 1];\nfor (int i = 1; i <= items.Count; i++)\n{\nItem currentItem = items[i - 1];\nfor (int space = 1; space <= capacity; space++)\n{\nif (space >= currentItem.Weight)\n{\nint remainingSpace = space - currentItem.Weight;\nint remainingSpaceValue = 0;\nif (remainingSpace > 0)\n{\nremainingSpaceValue = price[i - 1, remainingSpace];\n}\nint currentItemTotalValue = currentItem.Price + remainingSpaceValue;\nif (currentItemTotalValue > price[i - 1, space])\n {\n keep[i, space] = true;\n price[i, space] = currentItemTotalValue;\n }\n else\n {\nkeep[i, space] = false;\n price[i, space] = price[i - 1, space];\n }\n}\n}\n}\nList<Item> itemsToBePacked = new List<Item>();\nint remainSpace = capacity;\nint item = items.Count;\nwhile (item > 0)\n{\nbool toBePacked = keep[item, remainSpace];\nif (toBePacked)\n{\nitemsToBePacked.Add(items[item - 1]);\nremainSpace = remainSpace - items[item - 1].Weight;\n}\nitem--;\n}\ntotalValue = price[items.Count,capacity];\nreturn itemsToBePacked;\n}",
                code_java = "public class Knapsack {\npublic static void main(String[] args) {\nint N = Integer.parseInt(args[0]);   // number of items\nint W = Integer.parseInt(args[1]);   // maximum weight of knapsack\nint[] profit = new int[N+1];\nint[] weight = new int[N+1];\n// generate random instance, items 1..N\nfor (int n = 1; n <= N; n++) {\nprofit[n] = (int) (Math.random() * 1000);\nweight[n] = (int) (Math.random() * W);\n}\n// opt[n][w] = max profit of packing items 1..n with weight limit w\n// sol[n][w] = does opt solution to pack items 1..n with weight limit w include item n?\nint[][] opt = new int[N+1][W+1];\nboolean[][] sol = new boolean[N+1][W+1];\nfor (int n = 1; n <= N; n++) {\nfor (int w = 1; w <= W; w++) {\n// don't take item n\nint option1 = opt[n-1][w];\n// take item n\nint option2 = Integer.MIN_VALUE;\nif (weight[n] <= w) option2 = profit[n] + opt[n-1][w-weight[n]];\n// select better of two options\nopt[n][w] = Math.max(option1, option2);\nsol[n][w] = (option2 > option1);\n}\n}\n// determine which items to take\nboolean[] take = new boolean[N+1];\nfor (int n = N, w = W; n > 0; n--) {\nif (sol[n][w]) { take[n] = true;  w = w - weight[n]; }\nelse           { take[n] = false;     }\n}\n// print results\nSystem.out.println(\"item\" + \"	\" + \"profit\" + \"	\" + \"weight\" + \"	\" + \"take\");\nfor (int n = 1; n <= N; n++) {\nSystem.out.println(n + \"	\" + profit[n] + \"	\" + weight[n] + \"	\" + take[n]);\n}\n}\n} ",
                comp = " Complexity : O(2 ^ n)",
                link1 = "PLJHuErj-Tw",
                link2 = "EH6h7WA7sDw",


            });

            myList5.Add(new Dynamic_prog_ALGOs()
            {
                ID = 1,
                PName = "Longest Common Subsequence",

                /////////////// 
                PImage = "Assets/dynm_prog/Longest Common/face.png",
                desc = "The longest common subsequence (LCS) problem is the \nproblem of finding the longest subsequence\n common to all sequences in a set of sequences (often just two sequences).\n It differs from problems of finding common substrings:\n unlike substrings, subsequences are \nnot required to occupy consecutive positions within the original sequences.\n The longest common subsequence problem is a classic computer science \nproblem, the basis of data comparison programs such as \nthe diff utility, and has applications in bioinformatics",
                Images1 = "Assets/dynm_prog/Longest Common/1.png",
                Images2 = "Assets/dynm_prog/Longest Common/2.png",
                Images3 = "Assets/dynm_prog/Longest Common/3.png",
                Images4 = "Assets/dynm_prog/Longest Common/4.png",
                Images5 = "Assets/dynm_prog/Longest Common/5.png",
                Images6 = "Assets/dynm_prog/Longest Common/6.png",
                Images7 = "Assets/dynm_prog/Longest Common/7.png",
                pseudo_code1 = "Assets/dynm_prog/Longest Common/pseudo1.PNG",
                pseudo_code2 = "Assets/dynm_prog/Longest Common/pseudo2.PNG",
                analysis = "Assets/dynm_prog/Longest Common/analysis.PNG",
                /////////////////////////

                code_c_plus_plus = "void setAt(size_t i, size_t j, size_t value)\n{\ndata_[i + j * (m_ + 1)] = value;\n}\nsize_t getAt(size_t i, size_t j) const\n{\nreturn data_[i + j * (m_ + 1)];\n}\ntemplate<typename T> void\nbuild(const T* X, const T* Y)\n{\nfor (size_t i=0; i<=m_; ++i)\nsetAt(i, 0, 0);\nfor (size_t j=0; j<=n_; ++j)\nsetAt(0, j, 0);\nfor (size_t i = 0; i < m_; ++i)\n{\nfor (size_t j = 0; j < n_; ++j)\n{\nif (X[i] == Y[j])\nsetAt(i+1, j+1, getAt(i, j)+1);\nelse\nsetAt(i+1, j+1, std::max(getAt(i+1, j), getAt(i, j+1)));\n}\n}\n}" ,
                code_c_charp = "public static int GetLCS(string str1, string str2)\n{\nint[,] table;\nreturn GetLCSInternal(str1, str2, out table);\n}\nprivate static int GetLCSInternal(string str1, string str2, out int[,] matrix)\n{\nmatrix = null;\nif (string.IsNullOrEmpty(str1) || string.IsNullOrEmpty(str2))\n{\nreturn 0;\n}\nint[,] table = new int[str1.Length + 1, str2.Length + 1];\nfor (int i = 0; i < table.GetLength(0); i++)\n{\ntable[i, 0] = 0;\n}\nfor(int j= 0;j<table.GetLength(1); j++)\n{\ntable[0,j] = 0;\n}\nfor (int i = 1; i < table.GetLength(0); i++)\n{\nfor (int j = 1; j < table.GetLength(1); j++)\n{\nif (str1[i-1] == str2[j-1])\ntable[i, j] = table[i - 1, j - 1] + 1;\nelse\n{\nif (table[i, j - 1] > table[i - 1, j])\ntable[i, j] = table[i, j - 1];\nelse\ntable[i, j] = table[i - 1, j];\n}\n}\n}\nmatrix = table;\nreturn table[str1.Length, str2.Length];\n}" ,
                code_java = "public static <E> List<E> LongestCommonSubsequence(E[] s1, E[] s2)\n{\nint[][] num = new int[s1.length+1][s2.length+1];  //2D array, initialized to 0\n//Actual algorithm\nfor (int i = 1; i <= s1.length; i++)\nfor (int j = 1; j <= s2.length; j++)\nif (s1[i-1].equals(s2[j-1]))\nnum[i][j] = 1 + num[i-1][j-1];\nelse\nnum[i][j] = Math.max(num[i-1][j], num[i][j-1]);\nSystem.out.println(\"length of LCS = \" + num[s1.length][s2.length]);\nint s1position = s1.length, s2position = s2.length;\nList<E> result = new LinkedList<E>();\nwhile (s1position != 0 && s2position != 0)\n{\nif (s1[s1position - 1].equals(s2[s2position - 1]))\n{\nresult.add(s1[s1position - 1]);\ns1position--;\ns2position--;\n}\nelse if (num[s1position][s2position - 1] >= num[s1position][s2position])\n{\ns2position--;\n}\nelse\n{\ns1position--;\n}\n}\nCollections.reverse(result);\nreturn result;\n}" ,
                comp = " Complexity : O((n+r)log(n))",   // check this
                link1 = "aSwu8Z9nzOg",
                link2 = "V5hZoJ6uK-s&spfreload=10",

            });

            myList5.Add(new Dynamic_prog_ALGOs()
            {
                ID = 2,
                PName = "Longest Increasing Subsequence",

                /////////////// 
                PImage = "Assets/dynm_prog/Longest Increasing/face.png",
                desc = "In computer science, the \nlongest increasing subsequence \nproblem is to find a subsequence of a given sequence in which the \nsubsequence's elements are in sorted order, lowest to highest,\n and in which the subsequence is as long as possible. ",
                Images1 = "Assets/dynm_prog/Longest Increasing/1.png",
                Images2 = "Assets/dynm_prog/Longest Increasing/2.png",
                Images3 = "Assets/dynm_prog/Longest Increasing/3.png",
                Images4 = "Assets/dynm_prog/Longest Increasing/4.png",
                Images5 = "Assets/dynm_prog/Longest Increasing/5.png",
                Images6 = "Assets/dynm_prog/Longest Increasing/6.png",
                Images7 = "Assets/dynm_prog/Longest Increasing/7.png",
                pseudo_code1 = "Assets/dynm_prog/Longest Increasing/pseudo1.PNG",
                pseudo_code2 = "Assets/dynm_prog/Longest Increasing/pseudo2.PNG",
                analysis = "Assets/dynm_prog/Longest Increasing/analysis.PNG",
                /////////////////////////
                code_c_plus_plus = "int lis( int arr[], int n )\n{\nint *lis, i, j, max = 0;\nlis = (int*) malloc ( sizeof( int ) * n );\n/* Initialize LIS values for all indexes */\nfor ( i = 0; i < n; i++ )\nlis[i] = 1;\n/* Compute optimized LIS values in bottom up manner */\nfor ( i = 1; i < n; i++ )\nfor ( j = 0; j < i; j++ )\nif ( arr[i] > arr[j] && lis[i] < lis[j] + 1)\nlis[i] = lis[j] + 1;\n/* Pick maximum of all LIS values */\nfor ( i = 0; i < n; i++ )\nif ( max < lis[i] )\nmax = lis[i];\n/* Free memory to avoid memory leak */\nfree( lis );\nreturn max;\n}" ,
                code_c_charp = "using System;\nusing System.Collections.Generic;\nusing System.Linq;\nusing System.Text;\nnamespace Algorithms\n{\nclass LongestIncreasingSequence\n{\npublic List<int> Calculate(List<int> deck)\n{\nList<int> longestIncreasingSequence = new List<int>();\nList<Stack<LinkedNode<int>>> piles = new List<Stack<LinkedNode<int>>>();\nfor (int i = 0; i < deck.Count; i++)\n{\nint addToPileNumber = DeterminePileToAddNumberTo(deck[i], piles);\nLinkedNode<int> data = new LinkedNode<int>(deck[i]);\nif (addToPileNumber == -1) //No suitable pile found. Create a new one\n{\nStack<LinkedNode<int>> newStack = new Stack<LinkedNode<int>>();\npiles.Add(newStack);\nnewStack.Push(data);\nif (piles.Count > 1)\n{\ndata.Next = piles[piles.Count - 2].Peek();\n}\n}\nelse\n{\nif (addToPileNumber > 0)\n{\ndata.Next=piles[addToPileNumber - 1].Peek();\n}\npiles[addToPileNumber].Push(data);\n}\n}\nSystem.Diagnostics.Debug.WriteLine(\"Total number of piles created were {0}. Therefore the sequence size should be {0}\", piles.Count);\nreturn GetSequenceFromLinkedNodes(piles[piles.Count-1].Peek());\n}\nprivate List<int> GetSequenceFromLinkedNodes(LinkedNode<int> LinkedNode)\n{\nStack<int> largestSequenceStack = new Stack<int>();\nlargestSequenceStack.Push(LinkedNode.Data);\nwhile (LinkedNode.Next != null)\n{\nLinkedNode = LinkedNode.Next;\nlargestSequenceStack.Push(LinkedNode.Data);\n}\nreturn largestSequenceStack.ToList();\n}\nprivate int DeterminePileToAddNumberTo(int number, List<Stack<LinkedNode<int>>> piles)\n{\nreturn piles.FindIndex(p => p.Peek().Data > number);\n}\n}\nclass LinkedNode<T>\n{\npublic LinkedNode()\n{ }\npublic LinkedNode(T data)\n{\nthis.Data = data;\n}\npublic T Data { get; set; }\npublic LinkedNode<T> Next { get; set; }\n}\n}" , 
                code_java = "public static int lis_nlgn(int[] a) {\nint[] dp = new int[a.length];\nint max = -1;\nfor(int x : a) {\nint pos = Arrays.binarySearch(dp, 0, max + 1, x);\nif(pos < 0) {\npos = -pos - 1;\ndp[pos] = x;\nif(pos == max + 1)\nmax++;\n}\n}\nreturn max + 1;\n}" ,
                comp = " Complexity : O(n^2)",   // check this
                link1 = "aSwu8Z9nzOg",
                link2 = "V5hZoJ6uK-s&spfreload=10",

            });

        }
    }
}

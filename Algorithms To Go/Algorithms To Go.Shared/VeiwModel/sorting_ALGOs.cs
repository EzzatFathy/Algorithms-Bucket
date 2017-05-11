using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms_To_Go.VeiwModel
{
    public class sorting_ALGOs
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


    public class Data2
    {
        public List<sorting_ALGOs> myList2
        {
            get
            {
                return privateList;
            }
        }

        private List<sorting_ALGOs> privateList = new List<sorting_ALGOs>();


        public void Data_in()
        {
            myList2.Add(new sorting_ALGOs()
            {
                ID = 0,
                PName = "Heap Sort",
                PImage = "Assets/sortings/heap/face.png",
                desc = "Combines the better attributes of merge sort and insertion sort.\nLike merge sort, but unlike insertion sort, running time is O(n lg n).\nLike insertion sort, but unlike merge sort, sorts in place.\nIntroduces an algorithm design technique \nCreate data structure (heap) to manage information during the execution of an algorithm.\nArray viewed as a nearly complete binary tree.\nPhysically – linear array.\nLogically – binary tree, filled on all levels (except lowest.)",
                link1 = "hfFxxC30jKc&list=PLrW6ND2wzt4qVfoiiblU95KOWuEnI3xDV&index=6",
                link2 = "WfbCZ7RTSyM&list=PLrW6ND2wzt4qVfoiiblU95KOWuEnI3xDV&index=7",
                Images1 = "Assets/sortings/heap/1.png",
                Images2 = "Assets/sortings/heap/2.png",
                Images3 = "Assets/sortings/heap/3.png",
                Images4 = "Assets/sortings/heap/4.png",
                Images5 = "Assets/sortings/heap/5.png",
                Images6 = "Assets/sortings/heap/6.png",
                Images7 = "Assets/sortings/heap/7.png",
                pseudo_code1 = "Assets/sortings/heap/pseudo.jpg",
                pseudo_code2 = "Assets/sortings/heap/pseudo max heap.PNG",
                analysis = "Assets/sortings/heap/analysis.PNG",
                code_c_plus_plus = "#include <iostream>\nusing namespace std;\nvoid MAX_HEAPIFY(int a[], int i, int n)\n{\nint l,r,largest,loc;\nl=2*i;\nr=(2*i+1);\nif((l<=n)&&a[l]>a[i])\nlargest=l;\nelse\nlargest=i;\nif((r<=n)&&(a[r]>a[largest]))\nlargest=r;\nif(largest!=i)\n{\nloc=a[i];\na[i]=a[largest];\na[largest]=loc;\nMAX_HEAPIFY(a, largest,n);\n}\n}\nvoid BUILD_MAX_HEAP(int a[], int n)\n{\nfor(int k = n/2; k >= 1; k--)\n{\nMAX_HEAPIFY(a, k, n);\n}\n}\nvoid HEAPSORT(int a[], int n)\n{\nBUILD_MAX_HEAP(a,n);\nint i, temp;\nfor (i = n; i >= 2; i--)\n{\ntemp = a[i];\na[i] = a[1];\na[1] = temp;\nMAX_HEAPIFY(a, 1, i - 1);\n}\n}\nint main()\n{\nint n;\ncout<<\"Enter the size of the array\"<<endl;\ncin>>n;\nint a[n];\ncout<<\"Enter the elements in the array\"<<endl;\nfor (int i = 1; i <= n; i++)\n{\ncin>>a[i];\n}\nHEAPSORT(a, n);\ncout<<\":::::::SORTED FORM::::::\"<<endl;\nfor (int i = 1; i <= n; i++){\ncout<<a[i]<<endl;\n}\n}",
                code_c_charp = "public static void HeapSort(int[] input)\n{\nint heapSize = input.Length;\nfor (int p = (heapSize - 1) / 2; p >= 0; p--)\nMaxHeapify(input, heapSize, p);\nfor (int i = input.Length - 1; i > 0; i--)\n{\nint temp = input[i];\ninput[i] = input[0];\ninput[0] = temp;\nheapSize--;\nMaxHeapify(input, heapSize, 0);\n}\n}\nprivate static void MaxHeapify(int[] input, int heapSize, int index)\n{\nint left = (index + 1) * 2 - 1;\nint right = (index + 1) * 2;\nint largest = 0;\nif (left < heapSize && input[left] > input[index])\nlargest = left;\nelse\nlargest = index;\nif (right < heapSize && input[right] > input[largest])\nlargest = right;\nif (largest != index)\n{\nint temp = input[index];\ninput[index] = input[largest];\ninput[largest] = temp;\nMaxHeapify(input, heapSize, largest);\n}\n}" ,
                code_java = "import java.util.Scanner;\npublic class HeapSort \n{ \n   private static int N;\npublic static void sort(int arr[])\n{\nheapify(arr);\nfor (int i = N; i > 0; i--)\n{\nswap(arr,0, i);\nN = N-1;\nmaxheap(arr, 0);\n}\n}\n     public static void heapify(int arr[])\n{\nN = arr.length-1;\nfor (int i = N/2; i >= 0; i--)\nmaxheap(arr, i);\n        }\npublic static void maxheap(int arr[], int i)\n{\n int left = 2*i ;\nint right = 2*i + 1;\nint max = i;\nif (left <= N && arr[left] > arr[i])\nmax = left;\nif (right <= N && arr[right] > arr[max])\n        max = right;\nif (max != i)\n{\nswap(arr, i, max);\nmaxheap(arr, max);\n}\n}\n    public static void swap(int arr[], int i, int j)\n{\nint tmp = arr[i];\narr[i] = arr[j];\narr[j] = tmp;\n }\n    public static void main(String[] args)\n {\nScanner scan = new Scanner( System.in );\n        System.out.println(\"Heap Sort Test\n\");\nint n, i;\n    System.out.println(\"Enter number of integer elements\");\nn = scan.nextInt();\n    int arr[] = new int[ n ];\nSystem.out.println(\"\nEnter \"+ n +\" integer elements\");\nfor (i = 0; i < n; i++)\narr[i] = scan.nextInt();\nsort(arr);\nSystem.out.println(\"\nElements after sorting \");\n        for (i = 0; i < n; i++)\nSystem.out.print(arr[i]+\" \");\nSystem.out.println();\n            }\n}",
                comp = " Complexity : O(n lg n)",
            });

            myList2.Add(new sorting_ALGOs()
            {
                ID = 1,
                PName = "Bubble Sort",
                // need data
                PImage = "Assets/sortings/bubble/face.png",
                desc = "Combines the better attributes of merge sort and insertion sort.\nLike merge sort, but unlike insertion sort, running time is O(n lg n).\nLike insertion sort, but unlike merge sort, sorts in place.\nIntroduces an algorithm design technique \nCreate data structure (heap) to manage information during the execution of an algorithm.\nArray viewed as a nearly complete binary tree.\nPhysically – linear array.\nLogically – binary tree, filled on all levels (except lowest.)",
                Images1 = "Assets/sortings/bubble/1.png",
                Images2 = "Assets/sortings/bubble/2.png",
                Images3 = "Assets/sortings/bubble/3.png",
                Images4 = "Assets/sortings/bubble/4.png",
                Images5 = "Assets/sortings/bubble/5.png",
                Images6 = "Assets/sortings/bubble/6.png",
                Images7 = "Assets/sortings/bubble/7.png",
                pseudo_code1 = "Assets/sortings/bubble/pseudo1.PNG",
                pseudo_code2 = "Assets/sortings/bubble/pseudo2.PNG",
                analysis = "Assets/sortings/bubble/analysis.PNG",
                //////////////////////////////
                link1 = "8XjK6fagJeA&index=2&list=PLrW6ND2wzt4qVfoiiblU95KOWuEnI3xDV",
                link2 = "Jdtq5uKz-w4", 
                code_c_charp = "using System;\nusing System.Collections.Generic;\nusing System.Text;\nnamespace ConsoleApplication1\n{\nclass Program\n{\nstatic int BubbleSort()\n{\nConsole.Write(\"\nProgram for Ascending order of Numeric Values using BUBBLE SORT\");\nConsole.Write(\"\n\nEnter the total number of elements: \");\nint max = Convert.ToInt32(Console.ReadLine());\nint [] numarray = new int[max];\nfor(int i = 0; i < max; i++)\n{\nConsole.Write(\"\nEnter [\" + (i + 1).ToString() + \"] element: \");\nnumarray[i] = Convert.ToInt32(Console.ReadLine());\n}\nConsole.Write(\"Before Sorting   : \");\nfor(int k = 0; k < max; k++)\nConsole.Write(numarray[k] + \" \");\nConsole.Write(\"\n\");\nfor(int i = 1; i < max; i++)\n{\nfor(int j = 0; j < max - i; j++)\n{\nif(numarray[j] > numarray[j + 1])\n{\nint temp = numarray[j];\nnumarray[j] = numarray[j + 1];\nnumarray[j + 1] = temp;\n}\n}\nConsole.Write(\"After iteration \" + i.ToString() + \": \");\nfor(int k = 0; k < max; k++)\nConsole.Write(numarray[k] +  \" \");\nConsole.Write(\"/*** \" + (i + 1).ToString() + \" biggest number(s) is(are) pushed to the end of the array ***/\n\");\n}\nConsole.Write(\"\n\nThe numbers in ascending orders are given below:\n\n\");\nfor(int i = 0; i < max; i++)\n{\nConsole.Write(\"Sorted [\" + (i + 1).ToString() + \"] element: \");\nConsole.Write(numarray[i]);\nConsole.Write(\"\n\");\n}\nreturn 0;\n} \n static void Main(string[] args)\n{\nBubbleSort();\n}\n}\n}\n " , 
                code_c_plus_plus = "#include<iostream>\nusing namespace std;\nint main(){\n//declaring array\nint array[5];\ncout<<\"Enter 5 numbers randomly : \"<<endl;\nfor(int i=0; i<5; i++)\n{\n//Taking input in array\n  cin>>array[i];\n        }\n  cout<<endl;\n cout<<\"Input array is: \"<<endl;\nfor(int j=0; j<5; j++)\n{\n//Displaying Array\n cout<<\"\t\t\tValue at \"<<j<<\" Index: \"<<array[j]<<endl;\n         }\n   cout<<endl;\n// Bubble Sort Starts Here\nint temp;\nfor(int i2=0; i2<=4; i2++)\n{\nfor(int j=0; j<4; j++)\n{\nif(array[j]>array[j+1])\n{\ntemp=array[j];\narray[j]=array[j+1];\narray[j+1]=temp;\n        }\n}\n         }\n // Displaying Sorted array\ncout<<\"  Sorted Array is: \"<<endl;\nfor(int i3=0; i3<5; i3++)\n{\ncout<<\"\t\t\tValue at \"<<i3<<\" Index: \"<<array[i3]<<endl;\n  }\n   return 0;\n}\n" , 
                code_java = "import java.util.Scanner;\nclass BubbleSort {\npublic static void main(String []args) {\nint n, c, d, swap;\nScanner in = new Scanner(System.in);\nSystem.out.println(\"Input number of integers to sort\");\nn = in.nextInt();\nint array[] = new int[n];\nSystem.out.println(\"Enter \" + n + \" integers\");\nfor (c = 0; c < n; c++)\n array[c] = in.nextInt();\nfor (c = 0; c < ( n - 1 ); c++) {\nfor (d = 0; d < n - c - 1; d++) {\nif (array[d] > array[d+1]) /* For descending order use < */\n{\nswap       = array[d];\narray[d]   = array[d+1];\narray[d+1] = swap;\n}\n}\n}\nSystem.out.println(\"Sorted list of numbers\");\nfor (c = 0; c < n; c++)\n System.out.println(array[c]);\n}\n}\n" ,
                comp = " Complexity : O(n log n)",  
            });

            myList2.Add(new sorting_ALGOs()
            {
                ID = 2,
                PName = "Insertion Sort",
                // need data
                PImage = "Assets/sortings/insertion/face.png",
                desc = "Combines the better attributes of merge sort and insertion sort.\nLike merge sort, but unlike insertion sort, running time is O(n lg n).\nLike insertion sort, but unlike merge sort, sorts in place.\nIntroduces an algorithm design technique \nCreate data structure (heap) to manage information during the execution of an algorithm.\nArray viewed as a nearly complete binary tree.\nPhysically – linear array.\nLogically – binary tree, filled on all levels (except lowest.)",
                Images1 = "Assets/sortings/insertion/1.png",
                Images2 = "Assets/sortings/insertion/2.png",
                Images3 = "Assets/sortings/insertion/3.png",
                Images4 = "Assets/sortings/insertion/4.png",
                Images5 = "Assets/sortings/insertion/5.png",
                Images6 = "Assets/sortings/insertion/6.png",
                Images7 = "Assets/sortings/insertion/7.png",
                pseudo_code1 = "Assets/sortings/insertion/pseudo1.PNG",
                pseudo_code2 = "Assets/sortings/insertion/pseudo2.PNG",
                analysis = "Assets/sortings/insertion/analysis.PNG",
                //////////////////////////////
                link1 = "fJMDs0by5xI&index=3&list=PLrW6ND2wzt4qVfoiiblU95KOWuEnI3xDV",
                link2 = "SKeOcBwko", 
                code_java = "package com.vaibhav.test;\nimport java.util.Arrays;\npublic class InsertionSort {\npublic static void main(String[] args) {\nint A[] = new int[10];\npopulateArray(A);\nSystem.out.println(\"Before Sorting: \");\nprintArray(A);\n// sort the array\ninsertionSort(A);\nSystem.out.println(\"\nAfter Sorting: \");\nprintArray(A);\n}\n/**\n* This method will sort the integer array using insertion sort algorithm\n* \n* @param arr\n*/\nprivate static void insertionSort(int[] arr) {\nfor (int i = 1; i < arr.length; i++) {\nint valueToSort = arr[i];\nint j = i;\nwhile (j > 0 && arr[j - 1] > valueToSort) {\narr[j] = arr[j - 1];\nj--;\n}\narr[j] = valueToSort;\n}\n}\npublic static void printArray(int[] B) {\nSystem.out.println(Arrays.toString(B));\n}\npublic static void populateArray(int[] B) {\nfor (int i = 0; i < B.length; i++) {\nB[i] = (int) (Math.random() * 100);\n}\n}\n}" , 
                code_c_plus_plus = "#include <cstdlib>\n#include <iostream>\nusing namespace std;\n//member function\nvoid insertion_sort(int arr[], int length);\nvoid print_array(int array[],int size);\nint main() {\nint array[5]= {5,4,3,2,1};\ninsertion_sort(array,5);\nreturn 0;\n}//end of main\nvoid insertion_sort(int arr[], int length) {\nint i, j ,tmp;\nfor (i = 1; i < length; i++) {\nj = i;\nwhile (j > 0 && arr[j - 1] > arr[j]) {\ntmp = arr[j];\narr[j] = arr[j - 1];\narr[j - 1] = tmp;\nj--;\n}//end of while loop\nprint_array(arr,5);\n}//end of for loop\n}//end of insertion_sort.\nvoid print_array(int array[], int size){\ncout<< \"sorting: \";\nint j;\nfor (j=0; j<size;j++)\nfor (j=0; j<size;j++)\ncout <<\" \"<< array[j];\ncout << endl;\n }//end of print_array" , 
                code_c_charp = "using System;\nusing System.Collections.Generic;\nusing System.Text;\nnamespace ConsoleApplication1\n{\nclass Program\n{\nstatic int InsertionSort()\n{\nConsole.Write(\"\nProgram for Ascending order of Numeric Values using INSERTION SORT\");\nConsole.Write(\"\n\nEnter the total number of elements: \");\nint max = Convert.ToInt32(Console.ReadLine());\nint [] numarray = new int[max];\nfor(int i = 0; i < max; i++)\n{\nConsole.Write(\"\nEnter [\" + (i + 1).ToString() + \"] element: \");\nnumarray[i] = Convert.ToInt32(Console.ReadLine());\n}\nConsole.Write(\"Before Sorting   : \");\nfor(int k = 0; k < max; k++)\nConsole.Write(numarray[k] + \" \");\nConsole.Write(\"\\n\");  \nfor(int i = 1; i < max; i++)\n{\nint j = i;\nwhile(j > 0)\n{\nif(numarray[j-1] > numarray[j])\n{\nint temp = numarray[j - 1];\nnumarray[j - 1] = numarray[j];\nnumarray[j] = temp;\nj--;\n}\nelse\nbreak;\n}\nConsole.Write(\"After iteration \" + i.ToString() + \": \");\nfor(int k = 0; k < max; k++)\nConsole.Write(numarray[k] + \" \");\nConsole.Write(\"/*** \" + (i + 1).ToString() + \" numbers from the begining of the array are input and they are sorted ***/\n\");\n}\nConsole.Write(\"\\n\nThe numbers in ascending orders are given below:\\n\\n\");\nfor(int i = 0; i < max; i++)\n{\nConsole.Write(\"Sorted [\" + (i + 1).ToString() + \"] element: \");\nConsole.Write(numarray[i]);\nConsole.Write(\"\\n\");\n}\nreturn 0;\n}\nstatic void Main(string[] args)\n{\nInsertionSort();\n}\n}\n}" ,
                comp = " Complexity : O(n^2)",  
            });

            myList2.Add(new sorting_ALGOs()
            {
                ID = 3,
                PName = "Merge Sort",
                // need data
                PImage = "Assets/sortings/merge/face.png",
                desc = "Combines the better attributes of merge sort and insertion sort.\nLike merge sort, but unlike insertion sort, running time is O(n lg n).\nLike insertion sort, but unlike merge sort, sorts in place.\nIntroduces an algorithm design technique \nCreate data structure (heap) to manage information during the execution of an algorithm.\nArray viewed as a nearly complete binary tree.\nPhysically – linear array.\nLogically – binary tree, filled on all levels (except lowest.)",
                Images1 = "Assets/sortings/merge/1.png",
                Images2 = "Assets/sortings/merge/2.png",
                Images3 = "Assets/sortings/merge/3.png",
                Images4 = "Assets/sortings/merge/4.png",
                Images5 = "Assets/sortings/merge/5.png",
                Images6 = "Assets/sortings/merge/6.png",
                Images7 = "Assets/sortings/merge/7.png",
                pseudo_code1 = "Assets/sortings/merge/pseudo1.PNG",
                pseudo_code2 = "Assets/sortings/merge/pseudo2.PNG",
                analysis = "Assets/sortings/heap/analysis.PNG",
                //////////////////////////////
                link1 = "Pow9VYIWfOg&list=PLrW6ND2wzt4qVfoiiblU95KOWuEnI3xDV&index=4",
                link2 = "TzeBrDU-JaY", 
                code_c_charp = "using System;\nusing System.Collections.Generic;\nusing System.Text;\nnamespace CSharpSort\n{\nclass Program\n{\nstatic public void DoMerge(int [] numbers, int left, int mid, int right)\n{\nint [] temp = new int[25];\nint i, left_end, num_elements, tmp_pos;\nleft_end = (mid - 1);\ntmp_pos = left;\nnum_elements = (right - left + 1);\nwhile ((left <= left_end) && (mid <= right))\n{\nif (numbers[left] <= numbers[mid])\ntemp[tmp_pos++] = numbers[left++];\nelse\ntemp[tmp_pos++] = numbers[mid++];\n}\nwhile (left <= left_end)\ntemp[tmp_pos++] = numbers[left++];\nwhile (mid <= right)\ntemp[tmp_pos++] = numbers[mid++];\nfor (i = 0; i < num_elements; i++)\n{\nnumbers[right] = temp[right];\nright--;\n}\n}\nstatic public void MergeSort_Recursive(int [] numbers, int left, int right)\n{\nint mid;\nif (right > left)\n{\nmid = (right + left) / 2;\nMergeSort_Recursive(numbers, left, mid);\nMergeSort_Recursive(numbers, (mid + 1), right);\nDoMerge(numbers, left, (mid+1), right);\n}\n}\nstatic void Main(string[] args)\n{\nint[] numbers = { 3, 8, 7, 5, 2, 1, 9, 6, 4 };\nint len = 9;\nConsole.WriteLine(\"MergeSort By Recursive Method\");\nMergeSort_Recursive(numbers, 0, len - 1);\nfor (int i = 0; i < 9; i++)\nConsole.WriteLine(numbers[i]);\nConsole.WriteLine(numbers[i]);\n}\n}\n}" ,
                code_c_plus_plus = "#include <iostream>\nusing namespace std;\n#include <conio.h>\nvoid merge(int *,int, int , int );\nvoid mergesort(int *a, int low, int high)\n{\nint mid;\nif (low < high)\n{\nmid=(low+high)/2;\nmergesort(a,low,mid);\nmergesort(a,mid+1,high);\nmerge(a,low,high,mid);\n}\nreturn;\n}\nvoid merge(int *a, int low, int high, int mid)\n{\nint i, j, k, c[50];\ni = low;\nk = low;\nj = mid + 1;\nwhile (i <= mid && j <= high)\n{\nif (a[i] < a[j])\n{\nc[k] = a[i];\nk++;\ni++;\n}\nelse\n{\nc[k] = a[j];\nk++;\nj++;\n}\n}\nwhile (i <= mid)\n{\nc[k] = a[i];\nk++;\ni++;\n}\nwhile (j <= high)\n{\nc[k] = a[j];\nk++;\nj++;\n}\nfor (i = low; i < k; i++)\n{\na[i] = c[i];\n}\n}\nint main()\n{\nint a[20], i, b[20];\ncout<<\"enter  the elements\\n\";\nfor (i = 0; i < 5; i++)\n{\ncin>>a[i];\n}\nmergesort(a, 0, 4);\ncout<<\"sorted array\\n\";\nfor (i = 0; i < 5; i++)\n{\ncout<<a[i];\n}\ncout<<\"enter  the elements\\n\";\nfor (i = 0; i < 5; i++)\n{\ncin>>b[i];\n}\nmergesort(b, 0, 4);\ncout<<\"sorted array\\n\";\nfor (i = 0; i < 5; i++)\n{\ncout<<b[i];\n}\ngetch();" , 
                code_java = "package com.java2novice.sorting;\npublic class MyMergeSort {\nprivate int[] array;\nprivate int[] tempMergArr;\nprivate int length;\npublic static void main(String a[]){\nint[] inputArr = {45,23,11,89,77,98,4,28,65,43};\nMyMergeSort mms = new MyMergeSort();\nmms.sort(inputArr);\nfor(int i:inputArr){\nSystem.out.print(i);\nSystem.out.print(\" \");\n}\n}\npublic void sort(int inputArr[]) {\nthis.array = inputArr;\nthis.length = inputArr.length;\nthis.tempMergArr = new int[length];\ndoMergeSort(0, length - 1);\n}\nprivate void doMergeSort(int lowerIndex, int higherIndex) {\nif (lowerIndex < higherIndex) {\nint middle = lowerIndex + (higherIndex - lowerIndex) / 2;\n// Below step sorts the left side of the array\ndoMergeSort(lowerIndex, middle);\n// Below step sorts the right side of the array\ndoMergeSort(middle + 1, higherIndex);\n// Now merge both sides\nmergeParts(lowerIndex, middle, higherIndex);\n}\n}\nprivate void mergeParts(int lowerIndex, int middle, int higherIndex) {\nfor (int i = lowerIndex; i <= higherIndex; i++) {\ntempMergArr[i] = array[i];\n}\nint i = lowerIndex;\nint j = middle + 1;\nint k = lowerIndex;\nwhile (i <= middle && j <= higherIndex) {\nif (tempMergArr[i] <= tempMergArr[j]) {\narray[k] = tempMergArr[i];\ni++;\n} else {\narray[k] = tempMergArr[j];\nj++;\n}\nk++;\n}\nwhile (i <= middle) {\narray[k] = tempMergArr[i];\nk++;\ni++;\n}\n}\n}" ,
                comp = " Complexity : O(n log(n))",   
            });
        }
    }
}

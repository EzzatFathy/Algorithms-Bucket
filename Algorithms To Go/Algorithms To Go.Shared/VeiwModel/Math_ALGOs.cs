using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms_To_Go.VeiwModel
{
    public class Math_ALGOs
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


    public class Data3
    {
        public List<Math_ALGOs> myList3
        {
            get
            {
                return privateList;
            }
        }

        private List<Math_ALGOs> privateList = new List<Math_ALGOs>();


        public void Data_in()
        {

            myList3.Add(new Math_ALGOs()
            {
                ID = 0,
                PName = "Sieve of Eratosthenes",
                /// need data
                PImage = "Assets/math/Sieve/face - Copy.png",
                desc = "Sieve of Eratosthenes is used to find prime numbers up to some predefined integer n.\n For sure, we can just test all the numbers in \nrange from 2 to n for primality using some approach, but it is quite inefficient.\n Sieve of Eratosthenes is a simple algorithm to find prime numbers.\n Though, there are better algorithms exist today,\n sieve of Eratosthenes is a great example of the sieve approach.\nAlgorithmFirst of all algorithm requires a bit array \nisComposite to store n - 1 numbers: isComposite[2 .. n]. Initially the \narray contains zeros in all cells. During algorithm's work, numbers, which \ncan be represented as k * p, where k >= 2, p is prime, are marked as \ncomposite numbers by writing 1 in a corresponding cell. \nAlgorithm consists of two nested loops: outer, seeking for \nunmarked numbers (primes), and inner, marking primes' multiples as composites.\nFor all numbers m: 2 .. n, if m is unmarked:\nadd m to primes list;\nmark all it's multiples, lesser or equal, than n (k * m <= n, k >= 2);\notherwise, if m is marked, then it is a composite number." ,
                Images1 = "Assets/math/Sieve/1.png",
                Images2 = "Assets/math/Sieve/2.png",
                Images3 = "Assets/math/Sieve/3.png",
                Images4 = "Assets/math/Sieve/4.png",
                Images5 = "Assets/math/Sieve/5.png",
                Images6 = "Assets/math/Sieve/6.png",
                Images7 = "Assets/math/Sieve/7.png",
                pseudo_code1 = "Assets/math/Sieve/pseudo.PNG",
                pseudo_code2 = "Assets/math/Sieve/pseudo max heap.PNG",
                analysis = "Assets/math/Sieve/analysis.PNG",
                /////////////////////////////////////////////////////
                link1 = "V08g_lkKj6Q",
                link2 = "eKp56OLhoQs",
                code_c_plus_plus = "#include <iostream>\n#include <bitset>\n#define SIZE 10000000\n#define MAX (int)(SIZE-3)/2\nusing namespace std;\nint primes[MAX + 1];\nbitset<MAX + 1> bset;\nvoid setPrimes()\n{\nfor(int i = 0; i * i <= SIZE; i++)\nif(!bset.test(i))\nfor(int j = i + 1;(2 * j + 1) * ( 2 * i + 3) <= SIZE;j++)\nbset.set(((2 * j + 1) * (2 * i + 3) - 3)/2);\nprimes[0]=2;\nfor(int i = 1, j = 0; j < MAX + 1; j++)\nif(!bset.test(j))\nprimes[i++] = 2 * j + 3;  \n}" ,
                code_c_charp = "bool[] notPrime = new bool[total];\nnotPrime[0] = true;\nnotPrime[1] = true;\nfor (int i = 2; i <= Math.Sqrt(notPrime.Length); i++) {\nif (!notPrime[i]) {\nfor (int j = i * 2; j < notPrime.Length; j += i) {\nnotPrime[j] = true;\n}\n}\n}\n// Using Linq C#\nint cur = 1, total = 1000;\nvar pc = Enumerable.Range(2, total).ToList();\nwhile(cur <= Math.Sqrt(total))\n{\ncur = pc.First(i => i > cur);\npc.RemoveAll(i => i != cur && i % cur == 0);\n}",
                code_java = "public class PrimeSieve {\npublic static void main(String[] args) { \nint N = Integer.parseInt(args[0]);\n// initially assume all integers are prime\nboolean[] isPrime = new boolean[N + 1];\nfor (int i = 2; i <= N; i++) {\nisPrime[i] = true;\n}\n// mark non-primes <= N using Sieve of Eratosthenes\nfor (int i = 2; i*i <= N; i++) {\n// if i is prime, then mark multiples of i as nonprime\n// suffices to consider mutiples i, i+1, ..., N/i\nif (isPrime[i]) {\nfor (int j = i; i*j <= N; j++) {\nisPrime[i*j] = false;\n}\n}\n}\n// count primes\nint primes = 0;\nfor (int i = 2; i <= N; i++) {\nif (isPrime[i]) primes++;\n}\nSystem.out.println(\"The number of primes <= \" + N + \" is \" + primes);\n}\n}",
                comp = " Complexity : O((n lg n) (lg lg n))", 
            });

            myList3.Add(new Math_ALGOs()
            {
                ID = 1,
                PName = "Pascal Traingle",
                /// need data
                PImage = "Assets/math/Pascal/face.png",
                desc= "Pascal's Triangle: One of the most interesting Number Patterns is Pascal's Triangle (named after Blaise Pascal, a famous French Mathematician and Philosopher).\nTo build the triangle, start with \"1\" at the top, then continue placing numbers below it in a triangular pattern.\nEach number is just the two numbers above it added together (except for the edges, which are all \"1\").\nPatterns Within the Triangle:\nDiagonals:\n- The first diagonal is, of course, just \"1\"s, and the next diagonal has the Counting Numbers (1,2,3, etc).\n- The third diagonal has the triangular numbers\n- (The fourth diagonal, not highlighted, has the tetrahedral numbers.)\nHorizontal Sums:\n- What do you notice about the horizontal sums?\n- Is there a pattern? Isn't it amazing! It doubles each time (powers of 2)." ,
                Images1 = "Assets/math/Pascal/1.png",
                Images2 = "Assets/math/Pascal/2.png",
                Images3 = "Assets/math/Pascal/3.png",
                Images4 = "Assets/math/Pascal/4.png",
                Images5 = "Assets/math/Pascal/5.png",
                Images6 = "Assets/math/Pascal/6.png",
                Images7 = "Assets/math/Pascal/7.png",
                pseudo_code1 = "Assets/math/Pascal/pseudo.PNG",
                pseudo_code2 = "Assets/math/Pascal/pseudo max heap.PNG",
                analysis = "Assets/math/Pascal/analysis.PNG",
                /////////////////////////////////////////////////////
                link1 = "bMB8qDYa8N0",
                link2 = "_44TYnloDc0",
                code_c_plus_plus = "#include <iostream>\nint main()\n{\nint n, x, y, c, q;\ncout << \"Enter Number of Rows:\";\ncin >> n;\nfor (y = 0; y < n; y++) {\nc = 1;\nfor(q = 0; q < n - y; q++) {\nprintf(\"%3s\", \" \");\n}\nfor (x = 0; x <= y; x++) {\nprintf(\"   %3d \",c);\nc = c * (y - x) / (x + 1);\n}\ncout << endl;\n}\ncout << endl;\nreturn 0;\n}" ,
                code_c_charp = "using System;\nusing System.Collections.Generic;\nusing System.Text;\nnamespace PascalTriangle\n{\nclass PascalTriangle\n{\nstatic void Main(string[] args)\n{\nSystem.Console.WriteLine(\"Pascal Triangle Program\");\nSystem.Console.Write(\"Enter the number of rows: \");\nstring input = System.Console.ReadLine();\nint n = Convert.ToInt32(input);\nfor (int y = 0; y < n; y++)\n{\nint c = 1;\nfor (int q = 0; q < n - y; q++)\n{\nSystem.Console.Write(\"   \");\n}\nfor (int x = 0; x <= y; x++)\n{\nSystem.Console.Write(\"   {0:D} \", c);\nc = c * (y - x) / (x + 1);\n}\nSystem.Console.WriteLine();\nSystem.Console.WriteLine();\n}\nSystem.Console.WriteLine();\n}\n}\n}" , 
                code_java = "public static long[][] pascal(final int n) {\nlong[][] a = new long[n][];\nfor(int i = 0; i < n; i++)\na[i] = new long[i + 2];\na[0][0] = 1;\nfor(int i = 1; i < a.length; i++) {\na[i][0] = 1;\nfor(int j = 1; j < a[i].length - 1; j++) {\na[i][j] = a[i - 1][j] + a[i - 1][j - 1];\n}\n}\nreturn a;\n}" ,
                comp = " Complexity : O(n ^ 2)",
            });

            myList3.Add(new Math_ALGOs()
            {
                ID = 2,
                PName = "Prime Factorization",
                /// need data
                PImage = "Assets/math/Prime/face.png",
                desc= "Prime Numbers:\nA Prime Number can be divided evenly only by 1 or itself. And it must be a whole number greater than 1.\nFactors:\n\"Factors\" are the numbers you multiply together to get another number:\n\n\t2 * 3 = 6 [2, 3 are factors]\nPrime Factorization:\n\"Prime Factorization\" is finding which prime numbers multiply together to make the original number." ,
                Images1 = "Assets/math/Prime/1.png",
                Images2 = "Assets/math/Prime/2.png",
                Images3 = "Assets/math/Prime/3.png",
                Images4 = "Assets/math/Prime/4.png",
                Images5 = "Assets/math/Prime/5.png",
                Images6 = "Assets/math/Prime/6.png",
                Images7 = "Assets/math/Prime/7.png",
                pseudo_code1 = "Assets/math/Prime/pseudo.PNG",
                pseudo_code2 = "Assets/math/Prime/pseudo max heap.PNG",
                analysis = "Assets/math/Prime/analysis.PNG",
                /////////////////////////////////////////////////////
                link1 = "hZvRDG-HgMY",
                link2 = "6PDtgHhpCHo&spfreload=10",
                code_c_plus_plus = "#include<stdio.h>\n#include<math.h>\nprime_factorization(long x)\n{\nlong i;\nlong c;\nc = x;\nwhile ((c % 2) == 0) {\nprintf(\"%ld\n\",2);\nc = c / 2;\n}\ni = 3;\nwhile (i <= (sqrt(c)+1)) {\nif ((c % i) == 0) {\nprintf(\"%ld\n\",i);\nc = c / i;\n}\nelse\ni = i + 2;\n}\nif (c > 1) printf(\"%ld\n\",c);\n}" ,
                code_c_charp = "using System.Collections;\npublic static int[] PrimeFactors(int num)\n{  \nArrayList factors = new ArrayList();\nbool alreadyCounted = false;  \nwhile (num % 2 == 0)  \n{  \nif (alreadyCounted == false)  \n{  \nfactors.Add(2);  \nalreadyCounted = true;  \n}  \nnum = num / 2;  \n}\n\nint divisor = 3;\nalreadyCounted = false;  \nwhile (divisor <= num)  \n{  \nif (num % divisor == 0)  \n{  \nif (alreadyCounted == false)  \n{  \nfactors.Add(divisor);  \nalreadyCounted = true;  \n}  \nnum = num / divisor;  \n}  \nelse  \n{  \nalreadyCounted = false;  \ndivisor += 2;  \n}\n}  \nint[] returnFactors = (int[])factors.ToArray(typeof(int));\nreturn returnFactors;  \n}" ,
                code_java = "public static List<Integer> primeFactors(int numbers) {\nint n = numbers;\nList<Integer> factors = new ArrayList<Integer>();\nfor (int i = 2; i <= n / i; i++) {\nwhile (n % i == 0) {\nfactors.add(i);\nn /= i;\n}\n}\nif (n > 1) {\nfactors.add(n);\n}\nreturn factors;\n}" ,
                comp = " Complexity : O(root(n))", 
            });
        }
    }
}

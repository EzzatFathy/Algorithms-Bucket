using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms_To_Go.VeiwModel
{
    public class Graph_ALGOs
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


    public class Data1
    {
        public List<Graph_ALGOs> myList1
        {
            get
            {
                return privateList;
            }
        }

        private List<Graph_ALGOs> privateList = new List<Graph_ALGOs>();


        public void Data_in()
        {
            myList1.Add(new Graph_ALGOs()
            {
                ID = 0,
                PName = "Breadth First Search",
                //     
                PImage = "Assets/graph/Breadth/face.png",
                desc = "Combines the better attributes of merge sort and insertion sort.\nLike merge sort, but unlike insertion sort, running time is O(n lg n).\nLike insertion sort, but unlike merge sort, sorts in place.\nIntroduces an algorithm design technique \nCreate data structure (heap) to manage information during the execution of an algorithm.\nArray viewed as a nearly complete binary tree.\nPhysically – linear array.\nLogically – binary tree, filled on all levels (except lowest.)",
                Images1 = "Assets/graph/Breadth/1.png",
                Images2 = "Assets/graph/Breadth/2.png",
                Images3 = "Assets/graph/Breadth/3.png",
                Images4 = "Assets/graph/Breadth/4.png",
                Images5 = "Assets/graph/Breadth/5.png",
                Images6 = "Assets/graph/Breadth/6.png",
                Images7 = "Assets/graph/Breadth/7.png",
                pseudo_code1 = "Assets/graph/Breadth/pseudo1.PNG",
                pseudo_code2 = "Assets/graph/Breadth/pseudo2.PNG",
                analysis = "Assets/graph/Breadth/analysis.PNG",
                ///////////////////////////////////////////////////
                link1 = "0GGQXtiCLYs",
                link2 = "COB1GHq0YwY",
                code_c_plus_plus = "#include<iostream>\n#include <list>\nusing namespace std;\n// This class represents a directed graph using adjacency list representation\nclass Graph\n{\nint V;    // No. of vertices\nlist<int> *adj;    // Pointer to an array containing adjacency lists\npublic:\nGraph(int V);  // Constructor\nvoid addEdge(int v, int w); // function to add an edge to graph\nvoid BFS(int s);  // prints BFS traversal from a given source s\n};\nGraph::Graph(int V)\n{\nthis->V = V;\nadj = new list<int>[V];\n}\nvoid Graph::addEdge(int v, int w)\n{\nadj[v].push_back(w); // Add w to v’s list.\n}\nvoid Graph::BFS(int s)\n{\n// Mark all the vertices as not visited\nbool *visited = new bool[V];\nfor(int i = 0; i < V; i++)\nvisited[i] = false;\n// Create a queue for BFS\nlist<int> queue;\n// Mark the current node as visited and enqueue it\nvisited[s] = true;\nqueue.push_back(s);\n// 'i' will be used to get all adjacent vertices of a vertex\nlist<int>::iterator i;\nwhile(!queue.empty())\n{\n// Dequeue a vertex from queue and print it\ns = queue.front();\ncout << s << \" \";\nqueue.pop_front();\n// Get all adjacent vertices of the dequeued vertex s\n// If a adjacent has not been visited, then mark it visited\n// and enqueue it\nfor(i = adj[s].begin(); i != adj[s].end(); ++i)\n{\nif(!visited[*i])\n{\nvisited[*i] = true;\nqueue.push_back(*i);\n}\n}\n}\n}\n// Driver program to test methods of graph class\nint main()\n{\n// Create a graph given in the above diagram\nGraph g(4);\ng.addEdge(0, 1);\ng.addEdge(0, 2);\ng.addEdge(1, 2);\ng.addEdge(2, 0);\ng.addEdge(2, 3);\ng.addEdge(3, 3);\ncout << \"Following is Breadth First Traversal (starting from vertex 2) \n\";\ng.BFS(2);\nreturn 0;\n}" ,  
                code_c_charp = "using System;\nusing System.Collections.Generic;\nusing System.Linq;\nusing System.Text;\nnamespace BreadthFirst\n{\nclass Program\n{\npublic class Person\n{\npublic Person(string name)\n{\nthis.name = name;\n}\npublic string name { get; set; }\npublic List<Person> Friends\n{\nget\n{\nreturn FriendsList;\n}\n}\npublic void isFriendOf(Person p)\n{\nFriendsList.Add(p);\n}\nList<Person> FriendsList = new List<Person>();\npublic override string ToString()\n{\nreturn name;\n}\n}\npublic class BreadthFirstAlgorithm\n{\npublic Person BuildFriendGraph()\n{\nPerson Aaron = new Person(\"Aaron\");\nPerson Betty = new Person(\"Betty\");\nPerson Brian = new Person(\"Brian\");\nAaron.isFriendOf(Betty);\nAaron.isFriendOf(Brian);\nPerson Catherine = new Person(\"Catherine\");\nPerson Carson = new Person(\"Carson\");\nPerson Darian = new Person(\"Darian\");\nPerson Derek = new Person(\"Derek\");\nBetty.isFriendOf(Catherine);\nBetty.isFriendOf(Darian);\nBrian.isFriendOf(Carson);\nBrian.isFriendOf(Derek);\nreturn Aaron;\n}\npublic Person Search(Person root, string nameToSearchFor)\n{\nQueue<Person> Q = new Queue<Person>();\nHashSet<Person> S = new HashSet<Person>();\nQ.Enqueue(root);\nS.Add(root);\nwhile (Q.Count > 0)\n{\nPerson p = Q.Dequeue();\nif (p.name == nameToSearchFor)\nreturn p;\nforeach (Person friend in p.Friends)\n{\nif (!S.Contains(friend))\n{\nQ.Enqueue(friend);\nS.Add(friend);\n}\n}\n}\nreturn null;\n}\npublic void Traverse(Person root)\n{\nQueue<Person> traverseOrder = new Queue<Person>();\nQueue<Person> Q = new Queue<Person>();\nHashSet<Person> S = new HashSet<Person>();\nQ.Enqueue(root);\nS.Add(root);\nwhile (Q.Count > 0)\n{\nPerson p = Q.Dequeue();\ntraverseOrder.Enqueue(p);\nforeach (Person friend in p.Friends)\n{\nif (!S.Contains(friend))\n{\nQ.Enqueue(friend);\nS.Add(friend);\n}\n}\n}\nwhile (traverseOrder.Count > 0)\n{\nPerson p = traverseOrder.Dequeue();\nConsole.WriteLine(p);\n}\n}\n}\nstatic void Main(string[] args)\n{\nBreadthFirstAlgorithm b = new BreadthFirstAlgorithm();\nPerson root = b.BuildFriendGraph();\nConsole.WriteLine(\"Traverse\n------\");\nb.Traverse(root);\nConsole.WriteLine(\"\nSearch\n------\");\nPerson p = b.Search(root, \"Catherine\");\nConsole.WriteLine(p == null ? \"Person not found\" : p.name);\np = b.Search(root, \"Alex\");\nConsole.WriteLine(p == null ? \"Person not found\" : p.name);\n}\n}\n}",      
                code_java = "public void bfs() {\n// BFS uses Queue data structure\nQueue queue = new LinkedList();\nqueue.add(this.rootNode);\nprintNode(this.rootNode);\nrootNode.visited = true;\nwhile (!queue.isEmpty()) {\nNode node = (Node) queue.remove();\nNode child = null;\nwhile ((child = getUnvisitedChildNode(node)) != null) {\nchild.visited = true;\nprintNode(child);\nqueue.add(child);\n}\n}\n// Clear visited property of nodes\nclearNodes();\n}",
                comp = " Complexity : O(|V|+|E|)",

            });

            myList1.Add(new Graph_ALGOs()
            {
                ID = 1,
                PName = "Depth First Search",
                //     
                PImage = "Assets/graph/Depth/face.png",
                desc = "Depth-first search (DFS) \nis an algorithm for traversing or \nsearching tree or graph data structures.\n One starts at the root (selecting some \narbitrary node as the root in the case of a graph) and \nexplores as far as possible along each branch before backtracking.",
                Images1 = "Assets/graph/Depth/1.png",
                Images2 = "Assets/graph/Depth/2.png",
                Images3 = "Assets/graph/Depth/3.png",
                Images4 = "Assets/graph/Depth/4.png",
                Images5 = "Assets/graph/Depth/5.png",
                Images6 = "Assets/graph/Depth/6.png",
                Images7 = "Assets/graph/Depth/7.png",
                pseudo_code1 = "Assets/graph/Depth/pseudo1.PNG",
                pseudo_code2 = "Assets/graph/Depth/pseudo2.PNG",
                analysis = "Assets/graph/Depth/analysis.PNG",
                ///////////////////////////////////////////////////
                link1 = "f7xa3T5PaBI",
                link2 = "9DP0X2xlPCo",
                code_c_plus_plus = "enum VertexState { White, Gray, Black };\nvoid Graph::DFS() {\nVertexState *state = new VertexState[vertexCount];\nfor (int i = 0; i < vertexCount; i++)\nstate[i] = White;\nrunDFS(0, state);\ndelete [] state;\n}\nvoid Graph::runDFS(int u, VertexState state[]) {\nstate[u] = Gray;\nfor (int v = 0; v < vertexCount; v++)\nif (isEdge(u, v) && state[v] == White)\nrunDFS(v, state);\nstate[u] = Black;\n}",  
                code_c_charp = "Visit(IVertexListGraph g, IVertex u)\n{\nColors[u] = Gray;\nOnDiscoverVertex(u); // event\n// examine edges\nforeach(IEdge e in g.OutEdges(u))\n{\nOnExamineEdge(e); // event\nif (Colors[u] == White)\n{\nOnTreeEdge(e); // event\nVisit(e.Target);\n}\nelse if (Colors[u] == Gray)\n{\nOnBackEdge(e); // event\n}\nelse\nOnForwardOrCrossEdge(e); // event\n}\nColors[u] = Black;\nOnFinishVertex(u); // event\n}",    
                code_java = "public class Graph {\nenum VertexState { White, Gray, Black }\npublic void DFS() {\nVertexState state[] = new VertexState[vertexCount];\nfor (int i = 0; i < vertexCount; i++)\nstate[i] = VertexState.White;\nrunDFS(0, state);\n}\npublic void runDFS(int u, VertexState[] state) {\nstate[u] = VertexState.Gray;\nfor (int v = 0; v < vertexCount; v++)\nif (isEdge(u, v) && state[v] == VertexState.White)\nrunDFS(v, state);\nstate[u] = VertexState.Black;\n}\n}" ,
                comp = " Complexity : O(|V|+|E|)",

            });


            myList1.Add(new Graph_ALGOs()
            {
                ID = 2,
                PName = "Dijikstra",
                //     
                PImage = "Assets/graph/Dijikstra/face.png",
                desc = "Dijkstra's algorithm, conceived by \nDutch computer scientist Edsger Dijkstra in 1956 and published in 1959, is a \ngraph search algorithm that solves the single-source shortest path problem \nfor a graph with nonnegative edge path costs, producing a \nshortest path tree. This algorithm is often used in \nrouting and as a subroutine in other graph algorithms",
                Images1 = "Assets/graph/Dijikstra/1.png",
                Images2 = "Assets/graph/Dijikstra/2.png",
                Images3 = "Assets/graph/Dijikstra/3.png",
                Images4 = "Assets/graph/Dijikstra/4.png",
                Images5 = "Assets/graph/Dijikstra/5.png",
                Images6 = "Assets/graph/Dijikstra/6.png",
                Images7 = "Assets/graph/Dijikstra/7.png",
                pseudo_code1 = "Assets/graph/Dijikstra/pseudo1.PNG",
                pseudo_code2 = "Assets/graph/Dijikstra/pseudo2.PNG",
                analysis = "Assets/graph/Dijikstra/analysis.PNG",
                ///////////////////////////////////////////////////
                link1 = "mv4r7F82doA",
                link2 = "6GzxGabB5MI",
                code_c_plus_plus = "Oops couldn't found suitable Code." ,
                code_c_charp = "Oops couldn't found suitable Code.",
                code_java = "public class Dijkstra {\n// Dijkstra's algorithm to find shortest path from s to all other nodes\npublic static int [] dijkstra (WeightedGraph G, int s) {\nfinal int [] dist = new int [G.size()];  // shortest known distance from \"s\"\\nfinal int [] pred = new int [G.size()];  // preceeding node in path\nfinal boolean [] visited = new boolean [G.size()]; // all false initially\nfor (int i=0; i<dist.length; i++) {\ndist[i] = Integer.MAX_VALUE;\n}\ndist[s] = 0;\nfor (int i=0; i<dist.length; i++) {\nfinal int next = minVertex (dist, visited);\nvisited[next] = true;\n// The shortest path to next is dist[next] and via pred[next].\nfinal int [] n = G.neighbors (next);\nfor (int j=0; j<n.length; j++) {\nfinal int v = n[j];\nfinal int d = dist[next] + G.getWeight(next,v);\nif (dist[v] > d) {\ndist[v] = d;\npred[v] = next;\n}\n}\n}\nreturn pred;  // (ignore pred[s]==0!)\n}\nprivate static int minVertex (int [] dist, boolean [] v) {\nint x = Integer.MAX_VALUE;\nint y = -1;   // graph not connected, or no unvisited vertices\nfor (int i=0; i<dist.length; i++) {\nif (!v[i] && dist[i]<x) {y=i; x=dist[i];}\n}\nreturn y;\n}\npublic static void printPath (WeightedGraph G, int [] pred, int s, int e) {\nfinal java.util.ArrayList path = new java.util.ArrayList();\nint x = e;\nwhile (x!=s) {\npath.add (0, G.getLabel(x));\nx = pred[x];\n}\npath.add (0, G.getLabel(s));\nSystem.out.println (path);\n}\n}" ,
                comp = " Complexity : O(E lg V)",  

            });




            myList1.Add(new Graph_ALGOs()
            {
                ID = 3,
                PName = "Prim's Algorithm",
                //      
                PImage = "Assets/graph/Prim/face.png",
                desc = "Combines the better attributes of merge sort and insertion sort.\nLike merge sort, but unlike insertion sort, running time is O(n lg n).\nLike insertion sort, but unlike merge sort, sorts in place.\nIntroduces an algorithm design technique \nCreate data structure (heap) to manage information during the execution of an algorithm.\nArray viewed as a nearly complete binary tree.\nPhysically – linear array.\nLogically – binary tree, filled on all levels (except lowest.)",
                Images1 = "Assets/graph/Prim/1.png",
                Images2 = "Assets/graph/Prim/2.png",
                Images3 = "Assets/graph/Prim/3.png",
                Images4 = "Assets/graph/Prim/4.png",
                Images5 = "Assets/graph/Prim/5.png",
                Images6 = "Assets/graph/Prim/6.png",
                Images7 = "Assets/graph/Prim/7.png",
                pseudo_code1 = "Assets/graph/Prim/pseudo1.PNG",
                pseudo_code2 = "Assets/graph/Prim/pseudo2.PNG",
                analysis = "Assets/graph/Prim/analysis.PNG",
                ///////////////////////////////////////////////////
                link1 = "3mMNAxMeSNA",
                link2 = "KHuoz63z6xw",
                // 
                code_c_plus_plus = "#include <iostream>\n#include <conio.h>\nusing namespace std;\nstruct node\n{\nint fr, to, cost;\n}p[6];\nint c = 0, temp1 = 0, temp = 0;\nvoid prims(int *a, int b[][7], int i, int j)\n{\na[i] = 1;\nwhile (c < 6)\n{\nint min = 999;\nfor (int i = 0; i < 7; i++)\n{\nif (a[i] == 1)\n{\nfor (int j = 0; j < 7; )\n{\nif (b[i][j] >= min || b[i][j] == 0)\n{\nj++;\n}\nelse if (b[i][j] < min)\n{\nmin = b[i][j];\ntemp = i;\ntemp1 = j;\n}\n}\n}\n}\na[temp1] = 1;\np[c].fr = temp;\np[c].to = temp1;\np[c].cost = min;\nc++;\nb[temp][temp1] = b[temp1][temp]=1000;\n}\nfor (int k = 0; k < 6; k++)\n{\ncout<<\"source node:\"<<p[k].fr<<endl;\ncout<<\"destination node:\"<<p[k].to<<endl;\ncout<<\"weight of node\"<<p[k].cost<<endl;\n}\n}\nint main()\n{\nint a[7];\nfor (int i = 0; i < 7; i++)\n{\na[i] = 0;\n}\nint b[7][7];\nfor (int i = 0; i < 7; i++)\n{\ncout<<\"enter values for \"<<(i+1)<<\" row\"<<endl;\nfor (int j = 0; j < 7; j++)\n{\ncin>>b[i][j];\n}\n}\nprims(a, b, 0, 0);\ngetch();\n}",
                code_c_charp = "Oops couldn't found suitable Code.",
                code_java = "Oops couldn't found suitable Code.",
                comp = " Complexity : O(ElgV)", 
            });



         


        }
    }
}

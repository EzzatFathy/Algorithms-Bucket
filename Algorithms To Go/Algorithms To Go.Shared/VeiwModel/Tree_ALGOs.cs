using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms_To_Go.VeiwModel
{
    public class Tree_ALGOs
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


    public class Data4
    {
        public List<Tree_ALGOs> myList4
        {
            get
            {
                return privateList;
            }
        }

        private List<Tree_ALGOs> privateList = new List<Tree_ALGOs>();


        public void Data_in()
        {
            myList4.Add(new Tree_ALGOs()
            {
                ID = 0,
                PName = "Lowest Common Ancestor",
                // need data 
                PImage = "Assets/tree/Lowest/face.png",
                desc = "The lowest common ancestor (LCA)\n is a concept in graph theory and computer science.\n Let T be a rooted tree with n nodes. The lowest common ancestor is defined \nbetween two nodes v and w as the lowest node in T that has both v and w as \ndescendants (where we allow a node to be a descendant of itself).",
Images1 = "Assets/sortings/heap/1.png",
                Images2 = "Assets/tree/Lowest/2.png",
                Images3 = "Assets/tree/Lowest/3.png",
                Images4 = "Assets/tree/Lowest/4.png",
                Images5 = "Assets/tree/Lowest/5.png",
                Images6 = "Assets/tree/Lowest/6.png",
                Images7 = "Assets/tree/Lowest/7.png",
                pseudo_code1 = "Assets/tree/Lowest/pseudo.PNG",
                pseudo_code2 = "Assets/tree/Lowest/pseudo max heap.PNG",
                analysis = "Assets/tree/Lowest/analysis.PNG",
                //////////////////////////////////////
                link1 = "LFjCr2yDJdc",
                link2 = "c1jR2M9gzic",
                code_c_plus_plus = "int getHeight(Node *p) {\nint height = 0;\nwhile (p) {\nheight++;\np = p->parent;\n}\nreturn height;\n}\n// As root->parent is NULL, we don't need to pass root in.\nNode *LCA(Node *p, Node *q) {\nint h1 = getHeight(p);\nint h2 = getHeight(q);\n// swap both nodes in case p is deeper than q.\nif (h1 > h2) {\nswap(h1, h2);\nswap(p, q);\n}\n// invariant: h1 <= h2.\nint dh = h2 - h1;\nfor (int h = 0; h < dh; h++)\nq = q->parent;\nwhile (p && q) {\nif (p == q) return p;\np = p->parent;\nq = q->parent;\n}\nreturn NULL;  // p and q are not in the same tree\n}" ,
                code_c_charp = "public interface Node\n{\nNode Parent { get; }\n}\npublic static Node GetLeastCommonAncestor(Node a, Node b)\n{\nStack<Node> aStack = GetStack(a);\nStack<Node> bStack = GetStack(b);\nNode zipper;\nwhile (aStack.Count > 0 && bStack.Count > 0 && aStack.Pop() == bStack.Peek())\nzipper = bStack.Pop();\nreturn zipper;\n}\nprivate static Stack<Node> GetStack(Node me)\n{\nStack<Node> stack = new Stack<Node>();\nwhile (me != null)\n{\nstack.Push(me);\nme = me.Parent;\n}\nreturn stack;\n}",
                code_java = "public static Node findLowestCommonAncestor( Node startNode, int a, int b ) {\n// Find the lowest (nearest) common ancestor\nwhile( startNode != null ) {\nif( a < startNode.data && b < startNode.data ) {\nstartNode = startNode.left;\n} else if( a > startNode.data && b > startNode.data ) { \nstartNode = startNode.right;\n} else {\nreturn startNode;\n}\n}\nreturn null;\n}",
                comp = " Complexity : O(n2) ",  

            });

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NG.DFS
{


    class node
    {
        public int item;
        public node root;
        public node right;
        public node left;


    }
    class DFS
    {
        Queue<Int32> qt = new Queue<Int32>();
        Dictionary<int, node> MyList = new Dictionary<int, node>();
        public void DFSInorder(node root)
        {
            if (root == null)
            {
                return;
            }
            DFSInorder(root.left);
            Console.WriteLine(root.item);
            DFSInorder(root.right);


        }

        static void Main(string[] args)
        {
            DFS dfs = new DFS();
            node myNode1 = new node();
            node myNode2 = new node();
            node myNode3 = new node();
            node myNode4 = new node();
            node myNode5 = new node();
            node myNode6 = new node();


            myNode1.root = myNode1;
            myNode1.left = myNode2;
            myNode1.right = myNode3;
            myNode1.item = 5;

            myNode2.root = myNode1;
            myNode2.left = myNode4;
            myNode2.right = myNode5;
            myNode2.item = 3;

            myNode3.root = myNode1;
            myNode3.right = myNode6;
            myNode3.left = null;
            myNode3.item = 7;

            myNode4.root = myNode2;
            myNode4.left = null;
            myNode4.right = null;
            myNode4.item = 1;

            myNode5.root = myNode2;
            myNode5.left = null;
            myNode5.right = null;
            myNode5.item = 2;

            myNode6.root = myNode3;
            myNode6.left = null;
            myNode6.right = null;
            myNode6.item = 6;

            dfs.DFSInorder(myNode1);
            Console.ReadKey();

        }
    }

}
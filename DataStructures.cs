using System;
using System.Collections.Generic;

namespace MunicipalServices
{
    // =========================================================
    // 1. AVL TREE (Fulfills the Basic Trees / BST Requirement)
    // Used to quickly search for a request by its unique ID.
    // =========================================================
    public class TreeNode
    {
        public ServiceRequest Data;
        public TreeNode Left, Right;
        public int Height;

        public TreeNode(ServiceRequest data)
        {
            Data = data;
            Height = 1;
        }
    }

    public class RequestAVLTree
    {
        public TreeNode Root;

        public int Height(TreeNode N)
        {
            if (N == null) return 0;
            return N.Height;
        }

        public int Max(int a, int b) { return (a > b) ? a : b; }

        public TreeNode RightRotate(TreeNode y)
        {
            TreeNode x = y.Left;
            TreeNode T2 = x.Right;
            x.Right = y;
            y.Left = T2;
            y.Height = Max(Height(y.Left), Height(y.Right)) + 1;
            x.Height = Max(Height(x.Left), Height(x.Right)) + 1;
            return x;
        }

        public TreeNode LeftRotate(TreeNode x)
        {
            TreeNode y = x.Right;
            TreeNode T2 = y.Left;
            y.Left = x;
            x.Right = T2;
            x.Height = Max(Height(x.Left), Height(x.Right)) + 1;
            y.Height = Max(Height(y.Left), Height(y.Right)) + 1;
            return y;
        }

        public int GetBalance(TreeNode N)
        {
            if (N == null) return 0;
            return Height(N.Left) - Height(N.Right);
        }

        public TreeNode Insert(TreeNode node, ServiceRequest data)
        {
            if (node == null) return new TreeNode(data);

            if (data.RequestId < node.Data.RequestId)
                node.Left = Insert(node.Left, data);
            else if (data.RequestId > node.Data.RequestId)
                node.Right = Insert(node.Right, data);
            else
                return node; // Duplicate IDs not allowed

            node.Height = 1 + Max(Height(node.Left), Height(node.Right));
            int balance = GetBalance(node);

            // Balancing cases
            if (balance > 1 && data.RequestId < node.Left.Data.RequestId) return RightRotate(node);
            if (balance < -1 && data.RequestId > node.Right.Data.RequestId) return LeftRotate(node);
            if (balance > 1 && data.RequestId > node.Left.Data.RequestId)
            {
                node.Left = LeftRotate(node.Left);
                return RightRotate(node);
            }
            if (balance < -1 && data.RequestId < node.Right.Data.RequestId)
            {
                node.Right = RightRotate(node.Right);
                return LeftRotate(node);
            }
            return node;
        }

        public ServiceRequest Search(TreeNode root, int id)
        {
            if (root == null || root.Data.RequestId == id) return root?.Data;
            if (root.Data.RequestId < id) return Search(root.Right, id);
            return Search(root.Left, id);
        }
    }

    // =========================================================
    // 2. MIN-HEAP (Fulfills the Heaps Requirement)
    // Used to automatically bring the highest priority (1) to the top.
    // =========================================================
    public class RequestMinHeap
    {
        private List<ServiceRequest> heap = new List<ServiceRequest>();

        public void Insert(ServiceRequest request)
        {
            heap.Add(request);
            int i = heap.Count - 1;

            // Bubble up based on Priority (1 is highest priority)
            while (i > 0 && heap[(i - 1) / 2].Priority > heap[i].Priority)
            {
                var temp = heap[(i - 1) / 2];
                heap[(i - 1) / 2] = heap[i];
                heap[i] = temp;
                i = (i - 1) / 2;
            }
        }

        public ServiceRequest ExtractMin()
        {
            if (heap.Count == 0) return null;
            var min = heap[0];
            heap[0] = heap[heap.Count - 1];
            heap.RemoveAt(heap.Count - 1);

            Heapify(0);
            return min;
        }

        private void Heapify(int i)
        {
            int smallest = i;
            int left = 2 * i + 1;
            int right = 2 * i + 2;

            if (left < heap.Count && heap[left].Priority < heap[smallest].Priority) smallest = left;
            if (right < heap.Count && heap[right].Priority < heap[smallest].Priority) smallest = right;

            if (smallest != i)
            {
                var temp = heap[i];
                heap[i] = heap[smallest];
                heap[smallest] = temp;
                Heapify(smallest);
            }
        }
    }

    // =========================================================
    // 3. GRAPH & MST (Fulfills Graph, Traversal, and MST Requirement)
    // Uses Kruskal's algorithm to find the Minimum Spanning Tree.
    // =========================================================
    public class MunicipalGraph
    {
        public int Vertices = 0;
        public List<Edge> AllEdges = new List<Edge>();

        public void AddEdge(int source, int dest, int weight)
        {
            AllEdges.Add(new Edge(source, dest, weight));
            Vertices = Math.Max(Vertices, Math.Max(source, dest)) + 1;
        }

        // Kruskal's Algorithm for Minimum Spanning Tree
        public List<Edge> GetMST()
        {
            List<Edge> mst = new List<Edge>();

            // Sort edges by weight
            AllEdges.Sort((a, b) => a.Weight.CompareTo(b.Weight));

            int[] parent = new int[Vertices];
            for (int i = 0; i < Vertices; i++) parent[i] = i;

            int Find(int i)
            {
                if (parent[i] == i) return i;
                return parent[i] = Find(parent[i]);
            }

            void Union(int x, int y)
            {
                int xroot = Find(x);
                int yroot = Find(y);
                if (xroot != yroot) parent[xroot] = yroot;
            }

            foreach (var edge in AllEdges)
            {
                int x = Find(edge.Source);
                int y = Find(edge.Destination);

                if (x != y)
                {
                    mst.Add(edge);
                    Union(x, y);
                }
            }
            return mst;
        }
    }
}
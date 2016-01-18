using Microsoft.Msagl.Drawing;
using Microsoft.Msagl.GraphViewerGdi;
using Microsoft.Msagl.Layout.Layered;
using System.Windows.Forms;
using System.Collections.Generic;
using System;

namespace MaxFlowDemo
{
    public partial class Form1 : Form
    {
        void FordFulkersonAlgo(Node nodeSource, Node nodeTerminal)
        {
            var flow = 0f;
            var path = Bfs(nodeSource, nodeTerminal);

            while (path != null && path.Count > 0)
            {
                reloadLabels();
                //ta pętla to kolejne kroki zmieniania się grafu - zapisać przed obliczeniami stan w tablicy, obsłużyć przerywanie (zawieszanie - mogą być dialogboxy zawieszące tego while'a) i sterowanie - zmiana zmiennych na takie z pamięci
                var minCapacity = float.MaxValue;
                foreach (var edge in path)
                {
                    if (((EdgeData)(edge.UserData)).currFlow < minCapacity)
                        minCapacity = ((EdgeData)(edge.UserData)).currFlow;
                }

                //if (minCapacity == float.MaxValue || minCapacity < 0)
                //    ;// throw new Exception("minCapacity " + minCapacity);

                AugmentPath(path, minCapacity);
                flow += minCapacity;

                path = Bfs(nodeSource, nodeTerminal);
            }
            reloadLabels();
            MessageBox.Show(flow.ToString());
        }
        void AugmentPath(IEnumerable<Edge> path, float minCapacity)
        {
            foreach (var edge in path)
            {
                ((EdgeData)(edge.UserData)).currFlow -= minCapacity;
            }
        }
        List<Edge> Bfs(Node root, Node target)
        {
            ((NodeData)(root.UserData)).TraverseParent = null;
            ((NodeData)(target.UserData)).TraverseParent = null;

            var queue = new Queue<Node>();
            var discovered = new HashSet<Node>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                Node current = queue.Dequeue();
                discovered.Add(current);

                if (current.Id == target.Id)
                    return GetPath(current);

                var nodeEdges = current.OutEdges;
                foreach (var edge in nodeEdges)
                {
                    var next = edge.TargetNode;
                    var c = ((EdgeData)(edge.UserData)).currFlow;
                    if (c > 0 && !discovered.Contains(next))
                    {
                        ((NodeData)(next.UserData)).TraverseParent = current;
                        queue.Enqueue(next);
                    }
                }
            }
            return null;
        }
        List<Edge> GetPath(Node node)
        {
            var path = new List<Edge>();
            var current = node;
            while (((NodeData)(current.UserData)).TraverseParent != null)
            {
                var edge = new Edge(((NodeData)(current.UserData)).TraverseParent, current, ConnectionToGraph.Disconnected);
                foreach (Edge e in ((NodeData)(current.UserData)).TraverseParent.OutEdges)
                {
                    if (e.TargetNode == current) edge.UserData = e.UserData;
                }
                path.Add(edge);
                current = ((NodeData)(current.UserData)).TraverseParent;
            }
            return path;
        }
    }

}

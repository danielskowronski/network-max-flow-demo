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
            List<AlgoState> steps = new List<AlgoState>(); AlgoState cas = new AlgoState();

            while (path != null && path.Count > 0)
            {
                var minCapacity = float.MaxValue;
                foreach (var edge in path)
                {
                    if (((EdgeData)(edge.UserData)).currFlow < minCapacity)
                        minCapacity = ((EdgeData)(edge.UserData)).currFlow;
                }

                AugmentPath(path, minCapacity);
                flow += minCapacity;

                clearColors();
                reloadLabels();
                foreach (Edge e in path)
                {
                    foreach (Edge e2 in graph.Edges)
                    {
                        if (e2.Source == e.Source && e2.Target == e.Target) e2.Attr.Color = Color.Red;
                        //dirty code written without understanding Graph class - fixme!
                    }
                }
                redraw();
                DialogResult dr = MessageBox.Show("pauza\n\nYes=kontynuuj, No=wstecz o jeden krok", "pauza", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes) {
                    cas.g = graph; cas.p = path; steps.Add(cas); 
                    path = Bfs(nodeSource, nodeTerminal);
                }
                else if (dr == DialogResult.No)
                {
                    if (steps.Count < 1)
                    {
                        MessageBox.Show("Nie można sie cofnąć!");
                    }
                    else { 
                        cas = steps[steps.Count - 1];
                        steps.RemoveAt(steps.Count - 1);
                        graph = cas.g; path = cas.p;
                        continue;
                    }
                }
            }

            clearColors();
            reloadLabels();
            MessageBox.Show("Maksymalny przepływ wynosi: "+flow.ToString());
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

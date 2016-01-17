using Microsoft.Msagl.Drawing;
using Microsoft.Msagl.GraphViewerGdi;
using Microsoft.Msagl.Layout.Layered;
using System.Windows.Forms;
using System.Collections.Generic;
using System;

namespace MaxFlowDemo
{
    public class EdgeData
    {
        public float currFlow = 0;
        public float maxFlow = 0;
        public override string ToString() { return currFlow + "/" + maxFlow; }
    }
    public class NodeData
    {
        public Node TraverseParent;
    }
    public partial class Form1 : Form
    {
        bool loaded = false;

        Graph graph;
        GViewer gViewer;
        string srcKey = "", trgtKey = "";

        public Form1()
        {
            InitializeComponent();
            gViewer = new GViewer() { Dock = DockStyle.Right, Width = this.Width - 160 };
            SuspendLayout();
            Controls.Add(gViewer);
            ResumeLayout();
            graph = new Graph();
            var sugiyamaSettings = (SugiyamaLayoutSettings)graph.LayoutAlgorithmSettings;
            sugiyamaSettings.NodeSeparation *= 2;

            gViewer.Graph = graph;
            loaded = true;

            reloadNodesCombobox();
            reloadEdgesCombobox();
        }

        private void redraw()
        {
            gViewer.Graph = graph;
        }
        private void reloadNodesCombobox()
        {
            comboBox_delNode.Items.Clear();
            comboBox_newEdgeTrgt.Items.Clear();
            comboBox_newEdgeSrc.Items.Clear();
            comboBox_selectSource.Items.Clear();
            comboBox_selectTarget.Items.Clear();

            foreach (Node n in graph.Nodes)
            {
                comboBox_delNode.Items.Add(n);
                comboBox_newEdgeTrgt.Items.Add(n);
                comboBox_newEdgeSrc.Items.Add(n);
                comboBox_selectSource.Items.Add(n);
                comboBox_selectTarget.Items.Add(n);
            }
        }
        private void reloadEdgesCombobox()
        {
            comboBox_delEdge.Items.Clear();
            comboBox_changeCap.Items.Clear();

            foreach (Edge e in graph.Edges)
            {
                comboBox_delEdge.Items.Add(e);
                comboBox_changeCap.Items.Add(e);
            }
        }

        private void Form1_Resize(object sender, System.EventArgs e)
        {
            if (!loaded) return;

            Form s = (Form)(sender);
            gViewer.Width = s.Width - 100;
        }

        private void button_redraw_Click(object sender, System.EventArgs e)
        {
            redraw();
        }


        private void button2_Click(object sender, System.EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Czy na pewno wyczyścić graf?", "Czy na pewno wyczyścić graf?", MessageBoxButtons.OKCancel);
            if (confirm != DialogResult.OK) return;

            graph = new Graph();
            redraw();
        }

        private void button3_Click(object sender, System.EventArgs e)
        {

        }

        private void button4_Click(object sender, System.EventArgs e)
        {

        }

        private void button_delNode_Click(object sender, System.EventArgs e)
        {
            if (comboBox_delNode.SelectedItem == null)
            {
                MessageBox.Show("Wybierz węzeł do usunięcia.");
                return;
            }
            graph.RemoveNode(graph.FindNode(comboBox_delNode.SelectedItem.ToString()));
            comboBox_delNode.SelectedItem = null;
            reloadNodesCombobox();
            redraw();
        }

        private void button_newEdge_Click(object sender, System.EventArgs e)
        {
            if (comboBox_newEdgeSrc.SelectedItem == null || comboBox_newEdgeTrgt.SelectedItem == null)
            {
                MessageBox.Show("Krawędź musi mieć dwa końce!");
                return;
            }
            if (comboBox_newEdgeSrc.SelectedItem == comboBox_newEdgeTrgt.SelectedItem)
            {
                MessageBox.Show("Pętla jednowierzchołkowa nie ma sensu!");
                return;
            }

            Edge edge = new Edge(graph.FindNode(comboBox_newEdgeSrc.SelectedItem.ToString()), graph.FindNode(comboBox_newEdgeTrgt.SelectedItem.ToString()), ConnectionToGraph.Connected);
            edge.UserData = new EdgeData();
            edge.LabelText = edge.UserData.ToString();
        //    graph.AddPrecalculatedEdge(edge);
            comboBox_newEdgeSrc.SelectedItem = comboBox_newEdgeTrgt.SelectedItem = null;
            reloadEdgesCombobox();
            redraw();
        }

        private void button_delEdge_Click(object sender, System.EventArgs e)
        {
            if (comboBox_delEdge.SelectedItem == null)
            {
                MessageBox.Show("Wybierz krawędź do usunięcia.");
                return;
            }
            graph.RemoveEdge((Edge)(comboBox_delEdge.SelectedItem));
            comboBox_delEdge.SelectedItem = null;
            reloadEdgesCombobox();
            redraw();
        }
        /* ------------------------------------------------------------------------------------------------------- */

        void FordFulkersonAlgo(Node nodeSource, Node nodeTerminal)
        {
            var flow = 0f;
            var path = Bfs(nodeSource, nodeTerminal);

            while (path != null && path.Count > 0)
            {
                var minCapacity = float.MaxValue;
                foreach (var edge in path)
                {
                    if ( ((EdgeData)(edge.UserData)).maxFlow < minCapacity)
                        minCapacity = ((EdgeData)(edge.UserData)).maxFlow; // update
                }

                if (minCapacity == float.MaxValue || minCapacity < 0)
                    ;// throw new Exception("minCapacity " + minCapacity);

                AugmentPath(path, minCapacity);
                flow += minCapacity;

                path = Bfs(nodeSource, nodeTerminal);
            }
            MessageBox.Show(flow.ToString());
        }
        void AugmentPath(IEnumerable<Edge> path, float minCapacity)
        {
            foreach (var edge in path)
            {
                //var keyResidual =   //GetKey(edge.NodeTo.Id, edge.NodeFrom.Id);
                //var edgeResidual =  new Edge //((EdgeData)(edge.UserData)). //Edges[keyResidual];

                ((EdgeData)(edge.UserData)).maxFlow -= minCapacity;//.....
                //edgeResidual.Capacity += minCapacity;//our grah is indricted
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

                var nodeEdges = current.OutEdges;//  .NodeEdges;
                foreach (var edge in nodeEdges)
                {
                    var next = edge.TargetNode;// .NodeTo;
                    var c = ((EdgeData)(edge.UserData)).maxFlow;//  GetCapacity(current, next);
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
                //var key = GetKey(current.TraverseParent.Id, current.Id);
                var edge = new Edge(((NodeData)(current.UserData)).TraverseParent, current, ConnectionToGraph.Connected);
                foreach (Edge e in ((NodeData)(current.UserData)).TraverseParent.OutEdges)
                {
                    if (e.TargetNode == current) edge.UserData = e.UserData;
                }
                path.Add(edge);
                current = ((NodeData)(current.UserData)).TraverseParent;
            }   
            return path;
        }
        /* ------------------------------------------------------------------------------------------------------- */
        private void button_calc_Click(object sender, System.EventArgs e)
        {
            FordFulkersonAlgo(graph.FindNode(srcKey), graph.FindNode(trgtKey));
            redraw();//
            int a = 0;
        }

        private void comboBox_selectSource_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (comboBox_selectSource.SelectedItem == null)
            {
                MessageBox.Show("Wybierz krawędź.");
                return;
            }
            Node n = graph.FindNode(srcKey);
            if (n != null)
            {
                n.Attr.Shape = Shape.Box; n.Attr.Color = Color.Black;
            }
            srcKey = comboBox_selectSource.SelectedItem.ToString();
            n = (Node)(comboBox_selectSource.SelectedItem);
            n.Attr.Shape = Shape.House; n.Attr.Color = Color.Blue;
            redraw();
        }

        private void comboBox_selectTarget_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (comboBox_selectTarget.SelectedItem == null)
            {
                MessageBox.Show("Wybierz krawędź.");
                return;
            }
            Node n = graph.FindNode(trgtKey);
            if (n != null)
            {
                n.Attr.Shape = Shape.Box; n.Attr.Color = Color.Black;
            }
            trgtKey = comboBox_selectTarget.SelectedItem.ToString();
            n = (Node)(comboBox_selectTarget.SelectedItem);
            n.Attr.Shape = Shape.Ellipse; n.Attr.Color = Color.Blue;
            redraw();
        }

        private void button_changeCap_Click(object sender, System.EventArgs e)
        {
            if (comboBox_changeCap.SelectedItem == null)
            {
                MessageBox.Show("Wybierz krawędź.");
                return;
            }
            int cap = 0;

            if (!Int32.TryParse(textBox_changeCap.Text, out cap))
            {
                MessageBox.Show("Wprowadź liczbową wartość max przepływu na krawędzi!");
                return;
            }
            Edge edge = (Edge)(comboBox_changeCap.SelectedItem);
            ((EdgeData)(edge.UserData)).maxFlow = cap;
            //invalidate all curr flows here!
            edge.LabelText = edge.UserData.ToString();
            redraw();
        }

        private void button_newNode_Click(object sender, System.EventArgs e)
        {
            graph.AddNode(textBox_newNodeName.Text);
            graph.FindNode(textBox_newNodeName.Text).UserData = new NodeData();
            textBox_newNodeName.Text = "";
            reloadNodesCombobox();
            redraw();
        }
    }
}

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
            gViewer.Width = s.Width - 160;
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

        private void addEdge(Graph g, string source, string target, float maxFlow)
        {
            Edge e;
            e = new Edge(graph.FindNode(source), graph.FindNode(target), ConnectionToGraph.Connected);
            e.UserData = new EdgeData();
            ((EdgeData)(e.UserData)).maxFlow = ((EdgeData)(e.UserData)).currFlow = maxFlow;
            e.LabelText = ((EdgeData)(e.UserData)).ToString();
        }
        private void addNode(Graph g, string label)
        {
            g.AddNode(label);
            g.FindNode(label).UserData = new NodeData();
        }
        private void button3_Click(object sender, System.EventArgs e)
        {
            //demo1 - graf z http://eduinf.waw.pl/inf/alg/001_search/0146.php
            button2_Click(sender, e);

            addNode(graph, "s");
            addNode(graph, "a");
            addNode(graph, "b");
            addNode(graph, "c");
            addNode(graph, "d");
            addNode(graph, "e");
            addNode(graph, "t");

            addEdge(graph, "s", "a", 9);
            addEdge(graph, "s", "d", 9);
            addEdge(graph, "a", "b", 7);
            addEdge(graph, "a", "c", 3);
            addEdge(graph, "b", "t", 6);
            addEdge(graph, "b", "c", 4);
            addEdge(graph, "c", "t", 9);
            addEdge(graph, "c", "e", 2);
            addEdge(graph, "d", "c", 3);
            addEdge(graph, "d", "e", 6);
            addEdge(graph, "e", "t", 8);

            reloadEdgesCombobox();
            reloadNodesCombobox();

            comboBox_selectSource.SelectedItem = graph.FindNode("s");
            comboBox_selectTarget.SelectedItem = graph.FindNode("t");

            redraw();
        }

        private void button4_Click(object sender, System.EventArgs e)
        {
            //demo2
            button2_Click(sender, e);

            addNode(graph, "s");
            addNode(graph, "a");
            addNode(graph, "b");
            addNode(graph, "t");

            addEdge(graph, "s", "a", 4);
            addEdge(graph, "s", "b", 5);
            addEdge(graph, "a", "t", 5);
            addEdge(graph, "b", "t", 4);

            reloadEdgesCombobox();
            reloadNodesCombobox();

            comboBox_selectSource.SelectedItem = graph.FindNode("s");
            comboBox_selectTarget.SelectedItem = graph.FindNode("t");

            redraw();
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
            invalidateFlow();
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
                MessageBox.Show("Pętle są niedozwolone w sieci przepływowej!");
                return;
            }

            Edge edge = new Edge(graph.FindNode(comboBox_newEdgeSrc.SelectedItem.ToString()), graph.FindNode(comboBox_newEdgeTrgt.SelectedItem.ToString()), ConnectionToGraph.Connected);
            edge.UserData = new EdgeData();
            edge.LabelText = edge.UserData.ToString();
            comboBox_newEdgeSrc.SelectedItem = comboBox_newEdgeTrgt.SelectedItem = null;
            reloadEdgesCombobox();
            invalidateFlow();
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
            invalidateFlow();
            redraw();
        }

        private void reloadLabels()
        {
            foreach (Edge e in graph.Edges)
            {
                e.LabelText = ((EdgeData)(e.UserData)).ToString();
            }
        }
        private void clearColors()
        {
            foreach (Edge e in graph.Edges)
            {
                e.Attr.Color = Color.Black;
            }
        }
        private void invalidateFlow()
        {
            foreach (Edge e in graph.Edges)
            {
                ((EdgeData)(e.UserData)).currFlow = ((EdgeData)(e.UserData)).maxFlow;
            }
        }

        private void button_calc_Click(object sender, System.EventArgs e)
        {
            if (srcKey == "" || trgtKey == "")
            {
                MessageBox.Show("Ustaw najpierw źródło i ujście");
                return;
            }
            if (srcKey == trgtKey )
            {
                MessageBox.Show("Źródło nie może być równe celowi");
                return;
            }

            FordFulkersonAlgo(graph.FindNode(srcKey), graph.FindNode(trgtKey));
            redraw();
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
            invalidateFlow();
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
            invalidateFlow();
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
            ((EdgeData)(edge.UserData)).maxFlow = ((EdgeData)(edge.UserData)).currFlow = cap;
            invalidateFlow();
            edge.LabelText = edge.UserData.ToString();
            redraw();
        }

        private void button_newNode_Click(object sender, System.EventArgs e)
        {
            invalidateFlow();
            graph.AddNode(textBox_newNodeName.Text);
            graph.FindNode(textBox_newNodeName.Text).UserData = new NodeData();
            textBox_newNodeName.Text = "";
            reloadNodesCombobox();
            redraw();
        }
    }
}

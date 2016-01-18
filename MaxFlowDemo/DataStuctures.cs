using Microsoft.Msagl.Drawing;
using System.Collections.Generic;

namespace MaxFlowDemo
{
    public class EdgeData
    {
        public float currFlow = 0;
        public float maxFlow = 0;
        public override string ToString() { return maxFlow-currFlow + "/" + maxFlow; }
    }
    public class NodeData
    {
        public Node TraverseParent;
    }
    public class AlgoState
    {
        //savepoints of FFalgo (for reverting steps)
        public Graph g;
        public List<Edge> p;
    }
}

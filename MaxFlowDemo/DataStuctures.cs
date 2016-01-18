﻿using Microsoft.Msagl.Drawing;

namespace MaxFlowDemo
{
    public class EdgeData
    {
        public float currFlow = 0;
        public float currFlowReverse = 0;
        public float maxFlow = 0;
        public override string ToString() { return currFlow + "&" + currFlowReverse + "/" + maxFlow; }
    }
    public class NodeData
    {
        public Node TraverseParent;
    }
}
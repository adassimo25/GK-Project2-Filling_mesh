
using System;
using System.Collections.Generic;

namespace Project2_Filling_mesh
{
    public class Triangle
    {
        public Vertex A { get; private set; }
        public Vertex B { get; private set; }
        public Vertex C { get; private set; }

        public Triangle(Vertex A, Vertex B, Vertex C)
        {
            this.A = A;
            this.B = B;
            this.C = C;
        }

        public Vertex GetVertexClicked(int eX, int eY)
        {
            if (A.IsClicked(eX, eY))
                return A;
            if (B.IsClicked(eX, eY))
                return B;
            if (C.IsClicked(eX, eY))
                return C;
            return null;
        }

        public List<(Vertex, Vertex)> GetEdges()
        {
            List<(Vertex, Vertex)> edges = new List<(Vertex, Vertex)>();
            edges.Add((A, B));
            edges.Add((B, C));
            edges.Add((C, A));
            return edges;
        }

        public double GetArea()
        {
            return 0.5 * Math.Abs((B.X - A.X) * (C.Y - A.Y) - (B.Y - A.Y) * (C.X - A.X));
        }
    }
}

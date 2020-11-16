
using System;
using System.Drawing;

namespace Project2_Filling_mesh
{
    public class Vertex
    {
        public double X { get; private set; }
        public double Y { get; private set; }

        public Vertex(Vertex vertex)
        {
            X = vertex.X;
            Y = vertex.Y;
        }

        public Vertex(double X, double Y)
        {
            this.X = X;
            this.Y = Y;
        }

        public bool IsClicked(int eX, int eY)
        {
            return Math.Sqrt((float)((eX - X) * (eX - X) + (eY - Y) * (eY - Y))) <= Constants.vertexRadius;
        }

        public void SetLocation(double X, double Y)
        {
            this.X = X;
            this.Y = Y;
        }

        public Point ToPoint()
        {
            return new Point((int)X, (int)Y);
        }
    }
}

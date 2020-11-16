
using System.Drawing;

namespace Project2_Filling_mesh
{
    public static class MyDraw
    {
        public static void Edge(Graphics graphics, Vertex v1, Vertex v2, Pen pen)
        {
            graphics.DrawLine(pen, v1.ToPoint(), v2.ToPoint());
        }

        public static void Triangle(Graphics graphics, Triangle triangle)
        {
            Pen pen = new Pen(Color.Black, Constants.vertexRadius);
            Edge(graphics, triangle.A, triangle.B, pen);
            Edge(graphics, triangle.B, triangle.C, pen);
            Edge(graphics, triangle.C, triangle.A, pen);
        }

        public static void AllTriangles(Graphics graphics, Triangle[,] triangles)
        {
            for (int i = 0; i < triangles.GetLength(0); i++)
                for (int j = 0; j < triangles.GetLength(1); j++)
                    Triangle(graphics, triangles[i, j]);
        }
    }
}

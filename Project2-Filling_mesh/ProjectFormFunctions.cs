
using System;
using System.IO;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project2_Filling_mesh
{
    public partial class ProjectForm : Form
    {
        #region MeshGeneration

        private void GenerateMesh()
        {
            int dFB = Constants.distFromBorder;
            M = (double)(numericUpDownM.Value);
            N = (double)(numericUpDownN.Value);
            dX = (pictureBox.Width - 2 * dFB) / M;
            dY = (pictureBox.Height - 2 * dFB) / N;
            Vertex[,] vertices = new Vertex[(int)N + 1, (int)M + 1];
            CalculateVertices(vertices);
            GenerateTriangles(vertices);
        }

        private void CalculateVertices(Vertex[,] vertices)
        {
            int dFB = Constants.distFromBorder;
            for (int i = 0; i <= N; i++)
                for (int j = 0; j <= M; j++)
                    vertices[i, j] = new Vertex(dFB + (int)(j * dX), dFB + (int)(i * dY));
        }

        private void GenerateTriangles(Vertex[,] vertices)
        {
            triangles = new Triangle[2 * (int)N, (int)M];
            for (int i = 1; i <= N; i++)
                for (int j = 0; j < M; j++)
                {
                    triangles[2 * i - 2, j] = (new Triangle(vertices[i - 1, j], vertices[i - 1, j + 1], vertices[i, j]));
                    triangles[2 * i - 1, j] = (new Triangle(vertices[i, j], vertices[i, j + 1], vertices[i - 1, j + 1]));
                }
        }

        #endregion

        #region VertexMoving

        private Vertex GetVertexClicked(int eX, int eY)
        {
            Vertex vClicked;
            foreach (var triangle in triangles)
            {
                vClicked = triangle.GetVertexClicked(eX, eY);
                if (vClicked != null && !IsVertexExtreme(vClicked))
                    return vClicked;
            }
            return null;
        }

        private bool IsVertexExtreme(Vertex vertex)
        {
            int dFB = Constants.distFromBorder;
            return (vertex.X == dFB || vertex.X == pictureBox.Width - dFB || vertex.Y == dFB || vertex.Y == pictureBox.Height - dFB);
        }

        private void MoveVertex(Vertex vertex, int eX, int eY)
        {
            int dFB = Constants.distFromBorder;
            int pBW = pictureBox.Width - dFB;
            int pBH = pictureBox.Height - dFB;

            if (eX < dFB && eY < dFB)
                vertex.SetLocation(dFB, dFB);
            else if (eX > pBW && eY < dFB)
                vertex.SetLocation(pBW, dFB);
            else if (eX > pBW && eY > pBH)
                vertex.SetLocation(pBW, pBH);
            else if (eX < dFB && eY > pBH)
                vertex.SetLocation(dFB, pBH);
            else if (eX < dFB)
                vertex.SetLocation(dFB, eY);
            else if (eY < dFB)
                vertex.SetLocation(eX, dFB);
            else if (eX > pBW)
                vertex.SetLocation(pBW, eY);
            else if (eY > pBH)
                vertex.SetLocation(eX, pBH);
            else
                vertex.SetLocation(eX, eY);
        }

        #endregion

        #region VectorFuntions

        private Vector3D GetNormalVectorFromColor(Color color)
        {
            double hrgbMV = Constants.rgbMaxValue / 2;
            return new Vector3D((color.R - hrgbMV) / hrgbMV, -(color.G - hrgbMV) / hrgbMV, color.B / Constants.rgbMaxValue);
        }

        private double VersorsDotProduct(Vector3D v1, Vector3D v2)
        {
            return (v1.X * v2.X + v1.Y * v2.Y + v1.Z * v2.Z);
        }

        #endregion

        #region Filling

        private void FillPrecision(List<(Vertex, Vertex)> edges)
        {
            Action<int, int> fillPrecisionAction = delegate (int x, int y)
            {
                workingImage.SetPixel(x, y, GetLambertColor(x, y));
            };
            Fill(edges, fillPrecisionAction);
        }

        private void FillInterpolation(Triangle triangle)
        {
            Vertex[] vertices = { triangle.A, triangle.B, triangle.C };
            Color[] verticesColors = new Color[vertices.Length];
            for (int i = 0; i < vertices.Length; i++)
                verticesColors[i] = GetLambertColor((int)vertices[i].X, (int)vertices[i].Y);
            Action<int, int> fillInterpolationAction = delegate (int x, int y)
            {
                workingImage.SetPixel(x, y, GetInterpolationColor(triangle, verticesColors, x, y));
            };
            Fill(triangle.GetEdges(), fillInterpolationAction);
        }

        private Color GetLambertColor(int x, int y)
        {
            Vector3D normalVersor = nvTexture ? GetNormalVectorFromColor(normalVectorMap.GetPixel(x, y)) : new Vector3D(Constants.constantNormalVersor);
            normalVersor.Normalise();
            Vector3D lightVersor = lvConstant ? new Vector3D(Constants.constantLightVersor) : new Vector3D(lightVector.X - x, lightVector.Y - y, lightVector.Z);
            lightVersor.Normalise();
            Color objectColor = ocTexture ? backgroundImage.GetPixel(x, y) : constObjectColor;

            Vector3D vecR = (2 * VersorsDotProduct(normalVersor, lightVersor)) * normalVersor - lightVersor;
            vecR.Normalise();
            double firFactor = kd * VersorsDotProduct(normalVersor, lightVersor);
            double secFactor = ks * Math.Pow(VersorsDotProduct(Constants.V, vecR), m);
            double R = GetLambertColorComponent(objectColor.R, lightColor.R, firFactor, secFactor);
            double G = GetLambertColorComponent(objectColor.G, lightColor.G, firFactor, secFactor);
            double B = GetLambertColorComponent(objectColor.B, lightColor.B, firFactor, secFactor);
            return Color.FromArgb((int)R, (int)G, (int)B);
        }

        private double GetLambertColorComponent(double objectColor, double lightColor, double firFactor, double secFactor)
        {
            double colorComponent = (firFactor + secFactor) * objectColor * lightColor / Constants.rgbMaxValue;
            if (colorComponent < 0)
                colorComponent = 0;
            if (colorComponent > Constants.rgbMaxValue)
                colorComponent = Constants.rgbMaxValue;
            return colorComponent;
        }

        private Color GetInterpolationColor(Triangle triangle, Color[] verticesColors, int x, int y)
        {
            double triangleArea = triangle.GetArea();
            double aFactor = (new Triangle(new Vertex(x, y), triangle.B, triangle.C)).GetArea() / triangleArea;
            double bFactor = (new Triangle(triangle.A, new Vertex(x, y), triangle.C)).GetArea() / triangleArea;
            double cFactor = (new Triangle(triangle.A, triangle.B, new Vertex(x, y))).GetArea() / triangleArea;

            int R = (int)(aFactor * verticesColors[0].R + bFactor * verticesColors[1].R + cFactor * verticesColors[2].R);
            int G = (int)(aFactor * verticesColors[0].G + bFactor * verticesColors[1].G + cFactor * verticesColors[2].G);
            int B = (int)(aFactor * verticesColors[0].B + bFactor * verticesColors[1].B + cFactor * verticesColors[2].B);
            R = R > 255 ? 255 : R;
            G = G > 255 ? 255 : G;
            B = B > 255 ? 255 : B;

            return Color.FromArgb(R, G, B);
        }

        private void Fill(List<(Vertex, Vertex)> edges, Action<int, int> fillAction)
        {
            List<(double, double, double mf)>[] ET = EdgesBucketSort(edges);
            int edgesCount = edges.Count;
            int y = 0;
            while (ET[y] == null)
                y++;
            List<(double yMax, double xMin, double mf)> AET = new List<(double, double, double)>();

            while (edgesCount != 0 || AET.Count != 0)
            {
                if (ET[y] != null)
                {
                    foreach (var edge in ET[y])
                    {
                        if (edge.mf != double.NaN)
                            AET.Add(edge);
                        edgesCount--;
                    }
                }
                AET.Sort((e1, e2) => e1.xMin.CompareTo(e2.xMin));
                for (int i = 0; i < AET.Count - 1; i++)
                    for (int j = (int)AET[i].xMin; j < AET[i + 1].xMin; j++)
                        fillAction(j, y);
                AET.RemoveAll(x => (x.yMax == y));
                y++;
                for (int i = 0; i < AET.Count; i++)
                    AET[i] = (AET[i].yMax, AET[i].xMin + AET[i].mf, AET[i].mf);
            }
        }

        private List<(double, double, double)>[] EdgesBucketSort(List<(Vertex v1, Vertex v2)> edges)
        {
            List<(double, double, double)>[] sortedEdges = new List<(double, double, double)>[pictureBox.Height];
            foreach (var edge in edges)
            {
                int index = edge.v1.Y < edge.v2.Y ? (int)edge.v1.Y : (int)edge.v2.Y;
                if (sortedEdges[index] == null)
                    sortedEdges[index] = new List<(double, double, double)>();
                double m = 0;
                try
                {
                    m = (edge.v2.X - edge.v1.X) / (edge.v2.Y - edge.v1.Y);
                }
                catch (Exception) { }
                if (edge.v1.Y != edge.v2.Y)
                    sortedEdges[index].Add((Math.Max(edge.v1.Y, edge.v2.Y), edge.v1.Y < edge.v2.Y ? edge.v1.X : edge.v2.X, m));
                else
                    sortedEdges[index].Add((Math.Max(edge.v1.Y, edge.v2.Y), edge.v1.Y < edge.v2.Y ? edge.v1.X : edge.v2.X, double.NaN));
            }
            return sortedEdges;
        }

        #endregion

        #region ImageLoading

        private OpenFileDialog ImagesFileDialog(string title)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Path.Combine(Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).ToString()).ToString(), "images");
            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            openFileDialog.FilterIndex = 1;
            openFileDialog.Title = title;
            openFileDialog.Multiselect = false;
            return openFileDialog;
        }

        #endregion

        #region Redrawing

        private void RedrawTrianglesEdges()
        {
            graphics.Clear(pictureBox.BackColor);
            pictureBox.Image = new Bitmap(workingImage.Bitmap);
            graphics = Graphics.FromImage(pictureBox.Image);
            if (meshVisible.Checked)
                MyDraw.AllTriangles(graphics, triangles);
            pictureBox.Refresh();
        }

        private void RedrawAll()
        {
            graphics.Clear(pictureBox.BackColor);
            workingImageGraphics.DrawImage(backgroundImage.Bitmap, 0, 0, pBWidth, pBHeight);
            Parallel.For(0, triangles.GetLength(0), i =>
            {
                for (int j = 0; j < triangles.GetLength(1); j++)
                {
                    if (fPrecision)
                        FillPrecision(triangles[i, j].GetEdges());
                    else
                        FillInterpolation(triangles[i, j]);
                }
            });
            pictureBox.Image = new Bitmap(workingImage.Bitmap);
            graphics = Graphics.FromImage(pictureBox.Image);
            if (meshVisible.Checked)
                MyDraw.AllTriangles(graphics, triangles);
            pictureBox.Refresh();
        }

        #endregion
    }
}

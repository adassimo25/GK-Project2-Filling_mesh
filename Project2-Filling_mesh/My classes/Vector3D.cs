
using System;

namespace Project2_Filling_mesh
{
    public class Vector3D
    {
        public double X { get; private set; }
        public double Y { get; private set; }
        public double Z { get; private set; }

        public Vector3D(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public Vector3D(Vector3D vector3D)
        {
            X = vector3D.X;
            Y = vector3D.Y;
            Z = vector3D.Z;
        }

        public void Normalise()
        {
            double length = CalculateLength();
            try
            {
                X /= length;
                Y /= length;
                Z /= length;
            }
            catch (Exception) { }
        }

        public double CalculateLength()
        {
            return Math.Sqrt(X * X + Y * Y + Z * Z);
        }

        public static Vector3D operator +(Vector3D v1, Vector3D v2)
        {
            return new Vector3D(v1.X + v2.X, v1.Y + v2.Y, v1.Z + v2.Z);
        }

        public static Vector3D operator -(Vector3D v1, Vector3D v2)
        {
            return new Vector3D(v1.X - v2.X, v1.Y - v2.Y, v1.Z - v2.Z);
        }

        public static Vector3D operator *(double a, Vector3D v)
        {
            return new Vector3D(a * v.X, a * v.Y, a * v.Z);
        }
    }
}

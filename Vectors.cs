using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vector
{
    public class Vector
    {
        public int x;
        public int y;
        public Vector(int _x,int _y)
        {
            x = _x;
            y = _x;
        }
        /// <summary>
        /// Calculates how far are 2 points.
        /// </summary>
        public static double Distance(int _x1,int _x2, int _y1, int _y2)
        {
            return Math.Sqrt(_x1 * _x1 + _x2 * _x2 - 2 * _x1 * _x2 + _y1 * _y1 + _y2 * _y2 - 2 * _y1 * _y2);
        }
        /// <summary>
        /// Calculates Factorial of an integer
        /// </summary>
        public static int Factorial(int F)
        {
            int r = 1;
            if (F == 0) { return 0; }
            for (int i = 1; i < F + 1; i++)
            {
                r *= i;
            }
            return r;
        }
        /// <summary>
        /// Calculates b^(ex)
        /// </summary>
        public static float Power(float b, int ex)
        {
            float r = 1;
            for (int i = 0; i < ex; i++)
            {
                r *= b;
            }
            if(ex<0)
            {
                r = 1 / r;
            }
            return r;
        }
        /// <summary>
        /// Calculates Natural Logarithm
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public float ln(float input)
        {
            float r = 0.00f;
            for (int i = 1; i < 101; i++)
            {
                r += Power(input - 1, i) / Factorial(i);
            }
            return r;
        }
        /// <summary>
        /// returns e^(exp)
        /// </summary>
        /// <param name="exp"></param>
        /// <returns></returns>
        public float EulerNumEx(float exp)
        {
            float r = 0f;
            for (int i = 0; i < 101; i++)
            {
                r += Power(exp, i) / Factorial(i);
            }
            return r;
        }
        /// <summary>
        /// Returns a value between 0,1
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public float Sigmoid(float i)
        {
            float r = EulerNumEx(i);
            r = 1/r;
            return 1 / (1 + r);
        }
        /// <summary>
        /// Returns absolute value of a number
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public float Abolute(float value)
        {
            if (value < 0)
            {
                value *= -1;
            }
            return value;
        }
        /// <summary>
        /// Returns value between -1,1
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public float SoftSign(float value)
        {
            return (value / (1 + Abolute(value)));
        }
        public static class Matrix2D
        {
            /// <summary>
            /// Add two matrices
            /// </summary>
            /// <param name="m1"></param>
            /// <param name="m2"></param>
            /// <returns></returns>
            public static float[,] Add(float[,] m1,float[,] m2)
            {
                if (m1.GetLength(0) != m2.GetLength(0) || m1.GetLength(1) != m2.GetLength(1))
                {
                    throw new System.ArgumentException("Can not add matrices of different sizes");
                }
                float[,] mr = new float[m1.GetLength(0),m1.GetLength(2)];
                for (int i1 = 0; i1 < mr.GetLength(0); i1++)
                {
                    for (int i2 = 0; i2 < mr.GetLength(1); i1++)
                    {
                        mr[i1, i2] = m1[i1, i2] + m2[i1, i2];
                    }
                }
                return mr;
            }
            /// <summary>
            /// Multiplies all elements of matrcies with a constant scalar
            /// </summary>
            /// <param name="scalar"></param>
            /// <param name="matrix"></param>
            /// <returns></returns>
            public static float[,] ScalarMultiplication(float scalar, float[,] matrix)
            {
                for (int i1 = 0; i1 < matrix.GetLength(0); i1++)
                {
                    for (int i2 = 0; i2 < matrix.GetLength(1); i2++)
                    {
                        matrix[i1,i2] *= scalar;
                    }
                }
                return matrix;
            }
        }
    }
}

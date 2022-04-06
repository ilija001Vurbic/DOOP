using System;
using System.Collections.Generic;
using System.Text;

namespace LV3_DOOP
{
    class MatrixGenerator
    {
        private static MatrixGenerator instance;
        private Random randomGenerator;
        private MatrixGenerator()
        {
            this.randomGenerator = new Random();
        }

        public static MatrixGenerator GetInstance()
        {
            if(instance == null)
            {
                return new MatrixGenerator();
            }
            return instance;
        }

        public double[][] GenerateMatrix(int rowCount, int columnCount)
        {
            double[][] matrix = new double[rowCount][];
            for(int i = 0; i < rowCount; i++)
            {
                matrix[i] = new double[columnCount];
            }
            for(int i = 0; i < rowCount; i++)
            {
                for(int j = 0; j < columnCount; j++)
                {
                    matrix[i][j]=randomGenerator.NextDouble();
                }
            }
            return matrix;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOOP_LV4
{
    class Analyzer3rdParty
    {
        public double[] PerRowAverage(double[][] data)
        {
            int rowCount = data.Length;
            double[] results = new double[rowCount];
            for (int i = 0; i < rowCount; i++)
            {
                results[i] = data[i].Average();
            }
            return results;
        }
        public double[] PerColumnAverage(double[][] data)
        {
            int rowCount = data.Length;
            int columnCount = data.First().Length;
            double[] columnAverage = new double[columnCount];
            for(int i = 0; i < columnCount; i++)
            {
                columnAverage[i] = 0;
                for(int j=0;j<rowCount;j++)
                {
                    columnAverage[i] += data[j][i];

                }
                columnAverage[i] /= rowCount;
            }
            return columnAverage;
        }
    }
}

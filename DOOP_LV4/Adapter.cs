using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOOP_LV4
{
    class Adapter : IAnalytics
    {
        private Analyzer3rdParty analyticsService;
        public Adapter(Analyzer3rdParty service)
        {
            this.analyticsService = service;
        }
        private double[][] ConvertData(Dataset dataset)
        {
            IList<List<double>> originalData = dataset.GetData();
            double[][] convertedData = new double[originalData.Count][];
            for(int i = 0; i < originalData.Count; i++)
            {
                convertedData[i] = new double[originalData[i].Count];
                originalData[i].CopyTo(convertedData[i]);
            }
            return convertedData;
        }
        public double[] CalculateAveragePerColumn(Dataset dataset)
        {
            double[][] data = this.ConvertData(dataset);
            return this.analyticsService.PerColumnAverage(data);
        }
        public double[] CalculateAveragePerRow(Dataset dataset)
        {
            double[][] data = this.ConvertData(dataset);
            return this.analyticsService.PerRowAverage(data);
        }
    }
}
